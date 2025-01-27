Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class usrCust000000002

    'Variáveis da Classe
    Private oClsCust000000002 As New clsUsrCust000000002

#Region "::: CONTROLES :::"

    Private Sub usrCust000000002_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCust000000002_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                    
            End Select

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
            oForm.NomeFormulario = Formulario.RelatorioCust000000002
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioCust000000002)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrarGrid.Click

        Try

            'Carrega Dados da Grid
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnVisualizarImpressao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub cboCongelarColuna_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCongelarColuna.SelectedIndexChanged

        Try

            If cboCongelarColuna.SelectedIndex = -1 Then
                grdListagem.FrozenColumns = 0
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
                                     Formulario.RelatorioCust000000002)

            'Carrega Combo
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.RelatorioCust000000002, _
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
                                          Formulario.RelatorioCust000000002, _
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCust000000002_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Limpa Controles
            dtpDataPedidoInicioFiltro.Value = Now.Date : dtpDataPedidoInicioFiltro.Checked = False
            dtpDataPedidoTerminoFiltro.Value = Now.Date : dtpDataPedidoTerminoFiltro.Checked = False
            dtpDataEmissaoInicioFiltro.Value = Now.Date : dtpDataEmissaoInicioFiltro.Checked = False
            dtpDataEmissaoTerminoFiltro.Value = Now.Date : dtpDataEmissaoTerminoFiltro.Checked = False

            'Verifica Direito
            btnExcelGrid.Enabled = VerificaDireito(Formulario.RelatorioCust000000002, gcPrint)

            'Carrega ComboBox
            Call LoadCombo(cboGrupoItemFiltro, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboMarcaFiltro, "sp_select_combo_cadastro_basico_item_marca " & goUsuario.iEmpresa, False)
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioCust000000002)

            'Seta Focu
            txtNumeroPedidoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCust000000002.LoadGrid(grdListagem, _
                                       IIf(IsNumeric(txtNumeroPedidoFiltro.Text.Trim), txtNumeroPedidoFiltro.Text.Trim, -1), _
                                       IIf(dtpDataPedidoInicioFiltro.Checked = False, "", dtpDataPedidoInicioFiltro.Value), _
                                       IIf(dtpDataPedidoTerminoFiltro.Checked = False, "", dtpDataPedidoTerminoFiltro.Value), _
                                       IIf(IsNumeric(txtNotaFiscalFiltro.Text.Trim), txtNotaFiscalFiltro.Text.Trim, -1), _
                                       IIf(dtpDataEmissaoInicioFiltro.Checked = False, "", dtpDataEmissaoInicioFiltro.Value), _
                                       IIf(dtpDataEmissaoTerminoFiltro.Checked = False, "", dtpDataEmissaoTerminoFiltro.Value), _
                                       txtClienteFiltro.Text.Trim, _
                                       IIf(cboGrupoItemFiltro.SelectedIndex = -1, -1, cboGrupoItemFiltro.SelectedValue), _
                                       IIf(cboMarcaFiltro.SelectedIndex = -1, -1, cboMarcaFiltro.SelectedValue), _
                                       txtProdutoFiltro.Text.Trim)

            If grdListagem.GetDataRows.Count = 0 Then
                txtPercentualRO.Value = 0
            Else
                txtPercentualRO.Value = grdListagem.GetTotalRow.Cells("ro").Value / grdListagem.GetTotalRow.Cells("valor_total").Value * 100
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub VisualizarImpressao()

        Try

            'Redimensiona Vetor
            ReDim goCrystalReport.sReportParameter(10)

            ''Seta Paramentro - Nome
            'goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            'goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            ''Seta Paramentro - Empresa
            'goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
            'goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
            ''Seta Paramentro - Empresa
            'goCrystalReport.sReportParameter(2).sParamenter = "@codigo_grupo_item"
            'goCrystalReport.sReportParameter(2).sValue = IIf(cboGrupoItemFiltro.SelectedIndex = -1, -1, cboGrupoItemFiltro.SelectedValue)
            ''Seta Paramentro - Código Produto
            'goCrystalReport.sReportParameter(3).sParamenter = "@codigo_produto"
            'goCrystalReport.sReportParameter(3).sValue = txtCodigoProdutoFiltro.Text.Trim
            ''Seta Paramentro - Descrição
            'goCrystalReport.sReportParameter(4).sParamenter = "@codigo_produto"
            'goCrystalReport.sReportParameter(4).sValue = txtCodigoProdutoFiltro.Text.Trim
            ''Seta Paramentro - Mês
            'goCrystalReport.sReportParameter(5).sParamenter = "@mes_ano"
            'goCrystalReport.sReportParameter(5).sValue = IIf(cboMesFiltro.SelectedIndex = -1, "", cboMesFiltro.SelectedValue)

            'Abre Relatório
            Dim oReport = New usrReport
            oReport.Dock = DockStyle.Fill
            frmMain.LoadPageReport(goCrystalReport.sReport, Me.Parent.Text, oReport)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
