Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Imports Janus.Windows.GridEX.EditControls

Public Class usrCadFuncionario

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadFuncionario As New clsUsrCadFuncionario

#End Region

#Region "::: CONTROLES :::"

#Region "::: GERAL :::"

    Private Sub usrCadFuncionario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

                Case Keys.F3
                    Select Case sender.name
                        Case "txtCEP" : Call btnProcurarCEP_Click(btnProcurarCEP, System.EventArgs.Empty)
                        Case "cboCentroGasto" : Call btnProcurarCentroGasto_Click(btnProcurarCentroGasto, System.EventArgs.Empty)
                    End Select

                Case Keys.F5
                    Select Case sender.name
                        Case "cboPais" : Call LoadCombo(cboPais, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)
                        Case "cboCentroTrabalho" : Call LoadCombo(cboCentroTrabalho, "sp_select_combo_cadastro_basico_centro_trabalho " & goUsuario.iEmpresa)
                        Case "cboCentroTrabalhoRateio" : Call LoadCombo(cboCentroTrabalhoRateio, "sp_select_combo_cadastro_basico_centro_trabalho " & goUsuario.iEmpresa)
                        Case "cboOperacao" : Call LoadCombo(cboCentroTrabalho, "sp_select_combo_cadastro_basico_centro_trabalho " & goUsuario.iEmpresa)
                        Case "cboAjudaCusto" : Call LoadCombo(cboAjudaCusto, "sp_select_combo_cadastro_basico_ajuda_custo " & goUsuario.iEmpresa)
                        Case "cboAtividade" : Call LoadCombo(cboAtividade, "sp_select_combo_cadastro_basico_atividade " & goUsuario.iEmpresa)
                        Case "cboCentroGasto" : Call LoadCombo(cboCentroGasto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)
                        Case "cboBanco" : Call LoadCombo(cboBanco, "sp_select_combo_cadastro_basico_banco " & goUsuario.iEmpresa)
                        Case "cboDocumento" : Call LoadCombo(cboDocumento, "sp_select_combo_cadastro_basico_documento " & goUsuario.iEmpresa)
                        Case "cboTurno" : Call LoadCombo(cboTurno, "sp_select_combo_cadastro_basico_turno " & goUsuario.iEmpresa)
                        Case "cboTipoArquivo" : Call LoadCombo(cboTipoArquivo, "sp_select_combo_cadastro_basico_tipo_arquivo " & goUsuario.iEmpresa)
                        Case "cboOcupacao" : Call LoadCombo(cboOcupacao, "sp_select_combo_cadastro_basico_ocupacao " & goUsuario.iEmpresa)
                        Case "cboHoraExtraSegundaPagamento", "cboHoraExtraTercaPagamento", "cboHoraExtraQuartaPagamento", "cboHoraExtraQuintaPagamento",
                             "cboHoraExtraSextaPagamento", "cboHoraExtraSabadoPagamento", "cboHoraExtraDomingoPagamento", "cboHoraExtraAposSegundaPagamento",
                             "cboHoraExtraAposTercaPagamento", "cboHoraExtraAposQuartaPagamento", "cboHoraExtraAposQuintaPagamento", "cboHoraExtraAposSextaPagamento",
                             "cboHoraExtraAposSabadoPagamento", "cboHoraExtraAposDomingoPagamento"
                            Dim oComboBox(13) As UIComboBox
                            oComboBox(0) = cboHoraExtraSegundaPagamento : oComboBox(1) = cboHoraExtraTercaPagamento
                            oComboBox(2) = cboHoraExtraQuartaPagamento : oComboBox(3) = cboHoraExtraQuintaPagamento
                            oComboBox(4) = cboHoraExtraSextaPagamento : oComboBox(5) = cboHoraExtraSabadoPagamento : oComboBox(6) = cboHoraExtraDomingoPagamento
                            oComboBox(7) = cboHoraExtraAposSegundaPagamento : oComboBox(8) = cboHoraExtraAposTercaPagamento
                            oComboBox(9) = cboHoraExtraAposQuartaPagamento : oComboBox(10) = cboHoraExtraAposQuintaPagamento
                            oComboBox(11) = cboHoraExtraAposSextaPagamento : oComboBox(12) = cboHoraExtraAposSabadoPagamento : oComboBox(13) = cboHoraExtraAposDomingoPagamento
                            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_tipo_hora_extra " & goUsuario.iEmpresa)
                    End Select

                Case Keys.Oemplus, Keys.Add
                    Select Case sender.name
                        Case "cboPais" : Call btnCadastrarPais_Click(btnCadastrarPais, System.EventArgs.Empty)
                        Case "cboMaquinaEquipamento" : Call btnCadastrarMaquina_Click(btnCadastrarMaquina, System.EventArgs.Empty)
                        Case "cboServico" : Call cboCentroTrabalho_SelectedIndexChanged(cboCentroTrabalho, System.EventArgs.Empty)
                        Case "cboAjudaCusto" : Call btnCadastrarAjudaCusto_Click(btnCadastrarAjudaCusto, System.EventArgs.Empty)
                        Case "cboAtividade" : Call btnCadastrarAtividade_Click(btnCadastrarAtividade, System.EventArgs.Empty)
                        Case "cboCentroTrabalho" : Call btnCadastrarCentroTrabalho_Click(btnCadastrarCentroTrabalho, System.EventArgs.Empty)
                        Case "cboCentroTrabalhoRateio" : Call btnCadastrarCentroTrabalhoRateio_Click(btnCadastrarCentroTrabalhoRateio, System.EventArgs.Empty)
                        Case "cboOperacao" : Call btnCadastrarOperacao_Click(btnCadastrarOperacao, System.EventArgs.Empty)
                        Case "cboCentroGasto" : Call btnCadastrarCentroGasto_Click(btnCadastrarCentroGasto, System.EventArgs.Empty)
                        Case "cboBanco" : Call btnCadastrarBanco_Click(btnCadastrarBanco, System.EventArgs.Empty)
                        Case "cboDocumento" : Call btnCadastrarDocumento_Click(btnCadastrarDocumento, System.EventArgs.Empty)
                        Case "cboTurno" : Call btnCadastrarTurno_Click(btnCadastrarTurno, System.EventArgs.Empty)
                        Case "cboTipoArquivo" : Call btnCadastrarTipoArquivo_Click(btnCadastrarTipoArquivo, System.EventArgs.Empty)
                        Case "cboOcupacao" : Call btnCadastrarOcupacao_Click(btnCadastrarOcupacao, System.EventArgs.Empty)
                        Case "cboHoraExtraSegundaPagamento", "cboHoraExtraTercaPagamento", "cboHoraExtraQuartaPagamento", "cboHoraExtraQuintaPagamento",
                             "cboHoraExtraSextaPagamento", "cboHoraExtraSabadoPagamento", "cboHoraExtraDomingoPagamento", "cboHoraExtraAposSegundaPagamento",
                             "cboHoraExtraAposTercaPagamento", "cboHoraExtraAposQuartaPagamento", "cboHoraExtraAposQuintaPagamento", "cboHoraExtraAposSextaPagamento",
                             "cboHoraExtraAposSabadoPagamento", "cboHoraExtraAposDomingoPagamento"
                            'Call btnCadastrarTipoHoraExtra_Click(btnCadastrarTipoHoraExtra, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadFuncionario_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: FUNCIONÁRIO :::"

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
            oForm.NomeFormulario = Formulario.CadastroBasicoFuncionario
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoFuncionario)

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

    Private Sub btnFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFoto.Click

        Try

            'Variaveis Locais
            Dim arqImagem As New OpenFileDialog

            'Abre PopUp para Usuário selecionar Imagem
            arqImagem.InitialDirectory = "c:\\dados"
            arqImagem.Filter = "(Imagens BMP;JPG;GIF;PNG)|*.BMP;*.JPG;*.GIF;*.PNG"
            arqImagem.Title = "Selecione o Arquivo"

            If arqImagem.ShowDialog() = DialogResult.OK Then
                txtFoto.Text = arqImagem.FileName
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarMaquina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarMaquina.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadMaquina")

            'Carrega Combo
            Call LoadCombo(cboMaquinaEquipamento, "sp_select_combo_cadastro_basico_maquina " & goUsuario.iEmpresa)
            'Seta Focu
            cboMaquinaEquipamento.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarOcupacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarOcupacao.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadOcupacao")

            'Carrega Combo
            Call LoadCombo(cboOcupacao, "sp_select_combo_cadastro_basico_ocupacao " & goUsuario.iEmpresa)

            'Seta Focu
            cboOcupacao.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarPais_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarPais.Click
        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadPais")

            'Carrega Combo
            Call LoadCombo(cboPais, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)
            'Seta Focu
            cboPais.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarCEP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCEP.Click

        Try

            'Verifica se foi preenchido o CEP
            If txtCEP.Text.Replace("-", "").Trim.Length = 8 Then

                'Verifica se há o cep no banco de dados
                ProcuraCep(CLng(Replace(txtCEP.Text.Trim, "-", "")),
                           cboPais,
                           cboUF,
                           cboMunicipio,
                           txtBairro,
                           txtLogradouro,
                           txtComplemento)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnEmail_Click(sender As Object, e As EventArgs) Handles btnEmail.Click

        Try

            'Email
            Call Email()

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

                Call Editar(oClsCadFuncionario.CodigoFuncionario)

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
            txtProntuarioFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboPais_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPais.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum Registro
            If cboPais.SelectedIndex = -1 Then
                'Limpa Controles
                cboUF.DataSource = Nothing
                cboUF.Text = ""
            Else
                Call LoadCombo(cboUF, "sp_select_combo_static_estado_pais " & cboPais.SelectedValue)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboUF_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUF.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum Registro
            If cboUF.SelectedIndex = -1 Then
                'Limpa Controles
                cboMunicipio.DataSource = Nothing
                cboMunicipio.Text = ""
            Else
                'Carrega Combo
                Call LoadCombo(cboMunicipio, "sp_select_combo_static_municipio " & cboUF.SelectedValue)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    'Private Sub cboCategoriaCNH_SelectedIndexChanged(sender As Object, e As EventArgs)

    '    Try

    '        'Verifica se foi Selecionado Algum Registro
    '        If cboCategoriaCNH.SelectedIndex = -1 Then
    '            frmMain.errMsg.Clear()
    '        Else
    '            frmMain.errMsg.SetError(lblCategoriaCNH, cboCategoriaCNH.SelectedValue)
    '        End If

    '    Catch ex As Exception
    '        'Trata Erro
    '        Call TratamentoErro(ex.Message, Me.Parent.Text)
    '    End Try

    'End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Linha é válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key
                Case "editar" : Call Editar(grdListagem.CurrentRow.Cells("codigo").Value)
                Case "visualizar" : Call VisualizarDocumento()
                Case "email" : Call Email(grdListagem.CurrentRow)
                Case "view" : Call Visualizar()
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name,
                                     Formulario.CadastroBasicoFuncionario,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem,
                                     Formulario.CadastroBasicoFuncionario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name,
                                          Formulario.CadastroBasicoFuncionario,
                                          e.Group.Column.Key,
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False),
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub txtFoto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFoto.TextChanged

        Try

            'Verifica se foi Selecionado alguma Foto
            If txtFoto.Text <> "" Then
                picFoto.Image = Image.FromFile(txtFoto.Text)
            Else
                picFoto.Image.Dispose()
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: CENTRO DE TRABALHO / OPERAÇÃO :::"

    Private Sub btnAgruparGridOperacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridOperacao.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdOperacao.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdOperacao.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdOperacao.GroupByBoxVisible = True
                grdOperacao.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridOperacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridOperacao.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdOperacao
            oForm.NomeFormulario = Formulario.CadastroBasicoFuncionario
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdOperacao, Formulario.CadastroBasicoFuncionario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridOperacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridOperacao.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdOperacao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarCentroTrabalho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCentroTrabalho.Click
        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCentroTrabalho")

            'Carrega Combo
            Call LoadCombo(cboCentroTrabalho, "sp_select_combo_cadastro_basico_centro_trabalho " & goUsuario.iEmpresa)

            'Seta Focu
            cboCentroTrabalho.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarOperacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarOperacao.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadOperacao")

            If cboCentroTrabalho.SelectedIndex = -1 Then
                cboOperacao.DataSource = Nothing
                cboOperacao.Text = ""
            Else
                Call LoadCombo(cboOperacao, "sp_select_combo_cadastro_basico_operacao " & cboCentroTrabalho.SelectedValue & ", " & goUsuario.iEmpresa)
            End If

            'Seta Focu
            cboOperacao.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirOperacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirOperacao.Click

        Try

            'Deleta Registros
            Call DeleteOperacao()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirOperacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirOperacao.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call Salvar()

                'Valida Dados do Formulário
                'If ValidacaoOperacao() = True Then

                'Obtém Código
                If IsNumeric(btnInserirOperacao.Tag) = False Then

                    'Insere Serviço
                    Call oClsCadFuncionario.InsertOperacao(cboCentroTrabalho.SelectedValue,
cboOperacao.SelectedValue)

                Else

                    'Atualiza Serviço
                    Call oClsCadFuncionario.UpdateOperacao(cboCentroTrabalho.SelectedValue,
cboOperacao.SelectedValue,
grdOperacao.CurrentRow.Cells("codigo").Value)
                End If

                'Carrega Grid
                Call oClsCadFuncionario.LoadGridOperacao(grdOperacao,
                                                             btnSalvar.Tag)

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoOperacao()

                'End If

            End If
        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCentroTrabalho_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCentroTrabalho.SelectedItemChanged
        Try

            'Verifica se foi Selecionado algum Centro de Trabalho
            If cboCentroTrabalho.SelectedIndex = -1 Then
                'Limpa Controle
                cboOperacao.DataSource = Nothing : cboOperacao.Text = ""
            Else
                'Carrega Combo
                Call LoadCombo(cboOperacao, "sp_select_combo_cadastro_basico_operacao " & cboCentroTrabalho.SelectedValue & ", " & goUsuario.iEmpresa)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdOperacao_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdOperacao.RowDoubleClick

        Try

            'Verifica se a Linha é válida
            If IsNothing(grdOperacao.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdOperacao.CurrentColumn.Key

                Case "editar" : Call EditarOperacao()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdOperacao_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdOperacao.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdOperacao.Name,
                                     Formulario.CadastroBasicoFuncionario,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdOperacao_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdOperacao.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdOperacao,
                                     Formulario.CadastroBasicoFuncionario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdOperacao_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdOperacao.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdOperacao.Name,
                                          Formulario.CadastroBasicoFuncionario,
                                          e.Group.Column.Key,
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False),
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: DADOS BANCÁRIOS :::"

    Private Sub btnAgruparGridContaBancaria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridContaBancaria.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdContaBancaria.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdContaBancaria.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdContaBancaria.GroupByBoxVisible = True
                grdContaBancaria.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridContaBancaria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridContaBancaria.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdContaBancaria
            oForm.NomeFormulario = Formulario.CadastroBasicoFuncionario
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdContaBancaria, Formulario.CadastroBasicoFuncionario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridContaBancaria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridContaBancaria.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdContaBancaria)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarBanco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarBanco.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadBanco")

            'Carrega Combo            
            Call LoadCombo(cboBanco, "sp_select_combo_cadastro_basico_banco " & goUsuario.iEmpresa)

            'Seta Focu
            cboBanco.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluirContaBancaria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirContaBancaria.Click

        Try

            'Deleta Registros
            Call DeleteContaBancaria()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirContaBancaria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirContaBancaria.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call Salvar()

                'Valida Dados do Formulário
                If ValidacaoContaBancaria() = True Then

                    'Verifica o Tipo de Operação
                    If IsNumeric(btnInserirContaBancaria.Tag) = False Then

                        'Insere Registro
                        Call oClsCadFuncionario.InsertContaBancaria(cboBanco.SelectedValue,
                                                                    cboTipoContaBancaria.SelectedValue,
                                                                    txtAgencia.Text.Trim,
                                                                    txtConta.Text.Trim,
                                                                    txtDigitoConta.Text.Trim,
                                                                    cboContaPagamento.SelectedValue)

                    Else

                        'Atualiza Registro
                        Call oClsCadFuncionario.UpdateContaBancaria(cboBanco.SelectedValue,
                                                                    cboTipoContaBancaria.SelectedValue,
                                                                    txtAgencia.Text.Trim,
                                                                    txtConta.Text.Trim,
                                                                    txtDigitoConta.Text.Trim,
                                                                    cboContaPagamento.SelectedValue,
                                                                    grdContaBancaria.CurrentRow.Cells("codigo").Value)

                    End If

                    'Carrega Grid
                    Call oClsCadFuncionario.LoadGridContaBancaria(grdContaBancaria,
                                                                  btnSalvar.Tag)

                    'Prepara Formulário para Inserção de um Novo Registro
                    Call NovoContaBancaria()

                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdContaBancaria_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdContaBancaria.RowDoubleClick

        Try

            'Verifica se a Linha é válida
            If IsNothing(grdContaBancaria.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdContaBancaria.CurrentColumn.Key

                Case "editar" : Call EditarContaBancaria()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdContaBancaria_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdContaBancaria.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdContaBancaria.Name,
                                     Formulario.CadastroBasicoFuncionario,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdContaBancaria_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdContaBancaria.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdContaBancaria,
                                     Formulario.CadastroBasicoFuncionario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdContaBancaria_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdContaBancaria.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdContaBancaria.Name,
                                          Formulario.CadastroBasicoFuncionario,
                                          e.Group.Column.Key,
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False),
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ATIVIDADE :::"

    Private Sub btnAgruparGridAtividade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridAtividade.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdAtividade.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdAtividade.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdAtividade.GroupByBoxVisible = True
                grdAtividade.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridAtividade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridAtividade.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdAtividade
            oForm.NomeFormulario = Formulario.CadastroBasicoFuncionario
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdAtividade, Formulario.CadastroBasicoFuncionario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridAtividade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridAtividade.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdAtividade)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirAtividade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirAtividade.Click

        Try

            'Deleta Registros
            Call DeleteAtividade()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirAtividade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirAtividade.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call Salvar()

                'Valida Dados do Formulário
                If ValidacaoAtividade() = True Then

                    'Obtém Código
                    If IsNumeric(btnInserirAtividade.Tag) = False Then

                        'Insere Atividade
                        Call oClsCadFuncionario.InsertAtividade(cboAtividade.SelectedValue)

                    Else

                        'Atualiza Atividade
                        Call oClsCadFuncionario.UpdateAtividade(cboAtividade.SelectedValue,
                                                                grdAtividade.CurrentRow.Cells("codigo").Value)


                    End If

                    'Carrega Grid
                    Call oClsCadFuncionario.LoadGridAtividade(grdAtividade, btnSalvar.Tag)

                    'Prepara Formulário para Inserção de um Novo Registro
                    Call NovoAtividade()

                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdAtividade_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdAtividade.RowDoubleClick

        Try

            'Verifica se a Linha é válida
            If IsNothing(grdAtividade.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdAtividade.CurrentColumn.Key

                Case "editar" : Call EditarAtividade()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdAtividade_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdAtividade.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdAtividade.Name,
                                     Formulario.CadastroBasicoFuncionario,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdAtividade_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdAtividade.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdAtividade,
                                     Formulario.CadastroBasicoFuncionario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdAtividade_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdAtividade.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdAtividade.Name,
                                          Formulario.CadastroBasicoFuncionario,
                                          e.Group.Column.Key,
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False),
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarAtividade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarAtividade.Click
        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadAtividade")

            'Carrega Combo            
            Call LoadCombo(cboAtividade, "sp_select_combo_cadastro_basico_atividade " & goUsuario.iEmpresa)

            'Seta Focu
            cboAtividade.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub


    Private Sub grdSalario_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdSalario.RowDoubleClick
        Try

            'Verifica se a Linha é válida
            If IsNothing(grdSalario.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdSalario.CurrentColumn.Key

                Case "editar" : Call EditarSalario()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirSalario_Click(sender As Object, e As EventArgs) Handles btnInserirSalario.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call Salvar()

                'Valida Dados do Formulário
                If ValidacaoSalario() = True Then

                    'Obtém Código
                    If IsNumeric(btnInserirSalario.Tag) = False Then

                        'Insere Atividade
                        Call oClsCadFuncionario.InsertSalario(dtpDataSalario.Value,
                                                               txtValorSalario.Value,
                                                               IIf(cboAtivoSalario.SelectedIndex = -1, 0, cboAtivoSalario.SelectedValue))

                    Else

                        'Atualiza Atividade
                        Call oClsCadFuncionario.UpdateSalario(dtpDataSalario.Value,
                                                              txtValorSalario.Value,
                                                              IIf(cboAtivoSalario.SelectedIndex = -1, 0, cboAtivoSalario.SelectedValue),
                                                              grdSalario.CurrentRow.Cells("codigo").Value)


                    End If

                    'Carrega Grid
                    Call oClsCadFuncionario.LoadGridSalario(grdSalario, btnSalvar.Tag)

                    'Prepara Formulário para Inserção de um Novo Registro
                    Call NovoSalario()

                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluirSalario_Click(sender As Object, e As EventArgs) Handles btnExcluirSalario.Click
        Try

            'Deleta Registros
            Call DeleteSalario()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnNovoSalario_Click(sender As Object, e As EventArgs) Handles btnNovoSalario.Click
        Try

            Call NovoSalario()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

#End Region

#Region "::: DEPENDENTE :::"

    Private Sub btnAgruparGridDependente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridDependente.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdDependente.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdDependente.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdDependente.GroupByBoxVisible = True
                grdDependente.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridDependente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridDependente.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdDependente
            oForm.NomeFormulario = Formulario.CadastroBasicoFuncionario
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdDependente, Formulario.CadastroBasicoFuncionario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridDependente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridDependente.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdDependente)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirDependente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirDependente.Click

        Try

            'Deleta Registros
            Call DeleteDependente()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirDependente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirDependente.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call Salvar()

                'Valida Dados do Formulário
                If ValidacaoDependente() = True Then

                    'Verifica o Tipo de Operação
                    If IsNumeric(btnInserirDependente.Tag) = False Then

                        'Insere Registro
                        Call oClsCadFuncionario.InsertDependente(txtNomeDependente.Text.Trim,
                                                                 txtParentescoDependente.Text.Trim,
                                                                 dtpDataNascimento.Value,
                                                                 If(chkIR.Checked = True, True, False),
                                                                 If(chkSalFam.Checked = True, True, False))

                    Else

                        'Altera Registro
                        Call oClsCadFuncionario.UpdateDependente(txtNomeDependente.Text.Trim,
                                                                 txtParentescoDependente.Text.Trim,
                                                                 dtpDataNascimento.Value,
                                                                 chkIR.CheckedValue,
                                                                 chkSalFam.CheckedValue,
                                                                 grdDependente.CurrentRow.Cells("codigo").Value)

                    End If

                    'Carrega Grid
                    Call oClsCadFuncionario.LoadGridDependente(grdDependente,
                                                               btnSalvar.Tag)

                    'Prepara Formulário para Inserção de um Novo Registro
                    Call NovoDependente()

                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdDependente_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdDependente.RowDoubleClick

        Try

            'Verifica se a Linha é válida
            If IsNothing(grdDependente.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdDependente.CurrentColumn.Key

                Case "editar" : Call EditarDependente()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdDependente_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdDependente.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdDependente.Name,
                                     Formulario.CadastroBasicoFuncionario,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdDependente_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdDependente.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdDependente,
                                     Formulario.CadastroBasicoFuncionario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdDependente_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdDependente.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdDependente.Name,
                                          Formulario.CadastroBasicoFuncionario,
                                          e.Group.Column.Key,
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False),
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: DOCUMENTOS :::"

    Private Sub btnAgruparGridDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridDocumento.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdDocumento.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdDocumento.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdDocumento.GroupByBoxVisible = True
                grdDocumento.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridDocumento.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdDocumento
            oForm.NomeFormulario = Formulario.CadastroBasicoFuncionario
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdDocumento, Formulario.CadastroBasicoFuncionario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridDocumento.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdDocumento)

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
            Call LoadCombo(cboDocumento, "sp_select_combo_cadastro_basico_documento " & goUsuario.iEmpresa)

            'Seta Focu
            cboDocumento.Focus()

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
            Call LoadCombo(cboTipoArquivo, "sp_select_combo_cadastro_basico_tipo_arquivo " & goUsuario.iEmpresa, False)

            'Seta Focu
            cboTipoArquivo.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnArquivoDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArquivoDocumento.Click

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
                txtArquivoDocumento.Text = arqArquivo.FileName
            End If

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

                    'Váriaveis Locais
                    Dim sArquivoInteracti = LoadDescricao("sp_select_configuracao_interacti_pasta_arquivo " & goUsuario.iEmpresa)

                    'Verifica se o Caminho é Válido
                    If Directory.Exists(sArquivoInteracti) = False Then
                        frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Você não possui Acesso a pasta para Salvar os Arquivos, ou não foi Configurado a Pasta padrão.")
                        Exit Sub
                    End If

                    'Verifica o Tipo de Operação
                    If IsNumeric(btnInserirDocumento.Tag) = False Then

                        'Insere Registro
                        Call oClsCadFuncionario.InsertDocumento(cboDocumento.SelectedValue,
                                                                cboDocumento.Text,
                                                                txtDescricaoDocumento.Text.Trim,
                                                                dtpDataEmissaoDocumento.Value,
                                                                IIf(dtpDataValidadeDocumento.Checked = False, "", dtpDataValidadeDocumento.Value),
                                                                txtAlertaAntecedenciaDia.Value,
                                                                cboTipoArquivo.SelectedValue,
                                                                sArquivoInteracti,
                                                                txtArquivoDocumento.Text.Trim)
                        Call InsertArquivoBD("tb_cad_funcionario",
                                        txtDescricaoDocumento.Text.Trim,
                                        "-",
                                        txtArquivoDocumento.Text.Trim,
                                        cboTipoArquivo.SelectedValue,
                                        oClsCadFuncionario.CodigoFuncionario,
                                        oClsCadFuncionario.CodigoInsertDocumento)

                    Else

                        'Altera Registro
                        Call oClsCadFuncionario.UpdateDocumento(cboDocumento.SelectedValue,
                                                                cboDocumento.Text,
                                                                txtDescricaoDocumento.Text.Trim,
                                                                dtpDataEmissaoDocumento.Value,
                                                                IIf(dtpDataValidadeDocumento.Checked = False, "", dtpDataValidadeDocumento.Value),
                                                                txtAlertaAntecedenciaDia.Value,
                                                                cboTipoArquivo.SelectedValue,
                                                                sArquivoInteracti,
                                                                txtArquivoDocumento.Text.Trim,
                                                                grdDocumento.CurrentRow.Cells("arquivo_interacti").Value,
                                                                grdDocumento.CurrentRow.Cells("codigo").Value)

                    End If

                    'Carrega Grid
                    Call oClsCadFuncionario.LoadGridDocumento(grdDocumento,
                                                              oClsCadFuncionario.CodigoFuncionario)

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

            'Verifica se a Linha é válida
            If IsNothing(grdDocumento.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdDocumento.CurrentColumn.Key
                Case "editar" : Call EditarDocumento()
                Case "visualizar" : Call modFunction.VisualizarDocumentoBD(grdDocumento.CurrentRow.Cells("arquivo").Value, grdDocumento.CurrentRow.Cells("extensao").Value)
                Case "email" : Call Email(grdDocumento.CurrentRow)
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdDocumento_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdDocumento.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdDocumento.Name,
                                     Formulario.CadastroBasicoFuncionario,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdDocumento_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdDocumento.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdDocumento,
                                     Formulario.CadastroBasicoFuncionario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdDocumento_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdDocumento.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdDocumento.Name,
                                          Formulario.CadastroBasicoFuncionario,
                                          e.Group.Column.Key,
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False),
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: JORNADA DE TRABALHO / PAGAMENTO :::"

    Private Sub btnCadastrarCentroGasto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCentroGasto.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCentroGasto")

            'Carrega Combo
            Call LoadCombo(cboCentroGasto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)
            'Seta Focu
            cboCentroGasto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarCentroGasto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCentroGasto.Click

        Try
            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindCentroGasto"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Centro de Gasto"

            'Seta Váriaveis
            oComboBoxFind = cboCentroGasto

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCentroGasto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarTurno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarTurno.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadTurno")

            'Carrega Combo
            Call LoadCombo(cboTurno, "sp_select_combo_cadastro_basico_turno " & goUsuario.iEmpresa)
            'Seta Focu
            cboTurno.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboTurno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTurno.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado Algum Turno
            If cboTurno.SelectedIndex <> -1 Then

                'Carrega dados do Turno
                Call LoadDadosTurno()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboTipoValorPagamento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoValorPagamento.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado Algum Turno
            If cboTipoValorPagamento.SelectedIndex = -1 Then
                txtValorBasePagamento.Enabled = False : txtValorBasePagamento.Value = 0
                txtValorHoraPagamento.Enabled = False : txtValorHoraPagamento.Value = 0
            ElseIf cboTipoValorPagamento.SelectedValue = CInt(TipoValor.ValorFixo) Then
                txtValorBasePagamento.Enabled = True
                txtValorHoraPagamento.Enabled = False : txtValorHoraPagamento.Value = 0
            ElseIf cboTipoValorPagamento.SelectedValue = CInt(TipoValor.ValorHora) Then
                txtValorBasePagamento.Enabled = False : txtValorBasePagamento.Value = 0
                txtValorHoraPagamento.Enabled = True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: AJUDA DE CUSTO :::"

    Private Sub btnAgruparGridAjudaCusto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridAjudaCusto.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdAjudaCusto.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdAjudaCusto.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdAjudaCusto.GroupByBoxVisible = True
                grdAjudaCusto.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridAjudaCusto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridAjudaCusto.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdAjudaCusto
            oForm.NomeFormulario = Formulario.CadastroBasicoFuncionario
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdAjudaCusto, Formulario.CadastroBasicoFuncionario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridAjudaCusto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridAjudaCusto.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdAjudaCusto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarAjudaCusto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarAjudaCusto.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadAjudaCusto")

            'Carrega Combo            
            Call LoadCombo(cboAjudaCusto, "sp_select_combo_cadastro_basico_ajuda_custo " & goUsuario.iEmpresa)

            'Seta Focu
            cboAjudaCusto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluirAjudaCusto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirAjudaCusto.Click

        Try

            'Deleta Registros
            Call DeleteAjudaCusto()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirAjudaCusto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirAjudaCusto.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call Salvar()

                'Valida Dados do Formulário
                If ValidacaoAjudaCusto() = True Then

                    'Obtém Código
                    If IsNumeric(btnInserirAjudaCusto.Tag) = False Then

                        'Insere Serviço
                        Call oClsCadFuncionario.InsertAjudaCusto(cboAjudaCusto.SelectedValue,
                                                                 txtValorAjudaCusto.Value,
                                                                 txtDescontoAjudaCusto.Value)

                    Else

                        'Atualiza Serviço
                        Call oClsCadFuncionario.UpdateAjudaCusto(cboAjudaCusto.SelectedValue,
                                                                 txtValorAjudaCusto.Value,
                                                                 txtDescontoAjudaCusto.Value,
                                                                 grdAjudaCusto.CurrentRow.Cells("codigo").Value)


                    End If

                    'Carrega Grid
                    Call oClsCadFuncionario.LoadGridAjudaCusto(grdAjudaCusto,
                                                            btnSalvar.Tag)

                    'Prepara Formulário para Inserção de um Novo Registro
                    Call NovoAjudaCusto()

                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdAjudaCusto_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdAjudaCusto.RowDoubleClick

        Try

            'Verifica se a Linha é válida
            If IsNothing(grdAjudaCusto.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdAjudaCusto.CurrentColumn.Key

                Case "editar" : Call EditarAjudaCusto()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdAjudaCusto_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdAjudaCusto.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdAjudaCusto.Name,
                                     Formulario.CadastroBasicoFuncionario,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdAjudaCusto_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdAjudaCusto.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdAjudaCusto,
                                     Formulario.CadastroBasicoFuncionario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdAjudaCusto_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdAjudaCusto.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdAjudaCusto.Name,
                                          Formulario.CadastroBasicoFuncionario,
                                          e.Group.Column.Key,
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False),
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: RATEIRO :::"

    Private Sub btnAgruparGridRateio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridRateio.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdRateio.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdRateio.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdRateio.GroupByBoxVisible = True
                grdRateio.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridRateio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridRateio.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdRateio
            oForm.NomeFormulario = Formulario.CadastroBasicoFuncionario
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdRateio, Formulario.CadastroBasicoFuncionario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridRateio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridRateio.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdRateio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarCentroTrabalhoRateio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCentroTrabalhoRateio.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCentroTrabalho")

            'Carrega Combo
            Call LoadCombo(cboCentroTrabalhoRateio, "sp_select_combo_cadastro_basico_centro_trabalho " & goUsuario.iEmpresa)

            'Seta Focu
            cboCentroTrabalhoRateio.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluirRateio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirRateio.Click

        Try

            'Deleta Registros
            Call DeleteRateio()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirRateio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirRateio.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call Salvar()

                'Valida Dados do Formulário
                If ValidacaoRateio() = True Then

                    'Obtém Código
                    If IsNumeric(btnInserirRateio.Tag) = False Then

                        'Insere Serviço
                        Call oClsCadFuncionario.InsertRateio(cboCentroTrabalhoRateio.SelectedValue,
                                                             txtPercentualRateio.Value)

                    Else

                        'Atualiza Serviço
                        Call oClsCadFuncionario.UpdateRateio(cboCentroTrabalhoRateio.SelectedValue,
                                                             txtPercentualRateio.Value,
                                                             grdRateio.CurrentRow.Cells("codigo").Value)


                    End If

                    'Carrega Grid
                    Call oClsCadFuncionario.LoadGridRateio(grdRateio,
                                                           btnSalvar.Tag)

                    'Prepara Formulário para Inserção de um Novo Registro
                    Call NovoRateio()

                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdRateio_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdRateio.RowDoubleClick

        Try

            'Verifica se a Linha é válida
            If IsNothing(grdRateio.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdRateio.CurrentColumn.Key

                Case "editar" : Call EditarRateio()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdRateio_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdRateio.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdRateio.Name,
                                     Formulario.CadastroBasicoFuncionario,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdRateio_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdRateio.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdRateio,
                                     Formulario.CadastroBasicoFuncionario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdRateio_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdRateio.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdRateio.Name,
                                          Formulario.CadastroBasicoFuncionario,
                                          e.Group.Column.Key,
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False),
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FALTA :::"

    Private Sub btnAgruparGridFalta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridFalta.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdFalta.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdFalta.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdFalta.GroupByBoxVisible = True
                grdFalta.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridFalta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridFalta.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdFalta
            oForm.NomeFormulario = Formulario.CadastroBasicoFuncionario
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdFalta, Formulario.CadastroBasicoFuncionario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridFalta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridFalta.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdFalta)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarTipoArquivoFalta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarTipoArquivoFalta.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadTipoArquivo")

            'Carrega Combo            
            Call LoadCombo(cboTipoArquivoFalta, "sp_select_combo_cadastro_basico_tipo_arquivo " & goUsuario.iEmpresa, False)

            'Seta Focu
            cboTipoArquivoFalta.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnArquivoFalta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArquivoFalta.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Campo - Tipo de Arquivo
            If ValidaCampo(cboTipoArquivoFalta, lblTipoArquivoFalta) = False Then
                Exit Sub
            End If

            'Variaveis Locais
            Dim arqArquivo As New OpenFileDialog

            'Abre PopUp para Usuário selecionar Imagem
            arqArquivo.InitialDirectory = "c:\\dados"
            arqArquivo.Filter = LoadDescricao("sp_select_cadastro_basico_extensao_tipo_arquivo " & goUsuario.iEmpresa & "," & cboTipoArquivoFalta.SelectedValue)
            arqArquivo.Title = "Selecione o Arquivo"

            If arqArquivo.ShowDialog() = DialogResult.OK Then
                txtArquivoFalta.Text = arqArquivo.FileName
                txtArquivoFalta.Tag = ""
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirFalta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirFalta.Click

        Try

            'Deleta Registros
            Call DeleteFalta()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirFalta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirFalta.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call Salvar()

                'Valida Dados do Formulário
                If ValidacaoFalta() = True Then

                    'Váriaveis Locais
                    Dim sArquivoInteracti = LoadDescricao("sp_select_configuracao_interacti_pasta_arquivo " & goUsuario.iEmpresa)


                    'Verifica se o Caminho é Válido
                    If Directory.Exists(sArquivoInteracti) = False Then
                        frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Você não possui Acesso a pasta para Salvar os Arquivos, ou não foi Configurado a Pasta padrão.")
                        Exit Sub
                    End If

                    'Obtém Código
                    If IsNumeric(btnInserirFalta.Tag) = False Then

                        'Insere Falta
                        Call oClsCadFuncionario.InsertFalta(cboTipoFalta.SelectedValue,
                                                            txtDescricaoFalta.Text.Trim,
                                                            dtpDataFalta.Value,
                                                            ((txtHoraInicio.Text.Split(":")(0) * 60) + txtHoraInicio.Text.Split(":")(1) + (txtHoraInicio.Text.Split(":")(2) / 60)),
                                                            ((txtHoraTermino.Text.Split(":")(0) * 60) + txtHoraTermino.Text.Split(":")(1) + (txtHoraTermino.Text.Split(":")(2) / 60)),
                                                            cboTipoArquivoFalta.SelectedValue,
                                                            sArquivoInteracti,
                                                            txtArquivoFalta.Text.Trim)

                        Call InsertArquivoBD("tb_cad_funcionario",
                                        txtDescricaoFalta.Text.Trim,
                                        "-",
                                        txtArquivoFalta.Text.Trim,
                                        cboTipoArquivoFalta.SelectedValue,
                                        oClsCadFuncionario.CodigoFuncionario)
                    Else

                        'Atualiza Falta
                        Call oClsCadFuncionario.UpdateFalta(cboTipoFalta.SelectedValue,
                                                            txtDescricaoFalta.Text.Trim,
                                                            dtpDataFalta.Value,
                                                            ((txtHoraInicio.Text.Split(":")(0) * 60) + txtHoraInicio.Text.Split(":")(1) + (txtHoraInicio.Text.Split(":")(2) / 60)),
                                                            ((txtHoraTermino.Text.Split(":")(0) * 60) + txtHoraTermino.Text.Split(":")(1) + (txtHoraTermino.Text.Split(":")(2) / 60)),
                                                            cboTipoArquivoFalta.SelectedValue,
                                                            IIf(IsDBNull(txtArquivoFalta.Tag), "NÃO", sArquivoInteracti),
                                                            txtArquivoFalta.Text.Trim,
                                                            btnInserirFalta.Tag)


                    End If



                    'Carrega Grid
                    Call oClsCadFuncionario.LoadGridFalta(grdFalta, btnSalvar.Tag)

                    'Prepara Formulário para Inserção de um Novo Registro
                    Call NovoFalta()

                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdFalta_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdFalta.RowDoubleClick

        Try

            'Verifica se a Linha é válida
            If IsNothing(grdFalta.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdFalta.CurrentColumn.Key

                Case "editar" : Call EditarFalta()
                Case "visualizar" : Call modFunction.VisualizarDocumentoBD(grdFalta.CurrentRow.Cells("arquivo").Value, grdFalta.CurrentRow.Cells("extensao").Value)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdFalta_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdFalta.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdFalta.Name,
                                     Formulario.CadastroBasicoFuncionario,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdFalta_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdFalta.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdFalta,
                                     Formulario.CadastroBasicoFuncionario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdFalta_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdFalta.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdFalta.Name,
                                          Formulario.CadastroBasicoFuncionario,
                                          e.Group.Column.Key,
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False),
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadFuncionario_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.CadastroBasicoFuncionario, gcDelete)
            btnNovo1.Enabled = VerificaDireito(Formulario.CadastroBasicoFuncionario, gcInsert)
            btnNovo.Enabled = VerificaDireito(Formulario.CadastroBasicoFuncionario, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.CadastroBasicoFuncionario, gcPrint)
            btnExcelGridDocumento.Enabled = VerificaDireito(Formulario.CadastroBasicoFuncionario, gcPrint)
            btnExcelGridAjudaCusto.Enabled = VerificaDireito(Formulario.CadastroBasicoFuncionario, gcPrint)
            btnExcelGridContaBancaria.Enabled = VerificaDireito(Formulario.CadastroBasicoFuncionario, gcPrint)
            btnExcelGridDependente.Enabled = VerificaDireito(Formulario.CadastroBasicoFuncionario, gcPrint)
            btnExcelGridOperacao.Enabled = VerificaDireito(Formulario.CadastroBasicoFuncionario, gcPrint)
            btnExcelGridRateio.Enabled = VerificaDireito(Formulario.CadastroBasicoFuncionario, gcPrint)

            'Verifica Direito - Cadastrar
            btnCadastrarOcupacao.Enabled = VerificaDireito(Formulario.CadastroBasicoOcupacao, gcInsert)
            btnCadastrarCentroTrabalho.Enabled = VerificaDireito(Formulario.CadastroBasicoCentroTrabalho, gcInsert)
            btnCadastrarOperacao.Enabled = VerificaDireito(Formulario.CadastroBasicoOperacao, gcInsert)
            btnCadastrarBanco.Enabled = VerificaDireito(Formulario.CadastroBasicoBanco, gcInsert)
            btnCadastrarDocumento.Enabled = VerificaDireito(Formulario.CadastroBasicoDocumento, gcInsert)
            btnCadastrarPais.Enabled = VerificaDireito(Formulario.CadastroBasicoPais, gcInsert)
            btnCadastrarTipoArquivo.Enabled = VerificaDireito(Formulario.CadastroBasicoTipoArquivo, gcInsert)
            btnCadastrarTurno.Enabled = VerificaDireito(Formulario.CadastroBasicoTurno, gcInsert)
            btnCadastrarAjudaCusto.Enabled = VerificaDireito(Formulario.CadastroBasicoAjudaCusto, gcInsert)
            btnCadastrarCentroGasto.Enabled = VerificaDireito(Formulario.CadastroBasicoCentroGasto, gcInsert)
            btnCadastrarCentroTrabalhoRateio.Enabled = VerificaDireito(Formulario.CadastroBasicoCentroTrabalho, gcInsert)
            btnCadastrarAtividade.Enabled = VerificaDireito(Formulario.CadastroBasicoAtividade, gcInsert)

            'Filtros
            Call LoadComboSimNao(cboAtivoFiltro)
            'Define como padrão o SIM
            cboAtivoFiltro.SelectedValue = 1

            'Carrega Combo - Dados Gerais
            LoadCombo(cboPais, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)
            Call LoadCombo(cboOcupacao, "sp_select_combo_cadastro_basico_ocupacao " & goUsuario.iEmpresa)
            Call LoadCombo(cboUFCTPS, "sp_select_combo_static_estado_codigo_pais " & CInt(Pais.Brasil))
            'Call LoadCombo(cboCategoriaCNH, "sp_select_combo_static_categoria_cnh")
            Call LoadComboSimNao(cboAtivo)
            Call LoadCombo(cboNivelPermissaoAPP, "sp_select_combo_static_nivel_permissao_app ")

            'Carrega Combo - Atividade
            ' Call LoadCombo(cboAtividade, "sp_select_combo_cadastro_basico_atividade " & goUsuario.iEmpresa)
            'Carrega Combo - Centro de Trabalho
            Call LoadCombo(cboCentroTrabalho, "sp_select_combo_cadastro_basico_centro_trabalho " & goUsuario.iEmpresa & ",'TODOS'")
            'Carrega Combo - Dados Bancários
            Call LoadCombo(cboBanco, "sp_select_combo_cadastro_basico_banco " & goUsuario.iEmpresa)
            Call LoadCombo(cboTipoContaBancaria, "sp_select_combo_static_tipo_conta_bancaria")
            Call LoadComboSimNao(cboContaPagamento)
            'Carrega Combo - Dados Pessoais
            Call LoadCombo(cboSexo, "sp_select_combo_static_sexo")
            Call LoadCombo(cboEstadoCivil, "sp_select_combo_static_estado_civil")
            Call LoadCombo(cboFormacao, "sp_select_combo_static_formacao")
            'Carrega Combo - Documento
            Call LoadCombo(cboDocumento, "sp_select_combo_cadastro_basico_documento_tipo " & goUsuario.iEmpresa & ", " & TipoDocumento.Funcionario)
            Call LoadCombo(cboTipoArquivo, "sp_select_combo_cadastro_basico_tipo_arquivo " & goUsuario.iEmpresa, False)
            'Carrega Combo - Jornada de Trabalho / Pagamento
            Call LoadCombo(cboTipoValorPagamento, "sp_select_combo_static_tipo_valor")
            Call LoadComboSimNao(cboBancoHoraPagamento)
            Call LoadCombo(cboTurno, "sp_select_combo_cadastro_basico_turno " & goUsuario.iEmpresa)
            Call LoadCombo(cboCentroGasto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboTipoContrato, "sp_select_combo_static_tipo_contrato_trabalho", False)
            Dim oComboBox(13) As UIComboBox
            oComboBox(0) = cboHoraExtraSegundaPagamento : oComboBox(1) = cboHoraExtraTercaPagamento
            oComboBox(2) = cboHoraExtraQuartaPagamento : oComboBox(3) = cboHoraExtraQuintaPagamento
            oComboBox(4) = cboHoraExtraSextaPagamento : oComboBox(5) = cboHoraExtraSabadoPagamento : oComboBox(6) = cboHoraExtraDomingoPagamento
            oComboBox(7) = cboHoraExtraAposSegundaPagamento : oComboBox(8) = cboHoraExtraAposTercaPagamento
            oComboBox(9) = cboHoraExtraAposQuartaPagamento : oComboBox(10) = cboHoraExtraAposQuintaPagamento
            oComboBox(11) = cboHoraExtraAposSextaPagamento : oComboBox(12) = cboHoraExtraAposSabadoPagamento : oComboBox(13) = cboHoraExtraAposDomingoPagamento
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_tipo_hora_extra " & goUsuario.iEmpresa)
            'Carrega Combo - Ajuda de Custo
            Call LoadCombo(cboAjudaCusto, "sp_select_combo_cadastro_basico_ajuda_custo " & goUsuario.iEmpresa, False)
            'Carrega Combo - Centro de Trabalho Rateio
            Call LoadCombo(cboCentroTrabalhoRateio, "sp_select_combo_cadastro_basico_centro_trabalho " & goUsuario.iEmpresa)
            'Falta
            Call LoadCombo(cboTipoFalta, "sp_select_combo_static_tipo_falta")
            Call LoadCombo(cboTipoArquivoFalta, "sp_select_combo_cadastro_basico_tipo_arquivo " & goUsuario.iEmpresa, False)

            Call LoadCombo(cboTurnoRelatorio, "sp_select_combo_static_turno_relatorio", False)

            Call LoadCombo(cboMaquinaEquipamento, "sp_select_combo_cadastro_basico_maquina " & goUsuario.iEmpresa, False)

            Call LoadComboSimNao(cboAtivoSalario)

            'Seta Controles
            dtpDataNascimentoFuncionario.Value = Now.Date
            dtpDataAdmissao.Value = Now.Date
            dtpDataDemissao.Value = Now.Date : dtpDataDemissao.Checked = False
            dtpDataEmissaoCTPS.Value = Now.Date
            dtpDataEmissaoDocumento.Value = Now.Date
            dtpDataExpedicao.Value = Now.Date
            dtpDataExpedicaoPISPASEP.Value = Now.Date
            dtpDataSalario.Value = Now.Date

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoFuncionario)
            Call ConfiguraGrid(grdOperacao, Formulario.CadastroBasicoFuncionario)
            Call ConfiguraGrid(grdAtividade, Formulario.CadastroBasicoFuncionario)
            Call ConfiguraGrid(grdDocumento, Formulario.CadastroBasicoFuncionario)
            Call ConfiguraGrid(grdContaBancaria, Formulario.CadastroBasicoFuncionario)
            Call ConfiguraGrid(grdDependente, Formulario.CadastroBasicoFuncionario)
            Call ConfiguraGrid(grdAjudaCusto, Formulario.CadastroBasicoAjudaCusto)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            txtProntuarioFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCIONÁRIO :::"

    Private Sub Delete()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdListagem, "main") = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & IIf(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCadFuncionario.Delete()

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
            txtProntuario.Text = ""
            txtNome.Text = ""
            txtCTPS.Text = ""
            txtSerieCTPS.Text = ""
            cboUFCTPS.SelectedIndex = -1
            dtpDataEmissaoCTPS.Value = Now.Date : dtpDataEmissaoCTPS.Checked = False
            txtCPF.Text = ""
            txtRG.Text = ""
            dtpDataExpedicao.Value = Now.Date : dtpDataExpedicao.Checked = False
            txtOrgaoEmissor.Text = ""
            txtTituloEleitor.Text = ""
            txtZona.Text = ""
            txtSecao.Text = ""
            txtCNH.Text = ""
            txtCategoriaCNH.Text = ""
            txtCertificadoMilitar.Text = ""
            txtPISPASEP.Text = ""
            dtpDataExpedicaoPISPASEP.Value = Now.Date : dtpDataExpedicaoPISPASEP.Checked = False
            btnSalvar.Tag = ""
            cboTurnoRelatorio.SelectedIndex = -1
            cboMaquinaEquipamento.SelectedIndex = -1
            cboAtivo.SelectedIndex = -1
            txtEscolhasApontamento.Value = 0
            cboNivelPermissaoAPP.SelectedIndex = -1


            'Limpa Controles - Dados Gerais
            txtCEP.Text = ""
            cboPais.SelectedIndex = -1
            cboUF.SelectedIndex = -1 : cboUF.Text = ""
            cboMunicipio.SelectedIndex = -1 : cboMunicipio.Text = ""
            txtLogradouro.Text = ""
            txtNumero.Text = ""
            txtBairro.Text = ""
            txtComplemento.Text = ""
            txtEmail.Text = ""
            dtpDataNascimentoFuncionario.Value = Now.Date
            txtTelefone1.Text = ""
            txtTelefone2.Text = ""
            txtNextel.Text = ""
            txtTelefoneRecado.Text = ""
            txtFoto.Text = ""
            picFoto.Image = Nothing
            dtpDataAdmissao.Value = Now.Date
            dtpDataDemissao.Value = Now.Date : dtpDataDemissao.Checked = False
            txtCargo.Text = ""
            cboOcupacao.SelectedIndex = -1
            txtObservacao.Text = ""

            'Limpa Controles - Centro de Trabalho
            cboCentroTrabalho.SelectedIndex = -1
            cboOperacao.SelectedIndex = -1
            grdOperacao.DataSource = Nothing
            btnInserirOperacao.Tag = ""

            'Limpa Controles - Atividade
            cboAtividade.SelectedIndex = -1
            btnInserirAtividade.Tag = ""
            grdAtividade.DataSource = Nothing

            'Limpa Controles - Salario
            Call NovoSalario()

            'Limpa Controles - Dados Bancários
            cboBanco.SelectedIndex = -1
            cboTipoContaBancaria.SelectedIndex = -1
            txtAgencia.Text = ""
            txtConta.Text = ""
            txtDigitoConta.Text = ""
            cboContaPagamento.SelectedIndex = -1
            grdContaBancaria.DataSource = Nothing
            btnInserirContaBancaria.Tag = ""

            'Limpa Controles - Dados Pessoais
            cboSexo.SelectedIndex = -1
            cboEstadoCivil.SelectedIndex = -1
            txtNomeConjuge.Text = ""
            cboFormacao.SelectedIndex = -1
            txtNomePai.Text = ""
            txtNomeMae.Text = ""
            txtNomeDependente.Text = ""
            txtParentescoDependente.Text = ""
            dtpDataNascimento.Value = Now.Date : dtpDataNascimento.Checked = False
            chkIR.Checked = False
            chkSalFam.Checked = False
            grdDependente.DataSource = Nothing
            btnInserirDependente.Tag = ""

            'Limpa Controles - Documento
            cboDocumento.SelectedIndex = -1
            txtDescricaoDocumento.Text = ""
            dtpDataEmissaoDocumento.Value = Now.Date
            dtpDataValidadeDocumento.Value = Now.Date : dtpDataValidadeDocumento.Checked = False
            cboTipoArquivo.SelectedIndex = -1
            txtArquivoDocumento.Text = ""
            grdDocumento.DataSource = Nothing
            btnInserirDocumento.Tag = ""

            'Limpa Controles - Jornada de Trabalho / Pagamento
            cboTipoValorPagamento.SelectedIndex = -1
            txtValorBasePagamento.Value = 0
            txtValorHoraPagamento.Value = 0
            txtAdicionalNoturnoPagamento.Value = 0
            cboBancoHoraPagamento.SelectedIndex = -1
            cboTurno.SelectedIndex = -1
            cboCentroGasto.SelectedIndex = -1
            cboTipoContrato.SelectedIndex = -1
            txtObservacaoTipoContrato.Text = ""
            txtHoraEntradaSegunda.Text = "00:00:00"
            txtHoraEntradaTerca.Text = "00:00:00"
            txtHoraEntradaQuarta.Text = "00:00:00"
            txtHoraEntradaQuinta.Text = "00:00:00"
            txtHoraEntradaSexta.Text = "00:00:00"
            txtHoraEntradaSabado.Text = "00:00:00"
            txtHoraEntradaDomingo.Text = "00:00:00"
            txtHoraSaidaSegunda.Text = "00:00:00"
            txtHoraSaidaTerca.Text = "00:00:00"
            txtHoraSaidaQuarta.Text = "00:00:00"
            txtHoraSaidaQuinta.Text = "00:00:00"
            txtHoraSaidaSexta.Text = "00:00:00"
            txtHoraSaidaSabado.Text = "00:00:00"
            txtHoraSaidaDomingo.Text = "00:00:00"
            txtHoraAlmocoSegundaInicio.Text = "00:00:00"
            txtHoraAlmocoTercaInicio.Text = "00:00:00"
            txtHoraAlmocoQuartaInicio.Text = "00:00:00"
            txtHoraAlmocoQuintaInicio.Text = "00:00:00"
            txtHoraAlmocoSextaInicio.Text = "00:00:00"
            txtHoraAlmocoSabadoInicio.Text = "00:00:00"
            txtHoraAlmocoDomingoInicio.Text = "00:00:00"
            txtHoraAlmocoSegundaTermino.Text = "00:00:00"
            txtHoraAlmocoTercaTermino.Text = "00:00:00"
            txtHoraAlmocoQuartaTermino.Text = "00:00:00"
            txtHoraAlmocoQuintaTermino.Text = "00:00:00"
            txtHoraAlmocoSextaTermino.Text = "00:00:00"
            txtHoraAlmocoSabadoTermino.Text = "00:00:00"
            txtHoraAlmocoDomingoTermino.Text = "00:00:00"
            txtHoraIntervaloSegundaInicio.Text = "00:00:00"
            txtHoraIntervaloTercaInicio.Text = "00:00:00"
            txtHoraIntervaloQuartaInicio.Text = "00:00:00"
            txtHoraIntervaloQuintaInicio.Text = "00:00:00"
            txtHoraIntervaloSextaInicio.Text = "00:00:00"
            txtHoraIntervaloSabadoInicio.Text = "00:00:00"
            txtHoraIntervaloDomingoInicio.Text = "00:00:00"
            txtHoraIntervaloSegundaTermino.Text = "00:00:00"
            txtHoraIntervaloTercaTermino.Text = "00:00:00"
            txtHoraIntervaloQuartaTermino.Text = "00:00:00"
            txtHoraIntervaloQuintaTermino.Text = "00:00:00"
            txtHoraIntervaloSextaTermino.Text = "00:00:00"
            txtHoraIntervaloSabadoTermino.Text = "00:00:00"
            txtHoraIntervaloDomingoTermino.Text = "00:00:00"
            txtHoraAdicionaNoturnoInicio.Text = "00:00:00"
            txtHoraAdicionaNoturnoTermino.Text = "00:00:00"
            cboHoraExtraSegundaPagamento.SelectedIndex = -1
            txtHoraExtraAposSegundaPagamento.Value = 0
            cboHoraExtraAposSegundaPagamento.SelectedIndex = -1
            cboHoraExtraTercaPagamento.SelectedIndex = -1
            txtHoraExtraAposTercaPagamento.Value = 0
            cboHoraExtraAposTercaPagamento.SelectedIndex = -1
            cboHoraExtraQuartaPagamento.SelectedIndex = -1
            txtHoraExtraAposQuartaPagamento.Value = 0
            cboHoraExtraAposQuartaPagamento.SelectedIndex = -1
            cboHoraExtraQuintaPagamento.SelectedIndex = -1
            txtHoraExtraAposQuintaPagamento.Value = 0
            cboHoraExtraAposQuintaPagamento.SelectedIndex = -1
            cboHoraExtraSextaPagamento.SelectedIndex = -1
            txtHoraExtraAposSextaPagamento.Value = 0
            cboHoraExtraAposSextaPagamento.SelectedIndex = -1
            cboHoraExtraSabadoPagamento.SelectedIndex = -1
            txtHoraExtraAposSabadoPagamento.Value = 0
            cboHoraExtraAposSabadoPagamento.SelectedIndex = -1
            cboHoraExtraDomingoPagamento.SelectedIndex = -1
            txtHoraExtraAposDomingoPagamento.Value = 0
            cboHoraExtraAposDomingoPagamento.SelectedIndex = -1

            'Limpa Controles - Falta
            cboTipoFalta.Text = ""
            txtDescricaoFalta.Text = ""
            dtpDataFalta.Value = Now.Date
            cboTipoArquivoFalta.Text = ""
            txtArquivoFalta.Text = ""
            txtArquivoFalta.Tag = ""
            btnInserirFalta.Tag = ""

            'Limpa Controles - Rateio
            cboCentroTrabalhoRateio.SelectedIndex = -1
            txtPercentualRateio.Value = 0
            btnInserirRateio.Tag = ""
            grdRateio.DataSource = Nothing

            'Habilita Controles
            btnSalvar.Enabled = True
            btnInserirContaBancaria.Enabled = True : btnExcluirContaBancaria.Enabled = VerificaDireito(Formulario.CadastroBasicoFuncionario, gcDelete)
            btnInserirDependente.Enabled = True : btnExcluirDependente.Enabled = VerificaDireito(Formulario.CadastroBasicoFuncionario, gcDelete)
            btnInserirDocumento.Enabled = True : btnExcluirDocumento.Enabled = VerificaDireito(Formulario.CadastroBasicoFuncionario, gcDelete)
            btnInserirOperacao.Enabled = True : btnExcluirOperacao.Enabled = VerificaDireito(Formulario.CadastroBasicoFuncionario, gcDelete)

            'Seta Aba
            tabDados.SelectedTab = pagDadosGerais

            'Seta Focu
            txtProntuario.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar(iCodigo As Long)

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoFuncionario, gcUpdate) = True Then

                'Limpa Controle
                frmMain.errInfo.Clear()

                'Limpa Formulário
                Call Novo()

                'Carrega Controles
                Call oClsCadFuncionario.LoadDados(iCodigo,
                                                  txtProntuario,
                                                  txtNome,
                                                  cboMaquinaEquipamento,
                                                  txtCTPS,
                                                  txtSerieCTPS,
                                                  cboUFCTPS,
                                                  dtpDataEmissaoCTPS,
                                                  txtCPF,
                                                  txtRG,
                                                  dtpDataExpedicao,
                                                  txtOrgaoEmissor,
                                                  txtTituloEleitor,
                                                  txtZona,
                                                  txtSecao,
                                                  txtCNH,
                                                  txtCategoriaCNH,
                                                  txtCertificadoMilitar,
                                                  txtPISPASEP,
                                                  dtpDataExpedicaoPISPASEP,
                                                  txtCEP,
                                                  cboPais,
                                                  cboUF,
                                                  cboMunicipio,
                                                  txtLogradouro,
                                                  txtNumero,
                                                  txtBairro,
                                                  txtComplemento,
                                                  dtpDataNascimentoFuncionario,
                                                  txtEmail,
                                                  txtTelefone1,
                                                  txtTelefone2,
                                                  txtNextel,
                                                  txtTelefoneRecado,
                                                  dtpDataAdmissao,
                                                  dtpDataDemissao,
                                                  txtCargo,
                                                  cboOcupacao,
                                                  txtObservacao,
                                                  picFoto,
                                                  cboSexo,
                                                  cboEstadoCivil,
                                                  txtNomeConjuge,
                                                  cboFormacao,
                                                  txtNomePai,
                                                  txtNomeMae,
                                                  cboTipoValorPagamento,
                                                  txtValorBasePagamento,
                                                  txtValorHoraPagamento,
                                                  txtAdicionalNoturnoPagamento,
                                                  cboBancoHoraPagamento,
                                                  cboCentroGasto,
                                                  cboTipoContrato,
                                                  txtObservacaoTipoContrato,
                                                  cboTurno,
                                                  txtHoraEntradaSegunda,
                                                  txtHoraEntradaTerca,
                                                  txtHoraEntradaQuarta,
                                                  txtHoraEntradaQuinta,
                                                  txtHoraEntradaSexta,
                                                  txtHoraEntradaSabado,
                                                  txtHoraEntradaDomingo,
                                                  txtHoraSaidaSegunda,
                                                  txtHoraSaidaTerca,
                                                  txtHoraSaidaQuarta,
                                                  txtHoraSaidaQuinta,
                                                  txtHoraSaidaSexta,
                                                  txtHoraSaidaSabado,
                                                  txtHoraSaidaDomingo,
                                                  txtHoraAlmocoSegundaInicio,
                                                  txtHoraAlmocoTercaInicio,
                                                  txtHoraAlmocoQuartaInicio,
                                                  txtHoraAlmocoQuintaInicio,
                                                  txtHoraAlmocoSextaInicio,
                                                  txtHoraAlmocoSabadoInicio,
                                                  txtHoraAlmocoDomingoInicio,
                                                  txtHoraAlmocoSegundaTermino,
                                                  txtHoraAlmocoTercaTermino,
                                                  txtHoraAlmocoQuartaTermino,
                                                  txtHoraAlmocoQuintaTermino,
                                                  txtHoraAlmocoSextaTermino,
                                                  txtHoraAlmocoSabadoTermino,
                                                  txtHoraAlmocoDomingoTermino,
                                                  txtHoraIntervaloSegundaInicio,
                                                  txtHoraIntervaloTercaInicio,
                                                  txtHoraIntervaloQuartaInicio,
                                                  txtHoraIntervaloQuintaInicio,
                                                  txtHoraIntervaloSextaInicio,
                                                  txtHoraIntervaloSabadoInicio,
                                                  txtHoraIntervaloDomingoInicio,
                                                  txtHoraIntervaloSegundaTermino,
                                                  txtHoraIntervaloTercaTermino,
                                                  txtHoraIntervaloQuartaTermino,
                                                  txtHoraIntervaloQuintaTermino,
                                                  txtHoraIntervaloSextaTermino,
                                                  txtHoraIntervaloSabadoTermino,
                                                  txtHoraIntervaloDomingoTermino,
                                                  txtHoraAdicionaNoturnoInicio,
                                                  txtHoraAdicionaNoturnoTermino,
                                                  cboHoraExtraSegundaPagamento,
                                                  txtHoraExtraAposSegundaPagamento,
                                                  cboHoraExtraAposSegundaPagamento,
                                                  cboHoraExtraTercaPagamento,
                                                  txtHoraExtraAposTercaPagamento,
                                                  cboHoraExtraAposTercaPagamento,
                                                  cboHoraExtraQuartaPagamento,
                                                  txtHoraExtraAposQuartaPagamento,
                                                  cboHoraExtraAposQuartaPagamento,
                                                  cboHoraExtraQuintaPagamento,
                                                  txtHoraExtraAposQuintaPagamento,
                                                  cboHoraExtraAposQuintaPagamento,
                                                  cboHoraExtraSextaPagamento,
                                                  txtHoraExtraAposSextaPagamento,
                                                  cboHoraExtraAposSextaPagamento,
                                                  cboHoraExtraSabadoPagamento,
                                                  txtHoraExtraAposSabadoPagamento,
                                                  cboHoraExtraAposSabadoPagamento,
                                                  cboHoraExtraDomingoPagamento,
                                                  txtHoraExtraAposDomingoPagamento,
                                                  cboHoraExtraAposDomingoPagamento,
                                                  cboTurnoRelatorio,
                                                  cboAtivo,
                                                  cboNivelPermissaoAPP,
                                                  txtEscolhasApontamento)

                'Seta Controle
                btnSalvar.Tag = iCodigo

                'Carrega Grid - Serviço
                oClsCadFuncionario.LoadGridOperacao(grdOperacao, iCodigo)

                'Carrega Grid - Conta Bancária
                oClsCadFuncionario.LoadGridContaBancaria(grdContaBancaria, iCodigo)

                'Carrega Grid - Dependente
                oClsCadFuncionario.LoadGridDependente(grdDependente, iCodigo)

                'Carrega Grid - Documento
                oClsCadFuncionario.LoadGridDocumento(grdDocumento, iCodigo)

                'Carrega Grid - Ajuda de Custo
                oClsCadFuncionario.LoadGridAjudaCusto(grdAjudaCusto, iCodigo)

                'Carrega Grid - Rateio
                oClsCadFuncionario.LoadGridRateio(grdRateio, iCodigo)

                'Carrega Grid - Atividade
                oClsCadFuncionario.LoadGridAtividade(grdAtividade, iCodigo)

                'Carrega Grid - Falta
                Call oClsCadFuncionario.LoadGridFalta(grdFalta, iCodigo)

                'Carrega Grid - Salario
                Call oClsCadFuncionario.LoadGridSalario(grdSalario, btnSalvar.Tag)

                'Seta Aba Default
                tabDados.SelectedTab = pagDadosGerais

                'Alterna Aba
                If tabMain.SelectedTab.Name <> pagDados.Name Then
                    'Foca Aba
                    tabDados.SelectedTab = pagDadosGerais

                    'Alterna Aba
                    tabMain.TabPages.Remove(pagLista)
                    tabMain.TabPages.Add(pagDados)
                End If

                'Seta Focu
                txtProntuario.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Visualizar()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoFuncionario, gcSelect) = True Then

                'Limpa Controle
                frmMain.errInfo.Clear()

                'Limpa Formulário
                Call Novo()

                'Carrega Controles
                Call oClsCadFuncionario.LoadDados(grdListagem.CurrentRow.Cells("codigo").Value,
                                                  txtProntuario,
                                                  txtNome,
                                                  cboMaquinaEquipamento,
                                                  txtCTPS,
                                                  txtSerieCTPS,
                                                  cboUFCTPS,
                                                  dtpDataEmissaoCTPS,
                                                  txtCPF,
                                                  txtRG,
                                                  dtpDataExpedicao,
                                                  txtOrgaoEmissor,
                                                  txtTituloEleitor,
                                                  txtZona,
                                                  txtSecao,
                                                  txtCNH,
                                                  txtCategoriaCNH,
                                                  txtCertificadoMilitar,
                                                  txtPISPASEP,
                                                  dtpDataExpedicaoPISPASEP,
                                                  txtCEP,
                                                  cboPais,
                                                  cboUF,
                                                  cboMunicipio,
                                                  txtLogradouro,
                                                  txtNumero,
                                                  txtBairro,
                                                  txtComplemento,
                                                  dtpDataNascimentoFuncionario,
                                                  txtEmail,
                                                  txtTelefone1,
                                                  txtTelefone2,
                                                  txtNextel,
                                                  txtTelefoneRecado,
                                                  dtpDataAdmissao,
                                                  dtpDataDemissao,
                                                  txtCargo,
                                                  cboOcupacao,
                                                  txtObservacao,
                                                  picFoto,
                                                  cboSexo,
                                                  cboEstadoCivil,
                                                  txtNomeConjuge,
                                                  cboFormacao,
                                                  txtNomePai,
                                                  txtNomeMae,
                                                  cboTipoValorPagamento,
                                                  txtValorBasePagamento,
                                                  txtValorHoraPagamento,
                                                  txtAdicionalNoturnoPagamento,
                                                  cboBancoHoraPagamento,
                                                  cboCentroGasto,
                                                  cboTipoContrato,
                                                  txtObservacaoTipoContrato,
                                                  cboTurno,
                                                  txtHoraEntradaSegunda,
                                                  txtHoraEntradaTerca,
                                                  txtHoraEntradaQuarta,
                                                  txtHoraEntradaQuinta,
                                                  txtHoraEntradaSexta,
                                                  txtHoraEntradaSabado,
                                                  txtHoraEntradaDomingo,
                                                  txtHoraSaidaSegunda,
                                                  txtHoraSaidaTerca,
                                                  txtHoraSaidaQuarta,
                                                  txtHoraSaidaQuinta,
                                                  txtHoraSaidaSexta,
                                                  txtHoraSaidaSabado,
                                                  txtHoraSaidaDomingo,
                                                  txtHoraAlmocoSegundaInicio,
                                                  txtHoraAlmocoTercaInicio,
                                                  txtHoraAlmocoQuartaInicio,
                                                  txtHoraAlmocoQuintaInicio,
                                                  txtHoraAlmocoSextaInicio,
                                                  txtHoraAlmocoSabadoInicio,
                                                  txtHoraAlmocoDomingoInicio,
                                                  txtHoraAlmocoSegundaTermino,
                                                  txtHoraAlmocoTercaTermino,
                                                  txtHoraAlmocoQuartaTermino,
                                                  txtHoraAlmocoQuintaTermino,
                                                  txtHoraAlmocoSextaTermino,
                                                  txtHoraAlmocoSabadoTermino,
                                                  txtHoraAlmocoDomingoTermino,
                                                  txtHoraIntervaloSegundaInicio,
                                                  txtHoraIntervaloTercaInicio,
                                                  txtHoraIntervaloQuartaInicio,
                                                  txtHoraIntervaloQuintaInicio,
                                                  txtHoraIntervaloSextaInicio,
                                                  txtHoraIntervaloSabadoInicio,
                                                  txtHoraIntervaloDomingoInicio,
                                                  txtHoraIntervaloSegundaTermino,
                                                  txtHoraIntervaloTercaTermino,
                                                  txtHoraIntervaloQuartaTermino,
                                                  txtHoraIntervaloQuintaTermino,
                                                  txtHoraIntervaloSextaTermino,
                                                  txtHoraIntervaloSabadoTermino,
                                                  txtHoraIntervaloDomingoTermino,
                                                  txtHoraAdicionaNoturnoInicio,
                                                  txtHoraAdicionaNoturnoTermino,
                                                  cboHoraExtraSegundaPagamento,
                                                  txtHoraExtraAposSegundaPagamento,
                                                  cboHoraExtraAposSegundaPagamento,
                                                  cboHoraExtraTercaPagamento,
                                                  txtHoraExtraAposTercaPagamento,
                                                  cboHoraExtraAposTercaPagamento,
                                                  cboHoraExtraQuartaPagamento,
                                                  txtHoraExtraAposQuartaPagamento,
                                                  cboHoraExtraAposQuartaPagamento,
                                                  cboHoraExtraQuintaPagamento,
                                                  txtHoraExtraAposQuintaPagamento,
                                                  cboHoraExtraAposQuintaPagamento,
                                                  cboHoraExtraSextaPagamento,
                                                  txtHoraExtraAposSextaPagamento,
                                                  cboHoraExtraAposSextaPagamento,
                                                  cboHoraExtraSabadoPagamento,
                                                  txtHoraExtraAposSabadoPagamento,
                                                  cboHoraExtraAposSabadoPagamento,
                                                  cboHoraExtraDomingoPagamento,
                                                  txtHoraExtraAposDomingoPagamento,
                                                  cboHoraExtraAposDomingoPagamento,
                                                  cboTurnoRelatorio,
                                                  cboAtivo,
                                                  cboNivelPermissaoAPP,
                                                  txtEscolhasApontamento)

                'Seta Controle
                btnSalvar.Tag = grdListagem.CurrentRow.Cells("codigo").Value

                'Carrega Grid - Operação
                oClsCadFuncionario.LoadGridOperacao(grdOperacao,
                                                    grdListagem.CurrentRow.Cells("codigo").Value)

                'Carrega Grid - Conta Bancária
                oClsCadFuncionario.LoadGridContaBancaria(grdContaBancaria,
                                                         grdListagem.CurrentRow.Cells("codigo").Value)

                'Carrega Grid - Dependente
                oClsCadFuncionario.LoadGridDependente(grdDependente,
                                                      grdListagem.CurrentRow.Cells("codigo").Value)

                'Carrega Grid - Documento
                oClsCadFuncionario.LoadGridDocumento(grdDocumento,
                                                     grdListagem.CurrentRow.Cells("codigo").Value)

                'Carrega Grid - Ajuda de Custo
                oClsCadFuncionario.LoadGridAjudaCusto(grdAjudaCusto,
                                                      grdListagem.CurrentRow.Cells("codigo").Value)

                'Habilita Controles
                btnSalvar.Enabled = False
                btnInserirContaBancaria.Enabled = False : btnExcluirContaBancaria.Enabled = False
                btnInserirDependente.Enabled = False : btnExcluirDependente.Enabled = False
                btnInserirDocumento.Enabled = False : btnExcluirDocumento.Enabled = False
                btnInserirOperacao.Enabled = False : btnExcluirOperacao.Enabled = False

                'Seta Aba Default
                tabDados.SelectedTab = pagDadosGerais

                'Alterna Aba
                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                txtProntuario.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCadFuncionario.CodigoFuncionario = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0)
            oClsCadFuncionario.Prontuario = txtProntuario.Text.Trim
            oClsCadFuncionario.Nome = txtNome.Text.Trim
            oClsCadFuncionario.CodigoMaquina = IIf(cboMaquinaEquipamento.SelectedIndex = -1, -1, cboMaquinaEquipamento.SelectedValue)
            oClsCadFuncionario.CTPS = txtCTPS.Text.Trim
            oClsCadFuncionario.SerieCTPS = txtSerieCTPS.Text.Trim
            oClsCadFuncionario.UFCTPS = IIf(cboUFCTPS.SelectedIndex = -1, "", cboUFCTPS.SelectedValue)
            oClsCadFuncionario.DataEmissaoCTPS = IIf(dtpDataEmissaoCTPS.Checked = True, dtpDataEmissaoCTPS.Value, "")
            oClsCadFuncionario.CPF = txtCPF.Text.Trim
            oClsCadFuncionario.RG = txtRG.Text.Trim
            oClsCadFuncionario.DataExpedicaoRG = IIf(dtpDataExpedicao.Checked = True, dtpDataExpedicao.Value, "")
            oClsCadFuncionario.OrgaoEmissor = txtOrgaoEmissor.Text.Trim
            oClsCadFuncionario.TituloEleitor = txtTituloEleitor.Text.Trim
            oClsCadFuncionario.ZonaEleitoral = txtZona.Text.Trim
            oClsCadFuncionario.SecaoEleitoral = txtSecao.Text.Trim
            oClsCadFuncionario.CNH = txtCNH.Text.Trim
            oClsCadFuncionario.CategoriaCNH = txtCategoriaCNH.Text.Trim
            oClsCadFuncionario.CertificadoMilitar = txtCertificadoMilitar.Text.Trim
            oClsCadFuncionario.PISPASEP = txtPISPASEP.Text.Trim
            oClsCadFuncionario.DataExpedicaoPISPASEP = IIf(dtpDataExpedicaoPISPASEP.Checked = True, dtpDataExpedicaoPISPASEP.Value, "")
            oClsCadFuncionario.CodigoTurnoRelatorio = IIf(cboTurnoRelatorio.SelectedIndex = -1, -1, cboTurnoRelatorio.SelectedValue)
            oClsCadFuncionario.Ativo = IIf(cboAtivo.SelectedIndex = -1, -1, cboAtivo.SelectedValue)
            oClsCadFuncionario.NivelPermissaoAPP = IIf(cboNivelPermissaoAPP.SelectedIndex = -1, -1, cboNivelPermissaoAPP.SelectedValue)
            oClsCadFuncionario.EscolhasApontamento = txtEscolhasApontamento.Value
            'Seta Parametros - Dados Gerais
            oClsCadFuncionario.Cep = txtCEP.Text
            oClsCadFuncionario.Pais = IIf(cboPais.SelectedIndex = -1, -1, cboPais.SelectedValue)
            oClsCadFuncionario.UF = IIf(cboUF.SelectedIndex = -1, "", cboUF.SelectedValue)
            oClsCadFuncionario.Municipio = IIf(cboMunicipio.SelectedIndex = -1, -1, cboMunicipio.SelectedValue)
            oClsCadFuncionario.Logradouro = txtLogradouro.Text.Trim
            oClsCadFuncionario.Numero = txtNumero.Text.Trim
            oClsCadFuncionario.Bairro = txtBairro.Text.Trim
            oClsCadFuncionario.Complemento = txtComplemento.Text.Trim
            oClsCadFuncionario.Email = txtEmail.Text.Trim
            oClsCadFuncionario.DataNascimento = IIf(dtpDataNascimentoFuncionario.Checked = False, "", dtpDataNascimentoFuncionario.Value)
            oClsCadFuncionario.Telefone1 = txtTelefone1.Text.Trim
            oClsCadFuncionario.Telefone2 = txtTelefone2.Text.Trim
            oClsCadFuncionario.Nextel = txtNextel.Text.Trim
            oClsCadFuncionario.TelefoneRecado = txtTelefoneRecado.Text.Trim
            oClsCadFuncionario.DataAdmissao = dtpDataAdmissao.Value
            oClsCadFuncionario.DataDemissao = IIf(dtpDataDemissao.Checked = True, dtpDataDemissao.Value, "")
            oClsCadFuncionario.Cargo = txtCargo.Text.Trim
            oClsCadFuncionario.CodigoOcupacao = IIf(cboOcupacao.SelectedIndex = -1, -1, cboOcupacao.SelectedValue)
            oClsCadFuncionario.Observacao = txtObservacao.Text.Trim
            oClsCadFuncionario.Foto = picFoto
            'Seta Parâmetros - Dados Pessoais
            oClsCadFuncionario.CodigoSexo = IIf(cboSexo.SelectedIndex = -1, -1, cboSexo.SelectedValue)
            oClsCadFuncionario.CodigoEstadoCivil = IIf(cboEstadoCivil.SelectedIndex = -1, -1, cboEstadoCivil.SelectedValue)
            oClsCadFuncionario.NomeConjuge = txtNomeConjuge.Text.Trim
            oClsCadFuncionario.CodigoFormacao = IIf(cboFormacao.SelectedIndex = -1, -1, cboFormacao.SelectedValue)
            oClsCadFuncionario.NomePai = txtNomePai.Text.Trim
            oClsCadFuncionario.NomeMae = txtNomeMae.Text.Trim
            'Seta Parâmetros - Jornada de Trabalho / Pagamento
            oClsCadFuncionario.CodigoTipoValor = IIf(cboTipoValorPagamento.SelectedIndex = -1, -1, cboTipoValorPagamento.SelectedValue)
            oClsCadFuncionario.ValorBase = txtValorBasePagamento.Value
            oClsCadFuncionario.ValorHora = txtValorHoraPagamento.Value
            oClsCadFuncionario.PercentualAdicionalNoturno = txtAdicionalNoturnoPagamento.Value
            oClsCadFuncionario.BancoHoras = IIf(cboBancoHoraPagamento.SelectedIndex = -1, "", cboBancoHoraPagamento.SelectedValue)
            oClsCadFuncionario.CodigoCentroGasto = IIf(cboCentroGasto.SelectedIndex = -1, -1, cboCentroGasto.SelectedValue)
            oClsCadFuncionario.CodigoTipoContrato = IIf(cboTipoContrato.SelectedIndex = -1, -1, cboTipoContrato.SelectedValue)
            oClsCadFuncionario.CodigoTurno = IIf(cboTurno.SelectedIndex = -1, -1, cboTurno.SelectedValue)
            oClsCadFuncionario.ObservacaoTipoContrato = txtObservacaoTipoContrato.Text.Trim
            oClsCadFuncionario.HoraEntradaSegunda = FormataHora(txtHoraEntradaSegunda)
            oClsCadFuncionario.HoraEntradaTerca = FormataHora(txtHoraEntradaTerca)
            oClsCadFuncionario.HoraEntradaQuarta = FormataHora(txtHoraEntradaQuarta)
            oClsCadFuncionario.HoraEntradaQuinta = FormataHora(txtHoraEntradaQuinta)
            oClsCadFuncionario.HoraEntradaSexta = FormataHora(txtHoraEntradaSexta)
            oClsCadFuncionario.HoraEntradaSabado = FormataHora(txtHoraEntradaSabado)
            oClsCadFuncionario.HoraEntradaDomingo = FormataHora(txtHoraEntradaDomingo)
            oClsCadFuncionario.HoraSaidaSegunda = FormataHora(txtHoraSaidaSegunda)
            oClsCadFuncionario.HoraSaidaTerca = FormataHora(txtHoraSaidaTerca)
            oClsCadFuncionario.HoraSaidaQuarta = FormataHora(txtHoraSaidaQuarta)
            oClsCadFuncionario.HoraSaidaQuinta = FormataHora(txtHoraSaidaQuinta)
            oClsCadFuncionario.HoraSaidaSexta = FormataHora(txtHoraSaidaSexta)
            oClsCadFuncionario.HoraSaidaSabado = FormataHora(txtHoraSaidaSabado)
            oClsCadFuncionario.HoraSaidaDomingo = FormataHora(txtHoraSaidaDomingo)
            oClsCadFuncionario.HoraAlmocoSegundaInicio = FormataHora(txtHoraAlmocoSegundaInicio)
            oClsCadFuncionario.HoraAlmocoTercaInicio = FormataHora(txtHoraAlmocoTercaInicio)
            oClsCadFuncionario.HoraAlmocoQuartaInicio = FormataHora(txtHoraAlmocoQuartaInicio)
            oClsCadFuncionario.HoraAlmocoQuintaInicio = FormataHora(txtHoraAlmocoQuintaInicio)
            oClsCadFuncionario.HoraAlmocoSextaInicio = FormataHora(txtHoraAlmocoSextaInicio)
            oClsCadFuncionario.HoraAlmocoSabadoInicio = FormataHora(txtHoraAlmocoSabadoInicio)
            oClsCadFuncionario.HoraAlmocoDomingoInicio = FormataHora(txtHoraAlmocoDomingoInicio)
            oClsCadFuncionario.HoraAlmocoSegundaTermino = FormataHora(txtHoraAlmocoSegundaTermino)
            oClsCadFuncionario.HoraAlmocoTercaTermino = FormataHora(txtHoraAlmocoTercaTermino)
            oClsCadFuncionario.HoraAlmocoQuartaTermino = FormataHora(txtHoraAlmocoQuartaTermino)
            oClsCadFuncionario.HoraAlmocoQuintaTermino = FormataHora(txtHoraAlmocoQuintaTermino)
            oClsCadFuncionario.HoraAlmocoSextaTermino = FormataHora(txtHoraAlmocoSextaTermino)
            oClsCadFuncionario.HoraAlmocoSabadoTermino = FormataHora(txtHoraAlmocoSabadoTermino)
            oClsCadFuncionario.HoraAlmocoDomingoTermino = FormataHora(txtHoraAlmocoDomingoTermino)
            oClsCadFuncionario.HoraIntervaloSegundaInicio = FormataHora(txtHoraIntervaloSegundaInicio)
            oClsCadFuncionario.HoraIntervaloTercaInicio = FormataHora(txtHoraIntervaloTercaInicio)
            oClsCadFuncionario.HoraIntervaloQuartaInicio = FormataHora(txtHoraIntervaloQuartaInicio)
            oClsCadFuncionario.HoraIntervaloQuintaInicio = FormataHora(txtHoraIntervaloQuintaInicio)
            oClsCadFuncionario.HoraIntervaloSextaInicio = FormataHora(txtHoraIntervaloSextaInicio)
            oClsCadFuncionario.HoraIntervaloSabadoInicio = FormataHora(txtHoraIntervaloSabadoInicio)
            oClsCadFuncionario.HoraIntervaloDomingoInicio = FormataHora(txtHoraIntervaloDomingoInicio)
            oClsCadFuncionario.HoraIntervaloSegundaTermino = FormataHora(txtHoraIntervaloSegundaTermino)
            oClsCadFuncionario.HoraIntervaloTercaTermino = FormataHora(txtHoraIntervaloTercaTermino)
            oClsCadFuncionario.HoraIntervaloQuartaTermino = FormataHora(txtHoraIntervaloQuartaTermino)
            oClsCadFuncionario.HoraIntervaloQuintaTermino = FormataHora(txtHoraIntervaloQuintaTermino)
            oClsCadFuncionario.HoraIntervaloSextaTermino = FormataHora(txtHoraIntervaloSextaTermino)
            oClsCadFuncionario.HoraIntervaloSabadoTermino = FormataHora(txtHoraIntervaloSabadoTermino)
            oClsCadFuncionario.HoraIntervaloDomingoTermino = FormataHora(txtHoraIntervaloDomingoTermino)
            oClsCadFuncionario.HoraAdicionalNoturnoInicio = FormataHora(txtHoraAdicionaNoturnoInicio)
            oClsCadFuncionario.HoraAdicionalNoturnoTermino = FormataHora(txtHoraAdicionaNoturnoTermino)
            oClsCadFuncionario.CodigoHoraExtraSegunda = IIf(cboHoraExtraSegundaPagamento.SelectedIndex = -1, -1, cboHoraExtraSegundaPagamento.SelectedValue)
            oClsCadFuncionario.HoraExtraAposSegunda = txtHoraExtraAposSegundaPagamento.Value
            oClsCadFuncionario.CodigoHoraExtraAposSegunda = IIf(cboHoraExtraAposSegundaPagamento.SelectedIndex = -1, -1, cboHoraExtraAposSegundaPagamento.SelectedValue)
            oClsCadFuncionario.CodigoHoraExtraTerca = IIf(cboHoraExtraTercaPagamento.SelectedIndex = -1, -1, cboHoraExtraTercaPagamento.SelectedValue)
            oClsCadFuncionario.HoraExtraAposTerca = txtHoraExtraAposTercaPagamento.Value
            oClsCadFuncionario.CodigoHoraExtraAposTerca = IIf(cboHoraExtraAposTercaPagamento.SelectedIndex = -1, -1, cboHoraExtraAposTercaPagamento.SelectedValue)
            oClsCadFuncionario.CodigoHoraExtraQuarta = IIf(cboHoraExtraQuartaPagamento.SelectedIndex = -1, -1, cboHoraExtraQuartaPagamento.SelectedValue)
            oClsCadFuncionario.HoraExtraAposQuarta = txtHoraExtraAposQuartaPagamento.Value
            oClsCadFuncionario.CodigoHoraExtraAposQuarta = IIf(cboHoraExtraAposQuartaPagamento.SelectedIndex = -1, -1, cboHoraExtraAposQuartaPagamento.SelectedValue)
            oClsCadFuncionario.CodigoHoraExtraQuinta = IIf(cboHoraExtraQuintaPagamento.SelectedIndex = -1, -1, cboHoraExtraQuintaPagamento.SelectedValue)
            oClsCadFuncionario.HoraExtraAposQuinta = txtHoraExtraAposQuintaPagamento.Value
            oClsCadFuncionario.CodigoHoraExtraAposQuinta = IIf(cboHoraExtraAposQuintaPagamento.SelectedIndex = -1, -1, cboHoraExtraAposQuintaPagamento.SelectedValue)
            oClsCadFuncionario.CodigoHoraExtraSexta = IIf(cboHoraExtraSextaPagamento.SelectedIndex = -1, -1, cboHoraExtraSextaPagamento.SelectedValue)
            oClsCadFuncionario.HoraExtraAposSexta = txtHoraExtraAposSextaPagamento.Value
            oClsCadFuncionario.CodigoHoraExtraAposSexta = IIf(cboHoraExtraAposSextaPagamento.SelectedIndex = -1, -1, cboHoraExtraAposSextaPagamento.SelectedValue)
            oClsCadFuncionario.CodigoHoraExtraSabado = IIf(cboHoraExtraSabadoPagamento.SelectedIndex = -1, -1, cboHoraExtraSabadoPagamento.SelectedValue)
            oClsCadFuncionario.HoraExtraAposSabado = txtHoraExtraAposSabadoPagamento.Value
            oClsCadFuncionario.CodigoHoraExtraAposSabado = IIf(cboHoraExtraAposSabadoPagamento.SelectedIndex = -1, -1, cboHoraExtraAposSabadoPagamento.SelectedValue)
            oClsCadFuncionario.CodigoHoraExtraDomingo = IIf(cboHoraExtraDomingoPagamento.SelectedIndex = -1, -1, cboHoraExtraDomingoPagamento.SelectedValue)
            oClsCadFuncionario.HoraExtraAposDomingo = txtHoraExtraAposDomingoPagamento.Value
            oClsCadFuncionario.CodigoHoraExtraAposDomingo = IIf(cboHoraExtraAposDomingoPagamento.SelectedIndex = -1, -1, cboHoraExtraAposDomingoPagamento.SelectedValue)
            'Verifica o Tipo de Operação
            If IsNumeric(btnSalvar.Tag) Then
                oClsCadFuncionario.Update()
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                oClsCadFuncionario.Insert()
                btnSalvar.Tag = oClsCadFuncionario.CodigoFuncionario
                frmMain.Informacao(Mensagem.RegistroInserido)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function FormataHora(campo As MaskedEditBox) As Double
        Try

            Dim dHoraFormatada As Double

            dHoraFormatada = ((DatePart(DateInterval.Hour, CDate(campo.Text)) * 60) + DatePart(DateInterval.Minute, CDate(campo.Text)) + (DatePart(DateInterval.Second, CDate(campo.Text)) / 60))

            Return dHoraFormatada

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCadFuncionario.LoadGrid(grdListagem,
                                        txtProntuarioFiltro.Text.Trim,
                                        txtNomeFiltro.Text.Trim,
                                        txtCPFFiltro.Text.Trim,
                                        txtRGFiltro.Text.Trim,
                                        txtOrgaoEmissorFiltro.Text.Trim,
                                        IIf(cboAtivoFiltro.SelectedIndex = -1, 11, cboAtivoFiltro.SelectedValue))

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


            'Verifica se foi Preenchido o Campo - ATIVO
            If ValidaCampo(cboAtivo, lblAtivo) = False Then
                Exit Function
            End If


            'Verifica se foi Preenchido o Campo - Prontuário
            If ValidaCampo(txtProntuario, lblProntuario, TipoCampo.texto) = False Then
                Exit Function
            End If

            ''Valida se o Prontuário é Válido
            'If oClsCadFuncionario.ValidaProntuario(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0), _
            '                                       txtProntuario.Text.Trim) = False Then
            '    frmMain.errInfo.SetError(lblProntuario, "Este Prontuário já está associado a outro Registro")
            '    txtProntuario.Focus()
            '    Exit Function
            'End If

            'Verifica se foi Preenchido o Campo - Nome
            If ValidaCampo(txtNome, lblNome, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - CPF
            If txtCPF.Text.Trim <> "" Then
                If ValidaCPF(txtCPF.Text.Trim) = False Then
                    frmMain.errInfo.SetError(lblCPF, "O CPF informado é inválido.")
                    tabDados.SelectedTab = pagDadosGerais
                    txtCPF.Focus()
                    Exit Function
                End If
            End If

            If IsNumeric(btnSalvar.Tag) = False Then
                If oClsCadFuncionario.ValidaCpf(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1),
                                                txtCPF.Text.Trim) = False Then
                    frmMain.errInfo.SetError(lblCPF, "Este CPF: " & txtCPF.Text & " já está associado a outro Registro.")
                    tabDados.SelectedTab = pagDadosGerais
                    txtCPF.Focus()
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub Email(ByVal oRow As GridEXRow)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim sArquivo As String = ""

            'Verifica o Tipo de Documento
            If IsDBNull(oRow.Cells("codigo_documento").Value) Then

                'Váriaveis Locais
                Dim oRptDocument As New ReportDocument

                'Abre Relatório
                oRptDocument.Load(goCrystalReport.sPath & oRow.Cells("arquivo_interacti").Value,
                                  CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)

                'Seta Parametros Relatório
                oRptDocument.SetParameterValue("@codigo", oRow.Cells("codigo_funcionario").Value)
                oRptDocument.SetParameterValue("@codigo_empresa", goUsuario.iEmpresa)
                oRptDocument.SetParameterValue("usuario", goUsuario.sNome)

                'Abre Conexão com o Banco de Dados
                For i = 0 To oRptDocument.DataSourceConnections.Count - 1
                    oRptDocument.DataSourceConnections.Item(i).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)
                Next

                'Arquivo
                Dim sReport As String = System.IO.Path.GetTempPath
                sReport &= oRow.Cells("documento").Value & ".pdf"

                'Exporta para Arquivo PDF
                oRptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat,
                                          sReport)

                sArquivo &= IIf(sArquivo = "", "", ";") & sReport

            Else

                Dim sArquivoBD As String = Path.GetTempPath & oRow.Cells("descricao").Value.ToString.Replace(" ", "_").Replace(".", "") & "." & oRow.Cells("extensao").Value

                'Verifica se foi Informado o Arquivo
                Dim oFileStream As New FileStream(sArquivoBD, FileMode.OpenOrCreate, FileAccess.Write)
                oFileStream.Write(oRow.Cells("arquivo").Value, 0, oRow.Cells("arquivo").Value.Length)
                oFileStream.Flush()
                oFileStream.Close()

                sArquivo &= IIf(sArquivo = "", "", ";") & sArquivoBD

            End If

            'Enviar E-mail
            Call EnviarEmail(oRow.Cells("documento").Value,
                             "",
                             sArquivo,
                             sArquivo,
                             "",
                             -1)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Email()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdListagem, "documento") = True Then

                Dim sArquivo As String = ""

                For Each oRow As GridEXRow In gSelecaoRow

                    If IsDBNull(oRow.Cells("codigo_documento").Value) Then

                        'Váriaveis Locais
                        Dim oRptDocument As New ReportDocument

                        'Abre Relatório
                        oRptDocument.Load(goCrystalReport.sPath & oRow.Cells("arquivo").Value,
                                          CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)

                        'Seta Parametros Relatório
                        oRptDocument.SetParameterValue("@codigo", oRow.Cells("codigo_funcionario").Value)
                        oRptDocument.SetParameterValue("@codigo_empresa", goUsuario.iEmpresa)
                        oRptDocument.SetParameterValue("usuario", goUsuario.sNome)

                        'Abre Conexão com o Banco de Dados
                        For i = 0 To oRptDocument.DataSourceConnections.Count - 1
                            oRptDocument.DataSourceConnections.Item(i).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)
                        Next

                        'Arquivo
                        Dim sReport As String = System.IO.Path.GetTempPath
                        sReport &= oRow.Cells("documento").Value & ".pdf"

                        'Exporta para Arquivo PDF
                        oRptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat,
                                                  sReport)

                        sArquivo &= IIf(sArquivo = "", "", ";") & sReport

                    Else

                        Dim sArquivoBD As String = Path.GetTempPath & oRow.Cells("descricao").Value.ToString.Replace(" ", "_").Replace(".", "") & "." & oRow.Cells("extensao").Value

                        'Verifica se foi Informado o Arquivo
                        Dim oFileStream As New FileStream(sArquivoBD, FileMode.OpenOrCreate, FileAccess.Write)
                        oFileStream.Write(oRow.Cells("arquivo").Value, 0, oRow.Cells("arquivo").Value.Length)
                        oFileStream.Flush()
                        oFileStream.Close()

                        sArquivo &= IIf(sArquivo = "", "", ";") & sArquivoBD

                    End If

                Next

                'Enviar E-mail
                Call EnviarEmail("Documentos",
                                 "",
                                 sArquivo,
                                 sArquivo,
                                 "",
                                 -1)

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mais Registro
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub VisualizarDocumento()

        Try

            'Verifica se é Relatório
            If IsDBNull(grdListagem.CurrentRow.Cells("codigo_documento").Value) Then

                'Redimenciona Vetor
                ReDim goCrystalReport.sReportParameter(2)
                'Seta Parametros
                goCrystalReport.sReportParameter(0).sParamenter = "usuario"
                goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
                goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
                goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
                goCrystalReport.sReportParameter(2).sParamenter = "@codigo"
                goCrystalReport.sReportParameter(2).sValue = grdListagem.CurrentRow.Cells("codigo_funcionario").Value
                goCrystalReport.sReport = goCrystalReport.sPath & grdListagem.CurrentRow.Cells("arquivo").Value

                Dim oReport As New usrReport
                oReport.Dock = DockStyle.Fill

                'Abre Relatório
                frmMain.LoadPageReport("CAD000000007", "Dados do Funcionário", oReport)

            Else

                Call VisualizarDocumentoBD(grdListagem.CurrentRow.Cells("arquivo").Value, grdListagem.CurrentRow.Cells("extensao").Value)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: CENTRO DE TRABALHO \ OPERAÇÃO :::"

    Private Sub DeleteOperacao()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdOperacao) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & IIf(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Deleta Linha
                    Call oClsCadFuncionario.DeleteOperacao(btnSalvar.Tag)

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

    Private Sub EditarOperacao()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoFuncionario, gcUpdate) = True Then

                With grdOperacao.CurrentRow.Cells

                    'Carrega Controles
                    cboCentroTrabalho.SelectedValue = .Item("codigo_centro_trabalho").Value
                    cboOperacao.SelectedValue = .Item("codigo_operacao").Value
                    btnInserirOperacao.Tag = grdOperacao.CurrentRow.RowIndex

                End With

                'Seta Focu
                cboCentroGasto.Focus()

            Else

                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoOperacao()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Operação
            cboCentroTrabalho.SelectedIndex = -1
            cboOperacao.SelectedIndex = -1
            btnInserirOperacao.Tag = ""

            'Seta Focu
            cboOperacao.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoOperacao() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoOperacao = False

            'Verifica se foi Selecionado o Campo - Centro de Trabalho
            If ValidaCampo(cboCentroTrabalho, lblCentroTrabalho) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Operação
            If ValidaCampo(cboOperacao, lblOperacao) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoOperacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: DADOS BANCÁRIOS :::"

    Private Sub DeleteContaBancaria()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdContaBancaria) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & IIf(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsCadFuncionario.DeleteContaBancaria(btnSalvar.Tag)

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

    Private Sub EditarContaBancaria()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoFuncionario, gcUpdate) = True Then

                With grdContaBancaria.CurrentRow.Cells

                    'Carrega Controles
                    cboBanco.SelectedValue = .Item("codigo_banco").Value
                    cboTipoContaBancaria.SelectedValue = .Item("codigo_tipo_conta_bancaria").Value
                    txtAgencia.Text = .Item("agencia").Value
                    txtConta.Text = .Item("conta").Value
                    txtDigitoConta.Text = .Item("digito").Value
                    cboContaPagamento.SelectedValue = .Item("conta_pagamento").Value
                    btnInserirContaBancaria.Tag = grdContaBancaria.CurrentRow.RowIndex

                End With

                'Seta Focu
                cboBanco.Focus()

            Else

                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoContaBancaria()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Conta Bancária
            cboBanco.SelectedIndex = -1
            cboTipoContaBancaria.SelectedIndex = -1
            txtAgencia.Text = ""
            txtConta.Text = ""
            txtDigitoConta.Text = ""
            cboContaPagamento.SelectedIndex = -1
            btnInserirContaBancaria.Tag = ""

            'Seta Focu
            cboBanco.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoContaBancaria() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoContaBancaria = False

            'Verifica se foi Selecionado o Campo - Banco
            If ValidaCampo(cboBanco, lblBanco) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Tipo de Conta Bancária
            If ValidaCampo(cboTipoContaBancaria, lblTipoContaBancaria) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Agência
            If ValidaCampo(txtAgencia, lblAgencia, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Conta
            If ValidaCampo(txtConta, lblConta, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Conta de Pagamento
            If ValidaCampo(cboContaPagamento, lblContaPagamento) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoContaBancaria = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: ATIVIDADE :::"

    Private Sub DeleteAtividade()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdAtividade) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & IIf(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Deleta Linha
                    Call oClsCadFuncionario.DeleteAtividade(btnSalvar.Tag)

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

    Private Sub EditarAtividade()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoFuncionario, gcUpdate) = True Then

                With grdSalario.CurrentRow.Cells

                    'Carrega Controles
                    cboAtividade.SelectedValue = .Item("codigo").Value
                    btnInserirAtividade.Tag = grdAtividade.CurrentRow.RowIndex

                End With

                'Seta Focu
                cboAtividade.Focus()

            Else

                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoAtividade()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Ocupacao
            cboAtividade.SelectedIndex = -1
            btnInserirAtividade.Tag = ""

            'Seta Focu
            cboAtividade.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoAtividade() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoAtividade = False

            'Verifica se foi Selecionado o Campo - Ocupacao
            If ValidaCampo(cboAtividade, lblAtividade) = False Then
                Exit Function
            End If

            'Verifica se a Ocupacao é Válida
            If IsNumeric(btnInserirAtividade.Tag) Then
                If VerificaExisteValorGrid(grdAtividade, "codigo", cboAtividade.SelectedValue, grdAtividade.CurrentRow.RowIndex) Then
                    frmMain.errInfo.SetError(lblAtividade, "Esta Atividade: " & cboAtividade.Text & " já está associado a um outro registro.")
                    cboAtividade.Focus()
                    Exit Function
                End If
            Else
                If VerificaExisteValorGrid(grdAtividade, "codigo", cboAtividade.SelectedValue, -1) Then
                    frmMain.errInfo.SetError(lblAtividade, "Esta Atividade: " & cboAtividade.Text & " já está associado a um outro registro.")
                    cboAtividade.Focus()
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            ValidacaoAtividade = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: SALARIO :::"

    Private Sub EditarSalario()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoFuncionario, gcUpdate) = True Then

                With grdSalario.CurrentRow.Cells

                    'Carrega Controles
                    dtpDataSalario.Value = .Item("data").Value
                    txtValorSalario.Value = .Item("valor").Value
                    cboAtivoSalario.SelectedValue = .Item("ativo").Value
                    btnInserirSalario.Tag = grdSalario.CurrentRow.RowIndex

                End With

                'Seta Focu
                txtValorSalario.Focus()

            Else

                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoSalario() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoSalario = False

            If ValidaCampo(cboAtivoSalario, lblAtivoSalario) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Ocupacao
            If ValidaCampo(txtValorSalario, lblValorSalario, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoSalario = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub NovoSalario()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            dtpDataSalario.Value = Now.Date
            txtValorSalario.Value = 0
            cboAtivoSalario.SelectedIndex = -1
            btnInserirSalario.Tag = ""

            'Seta Focu
            dtpDataSalario.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteSalario()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdSalario) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & IIf(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Deleta Linha
                    Call oClsCadFuncionario.DeleteSalario(btnSalvar.Tag)

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

#End Region



#Region "::: DEPENDENTE :::"

    Private Sub DeleteDependente()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdDependente) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & IIf(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Dependente
                    Call oClsCadFuncionario.DeleteDependente()

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

    Private Sub EditarDependente()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoFuncionario, gcUpdate) = True Then

                With grdDependente.CurrentRow.Cells

                    'Carrega Controles
                    txtNomeDependente.Text = grdDependente.CurrentRow.Cells("nome").Value
                    txtParentescoDependente.Text = grdDependente.CurrentRow.Cells("parentesco").Value
                    dtpDataNascimento.Value = grdDependente.CurrentRow.Cells("data_nascimento").Value
                    chkIR.Checked = grdDependente.CurrentRow.Cells("ir").Value
                    chkSalFam.Checked = grdDependente.CurrentRow.Cells("salario_familia").Value
                    btnInserirDependente.Tag = grdDependente.CurrentRow.RowIndex

                End With

                'Seta Focu
                txtNomeDependente.Focus()

            Else

                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoDependente()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Dependente
            txtNomeDependente.Text = ""
            txtParentescoDependente.Text = ""
            dtpDataNascimento.Value = Now.Date
            chkIR.Checked = False
            chkSalFam.Checked = False
            btnInserirDependente.Tag = ""

            'Seta Focu
            txtNomeDependente.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoDependente() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoDependente = False

            'Verifica se foi Preenchido o Campo - Nome
            If ValidaCampo(txtNomeDependente, lblNomeDependente, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se a Dependente é Válida
            If IsNumeric(btnInserirDependente.Tag) Then
                If VerificaExisteValorGrid(grdDependente, "nome", txtNomeDependente.Text.Trim, grdDependente.CurrentRow.RowIndex) Then
                    frmMain.errInfo.SetError(lblNomeDependente, "Este Dependente: " & txtNomeDependente.Text & " já está associado a um outro registro.")
                    txtNomeDependente.Focus()
                    Exit Function
                End If
            Else
                If VerificaExisteValorGrid(grdDependente, "nome", txtNomeDependente.Text.Trim, -1) Then
                    frmMain.errInfo.SetError(lblNomeDependente, "Este Dependente: " & txtNomeDependente.Text & " já está associado a um outro registro.")
                    txtNomeDependente.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Parentesco
            If ValidaCampo(txtParentescoDependente, lblParentescoDependente, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoDependente = True

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
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & IIf(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Deleta Linha
                    Call oClsCadFuncionario.DeleteDocumento(btnSalvar.Tag)

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
                    txtDescricaoDocumento.Text = .Cells("descricao").Value
                    dtpDataEmissaoDocumento.Value = .Cells("data_emissao").Value
                    If IsDBNull(.Cells("data_validade").Value) Then
                        dtpDataValidadeDocumento.Value = Now.Date : dtpDataValidadeDocumento.Checked = False
                    Else
                        dtpDataValidadeDocumento.Value = .Cells("data_validade").Value : dtpDataValidadeDocumento.Checked = True
                    End If
                    txtAlertaAntecedenciaDia.Value = .Cells("alerta_antecedencia").Value
                    cboTipoArquivo.SelectedValue = .Cells("codigo_tipo_arquivo").Value
                    txtArquivoDocumento.Text = .Cells("arquivo_interacti").Value
                    btnInserirDocumento.Tag = .RowIndex

                End With

                'Seta Focu
                cboDocumento.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
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
            txtDescricaoDocumento.Text = ""
            dtpDataEmissaoDocumento.Value = Now.Date
            dtpDataValidadeDocumento.Value = Now.Date : dtpDataValidadeDocumento.Checked = False
            txtAlertaAntecedenciaDia.Value = 0
            cboTipoArquivo.SelectedIndex = -1
            txtArquivoDocumento.Text = ""
            btnInserirDocumento.Tag = ""

            'Seta Focu
            cboDocumento.Focus()

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

            'Verifica se foi Selecionado o Campo - Tipo do Arquivo
            If ValidaCampo(cboTipoArquivo, lblTipoArquivo) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Arquivo
            If ValidaCampo(txtArquivoDocumento, lblArquivoDocumento, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoDocumento = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: JORNADA DE TRABALHO / PAGAMENTO :::"

    Private Sub LoadDadosTurno()

        Try

            'Carrega Dados do Turno
            oClsCadFuncionario.LoadDadosTurno(cboTurno.SelectedValue,
                                              txtHoraEntradaSegunda,
                                              txtHoraEntradaTerca,
                                              txtHoraEntradaQuarta,
                                              txtHoraEntradaQuinta,
                                              txtHoraEntradaSexta,
                                              txtHoraEntradaSabado,
                                              txtHoraEntradaDomingo,
                                              txtHoraSaidaSegunda,
                                              txtHoraSaidaTerca,
                                              txtHoraSaidaQuarta,
                                              txtHoraSaidaQuinta,
                                              txtHoraSaidaSexta,
                                              txtHoraSaidaSabado,
                                              txtHoraSaidaDomingo,
                                              txtHoraAlmocoSegundaInicio,
                                              txtHoraAlmocoTercaInicio,
                                              txtHoraAlmocoQuartaInicio,
                                              txtHoraAlmocoQuintaInicio,
                                              txtHoraAlmocoSextaInicio,
                                              txtHoraAlmocoSabadoInicio,
                                              txtHoraAlmocoDomingoInicio,
                                              txtHoraAlmocoSegundaTermino,
                                              txtHoraAlmocoTercaTermino,
                                              txtHoraAlmocoQuartaTermino,
                                              txtHoraAlmocoQuintaTermino,
                                              txtHoraAlmocoSextaTermino,
                                              txtHoraAlmocoSabadoTermino,
                                              txtHoraAlmocoDomingoTermino,
                                              txtHoraIntervaloSegundaInicio,
                                              txtHoraIntervaloTercaInicio,
                                              txtHoraIntervaloQuartaInicio,
                                              txtHoraIntervaloQuintaInicio,
                                              txtHoraIntervaloSextaInicio,
                                              txtHoraIntervaloSabadoInicio,
                                              txtHoraIntervaloDomingoInicio,
                                              txtHoraIntervaloSegundaTermino,
                                              txtHoraIntervaloTercaTermino,
                                              txtHoraIntervaloQuartaTermino,
                                              txtHoraIntervaloQuintaTermino,
                                              txtHoraIntervaloSextaTermino,
                                              txtHoraIntervaloSabadoTermino,
                                              txtHoraIntervaloDomingoTermino,
                                              txtHoraAdicionaNoturnoInicio,
                                              txtHoraAdicionaNoturnoTermino,
                                              cboHoraExtraSegundaPagamento,
                                              txtHoraExtraAposSegundaPagamento,
                                              cboHoraExtraAposSegundaPagamento,
                                              cboHoraExtraTercaPagamento,
                                              txtHoraExtraAposTercaPagamento,
                                              cboHoraExtraAposTercaPagamento,
                                              cboHoraExtraQuartaPagamento,
                                              txtHoraExtraAposQuartaPagamento,
                                              cboHoraExtraAposQuartaPagamento,
                                              cboHoraExtraQuintaPagamento,
                                              txtHoraExtraAposQuintaPagamento,
                                              cboHoraExtraAposQuintaPagamento,
                                              cboHoraExtraSextaPagamento,
                                              txtHoraExtraAposSextaPagamento,
                                              cboHoraExtraAposSextaPagamento,
                                              cboHoraExtraSabadoPagamento,
                                              txtHoraExtraAposSabadoPagamento,
                                              cboHoraExtraAposSabadoPagamento,
                                              cboHoraExtraDomingoPagamento,
                                              txtHoraExtraAposDomingoPagamento,
                                              cboHoraExtraAposDomingoPagamento)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: AJUDA DE CUSTO :::"

    Private Sub DeleteAjudaCusto()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdAjudaCusto) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & IIf(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Deleta Linha
                    Call oClsCadFuncionario.DeleteAjudaCusto(btnSalvar.Tag)

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

    Private Sub EditarAjudaCusto()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoFuncionario, gcUpdate) = True Then

                With grdAjudaCusto.CurrentRow.Cells

                    'Carrega Controles
                    cboAjudaCusto.SelectedValue = .Item("codigo").Value
                    txtValorAjudaCusto.Value = .Item("valor").Value
                    txtDescontoAjudaCusto.Value = .Item("desconto").Value
                    btnInserirAjudaCusto.Tag = grdAjudaCusto.CurrentRow.RowIndex

                End With

                'Seta Focu
                cboAjudaCusto.Focus()

            Else

                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoAjudaCusto()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Ocupacao
            cboAjudaCusto.SelectedIndex = -1
            txtValorAjudaCusto.Value = 0
            txtDescontoAjudaCusto.Value = 0
            btnInserirAjudaCusto.Tag = ""

            'Seta Focu
            cboAjudaCusto.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoAjudaCusto() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoAjudaCusto = False

            'Verifica se foi Selecionado o Campo - Ocupacao
            If ValidaCampo(cboAjudaCusto, lblAjudaCusto) = False Then
                Exit Function
            End If

            'Verifica se a Ocupacao é Válida
            If IsNumeric(btnInserirAjudaCusto.Tag) Then
                If VerificaExisteValorGrid(grdAjudaCusto, "codigo", cboAjudaCusto.SelectedValue, grdAjudaCusto.CurrentRow.RowIndex) Then
                    frmMain.errInfo.SetError(lblAjudaCusto, "Esta Ajuda de Custo: " & cboAjudaCusto.Text & " já está associado a um outro registro.")
                    cboAjudaCusto.Focus()
                    Exit Function
                End If
            Else
                If VerificaExisteValorGrid(grdAjudaCusto, "codigo", cboAjudaCusto.SelectedValue, -1) Then
                    frmMain.errInfo.SetError(lblAjudaCusto, "Esta Ajuda de Custo: " & cboAjudaCusto.Text & " já está associado a um outro registro.")
                    cboAjudaCusto.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Valor
            If ValidaCampo(txtValorAjudaCusto, lblValorAjudaCusto, True) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Desconto
            If ValidaCampo(txtDescontoAjudaCusto, lblDescontoAjudaCusto, True) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoAjudaCusto = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: RATEIO :::"

    Private Sub DeleteRateio()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdRateio) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & IIf(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Deleta Linha
                    Call oClsCadFuncionario.DeleteRateio(btnSalvar.Tag)

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

    Private Sub EditarRateio()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoFuncionario, gcUpdate) = True Then

                With grdRateio.CurrentRow.Cells

                    'Carrega Controles
                    cboCentroTrabalhoRateio.SelectedValue = .Item("codigo_centro_trabalho").Value
                    btnInserirRateio.Tag = .Item("codigo").Value

                End With

                'Seta Focu
                cboCentroTrabalhoRateio.Focus()

            Else

                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoRateio()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Operação
            cboCentroTrabalhoRateio.SelectedIndex = -1
            txtPercentualRateio.Value = 0
            btnInserirRateio.Tag = ""

            'Seta Focu
            cboCentroTrabalhoRateio.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoRateio() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoRateio = False

            'Verifica se foi Selecionado o Campo - Centro de Trabalho
            If ValidaCampo(cboCentroTrabalhoRateio, lblCentroTrabalhoRateio) = False Then
                Exit Function
            End If

            'Verifica se a Ocupacao é Válida
            If IsNumeric(btnInserirRateio.Tag) Then
                If VerificaExisteValorGrid(grdRateio, "codigo_centro_trabalho", cboCentroTrabalhoRateio.SelectedValue, grdRateio.CurrentRow.RowIndex) Then
                    frmMain.errInfo.SetError(lblCentroTrabalhoRateio, "Este Centro de Trabalho: " & cboCentroTrabalhoRateio.Text & " já está associado a um outro registro.")
                    cboCentroTrabalhoRateio.Focus()
                    Exit Function
                End If
            Else
                If VerificaExisteValorGrid(grdRateio, "codigo_centro_trabalho", cboCentroTrabalhoRateio.SelectedValue, -1) Then
                    frmMain.errInfo.SetError(lblCentroTrabalhoRateio, "Este Centro de Trabalho: " & cboCentroTrabalhoRateio.Text & " já está associado a um outro registro.")
                    cboCentroTrabalhoRateio.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - % Rateio
            If ValidaCampo(txtPercentualRateio, lblPercentualRateio, True) = False Then
                Exit Function
            End If

            'Verifica se foi o Valor Informado é Válido
            Dim dTotalRateio As Double = 0
            If grdRateio.GetDataRows.Count > 0 Then
                dTotalRateio = grdRateio.GetTotalRow.Cells("percentual_rateio").Value
            End If

            If IsNumeric(btnInserirRateio.Tag) Then
                dTotalRateio -= grdRateio.CurrentRow.Cells("percentual_rateio").Value
            End If

            If dTotalRateio + txtPercentualRateio.Value > 100 Then
                frmMain.errInfo.SetError(lblPercentualRateio, "A Soma do % Rateio não pode ser maior que 100%.")
                txtPercentualRateio.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoRateio = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: FALTA :::"

    Private Sub DeleteFalta()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdFalta) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & IIf(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Deleta Linha
                    Call oClsCadFuncionario.DeleteFalta(btnSalvar.Tag)

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

    Private Sub EditarFalta()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoFuncionario, gcUpdate) = True Then

                With grdFalta.CurrentRow.Cells

                    'Carrega Controles
                    cboTipoFalta.SelectedValue = .Item("codigo_tipo_falta").Value
                    txtDescricaoFalta.Text = .Item("descricao").Value
                    dtpDataFalta.Value = .Item("data").Value
                    txtHoraInicio.Text = .Item("hora_inicio").Value
                    txtHoraTermino.Text = .Item("hora_termino").Value
                    cboTipoArquivo.SelectedValue = .Item("codigo_tipo_arquivo").Value
                    txtArquivoFalta.Tag = .Item("extensao").Value
                    btnInserirFalta.Tag = .Item("codigo").Value

                End With

                'Seta Focu
                cboTipoFalta.Focus()

            Else

                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoFalta()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Ocupacao
            cboTipoFalta.Text = ""
            txtDescricaoFalta.Text = ""
            dtpDataFalta.Value = Now.Date
            cboTipoArquivoFalta.Text = ""
            txtHoraInicio.Text = "00:00:00"
            txtHoraTermino.Text = "00:00:00"
            txtArquivoFalta.Text = ""
            txtArquivoFalta.Tag = ""
            btnInserirFalta.Tag = ""

            'Seta Focu
            cboTipoFalta.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoFalta() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoFalta = False

            'Verifica se foi Selecionado o Campo - Tipo de Falta
            If ValidaCampo(cboTipoFalta, lblTipoFalta) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Descrição
            If ValidaCampo(txtDescricaoFalta, lblDescricaoFalta, TipoCampo.texto) = False Then
                Exit Function
            End If

            ''Verifica se a Data é Válida
            'If IsNumeric(btnInserirFalta.Tag) Then
            '    If VerificaExisteValorGrid(grdFalta, "data", dtpDataFalta.Value, grdFalta.CurrentRow.RowIndex) Then
            '        frmMain.errInfo.SetError(lblDataFalta, "Esta Data: " & dtpDataFalta.Value & " já está associado a um outro registro.")
            '        dtpDataFalta.Focus()
            '        Exit Function
            '    End If
            'Else
            '    If VerificaExisteValorGrid(grdFalta, "data", dtpDataFalta.Value, -1) Then
            '        frmMain.errInfo.SetError(lblDataFalta, "Esta Data: " & dtpDataFalta.Value & " já está associado a um outro registro.")
            '        dtpDataFalta.Focus()
            '        Exit Function
            '    End If
            'End If

            'Verifica se foi Preenchido o Campo - Hora Início
            If ValidaCampo(txtHoraInicio, lblHoraInicio, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Hora Término
            If ValidaCampo(txtHoraTermino, lblHoraTermino, TipoCampo.hora) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoFalta = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function







#End Region

#End Region

End Class
