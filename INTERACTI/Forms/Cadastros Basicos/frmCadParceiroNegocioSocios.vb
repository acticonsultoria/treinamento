Imports Janus.Windows.GridEX

Public Class frmCadParceiroNegocioSocios

#Region "::: VARIAVEIS :::"

    'Variável da Classe
    Private oGrid As GridEX
    Private iCodigoParceiroNegocio As Integer
    Private iCodigo As Integer = -1
    Private oClsUsrCadParceiroNegocio As New clsUsrCadParceiroNegocio

#End Region

#Region "::: PROPERTIE :::"
    Public Property Codigo() As Integer
        Get
            Return iCodigo
        End Get
        Set(ByVal value As Integer)
            iCodigo = value
        End Set
    End Property
    Public Property CodigoParceiroNegocio() As Integer
        Get
            Return iCodigoParceiroNegocio
        End Get
        Set(ByVal value As Integer)
            iCodigoParceiroNegocio = value
        End Set
    End Property
    Public Property Grid() As GridEX
        Get
            Return oGrid
        End Get
        Set(ByVal value As GridEX)
            oGrid = value
        End Set
    End Property


#End Region

#Region "::: CONTROLES :::"

    Private Sub frmFinTituloHistorico_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try
            If grpPFBR.Visible = True Then
                'If ValidacaoPessoaFisicaBrasileira() = True Then
                Call SalvarPessoaFisicaBrasileira()
                Me.Dispose()
                'End If
            Else
            If grpPessoaFisicaEstrangeira.Visible = True Then
                    ' If ValidacaoPessoaFisicaEstrangeira() = True Then
                    Call SalvarPessoaFisicaEstrangeira()
                    Me.Dispose()
                    ' End If
            Else
                If grpPessoaJuridicaBrasileira.Visible = True Then
                        'If ValidacaoPessoaJuridicaBrasileira() = True Then
                        Call SalvarPessoaJuridicaBrasileira()
                        Me.Dispose()
                        'End If
                Else
                    If grpPessoaJuridicaEstrangeira.Visible = True Then
                            ' If ValidacaoPessoaJuridicaEstrangeira() = True Then
                            Call SalvarPessoaJuridicaEstrangeira()
                            Me.Dispose()
                            'End If
                    End If
                End If
            End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub chkPessoaFisica_CheckedChanged(sender As Object, e As EventArgs) Handles chkPessoaFisica.CheckedChanged, _
                                                                                        chkPessoaJuridica.CheckedChanged, _
                                                                                        chkBrasileira.CheckedChanged, _
                                                                                        chkEstrangeira.CheckedChanged
        Try
            If chkPessoaFisica.Checked = True Then chkPessoaJuridica.Checked = False
            If chkPessoaJuridica.Checked = True Then chkPessoaFisica.Checked = False
            If chkBrasileira.Checked = True Then chkEstrangeira.Checked = False
            If chkEstrangeira.Checked = True Then chkBrasileira.Checked = False

            If chkPessoaFisica.Checked = True And chkBrasileira.Checked = True Then
                grpPessoaFisicaEstrangeira.Visible = False
                grpPFBR.Visible = True
                grpPFBR.Location = New System.Drawing.Point(8, 83)
                grpPFBR.Size = New System.Drawing.Size(993, 232)
                grpPessoaJuridicaBrasileira.Visible = False
                grpPessoaJuridicaEstrangeira.Visible = False
            End If

            If chkPessoaFisica.Checked = True And chkEstrangeira.Checked = True Then
                grpPessoaFisicaEstrangeira.Visible = True
                grpPessoaFisicaEstrangeira.Location = New System.Drawing.Point(8, 83)
                grpPessoaFisicaEstrangeira.Size = New System.Drawing.Size(993, 232)
                grpPFBR.Visible = False
                grpPessoaJuridicaBrasileira.Visible = False
                grpPessoaJuridicaEstrangeira.Visible = False
            End If

            If chkPessoaJuridica.Checked = True And chkBrasileira.Checked = True Then
                grpPessoaFisicaEstrangeira.Visible = False
                grpPFBR.Visible = False
                grpPessoaJuridicaBrasileira.Visible = True
                grpPessoaJuridicaBrasileira.Location = New System.Drawing.Point(8, 83)
                grpPessoaJuridicaBrasileira.Size = New System.Drawing.Size(993, 232)
                grpPessoaJuridicaEstrangeira.Visible = False
            End If

            If chkPessoaJuridica.Checked = True And chkEstrangeira.Checked = True Then
                grpPessoaFisicaEstrangeira.Visible = False
                grpPFBR.Visible = False
                grpPessoaJuridicaBrasileira.Visible = False
                grpPessoaJuridicaEstrangeira.Visible = True
                grpPessoaJuridicaEstrangeira.Location = New System.Drawing.Point(8, 83)
                grpPessoaJuridicaEstrangeira.Size = New System.Drawing.Size(993, 232)
            End If

            If (chkPessoaFisica.Checked = False And chkPessoaJuridica.Checked = False) _
                Or (chkBrasileira.Checked = False And chkEstrangeira.Checked = False) Then
                grpPessoaFisicaEstrangeira.Visible = False
                grpPFBR.Visible = False
                grpPessoaJuridicaBrasileira.Visible = False
                grpPessoaJuridicaEstrangeira.Visible = False
            End If
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub


