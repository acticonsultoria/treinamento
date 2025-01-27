Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports CrystalDecisions.CrystalReports.Engine
Imports Janus.Windows.UI.Tab
Imports Janus.Windows.CalendarCombo
Imports System.IO
Imports System.Math
Imports System.Reflection
Imports System.Reflection.Assembly
Imports Microsoft.Office.Interop

Public Class usrVenPedidoLegado

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsVenPedidoLegado As New clsUsrVenPedidoLegado
    Private bSalvo As Boolean = True
    Private lCodigoPedidoOrcamento As Long = -1

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrVenPedido_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGridPedidoVenda() Else Control_Enter(sender)

                Case Keys.F3

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboClienteFiltro" : Call btnProcurarClienteFiltro_Click(btnProcurarClienteFiltro, System.EventArgs.Empty)
                        Case "cboItemFiltro" : Call btnProcurarItemFiltro_Click(btnProcurarItemFiltro, System.EventArgs.Empty)
                        Case "cboCliente" : Call btnProcurarCliente_Click(btnProcurarCliente, System.EventArgs.Empty)
                                  Case "cboTransportadora" : Call btnProcurarTransportadora_Click(btnProcurarTransportadora, System.EventArgs.Empty)
                     
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboCliente" : Call LoadCombo(cboCliente, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa, "sp_select_combo_cadastro_basico_cliente_negativacao " & goUsuario.iEmpresa, oTipoComboBox)
                                   Case "cboTransportadora" : Call LoadCombo(cboTransportadora, "sp_select_combo_cadastro_basico_transportadora " & goUsuario.iEmpresa)
                        Case "cboCondicaoPagamento" : Call LoadCombo(cboCondicaoPagamento, "sp_select_combo_cadastro_basico_condicao_pagamento " & goUsuario.iEmpresa)
                        Case "cboFormaPagamento" : Call LoadCombo(cboFormaPagamento, "sp_select_combo_static_forma_pagamento", True)
                         End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboCliente" : Call btnCadastrarCliente_Click(btnCadastrarCliente, System.EventArgs.Empty)
                        Case "cboTransportadora" : Call btnCadastrarTransportadora_Click(btnCadastrarTransportadora, System.EventArgs.Empty)
                        Case "cboCondicaoPagamento" : Call btnCadastrarCondicaoPagamento_Click(btnCadastrarCondicaoPagamento, System.EventArgs.Empty)
                          
                    
                    End Select

                

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrVenPedido_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        ConfigurarUserControl()

    End Sub


    Private Sub btnCriarItemFantasma_Click(sender As Object, e As EventArgs) Handles btnCriarItemFantasma.Click
        Try
            CriarItemFantasma()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

#End Region

