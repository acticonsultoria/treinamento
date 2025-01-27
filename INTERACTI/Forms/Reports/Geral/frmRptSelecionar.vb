Imports Janus.Windows.GridEX

Public Class frmRptSelecionar

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsReportSelecionar As New clsFrmRptSelecionar
    Private sRelatorio As String
    Private sTipo As String
    Private oCurrentRow As GridEXRow

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property Tipo() As String
        Set(ByVal value As String)
            sTipo = value
        End Set
    End Property

    Public ReadOnly Property Relatorio() As String
        Get
            Return sRelatorio
        End Get
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmRptSelecionar_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

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

    Private Sub btnSelecionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelecionar.Click

        Try

            'Seta Relatório
            sRelatorio = oCurrentRow.Cells("relatorio").Value

            'Fecha o Formulário
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdRelatorio_RowCheckStateChanged(sender As Object, e As RowCheckStateChangeEventArgs) Handles grdRelatorio.RowCheckStateChanged

        Try

            'Verifica se tem alguma Linha Selecionada
            If e.Row.CheckState = RowCheckState.Checked Then

                'Desmarca Linha Anterior
                If IsNothing(oCurrentRow) = False Then
                    oCurrentRow.CheckState = RowCheckState.Unchecked
                End If

                'Seta Váriavel
                oCurrentRow = e.Row
                btnSelecionar.Enabled = True
            Else
                'Limpa Váriavel
                oCurrentRow = Nothing
                btnSelecionar.Enabled = False
            End If

            grdRelatorio.Refresh()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Carrega Grid
            Call oClsReportSelecionar.LoadGrid(grdRelatorio, sTipo)

            'Verifica se foi Carregado a Grid
            If grdRelatorio.GetDataRows.Count = 1 Then
                grdRelatorio.MoveToRowIndex(1)
                sRelatorio = grdRelatorio.CurrentRow.Cells("relatorio").Value
                Me.Dispose()
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

End Class