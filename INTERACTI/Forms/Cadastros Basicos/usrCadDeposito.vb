Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX

Public Class usrCadDeposito

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadDeposito As New clsUsrCadDeposito

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrCadDeposito_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                    
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadDeposito_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

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
            oForm.NomeFormulario = Formulario.CadastroBasicoDeposito
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoDeposito)

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

        'Prepara o Formulário para Inserção de um Novo Registro
        Call Novo()

        'Alterna Aba
        tabMain.TabPages.Remove(pagLista)
        tabMain.TabPages.Add(pagDados)

        'Seta Focu
        txtDescricao.Focus()

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
                Call Editar(oClsCadDeposito.Codigo)

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

        'Seta Focu
        txtDescricaoFiltro.Focus()

        'Alterna Aba
        tabMain.TabPages.Remove(pagDados)
        tabMain.TabPages.Add(pagLista)

        'Seta Focu
        txtDescricaoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Linha pressionada é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Editar(grdListagem.CurrentRow.Cells("codigo").Value)

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
                                     Formulario.CadastroBasicoDeposito)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.CadastroBasicoDeposito, _
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
                                          Formulario.CadastroBasicoDeposito, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadDeposito_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.CadastroBasicoDeposito, gcDelete)
            btnNovo1.Enabled = VerificaDireito(Formulario.CadastroBasicoDeposito, gcInsert)
            btnSalvar.Enabled = VerificaDireito(Formulario.CadastroBasicoDeposito, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.CadastroBasicoDeposito, gcPrint)

            'Carrega Combo
            Call LoadComboSimNao(cboAtivo)
            Call LoadComboSimNao(cboQualidade)
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboProprietarioFiltro : oComboBox(1) = cboProprietario
            Call LoadCombo(oComboBox, "sp_select_combo_static_proprietario_deposito")
            oComboBox(0) = cboLocalFiltro : oComboBox(1) = cboLocal
            Call LoadCombo(oComboBox, "sp_select_combo_static_local_deposito")            

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoDeposito)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            txtDescricaoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Editar(lCodigo As Long)

        Try


            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoCondicaoPagamento, gcUpdate) = True Then

                'Limpa Formulário
                Call Novo()

                txtDescricao.Tag = lCodigo

                oClsCadDeposito.LoadDados(lCodigo,
                                          txtDescricao,
                                          cboProprietario,
                                          cboLocal,
                                          cboAtivo,
                                          cboQualidade)

                'Carrega Grid
                oClsCadDeposito.LoadGrid(grdListagem,
                                     txtDescricaoFiltro.Text.Trim,
                                     IIf(cboProprietarioFiltro.SelectedIndex = -1, -1, cboProprietarioFiltro.SelectedValue),
                                     IIf(cboLocalFiltro.SelectedIndex = -1, -1, cboLocalFiltro.SelectedValue))

                'Alterna Aba
                If tabMain.SelectedTab.Name <> pagDados.Name Then

                    'Alterna Aba
                    tabMain.TabPages.Remove(pagLista)
                    tabMain.TabPages.Add(pagDados)
                End If

                'Seta Focu
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

            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCadDeposito.Delete()

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
            txtDescricao.Text = ""
            txtDescricao.Tag = ""
            cboAtivo.SelectedIndex = -1
            cboProprietario.SelectedIndex = -1
            cboLocal.SelectedIndex = -1
            cboQualidade.SelectedIndex = -1

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

            'Seta Parametros
            oClsCadDeposito.Codigo = IIf(IsNumeric(txtDescricao.Tag), txtDescricao.Tag, 0)
            oClsCadDeposito.Descricao = txtDescricao.Text.Trim
            oClsCadDeposito.Proprietario = cboProprietario.SelectedValue
            oClsCadDeposito.Local = cboLocal.SelectedValue
            oClsCadDeposito.Ativo = cboAtivo.SelectedValue
            oClsCadDeposito.Qualidade = cboQualidade.SelectedValue

            'Verifica o Tipo de Operação
            If IsNumeric(txtDescricao.Tag) Then
                oClsCadDeposito.Update()
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                oClsCadDeposito.Insert()
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
            oClsCadDeposito.LoadGrid(grdListagem, _
                                     txtDescricaoFiltro.Text.Trim, _
                                     IIf(cboProprietarioFiltro.SelectedIndex = -1, -1, cboProprietarioFiltro.SelectedValue), _
                                     IIf(cboLocalFiltro.SelectedIndex = -1, -1, cboLocalFiltro.SelectedValue))

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

            'Verifica se foi Preenchido o Campo - Descrição
            If ValidaCampo(txtDescricao, lblDescricao, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se o Depósito é Válido
            If oClsCadDeposito.ValidaDescricao(IIf(IsNumeric(txtDescricao.Tag), txtDescricao.Tag, 0),
                                               txtDescricao.Text.Trim) = False Then
                frmMain.errInfo.SetError(lblDescricao, "Este Depósito: " & txtDescricao.Text & " já está associado a outro Registro.")
                txtDescricao.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Ativo
            If ValidaCampo(cboAtivo, lblAtivo) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Proprietário
            If ValidaCampo(cboProprietario, lblProprietario) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Local
            If ValidaCampo(cboLocal, lblLocal) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Qualidade
            If ValidaCampo(cboQualidade, lblQualidade) = False Then
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
