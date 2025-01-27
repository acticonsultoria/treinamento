Imports System.IO
Imports INTERACTI.SQLHelper
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine

Public Class usrIntImportacaoSintegra

#Region "::: VÁRIAVEIS :::"

    Private oClsSinImportArquivo As New clsUsrIntImportacaoSintegra

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrSinImportArquivo_Load(sender As Object, e As EventArgs) Handles Me.Load

        'COnfigura Formulário
        Call ConfigureUserControl()

    End Sub

    Private Sub btnOpenArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenArquivo.Click

        Try

            'Váriaveis Locais
            Dim oArquivo As New OpenFileDialog

            'Abre PopUp para Usuário selecionar Imagem
            oArquivo.InitialDirectory = "c:\\dados"
            oArquivo.Filter = "(Arquivo do Sintegra TXT)|*.TXT"
            oArquivo.Title = "Selecione o Arquivo"

            If oArquivo.ShowDialog = DialogResult.OK Then
                txtArquivo.Text = oArquivo.FileName
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        'Carrega Grid
        Call LoadGrid()

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Deleta Aba
        frmMain.tabMain.TabPages.Remove(Me.Parent)
        'Fecha o Controle
        Me.Dispose()

    End Sub

    Private Sub btnImportarArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportarArquivo.Click

        'Limpa Erro
        frmMain.errInfo.Clear()

        'Valida Arquivo
        If Validacao() = True Then

            'Importa Arquivo
            Call ImportarArquivo()

        End If


        Call oClsSinImportArquivo.LoadArquivoImportado(grdArquivo)


    End Sub

    Private Sub btnLimparRegistros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimparRegistros.Click
        Try
            If MsgBox("Deseja limpar toda a importação do sintegra?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "LImpando importação") = MsgBoxResult.Yes Then
                oClsSinImportArquivo.LimparImportacao()
                oClsSinImportArquivo.LoadArquivoImportado(grdArquivo)
            End If
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnDiretorio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiretorio.Click
        Try

            'Váriaveis Locais
            Dim oArquivo As New System.Windows.Forms.FolderBrowserDialog
            frmMain.errInfo.Clear()

            If ValidaCampo(cboEmpresa, lblEmpresa) = False Then Exit Sub

            If oArquivo.ShowDialog = DialogResult.OK Then

                For Each oFile As String In System.IO.Directory.GetFiles(oArquivo.SelectedPath)
                    txtArquivo.Text = oFile
                    Application.DoEvents()
                    ImportarArquivo()

                Next
            End If



            Call oClsSinImportArquivo.LoadArquivoImportado(grdArquivo)




        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub usr_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Redimensiona Usercontrol
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub
#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigureUserControl()

        Try

            'Seta Cursor
            Cursor.Current = Cursors.WaitCursor

            'Carregando os dados da empresa
            Call LoadDadosEmitente()

            'Limpando os dados da empresa
            cboEmpresa.Items.Clear()
            cboEmpresaFiltro.Items.Clear()


            'Adicionado a única empresa
            cboEmpresa.Items.Add(goEmitente.sNomeFantasia, 1)
            cboEmpresaFiltro.Items.Add(goEmitente.sNomeFantasia, 1)

            'Setando o valor inicial
            cboEmpresa.SelectedIndex = 0
            cboEmpresaFiltro.SelectedIndex = 0

            'Carrega Arquivo Importado
            Call oClsSinImportArquivo.LoadArquivoImportado(grdArquivo)

            'grdArquivo.RootTable.Columns("arquivo").Width = 400

            'Setando o check box
            dtpDataInicio.Checked = False
            dtpDataTermino.Checked = False

            'Seta Cursor
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            frmMain.errInfo.Clear()

            If ValidaCampo(cboEmpresaFiltro, lblEmpresaFiltro) = False Then Exit Sub

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid - Registro 50
            Call oClsSinImportArquivo.LoadRegistro50(grdRegistro50, _
                                                     "", _
                                                     IIf(dtpDataInicio.Checked = True, dtpDataInicio.Value, ""), _
                                                     IIf(dtpDataTermino.Checked = True, dtpDataTermino.Value, ""), _
                                                     "", _
                                                     cboEmpresaFiltro.SelectedValue)

            'Carrega Grid - Registro 50
            Call oClsSinImportArquivo.LoadRegistro70(grdRegistro70, _
                                                     "", _
                                                     IIf(dtpDataInicio.Checked = True, dtpDataInicio.Value, ""), _
                                                     IIf(dtpDataTermino.Checked = True, dtpDataTermino.Value, ""), _
                                                     "", _
                                                     cboEmpresaFiltro.SelectedValue)

            'Carrega Grid - Registro 51
            Call oClsSinImportArquivo.LoadRegistro51(grdRegistro51, _
                                                     "", _
                                                     IIf(dtpDataInicio.Checked = True, dtpDataInicio.Value, ""), _
                                                     IIf(dtpDataTermino.Checked = True, dtpDataTermino.Value, ""), _
                                                     "", _
                                                     cboEmpresaFiltro.SelectedValue)

            'Carrega Grid - Registro 54
            Call oClsSinImportArquivo.LoadRegistro54(grdRegistro54, _
                                                     "", _
                                                     IIf(dtpDataInicio.Checked = True, dtpDataInicio.Value, ""), _
                                                     IIf(dtpDataTermino.Checked = True, dtpDataTermino.Value, ""), _
                                                     "", _
                                                     cboEmpresaFiltro.SelectedValue)

            'Carrega Grid - Registro 74
            Call oClsSinImportArquivo.LoadRegistro74(grdRegistro74, _
                                                     "", _
                                                     IIf(dtpDataInicio.Checked = True, dtpDataInicio.Value, ""), _
                                                     IIf(dtpDataTermino.Checked = True, dtpDataTermino.Value, ""), _
                                                     cboEmpresaFiltro.SelectedValue)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Selecionado o Campo - Arquivo
            If ValidaCampo(txtArquivo, lblArquivo, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Arquivo
            If ValidaCampo(cboEmpresa, lblEmpresa) = False Then
                Exit Function
            End If

            'Verifica se o Arquivo ja foi Importado
            If VerificaExisteValorGrid(grdArquivo, "arquivo", txtArquivo.Text.Trim) = True Then
                MsgBox("Este Arquivo ja foi importado!", MsgBoxStyle.Exclamation, Me.Parent.Text)

                Exit Function
            End If


            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Function

    Private Sub ImportarArquivo()

        Try

            'Váriaveis Locais
            Dim oStreamReader As New StreamReader(txtArquivo.Text)
            Dim sLinha As String

            'Seta Cursor
            Cursor.Current = Cursors.WaitCursor

            'Recebendo a quantidade de linhas
            Dim re As New System.Text.RegularExpressions.Regex("\r\n")
            Dim sr As New System.IO.StreamReader(txtArquivo.Text)
            Dim txt As String = sr.ReadToEnd()
            sr.Close()

            'Setando o valor máximo
            pgrBar.Maximum = re.Matches(txt).Count + 1

            'Valor inicial
            pgrBar.Value = 0

            'Insere Arquivo
            Call oClsSinImportArquivo.InsertArquivoImportado(txtArquivo.Text.Trim, cboEmpresa.SelectedValue)

            Do


                'Lendo a linha
                sLinha = oStreamReader.ReadLine

                Select Case Mid(sLinha, 1, 2)

                    Case "50" : Call oClsSinImportArquivo.InsertRegistro50(sLinha, txtArquivo.Text.Trim, cboEmpresa.SelectedValue)
                    Case "51" : Call oClsSinImportArquivo.InsertRegistro51(sLinha, txtArquivo.Text.Trim, cboEmpresa.SelectedValue)
                    Case "54" : Call oClsSinImportArquivo.InsertRegistro54(sLinha, txtArquivo.Text.Trim, cboEmpresa.SelectedValue)
                    Case "70" : Call oClsSinImportArquivo.InsertRegistro70(sLinha, txtArquivo.Text.Trim, cboEmpresa.SelectedValue)
                    Case "74" : Call oClsSinImportArquivo.InsertRegistro74(sLinha, txtArquivo.Text.Trim, cboEmpresa.SelectedValue)
                    Case "75" : Call oClsSinImportArquivo.InsertRegistro75(sLinha, txtArquivo.Text.Trim, cboEmpresa.SelectedValue)

                End Select

                'Incrementando
                pgrBar.Value += 1
                Application.DoEvents()


            Loop Until sLinha Is Nothing

            'Atualizando os itens 
            oClsSinImportArquivo.UpdateInformacao()

            MsgBox("Arquivo importado com sucesso!", MsgBoxStyle.Information)

            'Limpa Váriavel
            oStreamReader.Close()


            'Limpa Arquivo
            txtArquivo.Text = ""

            'Seta Cursor
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub

#End Region

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try
            Imprimir()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Public Sub Imprimir()
        Dim oRptDocument As New ReportDocument
        Dim sCodigoEmissaoCapa As String = ""
        Try

            Dim oSqlDataReader As SqlDataReader
            Dim sCaminho As String = "D:\Projetos\24_Fiscalizacao_DrawBack\nf impressa\2010\Entrada\"


            'Executa Query 
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_notas_imprimir_entrada")

            pgrBar.Maximum = oSqlDataReader.RecordsAffected + 1
            pgrBar.Value = 0
            While oSqlDataReader.Read

                sCodigoEmissaoCapa &= "," & oSqlDataReader.Item("codigo_entrada_capa")

                If System.IO.File.Exists(sCaminho & oSqlDataReader.Item("nota_fiscal") & "_" & Replace(oSqlDataReader.Item("razao_social"), ".", "") & ".pdf") = True Then
                    Continue While
                End If

                'Abre Relatório
                oRptDocument.Load("D:\Projetos\24_Fiscalizacao_DrawBack\FONTES\INTERACTI\bin\Debug\Reports\rptFaturamentoDANFE_ENTRADA.rpt", _
                                  CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)

                'Seta Parametros Relatório
                oRptDocument.SetParameterValue("@codigo_entrada_capa", oSqlDataReader.Item("codigo_entrada_capa"))
                oRptDocument.SetParameterValue("@codigo_empresa", goUsuario.iEmpresa)

                'Abre Conexão com o Banco de Dados
                For i = 0 To oRptDocument.DataSourceConnections.Count - 1
                    oRptDocument.DataSourceConnections.Item(i).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)
                Next

                'Exporta para Arquivo PDF
                oRptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, sCaminho & oSqlDataReader.Item("nota_fiscal") & "_" & Replace(oSqlDataReader.Item("razao_social"), ".", "") & ".pdf")

                'Limpa Váriavel
                oRptDocument.Close()





            End While

            'Fechando
            oSqlDataReader.Close()
        Catch SqlEx As SqlException
            Throw SqlEx
            'Limpa Váriavel
            oRptDocument.Close()

        Catch ex As Exception
            Throw ex
            'Limpa Váriavel
            oRptDocument.Close()

        End Try

    End Sub

    Public Sub Trocar()
        Dim oRptDocument As New ReportDocument
        Dim sCodigoEmissaoCapa As String = ""
        Try

            Dim oSqlDataReader As SqlDataReader



            'Executa Query 
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_notas_imprimir_entrada_tipo")

            pgrBar.Maximum = oSqlDataReader.RecordsAffected + 1
            pgrBar.Value = 0
            While oSqlDataReader.Read

                sCodigoEmissaoCapa &= "," & oSqlDataReader.Item("codigo_emissao_capa")

                Dim sCaminho As String = "D:\Projetos\24_Fiscalizacao_DrawBack\nf impressa\2008\" & oSqlDataReader.Item("nota_fiscal") & "_" & Replace(oSqlDataReader.Item("razao_social"), ".", "") & ".pdf"
                Dim sNovo As String = Replace(sCaminho, "nf impressa\2008\", "nf impressa\2008\exportação\")

                System.IO.File.Move(sCaminho, sNovo)

                pgrBar.Value += 1
                Application.DoEvents()



            End While

            'Fechando
            oSqlDataReader.Close()
        Catch SqlEx As SqlException
            Throw SqlEx
            'Limpa Váriavel
            oRptDocument.Close()

        Catch ex As Exception
            Throw ex
            'Limpa Váriavel
            oRptDocument.Close()

        End Try

    End Sub

    Private Sub btnTrocar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrocar.Click
        Try
            Trocar()
        Catch ex As Exception
            MsgBox(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
End Class
