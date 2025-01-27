Public Class usrCfgBancoContaSaldoInicial

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oCfgBancoContaSaldoInicial As New clsUsrCfgBancoContaSaldoInicial

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrCfgBancoContaSaldoInicial_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Try

            Select e.KeyCode

                Case Keys.Enter 
                    Control_Enter(sender)

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboContaBancaria" : Call btnCadastrarContaBancaria_Click(btnCadastrarContaBancaria, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCfgBancoContaSaldoInicial_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCfgBancoContaSaldoInicial_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona o User Control
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

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

        'Deleta Aba
        If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
        'Fecha o Controle
        Me.Dispose()

    End Sub

    Private Sub cboContaBancaria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboContaBancaria.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum modelo
            If cboContaBancaria.SelectedIndex = -1 Then
                'Limpa Controles
                txtSaldo.Value = 0
                dtpData.Value = Now.Date
            Else
                'Carrega Dados
                oCfgBancoContaSaldoInicial.LoadDados(cboContaBancaria.SelectedValue, _
                                                     dtpData, _
                                                     txtSaldo)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarContaBancaria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarContaBancaria.Click

        Try

                         'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadBancoConta")

            'Carrega Combo            
            LoadCombo(cboContaBancaria, "sp_select_combo_cadastro_basico_banco_conta " & goUsuario.iEmpresa)

            'Seta Focu
            cboContaBancaria.Focus()

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCfgBancoContaSaldoInicial_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnSalvar.Enabled = VerificaDireito(Formulario.ConfiguracaoBancoContaSaldoInicial, gcInsert)

            'Carrega Combo
            Call LoadCombo(cboContaBancaria, "sp_select_combo_cadastro_basico_banco_conta " & goUsuario.iEmpresa)

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
            oCfgBancoContaSaldoInicial.CodigoBancoConta = cboContaBancaria.SelectedValue
            oCfgBancoContaSaldoInicial.Data = dtpData.Value
            oCfgBancoContaSaldoInicial.SaldoInicial = txtSaldo.Value
            'Salva Dados
            oCfgBancoContaSaldoInicial.Save()

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
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

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Function

#End Region

End Class
