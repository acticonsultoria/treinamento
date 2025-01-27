Imports Janus.Windows.GridEX

Public Class frmCmpPedidoCompraAprovarFluxoFinanceiro

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsFinFluxoCaixa As New clsUsrFinFluxoCaixa
    Private lCodigoCotacao As Long
    Private iCodigoCotacaoFornecedor As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoCotacao() As Long
        Get
            Return lCodigoCotacao
        End Get
        Set(ByVal value As Long)
            lCodigoCotacao = value
        End Set
    End Property

    Public Property CodigoCotacaoFornecedor() As Integer
        Get
            Return iCodigoCotacaoFornecedor
        End Get
        Set(ByVal value As Integer)
            iCodigoCotacaoFornecedor = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmCmpPedidoAprovarFluxoFinanceiro_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Call btnSair_Click(btnSair, System.EventArgs.Empty)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmCmpPedidoAprovarFluxoFinanceiro_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub frmCmpPedidoAprovarFluxoFinanceiro_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdListagem)

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
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Carrega Grid
            Call LoadGrid()

            'Seta Focu
            btnSair.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid
            Call oClsFinFluxoCaixa.LoadGridFluxoFinanceiroAprovacaoPedidoCompra(grdListagem, _
                                                                                lCodigoCotacao, _
                                                                                iCodigoCotacaoFornecedor)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

End Class