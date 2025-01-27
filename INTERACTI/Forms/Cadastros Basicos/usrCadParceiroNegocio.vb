Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls
Imports Janus.Windows.Common
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Imports INTERACTI.modDeclaration

Public Class usrCadParceiroNegocio

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadParceiroNegocio As New clsUsrCadParceiroNegocio
    Private iCodigoParceiro As Integer
    Private iFormulario As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoParceiro() As Integer
        Get
            Return iCodigoParceiro
        End Get
        Set(ByVal value As Integer)
            iCodigoParceiro = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrCadParceiroNegocio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

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
                        Case "cboCentroCusto" : Call btnProcurarCentroCusto_Click(btnProcurarCentroCusto, System.EventArgs.Empty)
                        Case "cboContaContabil" : Call btnProcurarContaContabil_Click(btnProcurarContaContabil, System.EventArgs.Empty)
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
                        Case "cboCampanha" : Call LoadCombo(cboCampanha, "sp_select_combo_cadastro_basico_campanha_abrangencia " & goUsuario.iEmpresa)
                        Case "cboCentroCusto" : Call LoadCombo(cboCentroCusto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa, True)
                        Case "cboContaContabil" : Call LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa, True)
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
                        Case "cboVendedorInterno" : Call btnCadastrarVendedorInterno_Click(btnCadastrarVendedorInterno, System.EventArgs.Empty)
                        Case "cboCampanha" : Call btnCadastrarCampanha_Click(btnCadastrarCampanha, System.EventArgs.Empty)
                        Case "cboCentroCusto" : Call btnCadastrarCentroCusto_Click(btnCadastrarCentroCusto, System.EventArgs.Empty)
                        Case "cboContaContabil" : Call btnCadastrarContaContabil_Click(btnCadastrarContaContabil, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadParceiroNegocio_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnProcurarCEPAcompanhante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCEPAcompanhante.Click
        Try

            'Verifica se foi preenchido o CEP
            If txtCEPaAcompanhante.Text.Replace("-", "").Trim.Length = 8 Then

                'Verifica se há o cep no banco de dados
                ProcuraCep(CLng(Replace(txtCEPaAcompanhante.Text.Trim, "-", "")),
                           cboPaisAcompanhante,
                           cboUFAcompanhante,
                           cboMunicipioAcompanhante,
                           txtBairroAcompanhante,
                           txtLogradouroAcompanhante,
                           txtComplementoAcompanhante)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboUFAcompanhante_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboUFAcompanhante.SelectedIndexChanged
        Try
            If cboUFAcompanhante.SelectedIndex = -1 Then Exit Sub

            Call LoadCombo(cboMunicipioAcompanhante, "sp_select_combo_static_municipio '" & cboUFAcompanhante.SelectedValue & "'")
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboPaisAcompanhante_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPaisAcompanhante.SelectedIndexChanged
        Try
            If cboPaisAcompanhante.SelectedIndex = -1 Then Exit Sub

            Call LoadCombo(cboUFAcompanhante, "sp_select_combo_static_estado_pais " & cboPaisAcompanhante.SelectedValue)
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnCadastrarPaisAcompanhante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarPaisAcompanhante.Click
        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrCadPais"
            oForm.Titulo = Me.Parent.Text
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Carrega Combo
            Call LoadCombo(cboPais, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)
            Call LoadCombo(cboPaisEndereco, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)
            Call LoadCombo(cboPaisAcompanhante, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)
            'Seta Focu
            cboPais.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
#End Region

#Region "::: PARCEIRO DE NEGÓCIO :::"

    Private Sub cboIncidePisCofins_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboIncidePisCofins.SelectedIndexChanged

        Try

            txtAliquotaPIS.Value = 0 : txtAliquotaPIS.Enabled = False
            txtAliquotaCOFINS.Value = 0 : txtAliquotaCOFINS.Enabled = False

            If cboIncidePisCofins.SelectedValue = True Then
                txtAliquotaPIS.Enabled = True
                txtAliquotaCOFINS.Enabled = True
            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub chkCelular_CheckedChanged(sender As Object, e As EventArgs) Handles chkCelular.CheckedChanged

        If chkCelular.Checked = True Then
            txtTelefone1.Mask = "!(##) 00000-0000"
            lblTelefone1.Text = "Telefone Celular1:"
        Else
            txtTelefone1.Mask = "!(##) 0000-0000"
            lblTelefone1.Text = "Telefone1:"
        End If

    End Sub

    Private Sub chkCelular2_CheckedChanged(sender As Object, e As EventArgs) Handles chkCelular2.CheckedChanged

        If chkCelular2.Checked = True Then
            txtTelefone2.Mask = "!(##) 00000-0000"
            lblTelefone2.Text = "Telefone Celular2:"
        Else
            txtTelefone2.Mask = "!(##) 0000-0000"
            lblTelefone2.Text = "Telefone 2:"
        End If

    End Sub

    Private Sub btnCadastrarSegmento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarSegmento.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrCadParceiroNegocioSegmento"
            oForm.Titulo = Me.Parent.Text
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

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
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrCadPais"
            oForm.Titulo = Me.Parent.Text
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

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
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrCadPais"
            oForm.Titulo = Me.Parent.Text
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

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
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrCadVendedor"
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location : oForm.Tamanho = True
            oForm.Titulo = Me.Parent.Text
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

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
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrCadVendedor"
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location : oForm.Tamanho = True
            oForm.Titulo = Me.Parent.Text
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

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
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrCadCondicaoPagamento"
            oForm.Titulo = Me.Parent.Text
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Carrega Combo
            Call LoadCombo(cboCondicaoPagamento, "sp_select_combo_cadastro_basico_condicao_pagamento " & goUsuario.iEmpresa)
            'Seta Focu
            cboCondicaoPagamento.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarCampanha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCampanha.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrCadCampanhaAbrangencia"
            oForm.Titulo = Me.Parent.Text
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Carrega Combo
            Call LoadCombo(cboCampanha, "sp_select_combo_cadastro_basico_campanha_abrangencia " & goUsuario.iEmpresa)
            'Seta Focu
            cboCampanha.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarCondicaoPagamentoFornecedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCondicaoPagamentoFornecedor.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrCadCondicaoPagamento"
            oForm.Titulo = Me.Parent.Text
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

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

    Private Sub btnProcurarCEPEndereco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCepEndereco.Click

        Try

            'Verifica se foi preenchido o CEP
            If txtCepEndereco.Text.Replace("-", "").Trim.Length = 8 Then

                'Verifica se há o cep no banco de dados
                ProcuraCep(CLng(Replace(txtCepEndereco.Text.Trim, "-", "")),
                           cboPaisEndereco,
                           cboUFEndereco,
                           cboMunicipioEndereco,
                           txtBairroEndereco,
                           txtLogradouroEndereco,
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
            Novo()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click

        Try

            'Alterna Aba
            tabMain.SelectedTab = pagDados

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
            If Validacao() = False Then Exit Sub

            'Salva Dados do Registro
            Salvar()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
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
            tabMain.SelectedTab = pagLista

            'Seta Focu
            cboTipoParceiroNegocioFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCongelarColuna_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCongelarColuna.SelectedIndexChanged

        Try

            If cboCongelarColuna.SelectedIndex = -1 Then
                grdListagem.FrozenColumns = 6
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

            'Váriaveis Locais
            Dim sCNPJ As String
            Dim sInscricaoEstadual As String

            sCNPJ = txtCnpjCpf.Text.Trim
            sInscricaoEstadual = txtInscricaoEstadual.Text.Trim

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
                txtCNAE.Text = "" : txtCNAE.Enabled = False
                cboRegimeTributario.SelectedIndex = -1 : cboRegimeTributario.Enabled = False
                txtInscricaoEstadualSubstitutoTriburario.Text = "" : txtInscricaoEstadualSubstitutoTriburario.Enabled = False
                txtInscricaoMunicipal.Text = "" : txtInscricaoMunicipal.Enabled = False
                txtInscricaoSuframa.Text = "" : txtInscricaoSuframa.Enabled = False
                jstTip.SetSuperTip(txtInscricaoEstadual, oSuperTipSettings)

            ElseIf cboPersonalidade.SelectedValue = Personalidade.Juridica Then

                oSuperTipSettings.HeaderText = "Inscrição Estadual"
                oSuperTipSettings.Text = "Preencher Inscrição Estadual (somente  números) caso contribuinte do ICMS." & vbCrLf &
                                         "Preencher com ISENTO caso contribuinte do ICMS, mas não estiver obrigado a inscrição no cadastro de contribuintes." & vbCrLf &
                                         "Não preencher caso não for contribuinte do ICMS."

                lblCnpjCpf.Text = "CNPJ:"
                txtCnpjCpf.Text = ""
                txtCnpjCpf.Mask = "00,000,000/0000-00"
                txtCNAE.Enabled = True
                cboRegimeTributario.Enabled = True
                txtInscricaoEstadualSubstitutoTriburario.Enabled = True
                lblInscricaoEstadual.Text = "Inscrição Estadual:"
                txtInscricaoEstadual.Text = ""
                txtInscricaoMunicipal.Enabled = True
                txtInscricaoSuframa.Enabled = True
                jstTip.SetSuperTip(txtInscricaoEstadual, oSuperTipSettings)

            Else

                oSuperTipSettings.HeaderText = "Inscrição Estadual"
                oSuperTipSettings.Text = "Preencher Inscrição Estadual (somente  números) caso contribuinte do ICMS." & vbCrLf &
                                         "Preencher com ISENTO caso contribuinte do ICMS, mas não estiver obrigado a inscrição no cadastro de contribuintes." & vbCrLf &
                                         "Não preencher caso não for contribuinte do ICMS."

                lblCnpjCpf.Text = "CNPJ / CPF:"
                txtCnpjCpf.Text = ""
                txtCnpjCpf.Mask = ""
                lblInscricaoEstadual.Text = "Inscrição Estadual:"
                txtInscricaoEstadual.Text = ""
                txtCNAE.Text = "" : txtCNAE.Enabled = False
                cboRegimeTributario.SelectedIndex = -1 : cboRegimeTributario.Enabled = False
                txtInscricaoEstadualSubstitutoTriburario.Text = "" : txtInscricaoEstadualSubstitutoTriburario.Enabled = False
                txtInscricaoMunicipal.Text = "" : txtInscricaoMunicipal.Enabled = False
                txtInscricaoSuframa.Text = "" : txtInscricaoSuframa.Enabled = False
                jstTip.SetSuperTip(txtInscricaoEstadual, oSuperTipSettings)

            End If

            txtCnpjCpf.Text = sCNPJ
            txtInscricaoEstadual.Text = sInscricaoEstadual

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

    Private Sub cboTipoNegativacao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoNegativacao.SelectedIndexChanged

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

    Private Sub cboTipoInscricaoEstadual_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoInscricaoEstadual.SelectedIndexChanged

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
                If tabDados.TabPages.Contains(pagAmostra) = False Then tabDados.TabPages.Add(pagAmostra)
                If VerificaDireito(Formulario.CadastroBasicoParceiroNegocioClienteCondicaoFornecimento, IIf(IsNumeric(btnSalvar.Tag) = False, gcInsert, gcUpdate)) = True Then If tabDados.TabPages.Contains(pagDadosCliente) = False Then tabDados.TabPages.Add(pagDadosCliente)
                If VerificaDireito(Formulario.CadastroBasicoParceiroNegocioClienteCRM, IIf(IsNumeric(btnSalvar.Tag) = False, gcInsert, gcUpdate)) = True Then If tabDados.TabPages.Contains(pagRelacionamento) = False Then tabDados.TabPages.Add(pagRelacionamento)
                If VerificaDireito(Formulario.CadastroBasicoParceiroNegocioClienteMarcasHomologadas, IIf(IsNumeric(btnSalvar.Tag) = False, gcInsert, gcUpdate)) = True Then If tabDados.TabPages.Contains(pagMarca) = False Then tabDados.TabPages.Add(pagMarca)
                If VerificaDireito(Formulario.CadastroBasicoParceiroNegocioClienteNegativacao, IIf(IsNumeric(btnSalvar.Tag) = False, gcInsert, gcUpdate)) = True Then If tabDados.TabPages.Contains(pagNegativacao) = False Then tabDados.TabPages.Add(pagNegativacao)
                If tabDados.TabPages.Contains(pagChecklistCliente) = False Then tabDados.TabPages.Add(pagChecklistCliente)
            Else
                If tabDados.TabPages.Contains(pagAmostra) = True Then tabDados.TabPages.Remove(pagAmostra)
                If tabDados.TabPages.Contains(pagDadosCliente) = True Then tabDados.TabPages.Remove(pagDadosCliente)
                If tabDados.TabPages.Contains(pagRelacionamento) = True Then tabDados.TabPages.Remove(pagRelacionamento)
                If tabDados.TabPages.Contains(pagMarca) = True Then tabDados.TabPages.Remove(pagMarca)
                If tabDados.TabPages.Contains(pagNegativacao) = True Then tabDados.TabPages.Remove(pagNegativacao)
                If tabDados.TabPages.Contains(pagChecklistCliente) = True Then tabDados.TabPages.Remove(pagChecklistCliente)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub chkFornecedor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFornecedor.CheckedChanged

        Try

            'Verifica se é Fornecedor
            If chkFornecedor.Checked Or chkDespachante.Checked Or chkAgenteLogistico.Checked Then
                If tabDados.TabPages.Contains(pagDadosFornecedor) = False Then tabDados.TabPages.Add(pagDadosFornecedor)
                If VerificaDireito(Formulario.CadastroBasicoParceiroNegocioFornecedorCertificados, IIf(IsNumeric(btnSalvar.Tag), gcInsert, gcUpdate)) = True Then If tabDados.TabPages.Contains(pagCertificado) = False Then tabDados.TabPages.Add(pagCertificado)
            Else
                If tabDados.TabPages.Contains(pagDadosFornecedor) = True Then tabDados.TabPages.Remove(pagDadosFornecedor)
                If tabDados.TabPages.Contains(pagCertificado) = True Then tabDados.TabPages.Remove(pagCertificado)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub chkAgenteLogistico_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAgenteLogistico.CheckedChanged

        Try

            'Verifica se é Fornecedor
            If chkFornecedor.Checked Or chkDespachante.Checked Or chkAgenteLogistico.Checked Then
                If tabDados.TabPages.Contains(pagDadosFornecedor) = False Then tabDados.TabPages.Add(pagDadosFornecedor)
                If VerificaDireito(Formulario.CadastroBasicoParceiroNegocioFornecedorCertificados, IIf(IsNumeric(btnSalvar.Tag), gcInsert, gcUpdate)) = True Then If tabDados.TabPages.Contains(pagCertificado) = False Then tabDados.TabPages.Add(pagCertificado)
            Else
                If tabDados.TabPages.Contains(pagDadosFornecedor) = True Then tabDados.TabPages.Remove(pagDadosFornecedor)
                If tabDados.TabPages.Contains(pagCertificado) = True Then tabDados.TabPages.Remove(pagCertificado)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub chkDespachante_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDespachante.CheckedChanged

        Try

            'Verifica se é Fornecedor
            If chkFornecedor.Checked Or chkDespachante.Checked Or chkAgenteLogistico.Checked Then
                If tabDados.TabPages.Contains(pagDadosFornecedor) = False Then tabDados.TabPages.Add(pagDadosFornecedor)
                If VerificaDireito(Formulario.CadastroBasicoParceiroNegocioFornecedorCertificados, IIf(IsNumeric(btnSalvar.Tag), gcInsert, gcUpdate)) = True Then If tabDados.TabPages.Contains(pagCertificado) = False Then tabDados.TabPages.Add(pagCertificado)
            Else
                If tabDados.TabPages.Contains(pagDadosFornecedor) = True Then tabDados.TabPages.Remove(pagDadosFornecedor)
                If tabDados.TabPages.Contains(pagCertificado) = True Then tabDados.TabPages.Remove(pagCertificado)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdListagem.CellUpdated

        Try

            'Query
            Dim sQuery As String = "WHERE (((codigo) = " & grdListagem.GetValue("codigo") & "))"

            Select Case e.Column.Key

                Case "vendedor" : Call ExecuteQuery("sp_update_interacti_table_field 'tb_cad_parceiro_negocio', 'codigo_vendedor', " & IIf(IsDBNull(grdListagem.GetValue("vendedor")) = False, grdListagem.GetValue("vendedor"), "'NULL'") & ",'" & sQuery & "'")
                Case "vendedor_interno" : Call ExecuteQuery("sp_update_interacti_table_field 'tb_cad_parceiro_negocio', 'codigo_vendedor_interno', " & IIf(IsDBNull(grdListagem.GetValue("vendedor_interno")) = False, grdListagem.GetValue("vendedor_interno"), "'NULL'") & ",'" & sQuery & "'")

            End Select

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

                Case "editar" : tabMain.SelectedTab = pagDados
                Case "imprimir" : Call ImprimirParceiroNegocio(grdListagem.CurrentRow.Cells("codigo").Value)
                Case "email" : Call EmailParceiroNegocio(grdListagem.CurrentRow.Cells("codigo").Value)
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
            Call UpdateConfiguraGrid(grdListagem,
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
            Call UpdateConfiguraGrid(grdListagem.Name,
                                     Formulario.CadastroBasicoParceiroNegocio,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name,
                                          Formulario.CadastroBasicoParceiroNegocio,
                                          e.Group.Column.Key,
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False),
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub tabMain_Resize(sender As Object, e As EventArgs) Handles tabMain.Resize

        Try

            'Váriaveis Locais
            Dim dHeight As Integer = 566
            Dim dHeightGrid1 As Integer = 191
            Dim dHeightGrid2 As Integer = 258
            Dim dFator As Double = tabMain.Height - dHeight

            'Ajusta Histórico Financeiro
            grdContasAberto.Height = dHeightGrid1 + System.Math.Ceiling(dFator / 2)
            grdContasRecebidas.Height = dHeightGrid2 + System.Math.Floor(dFator / 2)
            grdContasAberto.Top = grdContasRecebidas.Top + grdContasRecebidas.Height + 9
            'Seta Top - Histórico Financeiro
            btnConfigurarGridContasRecebidas.Top = grdContasRecebidas.Top + grdContasRecebidas.Height - btnConfigurarGridContasRecebidas.Height - 2
            btnAgruparGridContasRecebidas.Top = btnConfigurarGridContasRecebidas.Top
            btnExcelGridContasRecebidas.Top = btnConfigurarGridContasRecebidas.Top

            'Ajusta Pedido de Venda
            grdPedidoVendaProduto.Height = grdContasAberto.Height
            grdPedidoVenda.Height = grdContasRecebidas.Height - 23
            grdPedidoVendaProduto.Top = grdContasAberto.Top
            grdNotaFiscal.Top = grdContasRecebidas.Top + 23
            grdNotaFiscal.Height = grdContasRecebidas.Height - 23
            'Ajusta Orçamento
            grdOrcamentoProduto.Height = grdContasAberto.Height
            grdNotaFiscalProduto.Height = grdContasAberto.Height
            grdOrcamento.Height = grdContasRecebidas.Height - 23
            grdOrcamentoProduto.Top = grdContasAberto.Top
            grdNotaFiscalProduto.Top = grdContasAberto.Top

            'Seta Top - Pedido de Venda
            btnConfigurarGridPedido.Top = btnConfigurarGridContasRecebidas.Top
            btnAgruparGridPedido.Top = btnConfigurarGridContasRecebidas.Top
            btnExcelGridPedido.Top = btnConfigurarGridContasRecebidas.Top
            'Seta Top - Orçamento
            btnConfigurarGridOrcamento.Top = btnConfigurarGridContasRecebidas.Top
            btnExcelGridOrcamento.Top = btnConfigurarGridContasRecebidas.Top
            btnAgruparGridOrcamento.Top = btnConfigurarGridContasRecebidas.Top
            'Seta Top - Fatumento
            btnConfigurarGridNotaFiscal.Top = btnConfigurarGridContasRecebidas.Top
            btnExcelGridNotaFiscal.Top = btnConfigurarGridContasRecebidas.Top
            btnAgruparGridNotaFiscal.Top = btnConfigurarGridContasRecebidas.Top

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub tabMain_ChangingSelectedTab(sender As Object, e As Janus.Windows.UI.Tab.TabCancelEventArgs) Handles tabMain.ChangingSelectedTab

        Try

            Select Case e.Page.Key

                Case "pagDados"
                    If IsNothing(grdListagem.CurrentRow) = False Then
                        Call Editar(grdListagem.CurrentRow.Cells("codigo").Value)
                    Else
                        Call Novo()
                    End If

                Case "pagHistoricoFinanceiro"
                    If IsNothing(grdListagem.CurrentRow) = False Then
                        oClsCadParceiroNegocio.LoadGridTitulo(grdContasRecebidas, grdListagem.CurrentRow.Cells("codigo").Value, "BAIXADO")
                        oClsCadParceiroNegocio.LoadGridTitulo(grdContasAberto, grdListagem.CurrentRow.Cells("codigo").Value, "ABERTO")
                        'Carrega Controles
                        txtCNPJHistoricoFinanceiro.Text = grdListagem.CurrentRow.Cells("cnpj_cpf").Value
                        txtRazaoSocialHistoricoFinanceiro.Text = grdListagem.CurrentRow.Cells("razao_social").Value
                        txtNomeFantasiaHistoricoFinanceiro.Text = grdListagem.CurrentRow.Cells("nome_fantasia").Value
                        txtSegmentoHistoricoFinanceiro.Text = grdListagem.CurrentRow.Cells("segmento").Value
                    Else
                        grdContasRecebidas.DataSource = Nothing
                        grdContasAberto.DataSource = Nothing
                    End If

                Case "pagPedidoVenda"
                    If IsNothing(grdListagem.CurrentRow) = False Then
                        oClsCadParceiroNegocio.LoadGridHistoricoVenda(grdPedidoVenda,
                                                                      grdListagem.CurrentRow.Cells("codigo").Value,
                                                                      dtpDataInicioPedidoVenda.Value,
                                                                      dtpDataTerminoPedidoVenda.Value)
                        'Carrega Controles
                        txtCNPJPedidoVenda.Text = grdListagem.CurrentRow.Cells("cnpj_cpf").Value
                        txtRazaoSocialPedidoVenda.Text = grdListagem.CurrentRow.Cells("razao_social").Value
                        txtNomeFantasiaPedidoVenda.Text = grdListagem.CurrentRow.Cells("nome_fantasia").Value
                        txtSegmentoPedidoVenda.Text = grdListagem.CurrentRow.Cells("segmento").Value
                    Else
                        grdPedidoVenda.DataSource = Nothing
                        grdPedidoVendaProduto.DataSource = Nothing
                    End If

                Case "pagOrcamento"
                    If IsNothing(grdListagem.CurrentRow) = False Then
                        oClsCadParceiroNegocio.LoadGridHistoricoOrcamento(grdOrcamento,
                                                                          grdListagem.CurrentRow.Cells("codigo").Value,
                                                                          dtpDataInicioOrcamento.Value,
                                                                          dtpDataTerminoOrcamento.Value)
                        'Carrega Controles
                        txtCNPJOrcamento.Text = grdListagem.CurrentRow.Cells("cnpj_cpf").Value
                        txtRazaoSocialOrcamento.Text = grdListagem.CurrentRow.Cells("razao_social").Value
                        txtNomeFantasiaOrcamento.Text = grdListagem.CurrentRow.Cells("nome_fantasia").Value
                        txtSegmentoOrcamento.Text = grdListagem.CurrentRow.Cells("segmento").Value
                    Else
                        grdOrcamento.DataSource = Nothing
                        grdOrcamentoProduto.DataSource = Nothing
                    End If

                Case "pagNotaFiscal"
                    If IsNothing(grdListagem.CurrentRow) = False Then
                        oClsCadParceiroNegocio.LoadGridHistoricoNotaFiscal(grdNotaFiscal,
                                                                           grdListagem.CurrentRow.Cells("codigo").Value,
                                                                           dtpDataInicioNotaFiscal.Value,
                                                                           dtpDataTerminoNotaFiscal.Value)
                        'Carrega Controles
                        txtCNPJNotaFiscal.Text = grdListagem.CurrentRow.Cells("cnpj_cpf").Value
                        txtRazaoSocialNotaFiscal.Text = grdListagem.CurrentRow.Cells("razao_social").Value
                        txtNomeFantasiaNotaFiscal.Text = grdListagem.CurrentRow.Cells("nome_fantasia").Value
                        txtSegmentoNotaFiscal.Text = grdListagem.CurrentRow.Cells("segmento").Value
                    Else
                        grdNotaFiscal.DataSource = Nothing
                        grdNotaFiscalProduto.DataSource = Nothing
                    End If

                Case "pagContato"
                    If IsNothing(grdListagem.CurrentRow) = False Then
                        oClsCadParceiroNegocio.LoadGridContato(grdContato, grdListagem.CurrentRow.Cells("codigo").Value)
                        oClsCadParceiroNegocio.Codigo = grdListagem.CurrentRow.Cells("codigo").Value
                        'Carrega Controles
                        txtCNPJContato.Text = grdListagem.CurrentRow.Cells("cnpj_cpf").Value
                        txtRazaoSocialContato.Text = grdListagem.CurrentRow.Cells("razao_social").Value
                        txtNomeFantasiaContato.Text = grdListagem.CurrentRow.Cells("nome_fantasia").Value
                        txtSegmentoContato.Text = grdListagem.CurrentRow.Cells("segmento").Value
                    Else
                        grdContato.DataSource = Nothing
                        oClsCadParceiroNegocio.Codigo = 0
                    End If

                Case "pagEndereco"
                    If IsNothing(grdListagem.CurrentRow) = False Then
                        oClsCadParceiroNegocio.LoadGridEndereco(grdEndereco, grdListagem.CurrentRow.Cells("codigo").Value)
                        oClsCadParceiroNegocio.Codigo = grdListagem.CurrentRow.Cells("codigo").Value
                        'Carrega Controles
                        txtCNPJEndereco.Text = grdListagem.CurrentRow.Cells("cnpj_cpf").Value
                        txtRazaoSocialEndereco.Text = grdListagem.CurrentRow.Cells("razao_social").Value
                        txtNomeFantasiaEndereco.Text = grdListagem.CurrentRow.Cells("nome_fantasia").Value
                        txtSegmentoEndereco.Text = grdListagem.CurrentRow.Cells("segmento").Value
                    Else
                        grdEndereco.DataSource = Nothing
                        oClsCadParceiroNegocio.Codigo = 0
                    End If

                Case "pagEstoque"
                    If IsNothing(grdListagem.CurrentRow) = False Then
                        oClsCadParceiroNegocio.LoadGridHistoricoEstoque(grdEstoque, grdListagem.CurrentRow.Cells("codigo").Value)
                        oClsCadParceiroNegocio.Codigo = grdListagem.CurrentRow.Cells("codigo").Value
                        'Carrega Controles
                        txtCNPJEstoque.Text = grdListagem.CurrentRow.Cells("cnpj_cpf").Value
                        txtRazaoSocialEstoque.Text = grdListagem.CurrentRow.Cells("razao_social").Value
                        txtNomeFantasiaEstoque.Text = grdListagem.CurrentRow.Cells("nome_fantasia").Value
                        txtSegmentoEstoque.Text = grdListagem.CurrentRow.Cells("segmento").Value
                    Else
                        grdEstoque.DataSource = Nothing
                        oClsCadParceiroNegocio.Codigo = 0
                    End If

                Case "pagClassificacao"
                    If IsNothing(grdListagem.CurrentRow) = False Then
                        btnSalvar.Tag = grdListagem.CurrentRow.Cells("codigo").Value
                        Call oClsCadParceiroNegocio.LoadGridCentroCusto(grdCentroCusto, btnSalvar.Tag)
                        Call oClsCadParceiroNegocio.LoadGridContaContabil(grdContaContabil, btnSalvar.Tag)
                        'Carrega Controles
                        txtCNPJClassificacao.Text = grdListagem.CurrentRow.Cells("cnpj_cpf").Value
                        txtRazaoSocialClassificacao.Text = grdListagem.CurrentRow.Cells("razao_social").Value
                        txtNomeFantasiaClassificacao.Text = grdListagem.CurrentRow.Cells("nome_fantasia").Value
                        txtSegmentoClassificacao.Text = grdListagem.CurrentRow.Cells("segmento").Value
                    End If

                Case "pagQualidade"
                    Call novaQualidade()
                    Call oClsCadParceiroNegocio.loadGridQualidade(grdQualidade, _
                                                                  btnSalvar.Tag)

                    Call oClsCadParceiroNegocio.LoadQualidadeRisco(lblMensagem, _
                                                                   lblMediaNota, _
                                                                   lblStatusQualidade, _
                                                                   btnSalvar.Tag)


            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: CLIENTE :::"

    Private Sub cboInstrucao1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboInstrucao1.SelectedIndexChanged

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

    Private Sub cboInstrucao2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboInstrucao2.SelectedIndexChanged

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

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrCadTipoContato"
            oForm.Titulo = Me.Parent.Text
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

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

            'Valida Dados do Contato
            If ValidacaoContato() = True Then

                'Verifica o Tipo de Operação
                If IsNumeric(btnSalvarContato.Tag) = False Then

                    'Insere Contato
                    Call oClsCadParceiroNegocio.InsertContato(txtNomeContato.Text.Trim,
                                                                  txtTelefoneContato.Text.Trim,
                                                                  txtCelularContato.Text.Trim,
                                                                  IIf(dtpDataAniversario.Checked = True, dtpDataAniversario.Value, ""),
                                                                  txtEmailContato.Text.Trim,
                                                                  txtComplementoContato.Text.Trim,
                                                                  cboTipoContato.SelectedValue)

                Else

                    'Atualiza Dados do Contato
                    Call oClsCadParceiroNegocio.UpdateContato(txtNomeContato.Text.Trim,
                                                              txtTelefoneContato.Text.Trim,
                                                              txtCelularContato.Text.Trim,
                                                              IIf(dtpDataAniversario.Checked = True, dtpDataAniversario.Value, ""),
                                                              txtEmailContato.Text.Trim,
                                                              txtComplementoContato.Text.Trim,
                                                              cboTipoContato.SelectedValue,
                                                              btnSalvarContato.Tag)

                End If

                'Carrega Lista de Contato
                Call oClsCadParceiroNegocio.LoadGridContato(grdContato, oClsCadParceiroNegocio.Codigo)

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoContato()

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
            Call UpdateConfiguraGrid(grdContato,
                                     Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdContato_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdContato.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdContato.Name,
                                     Formulario.CadastroBasicoParceiroNegocio,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdContato_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdContato.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdContato.Name,
                                          Formulario.CadastroBasicoParceiroNegocio,
                                          e.Group.Column.Key,
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False),
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

            'Valida Dados do Endereço
            If ValidacaoEndereco() = True Then

                'Verifica o Tipo de Operação
                If IsNumeric(btnSalvarEndereco.Tag) = False Then

                    'Insere Endereço                        
                    Call oClsCadParceiroNegocio.InsertEndereco(cboTipoEndereco.SelectedValue,
                                                               txtCepEndereco.Text.Trim,
                                                               cboPaisEndereco.SelectedValue,
                                                               cboUFEndereco.SelectedValue,
                                                               cboMunicipioEndereco.SelectedValue,
                                                               txtLogradouroEndereco.Text.Trim,
                                                               txtNumeroEndereco.Text.Trim,
                                                               txtBairroEndereco.Text.Trim,
                                                               txtComplementoEndereco.Text.Trim)

                Else

                    'Atualiza Endereço                        
                    Call oClsCadParceiroNegocio.UpdateEndereco(cboTipoEndereco.SelectedValue,
                                                               txtCepEndereco.Text.Trim,
                                                               cboPaisEndereco.SelectedValue,
                                                               cboUFEndereco.SelectedValue,
                                                               cboMunicipioEndereco.SelectedValue,
                                                               txtLogradouroEndereco.Text.Trim,
                                                               txtNumeroEndereco.Text.Trim,
                                                               txtBairroEndereco.Text.Trim,
                                                               txtComplementoEndereco.Text.Trim,
                                                               btnSalvarEndereco.Tag)

                End If

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoEndereco()

                'Carrega Lista de Endereço
                oClsCadParceiroNegocio.LoadGridEndereco(grdEndereco, oClsCadParceiroNegocio.Codigo)

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

                Case "duplicar" : Call DuplicarEndereco()
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
            Call UpdateConfiguraGrid(grdEndereco,
                                     Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdEndereco_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdEndereco.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdEndereco.Name,
                                     Formulario.CadastroBasicoParceiroNegocio,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdEndereco_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdEndereco.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdEndereco.Name,
                                          Formulario.CadastroBasicoParceiroNegocio,
                                          e.Group.Column.Key,
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False),
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
                        Call oClsCadParceiroNegocio.InsertCRM(txtAssuntoCRM.Text.Trim,
                                                              dtpDataCRM.Value)

                    Else

                        'Atualiza Dados do CRM
                        Call oClsCadParceiroNegocio.UpdateCRM(txtAssuntoCRM.Text.Trim,
                                                              dtpDataCRM.Value,
                                                              btnSalvarCRM.Tag)

                    End If

                    'Carrega Lista de CRM
                    Call oClsCadParceiroNegocio.LoadGridCRM(grdCRM,
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
            Call UpdateConfiguraGrid(grdCRM,
                                     Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdCRM_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdCRM.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdCRM.Name,
                                     Formulario.CadastroBasicoParceiroNegocio,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdCRM_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdCRM.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdCRM.Name,
                                          Formulario.CadastroBasicoParceiroNegocio,
                                          e.Group.Column.Key,
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False),
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
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrCadTipoArquivo"
            oForm.Titulo = Me.Parent.Text
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

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
                        Call oClsCadParceiroNegocio.InsertCertificado(txtCertificado.Text.Trim,
                                                                      dtpDataEmissaoCertificado.Value,
                                                                      IIf(dtpDataValidadeCertificado.Checked = True, dtpDataValidadeCertificado.Value, ""),
                                                                      iCodigoCertificado)


                        'Insere Arquivo
                        Call InsertArquivoBD("tb_cad_parceiro_negocio_certificado",
                                             txtCertificado.Text.Trim,
                                             dtpDataEmissaoCertificado.Value,
                                             txtArquivoCertificado.Text.Trim,
                                             cboTipoArquivoCertificado.SelectedValue,
                                             btnSalvar.Tag,
                                             iCodigoCertificado)

                    Else

                        'Atualiza Dados do Certificado
                        Call oClsCadParceiroNegocio.UpdateCertificado(txtCertificado.Text.Trim,
                                                                      dtpDataEmissaoCertificado.Value,
                                                                      IIf(dtpDataValidadeCertificado.Checked = True, dtpDataValidadeCertificado.Value, ""),
                                                                      btnSalvarCertificado.Tag)

                        'Verifica se tem Arquivo associado
                        If cboTipoArquivoCertificado.SelectedIndex = -1 And IsDBNull(grdCertificado.CurrentRow.Cells("path").Value) = False Then

                            'Deleta Arquivo
                            Call DeleteArquivoBD("tb_cad_parceiro_negocio_certificado",
                                                 grdCertificado.CurrentRow.Cells("path").Value,
                                                 btnSalvar.Tag,
                                                 btnSalvarCertificado.Tag)

                        ElseIf txtArquivoCertificado.Text.Trim <> "" Then

                            Call UpdateArquivoBD("tb_cad_parceiro_negocio_certificado",
                                                 txtCertificado.Text.Trim,
                                                 dtpDataEmissaoCertificado.Value,
                                                 txtArquivoCertificado.Text.Trim,
                                                 cboTipoArquivoCertificado.SelectedValue,
                                                 grdCertificado.CurrentRow.Cells("path").Value,
                                                 btnSalvar.Tag,
                                                 btnSalvarCertificado.Tag)

                        End If

                    End If

                    'Carrega Lista de Certificado
                    Call oClsCadParceiroNegocio.LoadGridCertificado(grdCertificado,
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
            Call UpdateConfiguraGrid(grdCertificado,
                                     Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdCertificado_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdCertificado.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdCertificado.Name,
                                     Formulario.CadastroBasicoParceiroNegocio,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdCertificado_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdCertificado.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdCertificado.Name,
                                          Formulario.CadastroBasicoParceiroNegocio,
                                          e.Group.Column.Key,
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False),
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ESPECIALIDADE :::"

    Private Sub grdEspecialidade_RowCheckStateChanged(sender As Object, e As RowCheckStateChangeEventArgs) Handles grdEspecialidade.RowCheckStateChanged

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

    Private Sub btnAtribuirOperacao_Click(sender As Object, e As EventArgs) Handles btnAtribuirOperacao.Click
        Try
            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrCadFornecedorOperacao"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Fornecedor por Operação"
            oForm.ShowDialog(Me)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
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

    Private Sub grdMarca_RowCheckStateChanged(sender As Object, e As RowCheckStateChangeEventArgs) Handles grdMarca.RowCheckStateChanged

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
            Call UpdateConfiguraGrid(grdMarca,
                                     Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdMarca_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdMarca.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdMarca.Name,
                                     Formulario.CadastroBasicoParceiroNegocio,
                                     e.Column.Key,
                                     e.ProposedWidth)

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
            oForm.NomeFormulario = Formulario.CadastroBasicoParceiroNegocio
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdArquivo, Formulario.CadastroBasicoParceiroNegocio)

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
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrCadTipoArquivo"
            oForm.Titulo = Me.Parent.Text
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

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
                    Call InsertArquivoBD("tb_cad_parceiro_negocio",
                                         txtDescricaoArquivo.Text.Trim,
                                         txtRevisaoArquivo.Text.Trim,
                                         txtArquivo.Text.Trim,
                                         cboTipoArquivo.SelectedValue,
                                         btnSalvar.Tag)

                Else

                    'Atualiza Arquivo
                    Call UpdateArquivoBD("tb_cad_parceiro_negocio",
                                         txtDescricaoArquivo.Text.Trim,
                                         txtRevisaoArquivo.Text.Trim,
                                         IIf(txtArquivo.Text.Trim = "", grdArquivo.CurrentRow.Cells("path").Value, txtArquivo.Text.Trim),
                                         cboTipoArquivo.SelectedValue,
                                         grdArquivo.CurrentRow.Cells("path").Value,
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
            Call UpdateConfiguraGrid(grdArquivo,
                                     Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdArquivo.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdArquivo.Name,
                                     Formulario.CadastroBasicoParceiroNegocio,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdArquivo.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdArquivo.Name,
                                          Formulario.CadastroBasicoParceiroNegocio,
                                          e.Group.Column.Key,
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False),
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ORÇAMENTO :::"

    Private Sub LoadGridOrcamento() Handles dtpDataInicioOrcamento.ValueChanged,
                                            dtpDataTerminoOrcamento.ValueChanged

        Try

            If IsNothing(grdListagem.CurrentRow) = False Then
                oClsCadParceiroNegocio.LoadGridHistoricoOrcamento(grdOrcamento,
                                                                  grdListagem.CurrentRow.Cells("codigo").Value,
                                                                  dtpDataInicioOrcamento.Value,
                                                                  dtpDataTerminoOrcamento.Value)
            Else
                grdOrcamento.DataSource = Nothing
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridOrcamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridOrcamento.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdOrcamento
            oForm.NomeFormulario = Formulario.CadastroBasicoParceiroNegocio
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            ConfiguraGrid(grdOrcamento, Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnAgruparGridOrcamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridOrcamento.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdOrcamento.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdOrcamento.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdOrcamento.GroupByBoxVisible = True
                grdOrcamento.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGridOrcamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridOrcamento.Click

        Try

            'Exporta Grid - Excel
            Call ExportExcel(grdOrcamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridOrcamentoProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridOrcamentoProduto.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdOrcamentoProduto
            oForm.NomeFormulario = Formulario.CadastroBasicoParceiroNegocio
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            ConfiguraGrid(grdOrcamentoProduto, Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnAgruparGridOrcamentoProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridOrcamentoProduto.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdOrcamentoProduto.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdOrcamentoProduto.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdOrcamentoProduto.GroupByBoxVisible = True
                grdOrcamentoProduto.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGridOrcamentoProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridOrcamentoProduto.Click

        Try

            'Exporta Grid - Excel
            Call ExportExcel(grdOrcamentoProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdOrcamento_SelectionChanged(sender As Object, e As EventArgs) Handles grdOrcamento.SelectionChanged

        Try

            Me.Select()

            'Verifica se foi Selecionado algum Registro
            If IsNothing(grdOrcamento.CurrentRow) = False Then

                'Carrega Grid - Produtos Similares
                Call oClsCadParceiroNegocio.LoadGridHistoricoOrcamentoProduto(grdOrcamentoProduto,
                                                                              grdOrcamento.CurrentRow.Cells("codigo_orcamento").Value)

            Else

                'Limpa Controle
                grdOrcamentoProduto.DataSource = Nothing

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdOrcamento_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdOrcamento.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdOrcamento.Name,
                                     Formulario.CadastroBasicoParceiroNegocio,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdOrcamento_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdOrcamento.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdOrcamento,
                                     Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdOrcamento_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdOrcamento.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdOrcamento.Name,
                                          Formulario.CadastroBasicoParceiroNegocio,
                                          e.Group.Column.Key,
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False),
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdOrcamentoProduto_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdOrcamentoProduto.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdOrcamentoProduto.Name,
                                     Formulario.CadastroBasicoParceiroNegocio,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdOrcamentoProduto_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdOrcamentoProduto.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdOrcamentoProduto,
                                     Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdOrcamentoProduto_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdOrcamentoProduto.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdOrcamentoProduto.Name,
                                          Formulario.CadastroBasicoParceiroNegocio,
                                          e.Group.Column.Key,
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False),
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: PEDIDO DE VENDA :::"

    Private Sub LoadGridPedidoVenda() Handles dtpDataInicioPedidoVenda.ValueChanged,
                                              dtpDataTerminoPedidoVenda.ValueChanged

        Try

            If IsNothing(grdListagem.CurrentRow) = False Then
                oClsCadParceiroNegocio.LoadGridHistoricoVenda(grdPedidoVenda,
                                                              grdListagem.CurrentRow.Cells("codigo").Value,
                                                              dtpDataInicioPedidoVenda.Value,
                                                              dtpDataTerminoPedidoVenda.Value)
            Else
                grdPedidoVenda.DataSource = Nothing
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridPedido.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdPedidoVenda
            oForm.NomeFormulario = Formulario.CadastroBasicoParceiroNegocio
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            ConfiguraGrid(grdPedidoVenda, Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnAgruparGridPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridPedido.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdPedidoVenda.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdPedidoVenda.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdPedidoVenda.GroupByBoxVisible = True
                grdPedidoVenda.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGridPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridPedido.Click

        Try

            'Exporta Grid - Excel
            Call ExportExcel(grdPedidoVenda)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridPedidoVendaProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridPedidoVendaProduto.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdPedidoVendaProduto
            oForm.NomeFormulario = Formulario.CadastroBasicoParceiroNegocio
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            ConfiguraGrid(grdPedidoVendaProduto, Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnAgruparGridPedidoVendaProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridPedidoVendaProduto.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdPedidoVendaProduto.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdPedidoVendaProduto.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdPedidoVendaProduto.GroupByBoxVisible = True
                grdPedidoVendaProduto.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGridPedidoVendaProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridPedidoVendaProduto.Click

        Try

            'Exporta Grid - Excel
            Call ExportExcel(grdPedidoVendaProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoVenda_SelectionChanged(sender As Object, e As EventArgs) Handles grdPedidoVenda.SelectionChanged

        Try

            Me.Select()

            'Verifica se foi Selecionado algum Registro
            If IsNothing(grdPedidoVenda.CurrentRow) = False Then

                'Carrega Grid - Produtos Similares
                Call oClsCadParceiroNegocio.LoadGridHistoricoVendaProduto(grdPedidoVendaProduto,
                                                                          grdPedidoVenda.CurrentRow.Cells("codigo_pedido").Value)

            Else

                'Limpa Controle
                grdPedidoVendaProduto.DataSource = Nothing

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoVenda_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdPedidoVenda.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdPedidoVenda.Name,
                                     Formulario.CadastroBasicoParceiroNegocio,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoVenda_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdPedidoVenda.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdPedidoVenda,
                                     Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoVenda_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdPedidoVenda.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdPedidoVenda.Name,
                                          Formulario.CadastroBasicoParceiroNegocio,
                                          e.Group.Column.Key,
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False),
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoVendaProduto_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdPedidoVendaProduto.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdPedidoVendaProduto.Name,
                                     Formulario.CadastroBasicoParceiroNegocio,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoVendaProduto_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdPedidoVendaProduto.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdPedidoVendaProduto,
                                     Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoVendaProduto_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdPedidoVendaProduto.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdPedidoVendaProduto.Name,
                                          Formulario.CadastroBasicoParceiroNegocio,
                                          e.Group.Column.Key,
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False),
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: NOTA FISCAL :::"

    Private Sub LoadGridNotaFiscal() Handles dtpDataInicioNotaFiscal.ValueChanged,
                                             dtpDataTerminoNotaFiscal.ValueChanged

        Try

            If IsNothing(grdListagem.CurrentRow) = False Then
                oClsCadParceiroNegocio.LoadGridHistoricoNotaFiscal(grdNotaFiscal,
                                                                   grdListagem.CurrentRow.Cells("codigo").Value,
                                                                   dtpDataInicioNotaFiscal.Value,
                                                                   dtpDataTerminoNotaFiscal.Value)
            Else
                grdNotaFiscal.DataSource = Nothing
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridNotaFiscal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridNotaFiscal.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdNotaFiscal
            oForm.NomeFormulario = Formulario.CadastroBasicoParceiroNegocio
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            ConfiguraGrid(grdNotaFiscal, Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnAgruparGridNotaFiscal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridNotaFiscal.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdNotaFiscal.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdNotaFiscal.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdNotaFiscal.GroupByBoxVisible = True
                grdNotaFiscal.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGridNotaFiscal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridNotaFiscal.Click

        Try

            'Exporta Grid - Excel
            Call ExportExcel(grdNotaFiscal)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridNotaFiscalProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridNotaFiscalProduto.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdNotaFiscalProduto
            oForm.NomeFormulario = Formulario.CadastroBasicoParceiroNegocio
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            ConfiguraGrid(grdNotaFiscalProduto, Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnAgruparGridNotaFiscalProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridNotaFiscalProduto.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdNotaFiscalProduto.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdNotaFiscalProduto.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdNotaFiscalProduto.GroupByBoxVisible = True
                grdNotaFiscalProduto.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGridNotaFiscalProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridNotaFiscalProduto.Click

        Try

            'Exporta Grid - Excel
            Call ExportExcel(grdNotaFiscalProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdNotaFiscal_SelectionChanged(sender As Object, e As EventArgs) Handles grdNotaFiscal.SelectionChanged

        Try

            Me.Select()

            'Verifica se foi Selecionado algum Registro
            If IsNothing(grdNotaFiscal.CurrentRow) = False Then

                'Carrega Grid - Produtos Similares
                Call oClsCadParceiroNegocio.LoadGridHistoricoNotaFiscalProduto(grdNotaFiscalProduto,
                                                                               grdNotaFiscal.CurrentRow.Cells("codigo_emissao_capa").Value)

            Else

                'Limpa Controle
                grdNotaFiscalProduto.DataSource = Nothing

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdNotaFiscal_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdNotaFiscal.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdNotaFiscal.Name,
                                     Formulario.CadastroBasicoParceiroNegocio,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdNotaFiscal_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdNotaFiscal.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdNotaFiscal,
                                     Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdNotaFiscal_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdNotaFiscal.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdNotaFiscal.Name,
                                          Formulario.CadastroBasicoParceiroNegocio,
                                          e.Group.Column.Key,
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False),
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdNotaFiscalProduto_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdNotaFiscalProduto.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdNotaFiscalProduto.Name,
                                     Formulario.CadastroBasicoParceiroNegocio,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdNotaFiscalProduto_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdNotaFiscalProduto.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdNotaFiscalProduto,
                                     Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdNotaFiscalProduto_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdNotaFiscalProduto.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdNotaFiscalProduto.Name,
                                          Formulario.CadastroBasicoParceiroNegocio,
                                          e.Group.Column.Key,
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False),
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: ESTOQUE :::"

    Private Sub LoadGridEstoque()

        Try

            'Verifica se foi Selecionado algum Registro
            If IsNothing(grdListagem.CurrentRow) = False Then
                oClsCadParceiroNegocio.LoadGridHistoricoEstoque(grdEstoque,
                                                                grdListagem.CurrentRow.Cells("codigo").Value)
            Else
                grdEstoque.DataSource = Nothing
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridEstoque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridEstoque.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdEstoque
            oForm.NomeFormulario = Formulario.CadastroBasicoParceiroNegocio
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            ConfiguraGrid(grdEstoque, Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnAgruparGridEstoque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridEstoque.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdEstoque.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdEstoque.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdEstoque.GroupByBoxVisible = True
                grdEstoque.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGridEstoque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridEstoque.Click

        Try

            'Exporta Grid - Excel
            Call ExportExcel(grdEstoque)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdEstoque_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdEstoque.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdEstoque.Name,
                                     Formulario.CadastroBasicoParceiroNegocio,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdEstoque_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdEstoque.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdEstoque,
                                     Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdEstoque_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdEstoque.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdEstoque.Name,
                                          Formulario.CadastroBasicoParceiroNegocio,
                                          e.Group.Column.Key,
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False),
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: CENTRO DE CUSTO :::"

    Private Sub btnAgruparGridCentroCusto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridCentroCusto.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdCentroCusto.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdCentroCusto.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdCentroCusto.GroupByBoxVisible = True
                grdCentroCusto.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridCentroCusto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridCentroCusto.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdCentroCusto
            oForm.NomeFormulario = Formulario.CadastroBasicoParceiroNegocio
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdCentroCusto, Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridCentroCusto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridCentroCusto.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdCentroCusto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarCentroCusto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCentroCusto.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrCadCentroGasto"
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location : oForm.Tamanho = True
            oForm.Titulo = Me.Parent.Text
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Carrega Combo
            LoadCombo(cboCentroCusto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)

            'Seta Focu
            cboCentroCusto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarCentroCusto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCentroCusto.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindCentroGasto"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Centro de Gasto"

            'Seta Váriaveis
            oComboBoxFind = cboCentroCusto

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCentroCusto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirCentroCusto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirCentroCusto.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Embalagem
            If ValidacaoCentroCusto() = True And IsNumeric(btnSalvar.Tag) = True Then

                'Verifica o Tipo de Operação
                If IsNumeric(btnInserirCentroCusto.Tag) Then

                    'Atualiza Registro
                    Call oClsCadParceiroNegocio.UpdateCentroCusto(btnSalvar.Tag,
                                                                  cboCentroCusto.SelectedValue,
                                                                  btnInserirCentroCusto.Tag)

                Else

                    'Insere Registro
                    Call oClsCadParceiroNegocio.InsertCentroCusto(btnSalvar.Tag,
                                                                  cboCentroCusto.SelectedValue)

                End If

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoCentroCusto()

                'Carrega Grid
                Call oClsCadParceiroNegocio.LoadGridCentroCusto(grdCentroCusto,
                                                                btnSalvar.Tag)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirCentroCusto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirCentroCusto.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Deleta CentroCusto
            Call DeleteCentroCusto()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdCentroCusto_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdCentroCusto.RowDoubleClick

        Try

            'Verifica se a célula pressionada é válida
            If IsNothing(grdCentroCusto.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdCentroCusto.CurrentColumn.Key
                Case "editar" : Call EditarCentroCusto()
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdCentroCusto_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdCentroCusto.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdCentroCusto,
                                     Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdCentroCusto_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdCentroCusto.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdCentroCusto.Name,
                                     Formulario.CadastroBasicoParceiroNegocio,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdCentroCusto_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdCentroCusto.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdCentroCusto.Name,
                                          Formulario.CadastroBasicoParceiroNegocio,
                                          e.Group.Column.Key,
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False),
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: CONTA CONTÁBIL :::"

    Private Sub btnAgruparGridContaContabil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridContaContabil.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdContaContabil.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdContaContabil.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdContaContabil.GroupByBoxVisible = True
                grdContaContabil.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridContaContabil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridContaContabil.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdContaContabil
            oForm.NomeFormulario = Formulario.CadastroBasicoParceiroNegocio
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdContaContabil, Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridContaContabil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridContaContabil.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdContaContabil)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarContaContabil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarContaContabil.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrCadPlanoContas"
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location : oForm.Tamanho = True
            oForm.Titulo = Me.Parent.Text
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Carrega Combo
            LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa)

            'Seta Focu
            cboContaContabil.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarContaContabil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarContaContabil.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindPlanoContas"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Conta Contábil"

            'Seta Váriaveis
            oComboBoxFind = cboContaContabil

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboContaContabil.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirContaContabil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirContaContabil.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Embalagem
            If ValidacaoContaContabil() = True And IsNumeric(btnSalvar.Tag) = True Then

                'Verifica o Tipo de Operação
                If IsNumeric(btnInserirContaContabil.Tag) Then

                    'Atualiza Registro
                    Call oClsCadParceiroNegocio.UpdateContaContabil(btnSalvar.Tag,
                                                          cboContaContabil.SelectedValue,
                                                          btnInserirContaContabil.Tag)

                Else

                    'Insere Registro
                    Call oClsCadParceiroNegocio.InsertContaContabil(btnSalvar.Tag,
                                                          cboContaContabil.SelectedValue)

                End If

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoContaContabil()

                'Carrega Grid
                Call oClsCadParceiroNegocio.LoadGridContaContabil(grdContaContabil,
                                                       btnSalvar.Tag)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirContaContabil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirContaContabil.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Deleta ContaContabil
            Call DeleteContaContabil()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdContaContabil_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdContaContabil.RowDoubleClick

        Try

            'Verifica se a célula pressionada é válida
            If IsNothing(grdContaContabil.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdContaContabil.CurrentColumn.Key
                Case "editar" : Call EditarContaContabil()
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdContaContabil_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdContaContabil.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdContaContabil,
                                     Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdContaContabil_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdContaContabil.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdContaContabil.Name,
                                     Formulario.CadastroBasicoParceiroNegocio,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdContaContabil_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdContaContabil.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdContaContabil.Name,
                                          Formulario.CadastroBasicoParceiroNegocio,
                                          e.Group.Column.Key,
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False),
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: AMOSTRA :::"

    Private Sub btnAgruparGridAmostra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridAmostra.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdContaContabil.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdContaContabil.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdContaContabil.GroupByBoxVisible = True
                grdContaContabil.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridAmostra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridAmostra.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdAmostra
            oForm.NomeFormulario = Formulario.CadastroBasicoParceiroNegocio
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdAmostra, Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridAmostra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridAmostra.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdAmostra)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirAmostra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirAmostra.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Item
            'If ValidacaoAmostra() = True Then

            'Salva Dados do Registro
            Call SalvarAmostra()
            Call LoadGridAmostra()

            'Prepara Formulário para Inserção de um Novo Registro
            Call NovoAmostra()

            'End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirAmostra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirAmostra.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Item
            'If ValidacaoAmostra() = True Then

            'Salva Dados do Registro
            Call DeleteAmostra()
            ''Prepara Formulário para Inserção de um Novo Registro
            'Call NovoAmostra()

            'End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdAmostra_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdAmostra.RowDoubleClick

        Try

            'Verifica se a célula pressionada é válida
            If IsNothing(grdAmostra.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdAmostra.CurrentColumn.Key
                Case "editar" : Call EditarAmostra(grdAmostra.CurrentRow.Cells("codigo").Value)
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: CONTA BANCÁRIA :::"

    Private Sub btnInserirConta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirConta.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Produto
            If IsNumeric(btnSalvar.Tag) = False Then
                'Salva Produto
                Call Salvar()
            End If

            'Valida Dados do Formulário
            If ValidacaoConta() = True Then

                If IsNumeric(btnInserirConta.Tag) = False Then

                    'Insere  
                    oClsCadParceiroNegocio.InsertConta(txtAgencia.Text,
                                                       txtConta.Text,
                                                       cboBanco.SelectedIndex,
                                                       iCodigoParceiro)

                Else

                    'Atualiza  
                    oClsCadParceiroNegocio.UpdateConta(txtAgencia.Text,
                                                       txtConta.Text,
                                                       cboBanco.SelectedValue,
                                                       btnInserirConta.Tag,
                                                       iCodigoParceiro)

                End If

                'Carrega Grid
                Call LoadGridConta()

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoConta()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirConta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirConta.Click

        Try

            'Deleta Registros
            Call DeleteConta()

            'Prepara Formulário para Inserção de um Novo Registro
            Call NovoConta()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdConta_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdConta.RowDoubleClick

        Try

            'Verifica se foi pressionado uma Célula Válida
            If IsNothing(grdConta.CurrentRow) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdConta.CurrentColumn.Key

                Case "editar" : Call EditarConta()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdConta_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdConta.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdConta,
                                     Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdConta_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdConta.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdConta.Name,
                                     Formulario.CadastroBasicoParceiroNegocio,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdConta_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdConta.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdConta.Name,
                                          Formulario.CadastroBasicoParceiroNegocio,
                                          e.Group.Column.Key,
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False),
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: CHECKLIST CLIENTE :::"

    Private Sub grdOrcamentoCheckListCliente_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdOrcamentoCheckListCliente.CellUpdated

        Try

            UpdateChecklistCliente()

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

            iFormulario = LoadCodigo("sp_select_static_formulario_codigo_user_control '" & Me.Name & "'")
            iFormularioGrid = iFormulario

            'Adiciona KeyUP
            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadParceiroNegocio_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcDelete)
            btnNovo1.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcInsert)
            btnNovo.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcInsert)
            btnSalvarContato.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioContatos, gcInsert)
            btnExcluirContato.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioContatos, gcDelete)
            btnExcelGridContato.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioContatos, gcPrint)
            btnSalvarEndereco.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioEnderecos, gcInsert)
            btnExcluirEndereco.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioEnderecos, gcDelete)
            btnExcelGridEndereco.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioEnderecos, gcPrint)
            btnSalvarCRM.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcInsert)
            btnExcluirCRM.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcDelete)
            btnExcelGridCRM.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcPrint)
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
            btnCadastrarCampanha.Enabled = VerificaDireito(Formulario.CadastroBasicoCampanhaAbrangencia, gcInsert)
            grdMarca.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioClienteMarcasHomologadas, gcInsert)
            btnCadastrarCentroCusto.Enabled = VerificaDireito(Formulario.CadastroBasicoCentroGasto, gcInsert)
            btnCadastrarContaContabil.Enabled = VerificaDireito(Formulario.CadastroBasicoPlanoContas, gcInsert)

            tabDadosBancarios.TabVisible = False

            grdListagem.RootTable.Columns.Remove("parceiro")

            If tabDados.TabPages.Contains(pagEspacoLeSix) = True Then tabDados.TabPages.Remove(pagEspacoLeSix) : txtCPFAcompanhante.Mask = "000,000,000-00"
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
            Call LoadCombo(cboRegimeTributario, "sp_select_combo_static_regime_tributario")
            Call LoadCombo(cboTipoInscricaoEstadual, "sp_select_combo_static_tipo_inscricao_estadual")
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
            Call LoadCombo(cboCampanha, "sp_select_combo_cadastro_basico_campanha_abrangencia " & goUsuario.iEmpresa)
            Call LoadCombo(cboCentroCusto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, 1, 1 ")
            Call LoadCombo(cboEstadoCivilAcompanhante, "sp_select_combo_static_estado_civil")
            Call LoadCombo(cboEstadoCivilCliente, "sp_select_combo_static_estado_civil")
            Call LoadCombo(cboPaisAcompanhante, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)
            Call LoadCombo(cboBanco, "sp_select_combo_cadastro_basico_banco " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboGrupoTecnologia, "sp_select_combo_static_grupo_tecnologia")
            Call LoadCombo(cboCategoria, "sp_select_combo_static_categoria_parceiro_negocio", False)
            Call LoadCombo(cboUnidadeNegocio, "sp_select_combo_static_unidade_negocio")
            Call LoadCombo(cboMercado, "sp_select_combo_static_mercado")
            LoadComboSimNao(cboIncidePisCofins)

            'Carrega Combo - Grid
            Call LoadComboGrid(grdListagem, "vendedor", "sp_select_combo_cadastro_basico_vendedor " & goUsuario.iEmpresa & ", " & goUsuario.iUsuario)
            Call LoadComboGrid(grdListagem, "vendedor_interno", "sp_select_combo_cadastro_basico_vendedor " & goUsuario.iEmpresa & ", " & goUsuario.iUsuario)
            If goDatabase.sInitialCatalog <> "INTERACTI_MODULINE_SJC_PRD" Then
                Call LoadCombo(cboTipoFrasco, "sp_select_combo_cadastro_basico_tipo_frasco " & goUsuario.iEmpresa)
            End If
            'Seta Controles
            dtpDataInicioOrcamento.Value = DateAdd(DateInterval.Year, -1, Now.Date)
            dtpDataInicioPedidoVenda.Value = DateAdd(DateInterval.Year, -1, Now.Date)
            dtpDataInicioNotaFiscal.Value = DateAdd(DateInterval.Year, -1, Now.Date)
            dtpDataTerminoOrcamento.Value = Now.Date
            dtpDataTerminoPedidoVenda.Value = Now.Date
            dtpDataTerminoNotaFiscal.Value = Now.Date

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
            Call ConfiguraGrid(grdContasRecebidas, Formulario.CadastroBasicoParceiroNegocio)
            Call ConfiguraGrid(grdContasAberto, Formulario.CadastroBasicoParceiroNegocio)
            Call ConfiguraGrid(grdOrcamento, Formulario.CadastroBasicoParceiroNegocio)
            Call ConfiguraGrid(grdOrcamentoProduto, Formulario.CadastroBasicoParceiroNegocio)
            Call ConfiguraGrid(grdPedidoVenda, Formulario.CadastroBasicoParceiroNegocio)
            Call ConfiguraGrid(grdPedidoVendaProduto, Formulario.CadastroBasicoParceiroNegocio)
            Call ConfiguraGrid(grdCentroCusto, Formulario.CadastroBasicoParceiroNegocio)
            Call ConfiguraGrid(grdContaContabil, Formulario.CadastroBasicoParceiroNegocio)
            Call ConfiguraGrid(grdOrcamentoCheckListCliente, iFormulario)

            AddMenuGrid(grdOrcamentoCheckListCliente)

            'Configura Controles - CalendarCombo
            dtpDataFundacao.Value = Now.Date : dtpDataFundacao.Checked = False
            dtpDataCadastro.Value = Now.Date : dtpDataCadastro.Checked = False

            Call LoadGridAmostra()

            'Seta Focu
            cboTipoParceiroNegocioFiltro.Focus()

            'Verifica a Tag      
            If IsNothing(Me.Tag) = False Then
                If Me.Tag.ToString.Contains("CODIGO:") Then
                    'Carrega a Grid
                    Call LoadGrid()
                    grdListagem.Find(grdListagem.RootTable.Columns("codigo"), ConditionOperator.Equal, Me.Tag.ToString.Replace("CODIGO:", ""), 1, 1)
                    tabMain.SelectedTab = pagDados
                ElseIf Me.Tag = "NOVO" Then
                    Call btnNovo1_Click(btnNovo1, System.EventArgs.Empty)
                Else
                    Call LoadGrid()
                End If
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: CONFIGURA GRID :::"

    Private Sub AddMenuGrid(ByVal oControl As Control)

        Try

            If TypeOf (oControl) Is GridEX Then

                Dim oGrid As GridEX = oControl
                oGrid.DynamicFiltering = True
                oGrid.FilterMode = FilterMode.Automatic

                ConfigurarBuiltInTextsGrid(oGrid)

                Dim oUICommandManager As New Janus.Windows.UI.CommandBars.UICommandManager
                Dim oUIContextMenu As New Janus.Windows.UI.CommandBars.UIContextMenu

                Dim oUICommandAdicionarCheckListCliente As New Janus.Windows.UI.CommandBars.UICommand
                Dim oUICommandExcluirCheckListCliente As New Janus.Windows.UI.CommandBars.UICommand

                oUICommandAdicionarCheckListCliente.Text = "Adicionar Cheklist Cliente" : oUICommandAdicionarCheckListCliente.Key = "adicionar_checklist_cliente"
                oUICommandExcluirCheckListCliente.Text = "Excluir Cheklist Cliente" : oUICommandExcluirCheckListCliente.Key = "excluir_checklist_cliente"

                oUICommandManager.Commands.Add(oUICommandAdicionarCheckListCliente)
                oUICommandManager.Commands.Add(oUICommandExcluirCheckListCliente)

                oUIContextMenu.Commands.Add(oUICommandAdicionarCheckListCliente)
                oUIContextMenu.Commands.Add(oUICommandExcluirCheckListCliente)
                oUICommandManager.SetContextMenu(oControl, oUIContextMenu)

                AddCommandClick(oUICommandAdicionarCheckListCliente, New DelegateCommandClick(AddressOf Button_CommandClick_Orcamento), oControl)
                AddCommandClick(oUICommandExcluirCheckListCliente, New DelegateCommandClick(AddressOf Button_CommandClick_Orcamento), oControl)
                AddMouseClick(oControl, New DelegateMouseClick(AddressOf Grid_MouseClick))

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Grid_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs)

        Try

            If e.Button = MouseButtons.Right Then

                Dim oGrid As GridEX = sender

                oGrid.CurrentColumn = oGrid.ColumnFromPoint(e.X, e.Y)

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Button_CommandClick_Orcamento(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs)

        Try

            'Váriavel
            Dim oUICommand As Janus.Windows.UI.CommandBars.UICommand = sender

            'Verifica o Tipo de Controle
            Select Case oUICommand.Key

                Case "adicionar_checklist_cliente"

                    Dim oForm As New frmCadParceiroNegocioAdicionarChecklistCliente
                    oForm.CodigoParceiroNegocio = btnSalvar.Tag
                    oForm.ShowDialog()

                    LoadGridChecklistCliente()

                Case "excluir_checklist_cliente"

                    If MsgBox("Deseja excluir permanentemente este registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Validação") <> MsgBoxResult.Yes Then Exit Sub

                    oClsCadParceiroNegocio.DeleteChecklistCliente(btnSalvar.Tag, grdOrcamentoCheckListCliente.GetValue("codigo"))
                    grdOrcamentoCheckListCliente.CurrentRow.Delete()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

            End Select

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: PARCEIRO DE NEGÓCIO :::"

    Private Sub Delete()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

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

            iCodigoParceiro = grdListagem.CurrentRow.Cells("codigo").Value

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcUpdate) = True Then

                'Limpa Formulário
                Call Novo()

                'Carrega Controles
                oClsCadParceiroNegocio.LoadControles(iCodigo,
                                                     chkAgenteLogistico,
                                                     chkCliente,
                                                     chkFornecedor,
                                                     chkDespachante,
                                                     cboPersonalidade,
                                                     txtRazaoSocial,
                                                     txtNomeFantasia,
                                                     cboSegmento,
                                                     cboAtivo,
                                                     txtCnpjCpf,
                                                     cboRegimeTributario,
                                                     txtCNAE,
                                                     cboTipoInscricaoEstadual,
                                                     txtInscricaoEstadual,
                                                     txtInscricaoEstadualSubstitutoTriburario,
                                                     txtInscricaoMunicipal,
                                                     txtInscricaoSuframa,
                                                     txtLogradouro,
                                                     txtNumero,
                                                     txtBairro,
                                                     cboMunicipio,
                                                     cboPais,
                                                     cboUF,
                                                     txtComplemento,
                                                     txtCEP,
                                                     cboVendedor,
                                                     cboVendedorInterno,
                                                     dtpDataFundacao,
                                                     dtpDataCadastro,
                                                     txtObservacao,
                                                     txtTelefone1,
                                                     txtTelefone2,
                                                     txtTelefoneRecado,
                                                     txtFax,
                                                     txtEmail,
                                                     txtEmail2,
                                                     cboCondicaoPagamento,
                                                     cboFormaPagamento,
                                                     cboMoeda,
                                                     cboModalidadeFrete,
                                                     txtCodigoIntegracao,
                                                     cboEnviarAR,
                                                     cboCampanha,
                                                     txtNumeroMesesValidadeProduto,
                                                     cboDestinacaoPadrao,
                                                     txtLimiteCredito,
                                                     cboInstrucao1,
                                                     cboInstrucao2,
                                                     txtNumeroDias1,
                                                     txtNumeroDias2,
                                                     cboCondicaoPagamentoFornecedor,
                                                     cboFormaPagamentoFornecedor,
                                                     cboMoedaFornecedor,
                                                     cboModalidadeFreteFornecedor,
                                                     txtClassificacaoFornecedor,
                                                     cboTipoNegativacao,
                                                     dtpDataNegativacao,
                                                     txtTextoNegativacao,
                                                     cboBanco,
                                                     txtAgencia,
                                                     txtConta,
                                                     cboGrupoTecnologia,
                                                     cboCategoria,
                                                     txtAliquotaICMS,
                                                     txtAliquotaIPI,
                                                     cboIncidePisCofins,
                                                     txtAliquotaPIS,
                                                     txtAliquotaCOFINS,
                                                     txtAliquotaISS,
                                                     txtPorcentagemReducaoBCICMS,
                                                     txtAliquotaICMSReduzida,
                                                     txtValidadeOrcamento,
                                                     chkFerramental,
                                                     chkProduto,
                                                     cboUnidadeNegocio,
                                                     cboMercado,
                                                     chkCelular,
                                                     chkCelular2)

                'Seta Código
                btnSalvar.Tag = iCodigo

                'Carrega Grid de Contato
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

                'Carrega Grid
                Call LoadGridConta()

                'Carrega Grid de Arquivos
                Call LoadGridArquivoBD(grdArquivo, "tb_cad_parceiro_negocio", iCodigo)

                'Carrega Grid de Requisitos do cliente
                LoadGridChecklistCliente()

                tabDados.SelectedTab = pagDadosGerais

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

    Private Sub EmailParceiroNegocio(ByVal iCodigo As Integer)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Dim oRptDocument As New ReportDocument

            'Abre Relatório
            oRptDocument.Load(goCrystalReport.sPath & "CAD000000008.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)

            'Seta Parametros Relatório
            oRptDocument.SetParameterValue("@codigo", iCodigo)
            oRptDocument.SetParameterValue("@codigo_empresa", goUsuario.iEmpresa)

            'Abre Conexão com o Banco de Dados
            For i = 0 To oRptDocument.DataSourceConnections.Count - 1
                oRptDocument.DataSourceConnections.Item(i).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)
            Next

            'Váriavel Relatório
            Dim sArquivoReport As String = System.IO.Path.GetTempFileName().Replace(".tmp", ".pdf")

            'Verifica se o Arquivo Existe
            If File.Exists(sArquivoReport) = True Then File.Delete(sArquivoReport)

            'Exporta para Arquivo PDF
            oRptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, sArquivoReport)

            'Limpa Váriavel
            oRptDocument = Nothing

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Enviar E-mail
            Call EnviarEmail("Dados Cadastrais", _
                             "", _
                             sArquivoReport, _
                             sArquivoReport, _
                             "", _
                             iCodigo)


        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub ImprimirParceiroNegocio(ByVal iCodigo As Integer)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Redimenciona Vetor
            ReDim goCrystalReport.sReportParameter(1)
            'Seta Parametros
            goCrystalReport.sReportParameter(0).sParamenter = "@codigo"
            goCrystalReport.sReportParameter(0).sValue = iCodigo
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa

            goCrystalReport.sReport = goCrystalReport.sPath & "CAD000000008.rpt"

            Dim oReport As New usrReport
            oReport.Dock = DockStyle.Fill

            frmMain.LoadPageReport("CAD000000008", "Relatório - Ficha do Parceiro de Negócio", oReport)

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

            cboBanco.SelectedIndex = -1 : cboBanco.Text = ""
            txtAgencia.Text = ""
            txtConta.Text = ""

            LimparCamposGroupBox(grpImpostos)

            cboUnidadeNegocio.UncheckAll()
            cboMercado.UncheckAll()
            chkFerramental.Checked = False
            chkProduto.Checked = False



            'Limpa Controles - Dados Gerais
            cboCategoria.SelectedIndex = -1
            cboGrupoTecnologia.Clear()
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
            chkCelular.Checked = True
            txtTelefone2.Text = ""
            chkCelular2.Checked = True
            txtFax.Text = ""
            txtTelefoneRecado.Text = ""
            txtEmail.Text = ""
            txtEmail2.Text = ""
            cboVendedor.SelectedIndex = -1 : cboVendedor.Text = ""
            cboVendedorInterno.SelectedIndex = -1 : cboVendedorInterno.Text = ""
            txtObservacao.Text = ""
            dtpDataFundacao.Value = Now.Date : dtpDataFundacao.Checked = False
            dtpDataCadastro.Value = Now.Date : dtpDataCadastro.Checked = False
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
            cboInstrucao1.SelectedIndex = -1
            cboInstrucao2.SelectedIndex = -1
            txtNumeroDias1.Value = 0 : txtNumeroDias1.Enabled = False
            txtNumeroDias2.Value = 0 : txtNumeroDias2.Enabled = False
            cboEnviarAR.SelectedIndex = -1
            cboDestinacaoPadrao.SelectedIndex = -1
            txtNumeroMesesValidadeProduto.Value = 0
            txtValidadeOrcamento.Value = 0

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

            'Limpa Controles - Classificação
            cboCentroCusto.Text = ""
            cboContaContabil.Text = ""
            grdCentroCusto.DataSource = Nothing
            grdContaContabil.DataSource = Nothing

            'Desabilita Abas
            If VerificaDireito(Formulario.CadastroBasicoParceiroNegocioContatos, gcSelect) = False Then tabDados.TabPages.Remove(pagContato)
            If VerificaDireito(Formulario.CadastroBasicoParceiroNegocioEnderecos, gcSelect) = False Then tabDados.TabPages.Remove(pagEndereco)
            tabDados.TabPages.Remove(pagDadosCliente)
            tabDados.TabPages.Remove(pagDadosFornecedor)
            tabDados.TabPages.Remove(pagNegativacao)
            tabDados.TabPages.Remove(pagRelacionamento)
            tabDados.TabPages.Remove(pagCertificado)
            tabDados.TabPages.Remove(pagMarca)
            tabDados.TabPages.Remove(pagEspacoLeSix)

            'Espaço Le Six
            txtNacionalidadeCliente.Text = ""
            txtProfissaoCliente.Text = ""
            cboEstadoCivilCliente.SelectedIndex = -1
            txtNomeAcompanhante.Text = ""
            txtProfissaoAcompanhante.Text = ""
            cboEstadoCivilAcompanhante.SelectedIndex = -1
            txtRGAcompanhante.Text = ""
            txtCPFAcompanhante.Text = ""
            txtCEPaAcompanhante.Text = ""
            cboPaisAcompanhante.SelectedIndex = -1
            cboUFAcompanhante.SelectedIndex = -1
            cboMunicipioAcompanhante.SelectedIndex = -1
            txtLogradouroAcompanhante.Text = ""
            txtNumeroAcompanhante.Text = ""
            txtBairroAcompanhante.Text = ""
            txtComplementoAcompanhante.Text = ""
            txNacionalidadeAcompanhante.Text = ""

            'Desabilita Controles
            chkAgenteLogistico.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioAgenteLogistico, gcInsert)
            chkDespachante.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioDespachante, gcInsert)
            chkCliente.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioCliente, gcInsert)
            chkFornecedor.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioFornecedor, gcInsert)

            'limpa requisitos do cliente
            grdOrcamentoCheckListCliente.DataSource = Nothing

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


            Dim i As Integer

            'Seta Parametros
            oClsCadParceiroNegocio.Ferramental = chkFerramental.Checked
            oClsCadParceiroNegocio.produto = chkProduto.Checked
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
            oClsCadParceiroNegocio.CodigoTipoInscricaoEstadual = cboTipoInscricaoEstadual.SelectedValue
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
            oClsCadParceiroNegocio.Email2 = txtEmail2.Text
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
            oClsCadParceiroNegocio.CodigoCampanha = IIf(cboCampanha.SelectedIndex = -1, -1, cboCampanha.SelectedValue)
            oClsCadParceiroNegocio.NumeroMesesValidadeProduto = txtNumeroMesesValidadeProduto.Value
            oClsCadParceiroNegocio.CodigoDestinacao = IIf(cboDestinacaoPadrao.SelectedIndex = -1, -1, cboDestinacaoPadrao.SelectedValue)
            oClsCadParceiroNegocio.LimiteCredito = txtLimiteCredito.Value
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
            oClsCadParceiroNegocio.CodigoCategoria = cboCategoria.SelectedValue
            oClsCadParceiroNegocio.PorcentagemReducaoBaseCalculoICMS = txtPorcentagemReducaoBCICMS.Value
            oClsCadParceiroNegocio.AliquotaICMS = txtAliquotaICMS.Value
            oClsCadParceiroNegocio.AliquotaICMSReduzida = txtAliquotaICMSReduzida.Value
            oClsCadParceiroNegocio.AliquotaIPI = txtAliquotaIPI.Value
            oClsCadParceiroNegocio.IncidePISCOFINS = IIf(cboIncidePisCofins.SelectedIndex = -1, 0, cboIncidePisCofins.SelectedValue)
            oClsCadParceiroNegocio.AliquotaPIS = txtAliquotaPIS.Value
            oClsCadParceiroNegocio.AliquotaCOFINS = txtAliquotaCOFINS.Value
            oClsCadParceiroNegocio.AliquotaISS = txtAliquotaISS.Value
            oClsCadParceiroNegocio.ValidadeOrcamentoDias = txtValidadeOrcamento.Value
            oClsCadParceiroNegocio.CheckTelefone1 = chkCelular.Checked
            oClsCadParceiroNegocio.CheckTelefone2 = chkCelular2.Checked

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


                btnSalvar.Tag = oClsCadParceiroNegocio.Codigo

                frmMain.Informacao(Mensagem.RegistroInserido)

            End If


            'Dim sUnidadeNegocio As String = ""
            oClsCadParceiroNegocio.DeleteUnidadeNegocio(btnSalvar.Tag)

            If cboUnidadeNegocio.SelectionLength > 0 Then
                For i = 0 To UBound(cboUnidadeNegocio.CheckedValues)
                    oClsCadParceiroNegocio.InsertUnidadeNegocio(btnSalvar.Tag,
                                                         cboUnidadeNegocio.CheckedValues(i).ToString)
                Next
            End If

            Dim sGrupoTecnologia As String = ""

            If cboGrupoTecnologia.SelectionLength > 0 Then
                For i = 0 To UBound(cboGrupoTecnologia.CheckedValues)
                    sGrupoTecnologia &= IIf(sGrupoTecnologia = "", "", ",") & cboGrupoTecnologia.CheckedValues(i).ToString
                Next

                oClsCadParceiroNegocio.InsertGrupoTecnologia(btnSalvar.Tag,
                                                             sGrupoTecnologia)

            End If

            oClsCadParceiroNegocio.DeleteMercado(btnSalvar.Tag)
            If cboMercado.SelectionLength > 0 Then
                For i = 0 To UBound(cboMercado.CheckedValues)
                    oClsCadParceiroNegocio.InsertMercado(btnSalvar.Tag,
                                                         cboMercado.CheckedValues(i).ToString)
                Next
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
                                            IIf(cboTipoNegativacaoFiltro.SelectedIndex = -1, -1, cboTipoNegativacaoFiltro.SelectedValue), -1, -1, -1, -1)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    'Private Sub GrupoTecnologia()

    '    Try

    '        Dim sGrupoTecnologia As String
    '        Dim i As Integer

    '        oClsCadParceiroNegocio.DeleteGrupoTecnologia()

    '        If cboGrupoTecnlogia.SelectionLength > 0 Then
    '            For i = 0 To UBound(cboGrupoTecnlogia.CheckedValues)
    '                oClsCadParceiroNegocio.InsertGrupoTecnologia(cboGrupoTecnlogia.CheckedValues)
    '                sGrupoTecnologia &= IIf(sGrupoTecnologia = "", "", ",") & cboGrupoTecnlogia.CheckedValues(i).ToString
    '            Next
    '        End If





    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    'End Sub

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

            'Verifica se foi Preenchido Corretamente o Campo - Email
            If txtEmail.Text.Trim <> "" Then
                If ValidaCampo(txtEmail, lblEmail, TipoCampo.email) = False Then
                    tabDados.SelectedTab = pagDadosGerais : txtEmail.Focus() : Exit Function
                End If
            End If

            If txtEmail2.Text.Trim <> "" Then
                If ValidaCampo(txtEmail2, lblEmail2, TipoCampo.email) = False Then
                    tabDados.SelectedTab = pagDadosGerais : txtEmail2.Focus() : Exit Function
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

            'Verifica se foi Selecionado o Campo - Tipo de Inscrição Estadual
            If ValidaCampo(cboTipoInscricaoEstadual, lblTipoInscricaoEstadual) = False Then
                tabDados.SelectedTab = pagDadosGerais : cboTipoInscricaoEstadual.Focus() : Exit Function
            End If

            If cboPersonalidade.Text <> "FÍSICA" Then

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

            'Verifica se foi Selcionado o Campo - Tipo de Negativação
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

            'Verifica se foi Preenchido o Campo - Número Meses Validade do Produto
            If ValidaCampo(txtNumeroMesesValidadeProduto, lblNumeroMesesValidadeProduto, False) = False Then
                tabDados.SelectedTab = pagDadosCliente
                txtNumeroMesesValidadeProduto.Focus()
                Exit Function
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

            If ValidaCampo(cboCategoria, lblCategoria) = False Then
                Exit Function
            End If

            If cboIncidePisCofins.SelectedValue = True Then

                If ValidaCampo(txtAliquotaPIS, lblAliquotaPIS, True) = False Then
                    tabDados.SelectedTab = pagImpostos
                    txtAliquotaPIS.Focus()
                    Exit Function
                End If

                If ValidaCampo(txtAliquotaCOFINS, lblAliquotaCOFINS, True) = False Then
                    tabDados.SelectedTab = pagImpostos
                    txtAliquotaCOFINS.Focus()
                    Exit Function
                End If

            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function ValidacaoEspacoLeSix() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoEspacoLeSix = False

            If ValidaCampo(txtNacionalidadeCliente, lblNacionalidadeCliente, TipoCampo.texto) = False Then
                tabDados.SelectedTab = pagEspacoLeSix
                Exit Function
            End If

            'If ValidaCampo(txNacionalidadeAcompanhante, lblNacionalidadeAcompanhante, TipoCampo.texto) = False Then
            '    tabDados.SelectedTab = pagEspacoLeSix
            '    Exit Function
            'End If

            'If ValidaCampo(txtProfissaoAcompanhante, lblProfissaoAcompanhante, TipoCampo.texto) = False Then
            '    tabDados.SelectedTab = pagEspacoLeSix
            '    Exit Function
            'End If

            If ValidaCampo(txtProfissaoCliente, lblProfissaoCliente, TipoCampo.texto) = False Then
                tabDados.SelectedTab = pagEspacoLeSix
                Exit Function
            End If

            If ValidaCampo(cboEstadoCivilCliente, lblEstadoCivilCliente) = False Then
                tabDados.SelectedTab = pagEspacoLeSix
                Exit Function
            End If

            'If ValidaCampo(cboEstadoCivilAcompanhante, lblEstadoCivilAcompanhante) = False Then
            '    tabDados.SelectedTab = pagEspacoLeSix
            '    Exit Function
            'End If

            'If ValidaCampo(txtRGAcompanhante, lblRGAcompanhante, TipoCampo.texto) = False Then
            '    tabDados.SelectedTab = pagEspacoLeSix
            '    Exit Function
            'End If

            'If txtCPFAcompanhante.Text <> "" Then
            '    If ValidaCPF(txtCPFAcompanhante.Text.Trim) = False Then
            '        frmMain.errInfo.SetError(lblCPFAcompanhante, "Este CPF não é válido!")
            '        txtCnpjCpf.Focus()
            '        Exit Function
            '    End If
            'End If

            'If ValidaCampo(txtNomeAcompanhante, lblNomeAcompanhante, TipoCampo.texto) = False Then
            '    tabDados.SelectedTab = pagEspacoLeSix
            '    Exit Function
            'End If




            'Seta Retorno da Função
            ValidacaoEspacoLeSix = True

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

    Private Sub ICMS_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPorcentagemReducaoBCICMS.LostFocus, _
                                                                                            txtAliquotaICMS.LostFocus

        Try

            CalculaICMSReduzido()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub CalculaICMSReduzido()

        Try

            Dim dAliquotaICMS As Double = 0

            If txtPorcentagemReducaoBCICMS.Value <= 0 Then
                dAliquotaICMS = txtAliquotaICMS.Value
            Else
                dAliquotaICMS = Math.Round(((100 - txtPorcentagemReducaoBCICMS.Value) / 100.0) / (100 / IIf(txtAliquotaICMS.Value <= 0, 1, txtAliquotaICMS.Value)) * 100.0)
            End If

            txtAliquotaICMSReduzida.Value = dAliquotaICMS

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
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Deleta Contato
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

    Private Sub DuplicarEndereco()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoParceiroNegocioEnderecos, gcInsert) = True Then

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

                    'Seta Focu
                    cboTipoEndereco.Focus()

                End With

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoInserir)
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
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Deleta Endereço
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
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

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
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

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
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    For Each oRow As GridEXRow In gSelecaoRow
                        modFunction.DeleteArquivoBD("tb_cad_parceiro_negocio", oRow.Cells("path").Value, btnSalvar.Tag)
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
            If VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcUpdate) = True Then

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

