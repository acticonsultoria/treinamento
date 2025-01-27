Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX

Public Class usrCadCFOP

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCadCFOP As New clsUsrCadCFOP

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrCadCFOP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                       
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrCadCFOP_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: CFOP :::"

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
            oForm.NomeFormulario = Formulario.CadastroBasicoCFOP
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoCFOP)

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

            'Alterna Aba
            tabMain.TabPages.Remove(pagLista)
            tabMain.TabPages.Add(pagDados)

            'Prepara o Formulário para Inserção de um Novo Registro
            Call Novo()

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

                Call Editar(oClsCadCFOP.Codigo)

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
            txtCFOPFiltro.Focus()

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

    Private Sub cboTipoMovimentacaoEstoque_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoMovimentacaoEstoque.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado algum Registro
            If cboTipoMovimentacaoEstoque.SelectedIndex = -1 Then
                grdDeposito.Enabled = False : btnConfigurarGridDeposito.Enabled = False : btnExcelGridDeposito.Enabled = False
                grdDepositoQualidade.Enabled = False : btnConfigurarGridDepositoQualidade.Enabled = False : btnExcelGridDepositoQualidade.Enabled = False
                Exit Sub
            End If

            'Verifica o Tipo de Movimentação do Estoque
            Select Case cboTipoMovimentacaoEstoque.SelectedValue
                Case CInt(TipoMovimentacaoEstoqueCFOP.EntradaSaida)
                    grdDeposito.Enabled = True : btnConfigurarGridDeposito.Enabled = True : btnExcelGridDeposito.Enabled = VerificaDireito(Formulario.CadastroBasicoCFOP, gcPrint)
                    grdDepositoQualidade.Enabled = True : btnConfigurarGridDepositoQualidade.Enabled = True : btnExcelGridDepositoQualidade.Enabled = VerificaDireito(Formulario.CadastroBasicoCFOP, gcPrint)
                Case CInt(TipoMovimentacaoEstoqueCFOP.SemMovimentacao)
                    grdDeposito.Enabled = False : btnConfigurarGridDeposito.Enabled = False : btnExcelGridDeposito.Enabled = False
                    grdDepositoQualidade.Enabled = False : btnConfigurarGridDepositoQualidade.Enabled = False : btnExcelGridDepositoQualidade.Enabled = False
            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Célula pressionada é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Editar(grdListagem.CurrentRow.Cells("codigo").Value)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.CadastroBasicoCFOP, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.CadastroBasicoCFOP)

            'Carrega Combo
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(sender As Object, e As Janus.Windows.GridEX.GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdListagem.Name, _
                                          Formulario.CadastroBasicoCFOP, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub txtCFOP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCFOP.TextChanged

        Try

            If Len(txtCFOP.Text.Trim) > 0 AndAlso IsNumeric(txtCFOP.Text.Substring(0, 1)) Then

                'Carrega Grid Tipo de Operação Nota Fiscal
                If txtCFOP.Text.Length = 4 AndAlso IsNumeric(txtCFOP.Text.Trim) AndAlso txtCFOP.Text.Substring(0, 1) > 0 And txtCFOP.Text.Substring(0, 1) < 4 Then
                    Call oClsCadCFOP.LoadGridTipoOperacaoEntradaNotaFiscal(grdTipoOperacaoNotaFiscal, txtCFOP.Text.Trim)
                    grdTipoOperacaoNotaFiscal.Enabled = True : btnConfigurarGridTipoOperacaoNotaFiscal.Enabled = True : btnExcelGridTipoOperacaoNotaFiscal.Enabled = VerificaDireito(Formulario.CadastroBasicoCFOP, gcPrint)
                ElseIf txtCFOP.Text.Length = 4 AndAlso IsNumeric(txtCFOP.Text.Trim) AndAlso txtCFOP.Text.Substring(0, 1) > 4 And txtCFOP.Text.Substring(0, 1) < 8 Then
                    Call oClsCadCFOP.LoadGridTipoOperacaoEmissaoNotaFiscal(grdTipoOperacaoNotaFiscal, txtCFOP.Text.Trim)
                    grdTipoOperacaoNotaFiscal.Enabled = True : btnConfigurarGridTipoOperacaoNotaFiscal.Enabled = True : btnExcelGridTipoOperacaoNotaFiscal.Enabled = VerificaDireito(Formulario.CadastroBasicoCFOP, gcPrint)
                Else
                    grdTipoOperacaoNotaFiscal.DataSource = Nothing
                    grdTipoOperacaoNotaFiscal.Enabled = False : btnConfigurarGridTipoOperacaoNotaFiscal.Enabled = False : btnExcelGridTipoOperacaoNotaFiscal.Enabled = False
                End If

            Else
                'Limpa Combo
                grdTipoOperacaoNotaFiscal.DataSource = Nothing
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: TIPO OPERAÇÃO - NOTA FISCAL :::"

    Private Sub btnConfigurarGridTipoOperacaoNotaFiscal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridTipoOperacaoNotaFiscal.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdTipoOperacaoNotaFiscal
            oForm.NomeFormulario = Formulario.CadastroBasicoCFOP
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdTipoOperacaoNotaFiscal, Formulario.CadastroBasicoCFOP)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridTipoOperacaoNotaFiscal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridTipoOperacaoNotaFiscal.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdTipoOperacaoNotaFiscal)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdTipoOperacaoNotaFiscal_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdTipoOperacaoNotaFiscal.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdTipoOperacaoNotaFiscal.Name, _
                                     Formulario.CadastroBasicoCFOP, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdTipoOperacaoNotaFiscal_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdTipoOperacaoNotaFiscal.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdTipoOperacaoNotaFiscal, _
                                     Formulario.CadastroBasicoCFOP)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: DEPÓSITO QUALIDADE :::"

    Private Sub btnConfigurarGridDepositoQualidade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridDepositoQualidade.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdDepositoQualidade
            oForm.NomeFormulario = Formulario.CadastroBasicoCFOP
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdDepositoQualidade, Formulario.CadastroBasicoCFOP)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridDepositoQualidade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridDepositoQualidade.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdDepositoQualidade)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdDepositoQualidade_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdDepositoQualidade.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdDepositoQualidade.Name, _
                                     Formulario.CadastroBasicoCFOP, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdDepositoQualidade_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdDepositoQualidade.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdDepositoQualidade, _
                                     Formulario.CadastroBasicoCFOP)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: DEPÓSITO :::"

    Private Sub btnConfigurarGridDeposito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridDeposito.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdDepositoQualidade
            oForm.NomeFormulario = Formulario.CadastroBasicoCFOP
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdDepositoQualidade, Formulario.CadastroBasicoCFOP)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridDeposito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridDeposito.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdDeposito)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdDeposito_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdDepositoQualidade.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdDepositoQualidade.Name, _
                                     Formulario.CadastroBasicoCFOP, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdDeposito_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdDepositoQualidade.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdDepositoQualidade, _
                                     Formulario.CadastroBasicoCFOP)

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCadCFOP_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.CadastroBasicoCFOP, gcDelete)
            btnNovo1.Enabled = VerificaDireito(Formulario.CadastroBasicoCFOP, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.CadastroBasicoCFOP, gcPrint)
            
            'Carrega Combo
            Call LoadCombo(cboTipoMovimentacaoEstoque, "sp_select_combo_static_tipo_movimentacao_estoque_cfop")
            Call LoadComboSimNao(cboGeraFinanceiro)
            Call LoadComboSimNao(cboAtivo)
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

            'Desabilita Controles
            grdDeposito.Enabled = False : btnConfigurarGridDeposito.Enabled = False : btnExcelGridDeposito.Enabled = False
            grdDepositoQualidade.Enabled = False : btnConfigurarGridDepositoQualidade.Enabled = False : btnExcelGridDepositoQualidade.Enabled = False
            grdTipoOperacaoNotaFiscal.Enabled = False : btnConfigurarGridTipoOperacaoNotaFiscal.Enabled = False : btnExcelGridTipoOperacaoNotaFiscal.Enabled = False

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.CadastroBasicoCFOP)
            Call ConfiguraGrid(grdTipoOperacaoNotaFiscal, Formulario.CadastroBasicoCFOP)
            Call ConfiguraGrid(grdDeposito, Formulario.CadastroBasicoCFOP)
            Call ConfiguraGrid(grdDepositoQualidade, Formulario.CadastroBasicoCFOP)

            'Seta Focu
            txtCFOPFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: CFOP :::"

    Private Sub Editar(lCodigo As Long)

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.CadastroBasicoCFOP, gcUpdate) = True Then

                'Carrega Controles
                btnSalvar.Tag = lCodigo


                oClsCadCFOP.LoadDados(lCodigo,
                                      txtCFOP,
                                      txtNaturezaOperacao,
                                      txtAplicacao,
                                      cboGeraFinanceiro,
                                      cboAtivo,
                                      txtMensagem,
                                      cboTipoMovimentacaoEstoque)

                'Carrega Grid - Depósito - Qualidade
                Call oClsCadCFOP.LoadGridDepositoQualidade(grdDepositoQualidade, lCodigo)
                'Carrega Grid - Depósito
                Call oClsCadCFOP.LoadGridDeposito(grdDeposito, lCodigo)

                'Alterna Aba
                If tabMain.SelectedTab.Name <> pagDados.Name Then

                    'Alterna Aba
                    tabMain.TabPages.Remove(pagLista)
                    tabMain.TabPages.Add(pagDados)
                End If

                'Seta Focu
                txtCFOP.Focus()

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

            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCadCFOP.Delete()

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

            'Limpa Controles
            txtCFOP.Text = ""
            btnSalvar.Tag = ""
            txtNaturezaOperacao.Text = ""
            cboAtivo.SelectedIndex = -1
            cboTipoMovimentacaoEstoque.SelectedIndex = -1
            cboGeraFinanceiro.SelectedIndex = -1
            txtAplicacao.Text = ""
            txtMensagem.Text = ""

            'Oculta Grid
            grdTipoOperacaoNotaFiscal.Enabled = False : btnConfigurarGridTipoOperacaoNotaFiscal.Enabled = False

            'Carrega Grid - Depósito - Qualidade
            Call oClsCadCFOP.LoadGridDepositoQualidade(grdDepositoQualidade, -1)
            'Carrega Grid - Depósito
            Call oClsCadCFOP.LoadGridDeposito(grdDeposito, -1)

            'Seta Focu
            txtCFOP.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsCadCFOP.Codigo = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0)
            oClsCadCFOP.CFOP = txtCFOP.Text.Trim
            oClsCadCFOP.NaturezaOperacao = txtNaturezaOperacao.Text.Trim
            oClsCadCFOP.Fatura = cboGeraFinanceiro.SelectedValue
            oClsCadCFOP.TipoMovimentacaoEstoque = cboTipoMovimentacaoEstoque.SelectedValue
            oClsCadCFOP.Ativo = cboAtivo.SelectedValue
            oClsCadCFOP.Aplicacao = txtAplicacao.Text.Trim
            oClsCadCFOP.Mensagem = txtMensagem.Text.Trim

            'Verifica o Tipo de Operação
            If IsNumeric(btnSalvar.Tag) Then
                oClsCadCFOP.Update()
                oClsCadCFOP.DeleteTipoOperacaoEntradaNotaFiscal(btnSalvar.Tag)
                oClsCadCFOP.DeleteTipoOperacaoEmissaoNotaFiscal(btnSalvar.Tag)
                If txtCFOP.Text.Substring(0, 1) < 5 Then
                    oClsCadCFOP.InsertTipoOperacaoEntradaNotaFiscal(btnSalvar.Tag, grdTipoOperacaoNotaFiscal)
                Else
                    oClsCadCFOP.InsertTipoOperacaoEmissaoNotaFiscal(btnSalvar.Tag, grdTipoOperacaoNotaFiscal)
                End If
                oClsCadCFOP.DeleteDeposito(btnSalvar.Tag)
                oClsCadCFOP.InsertDeposito(btnSalvar.Tag, grdDeposito)
                oClsCadCFOP.DeleteDepositoQualidade(btnSalvar.Tag)
                oClsCadCFOP.InsertDepositoQualidade(btnSalvar.Tag, grdDepositoQualidade)
                frmMain.Informacao(Mensagem.RegistroAlterado)
            Else
                oClsCadCFOP.Insert()
                btnSalvar.Tag = oClsCadCFOP.Codigo
                If txtCFOP.Text.Substring(0, 1) < 5 Then
                    oClsCadCFOP.InsertTipoOperacaoEntradaNotaFiscal(btnSalvar.Tag, grdTipoOperacaoNotaFiscal)
                Else
                    oClsCadCFOP.InsertTipoOperacaoEmissaoNotaFiscal(btnSalvar.Tag, grdTipoOperacaoNotaFiscal)
                End If
                oClsCadCFOP.InsertDeposito(btnSalvar.Tag, grdDeposito)
                oClsCadCFOP.InsertDepositoQualidade(btnSalvar.Tag, grdDepositoQualidade)
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
            oClsCadCFOP.LoadGrid(grdListagem, _
                                 txtCFOPFiltro.Text.Trim, _
                                 txtNaturezaOperacaoFiltro.Text.Trim)

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

            'Verifica se foi Preenchido o Campo - CFOP
            If ValidaCampo(txtCFOP, lblCFOP, TipoCampo.numero) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - CFOP com 4 dígitos
            If txtCFOP.Text.Length <> 4 Or (CInt(Mid(txtCFOP.Text, 1, 1)) > 7 Or CInt(Mid(txtCFOP.Text, 1, 1)) = 4) Then
                frmMain.errInfo.SetError(lblCFOP, "Este CFOP: " & txtCFOP.Text & " não é válido. O CFOP deve possuir 4 (quatro) dígitos e começar com 1, 2 ou 3 quando entrada e 5, 6 ou 7 quando saída.")
                txtCFOP.Focus()
                Exit Function
            End If

            'Verifica se o CFOP é válido
            If oClsCadCFOP.ValidaCFOP(IIf(IsNumeric(btnSalvar.Tag), _btnSalvar.Tag, -1), _
                                      txtCFOP.Text.Trim) = False Then
                frmMain.errInfo.SetError(lblCFOP, "Este CFOP: " & txtCFOP.Text & " já está associado a outro Registro.")
                txtCFOP.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Natureza Operação
            If ValidaCampo(txtNaturezaOperacao, lblNaturezaOperacao, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Tipo de Movimentação Estoque
            If ValidaCampo(cboTipoMovimentacaoEstoque, lblTipoMovimentacaoEstoque) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Gera Financeiro
            If ValidaCampo(cboGeraFinanceiro, lblGeraFinanceiro) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Ativo
            If ValidaCampo(cboAtivo, lblAtivo) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

End Class
