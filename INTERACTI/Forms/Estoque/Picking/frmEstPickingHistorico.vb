Imports Janus.Windows.GridEX

Public Class frmEstPickingHistorico

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsEstPicking As New clsUsrEstPicking
    Private lCodigoPicking As Long
    Private sNumeroPicking As String
    Private sDataPicking As String
    Private sNumeroPedido As String
    Private sCliente As String

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoPicking() As Long
        Get
            Return lCodigoPicking
        End Get
        Set(ByVal value As Long)
            lCodigoPicking = value
        End Set
    End Property

    Public Property NumeroPicking() As String
        Get
            Return sNumeroPicking
        End Get
        Set(ByVal value As String)
            sNumeroPicking = value
        End Set
    End Property

    Public Property DataPicking() As String
        Get
            Return sDataPicking
        End Get
        Set(ByVal value As String)
            sDataPicking = value
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

    Public Property Cliente() As String
        Get
            Return sCliente
        End Get
        Set(ByVal value As String)
            sCliente = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmEstPickingHistorico_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub frmEstPickingHistorico_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

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
            oForm.NomeFormulario = Formulario.EstoquePicking
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdHistorico, Formulario.EstoquePicking)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdHistorico_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdHistorico.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdHistorico, _
                                     Formulario.EstoquePicking)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdHistorico_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdHistorico.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdHistorico.Name, _
                                     Formulario.EstoquePicking, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
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

            'Carrega Controles
            txtNumeroPicking.Text = sNumeroPicking
            txtDataPicking.Text = sDataPicking
            txtNumeroPedidoCliente.Text = sNumeroPedido
            txtCliente.Text = sCliente

            'Carrega Grid
            Call oClsEstPicking.LoadGridHistorico(grdHistorico, _
                                                 lCodigoPicking)

            'Configura Grid
            Call ConfiguraGrid(grdHistorico, Formulario.EstoquePicking)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

End Class