#Region "::: PESSOA FÍSICA BRASILEIRA :::"
    Private Sub grpPFBR_VisibleChanged(sender As Object, e As EventArgs) Handles grpPFBR.VisibleChanged
        Try
            If grpPFBR.Visible = False Then
                txtNomePFBR.Text = ""
                txtCpfPFBR.Text = ""
                txtRGPFBR.Text = ""
                txtNacionalidadePFBR.Text = ""
                cboEstadoCivilPFBR.SelectedIndex = -1
                txtCEPPFBR.Text = ""
                cboPaisPFBR.SelectedIndex = -1
                cboUFPFBR.SelectedIndex = -1
                cboMunicipioPFBR.SelectedIndex = -1
                txtLogradouroPFBR.Text = ""
                txtNumeroPFBR.Text = ""
                txtBairroPFBR.Text = ""
                txtComplementoPFBR.Text = ""
                cboQualificacaoPFBR.SelectedIndex = -1
                txtTelefonePFBR.Text = ""
                txtEmailPFBR.Text = ""
                dtpDataAdmissaoPFBR.Value = Now.Date : dtpDataAdmissaoPFBR.Checked = True
            End If
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboPaisPFBR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPaisPFBR.SelectedIndexChanged
        Try

            'Verifica se foi selecionado algum Registro
            If cboPaisPFBR.SelectedIndex = -1 Then
                cboUFPFBR.DataSource = Nothing
                cboUFPFBR.Text = ""
                cboMunicipioPFBR.DataSource = Nothing
                cboMunicipioPFBR.Text = ""
            Else
                Call LoadCombo(cboUFPFBR, "sp_select_combo_static_estado_pais " & cboPaisPFBR.SelectedValue)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboUFPFBR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUFPFBR.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum Registro
            If cboUFPFBR.SelectedIndex = -1 Then
                cboMunicipioPFBR.DataSource = Nothing
                cboMunicipioPFBR.Text = ""
            Else
                Call LoadCombo(cboMunicipioPFBR, "sp_select_combo_static_municipio '" & cboUFPFBR.SelectedValue & "'")
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnProcurarCEPPFBR_Click(sender As Object, e As EventArgs) Handles btnProcurarCEPPFBR.Click
        Try

            'Verifica se foi preenchido o CEP
            If txtCEPPFBR.Text.Replace("-", "").Trim.Length = 8 Then

                'Verifica se há o cep no banco de dados
                ProcuraCep(CLng(Replace(txtCEPPFBR.Text.Trim, "-", "")), _
                           cboPaisPFBR, _
                           cboUFPFBR, _
                           cboMunicipioPFBR, _
                           txtBairroPFBR, _
                           txtLogradouroPFBR, _
                           txtComplementoPFBR)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnCadastrarPaisPFBR_Click(sender As Object, e As EventArgs) Handles btnCadastrarPaisPFBR.Click
        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadPais")

            'Carrega Combo
            Call LoadCombo(cboPaisPFBR, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)
            'Seta Focu
            cboPaisPFBR.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub txtCpfPFBR_LostFocus(sender As Object, e As EventArgs) Handles txtCpfPFBR.LostFocus
        Try

            If txtCpfPFBR.Text = "" Then Exit Sub

            oClsUsrCadParceiroNegocio.LoadControlesSocioCPFCNPJ(txtCpfPFBR.Text, _
                                                                txtNomePFBR, _
                                                                txtCEPPFBR, _
                                                                cboPaisPFBR, _
                                                                cboUFPFBR, _
                                                                cboMunicipioPFBR, _
                                                                txtLogradouroPFBR, _
                                                                txtNumeroPFBR, _
                                                                txtBairroPFBR, _
                                                                txtComplementoPFBR, _
                                                                txtTelefonePFBR, _
                                                                txtEmailPFBR, _
                                                                cboEstadoCivilPFBR, _
                                                                txtRGPFBR)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region "::: PESSOA FÍSICA ESTRANGEIRA :::"
    Private Sub grpPessoaFisicaEstrangeira_VisibleChanged(sender As Object, e As EventArgs) Handles grpPessoaFisicaEstrangeira.VisibleChanged
        Try
            If grpPessoaFisicaEstrangeira.Visible = False Then
                txtNomePFEX.Text = ""
                txtTaxIDPFEX.Text = ""
                txtNacionalidadePFEX.Text = ""
                cboEstadoCivilPFEX.SelectedIndex = -1
                txtIDPFEX.Text = ""
                txtCEPPFEX.Text = ""
                cboPaisPFEX.SelectedIndex = -1
                cboUFPFEX.SelectedIndex = -1
                cboMunicipioPFEX.SelectedIndex = -1
                txtLogradouroPFEX.Text = ""
                txtNumeroPFEX.Text = ""
                txtComplementoPFEX.Text = ""
                txtBairroPFEX.Text = ""
                cboQualificacaoPFEX.SelectedIndex = -1
                txtTelefonePFEX.Text = ""
                txtEmailPFEX.Text = ""
                dtpDataAdmissaoPFEX.Value = Now.Date : dtpDataAdmissaoPFEX.Checked = True
            End If
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboPaisPFEX_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPaisPFEX.SelectedIndexChanged
        Try

            'Verifica se foi selecionado algum Registro
            If cboPaisPFEX.SelectedIndex = -1 Then
                cboUFPFEX.DataSource = Nothing
                cboUFPFEX.Text = ""
                cboMunicipioPFEX.DataSource = Nothing
                cboMunicipioPFEX.Text = ""
            Else
                Call LoadCombo(cboUFPFEX, "sp_select_combo_static_estado_pais " & cboPaisPFEX.SelectedValue)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboUFPFEX_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUFPFEX.SelectedIndexChanged
        Try

            'Verifica se foi selecionado algum Registro
            If cboUFPFEX.SelectedIndex = -1 Then
                cboMunicipioPFEX.DataSource = Nothing
                cboMunicipioPFEX.Text = ""
            Else
                Call LoadCombo(cboMunicipioPFEX, "sp_select_combo_static_municipio '" & cboUFPFEX.SelectedValue & "'")
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnProcurarCEPPFEX_Click(sender As Object, e As EventArgs) Handles btnProcurarCEPPFEX.Click
        Try

            'Verifica se foi preenchido o CEP
            If txtCEPPFEX.Text.Replace("-", "").Trim.Length = 8 Then

                'Verifica se há o cep no banco de dados
                ProcuraCep(CLng(Replace(txtCEPPFEX.Text.Trim, "-", "")), _
                           cboPaisPFEX, _
                           cboUFPFEX, _
                           cboMunicipioPFEX, _
                           txtBairroPFEX, _
                           txtLogradouroPFEX, _
                           txtComplementoPFEX)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnCadPaisPFEX_Click(sender As Object, e As EventArgs) Handles btnCadPaisPFEX.Click
        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadPais")

            'Carrega Combo
            Call LoadCombo(cboPaisPFEX, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)
            'Seta Focu
            cboPaisPFEX.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

