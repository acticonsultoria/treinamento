Imports System.IO
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.CalendarCombo
Imports System.Math
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Reflection
Imports System.Reflection.Assembly

Public Class usrCmpPedido

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCmpPedido As New clsUsrCmpPedido
    Private bReaprovar As Boolean
    Private sCodigoProdutoAnterior As String
    Private oCurrentRow As GridEXRow
    Private iFormulario As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoProdutoAnterior() As String
        Get
            Return sCodigoProdutoAnterior
        End Get
        Set(ByVal value As String)
            sCodigoProdutoAnterior = value
        End Set
    End Property
     
#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrCmpPedido_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) 

        Try

            Select Case e.KeyCode

                Case Keys.Enter

                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGridPedidoCompra() Else Control_Enter(sender)
                    
                Case Keys.F3

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboFornecedor" : Call btnProcurarFornecedor_Click(btnProcurarFornecedor, System.EventArgs.Empty)
                        Case "cboProduto" : Call btnProcurarProduto_Click(btnProcurarProduto, System.EventArgs.Empty)
                        Case "cboServico" : Call btnProcurarServico_Click(btnProcurarServico, System.EventArgs.Empty)
                        Case "cboCentroGastoProduto" : Call btnProcurarCentroGastoProduto_Click(btnProcurarCentroGastoProduto, System.EventArgs.Empty)
                        Case "cboContaContabilProduto" : Call btnProcurarContaContabilProduto_Click(btnProcurarContaContabilProduto, System.EventArgs.Empty)
                        Case "cboCentroGastoServico" : Call btnProcurarCentroGastoServico_Click(btnProcurarCentroGastoServico, System.EventArgs.Empty)
                        Case "cboContaContabilServico" : Call btnProcurarContaContabilProduto_Click(btnProcurarContaContabilProduto, System.EventArgs.Empty)
                        Case "cboItemFiltro" : Call btnProcurarItemFiltro_Click(btnProcurarItemFiltro, System.EventArgs.Empty)
                        Case "txtObservacao" : Call btnProcurarAutotexto_Click(btnProcurarObservacao, System.EventArgs.Empty)
                        Case "cboFornecedorFiltro" : Call btnProcurarFornecedor_Click(btnProcurarFornecedorFiltro, System.EventArgs.Empty)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name

                        Case "cboFornecedor" : Call LoadCombo(cboFornecedor, "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa)
                        Case "cboFornecedorFiltro" : Call LoadCombo(cboFornecedorFiltro, "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa)
                        Case "cboProduto" : Call LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, 1, " & TipoItem.produto)
                        Case "cboUnidadeMedidaProduto" : Call LoadCombo(cboUnidadeMedidaProduto, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)
                        Case "cboCentroGastoProduto" : Call LoadCombo(cboCentroGastoProduto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)
                        Case "cboContaContabilProduto" : Call LoadCombo(cboContaContabilProduto, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa)
                        Case "cboServico" : Call LoadCombo(cboServico, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.servico))
                        Case "cboUnidadeMedidaServico" : Call LoadCombo(cboUnidadeMedidaServico, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)
                        Case "cboCentroGastoServico" : Call LoadCombo(cboCentroGastoServico, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)
                        Case "cboContaContabilServico" : Call LoadCombo(cboContaContabilServico, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa)
                        Case "cboTransportadora" : Call LoadCombo(cboTransportadora, "sp_select_combo_cadastro_basico_transportadora " & goUsuario.iEmpresa)
                        Case "cboAgenteLogistico" : Call LoadCombo(cboAgenteLogistico, "sp_select_combo_cadastro_basico_agente_logistico " & goUsuario.iEmpresa)
                        Case "cboIncoterms" : Call LoadCombo(cboIncoterms, "sp_select_combo_cadastro_basico_incoterms " & goUsuario.iEmpresa)
                        Case "cboInstrucaoEmbarque" : Call LoadCombo(cboInstrucaoEmbarque, "sp_select_combo_cadastro_basico_instrucao_embarque " & goUsuario.iEmpresa)
                        Case "cboModalidadeTransporte" : Call LoadCombo(cboModalidadeTransporte, "sp_select_combo_cadastro_basico_modalidade_transporte " & goUsuario.iEmpresa)
                        Case "cboCondicaoPagamento" : Call LoadCombo(cboCondicaoPagamento, "sp_select_combo_cadastro_basico_condicao_pagamento " & goUsuario.iEmpresa)
                        Case "cboFormaPagamento" : Call LoadCombo(cboFormaPagamento, "sp_select_combo_static_forma_pagamento")
                        Case "cboMoeda" : Call LoadCombo(cboMoeda, "sp_select_combo_cadastro_basico_moeda " & goUsuario.iEmpresa)
                        Case "cboItemFiltro" : Call LoadCombo(cboItemFiltro, "sp_select_combo_cadastro_basico_item_descricao " & goUsuario.iEmpresa & ", NULL, 1, -1")

                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboFornecedor" : Call btnCadastrarFornecedor_Click(btnCadastrarFornecedor, System.EventArgs.Empty)
                        Case "cboProduto" : Call btnCadastrarProduto_Click(btnCadastrarProduto, System.EventArgs.Empty)
                        Case "cboUnidadeMedidaProduto" : Call btnCadastrarUnidadeMedidaProduto_Click(btnCadastrarUnidadeMedidaProduto, System.EventArgs.Empty)
                        Case "cboUnidadeMedidaServico" : Call btnCadastrarUnidadeMedidaServico_Click(btnCadastrarUnidadeMedidaServico, System.EventArgs.Empty)
                        Case "cboCentroGastoProduto" : Call btnCadastrarCentroGastoProduto_Click(btnCadastrarCentroGastoProduto, System.EventArgs.Empty)
                        Case "cboContaContabilProduto" : Call btnCadastrarContaContabilProduto_Click(btnCadastrarContaContabilProduto, System.EventArgs.Empty)
                        Case "cboServico" : Call btnCadastrarServico_Click(btnCadastrarServico, System.EventArgs.Empty)
                        Case "cboCentroGastoServico" : Call btnCadastrarCentroGastoServico_Click(btnCadastrarCentroGastoServico, System.EventArgs.Empty)
                        Case "cboContaContabilServico" : Call btnCadastrarContaContabilServico_Click(btnCadastrarContaContabilServico, System.EventArgs.Empty)
                        Case "cboTransportadora" : Call btnCadastrarTransportadora_Click(btnCadastrarTransportadora, System.EventArgs.Empty)
                        Case "cboAgenteLogistico" : Call btnCadastrarAgenteLogistico_Click(btnCadastrarAgenteLogistico, System.EventArgs.Empty)
                        Case "cboIncoterms" : Call btnCadastrarIncoterms_Click(btnCadastrarIncoterms, System.EventArgs.Empty)
                        Case "cboInstrucaoEmbarque" : Call btnCadastrarInstrucaoEmbarque_Click(btnCadastrarInstrucaoEmbarque, System.EventArgs.Empty)
                        Case "cboModalidadeTransporte" : Call btnCadastrarModalidadeTransporte_Click(btnCadastrarModalidadeTransporte, System.EventArgs.Empty)
                        Case "cboCondicaoPagamento" : Call btnCadastrarCondicaoPagamento_Click(btnCadastrarCondicaoPagamento, System.EventArgs.Empty)
                        Case "txtObservacao" : Call btnCadastrarAutotexto_Click(btnCadastrarObservacao, System.EventArgs.Empty)


                    End Select

                Case Keys.F2
                    Select Case sender.Name
                        Case "cboProduto" : Call DadosProduto()
                    End Select

                Case Keys.F6
                    Select Case sender.Name
                        Case "cboProduto" : Call HistoricoProduto()
                        Case "cboFornecedor" : Call HistoricoParceiroNegocio()
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usr_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Configura UserControl
        ConfigurarUserControl()

    End Sub

    Private Sub AddMenuGrid(ByVal oControl As Control)

        Try

            If TypeOf (oControl) Is GridEX Then

                Dim oGrid As GridEX = oControl
                oGrid.DynamicFiltering = True
                oGrid.FilterMode = FilterMode.Automatic

                ConfigurarBuiltInTextsGrid(oGrid)

                Dim oUICommandManager As New Janus.Windows.UI.CommandBars.UICommandManager
                Dim oUIContextMenu As New Janus.Windows.UI.CommandBars.UIContextMenu
                Dim oUICommandCopiar As New Janus.Windows.UI.CommandBars.UICommand
                Dim oUICommandLimparFiltros As New Janus.Windows.UI.CommandBars.UICommand
                Dim oUICommandAdicionarProduto As New Janus.Windows.UI.CommandBars.UICommand
                Dim oUICommandExcluirLinha As New Janus.Windows.UI.CommandBars.UICommand
                Dim oUICommandRemoverOrdenacao As New Janus.Windows.UI.CommandBars.UICommand
                Dim oUICommandConfigurarGrid As New Janus.Windows.UI.CommandBars.UICommand
                Dim oUICommandExportarExcel As New Janus.Windows.UI.CommandBars.UICommand
                oUICommandCopiar.Text = "Copiar Conteúdo da Célula" : oUICommandCopiar.Key = "copiar"
                oUICommandLimparFiltros.Text = "Limpar Filtros da Listagem" : oUICommandLimparFiltros.Key = "limpar_filtros"
                oUICommandAdicionarProduto.Text = IIf(oControl.Name = "grdOrcamentoPedidoCompraProduto", "Adicionar Produto", "Adicionar Serviço") : oUICommandAdicionarProduto.Key = "adicionar_produto"
                oUICommandExcluirLinha.Text = "Excluir Linha" : oUICommandExcluirLinha.Key = "excluir_linha"
                oUICommandRemoverOrdenacao.Text = "Remover Ordenação" : oUICommandRemoverOrdenacao.Key = "remover_ordenacao"
                oUICommandConfigurarGrid.Text = "Configurar Listagem" : oUICommandConfigurarGrid.Key = "configurar_grid"
                oUICommandExportarExcel.Text = "Exportar para Excel" : oUICommandExportarExcel.Key = "exportar_excel"

                oUICommandManager.Commands.Add(oUICommandCopiar)
                oUICommandManager.Commands.Add(oUICommandLimparFiltros)
                oUICommandManager.Commands.Add(oUICommandAdicionarProduto)
                oUICommandManager.Commands.Add(oUICommandExcluirLinha)
                oUICommandManager.Commands.Add(oUICommandRemoverOrdenacao)
                oUICommandManager.Commands.Add(oUICommandConfigurarGrid)
                oUICommandManager.Commands.Add(oUICommandExportarExcel)

                oUIContextMenu.Commands.Add(oUICommandCopiar)
                oUIContextMenu.Commands.Add(oUICommandLimparFiltros)
                oUIContextMenu.Commands.Add(oUICommandAdicionarProduto)
                oUIContextMenu.Commands.Add(oUICommandExcluirLinha)
                oUIContextMenu.Commands.Add(oUICommandRemoverOrdenacao)
                oUIContextMenu.Commands.Add(oUICommandConfigurarGrid)
                oUIContextMenu.Commands.Add(oUICommandExportarExcel)
                oUICommandManager.SetContextMenu(oControl, oUIContextMenu)

                AddCommandClick(oUICommandCopiar, New DelegateCommandClick(AddressOf Button_CommandClick_PedidoCompra), oControl)
                AddCommandClick(oUICommandLimparFiltros, New DelegateCommandClick(AddressOf Button_CommandClick_PedidoCompra), oControl)
                AddCommandClick(oUICommandAdicionarProduto, New DelegateCommandClick(AddressOf Button_CommandClick_PedidoCompra), oControl)
                AddCommandClick(oUICommandExcluirLinha, New DelegateCommandClick(AddressOf Button_CommandClick_PedidoCompra), oControl)
                AddCommandClick(oUICommandRemoverOrdenacao, New DelegateCommandClick(AddressOf Button_CommandClick_PedidoCompra), oControl)
                AddCommandClick(oUICommandConfigurarGrid, New DelegateCommandClick(AddressOf Button_CommandClick_PedidoCompra), oControl)
                AddCommandClick(oUICommandExportarExcel, New DelegateCommandClick(AddressOf Button_CommandClick_PedidoCompra), oControl)
                AddMouseClick(oControl, New DelegateMouseClick(AddressOf Grid_MouseClick))

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Button_CommandClick_PedidoCompra(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs)

        Try

            'Váriavel
            Dim oUICommand As Janus.Windows.UI.CommandBars.UICommand = sender

            'Verifica o Tipo de Controle
            Select Case oUICommand.Key

                Case "limpar"

                    Dim oGrid As GridEX = sender.Tag
                    oGrid.CurrentColumn.CellStyle.BackColor = Nothing

                    'Limpa Controles
                    Dim oControl As Control = oGrid.Parent
                    While Not TypeOf (oControl) Is UserControl And Not TypeOf (oControl) Is Form
                        oControl = oControl.Parent
                    End While

                    'Atualiza Registro
                    Call UpdateConfiguraGridCor(oGrid.Name, oControl.Tag.ToString.Replace("FILTRAR", ""), oGrid.CurrentColumn.Key, -1, -1, -1)

                Case "limpar_filtros"

                    Dim oGrid As GridEX = sender.tag
                    oGrid.Row = -2
                    oGrid.RootTable.RemoveFilter()
                    oGrid.Refresh()

                Case "remover_ordenacao"
                    Dim oGrid As GridEX = sender.tag
                    oGrid.RootTable.SortKeys.Clear()

                Case "adicionar_produto"

                    If VerificaStatus() = False Then Exit Sub

                    If sender.tag.name = grdOrcamentoPedidoCompraProduto.Name Then
                        AdicionarProduto()
                    Else
                        AdicionarServico()
                    End If

                Case "excluir_linha"

                    Dim oGrid As GridEX = sender.tag

                    If VerificaStatusItem(oGrid) = False Then Exit Sub
                    If MsgBox("Deseja excluir permanentemente este registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Validação") <> MsgBoxResult.Yes Then Exit Sub

                    oClsCmpPedido.DeleteItemGrid(btnSalvar.Tag, oGrid.GetValue("codigo_pedido_item"))
                    oGrid.CurrentRow.Delete()
                    CalcularTotais()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                Case "copiar"

                    Dim oGrid As GridEX = sender.Tag

                    If IsNothing(oGrid.CurrentRow.Cells(oGrid.CurrentColumn.Key)) = False Then
                        Clipboard.SetDataObject(oGrid.CurrentRow.Cells(oGrid.CurrentColumn.Key).Text)
                    End If

                Case "configurar_grid"

                    Dim oForm As New frmCfgGrid
                    Dim oGrid As GridEX = sender.Tag

                    'Seta Parametros
                    oForm.Grid = oGrid
                    oForm.NomeFormulario = iFormulario
                    oForm.ShowDialog(Me)

                    'Configura Grid
                    ConfiguraGrid(oGrid, iFormulario)

                Case "exportar_excel"

                    Dim oGrid As GridEX = sender.tag

                    'Exporta Grid para Excel
                    ExportExcel(oGrid)

            End Select

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Grid_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs)

        Try

            If e.Button = MouseButtons.Right Then

                Dim oGrid As GridEX = sender

                oGrid.CurrentColumn = oGrid.ColumnFromPoint(e.X, e.Y)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: PEDIDO COMPRA :::"

    Private Sub txtPorcentagemAdiantamento_TextChanged(sender As Object, e As EventArgs) Handles txtPorcentagemAdiantamento.ValueChanged

        Try

            txtValorAdiantamento.Value = txtPorcentagemAdiantamento.Value * txtValorFinalPedido.Value

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnBaixarPedido_Click(sender As Object, e As EventArgs)
        Try

            'Deleta Registros
            Call BaixarPedidoCompra()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
    Private Sub btnImportarExcel_Click_1(sender As Object, e As EventArgs)
        Try

            'Váriaveis Locais
            Dim oForm As New frmCmpPedidoImportarExcel
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            If oForm.Numeros <> "" Then
                MsgBox("Foram gerados os pedidos: " & oForm.Numeros)
            End If
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = iFormulario
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, iFormulario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
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

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnEditarGrid_Click(sender As Object, e As EventArgs)

        Try

            'Váriaveis Locais
            Dim sCampo(0) As String

            'Carrega Valores
            sCampo(0) = "referencia"

            'Habilita Grid
            Call EditarGrid(grdListagem, _
                            sCampo, _
                            IIf(grdListagem.Tag.ToString = "E", False, True))

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarItemFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarItemFiltro.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = -1
            sItemCompraFind = "S"
            oComboBoxFind = cboItemFiltro

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboItemFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnProcurarFornecedorFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarFornecedorFiltro.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.cliente
            oComboBoxFind = cboFornecedorFiltro

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboFornecedorFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarFornecedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarFornecedor.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.fornecedor
            oComboBoxFind = cboFornecedor

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboFornecedor.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnProcurarAutotexto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarObservacao.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindAutotexto"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Autotexto"

            'Seta Parametros
            Select Case sender.Name
                Case "btnProcurarObservacao" : iTipoAutoTextoFind = TipoAutotexto.ObservacaoCompra : oEditBoxFind = txtObservacao
            End Select

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            Select Case sender.Name
                Case "btnProcurarObservacaoCompra" : txtObservacao.Focus()
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCadastrarFornecedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarFornecedor.Click

        Try

            'Carrega o form de parceiro de negócio
            LoadUsrControlForm(Me, "usrCadParceiroNegocio")

            'Carrega Combo            
            Call LoadCombo(cboFornecedor, "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa)

            'Seta Focu
            cboFornecedor.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarTransportadora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarTransportadora.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadTransportadora")

            'Carrega Combo            
            LoadCombo(cboTransportadora, "sp_select_combo_cadastro_basico_transportadora " & goUsuario.iEmpresa)

            'Seta Focu
            cboTransportadora.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarAutotexto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarObservacao.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadAutotexto")

            'Seta Focu
            txtObservacao.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarAgenteLogistico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarAgenteLogistico.Click

        Try

            'Carrega o form de parceiro de negócio
            LoadUsrControlForm(Me, "usrCadParceiroNegocio")

            'Carrega Combo            
            LoadCombo(cboAgenteLogistico, "sp_select_combo_cadastro_basico_agente_logistico " & goUsuario.iEmpresa)

            'Seta Focu
            cboAgenteLogistico.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarModalidadeTransporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarModalidadeTransporte.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadModalidadeTransporte")

            'Carrega Combo            
            LoadCombo(cboModalidadeTransporte, "sp_select_combo_cadastro_basico_modalidade_transporte " & goUsuario.iEmpresa)

            'Seta Focu
            cboModalidadeTransporte.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarInstrucaoEmbarque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarInstrucaoEmbarque.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadInstrucaoEmbarque")

            'Carrega Combo            
            LoadCombo(cboInstrucaoEmbarque, "sp_select_combo_cadastro_basico_instrucao_embarque " & goUsuario.iEmpresa)

            'Seta Focu
            cboInstrucaoEmbarque.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarIncoterms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarIncoterms.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadIncoterms")

            'Carrega Combo            
            LoadCombo(cboIncoterms, "sp_select_combo_cadastro_basico_incoterms " & goUsuario.iEmpresa)

            'Seta Focu
            cboIncoterms.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarCondicaoPagamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCondicaoPagamento.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCondicaoPagamento")

            'Carrega Combo            
            LoadCombo(cboCondicaoPagamento, "sp_select_combo_cadastro_basico_condicao_pagamento " & goUsuario.iEmpresa)

            'Seta Focu
            cboCondicaoPagamento.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Deleta Registros
            DeletePedidoCompra()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Dados da Grid
            Call LoadGridPedidoCompra()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            'Prepara o Formulário para Inserção de um Novo Registro
            Call NovoPedidoCompra()

            'Alterna Aba        
            tabMain.TabPages.Remove(pagListagem)
            tabMain.TabPages.Add(pagDados)
            tabMain.SelectedTab = pagDados

            'Configura Valor Default
            Call ConfigureValorDefault(Me)

            'Seta Focu
            dtpDataPedido.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click

        Try

            'Prepara o Formulário para Inserção de um Novo Registro
            Call NovoPedidoCompra()

            'Limpa Controle Financeiro
            Call NovoFinanceiro()

            'Configura Valor Default
            Call ConfigureValorDefault(Me)

            'Seta Focu        
            dtpDataPedido.Focus()

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

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call SalvarPedidoCompra()

                'Seta Controle
                btnImprimir.Enabled = VerificaDireito(iFormulario, gcPrint)

                'Executa Integração
                Call Integracao()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Try

            'Imprime Pedido de Compra
            Call ImprimirPedidoCompra(oClsCmpPedido.CodigoPedido,
                                      False,
                                      txtNumeroPedido.Text,
                                      cboFornecedor.Text)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnImpressaoDireta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

            'Váriaveis - Formulário
            Dim oForm As New frmIntEscolherImpressora
            'Seta Tamanho / Localização do Formulário
            'oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            Dim sNomeRelatorio As String = ""
            Dim rptCrystal As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim psi As New ProcessStartInfo

            rptCrystal = New CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptCrystal.Load(goCrystalReport.sPath & "CMP000000001.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)
            rptCrystal.PrintOptions.PrinterName = oForm.Impressora
            rptCrystal.SetParameterValue("usuario", goUsuario.sNome)
            rptCrystal.SetParameterValue("@codigo_pedido", oClsCmpPedido.CodigoPedido)
            rptCrystal.SetParameterValue("@codigo_empresa", goUsuario.iEmpresa)

            'Setando a conexão
            rptCrystal.DataSourceConnections.Item(0).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)

            'Enviando para impressora
            rptCrystal.PrintToPrinter(1, False, 1, 10)
            'Fechando o crystal
            rptCrystal.Close()

            For Each oRow As GridEXRow In grdArquivo.GetRows
                If IIf(IsDBNull(oRow.Cells.Item("path").Value), "", oRow.Cells.Item("path").Value) <> "" Then
                    'Verificando se existe o arquivo
                    If IO.File.Exists(oRow.Cells.Item("path").Value) Then
                        psi.UseShellExecute = True
                        psi.Verb = "print"
                        psi.Arguments = Shell(String.Format("rundll32 printui.dll,PrintUIEntry /y /n ""{0}""", oForm.Impressora))
                        psi.WindowStyle = ProcessWindowStyle.Hidden
                        psi.FileName = oRow.Cells.Item("path").Value
                        Process.Start(psi)
                    End If
                End If
            Next


        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        Try

            'Verifica se não foi gerado o Pedido de Compra
            If txtNumeroPedido.Text = "" And grdOrcamentoPedidoCompraProduto.GetDataRows.Count > 0 Then
                'Verifica se o usuário deseja sair do Pedido de Compra
                If MsgBox("Os Dados do Pedido de Compra serão perdidos. Deseja continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If

            'Carrega Grid
            Call LoadGridPedidoCompra()


            'Alterna Aba        
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagListagem)
            tabMain.SelectedTab = pagListagem




            'Seta Focu
            txtNumeroPedidoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNecessidadeEmail_Click(sender As Object, e As EventArgs) Handles btnNecessidadeEmail.Click

        Try

            'Grava Log
            oClsCmpPedido.NaoEmail(grdListagem.CurrentRow.Cells("codigo_pedido").Value)

            'Seta Grid
            Call UpdateRegistroGrid(grdListagem, "(codigo_pedido = " & grdListagem.CurrentRow.Cells("codigo_pedido").Value & ")", "pedido_enviado", True)
            Call UpdateRegistroGrid(grdListagem, "(codigo_pedido = " & grdListagem.CurrentRow.Cells("codigo_pedido").Value & ")", "follow_up_executado", True)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboMoeda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMoeda.SelectedIndexChanged

        Try

            'Limpa Controles
            txtFatorCambial.Value = 1
            txtFatorCambial.ReadOnly = True
            txtFatorCambial.TabStop = False
            txtFatorCambial.BackColor = Color.WhiteSmoke
            'cboMoeda.SelectedValue = CInt(Moeda.Real)


            'Verifica se foi Selecionado algum Item
            If cboMoeda.SelectedIndex <> -1 Then
                'cboMoeda.SelectedValue = CInt(Moeda.Real)
                If cboMoeda.SelectedValue <> CInt(Moeda.Real) Then
                    txtFatorCambial.Value = 0
                    txtFatorCambial.ReadOnly = False
                    txtFatorCambial.TabStop = True
                    txtFatorCambial.BackColor = Color.White
                End If
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboFornecedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFornecedor.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum Registro
            If cboFornecedor.SelectedIndex = -1 Then

                'Limpa Controles
                cboContato.DataSource = Nothing
                cboContato.Text = ""

                'Limpa - Desabilita Controles
                cboAgenteLogistico.Text = "" : cboAgenteLogistico.Enabled = False : btnCadastrarAgenteLogistico.Enabled = False
                cboModalidadeTransporte.Text = "" : cboModalidadeTransporte.Enabled = False : btnCadastrarModalidadeTransporte.Enabled = False
                cboInstrucaoEmbarque.Text = "" : cboInstrucaoEmbarque.Enabled = False : btnCadastrarInstrucaoEmbarque.Enabled = False
                cboIncoterms.Text = "" : cboIncoterms.Enabled = False : btnCadastrarIncoterms.Enabled = False

            Else

                'Carrega Combo - Contato
                Call LoadCombo(cboContato, "sp_select_combo_cadastro_basico_parceiro_negocio_contato " & goUsuario.iEmpresa & " , " & cboFornecedor.SelectedValue)

                'Verifica UF do Fornecedor
                Dim sUF As String = LoadDescricao("sp_select_cadastro_basico_parceiro_negocio_uf " & cboFornecedor.SelectedValue & ", " & goUsuario.iEmpresa)

                'Verifica o Tipo de UF
                If sUF <> "EX" Then

                    'Limpa - Desabilita Controles
                    cboAgenteLogistico.Text = "" : cboAgenteLogistico.Enabled = False : btnCadastrarAgenteLogistico.Enabled = False
                    cboModalidadeTransporte.Text = "" : cboModalidadeTransporte.Enabled = False : btnCadastrarModalidadeTransporte.Enabled = False
                    cboInstrucaoEmbarque.Text = "" : cboInstrucaoEmbarque.Enabled = False : btnCadastrarInstrucaoEmbarque.Enabled = False
                    cboIncoterms.Text = "" : cboIncoterms.Enabled = False : btnCadastrarIncoterms.Enabled = False

                Else

                    'Habilita Controles
                    cboAgenteLogistico.Enabled = True : btnCadastrarAgenteLogistico.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcInsert)
                    cboModalidadeTransporte.Enabled = True : btnCadastrarModalidadeTransporte.Enabled = VerificaDireito(Formulario.CadastroBasicoModalidadeTransporte, gcInsert)
                    cboInstrucaoEmbarque.Enabled = True : btnCadastrarInstrucaoEmbarque.Enabled = VerificaDireito(Formulario.CadastroBasicoInstrucaoEmbarque, gcInsert)
                    cboIncoterms.Enabled = True : btnCadastrarIncoterms.Enabled = VerificaDireito(Formulario.CadastroBasicoIncoterms, gcInsert)

                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Linha é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "baixar_pedido_compra" : BaixarPedidoCompra()
                Case "editar" : EditarPedidoCompra(grdListagem.CurrentRow.Cells.Item("codigo_pedido").Value)
                Case "duplicar" : DuplicarPedidoCompra()
                Case "imprimir" : ImprimirPedidoCompra(grdListagem.CurrentRow.Cells.Item("codigo_pedido").Value,
                                                       grdListagem.CurrentRow.Cells.Item("reaprovar").Value,
                                                       grdListagem.CurrentRow.Cells.Item("numero_pedido").Value,
                                                       grdListagem.CurrentRow.Cells.Item("parceiro_negocio").Value)
                'Case "email" : EmailPedidoCompra(grdListagem.CurrentRow.Cells.Item("codigo_pedido").Value, _
                '     grdListagem.CurrentRow.Cells.Item("reaprovar").Value)          
                'Case "follow_up" : FollowUpPedidoCompra()
                Case "editar_parceiro_negocio" : EditarParceiroNegocio()
                Case "ativar" : AtivarItemPedidoCompra()
                Case "historico" : HistoricoPedido()
                Case "historico_item" : HistoricoItemPedidoCompra()
                Case "cancelar" : CancelarItemPedidoCompra()
                'Case "atualizar_pedido" : AtualizarPedido()
                Case "cancelar_pedido" : CancelarPedido()
                Case "aprovar" : Call Aprovar()
                Case "reprovar" : Call Reprovar()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdListagem_MouseClick(sender As Object, e As MouseEventArgs) Handles grdListagem.MouseClick

        Try

            'Oculta Controle
            cmsPedido.Visible = False

            Select Case e.Button

                Case Windows.Forms.MouseButtons.Right

                    'Verifica se a linha pressionada é válida
                    If IsNothing(grdListagem.ColumnFromPoint(e.X, e.Y)) Then Exit Sub

                    'Verifica se foi pressionado a Coluna - Follow Up
                    If grdListagem.ColumnFromPoint(e.X, e.Y).Key = "email" Then

                        'Obtém possição
                        grdListagem.RowPositionFromPoint(e.X, e.Y)

                        'Verifica se o Pedido foi Enviado por E-mail
                        If grdListagem.CurrentRow.Cells("pedido_enviado").Value = False Then
                            btnNecessidadeEmail.Text = "Não é necessário enviar o Pedido de Compra: " & grdListagem.CurrentRow.Cells("numero_pedido").Value & " por e-mail"
                            cmsPedido.Show()
                        End If

                    End If

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
                                     iFormulario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     iFormulario, _
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
                                          iFormulario, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub txtDescontoGeral_LostFocus(sender As Object, e As EventArgs) Handles txtDescontoGeral.LostFocus, txtValorTotalPedido.LostFocus, txtValorDescontoPedido.LostFocus

        Try

            'Váriaveis Locais
            Dim dValor As Double

            dValor = txtValorTotalPedido.Value
            dValor -= txtValorDescontoPedido.Value
            dValor += txtValorImpostosServicoPedido.Value
            dValor += txtValorImpostosProdutoPedido.Value

            txtDescontoGeralPercentual.Value = txtDescontoGeral.Value / dValor

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub txtDescontoGeralPercentual_LostFocus(sender As Object, e As EventArgs) Handles txtDescontoGeralPercentual.LostFocus

        Try

            'Váriaveis Locais
            Dim dValor As Double

            dValor = txtValorTotalPedido.Value
            dValor -= txtValorDescontoPedido.Value
            dValor += txtValorImpostosServicoPedido.Value
            dValor += txtValorImpostosProdutoPedido.Value

            txtDescontoGeral.Value = txtDescontoGeralPercentual.Value * dValor

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub txtAcrescimoGeral_LostFocus(sender As Object, e As EventArgs) Handles txtAcrescimoGeral.LostFocus

        Try

            'Váriaveis Locais
            Dim dValor As Double

            dValor = txtValorTotalPedido.Value
            dValor -= txtValorDescontoPedido.Value
            dValor += txtValorImpostosServicoPedido.Value
            dValor += txtValorImpostosProdutoPedido.Value

            txtAcrescimoGeralPercentual.Value = txtAcrescimoGeral.Value / dValor

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub txtAcrescimoGeralPercentual_LostFocus(sender As Object, e As EventArgs) Handles txtAcrescimoGeralPercentual.LostFocus

        Try

            'Váriaveis Locais
            Dim dValor As Double

            dValor = txtValorTotalPedido.Value
            dValor -= txtValorDescontoPedido.Value
            dValor += txtValorImpostosServicoPedido.Value
            dValor += txtValorImpostosProdutoPedido.Value

            txtAcrescimoGeral.Value = txtAcrescimoGeralPercentual.Value * dValor

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CalculaValorFinalPedido() Handles txtValorTotalPedido.ValueChanged, _
                                                  txtValorDescontoPedido.ValueChanged, _
                                                  txtValorImpostosServicoPedido.ValueChanged, _
                                                  txtValorImpostosProdutoPedido.ValueChanged, _
                                                  txtDescontoGeral.ValueChanged, _
                                                  txtAcrescimoGeral.ValueChanged, _
                                                  txtValorFretePedido.ValueChanged, _
                                                  cboModalidadeFrete.SelectedIndexChanged

        Try

            'Váriaveis Locais
            Dim dValor As Double

            'Cálcula Valor Total
            dValor = txtValorTotalPedido.Value
            dValor -= txtValorDescontoPedido.Value
            dValor -= txtValorImpostosServicoPedido.Value
            dValor += txtValorImpostosProdutoPedido.Value
            'dValor += IIf(cboModalidadeFrete.SelectedValue = CInt(ModalidadeFrete.Emitente), txtValorFretePedido.Value, 0)
            dValor -= txtDescontoGeral.Value
            dValor += txtAcrescimoGeral.Value
            dValor += txtValorFretePedido.Value

            'Seta Valor Final
            txtValorFinalPedido.Value = dValor

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnAlterarData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterarData.Click

        Try

            If VerificaSelecaoRow(grdOrcamentoPedidoCompraProduto) = True Then
                Dim sData As String
                sData = InputBox("Digite a nova data de entrega:")

                If IsDate(sData) Then
                    For Each oRow In grdOrcamentoPedidoCompraProduto.GetCheckedRows
                        oClsCmpPedido.UpdateDataEntrega(oRow.Cells.Item("codigo_pedido_item").Value, _
                                                        btnSalvar.Tag, _
                                                        sData)
                    Next
                    frmMain.Informacao("Registro alterado com sucesso!", Color.Blue)
                    NovoProduto()
                Else
                    frmMain.Informacao("'" & sData & "' não é uma data válida!", Color.Red)
                End If
            Else
                frmMain.Informacao("Primeiramente selecione um ou mais registros!", Color.Red)
            End If

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnAlterarDataContratual_Click(sender As Object, e As EventArgs) Handles btnAlterarDataContratual.Click

        Try

            If VerificaSelecaoRow(grdOrcamentoPedidoCompraProduto) = True Then

                Dim sData As String
                sData = InputBox("Digite a nova Data Contratual:")

                If IsDate(sData) Then

                    For Each oRow In grdOrcamentoPedidoCompraProduto.GetCheckedRows

                        oClsCmpPedido.UpdateDataContratual(oRow.Cells.Item("codigo_pedido_item").Value, _
                                                        btnSalvar.Tag, _
                                                        sData)

                    Next

                    NovoProduto()
                    LoadGridProduto()

                    frmMain.Informacao("Registro alterado com sucesso!", Color.Blue)

                Else

                    frmMain.Informacao("'" & sData & "' não é uma data válida!", Color.Red)

                End If

            Else

                frmMain.Informacao("Primeiramente selecione um ou mais registros!", Color.Red)

            End If

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnImprimirMultiplos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirMultiplos.Click

        Try

            ImprimirPDF()

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdListagem.CellUpdated

        Try

            Cursor.Current = Cursors.WaitCursor

            Select Case e.Column.Key

                Case "triangulacao"

                    oClsCmpPedido.UpdateTriangulacao(grdListagem.CurrentRow.Cells("codigo_pedido").Value, _
                                                          grdListagem.CurrentRow.Cells("triangulacao").Value)
                    LoadGridPedidoCompra()

                Case "referencia"

                    oClsCmpPedido.UpdateReferencia(grdListagem.CurrentRow.Cells("codigo_cotacao").Value, _
                                                   grdListagem.CurrentRow.Cells("codigo_cotacao_item").Value, _
                                                   IIf(IsDBNull(grdListagem.CurrentRow.Cells("referencia").Value), "", grdListagem.CurrentRow.Cells("referencia").Value))

                    LoadGridPedidoCompra()

                    frmMain.Informacao(Mensagem.RegistroAlterado)

            End Select

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ITEM :::"

