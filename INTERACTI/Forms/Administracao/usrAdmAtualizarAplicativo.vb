Public Class usrAdmAtualizarAplicativo

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsAdmAtualizarAplicativo As New clsUsrAdmAtualizarAplicativo

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrECFLeituraX_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrECFLeituraX_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call Salvar()

                'Verifica se o Usuário deseja sair da Aplicação
                If MsgBox("Deseja sair da Aplicação?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then
                    End
                End If

                'Deleta Aba
                If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
                'Fecha o Controle
                Me.Dispose()

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

    Private Sub btnAplicativo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicativo.Click

        Try

            'Váriaveis Locais
            Dim oAplicativo As New OpenFileDialog

            'Seta Dados do OpenFileDialog
            oAplicativo.Filter = "Interacti|*.exe"
            oAplicativo.InitialDirectory = "c:\\DADOS"

            'Verifica se foi Selecionado algum Arquivo
            If oAplicativo.ShowDialog = DialogResult.OK Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Seta Arquivo
                txtAplicativo.Text = oAplicativo.FileName

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

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

            'Carrega Configuração
            oClsAdmAtualizarAplicativo.LoadDados(lblDataUltimaAtualizacao, _
                                                 lblVersaoAtual)

            'Seta Focu
            btnAplicativo.Focus()

            'Verifica Direito
            btnAtualizar.Enabled = VerificaDireito(Formulario.AdministracaoAtualizarAplicativo, gcInsert)

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
            oClsAdmAtualizarAplicativo.Aplicativo = txtAplicativo.Text
            oClsAdmAtualizarAplicativo.Versao = txtVersao.Text

            'Salva Dados
            oClsAdmAtualizarAplicativo.Insert()

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Preenchido o Campo - Aplicativo
            If ValidaCampo(txtAplicativo, lblAplicativo, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Versao
            If ValidaCampo(txtVersao, lblVersao, TipoCampo.texto) = False Then
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
