Imports System.IO
Imports System.IO.File
Imports BoletoNet
Imports Janus.Windows.GridEX
Imports Microsoft.Office.Interop

Public Class usrIntConciliacaoBancaria

#Region "::: VARIAVEIS :::"

    Private sArquivoNF As StreamWriter
    Private oClsIntegracaoBoleto As New clsUsrIntConciliacaoBancaria

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Property oClsCadGrupoConsultora As Object

    Private Sub usrIntConciliacaoBancaria_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call btnFiltrarRemessa_Click(btnFiltrarRemessa, System.EventArgs.Empty) Else Control_Enter(sender)
                        
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrIntConciliacaoBancaria_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: REMESSA :::"

    Private Sub btnAgruparGridRemessa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridRemessa.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdRemessa.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdRemessa.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdRemessa.GroupByBoxVisible = True
                grdRemessa.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridRemessa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridRemessa.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdRemessa
            oForm.NomeFormulario = Formulario.IntegracaoBoletoBancario
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdRemessa, Formulario.IntegracaoBoletoBancario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridRemessa_Click(sender As Object, e As EventArgs) Handles btnExcelGridRemessa.Click

        Try

            'Exporta para Excel
            Call ExportExcel(grdRemessa)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrarRemessa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrarRemessa.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Carrega Grid
            Call LoadGridRemessa()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnGerarArquivoRemessa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerarArquivoRemessa.Click

        Try

            'Gera Arquivo
            GerarArquivoRemessa()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSairRemessa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSairRemessa.Click

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

    Private Sub dtpDataEmissaoRemessaInicioFiltro_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDataEmissaoRemessaInicioFiltro.ValueChanged, dtpDataEmissaoRemessaInicioFiltro.ValueChanged

        Try

            'Seta MinDate
            dtpDataEmissaoRemessaTerminoFiltro.MinDate = dtpDataEmissaoRemessaInicioFiltro.Value

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdRemessa_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdRemessa.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdRemessa, _
                                     Formulario.IntegracaoBoletoBancario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdRemessa_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdRemessa.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdRemessa.Name, _
                                     Formulario.IntegracaoBoletoBancario, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdRemessa_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdRemessa.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdRemessa.Name, _
                                          Formulario.IntegracaoBoletoBancario, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdRemessa_RowCheckStateChanged(sender As Object, e As RowCheckStateChangeEventArgs) Handles grdRemessa.RowCheckStateChanged

        Try

            'Atualiza Grid
            grdRemessa.Refresh()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: RETORNO :::"

    Private Sub btnImportarRetorno_Click(sender As Object, e As EventArgs) Handles btnImportarRetorno.Click

        Try

            'Importa Arquivo
            Call ImportarArquivoRetorno()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovoRetorno_Click(sender As Object, e As EventArgs) Handles btnNovoRetorno.Click

        Try

            'Limpa Formulário
            Call NovoRetorno()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridRetorno_Click(sender As Object, e As EventArgs) Handles btnExcelGridRetorno.Click

        Try

            'Exporta para Excel
            Call ExportExcel(grdRetorno)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSairRetorno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSairRetorno.Click

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

    Private Sub btnSalvarRetorno_Click(sender As Object, e As EventArgs) Handles btnSalvarRetorno.Click

        Try

            'Salva Retorno
            Call SalvarPagamentoRetorno()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdRetorno_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdRetorno.RowDoubleClick
        Try

            Vincular()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try
            Call Imprimir()
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
    
#End Region

