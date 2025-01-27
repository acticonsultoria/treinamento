Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls
Imports Janus.Windows.Common
Imports Microsoft.Office.Interop

Public Class usrCadVendedor

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadVendedor As New clsUsrCadVendedor

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrCadVendedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                    
                Case Keys.F3

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "txtCEP" : Call btnProcurarCEP_Click(btnProcurarCEP, System.EventArgs.Empty)
                        Case "txtCepEndereco" : Call btnProcurarCEPEndereco_Click(btnProcurarCepEndereco, System.EventArgs.Empty)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name

                        Case "cboPais" : Call LoadCombo(cboPais, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)
                        Case "cboPaisEndereco" : Call LoadCombo(cboPaisEndereco, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)
                        Case "cboVendedor" : Call LoadCombo(cboVendedor, "sp_select_combo_cadastro_basico_vendedor " & goUsuario.iEmpresa & ", " & goUsuario.iUsuario, )
                        Case "cboRegraComissao" : Call LoadCombo(cboRegraComissao, "sp_select_combo_venda_regra_comissao " & goUsuario.iEmpresa)

                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name

                        Case "cboPais" : Call btnCadastrarPais_Click(btnCadastrarPais, System.EventArgs.Empty)
                        Case "cboPaisEndereco" : Call btnCadastrarPaisEndereco_Click(btnCadastrarPaisEndereco, System.EventArgs.Empty)
                        Case "cboRegraComissao" : Call btnCadastrarRegraComissao_Click(btnCadastrarRegraComissao, System.EventArgs.Empty)

                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadVendedor_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCadVendedor_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona Formulário
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

#End Region