#Region "::: PRODUTO :::"

    Private Sub grdOrcamentoPedidoCompraProduto_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdOrcamentoPedidoCompraProduto.CellUpdated

        Try

            If VerificaStatusItem(sender) = False Then
                LoadGridProduto()
                Exit Sub
            End If

            AtualizarProduto()
            LoadGridProduto()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnImportarItemCotacao_Click(sender As Object, e As EventArgs) Handles btnImportarItemCotacao.Click

        Try

            ImportarItemCotacao()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnAgruparGridProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridProduto.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdOrcamentoPedidoCompraProduto.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdOrcamentoPedidoCompraProduto.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdOrcamentoPedidoCompraProduto.GroupByBoxVisible = True
                grdOrcamentoPedidoCompraProduto.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridProduto.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdOrcamentoPedidoCompraProduto
            oForm.NomeFormulario = iFormulario
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdOrcamentoPedidoCompraProduto, iFormulario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridProduto.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdOrcamentoPedidoCompraProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarProduto.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = LoadDescricao("sp_select_configuracao_interacti_texto " & goUsuario.iEmpresa & ",'formulario_find_produto_compra'")
            oForm.UsrControl = IIf(oForm.UsrControl = "", "usrFindItem", oForm.UsrControl)
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros            
            iCodigoTipoItemFind = TipoItem.produto
            sItemVendaFind = ""
            sItemAtivoFixoFind = ""
            sItemEstoqueFind = ""
            sItemCompraFind = "S"
            sItemProducaoFind = ""
            bInserirProdutoFind = True
            sTipoFind = "COMPRAS"
            oComboBoxFind = cboProduto

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboProduto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarCentroGastoProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCentroGastoProduto.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindCentroGasto"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Centro de Gasto"

            'Seta Váriaveis
            lCodigoItemFind = IIf(cboProduto.SelectedIndex = -1, -1, cboProduto.SelectedValue)
            oComboBoxFind = cboCentroGastoProduto

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCentroGastoProduto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnProcurarContaContabilProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarContaContabilProduto.Click

        Try
            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindPlanoContas"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Conta Contábil"

            'Seta Váriaveis
            lCodigoItemFind = IIf(cboProduto.SelectedIndex = -1, -1, cboProduto.SelectedValue)
            'Seta Parametros
            oComboBoxFind = cboContaContabilProduto

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboContaContabilProduto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCadastrarProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarProduto.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadProduto")

            'Carrega Combo            
            Call LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, 1, " & TipoItem.produto)

            'Seta Focu
            cboProduto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarUnidadeMedidaProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarUnidadeMedidaProduto.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadUnidadeMedida")

            'Carrega Combo            
            Call LoadCombo(cboUnidadeMedidaProduto, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)

            'Seta Focu
            cboUnidadeMedidaProduto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarCentroGastoProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCentroGastoProduto.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCentroGasto")

            'Carrega Combo            
            If cboProduto.SelectedIndex > -1 Then
                Call LoadCombo(cboCentroGastoServico, "sp_select_combo_cadastro_basico_centro_custo_item " & goUsuario.iEmpresa & ", " & cboProduto.SelectedValue, True)
            End If

            'Seta Focu
            cboCentroGastoProduto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarContaContabilProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarContaContabilProduto.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadPlanoContas")

            'Carrega Combo            
            If cboProduto.SelectedIndex > -1 Then
                Call LoadCombo(cboContaContabilServico, "sp_select_combo_cadastro_basico_conta_contabil_item " & goUsuario.iEmpresa & ", " & cboProduto.SelectedValue, True)
            End If

            'Seta Focu
            cboContaContabilProduto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnDesmembrarPrevisaoEntregaProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesmembrarPrevisaoEntregaProduto.Click

        Try

            'Limpa o Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Preenchido o Campo - Quantidade
            If ValidaCampo(txtQuantidadeProduto, lblQuantidadeProduto, True) = False Then
                Exit Sub
            End If

            'Desmembrar Entrega
            Call DesmembrarEntregaItem(dtpPrevisaoEntregaProduto, _
                                       cboProduto.Text & " - " & txtDescricaoProduto.Text.Trim, _
                                       txtQuantidadeProduto.Value)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirProduto.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Campo - Fornecedor
            If ValidaCampo(cboFornecedor, lblFornecedor) = False Then
                Exit Sub
            End If

            'Salva Pedido
            Call SalvarPedidoCompra()

            'Valida Dados do Item
            If ValidacaoProduto() = True Then

                'Salva Dados do Registro
                Call InsertProduto()
                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoProduto()
                'Carrega Grid
                Call LoadGridProduto()
                'Calcula Totais
                Call CalcularTotais()
                'Salva Pedido
                Call SalvarPedidoCompra()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirProduto.Click

        Try

            If ValidaCotacao() = True Then

                'Deleta Registros
                Call DeleteProduto()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Function ValidaCotacao() As Boolean

        Try

            'Seta Retorno da Função
            ValidaCotacao = False

            For Each oRow In grdOrcamentoPedidoCompraProduto.GetCheckedRows
                If oClsCmpPedido.ValidaCotacao(grdOrcamentoPedidoCompraProduto.CurrentRow.Cells.Item("codigo_cotacao").Value) = False Then
                    MsgBox("Não é possivel excluir o item pois a Cotação " + oClsCmpPedido.Cotacao + " está vinculada a ele", vbExclamation, "Validação")
                    Exit Function
                End If

            Next

            'Seta Retorno da Função
            ValidaCotacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub cboProduto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProduto.SelectedIndexChanged

        Try

            'Verifica se Foi Selecionado algum Registro
            If cboProduto.SelectedIndex = -1 Then

                'Limpa Controles
                txtDescricaoProduto.Text = ""
                cboUnidadeMedidaProduto.SelectedIndex = -1

            Else

                'Carrega Dados do Item
                oClsCmpPedido.LoadDadosProduto(cboProduto, _
                                               txtDescricaoProduto, _
                                               cboUnidadeMedidaProduto, _
                                               txtPrecoCompraProduto)

                'If goDatabase.sInitialCatalog = "INTERACTI_NORSUL_PRD" Then
                '    If ((txtDescricaoProduto.Text <> sDescricao) And (sCodigoProdutoAnterior = cboProduto.Text)) Then
                '        txtDescricaoProduto.Text = txtDescricaoProduto.Text
                '    Else
                '        txtDescricaoProduto.Text = sDescricao
                '    End If
                'Else
                '    txtDescricaoProduto.Text = sDescricao
                'End If

                'Seta Preço de Compra
                If chkPrecoCompra.Visible = True And chkPrecoCompra.Checked = False Then
                    txtPrecoCompraProduto.Value = 0
                End If

                'Carrega Combo
                Call LoadCombo(cboCentroGastoProduto, "sp_select_combo_cadastro_basico_centro_custo_item " & goUsuario.iEmpresa & ", " & cboProduto.SelectedValue, True)
                Call LoadCombo(cboContaContabilProduto, "sp_select_combo_cadastro_basico_conta_contabil_item " & goUsuario.iEmpresa & ", " & cboProduto.SelectedValue, True)

                'Calcula Valor Total
                Call CalculaValorTotal()

            End If

            sCodigoProdutoAnterior = cboProduto.Text

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdOrcamentoPedidoCompraProduto.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdOrcamentoPedidoCompraProduto.CurrentColumn) Then Exit Sub

            Select Case grdOrcamentoPedidoCompraProduto.CurrentColumn.Key

                Case "editar" : Call EditarProduto()
                Case "visualizar_ordem_producao" : Call EditarOrdemProducao(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdOrcamentoPedidoCompraProduto.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdOrcamentoPedidoCompraProduto, _
                                     iFormulario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdOrcamentoPedidoCompraProduto.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdOrcamentoPedidoCompraProduto.Name, _
                                     iFormulario, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdOrcamentoPedidoCompraProduto.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdOrcamentoPedidoCompraProduto.Name, _
                                          iFormulario, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CalculoValorUnitarioDesconto(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrecoCompraProduto.ValueChanged, _
                                                                                                         txtDescontoValorProduto.LostFocus, _
                                                                                                         txtDescontoPercentualProduto.LostFocus, _
                                                                                                         txtValorUnitarioDescontoProduto.LostFocus

        Try
            If txtPrecoCompraProduto.Value = 0 Then
                txtPrecoCompraProduto.Value = txtValorUnitarioDescontoProduto.Value
            End If
            Select Case sender.Name



                Case "txtDescontoPercentualProduto"

                    If IsNumeric(txtDescontoPercentualProduto.Tag) Then
                        If Round(txtDescontoPercentualProduto.Tag, 5) = txtDescontoPercentualProduto.Value Then
                            txtValorUnitarioDescontoProduto.Value = txtPrecoCompraProduto.Value - (txtDescontoPercentualProduto.Tag * txtPrecoCompraProduto.Value / 100.0)
                        Else
                            txtValorUnitarioDescontoProduto.Value = txtPrecoCompraProduto.Value - (txtDescontoPercentualProduto.Value * txtPrecoCompraProduto.Value / 100.0)
                        End If
                    Else
                        txtValorUnitarioDescontoProduto.Value = txtPrecoCompraProduto.Value - (txtDescontoPercentualProduto.Value * txtPrecoCompraProduto.Value / 100.0)
                    End If
                    txtDescontoValorProduto.Value = txtPrecoCompraProduto.Value - txtValorUnitarioDescontoProduto.Value

                Case "txtDescontoValorProduto"
                    txtValorUnitarioDescontoProduto.Value = txtPrecoCompraProduto.Value - txtDescontoValorProduto.Value
                    txtDescontoPercentualProduto.Value = IIf(txtPrecoCompraProduto.Value = 0, 0, (1 - txtValorUnitarioDescontoProduto.Value / txtPrecoCompraProduto.Value) * 100)

                Case "txtValorUnitarioDescontoProduto"
                    If txtValorUnitarioDescontoProduto.Value < 0 Then
                        txtValorUnitarioDescontoProduto.Value = 0
                    End If
                    If txtValorUnitarioDescontoProduto.Value < txtPrecoCompraProduto.Value Then
                        txtDescontoPercentualProduto.Value = (1 - txtValorUnitarioDescontoProduto.Value / txtPrecoCompraProduto.Value) * 100
                        txtDescontoPercentualProduto.Tag = (1 - txtValorUnitarioDescontoProduto.Value / txtPrecoCompraProduto.Value) * 100
                        txtDescontoValorProduto.Value = txtPrecoCompraProduto.Value - txtValorUnitarioDescontoProduto.Value
                    Else
                        txtDescontoPercentualProduto.Value = 0
                        txtDescontoValorProduto.Value = 0
                    End If

                Case "txtValorUnitarioProduto"
                    If txtValorUnitarioDescontoProduto.Value = 0 Then
                        txtValorUnitarioDescontoProduto.Value = txtPrecoCompraProduto.Value
                        txtDescontoPercentualProduto.Value = 0
                        txtDescontoValorProduto.Value = 0
                    ElseIf txtDescontoPercentualProduto.Value = 0 Then
                        txtValorUnitarioDescontoProduto.Value = txtPrecoCompraProduto.Value
                    End If

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CalculaValorTotal() Handles txtQuantidadeProduto.ValueChanged, _
                                            txtValorUnitarioDescontoProduto.ValueChanged

        Try

            'Calcula Valor Total
            txtValorTotalProduto.Value = txtQuantidadeProduto.Value * txtValorUnitarioDescontoProduto.Value

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CalculaValorTotalImpostos() Handles txtValorTotalProduto.ValueChanged, _
                                                    chkICMSEmbutido.CheckedChanged, _
                                                    txtAliquotaICMSProduto.ValueChanged, _
                                                    chkIPIEmbutido.CheckedChanged, _
                                                    txtAliquotaIPIProduto.ValueChanged, _
                                                    chkPISCOFINSEmbutido.CheckedChanged, _
                                                    txtAliquotaPISCOFINSProduto.ValueChanged

        Try

            Dim dValorUnitarioImposto As Double = 0
            Dim dQuantidade As Double = IIf(IsNumeric(txtQuantidadeProduto.Value), txtQuantidadeProduto.Value, 0)
            Dim dValorUnitario As Double = IIf(IsNumeric(txtValorUnitarioDescontoProduto.Value), txtValorUnitarioDescontoProduto.Value, 0)
            Dim dAliquotaICMS As Double = IIf(IsNumeric(txtAliquotaICMSProduto.Value), txtAliquotaICMSProduto.Value, 0) / 100.0
            Dim dAliquotaPISCOFINS As Double = IIf(IsNumeric(txtAliquotaPISCOFINSProduto.Value), txtAliquotaPISCOFINSProduto.Value, 0) / 100.0
            Dim dAliquotaIPI As Double = IIf(IsNumeric(txtAliquotaIPIProduto.Value), txtAliquotaIPIProduto.Value, 0) / 100.0

            'Calcula IPI
            If chkIPIEmbutido.Checked = True Then
                dValorUnitario = (dValorUnitario / (1 + dAliquotaIPI))
            End If

            'Calcula ICMS / PIS / COFINS
            If chkICMSEmbutido.Checked = True And chkPISCOFINSEmbutido.Checked = True Then
                dValorUnitario = dValorUnitario
            ElseIf chkICMSEmbutido.Checked = True And chkPISCOFINSEmbutido.Checked = False Then
                dValorUnitario = (dValorUnitario / (1 - (dAliquotaPISCOFINS)))
            ElseIf chkICMSEmbutido.Checked = False And chkPISCOFINSEmbutido.Checked = True Then
                dValorUnitario = (dValorUnitario / (1 - (dAliquotaICMS)))
            ElseIf chkICMSEmbutido.Checked = False And chkPISCOFINSEmbutido.Checked = False Then
                dValorUnitario = (dValorUnitario / (1 - (dAliquotaICMS + dAliquotaPISCOFINS)))
            End If

            'Seta Controles
            txtAliquotaICMSProduto.Tag = dValorUnitario * txtAliquotaICMSProduto.Value / 100
            txtAliquotaPISCOFINSProduto.Tag = dValorUnitario * txtAliquotaPISCOFINSProduto.Value / 100
            txtAliquotaIPIProduto.Tag = dValorUnitario * txtAliquotaIPIProduto.Value / 100

            'Seta Controle - Valor Total Imposto
            txtValorTotalImpostoProduto.Value = ((IIf(IsNumeric(txtValorUnitarioDescontoProduto.Value), txtValorUnitarioDescontoProduto.Value, 0) + IIf(chkICMSEmbutido.Checked = True, 0, txtAliquotaICMSProduto.Tag) + IIf(chkPISCOFINSEmbutido.Checked = True, 0, txtAliquotaPISCOFINSProduto.Tag) + IIf(chkIPIEmbutido.Checked = True, 0, txtAliquotaIPIProduto.Tag)) * dQuantidade)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: SERVIÇO :::"

    Private Sub grdOrcamentoPedidoCompraServico_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdOrcamentoPedidoCompraServico.CellUpdated

        Try

            If VerificaStatusItem(sender) = False Then
                LoadGridServico()
                Exit Sub
            End If

            AtualizarServico()
            LoadGridServico()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnAgruparGridServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridServico.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdOrcamentoPedidoCompraServico.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdOrcamentoPedidoCompraServico.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdOrcamentoPedidoCompraServico.GroupByBoxVisible = True
                grdOrcamentoPedidoCompraServico.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridServico.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdOrcamentoPedidoCompraServico
            oForm.NomeFormulario = iFormulario
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdOrcamentoPedidoCompraServico, iFormulario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridServico.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdOrcamentoPedidoCompraServico)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarServico.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = TipoItem.servico
            oComboBoxFind = cboServico

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboServico.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnProcurarCentroGastoServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCentroGastoServico.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindCentroGasto"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Centro de Gasto"

            'Seta Váriaveis
            lCodigoItemFind = IIf(cboServico.SelectedIndex = -1, -1, cboServico.SelectedValue)
            oComboBoxFind = cboCentroGastoServico

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCentroGastoServico.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnProcurarContaContabilServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarContaContabilServico.Click

        Try
            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindPlanoContas"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Conta Contábil"

            'Seta Váriaveis
            lCodigoItemFind = IIf(cboServico.SelectedIndex = -1, -1, cboServico.SelectedValue)
            'Seta Parametros
            oComboBoxFind = cboContaContabilServico

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboContaContabilServico.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCadastrarServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarServico.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadServico")

            'Carrega Combo            
            Call LoadCombo(cboServico, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.servico))

            'Seta Focu
            cboServico.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarUnidadeMedidaServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarUnidadeMedidaServico.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadUnidadeMedida")

            'Carrega Combo            
            Call LoadCombo(cboUnidadeMedidaServico, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)

            'Seta Focu
            cboUnidadeMedidaServico.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarCentroGastoServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCentroGastoServico.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCentroGasto")

            'Carrega Combo            
            If cboServico.SelectedIndex > -1 Then
                Call LoadCombo(cboCentroGastoServico, "sp_select_combo_cadastro_basico_centro_custo_item " & goUsuario.iEmpresa & ", " & cboServico.SelectedValue, True)
            End If

            'Seta Focu
            cboCentroGastoServico.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarContaContabilServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarContaContabilServico.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadPlanoContas")

            'Carrega Combo            
            If cboServico.SelectedIndex > -1 Then
                Call LoadCombo(cboContaContabilServico, "sp_select_combo_cadastro_basico_conta_contabil_item " & goUsuario.iEmpresa & ", " & cboServico.SelectedValue, True)
            End If

            'Seta Focu
            cboContaContabilServico.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnDesmembrarPrevisaoEntregaServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesmembrarPrevisaoEntregaServico.Click

        Try

            'Limpa o Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Preenchido o Campo - Quantidade
            If ValidaCampo(txtQuantidadeServico, lblQuantidadeServico, True) = False Then
                Exit Sub
            End If

            'Desmembrar Entrega
            Call DesmembrarEntregaItem(dtpPrevisaoEntregaServico, _
                                       cboServico.Text & " - " & txtDescricaoServico.Text.Trim, _
                                       txtQuantidadeServico.Value)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirServico.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Campo - Fornecedor
            If ValidaCampo(cboFornecedor, lblFornecedor) = False Then
                Exit Sub
            End If

            'Salva Pedido
            Call SalvarPedidoCompra()

            'Valida Dados do Serviço
            If ValidacaoServico() = True Then

                'Salva Dados do Registro
                Call InsertServico()
                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoServico()
                'Carrega Grid
                Call LoadGridServico()
                'Atualiza Totais
                Call CalcularTotais()
                'Salva Pedido
                Call SalvarPedidoCompra()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirServico.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Salva Dados do Registro
            Call DeleteServico()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboServico_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboServico.SelectedIndexChanged

        Try

            'Verifica se Foi Selecionado algum Registro
            If cboServico.SelectedIndex = -1 Then
                'Limpa Controle
                txtDescricaoServico.Text = ""
            Else
                'Carrega Controle
                txtDescricaoServico.Text = LoadDescricao("sp_select_cadastro_basico_descricao_item " & cboServico.SelectedValue & ", " & goUsuario.iEmpresa)

                'Carrega Combo
                Call LoadCombo(cboCentroGastoServico, "sp_select_combo_cadastro_basico_centro_custo_item " & goUsuario.iEmpresa & ", " & cboServico.SelectedValue, True)
                Call LoadCombo(cboContaContabilServico, "sp_select_combo_cadastro_basico_conta_contabil_item " & goUsuario.iEmpresa & ", " & cboServico.SelectedValue, True)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CalculaValorLiquido() Handles txtDescontoServico.LostFocus, _
                                              txtValorServico.LostFocus, _
                                              txtQuantidadeServico.LostFocus

        Try

            'Calcula Valor Total
            txtValorTotalServico.Value = (txtQuantidadeServico.Value * (txtValorServico.Value - txtDescontoServico.Value))

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdServico_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdOrcamentoPedidoCompraServico.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdOrcamentoPedidoCompraServico.CurrentColumn) Then Exit Sub

            'Verifica qual linha foi Pressionada
            Select Case grdOrcamentoPedidoCompraServico.CurrentColumn.Key

                Case "editar" : Call EditarServico()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdServico_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdOrcamentoPedidoCompraServico.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdOrcamentoPedidoCompraServico, _
                                     iFormulario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdServico_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdOrcamentoPedidoCompraServico.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdOrcamentoPedidoCompraServico.Name, _
                                     iFormulario, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdServico_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdOrcamentoPedidoCompraServico.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdOrcamentoPedidoCompraServico.Name, _
                                          iFormulario, _
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

