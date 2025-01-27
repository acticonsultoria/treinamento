Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls
Imports Janus.Windows.Common
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO

Public Class usrFatEmissaoNFeProdutoClassificacao

#Region " :::: VARIAVEIS ::::"
    'Variáveis da Classe
    Private oClsUsrFatEmissaoNFeProdutoClassificacao As New clsUsrFatEmissaoNFeProdutoClassificacao

    Private iCodigoTipoDocumentoFiscal As TipoDocumentoFiscal
    Private lCodigoEmissaoCapa As Long
    Private iCodigoEmissaoItem As Integer
    Private sProduto As String
    Private sUnidadeMedidaNF As String
    Private sUnidadeMedidaEstoque As String
    Private dQuantidade As Double
    Private lCodigoItem As Long
    Private iCodigoCFOP As Integer
    Private bControlaLote As Boolean
    Private bQualidade As Boolean
    Private bAllowSave As Boolean
    Private iCodigoProduto As Integer
    Private sItem As String
#End Region

#Region ":::: PROPERTIE ::::"

    Public Property CodigoTipoDocumentoFiscal() As TipoDocumentoFiscal
        Get
            Return iCodigoTipoDocumentoFiscal
        End Get
        Set(ByVal value As TipoDocumentoFiscal)
            iCodigoTipoDocumentoFiscal = value
        End Set
    End Property

    Public Property CodigoEmissaoCapa() As Long
        Get
            Return lCodigoEmissaoCapa
        End Get
        Set(ByVal value As Long)
            lCodigoEmissaoCapa = value
        End Set
    End Property

    Public Property CodigoEmissaoItem() As Integer
        Get
            Return iCodigoEmissaoItem
        End Get
        Set(ByVal value As Integer)
            iCodigoEmissaoItem = value
        End Set
    End Property

    Public Property CodigoCFOP() As Integer
        Get
            Return iCodigoCFOP
        End Get
        Set(ByVal value As Integer)
            iCodigoCFOP = value
        End Set
    End Property

    Public Property Produto() As String
        Get
            Return sProduto
        End Get
        Set(ByVal value As String)
            sProduto = value
        End Set
    End Property

    Public Property UnidadeMedidaNF() As String
        Get
            Return sUnidadeMedidaNF
        End Get
        Set(ByVal value As String)
            sUnidadeMedidaNF = value
        End Set
    End Property

    Public Property UnidadeMedidaEstoque() As String
        Get
            Return sUnidadeMedidaEstoque
        End Get
        Set(ByVal value As String)
            sUnidadeMedidaEstoque = value
        End Set
    End Property

    Public Property CodigoProduto() As Integer
        Get
            Return iCodigoProduto
        End Get
        Set(ByVal value As Integer)
            iCodigoProduto = value
        End Set
    End Property

    Public Property Item() As String
        Get
            Return sItem
        End Get
        Set(ByVal value As String)
            sItem = value
        End Set
    End Property

    Public Property Quantidade() As Double
        Get
            Return dQuantidade
        End Get
        Set(ByVal value As Double)
            dQuantidade = value
        End Set
    End Property

    Public Property CodigoItem() As Long
        Get
            Return lCodigoItem
        End Get
        Set(ByVal value As Long)
            lCodigoItem = value
        End Set
    End Property

    Public Property ControlaLote() As Boolean
        Get
            Return bControlaLote
        End Get
        Set(ByVal value As Boolean)
            bControlaLote = value
        End Set
    End Property

    Public Property Qualidade() As Boolean
        Get
            Return bQualidade
        End Get
        Set(ByVal value As Boolean)
            bQualidade = value
        End Set
    End Property

    Public Property AllowSave() As Boolean
        Get
            Return bAllowSave
        End Get
        Set(ByVal value As Boolean)
            bAllowSave = value
        End Set
    End Property
#End Region

#Region "::: GERAL :::"

    Private Sub usrFatEmissaoNFeProdutoClassificacao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)


        Try

            Select Case e.KeyCode

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboDeposito" : Call LoadCombo(cboDeposito, "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrFatEmissaoNFeProdutoClassificacao_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarFormulario()

    End Sub

#End Region

