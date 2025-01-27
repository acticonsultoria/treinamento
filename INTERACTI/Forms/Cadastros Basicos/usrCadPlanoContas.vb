Public Class usrCadPlanoContas

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsUsrCadPlanoContas As New clsUsrCadPlanoContas
    Private oNode As TreeNode

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrCadPlanoContas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadTreeView() Else Control_Enter(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrCadPlanoContas_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega TreeView
            Call LoadTreeView()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Exclui Registro
            Call Delete()

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
            If Validacao() = False Then Exit Sub

            Salvar()
            Novo()
            LoadTreeView()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Deleta Aba
        If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
        'Fecha o Controle
        Me.Dispose()

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

    Private Sub cboOrigem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOrigem.SelectedIndexChanged

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Conta Contabil Superior
            LoadCombo(cboItemSuperior, "sp_select_combo_cadastro_basico_plano_contas_item_superior " & goUsuario.iEmpresa & ", '" & cboOrigem.SelectedValue & "'")

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub trvMain_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles trvMain.AfterSelect

        Try

            'Verifica se pode Atualizar
            If e.Node.ForeColor <> Color.ForestGreen Then
                Call Editar(e.Node.Tag)
                oNode = e.Node
            Else
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Está Conta não pode ser editada.")
                Call Novo()
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
            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadPlanoContas_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnSalvar.Enabled = VerificaDireito(Formulario.CadastroBasicoPlanoContas, gcInsert)
            btnNovo.Enabled = VerificaDireito(Formulario.CadastroBasicoPlanoContas, gcInsert)
            btnExcluir.Enabled = VerificaDireito(Formulario.CadastroBasicoPlanoContas, gcDelete)

            'Carrega ComboBox
            LoadCombo(cboOrigem, "sp_select_combo_cadastro_basico_plano_contas_origem " & goUsuario.iEmpresa)
            LoadCombo(cboCFOP, "sp_select_combo_cadastro_basico_cfop " & goUsuario.iEmpresa)
            LoadComboSimNao(cboAtivo)

            'Carrega Plano de Contas
            LoadTreeView()

            'Limpa Formulário
            Novo()

            cboOrigem.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Delete()

        Try

            'Verifica se foi selecionado um ou mais registros
            If VerificaSelecaoNode(trvMain) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoNode.Count = 1, " ", "s ") & gSelecaoNode.Count & " registro" & IIf(gSelecaoNode.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsUsrCadPlanoContas.Delete()

                    'Limpa Formulário
                    Call Novo()

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

            'Limpa Controles
            cboOrigem.SelectedIndex = -1
            cboItemSuperior.Text = ""
            txtContaContabil.Text = ""
            txtContaContabil.Tag = ""
            txtCodigoIntegracao.Text = ""
            cboAtivo.SelectedValue = True
            txtNomeConta.Text = ""
            oNode = Nothing
            cboCFOP.SelectedIndex = -1
            trvMain.SelectedNode = Nothing

            'Seta Focu
            cboOrigem.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsUsrCadPlanoContas.Codigo = txtContaContabil.Tag
            oClsUsrCadPlanoContas.CodigoContaContabilOrigem = IIf(cboOrigem.SelectedIndex = -1, -1, cboOrigem.SelectedValue)
            oClsUsrCadPlanoContas.CodigoContaContabil = IIf(cboItemSuperior.SelectedIndex = -1, -1, cboItemSuperior.SelectedValue)
            oClsUsrCadPlanoContas.CodigoIntegracao = txtCodigoIntegracao.Text.Trim
            oClsUsrCadPlanoContas.ContaContabil = txtContaContabil.Text.Trim
            oClsUsrCadPlanoContas.Ativo = cboAtivo.SelectedValue
            oClsUsrCadPlanoContas.NomeConta = txtNomeConta.Text.Trim
            oClsUsrCadPlanoContas.CodigoCFOP = IIf(cboCFOP.SelectedIndex = -1, -1, cboCFOP.SelectedValue)

            'Verifica o Tipo de Operação
            If Len(txtContaContabil.Tag) > 0 Then
                oClsUsrCadPlanoContas.Update(trvMain)
                oNode.Remove()
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                oClsUsrCadPlanoContas.Insert(trvMain)
                frmMain.Informacao(Mensagem.RegistroInserido)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadTreeView()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa TreeView
            trvMain.Nodes.Clear()

            'Carrega TreeView
            Call oClsUsrCadPlanoContas.LoadTreeView(trvMain, _
                                                    txtContaContabilFiltro.Text.Trim)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar(ByVal sContaContabil As String)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Controles
            oClsUsrCadPlanoContas.LoadDadosContaContabil(sContaContabil, _
                                                         txtContaContabil, _
                                                         txtCodigoIntegracao, _
                                                         txtNomeConta, _
                                                         cboOrigem, _
                                                         cboItemSuperior, _
                                                         cboAtivo, _
                                                         cboCFOP)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Verifica se foi Preenchido o Campo - Conta Contábil
            If ValidaCampo(txtContaContabil, lblContaContabil, TipoCampo.texto) = False Then Return False

            'Verifica se o Código Banco ja foi cadastrado
            If oClsUsrCadPlanoContas.ValidaCodigoContaContabil(txtContaContabil.Tag, _
                                                               txtContaContabil.Text.Trim) = False Then
                frmMain.errInfo.SetError(lblContaContabil, "Este Código: " & txtContaContabil.Text & " já está associado a outro Registro.")
                txtContaContabil.Focus()
                Return False
            End If

            'Verifica se foi Selecionado o Campo - Ativo
            If ValidaCampo(cboAtivo, lblAtivo) = False Then Return False

            'Verifica se foi Preenchido o Campo - Nome da Conta
            If ValidaCampo(txtNomeConta, lblNomeConta, TipoCampo.texto) = False Then Return False

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region
    
End Class
