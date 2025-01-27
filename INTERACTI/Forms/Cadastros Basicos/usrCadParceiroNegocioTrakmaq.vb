Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls
Imports Janus.Windows.Common

Public Class usrCadParceiroNegocioTrakmaq

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadParceiroNegocio As New clsUsrCadParceiroNegocio

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"
    Private Sub txtCPNJFilial_Leave(sender As Object, e As EventArgs) Handles txtCPNJFilial.Leave
        Try
            Dim iCodigo As Integer = -1
            iCodigo = IIf(IsDBNull(LoadCodigo("sp_select_codigo_parceiro_negocio_cnpj '" & txtCPNJFilial.Text & "'")), -1, LoadCodigo("sp_select_codigo_parceiro_negocio_cnpj '" & txtCPNJFilial.Text & "'"))

            If iCodigo <> -1 Then
                cboRazaoSocialFilial.SelectedValue = iCodigo
            End If
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnInserirFilial_Click(sender As Object, e As EventArgs) Handles btnInserirFilial.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Produto
            If IsNumeric(btnSalvar.Tag) = False Then
                'Salva Produto
                Call Salvar()
            End If

            'Valida Dados do Formulário
            If ValidaCampo(cboRazaoSocialFilial, lblRazaoSocialFilial) = True Then

                'Salva Dados do Registro
                Call SalvarFilial()
                oClsCadParceiroNegocio.LoadGridFilial(grdFilial, btnSalvar.Tag, goUsuario.iEmpresa)
                txtCPNJFilial.Text = "" : cboRazaoSocialFilial.SelectedIndex = -1

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluirFilial_Click(sender As Object, e As EventArgs) Handles btnExcluirFilial.Click
        Try
            Call DeleteFilial()
            oClsCadParceiroNegocio.LoadGridFilial(grdFilial, btnSalvar.Tag, goUsuario.iEmpresa)
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboCNAE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCNAE.SelectedIndexChanged
        Try
            If cboCNAE.SelectedIndex = -1 Then Exit Sub

            txtDescricaoCNAE.Text = LoadCodigo("sp_select_cadastro_basico_cnae_descricao " & cboCNAE.SelectedValue)
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub


    Private Sub btnInserirCNAE_Click(sender As Object, e As EventArgs) Handles btnInserirCNAE.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Produto
            If IsNumeric(btnSalvar.Tag) = False Then
                'Salva Produto
                Call Salvar()
            End If

            'Valida Dados do Formulário
            If ValidaCampo(cboCNAE, lblCodigoCNAE) = True Then

                'Salva Dados do Registro
                Call SalvarCNAE()
                oClsCadParceiroNegocio.LoadGridCNAE(grdCNAE, btnSalvar.Tag, goUsuario.iEmpresa)
                cboCNAE.SelectedIndex = -1 : txtDescricaoCNAE.Text = ""

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluirCNAE_Click(sender As Object, e As EventArgs) Handles btnExcluirCNAE.Click
        Try
            Call DeleteCNAE()
            oClsCadParceiroNegocio.LoadGridCNAE(grdCNAE, btnSalvar.Tag, goUsuario.iEmpresa)
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

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
                        Case "txtCepEndereco" : Call btnProcurarCEPEndereco_Click(btnProcurarCepEndereco, System.EventArgs.Empty)

                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name

                        Case "cboPais", "cboPaisEndereco"
                            Dim oComboBox(1) As UIComboBox
                            oComboBox(0) = cboPais : oComboBox(1) = cboPaisEndereco
                            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)
                        Case "cboSegmento", "cboSegmentoFiltro"
                            Dim oComboBox(1) As UIComboBox
                            oComboBox(0) = cboSegmentoFiltro : oComboBox(1) = cboSegmento
                            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_parceiro_negocio_segmento " & goUsuario.iEmpresa)
                        Case "cboTipoContato" : Call LoadCombo(cboTipoContato, "sp_select_combo_cadastro_basico_tipo_contato " & goUsuario.iEmpresa)
                        Case "cboVendedor" : Call LoadCombo(cboVendedor, "sp_select_combo_cadastro_basico_vendedor " & goUsuario.iEmpresa & ", " & goUsuario.iUsuario)
                        Case "cboVendedorInterno" : Call LoadCombo(cboVendedorInterno, "sp_select_combo_cadastro_basico_vendedor " & goUsuario.iEmpresa & ", " & goUsuario.iUsuario)
                        Case "cboCondicaoPagamento" : Call LoadCombo(cboCondicaoPagamento, "sp_select_combo_cadastro_basico_condicao_pagamento " & goUsuario.iEmpresa)
                        Case "cboTipoArquivoCertificado" : Call LoadCombo(cboTipoArquivoCertificado, "sp_select_combo_cadastro_basico_tipo_arquivo " & goUsuario.iEmpresa)

                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name

                        Case "cboSegmento" : Call btnCadastrarSegmento_Click(btnCadastrarSegmento, System.EventArgs.Empty)
                        Case "cboPais" : Call btnCadastrarPais_Click(btnCadastrarPais, System.EventArgs.Empty)
                        Case "cboVendedor" : Call btnCadastrarVendedor_Click(btnCadastrarVendedor, System.EventArgs.Empty)
                        Case "cboTipoContato" : Call btnCadastrarTipoContato_Click(btnCadastrarTipoContato, System.EventArgs.Empty)
                        Case "cboPaisEndereco" : Call btnCadastrarPaisEndereco_Click(btnCadastrarPaisEndereco, System.EventArgs.Empty)
                        Case "cboCondicaoPagamento" : Call btnCadastrarCondicaoPagamento_Click(btnCadastrarCondicaoPagamento, System.EventArgs.Empty)
                        Case "cboTipoArquivoCertificado" : Call btnCadastrarTipoArquivoCertificado_Click(btnCadastrarTipoArquivoCertificado, System.EventArgs.Empty)
                        Case "cboTipoArquivo" : Call btnCadastrarTipoArquivo_Click(btnCadastrarTipoArquivo, System.EventArgs.Empty)

                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadParceiroNegocioTrakmaq_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: PARCEIRO DE NEGÓCIO :::"

    Private Sub btnEditarGrid_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEditarGrid.Click

        Try

            'Váriaveis Locais
            Dim sCampo(3) As String

            'Carrega Valores
            sCampo(0) = "entrega_fisica"
            sCampo(1) = "entrega_email"
            sCampo(2) = "cronograma"
            sCampo(3) = "ativo"

            'Habilita Grid
            Call EditarGrid(grdListagem, _
                            sCampo, _
                             True)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

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
            Call LoadCombo(cboPaisEndereco, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)
            'Seta Focu
            cboPais.Focus()

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
            cboPaisEndereco.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarVendedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarVendedor.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadVendedor")

            'Carrega Combo
            Call LoadCombo(cboVendedor, "sp_select_combo_cadastro_basico_vendedor " & goUsuario.iEmpresa & ", " & goUsuario.iUsuario, )
            'Seta Focu
            cboVendedor.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarVendedorInterno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarVendedorInterno.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadVendedor")

            'Carrega Combo
            Call LoadCombo(cboVendedorInterno, "sp_select_combo_cadastro_basico_vendedor " & goUsuario.iEmpresa & ", " & goUsuario.iUsuario, )
            'Seta Focu
            cboVendedorInterno.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarCondicaoPagamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCondicaoPagamento.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCondicaoPagamento")

            'Carrega Combo
            Call LoadCombo(cboCondicaoPagamento, "sp_select_combo_cadastro_basico_condicao_pagamento " & goUsuario.iEmpresa)
            'Seta Focu
            cboCondicaoPagamento.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarCondicaoPagamentoFornecedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCondicaoPagamentoFornecedor.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCondicaoPagamento")

            'Carrega Combo
            Call LoadCombo(cboCondicaoPagamentoFornecedor, "sp_select_combo_cadastro_basico_condicao_pagamento " & goUsuario.iEmpresa)
            'Seta Focu
            cboCondicaoPagamentoFornecedor.Focus()

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

    Private Sub btnProcurarCEPEndereco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCepEndereco.Click

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

    Private Sub cboTipoNegativacao_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboTipoNegativacao.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum Registro
            If cboTipoNegativacao.SelectedIndex = -1 Then
                txtTextoNegativacao.Text = ""
                txtTextoNegativacao.Enabled = False
            Else
                If cboTipoNegativacao.SelectedValue = CInt(TipoNegativacaoCliente.Liberado) Then
                    txtTextoNegativacao.Text = ""
                    txtTextoNegativacao.Enabled = False
                Else
                    txtTextoNegativacao.Enabled = True
                End If
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

    Private Sub chkCliente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCliente.CheckedChanged

        Try

            'Verifica se é Cliente
            If chkCliente.Checked Then
                If VerificaDireito(Formulario.CadastroBasicoParceiroNegocioClienteCondicaoFornecimento, IIf(CStr(btnSalvar.Tag) = "", gcInsert, gcUpdate)) = True Then tabDados.TabPages.Add(pagDadosCliente)
                If VerificaDireito(Formulario.CadastroBasicoParceiroNegocioClienteCRM, IIf(CStr(btnSalvar.Tag) = "", gcInsert, gcUpdate)) = True Then tabDados.TabPages.Add(pagRelacionamento)
                If VerificaDireito(Formulario.CadastroBasicoParceiroNegocioClienteMarcasHomologadas, IIf(CStr(btnSalvar.Tag) = "", gcInsert, gcUpdate)) = True Then tabDados.TabPages.Add(pagMarca)
                If VerificaDireito(Formulario.CadastroBasicoParceiroNegocioClienteNegativacao, IIf(CStr(btnSalvar.Tag) = "", gcInsert, gcUpdate)) = True Then tabDados.TabPages.Add(pagNegativacao)
            Else
                tabDados.TabPages.Remove(pagDadosCliente)
                tabDados.TabPages.Remove(pagRelacionamento)
                tabDados.TabPages.Remove(pagMarca)
                tabDados.TabPages.Remove(pagNegativacao)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub chkFornecedor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFornecedor.CheckedChanged

        Try

            'Verifica se é Fornecedor
            If chkFornecedor.Checked Then

                If tabDados.TabPages.Contains(pagDadosFornecedor) = False Then tabDados.TabPages.Add(pagDadosFornecedor)
                If VerificaDireito(Formulario.CadastroBasicoParceiroNegocioFornecedorCertificados, IIf(IsNumeric(btnSalvar.Tag), gcInsert, gcUpdate)) = True Then If tabDados.TabPages.Contains(pagCertificado) = False Then tabDados.TabPages.Add(pagCertificado)
            Else
                If chkDespachante.Checked = False And chkAgenteLogistico.Checked = False Then tabDados.TabPages.Remove(pagDadosFornecedor)
                tabDados.TabPages.Remove(pagCertificado)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub chkAgenteLogistico_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAgenteLogistico.CheckedChanged

        Try

            'Verifica se é Fornecedor
            If chkAgenteLogistico.Checked Then
                If tabDados.TabPages.Contains(pagDadosFornecedor) = False Then tabDados.TabPages.Add(pagDadosFornecedor)
                If VerificaDireito(Formulario.CadastroBasicoParceiroNegocioFornecedorCertificados, IIf(IsNumeric(btnSalvar.Tag), gcInsert, gcUpdate)) = True Then If tabDados.TabPages.Contains(pagCertificado) = False Then tabDados.TabPages.Add(pagCertificado)
            Else
                If chkFornecedor.Checked = False And chkDespachante.Checked = False Then tabDados.TabPages.Remove(pagDadosFornecedor)
                tabDados.TabPages.Remove(pagCertificado)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub chkDespachante_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDespachante.CheckedChanged

        Try

            'Verifica se é Fornecedor
            If chkFornecedor.Checked Then
                If tabDados.TabPages.Contains(pagDadosFornecedor) = False Then tabDados.TabPages.Add(pagDadosFornecedor)
                If VerificaDireito(Formulario.CadastroBasicoParceiroNegocioFornecedorCertificados, IIf(IsNumeric(btnSalvar.Tag), gcInsert, gcUpdate)) = True Then If tabDados.TabPages.Contains(pagCertificado) = False Then tabDados.TabPages.Add(pagCertificado)
            Else
                If chkFornecedor.Checked = False And chkAgenteLogistico.Checked = False Then tabDados.TabPages.Remove(pagDadosFornecedor)
                tabDados.TabPages.Remove(pagCertificado)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    'Private Sub grdListagem_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdListagem.CellUpdated

    '    Try

    '        'Query
    '        Dim sQuery As String = "WHERE (((codigo) = " & grdListagem.GetValue("codigo") & "))"

    '        Select Case e.Column.Key

    '            Case "vendedor" : Call ExecuteQuery("sp_update_interacti_table_field 'tb_cad_parceiro_negocio', 'codigo_vendedor', " & IIf(IsDBNull(grdListagem.GetValue("vendedor")) = False, grdListagem.GetValue("vendedor"), "'NULL'") & ",'" & sQuery & "'")
    '            Case "vendedor_interno" : Call ExecuteQuery("sp_update_interacti_table_field 'tb_cad_parceiro_negocio', 'codigo_vendedor_interno', " & IIf(IsDBNull(grdListagem.GetValue("vendedor_interno")) = False, grdListagem.GetValue("vendedor_interno"), "'NULL'") & ",'" & sQuery & "'")

    '        End Select

    '    Catch ex As Exception
    '        'Trata Erro
    '        Call TratamentoErro(ex.Message, Me.Parent.Text)
    '    End Try

    'End Sub

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

    Private Sub btnAlterarEmpresa_Click(sender As Object, e As EventArgs) Handles btnAlterarEmpresa.Click
        Try
            Call AlterarEmpresa()
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try
            Call VisualizarImpressao()
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
#End Region

