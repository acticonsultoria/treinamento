Imports Janus.Windows.GridEX

Public Class usrVen000000003

    'Variáveis da Classe
    Private oClsVen000000003 As New clsUsrVen000000003

#Region "::: CONTROLES :::"

    Private Sub usrVen000000003_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

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

    Private Sub usrVen000000003_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.ComercialPedidoVenda
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ComercialPedidoVenda)

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

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Grid
            Call LoadGrid()

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
                                     Formulario.RelatorioVEN000000003)

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
                                     Formulario.RelatorioVEN000000003, _
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrVen000000003_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega ComboBox
            Call LoadCombo(cboClienteFiltro, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboSegmentoFiltro, "sp_select_combo_cadastro_basico_parceiro_negocio_segmento " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboGrupoItemFiltro, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboProbabilidadeVendaFiltro, "sp_select_combo_cadastro_basico_probabilidade_exito_venda " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboVendedorFiltro, "sp_select_combo_cadastro_basico_vendedor " & goUsuario.iEmpresa & ", " & goUsuario.iUsuario, False)
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

            'Configura DateTimePicker
            dtpDataOrcamentoInicioFiltro.Value = Now.Date : dtpDataOrcamentoInicioFiltro.Checked = False
            dtpDataOrcamentoTerminoFiltro.Value = Now.Date : dtpDataOrcamentoTerminoFiltro.Checked = False
            dtpDataPrevisaoInicioFiltro.Value = Now.Date : dtpDataPrevisaoInicioFiltro.Checked = False
            dtpDataPrevisaoTerminoFiltro.Value = Now.Date : dtpDataPrevisaoTerminoFiltro.Checked = False

            'Carrega Combo - Agrupado
            cboAgrupadoPorFiltro.Items.Clear()
            cboAgrupadoPorFiltro.Items.Add("CLIENTE", "cliente")
            cboAgrupadoPorFiltro.Items.Add("DATA ORÇAMENTO - DIA", "data_orcamento_dia")
            cboAgrupadoPorFiltro.Items.Add("DATA ORÇAMENTO - SEMANA", "data_orcamento_semana")
            cboAgrupadoPorFiltro.Items.Add("DATA ORÇAMENTO - MÊS", "data_orcamento_mes")
            cboAgrupadoPorFiltro.Items.Add("DATA PREVISÃO VENDA - DIA", "data_previsao_venda_dia")
            cboAgrupadoPorFiltro.Items.Add("DATA PREVISÃO VENDA - SEMANA", "data_previsao_venda_semana")
            cboAgrupadoPorFiltro.Items.Add("DATA PREVISÃO VENDA - MÊS", "data_previsao_venda_mes")
            cboAgrupadoPorFiltro.Items.Add("PROBABILIDADE DE VENDA", "probabilidade_venda")
            cboAgrupadoPorFiltro.Items.Add("SEGMENTO", "segmento")
            cboAgrupadoPorFiltro.Items.Add("VENDEDOR", "vendedor")

            'Verifica Direito
            btnExcelGrid.Enabled = VerificaDireito(Formulario.RelatorioVEN000000003, gcPrint)
            btnVisualizarImpressao.Enabled = VerificaDireito(Formulario.RelatorioVEN000000003, gcPrint)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioVEN000000003)

            'Seta Focu
            dtpDataOrcamentoInicioFiltro.Focus()

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
            Call oClsVen000000003.LoadGrid(grdListagem, _
                                           IIf(dtpDataOrcamentoInicioFiltro.Checked = True, dtpDataOrcamentoInicioFiltro.Value, ""), _
                                           IIf(dtpDataOrcamentoTerminoFiltro.Checked = True, dtpDataOrcamentoTerminoFiltro.Value, ""), _
                                           IIf(cboClienteFiltro.SelectedIndex = -1, -1, cboClienteFiltro.SelectedValue), _
                                           IIf(cboVendedorFiltro.SelectedIndex = -1, -1, cboVendedorFiltro.SelectedValue), _
                                           IIf(dtpDataPrevisaoInicioFiltro.Checked = True, dtpDataPrevisaoInicioFiltro.Value, ""), _
                                           IIf(dtpDataPrevisaoTerminoFiltro.Checked = True, dtpDataPrevisaoTerminoFiltro.Value, ""), _
                                           IIf(cboGrupoItemFiltro.SelectedIndex = -1, -1, cboGrupoItemFiltro.SelectedValue), _
                                           IIf(cboSegmentoFiltro.SelectedIndex = -1, -1, cboSegmentoFiltro.SelectedValue), _
                                           IIf(cboProbabilidadeVendaFiltro.SelectedIndex = -1, -1, cboProbabilidadeVendaFiltro.SelectedValue), _
                                           IIf(cboAgrupadoPorFiltro.SelectedIndex = -1, "", cboAgrupadoPorFiltro.SelectedValue))

            'Exclui Grupos
            If grdListagem.RootTable.Groups.Count > 0 Then
                grdListagem.RootTable.Groups.Remove(grdListagem.RootTable.Groups(0))
            End If

            'Agrupa Registr
            If cboAgrupadoPorFiltro.SelectedIndex > -1 Then
                grdListagem.AutomaticSort = False
                grdListagem.RootTable.Groups.Add(grdListagem.RootTable.Columns("agrupado"))
            End If

            grdListagem.MoveFirst()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub VisualizarImpressao()

        Try

            'Redimensiona Vetor
            ReDim goCrystalReport.sReportParameter(9)

            'Relatório
            goCrystalReport.sReport = goCrystalReport.sPath & "FIN000000001.rpt"

            'Seta Paramentro - Nome
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            'Seta Paramentro - Empresa
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
            ''Seta Paramentro - Código Parceiro de Negócio
            'goCrystalReport.sReportParameter(2).sParamenter = "@codigo_parceiro_negocio"
            'goCrystalReport.sReportParameter(2).sValue = IIf(cboFornecedorFiltro.SelectedIndex = -1, -1, cboFornecedorFiltro.SelectedValue)
            ''Seta Paramentro - Data Emissão Início
            'goCrystalReport.sReportParameter(3).sParamenter = "@data_emissao_inicio"
            'goCrystalReport.sReportParameter(3).sValue = IIf(dtpDataEmissaoInicioFiltro.Checked = False, "NULL", dtpDataEmissaoInicioFiltro.Value)
            ''Seta Paramentro - Data Emissão Término
            'goCrystalReport.sReportParameter(4).sParamenter = "@data_emissao_termino"
            'goCrystalReport.sReportParameter(4).sValue = IIf(dtpDataEmissaoTerminoFiltro.Checked = False, "NULL", dtpDataEmissaoTerminoFiltro.Value)
            ''Seta Paramentro - Data Vencimento Início
            'goCrystalReport.sReportParameter(5).sParamenter = "@data_vencimento_inicio"
            'goCrystalReport.sReportParameter(5).sValue = IIf(dtpDataVencimentoInicioFiltro.Checked = False, "NULL", dtpDataVencimentoInicioFiltro.Value)
            ''Seta Paramentro - Data Vencimento Término
            'goCrystalReport.sReportParameter(6).sParamenter = "@data_vencimento_termino"
            'goCrystalReport.sReportParameter(6).sValue = IIf(dtpDataVencimentoTerminoFiltro.Checked = False, "NULL", dtpDataVencimentoTerminoFiltro.Value)
            ''Seta Paramentro - Código Tipo Título Financeiro
            'goCrystalReport.sReportParameter(7).sParamenter = "@codigo_tipo_titulo_financeiro"
            'goCrystalReport.sReportParameter(7).sValue = IIf(cboTipoTituloFinanceiroFiltro.SelectedIndex = -1, -1, cboTipoTituloFinanceiroFiltro.SelectedValue)
            ''Seta Paramentro - Código Centro de Custo
            'goCrystalReport.sReportParameter(8).sParamenter = "@codigo_centro_custo"
            'goCrystalReport.sReportParameter(8).sValue = IIf(cboCentroCustoFiltro.SelectedIndex = -1, -1, cboCentroCustoFiltro.SelectedValue)
            'Seta Paramentro - Agrupado Por
            goCrystalReport.sReportParameter(9).sParamenter = "@agrupado_por"
            goCrystalReport.sReportParameter(9).sValue = IIf(cboAgrupadoPorFiltro.SelectedIndex = -1, "", cboAgrupadoPorFiltro.SelectedValue)

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
