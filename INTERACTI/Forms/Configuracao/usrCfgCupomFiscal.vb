Imports BoletoNet

Public Class usrCfgCupomFiscal

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oCfgCupomFiscal As New clsUsrCfgCupomFiscal

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrCfgCupomFiscal_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    Control_Enter(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCfgCupomFiscal_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCfgCupomFiscal_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona User Control
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

    Private Sub btnArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArquivo.Click

        Try

            'Variaveis Locais
            Dim arqINI As New OpenFileDialog

            'Abre PopUp para Usuário selecionar Imagem
            arqINI.InitialDirectory = "c:\\dados"
            arqINI.Filter = "(INI)|*.INI"
            arqINI.Title = "Selecione o Arquivo"

            If arqINI.ShowDialog() = DialogResult.OK Then
                txtArquivo.Text = arqINI.FileName
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCfgCupomFiscal_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnSalvar.Enabled = VerificaDireito(Formulario.ConfiguracaoCupomFiscal, gcInsert)

            'Carrega Combo
            Call LoadCombo(cboDepositoPadrao, "sp_select_combo_cadastro_basico_deposito_proprio_interno " & goUsuario.iEmpresa)
            Call LoadCombo(cboContaBancaria, "sp_select_combo_cadastro_basico_banco_conta " & goUsuario.iEmpresa)
            cboTipoICF.Items.Clear()
            cboTipoICF.Items.Add("IMPRESSORA", 0) : cboTipoICF.Items.Add("EMULADOR", 1)

            'Carrega Configuração
            oCfgCupomFiscal.LoadDados(txtCupomFiscal, _
                                      txtMensagem, _
                                      cboTipoICF, _
                                      txtArquivo, _
                                      cboDepositoPadrao, _
                                      cboContaBancaria)

            'Seta Focu
            txtCupomFiscal.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oCfgCupomFiscal.CupomFiscal = txtCupomFiscal.Text
            oCfgCupomFiscal.Mensagem = txtMensagem.Text
            oCfgCupomFiscal.TipoICF = cboTipoICF.SelectedValue
            oCfgCupomFiscal.Arquivo = txtArquivo.Text
            oCfgCupomFiscal.CodigoDeposito = cboDepositoPadrao.SelectedValue
            oCfgCupomFiscal.CodigoBancoConta = cboContaBancaria.SelectedValue
            'Salva Dados
            oCfgCupomFiscal.Save()

            'Altera Arquivo *.ini
            Call WritePrivateProfileString("SISTEMA", "EmulMFD", cboTipoICF.SelectedValue, txtArquivo.Text)

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

            'Verifica se foi Preenchido o Campo - Cupom Fiscal
            If ValidaCampo(txtCupomFiscal, lblCupomFiscal, TipoCampo.numero) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Tipo ICF
            If ValidaCampo(cboTipoICF, lblTipoICF) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Arquivo
            If ValidaCampo(txtArquivo, lblArquivo, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Depósito Padrão
            If ValidaCampo(cboDepositoPadrao, lblDepositoPadrao) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Conta Bancária
            If ValidaCampo(cboContaBancaria, lblContaBancaria) = False Then
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