#Region "::: CLIENTE :::"

    Private Sub cboInstrucao1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboInstrucao1.SelectedIndexChanged

        Try

            'Seta Controle
            If cboInstrucao1.SelectedIndex = -1 Then
                txtNumeroDias1.Enabled = False
                txtNumeroDias1.Value = 0
            ElseIf CType(LoadDescricao("sp_select_static_instrucao_boleto_bancario_dia '" & cboInstrucao1.SelectedValue & "'"), Boolean) = False Then
                txtNumeroDias1.Enabled = False
                txtNumeroDias1.Value = 0
            Else
                txtNumeroDias1.Enabled = True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboInstrucao2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboInstrucao2.SelectedIndexChanged

        Try

            'Seta Controle
            If cboInstrucao2.SelectedIndex = -1 Then
                txtNumeroDias2.Enabled = False
                txtNumeroDias2.Value = 0
            ElseIf CType(LoadDescricao("sp_select_static_instrucao_boleto_bancario_dia '" & cboInstrucao2.SelectedValue & "'"), Boolean) = False Then
                txtNumeroDias2.Enabled = False
                txtNumeroDias2.Value = 0
            Else
                txtNumeroDias2.Enabled = True
            End If

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

            'Exporta Grid para Excel
            Call ExportExcel(grdContato)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarTipoContato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarTipoContato.Click

        Try

            '             'Abre Formulário de Cadastro
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

                        If (goDatabase.sInitialCatalog = "INTERACTI_ASCON_PRD") Then

                            'Insere Contato
                            Call oClsCadParceiroNegocio.InsertContatoAscon(txtNomeContato.Text.Trim, _
                                                                      txtTelefoneContato.Text.Trim, _
                                                                      txtCelularContato.Text.Trim, _
                                                                      IIf(dtpDataAniversario.Checked = True, dtpDataAniversario.Value, ""), _
                                                                      txtEmailContato.Text.Trim, _
                                                                      txtComplementoContato.Text.Trim, _
                                                                      cboTipoContato.SelectedValue, _
                                                                      chkCronogram.Checked, _
                                                                      chkFinanceiro.Checked, _
                                                                      chkFaturamento.Checked, _
                                                                      chkMarketing.Checked, _
                                                                      chkCircular.Checked, _
                                                                      chkOutros.Checked)

                        Else

                            'Insere Contato
                            Call oClsCadParceiroNegocio.InsertContato(txtNomeContato.Text.Trim, _
                                                                      txtTelefoneContato.Text.Trim, _
                                                                      txtCelularContato.Text.Trim, _
                                                                      IIf(dtpDataAniversario.Checked = True, dtpDataAniversario.Value, ""), _
                                                                      txtEmailContato.Text.Trim, _
                                                                      txtComplementoContato.Text.Trim, _
                                                                      cboTipoContato.SelectedValue)

                        End If

                    Else

                        If (goDatabase.sInitialCatalog = "INTERACTI_ASCON_PRD") Then

                            'Atualiza Dados do Contato
                            Call oClsCadParceiroNegocio.UpdateContatoAscon(txtNomeContato.Text.Trim, _
                                                                      txtTelefoneContato.Text.Trim, _
                                                                      txtCelularContato.Text.Trim, _
                                                                      IIf(dtpDataAniversario.Checked = True, dtpDataAniversario.Value, ""), _
                                                                      txtEmailContato.Text.Trim, _
                                                                      txtComplementoContato.Text.Trim, _
                                                                      cboTipoContato.SelectedValue, _
                                                                      btnSalvarContato.Tag, _
                                                                      chkCronogram.Checked, _
                                                                      chkFinanceiro.Checked, _
                                                                      chkFaturamento.Checked, _
                                                                      chkMarketing.Checked, _
                                                                      chkCircular.Checked, _
                                                                      chkOutros.Checked)

                        Else

                            'Atualiza Dados do Contato
                            Call oClsCadParceiroNegocio.UpdateContato(txtNomeContato.Text.Trim, _
                                                                      txtTelefoneContato.Text.Trim, _
                                                                      txtCelularContato.Text.Trim, _
                                                                      IIf(dtpDataAniversario.Checked = True, dtpDataAniversario.Value, ""), _
                                                                      txtEmailContato.Text.Trim, _
                                                                      txtComplementoContato.Text.Trim, _
                                                                      cboTipoContato.SelectedValue, _
                                                                      btnSalvarContato.Tag)

                        End If

                       

                End If

            End If

            End If
            'Carrega Lista de Contato
            Call oClsCadParceiroNegocio.LoadGridContato(grdContato, _
                                                        btnSalvar.Tag)

            'Prepara Formulário para Inserção de um Novo Registro
            Call NovoContato()
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

    Private Sub grdContato_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdContato.GroupsChanging

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
                        Call oClsCadParceiroNegocio.InsertEndereco(cboTipoEndereco.SelectedValue, _
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
                        Call oClsCadParceiroNegocio.UpdateEndereco(cboTipoEndereco.SelectedValue, _
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
                    oClsCadParceiroNegocio.LoadGridEndereco(grdEndereco, _
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

    Private Sub grdEndereco_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdEndereco.GroupsChanging

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

#Region "::: CRM :::"

    Private Sub btnAgruparGridCRM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridCRM.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdCRM.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdCRM.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdCRM.GroupByBoxVisible = True
                grdCRM.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridCRM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridCRM.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdCRM
            oForm.NomeFormulario = Formulario.CadastroBasicoParceiroNegocio
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdCRM, Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridCRM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridCRM.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdCRM)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSalvarCRM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarCRM.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Parceiro de Negócio
            If Validacao() = True Then

                'Salva Dados do Parceiro de Negócio
                Call Salvar()

                'Valida Dados do CRM
                If ValidacaoCRM() = True Then

                    'Verifica o Tipo de Operação
                    If IsNumeric(btnSalvarCRM.Tag) = False Then

                        'Insere CRM
                        Call oClsCadParceiroNegocio.InsertCRM(txtAssuntoCRM.Text.Trim, _
                                                              dtpDataCRM.Value)

                    Else

                        'Atualiza Dados do CRM
                        Call oClsCadParceiroNegocio.UpdateCRM(txtAssuntoCRM.Text.Trim, _
                                                              dtpDataCRM.Value, _
                                                              btnSalvarCRM.Tag)

                    End If

                    'Carrega Lista de CRM
                    Call oClsCadParceiroNegocio.LoadGridCRM(grdCRM, _
                                                            btnSalvar.Tag)

                    'Prepara Formulário para Inserção de um Novo Registro
                    Call NovoCRM()

                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirCRM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirCRM.Click

        Try

            'Deleta Registros
            Call DeleteCRM()

            'Limpa Formulário
            Call NovoCRM()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdCRM_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdCRM.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdCRM.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdCRM.CurrentColumn.Key
                Case "editar" : Call EditarCRM()
                Case "comentario" : Call ComentarioCRM()
                Case "historico" : Call HistoricoCRM()
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdCRM_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdCRM.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdCRM, _
                                     Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdCRM_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdCRM.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdCRM.Name, _
                                     Formulario.CadastroBasicoParceiroNegocio, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdCRM_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdCRM.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdCRM.Name, _
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

#Region "::: CERTIFICADO :::"

    Private Sub btnAgruparGridCertificado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridCertificado.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdCertificado.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdCertificado.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdCertificado.GroupByBoxVisible = True
                grdCertificado.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridCertificado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridCertificado.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdCertificado
            oForm.NomeFormulario = Formulario.CadastroBasicoParceiroNegocio
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdCertificado, Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridCertificado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridCertificado.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdCertificado)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarTipoArquivoCertificado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarTipoArquivoCertificado.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadTipoArquivo")

            'Carrega Combo
            Call LoadCombo(cboTipoArquivoCertificado, "sp_select_combo_cadastro_basico_tipo_arquivo " & goUsuario.iEmpresa)
            'Seta Focu
            cboTipoArquivoCertificado.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnArquivoCertificado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArquivoCertificado.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Campo - Tipo de Arquivo
            If ValidaCampo(cboTipoArquivoCertificado, lblTipoArquivoCertificado) = False Then
                Exit Sub
            End If

            'Variaveis Locais
            Dim arqArquivo As New OpenFileDialog

            'Abre PopUp para Usuário selecionar Imagem
            arqArquivo.InitialDirectory = "c:\\dados"
            arqArquivo.Filter = LoadDescricao("sp_select_cadastro_basico_extensao_tipo_arquivo " & goUsuario.iEmpresa & "," & cboTipoArquivoCertificado.SelectedValue)
            arqArquivo.Title = "Selecione o Arquivo"

            If arqArquivo.ShowDialog() = DialogResult.OK Then
                txtArquivoCertificado.Text = arqArquivo.FileName
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSalvarCertificado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarCertificado.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Parceiro de Negócio
            If Validacao() = True Then

                'Salva Dados do Parceiro de Negócio
                Call Salvar()

                'Valida Dados do Certificado
                If ValidacaoCertificado() = True Then

                    'Verifica o Tipo de Operação
                    If IsNumeric(btnSalvarCertificado.Tag) = False Then

                        Dim iCodigoCertificado As Integer

                        'Insere Certificado
                        Call oClsCadParceiroNegocio.InsertCertificado(txtCertificado.Text.Trim, _
                                                                      dtpDataEmissaoCertificado.Value, _
                                                                      IIf(dtpDataValidadeCertificado.Checked = True, dtpDataValidadeCertificado.Value, ""), _
                                                                      iCodigoCertificado)


                        'Insere Arquivo
                        Call InsertArquivoBD("tb_cad_parceiro_negocio_certificado", _
                                             txtCertificado.Text.Trim, _
                                             dtpDataEmissaoCertificado.Value, _
                                             txtArquivoCertificado.Text.Trim, _
                                             cboTipoArquivoCertificado.SelectedValue, _
                                             btnSalvar.Tag, _
                                             iCodigoCertificado)

                    Else

                        'Atualiza Dados do Certificado
                        Call oClsCadParceiroNegocio.UpdateCertificado(txtCertificado.Text.Trim, _
                                                                      dtpDataEmissaoCertificado.Value, _
                                                                      IIf(dtpDataValidadeCertificado.Checked = True, dtpDataValidadeCertificado.Value, ""), _
                                                                      btnSalvarCertificado.Tag)

                        'Verifica se tem Arquivo associado
                        If cboTipoArquivoCertificado.SelectedIndex = -1 And IsDBNull(grdCertificado.CurrentRow.Cells("path").Value) = False Then

                            'Deleta Arquivo
                            Call DeleteArquivoBD("tb_cad_parceiro_negocio_certificado", _
                                                 grdCertificado.CurrentRow.Cells("path").Value, _
                                                 btnSalvar.Tag, _
                                                 btnSalvarCertificado.Tag)

                        ElseIf txtArquivoCertificado.Text.Trim <> "" Then

                            Call UpdateArquivoBD("tb_cad_parceiro_negocio_certificado", _
                                                 txtCertificado.Text.Trim, _
                                                 dtpDataEmissaoCertificado.Value, _
                                                 txtArquivoCertificado.Text.Trim, _
                                                 cboTipoArquivoCertificado.SelectedValue, _
                                                 grdCertificado.CurrentRow.Cells("path").Value, _
                                                 btnSalvar.Tag, _
                                                 btnSalvarCertificado.Tag)

                        End If

                    End If

                    'Carrega Lista de Certificado
                    Call oClsCadParceiroNegocio.LoadGridCertificado(grdCertificado, _
                                                                    btnSalvar.Tag)

                    'Prepara Formulário para Inserção de um Novo Registro
                    Call NovoCertificado()

                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirCertificado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirCertificado.Click

        Try

            'Deleta Registros
            Call DeleteCertificado()

            'Limpa Formulário
            Call NovoCertificado()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdCertificado_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdCertificado.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdCertificado.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdCertificado.CurrentColumn.Key
                Case "editar" : Call EditarCertificado()
                Case "visualizar"
                    If IsDBNull(grdCertificado.CurrentRow.Cells("arquivo").Value) = False Then
                        Call VisualizarDocumentoBD(grdCertificado.CurrentRow.Cells("arquivo").Value, grdCertificado.CurrentRow.Cells("extensao").Value)
                    Else
                        frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Não foi inserido nenhum Arquivo.")
                    End If
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdCertificado_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdCertificado.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdCertificado, _
                                     Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdCertificado_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdCertificado.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdCertificado.Name, _
                                     Formulario.CadastroBasicoParceiroNegocio, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdCertificado_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdCertificado.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdCertificado.Name, _
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

#Region "::: ESPECIALIDADE :::"

    Private Sub grdEspecialidade_RowCheckStateChanged(ByVal sender As Object, ByVal e As RowCheckStateChangeEventArgs) Handles grdEspecialidade.RowCheckStateChanged

        Try

            grdEspecialidade.Refresh()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridEspecialidade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridEspecialidade.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdEspecialidade)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: MARCA :::"

    Private Sub btnConfigurarGridMarca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridMarca.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdMarca
            oForm.NomeFormulario = Formulario.CadastroBasicoParceiroNegocio
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdMarca, Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridMarca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridMarca.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdMarca)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdMarca_RowCheckStateChanged(ByVal sender As Object, ByVal e As RowCheckStateChangeEventArgs) Handles grdMarca.RowCheckStateChanged

        Try

            grdMarca.Refresh()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdMarca_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdMarca.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdMarca, _
                                     Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdMarca_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdMarca.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdMarca.Name, _
                                     Formulario.CadastroBasicoParceiroNegocio, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: COBRANÇA :::"

    Private Sub btnAgruparGridCobranca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridCobranca.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdCobranca.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdCobranca.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdCobranca.GroupByBoxVisible = True
                grdCobranca.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridCobranca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridCobranca.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdCobranca
            oForm.NomeFormulario = Formulario.CadastroBasicoParceiroNegocio
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdCobranca, Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridCobranca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridCobranca.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdCobranca)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirCobranca_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnInserirCobranca.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Parceiro de Negócio
            If Validacao() = True Then

                'Salva Dados do Parceiro de Negócio
                Call Salvar()

                'Valida Dados do Contato
                If ValidacaoCobranca() = True Then

                    'Verifica o Tipo de Operação
                    If IsNumeric(btnInserirCobranca.Tag) = False Then

                        'Insere Contato
                        Call oClsCadParceiroNegocio.InsertCobranca(dtpDataCobranca.Value, _
                                                                  txtResponsavelCobranca.Text.Trim, _
                                                                  txtTelefoneContatoCobranca.Text.Trim, _
                                                                  txtHistoricoCobranca.Text.Trim, _
                                                                  txtContatoCobranca.Text.Trim)


                    Else

                        'Atualiza Dados do Contato
                        Call oClsCadParceiroNegocio.UpdateCobranca(dtpDataCobranca.Value, _
                                                                  txtResponsavelCobranca.Text.Trim, _
                                                                  txtTelefoneContatoCobranca.Text.Trim, _
                                                                  txtHistoricoCobranca.Text.Trim, _
                                                                  btnInserirCobranca.Tag, _
                                                                  txtContatoCobranca.Text.Trim)

                    End If

                    'Carrega Lista de Contato
                    Call oClsCadParceiroNegocio.LoadGridCobranca(grdCobranca, btnSalvar.Tag)

                    'Prepara Formulário para Inserção de um Novo Registro
                    Call NovoCobranca()

                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirCobranca_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExcluirCobranca.Click

        Try

            'Deleta Registros
            Call DeleteCobranca()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdCobranca_RowDoubleClick(ByVal sender As Object, ByVal e As RowActionEventArgs) Handles grdCobranca.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdCobranca.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdCobranca.CurrentColumn.Key

                Case "editar" : Call EditarCobranca()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdCobranca_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdCobranca.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdCobranca, _
                                     Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdCobranca_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdCobranca.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdCobranca.Name, _
                                     Formulario.CadastroBasicoParceiroNegocio, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdCobranca_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdCobranca.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdCobranca.Name, _
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

