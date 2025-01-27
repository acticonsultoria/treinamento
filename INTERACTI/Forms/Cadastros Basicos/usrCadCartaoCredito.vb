Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class usrCadCartaoCredito

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadCartaoCredito As New clsUsrCadCartaoCredito

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrCadCartaoCredito_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                    
                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboFuncionario", "cboFuncionarioFiltro"
                            Dim oComboBox(1) As UIComboBox
                            oComboBox(0) = cboFuncionarioPortadorFiltro : oComboBox(1) = cboFuncionarioPortador
                            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_funcionario " & goUsuario.iEmpresa, False)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboFuncionario" : Call btnCadastrarFuncionario_Click(btnCadastrarFuncionario, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadCartaoCredito_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrCadCartaoCredito_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdListagem.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdListagem.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdListagem.GroupByBoxVisible = True
                grdListagem.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.CadastroBasicoCartaoCredito
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoCartaoCredito)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarFuncionario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarFuncionario.Click

        Try

                         'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadFuncionario")

            'Carrega Combo
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboFuncionarioPortadorFiltro : oComboBox(1) = cboFuncionarioPortador
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_funcionario " & goUsuario.iEmpresa, False)

            'Seta Focu
            cboFuncionarioPortador.Focus()

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

            'Carrega Dados da Grid
            Call LoadGrid()

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
            cboContaBancaria.Focus()

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
            If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
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
            cboContaBancariaFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCongelarColuna_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCongelarColuna.SelectedIndexChanged

        Try

            If cboCongelarColuna.SelectedIndex = -1 Then
                grdListagem.FrozenColumns = 2
            Else
                grdListagem.FrozenColumns = cboCongelarColuna.SelectedValue
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica o Tipo de Registro
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call Editar()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.CadastroBasicoCartaoCredito)

            'Carrega Combo
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.CadastroBasicoCartaoCredito, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name, _
                                          Formulario.CadastroBasicoCartaoCredito, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadCartaoCredito_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.CadastroBasicoCartaoCredito, gcDelete)
            btnNovo1.Enabled = VerificaDireito(Formulario.CadastroBasicoCartaoCredito, gcInsert)
            btnNovo.Enabled = VerificaDireito(Formulario.CadastroBasicoCartaoCredito, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.CadastroBasicoCartaoCredito, gcPrint)
            'Verifica Direito Cadastrar
            btnCadastrarFuncionario.Enabled = VerificaDireito(Formulario.CadastroBasicoFuncionario, gcInsert)

            'Carrega Combo
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboContaBancariaFiltro : oComboBox(1) = cboContaBancaria
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_banco_conta " & goUsuario.iEmpresa, False)
            oComboBox(0) = cboBandeiraFiltro : oComboBox(1) = cboBandeira
            Call LoadCombo(oComboBox, "sp_select_combo_static_bandeira_cartao_credito", False)
            oComboBox(0) = cboFuncionarioPortadorFiltro : oComboBox(1) = cboFuncionarioPortador
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_funcionario " & goUsuario.iEmpresa, False)
            oComboBox(0) = cboDiaFechamento : oComboBox(1) = cboDiaPagamento
            Call LoadComboDia(oComboBox)
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)
            
            'Seta Controle
            dtpDataValidadeFiltro.Checked = False

            'Configura a Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoCartaoCredito)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            cboContaBancariaFiltro.Focus()

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
            If VerificaDireito(Formulario.CadastroBasicoCartaoCredito, gcUpdate) = True Then

                With grdListagem.CurrentRow.Cells

                    'Carrega Controles]
                    cboContaBancaria.SelectedValue = .Item("codigo_banco_conta").Value
                    cboBandeira.SelectedValue = .Item("codigo_bandeira_cartao").Value
                    txtQuatroUltimosDigitos.Text = .Item("quatro_ultimos_digitos").Value
                    dtpDataValidade.Value = .Item("validade").Value
                    cboDiaFechamento.SelectedValue = .Item("dia_fechamento").Value
                    cboDiaPagamento.SelectedValue = .Item("dia_pagamento").Value
                    cboFuncionarioPortador.SelectedValue = .Item("codigo_funcionario_portador").Value
                    btnSalvar.Tag = .Item("codigo").Value

                End With

                'Alterna Aba
                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                cboContaBancaria.Focus()

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

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCadCartaoCredito.Delete()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
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
            cboContaBancaria.SelectedIndex = -1
            cboBandeira.SelectedIndex = -1
            txtQuatroUltimosDigitos.Text = ""
            dtpDataValidade.Value = Now.Date
            cboDiaFechamento.SelectedIndex = -1
            cboDiaPagamento.SelectedIndex = -1
            cboFuncionarioPortador.SelectedIndex = -1
            btnSalvar.Tag = ""

            'Seta Focu
            cboContaBancaria.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCadCartaoCredito.Codigo = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1)
            oClsCadCartaoCredito.CodigoBancoConta = cboContaBancaria.SelectedValue
            oClsCadCartaoCredito.CodigoBandeiraCartaoCredito = cboBandeira.SelectedValue            
            oClsCadCartaoCredito.QuatroUltimosDigitos = txtQuatroUltimosDigitos.Text.Trim
            oClsCadCartaoCredito.DiaFechamento = cboDiaFechamento.SelectedValue
            oClsCadCartaoCredito.DiaPagamento = cboDiaPagamento.SelectedValue
            oClsCadCartaoCredito.Validade = dtpDataValidade.Value
            oClsCadCartaoCredito.CodigoFuncionarioPortador = IIf(cboFuncionarioPortador.SelectedIndex = -1, -1, cboFuncionarioPortador.SelectedValue)

            'Verifica o Tipo de Operação
            If IsNumeric(btnSalvar.Tag) Then
                oClsCadCartaoCredito.Update()
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                oClsCadCartaoCredito.Insert()
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
            Call oClsCadCartaoCredito.LoadGrid(grdListagem, _
                                               IIf(cboContaBancariaFiltro.SelectedIndex = -1, -1, cboContaBancariaFiltro.SelectedValue), _
                                               IIf(cboBandeiraFiltro.SelectedIndex = -1, -1, cboBandeiraFiltro.SelectedValue), _
                                               txtQuatroUltimosDigitosFiltro.Text.Trim, _
                                               IIf(dtpDataValidadeFiltro.Checked = False, "", dtpDataValidadeFiltro.Value), _
                                               IIf(cboFuncionarioPortadorFiltro.SelectedIndex = -1, -1, cboFuncionarioPortadorFiltro.SelectedValue))

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
            If ValidaCampo(txtQuatroUltimosDigitos, lblContaBancaria, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Bandeira
            If ValidaCampo(cboBandeira, lblBandeira) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Moeda
            If ValidaCampo(txtQuatroUltimosDigitos, lblQuatroUltimosDigitos, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se o Moeda preenchido é válido
            If oClsCadCartaoCredito.ValidaCartao(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0), _
                                                 IIf(cboContaBancaria.SelectedIndex = -1, -1, cboContaBancaria.SelectedValue), _
                                                 IIf(cboBandeira.SelectedIndex = -1, -1, cboBandeira.SelectedValue), _
                                                 txtQuatroUltimosDigitos.Text.Trim, _
                                                 dtpDataValidade.Value) = False Then
                frmMain.errInfo.SetError(lblQuatroUltimosDigitos, "Esta Cartão de Crédito: " & txtQuatroUltimosDigitos.Text & " já está associado a outro Registro.")
                txtQuatroUltimosDigitos.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Dia de Fechamento
            If ValidaCampo(cboDiaFechamento, lblDiaFechamento) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Dia de Pagamento
            If ValidaCampo(cboDiaPagamento, lblDiaPagamento) = False Then
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
