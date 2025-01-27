Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports System.IO

Public Class usrManRequisicao

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsManRequisicao As New clsUsrManRequisicao

#End Region

#Region "::: CONTROLES :::"

#Region "::: GERAL :::"

    Private Sub usrManRequisicao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboManutencao" : LoadCombo(cboManutencao, "sp_select_combo_cadastro_basico_manutencao " & goUsuario.iEmpresa, True)
                        Case "cboArea" : Call cboManutencao_SelectedIndexChanged(cboManutencao, System.EventArgs.Empty)
                        Case "cboTipoArquivo" : Call LoadCombo(cboTipoArquivo, "sp_select_combo_cadastro_basico_tipo_arquivo " & goUsuario.iEmpresa)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboManutencao" : Call btnCadastrarManutencao_Click(btnCadastrarManutencao, System.EventArgs.Empty)
                        Case "cboArea" : Call btnCadastrarArea_Click(btnCadastrarArea, System.EventArgs.Empty)
                        Case "cboTipoArquivo" : Call btnCadastrarTipoArquivo_Click(btnCadastrarTipoArquivo, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrManRequisicao_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: REQUISIÇÃO :::"

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
            oForm.NomeFormulario = Formulario.ManutencaoRequisicao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ManutencaoRequisicao)

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

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Dados da Grid
            Call LoadGrid()

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
            cboAprovador.Focus()

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
            cboAprovador.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Deleta Aba
        If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
        'Fecha o Controle
        Me.Dispose()

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

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Try

            'Verifica se não foi gerado a Requisição
            If txtNumeroRequisicao.Text = "" And grdManutencao.GetDataRows.Count > 0 Then
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
            End If

            'Imprime
            Call Imprimir(btnSalvar.Tag)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        Try

            'Verifica se não foi gerado a Requisição
            If txtNumeroRequisicao.Text = "" And grdManutencao.GetDataRows.Count > 0 Then
                'Verifica se o usuário deseja sair do Requisição
                If MsgBox("Os Dados da Requisição serão perdidos. Deseja continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If

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

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Coluna pressionada é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call Editar()
                Case "imprimir" : Call Imprimir(grdListagem.CurrentRow.Cells("codigo").Value)
                Case "historico" : Call Historico()
                Case "visualizar" : Call VisualizarDocumento(grdListagem.CurrentRow.Cells("arquivo_interacti").Value)
                Case "arquivo" : Call ListaArquivo("tb_man_requisicao", grdListagem.CurrentRow.Cells("codigo").Value)

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
                                     Formulario.ManutencaoRequisicao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.ManutencaoRequisicao, _
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
                                          Formulario.ManutencaoRequisicao, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: MANUTENÇÃO :::"

    Private Sub btnAgruparGridManutencao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridManutencao.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdManutencao.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdManutencao.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdManutencao.GroupByBoxVisible = True
                grdManutencao.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridManutencao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridManutencao.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdManutencao
            oForm.NomeFormulario = Formulario.ManutencaoRequisicao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdManutencao, Formulario.ManutencaoRequisicao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridManutencao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridManutencao.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdManutencao)

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

    Private Sub btnInserirManutencao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirManutencao.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Manutenção
            If ValidacaoManutencao() = True Then

                'Salva Dados do Registro
                Call InsertManutencao()

                'Carrega Manutencao
                Call oClsManRequisicao.LoadGridManutencao(grdManutencao, btnSalvar.Tag)

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoManutencao()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirManutencao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirManutencao.Click

        Try

            'Deleta Registros
            Call DeleteManutencao()

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

    Private Sub grdManutencao_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdManutencao.RowDoubleClick

        Try

            'Verifica se a Coluna pressionada é Válida
            If IsNothing(grdManutencao.CurrentColumn) Then Exit Sub

            Select Case grdManutencao.CurrentColumn.Key

                Case "editar" : Call EditarManutencao()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdManutencao_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdManutencao.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdManutencao, _
                                     Formulario.ManutencaoRequisicao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdManutencao_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdManutencao.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdManutencao.Name, _
                                     Formulario.ManutencaoRequisicao, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdManutencao_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdManutencao.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdManutencao.Name, _
                                          Formulario.ManutencaoRequisicao, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ARQUIVO :::"

    Private Sub btnAgruparGridArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridArquivo.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdArquivo.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdArquivo.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdArquivo.GroupByBoxVisible = True
                grdArquivo.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridArquivo.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdArquivo
            oForm.NomeFormulario = Formulario.ManutencaoRequisicao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdArquivo, Formulario.ManutencaoRequisicao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridArquivo.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdArquivo)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarTipoArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarTipoArquivo.Click

        Try

           'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadTipoArquivo")

            'Carrega Combo
            Call LoadCombo(cboTipoArquivo, "sp_select_combo_cadastro_basico_tipo_arquivo " & goUsuario.iEmpresa)
            'Seta Focu
            cboTipoArquivo.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArquivo.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Campo - Tipo de Arquivo
            If ValidaCampo(cboTipoArquivo, lblTipoArquivo) = False Then
                Exit Sub
            End If

            'Variaveis Locais
            Dim arqArquivo As New OpenFileDialog

            'Abre PopUp para Usuário selecionar Imagem
            arqArquivo.InitialDirectory = "c:\\dados"
            arqArquivo.Filter = LoadDescricao("sp_select_cadastro_basico_extensao_tipo_arquivo " & goUsuario.iEmpresa & "," & cboTipoArquivo.SelectedValue)
            arqArquivo.Title = "Selecione o Arquivo"

            If arqArquivo.ShowDialog() = DialogResult.OK Then
                txtArquivo.Text = arqArquivo.FileName
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirArquivo.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoArquivo() = True Then

                If IsNumeric(btnInserirArquivo.Tag) = False Then

                    'Insere Arquivo
                    Call InsertArquivoBD("tb_man_requisicao", _
                                         txtDescricaoArquivo.Text.Trim, _
                                         txtRevisaoArquivo.Text.Trim, _
                                         txtArquivo.Text.Trim, _
                                         cboTipoArquivo.SelectedValue, _
                                         btnSalvar.Tag)

                Else

                    'Atualiza Arquivo
                    Call UpdateArquivoBD("tb_man_requisicao", _
                                         txtDescricaoArquivo.Text.Trim, _
                                         txtRevisaoArquivo.Text.Trim, _
                                         IIf(txtArquivo.Text.Trim = "", grdArquivo.CurrentRow.Cells("path").Value, txtArquivo.Text.Trim), _
                                         cboTipoArquivo.SelectedValue, _
                                         grdArquivo.CurrentRow.Cells("path").Value, _
                                         btnSalvar.Tag)

                End If

                'Carrega Grid
                Call LoadGridArquivoBD(grdArquivo, "tb_man_requisicao", btnSalvar.Tag)

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoArquivo()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirArquivo.Click

        Try

            'Deleta Registros
            Call DeleteArquivo()

            'Prepara Formulário para Inserção de um Novo Registro
            Call NovoArquivo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboTipoArquivo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoArquivo.SelectedIndexChanged

        Try

            'Limpa Controle
            txtArquivo.Text = ""

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdArquivo.RowDoubleClick

        Try

            'Verifica se a Coluna pressionada é Válida
            If IsNothing(grdArquivo.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdArquivo.CurrentColumn.Key

                Case "editar" : Call EditarArquivo()
                Case "visualizar" : Call VisualizarDocumentoBD(grdArquivo.CurrentRow.Cells("arquivo").Value, grdArquivo.CurrentRow.Cells("extensao").Value)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdArquivo.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdArquivo, _
                                     Formulario.ManutencaoRequisicao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdArquivo.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdArquivo.Name, _
                                     Formulario.ManutencaoRequisicao, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdArquivo.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdArquivo.Name, _
                                          Formulario.ManutencaoRequisicao, _
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

#Region "::: GERAL :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrManRequisicao_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnNovo.Enabled = VerificaDireito(Formulario.ManutencaoRequisicao, gcInsert)
            btnNovo1.Enabled = VerificaDireito(Formulario.ManutencaoRequisicao, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.ManutencaoRequisicao, gcPrint)
            btnInserirManutencao.Enabled = VerificaDireito(Formulario.ManutencaoRequisicao, gcInsert)
            btnExcluirManutencao.Enabled = VerificaDireito(Formulario.ManutencaoRequisicao, gcDelete)
            btnExcelGridManutencao.Enabled = VerificaDireito(Formulario.ManutencaoRequisicao, gcPrint)
            btnInserirArquivo.Enabled = VerificaDireito(Formulario.ManutencaoRequisicao, gcInsert)
            btnExcluirArquivo.Enabled = VerificaDireito(Formulario.ManutencaoRequisicao, gcDelete)
            btnExcelGridArquivo.Enabled = VerificaDireito(Formulario.ManutencaoRequisicao, gcPrint)

            'Verifica Direito - Botão de Cadastro
            btnCadastrarManutencao.Enabled = VerificaDireito(Formulario.CadastroBasicoManutencao, gcInsert)
            btnCadastrarArea.Enabled = VerificaDireito(Formulario.CadastroBasicoArea, gcInsert)
            btnCadastrarTipoArquivo.Enabled = VerificaDireito(Formulario.CadastroBasicoTipoArquivo, gcInsert)
          
            'Carrega ComboBox        
            Call LoadCombo(cboStatusRequisicaoFiltro, "sp_select_combo_static_status_requisicao_compras")
            Call LoadCombo(cboRequisitanteFiltro, "sp_select_combo_administracao_usuario " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboAprovadorFiltro, "sp_select_combo_administracao_usuario_administrador " & goUsuario.iEmpresa & ", " & Formulario.ManutencaoRequisicaoAprovar, False)
            Call LoadCombo(cboAprovador, "sp_select_combo_administracao_usuario_administrador " & goUsuario.iEmpresa & ", " & Formulario.ManutencaoRequisicaoAprovar, False)
            Call LoadCombo(cboManutencaoFiltro, "sp_select_combo_cadastro_basico_manutencao " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboManutencao, "sp_select_combo_cadastro_basico_manutencao " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboTipoArquivo, "sp_select_combo_cadastro_basico_tipo_arquivo " & goUsuario.iEmpresa, False)

            'Configura DateTimer
            dtpDataRequisicaoInicioFiltro.Value = DateAdd(DateInterval.Month, -1, Now.Date) : dtpDataRequisicaoInicioFiltro.Checked = False
            dtpDataRequisicaoTerminoFiltro.Value = Now.Date : dtpDataRequisicaoTerminoFiltro.Checked = False

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ManutencaoRequisicao)
            Call ConfiguraGrid(grdManutencao, Formulario.ManutencaoRequisicao)
            Call ConfiguraGrid(grdArquivo, Formulario.ManutencaoRequisicao)

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