#Region "::: SOCIETÁRIO :::"
    Private Sub btnInserirSocietario_Click(sender As Object, e As EventArgs) Handles btnInserirSocietario.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Produto
            If IsNumeric(btnSalvar.Tag) = False Then
                'Salva Produto
                Call Salvar()
            End If

            'Valida Dados do Formulário
            If ValidaCampo(txtArquivoSocietario, lblArquivoSocietario, TipoCampo.texto) = True Then

                'Salva Dados do Registro
                Call SalvarArquivoSocietario()
                oClsCadParceiroNegocio.LoadGridSocietario(grdSocietario, btnSalvar.Tag, goUsuario.iEmpresa)
                Call NovoSocietario()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
    Private Sub grdSocietario_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdSocietario.RowDoubleClick
        Try
            'Verifica o Tipo de Célula
            If IsNothing(e.Row) Then Exit Sub

            Select Case grdSocietario.CurrentColumn.Key

                Case "visualizar" : Call VisualizarArquivoSocietario()
                Case "editar" : Call EditarSocietario()
                Case "email" : Call EmailSocietario()


            End Select
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
    Private Sub btnArquivoSocietario_Click(sender As Object, e As EventArgs) Handles btnArquivoSocietario.Click
        Try

            Dim oSaveFileDialog As New OpenFileDialog

            If oSaveFileDialog.ShowDialog = DialogResult.OK Then

                Dim oFileInfo As New System.IO.FileInfo(oSaveFileDialog.FileName)
                Dim sFile As String = "\\srvfs02\Aplicativos\SGA.NET\Arquivos Societario\" & oFileInfo.Name

                'Executa a cópia
                System.IO.File.Copy(oSaveFileDialog.FileName, sFile)

                'Atualiza
                txtArquivoSocietario.Text = sFile

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
    Private Sub btnCadTipoDocumentoSocietario_Click(sender As Object, e As EventArgs) Handles btnCadTipoDocumentoSocietario.Click
        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrSGACadTipoDocumento")

            'Carrega Combo
            Call LoadCombo(cboTipoDocumento, "sp_select_combo_sga_cadastro_basico_tipo_documento -1")
            'Seta Focu
            cboTipoArquivo.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
    Private Sub btnExcluirSocietario_Click(sender As Object, e As EventArgs) Handles btnExcluirSocietario.Click
        Try
            Call DeleteSocietario()
            oClsCadParceiroNegocio.LoadGridSocietario(grdSocietario, btnSalvar.Tag, goUsuario.iEmpresa)
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
#End Region

#Region "::: VINCENDO :::"
    Private Sub btnInserirVincendo_Click(sender As Object, e As EventArgs) Handles btnInserirVincendo.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Produto
            If IsNumeric(btnSalvar.Tag) = False Then
                'Salva Produto
                Call Salvar()
            End If

            'Valida Dados do Formulário
            If ValidaCampo(cboTipoVincendo, lblTipoVincendo) = True Then

                'Salva Dados do Registro
                Call SalvarVincendo()
                oClsCadParceiroNegocio.LoadGridVincendo(grdVincendo, btnSalvar.Tag, goUsuario.iEmpresa)
                Call NovoVincendo()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
    Private Sub btnExcluirVincendo_Click(sender As Object, e As EventArgs) Handles btnExcluirVincendo.Click
        Try
            Call DeleteVincendo()
            oClsCadParceiroNegocio.LoadGridVincendo(grdVincendo, btnSalvar.Tag, goUsuario.iEmpresa)
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
    Private Sub grdVincendo_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdVincendo.RowDoubleClick
        Try
            'Verifica o Tipo de Célula
            If IsNothing(e.Row) Then Exit Sub

            Select Case grdVincendo.CurrentColumn.Key

                Case "visualizar" : Call VisualizarArquivoVincendo()
                Case "editar" : Call EditarVincendo()


            End Select
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnCadastrarTipoVincendo_Click(sender As Object, e As EventArgs) Handles btnCadastrarTipoVincendo.Click
        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrSGACadTipoVincendo")

            'Carrega Combo
            Call LoadCombo(cboTipoVincendo, "sp_select_combo_sga_cadastro_basico_tipo_vincendo " & goUsuario.iEmpresa)
            'Seta Focu
            cboTipoArquivo.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnProcurarArquivoVincendo_Click(sender As Object, e As EventArgs) Handles btnProcurarArquivoVincendo.Click
        Try

            Dim oSaveFileDialog As New OpenFileDialog

            If oSaveFileDialog.ShowDialog = DialogResult.OK Then

                Dim oFileInfo As New System.IO.FileInfo(oSaveFileDialog.FileName)
                Dim sFile As String = "\\srvfs02\Aplicativos\SGA.NET\Arquivos Vincendo\" & oFileInfo.Name

                'Executa a cópia
                System.IO.File.Copy(oSaveFileDialog.FileName, sFile)

                'Atualiza
                txtArquivoSocietario.Text = sFile

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub txtRazaoSocial_LostFocus(sender As Object, e As EventArgs) Handles txtRazaoSocial.LostFocus
        Try
            If goDatabase.sInitialCatalog = "INTERACTI_ASCON_PRD" And txtNomeFantasia.Text = "" Then
                txtNomeFantasia.Text = txtRazaoSocial.Text
            End If
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnInserirSocio_Click(sender As Object, e As EventArgs) Handles btnInserirSocio.Click
        Try
            'Valida Dados do Formulário
            If Validacao() = True Then
                'Salva Dados do Registro
                Call Salvar()
            End If

            Call InserirSocios(btnSalvar.Tag)
            ' oClsCadParceiroNegocio.LoadGridSocio(grdSocio, btnSalvar.Tag, goUsuario.iEmpresa)
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdSocio_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdSocio.RowDoubleClick
        Try
            'Verifica o Tipo de Célula
            If IsNothing(e.Row) Then Exit Sub

            Select Case grdSocio.CurrentColumn.Key

                Case "editar" : Call InserirSocios(btnSalvar.Tag, grdSocio.CurrentRow.Cells.Item("codigo").Value)
                Case "inativar" : Call InativarSocio(btnSalvar.Tag, grdSocio.CurrentRow.Cells.Item("codigo").Value)

            End Select
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

