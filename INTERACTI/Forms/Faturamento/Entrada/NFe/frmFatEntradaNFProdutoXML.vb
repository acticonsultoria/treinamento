Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports System.Math

Public Class frmFatEntradaNFProdutoXML

#Region "::: VARIAVEIS :::"

    'Váriaveis
    Private oClsFatEntradaNFProdutoXML As New clsFrmFatEntradaNFProdutoXML
    Private lCodigoEntradaCapa As Long
    Private sUFEmitente As String
    Private sResultado As String
    Private oCurrentRow As GridEXRow

    Private lCodigoItem As Long
    Private lCodigoPedido As Long
    Private iCodigoPedidoItem As Integer
    Private iCodigoPedidoItemEntrega As Integer
    Private lCodigoEmissaoCapa As Long
    Private iCodigoEmissaoItem As Integer
    Private iCodigoEntradaItem As Integer
    Private iCodigoEntradaItemLote As Integer
    Private iCodigoParceiroNegocio As Integer
    Private sInformacoesAdicionais As String
    Private dQuantidadeXML As Double

    Private iCodigoUnidadeMedida As Integer
    Private bCFOPEstoque As Boolean
    Private bItemEstoque As Boolean
    Private bControlaQualidade As Boolean
    Private bControlaLote As Boolean
    Private bDataFabricacao As Boolean
    Private bDataValidade As Boolean
    Private dQuantidadePedido As Double
    Private dQuantidadePendente As Double
    Private dValorUnitario As Double
    Private dFatorConversao As Double
    Private sUnidadeMedida As String
    Private dToleranciaQuantidadePercentual As Double
    Private dToleranciaValor As Double
    Private iCodigoCentroGasto As Integer
    Private sContaContabil As String

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property CodigoEntradaCapa() As Long
        Set(ByVal value As Long)
            lCodigoEntradaCapa = value
        End Set
    End Property

    Public WriteOnly Property UFEmitente() As String
        Set(ByVal value As String)
            sUFEmitente = value
        End Set
    End Property

    Public ReadOnly Property Resultado() As String
        Get
            Return sResultado
        End Get
    End Property

#End Region

#Region "::: CONTROLES :::"

