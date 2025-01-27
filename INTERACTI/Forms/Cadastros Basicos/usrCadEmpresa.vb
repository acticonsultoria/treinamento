Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls
Imports System.IO

Public Class usrCadEmpresa

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadEmpresa As New clsUsrCadEmpresa

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrCadEmpresa_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.F3

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "txtCEP" : Call btnProcurarCEP_Click(btnProcurarCEP, System.EventArgs.Empty)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadEmpresa_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: EMPRESA :::"

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

    Private Sub txtLogo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLogo.TextChanged

        Try

            'Verifica se foi Selecionado alguma Logo
            If txtLogo.Text <> "" Then

                'Carrega Imagem
                Dim oImage As Image = Image.FromFile(txtLogo.Text)

                'Obtém tamanho da Imagem
                Dim iWidth As Integer = oImage.Size.Width
                Dim iHeight As Integer = oImage.Size.Height
                Dim oNewSize As Size

                If (214 / iWidth) < (134 / iHeight) Then
                    oNewSize = New Size(214, 214 * iHeight / iWidth)
                Else
                    oNewSize = New Size(134 * iWidth / iHeight, 134)
                End If

                'Carrega Imagem da Váriavel
                Dim oNewImagem As Image = New Bitmap(oImage)

                'Descarrega Imagem do Arquivo da Memória
                oImage.Dispose()

                oNewImagem = New Bitmap(oNewImagem, oNewSize)

                picLogo.Image = oNewImagem
                picLogo.SizeMode = PictureBoxSizeMode.CenterImage

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: DESPESA FIXA :::"

    Private Sub txtFaturamentoAnual_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFaturamentoAnual.LostFocus

        Try

            txtFaturamentoMensal.Value = txtFaturamentoAnual.Value / 12.0

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadEmpresa_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnSalvar.Enabled = VerificaDireito(Formulario.CadastroBasicoEmpresa, gcInsert)

            'Carrega Combo
            Call LoadCombo(cboCNAE, "sp_select_combo_static_cnae")
            Call LoadCombo(cboRegimeTributario, "sp_select_combo_static_regime_tributario")
            Call LoadCombo(cboPais, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)
            Call LoadCombo(cboUF, "sp_select_combo_static_estado")
            Call LoadComboSimNao(cboIncentivadorCultural)
            Call LoadCombo(cboRegimeEspecialTributacao, "sp_select_combo_static_regime_especial_tributacao_nfse")

            'Carrega Controles
            Call oClsCadEmpresa.LoadControles(txtCNPJ, _
                                              txtRazaoSocial, _
                                              txtNomeFantasia, _
                                              cboCNAE, _
                                              txtInscricaoEstadual, _
                                              txtInscricaoEstadualST, _
                                              cboRegimeTributario, _
                                              txtSigla, _
                                              cboPais, _
                                              cboUF, _
                                              cboMunicipio, _
                                              txtLogradouro, _
                                              txtNumero, _
                                              txtBairro, _
                                              txtComplemento, _
                                              txtCEP, _
                                              txtTelefone, _
                                              txtEmail, _
                                              picLogo, _
                                              txtInscricaoMunicipal, _
                                              cboIncentivadorCultural, _
                                              cboRegimeEspecialTributacao)

            oClsCadEmpresa.LoadDadosDespesaFixa(txtFaturamentoAnual, _
                                                txtFaturamentoMensal, _
                                                txtDespesaMensal)

            txtCNPJ.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: EMPRESA :::"

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCadEmpresa.CNPJ = txtCNPJ.Text.Trim
            oClsCadEmpresa.RazaoSocial = txtRazaoSocial.Text.Trim
            oClsCadEmpresa.NomeFantasia = txtNomeFantasia.Text.Trim
            oClsCadEmpresa.CNAE = cboCNAE.SelectedValue
            oClsCadEmpresa.InscricaoEstadual = txtInscricaoEstadual.Text.Trim
            oClsCadEmpresa.InscricaoEstadualST = txtInscricaoEstadualST.Text.Trim
            oClsCadEmpresa.RegimeTributario = IIf(cboRegimeTributario.SelectedIndex = -1, -1, cboRegimeTributario.SelectedValue)
            oClsCadEmpresa.Sigla = txtSigla.Text.Trim

            oClsCadEmpresa.Pais = cboPais.SelectedValue
            oClsCadEmpresa.UF = cboUF.SelectedValue
            oClsCadEmpresa.Municipio = cboMunicipio.SelectedValue
            oClsCadEmpresa.Logradouro = txtLogradouro.Text.Trim
            oClsCadEmpresa.Numero = txtNumero.Text.Trim
            oClsCadEmpresa.Bairro = txtBairro.Text.Trim
            oClsCadEmpresa.Complemento = txtComplemento.Text.Trim
            oClsCadEmpresa.Cep = txtCEP.Text.Trim
            oClsCadEmpresa.Telefone = txtTelefone.Text.Trim
            oClsCadEmpresa.Email = txtEmail.Text.Trim

            oClsCadEmpresa.Logo = picLogo

            oClsCadEmpresa.InscricaoMunicipal = txtInscricaoMunicipal.Text.Trim
            oClsCadEmpresa.IncentivadorCultural = IIf(cboIncentivadorCultural.SelectedIndex = -1, -1, IIf(cboIncentivadorCultural.SelectedValue = True, 1, 0))
            oClsCadEmpresa.CodigoRegimeEspecialTributacao = IIf(cboRegimeEspecialTributacao.SelectedIndex = -1, -1, cboRegimeEspecialTributacao.SelectedValue)

            'Atualiza Dados da Empresa
            oClsCadEmpresa.Update()

            'Atualiza valores de Despesas Fixas (tb_cfg_orcamento)
            oClsCadEmpresa.UpdateDespesaFixa(txtFaturamentoAnual.Value, _
                                             txtFaturamentoMensal.Value, _
                                             txtDespesaMensal.Value)

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

            'Verifica se foi Preenchido o Campo - Cnpj
            If ValidaCampo(txtCNPJ, lblCNPJ, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Razao Social
            If ValidaCampo(txtRazaoSocial, lblRazaoSocial, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Inscrição Estadual
            If ValidaCampo(txtInscricaoEstadual, lblInscricaoEstadual, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Regime Tributário
            If ValidaCampo(cboRegimeTributario, lblRegimeTributario) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Sigla
            If ValidaCampo(txtSigla, lblSigla, TipoCampo.texto) = False Then
                Exit Function
            ElseIf txtSigla.Text.Trim.Length < 2 Then
                frmMain.errInfo.SetError(lblSigla, "O Campo [SIGLA] deve possuir dois caracteres.")
                txtSigla.Focus()
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
            If ValidaCampo(cboMunicipio, lblMunicipio) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Logradouro
            If ValidaCampo(txtLogradouro, lblLogradouro, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Número
            If ValidaCampo(txtNumero, lblNumero, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Bairro
            If ValidaCampo(txtBairro, lblBairro, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - CEP
            If ValidaCampo(txtCEP, lblCEP, TipoCampo.texto) = False Then
                Exit Function
            End If

            If txtInscricaoMunicipal.Text.Trim <> "" Then

                'Verifica se foi Selecionado o Campo - Incentivador Cultural
                If ValidaCampo(cboIncentivadorCultural, lblIncentivadorCultural) = False Then
                    Exit Function
                End If

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

