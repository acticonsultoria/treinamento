Imports Janus.Windows.GridEX

Public Class frmEstRequisicaoHistorico

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsEstRequisicao As New clsUsrEstRequisicao

    Private sNumeroRequisicao As String
    Private sDataRequisicao As String
    Private sTipoRequisicao As String
    Private sNumeroDocumento As String
    Private sProduto As String
    Private dQuantidade As Double
    Private lCodigoRequisicao As Long
    Private iCodigoRequisicaoItem As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property NumeroRequisicao() As String
        Get
            Return sNumeroRequisicao
        End Get
        Set(ByVal value As String)
            sNumeroRequisicao = value
        End Set
    End Property

    Public Property DataRequisicao() As String
        Get
            Return sDataRequisicao
        End Get
        Set(ByVal value As String)
            sDataRequisicao = value
        End Set
    End Property

    Public Property TipoRequisicao() As String
        Get
            Return sTipoRequisicao
        End Get
        Set(ByVal value As String)
            sTipoRequisicao = value
        End Set
    End Property

    Public Property NumeroDocumento() As String
        Get
            Return sNumeroDocumento
        End Get
        Set(ByVal value As String)
            sNumeroDocumento = value
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

    Public Property CodigoRequisicao() As Long
        Get
            Return lCodigoRequisicao
        End Get
        Set(ByVal value As Long)
            lCodigoRequisicao = value
        End Set
    End Property

    Public Property CodigoRequisicaoItem() As Integer
        Get
            Return iCodigoRequisicaoItem
        End Get
        Set(ByVal value As Integer)
            iCodigoRequisicaoItem = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmEstRequisicaoHistorico_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub frmEstRequisicaoHistorico_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

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
            oForm.NomeFormulario = Formulario.EstoqueRequisicao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdHistorico, Formulario.EstoqueRequisicao)

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

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Dados do Item
            txtNumeroRequisicao.Text = sNumeroRequisicao
            txtDataRequisicao.Text = sDataRequisicao
            txtTipoRequisicao.Text = sTipoRequisicao
            txtNumeroDocumento.Text = sNumeroDocumento
            txtProduto.Text = sProduto
            txtQuantidade.Value = dQuantidade

            'Configura Grid
            Call ConfiguraGrid(grdHistorico, Formulario.EstoqueRequisicao)

            'Carrega Grid
            Call oClsEstRequisicao.LoadGridHistorico(grdHistorico, lCodigoRequisicao, iCodigoRequisicaoItem)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

End Class