#Region ":::: CONTROLES ::::"

    Private Sub btnConfigurarGridListagem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridListagem.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoNFeProdutoClassificacao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FaturamentoEmissaoNFeProdutoClassificacao)

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
            oForm.Grid = grdEstoque
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoNFeProdutoClassificacao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdEstoque, Formulario.FaturamentoEmissaoNFeProdutoClassificacao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Deleta Registros
            Call Excluir(grdListagem.CurrentRow.Cells("codigo").Value, _
                            grdListagem.CurrentRow.Cells("codigo_emissao_item").Value)
            'Limpa Formulário
            Call Novo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try
    End Sub

    'Private Sub CalculaQuantidadeEstoque(ByVal sender As Object, ByVal e As EventArgs) Handles txtQuantidadeEstoque.LostFocus, _
    '                                                                              txtFatorConversao.LostFocus, _
    '                                                                              txtQuantidadeNotaFiscal.LostFocus

    '    Try

    '        Seta Cursor do Mouse
    '        Cursor.Current = Cursors.WaitCursor

    '        Select Case sender.Name
    '            Case "txtQuantidadeEstoque" : txtFatorConversao.Value = txtQuantidadeEstoque.Value / txtQuantidadeNotaFiscal.Value
    '            Case "txtFatorConversao" : txtQuantidadeEstoque.Value = txtQuantidadeNotaFiscal.Value * txtFatorConversao.Value
    '            Case "txtQuantidadeNotaFiscal" : txtQuantidadeEstoque.Value = txtQuantidadeNotaFiscal.Value * txtFatorConversao.Value
    '        End Select

    '        Seta Cursor do Mouse
    '        Cursor.Current = Cursors.Default

    '    Catch ex As Exception
    '        Trata(Erro)
    '        Call TratamentoErro(ex.Message, Me.Text)
    '    End Try

    'End Sub

    Private Sub grdEstoque_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdEstoque.RowDoubleClick
        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdEstoque.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdEstoque.CurrentColumn.Key

                Case "editar" : Call EditarLote()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdEstoque_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdEstoque.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdEstoque.Name, _
                                     Formulario.FaturamentoEmissaoNFe, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdEstoque_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdEstoque.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdEstoque, _
                                     Formulario.FaturamentoEmissaoNFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
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

    Private Sub btnVoltarEstoque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltarEstoque.Click
        Try

            'Limpa(Registro)
            Call Novo()

            'Carrega(Grid)
            Call LoadGrid()

            'Alterna Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagLista)

            'Seta Focu
            cboProduto.Focus()

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

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        Try

            'Carrega Dados da Grid
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnInserir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserir.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados
                Call Salvar(grdListagem.CurrentRow.Cells("codigo").Value, _
                            grdListagem.CurrentRow.Cells("codigo_emissao_item").Value)
                'Limpa Formulário
                Call Novo()
                'Carrega Grid
                Call LoadGridLote(grdListagem.CurrentRow.Cells("codigo").Value, _
                            grdListagem.CurrentRow.Cells("codigo_emissao_item").Value)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick
        Try

            'Verifica se foi pressionado algum Registro
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call Editar(grdListagem.CurrentRow.Cells("codigo").Value, _
                                            grdListagem.CurrentRow.Cells("codigo_emissao_item").Value)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Salva Dados
            Call SalvarMovimentacao(grdListagem.CurrentRow.Cells("codigo").Value)




        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try
    End Sub

#End Region

