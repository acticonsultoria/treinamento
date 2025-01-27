Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Drawing.Printing

Public Class usrPrdApontamentoDespesa

#Region "::: VARIAVEIS :::"

    Private oClsPrdApontamento As New clsUsrPrdApontamentoDespesa

    Private iPasso As Integer
    Private lCodigoOrdemDespesa As Long
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
    Private dQuantidade As Double = 0

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

    Private Sub usrPrdApontamento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            'Select Case e.KeyCode

            '    Case Keys.Enter
            '        Select Case sender.name
            '            Case "cboTipoApontamento" : Call Passo1()
            '            Case "cboOPOperacao" : Call Passo2()
            '            Case "cboFuncionario" : If bOperacaoExterna = False Then Call Passo3() Else Call Passo4()
            '            Case "cboEquipamento" : Call Passo5()
            '            Case "txtQuantidadeProduzida" : Call Passo7()
            '            Case "txtQuantidadeAbertura" : Call Passo6()
            '            Case "cboMotivoParada" : Call Passo8()
            '        End Select

            'End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrPrdApontamento_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try

            'Select Case e.KeyCode

            '    Case Keys.Enter
            '        Select Case sender.name
            '            Case "cboTipoApontamento" : Call Passo1()
            '            Case "cboOPOperacao" : Call Passo2()
            '            Case "cboFuncionario" : If bOperacaoExterna = False Then Call Passo3() Else Call Passo4()
            '            Case "cboEquipamento" : Call Passo5()
            '            Case "txtQuantidadeProduzida" : Call Passo7()
            '            Case "txtQuantidadeAbertura" : Call Passo6()
            '            Case "cboMotivoParada" : Call Passo8()
            '        End Select

            'End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub usrPrdApontamento_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnCadastrarMotivoParada_Click(ByVal sender As Object, ByVal e As EventArgs)

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadMotivoParada")

            'Carrega Combo


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

    Private Sub cboOrdemProducao_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOrdemDespesa.SelectedValueChanged

        Try

            oClsPrdApontamento.LoadGridApontamento(grdApontamento, cboOrdemDespesa.SelectedValue)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick

        Try

            'Select Case iPasso
            '    Case 1 : lblInformativo.Text = "INFORME O TIPO DE APONTAMENTO"
            '    Case 2 : lblInformativo.Text = "INFORME A OP / OPERAÇÃO"
            '    Case 3 : lblInformativo.Text = "INFORME O FUNCIONÁRIO"
            '    Case 4 : lblInformativo.Text = "INFORME O FORNECEDOR"
            '    Case 5 : lblInformativo.Text = "INFORME O EQUIPAMENTO"
            '    Case 6 : lblInformativo.Text = "INFORME A QTDE. PRODUZIDA"
            '    Case 7 : lblInformativo.Text = "INFORME O MOTIVO PARADA"
            '    Case 8 : Timer.Stop() : Call Passo88()
            '    Case 9 : lblInformativo.Text = "INFORME O QTDE. ABERTURA"
            '    Case 99 : Timer.Stop() : Call Passo99()
            'End Select

            ''Seta Cor
            'lblInformativo.ForeColor = IIf(lblInformativo.ForeColor = Color.Red, Color.Black, Color.Red)

            'Application.DoEvents()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboOPOperacao_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOperacao.SelectedIndexChanged
        Try
            Dim sOrdemProducao As String = ""
            Dim sProduto As String = ""
            Dim sProjeto As String = ""
            Dim sSubProjeto As String = ""
            Dim iQuantidadeRejeito As Integer = 0

            'Carrega Váriaveis
            If cboOperacao.SelectedIndex = -1 Then Exit Sub
            lCodigoOrdemDespesa = cboOperacao.SelectedValue.ToString.Substring(0, 5)
            iSequencia = cboOperacao.SelectedValue.ToString.Substring(5, 5)

            'Seta Controles
            Call oClsPrdApontamento.LoadDadosOrdemDespesa(lCodigoOrdemDespesa, _
                                                           iSequencia, _
                                                           sOrdemProducao, _
                                                           sProduto)

            'Seta Controles
            lblOrdemProducaoValor.Text = sOrdemProducao
            lblCodigoProdutoValor.Text = sProduto
            lblTipoApontamentoValor.Text = cboTipoApontamento.Text

            If cboFuncionario.SelectedIndex = -1 Then Exit Sub
            If lblFuncionario.Text = "Funcionário:" Then
                iCodigoParceiroNegocio = -1

                'Carrega Váriaveis
                Call oClsPrdApontamento.LoadDadosApontamento(5, _
                                                                 lCodigoOrdemDespesa, _
                                                                 iSequencia, _
                                                                 "", _
                                                                 iCodigoFuncionario, _
                                                                 iCodigoApontamentoFuncionario, _
                                                                 iTipoApontamentoConcorrente, _
                                                                 dQuantidade)

                txtQuantidade.Value = dQuantidade
            Else
                If lblFuncionario.Text = "Fornecedor:" Then
                    iCodigoParceiroNegocio = cboFuncionario.SelectedValue
                    iCodigoFuncionario = -1

                    'Carrega Váriaveis
                    Call oClsPrdApontamento.LoadDadosApontamento(5, _
                                                                 lCodigoOrdemDespesa, _
                                                                 iSequencia, _
                                                                 "", _
                                                                 iCodigoFuncionario, _
                                                                 iCodigoApontamentoFuncionario, _
                                                                 iTipoApontamentoConcorrente, _
                                                                 dQuantidade)

                    txtQuantidade.Value = dQuantidade
                End If
            End If

            'If bOperacaoExterna = False Then

            '    'Carrega Combo - Funcionario
            '    Call LoadCombo(cboFuncionario, "sp_select_combo_producao_apontamento_funcionario " & 1 & ", " & lCodigoOrdemProducao & ", " & iSequencia & ", " & goUsuario.iEmpresa, False)
            '    lblFuncionario.Text = "Funcionário:"

            '    iPasso = 3

            'Else

            '    'Carrega Combo - Funcionario
            '    Call LoadCombo(cboFuncionario, "sp_select_combo_producao_apontamento_parceiro_negocio " & 1 & ", " & lCodigoOrdemProducao & ", " & iSequencia & ", " & goUsuario.iEmpresa, False)
            '    lblFuncionario.Text = "Fornecedor:"

            '    iPasso = 4

            'End If

            oClsPrdApontamento.LoadGridApontamento(grdApontamento, lCodigoOrdemDespesa)
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Try
            If MsgBox("Confirma os Dados do Apontamento?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then



                'Váriaveis Locais
                Dim dQuantidade As Double = IIf(IsNumeric(txtQuantidade.Value), txtQuantidade.Value, 0)

                If dtpDataTermino.Value < dtpDataInicio.Value Then
                    MsgBox("A Data de Término não pode ser menor que a Data de Inicio!", MsgBoxStyle.OkOnly)
                    Exit Sub
                End If

                'Calcula a Quantidade de Rejeito
                'lblQuantidadeRejeitoValor.Text = "0,0000"
                

                'Atualiza Apontamento
                Call oClsPrdApontamento.UpdateApontamento(1, _
                                                          lCodigoOrdemDespesa, _
                                                          iSequencia, _
                                                          iCodigoApontamentoFuncionario, _
                                                          cboFuncionario.SelectedValue, _
                                                          dQuantidade, _
                                                          dtpDataInicio.Value, _
                                                          dtpDataTermino.Value)
            End If
            Novo()
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboFuncionario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFuncionario.SelectedIndexChanged
        Try
            If cboFuncionario.SelectedIndex = -1 Then Exit Sub
            If lblFuncionario.Text = "Funcionário:" Then
                iCodigoParceiroNegocio = -1

                'Carrega Váriaveis
                Call oClsPrdApontamento.LoadDadosApontamento(1, _
                                                                 lCodigoOrdemDespesa, _
                                                                 iSequencia, _
                                                                 "", _
                                                                 iCodigoFuncionario, _
                                                                 iCodigoApontamentoFuncionario, _
                                                                 iTipoApontamentoConcorrente, _
                                                                 dQuantidade)
            Else
                If lblFuncionario.Text = "Fornecedor:" Then
                    iCodigoParceiroNegocio = cboFuncionario.SelectedValue
                    iCodigoFuncionario = -1

                    'Carrega Váriaveis
                    Call oClsPrdApontamento.LoadDadosApontamento(1, _
                                                                 lCodigoOrdemDespesa, _
                                                                 iSequencia, _
                                                                 "", _
                                                                 iCodigoFuncionario, _
                                                                 iCodigoApontamentoFuncionario, _
                                                                 iTipoApontamentoConcorrente, _
                                                                 dQuantidade)
                End If
            End If

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

   

    Private Sub cboOrdemProducao_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboOrdemDespesa.SelectedIndexChanged
        Try
            If cboOrdemDespesa.SelectedIndex = -1 Then Exit Sub
            Call LoadCombo(cboOperacao, "sp_select_combo_producao_apontamento_operacao_despesa " & cboOrdemDespesa.SelectedValue & ", " & goUsuario.iEmpresa)
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnProject_Click(sender As Object, e As EventArgs)
        Try
            Dim oCCBModificacaoProjeto As New frmCCBModificacaoProject
            oCCBModificacaoProjeto.ShowDialog()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnApontamentoLote_Click(sender As Object, e As EventArgs)
        Try
            Dim oForm As New frmPrdApontamentoLote
            oForm.ShowDialog()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnApontamentoOF_Click(sender As Object, e As EventArgs)
        Try
            Dim oForm As New frmPrdApontamentoOFIssartel
            oForm.ShowDialog()

            oClsPrdApontamento.LoadGridApontamento(grdApontamento, lCodigoOrdemDespesa)
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdApontamento_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdApontamento.RowDoubleClick
        Try

            'Verifica o Tipo de Registro
            If IsNothing(grdApontamento.CurrentColumn) Then Exit Sub

            Select Case grdApontamento.CurrentColumn.Key

                Case "excluir" : Call Excluir()

            End Select

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrPrdApontamento_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            cboTipoApontamento.Items.Clear()
            cboTipoApontamento.Items.Add("ABERTURA", 1)
            cboTipoApontamento.Items.Add("FECHAMENTO", 4)
            cboTipoApontamento.Items.Add("PARADA", 2)
            cboTipoApontamento.Items.Add("REABERTURA", 3)
            cboTipoApontamento.Items.Add("ÚNICO", 5)
            cboTipoApontamento.SelectedValue = 5

            'Carrega Combo
            Call LoadCombo(cboOrdemDespesa, "sp_select_combo_producao_apontamento_ordem_despesa " & 1 & ", " & goUsuario.iEmpresa)
            'Verifica o Tipo de Operação
            Call LoadCombo(cboFuncionario, "sp_select_combo_producao_funcionario " & goUsuario.iEmpresa)
            'Seta funcionário
            Dim sCodigoFuncionario As String
            sCodigoFuncionario = LoadCodigo("sp_select_cadastro_basico_funcionario_codigo " & goUsuario.iEmpresa & ", '" & goUsuario.sNome & "'")
            cboFuncionario.SelectedValue = sCodigoFuncionario
            'Carrega Combo - Ordem de Produção / Operação
            '
            'Prepara Formulário
            'Call Novo()
            'Call Passo1()
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

            cboOperacao.Text = ""
            'cboFuncionario.Text = ""
            txtQuantidade.Text = ""
            txtQuantidade.Text = ""
            dtpDataInicio.Value = Now.Date
            dtpDataTermino.Value = Now.Date
            cboOrdemDespesa.SelectedIndex = -1
            cboOperacao.SelectedIndex = -1


            lblOrdemProducaoValor.Text = "-"
            lblCodigoProdutoValor.Text = "-"
            lblTipoApontamentoValor.Text = "-"
            grdApontamento.DataSource = Nothing

            'Limpa Váriaveis
            iPasso = 1
            lCodigoOrdemDespesa = -1
            iSequencia = -1
            iSequenciaConcorrente = 0
            iCodigoApontamentoFuncionario = -1
            iCodigoApontamentoFuncionarioParada = -1
            iCodigoFuncionario = -1
            iCodigoEquipamento = -1
            iCodigoMotivoParada = -1
            iTipoApontamentoConcorrente = TipoApontamentoConcorrente.Nao
            bApontaEquipamento = False
            dQuantidadeAbertura = 0
            dQuantidadeAberturaTotal = 0
            dQuantidade = 0
            'Carrega Combo - Ordem de Produção / Operação
            'Call LoadCombo(cboOperacao, "sp_select_combo_producao_apontamento_ordem_operacao_issartel " & 1 & ", " & goUsuario.iEmpresa, False)

            'Seta Focu
            cboTipoApontamento.Focus()

            'Inicializa Timer
            'Carrega Váriaveis

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

            'Desabilita Controle
            cboFuncionario.Enabled = False

            'Verifica o Próximo Passo
            Select Case cboTipoApontamento.SelectedValue

                Case TipoApontamento.Abertura
                    If iTipoApontamentoConcorrente = TipoApontamentoConcorrente.Nao Then
                        'Seta Controle
                        txtQuantidade.Value = dQuantidade
                        txtQuantidade.Value = dQuantidadeAbertura
                        txtQuantidade.Tag = dQuantidadeAberturaTotal
                        iPasso = 99
                    ElseIf iTipoApontamentoConcorrente = TipoApontamentoConcorrente.ApontaQuantidadeAbertuda Then
                        txtQuantidade.Value = dQuantidade
                        txtQuantidade.Tag = dQuantidadeAbertura
                        txtQuantidade.Enabled = True
                        txtQuantidade.Focus()
                        iPasso = 9
                    ElseIf iTipoApontamentoConcorrente = TipoApontamentoConcorrente.NaoApontaQuantidadeAbertura Then
                        txtQuantidade.Value = dQuantidade
                        txtQuantidade.Value = 0
                        txtQuantidade.Tag = 0
                        iPasso = 99
                    End If

                Case TipoApontamento.Fechamento
                    If bApontaEquipamento = True Then
                        iPasso = 5
                    Else

                        If iTipoApontamentoConcorrente = TipoApontamentoConcorrente.Nao Or iTipoApontamentoConcorrente = TipoApontamentoConcorrente.ApontaQuantidadeAbertuda Then
                            'Seta Controle
                            txtQuantidade.Value = dQuantidade
                            txtQuantidade.Value = dQuantidadeAbertura
                            txtQuantidade.Enabled = True
                            txtQuantidade.Focus()
                            iPasso = 6
                        ElseIf TipoApontamentoConcorrente.NaoApontaQuantidadeAbertura Then
                            'Seta Controle
                            txtQuantidade.Value = dQuantidade
                            txtQuantidade.Enabled = True
                            txtQuantidade.Enabled = True
                            txtQuantidade.Focus()
                            iPasso = 6
                        End If
                    End If



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
                                                                  lCodigoOrdemDespesa, _
                                                                  iSequencia, _
                                                                  "", _
                                                                  iCodigoFuncionario, _
                                                                  iCodigoApontamentoFuncionario, _
                                                                  iTipoApontamentoConcorrente, _
                                                                  dQuantidade)

            'Desabilita Controle
            cboFuncionario.Enabled = False

            'Verifica o Próximo Passo
            Select Case cboTipoApontamento.SelectedValue

                Case TipoApontamento.Abertura
                    If iTipoApontamentoConcorrente = TipoApontamentoConcorrente.Nao Then
                        'Seta Controle
                        txtQuantidade.Value = dQuantidade
                        txtQuantidade.Value = dQuantidadeAbertura
                        txtQuantidade.Tag = dQuantidadeAberturaTotal
                        iPasso = 99
                    ElseIf iTipoApontamentoConcorrente = TipoApontamentoConcorrente.ApontaQuantidadeAbertuda Then
                        txtQuantidade.Value = dQuantidade
                        txtQuantidade.Tag = dQuantidadeAbertura
                        txtQuantidade.Enabled = True
                        txtQuantidade.Focus()
                        iPasso = 9
                    ElseIf iTipoApontamentoConcorrente = TipoApontamentoConcorrente.Nao Then
                        'Seta Controle
                        txtQuantidade.Value = dQuantidade
                        txtQuantidade.Value = 0
                        txtQuantidade.Tag = 0
                        iPasso = 99
                    End If

                Case TipoApontamento.Fechamento
                    If bApontaEquipamento = True Then
                        iPasso = 5
                    Else
                        'Seta Controle
                        txtQuantidade.Value = dQuantidade
                        txtQuantidade.Value = dQuantidadeAbertura
                        txtQuantidade.Enabled = True
                        txtQuantidade.Focus()
                        iPasso = 6
                    End If



                Case TipoApontamento.Reabertura
                    iPasso = 99

            End Select

        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Private Sub Excluir()

        Try

            'Verifica se o Usuário Deseja Excluir os Registros Selecionados
            If MsgBox("Deseja excluir permanentemente este registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Exclui Registros
                oClsPrdApontamento.ExcluirApontamento(cboOrdemDespesa.SelectedValue, _
                                                      grdApontamento.CurrentRow.Cells("sequencia").Value, _
                                                      grdApontamento.CurrentRow.Cells("codigo").Value)

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.RegistroExcluido)

                oClsPrdApontamento.LoadGridApontamento(grdApontamento, cboOrdemDespesa.SelectedValue)

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

            End If


        Catch ex As Exception
            Throw ex
        End Try

    End Sub
#End Region


End Class