#Region "::: REQUISIÇÃO :::"

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim sStatus As String = ""

            'Status
            If cboStatusRequisicaoFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboStatusRequisicaoFiltro.CheckedValues)
                    sStatus &= IIf(sStatus = "", "", ",") & cboStatusRequisicaoFiltro.CheckedValues(i).ToString
                Next
            End If

            'Carrega Controles
            oClsManRequisicao.LoadGridRequisicao(grdListagem, _
                                                 IIf(IsNumeric(txtNumeroRequisicaoFiltro.Text.Trim), txtNumeroRequisicaoFiltro.Text.Trim, -1), _
                                                 sStatus, _
                                                 IIf(cboRequisitanteFiltro.SelectedIndex = -1, -1, cboRequisitanteFiltro.SelectedValue), _
                                                 IIf(cboAprovadorFiltro.SelectedIndex = -1, -1, cboAprovadorFiltro.SelectedValue), _
                                                 IIf(cboManutencaoFiltro.SelectedIndex = -1, -1, cboManutencaoFiltro.SelectedValue), _
                                                 IIf(dtpDataRequisicaoInicioFiltro.Checked = False, "", dtpDataRequisicaoInicioFiltro.Value), _
                                                 IIf(dtpDataRequisicaoTerminoFiltro.Checked = False, "", dtpDataRequisicaoTerminoFiltro.Value))

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
            If VerificaDireito(Formulario.ManutencaoRequisicao, gcUpdate) = True Then

                'Verifica se o Usuário pode ou não alterar a Requisição
                If grdListagem.CurrentRow.Cells("codigo_usuario_aprovador").Value = goUsuario.iUsuario Or _
                    grdListagem.CurrentRow.Cells("codigo_usuario_requisitante").Value = goUsuario.iUsuario Then

                    'Limpa Formulário
                    Call Novo()

                    'Carrega Controles
                    txtNumeroRequisicao.Text = grdListagem.CurrentRow.Cells("numero_requisicao").Value
                    cboAprovador.SelectedValue = grdListagem.CurrentRow.Cells("codigo_usuario_aprovador").Value
                    btnSalvar.Tag = grdListagem.CurrentRow.Cells("codigo").Value

                    'Carrega Grid de Manutenção
                    Call oClsManRequisicao.LoadGridManutencao(grdManutencao, grdListagem.CurrentRow.Cells("codigo").Value)

                    'Váriaveis Locais
                    Dim bFlag = True

                    'Verifica se o Usuário tem direito de alterar o Aprovador
                    For Each oRow As GridEXRow In grdManutencao.GetDataRows
                        If oRow.Cells("status").Value <> CInt(StatusRequisicaoManutencao.AguardandoAprovacao) Then
                            If grdListagem.CurrentRow.Cells("codigo_usuario_aprovador").Value <> goUsuario.iUsuario Or _
                                (grdListagem.CurrentRow.Cells("codigo_usuario_aprovador").Value = goUsuario.iUsuario And _
                                (oRow.Cells("status").Value <> CInt(StatusRequisicaoManutencao.Aprovada) And _
                                oRow.Cells("status").Value <> CInt(StatusRequisicaoManutencao.Reprovada))) Then
                                bFlag = False
                                Exit For
                            End If
                        End If
                    Next

                    'Seta Controle
                    cboAprovador.Enabled = bFlag

                    'Carrega Grid de Arquivo
                    Call modFunction.LoadGridArquivoBD(grdArquivo, "tb_man_requisicao", grdListagem.CurrentRow.Cells("codigo").Value)

                    'Alterna Aba
                    tabMain.TabPages.Remove(pagListagem)
                    tabMain.TabPages.Add(pagDados)

                    'Seta Focu
                    If cboAprovador.Enabled = True Then cboAprovador.Focus() Else cboManutencao.Focus()

                Else
                    'Informa o Usuário que ele não tem Direito
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Você não é o Usuário Requisitante nem o Usuário Aprovador.")
                End If

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

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Insere Requisição
            Call oClsManRequisicao.Insert()

            'Limpa Controles - Dados Gerais
            txtNumeroRequisicao.Text = ""
            cboAprovador.SelectedIndex = -1
            cboAprovador.Enabled = True
            btnSalvar.Tag = oClsManRequisicao.Codigo

            'Limpa Controles - Itens
                cboManutencao.Text = ""
            txtComplemento.Text = ""
            dtpDataNecessidade.Value = Now.Date : dtpDataNecessidade.Checked = False
            cboArea.Text = ""
            txtJustificativa.Text = ""
            btnInserirManutencao.Tag = ""
            grdManutencao.DataSource = Nothing

            'Limpa Controles - Arquivos
            txtDescricaoArquivo.Text = ""
            cboTipoArquivo.SelectedIndex = -1
            txtArquivo.Text = ""
            btnInserirArquivo.Tag = ""
            grdArquivo.DataSource = Nothing

            'Seleciona Aba
            tabDados.SelectedTab = pagItem

            'Seta Focu
            cboAprovador.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsManRequisicao.Codigo = btnSalvar.Tag
            oClsManRequisicao.CodigoUsuarioAprovador = IIf(cboAprovador.SelectedIndex = -1, -1, cboAprovador.SelectedValue)

            'Atualiza Requisição
            oClsManRequisicao.Update()

            'Seta Controle
            txtNumeroRequisicao.Text = oClsManRequisicao.NumeroRequisicao

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Delete()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsManRequisicao.Delete()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                MsgBox("Primeiramente Selecione um ou mais Registros Válidos.", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Selecionado o Campo - Aprovador
            If ValidaCampo(cboAprovador, lblAprovador) = False Then
                Exit Function
            End If

            'Verifica se foi inserido algum Item
            If grdManutencao.GetDataRows.Count = 0 Then
                frmMain.Informacao(Mensagem.ValidacaoInserir, "Manutenção")
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub Imprimir(ByVal lCodigoRequisicao As Long)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Redimenciona Vetor
            ReDim goCrystalReport.sReportParameter(2)
            'Seta Parametros
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_requisicao"
            goCrystalReport.sReportParameter(1).sValue = lCodigoRequisicao
            goCrystalReport.sReportParameter(2).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(2).sValue = goUsuario.iEmpresa
            goCrystalReport.sReport = goCrystalReport.sPath & "CMP000000005.rpt"

            Dim oReport As New usrReport
            oReport.Dock = DockStyle.Fill

            'Abre Relatório
            frmMain.LoadPageReport("CMP000000005", "Requisição de Compra", oReport)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Historico()

        Try

            'Abre Formulário
            Dim oForm As New frmManRequisicaoHistorico

            'Seta Parâmetro
            oForm.NumeroRequisicao = grdListagem.CurrentRow.Parent.Cells("numero_requisicao").Value
            oForm.Requisitante = grdListagem.CurrentRow.Parent.Cells("requisitante").Value
            oForm.Manutencao = grdListagem.CurrentRow.Cells("manutencao").Value
            oForm.CodigoRequisicao = grdListagem.CurrentRow.Cells("codigo_requisicao").Value
            oForm.CodigoRequisicaoManutencao = grdListagem.CurrentRow.Cells("codigo").Value

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: MANUTENÇÃO :::"

    Private Sub NovoManutencao()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Itens
            cboManutencao.Text = ""
            txtComplemento.Text = ""
            dtpDataNecessidade.Value = Now.Date : dtpDataNecessidade.Checked = False
            cboArea.Text = ""
            txtJustificativa.Text = ""
            btnInserirManutencao.Tag = ""

            'Seta Focu
            cboManutencao.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarManutencao()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se o Registro pode ser editado
            If grdManutencao.CurrentRow.Cells("status").Value = CInt(StatusRequisicaoManutencao.AguardandoAprovacao) Or _
                (goUsuario.iUsuario = cboAprovador.SelectedValue And
                 (grdManutencao.CurrentRow.Cells("status").Value = CInt(StatusRequisicaoManutencao.Aprovada) Or _
                  grdManutencao.CurrentRow.Cells("status").Value = CInt(StatusRequisicaoManutencao.AguardandoAprovacao))) Then

                'Verifica se o usuário tem direito de alterar algum registro
                If VerificaDireito(Formulario.ManutencaoRequisicao, gcUpdate) = True Then

                    'Carrega Controles
                    cboManutencao.SelectedValue = grdManutencao.CurrentRow.Cells("codigo_manutencao").Value
                    txtComplemento.Text = grdManutencao.CurrentRow.Cells("complemento").Value
                    If IsDBNull(grdManutencao.CurrentRow.Cells("data_necessidade").Value) Then dtpDataNecessidade.Value = Now.Date : dtpDataNecessidade.Checked = False Else dtpDataNecessidade.Value = grdManutencao.CurrentRow.Cells("data_necessidade").Value : dtpDataNecessidade.Checked = True
                    cboArea.SelectedValue = grdManutencao.CurrentRow.Cells("codigo_area").Value
                    txtJustificativa.Text = grdManutencao.CurrentRow.Cells("justificativa").Value
                    btnInserirManutencao.Tag = grdManutencao.CurrentRow.Cells.Row.RowIndex

                    'Seta Focu
                    cboManutencao.Focus()

                Else
                    'Informa o Usuário que ele não tem Direito
                    frmMain.Informacao(Mensagem.DireitoAlteracao)
                End If

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.RegistroNaoPodeAlterado)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub InsertManutencao()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirManutencao.Tag) Then

                'Atualiza Registro da tb_man_requisicao_manutencao
                Call oClsManRequisicao.UpdateManutencao(btnSalvar.Tag, _
                                                        cboManutencao.SelectedValue, _
                                                        txtComplemento.Text.Trim, _
                                                        IIf(dtpDataNecessidade.Checked = True, dtpDataNecessidade.Value, ""), _
                                                        cboArea.SelectedValue, _
                                                        txtJustificativa.Text.Trim, _
                                                        grdManutencao.CurrentRow.Cells("codigo").Value)

            Else

                'Insere Registro na tb_man_requisicao_manutencao
                Call oClsManRequisicao.InsertManutencao(btnSalvar.Tag, _
                                                        cboManutencao.SelectedValue, _
                                                        txtComplemento.Text.Trim, _
                                                        IIf(dtpDataNecessidade.Checked = True, dtpDataNecessidade.Value, ""), _
                                                        cboArea.SelectedValue, _
                                                        txtJustificativa.Text.Trim)

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteManutencao()

        'Variaveis Locais
        Dim sStatus(0) As String

        Try

            'Seta Váriavel - Status
            sStatus(0) = CInt(StatusRequisicaoManutencao.AguardandoAprovacao)
            If goUsuario.iUsuario = cboAprovador.SelectedValue Then
                ReDim Preserve sStatus(2)
                sStatus(1) = CInt(StatusRequisicaoManutencao.Aprovada)
                sStatus(2) = CInt(StatusRequisicaoManutencao.Reprovada)
            End If

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdManutencao, "status", sStatus) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Linha
                    Call oClsManRequisicao.DeleteManutencao(btnSalvar.Tag)

                    'Limpa Formulário
                    Call NovoManutencao()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Selecione um ou mais Registros com Status válido.")
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoManutencao() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoManutencao = False

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
            ValidacaoManutencao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: ARQUIVO :::"

    Private Sub DeleteArquivo()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdArquivo) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    For Each oRow As GridEXRow In gSelecaoRow
                        'Exclui Registro do Banco de Dados
                        modFunction.DeleteArquivoBD("tb_man_requisicao", oRow.Cells("path").Value, btnSalvar.Tag)
                        'Exclui Registro da Grid
                        oRow.Delete()
                    Next

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário sobre a necessidade de Selecionar um ou mais Itenss
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarArquivo()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.ManutencaoRequisicao, gcUpdate) = True Then

                'Limpa Formulário
                Call NovoArquivo()

                'Carrega Controles
                txtDescricaoArquivo.Text = grdArquivo.CurrentRow.Cells("descricao").Value
                txtRevisaoArquivo.Text = grdArquivo.CurrentRow.Cells("revisao").Value
                cboTipoArquivo.SelectedValue = grdArquivo.CurrentRow.Cells("codigo_tipo_arquivo").Value
                txtArquivo.Text = ""
                btnInserirArquivo.Tag = grdArquivo.CurrentRow.RowIndex

                'Seta Focu
                cboTipoArquivo.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoArquivo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles            
            txtDescricaoArquivo.Text = ""
            txtRevisaoArquivo.Text = ""
            cboTipoArquivo.SelectedIndex = -1
            txtArquivo.Text = ""
            btnInserirArquivo.Tag = ""

            'Seta Focu
            txtDescricaoArquivo.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoArquivo() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoArquivo = False

            'Verifica se foi Preenchido o Campo - Descrição
            If ValidaCampo(txtDescricaoArquivo, lblDescricaoArquivo, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Revisão
            If ValidaCampo(txtRevisaoArquivo, lblRevisaoArquivo, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Tipo de Arquivo
            If ValidaCampo(cboTipoArquivo, lblTipoArquivo) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Arquivo
            If IsNumeric(btnInserirArquivo.Tag) = False Then
                If ValidaCampo(txtArquivo, lblArquivo, TipoCampo.texto) = False Then
                    Exit Function
                End If
            End If

            'Verifica se o Produto é Válido
            Dim iRow As Integer = -1

            If IsNumeric(btnInserirArquivo.Tag) Then
                iRow = grdArquivo.CurrentRow.RowIndex
            End If

            For Each oRow As GridEXRow In grdArquivo.GetDataRows
                If oRow.Cells("descricao").Value = txtDescricaoArquivo.Text.Trim And oRow.Cells("revisao").Value = txtRevisaoArquivo.Text.Trim And oRow.RowIndex <> iRow Then
                    frmMain.errInfo.SetError(lblDescricaoArquivo, "Esta Descrição / Revisão já se encontra associada a um Registro.")
                    txtDescricaoArquivo.Focus()
                    Return False
                End If
            Next

            'Seta Retorno da Função
            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

End Class


