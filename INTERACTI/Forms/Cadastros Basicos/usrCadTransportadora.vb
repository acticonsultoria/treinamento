Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls
Imports Janus.Windows.Common

Public Class usrCadTransportadora

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadTransportadora As New clsUsrCadTransportadora

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrCadTransportadora_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                    
                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboTipoContato" : Call LoadCombo(cboTipoContato, "sp_select_combo_cadastro_basico_tipo_contato " & goUsuario.iEmpresa)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboTipoContato" : Call btnCadastrarTipoContato_Click(btnCadastrarTipoContato, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadTransportadora_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: TRANSPORTADORA :::"

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
            oForm.NomeFormulario = Formulario.CadastroBasicoTransportadora
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoTransportadora)

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
            cboPersonalidadeFiltro.Focus()

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
                ProcuraCep(CLng(Replace(txtCEP.Text.Trim, "-", "")), _
                           cboUF, _
                           cboMunicipio, _
                           txtLogradouro)

            End If

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

    Private Sub cboPersonalidade_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPersonalidade.SelectedIndexChanged

        'Variaveis Locais
        Dim oSuperTipSettings As New SuperTipSettings

        If cboPersonalidade.SelectedIndex = -1 Then

            Exit Sub

        ElseIf cboPersonalidade.SelectedValue = Personalidade.Fisica Then

            oSuperTipSettings.HeaderText = "RG"
            oSuperTipSettings.Text = "Preencher RG (somente  números)."

            lblCnpjCpf.Text = "CPF:"
            txtCnpjCpf.Text = ""
            txtCnpjCpf.Mask = "000,000,000-00"
            txtInscricaoEstadual.Enabled = True
            lblInscricaoEstadual.Text = "RG:"
            txtInscricaoEstadual.Text = ""
            jstTip.SetSuperTip(txtInscricaoEstadual, oSuperTipSettings)

        ElseIf cboPersonalidade.SelectedValue = Personalidade.Juridica Then

            oSuperTipSettings.HeaderText = "Inscrição Estadual"
            oSuperTipSettings.Text = "Preencher Inscrição Estadual (somente  números) caso contribuinte do ICMS." & vbCrLf & _
                                     "Preencher com ISENTO caso contribuinte do ICMS, mas não estiver obrigado a inscrição no cadastro de contribuintes." & vbCrLf & _
                                     "Não preencher caso não for contribuinte do ICMS."

            lblCnpjCpf.Text = "CNPJ:"
            txtCnpjCpf.Text = ""
            txtCnpjCpf.Mask = "00,000,000/0000-00"
            lblInscricaoEstadual.Text = "Inscrição Estadual:"
            txtInscricaoEstadual.Text = ""
            jstTip.SetSuperTip(txtInscricaoEstadual, oSuperTipSettings)

        Else

            oSuperTipSettings.HeaderText = "Inscrição Estadual"
            oSuperTipSettings.Text = "Preencher Inscrição Estadual (somente  números) caso contribuinte do ICMS." & vbCrLf & _
                                     "Preencher com ISENTO caso contribuinte do ICMS, mas não estiver obrigado a inscrição no cadastro de contribuintes." & vbCrLf & _
                                     "Não preencher caso não for contribuinte do ICMS."

            lblCnpjCpf.Text = "CNPJ / CPF:"
            txtCnpjCpf.Text = ""
            txtCnpjCpf.Mask = ""
            lblInscricaoEstadual.Text = "Inscrição Estadual:"
            txtInscricaoEstadual.Text = ""
            jstTip.SetSuperTip(txtInscricaoEstadual, oSuperTipSettings)

        End If

    End Sub

    Private Sub cboPersonalidadeFiltro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPersonalidadeFiltro.SelectedIndexChanged

        If cboPersonalidadeFiltro.SelectedValue = Personalidade.Fisica Then

            lblCnpjCpfFiltro.Text = "CPF:"
            txtCnpjCpfFiltro.Text = ""
            txtCnpjCpfFiltro.Mask = "000,000,000-00"

        ElseIf cboPersonalidadeFiltro.SelectedValue = Personalidade.Juridica Then

            lblCnpjCpfFiltro.Text = "CNPJ:"
            txtCnpjCpfFiltro.Text = ""
            txtCnpjCpfFiltro.Mask = "00,000,000/0000-00"

        Else

            lblCnpjCpfFiltro.Text = "CNPJ / CPF:"
            txtCnpjCpfFiltro.Text = ""
            txtCnpjCpfFiltro.Mask = ""

        End If

    End Sub

    Private Sub cboUF_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUF.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum Registro
            If cboUF.SelectedIndex = -1 Then
                cboMunicipio.DataSource = Nothing
                cboMunicipio.Text = ""
            Else
                Call LoadCombo(cboMunicipio, "sp_select_combo_static_municipio '" & cboUF.SelectedValue & "'")
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Linha é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call Editar()
                Case "mapa" : Call Mapa()

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
                                     Formulario.CadastroBasicoTransportadora)

            'Carrega Combo
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.CadastroBasicoTransportadora, _
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
                                          Formulario.CadastroBasicoTransportadora, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: CONTATO :::"

    Private Sub btnAgruparGridContato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridContato.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdContato.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdContato.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdContato.GroupByBoxVisible = True
                grdContato.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridContato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridContato.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdContato
            oForm.NomeFormulario = Formulario.CadastroBasicoTransportadora
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdContato, Formulario.CadastroBasicoTransportadora)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridContato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridContato.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdContato)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarTipoContato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarTipoContato.Click

        Try

                        'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadTipoContato")

            'Carrega Combo
            Call LoadCombo(cboTipoContato, "sp_select_combo_cadastro_basico_tipo_contato " & goUsuario.iEmpresa)

            'Seta Focu
            cboTipoContato.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSalvarContato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarContato.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados da Transportadora
            If Validacao() = True Then

                'Salva Dados da Transportadora
                Call Salvar()

                'Valida Dados do Contato
                If ValidacaoContato() = True Then

                    'Verifica o Tipo de Operação
                    If IsNumeric(btnSalvarContato.Tag) = False Then

                        'Insere Contato
                        Call oClsCadTransportadora.InsertContato(txtNomeContato.Text.Trim, _
                                                                 txtTelefoneContato.Text.Trim, _
                                                                 txtCelularContato.Text.Trim, _
                                                                 IIf(dtpDataAniversario.Checked = True, dtpDataAniversario.Value, ""), _
                                                                 txtEmailContato.Text.Trim, _
                                                                 txtComplementoContato.Text.Trim, _
                                                                 cboTipoContato.SelectedValue)

                    Else

                        'Atualiza Dados do Contato
                        Call oClsCadTransportadora.UpdateContato(txtNomeContato.Text.Trim, _
                                                                 txtTelefoneContato.Text.Trim, _
                                                                 txtCelularContato.Text.Trim, _
                                                                 IIf(dtpDataAniversario.Checked = True, dtpDataAniversario.Value, ""), _
                                                                 txtEmailContato.Text.Trim, _
                                                                 txtComplementoContato.Text.Trim, _
                                                                 cboTipoContato.SelectedValue, _
                                                                 btnSalvarContato.Tag)

                    End If

                    'Carrega Lista de Contato
                    Call oClsCadTransportadora.LoadGridContato(grdContato, _
                                                               btnSalvar.Tag)

                    'Prepara Formulário para Inserção de um Novo Registro
                    Call NovoContato()

                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirContato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirContato.Click

        Try

            'Deleta Registros
            Call DeleteContato()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdContato_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdContato.RowDoubleClick

        Try

            'Verifica se a Linha é Válida
            If IsNothing(grdContato.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdContato.CurrentColumn.Key

                Case "editar" : Call EditarContato()
                Case "email" : Call EmailContato()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdContato_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdContato.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdContato, _
                                     Formulario.CadastroBasicoTransportadora)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdContato_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdContato.SizingColumn

        Try

            'Verifica se a Linha é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdContato.Name, _
                                     Formulario.CadastroBasicoTransportadora, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdContato_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdContato.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdContato.Name, _
                                          Formulario.CadastroBasicoTransportadora, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: VEÍCULO :::"

    Private Sub btnAgruparGridVeiculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridVeiculo.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdVeiculo.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdVeiculo.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdVeiculo.GroupByBoxVisible = True
                grdVeiculo.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridVeiculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridVeiculo.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdVeiculo
            oForm.NomeFormulario = Formulario.CadastroBasicoTransportadora
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdVeiculo, Formulario.CadastroBasicoTransportadora)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridVeiculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridVeiculo.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdVeiculo)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirVeiculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirVeiculo.Click

        Try

            'Deleta Registros
            Call DeleteVeiculo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirVeiculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirVeiculo.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Parceiro de Negócio
            If Validacao() = True Then

                'Salva Dados do Parceiro de Negócio
                Call Salvar()

                'Valida Dados do Formulário
                If ValidacaoVeiculo() = True Then

                    'Váriaveis Locais
                    Dim sPlacaAntigo As String = ""
                    Dim sUFAntigo As String = ""

                    'Carrega Váriaveis
                    If IsNumeric(btnInserirVeiculo.Tag) Then
                        sPlacaAntigo = grdVeiculo.CurrentRow.Cells("placa").Value
                        sUFAntigo = grdVeiculo.CurrentRow.Cells("uf").Value
                    End If

                    'Verifica o Tipo de Operação
                    If IsNumeric(btnInserirVeiculo.Tag) Then

                        'Atualiza Registro na tb_cad_transportadora_veiculo
                        Call oClsCadTransportadora.UpdateVeiculo(txtDescricaoVeiculo.Text.Trim, _
                                                                 txtPlacaVeiculo.Text.Trim, _
                                                                 cboUFVeiculo.SelectedValue, _
                                                                 txtRNTCVeiculo.Text.Trim, _
                                                                 sPlacaAntigo, _
                                                                 sUFAntigo)

                    Else

                        'Insere Registro na tb_cad_transportadora_veiculo
                        Call oClsCadTransportadora.InsertVeiculo(txtDescricaoVeiculo.Text.Trim, _
                                                                 txtPlacaVeiculo.Text.Trim, _
                                                                 cboUFVeiculo.SelectedValue, _
                                                                 txtRNTCVeiculo.Text.Trim)

                    End If

                    'Carrega Grid de Veículo
                    Call oClsCadTransportadora.LoadGridVeiculo(grdVeiculo, _
                                                               btnSalvar.Tag)

                    'Prepara Formulário para Inserção de um Novo Registro
                    Call NovoVeiculo()

                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdVeiculo_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdVeiculo.RowDoubleClick

        Try

            'Verifica se a Linha é Válida
            If IsNothing(grdVeiculo.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdVeiculo.CurrentColumn.Key

                Case "editar" : Call EditarVeiculo()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdVeiculo_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdVeiculo.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdVeiculo, _
                                     Formulario.CadastroBasicoTransportadora)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdVeiculo_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdVeiculo.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdVeiculo.Name, _
                                     Formulario.CadastroBasicoTransportadora, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdVeiculo_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdVeiculo.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdVeiculo.Name, _
                                          Formulario.CadastroBasicoTransportadora, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: MOTORISTA :::"
    Private Sub btnInserirMotorista_Click(sender As Object, e As EventArgs) Handles btnInserirMotorista.Click
        Try
            If Validacao() = True Then

                'Salva Dados do Parceiro de Negócio
                Call Salvar()

                'Valida Dados do Formulário
                If ValidacaoMotorista() = True Then

                    If IsNumeric(btnInserirMotorista.Tag) Then

                        'Atualiza Registro na tb_cad_transportadora_veiculo
                        Call oClsCadTransportadora.UpdateMotorista(btnSalvar.Tag, _
                                                                   btnInserirMotorista.Tag, _
                                                                   txtNomeMotorista.Text, _
                                                                   txtCPFMotorista.Text, _
                                                                   txtRGMotorista.Text, _
                                                                   txtPISNITMotorista.Text, _
                                                                   IIf(dtpDataNascimentoMotorista.Checked = True, dtpDataNascimentoMotorista.Value, ""), _
                                                                   txtCEPMotorista.Text, _
                                                                   IIf(cboUFMotorista.SelectedIndex = -1, "", cboUFMotorista.SelectedValue), _
                                                                   IIf(cboMunicipioMotorista.SelectedIndex = -1, -1, cboMunicipioMotorista.SelectedValue), _
                                                                   txtEnderecoMotorista.Text, _
                                                                   txtPlacaMotorista.Text, _
                                                                   txtNumeroNTT.Text, _
                                                                   IIf(dtpDataVencimentoNTT.Checked = False, "", dtpDataVencimentoNTT.Value), _
                                                                   txtNumeroCNH.Text, _
                                                                   dtpDataVencimentoCNH.Value)

                    Else

                        'Insere Registro na tb_cad_transportadora_veiculo
                        Call oClsCadTransportadora.InsertMotorista(btnSalvar.Tag, _
                                                                   txtNomeMotorista.Text, _
                                                                   txtCPFMotorista.Text, _
                                                                   txtRGMotorista.Text, _
                                                                   txtPISNITMotorista.Text, _
                                                                   IIf(dtpDataNascimentoMotorista.Checked = True, dtpDataNascimentoMotorista.Value, ""), _
                                                                   txtCEPMotorista.Text, _
                                                                   IIf(cboUFMotorista.SelectedIndex = -1, "", cboUFMotorista.SelectedValue), _
                                                                   IIf(cboMunicipioMotorista.SelectedIndex = -1, -1, cboMunicipioMotorista.SelectedValue), _
                                                                   txtEnderecoMotorista.Text, _
                                                                   txtPlacaMotorista.Text, _
                                                                   txtNumeroNTT.Text, _
                                                                   IIf(dtpDataVencimentoNTT.Checked = False, "", dtpDataVencimentoNTT.Value), _
                                                                   txtNumeroCNH.Text, _
                                                                   dtpDataVencimentoCNH.Value)

                    End If

                    'Carrega Grid de Veículo
                    Call oClsCadTransportadora.LoadGridMotorista(grdMotorista, _
                                                               btnSalvar.Tag)

                    'Prepara Formulário para Inserção de um Novo Registro
                    Call NovoMotorista()

                End If
            End If

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluirMotorista_Click(sender As Object, e As EventArgs) Handles btnExcluirMotorista.Click
        Try

            'Deleta Registros
            Call DeleteMotorista()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdMotorista_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdMotorista.RowDoubleClick

        Try

            'Verifica se a Linha é Válida
            If IsNothing(grdMotorista.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdMotorista.CurrentColumn.Key

                Case "editar" : Call EditarMotorista()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboUFMotorista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUFMotorista.SelectedIndexChanged
        Try

            'Verifica se foi selecionado algum Registro
            If cboUFMotorista.SelectedIndex = -1 Then
                cboMunicipioMotorista.DataSource = Nothing
                cboMunicipioMotorista.Text = ""
            Else
                Call LoadCombo(cboMunicipioMotorista, "sp_select_combo_static_municipio '" & cboUFMotorista.SelectedValue & "'")
            End If

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadTransportadora_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.CadastroBasicoTransportadora, gcDelete)
            btnNovo1.Enabled = VerificaDireito(Formulario.CadastroBasicoTransportadora, gcInsert)
            btnNovo.Enabled = VerificaDireito(Formulario.CadastroBasicoTransportadora, gcInsert)
            btnSalvarContato.Enabled = VerificaDireito(Formulario.CadastroBasicoTransportadora, gcInsert)
            btnExcluirContato.Enabled = VerificaDireito(Formulario.CadastroBasicoTransportadora, gcDelete)
            btnInserirVeiculo.Enabled = VerificaDireito(Formulario.CadastroBasicoTransportadora, gcInsert)
            btnExcluirVeiculo.Enabled = VerificaDireito(Formulario.CadastroBasicoTransportadora, gcDelete)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.CadastroBasicoTransportadora, gcPrint)
            btnExcelGridContato.Enabled = VerificaDireito(Formulario.CadastroBasicoTransportadora, gcPrint)
            btnExcelGridVeiculo.Enabled = VerificaDireito(Formulario.CadastroBasicoTransportadora, gcPrint)

            'Verifica Direito - Cadastrar
            btnCadastrarTipoContato.Enabled = VerificaDireito(Formulario.CadastroBasicoTipoContato, gcInsert)

            'Carrega Combo
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboPersonalidadeFiltro : oComboBox(1) = cboPersonalidade
            Call LoadCombo(oComboBox, "sp_select_combo_static_personalidade")
            Call LoadCombo(cboTipoContato, "sp_select_combo_cadastro_basico_tipo_contato " & goUsuario.iEmpresa, False)
            oComboBox(0) = cboUFFiltro : oComboBox(1) = cboUF
            Call LoadCombo(oComboBox, "sp_select_combo_static_estado_pais " & Pais.Brasil)
            Call LoadCombo(cboUFVeiculo, "sp_select_combo_static_estado")
            Call LoadCombo(cboUFMotorista, "sp_select_combo_static_estado")
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)
            Call LoadComboSimNao(cboImportado)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoTransportadora)
            Call ConfiguraGrid(grdContato, Formulario.CadastroBasicoTransportadora)
            Call ConfiguraGrid(grdVeiculo, Formulario.CadastroBasicoTransportadora)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            cboPersonalidadeFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: TRANSPORTADORA :::"

    Private Sub Delete()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCadTransportadora.Delete()

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

    Private Sub Editar()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoTransportadora, gcUpdate) = True Then

                'Limpa Formulário
                Call Novo()

                'Carrega Controles
                oClsCadTransportadora.LoadControles(grdListagem.CurrentRow.Cells.Item("codigo").Value, _
                                                    cboPersonalidade, _
                                                    txtRazaoSocial, _
                                                    txtNomeFantasia, _
                                                    cboAtivo, _
                                                    txtCnpjCpf, _
                                                    txtInscricaoEstadual, _
                                                    txtCEP, _
                                                    txtLogradouro, _
                                                    cboUF, _
                                                    cboMunicipio, _
                                                    txtObservacao, _
                                                    txtTelefone1, _
                                                    txtTelefone2, _
                                                    txtTelefoneRecado, _
                                                    txtFax, _
                                                    txtEmail, _
                                                    chkMotorista)

                'Seta Código
                btnSalvar.Tag = grdListagem.CurrentRow.Cells.Item("codigo").Value

                'Carrega Grid de Contato
                oClsCadTransportadora.LoadGridContato(grdContato, _
                                                      grdListagem.CurrentRow.Cells.Item("codigo").Value)

                'Carrega Grid de Veículo
                oClsCadTransportadora.LoadGridVeiculo(grdVeiculo, _
                                                      grdListagem.CurrentRow.Cells.Item("codigo").Value)

                Call oClsCadTransportadora.LoadGridMotorista(grdMotorista, _
                                                              grdListagem.CurrentRow.Cells.Item("codigo").Value)

                'Seta Aba
                tabDados.SelectedTab = pagDadosGerais

                'Alterna Aba
                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                cboPersonalidade.Focus()

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
            cboPersonalidade.SelectedIndex = -1
            btnSalvar.Tag = ""
            txtRazaoSocial.Text = ""
            txtNomeFantasia.Text = ""
            cboAtivo.SelectedValue = True
            txtCnpjCpf.Text = ""
            txtInscricaoEstadual.Text = ""
            txtLogradouro.Text = ""
            cboUF.SelectedIndex = -1
            cboMunicipio.SelectedIndex = -1
            txtTelefone1.Text = ""
            txtTelefone2.Text = ""
            txtFax.Text = ""
            txtTelefoneRecado.Text = ""
            txtEmail.Text = ""
            txtObservacao.Text = ""
            chkMotorista.Checked = False

            'Limpa Controles - Contato
            cboTipoContato.SelectedIndex = -1
            cboTipoContato.Text = ""
            txtNomeContato.Text = ""
            txtTelefoneContato.Text = ""
            txtCelularContato.Text = ""
            dtpDataAniversario.Value = Now.Date : dtpDataAniversario.Checked = False
            txtEmailContato.Text = ""
            txtComplementoContato.Text = ""
            btnSalvarContato.Tag = ""
            grdContato.DataSource = Nothing

            'Limpa Controles - Veículo
            txtDescricaoVeiculo.Text = ""
            txtPlacaVeiculo.Text = ""
            cboUF.SelectedIndex = -1
            txtRNTCVeiculo.Text = ""
            btnInserirVeiculo.Tag = ""
            grdVeiculo.DataSource = Nothing

            'Seta Aba
            tabDados.SelectedTab = pagDadosGerais

            'Seta Focu
            cboPersonalidade.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCadTransportadora.CodigoTransportadora = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1)
            oClsCadTransportadora.Personalidade = cboPersonalidade.SelectedValue
            oClsCadTransportadora.RazaoSocial = txtRazaoSocial.Text.Trim
            oClsCadTransportadora.NomeFantasia = txtNomeFantasia.Text.Trim
            oClsCadTransportadora.CNPJCPF = txtCnpjCpf.Text.Trim
            oClsCadTransportadora.InscricaoEstadual = txtInscricaoEstadual.Text.Trim
            oClsCadTransportadora.CEP = txtCEP.Text.Trim
            oClsCadTransportadora.Endereco = txtLogradouro.Text.Trim
            oClsCadTransportadora.UF = cboUF.SelectedValue
            oClsCadTransportadora.Municipio = cboMunicipio.Text
            oClsCadTransportadora.Telefone1 = txtTelefone1.Text
            oClsCadTransportadora.Email = txtEmail.Text
            oClsCadTransportadora.Telefone2 = txtTelefone2.Text
            oClsCadTransportadora.Fax = txtFax.Text
            oClsCadTransportadora.TelefoneRecado = txtTelefoneRecado.Text
            oClsCadTransportadora.Observacao = txtObservacao.Text.Trim
            oClsCadTransportadora.Ativo = cboAtivo.SelectedValue
            oClsCadTransportadora.Motorista = chkMotorista.Checked

            'Verifica o Tipo de Operação
            If IsNumeric(btnSalvar.Tag) Then
                oClsCadTransportadora.Update()
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                oClsCadTransportadora.Insert()
                btnSalvar.Tag = oClsCadTransportadora.CodigoTransportadora
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
            oClsCadTransportadora.LoadGrid(grdListagem, _
                                           IIf(cboPersonalidadeFiltro.SelectedIndex = -1, -1, cboPersonalidadeFiltro.SelectedValue), _
                                           txtRazaoSocialFiltro.Text.Trim, _
                                           txtNomeFantasiaFiltro.Text.Trim, _
                                           txtCnpjCpfFiltro.Text.Trim, _
                                           IIf(cboUFFiltro.SelectedIndex = -1, "", cboUFFiltro.SelectedValue), _
                                           txtMunicipioFiltro.Text.Trim, _
                                           IIf(cboImportado.SelectedIndex = -1, -1, IIf(cboImportado.SelectedValue = True, 1, 0)))

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

            'Verifica se foi Selecionado o Campo - Personalidade
            If ValidaCampo(cboPersonalidade, lblPersonalidade) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Razao Social
            If ValidaCampo(txtRazaoSocial, lblRazaoSocial, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Nome Fantasia
            If ValidaCampo(txtNomeFantasia, lblNomeFantasia, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Ativo
            If ValidaCampo(cboAtivo, lblAtivo) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - CEP
            If ValidaCampo(txtCEP, lblCEP, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - UF
            If ValidaCampo(cboUF, lblUF) = False Then
                tabDados.SelectedTab = pagDadosGerais : cboUF.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Município
            If cboUF.SelectedValue <> gcUFExterior Then
                If ValidaCampo(cboMunicipio, lblMunicipio) = False Then
                    tabDados.SelectedTab = pagDadosGerais : cboMunicipio.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Logradouro
            If ValidaCampo(txtLogradouro, lblLogradouro, TipoCampo.texto) = False Then
                tabDados.SelectedTab = pagDadosGerais : txtLogradouro.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - CNPJ / CPF
            If cboPersonalidade.SelectedValue <> Personalidade.OrgaoPublico Then

                'Verifica se foi Preenchido o Campo - CNPJ / CPF
                If ValidaCampo(txtCnpjCpf, lblCnpjCpf, TipoCampo.texto) = False Then
                    tabDados.SelectedTab = pagDadosGerais : txtCnpjCpf.Focus()
                    Exit Function
                End If

                ' Verifica se o CNPJ / CPF é válido
                If cboPersonalidade.SelectedValue = Personalidade.Fisica And txtCnpjCpf.Text <> "" Then
                    If ValidaCPF(txtCnpjCpf.Text.Trim) = False Then
                        frmMain.errInfo.SetError(lblCnpjCpf, "Este CPF não é válido!")
                        tabDados.SelectedTab = pagDadosGerais : txtCnpjCpf.Focus()
                        Exit Function
                    End If
                End If

                If cboPersonalidade.SelectedValue = Personalidade.Juridica And txtCnpjCpf.Text <> "" Then
                    If ValidaCNPJ(txtCnpjCpf.Text.Trim) = False Then
                        frmMain.errInfo.SetError(lblCnpjCpf, "Este CNPJ não é válido!")
                        tabDados.SelectedTab = pagDadosGerais : txtCnpjCpf.Focus()
                        Exit Function
                    End If
                End If

                'Passa Parametros
                If txtCnpjCpf.Text <> "" Then
                    If oClsCadTransportadora.ValidaCnpjCpf(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1), _
                                                           txtCnpjCpf.Text.Trim) = False Then
                        frmMain.errInfo.SetError(lblCnpjCpf, "Este " & IIf(cboPersonalidade.SelectedValue = Personalidade.Juridica, "CNPJ", "CPF") & ": " & txtCnpjCpf.Text & " já está associado a outro Registro.")
                        tabDados.SelectedTab = pagDadosGerais : txtCnpjCpf.Focus()
                        Exit Function
                    End If
                End If

                'Verifica se foi Preenchido o Campo - IE
                If txtInscricaoEstadual.Text.Trim <> "" Then

                    If ValidaCampo(txtInscricaoEstadual, lblInscricaoEstadual, TipoCampo.texto) = False Then
                        tabDados.SelectedTab = pagDadosGerais : txtInscricaoEstadual.Focus()
                        Exit Function
                    End If

                    'Verifica se a IE é válida
                    If cboPersonalidade.SelectedValue = Personalidade.Juridica Then
                        If ValidaIE(cboUF.SelectedValue, txtInscricaoEstadual.Text.Trim) = False Then
                            frmMain.errInfo.SetError(lblInscricaoEstadual, "Esta Inscrição Estadual não é válido!")
                            tabDados.SelectedTab = pagDadosGerais : txtInscricaoEstadual.Focus()
                            Exit Function
                        End If
                    End If

                End If

            End If

            'Verifica se o E-mail é Válido
            If txtEmail.Text.Trim <> "" Then
                If ValidaCampo(txtEmail, lblEmail, TipoCampo.email) = False Then
                    tabDados.SelectedTab = pagDadosGerais : txtEmail.Focus()
                    Exit Function
                End If
            End If

            ''Verifica se foi Selecionado o Campo - Telefone Principal
            'If ValidaCampo(txtTelefone1, lblTelefone1, TipoCampo.texto) = False Then
            '    Exit Function
            'End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub Mapa()

        Try

            'Váriaveis Locais - Formulário Mapa
            Dim oForm As New frmActMaps
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location

            Dim sEndereco As String = ""
            Dim sCEP As String = ""
            Dim sMunicipio As String = ""

            Call LoadDadosTransportadoraEndereco(grdListagem.CurrentRow.Cells("codigo").Value, _
                                                 sEndereco, _
                                                 sCEP, _
                                                 sMunicipio)

            'Seta Parâmetros do Formulário
            oForm.EnderecoDestino = sEndereco
            oForm.CepDestino = sCEP
            oForm.MunicipioDestino = sMunicipio

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: CONTATO :::"

    Private Sub NovoContato()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            cboTipoContato.SelectedIndex = -1
            cboTipoContato.Text = ""
            txtNomeContato.Text = ""
            txtTelefoneContato.Text = ""
            txtCelularContato.Text = ""
            dtpDataAniversario.Value = Now.Date : dtpDataAniversario.Checked = False
            txtEmailContato.Text = ""
            txtComplementoContato.Text = ""
            btnSalvarContato.Tag = ""

            'Seta Focu
            cboTipoContato.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EmailContato()

        Try

            'Verifica se o Contato possui E-mail
            If IsDBNull(grdContato.CurrentRow.Cells("email").Value) = False Then

                'Enviar E-mail
                Call EnviarEmail("", _
                                 grdContato.CurrentRow.Cells("email2").Value, _
                                 "", _
                                 "", _
                                 "", _
                                 -1)

            Else
                'Informa o Usuário que o Contato não possui E-mail
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub EditarContato()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoTransportadora, gcUpdate) = True Then

                With grdContato.CurrentRow.Cells

                    'Limpa Controles
                    Call NovoContato()

                    'Carrega Controles
                    cboTipoContato.SelectedValue = .Item("codigo_tipo_contato").Value
                    txtNomeContato.Text = .Item("nome").Value
                    txtTelefoneContato.Text = .Item("telefone").Value
                    txtCelularContato.Text = .Item("celular").Value
                    If IsDate(.Item("data_aniversario").Value) Then
                        dtpDataAniversario.Value = .Item("data_aniversario").Value : dtpDataAniversario.Checked = True
                    Else
                        dtpDataAniversario.Value = Now.Date : dtpDataAniversario.Checked = False
                    End If
                    txtEmailContato.Text = IIf(IsDBNull(.Item("email2").Value), "", .Item("email2").Value)
                    txtComplementoContato.Text = IIf(IsDBNull(.Item("complemento").Value), "", .Item("complemento").Value)
                    btnSalvarContato.Tag = .Item("codigo").Value

                    'Seta Focu
                    cboTipoContato.Focus()

                End With

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Function ValidacaoContato() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoContato = False

            'Verifica se foi Selecionado o Campo - Tipo de Contato
            If ValidaCampo(cboTipoContato, lblTipoContato) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Nome
            If ValidaCampo(txtNomeContato, lblNomeContato, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Telefone
            If txtTelefoneContato.Text.Trim = "" And txtCelularContato.Text.Trim = "" Then
                frmMain.errInfo.SetError(lblTelefoneContato, "O Campo [Telefone ou Celular] é obrigatório. Digite um valor para ele.")
                txtTelefoneContato.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Email
            If txtEmailContato.Text.Trim <> "" Then
                If ValidaCampo(txtEmailContato, lblEmailContato, TipoCampo.email) = False Then
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            ValidacaoContato = True

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Function

    Private Sub DeleteContato()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdContato) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Deleta Contato
                    oClsCadTransportadora.CodigoTransportadora = btnSalvar.Tag
                    oClsCadTransportadora.DeleteContato()

                    'Limpa Formulário
                    Call NovoContato()

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

#Region "::: VEÍCULO :::"

    Private Sub NovoVeiculo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            txtDescricaoVeiculo.Text = ""
            txtPlacaVeiculo.Text = ""
            cboUFVeiculo.SelectedIndex = -1
            txtRNTCVeiculo.Text = ""
            btnInserirVeiculo.Tag = ""

            'Seta Focu
            txtDescricaoVeiculo.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarVeiculo()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoTransportadora, gcUpdate) = True Then

                With grdVeiculo.CurrentRow.Cells

                    'Limpa Controles
                    Call NovoVeiculo()

                    'Carrega Controles
                    txtDescricaoVeiculo.Text = .Item("descricao").Value
                    txtPlacaVeiculo.Text = .Item("placa").Value
                    cboUFVeiculo.SelectedValue = .Item("uf").Value
                    txtRNTCVeiculo.Text = IIf(IsDBNull(.Item("rntc").Value), "", .Item("rntc").Value)
                    btnInserirVeiculo.Tag = .Row.RowIndex

                    'Seta Focu
                    txtDescricaoVeiculo.Focus()

                End With

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoVeiculo() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoVeiculo = False

            'Verifica se foi Preenchido o Campo - Descrição
            If ValidaCampo(txtDescricaoVeiculo, lblDescricaoVeiculo, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Placa
            If ValidaCampo(txtPlacaVeiculo, lblPlacaVeiculo, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - UF
            If ValidaCampo(cboUFVeiculo, lblUFVeiculo) = False Then
                Exit Function
            End If

            'Verifica se o Campo Telefone ja está na Grid
            For Each oRow As GridEXRow In grdVeiculo.GetDataRows
                If oRow.Cells("placa").Value = txtPlacaVeiculo.Text.Trim And oRow.Cells("uf").Value = cboUFVeiculo.SelectedValue Then
                    If IsNumeric(btnInserirVeiculo.Tag) Then
                        If btnInserirVeiculo.Tag <> grdVeiculo.CurrentRow.RowIndex Then
                            frmMain.errInfo.SetError(lblPlacaVeiculo, "Esta Placa já esta associada a outro Registro.")
                            txtPlacaVeiculo.Focus()
                            Exit Function
                        End If
                    Else
                        frmMain.errInfo.SetError(lblPlacaVeiculo, "Esta Placa já esta associada a outro Registro.")
                        txtPlacaVeiculo.Focus()
                        Exit Function
                    End If
                End If
            Next

            'Seta Retorno da Função
            ValidacaoVeiculo = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub DeleteVeiculo()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdVeiculo) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Deleta Vendedor
                    oClsCadTransportadora.CodigoTransportadora = btnSalvar.Tag
                    oClsCadTransportadora.DeleteVeiculo()

                    'Limpa Formulário
                    Call NovoVeiculo()

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

#Region "::: MOTORISTA :::"
    Private Sub EditarMotorista()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoTransportadora, gcUpdate) = True Then

                With grdMotorista.CurrentRow.Cells

                    'Limpa Controles
                    Call NovoMotorista()

                    'Carrega Controles
                    btnInserirMotorista.Tag = .Item("codigo").Value
                    txtNomeMotorista.Text = .Item("nome").Value
                    txtCPFMotorista.Text = .Item("cpf").Value
                    txtRGMotorista.Text = .Item("rg").Value
                    txtPISNITMotorista.Text = .Item("pis_nit").Value
                    If IsDBNull(.Item("data_nascimento").Value) = False Then
                        dtpDataNascimentoMotorista.Checked = True : dtpDataNascimentoMotorista.Value = .Item("data_nascimento").Value
                    Else
                        dtpDataNascimentoMotorista.Checked = False : dtpDataNascimentoMotorista.Value = Now.Date
                    End If
                    txtCEPMotorista.Text = .Item("cep").Value
                    cboUFMotorista.SelectedValue = .Item("uf").Value
                    cboMunicipioMotorista.SelectedValue = .Item("codigo_municipio").Value
                    txtEnderecoMotorista.Text = .Item("endereco").Value
                    txtPlacaMotorista.Text = .Item("placa").Value
                    txtNumeroNTT.Text = .Item("numero_ntt").Value
                    If IsDBNull(.Item("data_vencimento_ntt").Value) = False Then
                        dtpDataNascimentoMotorista.Checked = True : dtpDataNascimentoMotorista.Value = .Item("data_vencimento_ntt").Value
                    Else
                        dtpDataNascimentoMotorista.Checked = False : dtpDataNascimentoMotorista.Value = Now.Date
                    End If
                    txtNumeroCNH.Text = .Item("numero_cnh").Value
                    dtpDataVencimentoCNH.Value = .Item("data_vencimento_cnh").Value

                End With

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoMotorista() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoMotorista = False

            'Verifica se foi Preenchido o Campo - Descrição
            If ValidaCampo(txtNomeMotorista, lblNomeMotorista, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Placa
            If ValidaCampo(txtCPFMotorista, lblCPFMotorista, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoMotorista = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub NovoMotorista()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            btnInserirMotorista.Tag = ""
            txtNomeMotorista.Text = ""
            txtCPFMotorista.Text = ""
            txtRGMotorista.Text = ""
            txtPISNITMotorista.Text = ""
            dtpDataNascimentoMotorista.Checked = False : dtpDataNascimentoMotorista.Value = Now.Date
            txtCEPMotorista.Text = ""
            cboUFMotorista.SelectedIndex = -1
            cboMunicipioMotorista.SelectedIndex = -1
            txtEnderecoMotorista.Text = ""
            txtPlacaMotorista.Text = ""
            txtNumeroNTT.Text = ""
            dtpDataVencimentoNTT.Checked = False : dtpDataVencimentoNTT.Value = Now.Date


            'Seta Focu
            txtDescricaoVeiculo.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteMotorista()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdMotorista) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Deleta Vendedor
                    oClsCadTransportadora.DeleteMotorista()

                    'Limpa Formulário
                    Call NovoMotorista()

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

#End Region

    
End Class

