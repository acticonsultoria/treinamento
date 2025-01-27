Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Math

Public Class usrCmpRecebimento

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCmpRecebimento As New clsUsrCmpRecebimento
    Private oCurrentRow As GridEXRow

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrCmpRecebimento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

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

    Private Sub usrCmpRecebimento_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: RECEBIMENTO :::"

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.ComprasRecebimento
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ComprasRecebimento)

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

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Grid
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfirmarRecebimento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmarRecebimento.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() Then

                'Salva Recebimento
                Call Salvar()

                'Limpa Formulário
                Call Novo()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click

        Try

            'Exporta Planilha para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            'Prepara Formulário para um novo Recebimento
            Call Novo()

            'Alterna Aba                
            tabMain.TabPages.Remove(pagListagem)
            tabMain.TabPages.Add(pagDados)

            'Seta Focu
            txtNumeroDocumento.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Exclui Registros - Recebimento
            Call Excluir()

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

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        Try

            'Carrega Grid
            Call LoadGrid()

            'Seta Focu
            txtNumeroDocumentoFiltro.Focus()

            'Alterna Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagListagem)

            'Seta Focu
            txtNumeroDocumentoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboFornecedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFornecedor.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado Algum Registro
            If cboFornecedor.SelectedIndex = -1 Then
                'Limpa Controles
                cboNumeroPedido.Text = ""
                cboNumeroPedido.DropDownDataSource = Nothing
            Else
                'Carrega Combo - Pedido
                Call LoadCombo(cboNumeroPedido, "sp_select_combo_compras_recebimento_pedido " & goUsuario.iEmpresa & ", " & cboFornecedor.SelectedValue)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub tabDados_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.Tab.TabEventArgs) Handles tabDados.SelectedTabChanged

        Try

            Select Case e.Page.Key

                Case "pagFatura" : Call CalcularFatura()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key.ToString

                Case "imprimir"

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
                                     Formulario.ComprasRecebimento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.ComprasRecebimento, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ITENS :::"

    Private Sub btnConfigurarGridItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridItem.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdItem
            oForm.NomeFormulario = Formulario.ComprasRecebimento
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdItem, Formulario.ComprasRecebimento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnAgruparGridItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridItem.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdItem.GroupByBoxVisible = True Then

                'Exclui Linhas do Grupo
                For Each oGroup As GridEXGroup In grdItem.RootTable.Groups
                    grdItem.RootTable.Groups.Remove(oGroup)
                Next

                'Oculta Grupo
                grdItem.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdItem.GroupByBoxVisible = True
                grdItem.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrarPedido.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Campo - Fornecedor
            If ValidaCampo(cboFornecedor, lblFornecedor) = False Then
                Exit Sub
            End If

            'Verifica se foi Selecionado o Campo - Nº Pedido Compra
            If ValidaCampo(cboNumeroPedido, lblNumeroPedido) = False Then
                Exit Sub
            End If

            'Carrega Grid
            Call LoadGridItem()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdItem_RowCheckStateChanged(sender As Object, e As RowCheckStateChangeEventArgs) Handles grdItem.RowCheckStateChanged

        Try

            'Verifica se tem alguma Linha Selecionada
            If e.Row.CheckState = RowCheckState.Checked Then

                'Desmarca Linha Anterior
                If IsNothing(oCurrentRow) = False Then
                    oCurrentRow.CheckState = RowCheckState.Unchecked
                End If

                'Seta Váriavel
                oCurrentRow = e.Row

            Else
                'Limpa Váriavel
                oCurrentRow = Nothing
            End If

            'Atualiza Estoque
            grdItem.Refresh()

            'Prepara Formulário
            cboDeposito.SelectedIndex = -1
            txtQuantidade.Value = 0
            btnInserirEstoque.Tag = ""
            btnExcluirEstoque.Tag = ""

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado a Linha
            If IsNothing(oCurrentRow) = False Then

                'Carrega Grid
                Call LoadGridEstoque(oCurrentRow.Cells("recebimento").Value)
                txtLote.Enabled = oCurrentRow.Cells("controla_lote").Value
                'Carrega Combo
                Call LoadCombo(cboDeposito, "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa & ", 1, NULL, NULL", False)
                'Habilita Entrega
                grpEstoque.Enabled = True

            Else

                'Desabilita Controles
                grdEstoque.DataSource = Nothing
                grpEstoque.Enabled = False
                txtLote.Text = ""

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdItem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdItem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdItem, _
                                     Formulario.ComprasRecebimento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdItem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdItem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdItem.Name, _
                                     Formulario.ComprasRecebimento, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdItem_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdItem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdItem.Name, _
                                          Formulario.ComprasRecebimento, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ESTOQUE :::"

    Private Sub btnInserirEstoque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirEstoque.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoEstoque() = True Then

                'Váriaveis Locais
                Dim iCodigoDepositoAntigo As Integer = 0
                Dim sLoteAntigo As String = ""
                Dim dQuantidadeAntigo As Double = 0

                'Carrega dados Antigos
                If IsNumeric(btnInserirEstoque.Tag) Then
                    iCodigoDepositoAntigo = grdEstoque.CurrentRow.Cells("codigo_deposito").Value
                    sLoteAntigo = IIf(IsDBNull(grdEstoque.CurrentRow.Cells("lote").Value), "", grdEstoque.CurrentRow.Cells("lote").Value)
                    dQuantidadeAntigo = grdEstoque.CurrentRow.Cells("quantidade").Value
                End If

                'Salva Dados do Registro
                Call InsertEstoqueGrid(grdEstoque, _
                                       cboDeposito.Text, _
                                       txtLote.Text.Trim, _
                                       txtQuantidade.Value, _
                                       cboDeposito.SelectedValue, _
                                       iCodigoDepositoAntigo, _
                                       sLoteAntigo, _
                                       dQuantidadeAntigo)

                'Atualiza Estoque
                Call AtualizaEstoque()

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoEstoque()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirEstoque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirEstoque.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Deleta Estoque
            Call DeleteEstoque()

            'Atualiza Estoque
            Call AtualizaEstoque()

            'Limpa Formulário
            Call NovoEstoque()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdEstoque_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdEstoque.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdEstoque.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdEstoque.CurrentColumn.Key

                Case "editar" : Call EditarEstoque()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FATURA :::"

    Private Sub btnCalcularDuplicata_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcularDuplicata.Click

        Try

            'Gerar Duplicata
            Call GerarDuplicata()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub txtValor_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValorOriginal.ValueChanged, _
                                                                                                   txtValorDesconto.ValueChanged

        Try

            txtValorLiquido.Value = txtValorOriginal.Value - txtValorDesconto.Value

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCmpRecebimento_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnNovo.Enabled = VerificaDireito(Formulario.ComprasRecebimento, gcInsert)
            btnExcluir.Enabled = VerificaDireito(Formulario.ComprasRecebimento, gcDelete)
            btnConfirmarRecebimento.Enabled = VerificaDireito(Formulario.ComprasRecebimento, gcInsert)

            'Carrega Combo - Parceiro de Negócio
            Call LoadCombo(cboTipoItemFiltro, "sp_select_combo_static_tipo_item")
            Call LoadCombo(cboFornecedor, "sp_select_combo_compras_recebimento_fornecedor " & goUsuario.iEmpresa)
            Call LoadCombo(cboFormaPagamento, "sp_select_combo_static_tipo_documento_pagamento")

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ComprasRecebimento)
            Call ConfiguraGrid(grdItem, Formulario.ComprasRecebimento)

            'Seta Controles
            dtpDataRecebimentoInicioFiltro.Value = Now.Date : dtpDataRecebimentoInicioFiltro.Checked = False
            dtpDataRecebimentoTerminoFiltro.Value = Now.Date : dtpDataRecebimentoTerminoFiltro.Checked = False
            dtpDataRecebimento.Value = Now.Date

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            txtNumeroDocumentoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: RECEBIMENTO :::"

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid
            Call oClsCmpRecebimento.LoadGridRecebimento(grdListagem, _
                                                        txtNumeroDocumento.Text.Trim, _
                                                        IIf(dtpDataRecebimentoInicioFiltro.Checked = False, "", dtpDataRecebimentoInicioFiltro.Value), _
                                                        IIf(dtpDataRecebimentoTerminoFiltro.Checked = False, "", dtpDataRecebimentoTerminoFiltro.Value), _
                                                        txtFornecedorFiltro.Text.Trim, _
                                                        IIf(IsNumeric(txtNumeroPedidoFiltro.Text.Trim.Replace(goUsuario.sSiglaEmpresa, "")), txtNumeroPedidoFiltro.Text.Trim.Replace(goUsuario.sSiglaEmpresa, ""), -1), _
                                                        IIf(cboTipoItemFiltro.SelectedIndex = -1, -1, cboTipoItemFiltro.SelectedValue), _
                                                        txtItemFiltro.Text.Trim)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Excluir()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registros
                    Call oClsCmpRecebimento.DeleteRecebimento()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mais Registro
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Limpa Controles - Recebimento
            txtNumeroDocumento.Text = ""
            dtpDataRecebimento.Value = Now.Date
            cboFornecedor.SelectedIndex = -1
            Call LoadCombo(cboFornecedor, "sp_select_combo_compras_recebimento_fornecedor " & goUsuario.iEmpresa, False)
            btnConfirmarRecebimento.Tag = ""

            'Limpa Controles - Item
            grdItem.DataSource = Nothing

            'Limpa Controles - Estoque
            cboDeposito.SelectedIndex = -1
            txtLote.Text = ""
            txtQuantidade.Value = 0
            btnInserirEstoque.Tag = ""
            btnExcluirEstoque.Tag = ""
            grdEstoque.DataSource = Nothing
            grpEstoque.Enabled = False

            'Limpa Controles - Fatura
            txtFatura.Text = ""
            txtValorOriginal.Value = 0
            txtValorDesconto.Value = 0
            txtValorLiquido.Value = 0
            cboFormaPagamento.SelectedIndex = -1
            txtNumeroParcela.Value = 0
            txtIntervaloEntreParcelas.Value = 0
            grdDuplicata.DataSource = Nothing

            'Seta Aba
            tabDados.SelectedTab = pagItem

            'Seta Focu
            txtNumeroDocumento.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Váriaveis Locais
            Dim lCodigoRecebimento As Long

            'Insere Recebimento
            Call oClsCmpRecebimento.InsertRecebimento(txtNumeroDocumento.Text.Trim, _
                                                      dtpDataRecebimento.Value, _
                                                      cboFornecedor.SelectedValue, _
                                                      lCodigoRecebimento)

            'Seta Controle
            btnConfirmarRecebimento.Tag = lCodigoRecebimento

            'Insere Recebimento - Item
            Call oClsCmpRecebimento.InsertRecebimentoItem(lCodigoRecebimento, _
                                                          grdItem)

            'Insere Recebimento - Fatura
            Call oClsCmpRecebimento.InsertRecebimentoFatura(lCodigoRecebimento, _
                                                            txtFatura.Text.Trim, _
                                                            txtValorOriginal.Value, _
                                                            txtValorDesconto.Value, _
                                                            txtValorLiquido.Value, _
                                                            cboFormaPagamento.SelectedValue, _
                                                            txtNumeroParcela.Value, _
                                                            txtIntervaloEntreParcelas.Value)

            'Insere Recebimento - Fatura / Duplicata
            Call oClsCmpRecebimento.InsertRecebimentoFaturaDuplicata(lCodigoRecebimento, _
                                                                     grdDuplicata)

            'Efetua Integração
            Call Integracao(lCodigoRecebimento)

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Preenchido o Campo - Nº Documento
            If ValidaCampo(txtNumeroDocumento, lblNumeroDocumento, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Fornecedor
            If ValidaCampo(cboFornecedor, lblFornecedor) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Pedido
            If grdItem.GetDataRows.Count > 0 AndAlso grdItem.GetTotalRow.Cells("quantidade_recebida").Value <= 0 Then
                'Informa o Usuário sobre a Necessidade de selecionar um Registro
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
                grdItem.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Forma de Pagamento
            If ValidaCampo(cboFormaPagamento, lblFormaPagamento) = False Then
                tabDados.SelectedTab = pagFatura
                cboFormaPagamento.Focus()
                Exit Function
            End If

            'Verifica se o Valor das Parcelas é igual ao Valor Total
            If grdDuplicata.GetDataRows.Count = 0 OrElse _
              (grdDuplicata.GetTotalRow.Cells("valor").Value - txtValorLiquido.Value) > 1 Then
                tabDados.SelectedTab = pagFatura
                cboFormaPagamento.Focus()
                frmMain.errInfo.SetError(lblValorLiquido, "O Soma do Valor da(s) Parcela(s) não corresponde ao Valor Líquido. Favor verificar.")
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: ITENS :::"

    Private Sub EstoqueRecebimento()

        Try

            'Verifica se Controla Estoque do Item
            If grdItem.CurrentRow.Cells("item_estoque").Value = True Then

                'Valida se foi preenchido a Quantidade Recebida
                If grdItem.CurrentRow.Cells("quantidade_recebida").Value = 0 Then
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Primeiramente preencha a Quantidade Recebida.")
                    grdItem.Focus()
                    Exit Sub
                End If

                'Váriaveis Locais - Formulário
                Dim oForm As New frmCmpRecebimentoEstoque

                'Seta Parâmetros
                oForm.Estoque = IIf(IsDBNull(grdItem.CurrentRow.Cells("recebimento").Value), "", grdItem.CurrentRow.Cells("recebimento").Value)
                oForm.Quantidade = grdItem.CurrentRow.Cells("quantidade_recebida").Value
                oForm.Produto = grdItem.CurrentRow.Cells("codigo_produto_servico").Value & " - " & grdItem.CurrentRow.Cells("descricao").Value
                oForm.ControlaLote = grdItem.CurrentRow.Cells("controla_lote").Value
                oForm.CodigoItem = grdItem.CurrentRow.Cells("codigo_item").Value

                'Carrega Formulário
                Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                'Preenche a Grid
                grdItem.SetValue("recebimento", oForm.Estoque)
                grdItem.SetValue("quantidade_estoque", oForm.QuantidadeEstoque)
                btnConfirmarRecebimento.Focus()

            Else
                'Informa o Usuário sobre o problema ocorrido
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Este Item não controla Estoque.")
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridItem()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim sCodigoPedido As String = ""

            'Código do Pedido de Compra
            For i = 0 To UBound(cboNumeroPedido.CheckedValues)
                sCodigoPedido &= IIf(sCodigoPedido = "", "", ",") & cboNumeroPedido.CheckedValues(i).ToString
            Next

            'Carrega Grid - Itens
            Call oClsCmpRecebimento.LoadGridItem(grdItem, sCodigoPedido)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ESTOQUE :::"

    Private Sub NovoEstoque()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            cboDeposito.SelectedIndex = -1
            txtQuantidade.Value = 0
            btnInserirEstoque.Tag = ""
            btnExcluirEstoque.Tag = ""

            'Verifica se foi Selecionado a Linha
            If IsNothing(oCurrentRow) = False Then

                'Carrega Grid
                Call LoadGridEstoque(oCurrentRow.Cells("recebimento").Value)
                txtLote.Enabled = oCurrentRow.Cells("controla_lote").Value
                'Carrega Combo
                Call LoadCombo(cboDeposito, "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa & ", 1, NULL, 0", False)
                'Habilita Entrega
                grpEstoque.Enabled = True

            Else

                'Desabilita Controles
                grdEstoque.DataSource = Nothing
                grpEstoque.Enabled = False
                txtLote.Text = ""

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridEstoque(ByVal sEstoque As String)

        Try

            'Limpa Grid
            grdEstoque.DataSource = Nothing

            'Verifica se existe alguma Estoque Lançado
            If sEstoque = "" Then Exit Sub

            'Váriaveis Locais
            Dim sEstoques() As String = sEstoque.Split("|")
            Dim sDadosEstoque() As String

            For i As Integer = 0 To UBound(sEstoques)

                sDadosEstoque = sEstoques(i).Split("§")

                'Insere Dados do Estoque
                Call InsertEstoqueGrid(grdEstoque, _
                                       sDadosEstoque(0), _
                                       sDadosEstoque(1), _
                                       sDadosEstoque(2), _
                                       sDadosEstoque(3), _
                                       -1, _
                                       "", _
                                       -1)
            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub InsertEstoqueGrid(ByVal oGrid As GridEX, _
                                  ByVal sDeposito As String, _
                                  ByVal sLote As String, _
                                  ByVal dQuantidade As Double, _
                                  ByVal iCodigoDeposito As Integer, _
                                  ByVal iCodigoDepositoAntigo As Integer, _
                                  ByVal sLoteAntigo As String, _
                                  ByVal dQuantidadeAntigo As Double)

        Try

            'Variaveis Locais
            Dim oDataSet As New DataSet
            Dim oDataTable As New DataTable
            Dim oDataRow As DataRow
            Dim oDCDeposito As New DataColumn("deposito")
            Dim oDCLote As New DataColumn("lote")
            Dim oDCQuantidade As New DataColumn("quantidade")
            Dim oDCCodigoDeposito As New DataColumn("codigo_deposito")

            'Verifica se o DataSource é Vazio
            If Not oGrid.DataSource Is Nothing Then
                oDataSet = oGrid.DataSource.DataSet
                oDataTable = oDataSet.Tables(0)
                oGrid.DataSource = Nothing
            Else
                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)
                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCDeposito)
                oDataTable.Columns.Add(oDCLote)
                oDataTable.Columns.Add(oDCQuantidade)
                oDataTable.Columns.Add(oDCCodigoDeposito)
                'Seta DataType
                oDCQuantidade.DataType = 0.0.GetType
            End If

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirEstoque.Tag) = False Then
                'Adiciona Linhas ao DataTable
                oDataRow = oDataTable.NewRow
                oDataRow("deposito") = sDeposito
                oDataRow("lote") = IIf(sLote = "", DBNull.Value, sLote)
                oDataRow("quantidade") = dQuantidade
                oDataRow("codigo_deposito") = iCodigoDeposito
                oDataTable.Rows.Add(oDataRow)
            Else
                Dim sQuery As String = ""
                sQuery = "(codigo_deposito = " & iCodigoDepositoAntigo & ")"
                sQuery &= IIf(sLote = "", "", " AND (lote = " & sLoteAntigo & ")")
                sQuery &= " AND (quantidade = " & dQuantidadeAntigo & ")"
                oDataRow = oDataTable.Select(sQuery)(0)
                oDataRow("deposito") = sDeposito
                oDataRow("lote") = IIf(sLote = "", DBNull.Value, sLote)
                oDataRow("quantidade") = dQuantidade
                oDataRow("codigo_deposito") = iCodigoDeposito
            End If

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteEstoque()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdEstoque) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    For Each oRow As GridEXRow In gSelecaoRow
                        'Deleta Linha
                        oRow.Delete()
                    Next

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

    Private Sub EditarEstoque()

        Try

            'Limpa Formulário
            Call NovoEstoque()

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.ComprasRecebimento, gcUpdate) = True Then

                With grdEstoque.CurrentRow.Cells

                    'Carrega Controles
                    cboDeposito.SelectedValue = .Item("codigo_deposito").Value
                    If IsDBNull(.Item("lote").Value) = False Then txtLote.Text = .Item("lote").Value
                    txtQuantidade.Value = .Item("quantidade").Value
                    btnInserirEstoque.Tag = grdEstoque.CurrentRow.RowIndex
                    btnExcluirEstoque.Tag = .Item("quantidade").Value

                End With

                'Seta Focu
                cboDeposito.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub AtualizaEstoque()

        Try

            'Váriaveis Locais
            Dim sQuery As String
            Dim sEstoque As String = ""
            Dim dQuantidadeEstoque As Double = 0

            'Seta Query
            sQuery = "((codigo_pedido = " & oCurrentRow.Cells("codigo_pedido").Value & ") "
            sQuery &= "AND (codigo_pedido_item = " & oCurrentRow.Cells("codigo_pedido_item").Value & ") "
            sQuery &= "AND (codigo_pedido_item_entrega = " & oCurrentRow.Cells("codigo_pedido_item_entrega").Value & "))"

            'Carrega Estoque
            For Each oRow As GridEXRow In grdEstoque.GetDataRows
                sEstoque &= IIf(sEstoque = "", "", "|")
                sEstoque &= oRow.Cells("deposito").Value & "§"
                sEstoque &= oRow.Cells("lote").Value & "§"
                sEstoque &= oRow.Cells("quantidade").Value & "§"
                sEstoque &= oRow.Cells("codigo_deposito").Value
            Next

            'Carrega Quantidade Estoque
            If grdEstoque.GetDataRows.Count > 0 Then
                dQuantidadeEstoque = grdEstoque.GetTotalRow.Cells("quantidade").Value
            End If

            'Atualiza Grid
            Call UpdateRegistroGrid(grdItem, sQuery, "quantidade_recebida", dQuantidadeEstoque)
            Call UpdateRegistroGrid(grdItem, sQuery, "recebimento", sEstoque)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoEstoque() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoEstoque = False

            'Verifica se foi Selecionado o Campo - Depósito
            If ValidaCampo(cboDeposito, lblDeposito) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Lote
            If txtLote.Enabled = True Then
                If ValidaCampo(txtLote, lblLote, TipoCampo.texto) = False Then
                    Exit Function
                End If
            End If

            'Verifica se o Registro é Duplicado
            If IsNumeric(btnInserirEstoque.Tag) Then
                For Each oRow As GridEXRow In grdEstoque.GetDataRows
                    If oRow.Cells("codigo_deposito").Value = cboDeposito.SelectedValue And _
                        IIf(IsDBNull(oRow.Cells("lote").Value), "", oRow.Cells("lote").Value) = txtLote.Text.Trim And _
                        oRow.RowIndex <> btnInserirEstoque.Tag Then
                        frmMain.errInfo.SetError(lblDeposito, "Estes Dados já foram informados anteriormente.")
                        cboDeposito.Focus()
                        Exit Function
                    End If
                Next
            Else
                For Each oRow As GridEXRow In grdEstoque.GetDataRows
                    If oRow.Cells("codigo_deposito").Value = cboDeposito.SelectedValue And _
                        IIf(IsDBNull(oRow.Cells("lote").Value), "", oRow.Cells("lote").Value) = txtLote.Text.Trim Then
                        frmMain.errInfo.SetError(lblDeposito, "Estes Dados já foram informados anteriormente.")
                        cboDeposito.Focus()
                        Exit Function
                    End If
                Next
            End If

            'Verifica se foi Preenchido o Campo - Quantidade
            If ValidaCampo(txtQuantidade, lblQuantidade, True) = False Then
                Exit Function
            End If

            'Verifica se a Quantidade é maior que a Quantidade Requerida
            Dim dQuantidade As Double = 0
            If grdEstoque.GetDataRows.Count > 0 Then dQuantidade = grdEstoque.GetTotalRow.Cells("quantidade").Value
            If IsNumeric(btnExcluirEstoque.Tag) Then dQuantidade -= btnExcluirEstoque.Tag
            If (oCurrentRow.Cells("quantidade_pendente").Value) < (txtQuantidade.Value + dQuantidade) Then
                frmMain.errInfo.SetError(lblQuantidade, "A Quantidade informada é maior que a Quantidade do Pedido de Compra.")
                txtQuantidade.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoEstoque = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: FATURA :::"

    Private Sub CalcularFatura()

        Try

            'Verifica se existe Registro na Grid
            If grdItem.GetDataRows.Count > 0 Then
                txtValorOriginal.Value = grdItem.GetTotalRow.Cells("valor_total").Value
            Else
                txtValorOriginal.Value = 0
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub GerarDuplicata()

        Try

            'Verifica Número de Parcela
            txtNumeroParcela.Value = IIf(txtNumeroParcela.Value = 0, 1, txtNumeroParcela.Value)

            'Gera Duplicata
            oClsCmpRecebimento.GerarDuplicata(grdDuplicata, _
                                              dtpDataRecebimento.Value, _
                                              txtValorLiquido.Value, _
                                              txtNumeroParcela.Value, _
                                              txtIntervaloEntreParcelas.Value)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: INTEGRAÇÃO :::"

    Private Sub Integracao(ByVal lCodigoRecebimento As Long)

        Try

            'Váriaveis - Integração
            Dim oClsIntegracao As New clsIntegracao

            'Integração - Compras
            oClsIntegracao.IntegracaoRecebimentoCompras(lCodigoRecebimento)
            'Integração - Estoque
            oClsIntegracao.IntegracaoRecebimentoEstoque(lCodigoRecebimento)
            'Integração - Financeiro
            oClsIntegracao.IntegracaoRecebimentoFinanceiro(lCodigoRecebimento)
            'Integração - Financeiro Financeiro
            oClsIntegracao.IntegracaoRecebimentoComprasFinanceiro(lCodigoRecebimento)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class


