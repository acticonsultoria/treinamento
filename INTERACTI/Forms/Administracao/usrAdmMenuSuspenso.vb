Public Class usrAdmMenuSuspenso

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private WithEvents oClsAdmSuspenso As New clsUsrAdmMenuSuspenso

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrAdmMenuSuspenso_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFoto.Click

        Try

            'Variaveis Locais
            Dim arqImagem As New OpenFileDialog

            'Abre PopUp para Usuário selecionar Imagem
            arqImagem.InitialDirectory = "c:\\dados"
            arqImagem.Filter = "(Imagens BMP;JPG;PNG;GIF)|*.BMP;*.JPG;*.PNG;*.GIF"
            arqImagem.Title = "Selecione o Arquivo"

            If arqImagem.ShowDialog() = DialogResult.OK Then
                txtImagem.Text = arqImagem.FileName
            Else
                picImagem.Image = Nothing
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click

        Try

            'Limpa Controles
            txtImagem.Text = ""
            picImagem.Image = Nothing
            
        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Deleta Registro
            Call Delete()
            'Prepara Formulário para Inserção de um Novo Registro
            Call Novo()
            'Carrega Menu
            mnuMain.Items.Clear()
            oClsAdmSuspenso.LoadMenuSuspenso(mnuMain)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Insere Registro
                Call Salvar()
                'Prepara Formulário para Inserção de um Novo Registro
                Call Novo()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnAtualizarMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizarMenu.Click

        Try

            'Carrega Menu
            mnuMain.Items.Clear()
            oClsAdmSuspenso.LoadMenuSuspenso(mnuMain)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Deleta Aba
            If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)

            'Executa Tarefas Pendentes do Sistema
            Application.DoEvents()

            'Carrega Menu
            Dim oClsMain As New clsFrmMain
            Call oClsMain.LoadMenu(frmMain.mnuMain)

            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            'Limpa Formulário
            Call Novo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub txtImagem_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImagem.TextChanged

        Try

            'Verifica se foi Selecionado alguma Imagem
            If txtImagem.Text <> "" Then
                picImagem.Image = Image.FromFile(txtImagem.Text)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub mnuMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles oClsAdmSuspenso.Click

        Try

            'Limpa Controles
            Call Novo()

            'Carrega Controles
            txtCodigo.Text = sender.name
            txtCodigo.Tag = sender.name
            txtDescricao.Text = sender.text
            cboFormulario.SelectedValue = sender.Tag
            If Not sender.OwnerItem Is Nothing Then cboMenuSuperior.SelectedValue = sender.OwnerItem.name
            If Not sender.Image Is Nothing Then picImagem.Image = sender.Image

            'Seta Focu
            txtCodigo.Focus()

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

            'Limpa Formulário
            Call Novo()

            'Verifica Direito
            btnSalvar.Enabled = VerificaDireito(Formulario.AdministracaoMenuSuspenso, gcInsert)
            btnExcluir.Enabled = VerificaDireito(Formulario.AdministracaoMenuSuspenso, gcDelete)

            'Carrega Menu
            mnuMain.Items.Clear()
            oClsAdmSuspenso.LoadMenuSuspenso(mnuMain)

            'Seta Focu
            txtCodigo.Focus()

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
            oClsAdmSuspenso.Codigo = txtCodigo.Tag
            oClsAdmSuspenso.CodigoMenu = txtCodigo.Text.Trim
            oClsAdmSuspenso.Descricao = txtDescricao.Text.Trim
            oClsAdmSuspenso.CodigoMenuPai = IIf(cboMenuSuperior.SelectedIndex = -1, "", cboMenuSuperior.SelectedValue)
            oClsAdmSuspenso.Formulario = IIf(cboFormulario.SelectedIndex = -1, "", cboFormulario.SelectedValue)
            oClsAdmSuspenso.Imagem = picImagem

            'Verifica o Tipo de Operação
            If txtCodigo.Tag = "" Then
                oClsAdmSuspenso.Insert()
                frmMain.Informacao(Mensagem.RegistroInserido)
            Else
                oClsAdmSuspenso.Update()
                frmMain.Informacao(Mensagem.RegistroAlterado)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Delete()

        Try

            If txtCodigo.Tag <> "" Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsAdmSuspenso.Delete(txtCodigo.Tag)

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else

                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Carrega Combo
            Call LoadCombo(cboFormulario, "sp_select_combo_static_formulario") : cboFormulario.Text = ""
            Call LoadCombo(cboMenuSuperior, "sp_select_combo_static_menu_suspenso " & goUsuario.iIdioma) : cboMenuSuperior.Text = ""

            'Limpa Controles
            txtCodigo.Text = ""
            txtCodigo.Tag = ""
            txtDescricao.Text = ""
            cboFormulario.SelectedIndex = -1
            cboMenuSuperior.SelectedIndex = -1
            txtImagem.Text = ""
            picImagem.Image = Nothing

            'Seta Focu
            txtCodigo.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Preenchido o Campo - Código
            If ValidaCampo(txtCodigo, lblCodigo, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se o Código ja foi cadastrado
            If oClsAdmSuspenso.ValidaCodigo(txtCodigo.Tag, _
                                            txtCodigo.Text.Trim) = False Then
                frmMain.errInfo.SetError(lblCodigo, "Este Código: " & txtCodigo.Text & " já está associado a outro Registro.")
                txtCodigo.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Descrição
            If ValidaCampo(txtDescricao, lblDescricao, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class
