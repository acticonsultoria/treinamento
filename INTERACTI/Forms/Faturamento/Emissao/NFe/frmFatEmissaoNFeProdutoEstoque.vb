Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX.EditControls
Imports Dundas.Charting.WinControl
Imports Janus.Windows.CalendarCombo

Public Class frmFatEmissaoNFeProdutoEstoque

#Region "::: VARIAVEIS :::"

    Private oClsFatEmissaoNFeProdutoEstoque As New clsFrmFatEmissaoNFeProdutoEstoque

    Private iCodigoTipoDocumentoFiscal As TipoDocumentoFiscal
    Private lCodigoEmitente As Long
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
    Private bImportacao As Boolean

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property CodigoEmitente() As Long
        Set(ByVal value As Long)
            lCodigoEmitente = value
        End Set
    End Property

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

    Public Property Importacao() As Boolean
        Get
            Return bImportacao
        End Get
        Set(ByVal value As Boolean)
            bImportacao = value
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

#Region "::: CONTROLES :::"

#Region "::: GERAL :::"

    Private Sub frmFatEmissaoNFeProdutoEstoque_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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

    Private Sub frmFatEmissaoNFeProdutoEstoque_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        ConfigurarFormulario()

    End Sub

#End Region

#Region "::: ESTOQUE :::"

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdEstoque
            oForm.NomeFormulario = Formulario.FaturamentoEmissaoNFe
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdEstoque, Formulario.FaturamentoEmissaoNFe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Deleta Registros
            Delete()
            'Limpa Formulário
            Novo()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        Try

            'Fecha Formulário
            Me.Dispose()

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
            If Validacao() = False Then Exit Sub

            'Salva Dados
            Salvar()
            'Limpa Formulário
            Novo()
            'Carrega Grid
            LoadGrid()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub cboDeposito_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDeposito.SelectedIndexChanged

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Controle
            cboLote.DataSource = Nothing : cboLote.Text = ""

            'Verifica se foi Selecionado Algum Registro
            If cboDeposito.SelectedIndex > -1 Then
                Call LoadCombo(cboLote, "sp_select_combo_cadastro_basico_deposito_item_lote " & lCodigoItem & ", " & cboDeposito.SelectedValue & ", " & goUsuario.iEmpresa)
                Call cboLote_SelectedIndexChanged(cboLote, System.EventArgs.Empty)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboLote_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLote.SelectedIndexChanged

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se foi Selecionado Algum Registro
            If cboLote.SelectedIndex > -1 Then
                'Carrega Informação do Estoque
                txtSaldoEstoque.Value = CType(LoadDescricao("sp_select_estoque_item_saldo " & lCodigoItem & ", '" & cboLote.SelectedValue & "'," & cboDeposito.SelectedValue & ", " & goUsuario.iEmpresa & ", " & lCodigoEmissaoCapa & ", " & iCodigoEmissaoItem), Double)
            Else
                'Limpa Váriavel
                txtSaldoEstoque.Value = 0
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub CalculaQuantidadeEstoque(sender As Object, e As EventArgs) Handles txtQuantidadeEstoque.LostFocus, _
                                                                                   txtFatorConversao.LostFocus, _
                                                                                   txtQuantidadeNotaFiscal.LostFocus

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Select Case sender.Name
                Case "txtQuantidadeEstoque" : txtFatorConversao.Value = txtQuantidadeEstoque.Value / txtQuantidadeNotaFiscal.Value
                Case "txtFatorConversao" : txtQuantidadeEstoque.Value = txtQuantidadeNotaFiscal.Value * txtFatorConversao.Value
                Case "txtQuantidadeNotaFiscal" : txtQuantidadeEstoque.Value = txtQuantidadeNotaFiscal.Value * txtFatorConversao.Value
            End Select

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdEstoque_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdEstoque.RowDoubleClick

        Try

            'Verifica o Tipo de Operação
            Select Case grdEstoque.CurrentColumn.Key

                Case "editar" : Editar()
                Case "desvincular_pedido_compra" : DesvincularPedidoCompra()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
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

    Private Sub cboPedidoCompra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPedidoCompra.SelectedIndexChanged

        Try

            cboPedidoCompraItem.SelectedIndex = -1
            cboPedidoCompraItem.Text = ""
            cboPedidoCompraItem.DataSource = Nothing

            If cboPedidoCompra.SelectedIndex = -1 Then Exit Sub

            LoadCombo(cboPedidoCompraItem, "sp_select_combo_faturamento_entrada_pedido_compra_item_retorno " & cboPedidoCompra.SelectedValue & "," & goUsuario.iEmpresa)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub cboCodigoItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPedidoCompraItem.SelectedIndexChanged

        Try

            txtQuantidadePedidoCompra.Value = 0
            txtReferencia.Text = ""

            If cboPedidoCompraItem.SelectedIndex = -1 Then Exit Sub

            oClsFatEmissaoNFeProdutoEstoque.LoadControles(cboPedidoCompra.SelectedValue, _
                                                          cboPedidoCompraItem.SelectedValue, _
                                                          txtQuantidadePedidoCompra, _
                                                          txtReferencia)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
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

            'Carrega Combo - Depósito
            LoadCombo(cboPedidoCompra, "sp_select_combo_faturamento_entrada_pedido_compra_retorno " & lCodigoEmitente & "," & goUsuario.iEmpresa)
            LoadCombo(cboDeposito, "sp_select_combo_cadastro_basico_deposito_faturamento_emissao " & goUsuario.iEmpresa & ", " & lCodigoEmissaoCapa & ", " & iCodigoEmissaoItem, False)

            'Seta Controle
            txtProduto.Text = sProduto
            txtQuantidadeNotaFiscalTotal.Value = dQuantidade
            txtQuantidadeNotaFiscalTotal.FormatString = "#,#0.0000 " & sUnidadeMedidaNF
            txtSaldoEstoque.FormatString = "#,#0.0000 " & sUnidadeMedidaEstoque

            'Verifia se Controla Lote
            If bControlaLote = False Then
                cboLote.Text = "" : cboLote.Enabled = False
                txtLote.Text = "" : txtLote.Enabled = False
            End If

            'Carrega Grid
            LoadGrid()

            'Configurar Grid
            ConfiguraGrid(grdEstoque, Formulario.FaturamentoEmissaoNFe)

            'Váriaveis
            Dim sTipo As String = LoadDescricao("sp_select_faturamento_emissao_item_estoque_forma_controle_lote " & lCodigoEmissaoCapa & ", " & iCodigoEmissaoItem & ", " & goUsuario.iEmpresa & ", " & iCodigoTipoDocumentoFiscal)

            'Verifica o Tipo de Documento Fiscal
            Select Case sTipo
                Case "texto"
                    cboLote.Visible = False : txtLote.Visible = True : lblSaldoEstoque.Visible = False
                Case "combo"
                    cboLote.Visible = True : txtLote.Visible = False
            End Select

            If bImportacao = False Then

                lblPedidoCompra.Visible = False
                cboPedidoCompra.Visible = False
                lblPedidoCompraItem.Visible = False
                cboPedidoCompraItem.Visible = False
                lblQuantidadePedidoCompra.Visible = False
                txtQuantidadePedidoCompra.Visible = False
                lblReferencia.Visible = False
                txtReferencia.Visible = False

                'ConfiguraLocation()

            End If

            'Seta Focu
            cboDeposito.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