#Region ":::: FUNCTION / SUB ::::"

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsUsrFatEmissaoNFeProdutoClassificacao.LoadGrid(grdListagem, _
                                                              IIf(cboProduto.SelectedIndex = -1, -1, cboProduto.SelectedValue), _
                                                              txtDestinatarioFiltro.Text.Trim, _
                                                              IIf(IsNumeric(txtNotaFiscalFiltro.Text.Trim), txtNotaFiscalFiltro.Text.Trim, -1), _
                                                              IIf(dtpDataEmissaoTerminoFiltro.Checked = False, "", dtpDataEmissaoTerminoFiltro.Value), _
                                                              IIf(dtpDataEmissaoInicioFiltro.Checked = False, "", dtpDataEmissaoInicioFiltro.Value), _
                                                              IIf(cboUnidadeMedida.SelectedIndex = -1, -1, cboUnidadeMedida.SelectedValue))


            'Seta Cursor
            If grdListagem.GetDataRows.Count > 0 Then grdListagem.Row = 0

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Editar(ByVal lCodigoEmissaoCapa As Long, _
                      ByVal iCodigoEmissaoItem As Integer)

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.FaturamentoEmissaoNFeProdutoClassificacao, gcUpdate) = True Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Seta Código

                oClsUsrFatEmissaoNFeProdutoClassificacao.CodigoEmissaoCapa = lCodigoEmissaoCapa
                oClsUsrFatEmissaoNFeProdutoClassificacao.CodigoEmissaoItem = iCodigoEmissaoItem

                With grdListagem.CurrentRow.Cells

                    'Carrega Controles
                    txtProduto.Text = .Item("codigo_produto").Value
                    txtQuantidadeNotaFiscalTotal.Text = .Item("quantidade").Value
                    txtUnidadeMedida.Text = .Item("unidade_medida").Value

                End With


                'Carrega Grid NF Referenciada
                Call oClsUsrFatEmissaoNFeProdutoClassificacao.LoadGridLote(grdEstoque, _
                                                                           lCodigoEmissaoCapa, _
                                                                           iCodigoEmissaoItem)




                'Alterna Aba
                If tabMain.TabPages.Contains(pagLista) Then tabMain.TabPages.Remove(pagLista)
                If tabMain.TabPages.Contains(pagDados) = False Then tabMain.TabPages.Add(pagDados)

                'Seta Focu
                cboDeposito.Focus()

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica
            If ValidaCampo(cboDeposito, lblDeposito, TipoCampo.texto) = False Then
                cboDeposito.Focus()
                Exit Function
            End If

            'Verifica 
            If (txtLote.Enabled) = True Then
                If (ValidaCampo(txtLote, lblLote, TipoCampo.texto) = False) Then
                    txtLote.Focus()
                    Exit Function
                End If
            End If

            'Verifica 
            If ValidaCampo(txtFatorConversao, lblFatorConversao, TipoCampo.numero) = False Then
                txtFatorConversao.Focus()
                Exit Function
            End If

            'Verifica 
            If ValidaCampo(txtQuantidadeEstoque, lblQuantidadeEstoque, TipoCampo.numero) = False Then
                txtQuantidadeEstoque.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub Salvar(ByVal lCodigoEmissaoCapa As Long, _
                      ByVal iCodigoEmissaoItem As Integer)

        Try

            'Váriavel - Lote
            Dim sLote As String = ""

            If txtLote.Enabled = True Then
                sLote = txtLote.Text.Trim
            End If

            'Seta Código
            oClsUsrFatEmissaoNFeProdutoClassificacao.CodigoEmissaoCapa = lCodigoEmissaoCapa
            oClsUsrFatEmissaoNFeProdutoClassificacao.CodigoEmissaoItem = iCodigoEmissaoItem

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserir.Tag) Then

                'Váriaveis 
                Dim iCodigoAntigo As Integer

                'Obtém Código
                If IsNumeric(btnInserir.Tag) Then
                    iCodigoAntigo = grdEstoque.CurrentRow.Cells("codigo").Value
                End If

                'Atualiza Registro
                Call oClsUsrFatEmissaoNFeProdutoClassificacao.Update(lCodigoEmissaoCapa, _
                                                            iCodigoEmissaoItem, _
                                                            cboDeposito.SelectedValue, _
                                                            txtQuantidadeEstoque.Value, _
                                                            sLote, _
                                                            iCodigoAntigo, _
                                                            cboUnidadeMedida.SelectedValue, _
                                                            IIf(cboCodigoProduto.SelectedIndex = -1, -1, cboCodigoProduto.SelectedValue), _
                                                            cboCodigoProduto.Text)

            Else

                'Insere Registro
                Call oClsUsrFatEmissaoNFeProdutoClassificacao.Insert(lCodigoEmissaoCapa, _
                                                            iCodigoEmissaoItem, _
                                                            cboDeposito.SelectedValue, _
                                                            txtQuantidadeEstoque.Value, _
                                                            sLote, _
                                                            cboUnidadeMedida.SelectedValue, _
                                                            IIf(cboCodigoProduto.SelectedIndex = -1, -1, cboCodigoProduto.SelectedValue), _
                                                            cboCodigoProduto.Text)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Limpa Controles
            txtLote.Text = ""
            txtQuantidadeEstoque.Text = ""
            cboDeposito.SelectedIndex = -1
            txtFatorConversao.Text = ""
            btnInserir.Tag = ""
            cboCodigoProduto.SelectedIndex = -1

            'Seta Focu
            cboDeposito.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridLote(ByVal lCodigoEmissaoCapa As Long, _
                      ByVal iCodigoEmissaoItem As Integer)

        Try

            'Seta Código
            oClsUsrFatEmissaoNFeProdutoClassificacao.CodigoEmissaoCapa = lCodigoEmissaoCapa
            oClsUsrFatEmissaoNFeProdutoClassificacao.CodigoEmissaoItem = iCodigoEmissaoItem

            'Carrega Grid
            Call oClsUsrFatEmissaoNFeProdutoClassificacao.LoadGridLote(grdEstoque, _
                                                          lCodigoEmissaoCapa, _
                                                          iCodigoEmissaoItem)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Combo - Depósito
            Call LoadCombo(cboDeposito, "sp_select_combo_cadastro_basico_deposito_faturamento_emissao " & goUsuario.iEmpresa & ", " & lCodigoEmissaoCapa & ", " & iCodigoEmissaoItem, False)
            Call LoadCombo(cboUnidadeMedida, "sp_select_combo_cadastro_basico_unidade_medida " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboCodigoProduto, "sp_select_combo_cadastro_basico_produto " & goUsuario.iEmpresa)
            'Seta Controle
            txtProduto.Text = sProduto
            txtQuantidadeNotaFiscalTotal.Value = dQuantidade
            txtQuantidadeNotaFiscalTotal.FormatString = "#,#0.0000 "
            txtSaldoEstoque.FormatString = "#,#0.0000 "

            btnInserir.Enabled = True
            btnExcluir.Enabled = True
            btnVoltarEstoque.Enabled = True

            'Carrega Grid
            Call LoadGrid()

            'Configurar Grid
            Call ConfiguraGrid(grdEstoque, Formulario.FaturamentoEmissaoNFe)

            'Seta Focu
            cboDeposito.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub EditarLote()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcUpdate) = True Then

                'Limpa Erro
                frmMain.errInfo.Clear()

                With grdEstoque.CurrentRow.Cells

                    'Carrega Controles
                    cboDeposito.SelectedValue = .Item("deposito").Value
                    cboUnidadeMedida.SelectedValue = .Item("codigo_unidade_medida").Value
                    cboCodigoProduto.SelectedValue = .Item("codigo_produto").Value
                    txtQuantidadeEstoque.Value = .Item("quantidade_estoque").Value
                    ' If IsDBNull(.Item("quantidade_estoque").Value) = False Then If IsDBNull(.Item("quantidade_nota_fiscal").Value) = False Then txtFatorConversao.Text = .Item("quantidade_estoque").Value / .Item("quantidade_nota_fiscal").Value
                    txtFatorConversao.Value = "1"
                    If IsDBNull(.Item("lote").Value) = False Then txtLote.Text = .Item("lote").Value
                    btnInserir.Tag = grdEstoque.CurrentRow.RowIndex

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

    Private Sub Excluir(ByVal lCodigoEmissaoCapa As Long, _
                      ByVal iCodigoEmissaoItem As Integer)

        Try
            'Seta Código
            oClsUsrFatEmissaoNFeProdutoClassificacao.CodigoEmissaoCapa = lCodigoEmissaoCapa
            oClsUsrFatEmissaoNFeProdutoClassificacao.CodigoEmissaoItem = iCodigoEmissaoItem

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdEstoque) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsUsrFatEmissaoNFeProdutoClassificacao.Delete(lCodigoEmissaoCapa, _
                                                           iCodigoEmissaoItem)

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

    Private Sub SalvarMovimentacao(ByVal lCodigoEmissaoCapa As Long)

        Try

            'Seta Código
            oClsUsrFatEmissaoNFeProdutoClassificacao.CodigoEmissaoCapa = lCodigoEmissaoCapa


            oClsUsrFatEmissaoNFeProdutoClassificacao.SalvarLote(lCodigoEmissaoCapa)

            frmMain.Informacao(Mensagem.RegistroSalvo)


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

    
    Private Sub btnProcurarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarItem.Click
        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = TipoItem.produto
            oComboBoxFind = cboCodigoProduto

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCodigoProduto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub brnGerarNovoLote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brnGerarNovoLote.Click
        Try
            GerarNovoLote(oClsUsrFatEmissaoNFeProdutoClassificacao.CodigoEmissaoCapa, oClsUsrFatEmissaoNFeProdutoClassificacao.CodigoEmissaoItem)
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
    Private Sub GerarNovoLote(ByVal lCodigoEmissaoCapa As Long, _
                              ByVal iCodigoEmissaoItem As Integer)

        Try

            txtLote.Text = LoadCodigo("sp_select_fatuaramento_emissao_classificacao_novo_lote " & lCodigoEmissaoCapa & ", " & goUsuario.iEmpresa & ", " & iCodigoEmissaoItem)


        Catch ex As Exception
            Throw ex
        End Try

    End Sub
End Class