#End Region

#Region "::: PESSOA JURÍDICA BRASILEIRA :::"
    Private Sub grpPessoaJuridicaBrasileira_VisibleChanged(sender As Object, e As EventArgs) Handles grpPessoaJuridicaBrasileira.VisibleChanged
        Try
            If grpPessoaJuridicaBrasileira.Visible = False Then
                txtRazaoSocialPJBR.Text = ""
                txtCNPJPJBR.Text = ""
                cboTipoOrgaoRegistroPJBR.SelectedIndex = -1
                txtCEPPJBR.Text = ""
                cboPaisPJBR.SelectedIndex = -1
                cboUFPJBR.SelectedIndex = -1
                cboMunicipioPJBR.SelectedIndex = -1
                txtLogradouroPJBR.Text = ""
                txtNumeroPJBR.Text = ""
                txtComplementoPJBR.Text = ""
                txtBairroPJBR.Text = ""
                cboTipoOrgaoRegistroPJBR.SelectedIndex = -1
                txtNirePJBR.Text = ""
                dtpDataInicioAtivPJBR.Value = Now.Date : dtpDataInicioAtivPJBR.Checked = False
                txtNumeroRegistoPJBR.Text = ""
                dtpDataRegistroPJBR.Value = Now.Date : dtpDataRegistroPJBR.Checked = False
                txtRepresentanteLegalPJBR.Text = ""
                cboQualificacaoPJBR.SelectedIndex = -1
                txtTelefonePJBR.Text = ""
                txtEmailPJBR.Text = ""
                dtpDataAdmissaoPJBR.Value = Now.Date : dtpDataAdmissaoPJBR.Checked = True
            End If
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboPaisPJBR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPaisPJBR.SelectedIndexChanged
        Try

            'Verifica se foi selecionado algum Registro
            If cboPaisPJBR.SelectedIndex = -1 Then
                cboUFPJBR.DataSource = Nothing
                cboUFPJBR.Text = ""
                cboMunicipioPJBR.DataSource = Nothing
                cboMunicipioPJBR.Text = ""
            Else
                Call LoadCombo(cboUFPJBR, "sp_select_combo_static_estado_pais " & cboPaisPJBR.SelectedValue)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboUFPJBR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUFPJBR.SelectedIndexChanged
        Try

            'Verifica se foi selecionado algum Registro
            If cboUFPJBR.SelectedIndex = -1 Then
                cboMunicipioPJBR.DataSource = Nothing
                cboMunicipioPJBR.Text = ""
            Else
                Call LoadCombo(cboMunicipioPJBR, "sp_select_combo_static_municipio '" & cboUFPJBR.SelectedValue & "'")
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnProcurarCEPPJBR_Click(sender As Object, e As EventArgs) Handles btnProcurarCEPPJBR.Click
        Try

            'Verifica se foi preenchido o CEP
            If txtCEPPJBR.Text.Replace("-", "").Trim.Length = 8 Then

                'Verifica se há o cep no banco de dados
                ProcuraCep(CLng(Replace(txtCEPPJBR.Text.Trim, "-", "")), _
                           cboPaisPJBR, _
                           cboUFPJBR, _
                           cboMunicipioPJBR, _
                           txtBairroPJBR, _
                           txtLogradouroPJBR, _
                           txtComplementoPJBR)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnCadPaisPJBR_Click(sender As Object, e As EventArgs) Handles btnCadPaisPJBR.Click
        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadPais")

            'Carrega Combo
            Call LoadCombo(cboPaisPJBR, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)
            'Seta Focu
            cboPaisPJBR.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub txtCNPJPJBR_LostFocus(sender As Object, e As EventArgs) Handles txtCNPJPJBR.LostFocus
        Try

            If txtCNPJPJBR.Text = "" Then Exit Sub

            oClsUsrCadParceiroNegocio.LoadControlesSocioCPFCNPJ(txtCNPJPJBR.Text, _
                                                                txtRazaoSocialPJBR, _
                                                                txtCEPPJBR, _
                                                                cboPaisPJBR, _
                                                                cboUFPJBR, _
                                                                cboMunicipioPJBR, _
                                                                txtLogradouroPJBR, _
                                                                txtNumeroPJBR, _
                                                                txtBairroPJBR, _
                                                                txtComplementoPJBR, _
                                                                txtTelefonePJBR, _
                                                                txtEmailPJBR, _
                                                                cboEstadoCivilPFBR, _
                                                                txtRGPFBR)

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
#End Region