#Region "::: GERAL :::"

    Private Sub frmFatEmissaoNFeProdutoXML_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.F2
                    Select Case sender.Name
                        Case "cboProduto" : Call DadosProduto()
                    End Select

                Case Keys.F3

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboProduto" : Call btnProcurarProduto_Click(btnProcurarProduto, System.EventArgs.Empty)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboProduto" : If cboNumeroDocumento.Enabled = False Then Call cboTipoOperacao_SelectedIndexChanged(cboTipoOperacao, System.EventArgs.Empty) Else Call cboNumeroDocumento_SelectedIndexChanged(cboNumeroDocumento, System.EventArgs.Empty)
                        Case "cboCFOPEntrada" : Call LoadCombo(cboCFOP, "sp_select_combo_faturamento_entrada_cfop " & goUsuario.iEmpresa & ", " & lCodigoEntradaCapa)
                        Case "cboDeposito" : Call cboProduto_SelectedIndexChanged(cboProduto, System.EventArgs.Empty) : cboDeposito.Focus()
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboProduto" : Call btnCadastrarProduto_Click(btnCadastrarProduto, System.EventArgs.Empty)
                        Case "cboDeposito" : Call btnCadastrarDeposito_Click(btnCadastrarDeposito, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmFatEmissaoNFeProdutoXML_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

#End Region

#Region "::: NOTA FISCAL ENTRADA XML :::"

    Private Sub btnConfigurarGridXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridXML.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdXML
            oForm.NomeFormulario = Formulario.FaturamentoEntradaNF
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdXML, Formulario.FaturamentoEntradaNF)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnAgruparGridXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridXML.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdXML.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdXML.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdXML.GroupByBoxVisible = True
                grdXML.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGridXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridXML.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdXML)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click

        Try

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Item
                Call SalvarXML()

                'Seta Váriavel 
                sResultado = "S"

                'Fecha o Formulário
                Me.Dispose()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Try

            'Verifica se o usuário deseja cancelar a importação da Nota Fiscal Eletrônica
            If MsgBox("Deseja Cancelar a Importação da Nota Fiscal Eletrônica?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                'Seta Váriavel 
                sResultado = "N"

                'Fecha o Formulário
                Me.Dispose()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub chkCadastrarProduto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCadastrarProduto.CheckedChanged
        Try

            'Variavel
            Dim lCodigoItemAutomatico As Long

            'Verifica se o usuário deseja cancelar a importação da Nota Fiscal Eletrônica
            If MsgBox("Deseja cadastrar o produto selecionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                'Verifica se foi selecionado o Tipo de Operação - Entrada Nota Fiscal
                'Verifica se foi Selecionado o Campo - Tipo de Operação
                If ValidaCampo(cboTipoOperacao, lblTipoOperacao) = False Then
                    Exit Sub
                End If

                If cboTipoOperacao.SelectedValue = CInt(TipoOperacaoNotaFiscalEntrada.EntradaNFe) Then


                    'Cadastra Produto
                    oClsFatEntradaNFProdutoXML.InsertCadastroProduto(lCodigoItemAutomatico, _
                                                                     grdXML.CurrentRow.Cells.Item("codigo_produto").Value, _
                                                                     grdXML.CurrentRow.Cells.Item("descricao").Value, _
                                                                     grdXML.CurrentRow.Cells.Item("unidade_medida").Value, _
                                                                     grdXML.CurrentRow.Cells.Item("ncm").Value, _
                                                                     grdXML.CurrentRow.Cells.Item("valor_unitario").Value)


                    'Carrega Combo de Produto
                    Call LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_item_descricao " & goUsuario.iEmpresa & ", NULL, 1, " & CInt(TipoItem.produto), False)


                    'Seleciona o produto
                    cboProduto.SelectedValue = lCodigoItemAutomatico
                    txtQuantidade.Value = grdXML.CurrentRow.Cells.Item("quantidade").Value

                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub VerificaGrid()
        Try



            'Verifica o Status da Linha
            If grdXML.CurrentRow.CheckState = RowCheckState.Checked Then

                'Verifica se tinha outra linha selecionada
                If IsNothing(oCurrentRow) = False Then
                    oCurrentRow.CheckState = RowCheckState.Unchecked
                End If

                'Seta Váriaveis
                oCurrentRow = grdXML.CurrentRow
                iCodigoParceiroNegocio = grdXML.CurrentRow.Cells("codigo_parceiro_negocio").Value
                iCodigoEntradaItem = grdXML.CurrentRow.Cells("codigo_entrada_item").Value
                sInformacoesAdicionais = grdXML.CurrentRow.Cells("informacoes_adicionais").Value
                dQuantidadeXML = grdXML.CurrentRow.Cells("quantidade").Value

                'Carrega Grid - Recebimento
                Call LoadGridRecebimento()

                'Habilita Controle
                cboCFOP.Enabled = True

            Else

                'Limpa Váriavel
                iCodigoParceiroNegocio = -1
                iCodigoEntradaItem = -1
                sInformacoesAdicionais = ""
                dQuantidadeXML = 0

                'Limpa Grid
                grdRecebimento.DataSource = Nothing

                'Desabilita Controle
                cboCFOP.Enabled = False

            End If

            'Limpa Formulário - Recebimento
            Call NovoRecebimento()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub grdXML_RowCheckStateChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowCheckStateChangeEventArgs) Handles grdXML.RowCheckStateChanged

        Try



            'Verifica o Status da Linha
            If e.CheckState = RowCheckState.Checked Then

                'Verifica se tinha outra linha selecionada
                If IsNothing(oCurrentRow) = False Then
                    oCurrentRow.CheckState = RowCheckState.Unchecked
                End If

                'Seta Váriaveis
                oCurrentRow = e.Row
                iCodigoParceiroNegocio = oCurrentRow.Cells("codigo_parceiro_negocio").Value
                iCodigoEntradaItem = oCurrentRow.Cells("codigo_entrada_item").Value
                sInformacoesAdicionais = oCurrentRow.Cells("informacoes_adicionais").Value
                dQuantidadeXML = oCurrentRow.Cells("quantidade").Value

                'Carrega Grid - Recebimento
                Call LoadGridRecebimento()

                'Habilita Controle
                cboTipoOperacao.Enabled = True

            Else

                'Limpa Váriavel
                oCurrentRow = Nothing
                iCodigoParceiroNegocio = -1
                iCodigoEntradaItem = -1
                sInformacoesAdicionais = ""
                dQuantidadeXML = 0

                'Limpa Grid
                grdRecebimento.DataSource = Nothing

                'Desabilita Controle
                cboTipoOperacao.Enabled = False

            End If

            'Limpa Formulário - Recebimento
            Call NovoRecebimento()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdXML_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdXML.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdXML.Name, _
                                     Formulario.FaturamentoEntradaNF, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdXML_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdXML.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdXML, _
                                     Formulario.FaturamentoEntradaNF)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdXML_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdXML.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdXML.Name, _
                                          Formulario.FaturamentoEntradaNF, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: RECEBIMENTO :::"

    Private Sub btnBaixarMultiplo_Click(sender As Object, e As EventArgs) Handles btnBaixarMultiplo.Click
        Try

            Dim oForm As New frmFatEntradaNFProdutoXMLLote
            oForm.CodigoEntradaCapa = lCodigoEntradaCapa
            oForm.CodigoEntradaItem = iCodigoEntradaItem
            oForm.QuantidadeNF = dQuantidadeXML
            oForm.CodigoFornecedor = iCodigoParceiroNegocio

            oForm.ShowDialog()

            'Carrega Grid - Entrega
            Call LoadGridXML()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnConfigurarGridRecebimento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridRecebimento.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdRecebimento
            oForm.NomeFormulario = Formulario.FaturamentoEntradaNF
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdRecebimento, Formulario.FaturamentoEntradaNF)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnAgruparGridRecebimento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridRecebimento.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdRecebimento.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdRecebimento.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdRecebimento.GroupByBoxVisible = True
                grdRecebimento.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGridRecebimento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridRecebimento.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdRecebimento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCadastrarProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarProduto.Click

        Try

               'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadProduto")

            'Carrega Combo - Item
            If cboNumeroDocumento.Enabled = False Then Call cboTipoOperacao_SelectedIndexChanged(cboTipoOperacao, System.EventArgs.Empty) Else Call cboNumeroDocumento_SelectedIndexChanged(cboNumeroDocumento, System.EventArgs.Empty)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCadastrarDeposito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarDeposito.Click

        Try

               'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadDeposito")

            'Chama Evento
            Call cboProduto_SelectedIndexChanged(cboProduto, System.EventArgs.Empty)

            'Seta Focu
            cboDeposito.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCadastrarCentroGasto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCentroGasto.Click

        Try

               'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCentroGasto")

            'Carrega Combo            
            Call LoadCombo(cboCentroGasto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)

            'Seta Focu
            cboCentroGasto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCadastrarContaContabil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarContaContabil.Click

        Try

               'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadPlanoContas")

            'Carrega Combo            
            Call LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa)

            'Seta Focu
            cboContaContabil.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnProcurarProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarProduto.Click

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

    Private Sub btnProcurarCentroGasto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCentroGasto.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindCentroGasto"
            oForm.Titulo = Me.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Centro de Gasto"

            'Seta Váriaveis
            lCodigoItemFind = IIf(cboProduto.SelectedIndex = -1, -1, cboProduto.SelectedValue)
            oComboBoxFind = cboCentroGasto

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCentroGasto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnProcurarContaContabil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarContaContabil.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindPlanoContas"
            oForm.Titulo = Me.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Conta Contábil"

            'Seta Váriaveis
            lCodigoItemFind = IIf(cboProduto.SelectedIndex = -1, -1, cboProduto.SelectedValue)
            oComboBoxFind = cboContaContabil

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboContaContabil.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnFindCFOPDestinacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindCFOPDestinacao"
            oForm.Titulo = Me.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar CFOP - Destinação"

            oComboBoxFind = cboCFOP
            oComboBoxFind.Tag = sUFEmitente

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCFOP.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnAtualizarPedidoCompra_Click(sender As Object, e As EventArgs) Handles btnAtualizarPedidoCompra.Click

        Try

            'Abre Formulário para Alteração de Unidade de Medida
            Dim oForm As New frmFatEntradaNFPedidoCompraUnidadeMedida

            'Seta Parâmetros
            oForm.CodigoPedido = lCodigoPedido
            oForm.CodigoPedidoItem = iCodigoPedidoItem
            oForm.Quantidade = txtQuantidadeDocumento.Value

            'Abre Formulário
            oForm.ShowDialog(Me)

            'Atualiza Registro
            Call cboProduto_SelectedIndexChanged(cboProduto, System.EventArgs.Empty)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnInserir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserir.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoRecebimento() = True Then

                'Insere Registro
                Call SalvarRecebimento()

                'Carrega Grid - Entrega
                Call LoadGridXML()

                Try
                    grdXML.CurrentRow.CheckState = RowCheckState.Unchecked
                    grdXML.Row = grdXML.Row + 1
                    grdXML.CurrentRow.CheckState = RowCheckState.Checked

                    grdXML.Refresh()

                    Call VerificaGrid()

                    If cboNumeroDocumento.SelectedIndex <> -1 Then

                        'Verifica o Tipo de Operação
                        Select Case cboTipoOperacao.SelectedValue

                            Case CInt(TipoOperacaoNotaFiscalEntrada.Compra)
                                'Seta Váriavel
                                lCodigoPedido = cboNumeroDocumento.SelectedValue
                                'Carrega Combo
                                Call LoadCombo(cboProduto, "sp_select_combo_faturamento_entrada_pedido_compra_produto " & goUsuario.iEmpresa & ", " & lCodigoPedido & ", " & lCodigoEntradaCapa & ", " & iCodigoEntradaItem & ", " & iCodigoEntradaItemLote, False)

                            Case CInt(TipoOperacaoNotaFiscalEntrada.DevolucaoNFe)
                                'Seta Váriavel
                                lCodigoEmissaoCapa = cboNumeroDocumento.SelectedValue
                                'Carrega Combo
                                Call LoadCombo(cboProduto, "sp_select_combo_faturamento_entrada_nota_fiscal_devolucao_produto " & goUsuario.iEmpresa & ", " & lCodigoEmissaoCapa & ", " & lCodigoEntradaCapa & ", " & iCodigoEntradaItem & ", " & iCodigoEntradaItemLote, False)

                            Case CInt(TipoOperacaoNotaFiscalEntrada.RetornoRemessaIndustrializacao)
                                'Carrega Combo
                                Call LoadCombo(cboProduto, "sp_select_combo_faturamento_entrada_nota_fiscal_retorno_remessa_industrializacao " & goUsuario.iEmpresa & ", " & lCodigoEmissaoCapa & ", " & lCodigoEntradaCapa & ", " & iCodigoEntradaItem & ", " & iCodigoEntradaItemLote, False)

                            Case CInt(TipoOperacaoNotaFiscalEntrada.OrdemProducao)
                                'Carrega Combo
                                Call LoadCombo(cboProduto, "sp_select_combo_faturamento_entrada_ordem_producao_produto " & goUsuario.iEmpresa & ", " & lCodigoPedido & ", " & lCodigoEntradaCapa & ", " & iCodigoEntradaItem & ", " & cboNumeroDocumento.SelectedValue, False)

                        End Select
                    End If

                Catch ex As Exception

                End Try


                'Limpa Formulário - Recebimento
                Call NovoRecebimento()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Exclui Entrega
            Call DeleteRecebimento()

            'Carrega Grid - Entrega
            Call LoadGridXML()

            'Limpa Formulário
            Call NovoRecebimento()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub QuantidadeEstoque(sender As Object, e As EventArgs) Handles txtQuantidade.LostFocus, _
                                                                            txtFatorConversao.LostFocus, _
                                                                            txtQuantidadeEstoque.LostFocus

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Select Case sender.Name

                Case "txtFatorConversao" : txtQuantidadeEstoque.Value = txtQuantidade.Value * txtFatorConversao.Value
                Case "txtQuantidadeEstoque" : txtFatorConversao.Value = IIf(txtQuantidade.Value = 0, 0, txtQuantidadeEstoque.Value / txtQuantidade.Value)
                Case "txtQuantidade" : txtQuantidadeEstoque.Value = txtQuantidade.Value * txtFatorConversao.Value

            End Select

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboCFOP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCFOP.SelectedIndexChanged
        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se foi Selecionado Algum CFOP
            If cboCFOP.SelectedIndex = -1 Then

                'Limpa Controle
                'cboTipoOperacao.Text = ""
                bCFOPEstoque = False
                'cboTipoOperacao.DataSource = Nothing

           

            Else

           
                'Carrega Váriavel - Controle de Estoque
                bCFOPEstoque = LoadDescricao("sp_select_cadastro_basico_estoque_cfop_estoque " & cboCFOP.SelectedValue & ", " & goUsuario.iEmpresa)

             

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboTipoOperacao_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoOperacao.SelectedIndexChanged

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Controles
            cboNumeroDocumento.Text = ""
            lblNumeroDocumento.Text = "Nº Documento:"
            cboProduto.Text = ""
            txtQuantidadeDocumento.Value = 0
            txtQuantidade.Value = 0
            cboUnidadeMedida.Text = ""
            txtFatorConversao.Value = 0
            txtQuantidadeEstoque.Value = 0
            cboDeposito.Text = ""
            txtLote.Text = ""
            dtpDataFabricacao.Value = Now.Date
            dtpDataValidade.Value = Now.Date
            cboCentroGasto.Text = ""
            cboContaContabil.Text = ""

            'Desabilita / Oculta Controles
            cboNumeroDocumento.Enabled = False
            cboProduto.Enabled = False
            lblQuantidadeDocumento.Visible = False
            txtQuantidadeDocumento.Visible = False
            btnAtualizarPedidoCompra.Visible = False
            btnCadastrarProduto.Enabled = False
            btnProcurarProduto.Enabled = False
            txtQuantidadeDocumento.Enabled = False
            txtQuantidade.Enabled = False
            cboUnidadeMedida.Enabled = False
            btnCadastrarUnidadeMedida.Enabled = False
            txtFatorConversao.Enabled = False
            txtQuantidadeEstoque.Enabled = False
            cboDeposito.Enabled = False
            btnCadastrarDeposito.Enabled = False
            txtLote.Enabled = False
            dtpDataFabricacao.Enabled = False
            dtpDataValidade.Enabled = False
            cboCentroGasto.Enabled = False
            cboContaContabil.Enabled = False
            lblValorUnitarioPedido.Visible = False
            txtValorUnitarioPedido.Visible = False
            lblAliquotaICMSPedido.Visible = False
            txtAliquotaICMSPedido.Visible = False
            lblAliquotaIPIPedido.Visible = False
            txtAliquotaIPIPedido.Visible = False
            lblAliquotaPISCOFINSPedido.Visible = False
            txtAliquotaPISCOFINSPedido.Visible = False
            lblAliquotaICMSUltimaNF.Visible = False
            txtAliquotaICMSUltimaNF.Visible = False

            'Verifica o Tipo de Operação Selecionada
            Select Case cboTipoOperacao.SelectedValue

                Case CInt(TipoOperacaoNotaFiscalEntrada.EntradaNFe), CInt(TipoOperacaoNotaFiscalEntrada.RemessaTerceiros)
                    'Carrega Combo de Produto
                    Call LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_item_descricao " & goUsuario.iEmpresa & ", NULL, 1, " & CInt(TipoItem.produto), False) : cboProduto.Enabled = True
                    'Verifica Direito - Cadastrar Produto
                    btnCadastrarProduto.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcInsert)
                    btnProcurarProduto.Enabled = True

                Case CInt(TipoOperacaoNotaFiscalEntrada.EntradaNFeNumeroDocumento)
                    'Carrega Combo de Produto
                    Call LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_item_descricao " & goUsuario.iEmpresa & ", NULL, 1, " & CInt(TipoItem.produto), False) : cboProduto.Enabled = True
                    cboNumeroDocumento.DataSource = Nothing
                    cboNumeroDocumento.Text = ""
                    cboNumeroDocumento.Enabled = True
                    'Verifica Direito - Cadastrar Produto
                    btnCadastrarProduto.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcInsert)
                    btnProcurarProduto.Enabled = True

                Case CInt(TipoOperacaoNotaFiscalEntrada.Compra)
                    'Carrega Combo de Pedido de Compra
                    Call LoadCombo(cboNumeroDocumento, "sp_select_combo_faturamento_entrada_pedido_compra " & goUsuario.iEmpresa & ", " & iCodigoParceiroNegocio & ", " & lCodigoEntradaCapa & ", " & iCodigoEntradaItem & ", " & iCodigoEntradaItemLote, False)
                    'Habilita Controle
                    cboNumeroDocumento.Enabled = True
                    'Seta Label
                    lblNumeroDocumento.Text = "Pedido de Compra:"
                    txtQuantidadeDocumento.Visible = True
                    lblQuantidadeDocumento.Visible = True
                    btnAtualizarPedidoCompra.Visible = VerificaDireito(Formulario.FaturamentoEntradaNF, gcAdministrator)
                    lblQuantidadeDocumento.Text = "Qtde. Pedido:"

                    lblValorUnitarioPedido.Visible = True
                    txtValorUnitarioPedido.Visible = True
                    txtValorUnitarioPedido.Value = 0
                    lblAliquotaICMSPedido.Visible = True
                    txtAliquotaICMSPedido.Visible = True
                    txtAliquotaICMSPedido.Value = 0
                    lblAliquotaIPIPedido.Visible = True
                    txtAliquotaIPIPedido.Visible = True
                    txtAliquotaIPIPedido.Value = 0
                    lblAliquotaPISCOFINSPedido.Visible = True
                    txtAliquotaPISCOFINSPedido.Visible = True
                    txtAliquotaPISCOFINSPedido.Value = 0
                    lblAliquotaICMSUltimaNF.Visible = True
                    txtAliquotaICMSUltimaNF.Visible = True
                    txtAliquotaICMSUltimaNF.Value = 0
                    
                Case CInt(TipoOperacaoNotaFiscalEntrada.DevolucaoNFe)
                    'Carrega Combo de Nota Fiscal Emitida
                    Call LoadCombo(cboNumeroDocumento, "sp_select_combo_faturamento_entrada_nota_fiscal_devolucao " & goUsuario.iEmpresa & ", " & iCodigoParceiroNegocio & ", " & lCodigoEntradaCapa & ", " & iCodigoEntradaItem & ", " & iCodigoEntradaItemLote, False)
                    'Habilita Controle
                    cboNumeroDocumento.Enabled = True
                    'Seta Label
                    lblNumeroDocumento.Text = "Nota Fiscal:"
                    txtQuantidadeDocumento.Visible = True
                    lblQuantidadeDocumento.Visible = True
                    lblQuantidadeDocumento.Text = "Qtde. Nota Fiscal:"

                    lblValorUnitarioPedido.Visible = True
                    txtValorUnitarioPedido.Visible = True
                    txtValorUnitarioPedido.Value = 0
                    lblAliquotaICMSPedido.Visible = True
                    txtAliquotaICMSPedido.Visible = True
                    txtAliquotaICMSPedido.Value = 0
                    lblAliquotaIPIPedido.Visible = True
                    txtAliquotaIPIPedido.Visible = True
                    txtAliquotaIPIPedido.Value = 0
                    lblAliquotaPISCOFINSPedido.Visible = True
                    txtAliquotaPISCOFINSPedido.Visible = True
                    txtAliquotaPISCOFINSPedido.Value = 0
                    lblAliquotaICMSUltimaNF.Visible = True
                    txtAliquotaICMSUltimaNF.Visible = True
                    txtAliquotaICMSUltimaNF.Value = 0

                Case CInt(TipoOperacaoNotaFiscalEntrada.RetornoRemessaIndustrializacao)
                    'Carrega Combo de Nota Fiscal
                    Call LoadCombo(cboNumeroDocumento, "sp_select_combo_faturamento_entrada_nota_fiscal_retorno_remessa_industrializacao  " & goUsuario.iEmpresa & ", " & iCodigoParceiroNegocio & ", " & lCodigoEntradaCapa & ", " & iCodigoEntradaItem & ", " & iCodigoEntradaItemLote, False)
                    'Habilita Controle
                    lblNumeroDocumento.Text = "Ordem Produção:"
                    cboNumeroDocumento.Enabled = True
                    'Exibe Controles
                    txtQuantidadeDocumento.Visible = True
                    lblQuantidadeDocumento.Visible = True
                    lblQuantidadeDocumento.Text = "Qtde. Nota Fiscal:"

                Case CInt(TipoOperacaoNotaFiscalEntrada.OrdemProducao)
                    'Carrega Combo de Nota Fiscal
                    Call LoadCombo(cboNumeroDocumento, "sp_select_combo_faturamento_entrada_nota_fiscal_ordem_producao  " & goUsuario.iEmpresa & ", " & iCodigoParceiroNegocio & ", " & lCodigoEntradaCapa & ", " & iCodigoEntradaItem & ", " & iCodigoEntradaItemLote, False)
                    'Habilita Controle
                    lblNumeroDocumento.Text = "Ordem Produção:"
                    cboNumeroDocumento.Enabled = True
                    'Exibe Controles
                    txtQuantidadeDocumento.Visible = True
                    lblQuantidadeDocumento.Visible = True
                    lblQuantidadeDocumento.Text = "Quantidade:"
            End Select

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboNumeroDocumento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNumeroDocumento.SelectedIndexChanged

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Controles
            cboProduto.Text = ""
            txtQuantidadeDocumento.Value = 0
            txtQuantidade.Value = 0
            cboUnidadeMedida.Text = ""
            txtFatorConversao.Value = 0
            txtQuantidadeEstoque.Value = 0
            'cboDeposito.Text = ""
            'txtLote.Text = ""
            dtpDataFabricacao.Value = Now.Date
            dtpDataValidade.Value = Now.Date
            cboCentroGasto.Text = ""
            cboContaContabil.Text = ""

            'Desabilita / Oculta Controles
            btnCadastrarProduto.Enabled = False
            btnProcurarProduto.Enabled = False
            txtQuantidade.Enabled = False
            cboUnidadeMedida.Enabled = False
            btnCadastrarUnidadeMedida.Enabled = False
            txtFatorConversao.Enabled = False
            txtQuantidadeEstoque.Enabled = False
            'cboDeposito.Enabled = False
            btnCadastrarDeposito.Enabled = False
            ' txtLote.Enabled = False
            dtpDataFabricacao.Enabled = False
            dtpDataValidade.Enabled = False
            cboCentroGasto.Enabled = False
            cboContaContabil.Enabled = False

            'Verifica se foi Selecionado algum Registro
            If cboNumeroDocumento.SelectedIndex <> -1 Then

                'Verifica o Tipo de Operação
                Select Case cboTipoOperacao.SelectedValue

                    Case CInt(TipoOperacaoNotaFiscalEntrada.Compra)
                        'Seta Váriavel
                        lCodigoPedido = cboNumeroDocumento.SelectedValue
                        'Carrega Combo
                        Call LoadCombo(cboProduto, "sp_select_combo_faturamento_entrada_pedido_compra_produto " & goUsuario.iEmpresa & ", " & lCodigoPedido & ", " & lCodigoEntradaCapa & ", " & iCodigoEntradaItem & ", " & iCodigoEntradaItemLote, False)

                    Case CInt(TipoOperacaoNotaFiscalEntrada.DevolucaoNFe)
                        'Seta Váriavel
                        lCodigoEmissaoCapa = cboNumeroDocumento.SelectedValue
                        'Carrega Combo
                        Call LoadCombo(cboProduto, "sp_select_combo_faturamento_entrada_nota_fiscal_devolucao_produto " & goUsuario.iEmpresa & ", " & lCodigoEmissaoCapa & ", " & lCodigoEntradaCapa & ", " & iCodigoEntradaItem & ", " & iCodigoEntradaItemLote, False)

                    Case CInt(TipoOperacaoNotaFiscalEntrada.RetornoRemessaIndustrializacao)
                        'Carrega Combo
                        Call LoadCombo(cboProduto, "sp_select_combo_faturamento_entrada_nota_fiscal_retorno_remessa_industrializacao " & goUsuario.iEmpresa & ", " & lCodigoEmissaoCapa & ", " & lCodigoEntradaCapa & ", " & iCodigoEntradaItem & ", " & iCodigoEntradaItemLote, False)

                    Case CInt(TipoOperacaoNotaFiscalEntrada.OrdemProducao)
                        'Carrega Combo
                        Call LoadCombo(cboProduto, "sp_select_combo_faturamento_entrada_ordem_producao_produto " & goUsuario.iEmpresa & ", " & lCodigoPedido & ", " & lCodigoEntradaCapa & ", " & iCodigoEntradaItem & ", " & cboNumeroDocumento.SelectedValue, False)

                End Select

                'Habilita Controle
                cboProduto.Enabled = True

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboProduto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProduto.SelectedIndexChanged

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim dAliquotaICMS As Double = 0
            Dim dAliquotaIPI As Double = 0
            Dim dAliquotaPISCOFINS As Double = 0
            Dim dAliquotaICMSUltimaNF As Double = 0

            'Limpa Váriaveis
            bItemEstoque = False
            bControlaQualidade = False
            bControlaLote = False
            bDataFabricacao = False
            bDataValidade = False
            dQuantidadePedido = 0
            dQuantidadePendente = 0
            dValorUnitario = 0
            dFatorConversao = 0
            lCodigoItem = 0
            lCodigoPedido = 0
            iCodigoPedidoItem = 0
            iCodigoPedidoItemEntrega = 0
            lCodigoEmissaoCapa = 0
            iCodigoEmissaoItem = 0
            sUnidadeMedida = ""
            iCodigoCentroGasto = 0
            sContaContabil = ""

            'Limpa Controles
            txtQuantidadeDocumento.Value = 0
            txtQuantidade.Value = 0
            cboUnidadeMedida.Text = ""
            txtFatorConversao.Value = 0
            txtQuantidadeEstoque.Value = 0
            ' cboDeposito.Text = ""
            'txtLote.Text = ""
            dtpDataFabricacao.Value = Now.Date
            dtpDataValidade.Value = Now.Date
            cboCentroGasto.Text = ""
            cboContaContabil.Text = ""

            'Seta Propriedade dos Controles
            txtQuantidadeDocumento.Enabled = False
            txtQuantidade.Enabled = False
            cboUnidadeMedida.Enabled = True
            btnCadastrarUnidadeMedida.Enabled = False
            txtFatorConversao.Enabled = True
            txtQuantidadeEstoque.Enabled = False
            ' cboDeposito.Enabled = False
            btnCadastrarDeposito.Enabled = False
            'txtLote.Enabled = False
            dtpDataFabricacao.Enabled = False
            dtpDataValidade.Enabled = False
            cboCentroGasto.Enabled = True
            cboContaContabil.Enabled = True

            'Verifica se foi Selecionado Algum Registro
            If cboProduto.SelectedIndex > -1 Then

                'Váriaveis Locais
                Dim sOperacao As String = IIf(IsNumeric(btnInserir.Tag), "E", "I")

                Select Case cboTipoOperacao.SelectedValue

                    Case CInt(TipoOperacaoNotaFiscalEntrada.EntradaNFe), CInt(TipoOperacaoNotaFiscalEntrada.RemessaTerceiros), CInt(TipoOperacaoNotaFiscalEntrada.OrdemProducao)
                        lCodigoItem = cboProduto.SelectedValue

                    Case CInt(TipoOperacaoNotaFiscalEntrada.Compra)
                        Dim sAux() As String = cboProduto.SelectedValue.ToString.Split("|")
                        lCodigoPedido = cboNumeroDocumento.SelectedValue
                        iCodigoPedidoItem = sAux(0)
                        iCodigoPedidoItemEntrega = sAux(1)
                        lCodigoItem = sAux(2)





                    Case CInt(TipoOperacaoNotaFiscalEntrada.DevolucaoNFe)
                        Dim sAux() As String = cboProduto.SelectedValue.ToString.Split("|")
                        lCodigoEmissaoCapa = cboNumeroDocumento.SelectedValue
                        iCodigoEmissaoItem = sAux(0)
                        lCodigoItem = sAux(1)

                End Select

                'Carrega Dados do Produto
                Call oClsFatEntradaNFProdutoXML.LoadDadosProduto(cboTipoOperacao.SelectedValue, _
                                                                 cboNumeroDocumento.SelectedValue, _
                                                                 lCodigoItem, _
                                                                 lCodigoEntradaCapa, _
                                                                 iCodigoEntradaItem, _
                                                                 iCodigoEntradaItemLote, _
                                                                 sOperacao, _
                                                                 lCodigoPedido, _
                                                                 iCodigoPedidoItem, _
                                                                 iCodigoPedidoItemEntrega, _
                                                                 lCodigoEmissaoCapa, _
                                                                 iCodigoEmissaoItem, _
                                                                 iCodigoUnidadeMedida, _
                                                                 bItemEstoque, _
                                                                 bControlaQualidade,
                                                                 bControlaLote, _
                                                                 bDataFabricacao, _
                                                                 bDataValidade, _
                                                                 dQuantidadePedido, _
                                                                 dQuantidadePendente, _
                                                                 dValorUnitario, _
                                                                 dFatorConversao, _
                                                                 sUnidadeMedida, _
                                                                 dToleranciaQuantidadePercentual, _
                                                                 dToleranciaValor, _
                                                                 iCodigoCentroGasto, _
                                                                 sContaContabil, _
                                                                 dAliquotaICMS, _
                                                                 dAliquotaIPI, _
                                                                 dAliquotaPISCOFINS, _
                                                                 dAliquotaICMSUltimaNF)

                'Carrega Combo
                Call LoadCombo(cboCentroGasto, "sp_select_combo_cadastro_basico_centro_custo_item " & goUsuario.iEmpresa & ", " & lCodigoItem, True)
                Call LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil_item " & goUsuario.iEmpresa & ", " & lCodigoItem, True)

                Call LoadCombo(cboCFOP, "sp_select_combo_faturamento_entrada_cfop " & goUsuario.iEmpresa & ", " & lCodigoEntradaCapa)
                If sContaContabil <> "" Then
                    cboContaContabil.SelectedValue = sContaContabil

                    Dim iCFOP As Integer = -1

                    iCFOP = LoadCodigo("sp_select_cadastro_basico_cfop_conta_contabil_entrada " & goUsuario.iEmpresa & "," & lCodigoEntradaCapa & "," & iCodigoEntradaItem & ",'" & sContaContabil & "'")

                    If iCFOP <> -1 Then
                        cboCFOP.SelectedValue = iCFOP
                    End If

                End If


                cboCFOP.Enabled = True
                'Habilita Controle                                
                txtQuantidade.Enabled = True
                txtQuantidadeDocumento.Value = dQuantidadePendente
                txtQuantidadeDocumento.FormatString = "#,#0.0000 " & sUnidadeMedida
                txtValorUnitarioPedido.Value = dValorUnitario
                txtAliquotaICMSPedido.Value = dAliquotaICMS
                txtAliquotaIPIPedido.Value = dAliquotaIPI
                txtAliquotaPISCOFINSPedido.Value = dAliquotaPISCOFINS
                txtAliquotaICMSUltimaNF.Value = dAliquotaICMSUltimaNF

                'Controles de Pedido
                txtValorUnitarioPedido.Visible = IIf(lCodigoPedido = 0 And lCodigoEmissaoCapa = 0, False, True)
                lblValorUnitarioPedido.Visible = IIf(lCodigoPedido = 0 And lCodigoEmissaoCapa = 0, False, True)
                lblAliquotaICMSPedido.Visible = IIf(lCodigoPedido = 0 And lCodigoEmissaoCapa = 0, False, True)
                txtAliquotaICMSPedido.Visible = IIf(lCodigoPedido = 0 And lCodigoEmissaoCapa = 0, False, True)
                lblAliquotaIPIPedido.Visible = IIf(lCodigoPedido = 0 And lCodigoEmissaoCapa = 0, False, True)
                txtAliquotaIPIPedido.Visible = IIf(lCodigoPedido = 0 And lCodigoEmissaoCapa = 0, False, True)
                lblAliquotaPISCOFINSPedido.Visible = IIf(lCodigoPedido = 0 And lCodigoEmissaoCapa = 0, False, True)
                txtAliquotaPISCOFINSPedido.Visible = IIf(lCodigoPedido = 0 And lCodigoEmissaoCapa = 0, False, True)
                lblAliquotaICMSUltimaNF.Visible = IIf(lCodigoPedido = 0 And lCodigoEmissaoCapa = 0, False, True)
                txtAliquotaICMSUltimaNF.Visible = IIf(lCodigoPedido = 0 And lCodigoEmissaoCapa = 0, False, True)

                'Verifica se foi Selecionado algum Registro
                lblValorUnitarioPedido.ForeColor = IIf(grdXML.CurrentRow.Cells("valor_unitario").Value <> dValorUnitario, Color.Red, Color.Black)
                lblAliquotaICMSPedido.ForeColor = IIf(grdXML.CurrentRow.Cells("aliquota_icms").Value <> (dAliquotaICMS * 100.0), Color.Red, Color.Black)
                lblAliquotaIPIPedido.ForeColor = IIf(grdXML.CurrentRow.Cells("aliquota_ipi").Value <> (dAliquotaIPI * 100.0), Color.Red, Color.Black)
                lblAliquotaPISCOFINSPedido.ForeColor = IIf((grdXML.CurrentRow.Cells("aliquota_pis").Value + grdXML.CurrentRow.Cells("aliquota_cofins").Value) <> (dAliquotaPISCOFINS * 100.0), Color.Red, Color.Black)
                lblAliquotaICMSUltimaNF.ForeColor = IIf(grdXML.CurrentRow.Cells("aliquota_icms").Value <> (dAliquotaICMSUltimaNF * 100.0), Color.Red, Color.Black)



                'Baixar completo a quantidade na linha do pedido de compra
                txtQuantidade.Value = dQuantidadeXML
                txtFatorConversao.Value = 1
                txtQuantidadeEstoque.Value = dQuantidadeXML
                Dim iCodigoUnidadeMedidaXML As Integer = LoadCodigo("sp_select_cadastro_basico_codigo_unidade_medida '" & grdXML.CurrentRow.Cells("unidade_medida").Value & "'," & goUsuario.iEmpresa)
                cboUnidadeMedida.SelectedValue = iCodigoUnidadeMedidaXML


                Dim iCFOPNF As Integer = LoadCodigo("sp_select_faturamento_entrada_item_cfop_pedido_compra " & lCodigoPedido & "," & iCodigoPedidoItem & "," & grdXML.CurrentRow.Cells("cfop").Value & "," & goUsuario.iEmpresa)

                If iCFOPNF > -1 Then

                    cboCFOP.SelectedValue = iCFOPNF

                End If
                Application.DoEvents()
                cboDeposito.SelectedValue = 1

                'Verifica se Controla Estoque do Item
                If bItemEstoque = False Or bCFOPEstoque = False Then Exit Sub

                cboUnidadeMedida.Enabled = True : btnCadastrarUnidadeMedida.Enabled = VerificaDireito(Formulario.CadastroBasicoUnidadeMedida, gcInsert)
                txtFatorConversao.Enabled = True
                txtQuantidadeEstoque.Enabled = True
                txtQuantidade.Value = dQuantidadePedido
                cboDeposito.Enabled = True : btnCadastrarDeposito.Enabled = VerificaDireito(Formulario.CadastroBasicoDeposito, gcInsert)

                'Seta Controles
                If grdRecebimento.GetDataRows.Count > 0 Then txtQuantidade.Value = txtQuantidade.Value - grdRecebimento.GetTotalRow.Cells("quantidade").Value Else txtQuantidade.Value = txtQuantidade.Value
                'If iCodigoUnidadeMedida <> -1 Then cboUnidadeMedida.SelectedValue = iCodigoUnidadeMedida
                txtFatorConversao.Value = IIf(dFatorConversao > 0, dFatorConversao, 1)
                If grdRecebimento.GetDataRows.Count > 0 Then txtQuantidade.Value = dQuantidadeXML - grdRecebimento.GetTotalRow.Cells("quantidade").Value Else txtQuantidade.Value = dQuantidadeXML
                'If txtQuantidade.Value > dQuantidadePendente And dQuantidadePendente > 0 Then txtQuantidade.Value = dQuantidadePendente
                txtQuantidadeEstoque.Value = txtQuantidade.Value * txtFatorConversao.Value
                If iCodigoCentroGasto <> 0 Then cboCentroGasto.SelectedValue = iCodigoCentroGasto
                If sContaContabil <> "" Then cboContaContabil.SelectedValue = sContaContabil

                'Verifica se o Item Controla Qualidade
                If bControlaQualidade = True Then

                    'Desabilita Controles (Serão preenchidos posteriormente na usrQAEntradaNF)
                    txtLote.Enabled = False
                    dtpDataFabricacao.Enabled = False
                    dtpDataValidade.Enabled = False

                    'Carrega Combo - Depósito (Somente os liberados em Qualidade)
                    If cboDeposito.SelectedIndex = -1 Then
                        Call LoadCombo(cboDeposito, "sp_select_combo_cadastro_basico_deposito_cfop_qualidade " & goUsuario.iEmpresa & ", " & cboCFOP.SelectedValue & ", " & cboTipoOperacao.SelectedValue, True)
                    End If
                   
                Else

                    'Habilita Controles
                    txtLote.Enabled = bControlaLote
                    dtpDataFabricacao.Enabled = bDataFabricacao
                    dtpDataValidade.Enabled = bDataValidade

                    If sInformacoesAdicionais <> "" Then

                        'Dim sDados() As String = sInformacoesAdicionais.Split(" ")

                        'For i = 0 To UBound(sDados)
                        '    If sDados(i).ToUpper.Contains("LOTE") Then
                        '        txtLote.Text = sDados(i + 1)
                        '    ElseIf sDados(i).ToUpper.Contains("VALIDADE") Or sDados(i).ToUpper.Contains("VAL") AndAlso IsDate(sDados(i + 1).Trim) = True Then
                        '        dtpDataValidade.Value = CDate(sDados(i + 1).Trim)
                        '    ElseIf sDados(i).ToUpper.Contains("FABRICAÇÃO") Or sDados(i).ToUpper.Contains("FAB") Or sDados(i).ToUpper.Contains("FABRICACAO") AndAlso IsDate(sDados(i + 1).Trim) = True Then
                        '        dtpDataFabricacao.Value = CDate(sDados(i + 1).Trim)
                        '    End If
                        'Next

                    End If

                    'Carrega Combo - Depósito 
                    If cboDeposito.SelectedIndex = -1 Then
                        Call LoadCombo(cboDeposito, "sp_select_combo_cadastro_basico_deposito_cfop " & goUsuario.iEmpresa & ", " & cboCFOP.SelectedValue & ", " & cboTipoOperacao.SelectedValue, True)
                    End If
                   
                End If


             


            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdRecebimento_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdRecebimento.RowDoubleClick

        Try

            'Verifica se a Linha é Válida
            If IsNothing(grdRecebimento.CurrentColumn) Then Exit Sub

            'Verifica qual Coluna foi Pressionada
            Select Case grdRecebimento.CurrentColumn.Key

                Case "editar" : Call EditarRecebimento()
                Case "kit" : Call Kit()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdRecebimento_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdRecebimento.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdRecebimento.Name, _
                                     Formulario.FaturamentoEntradaNF, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdRecebimento_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdRecebimento.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdRecebimento, _
                                     Formulario.FaturamentoEntradaNF)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdRecebimento_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdRecebimento.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdRecebimento.Name, _
                                          Formulario.FaturamentoEntradaNF, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: GERAL :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmFatEmissaoNFeProdutoXML_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Configura Grid
            Call ConfiguraGrid(grdXML, Formulario.FaturamentoEntradaNF)
            Call ConfiguraGrid(grdRecebimento, Formulario.FaturamentoEntradaNF)

            'Verifica Direito dos Controles
            btnCadastrarProduto.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcInsert)
            btnCadastrarDeposito.Enabled = VerificaDireito(Formulario.CadastroBasicoDeposito, gcInsert)
            btnExcelGridXML.Enabled = VerificaDireito(Formulario.FaturamentoEntradaNF, gcPrint)

            'Carrega Grid
            Call LoadGridXML()

            'Carrega Combo
            Call LoadCombo(cboCFOP, "sp_select_combo_faturamento_entrada_cfop " & goUsuario.iEmpresa & ", " & lCodigoEntradaCapa)
            Call LoadCombo(cboUnidadeMedida, "sp_select_combo_cadastro_basico_unidade_medida " & goUsuario.iEmpresa, False)
            'Carrega Combo
            Call LoadCombo(cboTipoOperacao, "sp_select_combo_static_tipo_operacao_nota_fiscal_entrada -1, " & goUsuario.iEmpresa)


            'Desabilita Controles
            cboCFOP.Enabled = False
            cboTipoOperacao.Enabled = False
            cboNumeroDocumento.Enabled = False
            cboProduto.Enabled = False
            txtQuantidade.Enabled = False
            cboUnidadeMedida.Enabled = False
            txtFatorConversao.Enabled = False
            txtQuantidadeEstoque.Enabled = False
            cboDeposito.Enabled = False
            txtLote.Enabled = False
            dtpDataFabricacao.Enabled = False : dtpDataFabricacao.Value = Now.Date
            dtpDataValidade.Enabled = False : dtpDataValidade.Value = Now.Date

            'Seta Váriavel
            sResultado = "N"

            'Oculta Controles
            txtQuantidadeDocumento.Visible = False
            lblQuantidadeDocumento.Visible = False
            btnAtualizarPedidoCompra.Visible = False
            lblValorUnitarioPedido.Visible = False
            txtValorUnitarioPedido.Visible = False
            lblAliquotaICMSPedido.Visible = False
            txtAliquotaICMSPedido.Visible = False
            lblAliquotaIPIPedido.Visible = False
            txtAliquotaIPIPedido.Visible = False
            lblAliquotaPISCOFINSPedido.Visible = False
            txtAliquotaPISCOFINSPedido.Visible = False
            lblAliquotaICMSUltimaNF.Visible = False
            txtAliquotaICMSUltimaNF.Visible = False

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: NOTA FISCAL ENTRADA XML :::"

    Private Sub SalvarXML()

        Try

            'Salva Dados do Item
            oClsFatEntradaNFProdutoXML.SalvarXML(lCodigoEntradaCapa)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridXML()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor
            Dim Index As Integer


            'Verifica se alguma Linha está selecionada
            If IsNothing(oCurrentRow) Then
                'Carrega Grid
                Call oClsFatEntradaNFProdutoXML.LoadGridXML(grdXML, lCodigoEntradaCapa, Nothing)
            Else
                'Carrega Grid
                Call oClsFatEntradaNFProdutoXML.LoadGridXML(grdXML, lCodigoEntradaCapa, oCurrentRow)
                'Define o index como a linha selecionada
                Index = oCurrentRow.RowIndex
                'Seleciona Linha
                oCurrentRow.CheckState = RowCheckState.Checked
                'Deixa exatamente no lugar da linha onde o index foi selecionada
                grdXML.Row = Index
                'Seleciona Registro
                Call LoadGridRecebimento()
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se não é contrato
            If cboNumeroDocumento.Text.Contains("CT") = False Then

                'Verifica se foi Selecionado algum Registro
                For Each oRow As GridEXRow In grdXML.GetDataRows
                    If oRow.Cells("quantidade").Value > oRow.Cells("quantidade_entregue").Value Then
                        frmMain.Informacao(Mensagem.ValorInformadoNaoValido, "Qtde. Entregue")
                        Exit Function
                    End If
                Next

            End If
            

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: RECEBIMENTO :::"

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

            Else
                'Informa o Usuário que é necessário selecionar um Produto
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridRecebimento()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid - Recebimento
            Call oClsFatEntradaNFProdutoXML.LoadGridRecebimento(grdRecebimento, _
                                                                lCodigoEntradaCapa, _
                                                                iCodigoEntradaItem)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarRecebimento()

        Try

            'Váriaveis Locais
            Dim sKit As String = ""
            Dim sNumeroDocumento As String = ""

            If cboTipoOperacao.SelectedValue = TipoOperacaoNotaFiscalEntrada.EntradaNFeNumeroDocumento Then
                sNumeroDocumento = cboNumeroDocumento.Text.Trim
            Else
                sNumeroDocumento = IIf(cboNumeroDocumento.SelectedIndex = -1, "", cboNumeroDocumento.Text)
            End If

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserir.Tag) Then

                'Insere Registro na tb_fat_entrada_item_pedido_tmp
                Call oClsFatEntradaNFProdutoXML.UpdateRecebimento(lCodigoEntradaCapa, _
                                                                  oCurrentRow.Cells("codigo_entrada_item").Value, _
                                                                  grdRecebimento.CurrentRow.Cells("codigo").Value, _
                                                                  cboCFOP.SelectedValue, _
                                                                  cboTipoOperacao.SelectedValue, _
                                                                  sNumeroDocumento, _
                                                                  lCodigoItem, _
                                                                  bControlaQualidade, _
                                                                  txtQuantidade.Value, _
                                                                  IIf(cboUnidadeMedida.SelectedIndex = -1, -1, cboUnidadeMedida.SelectedValue), _
                                                                  IIf(txtQuantidadeEstoque.Enabled = True, txtQuantidadeEstoque.Value, 0), _
                                                                  IIf(cboDeposito.SelectedIndex = -1, -1, cboDeposito.SelectedValue), _
                                                                  txtLote.Text.Trim, _
                                                                  IIf(dtpDataValidade.Enabled = False, "", dtpDataValidade.Value), _
                                                                  IIf(dtpDataFabricacao.Enabled = False, "", dtpDataFabricacao.Value), _
                                                                  DateDiff(DateInterval.Month, dtpDataFabricacao.Value, dtpDataValidade.Value), _
                                                                  IIf(cboCentroGasto.SelectedIndex = -1, -1, cboCentroGasto.SelectedValue), _
                                                                  IIf(cboContaContabil.SelectedIndex = -1, "", cboContaContabil.SelectedValue), _
                                                                  IIf(cboTipoOperacao.SelectedValue = CInt(TipoOperacaoNotaFiscalEntrada.Compra), lCodigoPedido, -1), _
                                                                  IIf(cboTipoOperacao.SelectedValue = CInt(TipoOperacaoNotaFiscalEntrada.Compra), iCodigoPedidoItem, -1), _
                                                                  IIf(cboTipoOperacao.SelectedValue = CInt(TipoOperacaoNotaFiscalEntrada.Compra), iCodigoPedidoItemEntrega, -1), _
                                                                  IIf(cboTipoOperacao.SelectedValue = CInt(TipoOperacaoNotaFiscalEntrada.DevolucaoNFe) Or cboTipoOperacao.SelectedValue = CInt(TipoOperacaoNotaFiscalEntrada.RetornoRemessaIndustrializacao), lCodigoEmissaoCapa, -1), _
                                                                  IIf(cboTipoOperacao.SelectedValue = CInt(TipoOperacaoNotaFiscalEntrada.DevolucaoNFe) Or cboTipoOperacao.SelectedValue = CInt(TipoOperacaoNotaFiscalEntrada.RetornoRemessaIndustrializacao), iCodigoEmissaoItem, -1), _
                                                                  IIf(cboTipoOperacao.SelectedValue = CInt(TipoOperacaoNotaFiscalEntrada.RetornoRemessaIndustrializacao), cboNumeroDocumento.SelectedValue, -1), _
                                                                  sKit)

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroAlterado)

            Else

                'Insere Registro na tb_fat_entrada_item_pedido_tmp
                Call oClsFatEntradaNFProdutoXML.InsertRecebimento(lCodigoEntradaCapa, _
                                                                  iCodigoEntradaItem, _
                                                                  cboCFOP.SelectedValue, _
                                                                  cboTipoOperacao.SelectedValue, _
                                                                  sNumeroDocumento, _
                                                                  lCodigoItem, _
                                                                  bControlaQualidade, _
                                                                  txtQuantidade.Value, _
                                                                  IIf(cboUnidadeMedida.SelectedIndex = -1, -1, cboUnidadeMedida.SelectedValue), _
                                                                  txtQuantidadeEstoque.Value, _
                                                                  IIf(cboDeposito.SelectedIndex = -1, -1, cboDeposito.SelectedValue), _
                                                                  txtLote.Text.Trim, _
                                                                  IIf(dtpDataValidade.Enabled = False, "", dtpDataValidade.Value), _
                                                                  IIf(dtpDataFabricacao.Enabled = False, "", dtpDataFabricacao.Value), _
                                                                  DateDiff(DateInterval.Month, dtpDataFabricacao.Value, dtpDataValidade.Value), _
                                                                  IIf(cboCentroGasto.SelectedIndex = -1, -1, cboCentroGasto.SelectedValue), _
                                                                  IIf(cboContaContabil.SelectedIndex = -1, "", cboContaContabil.SelectedValue), _
                                                                  IIf(cboTipoOperacao.SelectedValue = CInt(TipoOperacaoNotaFiscalEntrada.Compra), lCodigoPedido, -1), _
                                                                  IIf(cboTipoOperacao.SelectedValue = CInt(TipoOperacaoNotaFiscalEntrada.Compra), iCodigoPedidoItem, -1), _
                                                                  IIf(cboTipoOperacao.SelectedValue = CInt(TipoOperacaoNotaFiscalEntrada.Compra), iCodigoPedidoItemEntrega, -1), _
                                                                  IIf(cboTipoOperacao.SelectedValue = CInt(TipoOperacaoNotaFiscalEntrada.DevolucaoNFe) Or cboTipoOperacao.SelectedValue = CInt(TipoOperacaoNotaFiscalEntrada.RetornoRemessaIndustrializacao), lCodigoEmissaoCapa, -1), _
                                                                  IIf(cboTipoOperacao.SelectedValue = CInt(TipoOperacaoNotaFiscalEntrada.DevolucaoNFe) Or cboTipoOperacao.SelectedValue = CInt(TipoOperacaoNotaFiscalEntrada.RetornoRemessaIndustrializacao), iCodigoEmissaoItem, -1), _
                                                                  IIf(cboTipoOperacao.SelectedValue = CInt(TipoOperacaoNotaFiscalEntrada.OrdemProducao), cboNumeroDocumento.SelectedValue, -1), _
                                                                  sKit, _
                                                                  txtQuantidadeDocumento.Value)

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroInserido)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarRecebimento()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            With grdRecebimento.CurrentRow.Cells

                'Limpa Formulário
                Call NovoRecebimento()

                'Carrega Controles
                btnInserir.Tag = grdRecebimento.CurrentRow.Cells("codigo").Value
                cboCFOP.SelectedValue = grdRecebimento.CurrentRow.Cells("codigo_cfop").Value
                cboTipoOperacao.SelectedValue = grdRecebimento.CurrentRow.Cells("codigo_tipo_operacao").Value
                cboNumeroDocumento.SelectedValue = grdRecebimento.CurrentRow.Cells("codigo_composto_numero_documento").Value
                If cboTipoOperacao.SelectedValue = TipoOperacaoNotaFiscalEntrada.EntradaNFeNumeroDocumento Then
                    cboNumeroDocumento.Text = grdRecebimento.CurrentRow.Cells("numero_documento").Value
                End If
                cboProduto.SelectedValue = grdRecebimento.CurrentRow.Cells("codigo_composto_produto").Value
                txtQuantidade.Value = grdRecebimento.CurrentRow.Cells("quantidade").Value
                If IsDBNull(grdRecebimento.CurrentRow.Cells("codigo_unidade_medida").Value) = False Then cboUnidadeMedida.SelectedValue = grdRecebimento.CurrentRow.Cells("codigo_unidade_medida").Value
                txtFatorConversao.Value = IIf(IsDBNull(grdRecebimento.CurrentRow.Cells("fator_conversao").Value), 0, grdRecebimento.CurrentRow.Cells("fator_conversao").Value)
                txtQuantidadeEstoque.Value = IIf(IsDBNull(grdRecebimento.CurrentRow.Cells("quantidade_estoque").Value), 0, grdRecebimento.CurrentRow.Cells("quantidade_estoque").Value)
                If IsDBNull(grdRecebimento.CurrentRow.Cells("codigo_deposito").Value) = False Then cboDeposito.SelectedValue = grdRecebimento.CurrentRow.Cells("codigo_deposito").Value
                txtLote.Text = IIf(IsDBNull(grdRecebimento.CurrentRow.Cells("lote").Value), "", grdRecebimento.CurrentRow.Cells("lote").Value)
                If IsDBNull(grdRecebimento.CurrentRow.Cells("data_fabricacao").Value) = False Then dtpDataValidade.Value = grdRecebimento.CurrentRow.Cells("data_fabricacao").Value
                If IsDBNull(grdRecebimento.CurrentRow.Cells("data_validade").Value) = False Then dtpDataValidade.Value = grdRecebimento.CurrentRow.Cells("data_validade").Value
                cboCentroGasto.SelectedValue = grdRecebimento.CurrentRow.Cells("codigo_centro_gasto").Value
                cboContaContabil.SelectedValue = grdRecebimento.CurrentRow.Cells("codigo_conta_contabil").Value

                'Seta Focu
                cboCFOP.Focus()

            End With

            'Seta Cursor do Mousr
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteRecebimento()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdRecebimento) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsFatEntradaNFProdutoXML.DeleteRecebimento()

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
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub NovoRecebimento()

        Try

            'Limpa Controles
            If Not oCurrentRow Is Nothing Then
                'Seta Controles
                'cboCFOP.SelectedValue = CType(LoadDescricao("sp_select_cadastro_basico_cfop_relacionado " & goUsuario.iEmpresa & ", " & oCurrentRow.Cells("cfop").Value), String)
                'Váriavel - Quantidade
                Dim dQuantidade As Double = 0
                If grdRecebimento.GetDataRows.Count > 0 Then
                    dQuantidade = grdRecebimento.GetTotalRow.Cells("quantidade").Value
                End If
                txtQuantidade.Value = oCurrentRow.Cells("quantidade").Value - dQuantidade
                txtFatorConversao.Value = 1
                txtQuantidadeEstoque.Value = txtQuantidade.Value * txtFatorConversao.Value
            Else
                cboCFOP.Text = ""
                txtQuantidade.Value = 0
                txtFatorConversao.Value = 0
                txtQuantidadeEstoque.Value = 0
            End If

            'Limpa Controle
            'cboNumeroDocumento.Text = ""
            'cboUnidadeMedida.Text = ""
            'txtLote.Text = ""
            'dtpDataFabricacao.Value = Now.Date
            'dtpDataValidade.Value = Now.Date
            'cboCentroGasto.Text = ""
            'cboContaContabil.Text = ""
            btnInserir.Tag = ""

            'Limpa Váriaveis
            bItemEstoque = False
            bControlaQualidade = False
            bControlaLote = False
            bDataFabricacao = False
            bDataValidade = False
            dQuantidadePendente = 0
            dValorUnitario = 0
            dFatorConversao = 0
            iCodigoEntradaItemLote = -1

            'Executa Rotina CFOP
            'Call cboCFOP_SelectedIndexChanged(cboCFOP, System.EventArgs.Empty)

            'Seta Focu
            cboCFOP.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub KIT()

        Try

            'Verifica a Forma de Venda do Produto
            If grdRecebimento.CurrentRow.Cells("codigo_forma_venda_item").Value = CInt(FormaVendaItem.Kit) Then

                'Váriaveis Locais
                Dim oForm As New frmFatEntradaNFProdutoKIT

                'Seta Parâmetros
                oForm.CodigoItem = grdRecebimento.CurrentRow.Cells("codigo_item").Value
                oForm.CodigoProduto = grdRecebimento.CurrentRow.Cells("codigo_produto").Value
                oForm.Descricao = grdRecebimento.CurrentRow.Cells("descricao").Value
                oForm.QuantidadeProduto = grdRecebimento.CurrentRow.Cells("quantidade_estoque").Value
                oForm.CodigoEntradaCapa = grdRecebimento.CurrentRow.Cells("codigo_entrada_capa").Value
                oForm.CodigoEntradaItem = grdRecebimento.CurrentRow.Cells("codigo_entrada_item").Value
                oForm.Codigo = grdRecebimento.CurrentRow.Cells("codigo").Value

                'Abre o Formulário
                oForm.ShowDialog(Me)

                'Carrega Grid
                Call LoadGridRecebimento()

            Else

                'Informa o Usuário que a Operação não pode ser realizada
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "O Produto Selecionado não é um KIT.")

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoRecebimento() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoRecebimento = False

            'Verifica se foi Selecionado a Linha
            If oCurrentRow Is Nothing Then
                frmMain.Informacao(Mensagem.Erro, "Primeiramente Selecione um Produto para Entrada de Nota Fiscal.")
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - CFOP
            If ValidaCampo(cboCFOP, lblCFOP) = False Then
                Exit Function
                'Else
                '    Dim oRow() As GridEXRow = grdRecebimento.GetDataRows
                '    If grdRecebimento.GetDataRows.Count > 0 Then
                '        If IsNumeric(btnInserir.Tag) = True Then
                '            If grdRecebimento.GetDataRows.Count > 1 Then
                '                If oRow(IIf(oRow(0).RowIndex <> grdRecebimento.CurrentRow.RowIndex, 0, 1)).Cells("codigo_cfop").Value <> cboCFOP.SelectedValue Then
                '                    frmMain.errInfo.SetError(lblCFOP, "Este CFOP não é válido, uma vez que já foi informado outro CFOP.")
                '                    cboCFOP.Focus()
                '                    Exit Function
                '                End If
                '            End If
                '        ElseIf oRow(0).Cells("codigo_cfop").Value <> cboCFOP.SelectedValue Then
                '            frmMain.errInfo.SetError(lblCFOP, "Este CFOP não é válido, uma vez que já foi informado outro CFOP.")
                '            cboCFOP.Focus()
                '            Exit Function
                '        End If
                '    End If
            End If

            'Verifica se foi Selecionado o Campo - Tipo de Operação
            If ValidaCampo(cboTipoOperacao, lblTipoOperacao) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Nº Documento
            If cboNumeroDocumento.Enabled = True And cboTipoOperacao.SelectedValue <> TipoOperacaoNotaFiscalEntrada.EntradaNFeNumeroDocumento Then
                If ValidaCampo(cboNumeroDocumento, lblNumeroDocumento) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - Item
            If ValidaCampo(cboProduto, lblProduto) = False Then
                Exit Function
            End If

            'Verifica se o Fornecedor é Homologado para o Produto
            If oClsFatEntradaNFProdutoXML.ValidaFornecedorHomologado(lCodigoItem, _
                                                                     lCodigoEntradaCapa) = False Then
                frmMain.errInfo.SetError(lblProduto, "Este Produto necessita que o Fornecedor seja Homologado, e o Fornecedor Informado não é.")
                cboProduto.Focus()
                Exit Function
            End If

            If cboTipoOperacao.SelectedValue = CInt(TipoOperacaoNotaFiscalEntrada.Compra) Then

                Dim sAux() As String
                sAux = cboProduto.SelectedValue.ToString.Split("|")


                If cboNumeroDocumento.Text.Contains("CT") = False Then

                    If oClsFatEntradaNFProdutoXML.ValidaUnidadeMedida(cboNumeroDocumento.SelectedValue, _
                                                                  IIf(IsNothing(sAux(2)), -1, sAux(2)), _
                                                                  cboUnidadeMedida.SelectedValue) = False Then
                        If MsgBox("A unidade de medida deste item difere da unidade cadastrada no Pedido de Compra. Deseja Continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.No Then
                            Exit Function
                        End If

                    End If

                    If oClsFatEntradaNFProdutoXML.ValidaEntregaFisica(cboNumeroDocumento.SelectedValue, _
                                                                      sAux(0), _
                                                                      sAux(1)) = False Then

                        MsgBox("Não existe data de entrada física desde item!", MsgBoxStyle.Exclamation, "Validação")
                        Exit Function
                    End If

                End If

            End If


            'Verifica se o Produto Selecionado é Válido
            'If IsNumeric(btnInserir.Tag) = False Then
            '    If grdRecebimento.GetDataRows.Count > 0 Then
            '        If lCodigoItem <> grdRecebimento.GetDataRows(0).Cells("codigo_item").Value Then
            '            frmMain.errInfo.SetError(lblProduto, "O Produto Selecionado não é válido, porque se difere do Produto já inserido.")
            '            cboProduto.Focus()
            '            Exit Function
            '        End If
            '    End If
            'End If

            'Verifica se foi Preenchido o Campo - Quantidade
            If ValidaCampo(txtQuantidade, lblQuantidade, IIf(grdXML.CurrentRow.Cells("quantidade").Value = 0, False, True)) = False Then
                Exit Function
            End If

            'Váriavel Local
            Dim dQuantidade As Double = 0

            'Seta Váriavel
            If grdRecebimento.GetDataRows.Count > 0 Then
                dQuantidade = grdRecebimento.GetTotalRow.Cells("quantidade").Value
                If IsNumeric(btnInserir.Tag) Then
                    dQuantidade -= grdRecebimento.CurrentRow.Cells("quantidade").Value
                End If
            End If

            'Verifica se a Quantidade é Válida
            If dQuantidade + txtQuantidade.Value > oCurrentRow.Cells("quantidade").Value Then
                frmMain.errInfo.SetError(lblQuantidade, "A Quantidade informada NÃO pode ser maior que a Quantidade da Nota Fiscal.")
                txtQuantidade.Focus()
                Exit Function
            End If

            'Verifica se a Quantidade é Válida
            If cboTipoOperacao.SelectedValue = CInt(TipoOperacaoNotaFiscalEntrada.DevolucaoNFe) Then
                If txtQuantidade.Value > dQuantidadePendente Then
                    frmMain.errInfo.SetError(lblQuantidade, "A Quantidade informada é inválida, por ser maior que a quantidade da Nota Fiscal Emitida para esta empresa.")
                    txtQuantidade.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - Unidade de Medida
            If cboUnidadeMedida.Enabled = True Then
                If ValidaCampo(cboUnidadeMedida, lblUnidadeMedida, True) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Fator de Conversão
            If txtFatorConversao.Enabled = True Then
                If ValidaCampo(txtFatorConversao, lblFatorConversao, True) = False Then
                    Exit Function
                End If
            End If

            'Verifica se o Valor Unitário é igual o do Pedido
            If cboTipoOperacao.SelectedValue = CInt(TipoOperacaoNotaFiscalEntrada.Compra) Then

                'Verifica se a Quantidade é condizente com o Pedido
                'If txtQuantidade.Value > (dQuantidadePendente + (dQuantidadePedido * dToleranciaQuantidadePercentual / 100)) Then
                '    MsgBox("A Quantidade informada é de: " & FormatNumber(txtQuantidade.Value, 4, Microsoft.VisualBasic.TriState.True) & vbCrLf & _
                '           "A Quantidade Pendente de Recebimento é de: " & FormatNumber(dQuantidadePendente, 4, Microsoft.VisualBasic.TriState.True) & vbCrLf & _
                '           "A Tolerância para o Item é de: " & FormatNumber(dToleranciaQuantidadePercentual, 2, Microsoft.VisualBasic.TriState.True) & ". Totalizando: " & FormatNumber((dQuantidadePendente + (dQuantidadePedido * dToleranciaQuantidadePercentual / 100)), 4, Microsoft.VisualBasic.TriState.True) & vbCrLf & vbCrLf & _
                '           "Caso Deseje Receber a Mercadoria, efetue com o Tipo de Operação: COMPRA - PEDIDO EXCEDENTE.", MsgBoxStyle.Exclamation, Me.Text)
                '    cboTipoOperacao.Focus()
                '    Exit Function
                'End If

                'Verifica se o Valor Unitário bate com o Valor do Pedido
                If (Round((grdXML.CurrentRow.Cells("valor_unitario").Value / IIf(txtFatorConversao.Value = 0, 1, txtFatorConversao.Value)), 4) <> Round(dValorUnitario, 4)) Then
                    If MsgBox("O Valor do Produto na Nota Fiscal é de R$ " & FormatNumber((grdXML.CurrentRow.Cells("valor_unitario").Value) / IIf(txtFatorConversao.Value = 0, 1, txtFatorConversao.Value), 4, Microsoft.VisualBasic.TriState.True) & vbCrLf & _
                              "O Valor do Produto no Pedido de Compra é de R$ " & FormatNumber((dValorUnitario / IIf(txtFatorConversao.Value = 0, 1, txtFatorConversao.Value)), 4, Microsoft.VisualBasic.TriState.True) & vbCrLf & _
                              "Deseja continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.No Then
                        Exit Function
                    End If
                End If

            End If

            'Verifica se foi Selecionado o Campo - Depósito
            If cboDeposito.Enabled = True Then
                If ValidaCampo(cboDeposito, lblDeposito) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Lote
            If txtLote.Enabled = True Then
                If ValidaCampo(txtLote, lblLote, TipoCampo.texto) = False Then
                    Exit Function
                End If
            End If

            'Verifica se a Data de Fabricação é correta
            If dtpDataFabricacao.Enabled = True Then
                If dtpDataFabricacao.Value > Now.Date Then
                    frmMain.errInfo.SetError(lblDataFabricacao, "A Data de Fabricação NÃO pode ser maior que a Data Corrente.")
                    dtpDataFabricacao.Focus()
                End If
            End If

            'Verifica se a Data de Validade é correta
            If dtpDataValidade.Enabled = True Then
                If dtpDataValidade.Value < Now.Date Then
                    frmMain.errInfo.SetError(lblDataValidade, "A Data de Validade NÃO pode ser menor que a Data Corrente.")
                    dtpDataValidade.Focus()
                End If
            End If

            'Verifica se o CFOP Movimenta Estoque
            If oClsFatEntradaNFProdutoXML.ValidaCFOPEstoque(cboCFOP.SelectedValue) = True Then

                'Verifica se existe OP para o item
                If oClsFatEntradaNFProdutoXML.ValidaProdutoOrdemProducao(lCodigoItem) = True Then

                    'Informa o usuário e pergunta se ele deseja continuar
                    If MsgBox("Existe uma Ordem de Produção para este Item. Deseja continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.No Then
                        Exit Function
                    End If

                End If

            End If

            'Seta Retorno da Função
            ValidacaoRecebimento = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

   
End Class

