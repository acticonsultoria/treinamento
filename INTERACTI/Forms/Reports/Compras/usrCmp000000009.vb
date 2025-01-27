Imports Janus.Windows.GridEX

Public Class usrCmp000000009

    'Variáveis da Classe
    Private oClsCmp000000009 As New clsUsrCmp000000009

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

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.RelatorioCMP000000009
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioCMP000000009)

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

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click

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

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.RelatorioCMP000000009)

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
                                     Formulario.RelatorioCMP000000009, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub trvMain_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles trvMain.AfterCheck

        Try

            For Each oNode As TreeNode In e.Node.Nodes
                oNode.Checked = e.Node.Checked
            Next

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
            cboStatusFiltro.Items.Add("ENTREGUE ATRASADO", 2)
            cboStatusFiltro.Items.Add("ENTREGUE NO PRAZO", 1)
            cboStatusFiltro.Items.Add("NÃO ENTREGUE", 3)
            'Carrega Combo - Agrupado
            cboAgrupadoPorFiltro.Items.Clear()
            cboAgrupadoPorFiltro.Items.Add("DATA EMISSÃO NF - DIA", "data_emissao_dia")
            cboAgrupadoPorFiltro.Items.Add("DATA EMISSÃO NF - SEMANA", "data_emissao_semana")
            cboAgrupadoPorFiltro.Items.Add("DATA EMISSÃO NF - MÊS", "data_emissao_mes")
            cboAgrupadoPorFiltro.Items.Add("DATA ENTRADA NF - DIA", "data_entrada_dia")
            cboAgrupadoPorFiltro.Items.Add("DATA ENTRADA NF - SEMANA", "data_entrada_semana")
            cboAgrupadoPorFiltro.Items.Add("DATA ENTRADA NF - MÊS", "data_entrada_mes")
            cboAgrupadoPorFiltro.Items.Add("DATA PEDIDO - DIA", "data_pedido_dia")
            cboAgrupadoPorFiltro.Items.Add("DATA PEDIDO - SEMANA", "data_pedido_semana")
            cboAgrupadoPorFiltro.Items.Add("DATA PEDIDO - MÊS", "data_pedido_mes")
            cboAgrupadoPorFiltro.Items.Add("DATA PREVISÃO ENTREGA - DIA", "data_previsao_entrega_dia")
            cboAgrupadoPorFiltro.Items.Add("DATA PREVISÃO ENTREGA - SEMANA", "data_previsao_entrega_semana")
            cboAgrupadoPorFiltro.Items.Add("DATA PREVISÃO ENTREGA - MÊS", "data_previsao_entrega_mes")
            cboAgrupadoPorFiltro.Items.Add("FORNECEDOR", "fornecedor")
            cboAgrupadoPorFiltro.Items.Add("GRUPO DE ITEM", "grupo_item")
            cboAgrupadoPorFiltro.Items.Add("STATUS", "status")
            'Carrega Combo - Avaliar Por
            cboAvaliarPor.Items.Clear()
            cboAvaliarPor.Items.Add("EMISSÃO", "data_emissao")
            cboAvaliarPor.Items.Add("ENTRADA", "data_entrada")

            'Carrega TreeView
            Call LoadTreeView()

            'Configura DateTimePicker
            dtpDataPedidoInicioFiltro.Value = Now.Date : dtpDataPedidoInicioFiltro.Checked = False
            dtpDataPedidoTerminoFiltro.Value = Now.Date : dtpDataPedidoTerminoFiltro.Checked = False
            dtpDataPrevisaoEntregaInicioFiltro.Value = Now.Date : dtpDataPrevisaoEntregaInicioFiltro.Checked = False
            dtpDataPrevisaoEntregaTerminoFiltro.Value = Now.Date : dtpDataPrevisaoEntregaTerminoFiltro.Checked = False
            dtpDataEmissaoInicioFiltro.Value = Now.Date : dtpDataEmissaoInicioFiltro.Checked = False
            dtpDataEmissaoTerminoFiltro.Value = Now.Date : dtpDataEmissaoTerminoFiltro.Checked = False
            dtpDataEntradaInicioFiltro.Value = Now.Date : dtpDataEntradaInicioFiltro.Checked = False
            dtpDataEntradaTerminoFiltro.Value = Now.Date : dtpDataEntradaTerminoFiltro.Checked = False

            'Verifica Direito
            btnExcel.Enabled = VerificaDireito(Formulario.RelatorioCMP000000009, gcPrint)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioCMP000000009)

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

            'Valida Formulário
            If ValidaCampo(cboAvaliarPor, lblAvaliarPor) = False Then
                Exit Sub
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim sCodigoGrupoItem As String = ""

            'Verifica se foi Selecionado o Registro
            If VerificaSelecaoNodeDesmarcado(trvMain) = True Then
                For Each oNode As TreeNode In gSelecaoNode
                    sCodigoGrupoItem &= IIf(sCodigoGrupoItem = "", "", ",") & oNode.Tag
                Next
            End If

            'Seta Parametros
            oClsCmp000000009.LoadGrid(grdListagem, _
                                      IIf(cboFornecedorFiltro.SelectedIndex = -1, -1, cboFornecedorFiltro.SelectedValue), _
                                      IIf(cboStatusFiltro.SelectedIndex = -1, -1, cboStatusFiltro.SelectedValue), _
                                      IIf(dtpDataPedidoInicioFiltro.Checked = True, dtpDataPedidoInicioFiltro.Value, ""), _
                                      IIf(dtpDataPedidoTerminoFiltro.Checked = True, dtpDataPedidoTerminoFiltro.Value, ""), _
                                      IIf(dtpDataPrevisaoEntregaInicioFiltro.Checked = True, dtpDataPrevisaoEntregaInicioFiltro.Value, ""), _
                                      IIf(dtpDataPrevisaoEntregaTerminoFiltro.Checked = True, dtpDataPrevisaoEntregaTerminoFiltro.Value, ""), _
                                      IIf(dtpDataEmissaoInicioFiltro.Checked = True, dtpDataEmissaoInicioFiltro.Value, ""), _
                                      IIf(dtpDataEmissaoTerminoFiltro.Checked = True, dtpDataEmissaoTerminoFiltro.Value, ""), _
                                      IIf(dtpDataEntradaInicioFiltro.Checked = True, dtpDataEntradaInicioFiltro.Value, ""), _
                                      IIf(dtpDataEntradaTerminoFiltro.Checked = True, dtpDataEntradaTerminoFiltro.Value, ""), _
                                      sCodigoGrupoItem, _
                                      txtCodigoProdutoFiltro.Text.Trim, _
                                      txtDescricaoFiltro.Text.Trim, _
                                      IIf(cboAgrupadoPorFiltro.SelectedIndex = -1, -1, cboAgrupadoPorFiltro.SelectedValue), _
                                      cboAvaliarPor.SelectedValue)

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
            'Seta Paramentro - Data Pedido Início
            goCrystalReport.sReportParameter(3).sParamenter = "@data_pedido_inicio"
            goCrystalReport.sReportParameter(3).sValue = IIf(dtpDataPedidoInicioFiltro.Checked = False, "NULL", dtpDataPedidoInicioFiltro.Value)
            'Seta Paramentro - Data Pedido Término
            goCrystalReport.sReportParameter(4).sParamenter = "@data_pedido_termino"
            goCrystalReport.sReportParameter(4).sValue = IIf(dtpDataPedidoTerminoFiltro.Checked = False, "NULL", dtpDataPedidoTerminoFiltro.Value)
            'Seta Paramentro - Data Previsão Entrega Início
            goCrystalReport.sReportParameter(5).sParamenter = "@data_previsao_entrega_inicio"
            goCrystalReport.sReportParameter(5).sValue = IIf(dtpDataPrevisaoEntregaInicioFiltro.Checked = False, "NULL", dtpDataPrevisaoEntregaInicioFiltro.Value)
            'Seta Paramentro - Data Previsão Entrega Término
            goCrystalReport.sReportParameter(6).sParamenter = "@data_previsao_entrega_termino"
            goCrystalReport.sReportParameter(6).sValue = IIf(dtpDataPrevisaoEntregaTerminoFiltro.Checked = False, "NULL", dtpDataPrevisaoEntregaTerminoFiltro.Value)
            'Seta Paramentro - Data Emissão Início
            goCrystalReport.sReportParameter(7).sParamenter = "@data_emissao_inicio"
            goCrystalReport.sReportParameter(7).sValue = IIf(dtpDataEmissaoInicioFiltro.Checked = False, "NULL", dtpDataEmissaoInicioFiltro.Value)
            'Seta Paramentro - Data Emissão Término
            goCrystalReport.sReportParameter(8).sParamenter = "@data_emissao_termino"
            goCrystalReport.sReportParameter(8).sValue = IIf(dtpDataEmissaoTerminoFiltro.Checked = False, "NULL", dtpDataEmissaoTerminoFiltro.Value)
            'Seta Paramentro - Data Entrada Início
            goCrystalReport.sReportParameter(9).sParamenter = "@data_entrada_inicio"
            goCrystalReport.sReportParameter(9).sValue = IIf(dtpDataEntradaInicioFiltro.Checked = False, "NULL", dtpDataEntradaInicioFiltro.Value)
            'Seta Paramentro - Data Entrada Término
            goCrystalReport.sReportParameter(10).sParamenter = "@data_entrada_termino"
            goCrystalReport.sReportParameter(10).sValue = IIf(dtpDataEntradaTerminoFiltro.Checked = False, "NULL", dtpDataEntradaTerminoFiltro.Value)
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

    Private Sub LoadTreeView()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Dim oClsCadGrupoItem As New clsUsrCadGrupoItem

            'Limpa TreeView
            trvMain.Nodes.Clear()

            'Seta Parametros
            oClsCadGrupoItem.LoadTreeViewChecked(trvMain, "")

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
