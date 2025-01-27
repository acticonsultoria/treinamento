Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports System.IO

Public Class usrCadContratoCambio

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadContratoCambio As New clsUsrCadContratoCambio

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrCadContratoCambio_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) 

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then
                        If btnGrafico.Visible = False Then Call LoadGrafico() Else Call LoadGrid()
                    Else
                        Control_Enter(sender)
                    End If

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboBancoFiltro", "cboBanco"
                            Dim oComboBox(1) As UIComboBox
                            oComboBox(0) = cboBanco : oComboBox(1) = cboBancoFiltro
                            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_banco_todos " & goUsuario.iEmpresa)
                        Case "cboInstituicaoFinanceiraFiltro", "cboInstituicaoFinanceira"
                            Dim oComboBox(1) As UIComboBox
                            oComboBox(0) = cboInstituicaoFinanceiraFiltro : oComboBox(1) = cboInstituicaoFinanceira
                            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_instituicao_financeira " & goUsuario.iEmpresa)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboBanco"
                            Call btnCadastrarBanco_Click(btnCadastrarBanco, System.EventArgs.Empty)
                        Case "cboInstituicaoFinanceira"
                            Call btnCadastrarInstituicaoFinanceira_Click(btnCadastrarInstituicaoFinanceira, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadContratoCambio_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCadContratoCambio_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona Formulário
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnCadastrarBanco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarBanco.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrCadBanco"
            oForm.Titulo = Me.Text
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Carrega Combo
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboBancoFiltro : oComboBox(1) = cboBanco
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_banco_todos " & goUsuario.iEmpresa)

            'Seta Focu
            cboBanco.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarInstituicaoFinanceira_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarInstituicaoFinanceira.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrCadInstituicaoFinanceira"
            oForm.Titulo = Me.Text
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Carrega Combo
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboInstituicaoFinanceiraFiltro : oComboBox(1) = cboInstituicaoFinanceira
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_instituicao_financeira " & goUsuario.iEmpresa)

            'Seta Focu
            cboInstituicaoFinanceira.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLista.Click

        Try

            'Carrega Grid
            Call LoadGrid()

            'Exibe / Oculta Controles
            btnGrafico.Visible = True
            btnLista.Visible = False
            grdListagem.Visible = True
            chrDados.Visible = False

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnGrafico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrafico.Click

        Try

            'Carrega Gráfico
            Call LoadGrafico()

            'Exibe / Oculta Controles
            btnLista.Visible = True
            btnGrafico.Visible = False
            chrDados.Visible = True
            grdListagem.Visible = False

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

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Verifica se é Lista ou Gráfico
            If btnGrafico.Visible = False Then
                'Carrega Gráfico
                Call LoadGrafico()
            Else
                'Carrega Grid
                Call LoadGrid()
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            'Prepara Formulário para Inserção de um Novo Registro
            Call Novo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click

        Try

            'Prepara o Formulário para Inserção de um Novo Registro
            Call Novo()

            'Alterna Aba
            tabMain.TabPages.Remove(pagLista)
            tabMain.TabPages.Add(pagDados)

            'Seta Focu
            txtNumeroContrato.Focus()

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
                'Prepara Formulário para Inserção de um Novo Registro
                Call Novo()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Deleta Aba
            If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else frmMain.tabMain.TabPages.Remove(Me.Parent)
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
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagLista)

            'Seta Focu
            txtNumeroContratoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArquivo.Click

        Try

            'Variaveis Locais
            Dim arqArquivo As New OpenFileDialog

            'Abre PopUp para Usuário selecionar Imagem
            arqArquivo.InitialDirectory = "c:\\dados"
            arqArquivo.Title = "Selecione o Arquivo"

            If arqArquivo.ShowDialog() = DialogResult.OK Then
                txtArquivo.Text = arqArquivo.FileName
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboMoeda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMoeda.SelectedIndexChanged

        Try

            'Limpa Controles
            txtFatorCambial.Value = 1
            txtFatorCambial.ReadOnly = True
            txtFatorCambial.TabStop = False
            txtFatorCambial.BackColor = Color.WhiteSmoke

            'Verifica se foi Selecionado algum Item
            If cboMoeda.SelectedIndex <> -1 Then
                If cboMoeda.SelectedValue <> CInt(Moeda.Real) Then
                    txtFatorCambial.Value = 0
                    txtFatorCambial.ReadOnly = False
                    txtFatorCambial.TabStop = True
                    txtFatorCambial.BackColor = Color.White
                End If
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica o Tipo de Linha da Grid
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call Editar()
                Case "visualizar" : Call Visualizar()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CalculaValorOperacaoMoedaCorrente() Handles txtFatorCambial.ValueChanged, _
                                                            txtValorOperacao.ValueChanged

        Try

            'Calculá Valor da Operação - Moeda Corrente
            txtValorOperacaoMoedaCorrente.Value = txtValorOperacao.Value * txtFatorCambial.Value

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
            Call AddKeyUp(Me, New DelegateKeyUp(AddressOf usrCadContratoCambio_KeyUp))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.CadastroBasicoContratoCambio, gcDelete)
            btnNovo1.Enabled = VerificaDireito(Formulario.CadastroBasicoContratoCambio, gcInsert)

            'Carrega Combo
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboTipoFiltro : oComboBox(1) = cboTipo
            Call LoadCombo(oComboBox, "sp_select_combo_static_tipo_contrato_cambio")
            oComboBox(0) = cboBancoFiltro : oComboBox(1) = cboBanco
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_banco_todos " & goUsuario.iEmpresa)
            oComboBox(0) = cboMoedaFiltro : oComboBox(1) = cboMoeda
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_moeda " & goUsuario.iEmpresa)
            oComboBox(0) = cboInstituicaoFinanceiraFiltro : oComboBox(1) = cboInstituicaoFinanceira
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_instituicao_financeira " & goUsuario.iEmpresa)

            'Oculta Controles
            btnLista.Visible = False
            chrDados.Visible = False

            'Seta Controles - CalendarCombo
            dtpDataInicioFiltro.Value = Now.Date : dtpDataInicioFiltro.Checked = False
            dtpDataTerminoFiltro.Value = Now.Date : dtpDataTerminoFiltro.Checked = False

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            txtNumeroContratoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Editar()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoContratoCambio, gcUpdate) = True Then

                With grdListagem.CurrentRow.Cells

                    'Carrega Controles
                    txtNumeroContrato.Text = .Item("numero_contrato").Value
                    If IsDBNull(.Item("data").Value) = False Then dtpData.Value = .Item("data").Value Else dtpData.Value = Now.Date
                    cboTipo.SelectedValue = .Item("codigo_tipo").Value
                    txtValorOperacao.Value = .Item("valor_operacao").Value
                    cboMoeda.SelectedValue = .Item("codigo_moeda").Value
                    txtFatorCambial.Value = .Item("fator_cambial").Value
                    txtValorOperacaoMoedaCorrente.Value = .Item("valor_operacao_moeda_corrente").Value
                    cboBanco.SelectedValue = .Item("codigo_banco").Value
                    cboInstituicaoFinanceira.SelectedValue = .Item("codigo_instituicao_financeira").Value
                    txtArquivo.Text = IIf(IsDBNull(.Item("arquivo").Value), "", .Item("arquivo").Value)
                    btnSalvar.Tag = .Item("codigo").Value

                End With

                'Alterna Aba
                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                txtNumeroContrato.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Delete()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir o(s) Registro(s) Selecionado(s)?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCadContratoCambio.Delete()

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

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            txtNumeroContrato.Text = ""
            cboTipo.SelectedIndex = -1
            txtValorOperacao.Value = 0
            cboMoeda.SelectedIndex = -1
            txtFatorCambial.Value = 0
            txtValorOperacaoMoedaCorrente.Value = 0
            cboBanco.SelectedIndex = -1
            cboInstituicaoFinanceira.SelectedIndex = -1
            txtArquivo.Text = ""
            btnSalvar.Tag = ""

            'Seta Focu
            txtNumeroContrato.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCadContratoCambio.Codigo = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0)
            oClsCadContratoCambio.Data = dtpData.Value
            oClsCadContratoCambio.NumeroContrato = txtNumeroContrato.Text.Trim
            oClsCadContratoCambio.CodigoTipo = cboTipo.SelectedValue
            oClsCadContratoCambio.ValorOperacao = txtValorOperacao.Value
            oClsCadContratoCambio.CodigoMoeda = cboMoeda.SelectedValue
            oClsCadContratoCambio.FatorCambial = txtFatorCambial.Value
            oClsCadContratoCambio.ValorOperacaoMoedaCorrente = txtValorOperacaoMoedaCorrente.Value
            oClsCadContratoCambio.CodigoInstituicaoFinanceira = IIf(cboInstituicaoFinanceira.SelectedIndex = -1, -1, cboInstituicaoFinanceira.SelectedValue)
            oClsCadContratoCambio.CodigoBanco = cboBanco.SelectedValue
            oClsCadContratoCambio.Arquivo = txtArquivo.Text.Trim

            'Verifica o Tipo de Operação
            If IsNumeric(btnSalvar.Tag) Then
                oClsCadContratoCambio.Update()
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                oClsCadContratoCambio.Insert()
                frmMain.Informacao(Mensagem.RegistroInserido)
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

            'Seta Parametros
            oClsCadContratoCambio.LoadGrid(grdListagem, _
                                           txtNumeroContratoFiltro.Text.Trim, _
                                           IIf(dtpDataInicioFiltro.Checked = False, "", dtpDataInicioFiltro.Value), _
                                           IIf(dtpDataTerminoFiltro.Checked = False, "", dtpDataTerminoFiltro.Value), _
                                           IIf(cboTipoFiltro.SelectedIndex = -1, -1, cboTipoFiltro.SelectedValue), _
                                           IIf(cboMoedaFiltro.SelectedIndex = -1, -1, cboMoedaFiltro.SelectedValue), _
                                           IIf(cboBancoFiltro.SelectedIndex = -1, -1, cboBancoFiltro.SelectedValue), _
                                           IIf(cboInstituicaoFinanceiraFiltro.SelectedIndex = -1, -1, cboInstituicaoFinanceiraFiltro.SelectedValue))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadGrafico()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            Call oClsCadContratoCambio.LoadGrafico(chrDados, _
                                                   txtNumeroContratoFiltro.Text.Trim, _
                                                   IIf(dtpDataInicioFiltro.Checked = False, "", dtpDataInicioFiltro.Value), _
                                                   IIf(dtpDataTerminoFiltro.Checked = False, "", dtpDataTerminoFiltro.Value), _
                                                   IIf(cboTipoFiltro.SelectedIndex = -1, -1, cboTipoFiltro.SelectedValue), _
                                                   IIf(cboMoedaFiltro.SelectedIndex = -1, -1, cboMoedaFiltro.SelectedValue), _
                                                   IIf(cboBancoFiltro.SelectedIndex = -1, -1, cboBancoFiltro.SelectedValue), _
                                                   IIf(cboInstituicaoFinanceiraFiltro.SelectedIndex = -1, -1, cboInstituicaoFinanceiraFiltro.SelectedValue))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Visualizar()

        Try

            'Verifica se foi Informado o Arquivo
            If IsDBNull(grdListagem.CurrentRow.Cells("arquivo").Value) = False Then

                'Informa o Usuário que não foi Informado o Arquivo
                frmMain.Informacao(Mensagem.NaoFoiInformado, "Arquivo")

                'Verifica se o Arquivo Existe
                If File.Exists(grdListagem.CurrentRow.Cells("arquivo").Value) Then
                    'Abre o Arquivo
                    Dim oProcess As New Process
                    oProcess.Start(grdListagem.CurrentRow.Cells("arquivo").Value)
                Else
                    'Informa o Usuário que o Arquivo Informado não foi Localizado.
                    frmMain.Informacao(Mensagem.ObjetoNaoEncontrado, "Arquivo")
                End If

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se foi Preenchido o Campo - Nº Contrato
            If ValidaCampo(txtNumeroContrato, lblNumeroContrato, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Passa Parametros
            If oClsCadContratoCambio.ValidaNumeroContrato(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0), _
                                                          txtNumeroContrato.Text.Trim) = False Then
                frmMain.errInfo.SetError(lblNumeroContrato, "Este Nº de Contrato: " & txtNumeroContrato.Text & " já está associado a outro Registro.")
                txtNumeroContrato.Focus()
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Ativo
            If ValidaCampo(cboTipo, lblTipo) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Valor Operação
            If ValidaCampo(txtValorOperacao, lblValorOperacao, True) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Moeda
            If ValidaCampo(cboMoeda, lblMoeda) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Fator Cambial
            If ValidaCampo(txtFatorCambial, lblFatorCambial, True) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Banco
            If ValidaCampo(cboBanco, lblBanco) = False Then
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
