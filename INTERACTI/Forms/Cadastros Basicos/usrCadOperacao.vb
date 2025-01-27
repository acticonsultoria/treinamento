Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX

Public Class usrCadOperacao

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadOperacao As New clsUsrCadOperacao
    Private iFormulario As Integer

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboCentroTrabalho", "cboCentroTrabalhoFiltro"
                            Dim oComboBox(1) As UIComboBox
                            oComboBox(0) = cboCentroTrabalhoFiltro : oComboBox(1) = cboCentroTrabalho
                            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_centro_trabalho " & goUsuario.iEmpresa)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboCentroTrabalho" : Call btnCadastrarCentroTrabalho_Click(btnCadastrarCentroTrabalho, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub usr_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        ConfigurarUserControl()

    End Sub

#End Region

#Region "::: OPERAÇÃO :::"
    Private Sub cboCentroTrabalho_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCentroTrabalho.SelectedIndexChanged
        Try
            If cboCentroTrabalho.SelectedIndex = -1 Then Exit Sub
            txtOperacao.Text = LoadCodigo("sp_select_cadastro_basico_operacao_novo_codigo " & cboCentroTrabalho.SelectedValue & "," & goUsuario.iEmpresa)
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub cboTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipo.SelectedIndexChanged
        Try
            If cboTipo.SelectedIndex = -1 Then Exit Sub


            btnCadastrarCentroTrabalho.Visible = False
            cboCentroTrabalho.Visible = False
            lblCentroTrabalho.Visible = False

            btnCadastrarGrupoOperacao.Visible = False
            cboGrupoOperacao.Visible = False
            lblGrupoOperacao.Visible = False

            If cboTipo.SelectedValue = "INTERNO" Then

                btnCadastrarCentroTrabalho.Visible = True
                cboCentroTrabalho.Visible = True
                lblCentroTrabalho.Visible = True

            Else
                cboCentroTrabalho.SelectedValue = 0 'EXTERNO
                btnCadastrarGrupoOperacao.Visible = True
                cboGrupoOperacao.Visible = True
                lblGrupoOperacao.Visible = True
            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnCadastrarGrupoOperacao_Click(sender As Object, e As EventArgs) Handles btnCadastrarGrupoOperacao.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadGrupoOperacao")

            'Carrega Combo
            LoadCombo(cboGrupoOperacao, "sp_select_combo_cadastro_basico_grupo_operacao " & goUsuario.iEmpresa, False)

            cboGrupoOperacao.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnCadastrarCentroTrabalho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCentroTrabalho.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCentroTrabalho")

            'Carrega Combo
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboCentroTrabalho : oComboBox(1) = cboCentroTrabalhoFiltro
            LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_centro_trabalho " & goUsuario.iEmpresa)

            cboCentroTrabalho.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Deleta Registros
            Delete()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Dados da Grid
            LoadGrid()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            'Prepara Formulário para Inserção de um Novo Registro
            Novo()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click

        Try

            'Alterna Aba
            tabMain.TabPages.Remove(pagLista)
            tabMain.TabPages.Add(pagDados)

            'Prepara o Formulário para Inserção de um Novo Registro
            Novo()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
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
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Deleta Aba
            If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        Try

            'Carrega Grid
            LoadGrid()

            'Alterna Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagLista)

            cboCentroTrabalhoFiltro.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Editar()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(grdListagem, _
                                iFormulario)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(grdListagem.Name, _
                                iFormulario, _
                                e.Column.Key, _
                                e.ProposedWidth)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            UpdateConfiguraGridGrupo(grdListagem.Name, _
                                     iFormulario, _
                                     e.Group.Column.Key, _
                                     IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                     e.ProposedPosition)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnAtribuirFornecedor_Click(sender As Object, e As EventArgs) Handles btnAtribuirFornecedor.Click
        Try
            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrCadFornecedorOperacao"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Fornecedor por Operação"
            oForm.ShowDialog(Me)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            iFormulario = LoadCodigo("sp_select_static_formulario_codigo_user_control '" & Me.Name & "'")

            'Adiciona KeyUP
            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf usr_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(iFormulario, gcDelete)
            btnSalvar.Enabled = VerificaDireito(iFormulario, gcInsert)
            btnNovo.Enabled = VerificaDireito(iFormulario, gcInsert)
            btnNovo1.Enabled = VerificaDireito(iFormulario, gcInsert)

            'Verifica Direito - Cadastro
            btnCadastrarCentroTrabalho.Enabled = VerificaDireito(Formulario.CadastroBasicoCentroTrabalho, gcPrint)

            'Carrega ComboBox
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboCentroTrabalho : oComboBox(1) = cboCentroTrabalhoFiltro
            LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_centro_trabalho " & goUsuario.iEmpresa & ",'OPERACIONAL'")

            LoadCombo(cboGrupoOperacao, "sp_select_combo_cadastro_basico_grupo_operacao " & goUsuario.iEmpresa, False)


            cboTipo.Items.Add("EXTERNO", "EXTERNO")
            If goUsuario.iPerfil = 1 Then
                cboTipo.Items.Add("INTERNO", "INTERNO")
            End If

            'Configura Grid
            ConfiguraGrid(grdListagem, iFormulario)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            cboCentroTrabalhoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Delete()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & iif(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCadOperacao.Delete()

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
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            LimparCamposGroupBox(grpDados)
            cboCentroTrabalho.Enabled = True
            btnSalvar.Tag = ""

            cboTipo.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar()

        Try

            If goUsuario.iPerfil <> 1 And grdListagem.GetValue("tipo") = "INTERNO" Then

                frmMain.Informacao("Você não possui direito de edição de processos internos!", Color.Red)
                Exit Sub
            End If

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(iFormulario, gcUpdate) = True Then

                'Prepara Formulário
                Novo()

                'Seta Váriavel
                btnSalvar.Tag = grdListagem.CurrentRow.Cells("codigo").Value

                'Carrega Controles
                oClsCadOperacao.LoadDados(grdListagem.CurrentRow.Cells("codigo").Value,
                                          cboCentroTrabalho,
                                          cboGrupoOperacao,
                                          txtOperacao,
                                          txtDescricao,
                                          txtObservacao,
                                          cboTipo)

                'Alterna Aba
                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                cboCentroTrabalho.Enabled = False

                cboTipo.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCadOperacao.Codigo = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0)
            oClsCadOperacao.Operacao = txtOperacao.Text.Trim
            oClsCadOperacao.Descricao = txtDescricao.Text.Trim
            oClsCadOperacao.CentroTrabalho = cboCentroTrabalho.SelectedValue
            oClsCadOperacao.Observacao = txtObservacao.Text.Trim
            oClsCadOperacao.CodigoGrupoOperacao = IIf(cboGrupoOperacao.SelectedIndex = -1, -1, cboGrupoOperacao.SelectedValue)

            'Verifica o Tipo de Operação
            If IsNumeric(btnSalvar.Tag) Then
                oClsCadOperacao.Update()
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                oClsCadOperacao.Insert()
                frmMain.Informacao(Mensagem.RegistroInserido)
                btnSalvar.Tag = oClsCadOperacao.Codigo
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
            oClsCadOperacao.LoadGrid(grdListagem, _
                                     txtOperacaoFiltro.Text.Trim, _
                                     txtDescricaoFiltro.Text.Trim, _
                                     IIf(cboCentroTrabalhoFiltro.SelectedIndex = -1, -1, cboCentroTrabalhoFiltro.SelectedValue))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try
            If ValidaCampo(txtOperacao, lblOperacao, TipoCampo.texto) = False Then Return False

            If cboGrupoOperacao.Visible = True Then
                If ValidaCampo(cboGrupoOperacao, lblGrupoOperacao) = False Then Return False

            End If
            If cboCentroTrabalho.Visible = True Then
                If ValidaCampo(cboCentroTrabalho, lblCentroTrabalho) = False Then Return False

            End If
            If ValidaCampo(txtDescricao, lblDescricao, TipoCampo.texto) = False Then Return False

            If ValidaCampo(cboTipo, lblTipo) = False Then Return False

            'Valida se a Operação é válido
            If oClsCadOperacao.ValidaOperacao(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0),
                                              cboCentroTrabalho.SelectedValue,
                                              txtOperacao.Text.Trim) = False Then
                frmMain.errInfo.SetError(lblOperacao, "Esta Operação já está associado a outro Registro")
                txtDescricao.Focus()
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function



#End Region



End Class
