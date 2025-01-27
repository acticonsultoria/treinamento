Public Class usrCfgPastaIntegracaoNFe

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCfgPastaIntegracaoNFe As New clsUsrCfgPastaIntegracaoNFe

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrCfgPastaIntegracaoNFe_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

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

    Private Sub usrCfgPastaIntegracaoNFe_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCfgPastaIntegracaoNFe_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Redimensiona Vetor
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
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Deleta Aba
        If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
        'Fecha o Controle
        Me.Dispose()

    End Sub

    Private Sub btnPastaArquivoNFe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPastaArquivoNFe.Click

        Try

            'Váriaveis Locais
            Dim oPasta As New FolderBrowserDialog

            oPasta.Description = "Selecione a Pasta onde será salvo o Arquivo"

            'Seleciona Pasta
            If oPasta.ShowDialog() = DialogResult.OK Then
                txtPastaArquivoNFe.Text = oPasta.SelectedPath
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnPastaArquivoRetornoNFe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPastaArquivoRetornoNFe.Click

        Try

            'Váriaveis Locais
            Dim oPasta As New FolderBrowserDialog

            oPasta.Description = "Selecione a Pasta onde será salvo o Arquivo"

            'Seleciona Pasta
            If oPasta.ShowDialog() = DialogResult.OK Then
                txtPastaArquivoRetornoNFe.Text = oPasta.SelectedPath
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnPastaArquivoCancelamentoNFe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPastaArquivoCancelamentoNFe.Click

        Try

            'Váriaveis Locais
            Dim oPasta As New FolderBrowserDialog

            oPasta.Description = "Selecione a Pasta onde será salvo o Arquivo"

            'Seleciona Pasta
            If oPasta.ShowDialog() = DialogResult.OK Then
                txtPastaArquivoCancelamentoNFe.Text = oPasta.SelectedPath
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnPastaArquivoRetornoCancelamentoNFe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPastaArquivoRetornoCancelamentoNFe.Click

        Try

            'Váriaveis Locais
            Dim oPasta As New FolderBrowserDialog

            oPasta.Description = "Selecione a Pasta onde será salvo o Arquivo"

            'Seleciona Pasta
            If oPasta.ShowDialog() = DialogResult.OK Then
                txtPastaArquivoRetornoCancelamentoNFe.Text = oPasta.SelectedPath
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCfgPastaIntegracaoNFe_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega Registro
            Call LoadDados()

            'Seta Focu
            txtPastaArquivoNFe.Focus()

            'Verifica Direito
            btnSalvar.Enabled = VerificaDireito(Formulario.ConfiguracaoPastaIntegracaoNFe, gcInsert)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCfgPastaIntegracaoNFe.PastaArquivoNFe = txtPastaArquivoNFe.Text
            oClsCfgPastaIntegracaoNFe.PastaArquivoRetornoNFe = txtPastaArquivoRetornoNFe.Text
            oClsCfgPastaIntegracaoNFe.PastaArquivoCancelamentoNFe = txtPastaArquivoCancelamentoNFe.Text
            oClsCfgPastaIntegracaoNFe.PastaArquivoRetornoCancelamentoNFe = txtPastaArquivoRetornoCancelamentoNFe.Text

            'Slava Dados
            oClsCfgPastaIntegracaoNFe.Insert()

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroAlterado)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadDados()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCfgPastaIntegracaoNFe.LoadDados(txtPastaArquivoNFe, _
                                     txtPastaArquivoRetornoNFe, _
                                     txtPastaArquivoCancelamentoNFe, _
                                     txtPastaArquivoRetornoCancelamentoNFe)

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

            'Verifica se foi Preenchido o Campo - Pasta Arquivo NFe
            If ValidaCampo(txtPastaArquivoNFe, lblPastaArquivoNFe, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Pasta Arquivo Retorno NFe
            If ValidaCampo(txtPastaArquivoRetornoNFe, lblPastaArquivoRetornoNFe, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Pasta Arquivo Cancelamento NFe
            If ValidaCampo(txtPastaArquivoCancelamentoNFe, lblPastaArquivoCancelamentoNFe, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Pasta Arquivo Retorno Cancelamento NFe
            If ValidaCampo(txtPastaArquivoRetornoCancelamentoNFe, lblPastaArquivoRetornoCancelamentoNFe, TipoCampo.texto) = False Then
                Exit Function
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
