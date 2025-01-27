Imports System.IO
Imports System.IO.File

Public Class usrIntProsoft

#Region "::: VARIAVEIS :::"

    Private sArquivoNF As StreamWriter
    Private oClsUsrIntProsoft As New clsUsrIntProsoft

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrIntProsoft_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                    
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrIntProsoft_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrIntProsoft_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona User Control
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdNotaFiscal
            oForm.NomeFormulario = Formulario.IntegracaoProsoft
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdNotaFiscal, Formulario.IntegracaoProsoft)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Carrega Grid
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnGerarArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerarArquivo.Click

        Try

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Váriavel Local
                Dim sPath As String = ""
                Dim oFolder As New FolderBrowserDialog

                'Verifica se foi Selecionado algum Arquivo
                If oFolder.ShowDialog = DialogResult.OK Then
                    sPath = oFolder.SelectedPath
                End If

                'Desabilita FolderDialog
                oFolder.Dispose()

                'Gera Arquivo do Prosoft
                If sPath <> "" Then
                    Call GerarArquivoProsoft(sPath)
                End If

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnEnviarEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviarEmail.Click

        Try

            'Váriaveis Locais
            Dim sPath As String = ""
            Dim oFolder As New FolderBrowserDialog

            'Verifica se foi Selecionado algum Arquivo
            If oFolder.ShowDialog = DialogResult.OK Then
                sPath = oFolder.SelectedPath
            End If

            'Desabilita FolderDialog
            oFolder.Dispose()

            'Gera Arquivo do Prosoft
            If sPath <> "" Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Gera Arquivo - Prosoft
                Call GerarArquivoProsoft(sPath)

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

                'Enviar E-mail
                Call EnviarEmail("Arquivo Prosoft - " & goUsuario.sSiglaEmpresa & "_" & Format(dtpDataEmissaoInicioFiltro.Value, "yyyyMMdd") & "_" & Format(dtpDataEmissaoTerminoFiltro.Value, "yyyyMMdd"), _
                                 "", _
                                 sPath, _
                                 sPath, _
                                 "", _
                                 -1)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Deleta Aba
            If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    'Private Sub dtpDataInicioFiltro_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDataEmissaoInicioFiltro.ValueChanged

    '    Try

    '        'Seta MinDate
    '        dtpDataEmissaoTerminoFiltro.MinDate = dtpDataEmissaoInicioFiltro.Value

    '    Catch ex As Exception
    '        'Trata Erro
    '        Call TratamentoErro(ex.Message, Me.Parent.Text)
    '    End Try

    'End Sub

    Private Sub grdNotaFiscal_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdNotaFiscal.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdNotaFiscal, _
                                     Formulario.IntegracaoProsoft)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdNotaFiscal_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdNotaFiscal.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdNotaFiscal.Name, _
                                     Formulario.IntegracaoProsoft, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrIntProsoft_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Data
            dtpDataEmissaoInicioFiltro.Value = Format(DateAdd(DateInterval.Day, (Now.Day - 1) * -1, Now.Date), "dd/MM/yyyy")
            dtpDataEmissaoTerminoFiltro.Value = Format(Now.Date, "dd/MM/yyyy")

            'Verifica Direito
            btnGerarArquivo.Enabled = VerificaDireito(Formulario.IntegracaoProsoft, gcInsert)
            btnEnviarEmail.Enabled = VerificaDireito(Formulario.IntegracaoProsoft, gcInsert)

            'Configura Grid
            Call ConfiguraGrid(grdNotaFiscal, Formulario.IntegracaoProsoft)

            'Carrega Combo - Tipo de Operacao
            Call LoadCombo(cboTipoOperacao, "sp_select_combo_static_tipo_documento_fiscal " & goUsuario.iPerfil & ", " & goUsuario.iEmpresa)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid
            oClsUsrIntProsoft.LoadGrid(grdNotaFiscal, _
                                       Format(dtpDataEmissaoInicioFiltro.Value, "dd/MM/yyyy"), _
                                       Format(dtpDataEmissaoTerminoFiltro.Value, "dd/MM/yyyy"), _
                                       cboTipoOperacao.SelectedValue)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default
            
        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub GerarArquivoProsoft(ByVal sPath As String)

        Try

            'Váriaveis Locais
            Dim lCodigo() As Long
            Dim iCont As Integer = 0
            Dim sRetorno As String = ""

            'Seta Parametros
            oClsUsrIntProsoft.DataInicio = Format(dtpDataEmissaoInicioFiltro.Value, "dd/MM/yyyy")
            oClsUsrIntProsoft.DataTermino = Format(dtpDataEmissaoTerminoFiltro.Value, "dd/MM/yyyy")

            'Redimensionando
            ReDim lCodigo(grdNotaFiscal.RowCount - 1)

            'Atribuindo os códigos 
            For Each oRow As Janus.Windows.GridEX.GridEXRow In grdNotaFiscal.GetCheckedRows
                lCodigo(iCont) = oRow.Cells.Item("codigo").Value
                iCont += 1
            Next

            'Verifica o Tipo de Operação
            Select cboTipoOperacao.SelectedValue

                Case CInt(TipoDocumentoFiscal.Saida)

                    'ARQUIVO - CAPA
                    sArquivoNF = New StreamWriter(sPath & "\" & goUsuario.sSiglaEmpresa & "_" & "SAIDA_CAPA_" & Format(dtpDataEmissaoInicioFiltro.Value, "yyyyMMdd") & "_" & Format(dtpDataEmissaoTerminoFiltro.Value, "yyyyMMdd") & ".txt")
                    oClsUsrIntProsoft.ArquivoNF = sArquivoNF
                    sRetorno = oClsUsrIntProsoft.GerarArquivoProsoft(lCodigo, 1, cboTipoOperacao.SelectedValue)
                    sArquivoNF.Close()

                    'ARQUIVO - ITEM
                    sArquivoNF = New StreamWriter(sPath & "\" & goUsuario.sSiglaEmpresa & "_" & "SAIDA_ITENS_" & Format(dtpDataEmissaoInicioFiltro.Value, "yyyyMMdd") & "_" & Format(dtpDataEmissaoTerminoFiltro.Value, "yyyyMMdd") & ".txt")
                    oClsUsrIntProsoft.ArquivoNF = sArquivoNF
                    sRetorno = oClsUsrIntProsoft.GerarArquivoProsoft(lCodigo, 0, cboTipoOperacao.SelectedValue)
                    sArquivoNF.Close()

                    Try

                   

                    'ARQUIVO - PARCEIRO
                    sArquivoNF = New StreamWriter(sPath & "\" & goUsuario.sSiglaEmpresa & "_" & "SAIDA_CADASTRO_PARCEIRO_" & Format(dtpDataEmissaoInicioFiltro.Value, "yyyyMMdd") & "_" & Format(dtpDataEmissaoTerminoFiltro.Value, "yyyyMMdd") & ".txt")
                    oClsUsrIntProsoft.ArquivoNF = sArquivoNF
                    sRetorno = oClsUsrIntProsoft.GerarArquivoProsoft(lCodigo, 3, cboTipoOperacao.SelectedValue)
                        sArquivoNF.Close()

                    Catch ex As Exception

                    End Try

                Case CInt(TipoDocumentoFiscal.Entrada)

                    'ARQUIVO - CAPA
                    sArquivoNF = New StreamWriter(sPath & "\" & goUsuario.sSiglaEmpresa & "_" & "ENTRADA_CAPA_" & Format(dtpDataEmissaoInicioFiltro.Value, "yyyyMMdd") & "_" & Format(dtpDataEmissaoTerminoFiltro.Value, "yyyyMMdd") & ".txt")
                    oClsUsrIntProsoft.ArquivoNF = sArquivoNF
                    sRetorno = oClsUsrIntProsoft.GerarArquivoProsoft(lCodigo, 1, cboTipoOperacao.SelectedValue)
                    sArquivoNF.Close()

                    'ARQUIVO - ITEM
                    sArquivoNF = New StreamWriter(sPath & "\" & goUsuario.sSiglaEmpresa & "_" & "ENTRADA_ITENS_" & Format(dtpDataEmissaoInicioFiltro.Value, "yyyyMMdd") & "_" & Format(dtpDataEmissaoTerminoFiltro.Value, "yyyyMMdd") & ".txt")
                    oClsUsrIntProsoft.ArquivoNF = sArquivoNF
                    sRetorno = oClsUsrIntProsoft.GerarArquivoProsoft(lCodigo, 0, cboTipoOperacao.SelectedValue)
                    sArquivoNF.Close()


                    Try

                    
                    'ARQUIVO - PARCEIRO
                    sArquivoNF = New StreamWriter(sPath & "\" & goUsuario.sSiglaEmpresa & "_" & "ENTRADA_CADASTRO_PARCEIRO_" & Format(dtpDataEmissaoInicioFiltro.Value, "yyyyMMdd") & "_" & Format(dtpDataEmissaoTerminoFiltro.Value, "yyyyMMdd") & ".txt")
                    oClsUsrIntProsoft.ArquivoNF = sArquivoNF
                    sRetorno = oClsUsrIntProsoft.GerarArquivoProsoft(lCodigo, 3, cboTipoOperacao.SelectedValue)
                    sArquivoNF.Close()


                    Catch ex As Exception

                    End Try

            End Select

            'Verifica se ocorreu algum Problema
            If sRetorno <> "" Then

                'Váriavel - Erro
                Dim sErro As String = "NF's não exportadas:" & vbNewLine

                'Tirando o último pipe
                sRetorno = Mid(sRetorno, 1, Len(sRetorno) - 1)

                'Recebendo os codigos não gerados
                Dim sCodigos() As String = sRetorno.Split("|")

                For i As Integer = 0 To UBound(sCodigos)
                    For Each oRow In grdNotaFiscal.GetCheckedRows
                        If sCodigos(i) = oRow.Cells.Item("codigo").Value Then
                            sErro += CStr(oRow.Cells.Item("nota_fiscal").Value) + " - " + oRow.Cells.Item("parceiro").Value + vbNewLine
                        End If
                    Next
                Next

                'Informa o Erro
                MsgBox(sErro)

            End If

            'Informa o Usuário do Sucesso da Operação
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

        Catch ex As Exception
            sArquivoNF.Close()
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            ''Verifica se foi Selecionado o Campo - Tipo de Operação
            'If ValidaCampo(cboTipoOperacao, lblTipoOperacao) = False Then
            '    Exit Function
            'End If

            'Verifica se foi Selecionado alguma Nota Fiscal
            If VerificaSelecaoRow(grdNotaFiscal) = False Then
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class