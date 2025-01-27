Imports Janus.Windows.GridEX

Public Class frmCstMonthlyReport

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oGrid As GridEX
    Private sMes As String
    Private iAno As Integer
    Private sDescricao As String
    Private oClsCstCenario As New clsCstCenario

#End Region

#Region "::: PROPERTIE :::"
    Public Property Ano() As Integer
        Get
            Return iAno
        End Get
        Set(ByVal value As Integer)
            iAno = value
        End Set
    End Property
    Public Property Descricao() As String
        Get
            Return sDescricao
        End Get
        Set(ByVal value As String)
            sDescricao = value
        End Set
    End Property
    Public Property Mes() As String
        Get
            Return sMes
        End Get
        Set(ByVal value As String)
            sMes = value
        End Set
    End Property

    Public Property Grid() As GridEX
        Get
            Return oGrid
        End Get
        Set(ByVal value As GridEX)
            oGrid = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"


    Private Sub frmPrdOrdemProducaoCancelar_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarForm()

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Fecha o Controle
        Me.Dispose()

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarForm()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            txtMesAno.Text = sMes & "/" & CStr(iAno)
            txtDescricao.Text = sDescricao

            oClsCstCenario.LoadGridMonthlyReportDetalhado(grdListagem, iAno, sMes, sDescricao)

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)




            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub


#End Region

End Class