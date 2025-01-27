Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls

Public Class frmFinReceitaCobrancaTipo

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

    Private Sub frmFinReceitaCobrancaTipo_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click

        Try

            'Seta Váriavel de Retorno
            If rdbInstrucaoProtesto.Checked = True Then
                goCrystalReport.sReport = goCrystalReport.sPath & "FIN000000014.rpt"
                goCrystalReport.sManual = "Instrução de Protesto"
            ElseIf rdbInstrucaoCobranca.Checked = True Then
                goCrystalReport.sReport = goCrystalReport.sPath & "FIN000000015.rpt"
                goCrystalReport.sManual = "Instrução de Cobrança"
            End If

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

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

End Class