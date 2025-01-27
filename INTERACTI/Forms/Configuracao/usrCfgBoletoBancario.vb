Imports BoletoNet

Public Class usrCfgBoletoBancario

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oCfgBoletoBancario As New clsUsrCfgBoletoBancario

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrCfgBoletoBancario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    Control_Enter(sender)

                Case Keys.F3

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboCentroGasto" : Call btnProcurarCentroGasto_Click(btnProcurarCentroGasto, System.EventArgs.Empty)
                        Case "cboContaContabil" : Call btnProcurarContaContabil_Click(btnProcurarContaContabil, System.EventArgs.Empty)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboCentroGasto" : Call LoadCombo(cboCentroGasto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)
                        Case "cboContaContabil" : Call LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboCentroGasto" : Call btnCadastrarCentroGasto_Click(btnCadastrarCentroGasto, System.EventArgs.Empty)
                        Case "cboContaContabil" : Call btnCadastrarContaContabil_Click(btnCadastrarContaContabil, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCfgBoletoBancario_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCfgBoletoBancario_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona User Control
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

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

    Private Sub btnProcurarContaContabil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarContaContabil.Click

        Try
            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindPlanoContas"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Conta Contábil"

            'Seta Parametros
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

    Private Sub btnCadastrarContaContabil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarContaContabil.Click

        Try

                        'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadPlanoContas")

            'Carrega Combo            
            Call LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa)

            'Seta Focu
            cboContaContabil.Focus()

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

    Private Sub cboContaBancaria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboContaBancaria.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum modelo
            If cboContaBancaria.SelectedIndex = -1 Then

                'Limpa Controles
                cboCentroGasto.Text = ""
                cboContaContabil.Text = ""
                txtJuros.Value = 0
                txtMulta.Value = 0
                cboCNAB.SelectedIndex = -1
                txtConvenio.Text = ""
                cboInstrucao1.SelectedIndex = -1
                cboInstrucao2.SelectedIndex = -1
                cboInstrucao3.SelectedIndex = -1
                txtNumeroDias1.Value = 0
                txtNumeroDias2.Value = 0
                txtNumeroDias3.Value = 0

            Else

                'Carrega Dados
                oCfgBoletoBancario.LoadDados(cboContaBancaria.SelectedValue, _
                                             cboCentroGasto, _
                                             cboContaContabil, _
                                             txtJuros, _
                                             txtMulta, _
                                             cboCNAB, _
                                             txtConvenio, _
                                             cboInstrucao1, _
                                             cboInstrucao2, _
                                             cboInstrucao3, _
                                             txtNumeroDias1, _
                                             txtNumeroDias2, _
                                             txtNumeroDias3)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

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

    Private Sub cboInstrucao3_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboInstrucao3.SelectedIndexChanged

        Try

            'Seta Controle
            If cboInstrucao3.SelectedIndex = -1 Then
                txtNumeroDias3.Enabled = False
                txtNumeroDias3.Value = 0
            ElseIf CType(LoadDescricao("sp_select_static_instrucao_boleto_bancario_dia '" & cboInstrucao3.SelectedValue & "'"), Boolean) = False Then
                txtNumeroDias3.Enabled = False
                txtNumeroDias3.Value = 0
            Else
                txtNumeroDias3.Enabled = True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCfgBoletoBancario_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnSalvar.Enabled = VerificaDireito(Formulario.ConfiguracaoBoletoBancario, gcInsert)
            'Verifica Direito - Controles
            btnCadastrarCentroGasto.Enabled = VerificaDireito(Formulario.CadastroBasicoCentroGasto, gcInsert)
            btnCadastrarContaContabil.Enabled = VerificaDireito(Formulario.CadastroBasicoPlanoContas, gcInsert)

            'Carrega Combo
            Call LoadCombo(cboContaBancaria, "sp_select_combo_cadastro_basico_banco_conta " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboCentroGasto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboCNAB, "sp_select_combo_static_cnab", False)
            Call LoadCombo(cboInstrucao1, "sp_select_combo_static_instrucao_boleto_bancario", False)
            Call LoadCombo(cboInstrucao2, "sp_select_combo_static_instrucao_boleto_bancario", False)
            Call LoadCombo(cboInstrucao3, "sp_select_combo_static_instrucao_boleto_bancario", False)


            'Seta Controles
            txtNumeroDias1.Enabled = False
            txtNumeroDias2.Enabled = False

            'Seta Focu
            cboContaBancaria.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oCfgBoletoBancario.BancoConta = cboContaBancaria.SelectedValue
            oCfgBoletoBancario.CodigoCentroGasto = IIf(cboCentroGasto.SelectedIndex = -1, -1, cboCentroGasto.SelectedValue)
            oCfgBoletoBancario.ContaContabil = IIf(cboContaContabil.SelectedIndex = -1, "", cboContaContabil.SelectedValue)
            oCfgBoletoBancario.Juros = txtJuros.Value
            oCfgBoletoBancario.Multa = txtMulta.Value
            oCfgBoletoBancario.CNAB = IIf(cboCNAB.SelectedIndex = -1, -1, cboCNAB.SelectedValue)
            oCfgBoletoBancario.Convenio = txtConvenio.Text.Trim
            oCfgBoletoBancario.Instrucao1 = IIf(cboInstrucao1.SelectedIndex = -1, "", cboInstrucao1.SelectedValue)
            oCfgBoletoBancario.Instrucao2 = IIf(cboInstrucao2.SelectedIndex = -1, "", cboInstrucao2.SelectedValue)
            oCfgBoletoBancario.Instrucao3 = IIf(cboInstrucao3.SelectedIndex = -1, "", cboInstrucao3.SelectedValue)
            oCfgBoletoBancario.NumeroDias1 = IIf(txtNumeroDias1.Enabled = True, txtNumeroDias1.Value, -1)
            oCfgBoletoBancario.NumeroDias2 = IIf(txtNumeroDias2.Enabled = True, txtNumeroDias2.Value, -1)
            oCfgBoletoBancario.NumeroDias3 = IIf(txtNumeroDias3.Enabled = True, txtNumeroDias3.Value, -1)
            'Salva Dados
            oCfgBoletoBancario.Salvar()

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

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

            'Verifica se foi Selecionado o Campo - Moedlo
            If ValidaCampo(cboContaBancaria, lblContaBancaria) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Juros
            If ValidaCampo(txtJuros, lblJuros, False) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Multa
            If ValidaCampo(txtMulta, lblMulta, False) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Instrução 1
            If ValidaCampo(cboInstrucao1, lblInstrucao1, False) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class
