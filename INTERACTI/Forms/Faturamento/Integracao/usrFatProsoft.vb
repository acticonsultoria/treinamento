Imports System.IO
Imports System.IO.File
Imports Microsoft.Office.Interop
Public Class usrFatProsoft

#Region "::: VARIAVEIS :::"

    Private sArquivoNF As StreamWriter
    Private oClsUsrFatProsoft As New clsUsrFatProsoft

#End Region

#Region "::: CONTROLES :::"

    Private Sub frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarForm()

    End Sub

    Private Sub usr_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Top = (frmMain.tabMain.Top + ((frmMain.tabMain.Height - Me.Height) / 2) + gcUserControlAjust)
        Me.Left = ((frmMain.tabMain.Width - Me.Width) / 2)

    End Sub

    Private Sub btnGerarArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerarArquivo.Click

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Gerando o arquivo
            GerarArquivoProsoftNotaFiscal()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default


        Catch ex As Exception

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Informa o Usuário sobre o erro Ocorrido
            frmMain.Informacao(ex.Message, Color.Red)

        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Fecha o Controle
        Me.Dispose()

        Try : frmMain.tabMain.TabPages.Remove(Me.Parent) : Catch ex As Exception : Me.TopLevelControl.Dispose() : End Try

    End Sub

    Private Sub drvArquivo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles drvLocal.SelectedIndexChanged

        Try
            dirLocal.Path = drvLocal.Drive

        Catch ex As Exception

            frmMain.Informacao(ex.Message, Color.Red)

        End Try

    End Sub

    Private Sub dtpDataInicioFiltro_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDataInicioFiltro.ValueChanged

        dtpDataTerminoFiltro.MinDate = dtpDataInicioFiltro.Value

    End Sub

    Private Sub FiltraNotaFiscal() Handles dtpDataInicioFiltro.ValueChanged, dtpDataTerminoFiltro.ValueChanged, cboTipoOperacao.SelectedIndexChanged
        If cboTipoOperacao.SelectedIndex = -1 Then Exit Sub
        If cboTipoOperacao.SelectedValue = TipoDocumentoFiscal.Entrada Then
            grdNotaFiscal.RootTable.Columns.Item("data_emissao").Caption = "Data Entrada"
        ElseIf cboTipoOperacao.SelectedValue = TipoDocumentoFiscal.Saida Then
            grdNotaFiscal.RootTable.Columns.Item("data_emissao").Caption = "Data Emissão"
        End If

        Call LoadNotaFiscal()

    End Sub

    Private Sub btnEnviarEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviarEmail.Click
        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor



            Dim oOutlook As New Microsoft.Office.Interop.Outlook.Application
            Dim oMail As Microsoft.Office.Interop.Outlook.MailItem
            oMail = oOutlook.CreateItem(Outlook.OlItemType.olMailItem)

            With oMail

                'Assunto    
                oMail.Subject = "Arquivo Prosoft - " & goUsuario.sSiglaEmpresa & "_" & Format(dtpDataInicioFiltro.Value, "yyyyMMdd") & "_" & Format(dtpDataTerminoFiltro.Value, "yyyyMMdd")

                'Gerando o arquivo
                cboTipoOperacao.SelectedValue = 1 'Selecionando as saídas
                grdNotaFiscal.CheckAllRecords()
                GerarArquivoProsoftNotaFiscal()

                'Definindo o caminho do arquivo para as saídas
                Dim sCaminho As String = dirLocal.Path & "\" & goUsuario.sSiglaEmpresa & "_SAIDA" & "_CAPA_" & Format(dtpDataInicioFiltro.Value, "yyyyMMdd") & "_" & Format(dtpDataTerminoFiltro.Value, "yyyyMMdd") & ".txt"
                oMail.Attachments.Add(sCaminho)
                oMail.Attachments.Add(sCaminho.Replace("CAPA", "ITENS"))

                'Gerando o arquivo
                cboTipoOperacao.SelectedValue = 0 'Selecionando as saídas
                grdNotaFiscal.CheckAllRecords()
                GerarArquivoProsoftNotaFiscal()

                'Agora atachando as entradas
                sCaminho = sCaminho.Replace("SAIDA", "ENTRADA")
                oMail.Attachments.Add(sCaminho)
                oMail.Attachments.Add(sCaminho.Replace("CAPA", "ITENS"))

                'Exibindo o email
                oMail.Display()


                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default
            End With
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarForm()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Data
            dtpDataInicioFiltro.Value = Format(DateAdd(DateInterval.Day, (Now.Day - 1) * -1, Now.Date), "dd/MM/yyyy")
            dtpDataTerminoFiltro.Value = Format(Now.Date, "dd/MM/yyyy")

            'Carrega Combo - Tipo de Operacao
            Call LoadCombo(cboTipoOperacao, "sp_select_combo_static_tipo_documento_fiscal")
            cboTipoOperacao.SelectedIndex = 0

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Informa o Usuário sobre o Erro Ocorrido
            frmMain.Informacao(ex.Message, Color.Red)

        End Try

    End Sub


    Private Sub LoadNotaFiscal()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            If cboTipoOperacao.SelectedIndex = -1 Then
                oClsUsrFatProsoft.LoadGridNF(grdNotaFiscal, _
                                                    CDate("01/01/1970"), _
                                                    CDate("01/01/1970"), _
                                                    1)
            Else

                'Carrega Grid
                oClsUsrFatProsoft.LoadGridNF(grdNotaFiscal, _
                                                   Format(dtpDataInicioFiltro.Value, "dd/MM/yyyy"), _
                                                   Format(dtpDataTerminoFiltro.Value, "dd/MM/yyyy"), _
                                                   cboTipoOperacao.SelectedValue)
            End If
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Informa o Usuário sobre o Erro Ocorrido
            frmMain.Informacao(ex.Message, Color.Red)

        End Try

    End Sub

    Private Sub GerarArquivoProsoftNotaFiscal()

        Try

            Dim lCodigo() As Long
            Dim iCont As Integer = 0

            'Validando
            If Validacao() = False Then Exit Sub

            'Seta Parametros
            oClsUsrFatProsoft.DataInicio = Format(dtpDataInicioFiltro.Value, "dd/MM/yyyy")
            oClsUsrFatProsoft.DataTermino = Format(dtpDataTerminoFiltro.Value, "dd/MM/yyyy")

            'Redimensionando
            ReDim lCodigo(grdNotaFiscal.RowCount - 1)

            'Atribuindo os códigos 
            For Each oRow As Janus.Windows.GridEX.GridEXRow In grdNotaFiscal.GetCheckedRows
                lCodigo(iCont) = oRow.Cells.Item("codigo").Value
                iCont += 1
            Next

            'Itens
            If cboTipoOperacao.SelectedValue = TipoDocumentoFiscal.Saida Then 'Exportando a saída

                'Caminho do arquivo
                sArquivoNF = New StreamWriter(dirLocal.Path & "\" & goUsuario.sSiglaEmpresa & "_" & "SAIDA_CAPA_" & Format(dtpDataInicioFiltro.Value, "yyyyMMdd") & "_" & Format(dtpDataTerminoFiltro.Value, "yyyyMMdd") & ".txt")
                'Passagem do parâmetro
                oClsUsrFatProsoft.ArquivoNF = sArquivoNF
                'Exportando o arquivo
                oClsUsrFatProsoft.GerarArquivoProsoft(lCodigo, 1, cboTipoOperacao.SelectedValue)
                'Fecha o Arquivo
                sArquivoNF.Close()

                'Caminho do arquivo
                sArquivoNF = New StreamWriter(dirLocal.Path & "\" & goUsuario.sSiglaEmpresa & "_" & "SAIDA_ITENS_" & Format(dtpDataInicioFiltro.Value, "yyyyMMdd") & "_" & Format(dtpDataTerminoFiltro.Value, "yyyyMMdd") & ".txt")
                'Passagem do parâmetro
                oClsUsrFatProsoft.ArquivoNF = sArquivoNF
                'Exportando o arquivo
                oClsUsrFatProsoft.GerarArquivoProsoft(lCodigo, 0, cboTipoOperacao.SelectedValue)
                'Fecha o Arquivo
                sArquivoNF.Close()

                ''Caminho do arquivo
                'sArquivoNF = New StreamWriter(dirLocal.Path & "\SAIDA_SERVICOS_PRESTADOS_" & Format(dtpDataInicioFiltro.Value, "yyyyMMdd") & "_" & Format(dtpDataTerminoFiltro.Value, "yyyyMMdd") & ".txt")
                ''Passagem do parâmetro
                'oClsUsrFatProsoft.ArquivoNF = sArquivoNF
                ''Exportando o arquivo
                'oClsUsrFatProsoft.GerarArquivoProsoft(lCodigo, 0, cboTipoOperacao.SelectedValue)
                ''Fecha o Arquivo
                'sArquivoNF.Close()


            Else 'Exportando a entrada

                'Caminho do arquivo
                sArquivoNF = New StreamWriter(dirLocal.Path & "\" & goUsuario.sSiglaEmpresa & "_" & "ENTRADA_CAPA_" & Format(dtpDataInicioFiltro.Value, "yyyyMMdd") & "_" & Format(dtpDataTerminoFiltro.Value, "yyyyMMdd") & ".txt")
                'Passagem do parâmetro
                oClsUsrFatProsoft.ArquivoNF = sArquivoNF
                'Exportando o arquivo
                oClsUsrFatProsoft.GerarArquivoProsoft(lCodigo, 1, cboTipoOperacao.SelectedValue)
                'Fecha o Arquivo
                sArquivoNF.Close()

                'Caminho do arquivo
                sArquivoNF = New StreamWriter(dirLocal.Path & "\" & goUsuario.sSiglaEmpresa & "_" & "ENTRADA_ITENS_" & Format(dtpDataInicioFiltro.Value, "yyyyMMdd") & "_" & Format(dtpDataTerminoFiltro.Value, "yyyyMMdd") & ".txt")
                'Passagem do parâmetro
                oClsUsrFatProsoft.ArquivoNF = sArquivoNF
                'Exportando o arquivo
                oClsUsrFatProsoft.GerarArquivoProsoft(lCodigo, 0, cboTipoOperacao.SelectedValue)
                'Fecha o Arquivo
                sArquivoNF.Close()

                ''Caminho do arquivo
                'sArquivoNF = New StreamWriter(dirLocal.Path & "\ENTRADA_SERVICOS_TOMADOS_" & Format(dtpDataInicioFiltro.Value, "yyyyMMdd") & "_" & Format(dtpDataTerminoFiltro.Value, "yyyyMMdd") & ".txt")
                ''Passagem do parâmetro
                'oClsUsrFatProsoft.ArquivoNF = sArquivoNF
                ''Exportando o arquivo
                'oClsUsrFatProsoft.GerarArquivoProsoft(lCodigo, 2, cboTipoOperacao.SelectedValue)
                ''Fecha o Arquivo
                'sArquivoNF.Close()
            End If

            'Informa o Usuário do Sucesso da Operação
            frmMain.Informacao("Arquivo Gerado com Sucesso!!!", Color.Blue)


        Catch ex As Exception
            sArquivoNF.Close()
            Throw ex

        End Try

    End Sub


    Private Function Validacao() As Boolean

        Try

            Validacao = False

            If ValidaCampo(cboTipoOperacao, lblTipoOperacao) = False Then
                Exit Function
            End If

        

            If VerificaSelecaoRow(grdNotaFiscal) = False Then
                frmMain.Informacao("Selecione ao menos uma Nota Fiscal!", Color.Red)
                Exit Function
            End If

            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function


#End Region


   
End Class