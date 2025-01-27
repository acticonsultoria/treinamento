Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Microsoft.Office.Interop
Imports System.IO

Public Class frmPrdOrdemProducaoLiberarProducao

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


            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                For Each oRow As GridEXRow In gSelecaoRow

                    If oRow.Cells("status").Value <> 1 Then
                        MessageBox.Show("Ordem de Produção já está liberada!")
                        Exit Sub
                    End If

                Next

                '1 = Liberar para produçao 
                LiberarProducao(1)

            Else
                'Informa o Usuário sobre a necessidade de Selecionar um ou mais Itenss
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnCancelarLiberacao_Click(sender As Object, e As EventArgs) Handles btnCancelarLiberacao.Click
        Try
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            '2 = Cancelar Liberacao
            LiberarProducao(2)

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

            oClsUsrPrdProducaoManual.LoadGridOrdemProducaoLiberarProducao(grdListagem, sCodigo)

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

    Private Sub LiberarProducao(iTipo As Integer)

        Try

            Dim sCodigoOP As String = ""

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then


                For Each oRow As GridEXRow In gSelecaoRow

                    sCodigoOP += IIf(sCodigoOP = "", "", ",") & CStr(oRow.Cells.Item("codigo").Value)

                Next

                oClsUsrPrdProducaoManual.UpdateLiberarProducao(sCodigoOP, iTipo)
                MessageBox.Show("Operação Realizado com Sucesso!")

                ConfigurarFormulario()

            Else
                'Informa o Usuário sobre a necessidade de Selecionar um ou mais Itenss
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If



        Catch ex As Exception
            Throw ex
        End Try

    End Sub



#End Region

End Class