Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports System.IO 
Imports System.Math

Public Class usrFatEntradaNFCorrecao

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsFatEntradaNFCorrecao As New clsUsrFatEntradaNFCorrecao
    Private lCodigoEntradaCapa As Long = -1
    Private iCodigoEntradaItem As Integer = -1
    Private lCodigoEmissaoCapa As Long = -1
    Private iCodigoEmissaoItem As Integer = -1
    Private lCodigoParceiroNegocio As Long = -1
    Private lCodigoPedido As Long = -1
    Private iCodigoPedidoItem As Integer = -1
    Private iCodigoPedidoItemEntrega As Integer = -1
    Private lCodigoItem As Long = -1
    Private dQuantidade As Double = -1


    Public Property CodigoEntradaCapa() As Long
        Get
            Return lCodigoEntradaCapa
        End Get
        Set(ByVal value As Long)
            lCodigoEntradaCapa = value
        End Set
    End Property

    Public Property CodigoEntradaItem() As Integer
        Get
            Return iCodigoEntradaItem
        End Get
        Set(ByVal value As Integer)
            iCodigoEntradaItem = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

#Region " ::: DADOS GERAIS ::: "

    Private Sub usrFatEntradaNFXML_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrFatEntradaNFXML_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region " ::: NOTA FISCAL ::: "

    Private Sub btnCadastrarCFOP_Click(sender As Object, e As EventArgs) Handles btnCadastrarCFOP.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCFOP")

            'Carrega Combo
            Call LoadCombo(cboCFOP, "sp_select_combo_faturamento_entrada_cfop " & goUsuario.iEmpresa & ", " & lCodigoEntradaCapa, False)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub btnFindCFOPDestinacao_Click(sender As Object, e As EventArgs) Handles btnFindCFOPDestinacao.Click
        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindCFOPDestinacao"
            oForm.Titulo = Me.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar CFOP - Destinação"

            oComboBoxFind = cboCFOP

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCFOP.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub btnCadastrarProduto_Click(sender As Object, e As EventArgs) Handles btnCadastrarProduto.Click
        Try


            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadProduto")

            'Carrega Combo            
            Call LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & TipoItem.produto)

            'Seta Focu
            cboProduto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnProcurarProduto_Click(sender As Object, e As EventArgs) Handles btnProcurarProduto.Click
        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = TipoItem.produto
            oComboBoxFind = cboProduto

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboProduto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub btnConfigurarGridProduto_Click(sender As Object, e As EventArgs) Handles btnConfigurarGridProduto.Click
        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdLote
            oForm.NomeFormulario = Formulario.FaturamentoEntradaCorrecao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdLote, Formulario.FaturamentoEntradaCorrecao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub btnAgruparGridProduto_Click(sender As Object, e As EventArgs) Handles btnAgruparGridProduto.Click
        Try

            'Verifica se o Grupo está Habilita
            If grdLote.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdLote.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdLote.GroupByBoxVisible = True
                grdLote.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub btnExcelGridProduto_Click(sender As Object, e As EventArgs) Handles btnExcelGridProduto.Click
        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdLote)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.FaturamentoEntradaCorrecao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FaturamentoEntradaCorrecao)

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

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        Try

            'Carrega Grid
            Call LoadGrid()

            'Seta Focu
            txtNotaFiscalFiltro.Focus()

            'Alterna Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagListagem)

            'Seta Focu
            txtNotaFiscalFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.FaturamentoEntradaCorrecao, gcInsert) = True Then

                'Insere 
                oClsFatEntradaNFCorrecao.SalvaLote(lCodigoEntradaCapa, _
                                                   iCodigoEntradaItem, _
                                                   cboCFOP.SelectedValue, _
                                                   cboProduto.SelectedValue, _
                                                   cboCSTIPI.Text, _
                                                   txtValorIPI.Value, _
                                                   txtBCIPI.Value, _
                                                   cboCSTICMS.Text, _
                                                   txtValorICMS.Value, _
                                                   txtBCICMS.Value)

                'Informa o Usuário do Sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroInserido)

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdListagem.RowDoubleClick

        Try

            Call Novo()

            'Verifica o Tipo da Linha
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            lCodigoEntradaCapa = grdListagem.CurrentRow.Cells("codigo_entrada_capa").Value
            iCodigoEntradaItem = grdListagem.CurrentRow.Cells("codigo_entrada_item").Value
            lCodigoParceiroNegocio = grdListagem.CurrentRow.Cells("codigo_parceiro_negocio").Value

            'Verifica qual coluna foi pressionada
            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call EditarLote()

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
                                     Formulario.FaturamentoEntradaCorrecao, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.FaturamentoEntradaCorrecao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name, _
                                          Formulario.FaturamentoEntradaCorrecao, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdLote_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdLote.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdLote.Name, _
                                     Formulario.FaturamentoEntradaCorrecao, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdLote_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdLote.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdLote, _
                                     Formulario.FaturamentoEntradaCorrecao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdLote_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdLote.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdLote.Name, _
                                          Formulario.FaturamentoEntradaCorrecao, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click
        Try

            frmMain.errInfo.Clear()

            If ValidacaoItemLote() = True Then

                Call InsertLote()
                Call NovoLote()
                Call LoadGridLote()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub QuantidadeEstoque(sender As Object, e As EventArgs) Handles txtLoteQuantidade.LostFocus, _
                                                                            txtLoteFatorConversao.LostFocus, _
                                                                            txtLoteQuantidadeEstoque.LostFocus

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Select Case sender.Name

                Case "txtLoteFatorConversao" : txtLoteQuantidadeEstoque.Value = txtLoteQuantidade.Value * txtLoteFatorConversao.Value
                Case "txtLoteQuantidadeEstoque" : txtLoteFatorConversao.Value = IIf(txtLoteQuantidade.Value = 0, 0, txtLoteQuantidadeEstoque.Value / txtLoteQuantidade.Value)
                Case "txtLoteQuantidade" : txtLoteQuantidadeEstoque.Value = txtLoteQuantidade.Value * txtLoteFatorConversao.Value

            End Select

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdLote_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdLote.RowDoubleClick
        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdLote.CurrentColumn) Then Exit Sub

            Select Case grdLote.CurrentColumn.Key

                Case "editar" : Call EditarItemLote()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Try

            'Deleta Registros
            Call DeleteLoteItem()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnAtualizarPedidoCompra_Click(sender As Object, e As EventArgs) Handles btnAtualizarPedidoCompra.Click
        Try

            'Abre Formulário para Alteração de Unidade de Medida
            Dim oForm As New frmFatEntradaNFPedidoCompraUnidadeMedida

            'Seta Parâmetros
            oForm.CodigoPedido = lCodigoPedido
            oForm.CodigoPedidoItem = iCodigoPedidoItem
            oForm.Quantidade = txtLoteQuantidadeDocumento.Value

            'Abre Formulário
            oForm.ShowDialog(Me)

            'Atualiza Registro
            Dim sCodigoItem As String = cboLoteProduto.SelectedValue
            cboLoteProduto.SelectedIndex = -1
            cboLoteProduto.SelectedValue = sCodigoItem

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub cboCFOP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCFOP.SelectedIndexChanged
        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se foi Selecionado Algum CFOP
            If cboCFOP.SelectedIndex = -1 Then

                'Limpa Controle
                cboLoteTipoOperacao.Text = ""
                cboLoteTipoOperacao.DataSource = Nothing

                'Desabilita Controle
                cboLoteTipoOperacao.Enabled = False

            Else

                'Carrega Combo
                Call LoadCombo(cboLoteTipoOperacao, "sp_select_combo_static_tipo_operacao_nota_fiscal_entrada " & cboCFOP.SelectedValue & ", " & goUsuario.iEmpresa)

                'Habilita Controle
                cboLoteTipoOperacao.Enabled = True

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub cboLoteTipoOperacao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLoteTipoOperacao.SelectedIndexChanged
        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica o Tipo de Operação Selecionada
            Select Case cboLoteTipoOperacao.SelectedValue

                Case CInt(TipoOperacaoNotaFiscalEntrada.EntradaNFe), CInt(TipoOperacaoNotaFiscalEntrada.RemessaTerceiros)
                    Call LoadCombo(cboLoteProduto, "sp_select_combo_cadastro_basico_item_descricao " & goUsuario.iEmpresa & ", NULL, 1, " & CInt(TipoItem.produto), False)

                Case CInt(TipoOperacaoNotaFiscalEntrada.EntradaNFeNumeroDocumento)
                    Call LoadCombo(cboLoteProduto, "sp_select_combo_cadastro_basico_item_descricao " & goUsuario.iEmpresa & ", NULL, 1, " & CInt(TipoItem.produto), False)

                Case CInt(TipoOperacaoNotaFiscalEntrada.Compra)
                    Call LoadCombo(cboLoteNumeroDocumento, "sp_select_combo_faturamento_entrada_correcao_pedido_compra " & goUsuario.iEmpresa & ", " & lCodigoParceiroNegocio & ", " & lCodigoEntradaCapa & ", " & iCodigoEntradaItem & ", NULL", False) : btnAtualizarPedidoCompra.Enabled = True
                Case CInt(TipoOperacaoNotaFiscalEntrada.DevolucaoNFe)
                    Call LoadCombo(cboLoteNumeroDocumento, "sp_select_combo_faturamento_entrada_nota_fiscal_devolucao " & goUsuario.iEmpresa & ", " & lCodigoParceiroNegocio, False)

                Case CInt(TipoOperacaoNotaFiscalEntrada.RetornoRemessaIndustrializacao)
                    Call LoadCombo(cboLoteNumeroDocumento, "sp_select_combo_faturamento_entrada_nota_fiscal_retorno_remessa_industrializacao  " & goUsuario.iEmpresa & ", " & lCodigoParceiroNegocio & ", " & lCodigoEntradaCapa & ", " & iCodigoEntradaItem & ", NULL", False)

                Case CInt(TipoOperacaoNotaFiscalEntrada.OrdemProducao)
                    Call LoadCombo(cboLoteNumeroDocumento, "sp_select_combo_faturamento_entrada_nota_fiscal_ordem_producao  " & goUsuario.iEmpresa & ", " & lCodigoParceiroNegocio & ", " & lCodigoEntradaCapa & ", " & iCodigoEntradaItem & ", NULL", False)

            End Select

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub cboLoteNumeroDocumento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLoteNumeroDocumento.SelectedIndexChanged
        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se foi Selecionado algum Registro
            If cboLoteNumeroDocumento.SelectedIndex <> -1 Then

                'Verifica o Tipo de Operação
                Select Case cboLoteTipoOperacao.SelectedValue

                    Case CInt(TipoOperacaoNotaFiscalEntrada.Compra)
                        lCodigoPedido = cboLoteNumeroDocumento.SelectedValue
                        Call LoadCombo(cboLoteProduto, "sp_select_combo_faturamento_entrada_correcao_pedido_compra_produto " & goUsuario.iEmpresa & ", " & lCodigoPedido, False)

                    Case CInt(TipoOperacaoNotaFiscalEntrada.DevolucaoNFe)
                        lCodigoEmissaoCapa = cboLoteNumeroDocumento.SelectedValue
                        Call LoadCombo(cboLoteProduto, "sp_select_combo_faturamento_entrada_nota_fiscal_devolucao_produto " & goUsuario.iEmpresa & ", " & lCodigoEmissaoCapa & ", " & lCodigoEntradaCapa & ", " & iCodigoEntradaItem & ", NULL", False)

                    Case CInt(TipoOperacaoNotaFiscalEntrada.RetornoRemessaIndustrializacao)
                        Call LoadCombo(cboLoteProduto, "sp_select_combo_faturamento_entrada_nota_fiscal_retorno_remessa_industrializacao " & goUsuario.iEmpresa & ", " & lCodigoEmissaoCapa & ", " & lCodigoEntradaCapa & ", " & iCodigoEntradaItem & ", NULL", False)

                    Case CInt(TipoOperacaoNotaFiscalEntrada.OrdemProducao)
                        Call LoadCombo(cboLoteProduto, "sp_select_combo_faturamento_entrada_ordem_producao_produto " & goUsuario.iEmpresa & ", " & lCodigoPedido & ", " & lCodigoEntradaCapa & ", " & iCodigoEntradaItem & ", " & cboLoteNumeroDocumento.SelectedValue, False)

                End Select

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub cboProdutoLote_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLoteProduto.SelectedIndexChanged
        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor



            'Verifica se foi Selecionado Algum Registro
            If cboLoteProduto.SelectedIndex > -1 Then

                Select Case cboLoteTipoOperacao.SelectedValue

                    Case CInt(TipoOperacaoNotaFiscalEntrada.EntradaNFe), CInt(TipoOperacaoNotaFiscalEntrada.RemessaTerceiros), CInt(TipoOperacaoNotaFiscalEntrada.OrdemProducao)
                        lCodigoItem = cboLoteProduto.SelectedValue

                    Case CInt(TipoOperacaoNotaFiscalEntrada.Compra)
                        Dim sAux() As String = cboLoteProduto.SelectedValue.ToString.Split("|")
                        lCodigoPedido = cboLoteNumeroDocumento.SelectedValue
                        iCodigoPedidoItem = sAux(0)
                        iCodigoPedidoItemEntrega = sAux(1)
                        lCodigoItem = sAux(2)

                    Case CInt(TipoOperacaoNotaFiscalEntrada.DevolucaoNFe)
                        Dim sAux() As String = cboLoteProduto.SelectedValue.ToString.Split("|")
                        lCodigoEmissaoCapa = cboLoteNumeroDocumento.SelectedValue
                        iCodigoEmissaoItem = sAux(0)
                        lCodigoItem = sAux(1)

                End Select


                'Carrega Dados do Produto
                Call oClsFatEntradaNFCorrecao.LoadDadosProduto(cboLoteTipoOperacao.SelectedValue, _
                                                                 cboLoteNumeroDocumento.SelectedValue, _
                                                                 lCodigoItem, _
                                                                 lCodigoEntradaCapa, _
                                                                 iCodigoEntradaItem, _
                                                                 lCodigoPedido, _
                                                                 iCodigoPedidoItem, _
                                                                 iCodigoPedidoItemEntrega, _
                                                                 lCodigoEmissaoCapa, _
                                                                 iCodigoEmissaoItem, _
                                                                 dQuantidade)

                txtLoteQuantidadeDocumento.Value = dQuantidade

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try
    End Sub
