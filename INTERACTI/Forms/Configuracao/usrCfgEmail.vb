Public Class usrCfgEmail

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCfgEmail As New clsUsrCfgEmail

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrCfgEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    Control_Enter(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCfgEmail_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCfgEmail_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona User Control
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call Salvar()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Deleta Aba
            If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboFormaEnvio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFormaEnvio.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado Algum Registro
            If cboFormaEnvio.SelectedIndex = -1 Then
                txtEmail.Text = "" : txtEmail.Enabled = False
                txtUsuario.Text = "" : txtUsuario.Enabled = False
                txtServidor.Text = "" : txtServidor.Enabled = False
                txtSenha.Text = "" : txtSenha.Enabled = False
                txtPorta.Text = "" : txtPorta.Enabled = False
                cboSSL.SelectedIndex = -1 : cboSSL.Enabled = False
            ElseIf cboFormaEnvio.SelectedValue = CInt(TipoEmail.Outlook) Then
                txtEmail.Text = "" : txtEmail.Enabled = False
                txtUsuario.Text = "" : txtUsuario.Enabled = False
                txtServidor.Text = "" : txtServidor.Enabled = False
                txtSenha.Text = "" : txtSenha.Enabled = False
                txtPorta.Text = "" : txtPorta.Enabled = False
                cboSSL.SelectedIndex = -1 : cboSSL.Enabled = False
            ElseIf cboFormaEnvio.SelectedValue = CInt(TipoEmail.Interacti) Then
                txtEmail.Enabled = True
                txtUsuario.Enabled = True
                txtServidor.Enabled = True
                txtSenha.Enabled = True
                txtPorta.Enabled = True
                cboSSL.Enabled = True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCfgEmail_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega Combo
            cboFormaEnvio.Items.Clear()
            cboFormaEnvio.Items.Add("OUTLOOK", CInt(TipoEmail.Outlook)) : cboFormaEnvio.Items.Add("INTERACTI", CInt(TipoEmail.Interacti))
            Call LoadComboSimNao(cboSSL)

            'Desabilita Controles
            txtEmail.Text = "" : txtEmail.Enabled = False
            txtUsuario.Text = "" : txtUsuario.Enabled = False
            txtServidor.Text = "" : txtServidor.Enabled = False
            txtSenha.Text = "" : txtSenha.Enabled = False
            txtPorta.Text = "" : txtPorta.Enabled = False
            cboSSL.SelectedIndex = -1 : cboSSL.Enabled = False

            'Carrega Registro
            Call LoadRegistro()

            'Seta Focu
            cboFormaEnvio.Focus()

            'Verifica Direito
            btnSalvar.Enabled = VerificaDireito(Formulario.ConfiguracaoEmail, gcInsert)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCfgEmail.CodigoFormaEnvio = cboFormaEnvio.SelectedValue
            oClsCfgEmail.Email = txtEmail.Text.Trim
            oClsCfgEmail.Usuario = txtUsuario.Text.Trim
            oClsCfgEmail.Senha = txtSenha.Text.Trim
            oClsCfgEmail.Servidor = txtServidor.Text.Trim
            oClsCfgEmail.Porta = txtPorta.Text.Trim
            oClsCfgEmail.SSL = cboSSL.SelectedValue
            'Salva Dados
            oClsCfgEmail.Save()

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadRegistro()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCfgEmail.LoadDados(cboFormaEnvio, _
                                   txtEmail, _
                                   txtUsuario, _
                                   txtSenha, _
                                   txtServidor, _
                                   txtPorta, _
                                   cboSSL)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Selecionado o Campo - Forma de Envio
            If ValidaCampo(cboFormaEnvio, lblFormaEnvio) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - E-mail
            If txtEmail.Enabled = True Then
                If ValidaCampo(txtEmail, lblEmail, TipoCampo.texto) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Usuário
            If txtUsuario.Enabled = True Then
                If ValidaCampo(txtUsuario, lblUsuario, TipoCampo.texto) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Senha
            If txtSenha.Enabled = True Then
                If ValidaCampo(txtSenha, lblSenha, TipoCampo.texto) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Servidor
            If txtServidor.Enabled = True Then
                If ValidaCampo(txtServidor, lblServidor, TipoCampo.texto) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Porta
            If txtPorta.Enabled = True Then
                If ValidaCampo(txtPorta, lblPorta, TipoCampo.numero) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - SSL
            If cboSSL.Enabled = True Then
                If ValidaCampo(cboSSL, lblSSL) = False Then
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Function

#End Region

End Class
