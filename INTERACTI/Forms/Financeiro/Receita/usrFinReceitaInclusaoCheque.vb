Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class usrFinReceitaInclusaoCheque

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsFinReceitaInclusaoCheque As New clsUsrFinReceitaInclusaoCheque

#End Region

#Region "::: CONTROLES :::"

    Private Sub btnCadastrarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCliente.Click

        Try

            'Carrega o form de parceiro de negócio
            LoadUsrControlForm(Me, "usrCadParceiroNegocio")

            'Carrega Combo            
            LoadCombo(cboCliente, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa)

            'Seta Focu
            cboCliente.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCliente.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.cliente
            oComboBoxFind = cboCliente

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCliente.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrFinReceitaInclusaoCheque_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrFinReceitaInclusaoCheque_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrFinReceitaInclusaoCheque_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

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
            oForm.NomeFormulario = Formulario.FinanceiroReceitaInclusaoCheque
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FinanceiroReceitaInclusaoCheque)

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
            txtNumero.Focus()

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
            txtNumeroFiltro.Focus()

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
                                     Formulario.FinanceiroReceitaInclusaoCheque)


        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.FinanceiroReceitaInclusaoCheque, _
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
                                          Formulario.FinanceiroReceitaInclusaoCheque, _
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFinReceitaInclusaoCheque_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.FinanceiroReceitaInclusaoCheque, gcDelete)
            btnNovo1.Enabled = VerificaDireito(Formulario.FinanceiroReceitaInclusaoCheque, gcInsert)
            btnNovo.Enabled = VerificaDireito(Formulario.FinanceiroReceitaInclusaoCheque, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.FinanceiroReceitaInclusaoCheque, gcPrint)

            'Seta Controle
            dtpData.Checked = False
            dtpDataPreDatado.Checked = False
            dtpDataFiltro.Checked = False
            dtpDataPreDatadoFiltro.Checked = False

            Call LoadCombo(cboCliente, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboClienteFiltro, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa, False)

            'Configura a Grid
            Call ConfiguraGrid(grdListagem, Formulario.FinanceiroReceitaInclusaoCheque)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            txtNumeroFiltro.Focus()

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
            If VerificaDireito(Formulario.FinanceiroReceitaInclusaoCheque, gcUpdate) = True Then

                With grdListagem.CurrentRow.Cells

                    'Carrega Controles]
                    cboCliente.SelectedValue = .Item("codigo_cliente").Value
                    txtNumero.Text = .Item("numero").Value
                    txtDescricao.Text = .Item("descricao").Value
                    txtValor.Value = .Item("valor").Value
                    dtpData.Value = .Item("data").Value

                    btnSalvar.Tag = .Item("codigo").Value

                    If IsDBNull(.Item("data").Value) = False Then
                        dtpData.Checked = True
                    Else
                        dtpData.Checked = False
                        dtpData.Value = Now.Date
                    End If

                    If IsDBNull(.Item("data_pre_datado").Value) = False Then
                        dtpDataPreDatado.Checked = True
                        dtpDataPreDatado.Value = .Item("data_pre_datado").Value
                    Else
                        dtpDataPreDatado.Checked = False
                        dtpDataPreDatado.Value = Now.Date
                    End If

                    If cboCliente.Text = "-1" Then
                        cboCliente.Text = ""
                    End If

                End With

                'Alterna Aba
                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                txtNumero.Focus()

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
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsFinReceitaInclusaoCheque.Delete()

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
            cboCliente.SelectedIndex = -1
            txtNumero.Text = ""
            txtDescricao.Text = ""
            txtValor.Value = 0
            dtpData.Value = Now.Date
            dtpData.Checked = False
            dtpDataPreDatado.Value = Now.Date
            dtpDataPreDatado.Checked = False
            btnSalvar.Tag = ""

            'Seta Focu
            txtNumero.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsFinReceitaInclusaoCheque.Codigo = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1)
            oClsFinReceitaInclusaoCheque.Data = IIf(dtpData.Checked = True, dtpData.Value, "")
            oClsFinReceitaInclusaoCheque.DataPreDatado = IIf(dtpDataPreDatado.Checked = True, dtpDataPreDatado.Value, "")
            oClsFinReceitaInclusaoCheque.Numero = txtNumero.Text.Trim
            oClsFinReceitaInclusaoCheque.CodigoCliente = IIf(cboCliente.SelectedIndex = -1, -1, cboCliente.SelectedValue)
            oClsFinReceitaInclusaoCheque.Valor = txtValor.Value
            oClsFinReceitaInclusaoCheque.Descricao = txtDescricao.Text

            'Verifica o Tipo de Operação
            If IsNumeric(btnSalvar.Tag) Then
                oClsFinReceitaInclusaoCheque.Update()
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                oClsFinReceitaInclusaoCheque.Insert()
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
            Call oClsFinReceitaInclusaoCheque.LoadGrid(grdListagem, _
                                                       IIf(cboClienteFiltro.SelectedIndex = -1, -1, cboClienteFiltro.SelectedValue), _
                                                       txtNumeroFiltro.Text.Trim, _
                                                       txtDescricaoFiltro.Text.Trim, _
                                                       IIf(dtpDataFiltro.Checked = True, dtpDataFiltro.Value, ""), _
                                                       IIf(dtpDataPreDatadoFiltro.Checked = True, dtpDataPreDatadoFiltro.Value, ""))

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

            If ValidaCampo(txtNumero, lblNumero, TipoCampo.texto) = False Then
                Exit Function
            End If

            If dtpData.Checked = False Then
                frmMain.errInfo.SetError(lblData, "O Campo Data é obrigatório. Digite um valor para ele.")
                dtpData.Focus()
                Exit Function
            End If

            If txtValor.Value = 0 Then
                frmMain.errInfo.SetError(lblValor, "O Campo Valor não pode ser zero. Digite um valor válido para ele.")
                txtValor.Focus()
                Exit Function
            End If

            If ValidaCampo(txtDescricao, lblDescricao, TipoCampo.texto) = False Then
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
