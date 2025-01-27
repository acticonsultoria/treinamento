Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX

Public Class usrCadEquipe

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadEquipe As New clsUsrCadEquipe

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrCadEquipe_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGridEquipe() Else Control_Enter(sender)
                    
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadEquipe_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCadEquipe_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

#End Region

#Region "::: EQUIPE :::"

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
            oForm.NomeFormulario = Formulario.CadastroBasicoEquipe
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoEquipe)

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
            Call DeleteEquipe()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Dados da Grid
            Call LoadGridEquipe()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            'Prepara Formulário para Inserção de um Novo Registro
            Call NovoEquipe()

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
            Call NovoEquipe()

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
            If ValidacaoEquipe() = True Then

                'Salva Dados do Registro
                Call SalvarEquipe()
                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoEquipe()

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
            Call LoadGridEquipe()

            'Alterna Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagLista)

            'Seta Focu
            txtCodigoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call EditarEquipe()

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
                                     Formulario.CadastroBasicoEquipe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.CadastroBasicoEquipe, _
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
                                          Formulario.CadastroBasicoEquipe, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCIONÁRIO :::"

    Private Sub btnAgruparGridFuncionario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridFuncionario.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdFuncionario.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdFuncionario.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdFuncionario.GroupByBoxVisible = True
                grdFuncionario.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridFuncionario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridFuncionario.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdFuncionario
            oForm.NomeFormulario = Formulario.CadastroBasicoEquipe
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdFuncionario, Formulario.CadastroBasicoEquipe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridFuncionario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridFuncionario.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdFuncionario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirFuncionario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirFuncionario.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados da Equipe
            If ValidacaoEquipe() = True Then

                'Salva Dados da Equipe
                Call SalvarEquipe()

                'Valida Dados da Funcionario
                If ValidacaoFuncionario() = True Then
                    'Salva Dados do Funcionário - Equipe
                    Call SalvarFuncionario()
                    'Carrega Funcionario
                    Call LoadGridFuncionario()
                    'Prepara Formulário para Inserção de um Novo Registro
                    Call NovoFuncionario()
                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirFuncionario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirFuncionario.Click

        Try

            'Deleta Registros
            Call DeleteFuncionario()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdFuncionario_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdFuncionario.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdFuncionario.CurrentColumn) Then Exit Sub

            Select Case grdFuncionario.CurrentColumn.Key

                Case "editar" : Call EditarFuncionario()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdFuncionario_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdFuncionario.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdFuncionario, _
                                     Formulario.CadastroBasicoEquipe)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdFuncionario_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdFuncionario.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdFuncionario.Name, _
                                     Formulario.CadastroBasicoEquipe, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdFuncionario_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdFuncionario.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdFuncionario.Name, _
                                          Formulario.CadastroBasicoEquipe, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadEquipe_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.CadastroBasicoEquipe, gcDelete)
            btnNovo1.Enabled = VerificaDireito(Formulario.CadastroBasicoEquipe, gcInsert)
            btnSalvar.Enabled = VerificaDireito(Formulario.CadastroBasicoEquipe, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.CadastroBasicoEquipe, gcPrint)
            btnInserirFuncionario.Enabled = VerificaDireito(Formulario.CadastroBasicoEquipe, gcInsert)
            btnExcluirFuncionario.Enabled = VerificaDireito(Formulario.CadastroBasicoEquipe, gcDelete)
            btnExcelGridFuncionario.Enabled = VerificaDireito(Formulario.CadastroBasicoEquipe, gcPrint)

            'Verifica Direito - Botão Cadastrar
            btnCadastrarFuncionario.Enabled = VerificaDireito(Formulario.CadastroBasicoFuncionario, gcInsert)

            'Carrega Combo
            Call LoadCombo(cboFuncionario, "sp_select_combo_cadastro_basico_funcionario " & goUsuario.iEmpresa, False)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoEquipe)
            Call ConfiguraGrid(grdFuncionario, Formulario.CadastroBasicoEquipe)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            txtCodigoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: REGIÃO :::"

    Private Sub DeleteEquipe()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCadEquipe.DeleteEquipe()

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

    Private Sub NovoEquipe()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Insere Equipe
            Call oClsCadEquipe.InsertEquipe()

            'Limpa Controles - Equipe
            btnSalvar.Tag = oClsCadEquipe.Codigo
            txtCodigo.Text = ""
            txtDescricao.Text = ""
            cboAtivo.SelectedValue = True

            'Limpa Controles - Municipio
            cboFuncionario.SelectedIndex = -1
            btnInserirFuncionario.Tag = ""
            grdFuncionario.DataSource = Nothing

            'Seta Focu
            txtCodigo.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarEquipe()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoEquipe, gcUpdate) = True Then

                'Seta Controles
                txtCodigo.Text = grdListagem.CurrentRow.Cells("codigo_equipe").Value
                txtDescricao.Text = grdListagem.CurrentRow.Cells("descricao").Value
                cboAtivo.SelectedValue = grdListagem.CurrentRow.Cells("ativo").Value
                btnSalvar.Tag = grdListagem.CurrentRow.Cells("codigo").Value

                'Carrega Grid - Funcionário
                Call LoadGridFuncionario()

                'Alterna Aba
                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                txtCodigo.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarEquipe()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCadEquipe.Codigo = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0)
            oClsCadEquipe.CodigoEquipe = txtCodigo.Text.Trim
            oClsCadEquipe.Descricao = txtDescricao.Text.Trim
            oClsCadEquipe.Ativo = cboAtivo.SelectedValue

            'Verifica o Tipo de Operação
            If IsNumeric(btnSalvar.Tag) Then
                oClsCadEquipe.UpdateEquipe()
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                oClsCadEquipe.InsertEquipe()
                btnSalvar.Tag = oClsCadEquipe.Codigo
                frmMain.Informacao(Mensagem.RegistroInserido)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridEquipe()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCadEquipe.LoadGridEquipe(grdListagem, _
                                         txtCodigoFiltro.text.trim, _
                                         txtDescricaoFiltro.Text.Trim)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoEquipe() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoEquipe = False

            'Verifica se foi Preenchido o Campo - Código
            If ValidaCampo(txtCodigo, lblCodigo, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Valida se o Código é Válido
            If oClsCadEquipe.ValidaCodigo(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0), _
                                          txtDescricao.Text.Trim) = False Then
                frmMain.errInfo.SetError(lblCodigo, "Este Código já está associado a outro Registro")
                txtCodigo.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Descrição
            If ValidaCampo(txtDescricao, lblDescricao, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Ativo
            If ValidaCampo(cboAtivo, lblAtivo) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoEquipe = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: FUNCIONÁRIO :::"

    Private Sub DeleteFuncionario()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdFuncionario) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCadEquipe.DeleteFuncionario()

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

    Private Sub NovoFuncionario()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            cboFuncionario.SelectedIndex = -1
            btnInserirFuncionario.Tag = ""

            'Seta Focu
            cboFuncionario.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarFuncionario()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoEquipe, gcUpdate) = True Then

                'Seta Controles
                cboFuncionario.SelectedValue = grdFuncionario.CurrentRow.Cells("codigo_funcionario").Value
                btnInserirFuncionario.Tag = grdFuncionario.CurrentRow.RowIndex

                'Seta Focu
                cboFuncionario.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarFuncionario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirFuncionario.Tag) Then

                'Atualiza Funcionário
                Call oClsCadEquipe.UpdateFuncionario(cboFuncionario.SelectedValue, _
                                                     grdFuncionario.CurrentRow.Cells("codigo_funcionario").Value)

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroAlterado)

            Else

                'Insere Funcionário
                oClsCadEquipe.InsertFuncionario(cboFuncionario.SelectedValue)

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroInserido)

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridFuncionario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid
            oClsCadEquipe.LoadGridFuncionario(grdFuncionario, _
                                              grdListagem.CurrentRow.Cells("codigo").Value)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoFuncionario() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoFuncionario = False

            'Verifica se foi Preenchido o Campo - Descrição Feriado
            If ValidaCampo(cboFuncionario, lblFuncionario) = False Then
                Exit Function
            End If

            'Verifica se o Funcionário já foi Inserido
            Dim iRow As Integer = -1

            If IsNumeric(btnInserirFuncionario.Tag) Then
                iRow = grdFuncionario.CurrentRow.RowIndex
            End If

            If VerificaExisteValorGrid(grdFuncionario, "codigo_funcionario", cboFuncionario.SelectedValue, iRow) = True Then
                frmMain.errInfo.SetError(lblFuncionario, "Este Funcionário: " & cboFuncionario.Text & " já se encontra cadastrado.")
                cboFuncionario.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoFuncionario = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

End Class