#Region "::: CENTRO DE CUSTO :::"

    Private Sub EditarCentroCusto()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcUpdate) = True Then

                With grdCentroCusto.CurrentRow.Cells

                    'Carrega Controles
                    cboCentroCusto.SelectedValue = .Item("codigo").Value
                    btnInserirCentroCusto.Tag = .Item("codigo").Value

                End With

                'Seta Focu
                cboCentroCusto.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoCentroCusto()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Contato
            cboCentroCusto.Text = ""
            btnInserirCentroCusto.Tag = ""

            'Seta Focu
            cboCentroCusto.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteCentroCusto()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdCentroCusto) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsCadParceiroNegocio.DeleteCentroCusto(btnSalvar.Tag)

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

    Private Function ValidacaoCentroCusto() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoCentroCusto = False

            'Verifica se foi Selecionado o Campo - CentroCusto
            If ValidaCampo(cboCentroCusto, lblCentroCusto) = False Then
                Exit Function
            End If

            'Verifica se já existe o CentroCusto Inserido
            If IsNumeric(btnInserirCentroCusto.Tag) = False Then
                If VerificaExisteValorGrid(grdCentroCusto, "codigo", cboCentroCusto.SelectedValue, -1) = True Then
                    frmMain.errInfo.SetError(lblCentroCusto, "Este Centro de Gasto: " & cboCentroCusto.Text & " já se encontra cadastrado para este Item.")
                    cboCentroCusto.Focus()
                    Exit Function
                End If
            Else
                If VerificaExisteValorGrid(grdCentroCusto, "codigo", cboCentroCusto.SelectedValue, grdCentroCusto.CurrentRow.RowIndex) = True Then
                    frmMain.errInfo.SetError(lblCentroCusto, "Este Centro de Gasto: " & cboCentroCusto.Text & " já se encontra cadastrado para este Item.")
                    cboCentroCusto.Focus()
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            ValidacaoCentroCusto = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: CONTA CONTÁBIL :::"

    Private Sub EditarContaContabil()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcUpdate) = True Then

                With grdContaContabil.CurrentRow.Cells

                    'Carrega Controles
                    cboContaContabil.SelectedValue = .Item("codigo").Value
                    btnInserirContaContabil.Tag = .Item("codigo").Value

                End With

                'Seta Focu
                cboContaContabil.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoContaContabil()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Contato
            cboContaContabil.Text = ""
            btnInserirContaContabil.Tag = ""

            'Seta Focu
            cboContaContabil.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteContaContabil()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdContaContabil) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsCadParceiroNegocio.DeleteContaContabil(btnSalvar.Tag)

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

    Private Function ValidacaoContaContabil() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoContaContabil = False

            'Verifica se foi Selecionado o Campo - ContaContabil
            If ValidaCampo(cboContaContabil, lblContaContabil) = False Then
                Exit Function
            End If

            'Verifica se já existe o ContaContabil Inserido
            If IsNumeric(btnInserirContaContabil.Tag) = False Then
                If VerificaExisteValorGrid(grdContaContabil, "codigo", cboContaContabil.SelectedValue, -1) = True Then
                    frmMain.errInfo.SetError(lblContaContabil, "Esta Conta Contábil: " & cboContaContabil.Text & " já se encontra cadastrado para este Item.")
                    cboContaContabil.Focus()
                    Exit Function
                End If
            Else
                If VerificaExisteValorGrid(grdContaContabil, "codigo", cboContaContabil.SelectedValue, grdContaContabil.CurrentRow.RowIndex) = True Then
                    frmMain.errInfo.SetError(lblContaContabil, "Esta Conta Contábil: " & cboContaContabil.Text & " já se encontra cadastrado para este Item.")
                    cboContaContabil.Focus()
                    Exit Function
                End If
            End If

            'Seta Retorno da Função
            ValidacaoContaContabil = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: AMOSTRA :::"

    Private Sub EditarAmostra(ByVal iCodigo As Integer)

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcUpdate) = True Then

                With grdAmostra.CurrentRow.Cells

                    'Carrega Controles
                    txtNumeroPedido.Text = .Item("numero_pedido").Value
                    cboProduto.SelectedValue = .Item("codigo_produto").Value
                    cboTipoFrasco.SelectedValue = .Item("codigo_frasco").Value
                    dtpDataAmostra.Value = .Item("data").Value
                    btnInserirAmostra.Tag = .Item("codigo").Value

                End With

                'Alterna Aba
                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                cboProduto.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteAmostra()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdAmostra) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCadParceiroNegocio.DeleteAmostra()

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

    Private Sub NovoAmostra()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            txtNumeroPedido.Text = ""
            cboProduto.SelectedValue = Nothing
            cboTipoFrasco.SelectedValue = Nothing
            btnInserirAmostra.Tag = ""

            'Seta Focu
            cboProduto.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarAmostra()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCadParceiroNegocio.Codigo = IIf(IsNumeric(btnInserirAmostra.Tag), btnInserirAmostra.Tag, 0)
            oClsCadParceiroNegocio.NumeroPedido = txtNumeroPedido.Text
            oClsCadParceiroNegocio.CodigoProduto = cboProduto.SelectedValue
            oClsCadParceiroNegocio.TipoFrasco = cboTipoFrasco.SelectedValue
            oClsCadParceiroNegocio.Data = dtpDataAmostra.Value

            'Verifica o Tipo de Operação
            If Len(btnInserirAmostra.Tag) > 0 Then
                oClsCadParceiroNegocio.UpdateAmostra()
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                oClsCadParceiroNegocio.InsertAmostra()
                frmMain.Informacao(Mensagem.RegistroInserido)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridAmostra()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCadParceiroNegocio.LoadGridAmostra(grdAmostra)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoAmostra() As Boolean

        'Try

        '    'Seta Retorno da Função
        '    ValidacaoAmostra = False

        '    'Verifica se foi Preenchido o Campo - Descrição
        '    If ValidaCampo(txtDescricao, lblDescricao, TipoCampo.texto) = False Then
        '        Exit Function
        '    End If

        '    'Passa Parametros
        '    If oClsCadTipoFrasco.ValidaDescricao(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0), _
        '                                           txtDescricao.Text.Trim) = False Then
        '        frmMain.errInfo.SetError(lblDescricao, "Este tipo de frasco: " & txtDescricao.Text & " já está associado a outro Registro.")
        '        txtDescricao.Focus()
        '        Exit Function
        '    End If

        '    'Verifica se foi Preenchido o Campo - Ativo
        '    If ValidaCampo(cboAtivo, lblAtivo) = False Then
        '        Exit Function
        '    End If

        '    'Seta Retorno da Função
        '    ValidacaoAmostra = True

        'Catch ex As Exception
        '    Throw ex
        'End Try

    End Function

