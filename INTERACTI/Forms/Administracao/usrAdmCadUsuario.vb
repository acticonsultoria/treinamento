Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class usrAdmCadUsuario

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsAdmCadUsuario As New clsUsrAdmCadUsuario

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrAdmCadUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name

                        Case "cboDepartamentoFiltro", "cboDepartamento"
                            Dim oComboBox(1) As UIComboBox
                            oComboBox(0) = cboDepartamentoFiltro : oComboBox(1) = cboDepartamento
                            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_departamento " & goUsuario.iEmpresa)
                        Case "cboPerfilFiltro", "cboPerfil"
                            Dim oComboBox(1) As UIComboBox
                            oComboBox(0) = cboPerfilFiltro : oComboBox(1) = cboPerfil
                            Call LoadCombo(oComboBox, "sp_select_combo_administracao_cadastro_perfil_usuario " & goUsuario.iEmpresa)
                        Case "cboVendedor" : Call LoadCombo(cboVendedor, "sp_select_combo_cadastro_basico_vendedor " & goUsuario.iEmpresa & ", " & goUsuario.iUsuario, False)
                        Case "cboFuncionario" : Call LoadCombo(cboFuncionario, "sp_select_combo_cadastro_basico_funcionario " & goUsuario.iEmpresa, False)

                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name

                        Case "cboDepartamento" : Call btnCadastrarDepartamento_Click(btnCadastrarDepartamento, System.EventArgs.Empty)
                        Case "cboPerfil" : Call btnCadastrarPerfil_Click(btnCadastrarPerfil, System.EventArgs.Empty)
                        Case "cboVendedor" : Call btnCadastrarVendedor_Click(btnCadastrarVendedor, System.EventArgs.Empty)

                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrAdmCadUsuario_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: USUÁRIOS :::"

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdListagem.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdListagem.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdListagem.GroupByBoxVisible = True
                grdListagem.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.AdministracaoCadastroUsuario
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.AdministracaoCadastroUsuario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarPerfil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarPerfil.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrAdmCadPerfil"
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location: oForm.Tamanho = True
            oForm.Titulo = Me.Parent.Text
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Carrega Combo
            LoadCombo(cboPerfil, "sp_select_combo_administracao_cadastro_perfil_usuario " & goUsuario.iEmpresa)
            'Seta Focu
            cboPerfil.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarDepartamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarDepartamento.Click

        Try

                         'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadDepartamento")

            'Carrega Combo
            LoadCombo(cboDepartamento, "sp_select_combo_cadastro_basico_departamento " & goUsuario.iEmpresa)
            'Seta Focu
            cboDepartamento.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarVendedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarVendedor.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadVendedor")

            'Carrega Combo
            LoadCombo(cboVendedor, "sp_select_combo_cadastro_basico_vendedor " & goUsuario.iEmpresa & ", " & goUsuario.iUsuario, )
            'Seta Focu
            cboDepartamento.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarFuncionario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarFuncionario.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadFuncionario")

            'Carrega Combo
            LoadCombo(cboFuncionario, "sp_select_combo_cadastro_basico_funcionario " & goUsuario.iEmpresa, False)
            'Seta Focu
            cboDepartamento.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArquivo.Click
        Try

            'Variaveis Locais
            Dim arqImagem As New OpenFileDialog

            'Abre PopUp para Usuário selecionar Imagem
            arqImagem.InitialDirectory = "c:\\dados"
            arqImagem.Filter = "(Imagens BMP;JPG;GIF)|*.BMP;*.JPG;*.GIF"
            arqImagem.Title = "Selecione o Arquivo"

            If arqImagem.ShowDialog() = DialogResult.OK Then
                txtAssinaturaDigital.Text = arqImagem.FileName
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnLimparArquivo_Click(sender As Object, e As EventArgs) Handles btnLimparArquivo.Click

        Try

            'Limpa Arquivo
            picAssinaturaDigital.Image = Nothing
            txtAssinaturaDigital.Text = ""

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Deleta Registros
            Call Delete()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Dados da Grid
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            'Prepara Formulário para Inserção de um Novo Registro
            Call Novo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click

        Try

            'Alterna Aba
            tabMain.TabPages.Remove(pagLista)
            tabMain.TabPages.Add(pagDados)

            'Prepara o Formulário para Inserção de um Novo Registro
            Call Novo()

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

                'Salva Dados do Registro
                Call Salvar()
                'Prepara Formulário para Inserção de um Novo Registro
                Call Novo()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
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
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        Try

            'Carrega Grid
            Call LoadGrid()

            'Alterna Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagLista)

            'Seta Focu
            txtNomeFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCongelarColuna_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCongelarColuna.SelectedIndexChanged

        Try

            If cboCongelarColuna.SelectedIndex = -1 Then
                grdListagem.FrozenColumns = 2
            Else
                grdListagem.FrozenColumns = cboCongelarColuna.SelectedValue
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Linha é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call Editar()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.AdministracaoCadastroUsuario)

            'Carrega Combo
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.AdministracaoCadastroUsuario, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name, _
                                          Formulario.AdministracaoCadastroUsuario, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub txtAssinaturaDigital_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAssinaturaDigital.TextChanged

        Try

            'Verifica se foi Selecionado alguma Logo
            If txtAssinaturaDigital.Text <> "" Then

                'Carrega Imagem
                Dim oImage As Image = Image.FromFile(txtAssinaturaDigital.Text)

                'Obtém tamanho da Imagem
                Dim iWidth As Integer = oImage.Size.Width
                Dim iHeight As Integer = oImage.Size.Height
                Dim oNewSize As Size

                If (392 / iWidth) < (98 / iHeight) Then
                    oNewSize = New Size(392, 392 * iHeight / iWidth)
                Else
                    oNewSize = New Size(98 * iWidth / iHeight, 98)
                End If

                'Carrega Imagem da Váriavel
                Dim oNewImagem As Image = New Bitmap(oImage)

                'Descarrega Imagem do Arquivo da Memória
                oImage.Dispose()

                oNewImagem = New Bitmap(oNewImagem, oNewSize)

                picAssinaturaDigital.Image = oNewImagem
                picAssinaturaDigital.SizeMode = PictureBoxSizeMode.CenterImage

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub



#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: DADOS GERAIS :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrAdmCadUsuario_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnNovo.Enabled = VerificaDireito(Formulario.AdministracaoCadastroUsuario, gcInsert)
            btnNovo1.Enabled = VerificaDireito(Formulario.AdministracaoCadastroUsuario, gcInsert)
            btnExcluir.Enabled = VerificaDireito(Formulario.AdministracaoCadastroUsuario, gcDelete)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.AdministracaoCadastroUsuario, gcPrint)

            'Verifica Direito Botão Cadastrar
            btnCadastrarDepartamento.Enabled = VerificaDireito(Formulario.CadastroBasicoDepartamento, gcInsert)
            btnCadastrarPerfil.Enabled = VerificaDireito(Formulario.AdministracaoCadastroPerfil, gcInsert)
            btnCadastrarVendedor.Enabled = VerificaDireito(Formulario.CadastroBasicoVendedor, gcInsert)

            'Carrega Combo
            Call LoadComboSimNao(cboAtivo)
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboDepartamento : oComboBox(1) = cboDepartamentoFiltro
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_departamento " & goUsuario.iEmpresa)
            oComboBox(0) = cboPerfil : oComboBox(1) = cboPerfilFiltro
            Call LoadCombo(oComboBox, "sp_select_combo_administracao_cadastro_perfil_usuario " & goUsuario.iEmpresa)
            LoadCombo(cboVendedor, "sp_select_combo_cadastro_basico_vendedor " & goUsuario.iEmpresa)
            LoadCombo(cboFuncionario, "sp_select_combo_cadastro_basico_funcionario " & goUsuario.iEmpresa)
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)


            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.AdministracaoCadastroUsuario)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            txtNomeFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: USUÁRIOS :::"

    Private Sub Editar()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.AdministracaoCadastroUsuario, gcUpdate) = True Then

                'Limpa Formulário
                Call Novo()

                With grdListagem.CurrentRow.Cells

                    txtNome.Text = .Item("nome").Value
                    btnSalvar.Tag = .Item("codigo").Value
                    txtUsuario.Text = .Item("usuario").Value
                    txtSenha.Text = Cripitografar(.Item("senha").Value)
                    txtConfirmarSenha.Text = Cripitografar(.Item("senha").Value)
                    txtEmail.Text = .Item("email").Value
                    txtCelular.Text = IIf(IsDBNull(.Item("celular").Value), "", .Item("celular").Value)
                    txtTelefone.Text = IIf(IsDBNull(.Item("telefone").Value), "", .Item("telefone").Value)
                    txtRamal.Text = IIf(IsDBNull(.Item("ramal").Value), "", .Item("ramal").Value)
                    cboAtivo.SelectedValue = .Item("ativo").Value
                    cboDepartamento.Text = .Item("departamento").Value
                    cboPerfil.Text = .Item("perfil").Value
                    cboVendedor.SelectedValue = .Item("codigo_vendedor").Value
                    cboFuncionario.SelectedValue = .Item("codigo_funcionario").Value



                    'Chama procedure para carregar Assinatura Digital
                    Call oClsAdmCadUsuario.LoadAssinaturaDigital(.Item("codigo").Value, _
                                                                 picAssinaturaDigital)

                End With

                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                txtNome.Focus()

            Else

                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Delete()

        Try

            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsAdmCadUsuario.Delete()

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

            'Limpa Controles
            txtNome.Text = ""
            cboPerfil.SelectedIndex = -1
            txtUsuario.Text = ""
            txtSenha.Text = ""
            txtConfirmarSenha.Text = ""
            txtEmail.Text = ""
            txtCelular.Text = ""
            txtTelefone.Text = ""
            txtRamal.Text = ""
            cboDepartamento.Text = ""
            cboAtivo.SelectedValue = True
            cboVendedor.SelectedIndex = -1
            cboFuncionario.SelectedIndex = -1
            btnSalvar.Tag = ""
            txtAssinaturaDigital.Text = ""
            picAssinaturaDigital.Image = Nothing


            'Seta Focu
            txtNome.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsAdmCadUsuario.Codigo = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0)
            oClsAdmCadUsuario.Nome = txtNome.Text
            oClsAdmCadUsuario.Perfil = cboPerfil.SelectedValue
            oClsAdmCadUsuario.Senha = Cripitografar(txtSenha.Text)
            oClsAdmCadUsuario.Email = txtEmail.Text
            oClsAdmCadUsuario.Celular = txtCelular.Text
            oClsAdmCadUsuario.Telefone = txtTelefone.Text
            oClsAdmCadUsuario.Ramal = txtRamal.Text
            oClsAdmCadUsuario.Usuario = txtUsuario.Text
            oClsAdmCadUsuario.Departamento = cboDepartamento.SelectedValue
            oClsAdmCadUsuario.Ativo = cboAtivo.SelectedValue
            oClsAdmCadUsuario.CodigoVendedor = IIf(cboVendedor.SelectedIndex = -1, -1, cboVendedor.SelectedValue)
            oClsAdmCadUsuario.CodigoFuncionario = IIf(cboFuncionario.SelectedIndex = -1, -1, cboFuncionario.SelectedValue)
            oClsAdmCadUsuario.AssinaturaDIgital = picAssinaturaDigital


            'Verifica o Tipo de Operação
            If Len(btnSalvar.Tag) > 0 Then
                oClsAdmCadUsuario.Update()
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                oClsAdmCadUsuario.Insert()
                frmMain.Informacao(Mensagem.RegistroInserido)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsAdmCadUsuario.LoadGridUsuario(grdListagem, _
                                              txtNomeFiltro.Text.Trim, _
                                              IIf(cboPerfilFiltro.SelectedIndex > -1, cboPerfilFiltro.SelectedValue, -1), _
                                              txtUsuarioFiltro.Text.Trim, _
                                              IIf(cboDepartamentoFiltro.SelectedIndex > -1, cboDepartamentoFiltro.SelectedValue, -1))

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

            'Verifica se foi Preenchido o Campo - Nome
            If ValidaCampo(txtNome, lblNome, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Perfil
            If ValidaCampo(cboPerfil, lblPerfil) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Usuário
            If ValidaCampo(txtUsuario, lblUsuario, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se o Usuário é Válido
            If oClsAdmCadUsuario.ValidaUsuario(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0), _
                                               txtUsuario.Text.Trim) = False Then
                frmMain.errInfo.SetError(lblUsuario, "Este Usuário: " & txtUsuario.Text & " já está associado a outro Registro.")
                txtUsuario.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Senha
            If ValidaCampo(txtSenha, lblSenha, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Confirmar Senha
            If ValidaCampo(txtConfirmarSenha, lblConfirmarSenha, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se o Campo - Senha é igual o campo Confirmar Senha
            If Trim(txtSenha.Text) <> Trim(txtConfirmarSenha.Text) Then
                frmMain.errInfo.SetError(lblConfirmarSenha, "A Confirmação da Senha está diferente da Senha.")
                txtConfirmarSenha.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Email
            If ValidaCampo(txtEmail, lblEmail, TipoCampo.email) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Departamento
            If ValidaCampo(cboDepartamento, lblDepartamento) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Ativo
            If ValidaCampo(cboAtivo, lblAtivo) = False Then
                Exit Function
            End If



            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

End Class