#Region "::: PESSOA JURÍDICA ESTRANGEIRA :::"
    Private Sub grpPessoaJuridicaEstrangeira_VisibleChanged(sender As Object, e As EventArgs) Handles grpPessoaJuridicaEstrangeira.VisibleChanged
        Try
            If grpPessoaJuridicaEstrangeira.Visible = False Then
                txtRazaoSocialPJEX.Text = ""
                txtTaxIDPJEX.Text = ""
                cboTipoSocietarioPJEX.SelectedIndex = -1
                txtCEPPJEX.Text = ""
                cboPaisPJEX.SelectedIndex = -1
                cboUFPJEX.SelectedIndex = -1
                cboMunicipioPJEX.SelectedIndex = -1
                txtLogradouroPJEX.Text = ""
                txtNumeroPJEX.Text = ""
                txtComplementoPJEX.Text = ""
                txtBairroPJEX.Text = ""
                cboTipoSocietarioPJEX.SelectedIndex = -1
                txtNumeroCadastroPJEX.Text = ""
                txtRepresentanteLegalPJEX.Text = ""
                cboQualificacaoPJEX.SelectedIndex = -1
                txtTelefonePJEX.Text = ""
                txtEmailPJEX.Text = ""
                dtpDataAdmissaoPJEX.Value = Now.Date : dtpDataAdmissaoPJEX.Checked = True
            End If
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboPaisPJEX_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPaisPJEX.SelectedIndexChanged
        Try

            'Verifica se foi selecionado algum Registro
            If cboPaisPJEX.SelectedIndex = -1 Then
                cboUFPJEX.DataSource = Nothing
                cboUFPJEX.Text = ""
                cboMunicipioPJEX.DataSource = Nothing
                cboMunicipioPJEX.Text = ""
            Else
                Call LoadCombo(cboUFPJEX, "sp_select_combo_static_estado_pais " & cboPaisPJEX.SelectedValue)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboUFPJEX_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUFPJEX.SelectedIndexChanged
        Try

            'Verifica se foi selecionado algum Registro
            If cboUFPJEX.SelectedIndex = -1 Then
                cboMunicipioPJEX.DataSource = Nothing
                cboMunicipioPJEX.Text = ""
            Else
                Call LoadCombo(cboMunicipioPJEX, "sp_select_combo_static_municipio '" & cboUFPJEX.SelectedValue & "'")
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnProcurarCEPPJEX_Click(sender As Object, e As EventArgs) Handles btnProcurarCEPPJEX.Click
        Try

            'Verifica se foi preenchido o CEP
            If txtCEPPJEX.Text.Replace("-", "").Trim.Length = 8 Then

                'Verifica se há o cep no banco de dados
                ProcuraCep(CLng(Replace(txtCEPPJEX.Text.Trim, "-", "")), _
                           cboPaisPJEX, _
                           cboUFPJEX, _
                           cboMunicipioPJEX, _
                           txtBairroPJEX, _
                           txtLogradouroPJEX, _
                           txtComplementoPJEX)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnCadPaisPJEX_Click(sender As Object, e As EventArgs) Handles btnCadPaisPJEX.Click
        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadPais")

            'Carrega Combo
            Call LoadCombo(cboPaisPJEX, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)
            'Seta Focu
            cboPaisPJEX.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Formulário
            'Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Seta Ícone
            Me.Icon = frmMain.Icon

            Call LoadCombo(cboQualificacaoPFBR, "sp_select_combo_static_qualificacao_socio")
            Call LoadCombo(cboQualificacaoPJBR, "sp_select_combo_static_qualificacao_socio")
            Call LoadCombo(cboQualificacaoPFEX, "sp_select_combo_static_qualificacao_socio")
            Call LoadCombo(cboQualificacaoPJEX, "sp_select_combo_static_qualificacao_socio")
            Call LoadCombo(cboTipoSocietarioPJEX, "sp_select_combo_static_tipo_societario")
            Call LoadCombo(cboTipoSocietarioPJBR, "sp_select_combo_static_tipo_societario")
            Call LoadCombo(cboEstadoCivilPFBR, "sp_select_combo_static_estado_civil")
            Call LoadCombo(cboEstadoCivilPFEX, "sp_select_combo_static_estado_civil")
            Call LoadCombo(cboPaisPFBR, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)
            Call LoadCombo(cboPaisPFEX, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)
            Call LoadCombo(cboPaisPJBR, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)
            Call LoadCombo(cboPaisPJEX, "sp_select_combo_cadastro_basico_pais " & goUsuario.iEmpresa)
            cboTipoOrgaoRegistroPJBR.Items.Clear()
            cboTipoOrgaoRegistroPJBR.Items.Add("CARTÓRIO DE REGISTRO DAS PESSOAS JURÍDICAS", 1)
            cboTipoOrgaoRegistroPJBR.Items.Add("JUNTA COMERCIAL", 2)
            cboOrgaoRegistroPJEX.Items.Clear()
            cboOrgaoRegistroPJEX.Items.Add("CARTÓRIO DE REGISTRO DAS PESSOAS JURÍDICAS", 1)
            cboOrgaoRegistroPJEX.Items.Add("JUNTA COMERCIAL", 2)

            If iCodigo <> -1 Then
                Call LoadControlesTipoPessoa()
                btnSalvar.Tag = iCodigo

                If grpPFBR.Visible = True Then
                    Call LoadControlesPessoaFisicaBrasileira()
                End If

                If grpPessoaFisicaEstrangeira.Visible = True Then
                    Call LoadControlesPessoaFisicaEstrangeira()
                End If

                If grpPessoaJuridicaBrasileira.Visible = True Then
                    Call LoadControlesPessoaJuridicaBrasileita()
                End If

                If grpPessoaJuridicaEstrangeira.Visible = True Then
                    Call LoadControlesPessoaJuridicaEstrangeira()
                End If
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub Novo()
        Try
            chkBrasileira.Checked = False
            chkEstrangeira.Checked = False
            chkPessoaFisica.Checked = False
            chkPessoaJuridica.Checked = False


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LoadControlesTipoPessoa()
        Try
            oClsUsrCadParceiroNegocio.LoadControlesSocioTipoPessoa(iCodigoParceiroNegocio, _
                                                                   iCodigo, _
                                                                   chkPessoaFisica, _
                                                                   chkPessoaJuridica, _
                                                                   chkBrasileira, _
                                                                   chkEstrangeira)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#Region "::: PESSOA FÍSICA BRASILEIRA :::"
    Private Function ValidacaoPessoaFisicaBrasileira() As Boolean
        Try
            ValidacaoPessoaFisicaBrasileira = False

            If ValidaCampo(txtNomePFBR, lblNomePFBR, TipoCampo.texto) = False Then
                Exit Function
            End If

            If ValidaCampo(txtCpfPFBR, lblCpfPFBR, TipoCampo.texto) = False Then
                Exit Function
            End If

            If txtCpfPFBR.Text <> "" Then
                If ValidaCPF(txtCpfPFBR.Text.Trim) = False Then
                    frmMain.errInfo.SetError(lblCpfPFBR, "Este CPF não é válido!")
                    txtCpfPFBR.Focus()
                    Exit Function
                End If
            End If

            If ValidaCampo(txtNacionalidadePFBR, lblNacionalidadePFBR, TipoCampo.texto) = False Then
                Exit Function
            End If

            If ValidaCampo(txtCEPPFBR, lblCEPPFBR, TipoCampo.texto) = False Then
                Exit Function
            End If

            If ValidaCampo(cboPaisPFBR, lblPaisPFBR) = False Then
                Exit Function
            End If

            If ValidaCampo(cboUFPFBR, lblUFPFBR) = False Then
                Exit Function
            End If

            If ValidaCampo(cboMunicipioPFBR, lblMunicipioPFBR) = False Then
                Exit Function
            End If

            If ValidaCampo(txtLogradouroPFBR, lblLogradouroPFBR, TipoCampo.texto) = False Then
                Exit Function
            End If

            If ValidaCampo(txtNumeroPFBR, lblNumeroPFBR, TipoCampo.texto) = False Then
                Exit Function
            End If

            If ValidaCampo(cboQualificacaoPFBR, lblQualificacaoPFBR) = False Then
                Exit Function
            End If

            ValidacaoPessoaFisicaBrasileira = True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub SalvarPessoaFisicaBrasileira()
        Try


            If IsNumeric(btnSalvar.Tag) Then

                oClsUsrCadParceiroNegocio.UpdateSocio(btnSalvar.Tag, iCodigoParceiroNegocio, txtNomePFBR.Text, txtCpfPFBR.Text, _
                                                      txtRGPFBR.Text, txtNacionalidadePFBR.Text, _
                                                      IIf(cboEstadoCivilPFBR.SelectedIndex = -1, -1, cboEstadoCivilPFBR.SelectedValue), _
                                                      txtCEPPFBR.Text, cboPaisPFBR.SelectedValue, cboUFPFBR.SelectedValue, cboMunicipioPFBR.SelectedValue, _
                                                      txtLogradouroPFBR.Text, txtNumeroPFBR.Text, txtBairroPFBR.Text, txtComplementoPFBR.Text, _
                                                      cboQualificacaoPFBR.SelectedValue, txtTelefonePFBR.Text, txtEmailPFBR.Text, _
                                                      "", "", "", -1, "", "", "", "", "", "", chkPessoaFisica.Checked, chkPessoaJuridica.Checked, _
                                                      chkEstrangeira.Checked, chkBrasileira.Checked, _
                                                      IIf(dtpDataAdmissaoPFBR.Checked = True, dtpDataAdmissaoPFBR.Value, ""), _
                                                      txtCidadeNascimentoPFBR.Text, _
                                                      IIf(dtpDataNascimentoPFBR.Checked = True, dtpDataNascimentoPFBR.Value, ""), _
                                                      txtProfissaoPFBR.Text)

            Else

                oClsUsrCadParceiroNegocio.InsertSocio(iCodigoParceiroNegocio, txtNomePFBR.Text, txtCpfPFBR.Text, _
                                                      txtRGPFBR.Text, txtNacionalidadePFBR.Text, _
                                                      IIf(cboEstadoCivilPFBR.SelectedIndex = -1, -1, cboEstadoCivilPFBR.SelectedValue), _
                                                      txtCEPPFBR.Text, cboPaisPFBR.SelectedValue, cboUFPFBR.SelectedValue, cboMunicipioPFBR.SelectedValue, _
                                                      txtLogradouroPFBR.Text, txtNumeroPFBR.Text, txtBairroPFBR.Text, txtComplementoPFBR.Text, _
                                                      cboQualificacaoPFBR.SelectedValue, txtTelefonePFBR.Text, txtEmailPFBR.Text, _
                                                      "", "", "", -1, "", "", "", "", "", "", chkPessoaFisica.Checked, chkPessoaJuridica.Checked, _
                                                      chkEstrangeira.Checked, chkBrasileira.Checked, _
                                                      IIf(dtpDataAdmissaoPFBR.Checked = True, dtpDataAdmissaoPFBR.Value, ""), _
                                                       txtCidadeNascimentoPFBR.Text, _
                                                      IIf(dtpDataNascimentoPFBR.Checked = True, dtpDataNascimentoPFBR.Value, ""), _
                                                      txtProfissaoPFBR.Text)

            End If
            
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LoadControlesPessoaFisicaBrasileira()
        Try
            oClsUsrCadParceiroNegocio.LoadControlesSocio(iCodigoParceiroNegocio, _
                                                        iCodigo, _
                                                        txtNomePFBR, txtCpfPFBR, txtRGPFBR, txtNacionalidadePFBR, _
                                                        cboEstadoCivilPFBR, txtCEPPFBR, cboPaisPFBR, cboUFPFBR, cboMunicipioPFBR, _
                                                        txtLogradouroPFBR, txtNumeroPFBR, txtBairroPFBR, txtComplementoPFBR, _
                                                        cboQualificacaoPFBR, txtTelefonePFBR, txtEmailPFBR, txtTaxIDPFEX, txtIDPFEX, _
                                                        cboTipoSocietarioPJBR, cboOrgaoRegistroPJEX, txtNirePJBR, dtpDataInicioAtivPJBR, _
                                                        txtNumeroRegistoPJBR, dtpDataRegistroPJBR, txtRepresentanteLegalPJBR, _
                                                        txtNumeroCadastroPJEX, dtpDataAdmissaoPFBR, txtCidadeNascimentoPFBR, _
                                                        dtpDataNascimentoPFBR, txtProfissaoPFBR)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LoadDadosCPFPessoaFisicaBrasileira()
        Try
            oClsUsrCadParceiroNegocio.LoadControlesSocio(iCodigoParceiroNegocio, _
                                                        iCodigo, _
                                                        txtNomePFBR, txtCpfPFBR, txtRGPFBR, txtNacionalidadePFBR, _
                                                        cboEstadoCivilPFBR, txtCEPPFBR, cboPaisPFBR, cboUFPFBR, cboMunicipioPFBR, _
                                                        txtLogradouroPFBR, txtNumeroPFBR, txtBairroPFBR, txtComplementoPFBR, _
                                                        cboQualificacaoPFBR, txtTelefonePFBR, txtEmailPFBR, txtTaxIDPFEX, txtIDPFEX, _
                                                        cboTipoSocietarioPJBR, cboOrgaoRegistroPJEX, txtNirePJBR, dtpDataInicioAtivPJBR, _
                                                        txtNumeroRegistoPJBR, dtpDataRegistroPJBR, txtRepresentanteLegalPJBR, _
                                                        txtNumeroCadastroPJEX, dtpDataAdmissaoPFBR, txtCidadeNascimentoPFBR, _
                                                        dtpDataNascimentoPFBR, txtProfissaoPFBR)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region "::: PESSOA FÍSICA ESTRANGEIRA :::"
    Private Function ValidacaoPessoaFisicaEstrangeira() As Boolean
        Try
            ValidacaoPessoaFisicaEstrangeira = False

            If ValidaCampo(txtNomePFEX, lblNomePFEX, TipoCampo.texto) = False Then
                Exit Function
            End If

            If ValidaCampo(txtCEPPFEX, lblCEPPFEX, TipoCampo.texto) = False Then
                Exit Function
            End If

            If ValidaCampo(cboPaisPFEX, lblPaisPFEX) = False Then
                Exit Function
            End If

            If ValidaCampo(cboUFPFEX, lblUFPFEX) = False Then
                Exit Function
            End If

            If ValidaCampo(cboMunicipioPFEX, lblMunicipioPFEX) = False Then
                Exit Function
            End If

            If ValidaCampo(txtLogradouroPFEX, lblLogradouroPFEX, TipoCampo.texto) = False Then
                Exit Function
            End If

            If ValidaCampo(txtNumeroPFEX, lblNumeroPFEX, TipoCampo.texto) = False Then
                Exit Function
            End If

            If ValidaCampo(cboQualificacaoPFEX, lblQualificacaoPFEX) = False Then
                Exit Function
            End If

            ValidacaoPessoaFisicaEstrangeira = True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub SalvarPessoaFisicaEstrangeira()
        Try


            If IsNumeric(btnSalvar.Tag) Then

                oClsUsrCadParceiroNegocio.UpdateSocio(btnSalvar.Tag, iCodigoParceiroNegocio,
                                                      txtNomePFEX.Text, "", "", txtNacionalidadePFEX.Text, _
                                                      IIf(cboEstadoCivilPFEX.SelectedIndex = -1, -1, cboEstadoCivilPFEX.SelectedValue), _
                                                      txtCEPPFEX.Text, cboPaisPFEX.SelectedValue, cboUFPFEX.SelectedValue, _
                                                      cboMunicipioPFEX.SelectedValue, txtLogradouroPFEX.Text, txtNumeroPFEX.Text, _
                                                      txtBairroPFEX.Text, txtComplementoPFEX.Text, cboQualificacaoPFEX.SelectedValue, _
                                                      txtTelefonePFEX.Text, txtEmailPFEX.Text, txtTaxIDPFEX.Text, txtIDPFEX.Text, _
                                                      "", -1, "", "", "", "", "", "", chkPessoaFisica.Checked, chkPessoaJuridica.Checked, _
                                                      chkEstrangeira.Checked, chkBrasileira.Checked, _
                                                      IIf(dtpDataAdmissaoPFEX.Checked = True, dtpDataAdmissaoPFEX.Value, ""), _
                                                       txtCidadeNascimentoPFEX.Text, _
                                                      IIf(dtpDataNascimentoPFEX.Checked = True, dtpDataNascimentoPFEX.Value, ""), _
                                                      txtProfissaoPFEX.Text)

            Else

                oClsUsrCadParceiroNegocio.InsertSocio(iCodigoParceiroNegocio,
                                                      txtNomePFEX.Text, "", "", txtNacionalidadePFEX.Text, _
                                                      IIf(cboEstadoCivilPFEX.SelectedIndex = -1, -1, cboEstadoCivilPFEX.SelectedValue), _
                                                      txtCEPPFEX.Text, cboPaisPFEX.SelectedValue, cboUFPFEX.SelectedValue, _
                                                      cboMunicipioPFEX.SelectedValue, txtLogradouroPFEX.Text, txtNumeroPFEX.Text, _
                                                      txtBairroPFEX.Text, txtComplementoPFEX.Text, cboQualificacaoPFEX.SelectedValue, _
                                                      txtTelefonePFEX.Text, txtEmailPFEX.Text, txtTaxIDPFEX.Text, txtIDPFEX.Text, _
                                                      "", -1, "", "", "", "", "", "", chkPessoaFisica.Checked, chkPessoaJuridica.Checked, _
                                                      chkEstrangeira.Checked, chkBrasileira.Checked, _
                                                      IIf(dtpDataAdmissaoPFEX.Checked = True, dtpDataAdmissaoPFEX.Value, ""), _
                                                       txtCidadeNascimentoPFEX.Text, _
                                                      IIf(dtpDataNascimentoPFEX.Checked = True, dtpDataNascimentoPFEX.Value, ""), _
                                                      txtProfissaoPFEX.Text)

            End If


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LoadControlesPessoaFisicaEstrangeira()
        Try
            oClsUsrCadParceiroNegocio.LoadControlesSocio(iCodigoParceiroNegocio, iCodigo, _
                                                         txtNomePFEX, txtCpfPFBR, txtRGPFBR, txtNacionalidadePFEX, cboEstadoCivilPFEX, _
                                                         txtCEPPFEX, cboPaisPFEX, cboUFPFEX, cboMunicipioPFEX, txtLogradouroPFEX, _
                                                         txtNumeroPFEX, txtBairroPFEX, txtComplementoPFEX, cboQualificacaoPFEX, _
                                                         txtTelefonePFEX, txtEmailPFEX, txtTaxIDPFEX, txtIDPFEX, cboTipoSocietarioPJEX, _
                                                         cboOrgaoRegistroPJEX, txtNirePJBR, dtpDataInicioAtivPJBR, txtNumeroRegistoPJBR, _
                                                         dtpDataRegistroPJBR, txtRepresentanteLegalPJEX, txtNumeroCadastroPJEX, dtpDataAdmissaoPFEX, _
                                                         txtCidadeNascimentoPFEX, _
                                                         dtpDataNascimentoPFEX, txtProfissaoPFEX)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region "::: PESSOA JURÍDICA BRASILEIRA :::"
    Private Function ValidacaoPessoaJuridicaBrasileira() As Boolean
        Try
            ValidacaoPessoaJuridicaBrasileira = False

            If ValidaCampo(txtRazaoSocialPJBR, lblRazaoSocialPJBR, TipoCampo.texto) = False Then
                Exit Function
            End If

            If ValidaCampo(txtCNPJPJBR, lblCNPJPJBR, TipoCampo.texto) = False Then
                Exit Function
            End If

            If txtCNPJPJBR.Text <> "" Then
                If ValidaCNPJ(txtCNPJPJBR.Text.Trim) = False Then
                    frmMain.errInfo.SetError(lblCNPJPJBR, "Este CNPJ não é válido!")
                    txtCNPJPJBR.Focus()
                    Exit Function
                End If
            End If

            If ValidaCampo(txtCEPPJBR, lblCEPPJBR, TipoCampo.texto) = False Then
                Exit Function
            End If

            If ValidaCampo(cboPaisPJBR, lblPaisPJBR) = False Then
                Exit Function
            End If

            If ValidaCampo(cboUFPJBR, lblUFPJBR) = False Then
                Exit Function
            End If

            If ValidaCampo(cboMunicipioPJBR, lblMunicipioPJBR) = False Then
                Exit Function
            End If

            If ValidaCampo(txtLogradouroPJBR, lblLogradouroPJBR, TipoCampo.texto) = False Then
                Exit Function
            End If

            If ValidaCampo(txtNumeroPJBR, lblNumeroPJBR, TipoCampo.texto) = False Then
                Exit Function
            End If

            If ValidaCampo(cboTipoSocietarioPJBR, lblTipoSocietarioPJBR) = False Then
                Exit Function
            End If

            If ValidaCampo(cboQualificacaoPJBR, lblQualificacaoPJBR) = False Then
                Exit Function
            End If

            ValidacaoPessoaJuridicaBrasileira = True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub SalvarPessoaJuridicaBrasileira()
        Try
         
                If IsNumeric(btnSalvar.Tag) Then

                oClsUsrCadParceiroNegocio.UpdateSocio(btnSalvar.Tag, iCodigoParceiroNegocio, txtRazaoSocialPJBR.Text, _
                                                      txtCNPJPJBR.Text, "", "", -1, txtCEPPJBR.Text, cboPaisPJBR.SelectedValue, _
                                                      cboUFPJBR.SelectedValue, cboMunicipioPJBR.SelectedValue, txtLogradouroPJBR.Text, _
                                                      txtNumeroPJBR.Text, txtBairroPJBR.Text, txtComplementoPJBR.Text, _
                                                      cboQualificacaoPJBR.SelectedValue, txtTelefonePJBR.Text, txtEmailPJBR.Text, _
                                                      "", "", _
                                                      IIf(cboTipoSocietarioPJBR.SelectedIndex = -1, -1, cboTipoSocietarioPJBR.SelectedValue), _
                                                      IIf(cboTipoOrgaoRegistroPJBR.SelectedIndex = -1, -1, cboTipoOrgaoRegistroPJBR.SelectedValue), _
                                                      txtNirePJBR.Text, _
                                                      IIf(dtpDataInicioAtivPJBR.Checked = False, "", dtpDataInicioAtivPJBR.Value), _
                                                      txtNumeroRegistoPJBR.Text, _
                                                      IIf(dtpDataRegistroPJBR.Checked = False, "", dtpDataRegistroPJBR.Text), _
                                                      txtRepresentanteLegalPJBR.Text, "", chkPessoaFisica.Checked, chkPessoaJuridica.Checked, _
                                                      chkEstrangeira.Checked, chkBrasileira.Checked, _
                                                      IIf(dtpDataAdmissaoPJBR.Checked = True, dtpDataAdmissaoPJBR.Value, ""), "", "", "")

                Else

                oClsUsrCadParceiroNegocio.InsertSocio(iCodigoParceiroNegocio, txtRazaoSocialPJBR.Text, _
                                                      txtCNPJPJBR.Text, "", "", -1, txtCEPPJBR.Text, cboPaisPJBR.SelectedValue, _
                                                      cboUFPJBR.SelectedValue, cboMunicipioPJBR.SelectedValue, txtLogradouroPJBR.Text, _
                                                      txtNumeroPJBR.Text, txtBairroPJBR.Text, txtComplementoPJBR.Text, _
                                                      cboQualificacaoPJBR.SelectedValue, txtTelefonePJBR.Text, txtEmailPJBR.Text, _
                                                      "", "", _
                                                      IIf(cboTipoSocietarioPJBR.SelectedIndex = -1, -1, cboTipoSocietarioPJBR.SelectedValue), _
                                                      IIf(cboTipoOrgaoRegistroPJBR.SelectedIndex = -1, -1, cboTipoOrgaoRegistroPJBR.SelectedValue), _
                                                      txtNirePJBR.Text, _
                                                      IIf(dtpDataInicioAtivPJBR.Checked = False, "", dtpDataInicioAtivPJBR.Value), _
                                                      txtNumeroRegistoPJBR.Text, _
                                                      IIf(dtpDataRegistroPJBR.Checked = False, "", dtpDataRegistroPJBR.Text), _
                                                      txtRepresentanteLegalPJBR.Text, "", chkPessoaFisica.Checked, chkPessoaJuridica.Checked, _
                                                      chkEstrangeira.Checked, chkBrasileira.Checked, _
                                                      IIf(dtpDataAdmissaoPJBR.Checked = True, dtpDataAdmissaoPJBR.Value, ""), "", "", "")

                End If


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LoadControlesPessoaJuridicaBrasileita()
        Try
            oClsUsrCadParceiroNegocio.LoadControlesSocio(iCodigoParceiroNegocio, iCodigo, _
                                                         txtRazaoSocialPJBR, txtCNPJPJBR, txtRGPFBR, txtNacionalidadePFBR, cboEstadoCivilPFBR, _
                                                         txtCEPPJBR, cboPaisPJBR, cboUFPJBR, cboMunicipioPJBR, txtLogradouroPJBR, _
                                                         txtNumeroPJBR, txtBairroPJBR, txtComplementoPJBR, cboQualificacaoPJBR, _
                                                         txtTelefonePJBR, txtEmailPJBR, txtTaxIDPJEX, txtIDPFEX, cboTipoSocietarioPJBR, _
                                                         cboTipoOrgaoRegistroPJBR, txtNirePJBR, dtpDataInicioAtivPJBR, txtNumeroRegistoPJBR, _
                                                         dtpDataRegistroPJBR, txtRepresentanteLegalPJBR, txtNumeroCadastroPJEX, dtpDataAdmissaoPJBR, _
                                                         txtCidadeNascimentoPFBR, _
                                                        dtpDataNascimentoPFBR, txtProfissaoPFBR)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region "::: PESSOA JURÍDICA ESTRANGEIRA :::"
    Private Function ValidacaoPessoaJuridicaEstrangeira() As Boolean
        Try
            ValidacaoPessoaJuridicaEstrangeira = False

            If ValidaCampo(txtRazaoSocialPJBR, lblRazaoSocialPJBR, TipoCampo.texto) = False Then
                Exit Function
            End If

            If ValidaCampo(txtTaxIDPJEX, lblTaxIDPJEX, TipoCampo.texto) = False Then
                Exit Function
            End If

            If ValidaCampo(txtCEPPJEX, lblCEPPJEX, TipoCampo.texto) = False Then
                Exit Function
            End If

            If ValidaCampo(cboPaisPJEX, lblPaisPJEX) = False Then
                Exit Function
            End If

            If ValidaCampo(cboUFPJEX, lblUFPJEX) = False Then
                Exit Function
            End If

            If ValidaCampo(cboMunicipioPJEX, lblMunicipioPJEX) = False Then
                Exit Function
            End If

            If ValidaCampo(txtLogradouroPJEX, lblLogradouroPJEX, TipoCampo.texto) = False Then
                Exit Function
            End If

            If ValidaCampo(txtNumeroPJEX, lblNumeroPJEX, TipoCampo.texto) = False Then
                Exit Function
            End If

            If ValidaCampo(cboTipoSocietarioPJEX, lblTipoSocietarioPJEX) = False Then
                Exit Function
            End If

            If ValidaCampo(cboQualificacaoPJEX, lblQualificacaoPJEX) = False Then
                Exit Function
            End If

            ValidacaoPessoaJuridicaEstrangeira = True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub SalvarPessoaJuridicaEstrangeira()
        Try


            If IsNumeric(btnSalvar.Tag) Then

                oClsUsrCadParceiroNegocio.UpdateSocio(btnSalvar.Tag, iCodigoParceiroNegocio, txtRazaoSocialPJEX.Text, _
                                                      "", "", "", -1, txtCEPPJEX.Text, cboPaisPJEX.SelectedValue, cboUFPJEX.SelectedValue, _
                                                      cboMunicipioPJEX.SelectedValue, txtLogradouroPJEX.Text, txtNumeroPJEX.Text, _
                                                      txtBairroPJEX.Text, txtComplementoPJEX.Text, cboQualificacaoPJEX.SelectedValue, _
                                                      txtTelefonePJEX.Text, txtEmailPJEX.Text, txtTaxIDPJEX.Text, "", cboTipoSocietarioPJEX.SelectedValue, _
                                                      IIf(cboOrgaoRegistroPJEX.SelectedIndex = -1, -1, cboOrgaoRegistroPJEX.SelectedValue), _
                                                      "", "", "", "", txtRepresentanteLegalPJEX.Text, txtNumeroCadastroPJEX.Text, _
                                                      chkPessoaFisica.Checked, chkPessoaJuridica.Checked, chkEstrangeira.Checked, chkBrasileira.Checked, _
                                                      IIf(dtpDataAdmissaoPJEX.Checked = True, dtpDataAdmissaoPJEX.Value, ""), "", "", "")

            Else

                oClsUsrCadParceiroNegocio.InsertSocio(iCodigoParceiroNegocio, txtRazaoSocialPJEX.Text, _
                                                      "", "", "", -1, txtCEPPJEX.Text, cboPaisPJEX.SelectedValue, cboUFPJEX.SelectedValue, _
                                                      cboMunicipioPJEX.SelectedValue, txtLogradouroPJEX.Text, txtNumeroPJEX.Text, _
                                                      txtBairroPJEX.Text, txtComplementoPJEX.Text, cboQualificacaoPJEX.SelectedValue, _
                                                      txtTelefonePJEX.Text, txtEmailPJEX.Text, txtTaxIDPJEX.Text, "", cboTipoSocietarioPJEX.SelectedValue, _
                                                      IIf(cboOrgaoRegistroPJEX.SelectedIndex = -1, -1, cboOrgaoRegistroPJEX.SelectedValue), _
                                                      "", "", "", "", txtRepresentanteLegalPJEX.Text, txtNumeroCadastroPJEX.Text, _
                                                      chkPessoaFisica.Checked, chkPessoaJuridica.Checked, chkEstrangeira.Checked, chkBrasileira.Checked, _
                                                      IIf(dtpDataAdmissaoPJEX.Checked = True, dtpDataAdmissaoPJEX.Value, ""), "", "", "")

            End If


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LoadControlesPessoaJuridicaEstrangeira()
        Try
            oClsUsrCadParceiroNegocio.LoadControlesSocio(iCodigoParceiroNegocio, iCodigo, _
                                                         txtRazaoSocialPJEX, txtCNPJPJBR, txtRGPFBR, txtNacionalidadePFEX, cboEstadoCivilPFEX, _
                                                         txtCEPPJEX, cboPaisPJEX, cboUFPJEX, cboMunicipioPJEX, txtLogradouroPJEX, txtNumeroPJEX, _
                                                         txtBairroPJEX, txtComplementoPJEX, cboQualificacaoPJEX, txtTelefonePJEX, txtEmailPJEX, _
                                                         txtTaxIDPJEX, txtIDPFEX, cboTipoSocietarioPJEX, cboOrgaoRegistroPJEX, txtNirePJBR, _
                                                         dtpDataInicioAtivPJBR, txtNumeroRegistoPJBR, dtpDataRegistroPJBR, txtRepresentanteLegalPJEX, _
                                                         txtNumeroCadastroPJEX, dtpDataAdmissaoPJEX, _
                                                         txtCidadeNascimentoPFEX, _
                                                         dtpDataNascimentoPFEX, txtProfissaoPFEX)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region
#End Region

    

End Class