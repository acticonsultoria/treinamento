Imports Janus.Windows.GridEX

Public Class frmCmpPedidoProdutoEntregaHistorico

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oGrid As GridEX
    Private oClsCmpPedidoEntrega As New clsUsrCmpPedidoEntrega
    Private sNumeroPedido As String
    Private sDataPedido As String
    Private sParceiroNegocio As String
    Private sProduto As String
    Private dQuantidade As Double
    Private sUnidadeMedida As String
    Private dValorUnitario As Double
    Private dValorTotal As Double

#End Region

#Region "::: PROPERTIE :::"

    Public Property Grid() As GridEX
        Get
            Return oGrid
        End Get
        Set(ByVal value As GridEX)
            oGrid = value
        End Set
    End Property

    Public Property NumeroPedido() As String
        Get
            Return sNumeroPedido
        End Get
        Set(ByVal value As String)
            sNumeroPedido = value
        End Set
    End Property

    Public Property DataPedido() As String
        Get
            Return sDataPedido
        End Get
        Set(ByVal value As String)
            sDataPedido = value
        End Set
    End Property

    Public Property ParceiroNegocio() As String
        Get
            Return sParceiroNegocio
        End Get
        Set(ByVal value As String)
            sParceiroNegocio = value
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

    Public Property Quantidade() As Double
        Get
            Return dQuantidade
        End Get
        Set(ByVal value As Double)
            dQuantidade = value
        End Set
    End Property

    Public Property UnidadeMedida() As String
        Get
            Return sUnidadeMedida
        End Get
        Set(ByVal value As String)
            sUnidadeMedida = value
        End Set
    End Property

    Public Property ValorUnitario() As Double
        Get
            Return dValorUnitario
        End Get
        Set(ByVal value As Double)
            dValorUnitario = value
        End Set
    End Property

    Public Property ValorTotal() As Double
        Get
            Return dValorTotal
        End Get
        Set(ByVal value As Double)
            dValorTotal = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmCmpPedidoProdutoEntregaHistorico_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub frmCmpPedidoProdutoEntregaHistorico_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona Formulário
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdHistorico
            oForm.NomeFormulario = Formulario.QualidadeInspecaoRecebimento
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdHistorico, Formulario.FaturamentoEntradaNF)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Fecha o Controle
        Me.Dispose()

    End Sub

    Private Sub grdHistorico_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdHistorico.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdHistorico, _
                                     Formulario.QualidadeInspecaoRecebimento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdHistorico_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdHistorico.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdHistorico.Name, _
                                     Formulario.QualidadeInspecaoRecebimento, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Carrega Dados do Item
            txtNumeroPedido.Text = sNumeroPedido
            txtDataPedido.Text = sDataPedido
            txtCliente.Text = sParceiroNegocio
            txtItem.Text = sProduto
            txtQuantidade.Value = dQuantidade
            txtUnidadeMedida.Text = sUnidadeMedida
            txtValorUnitario.Value = dValorUnitario
            txtValorTotal.Value = dValorTotal

            'Carrega Grid
            Call oClsCmpPedidoEntrega.LoadGridProdutoEntregaHistorico(grdHistorico, _
                                                                      oGrid.CurrentRow.Cells("codigo_pedido").Value, _
                                                                      oGrid.CurrentRow.Cells("codigo_pedido_item").Value, _
                                                                      oGrid.CurrentRow.Cells("codigo").Value)

            'Configura Grid
            Call ConfiguraGrid(grdHistorico, Formulario.FaturamentoEntradaNF)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

End Class