Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Math

Public Class usrManPreventiva

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsManPreventiva As New clsUsrManPreventiva

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrManPreventiva_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                    
                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboManutencao" : LoadCombo(cboManutencao, "sp_select_combo_cadastro_basico_manutencao " & goUsuario.iEmpresa, True)
                        Case "cboManutencaoFiltro" : LoadCombo(cboManutencaoFiltro, "sp_select_combo_cadastro_basico_manutencao " & goUsuario.iEmpresa, True)
                        Case "cboArea" : Call cboManutencao_SelectedIndexChanged(cboManutencao, System.EventArgs.Empty)
                        Case "cboAreaFiltro" : LoadCombo(cboAreaFiltro, "sp_select_combo_cadastro_basico_area " & goUsuario.iEmpresa, True)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboManutencao" : Call btnCadastrarManutencao_Click(btnCadastrarManutencao, System.EventArgs.Empty)
                        Case "cboArea" : Call btnCadastrarArea_Click(btnCadastrarArea, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrManPreventiva_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: PREVENTIVA :::"

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
            oForm.NomeFormulario = Formulario.ManutencaoPreventiva
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ManutencaoPreventiva)

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

    Private Sub btnCadastrarManutencao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarManutencao.Click

        Try


            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadManutencao")

            'Carrega Combo            
            Call LoadCombo(cboManutencao, "sp_select_combo_cadastro_basico_manutencao " & goUsuario.iEmpresa, True)

            'Seta Focu
            cboManutencao.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarArea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarArea.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadArea")

            'Carrega Combo            
            Call cboManutencao_SelectedIndexChanged(cboManutencao, System.EventArgs.Empty)

            'Seta Focu
            cboArea.Focus()

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
            tabMain.TabPages.Add(pagDados)
            tabMain.TabPages.Remove(pagListagem)

            'Seta Focu
            cboManutencao.Focus()

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

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            'Prepara o Formulário para Inserção de um Novo Registro
            Call Novo()

            'Seta Focu        
            cboManutencao.Focus()

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

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call Salvar()

            End If

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
            tabMain.TabPages.Add(pagListagem)

            'Seta Focu
            cboManutencaoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboManutencao_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboManutencao.SelectedIndexChanged

        Try

            'Verifica se Foi Selecionado algum Registro
            If cboManutencao.SelectedIndex = -1 Then
                'Limpa Controle
                cboArea.DataSource = Nothing : cboArea.Text = ""
            Else
                'Carrega Combo            
                Call LoadCombo(cboArea, "sp_select_combo_cadastro_basico_area_manutencao " & goUsuario.iEmpresa & ", " & cboManutencao.SelectedValue)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Célula é Válida
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
                                     Formulario.ManutencaoPreventiva)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.ManutencaoPreventiva, _
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
                                          Formulario.ManutencaoPreventiva, _
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrManPreventiva_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnNovo.Enabled = VerificaDireito(Formulario.ManutencaoPreventiva, gcInsert)
            btnNovo1.Enabled = VerificaDireito(Formulario.ManutencaoPreventiva, gcInsert)
            btnSalvar.Enabled = VerificaDireito(Formulario.ManutencaoPreventiva, gcUpdate)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.ManutencaoPreventiva, gcPrint)

            'Verifica Direito - Botão de Cadastro
            btnCadastrarManutencao.Enabled = VerificaDireito(Formulario.CadastroBasicoManutencao, gcInsert)
            btnCadastrarArea.Enabled = VerificaDireito(Formulario.CadastroBasicoArea, gcInsert)

            'Carrega ComboBox        
            Call LoadCombo(cboManutencao, "sp_select_combo_cadastro_basico_manutencao " & goUsuario.iEmpresa)
            Call LoadCombo(cboManutencaoFiltro, "sp_select_combo_cadastro_basico_manutencao " & goUsuario.iEmpresa)
            Call LoadCombo(cboAreaFiltro, "sp_select_combo_cadastro_basico_area " & goUsuario.iEmpresa)
            
            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ManutencaoPreventiva)

            'Seta Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            cboManutencaoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: PREVENTIVA :::"

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            cboManutencao.Text = ""
            cboArea.Text = ""
            txtComplemento.Text = ""
            btnSalvar.Tag = ""
            txtRecorrencia.Value = 0

            'Seta Focu
            cboManutencao.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Delete()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsManPreventiva.Delete()

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

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Controles
            oClsManPreventiva.LoadGrid(grdListagem, _
                                       IIf(cboManutencaoFiltro.SelectedIndex = -1, -1, cboManutencaoFiltro.SelectedValue), _
                                       IIf(cboAreaFiltro.SelectedIndex = -1, -1, cboAreaFiltro.SelectedValue))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.ManutencaoPreventiva, gcUpdate) = True Then

                'Carrega Controles
                cboManutencao.SelectedValue = grdListagem.CurrentRow.Cells("codigo_manutencao").Value
                cboArea.SelectedValue = grdListagem.CurrentRow.Cells("codigo_area").Value
                txtComplemento.Text = grdListagem.CurrentRow.Cells("complemento").Value
                txtRecorrencia.Value = grdListagem.CurrentRow.Cells("recorrencia").Value
                btnSalvar.Tag = grdListagem.CurrentRow.Cells("codigo").Value

                'Alterna Aba
                tabMain.TabPages.Remove(pagListagem)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                cboManutencao.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parâmentros
            oClsManPreventiva.Codigo = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1)
            oClsManPreventiva.CodigoManutencao = cboManutencao.SelectedValue
            oClsManPreventiva.CodigoArea = cboArea.SelectedValue
            oClsManPreventiva.Complemento = txtComplemento.Text.Trim
            oClsManPreventiva.Recorrencia = txtRecorrencia.Value

            'Verifica o Tipo de Operação
            If IsNumeric(btnSalvar.Tag) = False Then
                'Insere Registro
                oClsManPreventiva.Insert()
                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroInserido)
            Else
                'Atualiza Registro
                oClsManPreventiva.Update()
                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroAlterado)
            End If

            'Limpa Formulário
            Call Novo()

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

            'Verifica se foi Selecionado o Campo - Manutencao
            If ValidaCampo(cboManutencao, lblManutencao) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Área
            If ValidaCampo(cboArea, lblArea) = False Then
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


