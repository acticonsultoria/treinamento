Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class usrCadCriterioAvaliacao

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsUsrCadCriterioAvaliacao As New clsUsrCadCriterioAvaliacao
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
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usr_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        ConfigurarUserControl()

    End Sub

    Private Sub usr_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona Formulário
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub grd_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved, _
                                                                                                                       grdOpcao.ColumnMoved

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(sender, _
                                iFormulario)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn, _
                                                                                                                        grdOpcao.SizingColumn

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(sender.Name, _
                                iFormulario, _
                                e.Column.Key, _
                                e.ProposedWidth)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

#Region "::: CRITÉRIO DE AVALIAÇÃO :::"

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

            'Prepara o Formulário para Inserção de um Novo Registro
            Novo()

            'Alterna Aba
            tabMain.TabPages.Remove(pagLista)
            tabMain.TabPages.Add(pagDados)

            txtDescricao.Focus()

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
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        Try

            'Carrega Grid
            LoadGrid()

            'Alterna Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagLista)

            txtDescricaoFiltro.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica o Tipo de Linha
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Editar()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

#Region "::: CRITÉRIO DE AVALIAÇÃO - OPÇÃO :::"

    Private Sub btnInserirOpcao_Click(sender As Object, e As EventArgs) Handles btnInserirOpcao.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = False Or ValidacaoOpcao() = False Then Exit Sub

            Salvar()
            SalvarOpcao()
            LoadGridOpcao()
            NovoOpcao()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnExcluirOpcao_Click(sender As Object, e As EventArgs) Handles btnExcluirOpcao.Click

        Try

            DeleteOpcao()
            NovoOpcao()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdOpcao_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdOpcao.RowDoubleClick

        Try

            'Verifica o Tipo de Linha
            If IsNothing(grdOpcao.CurrentColumn) Then Exit Sub

            Select Case grdOpcao.CurrentColumn.Key

                Case "editar" : EditarOpcao()

            End Select

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

            iFormulario = LoadCodigo("sp_select_static_formulario_codigo_user_control '" & Me.Name & "'")

            'Adiciona KeyUP
            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf usr_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(iFormulario, gcDelete)
            btnNovo.Enabled = VerificaDireito(iFormulario, gcInsert)
            btnNovo1.Enabled = VerificaDireito(iFormulario, gcInsert)

            LoadComboSimNao(cboAtivo)
            LoadComboSimNao(cboNaoAplicavel)
            LoadComboSimNao(cboAtivoOpcao)
            LoadCombo(cboTipoCriterio, "sp_select_combo_static_tipo_criterio_avaliacao", False)

            'Configura Grid
            ConfiguraGrid(grdListagem, iFormulario)
            ConfiguraGrid(grdOpcao, iFormulario)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            txtDescricaoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

