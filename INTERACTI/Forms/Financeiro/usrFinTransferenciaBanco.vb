Public Class usrFinTransferenciaBanco

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsUsrFinTransferenciaBanco As New clsUsrFinTransferenciaBanco

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrCfgBancoContaSaldoInicial_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCfgBancoContaSaldoInicial_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona UserControl
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

    Private Sub cboContaBancariaOrigem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboContaBancariaOrigem.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum modelo
            If cboContaBancariaOrigem.SelectedIndex = -1 Then
                'Limpa Dados
                txtSaldoContaBancariaOrigem.Value = 0
            Else
                'Carrega Dados
                txtSaldoContaBancariaOrigem.Value = oClsUsrFinTransferenciaBanco.LoadSaldoAtual(cboContaBancariaOrigem.SelectedValue, _
                                                                                                dtpData.Value)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboContaBancariaDestino_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValorTransferencia.ValueChanged, _
                                                                                                                                 cboContaBancariaDestino.SelectedIndexChanged

        Try

            'Verifica se foi selecionado algum modelo
            If cboContaBancariaDestino.SelectedIndex = -1 Then
                'Limpa Dados
                txtSaldoFinalContaBancariaDestino.Value = 0

            Else
                'Carrega Dados
                txtSaldoFinalContaBancariaDestino.Value = oClsUsrFinTransferenciaBanco.LoadSaldoAtual(cboContaBancariaDestino.SelectedValue, _
                                                                                                      dtpData.Value)
                txtSaldoFinalContaBancariaDestino.Value += txtValorTransferencia.Value
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

            'Carrega Combo
            Call LoadCombo(cboContaBancariaOrigem, "sp_select_combo_cadastro_basico_banco_conta " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboContaBancariaDestino, "sp_select_combo_cadastro_basico_banco_conta " & goUsuario.iEmpresa, False)

            'Verifica Direito
            btnSalvar.Enabled = VerificaDireito(Formulario.FinanceiroTransferenciaBancaria, gcInsert)

            'Seta Focu
            cboContaBancariaOrigem.Focus()

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

            'Salvando a transferência
            oClsUsrFinTransferenciaBanco.SalvarTransferencia(cboContaBancariaOrigem.SelectedValue, _
                                                             txtValorTransferencia.Value, _
                                                             cboContaBancariaDestino.SelectedValue, _
                                                             dtpData.Value, _
                                                             txtNumeroDocumento.Text)

            'Zerando os valores
            cboContaBancariaDestino.SelectedIndex = -1
            cboContaBancariaOrigem.SelectedIndex = -1
            txtValorTransferencia.Value = 0
            txtNumeroDocumento.Text = ""
            dtpData.Value = Now

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

            'Verifica se foi Selecionado o Campo
            If ValidaCampo(cboContaBancariaOrigem, lblContaBancariaOrigem) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo
            If ValidaCampo(cboContaBancariaDestino, lblContaBancariaDestino) = False Then
                Exit Function
            End If

            'Verifica se a Conta Bancária de Origem é diferente da Conta Bancária de Destino
            If cboContaBancariaDestino.SelectedValue = cboContaBancariaOrigem.SelectedValue Then
                frmMain.errInfo.SetError(lblContaBancariaDestino, "A Conta Bancária de Destino não pode ser igual a Conta Bancária de Origem.")
                cboContaBancariaDestino.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo 
            If ValidaCampo(txtValorTransferencia, lblValorTransferencia, True) = False Then
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