#Region "::: PAGAMENTO :::"

    Private Sub btnAgruparGridPagamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridPagamento.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdPagamento.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdPagamento.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdPagamento.GroupByBoxVisible = True
                grdPagamento.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridPagamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridPagamento.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdPagamento
            oForm.NomeFormulario = Formulario.IntegracaoBoletoBancario
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdPagamento, Formulario.IntegracaoBoletoBancario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridPagamento_Click(sender As Object, e As EventArgs) Handles btnExcelGridPagamento.Click

        Try

            'Exporta para Excel
            Call ExportExcel(grdPagamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnGerarArquivoPagamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerarArquivoPagamento.Click

        Try

            'Gera Arquivo
            GerarArquivoPagamento()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    'Private Sub dtpDataEmissaoPagamentoInicioFiltro_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDataEmissaoPagamentoInicioFiltro.ValueChanged, dtpDataEmissaoPagamentoInicioFiltro.ValueChanged

    '    Try

    '        'Seta MinDate
    '        dtpDataEmissaoPagamentoTerminoFiltro.MinDate = dtpDataEmissaoPagamentoInicioFiltro.Value

    '    Catch ex As Exception
    '        'Trata Erro
    '        Call TratamentoErro(ex.Message, Me.Parent.Text)
    '    End Try

    'End Sub

    Private Sub btnFiltrarPagamento_Click(sender As Object, e As EventArgs) Handles btnFiltrarPagamento.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Carrega Grid
            Call LoadGridPagamento()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnImportarExcelPagamento_Click(sender As Object, e As EventArgs) Handles btnImportarExcelPagamento.Click
        Try
            Call ImportarArquivoExcel()
            Call LoadGridPagamento()
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdPagamento_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdPagamento, _
                                     Formulario.IntegracaoBoletoBancario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdPagamento_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdPagamento.Name, _
                                     Formulario.IntegracaoBoletoBancario, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdPagamento_GroupsChanging(sender As Object, e As GroupsChangingEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdPagamento.Name, _
                                          Formulario.IntegracaoBoletoBancario, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: DADOS GERAIS :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrIntConciliacaoBancaria_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Data
            dtpDataEmissaoRemessaInicioFiltro.Value = Now.Date : dtpDataEmissaoRemessaInicioFiltro.Checked = False
            dtpDataEmissaoRemessaTerminoFiltro.Value = Now.Date : dtpDataEmissaoRemessaTerminoFiltro.Checked = False

            'Configura Grid
            Call ConfiguraGrid(grdRemessa, Formulario.IntegracaoBoletoBancario)
            Call ConfiguraGrid(grdRetorno, Formulario.IntegracaoBoletoBancario)


            If Not goDatabase.sInitialCatalog = "INTERACTI_MAGMA_PRD" Then

                grdRetorno.RootTable.ColumnSets("ColumnSetVincular").Visible = False

            End If

            dtpDataEmissaoPagamentoInicioFiltro.Checked = False
            dtpDataEmissaoPagamentoTerminoFiltro.Checked = False
            dtpDataEmissaoPagamentoInicioFiltro.Value = Now
            dtpDataEmissaoPagamentoTerminoFiltro.Value = Now

            'Verifica Direito
            btnGerarArquivoRemessa.Enabled = VerificaDireito(Formulario.IntegracaoBoletoBancario, gcInsert)
            btnImportarRetorno.Enabled = VerificaDireito(Formulario.IntegracaoBoletoBancario, gcInsert)

            'Carrega Combo - Tipo de Operacao
            Call LoadCombo(cboBancoContaRemessa, "sp_select_combo_cadastro_basico_banco_conta " & goUsuario.iEmpresa)
            Call LoadCombo(cboBancoContaRetorno, "sp_select_combo_cadastro_basico_banco_conta " & goUsuario.iEmpresa)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: REMESSA :::"

    Private Sub LoadGridRemessa()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Campo - Conta Bancária
            If ValidaCampo(cboBancoContaRemessa, lblBancoContaRemessa) = False Then
                Exit Sub
            End If '

            'Carrega Grid
            Call oClsIntegracaoBoleto.LoadGridRemessa(grdRemessa, _
                                                      IIf(dtpDataEmissaoRemessaInicioFiltro.Checked = True, dtpDataEmissaoRemessaInicioFiltro.Value, ""), _
                                                      IIf(dtpDataEmissaoRemessaTerminoFiltro.Checked = True, dtpDataEmissaoRemessaTerminoFiltro.Value, ""), _
                                                      cboBancoContaRemessa.SelectedValue)

            grdRemessa.MoveFirst()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub GerarArquivoRemessa()

        Try

            'Valida Dados do Formulário
            If ValidacaoRemessa() = True Then

                'Setando o cursor
                Cursor.Current = Cursors.WaitCursor

                'Váriavel Local
                Dim sPath As String = ""
                Dim oFolder As New FolderBrowserDialog

                'Verifica se foi Selecionado algum Arquivo
                If oFolder.ShowDialog = DialogResult.OK Then

                    If cboBancoContaRemessa.Text.Contains("SICRED") Then
                        If Now.Month = 10 Or Now.Month = 11 Or Now.Month = 12 Then
                            If Now.Month = 10 Then sPath = oFolder.SelectedPath & "\70224O" & Format(Now, "dd") & ".CRM"
                            If Now.Month = 11 Then sPath = oFolder.SelectedPath & "\70224N" & Format(Now, "dd") & ".CRM"
                            If Now.Month = 12 Then sPath = oFolder.SelectedPath & "\70224D" & Format(Now, "dd") & ".CRM"
                        Else
                            sPath = oFolder.SelectedPath & "\70224" & Format(Now, "Mdd") & ".CRM"
                        End If


                        If System.IO.File.Exists(sPath) Then
                            If Now.Month = 10 Then sPath = oFolder.SelectedPath & "\70224O" & Format(Now, "dd") & ".RM2"
                            If Now.Month = 11 Then sPath = oFolder.SelectedPath & "\70224N" & Format(Now, "dd") & ".RM2"
                            If Now.Month = 12 Then sPath = oFolder.SelectedPath & "\70224D" & Format(Now, "dd") & ".RM2"
                            'sPath = oFolder.SelectedPath & "\70224" & Format(Now, "Mdd") & ".RM2"
                        End If

                    Else
                        If cboBancoContaRemessa.Text.Contains("BRADESCO") Then
                            Dim iNumeroArquivo As Integer = LoadCodigoTexto("select count(*) from tb_int_conciliacao_bancaria_arquivo_remessa where cast(data_processamento as date) = cast('" & Now.Date & "' as date)")
                            If iNumeroArquivo = 0 Then
                                iNumeroArquivo = 1
                            End If
                            sPath = oFolder.SelectedPath & "\CB" & Format(Now, "dd") & Format(Now, "MM") & "A" & CStr(iNumeroArquivo) & ".REM"
                        Else
                            sPath = oFolder.SelectedPath & "\R" & Format(Now, "MMdd") & "0.rem"
                        End If
                    End If

                End If

                'Desabilita FolderDialog
                oFolder.Dispose()

                'Gerando o arquivo
                Call oClsIntegracaoBoleto.GerarArquivoRemessa(grdRemessa, cboBancoContaRemessa.SelectedValue, sPath)


                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoRemessa() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoRemessa = False

            'Verifica se foi Selecionado o Campo - Banco Conta
            If ValidaCampo(cboBancoContaRemessa, lblBancoContaRemessa) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado alguma Nota Fiscal
            If VerificaSelecaoRow(grdRemessa) = False Then
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoRemessa = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: RETORNO :::"

    Private Sub ImportarArquivoRetorno()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Campo - Conta Bancária
            If ValidaCampo(cboBancoContaRetorno, lblContaBancariaRetorno) = False Then
                Exit Sub
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Abrindo o dialog para inserir o arquivo
            Dim oFileDialog As New OpenFileDialog
            oFileDialog.Multiselect = True
            'oFileDialog.Filter = "(Arquivo de Retorno)|*.ret"
            oFileDialog.Title = "Selecione o arquivo"
            oFileDialog.InitialDirectory = "c:\\dados"
            If oFileDialog.ShowDialog <> DialogResult.OK Then Exit Sub

            'Seta ProgressBar
            frmMain.stbMain.Panels("pnlProgressBar").ProgressBarMaxValue = oFileDialog.FileNames.Count
            frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue = 0
            frmMain.stbMain.Panels("pnlProgressBar").Visible = True

            'Lendo os arquivos selecionados
            For Each sFileName As String In oFileDialog.FileNames

                'Instanciando
                Dim oFile As New System.IO.FileInfo(sFileName)

                'Informa Arquivo que está sendo lido
                txtArquivoRetorno.Text = "Arquivo:" & sFileName.Replace(oFile.Directory.FullName & "\", "")

                'Carrega Arquivo
                Call oClsIntegracaoBoleto.LoadArquivoRetorno(cboBancoContaRetorno.SelectedValue, grdRetorno, sFileName)
                txtArquivoRetorno.Tag = sFileName

                'Seta Progressbar
                frmMain.stbMain.Panels("pnlProgressBar").ProgressBarValue += 1

                'Verificando eventos pendentes
                Application.DoEvents()

            Next

            'Oculta Progressbar
            frmMain.stbMain.Panels("pnlProgressBar").Visible = False

            'Informando ao usuário
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

            'Desabilita Controles
            cboBancoContaRetorno.Enabled = False
            btnImportarRetorno.Enabled = False

        Catch ex As Exception
            frmMain.stbMain.Panels("pnlProgressBar").Visible = False
            TratamentoErro(ex.Message, Me.Parent.ToString)
            grdRetorno.DataSource = Nothing
        Finally
            txtArquivoRetorno.Text = ""
            Cursor.Current = Cursors.Default
        End Try

    End Sub

    Private Sub NovoRetorno()

        Try

            'Limpa Registros
            cboBancoContaRetorno.SelectedIndex = -1 : cboBancoContaRetorno.Enabled = True
            txtArquivoRetorno.Text = ""
            grdRetorno.DataSource = Nothing
            btnImportarRetorno.Enabled = True

            'Seta Focu
            cboBancoContaRetorno.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarPagamentoRetorno()

        Try

            'Verifica se o Usuário Deseja Salvar os Dados dos Pagamentos
            If MsgBox("Deseja Salvar os Dados do Arquivo de Retorno?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                'Atualiza Registros
                Call oClsIntegracaoBoleto.SalvarRetorno(grdRetorno, cboBancoContaRetorno.SelectedValue)

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroSalvo)

                'Limpa Formulário
                Call NovoRetorno()

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Vincular()
        Try


            'Verifica se o bole
            If grdRetorno.CurrentColumn.Key = "vincular" Then


                'Faz as validações
                If grdRetorno.GetValue("sistema") = True Then
                    frmMain.Informacao("Só é possível fazer o vínculo de boletos que não foram gerados pelo sistema!", Color.Red)
                    Exit Sub
                End If
                If grdRetorno.GetValue("valor_pago") = 0 Then
                    frmMain.Informacao("Só é possível fazer o vínculo de boletos que não foram quitados!", Color.Red)
                    Exit Sub
                End If


                'Abre o formulário
                Dim oForm As New frmIntConciliacaoBancariaVincular
                oForm.Grid = grdRetorno
                oForm.CodigoBancoConta = cboBancoContaRetorno.SelectedValue
                oForm.Arquivo = txtArquivoRetorno.Tag
                oForm.ShowDialog()


            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Imprimir()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor



            If bSistemaPerforma = True Then

                Dim sCodigo As String = ""

                For Each oRow In grdRemessa.GetCheckedRows

                    sCodigo += IIf(sCodigo = "", "", ",") + CStr(oRow.Cells.Item("codigo").Value)

                Next

                'Redimenciona Vetor
                ReDim goCrystalReport.sReportParameter(1)
                'Seta Parametros
                goCrystalReport.sReportParameter(0).sParamenter = "@codigo_titulo_capa"
                goCrystalReport.sReportParameter(0).sValue = sCodigo
                goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
                goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
                goCrystalReport.sReport = goCrystalReport.sPath & "rptBoletoSantander.rpt"

                Dim oReport As New usrReport
                oReport.Dock = DockStyle.Fill

                'Abre Relatório
                frmMain.LoadPage("SANTANDER", "Boletos Bancários", oReport)

            Else



                'Redimenciona Vetor
                ReDim goCrystalReport.sReportParameter(3)
                'Seta Parametros
                goCrystalReport.sReportParameter(0).sParamenter = "@data_inicio"
                goCrystalReport.sReportParameter(0).sValue = IIf(dtpDataEmissaoRemessaInicioFiltro.Checked = False, "NULL", dtpDataEmissaoRemessaInicioFiltro.Value)
                goCrystalReport.sReportParameter(1).sParamenter = "@data_termino"
                goCrystalReport.sReportParameter(1).sValue = IIf(dtpDataEmissaoRemessaTerminoFiltro.Checked = False, "NULL", dtpDataEmissaoRemessaTerminoFiltro.Value)
                goCrystalReport.sReportParameter(2).sParamenter = "@codigo_banco_conta"
                goCrystalReport.sReportParameter(2).sValue = cboBancoContaRemessa.SelectedValue
                goCrystalReport.sReportParameter(3).sParamenter = "@codigo_empresa"
                goCrystalReport.sReportParameter(3).sValue = goUsuario.iEmpresa
                goCrystalReport.sReport = goCrystalReport.sPath & "FIN000000031.rpt"

                Dim oReport As New usrReport
                oReport.Dock = DockStyle.Fill

                'Abre Relatório
                frmMain.LoadPage("FIN000000031", "Boletos Bancários", oReport)


            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub
#End Region

#Region "::: PAGAMENTO :::"

    Private Sub ImportarArquivoExcel()

        Try
            frmMain.errInfo.Clear()
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim oApplicationClass As New Excel.ApplicationClass
            Dim oArquivoExcel As New OpenFileDialog
            Dim i As Integer

            'Seta Dados do OpenFileDialog
            oArquivoExcel.Filter = "Arquivo Excel|*.xls;*.xlsx;*.csv"
            oArquivoExcel.InitialDirectory = "c:\\"

            'Verifica se foi Selecionado algum Arquivo
            If oArquivoExcel.ShowDialog = DialogResult.OK Then

                'Abre o Arquivo
                oApplicationClass.Workbooks.Open(oArquivoExcel.FileName)

                'Percorre Linha a Linha o Arquivo
                For i = 2 To oApplicationClass.Rows.Count

                    'Verifica se acabou os registros
                    If oApplicationClass.Range("A" & i).Value Is Nothing Then
                        Exit For
                    End If

                    oClsIntegracaoBoleto.CodigoConsultora = oApplicationClass.Range("A" & i).Value
                    oClsIntegracaoBoleto.Banco = oApplicationClass.Range("D" & i).Value
                    oClsIntegracaoBoleto.Agencia = oApplicationClass.Range("E" & i).Value
                    oClsIntegracaoBoleto.Conta = oApplicationClass.Range("F" & i).Value
                    oClsIntegracaoBoleto.Valor = oApplicationClass.Range("H" & i).Value

                    oClsIntegracaoBoleto.InsertPagamento()


                Next

                oApplicationClass.Workbooks.Close()


                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default
            End If
            frmMain.Informacao(Mensagem.RegistroInserido)


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridPagamento()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Erro
            frmMain.errInfo.Clear()
             
            oClsIntegracaoBoleto.LoadGridPagamento(grdPagamento, _
                                                   IIf(dtpDataEmissaoPagamentoInicioFiltro.Checked = True, dtpDataEmissaoPagamentoInicioFiltro.Value, ""), _
                                                   IIf(dtpDataEmissaoPagamentoTerminoFiltro.Checked = True, dtpDataEmissaoPagamentoTerminoFiltro.Value, ""))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub GerarArquivoPagamento()

        Try

            'Valida Dados do Formulário
            If ValidacaoPagamento() = True Then

                'Setando o cursor
                Cursor.Current = Cursors.WaitCursor

                'Váriavel Local
                Dim sPath As String = ""
                Dim oFolder As New FolderBrowserDialog

                'Verifica se foi Selecionado algum Arquivo
                If oFolder.ShowDialog = DialogResult.OK Then

                    If cboBancoContaRemessa.Text.Contains("SICRED") Then
                        If Now.Month = 10 Or Now.Month = 11 Or Now.Month = 12 Then
                            If Now.Month = 10 Then sPath = oFolder.SelectedPath & "\70224O" & Format(Now, "dd") & ".CRM"
                            If Now.Month = 11 Then sPath = oFolder.SelectedPath & "\70224N" & Format(Now, "dd") & ".CRM"
                            If Now.Month = 12 Then sPath = oFolder.SelectedPath & "\70224D" & Format(Now, "dd") & ".CRM"
                        Else
                            sPath = oFolder.SelectedPath & "\70224" & Format(Now, "Mdd") & ".CRM"
                        End If


                        If System.IO.File.Exists(sPath) Then
                            If Now.Month = 10 Then sPath = oFolder.SelectedPath & "\70224O" & Format(Now, "dd") & ".RM2"
                            If Now.Month = 11 Then sPath = oFolder.SelectedPath & "\70224N" & Format(Now, "dd") & ".RM2"
                            If Now.Month = 12 Then sPath = oFolder.SelectedPath & "\70224D" & Format(Now, "dd") & ".RM2"
                            'sPath = oFolder.SelectedPath & "\70224" & Format(Now, "Mdd") & ".RM2"
                        End If

                    Else
                        If cboBancoContaRemessa.Text.Contains("BRADESCO") Then
                            Dim iNumeroArquivo As Integer = LoadCodigoTexto("select count(*) from tb_int_conciliacao_bancaria_arquivo_remessa where cast(data_processamento as date) = cast('" & Now.Date & "' as date)")
                            If iNumeroArquivo = 0 Then
                                iNumeroArquivo = 1
                            End If
                            sPath = oFolder.SelectedPath & "\CB" & Format(Now, "dd") & Format(Now, "MM") & "A" & CStr(iNumeroArquivo) & ".REM"
                        Else
                            sPath = oFolder.SelectedPath & "\R" & Format(Now, "MMdd") & "0.rem"
                        End If
                    End If

                End If

                'Desabilita FolderDialog
                oFolder.Dispose()

                'Gerando o arquivo
                'Call oClsIntegracaoBoleto.GerarArquivoPagamento(grdPagamento, sPath)


                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoPagamento() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoPagamento = False

            'Verifica se foi Selecionado o Campo - Tipo Serviço
            If ValidaCampo(cboTipoServico, lblTipoServico) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Forma Lançamento
            If ValidaCampo(cboFormaLancamento, lblFormaLancamento) = False Then
                Exit Function
            End If

            If VerificaSelecaoRow(grdPagamento) = False Then
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoPagamento = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region
  
End Class