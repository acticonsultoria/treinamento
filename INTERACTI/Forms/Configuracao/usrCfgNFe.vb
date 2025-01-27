Imports INTERACTI.NFe.CertificadoDigital

Public Class usrCfgNFe

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCfgNFe As New clsUsrCfgNFe

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrCfgNFe_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

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

    Private Sub usrCfgNFe_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCfgNFe_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnSalvarDiretorios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarDiretorios.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida dados do Formulário
            If ValidacaoDiretorios() = True Then

                'Salva dados do Diretórios
                Call SalvarDiretorios()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSalvarOutros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarOutros.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida dados do Formulário
            If ValidacaoOutros() = True Then

                'Salva dados do Outros
                Call SalvarOutros()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSalvarEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarEmail.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida dados do Formulário
            If ValidacaoEmail() = True Then

                'Salva dados do Outros
                Call SalvarEmail()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSairDiretorios.Click, _
                                                                                                  btnSairOutros.Click, _
                                                                                                  btnSairEmail.Click

        Try

            'Deleta Aba
            If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnPasta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPastaEntrada.Click, _
                                                                                                   btnPastaSaida.Click, _
                                                                                                   btnPastaRecibo.Click, _
                                                                                                   btnPastaImpressao.Click, _
                                                                                                   btnPastaXSD.Click, _
                                                                                                   btnPastaEnvio.Click

        Try

            'Váriaveis Locais
            Dim oFolder As New FolderBrowserDialog

            'Abre Pasta
            oFolder.ShowDialog()

            'Caso selecionado alguma Pasta
            If oFolder.SelectedPath <> "" Then

                Select Case sender.name

                    Case "btnPastaEntrada"
                        txtPastaEntrada.Text = oFolder.SelectedPath
                    Case "btnPastaSaida"
                        txtPastaSaida.Text = oFolder.SelectedPath
                    Case "btnPastaRecibo"
                        txtPastaRecibo.Text = oFolder.SelectedPath
                    Case "btnPastaImpressao"
                        txtPastaImpressao.Text = oFolder.SelectedPath
                    Case "btnPastaXSD"
                        txtPastaXSD.Text = oFolder.SelectedPath
                    Case "btnPastaEnvio"
                        txtPastaEnvio.Text = oFolder.SelectedPath

                End Select

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboHabilitaProxy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboHabilitaProxy.SelectedIndexChanged

        Try

            If cboHabilitaProxy.SelectedValue = True Then
                'Habilita Controles
                txtDominio.Enabled = True
                txtUsuario.Enabled = True
                txtSenha.Enabled = True
                txtEndereco.Enabled = True
                txtPorta.Enabled = True
            Else
                'Desabilita Controles
                txtDominio.Enabled = False
                txtUsuario.Enabled = False
                txtSenha.Enabled = False
                txtEndereco.Enabled = False
                txtPorta.Enabled = False
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboEnviarEmailAutomaticamente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEnviarEmailAutomaticamente.SelectedIndexChanged

        Try

            If cboEnviarEmailAutomaticamente.SelectedValue = True Then
                'Habilita Controles
                txtEmail.Enabled = True : txtEmail.Text = ""
                txtUsuarioEmail.Enabled = True : txtUsuarioEmail.Text = ""
                txtSenhaEmail.Enabled = True : txtSenhaEmail.Text = ""
                txtPortaEmail.Enabled = True : txtPortaEmail.Text = ""
                txtSenhaEmail.Enabled = True : txtSenhaEmail.Text = ""
                txtServidorEmail.Enabled = True : txtServidorEmail.Text = ""
                txtPortaEmail.Enabled = True : txtPortaEmail.Text = ""
                cboSSLEmail.Enabled = True : cboSSLEmail.Text = ""
                cboAutotextoEmail.Enabled = True : cboAutotextoEmail.Text = ""
                txtAutotexto.Text = ""
            Else
                'Desabilita Controles
                txtEmail.Enabled = False : txtEmail.Text = ""
                txtUsuarioEmail.Enabled = False : txtUsuarioEmail.Text = ""
                txtSenhaEmail.Enabled = False : txtSenhaEmail.Text = ""
                txtPortaEmail.Enabled = False : txtPortaEmail.Text = ""
                txtSenhaEmail.Enabled = False : txtSenhaEmail.Text = ""
                txtServidorEmail.Enabled = False : txtServidorEmail.Text = ""
                txtPortaEmail.Enabled = False : txtPortaEmail.Text = ""
                cboSSLEmail.Enabled = False : cboSSLEmail.Text = ""
                cboAutotextoEmail.Enabled = False : cboAutotextoEmail.Text = ""
                txtAutotexto.Text = ""
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboAutotextoEmail_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAutotextoEmail.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado algum E-mail
            If cboAutotextoEmail.SelectedIndex > -1 Then
                'Preenche Controle
                LoadDescricao(txtAutotexto, "sp_select_cadastro_basico_texto_email_texto " & cboAutotextoEmail.SelectedValue & ", " & goUsuario.iEmpresa & ",'" & goUsuario.sNome & "'," & -1 & ", " & -1)
            Else
                txtAutotexto.Text = ""
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCfgNFe_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnSalvarDiretorios.Enabled = VerificaDireito(Formulario.ConfiguracaoNotaFiscalEletronica, gcUpdate)
            btnSalvarOutros.Enabled = VerificaDireito(Formulario.ConfiguracaoNotaFiscalEletronica, gcUpdate)

            Call LoadComboCertificado(cboCertificado)

            'Carrega Combo
            Call LoadComboSimNao(cboHabilitaProxy)
            Call LoadCombo(cboUF, "sp_select_combo_static_estado_pais " & Pais.Brasil)
            Call LoadCombo(cboTipoAmbiente, "sp_select_combo_static_tipo_ambiente_nfe")
            Call LoadCombo(cboModoOperacao, "sp_select_combo_static_modo_operacao_nfe")
            Call LoadCombo(cboTimeOut, "sp_select_combo_static_timeout_nfe")
            Call LoadCombo(cboFormaImpressaoDanfe, "sp_select_combo_static_forma_impressao_danfe")
            Call LoadComboSimNao(cboHorarioVerao)
            Call LoadComboSimNao(cboEnviarEmailAutomaticamente)
            Call LoadComboSimNao(cboSSLEmail)
            Call LoadCombo(cboAutotextoEmail, "sp_select_combo_cadastro_basico_texto_email " & goUsuario.iEmpresa & ", " & TipoAutotextoEmail.NotaFiscalEmissao, False)

            'Carrega Dados
            Call LoadDados()

            'Seta Aba
            tabMain.SelectedTab = pagDiretorios

            'Seta Focu
            btnPastaEntrada.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadDados()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCfgNFe.LoadDados(txtPastaEntrada, _
                                 txtPastaSaida, _
                                 txtPastaRecibo, _
                                 txtPastaImpressao, _
                                 txtPastaXSD, _
                                 txtPastaEnvio, _
                                 cboHabilitaProxy, _
                                 txtDominio, _
                                 txtUsuario, _
                                 txtSenha, _
                                 txtEndereco, _
                                 txtPorta, _
                                 cboTipoAmbiente, _
                                 cboModoOperacao, _
                                 cboFormaImpressaoDanfe, _
                                 cboUF, _
                                 cboTimeOut, _
                                 txtQuantidadeMaximaNF, _
                                 txtTamanhoMaximo, _
                                 cboHorarioVerao, _
                                 cboCertificado, _
                                 cboEnviarEmailAutomaticamente, _
                                 txtEmail, _
                                 txtUsuarioEmail, _
                                 txtSenhaEmail, _
                                 txtServidorEmail, _
                                 txtPortaEmail, _
                                 cboSSLEmail, _
                                 cboAutotextoEmail)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarDiretorios()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCfgNFe.PastaEntrada = txtPastaEntrada.Text
            oClsCfgNFe.PastaSaida = txtPastaSaida.Text
            oClsCfgNFe.PastaRecibo = txtPastaRecibo.Text
            oClsCfgNFe.PastaImpressao = txtPastaImpressao.Text
            oClsCfgNFe.PastaXSD = txtPastaXSD.Text
            oClsCfgNFe.PastaEnvio = txtPastaEnvio.Text

            'Salva Dados
            oClsCfgNFe.SaveDiretorios()

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarOutros()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCfgNFe.HabilitaProxy = cboHabilitaProxy.SelectedValue
            oClsCfgNFe.Dominio = txtDominio.Text
            oClsCfgNFe.Usuario = txtUsuario.Text
            oClsCfgNFe.Senha = txtSenha.Text
            oClsCfgNFe.Endereco = txtEndereco.Text
            oClsCfgNFe.Porta = IIf(txtPorta.Text = "", -1, txtPorta.Text)
            oClsCfgNFe.TipoAmbiente = cboTipoAmbiente.SelectedValue
            oClsCfgNFe.ModoOperacao = cboModoOperacao.SelectedValue
            oClsCfgNFe.FormaImpressaoDanfe = cboFormaImpressaoDanfe.SelectedValue
            oClsCfgNFe.UF = cboUF.SelectedValue
            oClsCfgNFe.TimeOut = cboTimeOut.SelectedValue
            oClsCfgNFe.QuantidadeMaximaNF = txtQuantidadeMaximaNF.Value
            oClsCfgNFe.TamanhoMaximo = txtTamanhoMaximo.Value
            oClsCfgNFe.HorarioVerao = cboHorarioVerao.SelectedValue
            oClsCfgNFe.Certificado = cboCertificado.SelectedValue

            'Salva Dados
            oClsCfgNFe.SaveOutros()

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarEmail()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Call oClsCfgNFe.SaveEmail(cboEnviarEmailAutomaticamente.SelectedValue, _
                                      txtEmail.Text.Trim, _
                                      txtUsuarioEmail.Text.Trim, _
                                      txtSenhaEmail.Text.Trim, _
                                      txtServidorEmail.Text.Trim, _
                                      IIf(IsNumeric(txtPortaEmail.Text.Trim), txtPortaEmail.Text.Trim, -1), _
                                      IIf(cboSSLEmail.SelectedIndex = -1, -1, cboSSLEmail.SelectedValue), _
                                      IIf(cboAutotextoEmail.SelectedIndex = -1, -1, cboAutotextoEmail.SelectedValue))

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoDiretorios() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoDiretorios = False

            'Verifica se foi Preenchido o Campo - Pasta Entrada
            If ValidaCampo(txtPastaEntrada, lblPastaEntrada, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Pasta Saída
            If ValidaCampo(txtPastaSaida, lblPastaSaida, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Pasta Recibo
            If ValidaCampo(txtPastaRecibo, lblPastaRecibo, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Pasta Impressão
            If ValidaCampo(txtPastaImpressao, lblPastaImpressao, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Pasta XSD
            If ValidaCampo(txtPastaXSD, lblPastaXSD, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Pasta Envio
            If ValidaCampo(txtPastaEnvio, lblPastaEnvio, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoDiretorios = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function ValidacaoOutros() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoOutros = False

            'PROXY

            'Verifica se foi Selecionado o Campo - Habilitar Proxy
            If ValidaCampo(cboHabilitaProxy, lblHabilitarProxy) = False Then
                Exit Function
            End If

            'Caso Proxy Habilitado
            If cboHabilitaProxy.SelectedValue = True Then

                'Verifica se foi Preenchido o Campo - Usuário
                If ValidaCampo(txtUsuario, lblUsuario, TipoCampo.texto) = False Then
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - Senha
                If ValidaCampo(txtSenha, lblSenha, TipoCampo.texto) = False Then
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - Endereço
                If ValidaCampo(txtEndereco, lblEndereco, TipoCampo.texto) = False Then
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - Porta
                If ValidaCampo(txtPorta, lblPorta, TipoCampo.numero) = False Then
                    Exit Function
                End If

            End If

            'WEN SERVICE

            'Verifica se foi Selecionado o Campo - Tipo Ambiente
            If ValidaCampo(cboTipoAmbiente, lblTipoAmbiente) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Modo de Operação
            If ValidaCampo(cboModoOperacao, lblModoOperacao) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - UF
            If ValidaCampo(cboUF, lblUF) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Timeout
            If ValidaCampo(cboTimeOut, lblTimeOut) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Quantidade Máximo
            If ValidaCampo(txtQuantidadeMaximaNF, lblQuantidadeMaximaNF, True) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Tamanho Máximo
            If ValidaCampo(txtTamanhoMaximo, lblTamanhoMaximo, True) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Horário de Verão
            If ValidaCampo(cboHorarioVerao, lblHorarioVerao) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoOutros = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function ValidacaoEmail() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoEmail = False

            'Verifica se foi Selecionado se envia Email Automaticamente
            If ValidaCampo(cboEnviarEmailAutomaticamente, lblEnviarEmailAutomaticamente) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado a Opção de Enviar E-mail Automaticamente
            If cboEnviarEmailAutomaticamente.SelectedValue = False Then
                ValidacaoEmail = True
                Exit Function
            End If
            
            'Verifica se foi Preenchido o Campo - E-mail
            If txtEmail.Enabled = True Then
                If ValidaCampo(txtEmail, lblEmail, TipoCampo.texto) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Usuário
            If txtUsuarioEmail.Enabled = True Then
                If ValidaCampo(txtUsuarioEmail, lblUsuarioEmail, TipoCampo.texto) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Senha
            If txtSenhaEmail.Enabled = True Then
                If ValidaCampo(txtSenhaEmail, lblSenhaEmail, TipoCampo.texto) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Servidor
            If txtServidorEmail.Enabled = True Then
                If ValidaCampo(txtServidorEmail, lblServidorEmail, TipoCampo.texto) = False Then
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
            If cboSSLEmail.Enabled = True Then
                If ValidaCampo(cboSSLEmail, lblSSLEmail) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - SSL
            If cboAutotextoEmail.Enabled = True Then
                If ValidaCampo(cboAutotextoEmail, lblAutotextoEmail) = False Then
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            ValidacaoEmail = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class