#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region " ::: DADOS GERAIS ::: "

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFatEntradaNFXML_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            Call ConfiguraGrid(grdListagem, Formulario.FaturamentoEntradaCorrecao)

            'Carrega Combo 
            Call LoadCombo(cboCFOPFiltro, "sp_select_combo_cadastro_basico_cfop " & goUsuario.iEmpresa & ", 'E'")
            Call LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_nota_fiscal_entrada")
            Call LoadCombo(cboTipoOperacaoFiltro, "sp_select_combo_static_tipo_operacao_nota_fiscal_entrada -1, " & goUsuario.iEmpresa)
            Call LoadCombo(cboLoteUnidadeMedida, "sp_select_combo_cadastro_basico_unidade_medida " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_item_descricao " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.produto), False)
            Call LoadCombo(cboCFOP, "sp_select_combo_cadastro_basico_cfop " & goUsuario.iEmpresa & ", 'E'")
            Call LoadCombo(cboCSTICMS, "sp_select_combo_static_situacao_tributaria_icms_codigo")
            Call LoadCombo(cboCSTIPI, "sp_select_combo_static_situacao_tributaria_ipi_codigo")
            Call LoadCombo(cboLoteDeposito, "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa)
            Call LoadCombo(cboLoteContaContabil, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa)
            Call LoadCombo(cboLoteCentroGasto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)
            Call LoadComboSimNao(cboLoteControlaQualidade)

            'Verifica Direito
            btnCadastrarCFOP.Enabled = VerificaDireito(Formulario.CadastroBasicoCFOP, gcInsert)
            btnFindCFOPDestinacao.Enabled = VerificaDireito(Formulario.CadastroBasicoCFOP, gcSelect)
            btnCadastrarProduto.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcInsert)
            btnProcurarProduto.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcSelect)
            btnAtualizarPedidoCompra.Enabled = False

            'Seta CalendarCombo
            dtpDataEmissaoInicioFiltro.Value = Now.Date : dtpDataEmissaoInicioFiltro.Checked = False
            dtpDataEmissaoTerminoFiltro.Value = Now.Date : dtpDataEmissaoTerminoFiltro.Checked = False
            dtpDataEntradaInicioFiltro.Value = Now.Date : dtpDataEntradaInicioFiltro.Checked = False
            dtpDataEntradaTerminoFiltro.Value = Now.Date : dtpDataEntradaTerminoFiltro.Checked = False

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            txtNotaFiscalFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region " ::: NOTA FISCAL ::: "

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim sCFOP As String = ""
            Dim sStatus As String = ""
            Dim i As Integer

            'CFOP
            If cboCFOPFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboCFOPFiltro.CheckedValues)
                    sCFOP &= IIf(sCFOP = "", "", ",") & cboCFOPFiltro.CheckedValues(i).ToString
                Next
            End If

            'Status
            If cboStatusFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboStatusFiltro.CheckedValues)
                    sStatus &= IIf(sStatus = "", "", ",") & cboStatusFiltro.CheckedValues(i).ToString
                Next
            End If

            'Seta Parametros
            Call oClsFatEntradaNFCorrecao.LoadGridNotaFiscal(grdListagem, _
                                                     IIf(IsNumeric(txtNotaFiscalFiltro.Text.Trim), txtNotaFiscalFiltro.Text.Trim, -1), _
                                                     IIf(IsNumeric(txtSerieFiltro.Text.Trim), txtSerieFiltro.Text.Trim, ""), _
                                                     txtEmitenteFiltro.Text.Trim, _
                                                     IIf(dtpDataEmissaoInicioFiltro.Checked = False, "", dtpDataEmissaoInicioFiltro.Value), _
                                                     IIf(dtpDataEmissaoTerminoFiltro.Checked = False, "", dtpDataEmissaoTerminoFiltro.Value), _
                                                     txtProdutoFiltro.Text.Trim, _
                                                     txtLoteFiltro.Text.Trim, _
                                                     IIf(dtpDataEntradaInicioFiltro.Checked = False, "", dtpDataEntradaInicioFiltro.Value), _
                                                     IIf(dtpDataEntradaTerminoFiltro.Checked = False, "", dtpDataEntradaTerminoFiltro.Value), _
                                                     sCFOP, _
                                                     IIf(cboTipoOperacaoFiltro.SelectedIndex = -1, -1, cboTipoOperacaoFiltro.SelectedValue), _
                                                     txtNumeroDocumentoFiltro.Text.Trim, _
                                                     sStatus)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Erro
            frmMain.errInfo.Clear()

            cboCFOP.SelectedIndex = -1
            txtNotaFiscal.Text = ""
            cboProduto.SelectedIndex = -1
            txtNCM.Text = ""
            txtUnidadeMedida.Text = ""
            txtQuantidade.Text = ""
            txtValorUnitario.Text = ""
            txtValorTotal.Text = ""
            cboCSTIPI.SelectedIndex = -1
            txtValorIPI.Text = ""
            txtBCIPI.Text = ""
            cboCSTICMS.SelectedIndex = -1
            txtValorICMS.Text = ""
            txtBCICMS.Text = ""
            btnAtualizarPedidoCompra.Enabled = False
            Call NovoLote()

            lCodigoEntradaCapa = -1
            iCodigoEntradaItem = -1
            lCodigoParceiroNegocio = -1

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoLote()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Erro
            frmMain.errInfo.Clear()

            cboLoteTipoOperacao.SelectedIndex = -1
            cboLoteNumeroDocumento.SelectedIndex = -1 : btnAtualizarPedidoCompra.Enabled = False
            cboLoteProduto.SelectedIndex = -1
            txtLoteQuantidadeDocumento.Value = 0
            cboLoteNumeroDocumento.DataSource = Nothing
            cboLoteProduto.DataSource = Nothing
            cboLoteCentroGasto.SelectedIndex = -1 : cboLoteCentroGasto.Text = ""
            cboLoteContaContabil.SelectedIndex = -1 : cboLoteContaContabil.Text = ""
            cboLoteControlaQualidade.SelectedIndex = -1 : cboLoteControlaQualidade.Text = ""
            cboLoteDeposito.SelectedIndex = -1 : cboLoteDeposito.Text = ""
            cboLoteUnidadeMedida.SelectedIndex = -1
            dtpLoteDataFabricacao.Checked = False
            dtpLoteDataValidade.Checked = False
            dtpLoteDataValidade.Value = Now.Date
            dtpLoteDataFabricacao.Value = Now.Date
            txtLoteFabricante.Text = ""
            txtLoteFatorConversao.Value = 0
            txtLoteQuantidade.Value = 0
            txtLoteQuantidadeEstoque.Value = 0
            btnInserir.Tag = ""
            lCodigoEmissaoCapa = -1
            iCodigoEmissaoItem = -1
            lCodigoPedido = -1
            iCodigoPedidoItem = -1
            iCodigoPedidoItemEntrega = -1
            lCodigoItem = -1
            dQuantidade = -1

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarLote()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.FaturamentoEntradaCorrecao, gcUpdate) = True Then

                'Carrega dados da Nota Fiscal
                oClsFatEntradaNFCorrecao.LoadDadosNotaFiscal(lCodigoEntradaCapa, _
                                                             iCodigoEntradaItem, _
                                                             cboCFOP, _
                                                             txtNotaFiscal, _
                                                             cboProduto, _
                                                             txtNCM, _
                                                             txtUnidadeMedida, _
                                                             txtQuantidade, _
                                                             txtValorUnitario, _
                                                             txtValorTotal, _
                                                             cboCSTIPI, _
                                                             txtValorIPI, _
                                                             txtBCIPI, _
                                                             cboCSTICMS, _
                                                             txtValorICMS, _
                                                             txtBCICMS)

                Call LoadGridLote()

                If IsNumeric(txtNotaFiscal.Tag) = True Then
                    btnAtualizarPedidoCompra.Enabled = True
                Else
                    btnAtualizarPedidoCompra.Enabled = False
                End If

                tabMain.TabPages.Remove(pagListagem)
                tabMain.TabPages.Add(pagDados)

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoLote() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoLote = False

            If ValidaCampo(cboCFOP, lblCFOP) = False Then
                Exit Function
            End If

            If ValidaCampo(cboProduto, lblProduto) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoLote = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub LoadGridLote()

        Try
            oClsFatEntradaNFCorrecao.LoadGridLote(grdLote, _
                                          lCodigoEntradaCapa, _
                                          iCodigoEntradaItem)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoItemLote() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoItemLote = False

            If ValidaCampo(txtLoteQuantidade, lblLoteQuantidade, True) = False Then
                Exit Function
            End If

            If ValidaCampo(cboLoteUnidadeMedida, lblUnidadeMedida) = False Then
                Exit Function
            End If

            If ValidaCampo(txtLoteFatorConversao, lblFatorConversao, True) = False Then
                Exit Function
            End If

            If ValidaCampo(txtLoteQuantidadeEstoque, lblQuantidadeEstoque, True) = False Then
                Exit Function
            End If

            'Váriavel Local
            Dim dQuantidade As Double = 0

            'Seta Váriavel
            If grdLote.GetDataRows.Count > 0 Then
                dQuantidade = grdLote.GetTotalRow.Cells("quantidade").Value
                If IsNumeric(btnInserir.Tag) Then
                    dQuantidade -= grdLote.CurrentRow.Cells("quantidade").Value
                End If
            End If

            'Verifica se a Quantidade é Válida
            If dQuantidade + txtLoteQuantidade.Value > txtQuantidade.Value Then
                frmMain.errInfo.SetError(lblLoteQuantidade, "A Quantidade informada NÃO pode ser maior que a Quantidade da Nota Fiscal.")
                txtLoteQuantidade.Focus()
                Exit Function
            End If

            'Verifica se a Data de Fabricação é correta
            If dtpLoteDataFabricacao.Checked = True Then
                If dtpLoteDataFabricacao.Value > Now.Date Then
                    frmMain.errInfo.SetError(lblDataFabricacao, "A Data de Fabricação NÃO pode ser maior que a Data Corrente.")
                    dtpLoteDataFabricacao.Focus()
                End If
            End If

            'Verifica se a Data de Validade é correta
            If dtpLoteDataValidade.Checked = True Then
                If dtpLoteDataValidade.Value < Now.Date Then
                    frmMain.errInfo.SetError(lblDataValidade, "A Data de Validade NÃO pode ser menor que a Data Corrente.")
                    dtpLoteDataValidade.Focus()
                End If
            End If

            'Seta Retorno da Função
            ValidacaoItemLote = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub InsertLote()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.FaturamentoEntradaCorrecao, gcInsert) = True Then

                'Verifica o Tipo de Operação
                If IsNumeric(btnInserir.Tag) = False Then

                    'Insere 
                    oClsFatEntradaNFCorrecao.InsertLote(lCodigoEntradaCapa, _
                                                        iCodigoEntradaItem, _
                                                        cboLoteTipoOperacao.SelectedValue, _
                                                        cboLoteNumeroDocumento.Text, _
                                                        lCodigoItem, _
                                                        txtLoteQuantidade.Value, _
                                                        cboLoteUnidadeMedida.SelectedValue, _
                                                        txtLoteFatorConversao.Value, _
                                                        txtLoteQuantidadeEstoque.Value, _
                                                        IIf(cboLoteDeposito.SelectedIndex = -1, -1, cboLoteDeposito.SelectedValue), _
                                                        IIf(cboLoteContaContabil.SelectedIndex = -1, -1, cboLoteContaContabil.SelectedValue), _
                                                        IIf(dtpLoteDataFabricacao.Checked = True, dtpLoteDataFabricacao.Value, ""), _
                                                        txtLoteFabricante.Text, _
                                                        IIf(dtpLoteDataValidade.Checked = True, dtpLoteDataValidade.Value, ""), _
                                                        cboLoteControlaQualidade.SelectedValue, _
                                                        IIf(cboLoteCentroGasto.SelectedIndex = -1, -1, cboLoteCentroGasto.SelectedValue), _
                                                        lCodigoPedido, _
                                                        iCodigoPedidoItem, _
                                                        iCodigoPedidoItemEntrega, _
                                                        lCodigoEmissaoCapa, _
                                                        iCodigoEmissaoItem)

                    'Informa o Usuário do Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroInserido)

                Else

                    'Altera 
                    oClsFatEntradaNFCorrecao.UpdateLote(btnInserir.Tag, _
                                                        lCodigoEntradaCapa, _
                                                        iCodigoEntradaItem, _
                                                        txtLoteQuantidade.Value, _
                                                        cboLoteUnidadeMedida.SelectedValue, _
                                                        txtLoteFatorConversao.Value, _
                                                        txtLoteQuantidadeEstoque.Value, _
                                                        IIf(cboLoteDeposito.SelectedIndex = -1, -1, cboLoteDeposito.SelectedValue), _
                                                        IIf(cboLoteContaContabil.SelectedIndex = -1, -1, cboLoteContaContabil.SelectedValue), _
                                                        IIf(dtpLoteDataFabricacao.Checked = True, dtpLoteDataFabricacao.Value, ""), _
                                                        txtLoteFabricante.Text, _
                                                        IIf(dtpLoteDataValidade.Checked = True, dtpLoteDataValidade.Value, ""), _
                                                        cboLoteControlaQualidade.SelectedValue, _
                                                        IIf(cboLoteCentroGasto.SelectedIndex = -1, -1, cboLoteCentroGasto.SelectedValue), _
                                                        lCodigoPedido, _
                                                        iCodigoPedidoItem, _
                                                        iCodigoPedidoItemEntrega, _
                                                        lCodigoEmissaoCapa, _
                                                        iCodigoEmissaoItem, _
                                                        lCodigoItem)

                    'Informa o Usuário do Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroAlterado)

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

    Private Sub EditarItemLote()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor


            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.FaturamentoEntradaCorrecao, gcUpdate) = True Then

                btnInserir.Tag = grdLote.CurrentRow.Cells("codigo").Value

                With grdLote.CurrentRow.Cells

                    cboLoteTipoOperacao.SelectedValue = .Item("codigo_tipo_operacao").Value
                    cboLoteNumeroDocumento.Text = .Item("numero_documento").Value
                    cboLoteProduto.SelectedValue = .Item("codigo_composto_produto").Value
                    txtLoteQuantidade.Value = .Item("quantidade").Value
                    cboLoteUnidadeMedida.SelectedValue = .Item("codigo_unidade_medida").Value
                    txtLoteFatorConversao.Value = .Item("fator_conversao").Value
                    txtLoteQuantidadeEstoque.Value = .Item("quantidade_estoque").Value
                    cboLoteDeposito.SelectedValue = .Item("codigo_deposito").Value
                    cboLoteContaContabil.SelectedValue = .Item("conta_contabil").Value
                    txtLoteFabricante.Text = .Item("lote").Value
                    cboLoteControlaQualidade.SelectedValue = .Item("controla_qualidade").Value
                    cboLoteCentroGasto.SelectedValue = .Item("codigo_centro_gasto").Value

                    If IsDBNull(.Item("data_fabricacao").Value) = True Then
                        dtpLoteDataFabricacao.Checked = False
                    Else
                        dtpLoteDataFabricacao.Checked = True
                        dtpLoteDataFabricacao.Value = .Item("data_fabricacao").Value
                    End If

                    If IsDBNull(.Item("data_validade").Value) = True Then
                        dtpLoteDataValidade.Checked = False
                    Else
                        dtpLoteDataValidade.Checked = True
                        dtpLoteDataValidade.Value = .Item("data_validade").Value
                    End If

                End With

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

    Private Sub DeleteLoteItem()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdLote) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro do Banco de Dados
                    oClsFatEntradaNFCorrecao.DeleteLote()

                    'Prepara Formulário para Inserção de um Novo Registro
                    Call NovoLote()

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

#End Region

#End Region

End Class