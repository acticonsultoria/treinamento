Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Microsoft.Office.Interop
Imports System.IO

Public Class frmPrdOrdemProducaoFinalizarOP

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private sCodigo As String
    Private oClsUsrPrdProducaoManual As New clsUsrPrdProducaoManual
#End Region

#Region "::: PROPERTIE :::"

    Public Property Codigo As String
        Get
            Return sCodigo
        End Get
        Set(value As String)
            sCodigo = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

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
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        'Sair da tela
        Me.Dispose()
    End Sub

    Private Sub btnLiberarProducao_Click(sender As Object, e As EventArgs) Handles btnLiberarProducao.Click
        Try
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'For Each oRow In grdListagem.GetCheckedRows

            '    If oRow.Cells.Item("status").Value <> 2 Then


            '        If goUsuario.iUsuario = 1 Then
            '            If MsgBox("ACTI,  A OP NÃO ESTÁ AG. ESTOQUE. DESEJA CONTINUAR?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = vbNo Then Exit Sub
            '        End If

            '        MsgBox("Só é possível finalizar OP's com status de [AGUARDANDO ESTOQUE]!", vbExclamation)
            '        Exit Sub


            '    End If

            'Next

            '1 = Liberar para produçao 
            FinalizarOP(1)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            oClsUsrPrdProducaoManual.LoadGridOrdemProducaoFinalizarOP(grdListagem, sCodigo)

            grdListagem.CheckAllRecords()

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frm_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub FinalizarOP(iTipo As Integer)

        Try

            Dim sCodigoOP As String = ""

            For Each oRow In grdListagem.GetCheckedRows

                sCodigoOP += IIf(sCodigoOP = "", "", ",") & CStr(oRow.Cells.Item("codigo").Value)

            Next

            Dim sInputBox As String = InputBox("Por favor, digite a justificativa para continuar:", "Justificativa")

            If sInputBox = "" Then

                MessageBox.Show("A justificativa é obrigatória. Por favor, informe uma justificativa.")
                Exit Sub

            End If

            oClsUsrPrdProducaoManual.UpdateFinalizarOP(sCodigoOP, iTipo, sInputBox)
            MessageBox.Show("Operação Realizado com Sucesso!")

            ConfigurarFormulario()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub


#End Region

End Class