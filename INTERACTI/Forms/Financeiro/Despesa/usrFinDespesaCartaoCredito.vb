Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX

Public Class usrFinDespesaCartaoCredito

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsFinDespesaCartaoCredito As New clsUsrFinDespesaCartaoCredito

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrFinDespesaCartaoCredito_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                    
                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboFuncionarioPortadorFiltro" : Call LoadCombo(cboFuncionarioPortadorFiltro, "sp_select_combo_cadastro_basico_funcionario " & goUsuario.iEmpresa)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrFinDespesaCartaoCredito_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: CARTÃO DE CRÉDITO :::"

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Try
             
            'Paga Fatura
            Call Imprimir()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdListagem.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdListagem.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdListagem.GroupByBoxVisible = True
                grdListagem.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.FinanceiroDespesaControleCartaoCredito
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FinanceiroDespesaControleCartaoCredito)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exportar Grid - Excel
            Call ExportExcel(grdListagem)

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

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click

        Try

            'Verifica se foi Selecionado algum Cartão
            If ValidaCampo(cboCartaoCreditoFiltro, lblCartaoCreditoFiltro) = False Then
                Exit Sub
            End If

            'Paga Fatura
            Call PagarFatura()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboBandeiraFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBandeiraFiltro.SelectedIndexChanged

        Try

            'Limpa Controle
            cboCartaoCreditoFiltro.DataSource = Nothing
            cboCartaoCreditoFiltro.Text = ""

            Dim goFatura(2) As TipoComboBox
            goFatura(0).oColor = Color.SteelBlue : goFatura(0).sTipo = "1"
            goFatura(1).oColor = Color.ForestGreen : goFatura(1).sTipo = "2"
            goFatura(2).oColor = Color.Firebrick : goFatura(2).sTipo = "3"

            'Verifia se foi Selecionado Algum Registro
            If cboBandeiraFiltro.SelectedIndex <> -1 Then
                Call LoadCombo(cboCartaoCreditoFiltro, "sp_select_combo_financeiro_cartao_credito_fatura " & goUsuario.iEmpresa & ", " & cboBandeiraFiltro.SelectedValue, "sp_select_combo_financeiro_cartao_credito_fatura_tipo " & goUsuario.iEmpresa & ", " & cboBandeiraFiltro.SelectedValue, goFatura)
            End If

            'Carrega Fatura
            Call cboFiltro_SelectedIndexChanged()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboFiltro_SelectedIndexChanged() Handles cboCartaoCreditoFiltro.SelectedIndexChanged, _
                                                         cboFuncionarioPortadorFiltro.SelectedIndexChanged

        Try

            If cboCartaoCreditoFiltro.SelectedIndex = -1 Then

                'Limpa grid
                grdListagem.DataSource = Nothing

            Else

                'Carrega Grid
                Call LoadGrid()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCongelarColuna_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCongelarColuna.SelectedIndexChanged

        Try

            If cboCongelarColuna.SelectedIndex = -1 Then
                grdListagem.FrozenColumns = 1
            Else
                grdListagem.FrozenColumns = cboCongelarColuna.SelectedValue
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.FinanceiroDespesaControleCartaoCredito)

            'Carrega Combo
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            'Verifica a Coluna Pressionada
            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call EditarFatura()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.FinanceiroDespesaControleCartaoCredito, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name, _
                                          Formulario.FinanceiroDespesaControleCheque, _
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFinDespesaCartaoCredito_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Limpa Tag
            grdListagem.Tag = ""

            'Verifica Direito
            btnPagar.Enabled = VerificaDireito(Formulario.FinanceiroDespesaControleCartaoCredito, gcInsert)
            btnCancelar.Enabled = VerificaDireito(Formulario.FinanceiroDespesaControleCartaoCredito, gcAdministrator)
            btnImprimir.Enabled = VerificaDireito(Formulario.FinanceiroDespesaControleCartaoCredito, gcPrint)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.FinanceiroDespesaControleCartaoCredito, gcPrint)

            'Carrega ComboBox
            Call LoadCombo(cboBandeiraFiltro, "sp_select_combo_static_bandeira_cartao_credito", False)
            Call LoadCombo(cboFuncionarioPortadorFiltro, "sp_select_combo_cadastro_basico_funcionario " & goUsuario.iEmpresa, False)
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FinanceiroDespesaControleCartaoCredito)

            'Seta Focu
            cboBandeiraFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: CARTÃO DE CRÉDITO :::"

    Private Sub Imprimir()
        Try
            'Redimensiona Vetor
            ReDim goCrystalReport.sReportParameter(3)

            'Relatório
            goCrystalReport.sReport = goCrystalReport.sPath & "FIN000000032.rpt"

            'Váriavel Local
            Dim sAux(1) As String

            If cboCartaoCreditoFiltro.SelectedIndex = -1 Then
                sAux(0) = "-1" : sAux(1) = ""
            Else
                sAux = cboCartaoCreditoFiltro.SelectedValue.ToString.Split("|")
            End If

            'Dim sCodigos As String = ""
            'For Each oRow In grdListagem.GetCheckedRows
            '    If sCodigos <> "" Then sCodigos += ","

            '    sCodigos += CStr(oRow.Cells.Item("codigo_titulo_capa").Value)
            'Next

            'Seta Paramentro - 
            goCrystalReport.sReportParameter(0).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.iEmpresa
            'Seta Paramentro - Cartão Crédito
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_cartao_credito"
            goCrystalReport.sReportParameter(1).sValue = sAux(0)
            'Seta Paramentro - Fatura
            goCrystalReport.sReportParameter(2).sParamenter = "@fatura"
            goCrystalReport.sReportParameter(2).sValue = IIf(sAux(1) = "", DBNull.Value, sAux(1))
            'Seta Paramentro - Funcionário Portador
            goCrystalReport.sReportParameter(3).sParamenter = "@codigo_funcionario_portador"
            goCrystalReport.sReportParameter(3).sValue = IIf(cboFuncionarioPortadorFiltro.SelectedIndex = -1, -1, cboFuncionarioPortadorFiltro.SelectedValue)

            'Abre Relatório
            Dim oReport = New usrReport
            oReport.Dock = DockStyle.Fill
            oReport.TabPage = Me.Parent
            frmMain.LoadPageReport(goCrystalReport.sReport, "FIN000000032 - Controle Cartão de Crédito", oReport)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriavel Local
            Dim sAux(1) As String

            If cboCartaoCreditoFiltro.SelectedIndex = -1 Then
                sAux(0) = "-1" : sAux(1) = ""
            Else
                sAux = cboCartaoCreditoFiltro.SelectedValue.ToString.Split("|")
            End If

            'Carrega Controles
            Call oClsFinDespesaCartaoCredito.LoadGrid(grdListagem, _
                                                      sAux(0), _
                                                      sAux(1), _
                                                      IIf(cboFuncionarioPortadorFiltro.SelectedIndex = -1, -1, cboFuncionarioPortadorFiltro.SelectedValue))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub PagarFatura()

        Try

            'Verifica se o Usuário tem Direito
            If VerificaDireito(Formulario.FinanceiroDespesaControleCartaoCredito, gcAdministrator) = True Then

                'Verifica se o Status da Parcela é Aberto
                If grdListagem.CurrentRow.Cells("status").Value = CInt(StatusDespesaFaturaCartaoCredito.Aberta) Or _
                   grdListagem.CurrentRow.Cells("status").Value = CInt(StatusDespesaFaturaCartaoCredito.EmAtraso) Then

                    'Formulario
                    Dim oForm As New frmFinDespesaCartaoCreditoPagarFatura
                    'Seta Parâmetros
                    oForm.Bandeira = cboBandeiraFiltro.Text
                    oForm.CartaoCredito = cboCartaoCreditoFiltro.Text
                    oForm.DataVencimento = grdListagem.GetDataRows(0).Cells("fatura").Value
                    oForm.Valor = grdListagem.GetTotalRow.Cells("valor").Value
                    oForm.CodigoCartaoCredito = cboCartaoCreditoFiltro.SelectedValue.Split("|")(0)
                    'Abre Formulário
                    Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                    'Carrega Grid
                    Call cboFiltro_SelectedIndexChanged()

                Else
                    'Informa o Usuário que ele não pode liquidar este registro
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
                End If

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAdministrador)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ReabrirFatura()

        Try

            'Verifica se o Usuário tem Direito
            If VerificaDireito(Formulario.FinanceiroDespesaControleCartaoCredito, gcAdministrator) = True Then

                'Verifica se o Status da Parcela é Aberto
                If grdListagem.CurrentRow.Cells("status").Value = CInt(StatusDespesaFaturaCartaoCredito.Paga) Then

                    'Verifica se foi seleciona um cartão
                    If cboCartaoCreditoFiltro.SelectedIndex <> -1 Then

                        'Variavel
                        Dim sAuxiliar() As String
                        sAuxiliar = cboCartaoCreditoFiltro.SelectedValue.Split("|")
                            

                        'Verifica se o Usuário Deseja Cancelar a Liquidação da Fatura
                        If MsgBox("Deseja Reabrir da Fatura Selecionada?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                            'Seta Cursor do Mouse
                            Cursor.Current = Cursors.WaitCursor

                            'Cancela Compensação do Cheque
                            oClsFinDespesaCartaoCredito.UpdateStatusFatura(sAuxiliar(0), _
                                                                           sAuxiliar(1), _
                                                                           "", _
                                                                           0)

                            'Carraga Grid
                            If cboCartaoCreditoFiltro.SelectedIndex = -1 Then

                                'Limpa grid
                                grdListagem.DataSource = Nothing

                            Else

                                'Carrega Grid
                                Call LoadGrid()

                            End If

                            'Seta Cursor do Mouse
                            Cursor.Current = Cursors.Default

                        End If
                    Else

                        'Informa o Usuário que ele não pode cancelar este registro
                        frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Selecione um Cartão de Crédito")

                    End If

                Else
                    'Informa o Usuário que ele não pode cancelar este registro
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
                End If

                Else
                    'Informa o Usuário que ele não tem Direito
                    frmMain.Informacao(Mensagem.DireitoAdministrador)
                End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarFatura()

        Try

            'Verifica se o Usuário tem Direito
            If VerificaDireito(Formulario.FinanceiroDespesaControleCartaoCredito, gcAdministrator) = True Then
                
                'Verifica se o Status da Parcela é Aberto
                If grdListagem.CurrentRow.Cells("status").Value = CInt(StatusDespesaFaturaCartaoCredito.Aberta) Or _
                   grdListagem.CurrentRow.Cells("status").Value = CInt(StatusDespesaFaturaCartaoCredito.EmAtraso) Then

                    Dim oForm As New frmFinDespesaCartaoCreditoEditarFatura

                    oForm.NumeroDocumento = grdListagem.CurrentRow.Cells("numero_documento").Value
                    oForm.ParceiroNegocio = grdListagem.CurrentRow.Cells("parceiro_negocio").Value
                    oForm.Valor = grdListagem.CurrentRow.Cells("valor").Value
                    oForm.DataVencimentoOriginal = grdListagem.CurrentRow.Cells("fatura").Value

                Else
                    'Informa o Usuário que ele não pode cancelar este registro
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
                End If

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAdministrador)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Try

            'Verifica se foi Selecionado algum Cartão
            If ValidaCampo(cboCartaoCreditoFiltro, lblCartaoCreditoFiltro) = False Then
                Exit Sub
            End If

            'Paga Fatura
            Call ReabrirFatura()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

End Class
