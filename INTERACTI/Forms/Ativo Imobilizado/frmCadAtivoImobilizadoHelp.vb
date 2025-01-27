Imports Janus.Windows.GridEX

Public Class frmCadAtivoImobilizadoHelp

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oClsUsrCadAtivoImobilizado As New clsUsrCadAtivoImobilizado

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

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try
            Call Salvar()
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

            'Seta Ícone
            Me.Icon = frmMain.Icon

            ''Adiciona KeyUP
            'Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            'Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frm_KeyDown))
            'Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            ''Seta Tamanho / Posição do Formulário
            'Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            If goUsuario.iUsuario = 1 Then 'adm

                btnSalvar.Visible = True
            Else
                btnSalvar.Visible = False
            End If
            'Carrega o texto
            txtHELP.Text = oClsUsrCadAtivoImobilizado.LoadHelp(txtFormulario.Tag, _
                                                txtCampo.Tag)



            'Seta Focu
            txtHELP.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub Salvar()
        Try
            oClsUsrCadAtivoImobilizado.InsertHelp(txtFormulario.Tag, txtCampo.Tag, txtHELP.Text)
            Me.Dispose()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
    
#End Region

   
End Class