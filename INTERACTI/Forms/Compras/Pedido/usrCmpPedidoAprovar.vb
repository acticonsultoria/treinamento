Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Math

Public Class usrCmpPedidoAprovar

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCmpPedido As New clsUsrCmpPedido

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrCmpPedidoAprovar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                        
                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboFornecedorCotacaoFiltro" : Call LoadCombo(cboFornecedorCotacaoFiltro, "sp_select_combo_compras_gerar_pedido_fornecedor " & goUsuario.iEmpresa)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrCmpPedidoAprovar_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: ORÇAMENTO :::"

    Private Sub btnConfigurarGridCotacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridCotacao.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdCotacao
            oForm.NomeFormulario = Formulario.ComprasPedidoAprovar
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdCotacao, Formulario.ComprasPedidoAprovar)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdCotacao.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdCotacao.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdCotacao.GroupByBoxVisible = True
                grdCotacao.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdCotacao)

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

    Private Sub grdCotacao_RowCheckStateChanged(sender As Object, e As RowCheckStateChangeEventArgs) Handles grdCotacao.RowCheckStateChanged

        Try

            'Seleciona as Linhas
            'For Each oRow As GridEXRow In e.Row.GetChildRows
            '    oRow.CheckState = e.CheckState
            'Next

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdCotacao_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdCotacao.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdCotacao.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdCotacao.CurrentColumn.Key

                Case "mapa_comparativo" : Call MapaComparativo()
                Case "fluxo_financeiro" : Call FluxoFinanceiro()
                Case "visualizar" : Call VisualizarDocumentoBD(grdCotacao.CurrentRow.Cells("arquivo").Value, grdCotacao.CurrentRow.Cells("extensao").Value)
                Case "historico_preco" : Call HistoricoPrecoCompra()
                Case "historico" : Call HistoricoCotacaoItem(grdCotacao.CurrentRow)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdCotacao_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdCotacao.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdCotacao, _
                                     Formulario.ComprasPedidoAprovar)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdCotacao_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdCotacao.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdCotacao.Name, _
                                     Formulario.ComprasPedidoAprovar, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdCotacao_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdCotacao.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdCotacao.Name, _
                                          Formulario.ComprasPedidoAprovar, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: REPROVAR :::"

    Private Sub btnReprovarOrcamento_Click(sender As Object, e As EventArgs) Handles btnReprovarOrcamento.Click

        Try

            'Reprova Orçamento
            Call ReprovarOrcamento()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnReprovarCompra_Click(sender As Object, e As EventArgs) Handles btnReprovarCompra.Click

        Try

            'Reprova Compra
            Call ReprovarCompra()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: APROVAR :::"

    Private Sub btnAprovarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Gera Pedido de Compra
            Call GerarPedidoCompra()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnAprovarPedidoCompraUnitario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAprovarPedidoCompraUnitario.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Gera Pedido de Compra - Unitário
            Call GerarPedidoCompraUnitário()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: GERAL :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCmpPedidoAprovar_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnAprovarPedidoCompraUnitario.Enabled = VerificaDireito(Formulario.ComprasPedidoAprovar, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.ComprasPedidoAprovar, gcPrint)

            'Carrega ComboBox            
            Call LoadCombo(cboFornecedorCotacaoFiltro, "sp_select_combo_compras_gerar_pedido_fornecedor " & goUsuario.iEmpresa)

            'Configura DateTimer
            dtpDataCotacaoInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataCotacaoInicioFiltro.Checked = False
            dtpDataCotacaoTerminoFiltro.Value = Now.Date : dtpDataCotacaoTerminoFiltro.Checked = False

            'Configura Grid
            Call ConfiguraGrid(grdCotacao, Formulario.ComprasPedidoAprovar)

            'Seta Focu
            txtNumeroCotacaoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ORÇAMENTO :::"

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid - Cotação
            oClsCmpPedido.LoadGridCotacao(grdCotacao, _
                                          IIf(IsNumeric(txtNumeroCotacaoFiltro.Text.Trim), txtNumeroCotacaoFiltro.Text.Trim, -1), _
                                          IIf(dtpDataCotacaoInicioFiltro.Checked = True, dtpDataCotacaoInicioFiltro.Value, ""), _
                                          IIf(dtpDataCotacaoTerminoFiltro.Checked = True, dtpDataCotacaoTerminoFiltro.Value, ""), _
                                          IIf(cboFornecedorCotacaoFiltro.SelectedIndex = -1, -1, cboFornecedorCotacaoFiltro.SelectedValue), _
                                          txtItemFiltro.Text.Trim)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub MapaComparativo()

        Try

            Dim oFormularioCadastroBasico(1) As FormularioCadastroBasico

            'Carrega Váriaveis
            ReDim oFormularioCadastroBasico(0)
            oFormularioCadastroBasico(0).oValor = grdCotacao.CurrentRow.Cells("numero_cotacao").Value.ToString + "|" + grdCotacao.CurrentRow.Cells("codigo_cotacao").Value.ToString
            oFormularioCadastroBasico(0).sControle = "MP_cboNumeroCotacaoAprovacao"

            'Váriavel - Formulário
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrCmpCotacaoMapaComparativo"
            oForm.CadastroBasico = oFormularioCadastroBasico
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Recarrega a Grid
            Call LoadGrid()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub FluxoFinanceiro()

        Try

            'Váriavel - Formulário
            Dim oForm As New frmCmpPedidoCompraAprovarFluxoFinanceiro
            oForm.CodigoCotacao = grdCotacao.CurrentRow.Cells("codigo_cotacao").Value
            oForm.CodigoCotacaoFornecedor = grdCotacao.CurrentRow.Cells("codigo_cotacao_fornecedor").Value

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub HistoricoCotacaoItem(ByVal oRow As GridEXRow)

        Try

            'Verifica se existe cotação para o item 
            If IsDBNull(oRow.Cells.Item("codigo_cotacao_item").Value) = False Then

                'Váriavel - Formulário de Histórico
                Dim oForm As New frmCmpCotacaoItemHistorico

                'Seta Tamanho / Posição
                oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location

                'Seta Parâmentros
                oForm.NumeroCotacao = oRow.Parent.Cells("numero_cotacao").Value
                oForm.NumeroRequisicao = oRow.Cells("numero_requisicao").Value
                oForm.DataCotacao = oRow.Parent.Cells("data_cotacao").Value
                oForm.DataNecessidade = IIf(IsDBNull(oRow.Cells("data_necessidade").Value), "", oRow.Cells("data_necessidade").Value)
                oForm.Item = oRow.Cells("codigo_item").Value & " - " & oRow.Cells("descricao").Value
                oForm.CodigoCotacao = oRow.Cells("codigo_cotacao").Value
                oForm.CodigoCotacaoItem = oRow.Cells("codigo_cotacao_item").Value

                'Abre Formulário
                Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            Else
                'Informa o Usuário que não existe Cotação para o Item selecionado
                frmMain.Informacao(Mensagem.NaoExisteHistorico)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub HistoricoPrecoCompra()

        Try

                'Váriavel - Formulário de Histórico
            Dim oForm As New frmCmpPedidoHistoricoPreco
            'Seta Parâmentros
            oForm.CodigoProduto = grdCotacao.CurrentRow.Cells("codigo").Value
            'Seta Tamanho / Posição
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: REPROVAR :::"

    Private Sub ReprovarOrcamento()

        Try

            'Verifica se foi Selecionado algum Registro
            If VerificaSelecaoRow(grdCotacao) = True Then

                'Váriaveis - Formulário
                Dim oForm As New frmCmpPedidoOrcamentoCancelar
                oForm.Tipo = "ORÇAMENTO"
                'Abre Formulário
                oForm.ShowDialog(Me)

                'Carrega Grid
                Call LoadGrid()

            Else
                'Informa o Usuário sobre a Necessidade de Selecionar algum Registro
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ReprovarCompra()

        Try

            'Verifica se foi Selecionado algum Registro
            If VerificaSelecaoRow(grdCotacao) = True Then

                'Váriaveis - Formulário
                Dim oForm As New frmCmpPedidoOrcamentoCancelar
                oForm.Tipo = "COMPRA"
                'Abre Formulário
                oForm.ShowDialog(Me)

                'Carrega Grid
                Call LoadGrid()

            Else
                'Informa o Usuário sobre a Necessidade de Selecionar algum Registro
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: APROVAR :::"

    Private Sub GerarPedidoCompra()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdCotacao) = True Then

                'Verifica se o Usuário deseja gerar cotação dos Registros Selecionados
                If MsgBox("Deseja gerar Pedido de Compra para o(s) Registro(s) Selecionado(s)?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then


                    'Váriaveis Locais
                    Dim oPedidoCompra() As PedidoCompra
                    Dim bFlag As Boolean

                    ReDim oPedidoCompra(0)

                    For Each oRow As GridEXRow In gSelecaoRow

                        If oRow.Table.Key = "main" Then

                            bFlag = False

                            For i = 0 To UBound(oPedidoCompra)
                                If oRow.Cells("codigo_fornecedor").Value = oPedidoCompra(i).iCodigoFornecedor Then
                                    oPedidoCompra(i).dQuantidade += 1
                                    If IsNothing(oPedidoCompra(i).oRow) = False Then
                                        ReDim Preserve oPedidoCompra(i).oRow(UBound(oPedidoCompra(i).oRow) + 1)
                                    End If
                                    oPedidoCompra(i).oRow(UBound(oPedidoCompra(i).oRow)) = oRow
                                    bFlag = True
                                End If
                            Next

                            If bFlag = False Then

                                If oPedidoCompra(UBound(oPedidoCompra)).iCodigoFornecedor <> 0 Then
                                    ReDim Preserve oPedidoCompra(UBound(oPedidoCompra) + 1)
                                End If

                                ReDim oPedidoCompra(UBound(oPedidoCompra)).oRow(0)
                                oPedidoCompra(UBound(oPedidoCompra)).iCodigoFornecedor = oRow.Cells("codigo_fornecedor").Value
                                oPedidoCompra(UBound(oPedidoCompra)).dQuantidade = 1
                                oPedidoCompra(UBound(oPedidoCompra)).oRow(0) = oRow

                            End If

                        End If

                    Next

                    For i = 0 To UBound(oPedidoCompra)

                        If oPedidoCompra(i).dQuantidade = 1 Then

                            'Seta Cursor do Mouse
                            Cursor.Current = Cursors.WaitCursor

                            'Váriavel - Código Pedido
                            Dim lCodigoPedido As Long
                            Dim sNumeroPedido As String = ""

                            'Insere Pedido de Compra
                            Call oClsCmpPedido.InsertPedido(oPedidoCompra(i).iCodigoFornecedor, _
                                                            oPedidoCompra(i).oRow(0).Cells("codigo_modalidade_frete").Value, _
                                                            IIf(IsDBNull(oPedidoCompra(i).oRow(0).Cells("codigo_transportadora").Value), -1, oPedidoCompra(i).oRow(0).Cells("codigo_transportadora").Value), _
                                                            IIf(IsDBNull(oPedidoCompra(i).oRow(0).Cells("codigo_condicao_pagamento").Value), -1, oPedidoCompra(i).oRow(0).Cells("codigo_condicao_pagamento").Value), _
                                                            IIf(IsDBNull(oPedidoCompra(i).oRow(0).Cells("codigo_forma_pagamento").Value), -1, oPedidoCompra(i).oRow(0).Cells("codigo_forma_pagamento").Value), _
                                                            IIf(IsDBNull(oPedidoCompra(i).oRow(0).Cells("codigo_moeda").Value), -1, oPedidoCompra(i).oRow(0).Cells("codigo_moeda").Value), _
                                                            IIf(IsDBNull(oPedidoCompra(i).oRow(0).Cells("fator_cambial").Value), 1, oPedidoCompra(i).oRow(0).Cells("fator_cambial").Value), _
                                                            IIf(IsDBNull(oPedidoCompra(i).oRow(0).Cells("valor_frete").Value), 0, oPedidoCompra(i).oRow(0).Cells("valor_frete").Value), _
                                                            IIf(IsDBNull(oPedidoCompra(i).oRow(0).Cells("valor_total").Value), 0, oPedidoCompra(i).oRow(0).Cells("valor_total").Value), _
                                                            IIf(IsDBNull(oPedidoCompra(i).oRow(0).Cells("valor_desconto").Value), 0, oPedidoCompra(i).oRow(0).Cells("valor_desconto").Value), _
                                                            IIf(IsDBNull(oPedidoCompra(i).oRow(0).Cells("valor_icms").Value), 0, oPedidoCompra(i).oRow(0).Cells("valor_icms").Value), _
                                                            IIf(IsDBNull(oPedidoCompra(i).oRow(0).Cells("valor_ipi").Value), 0, oPedidoCompra(i).oRow(0).Cells("valor_ipi").Value), _
                                                            IIf(IsDBNull(oPedidoCompra(i).oRow(0).Cells("valor_final").Value), 0, oPedidoCompra(i).oRow(0).Cells("valor_final").Value), _
                                                            IIf(IsDBNull(oPedidoCompra(i).oRow(0).Cells("descritivo").Value), "", oPedidoCompra(i).oRow(0).Cells("descritivo").Value), _
                                                            lCodigoPedido, _
                                                            sNumeroPedido)

                            'Insere Itens ao Pedido de Compra / Atualiza Pedido de Compra
                            Call oClsCmpPedido.InsertPedidoItem(lCodigoPedido, _
                                                                oPedidoCompra(i).oRow)

                            'Integração
                            Dim oClsIntegracao As New clsIntegracao

                            'Integração com o Financeiro
                            Call oClsIntegracao.IntegracaoPedidoCompraFinanceiro(lCodigoPedido)

                            'Seta Cursor do Mouse
                            Cursor.Current = Cursors.Default

                        Else

                            'Váriaveis do Formulário
                            Dim iCodigoModalidadeFrete As Integer = -1
                            Dim iCodigoMoeda As Integer = -1
                            Dim dFatorCambial As Double = 0
                            Dim iCodigoTransportadora As Integer = -1
                            Dim iCodigoCondicaoPagamento As Integer = -1
                            Dim iCodigoFormaPagamento As Integer = -1
                            Dim dValorFrete As Double = 0
                            Dim dValorTotal As Double = 0
                            Dim dValorDesconto As Double = 0
                            Dim dValorICMS As Double = 0
                            Dim dValorIPI As Double = 0
                            Dim dValorFinal As Double = 0
                            Dim sDescritivo As String = ""

                            'Carrega Váriaveis
                            For Each oRow As GridEXRow In oPedidoCompra(i).oRow

                                If iCodigoModalidadeFrete = -1 Then
                                    iCodigoModalidadeFrete = IIf(IsDBNull(oRow.Cells("codigo_modalidade_frete").Value), -1, oRow.Cells("codigo_modalidade_frete").Value)
                                ElseIf iCodigoModalidadeFrete <> IIf(IsDBNull(oRow.Cells("codigo_modalidade_frete").Value), -1, oRow.Cells("codigo_modalidade_frete").Value) Then
                                    iCodigoModalidadeFrete = -2
                                    Exit For
                                End If

                                If iCodigoMoeda = -1 Then
                                    iCodigoMoeda = IIf(IsDBNull(oRow.Cells("codigo_moeda").Value), -1, oRow.Cells("codigo_moeda").Value)
                                ElseIf iCodigoMoeda <> IIf(IsDBNull(oRow.Cells("codigo_moeda").Value), -1, oRow.Cells("codigo_moeda").Value) Then
                                    iCodigoMoeda = -2
                                    Exit For
                                End If

                                If dFatorCambial = 0 Then
                                    dFatorCambial = IIf(IsDBNull(oRow.Cells("fator_cambial").Value), 0, oRow.Cells("fator_cambial").Value)
                                ElseIf dFatorCambial <> IIf(IsDBNull(oRow.Cells("fator_cambial").Value), 0, oRow.Cells("fator_cambial").Value) Then
                                    dFatorCambial = -2
                                End If

                                If iCodigoTransportadora = -1 Then
                                    iCodigoTransportadora = IIf(IsDBNull(oRow.Cells("codigo_transportadora").Value), -1, oRow.Cells("codigo_transportadora").Value)
                                ElseIf iCodigoTransportadora <> IIf(IsDBNull(oRow.Cells("codigo_transportadora").Value), -1, oRow.Cells("codigo_transportadora").Value) Then
                                    iCodigoTransportadora = -2
                                    Exit For
                                End If

                                If iCodigoCondicaoPagamento = -1 Then
                                    iCodigoCondicaoPagamento = IIf(IsDBNull(oRow.Cells("codigo_condicao_pagamento").Value), -1, oRow.Cells("codigo_condicao_pagamento").Value)
                                ElseIf iCodigoCondicaoPagamento <> IIf(IsDBNull(oRow.Cells("codigo_condicao_pagamento").Value), -1, oRow.Cells("codigo_condicao_pagamento").Value) Then
                                    iCodigoCondicaoPagamento = -2
                                    Exit For
                                End If

                                If iCodigoFormaPagamento = -1 Then
                                    iCodigoFormaPagamento = IIf(IsDBNull(oRow.Cells("codigo_forma_pagamento").Value), -1, oRow.Cells("codigo_forma_pagamento").Value)
                                ElseIf iCodigoFormaPagamento <> IIf(IsDBNull(oRow.Cells("codigo_forma_pagamento").Value), -1, oRow.Cells("codigo_forma_pagamento").Value) Then
                                    iCodigoFormaPagamento = -2
                                    Exit For
                                End If

                                If sDescritivo = "" Then
                                    sDescritivo &= IIf(sDescritivo = "", "", vbCrLf) & IIf(IsDBNull(oRow.Cells("descritivo").Value), "", oRow.Cells("descritivo").Value)
                                End If

                                dValorFrete += oRow.Cells("valor_frete").Value
                                dValorTotal += oRow.Cells("valor_total").Value
                                dValorDesconto += oRow.Cells("valor_desconto").Value
                                dValorICMS += oRow.Cells("valor_icms").Value
                                dValorIPI += oRow.Cells("valor_ipi").Value
                                dValorFinal += oRow.Cells("valor_final").Value

                            Next

                            If iCodigoModalidadeFrete = -2 Or _
                                iCodigoMoeda = -2 Or _
                                dFatorCambial = -1 Or _
                                iCodigoTransportadora = -2 Or _
                                iCodigoCondicaoPagamento = -2 Or _
                                iCodigoFormaPagamento = -2 Then

                                'Abre Formulário
                                Dim oForm As New frmCmpPedidoCompra
                                oForm.PedidoCompra = oPedidoCompra(i)
                                Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                                If oForm.FatorCambial <> 0 Then

                                    'Seta Cursor do Mouse
                                    Cursor.Current = Cursors.WaitCursor

                                    'Váriavel - Código Pedido
                                    Dim lCodigoPedido As Long
                                    Dim sNumeroPedido As String = ""

                                    Call oClsCmpPedido.InsertPedido(oPedidoCompra(i).iCodigoFornecedor, _
                                                                    oForm.CodigoModalidadeFrete, _
                                                                    oForm.CodigoTransportadora, _
                                                                    oForm.CodigoCondicaoPagamento, _
                                                                    oForm.CodigoFormaPagamento, _
                                                                    oForm.CodigoMoeda, _
                                                                    oForm.FatorCambial, _
                                                                    oForm.ValorFrete, _
                                                                    oForm.ValorTotal, _
                                                                    oForm.ValorDesconto, _
                                                                    oForm.ValorICMS, _
                                                                    oForm.ValorIPI, _
                                                                    oForm.ValorFinal, _
                                                                    sDescritivo, _
                                                                    lCodigoPedido, _
                                                                    sNumeroPedido)

                                    'Insere Itens ao Pedido de Compra / Atualiza Pedido de Compra
                                    Call oClsCmpPedido.InsertPedidoItem(lCodigoPedido, _
                                                                        oPedidoCompra(i).oRow)

                                    'Integração
                                    Dim oClsIntegracao As New clsIntegracao

                                    'Integração com o Financeiro
                                    Call oClsIntegracao.IntegracaoPedidoCompraFinanceiro(lCodigoPedido)

                                    'Seta Cursor do Mouse
                                    Cursor.Current = Cursors.Default

                                End If

                            Else

                                'Seta Cursor do Mouse
                                Cursor.Current = Cursors.WaitCursor

                                'Váriavel - Código Pedido
                                Dim lCodigoPedido As Long
                                Dim sNumeroPedido As String = ""

                                Call oClsCmpPedido.InsertPedido(oPedidoCompra(i).iCodigoFornecedor, _
                                                                iCodigoModalidadeFrete, _
                                                                iCodigoTransportadora, _
                                                                iCodigoCondicaoPagamento, _
                                                                iCodigoFormaPagamento, _
                                                                iCodigoMoeda, _
                                                                dFatorCambial, _
                                                                dValorFrete, _
                                                                dValorTotal, _
                                                                dValorDesconto, _
                                                                dValorICMS, _
                                                                dValorIPI, _
                                                                dValorFinal, _
                                                                sDescritivo, _
                                                                lCodigoPedido, _
                                                                sNumeroPedido)

                                'Insere Itens ao Pedido de Compra / Atualiza Pedido de Compra
                                Call oClsCmpPedido.InsertPedidoItem(lCodigoPedido, _
                                                                    oPedidoCompra(i).oRow)

                                'Integração
                                Dim oClsIntegracao As New clsIntegracao

                                'Integração com o Financeiro
                                Call oClsIntegracao.IntegracaoPedidoCompraFinanceiro(lCodigoPedido)

                                'Seta Cursor do Mouse
                                Cursor.Current = Cursors.Default

                            End If

                        End If

                    Next

                    'Carrega Combo
                    Call LoadCombo(cboFornecedorCotacaoFiltro, "sp_select_combo_compras_gerar_pedido_fornecedor " & goUsuario.iEmpresa)

                    'Carrega Grid
                    Call LoadGrid()

                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                MsgBox("Primeiramente Selecione um ou mais Registros Válidos.", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub GerarPedidoCompraUnitário()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdCotacao) = True Then

                'Verifica se o Usuário deseja gerar cotação dos Registros Selecionados
                If MsgBox("Deseja gerar Pedido de Compra para o(s) Registro(s) Selecionado(s)?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Dim lCodigoCotacao As Long = 0
                    Dim iCodigoCotacaoFornecedor As Integer = 0
                    Dim lCodigoPedido As Long = 0
                    Dim sNumeroPedido As String = ""

                    For Each oRow As GridEXRow In gSelecaoRow

                        'Verifica se é a mesma Cotação e o Mesmo Fornecedor
                        If lCodigoCotacao <> oRow.Cells("codigo_cotacao").Value Or iCodigoCotacaoFornecedor <> oRow.Cells("codigo_cotacao_fornecedor").Value Then

                            'Insere Pedido de Compra
                            Call oClsCmpPedido.InsertPedido(oRow.Parent.Cells("codigo_fornecedor").Value, _
                                                            IIf(IsDBNull(oRow.Parent.Cells("codigo_modalidade_frete").Value), -1, oRow.Parent.Cells("codigo_modalidade_frete").Value), _
                                                            IIf(IsDBNull(oRow.Parent.Cells("codigo_transportadora").Value), -1, oRow.Parent.Cells("codigo_transportadora").Value), _
                                                            IIf(IsDBNull(oRow.Parent.Cells("codigo_condicao_pagamento").Value), -1, oRow.Parent.Cells("codigo_condicao_pagamento").Value), _
                                                            IIf(IsDBNull(oRow.Parent.Cells("codigo_forma_pagamento").Value), -1, oRow.Parent.Cells("codigo_forma_pagamento").Value), _
                                                            IIf(IsDBNull(oRow.Parent.Cells("codigo_moeda").Value), -1, oRow.Parent.Cells("codigo_moeda").Value), _
                                                            IIf(IsDBNull(oRow.Parent.Cells("fator_cambial").Value), 1, oRow.Parent.Cells("fator_cambial").Value), _
                                                            IIf(IsDBNull(oRow.Parent.Cells("valor_frete").Value), 0, oRow.Parent.Cells("valor_frete").Value), _
                                                            0, _
                                                            0, _
                                                            0, _
                                                            0, _
                                                            0, _
                                                            IIf(IsDBNull(oRow.Parent.Cells("descritivo").Value), "", oRow.Parent.Cells("descritivo").Value), _
                                                            lCodigoPedido, _
                                                            sNumeroPedido)

                            lCodigoCotacao = oRow.Cells("codigo_cotacao").Value
                            iCodigoCotacaoFornecedor = oRow.Cells("codigo_cotacao_fornecedor").Value

                        End If

                        'Insere Itens ao Pedido de Compra / Atualiza Pedido de Compra
                        Call oClsCmpPedido.InsertPedidoItem(lCodigoPedido, oRow)

                        'Integração
                        Dim oClsIntegracao As New clsIntegracao

                        'Integração com o Financeiro
                        Call oClsIntegracao.IntegracaoPedidoCompraFinanceiro(lCodigoPedido)

                    Next

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                    'Carrega Combo
                    Call LoadCombo(cboFornecedorCotacaoFiltro, "sp_select_combo_compras_gerar_pedido_fornecedor " & goUsuario.iEmpresa)

                    'Carrega Grid
                    Call LoadGrid()

                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                MsgBox("Primeiramente Selecione um ou mais Registros Válidos.", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: ARQUIVO :::"


    Private Sub VisualizarDocumento(ByVal sArquivo As String)

        Try

            'Verifica se foi Informado o Arquivo
            If sArquivo = "" Then

                'Informa o Usuário que não foi Informado o Arquivo
                frmMain.Informacao(Mensagem.NaoFoiInformado, "Arquivo")

            Else

                'Verifica se o Arquivo Existe
                If IO.File.Exists(sArquivo) Then
                    'Abre o Arquivo
                    Dim oProcess As New Process
                    oProcess.Start(sArquivo)
                Else
                    'Informa o Usuário que o Arquivo Informado não foi Localizado.
                    frmMain.Informacao(Mensagem.ObjetoNaoEncontrado, "Arquivo")
                End If

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class


