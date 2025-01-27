Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports System.IO

Public Class usrCustApontamento

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCustApontamento As New clsUsrCustApontamento

    'Váriavel - Arquivo
    Dim sArquivoInteracti As String = LoadDescricao("sp_select_configuracao_interacti_pasta_arquivo " & goUsuario.iEmpresa)

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrCadMaquina_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

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

    Private Sub usrCadMaquina_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub
    Private Sub usrCadArea_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub
#End Region

#Region "::: MÁQUINA :::"

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
            oForm.NomeFormulario = Formulario.CadastroBasicoMaquinaEquipamento
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoMaquinaEquipamento)

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

            

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Célula clicada é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Editar()
                Case "visualizar" : Call VisualizarDocumentoBD(grdListagem.CurrentRow.Cells("arquivo").Value, grdListagem.CurrentRow.Cells("extensao").Value)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.CadastroBasicoMaquinaEquipamento, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.CadastroBasicoMaquinaEquipamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name, _
                                          Formulario.CadastroBasicoMaquinaEquipamento, _
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
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.ApontamentoCusto, gcDelete)
            btnNovo1.Enabled = VerificaDireito(Formulario.ApontamentoCusto, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.ApontamentoCusto, gcPrint)
           


            'Carrega Combo
            Call LoadCombo(cboFuncionario, "sp_select_combo_cadastro_basico_funcionario " & goUsuario.iEmpresa)
            Call LoadCombo(cboProjeto, "sp_select_combo_custo_projeto " & goUsuario.iEmpresa)
            Call LoadCombo(cboSubProjeto, "sp_select_combo_custo_sub_projeto " & goUsuario.iEmpresa)
            Call LoadCombo(cboProjetoFiltro, "sp_select_combo_custo_projeto " & goUsuario.iEmpresa)
            Call LoadCombo(cboSubProjetoFiltro, "sp_select_combo_custo_sub_projeto " & goUsuario.iEmpresa)
            Call LoadCombo(cboTipo, "sp_select_combo_custo_apontamento_tipo " & goUsuario.iEmpresa)
            'Call LoadComboSimNao(cboFuncionario)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoMaquinaEquipamento)
            


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: MÁQUINA :::"

    Private Sub Editar()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoMaquinaEquipamento, gcUpdate) = True Then

                'Limpa Formulário
                Call Novo()

                With grdListagem.CurrentRow.Cells

                    'Carrega Controles
                    txtMes.Text = .Item("mes").Value
                    btnSalvar.Tag = .Item("codigo").Value
                    txtObservacao.Text = .Item("observacao").Value
                    cboFuncionario.SelectedValue = .Item("codigo_funcionario").Value
                    cboProjeto.SelectedValue = .Item("projeto").Value
                    cboSubProjeto.SelectedValue = .Item("sub_projeto").Value
                    txtQtdHoras.Value = .Item("qtd_horas_apt").Value
                    txtSemana.Text = .Item("semana").Value
                    cboTipo.SelectedValue = .Item("tipo").Value
                    

                End With

                'Seta Aba
                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                txtMes.Focus()

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
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & iif(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsCustApontamento.Delete()

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
            cboFuncionario.SelectedIndex = -1
            txtSemana.Text = ""
            txtMes.Text = ""
            cboProjeto.SelectedIndex = -1
            cboSubProjeto.SelectedIndex = -1
            txtQtdHoras.Value = 0
            txtObservacao.Text = ""
            btnSalvar.Tag = ""
            cboTipo.SelectedIndex = -1

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCustApontamento.Codigo = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0)
            oClsCustApontamento.CodigoFuncionario = cboFuncionario.SelectedValue
            oClsCustApontamento.Semana = txtSemana.Value
            oClsCustApontamento.Mes = txtMes.Text
            oClsCustApontamento.Projeto = cboProjeto.Text
            oClsCustApontamento.SubProjeto = cboSubProjeto.Text
            oClsCustApontamento.QtdHoras = txtQtdHoras.Value
            oClsCustApontamento.Observacao = txtObservacao.Text
            oClsCustApontamento.Tipo = cboTipo.Text

            'Verifica o Tipo de Operação
            If IsNumeric(btnSalvar.Tag) Then
                Call oClsCustApontamento.Update()
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                Call oClsCustApontamento.Insert()
                frmMain.Informacao(Mensagem.RegistroInserido)
            End If

            'Seta Controle
            btnSalvar.Tag = oClsCustApontamento.Codigo

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
            Call oClsCustApontamento.LoadGrid(grdListagem, _
                                         txtFuncionarioFiltro.Text, _
                                         txtMesFiltro.Text.Trim, _
                                         cboProjetoFiltro.Text.Trim, _
                                         cboSubProjetoFiltro.Text)

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
            If ValidaCampo(cboFuncionario, lblFuncionario) = False Then
                Exit Function
            End If
            'Verifica se foi Preenchido o Campo - Código
            If ValidaCampo(txtSemana, lblSemana, TipoCampo.texto) = False Then
                Exit Function
            End If
            'Verifica se foi Selecionado o Campo - Ativo
            If ValidaCampo(cboProjeto, lblProjeto) = False Then
                Exit Function
            End If

            If ValidaCampo(cboSubProjeto, lblSubProjeto) = False Then
                Exit Function
            End If
            If ValidaCampo(txtQtdHoras, lblQtdHoras, TipoCampo.numero) = False Then
                Exit Function
            End If
            If ValidaCampo(cboTipo, lblTipo) = False Then
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

    Private Sub txtSemana_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSemana.ValueChanged
        Try
            txtMes.Text = CStr(LoadCodigo("sp_select_custo_mes " & txtSemana.Value))
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
End Class
