Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls
Imports Janus.Windows.Common
Imports System.IO

Public Class usrCadVeiculo

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadVeiculo As New clsUsrCadVeiculo

#End Region

#Region "::: CONTROLES :::"

#Region "::: GERAL :::"

    Private Sub usrCadVeiculo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

                Case Keys.F5
                    Select Case sender.name
                        Case "cboTipoVeiculoFiltro" : Call LoadCombo(cboTipoVeiculoFiltro, "sp_select_combo_cadastro_basico_tipo_veiculo " & goUsuario.iEmpresa)
                        Case "cboTipoVeiculo" : Call LoadCombo(cboTipoVeiculo, "sp_select_combo_cadastro_basico_tipo_veiculo " & goUsuario.iEmpresa)
                        Case "cboCentroGastoFiltro" : Call LoadCombo(cboCentroGastoFiltro, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)
                        Case "cboCentroGasto" : Call LoadCombo(cboCentroGasto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)
                        Case "cboDocumento" : Call LoadCombo(cboDocumento, "sp_select_combo_cadastro_basico_manutencao " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.servico))
                        Case "cboDocumento" : Call LoadCombo(cboDocumento, "sp_select_combo_cadastro_basico_documento_tipo " & goUsuario.iEmpresa & ", " & TipoDocumento.Equipamento)

                    End Select

                Case Keys.Oemplus, Keys.Add
                    Select Case sender.name
                        Case "cboTipoVeiculo" : Call btnCadastrarTipoVeiculo_Click(btnCadastrarTipoVeiculo, System.EventArgs.Empty)
                        Case "cboCentroGasto" : Call btnCadastrarCentroGasto_Click(btnCadastrarCentroGasto, System.EventArgs.Empty)
                        Case "cboDocumento" : Call btnCadastrarDocumento_Click(btnCadastrarDocumento, System.EventArgs.Empty)
                        Case "cboDocumento" : Call btnCadastrarDocumento_Click(btnCadastrarDocumento, System.EventArgs.Empty)

                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrCadVeiculo_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCadVeiculo_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

#End Region

