Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Microsoft.Office.Interop
Imports System.IO

Public Class frmPrdOrdemProducaoEstimativaHoras

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsUsrPrdProducaoManual As New clsUsrPrdProducaoManual
    Private oCurrentRow As GridEXRow
    Private lCodigoOrdemProducao As Long
    Private iFormulario As Integer

#End Region

#Region "::: PROPERTY :::"

    Public Property CodigoOrdemProducao() As Long
        Get
            Return lCodigoOrdemProducao
        End Get
        Set(ByVal value As Long)
            lCodigoOrdemProducao = value
        End Set
    End Property

    Public Property Formulario() As Integer
        Get
            Return iFormulario
        End Get
        Set(ByVal value As Integer)
            iFormulario = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"
    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     1724)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     1724, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Me.Dispose()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        ConfigurarFormulario()

    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs)

        Try

            ImportarRoteiro()

            Me.Dispose()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click

        Try

            Me.Dispose()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdListagem_RowCheckStateChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowCheckStateChangeEventArgs) Handles grdListagem.RowCheckStateChanged

        Try
            'Verifica o Status da Linha
            If e.CheckState = RowCheckState.Checked Then

                'Verifica se tinha outra linha selecionada
                If IsNothing(oCurrentRow) = False Then
                    oCurrentRow.CheckState = RowCheckState.Unchecked
                End If

                'Seta Váriaveis
                oCurrentRow = e.Row

            Else
                oCurrentRow = Nothing
            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarFormulario()

        Try
            Dim A As Integer = 1
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            iFormularioGrid = 1724

            'Adiciona KeyUP
            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf frm_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            Call ConfiguraGrid(grdListagem, 1724)

            iFormularioGrid = -1

            oClsUsrPrdProducaoManual.LoadGridEstimativaHoras(grdListagem, Nothing, lCodigoOrdemProducao)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub ImportarRoteiro()

        Try

            If grdListagem.GetCheckedRows.Count <= 0 Then
                MsgBox("Selecione alguma linha.", MsgBoxStyle.Exclamation, "Validação")
                Exit Sub
            End If



            If MsgBox("Deseja sobrescrever o roteiro existente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Validação") = MsgBoxResult.Yes Then

                oClsUsrPrdProducaoManual.DeleteRoteiroAll(lCodigoOrdemProducao)

            End If


            For Each oRow As GridEXRow In grdListagem.GetCheckedRows

                oClsUsrPrdProducaoManual.ImportarRoteiro(lCodigoOrdemProducao, _
                                                         oRow.Cells("codigo").Value)

            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class