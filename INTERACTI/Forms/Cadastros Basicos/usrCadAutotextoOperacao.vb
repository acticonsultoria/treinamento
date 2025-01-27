Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX

Public Class usrCadAutotextoOperacao

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadAutotextoOperacao As New clsUsrCadAutotextoOperacao
    Private iFormulario As Integer = -1

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

    Private Sub usr_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: AUTOTEXTO :::"

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = iFormulario
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, iFormulario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

            Delete()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
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

            tabMain.TabPages.Remove(pagLista)
            tabMain.TabPages.Add(pagDados)

            Novo()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            frmMain.errInfo.Clear()

            If Validacao() = True Then

                Salvar()

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

            cboOperacaoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica o Tipo da Célula
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call Editar()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grd_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(sender, _
                                iFormulario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grd_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(sender.Name, _
                                iFormulario, _
                                e.Column.Key, _
                                e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grd_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            UpdateConfiguraGridGrupo(sender.Name, _
                                     iFormulario, _
                                     e.Group.Column.Key, _
                                     IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                     e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarOperacao_Click(sender As Object, e As EventArgs) Handles btnCadastrarOperacao.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadOperacao")

            LoadCombo(cboOperacao, "sp_select_combo_cadastro_basico_autotexto_operacao " & goUsuario.iEmpresa, True)

            cboOperacao.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
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
            iFormulario = LoadCodigo("sp_select_static_formulario_codigo_user_control '" & Me.Name & "'")

            iFormularioGrid = iFormulario

            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usr_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(iFormulario, gcDelete)
            btnNovo1.Enabled = VerificaDireito(iFormulario, gcInsert)
            btnNovo.Enabled = VerificaDireito(iFormulario, gcInsert)

            'Carrega Combo
            LoadCombo(cboOperacaoFiltro, "sp_select_combo_cadastro_basico_autotexto_operacao " & goUsuario.iEmpresa, True)
            LoadCombo(cboOperacao, "sp_select_combo_cadastro_basico_autotexto_operacao " & goUsuario.iEmpresa, True)
            LoadComboSimNao(cboAtivo)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, iFormulario)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            cboOperacaoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: AUTOTEXTO :::"

    Private Sub Editar()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(iFormulario, gcUpdate) = True Then

                Novo()

                'Carrega Controles
                cboOperacao.SelectedValue = grdListagem.CurrentRow.Cells("codigo_operacao").Value
                txtAutotexto.Text = grdListagem.CurrentRow.Cells("autotexto").Value
                txtDescricao.Text = grdListagem.CurrentRow.Cells("descricao").Value
                btnSalvar.Tag = grdListagem.CurrentRow.Cells("codigo").Value
                cboAtivo.SelectedValue = grdListagem.CurrentRow.Cells("ativo").Value

                'Alterna Aba
                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                cboOperacao.Focus()

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

                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    Cursor.Current = Cursors.WaitCursor

                    oClsCadAutotextoOperacao.Delete()

                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    Cursor.Current = Cursors.Default

                End If

            Else
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            frmMain.errInfo.Clear()

            LimparCamposGroupBox(grpDados)

            btnSalvar.Tag = ""
            cboAtivo.SelectedValue = True

            cboOperacao.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsCadAutotextoOperacao.Codigo = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0)
            oClsCadAutotextoOperacao.CodigoOperacao = cboOperacao.SelectedValue
            oClsCadAutotextoOperacao.Descricao = txtDescricao.Text.Trim
            oClsCadAutotextoOperacao.Autotexto = txtAutotexto.Text
            oClsCadAutotextoOperacao.Ativo = cboAtivo.SelectedValue

            If Len(btnSalvar.Tag) > 0 Then
                oClsCadAutotextoOperacao.Update()
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                oClsCadAutotextoOperacao.Insert()
                frmMain.Informacao(Mensagem.RegistroInserido)
                btnSalvar.Tag = oClsCadAutotextoOperacao.Codigo
            End If

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
            Call oClsCadAutotextoOperacao.LoadGrid(grdListagem, _
                                           IIf(cboOperacaoFiltro.SelectedIndex = -1, -1, cboOperacaoFiltro.SelectedValue), _
                                           txtDescricaoFiltro.Text.Trim)

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

            If ValidaCampo(cboOperacao, lblOperacao) = False Then
                Exit Function
            End If

            If ValidaCampo(txtDescricao, lblDescricao, TipoCampo.texto) = False Then
                Exit Function
            End If

            If oClsCadAutotextoOperacao.ValidaDescricao(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0), _
                                                        cboOperacao.SelectedValue, _
                                                        txtAutotexto.Text.Trim) = False Then
                frmMain.errInfo.SetError(lblDescricao, "Esta Descrição: " & txtDescricao.Text & " já está associado a outro Registro.")
                txtDescricao.Focus()
                Exit Function
            End If

            If ValidaCampo(cboAtivo, lblAtivo) = False Then
                Exit Function
            End If

            If ValidaCampo(txtAutotexto, lblAutotexto, TipoCampo.texto) = False Then
                Exit Function
            End If

            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

End Class