#Region "::: FINANCEIRO MANUAL :::"

    Private Sub btnFinanceiroInserir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinanceiroInserir.Click
        Try
            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se Existe Valor Parcela
            If txtFinanceiroValorParcela.Value > 0 Then

                'Verifica o Tipo de Operação
                Call oClsCmpPedido.InsertFinanceiroGrid(grdFinanceiro, _
                                                           DateAdd(DateInterval.Day, txtFinanceiroIntervaloParcelas.Value, Now.Date), _
                                                           txtFinanceiroNumeroParcela.Value, _
                                                           txtFinanceiroIntervaloParcelas.Value, _
                                                           txtFinanceiroPercentualParcela.Value, _
                                                           txtFinanceiroValorParcela.Value, _
                                                           IIf(IsNumeric(btnFinanceitoExcluir.Tag), btnFinanceitoExcluir.Tag, IIf(grdFinanceiro.RowCount = 0, 1, grdFinanceiro.RowCount + 1)), _
                                                           IIf(IsNumeric(btnFinanceiroInserir.Tag), "U", "I"))
                'Limpa Controles
                NovoFinanceiro()
                'Focu
                txtFinanceiroNumeroParcela.Focus()

            Else

                'Informa o Usuário da Necessidade de Selecionar um ou mais Registro
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, " O valor da parcela deve maior que zero.")
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)

        End Try
    End Sub

    Private Sub btnFinanceitoExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinanceitoExcluir.Click
        Try

            'Deleta Registros
            Call DeleteFinanceiro()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub CalculaFinanceiroValorParcela_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFinanceiroPercentualParcela.LostFocus, _
                                                                                                                    txtFinanceiroValorParcela.LostFocus


        Try

            Select Case sender.Name

                Case "txtFinanceiroPercentualParcela"
                    txtFinanceiroValorParcela.Value = Math.Round((txtFinanceiroPercentualParcela.Value / 100) * txtValorFinalPedido.Value, 2)

                Case "txtFinanceiroValorParcela"
                    txtFinanceiroPercentualParcela.Value = Math.Round((txtFinanceiroValorParcela.Value / txtValorFinalPedido.Value) * 100, 2)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdFinanceiro_RowDoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdFinanceiro.RowDoubleClick

        Try

            'Verifica o Tipo da Linha
            If IsNothing(grdFinanceiro.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdFinanceiro.CurrentColumn.Key

                Case "editar" : Call EditarFinanceiro()


            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: IMPORTAR PEDIDO DE VENDA :::"

    'Private Sub btnImportarPedidoVenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportarPedidoVenda.Click
    '    Try

    '        'Abre Formulário de Pedido - Pedido de Venda
    '        Dim oForm As New frmCmpPedidoCompraVenda
    '        'Seta Tamanho e Localização do Formulário
    '        oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location
    '        oForm.CodigoPedido = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0)

    '        'Configura Formulário
    '        Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm)

    '        'Abre Formulário
    '        oForm.ShowDialog(Me)

    '        'Remove Abas
    '        tabMain.TabPages.Remove(pagListagem)
    '        tabMain.TabPages.Remove(pagDados)

    '        'Editar Pedido
    '        If oForm.CodigoPedido > 0 Then
    '            Call EditarPedidoCompra(oForm.CodigoPedido)
    '        End If

    '    Catch ex As Exception
    '        'Trata Erro
    '        Call TratamentoErro(ex.Message, Me.Parent.Text)
    '    End Try
    'End Sub

#End Region

#Region "::: ARQUIVO :::"

    Private Sub btnInserirArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirArquivo.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário e do Pedido de Compras
            If Validacao() = False Or ValidacaoArquivo() = False Then Exit Sub

            SalvarPedidoCompra()
            SalvarArquivo()
            LoadGridArquivo()
            NovoArquivo()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnExcluirArquivo_Click(sender As Object, e As EventArgs) Handles btnExcluirArquivo.Click

        Try

            DeleteArquivo()
            LoadGridArquivo()
            NovoArquivo()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnArquivo_Click(sender As Object, e As EventArgs) Handles btnArquivo.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Variaveis Locais
            Dim arqArquivo As New OpenFileDialog

            'Abre PopUp para Usuário selecionar Imagem
            arqArquivo.Title = "Selecione o Arquivo"

            If arqArquivo.ShowDialog() = DialogResult.OK Then
                txtArquivo.Text = arqArquivo.FileName
            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdArquivo_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdArquivo.RowDoubleClick

        Try

            If IsNothing(grdArquivo.CurrentColumn) Then Exit Sub

            Select Case grdArquivo.CurrentColumn.Key

                Case "visualizar" : VisualizarArquivo(grdArquivo.GetValue("caminho_arquivo"))

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
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

            iFormulario = LoadCodigo("sp_select_static_formulario_codigo_user_control '" & Me.Name & "'")

            'Adiciona Delegate
            AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCmpPedido_KeyDown))
            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Limpa Tag
            grdListagem.Tag = ""

            'Verifica Direito            
            btnExcluir.Enabled = VerificaDireito(iFormulario, gcDelete)
            btnExcluirProduto.Enabled = VerificaDireito(iFormulario, gcDelete)
            btnExcluirServico.Enabled = VerificaDireito(iFormulario, gcDelete)
            btnInserirProduto.Enabled = VerificaDireito(iFormulario, gcInsert)
            btnInserirServico.Enabled = VerificaDireito(iFormulario, gcInsert)
            btnNovo.Enabled = VerificaDireito(iFormulario, gcInsert)
            btnSalvar.Enabled = VerificaDireito(iFormulario, gcInsert)

            'Verifica Direito - Botão de Cadastro
            btnCadastrarFornecedor.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcInsert)
            btnCadastrarTransportadora.Enabled = VerificaDireito(Formulario.CadastroBasicoTransportadora, gcInsert)
            btnCadastrarCondicaoPagamento.Enabled = VerificaDireito(Formulario.CadastroBasicoCondicaoPagamento, gcInsert)
            btnCadastrarObservacao.Enabled = VerificaDireito(Formulario.CadastroBasicoAutotexto, gcInsert)
            btnCadastrarAgenteLogistico.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcInsert)
            btnCadastrarModalidadeTransporte.Enabled = VerificaDireito(Formulario.CadastroBasicoModalidadeTransporte, gcInsert)
            btnCadastrarInstrucaoEmbarque.Enabled = VerificaDireito(Formulario.CadastroBasicoInstrucaoEmbarque, gcInsert)
            btnCadastrarIncoterms.Enabled = VerificaDireito(Formulario.CadastroBasicoIncoterms, gcInsert)

            'Verifica Controle
            chkPrecoCompra.Checked = True
            chkPrecoCompra.Visible = CType(LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'pedido_compra_checkbox'"), Boolean)

            'Carrega ComboBox            
            Call LoadCombo(cboFornecedor, "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboFornecedorFiltro, "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_compras_pedido_item")
            Call LoadCombo(cboModalidadeFrete, "sp_select_combo_static_modalidade_frete")
            Call LoadCombo(cboTransportadora, "sp_select_combo_cadastro_basico_transportadora " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboCondicaoPagamento, "sp_select_combo_cadastro_basico_condicao_pagamento " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboFormaPagamento, "sp_select_combo_static_tipo_documento_pagamento", False)
            Call LoadCombo(cboMoeda, "sp_select_combo_cadastro_basico_moeda " & goUsuario.iEmpresa)
            Call LoadCombo(cboGrupoItemFiltro, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)
            Call LoadCombo(cboRequisitante, "sp_select_combo_administracao_usuario " & goUsuario.iEmpresa)
            Call LoadCombo(cboRequisitanteFiltro, "sp_select_combo_administracao_usuario " & goUsuario.iEmpresa)
            Call LoadCombo(cboAgenteLogistico, "sp_select_combo_cadastro_basico_agente_logistico " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboModalidadeTransporte, "sp_select_combo_cadastro_basico_modalidade_transporte " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboInstrucaoEmbarque, "sp_select_combo_cadastro_basico_instrucao_embarque " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboIncoterms, "sp_select_combo_cadastro_basico_incoterms " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboItemFiltro, "sp_select_combo_cadastro_basico_item_descricao " & goUsuario.iEmpresa & ", NULL, 1, -1")
            Call LoadCombo(cboOrdemProducao, "sp_select_combo_producao_ordem_producao " & goUsuario.iEmpresa)
            Call LoadCombo(cboAutotexto, "sp_select_combo_cadastro_basico_autotexto " & goUsuario.iEmpresa & ", " & 7, True) '7 - COMPRAS - TERMOS E CONDIÇÕES GERAIS

            Call LoadComboSimNao(cboFollowUpFitro)
            txtDescricaoProduto.ReadOnly = True

            'Configura DateTimer
            dtpDataPedidoInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataPedidoInicioFiltro.Checked = False
            dtpDataPedidoTerminoFiltro.Value = Now.Date : dtpDataPedidoTerminoFiltro.Checked = False

            dtpDataPrevisaoEntregaInicio.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataPrevisaoEntregaInicio.Checked = False
            dtpDataPrevisaoEntregaTermino.Value = Now.Date : dtpDataPrevisaoEntregaTermino.Checked = False

            'Seta Controles
            cboModalidadeFrete.Enabled = False
            txtValorFretePedido.Enabled = False
            cboMoeda.SelectedValue = "R$"
            dtpDataAdiantamento.Checked = False

            'Seta Aba
            tabMain.TabPages.Remove(pagDados)

            'Verifica o Direito do Usuário - Item
            If VerificaDireito(iFormulario, gcInsert) = True Then

                'Verifica Direito - Botão de Cadastro
                btnCadastrarProduto.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcInsert)
                btnCadastrarUnidadeMedidaProduto.Enabled = VerificaDireito(Formulario.CadastroBasicoUnidadeMedida, gcInsert)
                btnCadastrarCentroGastoProduto.Enabled = VerificaDireito(Formulario.CadastroBasicoCentroGasto, gcInsert)
                btnCadastrarContaContabilProduto.Enabled = VerificaDireito(Formulario.CadastroBasicoPlanoContas, gcInsert)
                btnExcelGridProduto.Enabled = VerificaDireito(iFormulario, gcPrint)

                'Carrega Combo
                Call LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, 1, " & TipoItem.produto)
                Call LoadCombo(cboUnidadeMedidaProduto, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)

            Else
                tabDados.TabPages.Remove(pagProduto)
            End If

            'Verifica o Direito do Usuário - Serviço
            If VerificaDireito(iFormulario, gcInsert) = True Then

                'Verifica Direito - Botão de Cadastro
                btnCadastrarServico.Enabled = VerificaDireito(Formulario.CadastroBasicoServico, gcInsert)
                btnCadastrarUnidadeMedidaServico.Enabled = VerificaDireito(Formulario.CadastroBasicoUnidadeMedida, gcInsert)
                btnCadastrarCentroGastoServico.Enabled = VerificaDireito(Formulario.CadastroBasicoCentroGasto, gcInsert)
                btnCadastrarContaContabilServico.Enabled = VerificaDireito(Formulario.CadastroBasicoPlanoContas, gcInsert)
                btnExcelGridServico.Enabled = VerificaDireito(iFormulario, gcPrint)

                'Carrega Combo
                Call LoadCombo(cboServico, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.servico), False)
                Call LoadCombo(cboUnidadeMedidaServico, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)

            Else
                tabDados.TabPages.Remove(pagServico)
            End If

            LoadComboGrid(grdOrcamentoPedidoCompraProduto, "codigo_unidade_medida", "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)
            LoadComboGrid(grdOrcamentoPedidoCompraProduto, "codigo_conta_contabil", "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa)
            LoadComboGrid(grdOrcamentoPedidoCompraProduto, "codigo_centro_custo", "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)

            LoadComboGrid(grdOrcamentoPedidoCompraServico, "codigo_unidade_medida", "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)
            LoadComboGrid(grdOrcamentoPedidoCompraServico, "codigo_conta_contabil", "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa)
            LoadComboGrid(grdOrcamentoPedidoCompraServico, "codigo_centro_custo", "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)

            'Configura Grid
            ConfiguraGrid(grdListagem, iFormulario)
            ConfiguraGrid(grdOrcamentoPedidoCompraProduto, iFormulario)
            ConfiguraGrid(grdOrcamentoPedidoCompraServico, iFormulario)
            ConfiguraGrid(grdArquivo, iFormulario)

            txtNumeroPedidoFiltro.Focus()

            AddMenuGrid(grdOrcamentoPedidoCompraProduto)
            AddMenuGrid(grdOrcamentoPedidoCompraServico)

            oClsCmpPedido.LoadGridPedido(grdListagem,
                                         -1,
                                         "01/01/2030",
                                         "",
                                         -1,
                                         -1,
                                         "",
                                         "",
                                         "",
                                         "",
                                         -1,
                                         "",
                                         -1,
                                         "",
                                         "")

            If Me.Tag.ToString.Contains("ID") = True Then
                Dim lCodigo As Long
                lCodigo = Convert.ToInt64(Me.Tag.ToString.Replace("ID:", ""))
                EditarPedidoCompra(lCodigo)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: PEDIDO COMPRA :::"

    Private Sub LoadGridPedidoCompra()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Dim sDestinacaoFiltro As String = ""
            Dim sRequerente As String = ""
            Dim sStatus As String = ""
            Dim sGrupoItem As String = ""
            Dim i As Integer

            'Requerente
            If cboRequisitanteFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboRequisitanteFiltro.CheckedValues)
                    sRequerente &= IIf(sRequerente = "", "", ",") & cboRequisitanteFiltro.CheckedValues(i).ToString
                Next
            End If

            'Status
            If cboStatusFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboStatusFiltro.CheckedValues)
                    sStatus &= IIf(sStatus = "", "", ",") & cboStatusFiltro.CheckedValues(i).ToString
                Next
            End If

            'Grupo de Item
            If cboGrupoItemFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboGrupoItemFiltro.CheckedValues)
                    sGrupoItem &= IIf(sGrupoItem = "", "", ",") & cboGrupoItemFiltro.CheckedValues(i).ToString
                Next
            End If

            'Carrega Controles
            oClsCmpPedido.LoadGridPedido(grdListagem,
                                         IIf(IsNumeric(txtNumeroPedidoFiltro.Text.Trim), txtNumeroPedidoFiltro.Text.Trim, -1),
                                         IIf(dtpDataPedidoInicioFiltro.Checked = False, "", dtpDataPedidoInicioFiltro.Value),
                                         IIf(dtpDataPedidoTerminoFiltro.Checked = False, "", dtpDataPedidoTerminoFiltro.Value),
                                         IIf(cboFornecedorFiltro.SelectedIndex = -1, -1, cboFornecedorFiltro.SelectedValue),
                                         IIf(cboFollowUpFitro.SelectedIndex = -1, -1, IIf(cboFollowUpFitro.SelectedValue = True, 1, 0)),
                                         sRequerente,
                                         txtReferenciaFiltro.Text.Trim,
                                         sStatus,
                                         txtNumeroCotacaoFiltro.Text.Trim,
                                         IIf(cboItemFiltro.SelectedIndex = -1, -1, cboItemFiltro.SelectedValue),
                                         sGrupoItem,
                                         IIf(cboTipoPedidoFiltro.SelectedIndex = -1, -1, cboTipoPedidoFiltro.SelectedValue),
                                         IIf(dtpDataPrevisaoEntregaInicio.Checked = False, "", dtpDataPrevisaoEntregaInicio.Value),
                                         IIf(dtpDataPrevisaoEntregaTermino.Checked = False, "", dtpDataPrevisaoEntregaTermino.Value))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarPedidoCompra(ByVal lCodigoPedidoCapa As Long)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(iFormulario, gcUpdate) = True Then

                'Limpa Formulário
                NovoPedidoCompra()

                'Se o pedido estiver cancelado ou faturado, bloqueia o botão
                If grdListagem.GetValue("status") = 2 Or grdListagem.GetValue("status") = 4 Then
                    btnImportarItemCotacao.Enabled = False
                Else
                    btnImportarItemCotacao.Enabled = True
                End If

                'Seta Código
                oClsCmpPedido.CodigoPedido = lCodigoPedidoCapa

                'Seta Controle
                btnSalvar.Tag = lCodigoPedidoCapa

                'Carrega Controles
                oClsCmpPedido.Editar(lCodigoPedidoCapa,
                                     txtNumeroPedido,
                                     dtpDataPedido,
                                     txtRevisao,
                                     cboFornecedor,
                                     cboContato,
                                     cboRequisitante,
                                     cboModalidadeFrete,
                                     cboTransportadora,
                                     txtObservacao,
                                     txtReferencia,
                                     cboAgenteLogistico,
                                     cboIncoterms,
                                     cboInstrucaoEmbarque,
                                     cboModalidadeTransporte,
                                     cboCondicaoPagamento,
                                     cboFormaPagamento,
                                     cboMoeda,
                                     txtFatorCambial,
                                     txtValorTotalPedido,
                                     txtValorDescontoPedido,
                                     txtValorImpostosProdutoPedido,
                                     txtValorImpostosServicoPedido,
                                     txtDescontoGeral,
                                     txtAcrescimoGeral,
                                     txtValorFretePedido,
                                     txtValorFreteImportacao,
                                     txtValorFinalPedido,
                                     txtFinalidadeProduto,
                                     txtPropostaFornecedor,
                                     txtLocalEntrega,
                                     cboTipoCompra,
                                     txtValorAdiantamento,
                                     txtPorcentagemAdiantamento,
                                     dtpDataAdiantamento,
                                     cboAutotexto)

                'Carrega Grid de Item
                oClsCmpPedido.LoadGridProduto(grdOrcamentoPedidoCompraProduto, _
                                              lCodigoPedidoCapa)

                'Carrega Grid de Serviço
                oClsCmpPedido.LoadGridServico(grdOrcamentoPedidoCompraServico, _
                                              lCodigoPedidoCapa)

                'Carrega Grid do Financeiro Manual
                oClsCmpPedido.LoadGridFinanceiro(lCodigoPedidoCapa, _
                                                 grdFinanceiro)

                'Seta Váriavel
                If IsNothing(grdListagem.CurrentRow) Then
                    bReaprovar = False
                Else
                    bReaprovar = grdListagem.CurrentRow.Cells("reaprovar").Value
                End If

                'Carrega Grid de Arquivo
                oClsCmpPedido.LoadGridArquivo(grdArquivo, _
                                              lCodigoPedidoCapa)

                'Seta Controle
                btnImprimir.Enabled = VerificaDireito(iFormulario, gcPrint)

                'Seta Aba
                If tabDados.TabPages.Contains(pagProduto) Then
                    tabDados.SelectedTab = pagProduto
                ElseIf tabDados.TabPages.Contains(pagServico) Then
                    tabDados.SelectedTab = pagServico
                Else
                    tabDados.SelectedTab = pagDadosGerais
                End If

                'Alterna Aba
                tabMain.TabPages.Remove(pagListagem)
                tabMain.TabPages.Add(pagDados)
                tabMain.SelectedTab = pagDados

                'Verifica se existe produto lançado
                If grdOrcamentoPedidoCompraProduto.GetDataRows.Count > 0 Then cboModalidadeFrete.Enabled = True : txtValorFretePedido.Enabled = True

                'Seta Focu
                dtpDataPedido.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoPedidoCompra()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Dados Gerais
            txtNumeroPedido.Text = ""
            dtpDataPedido.Value = Now.Date : dtpDataPedido.Checked = True
            txtRevisao.Text = ""
            cboFornecedor.SelectedIndex = -1 : cboFornecedor.Enabled = True
            cboContato.SelectedIndex = -1
            cboRequisitante.SelectedIndex = -1
            cboModalidadeFrete.SelectedIndex = -1
            cboTransportadora.SelectedIndex = -1
            txtObservacao.Text = ""
            txtReferencia.Text = ""
            cboCondicaoPagamento.SelectedIndex = -1
            cboFormaPagamento.SelectedIndex = -1
            cboMoeda.SelectedValue = CInt(Moeda.Real)
            txtFatorCambial.Value = 0
            txtValorTotalPedido.Value = 0
            txtValorDescontoPedido.Value = 0
            txtValorImpostosProdutoPedido.Value = 0
            txtValorImpostosServicoPedido.Value = 0
            txtValorFretePedido.Value = 0
            txtValorFreteImportacao.Value = 0
            txtValorFinalPedido.Value = 0
            txtPropostaFornecedor.Text = ""
            txtLocalEntrega.Text = ""
            cboTipoCompra.SelectedIndex = -1
            txtValorAdiantamento.Value = 0
            txtPorcentagemAdiantamento.Value = 0
            dtpDataAdiantamento.Value = Now.Date : dtpDataAdiantamento.Checked = False
            btnSalvar.Tag = ""

            'Limpa Controles - Produto
            cboProduto.SelectedIndex = -1 : cboProduto.Text = "" : cboProduto.Tag = ""
            txtDescricaoProduto.Text = ""
            txtComplementoProdutos.Text = ""
            txtQuantidadeProduto.Value = 0
            cboUnidadeMedidaProduto.SelectedIndex = -1
            chkIPIEmbutido.Checked = False
            chkICMSEmbutido.Checked = True
            chkPISCOFINSEmbutido.Checked = True
            txtAliquotaIPIProduto.Value = 0
            txtAliquotaICMSProduto.Value = 0
            txtAliquotaPISCOFINSProduto.Value = 0
            txtPrecoCompraProduto.Value = 0
            txtDescontoPercentualProduto.Value = 0
            txtDescontoValorProduto.Value = 0
            txtValorUnitarioDescontoProduto.Value = 0
            txtValorTotalProduto.Value = 0
            dtpPrevisaoEntregaProduto.Value = Now.Date : dtpPrevisaoEntregaProduto.Tag = ""
            cboCentroGastoProduto.SelectedIndex = -1
            cboContaContabilProduto.SelectedIndex = -1
            btnInserirProduto.Tag = ""
            txtRCItem.Text = ""
            txtOMItem.Text = ""
            grdOrcamentoPedidoCompraProduto.DataSource = Nothing
            dtpDataContratual.Checked = False
            dtpDataContratual.Value = Today.Date

            'Limpa Controles - Serviço
            cboServico.SelectedIndex = -1
            txtComplementoProdutos.Text = ""
            txtQuantidadeServico.Value = 0
            cboUnidadeMedidaServico.SelectedIndex = -1
            txtValorServico.Value = 0
            dtpPrevisaoEntregaServico.Tag = ""
            dtpPrevisaoEntregaServico.Value = Now.Date
            txtDescontoServico.Value = 0
            txtValorTotalServico.Value = 0
            chkISSRetido.Checked = False
            txtAliquotaISS.Value = 0
            txtAliquotaPIS.Value = 0
            txtAliquotaCOFINS.Value = 0
            txtAliquotaINSS.Value = 0
            txtAliquotaCSLL.Value = 0
            txtAliquotaIR.Value = 0
            cboCentroGastoServico.SelectedIndex = -1
            cboContaContabilServico.SelectedIndex = -1
            btnInserirServico.Tag = ""
            grdOrcamentoPedidoCompraServico.DataSource = Nothing
            dtpDataContratualServico.Checked = False
            dtpDataContratualServico.Value = Today.Date

            'Limpa Controles Financeiro
            txtFinanceiroNumeroParcela.Text = ""
            txtFinanceiroIntervaloParcelas.Text = ""
            txtFinanceiroPercentualParcela.Text = ""
            txtFinanceiroValorParcela.Text = ""
            grdFinanceiro.DataSource = Nothing
            btnFinanceiroInserir.Tag = ""
            btnFinanceitoExcluir.Tag = ""

            'Limpa Controles - Arquivo            
            txtTituloArquivo.Text = ""
            txtArquivo.Text = ""
            btnInserirArquivo.Tag = ""
            cboMoeda.SelectedValue = "R$"
            txtFatorCambial.Value = 1
            grdArquivo.DataSource = Nothing

            'Habilita Controles
            btnSalvar.Enabled = VerificaDireito(iFormulario, gcInsert)
            btnInserirProduto.Enabled = VerificaDireito(iFormulario, gcInsert)
            btnExcluirProduto.Enabled = VerificaDireito(iFormulario, gcDelete)
            btnInserirServico.Enabled = VerificaDireito(iFormulario, gcInsert)
            btnExcluirServico.Enabled = VerificaDireito(iFormulario, gcDelete)
            btnImprimir.Enabled = False

            'Seta Aba
            If tabDados.TabPages.Contains(pagProduto) Then
                tabDados.SelectedTab = pagProduto
            ElseIf tabDados.TabPages.Contains(pagServico) Then
                tabDados.SelectedTab = pagServico
            Else
                tabDados.SelectedTab = pagDadosGerais
            End If

            'Seta Focu
            cboFornecedor.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarPedidoCompra()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCmpPedido.DataPedido = IIf(dtpDataPedido.Checked = True, dtpDataPedido.Value, "")
            oClsCmpPedido.Revisao = txtRevisao.Text
            oClsCmpPedido.CodigoFornecedor = cboFornecedor.SelectedValue
            oClsCmpPedido.CodigoParceiroNegocioContato = IIf(cboContato.SelectedIndex = -1, -1, cboContato.SelectedValue)
            oClsCmpPedido.CodigoRequerente = IIf(cboRequisitante.SelectedIndex = -1, -1, cboRequisitante.SelectedValue)
            oClsCmpPedido.CodigoModalidadeFrete = IIf(cboModalidadeFrete.SelectedIndex = -1, -1, cboModalidadeFrete.SelectedValue)
            oClsCmpPedido.CodigoTransportadora = IIf(cboTransportadora.SelectedIndex = -1, -1, cboTransportadora.SelectedValue)
            oClsCmpPedido.Observacao = txtObservacao.Text.Trim
            oClsCmpPedido.CodigoAgenteLogistico = IIf(cboAgenteLogistico.SelectedIndex = -1, -1, cboAgenteLogistico.SelectedValue)
            oClsCmpPedido.CodigoIncoterms = IIf(cboIncoterms.SelectedIndex = -1, -1, cboIncoterms.SelectedValue)
            oClsCmpPedido.CodigoInstrucaoEmbarque = IIf(cboInstrucaoEmbarque.SelectedIndex = -1, -1, cboInstrucaoEmbarque.SelectedValue)
            oClsCmpPedido.CodigoModalidadeFrete = IIf(cboModalidadeFrete.SelectedIndex = -1, -1, cboModalidadeFrete.SelectedValue)
            oClsCmpPedido.Referencia = txtReferencia.Text.Trim
            oClsCmpPedido.LocalEntrega = txtLocalEntrega.Text.Trim
            oClsCmpPedido.CodigoCondicaoPagamento = IIf(cboCondicaoPagamento.SelectedIndex = -1, -1, cboCondicaoPagamento.SelectedValue)
            oClsCmpPedido.CodigoFormaPagamento = IIf(cboFormaPagamento.SelectedIndex = -1, -1, cboFormaPagamento.SelectedValue)
            oClsCmpPedido.CodigoMoeda = IIf(cboMoeda.SelectedIndex = -1, -1, cboMoeda.SelectedValue)
            oClsCmpPedido.FatorCambial = txtFatorCambial.Value
            oClsCmpPedido.ValorTotal = txtValorTotalPedido.Value
            oClsCmpPedido.ValorDesconto = txtValorDescontoPedido.Value
            oClsCmpPedido.DescontoGeral = txtDescontoGeral.Value
            oClsCmpPedido.AcrescimoGeral = txtAcrescimoGeral.Value
            oClsCmpPedido.ValorFrete = txtValorFretePedido.Value
            oClsCmpPedido.ValorFreteImportacao = txtValorFreteImportacao.Value
            oClsCmpPedido.ValorFinal = txtValorFinalPedido.Value
            oClsCmpPedido.PropostaFornecedor = txtPropostaFornecedor.Text
            oClsCmpPedido.FinalidadeProduto = txtFinalidadeProduto.Text
            oClsCmpPedido.CodigoTipoCompra = IIf(cboTipoCompra.SelectedIndex = -1, -1, cboTipoCompra.SelectedValue)
            oClsCmpPedido.DataAdiantamento = IIf(dtpDataAdiantamento.Checked = False, "", dtpDataAdiantamento.Value)
            oClsCmpPedido.ValorAdiantamento = txtValorAdiantamento.Value
            oClsCmpPedido.PorcentagemAdiantamento = txtPorcentagemAdiantamento.Value
            oClsCmpPedido.CodigoAutotexto = IIf(cboAutotexto.SelectedIndex = -1, -1, cboAutotexto.SelectedValue)

            'Verifica o Tipo de Operação
            If IsNumeric(btnSalvar.Tag) = False Then
                'Insere Registro
                oClsCmpPedido.Insert()
                'Carrega Controles
                txtNumeroPedido.Text = oClsCmpPedido.NumeroPedido
                btnSalvar.Tag = oClsCmpPedido.CodigoPedido
                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroInserido)
            Else
                'Atualiza Registro
                oClsCmpPedido.Update()
                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroAlterado)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeletePedidoCompra()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdListagem, "status", "1") = True Or VerificaSelecaoRow(grdListagem, "status", "6") = True Then

                If VerificaSelecaoRow(grdListagem) = True Then
                    'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                    If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & "registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                        'Seta Cursor do Mouse
                        Cursor.Current = Cursors.WaitCursor

                        'Exclui Registro
                        oClsCmpPedido.Delete()

                        'Informa o Usuário sobre o Sucesso da Operação
                        frmMain.Informacao(Mensagem.RegistroExcluido)

                        LoadGridPedidoCompra()

                        'Seta Cursor do Mouse
                        Cursor.Current = Cursors.Default

                    End If

                Else
                    'Informa o Usuário da Necessidade de Selecionar um ou mais Registro
                    frmMain.Informacao(Mensagem.ValidacaoSelecionar)
                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                MsgBox("Primeiramente Selecione um ou mais Registros Válidos." & vbCrLf & vbCrLf & "** Pedido que não foi Faturado, Cancelado ou Reprovado.", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub FollowUpPedidoCompra()

        Try

            'Variável - Formulário
            Dim oForm As New frmCmpPedidoFollowUp
            'Seta Parâmetros
            oForm.Grid = grdListagem
            'Abre o Formulário
            oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ImprimirPedidoCompra(ByVal lCodigoPedidoCapa As Long,
                                     ByVal bReaprovar As Boolean,
                                     ByVal sNumeroPedido As String,
                                     ByVal sFornecedor As String)

        Try

            'Verifica se o usuário tem direito de Imprimir
            If VerificaDireito(iFormulario, gcPrint) = False Then
                frmMain.Informacao(Mensagem.DireitoImprimir)
            End If

            Dim iStatus As Integer = LoadCodigo("sp_load_compras_pedido_status " & lCodigoPedidoCapa & "," & goUsuario.iEmpresa)

            If iStatus = 5 Or iStatus = 6 Or iStatus = 4 Then 'Reprovado | Ag. Aprovacao | Cancelado
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Este Pedido de Compra Necessita ser Aprovado.")
                Exit Sub
            End If

            If bReaprovar = True Then
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Este Pedido de Compra Necessita ser Reaprovado.")
                Exit Sub
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis - Locais
            Dim sReport As String
            Dim sUF As String = oClsCmpPedido.LoadUFParceiroNegocioPedido(lCodigoPedidoCapa)

            'Váriavel - Formulário
            Dim oForm As New frmRptSelecionar
            oForm.Tipo = "PEDIDO DE COMPRA"
            oForm.ShowDialog(Me)
            sReport = oForm.Relatorio

            'Verifica o Relatório
            If sReport = "" Then Exit Sub

            'Seta Váriavel
            sReport &= ".rpt"

            If sUF = "EX" Then
                sReport = sReport.Replace(".rpt", "E.rpt")
            End If

            'Verifica se o Arquivo existe,
            If System.IO.File.Exists(goCrystalReport.sPath & sReport) = False Then
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "O Relatório não foi encontrado, ou seu usuário não possui direito de Visualização pasta de Relatórios.")
                Exit Sub
            End If

            'Redimenciona Vetor
            ReDim goCrystalReport.sReportParameter(2)
            'Seta Parametros
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_pedido"
            goCrystalReport.sReportParameter(1).sValue = lCodigoPedidoCapa
            goCrystalReport.sReportParameter(2).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(2).sValue = goUsuario.iEmpresa
            goCrystalReport.sReport = goCrystalReport.sPath & sReport

            Dim oReport As New usrReport
            oReport.Dock = DockStyle.Fill

            'Remove as barras caso tenha
            sFornecedor = sFornecedor.Replace("/", "").Replace("\", "")

            Dim sNomeArquivo As String = sNumeroPedido + " - " + "LEGADO USINAGEM" + " - " + sFornecedor

            'Abre Relatório
            frmMain.LoadPageReport("CMP000000001", "Pedido de Compra", oReport, Nothing, sNomeArquivo)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EmailPedidoCompra(ByVal lCodigoPedido As Long, _
                                  ByVal bReaprovar As Boolean)

        Try

            If bReaprovar = True Then
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Este Pedido de Compra Necessita ser Reaprovado.")
                Exit Sub
            End If

            'Verifica se o Usuário tem Direito para Enviar o E-mail
            If VerificaDireito(iFormulario, gcAdministrator) = True Then

                'Váriaveis - Relatório
                Dim sReport As String
                Dim sUF As String = oClsCmpPedido.LoadUFParceiroNegocioPedido(lCodigoPedido)

                'Váriavel - Formulário
                Dim oForm As New frmRptSelecionar
                oForm.Tipo = "PEDIDO DE COMPRA"
                oForm.ShowDialog(Me)
                sReport = oForm.Relatorio

                'Verifica o Relatório
                If sReport = "" Then Exit Sub

                'Seta Váriavel
                sReport &= ".rpt"

                If sUF = "EX" Then
                    sReport = sReport.Replace(".rpt", "E.rpt")
                End If

                'Váriaveis Locais
                Dim oRptDocument As New ReportDocument

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Verifica se o Arquivo existe
                If System.IO.File.Exists(goCrystalReport.sPath & sReport) = False Then
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "O Relatório não foi encontrado, ou seu usuário não possui direito de Visualização pasta de Relatórios.")
                    Exit Sub
                End If

                'Abre Relatório
                oRptDocument.Load(goCrystalReport.sPath & sReport, _
                                  CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)

                'Seta Parametros Relatório
                oRptDocument.SetParameterValue("@codigo_pedido", lCodigoPedido)
                oRptDocument.SetParameterValue("@codigo_empresa", goUsuario.iEmpresa)
                oRptDocument.SetParameterValue("usuario", goUsuario.sNome)

                'Abre Conexão com o Banco de Dados
                For i = 0 To oRptDocument.DataSourceConnections.Count - 1
                    oRptDocument.DataSourceConnections.Item(i).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)
                Next

                Dim sArquivo As String = ApplicationPath() & "File\PEDIDO_" & grdListagem.CurrentRow.Cells("numero_pedido").Value.ToString.Replace("/", "-").Replace("\", "-") & "_" & Format(Now, "yyyyMMdd_hhmm") & ".pdf"

                'Exporta para Arquivo PDF
                oRptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, _
                                          sArquivo)

                'Limpa Váriavel
                oRptDocument = Nothing

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

                'Enviar E-mail
                Call EnviarEmail(goUsuario.sEmpresa & " - Pedido de Compra " & grdListagem.CurrentRow.Cells("numero_pedido").Value, _
                                 LoadContato(grdListagem.CurrentRow.Cells("codigo_fornecedor").Value, TipoContato.Comercial), _
                                 sArquivo, _
                                 sArquivo, _
                                 "", _
                                 grdListagem.CurrentRow.Cells("codigo_fornecedor").Value, _
                                 "", _
                                 -1,
                                 grdListagem.CurrentRow.Cells("codigo_pedido").Value, _
                                 TipoAutotextoEmail.PedidoCompra)

            Else
                'Informa o Usuário que ele não tem Direito para enviar o Pedido de Compra
                frmMain.Informacao(Mensagem.DireitoAdministrador)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DuplicarPedidoCompra()

        Try

            'Verifica se foi Selecionado Algum Fornecedor
            If MsgBox("Deseja Duplicar o Pedido de Compra Selecionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                'Duplica Pedido de Compra
                oClsCmpPedido.Duplicar(grdListagem.CurrentRow.Cells("codigo_pedido").Value)

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                'Carrega o Pedido de Compra
                Call EditarPedidoCompra(oClsCmpPedido.CodigoPedido)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarParceiroNegocio()

        Try

            'Váriaveis Locais
            Dim oFormularioCadastroBasico(0) As FormularioCadastroBasico

            'Seta Váriavel
            oFormularioCadastroBasico(0).oValor = "CODIGO:" & grdListagem.CurrentRow.Cells("codigo_fornecedor").Value : oFormularioCadastroBasico(0).sControle = "usrCadParceiroNegocio"

            'Carrega o form de parceiro de negócio
            LoadUsrControlForm(Me, "usrCadParceiroNegocio", oFormularioCadastroBasico)

            'Seta Focu
            cboFornecedor.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub HistoricoParceiroNegocio()

        Try

            'Verifica se foi Selecionado algum Registro
            If cboFornecedor.SelectedIndex <> -1 Then

                'Abre Formulário
                Dim oForm As New frmVenHistoricoParceiroNegocio
                oForm.CodigoParceiroNegocio = cboFornecedor.SelectedValue
                Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            Else
                'Informa o Usuário que é necessário selecionar um Produto
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub HistoricoPedido()

        Try

            'Váriaveis Locais
            Dim oForm As New frmCmpPedidoFollowUpHistorico

            'Seta Tamanho / Posição do Formulário
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location

            'Seta Parametros
            oForm.Grid = grdListagem

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function VerificaSelecaoRowPedido(ByVal oGrid As GridEX) As Boolean

        Try

            'Variáveis Loais
            Dim oCheckedRow() As GridEXRow
            Dim oRow As GridEXRow

            'Redimensiona Vetor
            ReDim gSelecaoRow(0)

            'Seta Retorno da Função
            VerificaSelecaoRowPedido = False

            With oGrid

                'Verifica se foi selecionado algum registro para salvar
                If .GetCheckedRows.Length > 0 Then

                    'Recebendo o array de linhas selecionadas
                    oCheckedRow = .GetCheckedRows

                    'Varrendo os itens selecionados
                    For Each oRow In oCheckedRow

                        If oRow.Cells("valor_faturado").Value = 0 And oRow.Cells("valor_cancelado").Value = 0 Then

                            'Redimensiona Vetor caso necessário
                            If Not gSelecaoRow(UBound(gSelecaoRow)) Is Nothing Then
                                ReDim Preserve gSelecaoRow(UBound(gSelecaoRow) + 1)
                            End If

                            'Seta Retorno da Função
                            VerificaSelecaoRowPedido = True

                            'Seta Valores
                            gSelecaoRow(UBound(gSelecaoRow)) = oRow

                        End If

                    Next

                End If

            End With

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Selecionado o Campo - Fornecedor
            If ValidaCampo(cboFornecedor, lblFornecedor) = False Then
                tabDados.SelectedTab = pagProduto
                cboFornecedor.Focus()
                Exit Function
            End If

            'Verifica se foi inserido algum Item
            If grdOrcamentoPedidoCompraProduto.GetDataRows.Count = 0 And grdOrcamentoPedidoCompraServico.GetDataRows.Count = 0 Then
                tabDados.SelectedTab = pagProduto
                frmMain.Informacao(Mensagem.ValidacaoInserir)
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Modalidade de Frete
            If grdOrcamentoPedidoCompraProduto.GetDataRows.Count > 0 Then
                If ValidaCampo(cboModalidadeFrete, lblModalidadeFrete) = False Then
                    tabDados.SelectedTab = pagDadosGerais
                    cboModalidadeFrete.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - Condição de Pagamento
            If ValidaCampo(cboCondicaoPagamento, lblCondicaoPagamento) = False Then
                tabDados.SelectedTab = pagDadosGerais
                cboCondicaoPagamento.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Moeda
            If ValidaCampo(cboMoeda, lblMoeda) = False Then
                tabDados.SelectedTab = pagDadosGerais
                cboMoeda.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Moeda
            If txtFatorCambial.Enabled = True Then
                If ValidaCampo(txtFatorCambial, lblMoeda, True) = False Then
                    tabDados.SelectedTab = pagDadosGerais
                    txtFatorCambial.Focus()
                    Exit Function
                End If
            End If

            If txtValorAdiantamento.Value <> 0 Then
                If dtpDataAdiantamento.Checked = False Then
                    frmMain.errInfo.SetError(lblDataAdiantamento, "Selecione a data do adiantamento!")
                    dtpDataAdiantamento.Focus()
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub CalcularTotais()

        Try

            'Atualiza Valor Total Orçamento
            txtValorTotalPedido.Value = 0
            txtValorDescontoPedido.Value = 0
            If grdOrcamentoPedidoCompraServico.GetDataRows.Count > 0 Then
                txtValorTotalPedido.Value += grdOrcamentoPedidoCompraServico.GetTotalRow.Cells("valor_total_desconto").Value + grdOrcamentoPedidoCompraServico.GetTotalRow.Cells("total_desconto").Value
                txtValorDescontoPedido.Value += grdOrcamentoPedidoCompraServico.GetTotalRow.Cells("total_desconto").Value
                txtValorImpostosServicoPedido.Value = grdOrcamentoPedidoCompraServico.GetTotalRow.Cells("valor_retido").Value
            End If
            If grdOrcamentoPedidoCompraProduto.GetDataRows.Count > 0 Then
                txtValorTotalPedido.Value += grdOrcamentoPedidoCompraProduto.GetTotalRow.Cells("valor_total_desconto").Value + grdOrcamentoPedidoCompraProduto.GetTotalRow.Cells("total_desconto").Value
                txtValorDescontoPedido.Value += grdOrcamentoPedidoCompraProduto.GetTotalRow.Cells("total_desconto").Value
                txtValorImpostosProdutoPedido.Value = grdOrcamentoPedidoCompraProduto.GetTotalRow.Cells("valor_ipi").Value
                txtValorImpostosProdutoPedido.Value += grdOrcamentoPedidoCompraProduto.GetTotalRow.Cells("valor_icms").Value
                txtValorImpostosProdutoPedido.Value += grdOrcamentoPedidoCompraProduto.GetTotalRow.Cells("valor_pis_cofins").Value
                cboModalidadeFrete.Enabled = True
                txtValorFretePedido.Enabled = True
            Else
                cboModalidadeFrete.SelectedIndex = -1 : cboModalidadeFrete.Enabled = False
                txtValorFretePedido.Value = 0 : txtValorFretePedido.Enabled = False
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ImprimirPDF()

        Try

            Dim sPastaImpressao As String = LoadDescricao("sp_select_configuracao_interacti_pasta_arquivo " & goUsuario.iEmpresa)
            Dim i As Integer = 0
            If sPastaImpressao = "" Then
                Throw New Exception("Não foi configurado a Pasta de Arquivos no Servidor.")
            Else
                If Directory.Exists(sPastaImpressao) = False Then
                    Throw New Exception("Você não possui permissão para enxergar a pasta (" & sPastaImpressao & ").")
                End If
            End If

            Dim oArquivo() As String
            Dim j As Integer = grdListagem.GetCheckedRows.Count
            ReDim oArquivo(j)

            For Each oRow As GridEXRow In grdListagem.GetCheckedRows

                Dim iStatus As Integer = LoadCodigo("sp_load_compras_pedido_status " & oRow.Cells.Item("codigo_pedido").Value & "," & goUsuario.iEmpresa)

                If iStatus = 5 Or iStatus = 6 Or iStatus = 4 Then 'Reprovado | Ag. Aprovacao | Cancelado
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "O Pedido de Compra: " & oRow.Cells.Item("numero_pedido").Value & " Necessita ser Aprovado.")
                    Exit Sub
                End If
            Next

            For Each oRow As GridEXRow In grdListagem.GetCheckedRows
                'Váriaveis - Relatório
                Dim sReport As String
                Dim sUF As String = oClsCmpPedido.LoadUFParceiroNegocioPedido(oRow.Cells.Item("codigo_pedido").Value)


                'Váriavel - Formulário
                Dim oForm As New frmRptSelecionar
                oForm.Tipo = "PEDIDO DE COMPRA"
                oForm.ShowDialog(Me)
                sReport = oForm.Relatorio

                'Verifica o Relatório
                If sReport = "" Then Exit Sub

                'Seta Váriavel
                sReport &= ".rpt"

                If sUF = "EX" Then
                    sReport = sReport.Replace(".rpt", "E.rpt")
                End If

                'Váriaveis Locais
                Dim oRptDocument As New ReportDocument

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Verifica se o Arquivo existe
                If System.IO.File.Exists(goCrystalReport.sPath & sReport) = False Then
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "O Relatório não foi encontrado, ou seu usuário não possui direito de Visualização pasta de Relatórios.")
                    Exit Sub
                End If

                'Abre Relatório
                oRptDocument.Load(goCrystalReport.sPath & sReport, _
                                  CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)

                'Seta Parametros Relatório
                oRptDocument.SetParameterValue("@codigo_pedido", oRow.Cells.Item("codigo_pedido").Value)
                oRptDocument.SetParameterValue("@codigo_empresa", goUsuario.iEmpresa)
                oRptDocument.SetParameterValue("usuario", goUsuario.sNome)

                'Abre Conexão com o Banco de Dados
                For iCont = 0 To oRptDocument.DataSourceConnections.Count - 1
                    oRptDocument.DataSourceConnections.Item(iCont).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)
                Next

                oArquivo(i) = sPastaImpressao & "PEDIDO_" & oRow.Cells.Item("numero_pedido").Value.ToString.Replace("/", "-").Replace("\", "-") & "_" & Format(Now, "yyyyMMdd_hhmm") & ".pdf"

                'Exporta para Arquivo PDF
                oRptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, _
                                          oArquivo(i))

                'Limpa Váriavel
                oRptDocument = Nothing
                i = i + 1
            Next

            Dim sArquivoImpressao As String = GerarPDF(sPastaImpressao + "PEDIDOS_" + Format(Now, "yyyyMMdd_hhmm") + "_.pdf", oArquivo)
            Dim psi As New ProcessStartInfo
            psi.UseShellExecute = True
            psi.FileName = sArquivoImpressao
            Process.Start(psi)
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default





        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub BaixarPedidoCompra()

        Try

            If VerificaDireito(419, gcSelect) = False Then
                MsgBox("Você não tem direito para baixar o pedido de compra", vbExclamation)
                Exit Sub
            End If


            If grdListagem.GetValue("status") <> 3 Then

                MsgBox("Só é possível fazer a baixa de pedidos que estão como [Parcialmente Entregue] !", MsgBoxStyle.Exclamation, "Validação")
                Exit Sub

            End If



            'Verifica se o Usuário Deseja Excluir os Registros Selecionados
            If MsgBox("Deseja baixar o Pedido de Compra?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Exclui Registro
                oClsCmpPedido.BaixarPedido(grdListagem.GetValue("codigo_pedido"))

                Call LoadGridPedidoCompra()

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroSalvo)

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

            End If



        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub AtualizarPedido()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Apenas Administrador e adm processos
            If goUsuario.iPerfil <> 1 Then
                MsgBox("Você não tem permissão para realizar esta ação.", MsgBoxStyle.Exclamation, "Validação")
                Exit Sub
            End If

            oClsCmpPedido.AtualizarStatusPedido(grdListagem.GetValue("codigo_pedido"))

            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

            LoadGridPedidoCompra()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CancelarPedido()

        Try

            'Verifica se o usuário tem direito de Cancelar algum registro
            If VerificaDireito(iFormulario, gcAdministrator) = True Then

                'Verifica o status do pedido
                If grdListagem.CurrentRow.Cells("quantidade_pedido").Value - grdListagem.CurrentRow.Cells("quantidade_entregue").Value > 0 Then

                    'Solicita confirmacao do usuario
                    If MsgBox("Deseja Cancelar o Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.No Then Exit Sub

                    'Variável - Formulário
                    Dim oForm As New frmCmpPedidoReprovar

                    'Seta Tamanho e Posição do Formulário
                    oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location

                    'Seta Parâmetros
                    oForm.NumeroPedido = grdListagem.CurrentRow.Cells("numero_pedido").Value
                    oForm.DataPedido = grdListagem.CurrentRow.Cells("data_pedido").Value
                    oForm.Fornecedor = grdListagem.CurrentRow.Cells("parceiro_negocio").Value
                    oForm.CodigoPedido = grdListagem.CurrentRow.Cells("codigo_pedido").Value
                    oForm.Tipo = 1 'Cancelar

                    'Abre o Formulário
                    oForm.ShowDialog(Me)

                    'Carrega Grid
                    Call LoadGridPedidoCompra()

                Else
                    'Informa o Usuário que o Pedido de Compra não pode ser Cancelado
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "A Quantidade Pendente não é maior que ""0"" no Pedido.")
                End If

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAdministrador)
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Aprovar()

        Try

            'Se status 2 -ENTREGUE ou  3 = PARCIALMENTE ENTREGUE n deixa continuar
            If grdListagem.CurrentRow.Cells("status").Value = 2 Or grdListagem.CurrentRow.Cells("status").Value = 3 Then
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Não é possível realizar essa operação devido ao status do pedido.")
                Exit Sub
            End If

            'Verifica se o Usuário deseja Reaprovar o Pedido de Compra
            If MsgBox("Deseja Aprovar o Pedido de Compra?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                If VerificaAprovador(grdListagem.CurrentRow.Cells("valor_pedido").Value) = False Then Exit Sub

                Call oClsCmpPedido.Aprovar(grdListagem.CurrentRow.Cells("codigo_pedido").Value)

                'ENVIAR EMAIL AVISANDO O COMPRADOR
                oClsCmpPedido.EnviarEmailAprovacaoSupervisorRetornoLegado(grdListagem.CurrentRow.Cells("codigo_pedido").Value, 1, 0)

                'ENVIAR EMAIL AVISANDO O REQUISITANTE
                oClsCmpPedido.EnviarEmailAprovacaoPedidoGerado(grdListagem.CurrentRow.Cells("codigo_pedido").Value)

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                'Carrega Grid
                Call LoadGridPedidoCompra()


            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Reprovar()

        Try

            'Se status 2 -ENTREGUE ou  3 = PARCIALMENTE ENTREGUE n deixa continuar
            If grdListagem.CurrentRow.Cells("status").Value = 2 Or grdListagem.CurrentRow.Cells("status").Value = 3 Then
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Não é possível realizar essa operação devido ao status do pedido.")
                Exit Sub
            End If

            'Verifica se o Usuário deseja Reaprovar o Pedido de Compra
            If MsgBox("Deseja Reprovar o Pedido de Compra?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                If VerificaAprovador(grdListagem.CurrentRow.Cells("valor_pedido").Value) = False Then Exit Sub

                'Variável - Formulário
                Dim oForm As New frmCmpPedidoReprovar

                'Seta Tamanho e Posição do Formulário
                oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location

                'Seta Parâmetros
                oForm.NumeroPedido = grdListagem.CurrentRow.Cells("numero_pedido").Value
                oForm.DataPedido = grdListagem.CurrentRow.Cells("data_pedido").Value
                oForm.Fornecedor = grdListagem.CurrentRow.Cells("parceiro_negocio").Value
                oForm.CodigoPedido = grdListagem.CurrentRow.Cells("codigo_pedido").Value
                oForm.Tipo = 2 'Reprovar

                'Abre o Formulário
                oForm.ShowDialog(Me)

                'Carrega Grid
                Call LoadGridPedidoCompra()

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function VerificaAprovador(dValorPedido As Double) As Boolean

        Try

            Dim bAprovador As Boolean = LoadCodigo("sp_load_compras_cotacao_usuario_aprovador " & goUsuario.iUsuario & "," & goUsuario.iEmpresa)

            If bAprovador = 0 Then
                MsgBox("Essa ação não pode ser realizada, usuário logado Não é Aprovador.", MsgBoxStyle.Exclamation, "Validação")
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function
#End Region

#Region "::: ITEM :::"

#Region "::: GERAL :::"

    Private Sub AdicionarProduto()

        Try

            frmMain.errInfo.Clear()

            If ValidaCampo(cboFornecedor, lblFornecedor) = False Then Exit Sub

            SalvarPedidoCompra()

            Dim oForm As New frmCmpPedidoNovoProduto
            oForm.CodigoPedido = btnSalvar.Tag
            oForm.ShowDialog()

            LoadGridProduto()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub AdicionarServico()

        Try

            frmMain.errInfo.Clear()

            If ValidaCampo(cboFornecedor, lblFornecedor) = False Then Exit Sub

            SalvarPedidoCompra()

            Dim oForm As New frmCmpPedidoNovoServico
            oForm.CodigoPedido = btnSalvar.Tag
            oForm.ShowDialog()

            LoadGridServico()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function VerificaStatusItem(ByVal oGrid As GridEX) As Boolean

        Try

            Dim iCodigo As Integer

            If oGrid.GetRows.Count <= 0 Then Return False

            iCodigo = oGrid.GetValue("codigo_pedido_item")

            Dim iStatus As Integer = LoadCodigo("sp_load_compras_pedido_item_status " & IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1) & "," & iCodigo & "," & goUsuario.iEmpresa)

            If iStatus = 2 Or iStatus = 3 Or iStatus = 4 Then
                MsgBox("Não é possível executar essa ação pois o Pedido de Compra não pode ser editado devido ao seu status.", MsgBoxStyle.Exclamation, "Validação")
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function VerificaStatus() As Boolean

        Try

            Dim iStatus As Integer = LoadCodigo("sp_load_compras_pedido_status " & IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1) & "," & goUsuario.iEmpresa)

            If iStatus = 2 Or iStatus = 3 Or iStatus = 4 Then
                MsgBox("Não é possível executar essa ação pois o Pedido de Compra não pode ser editado devido ao seu status.", MsgBoxStyle.Exclamation, "Validação")
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub CancelarItemPedidoCompra()

        Try

            'Verifica se o usuário tem direito de Cancelar algum registro
            If VerificaDireito(iFormulario, gcAdministrator) = True Then

                'Verifica o status do Pedido de Compra
                If grdListagem.CurrentRow.Cells("quantidade").Value - grdListagem.CurrentRow.Cells("quantidade_entregue").Value > 0 Then

                    'Váriaveis Locais
                    Dim oForm As New frmCmpPedidoCancelarItem
                    'Seta Parametros
                    oForm.CodigoPedido = grdListagem.CurrentRow.Cells("codigo_pedido").Value
                    oForm.CodigoPedidoItem = grdListagem.CurrentRow.Cells("codigo_pedido_item").Value
                    'Abre Formulário
                    Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                    'Carrega Grid
                    Call LoadGridPedidoCompra()

                Else
                    'Informa o Usuário que o Pedido de Compra não pode ser Cancelado
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "A Quantidade Pendente não é maior que ""0"".")
                End If

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAdministrador)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub AtivarItemPedidoCompra()

        Try

            'Verifica o status do Pedido de Compra
            If grdListagem.CurrentRow.Cells("status").Value = CInt(StatusCompraPedidoItem.Cancelado) Then

                'Verifica se o usuário tem direito de Administrador
                If VerificaDireito(iFormulario, gcAdministrator) = True Then

                    'Verifica se o Usuário deseja Retornar o Status do Pedido de Compra
                    If MsgBox("Deseja tornar ativo o Registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                        'Ativa Pedido de Compra
                        Call oClsCmpPedido.AtivarItem(grdListagem.CurrentRow.Cells("codigo_pedido").Value, _
                                                      grdListagem.CurrentRow.Cells("codigo_pedido_item").Value, _
                                                      grdListagem.CurrentRow.Cells("quantidade").Value, _
                                                      "REGISTRO ATIVADO")

                        'Carrega a Grid
                        Call LoadGridPedidoCompra()

                    End If

                Else
                    'Informa o Usuário que ele não tem Direito
                    frmMain.Informacao(Mensagem.DireitoAdministrador)
                End If

            Else
                'Informa o Usuário que o Pedido de Compra não pode ser Cancelado
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub HistoricoItemPedidoCompra()

        Try

            'Váriaveis Locais
            Dim oForm As New frmCmpPedidoHistoricoItem

            'Seta Tamanho / Posição do Formulário
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location

            'Seta Parametros
            oForm.Grid = grdListagem

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DesmembrarEntregaItem(ByVal dtpPrazoEntrega As CalendarCombo, _
                                      ByVal sItem As String, _
                                      ByVal dQuantidade As Double)

        Try

            'Váriavel - Formulário
            Dim oForm As New frmCmpPedidoItemDesmembrarEntrega

            'Seta Parâmetros
            oForm.Item = sItem
            oForm.dtpDataEntrega = dtpPrazoEntrega
            oForm.Quantidade = dQuantidade

            'Abre o Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Verifica se NÃO foi Preenchido a Data de Entrega
            If dtpPrazoEntrega.Tag.ToString <> "" Then

                'Váriaveis Locais
                Dim sAuxiliar(1) As String
                Dim sDataPrevisaoEntrega() As String

                'Carrega Váriaveis
                sAuxiliar = dtpPrazoEntrega.Tag.ToString.Split("|")
                sDataPrevisaoEntrega = sAuxiliar(0).Split(";")

                'Seta Controle
                dtpPrazoEntrega.Value = sDataPrevisaoEntrega(0)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: PRODUTO :::"

    Private Sub AtualizarProduto()

        Try

            Dim dQuantidade As Double = 0
            Dim dValorUnitario As Double = 0
            Dim dValorUnitarioDesconto As Double = 0
            Dim dValorTotalDesconto As Double = 0
            Dim dValorTotalImposto As Double = 0
            Dim dValorTotalImpostoIPI As Double = 0
            Dim dAliquotaICMS As Double = 0
            Dim dAliquotaPISCOFINS As Double = 0
            Dim dAliquotaIPI As Double = 0
            Dim dValorICMS As Double = 0
            Dim dValorPISCOFINS As Double = 0
            Dim dValorIPI As Double = 0
            Dim dPorcentagemDesconto As Double = 0
            Dim dDescontoUnitario As Double = 0

            dQuantidade = grdOrcamentoPedidoCompraProduto.GetValue("quantidade")
            dValorUnitario = grdOrcamentoPedidoCompraProduto.GetValue("valor_unitario")
            dValorUnitarioDesconto = grdOrcamentoPedidoCompraProduto.GetValue("valor_unitario_desconto")
            dAliquotaICMS = grdOrcamentoPedidoCompraProduto.GetValue("aliquota_icms")
            dAliquotaPISCOFINS = grdOrcamentoPedidoCompraProduto.GetValue("aliquota_pis_cofins")
            dAliquotaIPI = grdOrcamentoPedidoCompraProduto.GetValue("aliquota_ipi")
            dPorcentagemDesconto = grdOrcamentoPedidoCompraProduto.GetValue("desconto_unitario_percentual")
            dDescontoUnitario = grdOrcamentoPedidoCompraProduto.GetValue("desconto_unitario_valor")

            Select Case grdOrcamentoPedidoCompraProduto.CurrentColumn.Key

                Case "valor_unitario"
                    dDescontoUnitario = (dValorUnitario * dPorcentagemDesconto) / 100.0
                    dValorUnitarioDesconto = dValorUnitario - (dValorUnitario * dPorcentagemDesconto) / 100.0

                Case "desconto_unitario_percentual"
                    dDescontoUnitario = (dValorUnitario * dPorcentagemDesconto) / 100.0
                    dValorUnitarioDesconto = dValorUnitario - (dValorUnitario * dPorcentagemDesconto) / 100.0

                Case "desconto_unitario_valor"
                    dValorUnitarioDesconto = dValorUnitario - dDescontoUnitario
                    dPorcentagemDesconto = (dDescontoUnitario / IIf(dValorUnitario <= 0, 1, dValorUnitario)) * 100.0

            End Select

            dValorTotalDesconto = dValorUnitarioDesconto * dQuantidade
            dValorICMS = (dValorTotalDesconto * dAliquotaICMS) / 100.0
            dValorPISCOFINS = (dValorTotalDesconto * dAliquotaPISCOFINS) / 100.0
            'dValorTotalImposto = dValorTotalDesconto + dValorICMS + dValorPISCOFINS
            dValorIPI = (dValorTotalDesconto * dAliquotaIPI) / 100.0
            dValorTotalImpostoIPI = dValorTotalDesconto + dValorIPI

            grdOrcamentoPedidoCompraProduto.SetValue("desconto_unitario_valor", dDescontoUnitario)
            grdOrcamentoPedidoCompraProduto.SetValue("desconto_unitario_percentual", dPorcentagemDesconto)
            grdOrcamentoPedidoCompraProduto.SetValue("valor_unitario_desconto", dValorUnitarioDesconto)
            grdOrcamentoPedidoCompraProduto.SetValue("valor_total_desconto", dValorTotalDesconto)
            grdOrcamentoPedidoCompraProduto.SetValue("valor_icms", dValorICMS)
            grdOrcamentoPedidoCompraProduto.SetValue("valor_pis_cofins", dValorPISCOFINS)
            grdOrcamentoPedidoCompraProduto.SetValue("valor_total_imposto", dValorTotalDesconto)
            grdOrcamentoPedidoCompraProduto.SetValue("valor_ipi", dValorIPI)
            grdOrcamentoPedidoCompraProduto.SetValue("valor_total_imposto_ipi", dValorTotalImpostoIPI)

            oClsCmpPedido.UpdateProdutoGrid(grdOrcamentoPedidoCompraProduto.CurrentRow)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ImportarItemCotacao()

        Try

            Dim oForm As New frmCmpPedidoImportarCotacaoItem
            oForm.CodigoFornecedor = cboFornecedor.SelectedValue
            oForm.CodigoPedido = btnSalvar.Tag
            oForm.ShowDialog()

            LoadGridProduto()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoProduto()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Produtos
            cboProduto.SelectedIndex = -1 : cboProduto.Text = "" : cboProduto.Tag = ""
            txtDescricaoProduto.Text = ""
            txtComplementoProdutos.Text = ""
            txtQuantidadeProduto.Value = 0
            cboUnidadeMedidaProduto.SelectedIndex = -1
            'chkIPIEmbutido.Checked = False
            'chkICMSEmbutido.Checked = True
            'chkPISCOFINSEmbutido.Checked = True
            txtAliquotaIPIProduto.Value = 0
            txtAliquotaICMSProduto.Value = 0
            txtAliquotaPISCOFINSProduto.Value = 0
            txtPrecoCompraProduto.Value = 0
            txtDescontoPercentualProduto.Value = 0
            txtDescontoValorProduto.Value = 0
            txtValorUnitarioDescontoProduto.Value = 0
            txtValorTotalProduto.Value = 0
            dtpPrevisaoEntregaProduto.Value = Now.Date : dtpPrevisaoEntregaProduto.Tag = ""
            cboCentroGastoProduto.SelectedIndex = -1
            cboContaContabilProduto.SelectedIndex = -1
            txtRCItem.Text = ""
            txtOMItem.Text = ""
            btnInserirProduto.Tag = ""
            cboMoeda.SelectedValue = "R$"
            txtFatorCambial.Value = 1
            txtEspecificacoes.Text = ""
            cboOrdemProducao.SelectedIndex = -1


            'Configura Valor Default
            Call ConfigureValorDefault(Me)

            'Seta Focu
            cboProduto.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub InsertProduto()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim sAuxiliar(1) As String
            Dim iCodigoPedidoItem As Integer = -1

            'Seta Váriavel
            If dtpPrevisaoEntregaProduto.Tag <> "" And dtpPrevisaoEntregaProduto.Tag <> "|" Then
                sAuxiliar = dtpPrevisaoEntregaProduto.Tag.ToString.Split("|")
            Else
                sAuxiliar(0) = dtpPrevisaoEntregaProduto.Value
                sAuxiliar(1) = txtQuantidadeProduto.Value
            End If

            If IsNumeric(btnInserirProduto.Tag) Then
                iCodigoPedidoItem = grdOrcamentoPedidoCompraProduto.CurrentRow.Cells("codigo_pedido_item").Value
            End If

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirProduto.Tag) = False Then

                'Insere Produto no Pedido de Compra
                oClsCmpPedido.InsertProduto(cboProduto.SelectedValue, _
                                            txtComplementoProdutos.Text.Trim, _
                                            txtPrecoCompraProduto.Value, _
                                            txtQuantidadeProduto.Value, _
                                            IIf(cboUnidadeMedidaProduto.Enabled = True, cboUnidadeMedidaProduto.SelectedValue, -1), _
                                            chkIPIEmbutido.Checked, _
                                            txtAliquotaIPIProduto.Value, _
                                            txtAliquotaIPIProduto.Tag, _
                                            chkICMSEmbutido.Checked, _
                                            txtAliquotaICMSProduto.Value, _
                                            txtAliquotaICMSProduto.Tag, _
                                            chkPISCOFINSEmbutido.Checked, _
                                            txtAliquotaPISCOFINSProduto.Value, _
                                            txtAliquotaPISCOFINSProduto.Tag, _
                                            IIf(txtPrecoCompraProduto.Value > txtValorUnitarioDescontoProduto.Value, txtPrecoCompraProduto.Value, txtValorUnitarioDescontoProduto.Value), _
                                            txtDescontoPercentualProduto.Value, _
                                            txtDescontoValorProduto.Value, _
                                            IIf(cboCentroGastoProduto.SelectedIndex = -1, -1, cboCentroGastoProduto.SelectedValue), _
                                            IIf(cboContaContabilProduto.SelectedIndex = -1, "", cboContaContabilProduto.SelectedValue), _
                                            txtRCItem.Text, _
                                            txtOMItem.Text, _
                                            sAuxiliar(0).Split(";"), _
                                            sAuxiliar(1).Split(";"), _
                                            txtEspecificacoes.Text, _
                                            cboOrdemProducao.Text, _
                                            cboOrdemProducao.SelectedValue, _
                                            IIf(dtpDataContratual.Checked = True, dtpDataContratual.Value, ""))

                'Informa o Usuário sobre o sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroInserido)

            Else

                'Exclui Entrega do Item do Pedido de Compra
                Call oClsCmpPedido.DeleteItemEntrega(iCodigoPedidoItem)

                'Altera Produto no Pedido de Compra
                oClsCmpPedido.UpdateProduto(cboProduto.SelectedValue, _
                                            txtComplementoProdutos.Text.Trim, _
                                            txtPrecoCompraProduto.Value, _
                                            txtQuantidadeProduto.Value, _
                                            IIf(cboUnidadeMedidaProduto.Enabled = True, cboUnidadeMedidaProduto.SelectedValue, -1), _
                                            chkIPIEmbutido.Checked, _
                                            txtAliquotaIPIProduto.Value, _
                                            txtAliquotaIPIProduto.Tag, _
                                            chkICMSEmbutido.Checked, _
                                            txtAliquotaICMSProduto.Value, _
                                            txtAliquotaICMSProduto.Tag, _
                                            chkPISCOFINSEmbutido.Checked, _
                                            txtAliquotaPISCOFINSProduto.Value, _
                                            txtAliquotaPISCOFINSProduto.Tag, _
                                            IIf(txtPrecoCompraProduto.Value > txtValorUnitarioDescontoProduto.Value, txtPrecoCompraProduto.Value, txtValorUnitarioDescontoProduto.Value), _
                                            txtDescontoPercentualProduto.Value, _
                                            txtDescontoValorProduto.Value, _
                                            IIf(cboCentroGastoProduto.SelectedIndex = -1, -1, cboCentroGastoProduto.SelectedValue), _
                                            IIf(cboContaContabilProduto.SelectedIndex = -1, "", cboContaContabilProduto.SelectedValue), _
                                            txtRCItem.Text, _
                                            txtOMItem.Text, _
                                            sAuxiliar(0).Split(";"), _
                                            sAuxiliar(1).Split(";"), _
                                            iCodigoPedidoItem, _
                                            txtEspecificacoes.Text, _
                                            IIf(cboOrdemProducao.SelectedIndex = -1, "", cboOrdemProducao.Text), _
                                            IIf(cboOrdemProducao.SelectedIndex = -1, -1, cboOrdemProducao.SelectedValue), _
                                            IIf(dtpDataContratual.Checked = True, dtpDataContratual.Value, ""))

                'Informa o Usuário sobre o sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroAlterado)

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteProduto()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdOrcamentoPedidoCompraProduto, "status", CInt(StatusCompraPedidoItem.PedidoCompra)) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro do Banco de Dados
                    Call oClsCmpPedido.DeleteItem()

                    'Calcular Total
                    Call CalcularTotais()

                    'Prepara Formulário
                    Call NovoProduto()

                    'Integração
                    Call Integracao()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarProduto()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(iFormulario, gcUpdate) = True Then

                'Verifica o Status
                If grdOrcamentoPedidoCompraProduto.CurrentRow.Cells("status").Value = CInt(StatusCompraPedidoItem.PedidoCompra) Then

                    'Carrega Controles
                    oClsCmpPedido.EditarProduto(grdOrcamentoPedidoCompraProduto.CurrentRow.Cells("codigo_pedido_item").Value, _
                                                cboProduto, _
                                                txtComplementoProdutos, _
                                                txtQuantidadeProduto, _
                                                cboUnidadeMedidaProduto, _
                                                txtDescontoPercentualProduto, _
                                                txtDescontoValorProduto, _
                                                txtValorUnitarioDescontoProduto, _
                                                chkICMSEmbutido, _
                                                txtAliquotaICMSProduto, _
                                                chkPISCOFINSEmbutido, _
                                                txtAliquotaPISCOFINSProduto, _
                                                chkIPIEmbutido, _
                                                txtAliquotaIPIProduto, _
                                                dtpPrevisaoEntregaProduto, _
                                                cboCentroGastoProduto, _
                                                cboContaContabilProduto, _
                                                txtRCItem, _
                                                txtOMItem, _
                                                txtEspecificacoes, _
                                                cboOrdemProducao, _
                                                dtpDataContratual)

                    If goDatabase.sInitialCatalog = "INTERACTI_NORSUL_PRD" Then
                        txtDescricaoProduto.Text = grdOrcamentoPedidoCompraProduto.CurrentRow.Cells("descricao").Value
                    End If

                    btnInserirProduto.Tag = grdOrcamentoPedidoCompraProduto.CurrentRow.Cells("codigo_pedido_item").Value

                    'Seta Focu
                    cboProduto.Focus()

                Else
                    'Informa o Usuário que este Serviço não pode ser alterado
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
                End If

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridProduto()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid de Produto
            oClsCmpPedido.LoadGridProduto(grdOrcamentoPedidoCompraProduto, _
                                          btnSalvar.Tag)

            'Calcula Totais
            CalcularTotais()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoProduto() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoProduto = False

            'Verifica se foi Selecionado o Campo - Item
            If ValidaCampo(cboProduto, lblProduto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Quantidade
            If ValidaCampo(txtQuantidadeProduto, lblQuantidadeProduto, True) = False Then
                Exit Function
            End If

            'Verifica se a Quantidade Parcial está correta
            Dim sAuxiliar(1) As String
            Dim sDataPrevisaoEntrega() As String
            Dim sQuantidade() As String
            If dtpPrevisaoEntregaProduto.Tag <> "" Then
                sAuxiliar = dtpPrevisaoEntregaProduto.Tag.ToString.Split("|")
                sDataPrevisaoEntrega = sAuxiliar(0).Split(";")
                sQuantidade = sAuxiliar(1).Split(";")
                If sDataPrevisaoEntrega.Length = 1 Then
                    dtpPrevisaoEntregaProduto.Tag = dtpPrevisaoEntregaProduto.Value & "|" & txtQuantidadeProduto.Value
                Else
                    Dim dSomaQuantidade As Double = 0
                    Dim i As Integer
                    For i = 0 To UBound(sQuantidade)
                        dSomaQuantidade += sQuantidade(i)
                    Next i
                    If dSomaQuantidade <> txtQuantidadeProduto.Value Then
                        frmMain.errInfo.SetError(lblPrevisaoEntregaProduto, "A Quantidade do Produto é diferente da Quantidade Desmembrada.")
                        Exit Function
                    End If
                End If
            End If

            'Verifica se foi Selecionado o Campo - Unidade de Medida
            If cboUnidadeMedidaProduto.Enabled = True Then
                If ValidaCampo(cboUnidadeMedidaProduto, lblUnidadeMedidaProduto) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Valor Unitário
            If txtValorUnitarioDescontoProduto.Enabled = True Then
                If ValidaCampo(txtValorUnitarioDescontoProduto, lblValorUnitarioDescontoProduto, True) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Desconto %
            If txtDescontoPercentualProduto.Value < 0 Then
                frmMain.errInfo.SetError(lblDescontoPercentualProduto, "O Campo [DESCONTO (%)] deve ser maior ou igual a 0 (Zero). Digite um valor válido para ele.")
                txtDescontoPercentualProduto.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Desconto Valor
            If txtDescontoValorProduto.Value < 0 Then
                frmMain.errInfo.SetError(lblDescontoValorProduto, "O Campo [DESCONTO (VALOR)] deve ser maior ou igual a 0 (Zero). Digite um valor válido para ele.")
                txtDescontoValorProduto.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Centro de Gasto
            If LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'valida_centro_custo'") = True Then
                If ValidaCampo(cboCentroGastoProduto, lblCentroGastoProduto) = False Then
                    Exit Function
                End If
            End If

            ''Verifica se foi Selecionado o Campo - Conta Contábil
            If LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'valida_conta_contabil'") = True Then
                If ValidaCampo(cboContaContabilProduto, lblContaContabilProduto) = False Then
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            ValidacaoProduto = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub DadosProduto()

        Try

            'Verifica se foi Selecionado algum Registro
            If cboProduto.SelectedIndex <> -1 Then

                'Abre Formulário
                If CType(LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'dados_produto_estoque'"), Boolean) = True Then
                    Dim oForm As New frmVenDadosProdutoEstoque
                    oForm.CodigoProduto = cboProduto.SelectedValue
                    Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)
                Else
                    Dim oForm As New frmVenDadosProduto
                    oForm.CodigoProduto = cboProduto.SelectedValue
                    Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)
                End If

                'Carrega Dados do Produto
                Call cboProduto_SelectedIndexChanged(cboProduto, System.EventArgs.Empty)

            Else
                'Informa o Usuário que é necessário selecionar um Produto
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub HistoricoProduto()

        Try

            'Verifica se foi Selecionado algum Registro
            If cboProduto.SelectedIndex <> -1 Then

                'Abre Formulário
                Dim oForm As New frmVenHistoricoProduto
                oForm.CodigoItem = cboProduto.SelectedValue
                oForm.Produto = cboProduto.Text
                Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            Else
                'Informa o Usuário que é necessário selecionar um Produto
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Private Sub EditarOrdemProducao(ByVal oGrid As GridEX)

        Try


            Dim oUserControl As UserControl
            Dim oAssembly As Assembly = GetExecutingAssembly()

            oUserControl = oAssembly.CreateInstance("INTERACTI." & "usrPrdOrdemProducaoManual")
            oUserControl.Dock = DockStyle.Fill
            oUserControl.Tag = "ID:" + CStr(oGrid.CurrentRow.Cells.Item("codigo_ordem_producao").Value)

            frmMain.LoadPage("Ordem Produção", "Ordem de Produção", oUserControl, True)

            Application.DoEvents()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: SERVIÇO :::"

    Private Sub AtualizarServico()

        Try

            Dim dQuantidade As Double = 0
            Dim dValorUnitario As Double = 0
            Dim dValorUnitarioDesconto As Double = 0
            Dim dValorTotalDesconto As Double = 0
            Dim dValorTotalImposto As Double = 0
            Dim dValorTotalImpostoIPI As Double = 0
            Dim dAliquotaISS As Double = 0
            Dim dAliquotaPISCOFINS As Double = 0
            Dim dAliquotaINSS As Double = 0
            Dim dAliquotaCSLL As Double = 0
            Dim dAliquotaIR As Double = 0
            Dim dValorISS As Double = 0
            Dim dValorPISCOFINS As Double = 0
            Dim dValorINSS As Double = 0
            Dim dValorCSLL As Double = 0
            Dim dValorIR As Double = 0
            Dim dPorcentagemDesconto As Double = 0
            Dim dDescontoUnitario As Double = 0

            dQuantidade = IIf(IsDBNull(grdOrcamentoPedidoCompraServico.GetValue("quantidade")), 0, grdOrcamentoPedidoCompraServico.GetValue("quantidade"))
            dValorUnitario = IIf(IsDBNull(grdOrcamentoPedidoCompraServico.GetValue("valor_unitario")), 0, grdOrcamentoPedidoCompraServico.GetValue("valor_unitario"))
            dValorUnitarioDesconto = IIf(IsDBNull(grdOrcamentoPedidoCompraServico.GetValue("valor_unitario_desconto")), 0, grdOrcamentoPedidoCompraServico.GetValue("valor_unitario_desconto"))
            dAliquotaISS = IIf(IsDBNull(grdOrcamentoPedidoCompraServico.GetValue("aliquota_iss")), 0, grdOrcamentoPedidoCompraServico.GetValue("aliquota_iss"))
            dAliquotaPISCOFINS = IIf(IsDBNull(grdOrcamentoPedidoCompraServico.GetValue("aliquota_pis_cofins")), 0, grdOrcamentoPedidoCompraServico.GetValue("aliquota_pis_cofins"))
            dAliquotaINSS = IIf(IsDBNull(grdOrcamentoPedidoCompraServico.GetValue("aliquota_inss")), 0, grdOrcamentoPedidoCompraServico.GetValue("aliquota_inss"))
            dAliquotaCSLL = IIf(IsDBNull(grdOrcamentoPedidoCompraServico.GetValue("aliquota_csll")), 0, grdOrcamentoPedidoCompraServico.GetValue("aliquota_csll"))
            dAliquotaIR = IIf(IsDBNull(grdOrcamentoPedidoCompraServico.GetValue("aliquota_ir")), 0, grdOrcamentoPedidoCompraServico.GetValue("aliquota_ir"))
            dPorcentagemDesconto = IIf(IsDBNull(grdOrcamentoPedidoCompraServico.GetValue("desconto_unitario_percentual")), 0, grdOrcamentoPedidoCompraServico.GetValue("desconto_unitario_percentual"))
            dDescontoUnitario = IIf(IsDBNull(grdOrcamentoPedidoCompraServico.GetValue("desconto_unitario_valor")), 0, grdOrcamentoPedidoCompraServico.GetValue("desconto_unitario_valor"))

            Select Case grdOrcamentoPedidoCompraServico.CurrentColumn.Key

                Case "valor_unitario"
                    dDescontoUnitario = (dValorUnitario * dPorcentagemDesconto) / 100.0
                    dValorUnitarioDesconto = dValorUnitario - (dValorUnitario * dPorcentagemDesconto) / 100.0

                Case "desconto_unitario_percentual"
                    dDescontoUnitario = (dValorUnitario * dPorcentagemDesconto) / 100.0
                    dValorUnitarioDesconto = dValorUnitario - (dValorUnitario * dPorcentagemDesconto) / 100.0

                Case "desconto_unitario_valor"
                    dValorUnitarioDesconto = dValorUnitario - dDescontoUnitario
                    dPorcentagemDesconto = (dDescontoUnitario / IIf(dValorUnitario <= 0, 1, dValorUnitario)) * 100.0

            End Select

            dValorTotalDesconto = dValorUnitarioDesconto * dQuantidade
            dValorISS = (dValorTotalDesconto * dAliquotaISS) / 100.0
            dValorPISCOFINS = (dValorTotalDesconto * dAliquotaPISCOFINS) / 100.0
            dValorINSS = (dValorTotalDesconto * dAliquotaINSS) / 100.0
            dValorCSLL = (dValorTotalDesconto * dAliquotaCSLL) / 100.0
            dValorIR = (dValorTotalDesconto * dAliquotaIR) / 100.0

            grdOrcamentoPedidoCompraServico.SetValue("desconto_unitario_valor", dDescontoUnitario)
            grdOrcamentoPedidoCompraServico.SetValue("desconto_unitario_percentual", dPorcentagemDesconto)
            grdOrcamentoPedidoCompraServico.SetValue("valor_unitario_desconto", dValorUnitarioDesconto)
            grdOrcamentoPedidoCompraServico.SetValue("valor_total_desconto", dValorTotalDesconto)
            grdOrcamentoPedidoCompraServico.SetValue("valor_iss", dValorISS)
            grdOrcamentoPedidoCompraServico.SetValue("valor_pis_cofins", dValorPISCOFINS)
            grdOrcamentoPedidoCompraServico.SetValue("valor_inss", dValorINSS)
            grdOrcamentoPedidoCompraServico.SetValue("valor_csll", dValorCSLL)
            grdOrcamentoPedidoCompraServico.SetValue("valor_ir", dValorIR)

            oClsCmpPedido.UpdateServicoGrid(grdOrcamentoPedidoCompraServico.CurrentRow)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoServico()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Serviço
            cboServico.SelectedIndex = -1
            txtComplementoProdutos.Text = ""
            txtQuantidadeServico.Value = 0
            cboUnidadeMedidaServico.SelectedIndex = -1
            txtValorServico.Value = 0
            dtpPrevisaoEntregaServico.Tag = ""
            dtpPrevisaoEntregaServico.Value = Now.Date
            txtDescontoServico.Value = 0
            txtValorTotalServico.Value = 0
            chkISSRetido.Checked = False
            txtAliquotaISS.Value = 0
            txtAliquotaPIS.Value = 0
            txtAliquotaCOFINS.Value = 0
            txtAliquotaINSS.Value = 0
            txtAliquotaCSLL.Value = 0
            txtAliquotaIR.Value = 0
            cboCentroGastoServico.SelectedIndex = -1
            cboContaContabilServico.SelectedIndex = -1
            btnInserirServico.Tag = ""
            cboMoeda.SelectedValue = "R$"
            txtFatorCambial.Value = 1
            dtpDataContratualServico.Checked = False
            dtpDataContratualServico.Value = Today.Date

            'Configura Valor Default
            Call ConfigureValorDefault(Me)

            'Seta Focu
            cboServico.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub InsertServico()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim sAuxiliar(1) As String
            Dim iCodigoPedidoItem As Integer = -1

            'Seta Váriavel
            If IsNumeric(btnInserirServico.Tag) Then
                iCodigoPedidoItem = grdOrcamentoPedidoCompraServico.CurrentRow.Cells("codigo_pedido_item").Value
            End If

            'Seta Váriavel - Prazo de Entrega
            If dtpPrevisaoEntregaServico.Tag <> "" And dtpPrevisaoEntregaServico.Tag <> "|" Then
                sAuxiliar = dtpPrevisaoEntregaServico.Tag.ToString.Split("|")
            Else
                sAuxiliar(0) = dtpPrevisaoEntregaServico.Value
                sAuxiliar(1) = txtQuantidadeServico.Value
            End If

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirServico.Tag) = False Then

                'Insere Item no Pedido de Compra
                oClsCmpPedido.InsertServico(cboServico.SelectedValue, _
                                            txtComplemento.Text.Trim, _
                                            txtQuantidadeServico.Value, _
                                            cboUnidadeMedidaServico.SelectedValue, _
                                            txtValorServico.Value, _
                                            txtDescontoServico.Value, _
                                            txtValorTotalServico.Value, _
                                            dtpPrevisaoEntregaServico.Value, _
                                            chkISSRetido.Checked, _
                                            txtAliquotaISS.Value, _
                                            txtAliquotaPIS.Value, _
                                            txtAliquotaINSS.Value, _
                                            txtAliquotaCSLL.Value, _
                                            txtAliquotaIR.Value, _
                                            IIf(cboCentroGastoServico.SelectedIndex = -1, -1, cboCentroGastoServico.SelectedValue), _
                                            IIf(cboContaContabilServico.SelectedIndex = -1, "", cboContaContabilServico.SelectedValue), _
                                            sAuxiliar(0).Split(";"), _
                                            sAuxiliar(1).Split(";"), _
                                            IIf(dtpDataContratualServico.Checked = True, dtpDataContratualServico.Value, ""))

                'Informa o Usuário sobre o sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroInserido)

            Else

                'Exclui Entrega do Item do Pedido de Compra
                Call oClsCmpPedido.DeleteItemEntrega(iCodigoPedidoItem)

                'Altera Item no Pedido de Compra
                oClsCmpPedido.UpdateServico(cboServico.SelectedValue, _
                                            txtComplemento.Text.Trim, _
                                            txtQuantidadeServico.Value, _
                                            cboUnidadeMedidaServico.SelectedValue, _
                                            txtValorServico.Value, _
                                            txtDescontoServico.Value, _
                                            txtValorTotalServico.Value, _
                                            dtpPrevisaoEntregaServico.Value, _
                                            chkISSRetido.Checked, _
                                            txtAliquotaISS.Value, _
                                            txtAliquotaPIS.Value, _
                                            txtAliquotaCOFINS.Value, _
                                            txtAliquotaINSS.Value, _
                                            txtAliquotaCSLL.Value, _
                                            txtAliquotaIR.Value, _
                                            IIf(cboCentroGastoServico.SelectedIndex = -1, -1, cboCentroGastoServico.SelectedValue), _
                                            IIf(cboContaContabilServico.SelectedIndex = -1, "", cboContaContabilServico.SelectedValue), _
                                            iCodigoPedidoItem, _
                                            sAuxiliar(0).Split(";"), _
                                            sAuxiliar(1).Split(";"), _
                                            IIf(dtpDataContratualServico.Checked = True, dtpDataContratualServico.Value, ""))

                'Informa o Usuário sobre o sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroAlterado)

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteServico()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdOrcamentoPedidoCompraServico) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Serviço
                    Call oClsCmpPedido.DeleteItem()

                    'Atualiza Totais
                    Call CalcularTotais()

                    'Prepara Formulário para a Inserção de um Novo Registro
                    Call NovoServico()

                    'Integração
                    Call Integracao()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarServico()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(iFormulario, gcUpdate) = True Then

                'Verifica o Status
                If grdOrcamentoPedidoCompraServico.CurrentRow.Cells("status").Value = CInt(StatusCompraPedidoItem.PedidoCompra) Then

                    'Carrega Controles
                    oClsCmpPedido.EditarServico(grdOrcamentoPedidoCompraServico.CurrentRow.Cells("codigo_pedido_item").Value, _
                                                cboServico, _
                                                txtComplemento, _
                                                txtValorServico, _
                                                txtQuantidadeServico, _
                                                cboUnidadeMedidaServico, _
                                                txtDescontoServico, _
                                                txtValorTotalServico, _
                                                dtpPrevisaoEntregaServico, _
                                                chkISSRetido, _
                                                txtAliquotaISS, _
                                                txtAliquotaPIS, _
                                                txtAliquotaCOFINS, _
                                                txtAliquotaINSS, _
                                                txtAliquotaCSLL, _
                                                txtAliquotaIR, _
                                                cboCentroGastoServico, _
                                                cboContaContabilServico, _
                                                dtpDataContratualServico)

                    btnInserirServico.Tag = grdOrcamentoPedidoCompraServico.CurrentRow.Cells("codigo_pedido_item").Value

                    'Seta Focu
                    cboServico.Focus()

                Else
                    'Informa o Usuário que este Serviço não pode ser alterado
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
                End If

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridServico()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid de Serviço
            oClsCmpPedido.LoadGridServico(grdOrcamentoPedidoCompraServico, _
                                          btnSalvar.Tag)

            'Calcula Totais
            Call CalcularTotais()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoServico() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoServico = False

            'Verifica se foi Selecionado o Campo - Serviço
            If ValidaCampo(cboServico, lblServico) = False Then
                tabDados.SelectedTab = pagServico : cboServico.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Quantidade
            If ValidaCampo(txtQuantidadeServico, lblQuantidadeServico, True) = False Then
                tabDados.SelectedTab = pagServico : txtQuantidadeServico.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Unidade de Medida
            If ValidaCampo(cboUnidadeMedidaServico, lblUnidadeMedidaServico) = False Then
                tabDados.SelectedTab = pagServico : cboUnidadeMedidaServico.Focus()
                Exit Function
            End If

            'Verifica se a Quantidade Parcial está correta
            Dim sAuxiliar(1) As String
            Dim sDataPrevisaoEntrega() As String
            Dim sQuantiade() As String
            If dtpPrevisaoEntregaServico.Tag <> "" Then
                sAuxiliar = dtpPrevisaoEntregaServico.Tag.ToString.Split("|")
                sDataPrevisaoEntrega = sAuxiliar(0).Split(";")
                sQuantiade = sAuxiliar(1).Split(";")
                If sDataPrevisaoEntrega.Length = 1 Then
                    dtpPrevisaoEntregaServico.Tag = dtpPrevisaoEntregaServico.Value & "|" & txtQuantidadeServico.Value
                Else
                    Dim dSomaQuantidade As Double = 0
                    Dim i As Integer
                    For i = 0 To UBound(sQuantiade)
                        dSomaQuantidade += sQuantiade(i)
                    Next i
                    If dSomaQuantidade <> txtQuantidadeServico.Value Then
                        frmMain.errInfo.SetError(lblPrevisaoEntregaServico, "A Quantidade do Serviço é diferente da Quantidade Desmembrada.")
                        Exit Function
                    End If
                End If
            End If

            'Verifica se foi Preenchido o Campo - Valor do Serviço
            If ValidaCampo(txtValorServico, lblValorServico, True) = False Then
                tabDados.SelectedTab = pagServico : txtValorServico.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Valor Líquido do Serviço
            If ValidaCampo(txtValorTotalServico, lblValorTotalServico, True) = False Then
                tabDados.SelectedTab = pagServico : txtValorTotalServico.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Alíquota ISS
            'If goEmitente.iRegimeTributario <> RegimeTributario.SimplesNacional AndAlso _
            '   goEmitente.iRegimeTributario <> RegimeTributario.SimplesNacionalExceto Then
            '    If ValidaCampo(txtAliquotaISS, chkISSRetido, True) = False Then
            '        tabDados.SelectedTab = pagServico : txtAliquotaISS.Focus()
            '        Exit Function
            '    End If
            'End If

            'Verifica se foi Selecionado o Campo - Centro de Gasto
            If LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'valida_centro_custo'") = True Then
                If ValidaCampo(cboCentroGastoServico, lblCentroGastoServico) = False Then
                    Exit Function
                End If
            End If

            ''Verifica se foi Selecionado o Campo - Conta Contábil
            If LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'valida_conta_contabil'") = True Then
                If ValidaCampo(cboContaContabilServico, lblContaContabilServico) = False Then
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            ValidacaoServico = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

