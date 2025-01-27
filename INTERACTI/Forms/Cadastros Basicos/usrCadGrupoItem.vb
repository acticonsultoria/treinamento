Imports Janus.Windows.EditControls

Public Class usrCadGrupoItem

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadGrupoItem As New clsUsrCadGrupoItem
    Private oGrupoPaiTreeView As UIComboBox

#End Region

#Region "::: CONTROLES :::"

#Region "::: GERAL :::"

    Private Sub usrCadGrupoItem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadTreeView() Else Control_Enter(sender)
                    
                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.name
                        Case "cboGrupoItemPai" : Call LoadCombo(cboGrupoItemPai, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadGrupoItem_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCadGrupoItem_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposicionar UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

#End Region

#Region "::: GRUPO DE ITEM :::"
    Private Sub btnDuplicarEstrutura_Click(sender As Object, e As EventArgs) Handles btnDuplicarEstrutura.Click
        Try
            DuplicarEstrutura()
            Novo()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
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

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            'Prepara Formulário para Inserção de um Novo Registro
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

                Call Editar(btnSalvar.Tag)

                'Carrega a TreeView
                Call LoadTreeView()

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

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click

        Try

            'Limpa TreeView
            trvMainGrupo.Nodes.Clear()

            'Carrega TreeView
            Call oClsCadGrupoItem.LoadTreeView(trvMainGrupo, _
                                               txtGrupoItemFiltro.Text.Trim)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub trvMain_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles trvMainGrupo.NodeMouseDoubleClick

        Try

            'Verifica se o Nó é válido
            If IsNothing(e.Node) = True Then Exit Sub

            'Editar Grupo de Item
            Call Editar(e.Node.Tag)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub
    Private Sub TreeView1_MouseDown(sender As Object, e As MouseEventArgs) Handles trvMainGrupo.MouseDown

        Try

            If e.Button = MouseButtons.Right Then
                ' Verifica se o nó está selecionado
                Dim nodeSelected As TreeNode = trvMainGrupo.GetNodeAt(e.X, e.Y)
                If nodeSelected IsNot Nothing Then
                    ' Selecione o nó clicado antes de exibir o menu de contexto
                    trvMainGrupo.SelectedNode = nodeSelected

                    ' Exibe um menu de contexto ou executa qualquer ação desejada
                    Dim contextMenu As New ContextMenuStrip()
                    Dim oMenuItem As New ToolStripMenuItem("Adicionar")
                    AddHandler oMenuItem.Click, AddressOf AdicionarAbaixo
                    contextMenu.Items.Add(oMenuItem)
                    contextMenu.Show(trvMainGrupo, e.Location)
                End If
            End If
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub AdicionarAbaixo(sender As Object, e As EventArgs)
        Try



            ' Exemplo de ação a ser executada quando o item de menu Excluir é clicado
            If trvMainGrupo.SelectedNode IsNot Nothing Then

                'Limpa os campos
                Novo()

                cboGrupoItemPai.SelectedValue = trvMainGrupo.SelectedNode.Tag
                cboGrupoItemPai.Enabled = False
                txtDescricao.Focus()

            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: GERAL :::"

    Private Sub ConfigurarUserControl()

        Try

            oGrupoPaiTreeView = cboGrupoItemPai
            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadGrupoItem_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.CadastroBasicoGrupoItem, gcDelete)
            btnNovo.Enabled = VerificaDireito(Formulario.CadastroBasicoGrupoItem, gcInsert)
            btnSalvar.Enabled = VerificaDireito(Formulario.CadastroBasicoGrupoItem, gcInsert)

            'Carrega TreeView
            Call LoadTreeView()

            'Carrega Combo
            Call LoadCombo(cboGrupoItemPai, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa, False)
            Call LoadComboSimNao(cboAtivo) : cboAtivo.SelectedValue = True

            LoadCombo(cboTipoPerfil, "sp_select_combo_cadastro_basico_tipo_perfil " & goUsuario.iEmpresa)
            LoadCombo(cboMaterial, "sp_select_combo_cadastro_basico_material " & goUsuario.iEmpresa)
            LoadCombo(cboTipoItemSPED, "sp_select_combo_static_tipo_item_sped_orcamento")

            'Seta Focu
            txtDescricao.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: GRUPO DE ITEM :::"
    Private Sub DuplicarEstrutura()
        Try
            If IsNumeric(btnSalvar.Tag) = False Then
                MsgBox("Salve o grupo antes!", vbExclamation)
                Exit Sub
            End If

            'Dim sInputBox As String = InputBox("Digite a descrição do grupo:", "Duplicar estrutura")

            'Envia 
            oClsCadGrupoItem.DuplicarEstrutura(btnSalvar.Tag,
                                               cboGrupoItemPai.SelectedValue)

            frmMain.Informacao("Estrutura duplicada com sucesso.", Color.Blue)

            'Carrega os dados
            LoadTreeView()


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Editar(ByVal iCodigoGrupoItem As Integer)

        Try

            'Verifica se o Usuário tem direito de Alterar Dados
            If VerificaDireito(Formulario.CadastroBasicoGrupoItem, gcUpdate) = True Then

                'Limpa Formulário
                Call Novo()

                'Bloqueia a edição do pai
                cboGrupoItemPai.Enabled = False

                'Seta Controles
                Call oClsCadGrupoItem.LoadControles(iCodigoGrupoItem,
                                                    txtCodigoGrupoItem,
                                                    txtDescricao,
                                                    txtSigla,
                                                    cboGrupoItemPai,
                                                    cboAtivo,
                                                    cboMaterial,
                                                    cboTipoPerfil,
                                                    cboTipoItemSPED)

                'Seta Controle
                btnSalvar.Tag = iCodigoGrupoItem

                'Seta Focu
                txtDescricao.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Delete()

        Try

            'Verifica se foi selecionado um ou mais registros
            If VerificaSelecaoNode(trvMainGrupo) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoNode.Count = 1, " ", "s ") & gSelecaoNode.Count & " registro" & IIf(gSelecaoNode.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCadGrupoItem.Delete()

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
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            LimparCamposGroupBox(grpDados)
            cboAtivo.SelectedValue = True
            cboGrupoItemPai.Enabled = True
            btnSalvar.Tag = ""
            'Carrega Combo
            'Call LoadCombo(cboGrupoItemPai, "sp_select_combo_cadastro_basico_grupo_item_unico " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboGrupoItemPai, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa, False)
            'Seta Focu
            txtDescricao.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica o Tipo de Operação
            If Len(btnSalvar.Tag) > 0 Then
                oClsCadGrupoItem.Update(iCodigo:=btnSalvar.Tag,
                                        sDescricao:=txtDescricao.Text.Trim,
                                        sSigla:=txtSigla.Text,
                                        bAtivo:=cboAtivo.SelectedValue,
                                        iCodigoGrupoItemPai:=IIf(cboGrupoItemPai.SelectedIndex = -1, -1, cboGrupoItemPai.SelectedValue),
                                        iCodigoMaterial:=IIf(cboMaterial.SelectedIndex = -1, -1, cboMaterial.SelectedValue),
                                        iCodigoTipoPerfil:=IIf(cboTipoPerfil.SelectedIndex = -1, -1, cboTipoPerfil.SelectedValue),
                                        iCodigoFamilia:=-1,
                                        iCodigoTipoItemSPED:=IIf(cboTipoItemSPED.SelectedIndex = -1, -1, cboTipoItemSPED.SelectedValue))
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                oClsCadGrupoItem.Insert(sDescricao:=txtDescricao.Text.Trim,
                                        sSigla:=txtSigla.Text,
                                        bAtivo:=cboAtivo.SelectedValue,
                                        iCodigoGrupoItemPai:=IIf(cboGrupoItemPai.SelectedIndex = -1, -1, cboGrupoItemPai.SelectedValue),
                                        iCodigoMaterial:=IIf(cboMaterial.SelectedIndex = -1, -1, cboMaterial.SelectedValue),
                                        iCodigoTipoPerfil:=IIf(cboTipoPerfil.SelectedIndex = -1, -1, cboTipoPerfil.SelectedValue),
                                        iCodigoFamilia:=-1,
                                        iCodigoTipoItemSPED:=IIf(cboTipoItemSPED.SelectedIndex = -1, -1, cboTipoItemSPED.SelectedValue))
                frmMain.Informacao(Mensagem.RegistroInserido)
                btnSalvar.Tag = oClsCadGrupoItem.Codigo
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
            trvMainGrupo.Nodes.Clear()

            'Seta Parametros
            Call oClsCadGrupoItem.LoadTreeView(trvMainGrupo, _
                                               txtGrupoItemFiltro.Text.Trim)

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

            'Verifica se foi Preenchido o Campo - CodigoBanco -- Solicitação Renato (6323)
            'If ValidaCampo(txtCodigoGrupoItem, lblCodigoGrupoItem, TipoCampo.texto) = False Then
            '    Exit Function
            'End If

            'Verifica se a CodigoBanco preenchida é válida
            If oClsCadGrupoItem.ValidaCodigoGrupoItem(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0), _
                                                      txtCodigoGrupoItem.Text.Trim) = False Then
                frmMain.errInfo.SetError(lblCodigoGrupoItem, "Este Código: " & txtCodigoGrupoItem.Text & " já está associado a outro Registro.")
                txtCodigoGrupoItem.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Descrição
            If ValidaCampo(txtDescricao, lblDescricao, TipoCampo.texto) = False Then
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
