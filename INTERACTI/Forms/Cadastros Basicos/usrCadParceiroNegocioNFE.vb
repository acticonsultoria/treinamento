Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls
Imports Janus.Windows.Common

Public Class usrCadParceiroNegocioNFE

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadParceiroNegocio As New clsUsrCadParceiroNegocio

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"


    Private Sub usrCadParceiroNegocioTrakmaq_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

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

                        Case "cboPais"
                            Dim oComboBox(1) As UIComboBox
                            oComboBox(0) = cboPais
                            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)
                        Case "cboSegmento", "cboSegmentoFiltro"
                            Dim oComboBox(1) As UIComboBox
                            oComboBox(0) = cboSegmentoFiltro : oComboBox(1) = cboSegmento
                            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_parceiro_negocio_segmento " & goUsuario.iEmpresa)

                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name

                        Case "cboSegmento" : Call btnCadastrarSegmento_Click(btnCadastrarSegmento, System.EventArgs.Empty)
                        Case "cboPais" : Call btnCadastrarPais_Click(btnCadastrarPais, System.EventArgs.Empty)

                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadParceiroNegocioTrakmaq_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: PARCEIRO DE NEGÓCIO :::"

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

    Private Sub grdListagem_CellUpdated(ByVal sender As Object, ByVal e As ColumnActionEventArgs) Handles grdListagem.CellUpdated

        Try

            If grdListagem.CurrentRow.RowType = RowType.Record Then
                Dim sValor As String = grdListagem.GetValue(grdListagem.CurrentColumn.Key)
                If sValor.ToUpper = "TRUE" Then
                    sValor = "1"
                ElseIf sValor.ToUpper = "FALSE" Then
                    sValor = "0"
                End If
                UpdateGridFieldCadastroBasico("tb_cad_parceiro_negocio", grdListagem.CurrentColumn.Key, sValor, grdListagem.CurrentRow.Cells.Item("codigo").Value)

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
            oForm.NomeFormulario = Formulario.CadastroBasicoParceiroNegocio
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoParceiroNegocio)

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

    Private Sub btnCadastrarSegmento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarSegmento.Click

        Try
            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadParceiroNegocioTrakmaqSegmento")


            'Carrega Combo
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboSegmentoFiltro : oComboBox(1) = cboSegmento
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_parceiro_negocio_segmento " & goUsuario.iEmpresa)

            'Seta Focu
            cboSegmento.Focus()

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

    Private Sub btnCadastrarPaisEndereco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadPais")

            'Carrega Combo
            Call LoadCombo(cboPais, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)

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

    Private Sub btnMalaDireta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMalaDireta.Click

        Try

            'Enviar Mala Direta
            Call EnviarMalaDireta()

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
            cboTipoParceiroNegocioFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCongelarColuna_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboCongelarColuna.SelectedIndexChanged

        Try

            If cboCongelarColuna.SelectedIndex = -1 Then
                grdListagem.FrozenColumns = 5
            Else
                grdListagem.FrozenColumns = cboCongelarColuna.SelectedValue
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub
    

    Private Sub cboPersonalidade_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPersonalidade.SelectedIndexChanged

        Try

            'Variaveis Locais
            Dim oSuperTipSettings As New SuperTipSettings

            If cboPersonalidade.SelectedIndex = -1 Then

                Exit Sub

            ElseIf cboPersonalidade.SelectedValue = Personalidade.Fisica Then

                oSuperTipSettings.HeaderText = "RG"
                oSuperTipSettings.Text = "Preencher RG (somente  números)."

                lblCnpjCpf.Text = "CPF:"
                txtCnpjCpf.Mask = "000,000,000-00"
                txtInscricaoEstadual.Enabled = True
                lblInscricaoEstadual.Text = "RG:"
                txtCNAE.Text = "" : txtCNAE.Enabled = False
                cboRegimeTributario.SelectedIndex = -1 : cboRegimeTributario.Enabled = False
                txtInscricaoEstadualSubstitutoTriburario.Text = "" : txtInscricaoEstadualSubstitutoTriburario.Enabled = False
                txtInscricaoMunicipal.Text = "" : txtInscricaoMunicipal.Enabled = False
                txtInscricaoSuframa.Text = "" : txtInscricaoSuframa.Enabled = False
                jstTip.SetSuperTip(txtInscricaoEstadual, oSuperTipSettings)

            ElseIf cboPersonalidade.SelectedValue = Personalidade.Juridica Then

                oSuperTipSettings.HeaderText = "Inscrição Estadual"
                oSuperTipSettings.Text = "Preencher Inscrição Estadual (somente  números) caso contribuinte do ICMS." & vbCrLf & _
                                         "Preencher com ISENTO caso contribuinte do ICMS, mas não estiver obrigado a inscrição no cadastro de contribuintes." & vbCrLf & _
                                         "Não preencher caso não for contribuinte do ICMS."

                lblCnpjCpf.Text = "CNPJ:"
                txtCnpjCpf.Mask = "00,000,000/0000-00"
                txtCNAE.Enabled = True
                cboRegimeTributario.Enabled = True
                txtInscricaoEstadualSubstitutoTriburario.Enabled = True
                lblInscricaoEstadual.Text = "Inscrição Estadual:"
                txtInscricaoMunicipal.Enabled = True
                txtInscricaoSuframa.Enabled = True
                jstTip.SetSuperTip(txtInscricaoEstadual, oSuperTipSettings)

            Else

                oSuperTipSettings.HeaderText = "Inscrição Estadual"
                oSuperTipSettings.Text = "Preencher Inscrição Estadual (somente  números) caso contribuinte do ICMS." & vbCrLf & _
                                         "Preencher com ISENTO caso contribuinte do ICMS, mas não estiver obrigado a inscrição no cadastro de contribuintes." & vbCrLf & _
                                         "Não preencher caso não for contribuinte do ICMS."

                lblCnpjCpf.Text = "CNPJ / CPF:"
                lblInscricaoEstadual.Text = "Inscrição Estadual:"
                txtCNAE.Text = "" : txtCNAE.Enabled = False
                cboRegimeTributario.SelectedIndex = -1 : cboRegimeTributario.Enabled = False
                txtInscricaoEstadualSubstitutoTriburario.Text = "" : txtInscricaoEstadualSubstitutoTriburario.Enabled = False
                txtInscricaoMunicipal.Text = "" : txtInscricaoMunicipal.Enabled = False
                txtInscricaoSuframa.Text = "" : txtInscricaoSuframa.Enabled = False
                jstTip.SetSuperTip(txtInscricaoEstadual, oSuperTipSettings)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboPersonalidadeFiltro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPersonalidadeFiltro.SelectedIndexChanged

        Try

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

  
    Private Sub cboTipoInscricaoEstadual_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboTipoInscricaoEstadual.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum Registro
            If cboTipoInscricaoEstadual.SelectedIndex = -1 Then
                txtInscricaoEstadual.Enabled = True
            ElseIf cboTipoInscricaoEstadual.SelectedValue = 1 Or cboTipoInscricaoEstadual.SelectedValue = 9 Then
                txtInscricaoEstadual.Enabled = True
            ElseIf cboTipoInscricaoEstadual.SelectedValue = 2 Then
                txtInscricaoEstadual.Text = "ISENTO" : txtInscricaoEstadual.Enabled = False
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call Editar(grdListagem.CurrentRow.Cells("codigo").Value)
                Case "email" : Call EmailParceiroNegocio()
                Case "contato" : Call ContatoParceiroNegocio(grdListagem.CurrentRow.Cells("codigo").Value)
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
                                     Formulario.CadastroBasicoParceiroNegocio)

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
                                     Formulario.CadastroBasicoParceiroNegocio, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

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



