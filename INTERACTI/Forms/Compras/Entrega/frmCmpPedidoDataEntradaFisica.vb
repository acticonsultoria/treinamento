Imports Janus.Windows.GridEX

Public Class frmCmpPedidoDataEntradaFisica

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsCmpPedidoEntrega As New clsUsrCmpPedidoEntrega
    Private sNumeroPedido As String
    Private sDataPedido As String
    Private sParceiroNegocio As String

#End Region

#Region "::: PROPERTIE :::"

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
            oForm.Grid = grdEntradaFisica
            oForm.NomeFormulario = Formulario.QualidadeInspecaoRecebimento
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdEntradaFisica, Formulario.FaturamentoEntradaNF)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Try

            Call AtualizarDataEntradaFisica()

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Limpa a tabela temporária
        Call oClsCmpPedidoEntrega.DeleteTemp()
        'Fecha o Controle
        Me.Dispose()

    End Sub

    Private Sub grdHistorico_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdEntradaFisica.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdEntradaFisica, _
                                     Formulario.QualidadeInspecaoRecebimento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdHistorico_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdEntradaFisica.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdEntradaFisica.Name, _
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

            'Carrega Grid
            Call oClsCmpPedidoEntrega.LoadGridEntradaFisica(grdEntradaFisica)

            'Carrega Controles
            txtNumeroPedido.Text = sNumeroPedido
            txtDataPedido.Text = sDataPedido
            txtCliente.Text = sParceiroNegocio

            'Configura Grid
            Call ConfiguraGrid(grdEntradaFisica, Formulario.ComprasPedidoControleEntrega)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub AtualizarDataEntradaFisica()

        Try

            For Each oRow As GridEXRow In grdEntradaFisica.GetDataRows

                'Atualiza Data de Entrada linha a linha
                Call oClsCmpPedidoEntrega.AtualizarDataEntradafisica(oRow.Cells("codigo_pedido").Value, _
                                                                     oRow.Cells("codigo_pedido_item").Value, _
                                                                     oRow.Cells("codigo_pedido_item_entrega").Value, _
                                                                     dtpDataEntradaFisica.Value)

            Next

            frmMain.Informacao(Mensagem.RegistroSalvo)

        Catch ex As Exception
            'Trata Erro
            Throw ex
        End Try

    End Sub

#End Region

End Class