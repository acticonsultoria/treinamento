Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Math

Public Class usrManRequisicaoAprovar

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsManRequisicaoAprovar As New clsUsrManRequisicaoAprovar

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrManRequisicaoAprovar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

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

    Private Sub usrManRequisicaoAprovar_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: APROVAR / REPROVAR :::"

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
            oForm.NomeFormulario = Formulario.ManutencaoRequisicaoAprovar
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ManutencaoRequisicaoAprovar)

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

    Private Sub btnAprovar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAprovar.Click

        Try

            'Verifica se foi Selecionado algum valor válido
            If VerificaSelecaoRowDiferente(grdListagem, "status", CInt(StatusRequisicaoManutencao.AguardandoOrdemServico)) = True Then

                'Verifica se o Usuário deseja Aprovar a Requisição
                If MsgBox("Deseja Aprovar o(s) Registro(s) Selecionado(s)?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Aprova Requisição
                    oClsManRequisicaoAprovar.AprovarRequisicao()

                    'Carrega Grid
                    Call LoadGrid()

                End If

            Else
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Status da Requisição")
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnReprovar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReprovar.Click

        Try

            'Verifica se foi Selecionado algum valor válido
            If VerificaSelecaoRowDiferente(grdListagem, "status", CInt(StatusRequisicaoManutencao.Reprovada)) = True Then

                'Váriaveis - Formulário
                Dim oForm As New frmManRequisicaoReprovar

                'Seta Parâmetros
                Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                'Carrega Grid
                Call LoadGrid()

            Else
                 frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Status da Requisição")
            End If

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
            txtNumeroRequisicaoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCongelarColuna_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCongelarColuna.SelectedIndexChanged

        Try

            If cboCongelarColuna.SelectedIndex = -1 Then
                grdListagem.FrozenColumns = 3
            Else
                grdListagem.FrozenColumns = cboCongelarColuna.SelectedValue
            End If

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
                Case "arquivo" : Call ListaArquivo("tb_man_requisicao", grdListagem.CurrentRow.Cells("codigo_requisicao").Value)
                Case "historico" : Call Historico()

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
                                     Formulario.ManutencaoRequisicaoAprovar)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.ManutencaoRequisicaoAprovar, _
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
                                          Formulario.ManutencaoRequisicaoAprovar, _
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrManRequisicaoAprovar_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnReprovar.Enabled = VerificaDireito(Formulario.ManutencaoRequisicaoAprovar, gcAdministrator)
            btnAprovar.Enabled = VerificaDireito(Formulario.ManutencaoRequisicaoAprovar, gcAdministrator)
            btnSalvar.Enabled = VerificaDireito(Formulario.ManutencaoRequisicaoAprovar, gcUpdate)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.ManutencaoRequisicaoAprovar, gcPrint)

            'Verifica Direito - Botão de Cadastro
            btnCadastrarManutencao.Enabled = VerificaDireito(Formulario.CadastroBasicoManutencao, gcInsert)
            btnCadastrarArea.Enabled = VerificaDireito(Formulario.CadastroBasicoArea, gcInsert)
            
            'Carrega ComboBox        
            Call LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_requisicao_compras_aprovar")
            Call LoadCombo(cboRequisitanteFiltro, "sp_select_combo_administracao_usuario " & goUsuario.iEmpresa)
            Call LoadCombo(cboManutencao, "sp_select_combo_cadastro_basico_manutencao " & goUsuario.iEmpresa)
            Call LoadCombo(cboManutencaoFiltro, "sp_select_combo_cadastro_basico_manutencao " & goUsuario.iEmpresa)
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

            'Configura DateTimer
            dtpDataRequisicaoInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataRequisicaoInicioFiltro.Checked = False
            dtpDataRequisicaoTerminoFiltro.Value = Now.Date : dtpDataRequisicaoTerminoFiltro.Checked = False

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ManutencaoRequisicaoAprovar)

            'Seta Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            txtNumeroRequisicaoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: APROVAR / REPROVAR :::"

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim sRequisitante As String = ""
            Dim sStatus As String = ""
            Dim i As Integer

            'Requisitante
            If cboRequisitanteFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboRequisitanteFiltro.CheckedValues)
                    sRequisitante &= IIf(sRequisitante = "", "", ",") & cboRequisitanteFiltro.CheckedValues(i).ToString
                Next
            End If

            'Status
            If cboStatusFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboStatusFiltro.CheckedValues)
                    sStatus &= IIf(sStatus = "", "", ",") & cboStatusFiltro.CheckedValues(i).ToString
                Next
            End If

            'Carrega Controles
            oClsManRequisicaoAprovar.LoadGrid(grdListagem, _
                                              IIf(IsNumeric(txtNumeroRequisicaoFiltro.Text.Trim), txtNumeroRequisicaoFiltro.Text.Trim, -1), _
                                              sRequisitante, _
                                              IIf(dtpDataRequisicaoInicioFiltro.Checked = False, "", dtpDataRequisicaoInicioFiltro.Value), _
                                              IIf(dtpDataRequisicaoTerminoFiltro.Checked = False, "", dtpDataRequisicaoTerminoFiltro.Value), _
                                              IIf(cboManutencaoFiltro.SelectedIndex = -1, -1, cboManutencaoFiltro), _
                                              sStatus)

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
            If VerificaDireito(Formulario.ManutencaoRequisicaoAprovar, gcUpdate) = True Then

                'Carrega Controles
                Call oClsManRequisicaoAprovar.LoadControles(grdListagem.CurrentRow.Cells("codigo_requisicao").Value, _
                                                            grdListagem.CurrentRow.Cells("codigo").Value, _
                                                            txtNumeroRequisicao, _
                                                            txtAprovador, _
                                                            cboManutencao, _
                                                            txtComplemento, _
                                                            dtpDataNecessidade, _
                                                            cboArea, _
                                                            txtJustificativa)
                                                       
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

    Private Sub Historico()

        Try

            'Váriaveis Locais
            Dim oForm As New frmManRequisicaoHistorico

            'Seta Parâmetro
            oForm.NumeroRequisicao = grdListagem.CurrentRow.Cells("numero_requisicao").Value
            oForm.Requisitante = grdListagem.CurrentRow.Cells("requisitante").Value
            oForm.Manutencao = grdListagem.CurrentRow.Cells("manutencao").Value
            oForm.CodigoRequisicao = grdListagem.CurrentRow.Cells("codigo_requisicao").Value
            oForm.CodigoRequisicaoManutencao = grdListagem.CurrentRow.Cells("codigo").Value

            'Abre o Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriavel Local
            Dim oClsManRequisicao As New clsUsrManRequisicao

           'Atualiza Registro da tb_man_requisicao_manutencao
            Call oClsManRequisicao.UpdateManutencao(grdListagem.CurrentRow.Cells("codigo_requisicao").Value, _
                                                    cboManutencao.SelectedValue, _
                                                    txtComplemento.Text.Trim, _
                                                    IIf(dtpDataNecessidade.Checked = True, dtpDataNecessidade.Value, ""), _
                                                    cboArea.SelectedValue, _
                                                    txtJustificativa.Text.Trim, _
                                                    grdListagem.CurrentRow.Cells("codigo").Value)

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroAlterado)

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

            'Verifica se a Data de Necessidade informada é válida
            If dtpDataNecessidade.Checked = True Then
                If dtpDataNecessidade.Value < Now.Date Then
                    frmMain.errInfo.SetError(lblDataNecessidade, "A Data de Necessidade não pode ser menor que o dia corrente.")
                    dtpDataNecessidade.Focus()
                    Exit Function
                End If
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


