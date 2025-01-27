Imports Janus.Windows.GridEX

Public Class usrQA000000001

    'Variáveis da Classe
    Private oClsQA000000001 As New clsUsrQA000000001

#Region "::: CONTROLES :::"

    Private Sub usrCmp000000009_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCmp000000009_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

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
            oForm.NomeFormulario = Formulario.RelatorioQA000000001
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioQA000000001)

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

    Private Sub btnEditarGrid_Click(sender As Object, e As EventArgs) Handles btnEditarGrid.Click

        Try

            'Váriaveis Locais
            Dim sCampo(0) As String

            'Carrega Valores
            sCampo(0) = "lote_interno"

            'Habilita Grid
            Call EditarGrid(grdListagem, _
                            sCampo, _
                            IIf(grdListagem.Tag.ToString = "E", False, True))

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

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Exporta para Excel
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

    Private Sub grdListagem_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdListagem.CellUpdated

        Try

            'Query
            Dim sQuery As String = "WHERE (((codigo) = " & grdListagem.GetValue("codigo") & ") AND ((codigo_movimentacao) = " & grdListagem.GetValue("codigo_movimentacao") & "))"

            If IsNumeric(grdListagem.GetValue(e.Column.Key)) Then

                'Atualiza Registro Numérico
                Call ExecuteQuery("sp_update_interacti_table_field 'tb_qa_inspecao_produto', '" & e.Column.Key & "', " & IIf(IsDBNull(grdListagem.GetValue(e.Column.Key)) = False, grdListagem.GetValue(e.Column.Key).ToString.Replace(".", "").Replace(",", "."), "'NULL'") & ",'" & sQuery & "'")

            Else

                'Atualiza Registro AlphaNumérico
                Call ExecuteQuery("sp_update_interacti_table_field 'tb_qa_inspecao_produto', '" & e.Column.Key & "', " & IIf(IsDBNull(grdListagem.GetValue(e.Column.Key)) = False, "'''" & grdListagem.GetValue(e.Column.Key).ToString.Replace("''", "") & "'''", "'NULL'") & ",'" & sQuery & "'")

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
                                     Formulario.RelatorioQA000000001)

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
                                     Formulario.RelatorioQA000000001, _
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
                                          Formulario.RelatorioQA000000001, _
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCmp000000009_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega ComboBox
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)
            Call LoadCombo(cboFornecedorFiltro, "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa, False)
            'Carraga Combo - Status
            cboStatusFiltro.Items.Clear()
            cboStatusFiltro.Items.Add("LIBERADO", 1)
            cboStatusFiltro.Items.Add("LIBERADO PARCIALMENTE", 2)
            cboStatusFiltro.Items.Add("NÃO LIBERADO", 3)
            'Carrega Combo - Agrupado
            cboAgrupadoPorFiltro.Items.Clear()
            cboAgrupadoPorFiltro.Items.Add("DATA EMISSÃO NF - DIA", "data_emissao_dia")
            cboAgrupadoPorFiltro.Items.Add("DATA EMISSÃO NF - SEMANA", "data_emissao_semana")
            cboAgrupadoPorFiltro.Items.Add("DATA EMISSÃO NF - MÊS", "data_emissao_mes")
            cboAgrupadoPorFiltro.Items.Add("DATA ENTRADA NF - DIA", "data_entrada_dia")
            cboAgrupadoPorFiltro.Items.Add("DATA ENTRADA NF - SEMANA", "data_entrada_semana")
            cboAgrupadoPorFiltro.Items.Add("DATA ENTRADA NF - MÊS", "data_entrada_mes")
            cboAgrupadoPorFiltro.Items.Add("DATA LIBERAÇÃO - DIA", "data_liberacao_dia")
            cboAgrupadoPorFiltro.Items.Add("DATA LIBERAÇÃO - SEMANA", "data_liberacao_semana")
            cboAgrupadoPorFiltro.Items.Add("DATA LIBERAÇÃO - MÊS", "data_liberacao_mes")
            cboAgrupadoPorFiltro.Items.Add("FORNECEDOR", "fornecedor")
            cboAgrupadoPorFiltro.Items.Add("STATUS", "status")

            'Configura DateTimePicker
            dtpDataEntradaInicioFiltro.Value = Now.Date : dtpDataEntradaInicioFiltro.Checked = False
            dtpDataEntradaTerminoFiltro.Value = Now.Date : dtpDataEntradaTerminoFiltro.Checked = False
            dtpDataEmissaoInicioFiltro.Value = Now.Date : dtpDataEmissaoInicioFiltro.Checked = False
            dtpDataEmissaoTerminoFiltro.Value = Now.Date : dtpDataEmissaoTerminoFiltro.Checked = False
            dtpDataLiberacaoInicioFiltro.Value = Now.Date : dtpDataLiberacaoInicioFiltro.Checked = False
            dtpDataLiberacaoTerminoFiltro.Value = Now.Date : dtpDataLiberacaoTerminoFiltro.Checked = False

            'Verifica Direito
            btnExcelGrid.Enabled = VerificaDireito(Formulario.RelatorioQA000000001, gcPrint)
            btnEditarGrid.Enabled = VerificaDireito(Formulario.RelatorioQA000000001, gcUpdate)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioQA000000001)

            'Seta Focu
            cboFornecedorFiltro.Focus()

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
            oClsQA000000001.LoadGrid(grdListagem, _
                                     IIf(cboFornecedorFiltro.SelectedIndex = -1, -1, cboFornecedorFiltro.SelectedValue), _
                                     IIf(cboStatusFiltro.SelectedIndex = -1, -1, cboStatusFiltro.SelectedValue), _
                                     IIf(dtpDataEmissaoInicioFiltro.Checked = True, dtpDataEmissaoInicioFiltro.Value, ""), _
                                     IIf(dtpDataEmissaoTerminoFiltro.Checked = True, dtpDataEmissaoTerminoFiltro.Value, ""), _
                                     IIf(dtpDataEntradaInicioFiltro.Checked = True, dtpDataEntradaInicioFiltro.Value, ""), _
                                     IIf(dtpDataEntradaTerminoFiltro.Checked = True, dtpDataEntradaTerminoFiltro.Value, ""), _
                                     IIf(dtpDataLiberacaoInicioFiltro.Checked = True, dtpDataLiberacaoInicioFiltro.Value, ""), _
                                     IIf(dtpDataLiberacaoTerminoFiltro.Checked = True, dtpDataLiberacaoTerminoFiltro.Value, ""), _
                                     IIf(cboAgrupadoPorFiltro.SelectedIndex = -1, -1, cboAgrupadoPorFiltro.SelectedValue))

            'Exclui Grupos
            If grdListagem.RootTable.Groups.Count > 0 Then
                grdListagem.RootTable.Groups.Remove(grdListagem.RootTable.Groups(0))
            End If

            'Agrupa Registr
            If cboAgrupadoPorFiltro.SelectedIndex > -1 Then
                grdListagem.RootTable.Groups.Add(grdListagem.RootTable.Columns("agrupado"), SortOrder.Ascending)
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
            ReDim goCrystalReport.sReportParameter(11)

            'Relatório
            goCrystalReport.sReport = goCrystalReport.sPath & "CMP000000009.rpt"

            'Seta Paramentro - Nome
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            'Seta Paramentro - Empresa
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
            'Seta Paramentro - Código Fornecedor
            goCrystalReport.sReportParameter(2).sParamenter = "@codigo_fornecedor"
            goCrystalReport.sReportParameter(2).sValue = IIf(cboFornecedorFiltro.SelectedIndex = -1, -1, cboFornecedorFiltro.SelectedValue)
            'Seta Paramentro - Data Previsão Entrega Início
            goCrystalReport.sReportParameter(5).sParamenter = "@data_previsao_entrega_inicio"
            goCrystalReport.sReportParameter(5).sValue = IIf(dtpDataEntradaInicioFiltro.Checked = False, "NULL", dtpDataEntradaInicioFiltro.Value)
            'Seta Paramentro - Data Previsão Entrega Término
            goCrystalReport.sReportParameter(6).sParamenter = "@data_previsao_entrega_termino"
            goCrystalReport.sReportParameter(6).sValue = IIf(dtpDataEntradaTerminoFiltro.Checked = False, "NULL", dtpDataEntradaTerminoFiltro.Value)
            'Seta Paramentro - Data Emissão Início
            goCrystalReport.sReportParameter(7).sParamenter = "@data_emissao_inicio"
            goCrystalReport.sReportParameter(7).sValue = IIf(dtpDataEmissaoInicioFiltro.Checked = False, "NULL", dtpDataEmissaoInicioFiltro.Value)
            'Seta Paramentro - Data Emissão Término
            goCrystalReport.sReportParameter(8).sParamenter = "@data_emissao_termino"
            goCrystalReport.sReportParameter(8).sValue = IIf(dtpDataEmissaoTerminoFiltro.Checked = False, "NULL", dtpDataEmissaoTerminoFiltro.Value)
            'Seta Paramentro - Data Entrada Início
            goCrystalReport.sReportParameter(9).sParamenter = "@data_entrada_inicio"
            goCrystalReport.sReportParameter(9).sValue = IIf(dtpDataLiberacaoInicioFiltro.Checked = False, "NULL", dtpDataLiberacaoInicioFiltro.Value)
            'Seta Paramentro - Data Entrada Término
            goCrystalReport.sReportParameter(10).sParamenter = "@data_entrada_termino"
            goCrystalReport.sReportParameter(10).sValue = IIf(dtpDataLiberacaoTerminoFiltro.Checked = False, "NULL", dtpDataLiberacaoTerminoFiltro.Value)
            'Seta Paramentro - Agrupado Por
            goCrystalReport.sReportParameter(11).sParamenter = "@agrupado_por"
            goCrystalReport.sReportParameter(11).sValue = IIf(cboAgrupadoPorFiltro.SelectedIndex = -1, "", cboAgrupadoPorFiltro.SelectedValue)


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