#Region "::: ESTOQUE :::"

    Private Sub ConfiguraLocation()

        Try

            Dim x As Integer
            Dim y As Integer

            x = 6
            y = 64

            lblSaldoEstoque.Location = New Point(x, y)

            x = 9
            y = 79

            txtSaldoEstoque.Location = New Point(x, y)

            x = txtSaldoEstoque.Location.X + txtSaldoEstoque.Width + 6
            y = txtSaldoEstoque.Location.Y
            txtQuantidadeNotaFiscal.Location = New Point(x, y)

            x = txtQuantidadeNotaFiscal.Location.X + txtQuantidadeNotaFiscal.Width + 6
            y = txtQuantidadeNotaFiscal.Location.Y
            txtFatorConversao.Location = New Point(x, y)

            x = txtFatorConversao.Location.X + txtFatorConversao.Width + 6
            y = txtFatorConversao.Location.Y
            txtQuantidadeEstoque.Location = New Point(x, y)

            x = txtQuantidadeNotaFiscal.Location.X - 3
            y = txtQuantidadeNotaFiscal.Location.Y - 17
            lblQuantidadeNotaFiscal.Location = New Point(x, y)

            x = txtFatorConversao.Location.X - 3
            y = txtFatorConversao.Location.Y - 17
            lblFatorConversao.Location = New Point(x, y)

            x = txtQuantidadeEstoque.Location.X - 3
            y = txtQuantidadeEstoque.Location.Y - 17
            lblQuantidadeEstoque.Location = New Point(x, y)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Delete()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdEstoque) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsFatEmissaoNFeProdutoEstoque.Delete(lCodigoEmissaoCapa, _
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

    Private Sub Salvar()

        Try

            'Váriavel - Lote
            Dim sLote As String = ""

            'Seta Váriavel - Lote
            If cboLote.Visible = True Then
                sLote = IIf(cboLote.SelectedIndex = -1, "", cboLote.SelectedValue)
            ElseIf txtLote.Visible = True Then
                sLote = txtLote.Text.Trim
            End If

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserir.Tag) Then

                'Váriaveis 
                Dim iCodigoAntigo As Integer

                'Obtém Código
                If IsNumeric(btnInserir.Tag) Then
                    iCodigoAntigo = grdEstoque.CurrentRow.Cells("codigo").Value
                End If

                'Atualiza Registro
                oClsFatEmissaoNFeProdutoEstoque.Update(lCodigoEmissaoCapa, _
                                                       iCodigoEmissaoItem, _
                                                       cboDeposito.SelectedValue, _
                                                       txtQuantidadeNotaFiscal.Value, _
                                                       txtQuantidadeEstoque.Value, _
                                                       sLote, _
                                                       iCodigoAntigo, _
                                                       IIf(cboPedidoCompra.SelectedIndex = -1, -1, cboPedidoCompra.SelectedValue), _
                                                       IIf(cboPedidoCompraItem.SelectedIndex = -1, -1, cboPedidoCompraItem.SelectedValue))

            Else

                'Insere Registro
                oClsFatEmissaoNFeProdutoEstoque.Insert(lCodigoEmissaoCapa, _
                                                       iCodigoEmissaoItem, _
                                                       cboDeposito.SelectedValue, _
                                                       txtQuantidadeNotaFiscal.Value, _
                                                       txtQuantidadeEstoque.Value, _
                                                       sLote,
                                                       IIf(cboPedidoCompra.SelectedIndex = -1, -1, cboPedidoCompra.SelectedValue), _
                                                       IIf(cboPedidoCompraItem.SelectedIndex = -1, -1, cboPedidoCompraItem.SelectedValue))

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.FaturamentoEmissaoNFe, gcUpdate) = True Then

                'Limpa Erro
                frmMain.errInfo.Clear()

                With grdEstoque.CurrentRow.Cells

                    'Carrega Controles
                    cboDeposito.SelectedValue = .Item("codigo_deposito").Value
                    txtQuantidadeNotaFiscal.Value = .Item("quantidade").Value
                    txtQuantidadeEstoque.Value = .Item("quantidade_estoque").Value
                    txtFatorConversao.Value = .Item("quantidade_estoque").Value / .Item("quantidade").Value
                    If IsDBNull(.Item("lote").Value) = False Then cboLote.SelectedValue = .Item("lote").Value : txtLote.Text = .Item("lote").Value
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

    Private Sub LoadGrid()

        Try

            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid
            oClsFatEmissaoNFeProdutoEstoque.LoadGrid(grdEstoque, _
                                                     lCodigoEmissaoCapa, _
                                                     iCodigoEmissaoItem)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Dependente
            cboDeposito.SelectedIndex = -1
            txtFatorConversao.Value = 0
            txtQuantidadeEstoque.Value = 0
            cboLote.SelectedIndex = -1
            txtLote.Text = ""
            cboPedidoCompraItem.SelectedIndex = -1
            cboPedidoCompra.SelectedIndex = -1
            txtQuantidadeNotaFiscal.Value = 0
            btnInserir.Tag = ""

            'Seta Focu
            cboDeposito.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Selecionado o Campo - Depósito
            If ValidaCampo(cboDeposito, lblDeposito) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Lote
            If cboLote.Enabled = True And cboLote.Visible = True Then
                If ValidaCampo(cboLote, lblLote) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - Lote
            If txtLote.Enabled = True And txtLote.Visible = True Then
                If ValidaCampo(txtLote, lblLote, TipoCampo.texto) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Quantidade Nota Fiscal
            If ValidaCampo(txtQuantidadeNotaFiscal, lblQuantidadeNotaFiscal, True) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Quantidade
            If ValidaCampo(txtQuantidadeEstoque, lblQuantidadeEstoque, True) = False Then
                Exit Function
            End If

            'Verifica se a Quantidade é Válida
            Dim dQuantidade As Double
            If grdEstoque.GetDataRows.Count > 0 Then dQuantidade = grdEstoque.GetTotalRow.Cells("quantidade").Value
            If IsNumeric(btnInserir.Tag) Then
                dQuantidade -= grdEstoque.CurrentRow.Cells("quantidade").Value
            End If
            If txtQuantidadeNotaFiscal.Value + dQuantidade > txtQuantidadeNotaFiscalTotal.Value Then
                frmMain.errInfo.SetError(lblQuantidadeEstoque, "A Soma das Quantidades não pode ser maior que a Quantidade do Produto.")
                txtQuantidadeEstoque.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub DesvincularPedidoCompra()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsFatEmissaoNFeProdutoEstoque.DesvincularPedidoCompra(lCodigoEmissaoCapa, _
                                                                    iCodigoEmissaoItem, _
                                                                    grdEstoque.GetValue("codigo"))

            LoadGrid()

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class