#End Region

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
            oForm.NomeFormulario = Formulario.CadastroBasicoProduto
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdArquivo, Formulario.CadastroBasicoProduto)

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

            'Valida Dados do Produto
            If IsNumeric(btnSalvar.Tag) = False Then
                'Salva Produto
                Call Salvar()
            End If

            'Valida Dados do Formulário
            If ValidacaoArquivo() = True Then

                If IsNumeric(btnInserirArquivo.Tag) = False Then

                    'Insere Arquivo
                    Call InsertArquivoBD("tb_cad_parceiro_negocio", _
                                         txtDescricaoArquivo.Text.Trim, _
                                         txtRevisaoArquivo.Text.Trim, _
                                         txtArquivo.Text.Trim, _
                                         cboTipoArquivo.SelectedValue, _
                                         btnSalvar.Tag)

                Else

                    'Atualiza Arquivo
                    Call UpdateArquivoBD("tb_cad_parceiro_negocio", _
                                         txtDescricaoArquivo.Text.Trim, _
                                         txtRevisaoArquivo.Text.Trim, _
                                         IIf(txtArquivo.Text.Trim = "", grdArquivo.CurrentRow.Cells("path").Value, txtArquivo.Text.Trim), _
                                         cboTipoArquivo.SelectedValue, _
                                         grdArquivo.CurrentRow.Cells("path").Value, _
                                         btnSalvar.Tag)

                End If

                'Carrega Grid
                Call LoadGridArquivoBD(grdArquivo, "tb_cad_parceiro_negocio", btnSalvar.Tag)

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

    Private Sub cboTipoArquivo_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboTipoArquivo.SelectedIndexChanged

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

            'Verifica se foi pressionado uma Célula Válida
            If IsNothing(grdArquivo.CurrentRow) Then Exit Sub

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
                                     Formulario.CadastroBasicoProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdArquivo.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdArquivo.Name, _
                                     Formulario.CadastroBasicoProduto, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdArquivo.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdArquivo.Name, _
                                          Formulario.CadastroBasicoProduto, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

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
            btnSalvarContato.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioContatos, gcInsert)
            btnExcluirContato.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioContatos, gcDelete)
            btnExcelGridContato.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioContatos, gcPrint)
            btnSalvarEndereco.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioEnderecos, gcInsert)
            btnExcluirEndereco.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioEnderecos, gcDelete)
            btnExcelGridEndereco.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioEnderecos, gcPrint)
            btnSalvarCRM.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioRelacionamento, gcInsert)
            btnExcluirCRM.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioRelacionamento, gcDelete)
            btnExcelGridCRM.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioRelacionamento, gcPrint)
            btnSalvarCertificado.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioFornecedorCertificados, gcInsert)
            btnExcluirCertificado.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioFornecedorCertificados, gcDelete)
            btnExcelGridCertificado.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioFornecedorCertificados, gcPrint)
            btnExcelGridEspecialidade.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcPrint)
            btnExcelGridMarca.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioClienteMarcasHomologadas, gcPrint)
            btnExcelGridArquivo.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcPrint)

            'Verifica Direito - Botão de Cadastrar
            btnCadastrarSegmento.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioSegmento, gcInsert)
            btnCadastrarPais.Enabled = VerificaDireito(Formulario.CadastroBasicoPais, gcInsert)
            btnCadastrarPaisEndereco.Enabled = VerificaDireito(Formulario.CadastroBasicoPais, gcInsert)
            btnCadastrarVendedor.Enabled = VerificaDireito(Formulario.CadastroBasicoVendedor, gcInsert)
            btnCadastrarVendedorInterno.Enabled = VerificaDireito(Formulario.CadastroBasicoVendedor, gcInsert)
            btnCadastrarTipoContato.Enabled = VerificaDireito(Formulario.CadastroBasicoTipoContato, gcInsert)
            btnCadastrarCondicaoPagamento.Enabled = VerificaDireito(Formulario.CadastroBasicoCondicaoPagamento, gcInsert)
            btnCadastrarCondicaoPagamentoFornecedor.Enabled = VerificaDireito(Formulario.CadastroBasicoCondicaoPagamento, gcInsert)
            btnCadastrarTipoArquivoCertificado.Enabled = VerificaDireito(Formulario.CadastroBasicoTipoArquivo, gcInsert)
            grdMarca.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioClienteMarcasHomologadas, gcInsert)

            'Carrega Combo
            Dim oComboBox(1) As UIComboBox
            Call LoadCombo(cboTipoParceiroNegocioFiltro, "sp_select_combo_static_tipo_parceiro_negocio")
            oComboBox(0) = cboPersonalidadeFiltro : oComboBox(1) = cboPersonalidade
            Call LoadCombo(oComboBox, "sp_select_combo_static_personalidade")
            Call LoadCombo(cboSegmento, "sp_select_combo_cadastro_basico_parceiro_negocio_segmento " & goUsuario.iEmpresa)
            Call LoadCombo(cboSegmentoFiltro, "sp_select_combo_cadastro_basico_parceiro_negocio_segmento " & goUsuario.iEmpresa)
            Call LoadCombo(cboVendedor, "sp_select_combo_cadastro_basico_vendedor " & goUsuario.iEmpresa & ", " & goUsuario.iUsuario)
            Call LoadCombo(cboVendedorInterno, "sp_select_combo_cadastro_basico_vendedor " & goUsuario.iEmpresa & ", " & goUsuario.iUsuario)
            Call LoadCombo(cboVendedorFiltro, "sp_select_combo_cadastro_basico_vendedor " & goUsuario.iEmpresa & ", " & goUsuario.iUsuario)
            Call LoadCombo(cboPais, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)
            Call LoadCombo(cboPaisEndereco, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)
            Call LoadCombo(cboTipoInscricaoEstadual, "sp_select_combo_static_tipo_inscricao_estadual")
            Call LoadCombo(cboRegimeTributario, "sp_select_combo_static_regime_tributario")
            Call LoadCombo(cboTipoContato, "sp_select_combo_cadastro_basico_tipo_contato " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboTipoEndereco, "sp_select_combo_static_tipo_endereco")
            Call LoadCombo(cboTipoArquivoCertificado, "sp_select_combo_cadastro_basico_tipo_arquivo " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboTipoArquivo, "sp_select_combo_cadastro_basico_tipo_arquivo " & goUsuario.iEmpresa, False)
            oComboBox(0) = cboCondicaoPagamento : oComboBox(1) = cboCondicaoPagamentoFornecedor
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_condicao_pagamento " & goUsuario.iEmpresa, False)
            oComboBox(0) = cboFormaPagamento : oComboBox(1) = cboFormaPagamentoFornecedor
            Call LoadCombo(oComboBox, "sp_select_combo_static_tipo_documento_pagamento", False)
            oComboBox(0) = cboMoeda : oComboBox(1) = cboMoedaFornecedor
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_moeda " & goUsuario.iEmpresa, False)
            oComboBox(0) = cboModalidadeFrete : oComboBox(1) = cboModalidadeFreteFornecedor
            Call LoadCombo(oComboBox, "sp_select_combo_static_modalidade_frete", False)
            oComboBox(0) = cboTipoNegativacao : oComboBox(1) = cboTipoNegativacaoFiltro
            Call LoadCombo(oComboBox, "sp_select_combo_static_tipo_negativacao", False)
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)
            Call LoadCombo(cboInstrucao1, "sp_select_combo_static_instrucao_boleto_bancario", False)
            Call LoadCombo(cboInstrucao2, "sp_select_combo_static_instrucao_boleto_bancario", False)
            Call LoadCombo(cboDestinacaoPadrao, "sp_select_combo_static_destinacao", False)
            Call LoadComboSimNao(cboEnviarAR)
            Call LoadComboSimNao(cboImportado)
            Call LoadComboSimNao(cboClienteFiltro)
            Call LoadComboSimNao(cboFornecedorFiltro)
            Call LoadCombo(cboEmpresaContrato, "sp_select_combo_cadastro_basico_empresa")



            If (goDatabase.sInitialCatalog = "INTERACTI_ASCON_PRD") Then

                chkCronogram.Visible = True
                chkFinanceiro.Visible = True
                chkFaturamento.Visible = True
                chkMarketing.Visible = True
                chkCircular.Visible = True
                chkOutros.Visible = True
                lblAtivoFiltro.Visible = True
                cboAtivoFiltro.Visible = True
                btnImprimir.Visible = True
                btnAlterarEmpresa.Visible = True

                Call LoadCombo(cboTipoDocumento, "sp_select_combo_sga_cadastro_basico_tipo_documento -1")
                Call LoadCombo(cboTipoVincendo, "sp_select_combo_sga_cadastro_basico_tipo_vincendo")
                Call LoadCombo(cboRazaoSocialFilial, "sp_select_combo_cadastro_basico_parceiro_negocio_sga -1")
                Call LoadCombo(cboCNAE, "sp_select_combo_cadastro_basico_cnae")
                Call LoadComboSimNao(cboAtivoVincendo)
                cboAtivoVincendo.SelectedValue = True

            Else

                grdContato.RootTable.Columns("cronograma").Visible = False
                grdContato.RootTable.Columns("financeiro").Visible = False
                grdContato.RootTable.Columns("faturamento").Visible = False
                grdContato.RootTable.Columns("marketing").Visible = False
                grdContato.RootTable.Columns("circular").Visible = False
                grdContato.RootTable.Columns("outros").Visible = False

            End If


            'Carrega Combo - Grid
            Call LoadComboGrid(grdListagem, "vendedor", "sp_select_combo_cadastro_basico_vendedor " & goUsuario.iEmpresa & ", " & goUsuario.iUsuario)
            Call LoadComboGrid(grdListagem, "vendedor_interno", "sp_select_combo_cadastro_basico_vendedor " & goUsuario.iEmpresa & ", " & goUsuario.iUsuario)

            'Verifica Direito
            If VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcUpdate) = False Then
                grdListagem.RootTable.Columns("vendedor").CellStyle.BackColor = Color.Empty
                grdListagem.RootTable.Columns("vendedor").SelectableCells = SelectableCells.FilterRowCells
                grdListagem.RootTable.Columns("vendedor_interno").CellStyle.BackColor = Color.Empty
                grdListagem.RootTable.Columns("vendedor_interno").SelectableCells = SelectableCells.FilterRowCells
            End If

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoParceiroNegocio)
            Call ConfiguraGrid(grdContato, Formulario.CadastroBasicoParceiroNegocio)
            Call ConfiguraGrid(grdEndereco, Formulario.CadastroBasicoParceiroNegocio)
            Call ConfiguraGrid(grdCRM, Formulario.CadastroBasicoParceiroNegocio)
            Call ConfiguraGrid(grdCertificado, Formulario.CadastroBasicoParceiroNegocio)
            Call ConfiguraGrid(grdEspecialidade, Formulario.CadastroBasicoParceiroNegocio)
            Call ConfiguraGrid(grdMarca, Formulario.CadastroBasicoParceiroNegocio)

            'Configura Controles - CalendarCombo
            dtpDataFundacao.Value = Now.Date : dtpDataFundacao.Checked = False
            dtpDataCadastro.Value = Now.Date : dtpDataCadastro.Checked = False

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

            If goDatabase.sInitialCatalog = "INTERACTI_ASCON_PRD" Then
                Dim oFilterCondition As New GridEXFilterCondition(grdListagem.RootTable.Columns("ativo"), ConditionOperator.Equal, True)
                grdListagem.RootTable.FilterCondition = oFilterCondition
                'grdListagem.RootTable.FilterApplied.AddCondition(oFilterCondition)
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

    Private Sub VisualizarImpressao()

        Try

            'Redimensiona Vetor
            ReDim goCrystalReport.sReportParameter(10)

            'Relatório
            goCrystalReport.sReport = goCrystalReport.sPath & "SGA000000006.rpt"


            'Seta Paramentro - Mês
            goCrystalReport.sReportParameter(0).sParamenter = "@codigo_tipo_parceiro_negocio"
            goCrystalReport.sReportParameter(0).sValue = IIf(cboTipoParceiroNegocioFiltro.SelectedIndex = -1, -1, cboTipoParceiroNegocioFiltro.SelectedValue)
            'Seta Paramentro - Ano
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_personalidade"
            goCrystalReport.sReportParameter(1).sValue = IIf(cboPersonalidadeFiltro.SelectedIndex = -1, -1, cboPersonalidadeFiltro.SelectedValue)
            'Seta Paramentro - Código Cliente
            goCrystalReport.sReportParameter(2).sParamenter = "@razao_social"
            goCrystalReport.sReportParameter(2).sValue = txtRazaoSocialFiltro.Text
            'Seta Paramentro - Empresa
            goCrystalReport.sReportParameter(3).sParamenter = "@nome_fantasia"
            goCrystalReport.sReportParameter(3).sValue = txtNomeFantasiaFiltro.Text
            '
            goCrystalReport.sReportParameter(4).sParamenter = "@cnpj_cpf"
            goCrystalReport.sReportParameter(4).sValue = txtCnpjCpfFiltro.Text
            '
            goCrystalReport.sReportParameter(5).sParamenter = "@municipio"
            goCrystalReport.sReportParameter(5).sValue = txtMunicipioFiltro.Text
            '
            goCrystalReport.sReportParameter(6).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(6).sValue = goUsuario.iEmpresa

            goCrystalReport.sReportParameter(7).sParamenter = "@importado"
            goCrystalReport.sReportParameter(7).sValue = IIf(cboImportado.SelectedIndex = -1, "NULL", cboImportado.SelectedValue)
            '
            goCrystalReport.sReportParameter(8).sParamenter = "@ativo"
            goCrystalReport.sReportParameter(8).sValue = IIf(cboAtivoFiltro.SelectedIndex = -1, "NULL", cboAtivoFiltro.SelectedValue)

            goCrystalReport.sReportParameter(9).sParamenter = "@cliente"
            goCrystalReport.sReportParameter(9).sValue = IIf(cboClienteFiltro.SelectedIndex = -1, "NULL", IIf(cboClienteFiltro.SelectedValue = True, 1, 0))
            '
            goCrystalReport.sReportParameter(10).sParamenter = "@fornecedor"
            goCrystalReport.sReportParameter(10).sValue = IIf(cboFornecedorFiltro.SelectedIndex = -1, "NULL", IIf(cboFornecedorFiltro.SelectedValue = True, 1, 0))

            'Abre Relatório
            Dim oReport = New usrReport
            oReport.Dock = DockStyle.Fill
            frmMain.LoadPageReport(goCrystalReport.sReport, Me.Parent.Text, oReport)

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
                oClsCadParceiroNegocio.LoadControlesTrakmaq(iCodigo, _
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
                                                     cboVendedor, _
                                                     cboVendedorInterno, _
                                                     dtpDataFundacao, _
                                                     dtpDataCadastro, _
                                                     txtObservacao, _
                                                     txtTelefone1, _
                                                     txtTelefone2, _
                                                     txtTelefoneRecado, _
                                                     txtFax, _
                                                     txtEmail, _
                                                     cboCondicaoPagamento, _
                                                     cboFormaPagamento, _
                                                     cboMoeda, _
                                                     cboModalidadeFrete, _
                                                     txtCodigoIntegracao, _
                                                     cboEnviarAR, _
                                                     cboDestinacaoPadrao, _
                                                     txtLimiteCredito, _
                                                     txtAvisoTempoCompra, _
                                                     cboInstrucao1, _
                                                     cboInstrucao2, _
                                                     txtNumeroDias1, _
                                                     txtNumeroDias2, _
                                                     cboCondicaoPagamentoFornecedor, _
                                                     cboFormaPagamentoFornecedor, _
                                                     cboMoedaFornecedor, _
                                                     cboModalidadeFreteFornecedor, _
                                                     txtClassificacaoFornecedor, _
                                                     cboTipoNegativacao, _
                                                     dtpDataNegativacao, _
                                                     txtTextoNegativacao, _
                                                     chkCronograma, _
                                                     chkEntregaFisica, _
                                                     chkEntregaEmail, _
                                                     chkPagamentoPontual, _
                                                     txtCodigoProsoft, _
                                                     cboEmpresaContrato)

                Call oClsCadParceiroNegocio.LoadGridContato(grdContato, iCodigo)

                'Carrega Grid de Endereço
                Call oClsCadParceiroNegocio.LoadGridEndereco(grdEndereco, iCodigo)

                'Carrega Grid de CRM
                Call oClsCadParceiroNegocio.LoadGridCRM(grdCRM, iCodigo)

                'Carrega Grid de Certificado
                Call oClsCadParceiroNegocio.LoadGridCertificado(grdCertificado, iCodigo)

                'Carrega Grid de Especialidade
                Call oClsCadParceiroNegocio.LoadGridEspecialidade(grdEspecialidade, iCodigo)

                'Carrega Grid de Marcas
                Call oClsCadParceiroNegocio.LoadGridMarca(grdMarca, iCodigo)

                'Carrega Grid de Cobrança
                Call oClsCadParceiroNegocio.LoadGridCobranca(grdCobranca, iCodigo)

                If goDatabase.sInitialCatalog = "INTERACTI_ASCON_PRD" Then
                    'Carrega Grid de Societario
                    oClsCadParceiroNegocio.LoadGridSocietario(grdSocietario, btnSalvar.Tag, goUsuario.iEmpresa)
                    oClsCadParceiroNegocio.LoadGridVincendo(grdVincendo, btnSalvar.Tag, goUsuario.iEmpresa)
                    Call oClsCadParceiroNegocio.LoadGridSocio(grdSocio, iCodigo, goUsuario.iEmpresa)
                    oClsCadParceiroNegocio.LoadGridFilial(grdFilial, btnSalvar.Tag, goUsuario.iEmpresa)
                    oClsCadParceiroNegocio.LoadGridCNAE(grdCNAE, btnSalvar.Tag, goUsuario.iEmpresa)
                End If

                'Carrega Grid de Arquivos
                Call LoadGridArquivoBD(grdArquivo, "tb_cad_parceiro_negocio", iCodigo)

                tabDados.SelectedTab = pagDadosGerais

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
            txtFax.Text = ""
            txtTelefoneRecado.Text = ""
            txtEmail.Text = ""
            cboVendedor.SelectedIndex = -1 : cboVendedor.Text = ""
            cboVendedorInterno.SelectedIndex = -1 : cboVendedorInterno.Text = ""
            txtObservacao.Text = ""
            dtpDataFundacao.Value = Now.Date : dtpDataFundacao.Checked = False
            dtpDataCadastro.Value = Now.Date : dtpDataCadastro.Checked = False
            chkPagamentoPontual.Checked = True
            cboEmpresaContrato.SelectedIndex = -1

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

            'Limpa Controles - Cliente
            cboCondicaoPagamento.SelectedIndex = -1
            cboFormaPagamento.SelectedIndex = -1
            cboMoeda.SelectedIndex = -1
            cboModalidadeFrete.SelectedIndex = -1
            txtCodigoIntegracao.Text = ""
            txtLimiteCredito.Value = 0
            txtAvisoTempoCompra.Value = 0
            cboInstrucao1.SelectedIndex = -1
            cboInstrucao2.SelectedIndex = -1
            txtNumeroDias1.Value = 0 : txtNumeroDias1.Enabled = False
            txtNumeroDias2.Value = 0 : txtNumeroDias2.Enabled = False
            cboEnviarAR.SelectedIndex = -1
            cboDestinacaoPadrao.SelectedIndex = -1

            'Limpa Controles - Fornecedor
            cboCondicaoPagamentoFornecedor.SelectedIndex = -1
            cboFormaPagamentoFornecedor.SelectedIndex = -1
            cboMoedaFornecedor.SelectedIndex = -1
            cboModalidadeFreteFornecedor.SelectedIndex = -1
            txtClassificacaoFornecedor.Text = ""

            'Limpa Controles - Negativação
            cboTipoNegativacao.SelectedIndex = -1
            dtpDataNegativacao.Value = Now.Date
            txtTextoNegativacao.Text = ""

            'Limpa Controles - CRM
            txtAssuntoCRM.Text = ""
            dtpDataCRM.Value = Now.Date
            btnSalvarCRM.Tag = ""
            grdCRM.DataSource = Nothing

            'Limpa Controles - Certificado
            txtCertificado.Text = ""
            dtpDataEmissaoCertificado.Value = Now.Date
            dtpDataValidadeCertificado.Value = Now.Date : dtpDataValidadeCertificado.Checked = False
            cboTipoArquivoCertificado.SelectedIndex = -1
            txtArquivoCertificado.Text = ""
            btnSalvarCertificado.Tag = ""
            grdCertificado.DataSource = Nothing

            'Limpa Controles - Especialidade
            Call oClsCadParceiroNegocio.LoadGridEspecialidade(grdEspecialidade, -1)

            'Limpa Controles - Marca
            Call oClsCadParceiroNegocio.LoadGridMarca(grdMarca, -1)

            grdSocietario.DataSource = Nothing

            'Desabilita Abas
            If VerificaDireito(Formulario.CadastroBasicoParceiroNegocioContatos, gcSelect) = False Then tabDados.TabPages.Remove(pagContato)
            If VerificaDireito(Formulario.CadastroBasicoParceiroNegocioEnderecos, gcSelect) = False Then tabDados.TabPages.Remove(pagEndereco)
            tabDados.TabPages.Remove(pagDadosCliente)
            tabDados.TabPages.Remove(pagDadosFornecedor)
            tabDados.TabPages.Remove(pagNegativacao)
            tabDados.TabPages.Remove(pagRelacionamento)
            tabDados.TabPages.Remove(pagCertificado)
            tabDados.TabPages.Remove(pagMarca)

            'Desabilita Controles
            chkAgenteLogistico.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioAgenteLogistico, gcInsert)
            chkDespachante.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioDespachante, gcInsert)
            chkCliente.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioCliente, gcInsert)
            chkFornecedor.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioFornecedor, gcInsert)

            txtCPNJFilial.Text = ""
            cboRazaoSocialFilial.SelectedIndex = -1
            grdFilial.DataSource = Nothing
            grdCNAE.DataSource = Nothing

            'Seta Aba
            tabDados.SelectedTab = pagDadosGerais

            'Seta Focu
            cboPersonalidade.Focus()

            Call NovoVincendo()

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
            oClsCadParceiroNegocio.Fax = txtFax.Text
            oClsCadParceiroNegocio.TelefoneRecado = txtTelefoneRecado.Text
            oClsCadParceiroNegocio.CodigoVendedor = IIf(cboVendedor.SelectedIndex = -1, -1, cboVendedor.SelectedValue)
            oClsCadParceiroNegocio.CodigoVendedorInterno = IIf(cboVendedorInterno.SelectedIndex = -1, -1, cboVendedorInterno.SelectedValue)
            oClsCadParceiroNegocio.Observacao = txtObservacao.Text.Trim
            oClsCadParceiroNegocio.DataFundacao = IIf(dtpDataFundacao.Checked = True, dtpDataFundacao.Value, "")
            oClsCadParceiroNegocio.DataCadastro = IIf(dtpDataCadastro.Checked = True, dtpDataCadastro.Value, "")
            oClsCadParceiroNegocio.Ativo = cboAtivo.SelectedValue
            oClsCadParceiroNegocio.CodigoCondicaoPagamento = IIf(cboCondicaoPagamento.SelectedIndex = -1, -1, cboCondicaoPagamento.SelectedValue)
            oClsCadParceiroNegocio.CodigoFormaPagamento = IIf(cboFormaPagamento.SelectedIndex = -1, -1, cboFormaPagamento.SelectedValue)
            oClsCadParceiroNegocio.CodigoMoeda = IIf(cboMoeda.SelectedIndex = -1, -1, cboMoeda.SelectedValue)
            oClsCadParceiroNegocio.CodigoModalidadeFrete = IIf(cboModalidadeFrete.SelectedIndex = -1, -1, cboModalidadeFrete.SelectedValue)
            oClsCadParceiroNegocio.CodigoIntegracao = txtCodigoIntegracao.Text.Trim
            oClsCadParceiroNegocio.EnviarAR = IIf(cboEnviarAR.SelectedIndex = -1, -1, IIf(cboEnviarAR.SelectedValue = True, 1, 0))
            oClsCadParceiroNegocio.CodigoDestinacao = IIf(cboDestinacaoPadrao.SelectedIndex = -1, -1, cboDestinacaoPadrao.SelectedValue)
            oClsCadParceiroNegocio.LimiteCredito = txtLimiteCredito.Value
            oClsCadParceiroNegocio.AvisoTempoCompra = txtAvisoTempoCompra.Value
            oClsCadParceiroNegocio.CodigoInstrucaoCobranca1 = IIf(cboInstrucao1.SelectedIndex = -1, -1, cboInstrucao1.SelectedValue)
            oClsCadParceiroNegocio.CodigoInstrucaoCobranca2 = IIf(cboInstrucao2.SelectedIndex = -1, -1, cboInstrucao2.SelectedValue)
            oClsCadParceiroNegocio.NumeroDias1 = IIf(txtNumeroDias1.Enabled = False, -1, txtNumeroDias1.Value)
            oClsCadParceiroNegocio.NumeroDias2 = IIf(txtNumeroDias2.Enabled = False, -1, txtNumeroDias2.Value)
            oClsCadParceiroNegocio.CodigoCondicaoPagamentoFornecedor = IIf(cboCondicaoPagamentoFornecedor.SelectedIndex = -1, -1, cboCondicaoPagamentoFornecedor.SelectedValue)
            oClsCadParceiroNegocio.CodigoFormaPagamentoFornecedor = IIf(cboFormaPagamentoFornecedor.SelectedIndex = -1, -1, cboFormaPagamentoFornecedor.SelectedValue)
            oClsCadParceiroNegocio.CodigoMoedaFornecedor = IIf(cboMoedaFornecedor.SelectedIndex = -1, -1, cboMoedaFornecedor.SelectedValue)
            oClsCadParceiroNegocio.CodigoModalidadeFreteFornecedor = IIf(cboModalidadeFreteFornecedor.SelectedIndex = -1, -1, cboModalidadeFreteFornecedor.SelectedValue)
            oClsCadParceiroNegocio.ClassificacaoFornecedor = txtClassificacaoFornecedor.Text.Trim
            oClsCadParceiroNegocio.CodigoTipoNegativacao = IIf(cboTipoNegativacao.SelectedIndex = -1, -1, cboTipoNegativacao.SelectedValue)
            oClsCadParceiroNegocio.DataNegativacao = IIf(cboTipoNegativacao.SelectedIndex = -1, "", dtpDataNegativacao.Value)
            oClsCadParceiroNegocio.TextoNegativacao = IIf(cboTipoNegativacao.SelectedIndex = -1, "", txtTextoNegativacao.Text.Trim)
            oClsCadParceiroNegocio.Cronograma = chkCronograma.Checked
            oClsCadParceiroNegocio.EntregaFisica = chkEntregaFisica.Checked
            oClsCadParceiroNegocio.EntregaEmail = chkEntregaEmail.Checked
            oClsCadParceiroNegocio.PagamentoPontual = chkPagamentoPontual.Checked
            oClsCadParceiroNegocio.CodigoProsoft = txtCodigoProsoft.Text.Trim
            oClsCadParceiroNegocio.CodigoEmpresaContrato = IIf(cboEmpresaContrato.SelectedIndex = -1, -1, cboEmpresaContrato.SelectedValue)
            'Verifica o Tipo de Operação
            If IsNumeric(btnSalvar.Tag) Then
                Dim sAlteracao As String = ""
                oClsCadParceiroNegocio.Update()
                oClsCadParceiroNegocio.DeleteEspecialidade()
                oClsCadParceiroNegocio.InsertEspecialidade(grdEspecialidade)
                oClsCadParceiroNegocio.DeleteMarca()
                oClsCadParceiroNegocio.InsertMarca(grdMarca)
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                oClsCadParceiroNegocio.Insert()
                btnSalvar.Tag = oClsCadParceiroNegocio.Codigo
                oClsCadParceiroNegocio.InsertEspecialidade(grdEspecialidade)
                oClsCadParceiroNegocio.InsertMarca(grdMarca)
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

            'If cboAtivo.SelectedValue = True Then
            '    grdListagem.RemoveFilters()
            'End If

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
                                            IIf(cboImportado.SelectedIndex = -1, -1, IIf(cboImportado.SelectedValue = True, 1, 0)), _
                                            IIf(cboClienteFiltro.SelectedIndex = -1, -1, IIf(cboClienteFiltro.SelectedValue = True, 1, 0)), _
                                            IIf(cboFornecedorFiltro.SelectedIndex = -1, -1, IIf(cboFornecedorFiltro.SelectedValue = True, 1, 0)), _
                                            IIf(cboAtivoFiltro.SelectedIndex = -1, -1, IIf(cboAtivoFiltro.SelectedValue = True, 1, 0)))

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

            If goDatabase.sInitialCatalog = "INTERACTI_ASCON_PRD" Then
                If txtNomeFantasia.Text = "" Then
                    txtNomeFantasia.Text = txtRazaoSocial.Text
                End If

                If dtpDataFundacao.Checked = False Then
                    If cboPersonalidade.SelectedValue = 1 Then
                        If MsgBox("A Data de Fundação não está preenchida, deseja continuar?", MsgBoxStyle.YesNo, "Validação") = MsgBoxResult.No Then
                            Exit Function
                        End If
                    End If
                End If
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

            If goUsuario.iEmpresa <> 6 Then

                'Verifica se foi Preenchido o Campo - CEP
                If ValidaCampo(txtCEP, lblCEP, TipoCampo.texto) = False Then
                    tabDados.SelectedTab = pagDadosGerais : txtCEP.Focus() : Exit Function
                End If

                'Verifica se foi Selecionado o Campo - País
                If ValidaCampo(cboPais, lblPais) = False Then
                    tabDados.SelectedTab = pagDadosGerais : cboPais.Focus() : Exit Function
                End If

                'Verifica se foi Selecionado o Campo - UF
                If ValidaCampo(cboUF, lblUF) = False Then
                    tabDados.SelectedTab = pagDadosGerais : cboUF.Focus() : Exit Function
                End If

                'Verifica se foi Selecionado o Campo - Município
                If cboUF.SelectedValue <> gcUFExterior Then
                    If ValidaCampo(cboMunicipio, lblMunicipio) = False Then
                        tabDados.SelectedTab = pagDadosGerais : cboMunicipio.Focus() : Exit Function
                    End If
                End If

                'Verifica se foi Preenchido o Campo - Logradouro
                If ValidaCampo(txtLogradouro, lblLogradouro, TipoCampo.texto) = False Then
                    tabDados.SelectedTab = pagDadosGerais : txtLogradouro.Focus() : Exit Function
                End If

                'Verifica se foi Preenchido o Campo - Número
                If ValidaCampo(txtNumero, lblNumero, TipoCampo.texto) = False Then
                    tabDados.SelectedTab = pagDadosGerais : txtNumero.Focus() : Exit Function
                End If

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

                If goDatabase.sInitialCatalog <> "INTERACTI_ASCON_PRD" Then
                    If cboPersonalidade.Text <> "FÍSICA" Then

                        'Verifica se foi Selecionado o Campo - Tipo de Inscrição Estadual
                        If ValidaCampo(cboTipoInscricaoEstadual, lblTipoInscricaoEstadual) = False Then
                            tabDados.SelectedTab = pagDadosGerais : cboTipoInscricaoEstadual.Focus() : Exit Function
                        End If

                        'Verifica se foi Preenchido o Campo - IE
                        If txtInscricaoEstadual.Text.Trim <> "" Then

                            If ValidaCampo(txtInscricaoEstadual, lblInscricaoEstadual, TipoCampo.texto) = False Then
                                tabDados.SelectedTab = pagDadosGerais : txtInscricaoEstadual.Focus() : Exit Function
                            End If

                            'Verifica se a IE é válida
                            If cboPersonalidade.SelectedValue = Personalidade.Juridica Then
                                If ValidaIE(cboUF.SelectedValue, txtInscricaoEstadual.Text.Trim) = False Then
                                    frmMain.errInfo.SetError(lblInscricaoEstadual, "Esta Inscrição Estadual não é válido!")
                                    tabDados.SelectedTab = pagDadosGerais : txtInscricaoEstadual.Focus() : Exit Function
                                End If
                            End If

                        End If

                    End If
                End If



                If cboTipoNegativacao.SelectedIndex <> -1 AndAlso cboTipoNegativacao.SelectedValue <> CInt(TipoNegativacaoCliente.Liberado) Then

                    'Verifca se o Usuário Deseja Negativar o Cliente
                    If MsgBox(IIf(cboTipoNegativacao.SelectedValue = CInt(TipoNegativacaoCliente.BloquearCliente), "Deseja Bloquear o Cliente do Cliente: ", "Deseja Alertar o Vendedor sobre pendências do Cliente: ") & txtRazaoSocial.Text.Trim & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        'Verifica se foi Preenchido o Campo - Texto de Negativação
                        If ValidaCampo(txtTextoNegativacao, lblTextoNegativacao, TipoCampo.texto) = False Then
                            tabDados.SelectedTab = pagNegativacao : txtTextoNegativacao.Focus() : Exit Function
                        End If
                    Else
                        'Limpa Controles
                        cboTipoNegativacao.SelectedIndex = -1
                        dtpDataNegativacao.Value = Now.Date
                        txtTextoNegativacao.Text = ""
                    End If

                End If

                'Verifica se foi Preenchido o Campo - Número de Dias 1
                If txtNumeroDias1.Enabled = True Then
                    If ValidaCampo(txtNumeroDias1, lblNumeroDias1, True) = False Then
                        tabDados.SelectedTab = pagDadosCliente
                        txtNumeroDias1.Focus()
                        Exit Function
                    End If
                End If

                'Verifica se foi Selecionado o Campo - Instrução 1
                If cboInstrucao1.SelectedIndex <> -1 Then
                    'Verifica se foi Selecionado o Campo - Instrução 2
                    If ValidaCampo(cboInstrucao2, lblInstrucao2) = False Then
                        tabDados.SelectedTab = pagDadosCliente
                        cboInstrucao2.Focus()
                        Exit Function
                    End If
                End If

                'Verifica se foi Preenchido o Campo - Número de Dias 2
                If txtNumeroDias2.Enabled = True Then
                    If ValidaCampo(txtNumeroDias2, lblNumeroDias2, True) = False Then
                        tabDados.SelectedTab = pagDadosCliente
                        txtNumeroDias2.Focus()
                        Exit Function
                    End If
                End If
            End If


            'Verifica se foi Preenchido Corretamente o Campo - Email
            'If txtEmail.Text.Trim <> "" Then
            '    If ValidaCampo(txtEmail, lblEmail, TipoCampo.email) = False Then
            '        tabDados.SelectedTab = pagDadosGerais : txtEmail.Focus() : Exit Function
            '    End If
            'End If

            'Verifica se foi Preenchido o Campo - CNPJ / CPF




            'Verifica se foi Selcionado o Campo - Tipo de Negativação


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

    Private Sub AlterarEmpresa()
        Try
            Dim oForm As New frmFindEmpresa

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            oClsCadParceiroNegocio.AlterarEmpresa(oForm.CodigoEmpresaNova, txtCodigoIntegracao.Text)


            Call Novo()

            frmMain.Informacao("Empresa alterada com sucesso!", Color.Gray)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub InserirSocios(ByVal iCodigoParceiroNegocio As Integer, Optional ByVal iCodigo As Integer = -1)
        Try
            Dim oForm As New frmCadParceiroNegocioSocios
            oForm.CodigoParceiroNegocio = iCodigoParceiroNegocio
            oForm.Codigo = iCodigo

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            frmMain.Informacao("Sócio inserido com sucesso!", Color.Gray)
            oClsCadParceiroNegocio.LoadGridSocio(grdSocio, btnSalvar.Tag, goUsuario.iEmpresa)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub InativarSocio(ByVal iCodigoParceiroNegocio As Integer, Optional ByVal iCodigo As Integer = -1)
        Try
            Dim oForm As New frmCadParceiroNegocioSociosInativar
            oForm.CodigoParceiroNegocio = iCodigoParceiroNegocio
            oForm.Codigo = iCodigo

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            frmMain.Informacao("Sócio inserido com sucesso!", Color.Gray)
            oClsCadParceiroNegocio.LoadGridSocio(grdSocio, btnSalvar.Tag, goUsuario.iEmpresa)

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
            chkCronogram.Checked = False
            chkFinanceiro.Checked = False
            chkFaturamento.Checked = False
            chkMarketing.Checked = False
            chkCircular.Checked = False
            chkOutros.Checked = False

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
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub EditarContato()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoParceiroNegocioContatos, gcUpdate) = True Then

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
                    chkCronogram.Checked = .Item("cronograma").Value
                    chkFinanceiro.Checked = .Item("financeiro").Value
                    chkFaturamento.Checked = .Item("faturamento").Value
                    chkCircular.Checked = .Item("circular").Value
                    chkMarketing.Checked = .Item("marketing").Value
                    chkOutros.Checked = .Item("outros").Value

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
            'If txtTelefoneContato.Text.Trim = "" And txtCelularContato.Text.Trim = "" Then
            '    frmMain.errInfo.SetError(lblTelefoneContato, "O Campo [Telefone ou Celular] é obrigatório. Digite um valor para ele.")
            '    txtTelefoneContato.Focus()
            '    Exit Function
            'End If

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
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & iif(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Deleta Contato
                    oClsCadParceiroNegocio.Codigo = btnSalvar.Tag
                    oClsCadParceiroNegocio.DeleteContato()

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
            If VerificaDireito(Formulario.CadastroBasicoParceiroNegocioEnderecos, gcUpdate) = True Then

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
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & iif(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Deleta Endereço
                    oClsCadParceiroNegocio.Codigo = btnSalvar.Tag
                    oClsCadParceiroNegocio.DeleteEndereco()

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

#Region "::: CRM :::"

    Private Sub NovoCRM()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            txtAssuntoCRM.Text = ""
            dtpDataCRM.Value = Now.Date
            btnSalvarCRM.Tag = ""

            'Seta Focu
            txtAssuntoCRM.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarCRM()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoParceiroNegocioClienteCRM, gcUpdate) = True Then

                With grdCRM.CurrentRow.Cells

                    'Limpa Controles
                    Call NovoCRM()

                    'Carrega Controles
                    txtAssuntoCRM.Text = .Item("assunto").Value
                    dtpDataCRM.Value = .Item("data").Value
                    btnSalvarCRM.Tag = .Item("codigo").Value

                    'Seta Focu
                    txtAssuntoCRM.Focus()

                End With

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoCRM() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoCRM = False

            'Verifica se foi Preenchido o Campo - Assunto
            If ValidaCampo(txtAssuntoCRM, lblAssuntoCRM, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoCRM = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub DeleteCRM()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdCRM) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & iif(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Deleta Contato
                    oClsCadParceiroNegocio.Codigo = btnSalvar.Tag
                    oClsCadParceiroNegocio.DeleteCRM()

                    'Limpa Formulário
                    Call NovoCRM()

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

#Region "::: COMENTÁRIOS :::"

    Private Sub ComentarioCRM()

        Try

            'Verifica se o Usuário tem Direito
            If VerificaDireito(Formulario.CadastroBasicoParceiroNegocioClienteCRM, gcInsert) = False Then
                frmMain.Informacao(Mensagem.DireitoInserir)
                Exit Sub
            End If

            'Váriaveis Locais
            Dim oForm As New frmCadParceiroNegocioCRMComentarioInserir
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location
            'Seta Parâmetros
            oForm.Cliente = txtRazaoSocial.Text.Trim
            oForm.Assunto = grdCRM.CurrentRow.Cells("assunto").Value
            oForm.Codigo = btnSalvar.Tag
            oForm.CodigoCRM = grdCRM.CurrentRow.Cells("codigo").Value

            'Abre Formulário
            oForm.ShowDialog(Me)

            'Carrega Grid
            Call oClsCadParceiroNegocio.LoadGridCRM(grdCRM, _
                                                    btnSalvar.Tag)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub HistoricoCRM()

        Try

            'Verifica se o Usuário tem Direito
            If VerificaDireito(Formulario.CadastroBasicoParceiroNegocioClienteCRM, gcSelect) = False Then
                frmMain.Informacao(Mensagem.DireitoVisualizar)
                Exit Sub
            End If

            'Váriaveis Locais
            Dim oForm As New frmCadParceiroNegocioCRMComentario
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location
            'Seta Parâmetros
            oForm.Cliente = txtRazaoSocial.Text.Trim
            oForm.Assunto = grdCRM.CurrentRow.Cells("assunto").Value
            oForm.Codigo = btnSalvar.Tag
            oForm.CodigoCRM = grdCRM.CurrentRow.Cells("codigo").Value

            'Abre Formulário
            oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

#Region "::: CERTIFICADO :::"

    Private Sub NovoCertificado()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            txtCertificado.Text = ""
            dtpDataEmissaoCertificado.Value = Now.Date
            dtpDataValidadeCertificado.Value = Now.Date : dtpDataValidadeCertificado.Checked = False
            cboTipoArquivoCertificado.SelectedIndex = -1
            txtArquivoCertificado.Text = ""
            btnSalvarCertificado.Tag = ""

            'Seta Focu
            txtCertificado.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarCertificado()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoParceiroNegocioFornecedorCertificados, gcUpdate) = True Then

                With grdCertificado.CurrentRow.Cells

                    'Limpa Controles
                    Call NovoCertificado()

                    'Carrega Controles
                    txtCertificado.Text = .Item("certificado").Value
                    dtpDataEmissaoCertificado.Value = .Item("data_emissao").Value
                    If IsDBNull(.Item("data_validade").Value) = False Then dtpDataValidadeCertificado.Value = .Item("data_validade").Value : dtpDataValidadeCertificado.Checked = True
                    cboTipoArquivoCertificado.SelectedValue = .Item("codigo_tipo_arquivo").Value
                    txtArquivoCertificado.Text = ""
                    btnSalvarCertificado.Tag = .Item("codigo").Value

                    'Seta Focu
                    txtCertificado.Focus()

                End With

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoCertificado() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoCertificado = False

            'Verifica se foi Preenchido o Campo - Certificado
            If ValidaCampo(txtCertificado, lblCertificado, TipoCampo.texto) = False Then
                Exit Function
            End If
            If ValidaCampo(cboTipoArquivo, lblTipoArquivo) = False Then
                Exit Function
            End If
            If ValidaCampo(txtArquivoCertificado, lblArquivoCertificado, TipoCampo.texto) = False Then
                Exit Function
            End If
            'Seta Retorno da Função
            ValidacaoCertificado = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub DeleteCertificado()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdCertificado) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & iif(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Deleta Contato
                    oClsCadParceiroNegocio.Codigo = btnSalvar.Tag
                    oClsCadParceiroNegocio.DeleteCertificado()

                    'Limpa Formulário
                    Call NovoCertificado()

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

#Region "::: ARQUIVO :::"

    Private Sub DeleteArquivo()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdArquivo) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & iif(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    For Each oRow As GridEXRow In gSelecaoRow
                        modFunction.DeleteArquivoBD("tb_cad_parceiro_negocio", oRow.Cells("path").Value, btnSalvar.Tag)
                    Next

                    'Carrega Grid
                    Call LoadGridArquivoBD(grdArquivo, "tb_cad_parceiro_negocio", btnSalvar.Tag)

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
            If VerificaDireito(Formulario.CadastroBasicoProduto, gcUpdate) = True Then

                'Limpa Formulário
                Call NovoArquivo()

                'Carrega Controles
                txtDescricaoArquivo.Text = grdArquivo.CurrentRow.Cells("descricao").Value
                txtRevisaoArquivo.Text = grdArquivo.CurrentRow.Cells("revisao").Value
                cboTipoArquivo.SelectedValue = grdArquivo.CurrentRow.Cells("codigo_tipo_arquivo").Value
                txtArquivo.Text = grdArquivo.CurrentRow.Cells("path").Value
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

#Region "::: COBRANÇA :::"

    Private Sub NovoCobranca()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles

            dtpDataCobranca.Value = Now.Date
            txtResponsavelCobranca.Text = ""
            txtTelefoneContatoCobranca.Text = ""
            txtHistoricoCobranca.Text = ""
            btnInserirCobranca.Tag = ""
            txtContatoCobranca.Text = ""

            'Seta Focu
            dtpDataCobranca.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarCobranca()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcUpdate) = True Then

                With grdCobranca.CurrentRow.Cells

                    'Limpa Controles
                    Call NovoCobranca()

                    'Carrega Controles
                    dtpDataCobranca.Value = .Item("data_cobranca").Value
                    txtResponsavelCobranca.Text = .Item("responsavel_cobranca").Value
                    txtContatoCobranca.Text = .Item("contato").Value
                    txtTelefoneContato.Text = .Item("telefone_contato").Value
                    txtHistoricoCobranca.Text = .Item("historico").Value
                    btnInserirCobranca.Tag = .Item("codigo").Value

                    'Seta Focu
                    dtpDataCobranca.Focus()

                End With

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteCobranca()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdCobranca) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & iif(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Deleta Endereço
                    Call oClsCadParceiroNegocio.DeleteCobranca(btnSalvar.Tag)

                    'Limpa Formulário
                    Call NovoCobranca()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                MsgBox("Primeiramente Selecione um ou mais Registros.", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoCobranca() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoCobranca = False

            'Verifica se foi Preenchido o Campo - Responsavel Cobranca
            If ValidaCampo(txtResponsavelCobranca, lblResponsavelCobrança, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Histórico
            If ValidaCampo(txtHistoricoCobranca, lblHistoricoCobranca, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoCobranca = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: SOCIETÁRIO :::"
    Private Sub SalvarArquivoSocietario()

        Try


            If CStr(btnInserirSocietario.Tag) <> "" Then
                oClsCadParceiroNegocio.UpdateSocientario(btnInserirSocietario.Tag, _
                                                         btnSalvar.Tag, _
                                                         cboTipoDocumento.SelectedValue, _
                                                         txtDescricaoSocietario.Text, _
                                                         IIf(dtpDataAssinaturaSocietario.Checked = True, dtpDataAssinaturaSocietario.Value, ""), _
                                                         IIf(dtpDataRegistroSocietario.Checked = True, dtpDataRegistroSocietario.Value, ""), _
                                                         txtNumeroRegistroSocietario.Text, _
                                                         txtResumoSocietario.Text, _
                                                         txtArquivoSocietario.Text, _
                                                         goUsuario.iEmpresa)
            Else
                oClsCadParceiroNegocio.InsertSocietario(btnSalvar.Tag, _
                                                         cboTipoDocumento.SelectedValue, _
                                                         txtDescricaoSocietario.Text, _
                                                         IIf(dtpDataAssinaturaSocietario.Checked = True, dtpDataAssinaturaSocietario.Value, ""), _
                                                         IIf(dtpDataRegistroSocietario.Checked = True, dtpDataRegistroSocietario.Value, ""), _
                                                         txtNumeroRegistroSocietario.Text, _
                                                         txtResumoSocietario.Text, _
                                                         txtArquivoSocietario.Text, _
                                                         goUsuario.iEmpresa)
            End If



            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Private Sub NovoSocietario()
        Try
            cboTipoDocumento.SelectedIndex = -1
            txtDescricaoSocietario.Text = ""
            dtpDataAssinaturaSocietario.Value = Now.Date : dtpDataAssinaturaSocietario.Checked = True
            dtpDataRegistroSocietario.Value = Now.Date : dtpDataRegistroSocietario.Checked = True
            txtNumeroRegistroSocietario.Text = ""
            txtResumoSocietario.Text = ""
            btnInserirSocietario.Tag = ""
            txtArquivo.Text = ""

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub EmailSocietario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor


            'Enviar E-mail
            Call SendEmailOutlook("", "", "", grdSocietario.CurrentRow.Cells.Item("tipo_documento").Value, "", _
                                  grdSocietario.CurrentRow.Cells.Item("arquivo").Value, False, "")


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub VisualizarArquivoSocietario()

        Try

            'Verifica se existe Arquivo
            If IsDBNull(grdSocietario.CurrentRow.Cells("arquivo").Value) = False Then

                If System.IO.File.Exists(grdSocietario.CurrentRow.Cells("arquivo").Value) = True Then

                    'Abre o Arquivo
                    Dim oProcess As New Process
                    oProcess.Start(grdSocietario.CurrentRow.Cells("arquivo").Value)

                Else
                    'Informa o Usuário que o Arquivo associado não é válido
                    frmMain.Informacao("Arquivo não encontrado!", Color.Red)
                End If

            Else
                'Informa o Usuário que não existe Arquivo associado ao Registro
                frmMain.Informacao("Arquivo não informado!", Color.Red)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Private Sub EditarSocietario()

        Try
            With grdSocietario.CurrentRow.Cells

                'Verifica se pode salvar
                'btnSalvar.Enabled = VerificaDireito(Me.Name, gcAdministrator, False) Or txtSolicitante.Text = goUsuario.sNome
                If IsDBNull(.Item("codigo_sga_ordem_servico").Value) Then


                    'Seta Controles
                    btnInserirSocietario.Tag = .Item("codigo").Value
                    cboTipoDocumento.SelectedValue = .Item("codigo_tipo_documento").Value
                    txtDescricaoSocietario.Text = .Item("descricao").Value
                    If IsDBNull(.Item("data_assinatura").Value) Then
                        dtpDataAssinaturaSocietario.Checked = False : dtpDataAssinaturaSocietario.Value = Now.Date
                    Else
                        dtpDataAssinaturaSocietario.Checked = True : dtpDataAssinaturaSocietario.Value = .Item("data_assinatura").Value
                    End If
                    If IsDBNull(.Item("data_registro").Value) Then
                        dtpDataRegistroSocietario.Checked = False : dtpDataRegistroSocietario.Value = Now.Date
                    Else
                        dtpDataRegistroSocietario.Checked = True : dtpDataRegistroSocietario.Value = .Item("data_registro").Value
                    End If
                    txtNumeroRegistroSocietario.Text = .Item("numero_registro").Value
                    txtResumoSocietario.Text = .Item("resumo").Value
                    txtArquivoSocietario.Text = .Item("arquivo").Value
                Else
                    frmMain.Informacao("A edição desse resgitro não pode ser realizada por esse módulo!", Color.Gray)
                End If

            End With
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Private Sub DeleteSocietario()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdSocietario) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCadParceiroNegocio.DeleteSocietario()
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
#End Region

#Region "::: VINCENDO :::"
    Private Sub VisualizarArquivoVincendo()

        Try

            'Verifica se existe Arquivo
            If IsDBNull(grdVincendo.CurrentRow.Cells("arquivo").Value) = False Then

                If System.IO.File.Exists(grdVincendo.CurrentRow.Cells("arquivo").Value) = True Then

                    'Abre o Arquivo
                    Dim oProcess As New Process
                    oProcess.Start(grdVincendo.CurrentRow.Cells("arquivo").Value)

                Else
                    'Informa o Usuário que o Arquivo associado não é válido
                    frmMain.Informacao("Arquivo não encontrado!", Color.Red)
                End If

            Else
                'Informa o Usuário que não existe Arquivo associado ao Registro
                frmMain.Informacao("Arquivo não informado!", Color.Red)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Private Sub EditarVincendo()

        Try
            With grdVincendo.CurrentRow.Cells


                'Seta Controles
                btnInserirVincendo.Tag = .Item("codigo").Value
                cboTipoVincendo.SelectedValue = .Item("codigo_tipo_vincendo").Value
                txtDescricaoVincendo.Text = .Item("descricao").Value
                If IsDBNull(.Item("data_assinatura").Value) Then
                    dtpDataAssinaturaVincendo.Checked = False : dtpDataAssinaturaVincendo.Value = Now.Date
                Else
                    dtpDataAssinaturaVincendo.Checked = True : dtpDataAssinaturaVincendo.Value = .Item("data_assinatura").Value
                End If
                If IsDBNull(.Item("data_vencimento").Value) Then
                    dtpDataVencimentoVincendo.Checked = False : dtpDataVencimentoVincendo.Value = Now.Date
                Else
                    dtpDataVencimentoVincendo.Checked = True : dtpDataVencimentoVincendo.Value = .Item("data_vencimento").Value
                End If
                cboAtivoVincendo.SelectedValue = .Item("ativo").Value
                txtArquivoVincendo.Text = .Item("arquivo").Value


            End With
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Private Sub SalvarVincendo()

        Try


            If CStr(btnInserirVincendo.Tag) <> "" Then
                oClsCadParceiroNegocio.UpdateVincendo(btnInserirVincendo.Tag, _
                                                         btnSalvar.Tag, _
                                                         cboTipoVincendo.SelectedValue, _
                                                         txtDescricaoVincendo.Text, _
                                                         IIf(dtpDataAssinaturaVincendo.Checked = True, dtpDataAssinaturaVincendo.Value, ""), _
                                                         IIf(dtpDataVencimentoVincendo.Checked = True, dtpDataVencimentoVincendo.Value, ""), _
                                                         txtArquivoVincendo.Text, _
                                                         cboAtivoVincendo.SelectedValue, _
                                                         goUsuario.iEmpresa, chkRenovado.Checked, "", "")
            Else
                oClsCadParceiroNegocio.InsertVincendo(btnSalvar.Tag, _
                                                         cboTipoVincendo.SelectedValue, _
                                                         txtDescricaoVincendo.Text, _
                                                         IIf(dtpDataAssinaturaVincendo.Checked = True, dtpDataAssinaturaVincendo.Value, ""), _
                                                         IIf(dtpDataVencimentoVincendo.Checked = True, dtpDataVencimentoVincendo.Value, ""), _
                                                         txtArquivoVincendo.Text, _
                                                         cboAtivoVincendo.SelectedValue, _
                                                         goUsuario.iEmpresa, chkRenovado.Checked, "", "")
            End If



            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Private Sub NovoVincendo()
        Try
            cboTipoVincendo.SelectedIndex = -1
            txtDescricaoVincendo.Text = ""
            dtpDataAssinaturaVincendo.Value = Now.Date : dtpDataAssinaturaVincendo.Checked = True
            dtpDataVencimentoVincendo.Value = Now.Date : dtpDataVencimentoVincendo.Checked = True
            cboAtivoVincendo.SelectedValue = True
            btnInserirVincendo.Tag = ""
            txtArquivoVincendo.Text = ""

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub DeleteVincendo()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdVincendo) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCadParceiroNegocio.DeleteVincendo()

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
#End Region

#Region "::: FILIAL :::"

    Private Sub SalvarFilial()

        Try


            oClsCadParceiroNegocio.InsertFilial(btnSalvar.Tag, cboRazaoSocialFilial.SelectedValue)


            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteFilial()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdFilial) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCadParceiroNegocio.DeleteFilial(btnSalvar.Tag)

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

#End Region

#Region "::: CNAE :::"
    Private Sub SalvarCNAE()

        Try


            oClsCadParceiroNegocio.InsertCNAE(btnSalvar.Tag, cboCNAE.SelectedValue)


            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteCNAE()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdCNAE) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCadParceiroNegocio.DeleteCNAE(btnSalvar.Tag)

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
#End Region

#End Region

    
    

   
   
End Class