#Region "::: VEÍCULO :::"

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.CadastroBasicoVeiculo
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoVeiculo)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarTipoVeiculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarTipoVeiculo.Click

        Try

              'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadTipoVeiculo")

            'Carrega Combo
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboTipoVeiculoFiltro : oComboBox(1) = cboTipoVeiculo
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_tipo_veiculo " & goUsuario.iEmpresa)
            'Seta Focu
            cboTipoVeiculo.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarCentroGasto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCentroGasto.Click

        Try

                'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCentroGasto")

            'Carrega Combo
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboCentroGastoFiltro : oComboBox(1) = cboCentroGasto
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)
            'Seta Focu
            cboCentroGasto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click

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
                'Prepara Formulário para Inserção de um Novo Registro
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

            'Seta Focu
            cboTipoVeiculoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call EditarVeiculo()

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
                                     Formulario.CadastroBasicoVeiculo)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.CadastroBasicoVeiculo, _
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
                                          Formulario.CadastroBasicoVeiculo, _
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

    Private Sub btnConfigurarGridManutencao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridManutencao.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdManutencao
            oForm.NomeFormulario = Formulario.CadastroBasicoVeiculo
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdManutencao, Formulario.CadastroBasicoVeiculo)

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
            Call LoadCombo(cboManutencao, "sp_select_combo_cadastro_basico_manutencao " & goUsuario.iEmpresa, False)

            'Seta Focu
            cboManutencao.Focus()

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

    Private Sub btnInserirManutencao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirManutencao.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call Salvar()

                'Valida Dados do Formulário
                If ValidacaoManutencao() = True Then

                    'Verifica o Tipo de Operação
                    If IsNumeric(btnInserirManutencao.Tag) = False Then
                        'Insere Registro
                        Call oClsCadVeiculo.InsertManutencao(cboManutencao.SelectedValue, _
                                                             txtHoraKM.Value, _
                                                             txtAlertaAntecedenciaManutencao.Value)
                    Else
                        'Atualiza Registro
                        Call oClsCadVeiculo.UpdateManutencao(cboManutencao.SelectedValue, _
                                                             txtHoraKM.Value, _
                                                             txtAlertaAntecedenciaManutencao.Value, _
                                                             btnInserirManutencao.Tag)
                    End If

                    'Carrega Grid
                    oClsCadVeiculo.LoadGridManutencao(grdManutencao, _
                                                      btnSalvar.Tag)

                    'Prepara Formulário para Inserção de um Novo Registro
                    Call NovoManutencao()

                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdManutencao_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdManutencao.RowDoubleClick

        Try

            'Verifica o Tipo de Operação
            Select Case grdManutencao.CurrentColumn.Key

                Case "editar" : Call EditarManutencao()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdManutencao_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdManutencao.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdManutencao, _
                                     Formulario.CadastroBasicoVeiculo)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdManutencao_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdManutencao.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdManutencao.Name, _
                                     Formulario.CadastroBasicoVeiculo, _
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
                                          Formulario.CadastroBasicoVeiculo, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: DOCUMENTOS :::"

    Private Sub btnConfigurarGridDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridDocumento.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdDocumento
            oForm.NomeFormulario = Formulario.CadastroBasicoVeiculo
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdDocumento, Formulario.CadastroBasicoVeiculo)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnArquivoDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArquivoDocumento.Click

        Try

            'Variaveis Locais
            Dim arqArquivo As New OpenFileDialog

            'Abre PopUp para Usuário selecionar Imagem
            arqArquivo.InitialDirectory = "c:\\dados"
            arqArquivo.Title = "Selecione o Arquivo"

            If arqArquivo.ShowDialog() = DialogResult.OK Then
                txtArquivoDocumento.Text = arqArquivo.FileName
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarDocumento.Click

        Try

                'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadDocumento")

            'Carrega Combo            
            Call LoadCombo(cboDocumento, "sp_select_combo_cadastro_basico_documento_tipo " & goUsuario.iEmpresa & ", " & TipoDocumento.Equipamento)

            'Seta Focu
            cboDocumento.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirDocumento.Click

        Try

            'Deleta Registros
            Call DeleteDocumento()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirDocumento.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call Salvar()

                'Valida Dados do Formulário
                If ValidacaoDocumento() = True Then

                    'Verifica o Tipo de Operação
                    If IsNumeric(btnInserirDocumento.Tag) = False Then
                        'Insere Registro
                        Call oClsCadVeiculo.InsertDocumento(cboDocumento.SelectedValue, _
                                                            dtpDataEmissaoDocumento.Value, _
                                                            IIf(dtpDataValidadeDocumento.Checked = False, "", dtpDataValidadeDocumento.Value), _
                                                            txtAlertaAntecedenciaDia.Value, _
                                                            txtArquivoDocumento.Text)
                    Else
                        'Atualiza Registro
                        Call oClsCadVeiculo.UpdateDocumento(cboDocumento.SelectedValue, _
                                                            dtpDataEmissaoDocumento.Value, _
                                                            IIf(dtpDataValidadeDocumento.Checked = False, "", dtpDataValidadeDocumento.Value), _
                                                            txtAlertaAntecedenciaDia.Value, _
                                                            txtArquivoDocumento.Text, _
                                                            btnInserirDocumento.Tag)
                    End If

                    'Carrega Grid
                    oClsCadVeiculo.LoadGridDocumento(grdDocumento, _
                                                     btnSalvar.Tag)

                    'Prepara Formulário para Inserção de um Novo Registro
                    Call NovoDocumento()

                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdDocumento_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdDocumento.RowDoubleClick

        Try

            'Verifica o Tipo de Operação
            Select Case grdDocumento.CurrentColumn.Key

                Case "editar" : Call EditarDocumento()
                Case "arquivo" : Call VisualizarDocumento()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdDocumento_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdDocumento.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdDocumento, _
                                     Formulario.CadastroBasicoVeiculo)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdDocumento_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdDocumento.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdDocumento.Name, _
                                     Formulario.CadastroBasicoVeiculo, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdDocumento_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdDocumento.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdDocumento.Name, _
                                          Formulario.CadastroBasicoVeiculo, _
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadVeiculo_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.CadastroBasicoVeiculo, gcDelete)
            btnNovo1.Enabled = VerificaDireito(Formulario.CadastroBasicoVeiculo, gcInsert)

            'Verifica Direito - Botão Cadastrar
            btnCadastrarTipoVeiculo.Enabled = VerificaDireito(Formulario.CadastroBasicoVeiculo, gcInsert)
            btnCadastrarCentroGasto.Enabled = VerificaDireito(Formulario.CadastroBasicoCentroGasto, gcInsert)
            btnCadastrarDocumento.Enabled = VerificaDireito(Formulario.CadastroBasicoDocumento, gcInsert)

            'Carrega Combo
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboTipoVeiculoFiltro : oComboBox(1) = cboTipoVeiculo
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_tipo_veiculo " & goUsuario.iEmpresa, False)
            oComboBox(0) = cboCentroGastoFiltro : oComboBox(1) = cboCentroGasto
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa, False)
            oComboBox(0) = cboAnoFiltro : oComboBox(1) = cboAno
            Call LoadComboAno(oComboBox, DatePart(DateInterval.Year, DateAdd(DateInterval.Year, -20, Now.Date)), Now.Date.Year)
            Call LoadCombo(cboManutencao, "sp_select_combo_cadastro_basico_manutencao " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboDocumento, "sp_select_combo_cadastro_basico_documento_tipo " & goUsuario.iEmpresa & ", " & CInt(TipoDocumento.Equipamento), False)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoVeiculo)
            Call ConfiguraGrid(grdManutencao, Formulario.CadastroBasicoVeiculo)
            Call ConfiguraGrid(grdDocumento, Formulario.CadastroBasicoVeiculo)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            cboTipoVeiculoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: VEÍCULO :::"

    Private Sub Delete()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCadVeiculo.Delete()

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

    Private Sub EditarVeiculo()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoVeiculo, gcUpdate) = True Then

                'Carrega Controles
                oClsCadVeiculo.LoadDados(grdListagem.CurrentRow.Cells.Item("codigo").Value, _
                                         cboTipoVeiculo, _
                                         txtDescricao, _
                                         cboCentroGasto, _
                                         cboAno, _
                                         txtNumeroSerie, _
                                         txtPlaca, _
                                         txtRenavan, _
                                         dtpDataAquisicao)

                'Seta Código
                btnSalvar.Tag = grdListagem.CurrentRow.Cells.Item("codigo").Value

                'Carrega Grid de Contato
                oClsCadVeiculo.LoadGridDocumento(grdDocumento, _
                                                  grdListagem.CurrentRow.Cells.Item("codigo").Value)

                'Carrega Grid de Endereço
                oClsCadVeiculo.LoadGridDocumento(grdDocumento, _
                                                 grdListagem.CurrentRow.Cells.Item("codigo").Value)

                tabDados.SelectedTab = pagDadosGerais

                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                cboTipoVeiculo.Focus()

            Else

                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Dados Gerais
            cboTipoVeiculo.SelectedIndex = -1
            txtDescricao.Text = ""
            cboCentroGasto.SelectedIndex = -1
            cboAno.SelectedIndex = -1
            txtNumeroSerie.Text = ""
            txtPlaca.Text = ""
            txtRenavan.Text = ""
            dtpDataAquisicao.Value = Now.Date
            btnSalvar.Tag = ""

            'Limpa Controles - Manutenção
            cboDocumento.SelectedIndex = -1
            txtHoraKM.Value = 0
            btnInserirDocumento.Tag = ""
            grdDocumento.DataSource = Nothing

            'Limpa Controles - Documento
            cboDocumento.SelectedIndex = -1
            dtpDataEmissaoDocumento.Value = Now.Date
            dtpDataValidadeDocumento.Value = Now.Date : dtpDataValidadeDocumento.Checked = False
            btnInserirDocumento.Tag = ""
            grdDocumento.DataSource = Nothing

            'Seta Aba
            tabDados.SelectedTab = pagDadosGerais

            'Seta Focu
            cboTipoVeiculo.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCadVeiculo.CodigoEquipamento = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1)
            oClsCadVeiculo.CodigoTipoVeiculo = cboTipoVeiculo.SelectedValue
            oClsCadVeiculo.Descricao = txtDescricao.Text.Trim
            oClsCadVeiculo.CodigoCentroGasto = cboCentroGasto.SelectedValue
            oClsCadVeiculo.Ano = cboAno.SelectedValue
            oClsCadVeiculo.NumeroSerie = txtNumeroSerie.Text.Trim
            oClsCadVeiculo.Placa = txtPlaca.Text.Trim
            oClsCadVeiculo.Renavan = txtRenavan.Text.Trim
            oClsCadVeiculo.DataAquisicao = dtpDataAquisicao.Value

            'Verifica o Tipo de Operação
            If IsNumeric(btnSalvar.Tag) Then
                oClsCadVeiculo.Update()
            Else
                oClsCadVeiculo.Insert()
                btnSalvar.Tag = oClsCadVeiculo.CodigoEquipamento
            End If

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

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
            oClsCadVeiculo.LoadGrid(grdListagem, _
                                    IIf(cboTipoVeiculoFiltro.SelectedIndex = -1, -1, cboTipoVeiculoFiltro.SelectedValue), _
                                    txtDescricaoFiltro.Text.Trim, _
                                    IIf(cboCentroGastoFiltro.SelectedIndex = -1, -1, cboCentroGastoFiltro.SelectedValue), _
                                    IIf(cboAnoFiltro.SelectedIndex = -1, -1, cboAnoFiltro.SelectedValue), _
                                    txtNumeroSerieFiltro.Text.Trim, _
                                    txtPlacaFiltro.Text.Trim, _
                                    txtRenavanFiltro.Text.Trim)

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

            'Verifica se foi Selecionado o Campo - Tipo do Veículo
            If ValidaCampo(cboTipoVeiculo, lblTipoVeiculo) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Descrição
            If ValidaCampo(txtDescricao, lblDescricao, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Centro de Gasto
            If ValidaCampo(cboCentroGasto, lblCentroGasto) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Ano
            If ValidaCampo(cboAno, lblAno) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: MANUTENÇÃO :::"

    Private Sub DeleteManutencao()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdManutencao) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCadVeiculo.DeleteManutencao()

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

    Private Sub EditarManutencao()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoVeiculo, gcUpdate) = True Then

                With grdManutencao.CurrentRow

                    'Carrega Controles
                    cboManutencao.SelectedValue = .Cells("codigo_manutencao").Value
                    txtHoraKM.Value = .Cells("hora_km").Value
                    txtAlertaAntecedenciaManutencao.Value = .Cells("alerta_antecedencia").Value
                    btnInserirManutencao.Tag = .Cells("codigo").Value

                End With

                'Seta Focu
                cboManutencao.Focus()

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoManutencao()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Dependente
            cboManutencao.SelectedIndex = -1
            txtHoraKM.Value = 0
            txtAlertaAntecedenciaManutencao.Value = 0
            btnInserirManutencao.Tag = ""

            'Seta Focu
            cboManutencao.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoManutencao() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoManutencao = False

            'Verifica se foi Selecionado o Campo - Serviço
            If ValidaCampo(cboManutencao, lblManutencao) = False Then
                Exit Function
            End If

            'Verifica se a documento é Válida
            If IsNumeric(btnInserirManutencao.Tag) Then
                If VerificaExisteValorGrid(grdManutencao, "codigo_manutencao", cboManutencao.SelectedValue, grdManutencao.CurrentRow.RowIndex) Then
                    frmMain.errInfo.SetError(lblManutencao, "Esta Manutenção: " & cboManutencao.Text & " já está associado a um outro registro.")
                    cboManutencao.Focus()
                    Exit Function
                End If
            Else
                If VerificaExisteValorGrid(grdManutencao, "codigo_manutencao", cboManutencao.SelectedValue, -1) Then
                    frmMain.errInfo.SetError(lblManutencao, "Esta Manutenção: " & cboManutencao.Text & " já está associado a um outro registro.")
                    cboManutencao.Focus()
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            ValidacaoManutencao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: DOCUMENTOS :::"

    Private Sub DeleteDocumento()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdDocumento) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCadVeiculo.DeleteDocumento()

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

    Private Sub EditarDocumento()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoFuncionario, gcUpdate) = True Then

                With grdDocumento.CurrentRow

                    'Carrega Controles
                    cboDocumento.SelectedValue = .Cells("codigo_documento").Value
                    dtpDataEmissaoDocumento.Value = .Cells("data_emissao").Value
                    If IsDBNull(.Cells("data_validade").Value) Then
                        dtpDataValidadeDocumento.Value = Now.Date : dtpDataValidadeDocumento.Checked = False
                    Else
                        dtpDataValidadeDocumento.Value = .Cells("data_validade").Value : dtpDataValidadeDocumento.Checked = True
                    End If
                    txtAlertaAntecedenciaDia.Value = .Cells("alerta_antecedencia").Value
                    btnInserirDocumento.Tag = .Cells("codigo").Value

                End With

                'Seta Focu
                cboDocumento.Focus()

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoDocumento()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Dependente
            cboDocumento.SelectedIndex = -1
            dtpDataEmissaoDocumento.Value = Now.Date
            dtpDataValidadeDocumento.Value = Now.Date : dtpDataValidadeDocumento.Checked = False
            txtAlertaAntecedenciaDia.Value = 0
            btnInserirDocumento.Tag = ""

            'Seta Focu
            cboDocumento.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub VisualizarDocumento()

        Try

            'Verifica se foi Informado o Arquivo
            If IsDBNull(grdDocumento.CurrentRow.Cells("arquivo").Value) = False Then

                'Informa o Usuário que não foi Informado o Arquivo
                frmMain.Informacao(Mensagem.NaoFoiInformado, "Arquivo")

                'Verifica se o Arquivo Existe
                If File.Exists(grdDocumento.CurrentRow.Cells("arquivo").Value) Then
                    'Abre o Arquivo
                    Dim oProcess As New Process
                    oProcess.Start(grdDocumento.CurrentRow.Cells("arquivo").Value)
                Else
                    'Informa o Usuário que o Arquivo Informado não foi Localizado.
                    frmMain.Informacao(Mensagem.ObjetoNaoEncontrado, "Arquivo")
                End If

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoDocumento() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoDocumento = False

            'Verifica se foi Selecionado o Campo - Documento
            If ValidaCampo(cboDocumento, lblDocumento) = False Then
                Exit Function
            End If

            'Verifica se a documento é Válida
            If IsNumeric(btnInserirDocumento.Tag) Then
                If VerificaExisteValorGrid(grdDocumento, "codigo_documento", cboDocumento.SelectedValue, grdDocumento.CurrentRow.RowIndex) Then
                    frmMain.errInfo.SetError(lblDocumento, "Este Documento: " & cboDocumento.Text & " já está associado a um outro registro.")
                    cboDocumento.Focus()
                    Exit Function
                End If
            Else
                If VerificaExisteValorGrid(grdDocumento, "codigo_documento", cboDocumento.SelectedValue, -1) Then
                    frmMain.errInfo.SetError(lblDocumento, "Este Documento: " & cboDocumento.Text & " já está associado a um outro registro.")
                    cboDocumento.Focus()
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            ValidacaoDocumento = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

End Class

