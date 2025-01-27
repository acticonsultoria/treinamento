Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Drawing.Printing

Public Class usrPrdApontamentoAutoGestao

#Region "::: VARIAVEIS :::"

    Private oClsPrdApontamento As New clsUsrPrdApontamento

    Private iPasso As Integer
    Private lCodigoOrdemProducao As Long
    Private iSequencia As Integer
    Private iSequenciaConcorrente As Integer
    Private bOperacaoExterna As Boolean
    Private iCodigoApontamentoFuncionario As Integer
    Private iCodigoApontamentoFuncionarioParada As Integer
    Private iCodigoFuncionario As Integer
    Private iCodigoParceiroNegocio As Integer
    Private iCodigoMotivoParada As Integer
    Private iCodigoEquipamento As Integer
    Private iTipoApontamentoConcorrente As TipoApontamentoConcorrente = TipoApontamentoConcorrente.Nao
    Private bApontaEquipamento As Boolean = False
    Private dQuantidadeAbertura As Double = 0
    Private dQuantidadeAberturaTotal As Double = 0
    Private dQuantidadePlanejada As Double = 0

#End Region

#Region "::: ENUM :::"

    Private Enum TipoApontamento
        Abertura = 1
        Parada = 2
        Reabertura = 3
        Fechamento = 4
    End Enum

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrPrdApontamentoAutoGestao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    Select Case sender.name
                        Case "cboTipoApontamento" : Call Passo1()
                        Case "cboOPOperacao" : Call Passo2()
                        Case "cboFuncionario" : If bOperacaoExterna = False Then Call Passo3() Else Call Passo4()
                        Case "cboEquipamento" : Call Passo5()
                        Case "txtQuantidadeProduzida" : Call Passo7()
                        Case "txtQuantidadeAbertura" : Call Passo6()
                        Case "cboMotivoParada" : Call Passo8()
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrPrdApontamentoAutoGestao_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnCadastrarMotivoParada_Click(sender As Object, e As EventArgs) Handles btnCadastrarMotivoParada.Click

        Try

           'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadMotivoParada")

            'Carrega Combo
            Call LoadCombo(cboMotivoParada, "sp_select_combo_cadastro_basico_motivo_parada " & goUsuario.iEmpresa, True)

            'Seta Focu
            cboMotivoParada.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            'Prepara Formulário para Inicio de Coleta
            Call Novo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Deleta Aba
        If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
        'Fecha o Controle
        Me.Dispose()

    End Sub

    Private Sub txtQuantidadeProduzida_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQuantidadeProduzida.TextChanged

        'Calcula a Quantidade de Rejeito
        lblQuantidadeRejeitoValor.Text = FormatNumber(txtQuantidadeAbertura.Value - txtQuantidadeProduzida.Value, 4, Microsoft.VisualBasic.TriState.True)

    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick

        Try

            Select Case iPasso
                Case 1 : lblInformativo.Text = "INFORME O TIPO DE APONTAMENTO"
                Case 2 : lblInformativo.Text = "INFORME A OP / OPERAÇÃO"
                Case 3 : lblInformativo.Text = "INFORME O FUNCIONÁRIO"
                Case 4 : lblInformativo.Text = "INFORME O FORNECEDOR"
                Case 5 : lblInformativo.Text = "INFORME O EQUIPAMENTO"
                Case 6 : lblInformativo.Text = "INFORME A QTDE. PRODUZIDA"
                Case 7 : lblInformativo.Text = "INFORME O MOTIVO PARADA"
                Case 8 : Timer.Stop() : Call Passo88()
                Case 9 : lblInformativo.Text = "INFORME O QTDE. ABERTURA"
                Case 99 : Timer.Stop() : Call Passo99()
            End Select

            'Seta Cor
            lblInformativo.ForeColor = IIf(lblInformativo.ForeColor = Color.Red, Color.Black, Color.Red)

            Application.DoEvents()

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrPrdApontamentoAutoGestao_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            cboTipoApontamento.Items.Clear()
            cboTipoApontamento.Items.Add("ABERTURA", 1)
            cboTipoApontamento.Items.Add("FECHAMENTO", 4)
            cboTipoApontamento.Items.Add("PARADA", 2)
            cboTipoApontamento.Items.Add("REABERTURA", 3)

            'Carrega Combo
            Call LoadCombo(cboEquipamento, "sp_select_combo_cadastro_basico_equipamento_apontamento " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboMotivoParada, "sp_select_combo_cadastro_basico_motivo_parada " & goUsuario.iEmpresa, False)

            'Prepara Formulário
            Call Novo()

            'Seta Focu
            cboTipoApontamento.Focus()

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

            'Limpa Controles
            cboTipoApontamento.Text = "" : cboTipoApontamento.Enabled = True
            cboOPOperacao.Text = "" : cboOPOperacao.Enabled = False
            cboFuncionario.Text = "" : cboFuncionario.Enabled = False
            cboEquipamento.Text = "" : cboEquipamento.Enabled = False
            txtQuantidadePlanejada.Text = "" : txtQuantidadePlanejada.Enabled = False
            txtQuantidadeAbertura.Text = "" : txtQuantidadeAbertura.Enabled = False
            cboMotivoParada.SelectedIndex = -1 : cboMotivoParada.Enabled = False : btnCadastrarMotivoParada.Enabled = False
            txtQuantidadeProduzida.Text = "" : txtQuantidadeProduzida.Enabled = False
            lblOrdemProducaoValor.Text = "-"
            lblCodigoProdutoValor.Text = "-"
            lblTipoApontamentoValor.Text = "-"
            lblQuantidadeRejeitoValor.Text = "0,0000"
            grdApontamento.DataSource = Nothing

            'Limpa Váriaveis
            iPasso = 1
            lCodigoOrdemProducao = -1
            iSequencia = -1
            iSequenciaConcorrente = -1
            iCodigoApontamentoFuncionario = -1
            iCodigoApontamentoFuncionarioParada = -1
            iCodigoFuncionario = -1
            iCodigoEquipamento = -1
            iCodigoMotivoParada = -1
            iTipoApontamentoConcorrente = TipoApontamentoConcorrente.Nao
            bApontaEquipamento = False
            dQuantidadeAbertura = 0
            dQuantidadeAberturaTotal = 0
            dQuantidadePlanejada = 0

            'Limpa Gráfico
            chrIndicadorAtual.Series.Clear()
            chrIndicadorPeriodo.Series.Clear()

            'Seta Focu
            cboTipoApontamento.Focus()

            'Inicializa Timer
            Timer.Start()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Passo1()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Tipo de Apontamento
            If ValidaCampo(cboTipoApontamento, lblTipoApontamento) = False Then
                Exit Sub
            End If

            'Seta Controles
            lblTipoApontamentoValor.Text = cboTipoApontamento.Text

            'Carrega Combo - Ordem de Produção / Operação
            Call LoadCombo(cboOPOperacao, "sp_select_combo_producao_apontamento_ordem_operacao " & cboTipoApontamento.SelectedValue & ", " & goUsuario.iEmpresa, False)

            'Habilita / Desabilita Controle
            cboOPOperacao.Enabled = True
            cboTipoApontamento.Enabled = False

            'Seta Focu
            cboOPOperacao.Focus()

            'Seta Passo
            iPasso = 2

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Passo2()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado a Operação
            If ValidaCampo(cboOPOperacao, lblOPOperacao) = False Then
                Exit Sub
            End If

            'Váriavel Locais
            Dim sOrdemProducao As String = ""
            Dim sProduto As String = ""

            'Carrega Váriaveis
            lCodigoOrdemProducao = cboOPOperacao.SelectedValue.ToString.Substring(0, 5)
            iSequencia = cboOPOperacao.SelectedValue.ToString.Substring(5, 5)

            'Seta Controles
            Call oClsPrdApontamento.LoadDadosOrdemProducao(lCodigoOrdemProducao, _
                                                           iSequencia, _
                                                           sOrdemProducao, _
                                                           sProduto, _
                                                           bOperacaoExterna)

            'Carrega Gráfico
            Call oClsPrdApontamento.LoadGraficoOrdemProducao(chrIndicadorAtual, lCodigoOrdemProducao)

            'Seta Controles
            lblOrdemProducaoValor.Text = sOrdemProducao
            lblCodigoProdutoValor.Text = sProduto

            'Verifica o Tipo de Operação
            If bOperacaoExterna = False Then

                'Carrega Combo - Funcionario
                Call LoadCombo(cboFuncionario, "sp_select_combo_producao_apontamento_funcionario " & cboTipoApontamento.SelectedValue & ", " & lCodigoOrdemProducao & ", " & iSequencia & ", " & goUsuario.iEmpresa, False)
                lblFuncionario.Text = "Funcionário:"

                iPasso = 3

            Else

                'Carrega Combo - Funcionario
                Call LoadCombo(cboFuncionario, "sp_select_combo_producao_apontamento_parceiro_negocio " & cboTipoApontamento.SelectedValue & ", " & lCodigoOrdemProducao & ", " & iSequencia & ", " & goUsuario.iEmpresa, False)
                lblFuncionario.Text = "Fornecedor:"

                iPasso = 4

            End If

            'Habilita / Desabilita Controles
            cboFuncionario.Enabled = True
            cboOPOperacao.Enabled = False

            'Seta Focu
            cboFuncionario.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Passo3()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado O Funcionário
            If ValidaCampo(cboFuncionario, lblFuncionario) = False Then
                Exit Sub
            End If

            'Limpa Controle
            iCodigoParceiroNegocio = -1

            'Carrega Váriaveis
            Call oClsPrdApontamento.LoadDadosApontamento(cboTipoApontamento.SelectedValue, _
                                                         lCodigoOrdemProducao, _
                                                         iSequencia, _
                                                         cboFuncionario.SelectedValue.ToString.Replace("%", ""), _
                                                         iSequenciaConcorrente, _
                                                         iCodigoParceiroNegocio, _
                                                         iCodigoFuncionario, _
                                                         iCodigoApontamentoFuncionario, _
                                                         iCodigoApontamentoFuncionarioParada, _
                                                         iTipoApontamentoConcorrente, _
                                                         bApontaEquipamento, _
                                                         dQuantidadePlanejada, _
                                                         dQuantidadeAbertura, _
                                                         dQuantidadeAberturaTotal)

            'Carrega Gráfico
            'Call oClsPrdApontamento.LoadGraficoHistorico(chrIndicadorPeriodo, iCodigoFuncionario)

            'Desabilita Controle
            cboFuncionario.Enabled = False

            'Verifica o Próximo Passo
            Select Case cboTipoApontamento.SelectedValue

                Case TipoApontamento.Abertura
                    If iTipoApontamentoConcorrente = TipoApontamentoConcorrente.Nao Then
                        'Seta Controle
                        txtQuantidadePlanejada.Value = dQuantidadePlanejada
                        txtQuantidadeAbertura.Value = dQuantidadeAbertura
                        txtQuantidadeAbertura.Tag = dQuantidadeAberturaTotal
                        iPasso = 99
                    ElseIf iTipoApontamentoConcorrente = TipoApontamentoConcorrente.ApontaQuantidadeAbertuda Then
                        txtQuantidadePlanejada.Value = dQuantidadePlanejada
                        txtQuantidadeAbertura.Tag = dQuantidadeAbertura
                        txtQuantidadeAbertura.Enabled = True
                        txtQuantidadeAbertura.Focus()
                        iPasso = 9
                    ElseIf iTipoApontamentoConcorrente = TipoApontamentoConcorrente.NaoApontaQuantidadeAbertura Then
                        txtQuantidadePlanejada.Value = dQuantidadePlanejada
                        txtQuantidadeAbertura.Value = 0
                        txtQuantidadeAbertura.Tag = 0
                        iPasso = 99
                    End If

                Case TipoApontamento.Fechamento
                    If bApontaEquipamento = True Then
                        cboEquipamento.Enabled = True
                        cboEquipamento.Focus()
                        iPasso = 5
                    Else

                        If iTipoApontamentoConcorrente = TipoApontamentoConcorrente.Nao Or iTipoApontamentoConcorrente = TipoApontamentoConcorrente.ApontaQuantidadeAbertuda Then
                            'Seta Controle
                            txtQuantidadePlanejada.Value = dQuantidadePlanejada
                            txtQuantidadeAbertura.Value = dQuantidadeAbertura
                            txtQuantidadeProduzida.Enabled = True
                            txtQuantidadeProduzida.Focus()
                            iPasso = 6
                        ElseIf TipoApontamentoConcorrente.NaoApontaQuantidadeAbertura Then
                            'Seta Controle
                            txtQuantidadePlanejada.Value = dQuantidadePlanejada
                            txtQuantidadeAbertura.Enabled = True
                            txtQuantidadeProduzida.Enabled = True
                            txtQuantidadeAbertura.Focus()
                            iPasso = 6
                        End If
                    End If

                Case TipoApontamento.Parada
                    cboMotivoParada.Enabled = True
                    cboMotivoParada.Focus()
                    btnCadastrarMotivoParada.Enabled = VerificaDireito(Formulario.CadastroBasicoMotivoParada, gcInsert)
                    iPasso = 7

                Case TipoApontamento.Reabertura
                    iPasso = 99

            End Select

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Passo4()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado O Funcionário
            If ValidaCampo(cboFuncionario, lblFuncionario) = False Then
                Exit Sub
            End If

            iCodigoParceiroNegocio = cboFuncionario.SelectedValue
            iCodigoFuncionario = -1

            'Carrega Váriaveis
            Call oClsPrdApontamento.LoadDadosApontamento(cboTipoApontamento.SelectedValue, _
                                                         lCodigoOrdemProducao, _
                                                         iSequencia, _
                                                         "", _
                                                         iSequenciaConcorrente, _
                                                         iCodigoParceiroNegocio, _
                                                         iCodigoFuncionario, _
                                                         iCodigoApontamentoFuncionario, _
                                                         iCodigoApontamentoFuncionarioParada, _
                                                         iTipoApontamentoConcorrente, _
                                                         bApontaEquipamento, _
                                                         dQuantidadePlanejada, _
                                                         dQuantidadeAbertura, _
                                                         dQuantidadeAberturaTotal)

            'Desabilita Controle
            cboFuncionario.Enabled = False

            'Verifica o Próximo Passo
            Select Case cboTipoApontamento.SelectedValue

                Case TipoApontamento.Abertura
                    If iTipoApontamentoConcorrente = TipoApontamentoConcorrente.Nao Then
                        'Seta Controle
                        txtQuantidadePlanejada.Value = dQuantidadePlanejada
                        txtQuantidadeAbertura.Value = dQuantidadeAbertura
                        txtQuantidadeAbertura.Tag = dQuantidadeAberturaTotal
                        iPasso = 99
                    ElseIf iTipoApontamentoConcorrente = TipoApontamentoConcorrente.ApontaQuantidadeAbertuda Then
                        txtQuantidadePlanejada.Value = dQuantidadePlanejada
                        txtQuantidadeAbertura.Tag = dQuantidadeAbertura
                        txtQuantidadeAbertura.Enabled = True
                        txtQuantidadeAbertura.Focus()
                        iPasso = 9
                    ElseIf iTipoApontamentoConcorrente = TipoApontamentoConcorrente.Nao Then
                        'Seta Controle
                        txtQuantidadePlanejada.Value = dQuantidadePlanejada
                        txtQuantidadeAbertura.Value = 0
                        txtQuantidadeAbertura.Tag = 0
                        iPasso = 99
                    End If

                Case TipoApontamento.Fechamento
                    If bApontaEquipamento = True Then
                        iPasso = 5
                    Else
                        'Seta Controle
                        txtQuantidadePlanejada.Value = dQuantidadePlanejada
                        txtQuantidadeAbertura.Value = dQuantidadeAbertura
                        txtQuantidadeProduzida.Enabled = True
                        txtQuantidadeProduzida.Focus()
                        iPasso = 6
                    End If

                Case TipoApontamento.Parada
                    cboMotivoParada.Enabled = True
                    cboMotivoParada.Focus()
                    iPasso = 7

                Case TipoApontamento.Reabertura
                    iPasso = 99

            End Select

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Passo5()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Campo - Equipamento
            If ValidaCampo(cboEquipamento, lblEquipamento) = False Then
                Exit Sub
            End If

            'Seta Controles
            iCodigoEquipamento = cboEquipamento.SelectedValue.ToString.Replace("+", "")
            txtQuantidadePlanejada.Value = dQuantidadePlanejada
            txtQuantidadeAbertura.Value = dQuantidadePlanejada
            cboEquipamento.Enabled = False

            'Habilita Controles
            txtQuantidadeProduzida.Enabled = True
            txtQuantidadeProduzida.Focus()

            'Seta Passo
            iPasso = 6

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Passo6()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se a Quantidade é Válida
            If txtQuantidadeAbertura.Value > txtQuantidadePlanejada.Value Or _
               (txtQuantidadeAbertura.Value > IIf(IsNumeric(txtQuantidadeAbertura.Tag), txtQuantidadeAbertura.Tag, txtQuantidadeAbertura.Value) And _
                txtQuantidadeProduzida.Enabled = False) Then

                'Informa o Usuário que a Quantidade é Inválida
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Quantidade Informada é Inválida")
                'Seta Focu
                txtQuantidadeAbertura.Focus()

            ElseIf txtQuantidadeProduzida.Enabled = False Then

                'Seta Passo
                iPasso = 99

            ElseIf txtQuantidadeAbertura.Value + txtQuantidadeAbertura.Tag > txtQuantidadePlanejada.Value Then

                'Informa o Usuário que a Quantidade é Inválida
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Quantidade Informada é Inválida")
                'Seta Focu
                txtQuantidadeAbertura.Focus()

            Else

                'Seta Focu
                txtQuantidadeProduzida.Focus()
                iPasso = 6

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Passo7()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se a Quantidade Produzida é Maior ou Igual a 0
            If ValidaCampo(txtQuantidadeProduzida, lblQuantidadeProduzida, False) = False Then
                Exit Sub
            End If

            'Verifica se a Quantidade Produzida é Maior que a Quantidade Planejada
            If txtQuantidadeProduzida.Value > txtQuantidadeAbertura.Value Then
                frmMain.errInfo.SetError(lblQuantidadeProduzida, "A Qtde. Produzida não pode ser maior que a Qtde. Abertura.")
                txtQuantidadeProduzida.Focus()
                Exit Sub
            End If

            'Calcula a Quantidade de Rejeito
            lblQuantidadeRejeitoValor.Text = FormatNumber(txtQuantidadeAbertura.Value - txtQuantidadeProduzida.Value, 4, Microsoft.VisualBasic.TriState.True)

            'Verifica se a Quantidade é Válida
            If txtQuantidadeProduzida.Value < txtQuantidadeAbertura.Value Then
                iPasso = 8
            Else
                iPasso = 99
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Passo8()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Campo - Motivo de Parada
            If ValidaCampo(cboMotivoParada, lblMotivoParada) = False Then
                Exit Sub
            End If

            'Seta Váriavel
            iCodigoMotivoParada = cboMotivoParada.SelectedValue

            'Seta Passo
            iPasso = 99

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Passo88()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se a Quantidade Produzida é Maior ou Igual a 0
            If ValidaCampo(txtQuantidadeProduzida, lblQuantidadeProduzida, False) = False Then
                Exit Sub
            End If

            'Verifica se a Quantidade Produzida é Maior que a Quantidade Planejada
            If txtQuantidadeProduzida.Value > txtQuantidadeAbertura.Value Then
                frmMain.errInfo.SetError(lblQuantidadeProduzida, "A Qtde. Produzida não pode ser maior que a Qtde. Abertura.")
                txtQuantidadeProduzida.Focus()
                Exit Sub
            End If

            'Calcula a Quantidade de Rejeito
            lblQuantidadeRejeitoValor.Text = FormatNumber(txtQuantidadeAbertura.Value - txtQuantidadeProduzida.Value, 6, Microsoft.VisualBasic.TriState.True)

            'Verifica se a Quantidade é Válida
            If txtQuantidadeProduzida.Value < txtQuantidadeAbertura.Value Then

                'Variavel - Formulário
                Dim oForm As New frmPrdApontamentoRejeito

                'Seta Tamanho / Posição do Formulário
                oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location

                'Seta Parâmetros
                oForm.CodigoOrdemProducao = lCodigoOrdemProducao
                oForm.Sequencia = iSequencia
                oForm.SequenciaConcorrente = iSequenciaConcorrente
                oForm.CodigoApontamentoFuncionario = iCodigoApontamentoFuncionario
                oForm.CodigoFuncionario = iCodigoFuncionario
                oForm.CodigoEquipamento = iCodigoEquipamento
                oForm.OrdemProducao = lblOrdemProducaoValor.Text
                oForm.CodigoProduto = lblCodigoProdutoValor.Text
                oForm.QuantidadePlanejada = txtQuantidadeAbertura.Value
                oForm.QuantidadeProduzida = txtQuantidadeProduzida.Value
                oForm.QuantidadeRejeito = txtQuantidadeAbertura.Value - txtQuantidadeProduzida.Value

                'Abre o Formulário
                Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            End If

            Call Novo()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Passo99()

        Try

            'Verifica se o Usuário Confirma os Dados do Apontamento
            If MsgBox("Confirma os Dados do Apontamento?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                'Váriaveis Locais
                Dim dQuantidadeAbertura As Double = IIf(IsNumeric(txtQuantidadeAbertura.Value), txtQuantidadeAbertura.Value, 0)
                Dim dQuantidadeProduzida As Double = IIf(IsNumeric(txtQuantidadeProduzida.Value), txtQuantidadeProduzida.Value, 0)
                Dim dQuantidadeRejeito As Double = dQuantidadeAbertura - dQuantidadeProduzida

                'Atualiza Apontamento
                Call oClsPrdApontamento.UpdateApontamento(cboTipoApontamento.SelectedValue, _
                                                          lCodigoOrdemProducao, _
                                                          iSequencia, _
                                                          iSequenciaConcorrente, _
                                                          iCodigoApontamentoFuncionario, _
                                                          iCodigoApontamentoFuncionarioParada, _
                                                          iCodigoFuncionario, _
                                                          iCodigoParceiroNegocio, _
                                                          iCodigoEquipamento, _
                                                          iCodigoMotivoParada, _
                                                          dQuantidadeAbertura, _
                                                          dQuantidadeProduzida, _
                                                          dQuantidadeRejeito, _
                                                          IIf(IsNumeric(txtQuantidadeAbertura.Tag), txtQuantidadeAbertura.Tag, 0))

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
