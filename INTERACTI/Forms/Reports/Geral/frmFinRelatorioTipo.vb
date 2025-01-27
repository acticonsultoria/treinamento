Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls

Public Class frmFinRelatorioTipo

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private sDataLimite As String

#End Region

#Region "::: PROPERTIES :::"

    Public Property DataLimite() As String
        Get
            Return sDataLimite
        End Get
        Set(ByVal value As String)
            sDataLimite = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmFinRelatorioTipo_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click

        Try

            'Seta Váriavel
            sDataLimite = dtpDataLimite.Value

            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try


    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Seta Relatório
        goCrystalReport.sReport = ""
        goCrystalReport.sManual = ""
        'Fecha o Controle
        Me.Dispose()

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Ícone
            Me.Icon = frmMain.Icon

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

End Class