#End Region

#Region "::: CONTA BANCÁRIA  :::"

    Private Sub DeleteConta()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdConta) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCadParceiroNegocio.DeleteConta(iCodigoParceiro)

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

    Private Sub LoadGridConta()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCadParceiroNegocio.LoadGridConta(grdConta, _
                                                 iCodigoParceiro)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarConta()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcUpdate) = True Then

                'Carrega Controles
                txtConta.Text = grdConta.CurrentRow.Cells("conta").Value
                txtAgencia.Text = grdConta.CurrentRow.Cells("agencia").Value
                cboBanco.SelectedValue = grdConta.CurrentRow.Cells("codigo_banco").Value
                btnInserirConta.Tag = grdConta.CurrentRow.Cells("codigo").Value

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

    Private Sub NovoConta()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles            
            txtConta.Text = ""
            txtAgencia.Text = ""
            cboBanco.SelectedIndex = -1
            btnInserirConta.Tag = ""
            'grdConta.ClearItems()

            'Seta Focu
            txtDescricaoArquivo.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoConta() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoConta = False

            'Verifica se foi Preenchido o Campo - Agencia
            If ValidaCampo(txtAgencia, lblAgencia, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Conta
            If ValidaCampo(txtConta, lblConta, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Banco
            If ValidaCampo(cboBanco, lblBanco) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: CHECKLIST CLIENTE :::"

    Private Sub LoadGridChecklistCliente()
        Try

            oClsCadParceiroNegocio.LoadGridChecklistCliente(grdOrcamentoCheckListCliente, btnSalvar.Tag)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub UpdateChecklistCliente()
        Try

            oClsCadParceiroNegocio.UpdateChecklistCliente(lCodigoParceiroNegocio:=btnSalvar.Tag,
                                                          iCodigoCheklistCliente:=grdOrcamentoCheckListCliente.GetValue("codigo"),
                                                          bImpressoProposta:=grdOrcamentoCheckListCliente.GetValue("impresso_proposta"),
                                                          bExportadoParaOP:=grdOrcamentoCheckListCliente.GetValue("exportado_ordem_producao"))

            frmMain.Informacao(Mensagem.RegistroAlterado)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "::: QUALIDADE :::"

    Private Sub novaQualidade()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            dtpVencimentoQuestionario.Value = Now.Date
            dtpVencimentoCertificado.Value = Now.Date
            dtpEntregaQuestionario.Value = Now.Date
            txtNotaQuestionario.Value = 0

            btnInserirQualidade.Tag = ""

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarQualidade()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoParceiroNegocioContatos, gcUpdate) = True Then

                With grdQualidade.CurrentRow.Cells

                    'Limpa Controles
                    Call novaQualidade()
                    Call oClsCadParceiroNegocio.LoadQualidadeRisco(lblMensagem, _
                                                                   lblMediaNota, _
                                                                   lblStatusQualidade, _
                                                                   btnSalvar.Tag)

                    'Carrega Controles

                    dtpVencimentoQuestionario.Value = .Item("data_vencimento_questionario").Value
                    dtpVencimentoCertificado.Value = .Item("data_vencimento_certificado").Value
                    dtpEntregaQuestionario.Value = .Item("data_entrega_questionario").Value
                    txtNotaQuestionario.Value = .Item("nota_questionario").Value

                    btnInserirQualidade.Tag = .Item("codigo").Value

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

    Private Sub btnExcluirQualidade_Click(sender As Object, e As EventArgs) Handles btnExcluirQualidade.Click

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdQualidade) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente os registros selecionados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Deleta Contato
                    oClsCadParceiroNegocio.DeleteQualidade(btnSalvar.Tag)

                    'Limpa Formulário
                    Call novaQualidade()
                    Call oClsCadParceiroNegocio.LoadQualidadeRisco(lblMensagem, _
                                                                   lblMediaNota, _
                                                                   lblStatusQualidade, _
                                                                   btnSalvar.Tag)

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

    Private Sub grdQualidade_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdQualidade.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdQualidade.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdQualidade.CurrentColumn.Key

                Case "editar" : Call EditarQualidade()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirQualidade_Click(sender As Object, e As EventArgs) Handles btnInserirQualidade.Click

        If txtNotaQuestionario.Value < 0 Or txtNotaQuestionario.Value > 100 Then
            MsgBox("A nota do questionário deve ser entre 0 e 100.", MsgBoxStyle.Exclamation, "Validação")
            Exit Sub
        End If

        If dtpEntregaQuestionario.Value > dtpVencimentoCertificado.Value Or dtpEntregaQuestionario.Value > dtpVencimentoQuestionario.Value Then
            MsgBox("A data de vencimento não pode ser anterior a data de entrega.", MsgBoxStyle.Exclamation, "Validação")
            Exit Sub
        End If


        'Verifica o Tipo de Operação
        If IsNumeric(btnInserirQualidade.Tag) Then

            oClsCadParceiroNegocio.updateQualidade(btnInserirQualidade.Tag, _
                                                   txtNotaQuestionario.Value, _
                                                   dtpVencimentoCertificado.Value, _
                                                   dtpEntregaQuestionario.Value, _
                                                   dtpVencimentoQuestionario.Value, _
                                                   btnSalvar.Tag)



            Call oClsCadParceiroNegocio.loadGridQualidade(grdQualidade, _
                                                          btnSalvar.Tag)

            btnInserirQualidade.Tag = ""

            frmMain.Informacao(Mensagem.RegistroAlterado)
        Else

            oClsCadParceiroNegocio.InsertQualidade(txtNotaQuestionario.Text, _
                                                   dtpVencimentoCertificado.Value, _
                                                   dtpEntregaQuestionario.Value, _
                                                   dtpVencimentoQuestionario.Value, _
                                                   btnSalvar.Tag
                                                   )


            Call oClsCadParceiroNegocio.loadGridQualidade(grdQualidade, _
                                                          btnSalvar.Tag)

            frmMain.Informacao(Mensagem.RegistroInserido)

        End If

        Call novaQualidade()
        Call oClsCadParceiroNegocio.LoadQualidadeRisco(lblMensagem, _
                                                       lblMediaNota, _
                                                       lblStatusQualidade, _
                                                       btnSalvar.Tag)

    End Sub

#End Region


#End Region

    Private Sub btnProcurarCNPJ_Click(sender As Object, e As EventArgs) Handles btnProcurarCNPJ.Click
        Try


            BuscaWSSintegra(txtCnpjCpf.Text, _
                            txtRazaoSocial, _
                            txtInscricaoEstadual, _
                            cboPais, _
                            txtLogradouro, _
                            txtNumero, _
                            txtBairro, _
                            txtCEP, _
                            txtComplemento, _
                            cboUF, _
                            cboMunicipio)
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
End Class