#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: DADOS GERAIS :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadParceiroNegocioTrakmaq_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcDelete)
            btnNovo1.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcInsert)
            btnNovo.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcPrint)

            'Verifica Direito - Botão de Cadastrar
            btnCadastrarSegmento.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioSegmento, gcInsert)
            btnCadastrarPais.Enabled = VerificaDireito(Formulario.CadastroBasicoPais, gcInsert)

            'Carrega Combo
            Dim oComboBox(1) As UIComboBox
            Call LoadCombo(cboTipoParceiroNegocioFiltro, "sp_select_combo_static_tipo_parceiro_negocio")
            oComboBox(0) = cboPersonalidadeFiltro : oComboBox(1) = cboPersonalidade
            Call LoadCombo(oComboBox, "sp_select_combo_static_personalidade")
            Call LoadCombo(cboSegmento, "sp_select_combo_cadastro_basico_parceiro_negocio_segmento " & goUsuario.iEmpresa)
            Call LoadCombo(cboSegmentoFiltro, "sp_select_combo_cadastro_basico_parceiro_negocio_segmento " & goUsuario.iEmpresa)
            Call LoadCombo(cboVendedorFiltro, "sp_select_combo_cadastro_basico_vendedor " & goUsuario.iEmpresa & ", " & goUsuario.iUsuario)
            Call LoadCombo(cboPais, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)
            Call LoadCombo(cboTipoInscricaoEstadual, "sp_select_combo_static_tipo_inscricao_estadual")
            Call LoadCombo(cboRegimeTributario, "sp_select_combo_static_regime_tributario")
            Call LoadCombo(cboCentroGasto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa, False)
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)
            Call LoadComboSimNao(cboImportado)


            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoParceiroNegocio)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            cboTipoParceiroNegocioFiltro.Focus()

            'Verifica a Tag            
            If Me.Tag.ToString.Contains("CODIGO:") Then
                Call Editar(Me.Tag.ToString.Replace("CODIGO:", ""))
            ElseIf Me.Tag = "NOVO" Then
                Call btnNovo1_Click(btnNovo1, System.EventArgs.Empty)
            End If


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: PARCEIRO DE NEGÓCIO :::"

    Private Sub Delete()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCadParceiroNegocio.Delete()

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
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub ContatoParceiroNegocio(ByVal iCodigo As Integer)

        Try

            'Abre Formulário
            Dim oForm As New frmViewParceiroNegocioContato
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location
            oForm.CodigoParceiroNegocio = iCodigo

            'Seta Tamanho / Posição do Formulário
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location

            'Abre Formulário
            oForm.ShowDialog(Me)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Editar(ByVal iCodigo As Integer)

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcUpdate) = True Then

                'Limpa Formulário
                Call Novo()

                'Carrega Controles


                'Seta Código
                btnSalvar.Tag = iCodigo

                'Carrega Grid de Contato
                oClsCadParceiroNegocio.LoadControlesNFE(iCodigo, _
                                                     chkAgenteLogistico, _
                                                     chkCliente, _
                                                     chkFornecedor, _
                                                     chkDespachante, _
                                                     cboPersonalidade, _
                                                     txtRazaoSocial, _
                                                     txtNomeFantasia, _
                                                     cboSegmento, _
                                                     cboAtivo, _
                                                     txtCnpjCpf, _
                                                     cboRegimeTributario, _
                                                     txtCNAE, _
                                                     cboTipoInscricaoEstadual, _
                                                     txtInscricaoEstadual, _
                                                     txtInscricaoEstadualSubstitutoTriburario, _
                                                     txtInscricaoMunicipal, _
                                                     txtInscricaoSuframa, _
                                                     txtLogradouro, _
                                                     txtNumero, _
                                                     txtBairro, _
                                                     cboMunicipio, _
                                                     cboPais, _
                                                     cboUF, _
                                                     txtComplemento, _
                                                     txtCEP, _
                                                     txtObservacao, _
                                                     txtTelefone1, _
                                                     txtTelefone2, _
                                                     txtEmail, _
                                                     txtLimiteCredito, _
                                                     txtAvisoTempoCompra, _
                                                     cboCentroGasto)



                'Alternar Aba
                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                cboPersonalidade.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub EmailParceiroNegocio()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Enviar E-mail
            Call EnviarEmail("DADOS DO PARCEIRO DE NEGÓCIO " & grdListagem.CurrentRow.Cells("razao_social").Value, _
                             "", _
                             "", _
                             "", _
                             oClsCadParceiroNegocio.EmailParceiroNegocio(grdListagem.CurrentRow.Cells("codigo").Value), _
                             -1)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Dados Gerais
            chkAgenteLogistico.Checked = False
            chkCliente.Checked = False
            chkDespachante.Checked = False
            chkFornecedor.Checked = False
            cboPersonalidade.SelectedIndex = -1 : cboPersonalidade.Text = ""
            btnSalvar.Tag = ""
            txtRazaoSocial.Text = ""
            txtNomeFantasia.Text = ""
            cboSegmento.SelectedIndex = -1 : cboSegmento.Text = ""
            txtCNAE.Text = ""
            cboRegimeTributario.SelectedIndex = -1 : cboRegimeTributario.Text = ""
            cboAtivo.SelectedValue = True
            txtCnpjCpf.Text = ""
            cboTipoInscricaoEstadual.Text = ""
            txtInscricaoEstadual.Text = ""
            txtInscricaoMunicipal.Text = ""
            txtInscricaoSuframa.Text = ""
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
            txtEmail.Text = ""
            txtObservacao.Text = ""
            txtLimiteCredito.Value = 0
            txtAvisoTempoCompra.Value = 0
            cboCentroGasto.SelectedIndex = -1


            'Desabilita Controles
            chkAgenteLogistico.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioAgenteLogistico, gcInsert)
            chkDespachante.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioDespachante, gcInsert)
            chkCliente.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioCliente, gcInsert)
            chkFornecedor.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioFornecedor, gcInsert)

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
            oClsCadParceiroNegocio.Codigo = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1)
            oClsCadParceiroNegocio.AgenteLogistico = chkAgenteLogistico.Checked
            oClsCadParceiroNegocio.Cliente = chkCliente.Checked
            oClsCadParceiroNegocio.Fornecedor = chkFornecedor.Checked
            oClsCadParceiroNegocio.Despachante = chkDespachante.Checked
            oClsCadParceiroNegocio.Personalidade = cboPersonalidade.SelectedValue
            oClsCadParceiroNegocio.RazaoSocial = txtRazaoSocial.Text.Trim
            oClsCadParceiroNegocio.NomeFantasia = txtNomeFantasia.Text.Trim
            oClsCadParceiroNegocio.CodigoParceiroNegocioSegmento = IIf(cboSegmento.SelectedIndex = -1, -1, cboSegmento.SelectedValue)
            oClsCadParceiroNegocio.RegimeTributario = IIf(cboRegimeTributario.SelectedIndex = -1, -1, cboRegimeTributario.SelectedValue)
            oClsCadParceiroNegocio.CNAE = txtCNAE.Text.Trim
            oClsCadParceiroNegocio.CNPJCPF = txtCnpjCpf.Text.Trim
            oClsCadParceiroNegocio.CodigoTipoInscricaoEstadual = IIf(cboTipoInscricaoEstadual.SelectedIndex = -1, -1, cboTipoInscricaoEstadual.SelectedValue)
            oClsCadParceiroNegocio.InscricaoEstadual = txtInscricaoEstadual.Text.Trim
            oClsCadParceiroNegocio.InscricaoEstadualSubstitutoTributario = txtInscricaoEstadualSubstitutoTriburario.Text.Trim
            oClsCadParceiroNegocio.InscricaoMunicipal = txtInscricaoMunicipal.Text.Trim
            oClsCadParceiroNegocio.Cep = txtCEP.Text.Trim
            oClsCadParceiroNegocio.Pais = cboPais.SelectedValue
            oClsCadParceiroNegocio.UF = cboUF.SelectedValue
            oClsCadParceiroNegocio.Municipio = IIf(cboMunicipio.SelectedIndex = -1, -1, cboMunicipio.SelectedValue)
            oClsCadParceiroNegocio.Logradouro = txtLogradouro.Text.Trim
            oClsCadParceiroNegocio.Numero = txtNumero.Text.Trim
            oClsCadParceiroNegocio.Bairro = txtBairro.Text.Trim
            oClsCadParceiroNegocio.Complemento = txtComplemento.Text.Trim
            oClsCadParceiroNegocio.Telefone1 = txtTelefone1.Text
            oClsCadParceiroNegocio.Email = txtEmail.Text
            oClsCadParceiroNegocio.Telefone2 = txtTelefone2.Text
            oClsCadParceiroNegocio.Fax = ""
            oClsCadParceiroNegocio.TelefoneRecado = ""
            oClsCadParceiroNegocio.CodigoVendedor = -1
            oClsCadParceiroNegocio.CodigoVendedorInterno = -1
            oClsCadParceiroNegocio.Observacao = txtObservacao.Text.Trim
            oClsCadParceiroNegocio.DataFundacao = ""
            oClsCadParceiroNegocio.DataCadastro = ""
            oClsCadParceiroNegocio.Ativo = cboAtivo.SelectedValue
            oClsCadParceiroNegocio.CodigoCondicaoPagamento = -1
            oClsCadParceiroNegocio.CodigoFormaPagamento = -1
            oClsCadParceiroNegocio.CodigoMoeda = -1
            oClsCadParceiroNegocio.CodigoModalidadeFrete = -1
            oClsCadParceiroNegocio.CodigoIntegracao = ""
            oClsCadParceiroNegocio.EnviarAR = -1
            oClsCadParceiroNegocio.CodigoDestinacao = -1
            oClsCadParceiroNegocio.LimiteCredito = txtLimiteCredito.Value
            oClsCadParceiroNegocio.AvisoTempoCompra = txtAvisoTempoCompra.Value
            oClsCadParceiroNegocio.CodigoInstrucaoCobranca1 = -1
            oClsCadParceiroNegocio.CodigoInstrucaoCobranca2 = -1
            oClsCadParceiroNegocio.NumeroDias1 = -1
            oClsCadParceiroNegocio.NumeroDias2 = -1
            oClsCadParceiroNegocio.CodigoCondicaoPagamentoFornecedor = -1
            oClsCadParceiroNegocio.CodigoFormaPagamentoFornecedor = -1
            oClsCadParceiroNegocio.CodigoMoedaFornecedor = -1
            oClsCadParceiroNegocio.CodigoModalidadeFreteFornecedor = -1
            oClsCadParceiroNegocio.ClassificacaoFornecedor = ""
            oClsCadParceiroNegocio.CodigoTipoNegativacao = -1
            oClsCadParceiroNegocio.DataNegativacao = -1
            oClsCadParceiroNegocio.TextoNegativacao = ""
            oClsCadParceiroNegocio.Cronograma = False
            oClsCadParceiroNegocio.EntregaFisica = False
            oClsCadParceiroNegocio.EntregaEmail = False
            oClsCadParceiroNegocio.CodigoCentroGasto = IIf(cboCentroGasto.SelectedIndex = -1, -1, cboCentroGasto.SelectedValue)

            'Verifica o Tipo de Operação
            If IsNumeric(btnSalvar.Tag) Then
                Dim sAlteracao As String = ""
                oClsCadParceiroNegocio.Update()
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                oClsCadParceiroNegocio.Insert()
                btnSalvar.Tag = oClsCadParceiroNegocio.Codigo
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

            'Váriaveis Locais
            Dim sVendedor As String = ""

            'Vendedor
            If cboVendedorFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboVendedorFiltro.CheckedValues)
                    sVendedor &= IIf(sVendedor = "", "", ",") & cboVendedorFiltro.CheckedValues(i).ToString
                Next
            End If

            'Seta Parametros
            oClsCadParceiroNegocio.LoadGrid(grdListagem, _
                                            IIf(cboTipoParceiroNegocioFiltro.SelectedIndex = -1, -1, cboTipoParceiroNegocioFiltro.SelectedValue), _
                                            IIf(cboPersonalidadeFiltro.SelectedIndex = -1, -1, cboPersonalidadeFiltro.SelectedValue), _
                                            txtRazaoSocialFiltro.Text.Trim, _
                                            txtNomeFantasiaFiltro.Text.Trim, _
                                            txtCnpjCpfFiltro.Text.Trim, _
                                            IIf(cboSegmentoFiltro.SelectedIndex = -1, -1, cboSegmentoFiltro.SelectedValue), _
                                            txtMunicipioFiltro.Text.Trim, _
                                            sVendedor, _
                                            IIf(cboTipoNegativacaoFiltro.SelectedIndex = -1, -1, cboTipoNegativacaoFiltro.SelectedValue), _
                                            IIf(cboImportado.SelectedIndex = -1, -1, IIf(cboImportado.SelectedValue = True, 1, 0)), -1, -1, -1)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Mapa()

        Try

            'Váriaveis Locais - Formulário Mapa
            Dim oForm As New frmActMaps
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location

            Dim sEndereco As String = ""
            Dim sCEP As String = ""
            Dim sMunicipio As String = ""

            Call oClsCadParceiroNegocio.LoadDadosParceiroNegocioEndereco(grdListagem.CurrentRow.Cells("codigo").Value, _
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

            ''Verifica se foi Selecionado o Campo - Segmento
            'If ValidaCampo(cboSegmento, lblSegmento) = False Then
            '    Exit Function
            'End If

            'Verifica se foi Selecionado o Campo - Ativo
            If ValidaCampo(cboAtivo, lblAtivo) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Tipo do Parceiro de Negócio
            If chkCliente.Checked = False And _
                chkDespachante.Checked = False And _
                chkFornecedor.Checked = False And _
                chkAgenteLogistico.Checked = False Then
                frmMain.errInfo.SetError(chkCliente, "É necessário selecionar o Tipo de Parceiro de Negócio.")
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - CEP
            If ValidaCampo(txtCEP, lblCEP, TipoCampo.texto) = False Then
                txtCEP.Focus() : Exit Function
            End If

            'Verifica se foi Selecionado o Campo - País
            If ValidaCampo(cboPais, lblPais) = False Then
                cboPais.Focus() : Exit Function
            End If

            'Verifica se foi Selecionado o Campo - UF
            If ValidaCampo(cboUF, lblUF) = False Then
                cboUF.Focus() : Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Município
            If cboUF.SelectedValue <> gcUFExterior Then
                If ValidaCampo(cboMunicipio, lblMunicipio) = False Then
                    cboMunicipio.Focus() : Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Logradouro
            If ValidaCampo(txtLogradouro, lblLogradouro, TipoCampo.texto) = False Then
                txtLogradouro.Focus() : Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Número
            If ValidaCampo(txtNumero, lblNumero, TipoCampo.texto) = False Then
                txtNumero.Focus() : Exit Function
            End If

            'Verifica se foi Preenchido Corretamente o Campo - Email
            If txtEmail.Text.Trim <> "" Then
                If ValidaCampo(txtEmail, lblEmail, TipoCampo.email) = False Then
                    txtEmail.Focus() : Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - CNPJ / CPF
            If ((cboPersonalidade.SelectedValue <> Personalidade.OrgaoPublico And cboPersonalidade.SelectedValue <> Personalidade.Outros) And txtCnpjCpf.Text.Trim <> "" And cboUF.SelectedValue <> "EX") Then

                ' Verifica se o CNPJ / CPF é válido
                If cboPersonalidade.SelectedValue = Personalidade.Fisica And txtCnpjCpf.Text <> "" Then
                    If ValidaCPF(txtCnpjCpf.Text.Trim) = False Then
                        frmMain.errInfo.SetError(lblCnpjCpf, "Este CPF não é válido!")
                        txtCnpjCpf.Focus()
                        Exit Function
                    End If
                End If

                If cboPersonalidade.SelectedValue = Personalidade.Juridica And txtCnpjCpf.Text <> "" Then
                    If ValidaCNPJ(txtCnpjCpf.Text.Trim) = False Then
                        frmMain.errInfo.SetError(lblCnpjCpf, "Este CNPJ não é válido!")
                        txtCnpjCpf.Focus()
                        Exit Function
                    End If
                End If

                'Passa Parametros
                If oClsCadParceiroNegocio.ValidaCnpjCpf(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1), _
                                                        txtCnpjCpf.Text.Trim) = False Then
                    frmMain.errInfo.SetError(lblCnpjCpf, "Este " & IIf(cboPersonalidade.SelectedValue = Personalidade.Juridica, "CNPJ", "CPF") & ": " & txtCnpjCpf.Text & " já está associado a outro Registro.")
                    txtCnpjCpf.Focus()
                    Exit Function
                End If

            End If

            If cboPersonalidade.Text <> "FÍSICA" Then

                'Verifica se foi Selecionado o Campo - Tipo de Inscrição Estadual
                If ValidaCampo(cboTipoInscricaoEstadual, lblTipoInscricaoEstadual) = False Then
                    cboTipoInscricaoEstadual.Focus() : Exit Function
                End If

                'Verifica se foi Preenchido o Campo - IE
                If txtInscricaoEstadual.Text.Trim <> "" Then

                    If ValidaCampo(txtInscricaoEstadual, lblInscricaoEstadual, TipoCampo.texto) = False Then
                        txtInscricaoEstadual.Focus() : Exit Function
                    End If

                    'Verifica se a IE é válida
                    If cboPersonalidade.SelectedValue = Personalidade.Juridica Then
                        If ValidaIE(cboUF.SelectedValue, txtInscricaoEstadual.Text.Trim) = False Then
                            frmMain.errInfo.SetError(lblInscricaoEstadual, "Esta Inscrição Estadual não é válido!")
                            txtInscricaoEstadual.Focus() : Exit Function
                        End If
                    End If

                End If

            End If




            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub EnviarMalaDireta()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Váriaveis locais
                Dim sEmail As String = ""
                Dim sEmailAuxiliar As String

                For Each oRow As GridEXRow In gSelecaoRow
                    'Obtem E-mail do Parceiro de Negocios
                    If oRow.Cells("email2").Value <> "" Then sEmail &= IIf(sEmail = "", "", ";") & oRow.Cells("email2").Value
                    sEmailAuxiliar = oClsCadParceiroNegocio.LoadContatoParceiroNegocio(oRow.Cells("codigo").Value, -1)
                    'Obtem e-mail dos contatos de parceiro de negocios
                    If sEmailAuxiliar <> "" Then sEmail &= IIf(sEmail = "", "", ";") & sEmailAuxiliar
                Next

                'Enviar E-mail
                Call EnviarEmail("", _
                                 "", _
                                 "", _
                                 "", _
                                 "", _
                                 -1, _
                                 sEmail)

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mais Registro
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region


#End Region

End Class