#Region " ::: FINANCEIRO MANUAL ::: "

    Private Sub SalvarFinanceiro()

        Try


            'Deleta Dados da Fatura
            oClsCmpPedido.DeleteFinanceiro()

            'Salva Dados Fatura - Financeiro
            oClsCmpPedido.InsertFinanceiro(grdFinanceiro)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteFinanceiro()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdFinanceiro) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir o(s) Registro(s) Selecionado(s)?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro do Banco de Dados
                    Dim oRow As GridEXRow

                    For Each oRow In grdFinanceiro.GetCheckedRows
                        'Exclui Registro da Grid
                        oRow.Delete()
                    Next


                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                MsgBox("Primeiramente Selecione um ou mais Registros Válidos.", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarFinanceiro()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.FaturamentoEntradaNF, gcUpdate) = True Then

                'Carrega Controles
                txtFinanceiroNumeroParcela.Value = grdFinanceiro.CurrentRow.Cells("numero_parcela").Value
                txtFinanceiroIntervaloParcelas.Value = grdFinanceiro.CurrentRow.Cells("intervalo_parcela").Value
                txtFinanceiroPercentualParcela.Value = grdFinanceiro.CurrentRow.Cells("percentual_parcela").Value
                txtFinanceiroValorParcela.Value = grdFinanceiro.CurrentRow.Cells("valor_parcela").Value
                btnFinanceiroInserir.Tag = grdFinanceiro.CurrentRow.RowIndex
                btnFinanceitoExcluir.Tag = grdFinanceiro.CurrentRow.Cells("codigo").Value

                'Seta Focu
                txtFinanceiroNumeroParcela.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoFinanceiro()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            txtFinanceiroNumeroParcela.Value = 0
            txtFinanceiroIntervaloParcelas.Value = 0
            txtFinanceiroPercentualParcela.Value = 0
            txtFinanceiroValorParcela.Value = 0


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "::: ARQUIVO :::"

    Private Sub LoadGridArquivo()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCmpPedido.LoadGridArquivo(grdArquivo, _
                                                      btnSalvar.Tag)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarArquivo()

        Try

            Cursor.Current = Cursors.WaitCursor

            Dim oFileInfo As New System.IO.FileInfo(txtArquivo.Text.Trim)
            Dim sCaminho As String = LoadCodigo("sp_load_pasta_arquivo_compras_pedido " & goUsuario.iEmpresa)
            Dim sFile As String = sCaminho & Format(Now, "yy_MM_dd_hh_mm_ss_") & oFileInfo.Name

            System.IO.File.Copy(txtArquivo.Text.Trim, sFile)

            If Not IsNumeric(btnSalvar.Tag) Then Exit Sub

            oClsCmpPedido.InsertArquivo(btnSalvar.Tag, _
                                      txtTituloArquivo.Text.Trim, _
                                      sFile)

            frmMain.Informacao(Mensagem.RegistroInserido)



            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteArquivo()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdArquivo) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    oClsCmpPedido.ExcluirArquivo(btnSalvar.Tag)

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário sobre a necessidade de Selecionar um ou mais Itenss
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoArquivo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            LimparCamposGroupBox(grpArquivo)
            btnInserirArquivo.Tag = ""

            txtTituloArquivo.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoArquivo() As Boolean

        Try

            If ValidaCampo(txtTituloArquivo, lblTituloArquivo, TipoCampo.texto) = False Then Return False
            If ValidaCampo(txtArquivo, lblArquivo, TipoCampo.texto) = False Then Return False

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region " ::: INTEGRAÇÃO ::: "

    Private Sub Integracao()

        Try

            'Váriavel - Integração
            Dim oClsIntegracao As New clsIntegracao

            'Salva Financeiro - Receita
            oClsIntegracao.IntegracaoPedidoCompraFinanceiro(oClsCmpPedido.CodigoPedido,
                                                            IIf(grdFinanceiro.RowCount > 0, True, False))

            If dtpDataAdiantamento.Checked = True Then
                oClsIntegracao.IntegracaoPedidoCompraFinanceiroAdiantamento(oClsCmpPedido.CodigoPedido,
                                                                            IIf(grdFinanceiro.RowCount > 0, True, False))
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class