#Region "::: CRITÉRIO DE AVALIAÇÃO :::"

    Private Sub Editar()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(iFormulario, gcUpdate) = True Then

                Novo()

                With grdListagem.CurrentRow.Cells

                    'Carrega Controles
                    txtDescricao.Text = .Item("descricao").Value
                    cboTipoCriterio.SelectedValue = .Item("codigo_tipo_criterio_avaliacao").Value
                    cboAtivo.SelectedValue = .Item("ativo").Value
                    btnSalvar.Tag = .Item("codigo").Value

                End With

                LoadGridOpcao()

                'Alterna Aba
                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                txtDescricao.Focus()

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

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsUsrCadCriterioAvaliacao.Delete()

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
            LimparCamposGroupBox(grpOpcao)

            grdOpcao.DataSource = Nothing

            btnSalvar.Tag = ""
            btnInserirOpcao.Tag = ""

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
            If IsNumeric(btnSalvar.Tag) Then

                oClsUsrCadCriterioAvaliacao.Update(btnSalvar.Tag, _
                                                   txtDescricao.Text.Trim, _
                                                   cboTipoCriterio.SelectedValue, _
                                                   cboAtivo.SelectedValue)

                frmMain.Informacao(Mensagem.RegistroAlterado)

            Else

                oClsUsrCadCriterioAvaliacao.Insert(txtDescricao.Text.Trim, _
                                                   cboTipoCriterio.SelectedValue, _
                                                   cboAtivo.SelectedValue)

                btnSalvar.Tag = oClsUsrCadCriterioAvaliacao.Codigo

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
            oClsUsrCadCriterioAvaliacao.LoadGrid(grdListagem, _
                                                 txtDescricaoFiltro.Text.Trim)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            If ValidaCampo(txtDescricao, lblDescricao, TipoCampo.texto) = False Then Return False
            If ValidaCampo(cboTipoCriterio, lblTipoCriterio) = False Then Return False
            If ValidaCampo(cboAtivo, lblAtivo) = False Then Return False

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: CRITÉRIO DE AVALIAÇÃO - OPÇÃO :::"

    Private Function ValidacaoOpcao() As Boolean

        Try

            If ValidaCampo(txtDescricaoOpcao, lblDescricaoOpcao, TipoCampo.texto) = False Then Return False
            If ValidaCampo(txtNota, lblNota, True) = False Then Return False
            If ValidaCampo(cboNaoAplicavel, lblNaoAplicavel) = False Then Return False
            If ValidaCampo(cboAtivoOpcao, lblAtivoOpcao) = False Then Return False

            If oClsUsrCadCriterioAvaliacao.ValidaOpcao(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0), _
                                                       IIf(IsNumeric(btnInserirOpcao.Tag), btnInserirOpcao.Tag, 0), _
                                                       txtDescricaoOpcao.Text.Trim) = False Then
                MsgBox("Esta opção já está cadastrada!", MsgBoxStyle.Exclamation, "Validação")
                txtDescricaoOpcao.Focus()
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub SalvarOpcao()

        Try

            Cursor.Current = Cursors.WaitCursor

            If IsNumeric(btnInserirOpcao.Tag) Then

                oClsUsrCadCriterioAvaliacao.UpdateOpcao(btnSalvar.Tag, _
                                                        btnInserirOpcao.Tag, _
                                                        txtDescricaoOpcao.Text.Trim, _
                                                        txtNota.Value, _
                                                        cboNaoAplicavel.SelectedValue, _
                                                        cboAtivoOpcao.SelectedValue)

                frmMain.Informacao(Mensagem.RegistroSalvo)

            Else

                oClsUsrCadCriterioAvaliacao.InsertOpcao(btnSalvar.Tag, _
                                                        txtDescricaoOpcao.Text.Trim, _
                                                        txtNota.Value, _
                                                        cboNaoAplicavel.SelectedValue, _
                                                        cboAtivoOpcao.SelectedValue)

                frmMain.Informacao(Mensagem.RegistroInserido)

            End If

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridOpcao()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsUsrCadCriterioAvaliacao.LoadGridOpcao(grdOpcao, _
                                                      btnSalvar.Tag)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoOpcao()

        Try

            LimparCamposGroupBox(grpOpcao)
            btnInserirOpcao.Tag = ""

            txtDescricaoOpcao.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteOpcao()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdOpcao) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsUsrCadCriterioAvaliacao.DeleteOpcao(btnSalvar.Tag)

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

    Private Sub EditarOpcao()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(iFormulario, gcUpdate) = True Then

                NovoOpcao()

                With grdOpcao.CurrentRow.Cells

                    'Carrega Controles
                    txtDescricaoOpcao.Text = .Item("descricao").Value
                    txtNota.Value = .Item("nota").Value
                    cboNaoAplicavel.SelectedValue = .Item("nao_aplicavel").Value
                    cboAtivoOpcao.SelectedValue = .Item("ativo").Value
                    btnInserirOpcao.Tag = .Item("codigo").Value

                End With

                txtDescricaoOpcao.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class
