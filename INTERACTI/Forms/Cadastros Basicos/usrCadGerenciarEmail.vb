Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class usrCadGerenciarEmail

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oclsUsrCadGerenciarEmail As New clsUsrCadGerenciarEmail
    Private iFormulario As Integer

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadEmailDestinatario_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: EMAIL :::"

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

            'Prepara o Formulário para Inserção de um Novo Registro
            Call Novo()

            'Alterna Aba
            tabMain.TabPages.Remove(pagLista)
            tabMain.TabPages.Add(pagDados)

            cboModulo.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirEmailDestino_Click(sender As Object, e As EventArgs) Handles btnInserirEmailDestino.Click

        Try

            If cboUsuarioDestinatario.SelectedIndex = -1 Then Exit Sub

            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = False Then Exit Sub

            Salvar()
            SalvarDestinoEmail()
            oclsUsrCadGerenciarEmail.LoadGridDestinoEmail(grdEmailDestino, btnSalvar.Tag)

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = False Then Exit Sub

            'Salva Dados do Registro
            Salvar()

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

            'Alterna Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagLista)

            'Carrega Grid
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved,
                                                                                                                               grdEmailDestino.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(sender,
                                     iFormulario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn,
                                                                                                                                grdEmailDestino.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(sender.Name,
                                     iFormulario,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging,
                                                                                                   grdEmailDestino.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(sender.Name,
                                          iFormulario,
                                          e.Group.Column.Key,
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False),
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdListagem.RowDoubleClick
        Try

            'Verifica se a Célula é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call Editar()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdEmailDestino_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdEmailDestino.RowDoubleClick

        Try

            'Verifica se a Célula é Válida
            If IsNothing(grdEmailDestino.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdEmailDestino.CurrentColumn.Key

                Case "delete" : Call DeleteDestinoEmail()

            End Select

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

            iFormulario = LoadCodigo("sp_select_static_formulario_codigo_user_control " & Me.Name)
            iFormularioGrid = iFormulario

            'Adiciona KeyUP
            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf usr_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(iFormulario, gcDelete)
            btnNovo1.Enabled = VerificaDireito(iFormulario, gcInsert)
            btnNovo.Enabled = VerificaDireito(iFormulario, gcInsert)

            LoadCombo(cboModuloFiltro, "sp_select_combo_static_modulo_email ", False)
            LoadCombo(cboModulo, "sp_select_combo_static_modulo_email ", False)
            LoadCombo(cboUsuarioDestinatario, "sp_select_combo_administracao_usuario " & goUsuario.iEmpresa, False)
            LoadComboSimNao(cboAtivo)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Configura Grid
            ConfiguraGrid(grdListagem, iFormulario)
            ConfiguraGrid(grdEmailDestino, iFormulario)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: EMAIL :::"

    Private Sub Editar()

        Try

            'Verifica se o Usuário tem direito de Alterar Dados
            If VerificaDireito(iFormulario, gcUpdate) = True Then

                'Limpa Controles
                Novo()

                'Adiciona Aba
                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                btnSalvar.Tag = grdListagem.CurrentRow.Cells("codigo").Value

                oclsUsrCadGerenciarEmail.LoadControles(grdListagem.CurrentRow.Cells("codigo").Value,
                                                       cboModulo,
                                                       txtDescricao,
                                                       cboAtivo)

                oclsUsrCadGerenciarEmail.LoadGridDestinoEmail(grdEmailDestino,
                                                              grdListagem.CurrentRow.Cells("codigo").Value)

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            'Trata Erro
            Throw ex
        End Try

    End Sub

    Private Sub Delete()

        Try

            'Verifica se foi selecionado um ou mais registros
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    oclsUsrCadGerenciarEmail.Delete()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else

                'Informa o Usuário da Necessidade de Selecionar um ou mais Registro
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)

            End If

        Catch ex As Exception
            'Trata Erro
            Throw ex
        End Try

    End Sub

    Private Sub DeleteDestinoEmail()

        Try

            oclsUsrCadGerenciarEmail.DeleteDestinoEmail(grdEmailDestino.CurrentRow.Cells.Item("codigo").Value)

            oclsUsrCadGerenciarEmail.LoadGridDestinoEmail(grdEmailDestino, btnSalvar.Tag)

        Catch ex As Exception
            'Trata Erro
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()
            cboModulo.SelectedIndex = -1
            cboUsuarioDestinatario.SelectedIndex = -1
            cboAtivo.SelectedValue = 1
            txtDescricao.Text = ""

            btnSalvar.Tag = ""
            btnInserirEmailDestino.Tag = ""
            grdEmailDestino.DataSource = Nothing

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica o Tipo de Operação
            If IsNumeric(btnSalvar.Tag) Then

                oclsUsrCadGerenciarEmail.Update(btnSalvar.Tag,
                                                txtDescricao.Text.Trim,
                                                cboAtivo.SelectedValue,
                                                cboModulo.SelectedValue)

                frmMain.Informacao(Mensagem.RegistroAlterado)

            Else

                oclsUsrCadGerenciarEmail.Insert(txtDescricao.Text.Trim,
                                                cboAtivo.SelectedValue,
                                                cboModulo.SelectedValue)

                btnSalvar.Tag = oclsUsrCadGerenciarEmail.Codigo

                frmMain.Informacao(Mensagem.RegistroInserido)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarDestinoEmail()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            oclsUsrCadGerenciarEmail.InsertDestinoEmail(btnSalvar.Tag,
                                                        cboUsuarioDestinatario.SelectedValue)

            'Limpa campoo
            cboUsuarioDestinatario.SelectedIndex = -1

            frmMain.Informacao(Mensagem.RegistroInserido)

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

            oclsUsrCadGerenciarEmail.LoadGrid(grdListagem,
                                              txtDescricaoFiltro.Text.Trim,
                                              IIf(cboModuloFiltro.SelectedIndex = -1, -1, cboModuloFiltro.SelectedValue))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            If ValidaCampo(cboModulo, lblModulo) = False Then Return False
            If ValidaCampo(txtDescricao, lblDescricao, TipoCampo.texto) = False Then Return False
            If ValidaCampo(cboAtivo, lblAtivo) = False Then Return False

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

End Class