#Region "::: PEDIDO VENDA :::"

    Private Sub btnGerarOrdemProducao_Click(sender As Object, e As EventArgs) Handles btnGerarOrdemProducao.Click

        Try

            GerarOrdemProducao()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub
    Private Sub btnRegistroAnterior_Click(sender As Object, e As EventArgs) Handles btnRegistroAnterior.Click

        Try


            'Caso o pedido esteja sendo editado através da geração do orçamento e não tenha sido salvo, irá excluir e voltar o status do orçamento
            If lCodigoPedidoOrcamento > 0 And bSalvo = False Then

                If MsgBox("Os dados do pedido de venda serão perdidos. Deseja continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

                oClsVenPedidoLegado.DeletePedidoOrcamento(lCodigoPedidoOrcamento)

            End If

            If oClsVenPedidoLegado.CodigoPedido <= 0 Then Exit Sub

            Dim lCodigo As Long = LoadCodigo("sp_load_venda_pedido_codigo " & oClsVenPedidoLegado.CodigoPedido & ", 1, " & goUsuario.iEmpresa)

            If lCodigo <= 0 Then
                MsgBox("Sem registros anteriores!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            EditarPedidoVenda(lCodigo, False)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnProximoRegistro_Click(sender As Object, e As EventArgs) Handles btnProximoRegistro.Click

        Try



            'Caso o pedido esteja sendo editado através da geração do orçamento e não tenha sido salvo, irá excluir e voltar o status do orçamento
            If lCodigoPedidoOrcamento > 0 And bSalvo = False Then

                If MsgBox("Os dados do pedido de venda serão perdidos. Deseja continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

                oClsVenPedidoLegado.DeletePedidoOrcamento(lCodigoPedidoOrcamento)

            End If


            If oClsVenPedidoLegado.CodigoPedido <= 0 Then Exit Sub

            Dim lCodigo As Long = LoadCodigo("sp_load_venda_pedido_codigo " & oClsVenPedidoLegado.CodigoPedido & ", 2, " & goUsuario.iEmpresa)

            If lCodigo <= 0 Then
                MsgBox("Sem registros posteriores!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            EditarPedidoVenda(lCodigo, False)


        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub


    Private Sub grdProducao_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdProducao.RowDoubleClick

        Try

            EditarOrdemProducao()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
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

    Private Sub btnProcurarClienteFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarClienteFiltro.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.cliente
            oComboBoxFind = cboClienteFiltro

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboClienteFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarItemFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarItemFiltro.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = LoadDescricao("sp_select_configuracao_interacti_texto " & goUsuario.iEmpresa & ",'formulario_find_produto_venda'")
            oForm.UsrControl = IIf(oForm.UsrControl = "", "usrFindItem", oForm.UsrControl)
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = IIf(cboTipoItemFiltro.SelectedIndex = -1, -1, cboTipoItemFiltro.SelectedValue)
            sItemVendaFind = "S"
            oComboBoxFind = cboItemFiltro

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)



        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCliente.Click

        Try

            'Verifica se o Cliente está habilitado
            If cboCliente.Enabled = False Then
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
                Exit Sub
            End If

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.cliente
            oComboBoxFind = cboCliente

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCliente.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarTransportadora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarTransportadora.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindTransportadora"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Transportadora"

            'Seta Váriaveis
            oComboBoxFind = cboTransportadora

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboTransportadora.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub


    Private Sub btnCadastrarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCliente.Click

        Try

            'Verifica se o Cliente está habilitado
            If cboCliente.Enabled = False Then
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
                Exit Sub
            End If

            'Carrega o form de parceiro de negócio
            LoadUsrControlForm(Me, "usrCadParceiroNegocio")

            'Carrega Combo            
            Call LoadCombo(cboCliente, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa, "sp_select_combo_cadastro_basico_cliente_negativacao " & goUsuario.iEmpresa, oTipoComboBox)

            'Seta Focu
            cboCliente.Focus()

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


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Try

            'Cancelar Registros
            Call CancelarPedidoVenda()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Deleta Registros
            Call DeletePedidoVenda()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Dados da Grid
            Call LoadGridPedidoVenda()

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
            If ValidacaoPedidoVenda() = True Then

                'Salva Dados do Registro
                Call SalvarPedidoVenda()


                'Seta Controle
                btnImprimir.Enabled = VerificaDireito(Formulario.ComercialPedidoVenda, gcPrint)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Try

            'Imprime Pedido de Venda
            Call ImprimirPedidoVenda(oClsVenPedidoLegado.CodigoPedido, False)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        Try

            'Verifica se não foi gerado o Pedido de Venda
            If txtNumeroPedido.Text = "" And txtValorFinalPedido.Value > 0 Then
                'Verifica se o usuário deseja sair do Orçamento
                If MsgBox("Os Dados do Pedido de Venda serão perdidos. Deseja continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.No Then
                    Exit Sub
                End If
            ElseIf txtNumeroPedido.Text <> "" And (grdProduto.GetDataRows.Count = 0) Then
                'Verifica se o usuário deseja sair do Orçamento
                If MsgBox("O Pedido de Venda será excluido uma vez que o mesmo não possui Produtos ou Serviços lançados. Deseja continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If

            'Caso o pedido esteja sendo editado através da geração do orçamento e não tenha sido salvo, irá excluir e voltar o status do orçamento
            If lCodigoPedidoOrcamento > 0 And bSalvo = False Then

                If MsgBox("Os dados do pedido de venda serão perdidos. Deseja continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

                oClsVenPedidoLegado.DeletePedidoOrcamento(lCodigoPedidoOrcamento)

            End If

            'Carrega Grid
            Call LoadGridPedidoVenda()

            'Alterna Aba        
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagListagem)

            'Seta Focu
            txtNumeroPedidoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboTipoItemFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoItemFiltro.SelectedIndexChanged

        Try

            'Carrega Combo
            Call LoadCombo(cboItemFiltro, "sp_select_combo_cadastro_basico_item_descricao " & goUsuario.iEmpresa & ", 1, NULL, " & IIf(cboTipoItemFiltro.SelectedIndex = -1, -1, cboTipoItemFiltro.SelectedValue))

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : EditarPedidoVenda(grdListagem.CurrentRow.Cells.Item("codigo_pedido").Value)
                Case "duplicar" : DuplicarPedidoVenda()
                Case "inserir_revisao" : InserirRevisaoPedidoVenda()
                Case "imprimir" : ImprimirPedidoVenda(grdListagem.CurrentRow.Cells.Item("codigo_pedido").Value, False)
                Case "email" : EmailPedidoVenda(grdListagem.CurrentRow.Cells.Item("codigo_pedido").Value)
                Case "comentario" : InserirHistorico()
                Case "historico_pedido" : HistoricoPedidoVenda()
                Case "imprimir_nota_fiscal" : ImprimirDanfe(grdListagem.CurrentRow.Cells.Item("codigo").Value)
                Case "atualizar_pedido" : AtualizarPedido()
                Case "ordem_producao" : EditarOrdemProducao2()
                Case "numero_orcamento" : EditarOrcamento()
            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.ComercialPedidoVenda)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.ComercialPedidoVenda, _
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
                                          Formulario.ComercialPedidoVenda, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnGerarForecast_Click(sender As Object, e As EventArgs) Handles btnGerarForeCast.Click

        Try

            GerarForeCast()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try

    End Sub
    Private Sub CalculaValorFinalPedido() Handles txtValorTotalPedido.ValueChanged

        Try

            'Váriaveis Locais
            Dim dValor As Double

            'Cálcula Valor Total
            dValor = txtValorTotalPedido.Value
            dValor -= txtValorIPI.Value

            'Seta Valor Final
            txtValorFinalPedido.Value = dValor

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ITEM :::"

    Private Sub grdProduto_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdProduto.CellUpdated

        Try

            'Verifica se Já existe uma OP para o pedido de venda (COMENTADO SOLICITAÇÃO LEGADO)
            'Dim iQtdOPVinculadas As Integer = LoadCodigo("sp_validate_venda_pedido_editar " & grdProduto.CurrentRow.Cells("codigo_pedido").Value & " , " & goUsuario.iEmpresa)
            'If iQtdOPVinculadas > 0 Then
            '    MessageBox.Show("Não é possível editar o pedido, já que uma ordem de produção está vinculada a ele")
            '    Exit Sub
            'End If

            oClsVenPedidoLegado.AtualizarDadosItem(grdProduto.CurrentRow)

            frmMain.Informacao(Mensagem.RegistroAlterado)

            'LoadGridProduto()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdProduto_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdProduto.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdProduto, _
                                     Formulario.ComercialPedidoVenda)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdProduto.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdProduto.Name, _
                                     Formulario.ComercialPedidoVenda, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdProduto.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdProduto.Name, _
                                          Formulario.ComercialPedidoVenda, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdProduto.RowDoubleClick
        Try

            If grdProduto.CurrentColumn.Key = "duplicar" Then
                Call DuplicarItem()
            ElseIf grdProduto.CurrentColumn.Key = "cancelar" Then
                Call CancelarItem()
            ElseIf grdProduto.CurrentColumn.Key = "historico" Then
                Call HistoricoItem()
            End If

            Select Case grdProduto.CurrentColumn.Key
                Case "duplicar"
                    Call DuplicarItem()
                Case "cancelar"
                    Call CancelarItem()
                Case "historico"
                    Call HistoricoItem()
                Case "numero_pedido_cliente"
                    AtualizarNumeroPedidoCliente()
                Case "cfop"
                    AtualizarCFOP()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

#End Region

#Region "::: ARQUIVO :::"

    Private Sub btnAgruparGridArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridArquivo.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdArquivo.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdArquivo.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdArquivo.GroupByBoxVisible = True
                grdArquivo.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridArquivo.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdArquivo
            oForm.NomeFormulario = Formulario.ComercialPedidoVenda
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdArquivo, Formulario.ComercialPedidoVenda)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridArquivo.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdArquivo)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
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

    Private Sub btnInserirArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirArquivo.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

  

            Cursor.Current = Cursors.WaitCursor

            Dim oFileInfo As New System.IO.FileInfo(txtArquivo.Text.Trim)
            Dim sCaminho As String = LoadCodigo("sp_load_pasta_arquivo_venda_pedido " & goUsuario.iEmpresa)
            Dim sFile As String = sCaminho & Format(Now, "yy_MM_dd_hh_mm_ss_") & oFileInfo.Name

            System.IO.File.Copy(txtArquivo.Text.Trim, sFile)

            oClsVenPedidoLegado.InsertArquivo(oClsVenPedidoLegado.CodigoPedido, _
                                                    txtTituloArquivo.Text.Trim, _
                                                    sFile)

            LimparCamposGroupBox(grpArquivo)

            oClsVenPedidoLegado.LoadGridArquivo(grdArquivo, _
                                          oClsVenPedidoLegado.CodigoPedido)

            frmMain.Informacao(Mensagem.RegistroInserido)

            Cursor.Current = Cursors.Default


        Catch ex As Exception
    'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirArquivo.Click

        Try

            'Deleta Registros
            Call DeleteArquivo()

            oClsVenPedidoLegado.LoadGridArquivo(grdArquivo, oClsVenPedidoLegado.CodigoPedido)

            'Prepara Formulário para Inserção de um Novo Registro
            Call NovoArquivo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdArquivo.RowDoubleClick

        Try

            'Verifica se foi pressionado uma Célula Válida
            If IsNothing(grdArquivo.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdArquivo.CurrentColumn.Key


                Case "visualizar" : Call VisualizarArquivo(grdArquivo.CurrentRow.Cells("caminho_arquivo").Value)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdArquivo.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdArquivo, _
                                     Formulario.ComercialPedidoVenda)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdArquivo.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdArquivo.Name, _
                                     Formulario.ComercialPedidoVenda, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdArquivo.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdArquivo.Name, _
                                          Formulario.ComercialPedidoVenda, _
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
            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf usrVenPedido_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.ComercialPedidoVenda, gcDelete)
            btnSalvar.Enabled = VerificaDireito(Formulario.ComercialPedidoVenda, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.ComercialPedidoVenda, gcInsert)
            btnExcelGridArquivo.Enabled = VerificaDireito(Formulario.ComercialPedidoVenda, gcInsert)

            'Verifica Direito - Botão de Cadastro
            btnCadastrarCliente.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcInsert)
            btnCadastrarTransportadora.Enabled = VerificaDireito(Formulario.CadastroBasicoTransportadora, gcInsert)
            btnCadastrarCondicaoPagamento.Enabled = VerificaDireito(Formulario.CadastroBasicoCondicaoPagamento, gcInsert)
            btnCadastrarObservacaoVenda.Enabled = VerificaDireito(Formulario.CadastroBasicoAutotexto, gcInsert)
            
            'Tipo - Combobox
            ReDim oTipoComboBox(2)
            oTipoComboBox(0).oColor = Color.Red : oTipoComboBox(0).sTipo = 1
            oTipoComboBox(1).oColor = Color.Peru : oTipoComboBox(1).sTipo = 2
            oTipoComboBox(2).oColor = Color.Black : oTipoComboBox(2).sTipo = 3

            'Carrega ComboBox  
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboCliente : oComboBox(1) = cboClienteFiltro
            LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa)
            LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_venda_pedido_item")

            LoadCombo(cboModalidadeFrete, "sp_select_combo_static_modalidade_frete", True)
            LoadCombo(cboTransportadora, "sp_select_combo_cadastro_basico_transportadora " & goUsuario.iEmpresa, False)
            LoadCombo(cboCondicaoPagamento, "sp_select_combo_cadastro_basico_condicao_pagamento " & goUsuario.iEmpresa, False)
            LoadCombo(cboFormaPagamento, "sp_select_combo_static_tipo_documento_pagamento", False)

            LoadCombo(cboItemFiltro, "sp_select_combo_cadastro_basico_item_descricao " & goUsuario.iEmpresa & ", 1, NULL, -1")
            cboTipoItemFiltro.Items.Clear()
            cboTipoItemFiltro.Items.Add("PRODUTO", TipoItem.produto)
            cboTipoItemFiltro.Items.Add("SERVIÇO", TipoItem.servico)

            LoadComboGrid(grdProduto, "cfop", "sp_select_combo_cadastro_basico_cfop " & goUsuario.iEmpresa & ",'S'")
            LoadComboGrid(grdProduto, "ncm", "sp_select_combo_cadastro_basico_ncm " & goUsuario.iEmpresa)


            'Configura DateTimer
            dtpDataPedidoInicioFiltro.Value = DateAdd(DateInterval.Day, (DatePart(DateInterval.Day, Now.Date) - 1) * -1, Now.Date) : dtpDataPedidoInicioFiltro.Checked = False
            dtpDataPedidoTerminoFiltro.Value = Now.Date : dtpDataPedidoTerminoFiltro.Checked = False

            'Seta Controles
            cboModalidadeFrete.Enabled = False

            'Seta Aba
            tabMain.TabPages.Remove(pagDados)

            'Configura Grid
            ConfiguraGrid(grdListagem, Formulario.ComercialPedidoVenda)
            ConfiguraGrid(grdProduto, Formulario.ComercialPedidoVenda)
            ConfiguraGrid(grdArquivo, Formulario.ComercialPedidoVenda)

            txtNumeroPedidoFiltro.Focus()

            If Me.Tag.ToString.Contains("ID:") = True Then
                bSalvo = False
                lCodigoPedidoOrcamento = Convert.ToInt64(Me.Tag.ToString.Replace("ID:", ""))
                EditarPedidoVenda(lCodigoPedidoOrcamento, True)
            End If

            If Me.Tag.ToString.Contains("ID2:") = True Then
                lCodigoPedidoOrcamento = Convert.ToInt64(Me.Tag.ToString.Replace("ID2:", ""))
                EditarPedidoVenda(lCodigoPedidoOrcamento, True)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: PEDIDO VENDA :::"
    Private Sub CriarItemFantasma()
        Try

            'Quesitona o usuário
            If MsgBox("Deseja criar um item e uma Ordem de Produção Fantasma, para agrupar as outras ordens de produção?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Criar Item Fantasma") = vbNo Then Exit Sub

            If bSalvo = False Then
                SalvarPedidoVenda()
            End If

            'Insere o item
            oClsVenPedidoLegado.InsertitemFantasma(oClsVenPedidoLegado.CodigoPedido)

            'informa o usuário
            frmMain.Informacao("Item criado com sucesso!", Color.Blue)

            'Carrega a grid de produto
            LoadGridProduto()

            'Carrega o combo novamente
            LoadCombo(cboItemPai, "sp_select_combo_pedido_venda_item_ordem_producao_topo " & oClsVenPedidoLegado.CodigoPedido & ", " & goUsuario.iEmpresa)


        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Function ValidarGeracaoOP(ByVal bForecast As Boolean) As Boolean
        Try

            ValidarGeracaoOP = False


            If grdProduto.GetCheckedRows.Count = 0 And bForecast = False Then

                frmMain.Informacao("Selecione ao menos um registro!", Color.Red)
                Exit Function

            End If

            Dim sVetorValidacao(5) As String
            sVetorValidacao(0) = "numero_pedido_cliente"
            sVetorValidacao(1) = "numero_pedido_item_cliente"
            sVetorValidacao(2) = "numero_desenho"
            sVetorValidacao(3) = "cfop"
            sVetorValidacao(4) = "data_entrega"
            sVetorValidacao(5) = "ncm"


            'Primeiro valida se pode gerar
            For Each oRow In grdProduto.GetCheckedRows

                With oRow.Cells

                    Dim sItem As String = oRow.Cells.Item("descricao").Value

                    If bForecast = False Then

                        'Valida se já foi aberta OP
                        If oRow.Cells.Item("quantidade_producao").Value > 0.0 Then

                            'Informa o usuário
                            frmMain.Informacao("Não é possível gerar a OP do item [ " & sItem & " ] pois já foram geradas OP's para essa linha de pedido de venda!", Color.Blue)

                            'Sai da função
                            Exit Function

                        End If

                        'Valida se existe pendencias de abertura de OP
                        If oRow.Cells.Item("quantidade_pendente").Value = 0.0 Then

                            'Informa o usuário
                            frmMain.Informacao("Não é possível gerar a OP do item [ " & sItem & " ] pois não existe pendências para essa linha de pedido!", Color.Blue)

                            'Sai da função
                            Exit Function

                        End If

                    End If


                    'Percorre as colunas que devem ser validadas
                    For i As Integer = 0 To UBound(sVetorValidacao)

                        If IsDBNull(oRow.Cells.Item(sVetorValidacao(i)).Value) Then

                            frmMain.Informacao("Não é possível gerar a OP do item [ " & sItem & " ] pois não foi preenchido o campo [ " & grdProduto.RootTable.Columns(sVetorValidacao(i)).Caption & " ] !", Color.Red)
                            Exit Function

                        End If

                        If CStr(oRow.Cells.Item(sVetorValidacao(i)).Value) = "" Then

                            frmMain.Informacao("Não é possível gerar a OP do item [ " & sItem & " ] pois não foi preenchido o campo [ " & grdProduto.RootTable.Columns(sVetorValidacao(i)).Caption & " ] !", Color.Red)
                            Exit Function

                        End If

                    Next


                End With

            Next




            ValidarGeracaoOP = True

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub GerarOrdemProducao()

        Try


            'Valida se está preenchido
            If ValidarGeracaoOP(False) = False Then Exit Sub

            'Verifica com usuario
            If MsgBox("Deseja gerar a(s) Ordem(ns) de Produção do Pedido de Venda?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Geração de Ordem de Produção") = vbNo Then Exit Sub

            If bSalvo = False Then
                SalvarPedidoVenda()
            End If


            Dim oClsUsrPrdPlanejamento As New clsUsrPrdPlanejamento

            For Each oRow In grdProduto.GetCheckedRows

                With oRow.Cells

                    'Gera as ordens de produção
                    oClsUsrPrdPlanejamento.GerarOrdemProducao(.Item("codigo_item").Value, _
                                                              .Item("quantidade").Value, _
                                                              .Item("quantidade").Value, _
                                                              .Item("codigo_pedido").Value, _
                                                              .Item("codigo_pedido_item").Value, _
                                                              .Item("codigo_pedido_item_entrega").Value, _
                                                              .Item("data_entrega").Value, _
                                                              IIf(cboItemPai.SelectedIndex = -1, -1, cboItemPai.SelectedValue), _
                                                              .Item("codigo_orcamento").Value, _
                                                              .Item("codigo_orcamento_item").Value, _
                                                              chkAgrupar.Checked)

                End With

            Next

            'Atualiza a porcentagem de faturamento das OP's
            ExecuteQuery("sp_update_producao_ordem_producao_porcentagem_faturamento " & goUsuario.iEmpresa)

            SalvarPedidoVenda()

            'Carrega a grid novamente
            LoadGridProduto()

            'Carrega as OP's
            LoadGridProducao()

            'Informa o usuário
            frmMain.Informacao("Ordens de produção geradas com sucesso!", Color.Blue)


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub GerarForeCast()

        Try


            'Valida antes se pode gerar
            If ValidarGeracaoOP(True) = False Then Exit Sub

            'Salva o pedido
            If bSalvo = False Then
                SalvarPedidoVenda()
            End If

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico

            'Faz verificação para puxar o formulário específico do cliente
            oForm.UsrControl = "usrPrdPlanejamento"
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location : oForm.Tamanho = True
            oForm.Titulo = Me.Parent.Text
            oForm.Tag = "ID:" + CStr(oClsVenPedidoLegado.CodigoPedido)

            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            SalvarPedidoVenda()

            'Carrega a grid
            LoadGridProducao()

            'Carrega a grid novamente
            LoadGridProduto()

            Application.DoEvents()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarOrdemProducao2()

        Try

            Dim lCodigo As Long = -1

            If grdListagem.GetValue("codigo_ordem_producao").ToString.Contains(",") Then

                Dim oForm As New frmVenOrcamentoEscolherOrdemProducao
                oForm.Codigos = grdListagem.GetValue("codigo_ordem_producao")

                oForm.ShowDialog()

                lCodigo = oForm.Codigo

            Else

                lCodigo = grdListagem.GetValue("codigo_ordem_producao")

            End If

            Dim oUserControl As UserControl
            Dim oAssembly As Assembly = GetExecutingAssembly()

            If lCodigo <= 0 Then Exit Sub

            oUserControl = oAssembly.CreateInstance("INTERACTI." & "usrPrdOrdemProducaoManual")
            oUserControl.Dock = DockStyle.Fill
            oUserControl.Tag = "ID:" + CStr(lCodigo)

            frmMain.LoadPage("Ordem Produção", "Ordem de Produção", oUserControl, True)

            Application.DoEvents()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarOrcamento()

        Try

            Dim oUserControl As UserControl
            Dim oAssembly As Assembly = GetExecutingAssembly()

            oUserControl = oAssembly.CreateInstance("INTERACTI." & "usrVenOrcamentoLegado")
            oUserControl.Dock = DockStyle.Fill
            oUserControl.Tag = "ID:" + CStr(grdListagem.GetValue("codigo_orcamento"))

            frmMain.LoadPage("Orçamento", "Orçamento", oUserControl, True)

            Application.DoEvents()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarOrdemProducao()

        Try

            Dim oUserControl As UserControl
            Dim oAssembly As Assembly = GetExecutingAssembly()

            oUserControl = oAssembly.CreateInstance("INTERACTI." & "usrPrdOrdemProducaoManual")
            oUserControl.Dock = DockStyle.Fill
            oUserControl.Tag = "ID:" + CStr(grdProducao.GetValue("codigo"))

            frmMain.LoadPage("Ordem Produção", "Ordem de Produção", oUserControl, True)

            Application.DoEvents()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub AtualizarPedido()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            If VerificaDireito(229, gcSelect) = True Then

                oClsVenPedidoLegado.AtualizarStatusPedido(grdListagem.GetValue("codigo_pedido"))

                LoadGridPedidoVenda()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Usuário sem permissão de atualizar pedido")
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridPedidoVenda()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim sStatus As String = ""


            'Status
            For Each oRow As GridEXRow In cboStatusFiltro.DropDownList.GetCheckedRows
                sStatus &= IIf(sStatus = "", "", ",") & oRow.Cells("codigo").Value
            Next

            'Carrega Controles
            oClsVenPedidoLegado.LoadGridPedido(grdListagem, _
                                         IIf(IsNumeric(txtNumeroPedidoFiltro.Text.Trim), txtNumeroPedidoFiltro.Text.Trim, -1), _
                                         IIf(dtpDataPedidoInicioFiltro.Checked = False, "", dtpDataPedidoInicioFiltro.Value), _
                                         IIf(dtpDataPedidoTerminoFiltro.Checked = False, "", dtpDataPedidoTerminoFiltro.Value), _
                                         -1, _
                                         IIf(cboClienteFiltro.SelectedIndex = -1, -1, cboClienteFiltro.SelectedValue), _
                                         txtNumeroPedidoClienteFiltro.Text.Trim, _
                                         sStatus, _
                                         IIf(cboTipoItemFiltro.SelectedIndex = -1, -1, cboTipoItemFiltro.SelectedValue), _
                                         -1, _
                                         IIf(cboItemFiltro.SelectedIndex = -1, -1, cboItemFiltro.SelectedValue))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarPedidoVenda(ByVal lCodigoPedidoCapa As Long, _
                                  Optional ByVal bAlternarAba As Boolean = True)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.ComercialPedidoVenda, gcUpdate) = True Then

                'Limpa Formulário
                Call NovoPedidoVenda()

                'Seta Código
                oClsVenPedidoLegado.CodigoPedido = lCodigoPedidoCapa
                'Seta Controle
                btnSalvar.Tag = lCodigoPedidoCapa

                'Váriaveis Locais
                Dim iStatusFinanceiro As Integer

                'Carrega Controles
                Call oClsVenPedidoLegado.LoadControlesPedido(lCodigoPedidoCapa, _
                                                       txtNumeroPedido, _
                                                       dtpDataPedido, _
                                                       cboCliente, _
                                                       cboModalidadeFrete, _
                                                       cboTransportadora, _
                                                       txtObservacao, _
                                                       txtReferencia, _
                                                       cboCondicaoPagamento, _
                                                       cboFormaPagamento, _
                                                       txtValorTotalPedido, _
                                                       txtValorFinalPedido, _
                                                       txtComprador, _
                                                       iStatusFinanceiro, _
                                                       txtNumeroOrcamento)

                oClsVenPedidoLegado.LoadGridArquivo(grdArquivo, oClsVenPedidoLegado.CodigoPedido)


                'Carrega Grid de Produto
                Call LoadGridProduto()

                'carrega a grid de produção
                LoadGridProducao()

                'Carrega o combo dos  itens pais com OP
                LoadCombo(cboItemPai, "sp_select_combo_pedido_venda_item_ordem_producao_topo " & oClsVenPedidoLegado.CodigoPedido & ", " & goUsuario.iEmpresa)

                'Carrega Grid de Vendedor
                Call oClsVenPedidoLegado.LoadGridVendedor(grdVendedor, lCodigoPedidoCapa)

                'Verifica se existe produto lançado
                If grdProduto.GetDataRows.Count > 0 Then cboModalidadeFrete.Enabled = True

                'Seta Controle
                btnImprimir.Enabled = VerificaDireito(Formulario.ComercialPedidoVenda, gcPrint)
                btnSalvar.Enabled = IIf(iStatusFinanceiro = CInt(StatusTitulo.Aberto), VerificaDireito(Formulario.ComercialPedidoVenda, gcInsert), False)

                'Alterna Aba
                If bAlternarAba = True Then
                    tabMain.TabPages.Remove(pagListagem)
                    tabMain.TabPages.Add(pagDados)
                End If

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
    Private Sub LoadGridProducao()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsVenPedidoLegado.LoadGridProducao(grdProducao, _
                                                       oClsVenPedidoLegado.CodigoPedido)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Private Sub NovoPedidoVenda()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Dados Gerais
            txtNumeroPedido.Text = ""
            txtNumeroPedido.Tag = ""

            LimparCamposGroupBox(grpInformacoes)
            LimparCamposGroupBox(grpDadosVenda)
            LimparCamposGroupBox(grpTotal)

            'Limpa Grid - Vendedor
            Call oClsVenPedidoLegado.LoadGridVendedor(grdVendedor, -1)
            oClsVenPedidoLegado.LoadGridProducao(grdProduto, -1)

            'Configura Valor Default
            Call ConfigureValorDefault(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarPedidoVenda()

        Try

            'Verifica se Já existe uma OP para o pedido de venda (COMENTADO SOLICITAÇÃO LEGADO)
            'Dim iQtdOPVinculadas As Integer = LoadCodigo("sp_validate_venda_pedido_editar " & grdProduto.CurrentRow.Cells("codigo_pedido").Value & " , " & goUsuario.iEmpresa)
            'If iQtdOPVinculadas > 0 Then
            '    MessageBox.Show("Não é possível editar o pedido, já que uma ordem de produção está vinculada a ele")
            '    Exit Sub
            'End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsVenPedidoLegado.CodigoPedido = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1)
            oClsVenPedidoLegado.DataPedido = dtpDataPedido.Value
            oClsVenPedidoLegado.CodigoCliente = cboCliente.SelectedValue
            oClsVenPedidoLegado.Comprador = txtComprador.Text.Trim
            oClsVenPedidoLegado.CodigoModalidadeFrete = IIf(cboModalidadeFrete.SelectedIndex = -1, -1, cboModalidadeFrete.SelectedValue)
            oClsVenPedidoLegado.CodigoIncoterms = -1
            oClsVenPedidoLegado.CodigoCampanha = -1
            oClsVenPedidoLegado.CodigoEnderecoEntrega = -1
            oClsVenPedidoLegado.CodigoTransportadora = IIf(cboTransportadora.SelectedIndex = -1, -1, cboTransportadora.SelectedValue)
            oClsVenPedidoLegado.TermoGarantia = ""
            oClsVenPedidoLegado.CondicaoFornecimento = ""
            oClsVenPedidoLegado.Observacao = txtObservacao.Text.Trim
            oClsVenPedidoLegado.Referencia = txtReferencia.Text.Trim
            oClsVenPedidoLegado.CodigoCondicaoPagamento = IIf(cboCondicaoPagamento.SelectedIndex = -1, -1, cboCondicaoPagamento.SelectedValue)
            oClsVenPedidoLegado.CodigoFormaPagamento = IIf(cboFormaPagamento.SelectedIndex = -1, -1, cboFormaPagamento.SelectedValue)
            oClsVenPedidoLegado.CodigoMoeda = 1 'real fixo
            oClsVenPedidoLegado.FatorCambial = 1
            oClsVenPedidoLegado.ValorTotal = txtValorTotalPedido.Value
            oClsVenPedidoLegado.ValorDesconto = 0
            oClsVenPedidoLegado.DescontoGeral = 0
            oClsVenPedidoLegado.AcrescimoGeral = 0
            oClsVenPedidoLegado.ValorFinal = txtValorFinalPedido.Value
            oClsVenPedidoLegado.RO = 0
            oClsVenPedidoLegado.CodigoUsuario = goUsuario.iEmpresa
            oClsVenPedidoLegado.Liberacao = ""

            'Atualiza Registro
            oClsVenPedidoLegado.Update()
            oClsVenPedidoLegado.DeleteVendedor()
            oClsVenPedidoLegado.InsertVendedor(grdVendedor)
            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

            bSalvo = True

            'Seta Controle
            txtNumeroPedido.Text = oClsVenPedidoLegado.NumeroPedido

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeletePedidoVenda()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdListagem, "status", CInt(StatusTitulo.Aberto)) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Verifica se Já existe uma OP para o pedido de venda
                    Dim iQtdOPVinculadas As Integer = LoadCodigo("sp_validate_venda_pedido_editar " & grdListagem.CurrentRow.Cells("codigo_pedido").Value & " , " & goUsuario.iEmpresa)
                    If iQtdOPVinculadas > 0 Then
                        MessageBox.Show("Não é possível excluir o pedido, já que uma ordem de produção está vinculada a ele")
                        Exit Sub
                    End If

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsVenPedidoLegado.Delete()

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

    Private Sub CancelarPedidoVenda()

        Try

            'Verifica se o usuário tem direito de Cancelar algum registro
            If VerificaDireito(Formulario.ComercialPedidoVenda, gcAdministrator) = True Then

                'Verifica se Já existe uma OP para o pedido de venda
                Dim iQtdOPVinculadas As Integer = LoadCodigo("sp_validate_venda_pedido_editar " & grdListagem.CurrentRow.Cells("codigo_pedido").Value & " , " & goUsuario.iEmpresa)
                If iQtdOPVinculadas > 0 Then
                    MessageBox.Show("Não é possível editar o pedido, já que uma ordem de produção está vinculada a ele")
                    Exit Sub
                End If

                'Verifica o Pedido de Venda pode ser Cancelado
                If VerificaSelecaoRowCancelar(grdListagem) = True Then

                    'Váriaveis Locais
                    Dim oForm As New frmVenPedidoCancelar
                    'Seta Tamanho e Localização do Formulário
                    oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location
                    'Abre Formulário
                    Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)
                    'Carrega a Grid
                    Call LoadGridPedidoVenda()

                Else
                    'Informa o Usuário que o Pedido de Venda não pode ser Cancelado
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

    Private Sub EmailPedidoVenda(ByVal lCodigoPedidoVenda As Long)

        Try

            'Váriaveis Locais
            Dim oRptDocument As New ReportDocument

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriavel - Relatório
            Dim sReport As String = ""

            'Váriavel - Formulário
            Dim oForm As New frmRptSelecionar
            oForm.Tipo = "PEDIDO DE VENDA"
            oForm.ShowDialog(Me)
            sReport = oForm.Relatorio

            'Verifica o Relatório
            If sReport = "" Then Exit Sub

            'Carrega Váriavel
            sReport &= ".rpt"

            'Abre Relatório
            oRptDocument.Load(goCrystalReport.sPath & sReport, _
                              CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)

            'Seta Parametros Relatório
            oRptDocument.SetParameterValue("@codigo_pedido", lCodigoPedidoVenda)
            oRptDocument.SetParameterValue("@codigo_empresa", goUsuario.iEmpresa)
            oRptDocument.SetParameterValue("usuario", goUsuario.sNome)

            'Abre Conexão com o Banco de Dados
            For i = 0 To oRptDocument.DataSourceConnections.Count - 1
                oRptDocument.DataSourceConnections.Item(i).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)
            Next

            'Arquivo
            Dim sArquivo As String = System.IO.Path.GetTempPath
            sArquivo &= grdListagem.CurrentRow.Cells("numero_pedido").Value.ToString.Replace("/", "-").Replace("\", "-") & ".pdf"

            'Exporta para Arquivo PDF
            oRptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, _
                                      sArquivo)

            'Limpa Váriavel
            oRptDocument = Nothing

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Enviar E-mail
            Call EnviarEmail(goUsuario.sEmpresa & " - Pedido de Venda " & grdListagem.CurrentRow.Cells("numero_pedido").Value, _
                             LoadContatoVenda(grdListagem.CurrentRow.Cells("codigo_pedido").Value), _
                             sArquivo, _
                             sArquivo, _
                             "", _
                             grdListagem.CurrentRow.Cells("codigo_cliente").Value, _
                             "", _
                             -1, _
                             -1, _
                             TipoAutotextoEmail.PedidoVenda)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ImprimirPedidoVenda(ByVal lCodigoPedidoCapa As Long, _
                                    ByVal bAll As Boolean)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriavel - Relatório
            Dim sReport As String = ""

            'Váriavel - Formulário
            Dim oForm As New frmRptSelecionar
            oForm.Tipo = "PEDIDO DE VENDA"
            oForm.ShowDialog(Me)
            sReport = oForm.Relatorio

            'Verifica o Relatório
            If sReport = "" Then Exit Sub

            If bAll = True Then

                sReport += "_ALL"

            End If


            'Carrega Váriavel
            sReport &= ".rpt"

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
            'Seta Parametros - Report
            oReport.Tabela = "tb_ven_pedido"
            oReport.Codigo = lCodigoPedidoCapa
            oReport.Arquivo = False
            'Abre Relatório
            frmMain.LoadPageReport("VEN000000002 - P", "Pedido de Venda", oReport)

            
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub InserirRevisaoPedidoVenda()

        Try

            'Verifica se o Registro é Válido
            If grdListagem.CurrentRow.Cells("status").Value = CInt(StatusVendaPedidoItem.PedidoVenda) Then

                'Verifica se foi Selecionado Algum Cliente
                If MsgBox("Deseja Gerar Nova Revisão do Pedido de Venda Selecionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Duplica Pedido de Venda
                    oClsVenPedidoLegado.InsertRevisao(grdListagem.CurrentRow.Cells("codigo_pedido").Value)

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                    'Carrega o Pedido de Venda
                    Call EditarPedidoVenda(oClsVenPedidoLegado.CodigoPedido)

                End If

            Else

                'Informa o Usuário sobre a necessidade de selecionar um Registro Válido
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Selecione um Registro com Status = Pedido de Venda.")

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DuplicarPedidoVenda()

        Try

            'Verifica se foi Selecionado Algum Cliente
            If MsgBox("Deseja Duplicar o Pedido de Venda Selecionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                'Duplica Pedido de Venda
                oClsVenPedidoLegado.Duplicar(grdListagem.CurrentRow.Cells("codigo_pedido").Value)

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

                'Carrega o Pedido de Venda
                Call EditarPedidoVenda(oClsVenPedidoLegado.CodigoPedido)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub InserirHistorico()

        Try

            'Váriaveis - Formulário
            Dim oForm As New frmVenPedidoHistoricoInserir
            'Seta Tamanho e Localização do Formulário
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location

            'Seta Controle
            oForm.Grid = grdListagem

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub HistoricoPedidoVenda()

        Try

            'Váriaveis - Formulário
            Dim oForm As New frmVenPedidoHistorico
            'Seta Tamanho e Localização do Formulário
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location

            'Seta Controle
            oForm.Grid = grdListagem

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function VerificaSelecaoRowPedidoNaoFaturado(ByVal oGrid As GridEX) As Boolean

        Try

            'Váriaveis Locais
            Dim oRow As GridEXRow

            'Seta Retorno da Função
            VerificaSelecaoRowPedidoNaoFaturado = False

            'Verifica se foi Selecionado Algum Registro
            If oGrid.GetCheckedRows.Count = 0 Then
                Exit Function
            End If

            'Redimensiona Vetor
            ReDim gSelecaoRow(0)

            For Each oRow In oGrid.GetCheckedRows

                'Verifica se o Pedido de Venda foi Faturado
                If oRow.Cells("valor").Value > oRow.Cells("valor_faturado").Value Then
                    'Redimensiona Vetor caso necessário
                    If Not gSelecaoRow(UBound(gSelecaoRow)) Is Nothing Then
                        ReDim Preserve gSelecaoRow(UBound(gSelecaoRow) + 1)
                    End If
                    'Seta Retorno da Função
                    VerificaSelecaoRowPedidoNaoFaturado = True
                    'Seta Valores
                    gSelecaoRow(UBound(gSelecaoRow)) = oRow
                End If

            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function VerificaSelecaoRowCancelar(ByVal oGrid As GridEX) As Boolean

        Try

            'Variáveis Loais
            Dim oRow As GridEXRow

            'Redimensiona Vetor
            ReDim gSelecaoRow(0)

            'Seta Retorno da Função
            VerificaSelecaoRowCancelar = False

            With oGrid

                'Verifica se foi selecionado algum registro para salvar
                If .GetCheckedRows.Length > 0 Then

                    'Varrendo os itens selecionados
                    For Each oRow In .GetCheckedRows

                        'Verifica se o Pedido é Válido
                        If ((oRow.Cells("valor_pedido").Value - oRow.Cells("valor_faturado").Value - oRow.Cells("valor_cancelado").Value) > 0) Then

                            'Redimensiona Vetor caso necessário
                            If Not gSelecaoRow(UBound(gSelecaoRow)) Is Nothing Then
                                ReDim Preserve gSelecaoRow(UBound(gSelecaoRow) + 1)
                            End If

                            'Seta Retorno da Função
                            VerificaSelecaoRowCancelar = True

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

    

    Private Function ValidacaoPedidoVenda() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoPedidoVenda = False

            'Verifica se foi Selecionado o Campo - Cliente
            If ValidaCampo(cboCliente, lblCliente) = False Then
                tabDados.SelectedTab = pagProduto
                cboCliente.Focus()
                Exit Function
            End If

            'Verifica se o Cliente possui titulos em Atraso
            Dim dValor As Double = LoadDescricao("sp_select_venda_pedido_dados_cliente " & cboCliente.SelectedValue & ", " & goUsuario.iEmpresa)
            If dValor > 0 Then
                If MsgBox("O Cliente: " & cboCliente.Text & " possui R$ " & FormatNumber(dValor, 2, Microsoft.VisualBasic.TriState.True) & " em atraso. Deseja Continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.No Then
                    Exit Function
                End If
            End If

            'Verifica se foi inserido algum Item
            If grdProduto.GetDataRows.Count = 0 Then
                tabDados.SelectedTab = pagProduto
                frmMain.Informacao(Mensagem.ValidacaoInserir)
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Modalidade de Frete
            If grdProduto.GetDataRows.Count > 0 Then
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


            'Seta Retorno da Função
            ValidacaoPedidoVenda = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub CalcularTotais()
        Try

            txtValorTotalPedido.Value = grdProduto.GetTotalRow.Cells("valor_total").Value
            txtValorIPI.Value = grdProduto.GetTotalRow.Cells("valor_ipi").Value
            txtValorFinalPedido.Value = txtValorTotalPedido.Value + txtValorIPI.Value

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AtualizarNumeroPedidoCliente()
        Try
            If MsgBox("Deseja alterar o N° PO Cliente para os demais itens?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atualização em massa") = MsgBoxResult.Yes Then

                'Verifica se Já existe uma OP para o pedido de venda (COMENTADO SOLICITAÇÃO LEGADO)
                'Dim iQtdOPVinculadas As Integer = LoadCodigo("sp_validate_venda_pedido_editar " & btnSalvar.Tag & " , " & goUsuario.iEmpresa)
                'If iQtdOPVinculadas > 0 Then
                '    MessageBox.Show("Não é possível editar o pedido, já que uma ordem de produção está vinculada a ele")
                '    Exit Sub
                'End If

                Dim sNumeroPedidoCliente As String = grdProduto.CurrentRow.Cells("numero_pedido_cliente").Value
                Dim iCFOP As Integer = grdProduto.CurrentRow.Cells("cfop").Value

                oClsVenPedidoLegado.AtualizarDadosEmMassa(1, sNumeroPedidoCliente, iCFOP)

                'Carrega Grid de Produto
                Call LoadGridProduto()

            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AtualizarCFOP()
        Try
            If MsgBox("Deseja alterar o CFOP para os demais itens?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atualização em massa") = MsgBoxResult.Yes Then


                'Verifica se Já existe uma OP para o pedido de venda (COMENTADO SOLICITAÇÃO LEGADO)
                'Dim iQtdOPVinculadas As Integer = LoadCodigo("sp_validate_venda_pedido_editar " & btnSalvar.Tag & " , " & goUsuario.iEmpresa)
                'If iQtdOPVinculadas > 0 Then
                '    MessageBox.Show("Não é possível editar o pedido, já que uma ordem de produção está vinculada a ele")
                '    Exit Sub
                'End If

                Dim sNumeroPedidoCliente As String = grdProduto.CurrentRow.Cells("numero_pedido_cliente").Value
                Dim iCFOP As Integer = grdProduto.CurrentRow.Cells("cfop").Value

                oClsVenPedidoLegado.AtualizarDadosEmMassa(2, sNumeroPedidoCliente, iCFOP)

                'Carrega Grid de Produto
                Call LoadGridProduto()

            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


#End Region

#Region "::: ITEM :::"

    Private Sub LoadGridProduto()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid de Produto
            oClsVenPedidoLegado.LoadGridProduto(grdProduto, btnSalvar.Tag)

            'Carrega os dados
            CalcularTotais()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CancelarItem()
        Try

            'Verifica se Já existe uma OP para o pedido de venda
            Dim iQtdOPVinculadas As Integer = LoadCodigo("sp_validate_venda_pedido_editar " & grdProduto.CurrentRow.Cells("codigo_pedido").Value & " , " & goUsuario.iEmpresa & " , " & grdProduto.CurrentRow.Cells("codigo_pedido_item").Value)
            If iQtdOPVinculadas > 0 Then
                MessageBox.Show("Não é possível cancelar o item, uma ordem de produção está vinculada a ele")
                Exit Sub
            End If

            'Verifica se o usuário tem direito de Cancelar algum registro
            If VerificaDireito(Formulario.ComercialPedidoVenda, gcAdministrator) = True Then

                'Verifica o status do Pedido de Venda
                If grdProduto.CurrentRow.Cells("status").Value = CInt(StatusVendaPedidoItem.PedidoVenda) Or grdProduto.CurrentRow.Cells("status").Value = CInt(StatusVendaPedidoItem.ParcialmenteFaturado) Then


                    'Váriaveis Locais
                    Dim oForm As New frmVenPedidoCancelarItem
                    'Seta Tamanho e Localização do Formulário
                    oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location
                    'Seta Parametros
                    oForm.Grid = grdProduto
                    'Abre Formulário
                    Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                    'Carrega Grid
                    Call LoadGridProduto()

                Else
                    'Informa o Usuário que o Pedido de Venda não pode ser Cancelado
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
    Private Sub DuplicarItem()
        Try

            If MsgBox("Deseja duplicar o item do pedido de venda?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Duplicar Item") = vbNo Then Exit Sub

            'Verifica se Já existe uma OP para o pedido de venda (COMENTADO SOLICITAÇÃO LEGADO)
            'Dim iQtdOPVinculadas As Integer = LoadCodigo("sp_validate_venda_pedido_editar " & grdProduto.CurrentRow.Cells("codigo_pedido").Value & " , " & goUsuario.iEmpresa)
            'If iQtdOPVinculadas > 0 Then
            '    MessageBox.Show("Não é possível editar o pedido, já que uma ordem de produção está vinculada a ele")
            '    Exit Sub
            'End If

            Dim sInput As String = InputBox("Digite a quantidade da nova linha:", "Duplicar", grdProduto.GetValue("quantidade"))

            'Verifica se digitou quantidade correta
            If Not IsNumeric(sInput) Then Exit Sub

            'Insere o item espelhado com a nova quantidade
            oClsVenPedidoLegado.DuplicarItem(grdProduto.GetValue("codigo_pedido"), _
                                             grdProduto.GetValue("codigo_pedido_item"), _
                                             dQuantidade:=sInput)

            'Informa o usuário
            frmMain.Informacao("Item duplicado com sucesso!", Color.Blue)

            'Carrega a grid novamente
            LoadGridProduto()


        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub HistoricoItem()
        Try

                'Váriaveis Locais
            Dim oForm As New frmVenPedidoHistoricoItem
            'Seta Tamanho e Localização do Formulário
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location
            'Seta Parametros
            oForm.Grid = grdProduto
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "::: ARQUIVO :::"

    Private Sub DeleteArquivo()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdArquivo) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    oClsVenPedidoLegado.ExcluirArquivo(oClsVenPedidoLegado.CodigoPedido)

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

            LimparCamposGroupBox(grpArquivo)

            'Seta Focu
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

#Region "::: NOTA FISCAL :::"

    Private Sub ImprimirDanfe(ByVal sCodigoEmissaoCapa As String)

        Try

            'Verifica se o Usuário tem Direito de Imprimir Danfe
            If VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcPrint) = True Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                Dim iTipoDocumentoFiscal As TipoDocumentoFiscal

                If IsNumeric(sCodigoEmissaoCapa) Then
                    iTipoDocumentoFiscal = CType(LoadDescricao("sp_select_faturamento_emissao_tipo_documento_fiscal " & sCodigoEmissaoCapa & ", " & goUsuario.iEmpresa), TipoDocumentoFiscal)
                Else
                    iTipoDocumentoFiscal = TipoDocumentoFiscal.Saida
                End If

                'Redimenciona Vetor
                ReDim goCrystalReport.sReportParameter(1)
                'Seta Parametros
                goCrystalReport.sReportParameter(0).sParamenter = "@codigo_emissao_capa"
                goCrystalReport.sReportParameter(0).sValue = sCodigoEmissaoCapa
                goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
                goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
                goCrystalReport.sReport = goCrystalReport.sPath & "FAT000000003" & IIf(iTipoDocumentoFiscal = TipoDocumentoFiscal.SaidaSemNF, "PN", "") & ".rpt"

                Dim oReport As New usrReport
                oReport.Dock = DockStyle.Fill

                'Abre Relatório
                If iTipoDocumentoFiscal = TipoDocumentoFiscal.SaidaSemNF Then
                    frmMain.LoadPageReport("FAT000000003", "PRÉ NOTA", oReport)
                Else
                    frmMain.LoadPageReport("FAT000000003", "DANFE - Documento Auxiliar de Nota Fiscal Eletrônica", oReport)
                End If

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoImprimir)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#End Region

   
  
End Class


