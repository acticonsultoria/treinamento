Imports Janus.Windows.GridEX

Public Class usrFin000000012

    'Variáveis da Classe
    Private oClsFin000000012 As New clsUsrFin000000012

#Region "::: CONTROLES :::"

    Private Sub usrFin000000012_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrFin000000012_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

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
            oForm.NomeFormulario = Formulario.RelatorioFIN000000012
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioFIN000000012)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Dados da Grid
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnVisualizarImpressao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizarImpressao.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Visualizar Impressão
            Call VisualizarImpressao()

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

    Private Sub grdListagem_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Coluna Selecionada é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            'Verifica qual Colula foi Selecionada
            Select grdListagem.CurrentColumn.Key

                Case "atualizar_comissao" : Call AtualizarComissao()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.RelatorioFIN000000012)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.RelatorioFIN000000012, _
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
                                          Formulario.RelatorioFIN000000012, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFin000000012_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega ComboBox
            Call LoadCombo(cboVendedorFiltro, "sp_select_combo_cadastro_basico_vendedor " & goUsuario.iEmpresa, False)

            'Configura DateTimePicker
            dtpDataPedidoInicioFiltro.Value = Now.Date : dtpDataPedidoInicioFiltro.Checked = False
            dtpDataPedidoTerminoFiltro.Value = Now.Date : dtpDataPedidoTerminoFiltro.Checked = False
            dtpDataEmissaoInicioFiltro.Value = Now.Date : dtpDataEmissaoInicioFiltro.Checked = False
            dtpDataEmissaoTerminoFiltro.Value = Now.Date : dtpDataEmissaoTerminoFiltro.Checked = False
            dtpDataPagamentoInicioFiltro.Value = Now.Date : dtpDataPagamentoInicioFiltro.Checked = False
            dtpDataPagamentoTerminoFiltro.Value = Now.Date : dtpDataPagamentoTerminoFiltro.Checked = False

            'Verifica Direito
            btnExcelGrid.Enabled = VerificaDireito(Formulario.RelatorioFIN000000012, gcPrint)
            btnVisualizarImpressao.Enabled = VerificaDireito(Formulario.RelatorioFIN000000012, gcPrint)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioFIN000000012)

            'Seta Focu
            cboVendedorFiltro.Focus()

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

            'Seta Parametros
            oClsFin000000012.LoadGrid(grdListagem, _
                                      IIf(cboVendedorFiltro.SelectedIndex = -1, -1, cboVendedorFiltro.SelectedValue), _
                                      IIf(dtpDataPedidoInicioFiltro.Checked = True, dtpDataPedidoInicioFiltro.Value, ""), _
                                      IIf(dtpDataPedidoTerminoFiltro.Checked = True, dtpDataPedidoTerminoFiltro.Value, ""), _
                                      IIf(dtpDataEmissaoInicioFiltro.Checked = True, dtpDataEmissaoInicioFiltro.Value, ""), _
                                      IIf(dtpDataEmissaoTerminoFiltro.Checked = True, dtpDataEmissaoTerminoFiltro.Value, ""), _
                                      IIf(dtpDataPagamentoInicioFiltro.Checked = True, dtpDataPagamentoInicioFiltro.Value, ""), _
                                      IIf(dtpDataPagamentoTerminoFiltro.Checked = True, dtpDataPagamentoTerminoFiltro.Value, ""))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub VisualizarImpressao()

        Try

            'Redimensiona Vetor
            ReDim goCrystalReport.sReportParameter(8)

            'Relatório
            goCrystalReport.sReport = goCrystalReport.sPath & "FIN000000012.rpt"

            'Seta Paramentro - Nome
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            'Seta Paramentro - Empresa
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
            'Seta Paramentro - Código Centro de Gasto
            goCrystalReport.sReportParameter(2).sParamenter = "@codigo_vendedor"
            goCrystalReport.sReportParameter(2).sValue = IIf(cboVendedorFiltro.SelectedIndex = -1, -1, cboVendedorFiltro.SelectedValue)
            'Seta Paramentro - Data Pedido Início
            goCrystalReport.sReportParameter(3).sParamenter = "@data_pedido_inicio"
            goCrystalReport.sReportParameter(3).sValue = IIf(dtpDataPedidoInicioFiltro.Checked = False, "NULL", dtpDataPedidoInicioFiltro.Value)
            'Seta Paramentro - Data Pedido Término
            goCrystalReport.sReportParameter(4).sParamenter = "@data_pedido_termino"
            goCrystalReport.sReportParameter(4).sValue = IIf(dtpDataPedidoTerminoFiltro.Checked = False, "NULL", dtpDataPedidoTerminoFiltro.Value)
            'Seta Paramentro - Data Emissão Início
            goCrystalReport.sReportParameter(5).sParamenter = "@data_emissao_inicio"
            goCrystalReport.sReportParameter(5).sValue = IIf(dtpDataEmissaoInicioFiltro.Checked = False, "NULL", dtpDataEmissaoInicioFiltro.Value)
            'Seta Paramentro - Data Emissão Término
            goCrystalReport.sReportParameter(6).sParamenter = "@data_emissao_termino"
            goCrystalReport.sReportParameter(6).sValue = IIf(dtpDataEmissaoTerminoFiltro.Checked = False, "NULL", dtpDataEmissaoTerminoFiltro.Value)
            'Seta Paramentro - Data Pagamento Início
            goCrystalReport.sReportParameter(7).sParamenter = "@data_pagamento_inicio"
            goCrystalReport.sReportParameter(7).sValue = IIf(dtpDataPagamentoInicioFiltro.Checked = False, "NULL", dtpDataPagamentoInicioFiltro.Value)
            'Seta Paramentro - Data Pagamento Término
            goCrystalReport.sReportParameter(8).sParamenter = "@data_pagamento_termino"
            goCrystalReport.sReportParameter(8).sValue = IIf(dtpDataPagamentoTerminoFiltro.Checked = False, "NULL", dtpDataPagamentoTerminoFiltro.Value)

            'Abre Relatório
            Dim oReport = New usrReport
            oReport.Dock = DockStyle.Fill
            frmMain.LoadPageReport(goCrystalReport.sReport, Me.Parent.Text, oReport)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub AtualizarComissao()

        Try

            'Verifica se o Usuário deseja Atualizar a Comissão
            If MsgBox("Deseja atualiza a Comissão do Pedido de Venda: " & grdListagem.CurrentRow.Cells("numero_pedido").Value & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                'Atualiza Comissão
                oClsFin000000012.AtualizaComissao(grdListagem.CurrentRow.Cells("codigo_pedido").Value)

                'Carrega a Grid
                Call LoadGrid()

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
