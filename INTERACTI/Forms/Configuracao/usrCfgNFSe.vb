Imports INTERACTI.NFe.CertificadoDigital

Public Class usrCfgNFSe

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCfgNFSe As New clsUsrCfgNFSe

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrCfgNFSe_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown

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

    Private Sub usrCfgNSFe_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCfgNFSe_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnSalvarDiretorios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarDiretorios.Click

        'Limpa Erro
        frmMain.errInfo.Clear()

        'Valida dados do Formulário
        If ValidacaoDiretorios() = True Then

            'Salva dados do Diretórios
            Call SalvarDiretorios()

        End If

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

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
                                                                                                  btnSairDiretorios.Click, _
                                                                                                  btnSairOutros.Click

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

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCfgNFSe_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnSalvarDiretorios.Enabled = VerificaDireito(Formulario.ConfiguracaoNotaFiscalEletronica, gcUpdate)
            btnSalvarOutros.Enabled = VerificaDireito(Formulario.ConfiguracaoNotaFiscalEletronica, gcUpdate)

            Call LoadComboCertificado(cboCertificado)

            'Carrega Combo
            Call LoadComboSimNao(cboHabilitaProxy)
            Call LoadCombo(cboTipoAmbiente, "sp_select_combo_static_tipo_ambiente_nfe")

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
            oClsCfgNFSe.LoadDados(txtPastaEntrada, _
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
                                  txtTamanhoMaximo, _
                                  cboCertificado)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub SalvarDiretorios()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCfgNFSe.PastaEntrada = txtPastaEntrada.Text
            oClsCfgNFSe.PastaSaida = txtPastaSaida.Text
            oClsCfgNFSe.PastaRecibo = txtPastaRecibo.Text
            oClsCfgNFSe.PastaImpressao = txtPastaImpressao.Text
            oClsCfgNFSe.PastaXSD = txtPastaXSD.Text
            oClsCfgNFSe.PastaEnvio = txtPastaEnvio.Text

            'Salva Dados
            oClsCfgNFSe.SaveDiretorios()

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub SalvarOutros()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCfgNFSe.HabilitaProxy = cboHabilitaProxy.SelectedValue
            oClsCfgNFSe.Dominio = txtDominio.Text
            oClsCfgNFSe.Usuario = txtUsuario.Text
            oClsCfgNFSe.Senha = txtSenha.Text
            oClsCfgNFSe.Endereco = txtEndereco.Text
            oClsCfgNFSe.Porta = IIf(txtPorta.Text = "", -1, txtPorta.Text)
            oClsCfgNFSe.Certificado = cboCertificado.SelectedValue
            oClsCfgNFSe.TipoAmbiente = cboTipoAmbiente.SelectedValue
            oClsCfgNFSe.TamanhoMaximo = txtTamanhoMaximo.Value

            'Salva Dados
            oClsCfgNFSe.SaveOutros()

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
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
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
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

            'Verifica se foi Selecionado o Campo - Tipo Ambiente
            If ValidaCampo(cboTipoAmbiente, lblTipoAmbiente) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Tamanho Máximo
            If ValidaCampo(txtTamanhoMaximo, lblTamanhoMaximo, True) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoOutros = True

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Function

#End Region

End Class