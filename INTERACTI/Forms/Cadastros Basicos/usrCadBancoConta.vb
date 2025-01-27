Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls

Public Class usrCadBancoConta

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadBancoConta As New clsUsrCadBancoConta
    Private sCodigoBanco As Integer

#End Region

#Region "::: CONTROLES :::"

#Region "::: GERAL :::"

    Private Sub usrCadBancoConta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                    
                Case Keys.F3

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "txtCEP" : Call btnProcurarCEP_Click(btnProcurarCEP, System.EventArgs.Empty)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name

                        Case "cboBancoFiltro", "cboBanco"
                            Dim oComboBox(1) As UIComboBox
                            oComboBox(0) = cboBancoFiltro : oComboBox(1) = cboBanco
                            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_banco " & goUsuario.iEmpresa)
                        Case "cboPais" : Call LoadCombo(cboPais, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)
                        Case "cboTipoContato" : Call LoadCombo(cboTipoContato, "sp_select_combo_cadastro_basico_tipo_contato " & goUsuario.iEmpresa)

                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboBanco" : Call btnCadastrarBanco_Click(btnCadastrarBanco, System.EventArgs.Empty)
                        Case "cboPais" : Call btnCadastrarPais_Click(btnCadastrarPais, System.EventArgs.Empty)
                        Case "cboTipoContato" : Call btnCadastrarTipoContato_Click(btnCadastrarTipoContato, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrCadBancoConta_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: BANCO :::"

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
            oForm.NomeFormulario = Formulario.CadastroBasicoBancoConta
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoBancoConta)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid - Excel
            Call ExportExcel(grdListagem)

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

            'Prepara o Formulário para Inserção de um Novo Registro
            Call Novo()

            'Alterna Aba
            tabMain.TabPages.Remove(pagLista)
            tabMain.TabPages.Add(pagDados)

            'Seta Focu
            cboBanco.Focus()

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
            cboBancoFiltro.Focus()

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
                                     Formulario.CadastroBasicoBancoConta)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.CadastroBasicoBancoConta, _
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
            oForm.NomeFormulario = Formulario.CadastroBasicoParceiroNegocio
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdContato, Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridContato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridContato.Click

        Try

            'Exporta Grid - Excel
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

            'Valida Dados do Parceiro de Negócio
            If Validacao() = True Then

                'Salva Dados do Parceiro de Negócio
                Call Salvar()

                'Valida Dados do Contato
                If ValidacaoContato() = True Then

                    'Verifica o Tipo de Operação
                    If IsNumeric(btnSalvarContato.Tag) = False Then

                        'Insere Contato
                        Call oClsCadBancoConta.InsertContato(txtNomeContato.Text.Trim, _
                                                             txtTelefoneContato.Text.Trim, _
                                                             txtCelularContato.Text.Trim, _
                                                             IIf(dtpDataAniversario.Checked = True, dtpDataAniversario.Value, ""), _
                                                             txtEmailContato.Text.Trim, _
                                                             txtComplementoContato.Text.Trim, _
                                                             cboTipoContato.SelectedValue)

                    Else

                        'Atualiza Dados do Contato
                        Call oClsCadBancoConta.UpdateContato(txtNomeContato.Text.Trim, _
                                                             txtTelefoneContato.Text.Trim, _
                                                             txtCelularContato.Text.Trim, _
                                                             IIf(dtpDataAniversario.Checked = True, dtpDataAniversario.Value, ""), _
                                                             txtEmailContato.Text.Trim, _
                                                             txtComplementoContato.Text.Trim, _
                                                             cboTipoContato.SelectedValue, _
                                                             btnSalvarContato.Tag)

                    End If

                    'Carrega Lista de Contato
                    Call oClsCadBancoConta.LoadGridContato(grdContato, btnSalvar.Tag)

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

            'Limpa Formulário
            Call NovoContato()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdContato_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdContato.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
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
                                     Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdContato_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdContato.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdContato.Name, _
                                     Formulario.CadastroBasicoParceiroNegocio, _
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

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: BANCO :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadBancoConta_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.CadastroBasicoBancoConta, gcDelete)
            btnNovo1.Enabled = VerificaDireito(Formulario.CadastroBasicoBancoConta, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.CadastroBasicoBancoConta, gcPrint)
            btnSalvarContato.Enabled = VerificaDireito(Formulario.CadastroBasicoBancoConta, gcInsert)
            btnExcluirContato.Enabled = VerificaDireito(Formulario.CadastroBasicoBancoConta, gcDelete)
            btnExcelGridContato.Enabled = VerificaDireito(Formulario.CadastroBasicoBancoConta, gcPrint)

            'Verifica Direito - Cadastrar
            btnCadastrarBanco.Enabled = VerificaDireito(Formulario.CadastroBasicoBanco, gcInsert)
            btnCadastrarPais.Enabled = VerificaDireito(Formulario.CadastroBasicoPais, gcInsert)
            btnCadastrarTipoContato.Enabled = VerificaDireito(Formulario.CadastroBasicoTipoContato, gcInsert)

            'Carrega Combo
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboBancoFiltro : oComboBox(1) = cboBanco
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_banco " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboPais, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboTipoContato, "sp_select_combo_cadastro_basico_tipo_contato " & goUsuario.iEmpresa, False)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoBancoConta)
            Call ConfiguraGrid(grdContato, Formulario.CadastroBasicoBancoConta)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            cboBancoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
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
                    oClsCadBancoConta.Delete()

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

            'Limpa Controles - Dados Gerais
            cboBanco.SelectedIndex = -1
            btnSalvar.Tag = ""
            txtAgencia.Text = ""
            txtConta.Text = ""
            txtDigitoConta.Text = ""
            cboAtivo.SelectedValue = True
            cboAplicacao.SelectedValue = True
            txtLogradouro.Text = ""
            txtNumero.Text = ""
            txtBairro.Text = ""
            cboMunicipio.SelectedIndex = -1
            cboPais.SelectedIndex = -1
            cboUF.SelectedIndex = -1
            txtComplemento.Text = ""
            txtCEP.Text = ""
            txtObservacao.Text = ""
            'Limpa Controles - Contato
            cboTipoContato.SelectedIndex = -1
            txtNomeContato.Text = ""
            txtTelefoneContato.Text = ""
            txtCelularContato.Text = ""
            txtComplementoContato.Text = ""
            txtEmailContato.Text = ""
            dtpDataAniversario.Value = Now.Date : dtpDataAniversario.Checked = False
            btnSalvarContato.Tag = ""
            grdContato.DataSource = Nothing

            tabDados.SelectedIndex = 0

            'Seta Focu
            cboBanco.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoBancoConta, gcUpdate) = True Then

                'Limpa Formulário
                Call Novo()

                'Carrega Controles
                oClsCadBancoConta.LoadControles(grdListagem.CurrentRow.Cells.Item("codigo").Value, _
                                                cboBanco, _
                                                txtAgencia, _
                                                txtConta, _
                                                txtDigitoConta, _
                                                cboAtivo, _
                                                cboAplicacao, _
                                                txtLogradouro, _
                                                txtNumero, _
                                                txtBairro, _
                                                cboMunicipio, _
                                                cboPais, _
                                                cboUF, _
                                                txtComplemento, _
                                                txtCEP, _
                                                txtObservacao)

                'Seta Controle
                btnSalvar.Tag = grdListagem.CurrentRow.Cells.Item("codigo").Value

                'Carrega Grid de Contato
                oClsCadBancoConta.LoadGridContato(grdContato, _
                                                  grdListagem.CurrentRow.Cells.Item("codigo").Value)

                'Alterna Aba
                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

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

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCadBancoConta.Codigo = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0)
            oClsCadBancoConta.Banco = cboBanco.SelectedValue
            oClsCadBancoConta.Agencia = txtAgencia.Text.Trim
            oClsCadBancoConta.Conta = txtConta.Text.Trim
            oClsCadBancoConta.DigitoConta = txtDigitoConta.Text.Trim
            oClsCadBancoConta.Logradouro = txtLogradouro.Text.Trim
            oClsCadBancoConta.Numero = txtNumero.Text.Trim
            oClsCadBancoConta.Bairro = txtBairro.Text.Trim
            oClsCadBancoConta.CodigoMunicipio = IIf(cboMunicipio.SelectedIndex = -1, -1, cboMunicipio.SelectedValue)
            oClsCadBancoConta.Pais = IIf(cboPais.SelectedIndex = -1, -1, cboPais.SelectedValue)
            oClsCadBancoConta.UF = IIf(cboUF.SelectedIndex = -1, "", cboUF.SelectedValue)
            oClsCadBancoConta.Complemento = txtComplemento.Text.Trim
            oClsCadBancoConta.Cep = txtCEP.Text.Trim
            oClsCadBancoConta.Observacao = txtObservacao.Text.Trim
            oClsCadBancoConta.Ativo = cboAtivo.SelectedValue
            oClsCadBancoConta.Aplicacao = cboAplicacao.SelectedValue

            'Verifica o Tipo de Operação
            If Len(btnSalvar.Tag) > 0 Then
                oClsCadBancoConta.Update()
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                oClsCadBancoConta.Insert()
                frmMain.Informacao(Mensagem.RegistroInserido)
                btnSalvar.Tag = oClsCadBancoConta.Codigo
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
            oClsCadBancoConta.LoadGrid(grdListagem, _
                                       IIf(cboBancoFiltro.SelectedIndex = -1, -1, cboBancoFiltro.SelectedValue), _
                                       txtAgenciaFiltro.Text.Trim, _
                                       txtContaFilltro.Text.Trim, _
                                       txtDigitoContaFiltro.Text.Trim)

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

            'Verifica se foi Selecionado o Campo - Banco
            If ValidaCampo(cboBanco, lblBanco) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Agência
            If ValidaCampo(txtAgencia, lblAgencia, TipoCampo.numero) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Conta
            If ValidaCampo(txtConta, lblConta, TipoCampo.numero) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Ativo
            If ValidaCampo(cboAtivo, lblAtivo) = False Then
                Exit Function
            End If

            If ValidaCampo(cboAplicacao, lblAplicacao) = False Then
                Exit Function
            End If

            'Passa Parametros
            oClsCadBancoConta.Codigo = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0)
            oClsCadBancoConta.Agencia = txtAgencia.Text.Trim
            oClsCadBancoConta.Conta = txtConta.Text.Trim
            oClsCadBancoConta.DigitoConta = txtDigitoConta.Text.Trim
            If oClsCadBancoConta.ValidaAgenciaConta() = False Then
                frmMain.errInfo.SetError(lblAgencia, "Esta Conta: " & txtAgencia.Text & " / " & txtConta.Text & "-" & txtDigitoConta.Text & " já está associado a outro Registro.")
                txtAgencia.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

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
                                 grdContato.CurrentRow.Cells("email").Value, _
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
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub EditarContato()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcUpdate) = True Then

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
                    oClsCadBancoConta.Codigo = btnSalvar.Tag
                    oClsCadBancoConta.DeleteContato()

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

#End Region

End Class

