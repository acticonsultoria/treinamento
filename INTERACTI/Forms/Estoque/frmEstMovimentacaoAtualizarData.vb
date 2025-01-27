Imports Janus.Windows.GridEX

Public Class frmEstMovimentacaoAtualizarData

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsEstMovimentacao As New clsUsrEstMovimentacao
    Private lCodigo As Long
    Private sDataMovimentacao As String

#End Region

#Region "::: PROPERTIE :::"

    Public Property Codigo() As Long
        Get
            Return lCodigo
        End Get
        Set(ByVal value As Long)
            lCodigo = value
        End Set
    End Property

    Public Property DataMovimentacao() As String
        Get
            Return sDataMovimentacao
        End Get
        Set(ByVal value As String)
            sDataMovimentacao = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmCmpPedidoProdutoEntregaHistorico_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Try

            Call Salvar()

            Me.Dispose()

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Fecha o Controle
        Me.Dispose()

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            Me.Location = New Point(300, 250)

            'Carrega Controles
            btnSalvar.Tag = lCodigo
            dtpDataMovimentacaoAnterior.Value = sDataMovimentacao
            dtpNovaDataMovimentacao.Value = Now.Date

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub Salvar()

        Try

            Cursor.Current = Cursors.WaitCursor

            Call oClsEstMovimentacao.AtualizaDataMovimentacao(btnSalvar.Tag, _
                                                              dtpNovaDataMovimentacao.Value)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region
    
End Class