#Region "::: VENDEDOR :::"

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
            oForm.NomeFormulario = Formulario.CadastroBasicoVendedor
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoVendedor)

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

    Private Sub btnCadastrarRegraComissao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarRegraComissao.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrVenRegraComissao"
            oForm.Titulo = Me.Parent.Text
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Carrega Combo
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboRegraComissaoFiltro : oComboBox(1) = cboRegraComissao
            Call LoadCombo(oComboBox, "sp_select_combo_venda_regra_comissao " & goUsuario.iEmpresa)

            'Seta Focu
            cboRegraComissao.Focus()

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
            Call LoadCombo(cboPaisEndereco, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)
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
                ProcuraCep(CLng(Replace(txtCEP.Text.Trim, "-", "")), _
                           cboPais, _
                           cboUF, _
                           cboMunicipio, _
                           txtBairro, _
                           txtLogradouro, _
                           txtComplemento)

            End If

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
            cboTipoVendedorFiltro.Focus()

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

    Private Sub cboTipoVendedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoVendedor.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum Registro
            If cboTipoVendedor.SelectedIndex = -1 Then
                If tabDados.TabPages.Contains(pagSubordinados) = True Then
                    tabDados.TabPages.Remove(pagSubordinados)
                End If
            ElseIf cboTipoVendedor.SelectedValue = CInt(TipoVendedor.Supervisor) Then
                If tabDados.TabPages.Contains(pagSubordinados) = False Then
                    tabDados.TabPages.Add(pagSubordinados)
                    'Carrega Combo
                    Call LoadCombo(cboVendedor, "sp_select_combo_cadastro_basico_vendedor " & goUsuario.iEmpresa & ", -1, '" & TipoVendedor.Vendedor & "," & TipoVendedor.Representante & "'")
                End If
            Else
                If tabDados.TabPages.Contains(pagSubordinados) = True Then
                    tabDados.TabPages.Remove(pagSubordinados)
                End If
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboPais_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPais.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum Registro
            If cboPais.SelectedIndex = -1 Then
                cboUF.DataSource = Nothing
                cboUF.Text = ""
                cboMunicipio.DataSource = Nothing
                cboMunicipio.Text = ""
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

            'Verifica o Tipo de Linha
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call EditarVendedor()

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
                                     Formulario.CadastroBasicoVendedor)

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
                                     Formulario.CadastroBasicoVendedor, _
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
                                          Formulario.CadastroBasicoVendedor, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ENDEREÇO :::"

    Private Sub btnAgruparGridEndereco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridEndereco.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdEndereco.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdEndereco.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdEndereco.GroupByBoxVisible = True
                grdEndereco.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridEndereco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridEndereco.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdEndereco
            oForm.NomeFormulario = Formulario.CadastroBasicoParceiroNegocio
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdEndereco, Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridEndereco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridEndereco.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdEndereco)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarPaisEndereco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarPaisEndereco.Click

        Try

                         'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadPais")

            'Carrega Combo
            Call LoadCombo(cboPais, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)
            Call LoadCombo(cboPaisEndereco, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)
            'Seta Focu
            cboPais.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarCepEndereco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCepEndereco.Click

        Try

            'Verifica se foi preenchido o CEP
            If txtCepEndereco.Text.Replace("-", "").Trim.Length = 8 Then

                'Verifica se há o cep no banco de dados
                ProcuraCep(CLng(Replace(txtCepEndereco.Text.Trim, "-", "")), _
                           cboPaisEndereco, _
                           cboUFEndereco, _
                           cboMunicipioEndereco, _
                           txtBairroEndereco, _
                           txtLogradouroEndereco, _
                           txtComplementoEndereco)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirEndereco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirEndereco.Click

        Try

            'Deleta Registros
            Call DeleteEndereco()

            'Limpa Formulário
            Call NovoEndereco()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSalvarEndereco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarEndereco.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Parceiro de Negócio
            If Validacao() = True Then

                'Salva Dados do Parceiro de Negócio
                Call Salvar()

                'Valida Dados do Endereço
                If ValidacaoEndereco() = True Then

                    'Verifica o Tipo de Operação
                    If IsNumeric(btnSalvarEndereco.Tag) = False Then

                        'Insere Endereço                        
                        Call oClsCadVendedor.InsertEndereco(cboTipoEndereco.SelectedValue, _
                                                            txtCepEndereco.Text.Trim, _
                                                            cboPaisEndereco.SelectedValue, _
                                                            cboUFEndereco.SelectedValue, _
                                                            cboMunicipioEndereco.SelectedValue, _
                                                            txtLogradouroEndereco.Text.Trim, _
                                                            txtNumeroEndereco.Text.Trim, _
                                                            txtBairroEndereco.Text.Trim, _
                                                            txtComplementoEndereco.Text.Trim)

                    Else

                        'Atualiza Endereço                        
                        Call oClsCadVendedor.UpdateEndereco(cboTipoEndereco.SelectedValue, _
                                                            txtCepEndereco.Text.Trim, _
                                                            cboPaisEndereco.SelectedValue, _
                                                            cboUFEndereco.SelectedValue, _
                                                            cboMunicipioEndereco.SelectedValue, _
                                                            txtLogradouroEndereco.Text.Trim, _
                                                            txtNumeroEndereco.Text.Trim, _
                                                            txtBairroEndereco.Text.Trim, _
                                                            txtComplementoEndereco.Text.Trim, _
                                                            btnSalvarEndereco.Tag)

                    End If

                    'Prepara Formulário para Inserção de um Novo Registro
                    Call NovoEndereco()

                    'Carrega Lista de Endereço
                    oClsCadVendedor.LoadGridEndereco(grdEndereco, _
                                                     btnSalvar.Tag)

                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboPaisEndereco_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPaisEndereco.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum Registro
            If cboPaisEndereco.SelectedIndex = -1 Then
                cboUFEndereco.DataSource = Nothing
                cboUFEndereco.Text = ""
                cboMunicipioEndereco.DataSource = Nothing
                cboMunicipioEndereco.Text = ""
            Else
                Call LoadCombo(cboUFEndereco, "sp_select_combo_static_estado_pais " & cboPaisEndereco.SelectedValue)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboUFEndereco_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUFEndereco.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum Registro
            If cboUFEndereco.SelectedIndex = -1 Then
                cboMunicipioEndereco.DataSource = Nothing
                cboMunicipioEndereco.Text = ""
            Else
                Call LoadCombo(cboMunicipioEndereco, "sp_select_combo_static_municipio '" & cboUFEndereco.SelectedValue & "'")
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdEndereco_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdEndereco.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdEndereco.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdEndereco.CurrentColumn.Key

                Case "editar" : Call EditarEndereco()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdEndereco_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdEndereco.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdEndereco, _
                                     Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdEndereco_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdEndereco.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdEndereco.Name, _
                                     Formulario.CadastroBasicoParceiroNegocio, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdEndereco_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdEndereco.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdEndereco.Name, _
                                          Formulario.CadastroBasicoParceiroNegocio, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: SUBORDINADO :::"

    Private Sub btnConfigurarGridSubordinado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridSubordinado.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdSubordinado
            oForm.NomeFormulario = Formulario.CadastroBasicoVendedor
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdSubordinado, Formulario.CadastroBasicoVendedor)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridSubordinado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridSubordinado.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdSubordinado)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirSubordinado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirSubordinado.Click

        Try

            'Deleta Registros
            Call DeleteSubordinado()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirSubordinado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirSubordinado.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Parceiro de Negócio
            If Validacao() = True Then

                'Salva Dados do Parceiro de Negócio
                Call Salvar()

                'Valida Dados do Formulário
                If ValidacaoSubordinado() = True Then

                    'Verifica o Tipo de Operação
                    If IsNumeric(btnInserirSubordinado.Tag) = False Then

                        'Insere Subordinado
                        Call oClsCadVendedor.InsertSubordinado(cboVendedor.SelectedValue)

                    Else

                        'Váriaveis Locais
                        Dim iCodigoSubordinadoAntigo As Integer = IIf(IsNumeric(btnInserirSubordinado.Tag), btnInserirSubordinado.Tag, 0)

                        'Atualiza Subordinado
                        Call oClsCadVendedor.UpdateSubordinado(cboVendedor.SelectedValue, iCodigoSubordinadoAntigo)

                    End If

                    'Carrega Grid
                    Call oClsCadVendedor.LoadGridSubordinado(grdSubordinado, btnSalvar.Tag)

                    'Prepara Formulário para Inserção de um Novo Registro
                    Call NovoSubordinado()

                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdSubordinado_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdSubordinado.RowDoubleClick

        Try

            'Verifiva se a Coluna é Válida
            If IsNothing(grdSubordinado.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdSubordinado.CurrentColumn.Key

                Case "editar" : Call EditarSubordinado()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdSubordinado_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdSubordinado.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdSubordinado, _
                                     Formulario.CadastroBasicoVendedor)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdSubordinado_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdSubordinado.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdSubordinado.Name, _
                                     Formulario.CadastroBasicoVendedor, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdSubordinado_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdSubordinado.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdSubordinado.Name, _
                                          Formulario.CadastroBasicoVendedor, _
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadVendedor_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.CadastroBasicoVendedor, gcDelete)
            btnNovo.Enabled = VerificaDireito(Formulario.CadastroBasicoVendedor, gcInsert)
            btnNovo1.Enabled = VerificaDireito(Formulario.CadastroBasicoVendedor, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.CadastroBasicoVendedor, gcPrint)
            btnSalvarEndereco.Enabled = VerificaDireito(Formulario.CadastroBasicoVendedor, gcInsert)
            btnExcluirEndereco.Enabled = VerificaDireito(Formulario.CadastroBasicoVendedor, gcDelete)
            btnExcelGridEndereco.Enabled = VerificaDireito(Formulario.CadastroBasicoVendedor, gcPrint)
            btnInserirSubordinado.Enabled = VerificaDireito(Formulario.CadastroBasicoVendedor, gcInsert)
            btnExcluirSubordinado.Enabled = VerificaDireito(Formulario.CadastroBasicoVendedor, gcDelete)
            btnExcelGridSubordinado.Enabled = VerificaDireito(Formulario.CadastroBasicoVendedor, gcPrint)

            'Carrega Combo
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboTipoVendedorFiltro : oComboBox(1) = cboTipoVendedor
            Call LoadCombo(oComboBox, "sp_select_combo_static_tipo_vendedor")
            oComboBox(0) = cboRegraComissaoFiltro : oComboBox(1) = cboRegraComissao
            Call LoadCombo(oComboBox, "sp_select_combo_venda_regra_comissao " & goUsuario.iEmpresa)
            Call LoadCombo(cboPais, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)
            Call LoadCombo(cboPaisEndereco, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)
            Call LoadCombo(cboTipoEndereco, "sp_select_combo_static_tipo_endereco")
            Call LoadCombo(cboVendedor, "sp_select_combo_cadastro_basico_vendedor " & goUsuario.iEmpresa & ", " & goUsuario.iUsuario)
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)
            If goUsuario.sEmpresa.Contains("LAVALPA") Then
                pagEndereco.TabVisible = False
            Else
                pagEndereco.TabVisible = True
            End If
            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoVendedor)
            Call ConfiguraGrid(grdEndereco, Formulario.CadastroBasicoVendedor)
            Call ConfiguraGrid(grdSubordinado, Formulario.CadastroBasicoVendedor)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)
            tabDados.TabPages.Remove(pagSubordinados)

            'Seta Focu
            cboTipoVendedorFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: VENDEDOR :::"

    Private Sub Delete()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCadVendedor.Delete()

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

    Private Sub EditarVendedor()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoVendedor, gcUpdate) = True Then

                'Limpa Controles
                Call Novo()

                'Carrega Controles
                oClsCadVendedor.LoadControles(grdListagem.CurrentRow.Cells.Item("codigo").Value, _
                                              cboTipoVendedor, _
                                              txtNome, _
                                              cboRegraComissao, _
                                              cboAtivo, _
                                              txtCEP, _
                                              cboPais, _
                                              cboUF, _
                                              cboMunicipio, _
                                              txtLogradouro, _
                                              txtNumero, _
                                              txtBairro, _
                                              txtComplemento, _
                                              txtTelefone1, _
                                              txtTelefone2, _
                                              txtTelefoneRecado, _
                                              txtNextel, _
                                              txtEmail, _
                                              txtObservacao)

                'Seta Código
                btnSalvar.Tag = grdListagem.CurrentRow.Cells.Item("codigo").Value

                'Carrega Grid de Endereço
                oClsCadVendedor.LoadGridEndereco(grdEndereco, _
                                                 grdListagem.CurrentRow.Cells.Item("codigo").Value)
                'Carrega Grid de Subordinado
                oClsCadVendedor.LoadGridSubordinado(grdSubordinado, _
                                                    grdListagem.CurrentRow.Cells.Item("codigo").Value)

                tabDados.SelectedTab = pagDadosGerais

                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                cboTipoVendedor.Focus()

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
            cboTipoVendedor.SelectedIndex = -1
            txtNome.Text = ""
            cboRegraComissao.SelectedIndex = -1
            btnSalvar.Tag = ""
            cboAtivo.SelectedValue = True
            txtCEP.Text = ""
            cboPais.SelectedIndex = -1
            cboUF.SelectedIndex = -1
            cboMunicipio.SelectedIndex = -1
            txtLogradouro.Text = ""
            txtNumero.Text = ""
            txtBairro.Text = ""
            txtComplemento.Text = ""
            txtTelefone1.Text = ""
            txtTelefone2.Text = ""
            txtTelefoneRecado.Text = ""
            txtNextel.Text = ""
            txtEmail.Text = ""
            txtObservacao.Text = ""
            'Limpa Controles - Endereço
            cboTipoEndereco.SelectedIndex = -1
            txtCepEndereco.Text = ""
            cboPaisEndereco.SelectedIndex = -1
            cboUFEndereco.SelectedIndex = -1
            cboMunicipioEndereco.SelectedIndex = -1
            txtLogradouroEndereco.Text = ""
            txtNumeroEndereco.Text = ""
            txtBairroEndereco.Text = ""
            txtComplementoEndereco.Text = ""
            btnSalvarEndereco.Tag = ""
            grdEndereco.DataSource = Nothing
            'Limpa Controles - Vendedor
            cboVendedor.SelectedIndex = -1
            btnInserirSubordinado.Tag = ""
            grdSubordinado.DataSource = Nothing

            'Seta Aba
            tabDados.SelectedTab = pagDadosGerais

            'Seta Focu
            cboTipoVendedor.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCadVendedor.CodigoVendedor = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1)
            oClsCadVendedor.CodigoTipoVendedor = cboTipoVendedor.SelectedValue
            oClsCadVendedor.Nome = txtNome.Text.Trim
            oClsCadVendedor.CodigoVendaRegraComissao = cboRegraComissao.SelectedValue
            oClsCadVendedor.Ativo = cboAtivo.SelectedValue
            oClsCadVendedor.Cep = txtCEP.Text.Trim
            oClsCadVendedor.Pais = cboPais.SelectedValue
            oClsCadVendedor.UF = cboUF.SelectedValue
            oClsCadVendedor.Municipio = cboMunicipio.SelectedValue
            oClsCadVendedor.Logradouro = txtLogradouro.Text.Trim
            oClsCadVendedor.Numero = txtNumero.Text.Trim
            oClsCadVendedor.Bairro = txtBairro.Text.Trim
            oClsCadVendedor.Complemento = txtComplemento.Text.Trim
            oClsCadVendedor.Telefone1 = txtTelefone1.Text
            oClsCadVendedor.Telefone2 = txtTelefone2.Text
            oClsCadVendedor.TelefoneRecado = txtTelefoneRecado.Text
            oClsCadVendedor.Nextel = txtNextel.Text
            oClsCadVendedor.Email = txtEmail.Text
            oClsCadVendedor.Observacao = txtObservacao.Text.Trim

            'Verifica o Tipo de Operação
            If IsNumeric(btnSalvar.Tag) Then
                oClsCadVendedor.Update()
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                oClsCadVendedor.Insert()
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
            oClsCadVendedor.LoadGrid(grdListagem, _
                                     IIf(cboTipoVendedorFiltro.SelectedIndex = -1, -1, cboTipoVendedorFiltro.SelectedValue), _
                                     txtNomeFiltro.Text.Trim, _
                                     IIf(cboRegraComissaoFiltro.SelectedIndex = -1, -1, cboRegraComissaoFiltro.SelectedValue))

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

            'Verifica se foi Selecionado o Campo - Tipo de Vendedor
            If ValidaCampo(cboTipoVendedor, lblTipoVendedor) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Nome
            If ValidaCampo(txtNome, lblNome, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Venda Regra de Comissão
            If ValidaCampo(cboRegraComissao, lblRegraComissao) = False Then
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

            'Verifica se foi Selecionado o Campo - País
            If ValidaCampo(cboPais, lblPais) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - UF
            If ValidaCampo(cboUF, lblUF) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Município
            If cboUF.SelectedValue <> gcUFExterior Then
                If ValidaCampo(cboMunicipio, lblMunicipio) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Logradouro
            If ValidaCampo(txtLogradouro, lblLogradouro, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Número
            If ValidaCampo(txtNumero, lblNumero, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Telefone Principal
            If ValidaCampo(txtTelefone1, lblTelefone1, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region
    
#Region "::: ENDEREÇO :::"

    Private Sub NovoEndereco()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            cboTipoEndereco.SelectedIndex = -1
            txtCepEndereco.Text = ""
            cboPaisEndereco.SelectedIndex = -1
            cboUFEndereco.SelectedIndex = -1
            cboMunicipioEndereco.SelectedIndex = -1
            txtLogradouroEndereco.Text = ""
            txtNumeroEndereco.Text = ""
            txtBairroEndereco.Text = ""
            txtComplementoEndereco.Text = ""
            btnSalvarEndereco.Tag = ""

            'Seta Focu
            cboTipoEndereco.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarEndereco()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcUpdate) = True Then

                With grdEndereco.CurrentRow.Cells

                    'Limpa Controles
                    Call NovoEndereco()

                    'Carrega Controles
                    cboTipoEndereco.SelectedValue = .Item("codigo_tipo_endereco").Value
                    txtCepEndereco.Text = .Item("cep").Value
                    cboPaisEndereco.SelectedValue = .Item("codigo_pais").Value
                    cboUFEndereco.SelectedValue = .Item("uf").Value
                    cboMunicipioEndereco.SelectedValue = .Item("codigo_municipio").Value
                    txtLogradouroEndereco.Text = .Item("logradouro").Value
                    txtNumeroEndereco.Text = .Item("numero").Value
                    txtBairroEndereco.Text = .Item("bairro").Value
                    txtComplementoEndereco.Text = .Item("complemento").Value
                    btnSalvarEndereco.Tag = .Item("codigo").Value

                    'Seta Focu
                    cboTipoEndereco.Focus()

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

    Private Function ValidacaoEndereco() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoEndereco = False

            'Verifica se foi Selecionado o Campo - Tipo de Endereco
            If ValidaCampo(cboTipoEndereco, lblTipoEndereco) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - CEP
            If ValidaCampo(txtCepEndereco, lblCepEndereco, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - País
            If ValidaCampo(cboPaisEndereco, lblPaisEndereco) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - UF
            If ValidaCampo(cboUFEndereco, lblUFEndereco) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Município
            If cboUFEndereco.SelectedValue <> gcUFExterior Then
                If ValidaCampo(cboMunicipioEndereco, lblMunicipioEndereco) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Logradouro
            If ValidaCampo(txtLogradouroEndereco, lblLogradouroEndereco, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Número
            If ValidaCampo(txtNumeroEndereco, lblNumeroEndereco, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoEndereco = True

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Function

    Private Sub DeleteEndereco()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdEndereco) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Deleta Endereço
                    oClsCadVendedor.CodigoVendedor = btnSalvar.Tag
                    oClsCadVendedor.DeleteEndereco()

                    'Limpa Formulário
                    Call NovoEndereco()

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

#Region "::: SUBORDINADO::"

    Private Sub NovoSubordinado()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            cboVendedor.SelectedIndex = -1
            btnInserirSubordinado.Tag = ""

            'Seta Focu
            cboVendedor.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarSubordinado()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoVendedor, gcUpdate) = True Then

                With grdSubordinado.CurrentRow.Cells

                    'Limpa Controles
                    Call NovoSubordinado()

                    'Carrega Controles
                    cboVendedor.SelectedValue = .Item("codigo").Value
                    btnInserirSubordinado.Tag = .Item("codigo").Value

                    'Seta Focu
                    cboVendedor.Focus()

                End With

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoSubordinado() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoSubordinado = False

            'Verifica se foi Selecionado o Campo - Vendedor
            If ValidaCampo(cboVendedor, lblVendedor) = False Then
                Exit Function
            End If

            'Verifica se o Vendedor já foi Inserido
            If grdSubordinado.GetDataRows.Count > 0 Then
                If IsNumeric(btnInserirSubordinado.Tag) Then
                    If VerificaExisteValorGrid(grdSubordinado, "codigo", cboVendedor.SelectedValue, grdSubordinado.CurrentRow.RowIndex) = True Then
                        frmMain.errInfo.SetError(lblVendedor, "Este Vendedor: " & cboVendedor.Text & " já se encontra cadastrado.")
                        cboVendedor.Focus()
                        Exit Function
                    End If
                Else
                    If VerificaExisteValorGrid(grdSubordinado, "codigo", cboVendedor.SelectedValue, -1) = True Then
                        frmMain.errInfo.SetError(lblVendedor, "Este Vendedor: " & cboVendedor.Text & " já se encontra cadastrado.")
                        cboVendedor.Focus()
                        Exit Function
                    End If
                End If

            End If

            'Seta Retorno da Função
            ValidacaoSubordinado = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub DeleteSubordinado()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdSubordinado) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    For Each oRow In gSelecaoRow
                        oRow.Delete()
                    Next

                    'Limpa Formulário
                    Call NovoSubordinado()

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

