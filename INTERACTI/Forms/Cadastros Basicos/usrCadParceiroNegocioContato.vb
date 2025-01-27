Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls
Imports Janus.Windows.Common

Public Class usrCadParceiroNegocioContato

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadParceiroNegocio As New clsUsrCadParceiroNegocio
    Private iCodigoParceiroNegocio As Integer

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrCadParceiroNegocioContato_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    Call Control_Enter(sender)

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboTipoContato" : Call LoadCombo(cboTipoContato, "sp_select_combo_cadastro_basico_tipo_contato " & goUsuario.iEmpresa)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboTipoContato" : Call btnCadastrarTipoContato_Click(btnCadastrarTipoContato, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadParceiroNegocioContato_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: CONTATO :::"

    Private Sub btnAgruparGridContato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridContato.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdContato.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdContato.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdContato.GroupByBoxVisible = True
                grdContato.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridContato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridContato.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdContato
            oForm.NomeFormulario = Formulario.CadastroBasicoParceiroNegocio
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdContato, Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridContato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridContato.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdContato)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarTipoContato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarTipoContato.Click

        Try

                         'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadTipoContato")

            'Carrega Combo
            Call LoadCombo(cboTipoContato, "sp_select_combo_cadastro_basico_tipo_contato " & goUsuario.iEmpresa)

            'Seta Focu
            cboTipoContato.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSalvarContato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarContato.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Contato
            If ValidacaoContato() = True Then
                oClsCadParceiroNegocio.Codigo = iCodigoParceiroNegocio
                'Verifica o Tipo de Operação
                If IsNumeric(btnSalvarContato.Tag) = False Then



                    'Insere Contato
                    Call oClsCadParceiroNegocio.InsertContato(txtNomeContato.Text.Trim, _
                                                                  txtTelefoneContato.Text.Trim, _
                                                                  txtCelularContato.Text.Trim, _
                                                                  IIf(dtpDataAniversario.Checked = True, dtpDataAniversario.Value, ""), _
                                                                  txtEmailContato.Text.Trim, _
                                                                  txtComplementoContato.Text.Trim, _
                                                                  cboTipoContato.SelectedValue)

                Else

                    'Atualiza Dados do Contato
                    Call oClsCadParceiroNegocio.UpdateContato(txtNomeContato.Text.Trim, _
                                                              txtTelefoneContato.Text.Trim, _
                                                              txtCelularContato.Text.Trim, _
                                                              IIf(dtpDataAniversario.Checked = True, dtpDataAniversario.Value, ""), _
                                                              txtEmailContato.Text.Trim, _
                                                              txtComplementoContato.Text.Trim, _
                                                              cboTipoContato.SelectedValue, _
                                                              btnSalvarContato.Tag)

                End If

                'Carrega Lista de Contato
                Call oClsCadParceiroNegocio.LoadGridContato(grdContato, _
                                                            iCodigoParceiroNegocio)

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoContato()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirContato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirContato.Click

        Try

            'Deleta Registros
            Call DeleteContato()

            'Limpa Formulário
            Call NovoContato()

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

    Private Sub grdContato_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdContato.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdContato.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdContato.CurrentColumn.Key

                Case "editar" : Call EditarContato()
                Case "email" : Call EmailContato()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdContato_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdContato.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdContato, _
                                     Formulario.CadastroBasicoParceiroNegocio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdContato_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdContato.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdContato.Name, _
                                     Formulario.CadastroBasicoParceiroNegocio, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdContato_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdContato.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdContato.Name, _
                                          Formulario.CadastroBasicoParceiroNegocio, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: DADOS GERAIS :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadParceiroNegocioContato_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnSalvarContato.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioContatos, gcInsert)
            btnExcluirContato.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioContatos, gcDelete)
            btnExcelGridContato.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocioContatos, gcPrint)
            
            'Verifica Direito - Botão de Cadastrar
            btnCadastrarTipoContato.Enabled = VerificaDireito(Formulario.CadastroBasicoTipoContato, gcInsert)

            'Carrega Combo
            Call LoadCombo(cboTipoContato, "sp_select_combo_cadastro_basico_tipo_contato " & goUsuario.iEmpresa, False)
            
            'Configura Grid
            Call ConfiguraGrid(grdContato, Formulario.CadastroBasicoParceiroNegocio)

            'Verifica a Tag            
            If Me.Tag.ToString.Contains("CODIGO:") Then

                iCodigoParceiroNegocio = Me.Tag.ToString.Replace("CODIGO:", "")

                Call oClsCadParceiroNegocio.LoadControles(iCodigoParceiroNegocio, _
                                                          chkAgenteLogistico, _
                                                          chkCliente, _
                                                          chkFornecedor, _
                                                          chkDespachante, _
                                                          txtPersonalidade, _
                                                          txtRazaoSocial, _
                                                          txtNomeFantasia, _
                                                          txtSegmento, _
                                                          cboAtivo, _
                                                          txtRegimeTributario, _
                                                          txtCNAE)

                'Carrega Lista de Contato
                Call oClsCadParceiroNegocio.LoadGridContato(grdContato, _
                                                            iCodigoParceiroNegocio)

            End If

            'Seta Focu
            cboTipoContato.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: CONTATO :::"

    Private Sub NovoContato()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            cboTipoContato.SelectedIndex = -1
            cboTipoContato.Text = ""
            txtNomeContato.Text = ""
            txtTelefoneContato.Text = ""
            txtCelularContato.Text = ""
            dtpDataAniversario.Value = Now.Date : dtpDataAniversario.Checked = False
            txtEmailContato.Text = ""
            txtComplementoContato.Text = ""
            cboAtivo.SelectedValue = True
            btnSalvarContato.Tag = ""

            'Seta Focu
            cboTipoContato.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EmailContato()

        Try

            'Verifica se o Contato possui E-mail
            If IsDBNull(grdContato.CurrentRow.Cells("email").Value) = False Then

                'Enviar E-mail
                'Envia E-mail pelo Outlook
                Call SendEmailOutlook(grdContato.CurrentRow.Cells("email").Value, _
                                      "", _
                                      "", _
                                      "", _
                                      "", _
                                      "", _
                                      False, _
                                      "")

            Else
                'Informa o Usuário que o Contato não possui E-mail
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub EditarContato()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoParceiroNegocioContatos, gcUpdate) = True Then

                With grdContato.CurrentRow.Cells

                    'Limpa Controles
                    Call NovoContato()

                    'Carrega Controles
                    cboTipoContato.SelectedValue = .Item("codigo_tipo_contato").Value
                    txtNomeContato.Text = IIf(IsDBNull(.Item("nome").Value), "", .Item("nome").Value)
                    txtTelefoneContato.Text = IIf(IsDBNull(.Item("telefone").Value), "", .Item("telefone").Value)
                    txtCelularContato.Text = IIf(IsDBNull(.Item("celular").Value), "", .Item("celular").Value)
                    'cboAtivo.SelectedValue = .Item("ativo").Value
                    If .Item("data_aniversario").Value = "" Then
                        dtpDataAniversario.Value = Now.Date : dtpDataAniversario.Checked = False
                    Else
                        dtpDataAniversario.Value = .Item("data_aniversario").Value : dtpDataAniversario.Checked = True
                    End If
                    txtEmailContato.Text = IIf(IsDBNull(.Item("email2").Value), "", .Item("email2").Value)
                    txtComplementoContato.Text = IIf(IsDBNull(.Item("complemento").Value), "", .Item("complemento").Value)
                    btnSalvarContato.Tag = .Item("codigo").Value

                    'Seta Focu
                    cboTipoContato.Focus()

                End With

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Function ValidacaoContato() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoContato = False

            'Verifica se foi Selecionado o Campo - Tipo de Contato
            If ValidaCampo(cboTipoContato, lblTipoContato) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Nome
            If ValidaCampo(txtNomeContato, lblNomeContato, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Ativo
            If ValidaCampo(cboAtivo, lblAtivo) = False Then
                Exit Function
            End If

            ''Verifica se foi Preenchido o Campo - Telefone
            'If txtTelefoneContato.Text.Trim = "" And txtCelularContato.Text.Trim = "" Then
            '    frmMain.errInfo.SetError(lblTelefoneContato, "O Campo [Telefone ou Celular] é obrigatório. Digite um valor para ele.")
            '    txtTelefoneContato.Focus()
            '    Exit Function
            'End If

            'Seta Retorno da Função
            ValidacaoContato = True

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Function

    Private Sub DeleteContato()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdContato) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Deleta Contato
                    oClsCadParceiroNegocio.Codigo = iCodigoParceiroNegocio
                    oClsCadParceiroNegocio.DeleteContato()

                    'Limpa Formulário
                    Call NovoContato()

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

#End Region

#End Region

End Class

