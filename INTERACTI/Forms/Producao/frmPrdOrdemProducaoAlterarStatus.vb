Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Microsoft.Office.Interop
Imports System.IO

Public Class frmPrdOrdemProducaoAlterarStatus

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private sCodigo As String
    Private oCommand As Janus.Windows.UI.CommandBars.UICommand
    Private oClsUsrPrdProducaoManual As New clsUsrPrdProducaoManual
#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property CommandBar As Janus.Windows.UI.CommandBars.UICommand
        Set(value As Janus.Windows.UI.CommandBars.UICommand)
            oCommand = value
        End Set
    End Property

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

    Private Sub btnStatus_Click(sender As Object, e As EventArgs) Handles btnStatus.Click
        Try

            If Validacao() = False Then Exit Sub



            AlterarStatus()

            oClsUsrPrdProducaoManual.LoadGridOrdemProducaoAlterarStatus(grdListagem, sCodigo)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            oClsUsrPrdProducaoManual.LoadGridOrdemProducaoAlterarStatus(grdListagem, sCodigo)

            grdListagem.CheckAllRecords()

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frm_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)



            'Configura o command
            btnStatus.Image = oCommand.Image
            btnStatus.Text = oCommand.Text


            'Arruma a cor dos formatcondition da grdlistagem 
            For iFormat As Integer = 0 To grdListagem.RootTable.FormatConditions.Count - 1

                With grdListagem.RootTable.FormatConditions(iFormat)

                    Try
                        Dim oObject As Object = FindControl(grpLegenda, .Key)

                        If IsNothing(oObject) = False Then
                            .FormatStyle = New GridEXFormatStyle
                            .FormatStyle.ForeColor = oObject.backcolor
                        End If

                    Catch ex As Exception

                    End Try


                End With

            Next

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default




        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub


    Private Function Validacao() As Boolean
        Try
            Validacao = False

            'Percorrer os itens
            For Each oRow In grdListagem.GetCheckedRows

                If oClsUsrPrdProducaoManual.ValidaAlterarStatus(oRow.Cells.Item("codigo").Value, _
                                                                oCommand.Tag) = False Then

                    MsgBox("Não é possível alterar o status para [ " + btnStatus.Text + " ] da Ordem de Produção [ " + oRow.Cells.Item("ordem_producao").Value + _
                                " ] pois ela está no status [ " + oRow.Cells.Item("status2").Value + "].", MsgBoxStyle.Exclamation, "Validação")

                    Exit Function

                End If



            Next


            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub AlterarStatus()
        Try

            If MsgBox("Deseja alterar o Status das Ordens selecionadas?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Validação") = vbNo Then Exit Sub

            Dim sInput As String = ""

            'Se for para cancelar ou forçar finalização, pedir justificativa
            If oCommand.Tag = 4 Or oCommand.Tag = 3 Or oCommand.Tag = 11 Then


                sInput = InputBox("Digite a justificativa para [ " + oCommand.Text + " ] !", "Alterar Status")
                If sInput = "" Then Exit Sub


            End If


            Dim sCodigoOrdemProducao As String = ""

            'Concatena os codigos
            For Each oRow In grdListagem.GetCheckedRows

                sCodigoOrdemProducao += IIf(sCodigoOrdemProducao = "", "", ",") + CStr(oRow.Cells.Item("codigo").Value)

            Next


            Dim sRetorno As String = ""

            'Altera o status
            sRetorno = oClsUsrPrdProducaoManual.AlterarStatus(sCodigoOrdemProducao,
                                                   oCommand.Tag,
                                                   sInput)

            If sRetorno = "" Then
                MsgBox("Status alterados com sucesso!", MsgBoxStyle.Information, "Alterar status")
            Else
                MsgBox(sRetorno, MsgBoxStyle.Information, "Alterando Status")
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

   
End Class