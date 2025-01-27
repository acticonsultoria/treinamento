Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class frmFinReceitaPagamentoECF

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsFinReceitaPagamento As New clsUsrFinReceitaPagamento

    Private lCodigoTituloCapa As Long
    Private iCodigoFormaPagamento As Integer
    Private sParcela As String
    Private dValor As Double

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoTituloCapa() As Long
        Get
            Return lCodigoTituloCapa
        End Get
        Set(ByVal value As Long)
            lCodigoTituloCapa = value
        End Set
    End Property

    Public Property CodigoFormaPagamento() As Integer
        Get
            Return iCodigoFormaPagamento
        End Get
        Set(ByVal value As Integer)
            iCodigoFormaPagamento = value
        End Set
    End Property

    Public Property Parcela() As String
        Get
            Return sParcela
        End Get
        Set(ByVal value As String)
            sParcela = value
        End Set
    End Property

    Public Property Valor() As Double
        Get
            Return dValor
        End Get
        Set(ByVal value As Double)
            dValor = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frmFinReceitaPagamentoECF_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown, _
                                                                                                                              cboNumeroDocumentoChequeTerceiro.KeyUp, _
                                                                                                                              cboNumeroDocumentoChequeTerceiro.KeyUp

        Try

            Select Case e.KeyCode

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboContaBancaria" : Call LoadCombo(cboContaBancaria, "sp_select_combo_cadastro_basico_banco_conta " & goUsuario.iEmpresa)
                        Case "cboNumeroDocumentoChequeTerceiro" : Call LoadCombo(cboNumeroDocumentoChequeTerceiro, "sp_select_combo_financeiro_receita_cheque_terceiro " & goUsuario.iEmpresa)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboContaBancaria" : Call btnCadastrarContaBancaria_Click(btnCadastrarContaBancaria, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmFinReceitaPagamentoECF_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarFormulario()

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
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formúlário
            If Validacao() = True Then
                'Salva Pagamento
                Call Salvar()
                'Fecha o Formulário
                Me.Dispose()
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

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

    Private Sub cboPreDatadoCheque_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPreDatadoCheque.SelectedIndexChanged

        Try

            'Oculta Controles
            lblDataCompensacaoCheque.Visible = False
            dtpDataCompensacaoCheque.Visible = False

            'Exibe Controles
            If cboPreDatadoCheque.SelectedValue = True Then
                lblDataCompensacaoCheque.Visible = True
                dtpDataCompensacaoCheque.Visible = True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboNumeroDocumentoChequeTerceiro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNumeroDocumentoChequeTerceiro.SelectedIndexChanged

        Try

            'Carrega Dados do Cheque de Terceiro
            If cboNumeroDocumentoChequeTerceiro.SelectedIndex <> -1 Then

                Dim sCodigo() As String = cboNumeroDocumentoChequeTerceiro.SelectedValue.ToString.Split("|")

                'Carrega Dados do Cheque de Terceiro
                Call oClsFinReceitaPagamento.LoadDadosChequeTerceiro(sCodigo(0), _
                                                                     sCodigo(1), _
                                                                     sCodigo(2), _
                                                                     txtBancoChequeTerceiro, _
                                                                     txtDataRecebimentoChequeTerceiro, _
                                                                     txtPreDatadoChequeTerceiro, _
                                                                     txtValorChequeTerceiro)

            Else

                txtBancoChequeTerceiro.Text = ""
                txtDataRecebimentoChequeTerceiro.Text = ""
                txtPreDatadoChequeTerceiro.Text = ""
                txtValorChequeTerceiro.Text = ""

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub TratarBoletoBancario(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumeroBoleto1.TextChanged, _
                                                                                                  txtNumeroBoleto2.TextChanged, _
                                                                                                  txtNumeroBoleto3.TextChanged, _
                                                                                                  txtNumeroBoleto4.TextChanged, _
                                                                                                  txtNumeroBoleto5.TextChanged, _
                                                                                                  txtNumeroBoleto6.TextChanged, _
                                                                                                  txtNumeroBoleto7.TextChanged, _
                                                                                                  txtNumeroBoleto8.TextChanged

        Try

            If sender.MaxLength = sender.Text.Length Then

                SendKeys.Send("{TAB}")

                If sender.Name = "txtNumeroBoleto8" Then
                    dtpDataPagamentoBoleto.Value = DateAdd(DateInterval.Day, CLng(Mid(sender.text, 1, 4)), gcDateInicioBoleto)
                    txtValorBoleto.Value = CDbl(Mid(sender.text, 5)) / 100
                End If

            ElseIf sender.Name = "txtNumeroBoleto1" Then
                If sender.Text.Length >= 3 Then
                    txtBancoBoleto.Text = LoadDadosBanco(Mid(sender.Text, 1, 3))
                End If
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Verifica Direito - Botão de Cadastro
            btnCadastrarContaBancaria.Enabled = VerificaDireito(Formulario.CadastroBasicoBancoConta, gcInsert)

            'Carrega ComboBox
            Call LoadCombo(cboContaBancaria, "sp_select_combo_cadastro_basico_banco_conta " & goUsuario.iEmpresa)
            Call LoadComboSimNao(cboPreDatadoCheque)

            'Seta Conta Bancária
            cboContaBancaria.SelectedValue = CType(LoadDescricao("sp_select_configuracao_cupom_fiscal_conta_bancaria " & goUsuario.iEmpresa & ", '" & System.Net.Dns.GetHostName & "'"), Integer)

            'Configura Forma de Pagamento
            Call ConfiguraFormularioFormaPagamento()

            'Seta Focu
            cboContaBancaria.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub ConfiguraFormularioFormaPagamento()

        Try

            'Oculta Controles
            grpBoleto.Visible = False
            grpCheque.Visible = False
            grpChequeTerceiro.Visible = False
            grpOutros.Visible = False
            grpOutrosSimples.Visible = False

            'Torna Controle Visivel
            GetControlByName(LoadFormTipoDocumentoPagamento(iCodigoFormaPagamento, _
                                                            "sp_select_static_form_tipo_documento_pagamento_receita"), Me).Visible = True

            'Verifica Controle
            If grpBoleto.Visible = True Then
                'Limpa Controles - Boleto
                dtpDataPagamentoBoleto.Value = Now.Date
                txtValorBoleto.Value = dValor
                txtNumeroBoleto1.Text = ""
                txtNumeroBoleto2.Text = ""
                txtNumeroBoleto3.Text = ""
                txtNumeroBoleto4.Text = ""
                txtNumeroBoleto5.Text = ""
                txtNumeroBoleto6.Text = ""
                txtNumeroBoleto7.Text = ""
                txtNumeroBoleto8.Text = ""
                txtBancoBoleto.Text = ""
            ElseIf grpCheque.Visible = True Then
                'Limpa Controles - Cheque
                dtpDataPagamentoCheque.Value = Now.Date
                txtValorCheque.Value = dValor
                txtNumeroDocumentoCheque.Text = ""
                txtFavorecidoCheque.Text = ""
                cboPreDatadoCheque.SelectedValue = False
                lblDataCompensacaoCheque.Visible = False
                dtpDataCompensacaoCheque.Visible = False
                dtpDataCompensacaoCheque.Value = Now.Date                
            ElseIf grpChequeTerceiro.Visible = True Then
                'Limpa Controles - Cheque de Terceiro
                Call LoadCombo(cboNumeroDocumentoChequeTerceiro, "sp_select_combo_financeiro_titulo_cheque_terceiro " & goUsuario.iEmpresa)
                cboNumeroDocumentoChequeTerceiro.SelectedIndex = -1
            ElseIf grpOutros.Visible = True Then
                'Limpa Controles - Outros
                dtpDataPagamentoOutros.Value = Now.Date
                txtValorOutros.Value = dValor
                txtNumeroDocumentoOutros.Text = ""
                Me.Height -= 40
            ElseIf grpOutrosSimples.Visible = True Then
                'Limpa Controles - Outros Simples
                dtpDataPagamentoOutrosSimples.Value = Now.Date
                txtValorOutrosSimples.Value = dValor
                Me.Height -= 40
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim sNumeroParcela() As String
            Dim i As Integer = 0

            sNumeroParcela = sParcela.Split(",")

            For i = 0 To UBound(sNumeroParcela)

                Select Case LoadFormTipoDocumentoPagamento(iCodigoFormaPagamento, _
                                                          "sp_select_static_form_tipo_documento_pagamento_receita")

                    Case "grpBoleto"
                        Call oClsFinReceitaPagamento.InsertPagamentoIndividual(lCodigoTituloCapa, _
                                                                               sNumeroParcela(i), _
                                                                               cboContaBancaria.SelectedValue, _
                                                                               iCodigoFormaPagamento, _
                                                                               txtNumeroBoleto1.Text & " " & txtNumeroBoleto2.Text & " " & txtNumeroBoleto3.Text & " " & txtNumeroBoleto4.Text & " " & txtNumeroBoleto5.Text & " " & txtNumeroBoleto6.Text & " " & txtNumeroBoleto7.Text & " " & txtNumeroBoleto8.Text, _
                                                                               dtpDataPagamentoBoleto.Value, _
                                                                               txtValorBoleto.Value, _
                                                                               txtBancoBoleto.Text.Trim, _
                                                                               "", _
                                                                               -1, _
                                                                               "", _
                                                                               -1, _
                                                                               -1, _
                                                                               -1, _
                                                                               StatusReceitaPagamento.Quitado)

                    Case "grpOutros"
                        Call oClsFinReceitaPagamento.InsertPagamentoIndividual(lCodigoTituloCapa, _
                                                                               sNumeroParcela(i), _
                                                                               cboContaBancaria.SelectedValue, _
                                                                               iCodigoFormaPagamento, _
                                                                               txtNumeroDocumentoOutros.Text.Trim, _
                                                                               dtpDataPagamentoOutros.Value, _
                                                                               txtValorOutros.Value, _
                                                                               "", _
                                                                               "", _
                                                                               -1, _
                                                                               "", _
                                                                               -1, _
                                                                               -1, _
                                                                               -1, _
                                                                               StatusReceitaPagamento.Quitado)
                    Case "grpOutrosSimples"
                        Call oClsFinReceitaPagamento.InsertPagamentoIndividual(lCodigoTituloCapa, _
                                                                               sNumeroParcela(i), _
                                                                               cboContaBancaria.SelectedValue, _
                                                                               iCodigoFormaPagamento, _
                                                                               "", _
                                                                               dtpDataPagamentoOutrosSimples.Value, _
                                                                               txtValorOutrosSimples.Value, _
                                                                               "", _
                                                                               "", _
                                                                               -1, _
                                                                               "", _
                                                                               -1, _
                                                                               -1, _
                                                                               -1, _
                                                                               StatusReceitaPagamento.Quitado)

                    Case "grpCheque"
                        Call oClsFinReceitaPagamento.InsertPagamentoIndividual(lCodigoTituloCapa, _
                                                                               sNumeroParcela(i), _
                                                                               cboContaBancaria.SelectedValue, _
                                                                               iCodigoFormaPagamento, _
                                                                               txtNumeroDocumentoCheque.Text.Trim, _
                                                                               dtpDataPagamentoCheque.Value, _
                                                                               txtValorCheque.Value, _
                                                                               "", _
                                                                               txtFavorecidoCheque.Text.Trim, _
                                                                               IIf(cboPreDatadoCheque.SelectedValue = True, 1, 0), _
                                                                               IIf(dtpDataCompensacaoCheque.Visible = True, dtpDataCompensacaoCheque.Value, ""), _
                                                                               -1, _
                                                                               -1, _
                                                                               -1, _
                                                                               StatusReceitaPagamento.ChequeNaoCompensado)

                    Case "grpChequeTerceiro"

                        Dim sCodigo() As String = cboNumeroDocumentoChequeTerceiro.SelectedValue.ToString.Split("|")

                        Call oClsFinReceitaPagamento.InsertPagamentoIndividual(lCodigoTituloCapa, _
                                                                               sNumeroParcela(i), _
                                                                               cboContaBancaria.SelectedValue, _
                                                                               iCodigoFormaPagamento, _
                                                                               cboNumeroDocumentoChequeTerceiro.Text.Trim, _
                                                                               dtpDataPagamentoChequeTerceiro.Value, _
                                                                               txtValorChequeTerceiro.Value, _
                                                                               txtBancoChequeTerceiro.Text.Trim, _
                                                                               "", _
                                                                               -1, _
                                                                               "", _
                                                                               sCodigo(0), _
                                                                               sCodigo(1), _
                                                                               sCodigo(2), _
                                                                               StatusReceitaPagamento.ChequeNaoCompensado)

                End Select

            Next

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

            'Desabilita Botão
            btnPagar.Enabled = False

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

            'Verifica se foi Selecionado o Campo - Conta Bancária
            If ValidaCampo(cboContaBancaria, lblContaBancaria) = False Then
                Exit Function
            End If

            'Outros
            If grpOutros.Visible = True Then

                'Verifica se foi Preenchido o Campo - Número do Documento
                If ValidaCampo(txtNumeroDocumentoOutros, lblNumeroDocumentoOutros, TipoCampo.texto) = False Then
                    Exit Function
                End If

            End If

            'Cheque
            If grpCheque.Visible = True Then

                'Verifica se foi Preenchido o Campo - Número do Cheque
                If ValidaCampo(txtNumeroDocumentoCheque, lblNumeroDocumentoCheque, TipoCampo.texto) = False Then
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - Valor
                If ValidaCampo(txtValorCheque, lblValorCheque, True) = False Then
                    Exit Function
                End If

            End If

            'Cheque de Terceiros
            If grpChequeTerceiro.Visible = True Then

                'Verifica se foi Selecionado o Campo - Número do Cheque
                If ValidaCampo(cboNumeroDocumentoChequeTerceiro, lblNumeroDocumentoChequeTerceiro) = False Then
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - Valor
                If ValidaCampo(txtValorChequeTerceiro, lblValorChequeTerceiro, True) = False Then
                    Exit Function
                End If

            End If

            'Boleto Bancário
            If grpBoleto.Visible = True Then

                'Verifica se foi Preenchido o Campo - Boleto 1
                If ValidaCampo(txtNumeroBoleto1, lblBancoBoleto, TipoCampo.numero) = False Then
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - Boleto 2
                If ValidaCampo(txtNumeroBoleto2, lblBancoBoleto, TipoCampo.numero) = False Then
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - Boleto 3
                If ValidaCampo(txtNumeroBoleto3, lblBancoBoleto, TipoCampo.numero) = False Then
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - Boleto 4
                If ValidaCampo(txtNumeroBoleto4, lblBancoBoleto, TipoCampo.numero) = False Then
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - Boleto 5
                If ValidaCampo(txtNumeroBoleto5, lblBancoBoleto, TipoCampo.numero) = False Then
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - Boleto 6
                If ValidaCampo(txtNumeroBoleto6, lblBancoBoleto, TipoCampo.numero) = False Then
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - Boleto 7
                If ValidaCampo(txtNumeroBoleto7, lblBancoBoleto, TipoCampo.numero) = False Then
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - Valor Boleto
                If ValidaCampo(txtValorBoleto, lblValorBoleto, True) = False Then
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

End Class
