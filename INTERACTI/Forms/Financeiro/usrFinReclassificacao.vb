Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX

Public Class usrFinReclassificacao

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsFinReclassificacao As New clsUsrFinReclassificacao

#End Region

#Region "::: CONTROLES :::"

#Region "::: GERAL :::"

    Private Sub usrFinReclassificacao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                    
                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboCentroGasto" : Call LoadCombo(cboCentroGasto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)
                        Case "cboContaContabil" : Call LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.F3

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboCentroGastoFiltro" : Call btnProcurarCentroGastoFiltro_Click(btnProcurarCentroGastoFiltro, System.EventArgs.Empty)
                        Case "cboContaContabilFiltro" : Call btnProcurarContaContabilFiltro_Click(btnProcurarContaContabilFiltro, System.EventArgs.Empty)
                        Case "cboCentroGasto" : Call btnProcurarCentroGasto_Click(btnProcurarCentroGasto, System.EventArgs.Empty)
                        Case "cboContaContabil" : Call btnProcurarContaContabil_Click(btnProcurarContaContabil, System.EventArgs.Empty)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboCentroGasto" : Call btnCadastrarCentroGasto_Click(btnCadastrarCentroGasto, System.EventArgs.Empty)
                        Case "cboContaContabil" : Call btnCadastrarContaContabil_Click(btnCadastrarContaContabil, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrFinReclassificacao_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: TÍTULO :::"

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
            oForm.NomeFormulario = Formulario.FinanceiroReclassificacao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FinanceiroReclassificacao)

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

    Private Sub btnProcurarCentroGastoFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCentroGastoFiltro.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindCentroGasto"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Centro de Gasto"

            'Seta Váriaveis
            oComboBoxFind = cboCentroGastoFiltro

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCentroGastoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnProcurarContaContabilFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarContaContabilFiltro.Click

        Try
            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindPlanoContas"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Conta Contábil"

            'Seta Parametros
            oComboBoxFind = cboContaContabilFiltro

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboContaContabilFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Exclui Registros
            Call DeleteClassificacaoCapa()

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

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Deleta Aba
        If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
        'Fecha o Controle
        Me.Dispose()

    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        Try

            'Carrega Grid
            Call LoadGrid()

            'Alterna Aba
            tabMain.TabPages.Remove(pagDespesa)
            tabMain.TabPages.Add(pagListagem)

            'Seta Focu
            txtNumeroDocumentoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
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
                                     Formulario.FinanceiroReclassificacao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.FinanceiroReclassificacao, _
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
                                          Formulario.FinanceiroReclassificacao, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: CLASSIFICAÇÃO :::"

    Private Sub btnAgruparGridClassificacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridClassificacao.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdClassificacao.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdClassificacao.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdClassificacao.GroupByBoxVisible = True
                grdClassificacao.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridClassificacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridClassificacao.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdClassificacao
            oForm.NomeFormulario = Formulario.FinanceiroReclassificacao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdClassificacao, Formulario.FinanceiroReclassificacao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridClassificacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridClassificacao.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdClassificacao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarCentroGasto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCentroGasto.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindCentroGasto"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Centro de Gasto"

            'Seta Váriaveis
            oComboBoxFind = cboCentroGasto

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCentroGasto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnProcurarContaContabil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarContaContabil.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindPlanoContas"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Conta Contábil"

            'Seta Parametros
            oComboBoxFind = cboContaContabil

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboContaContabil.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCadastrarCentroGasto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCentroGasto.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCentroGasto")

            'Carrega Combo            
            LoadCombo(cboCentroGasto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)

            'Seta Focu
            cboCentroGasto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarContaContabil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarContaContabil.Click

        Try

            'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadPlanoContas")

            'Carrega Combo            
            LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa)

            'Seta Focu
            cboContaContabil.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirClassificao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirClassificao.Click

        Try

            'Insere Classificação
            Call InserirClassificacao()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirClassificacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirClassificacao.Click

        Try

            'Exclui Classificação
            Call DeleteClassificacao()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdClassificacao_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdClassificacao.RowDoubleClick

        Try

            'Verifica se a Coluna Pressionada é Válida
            If IsNothing(grdClassificacao.CurrentColumn) Then Exit Sub

            Select Case grdClassificacao.CurrentColumn.Key

                Case "editar" : Call EditarClassificacao()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdClassificacao_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdClassificacao.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdClassificacao, _
                                     Formulario.FinanceiroReclassificacao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdClassificacao_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdClassificacao.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdClassificacao.Name, _
                                     Formulario.FinanceiroReclassificacao, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdClassificacao_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdClassificacao.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdClassificacao.Name, _
                                          Formulario.FinanceiroReclassificacao, _
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

#Region "::: GERAL :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFinReclassificacao_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.FinanceiroReclassificacao, gcDelete)
            btnInserirClassificao.Enabled = VerificaDireito(Formulario.FinanceiroReclassificacao, gcInsert)
            btnExcluirClassificacao.Enabled = VerificaDireito(Formulario.FinanceiroReclassificacao, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.FinanceiroReclassificacao, gcPrint)
            btnExcelGridClassificacao.Enabled = VerificaDireito(Formulario.FinanceiroReclassificacao, gcPrint)

            'Verifica Direito - Botão de Cadastro            
            btnCadastrarCentroGasto.Enabled = VerificaDireito(Formulario.CadastroBasicoCentroGasto, gcInsert)
            btnCadastrarContaContabil.Enabled = VerificaDireito(Formulario.CadastroBasicoCentroGasto, gcInsert)

            'Carrega ComboBox
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboCentroGastoFiltro : oComboBox(1) = cboCentroGasto
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa, False)
            oComboBox(0) = cboContaContabilFiltro : oComboBox(1) = cboContaContabil
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa, False)
            'Carrega Combo - Tipo de Item
            cboTipoTituloFiltro.Items.Add("RECEITA", "R")
            cboTipoTituloFiltro.Items.Add("DESPESA", "D")
            'Carrega Combo - Status
            cboStatusFiltro.Items.Add("CLASSIFICADO", 1)
            cboStatusFiltro.Items.Add("NÃO CLASSIFICADO", 2)
            cboStatusFiltro.Items.Add("PARCIALMENTE CLASSIFICADO", 3)            

            'Seta Controle
            dtpDataEmissaoInicioFiltro.Value = Now.Date : dtpDataEmissaoInicioFiltro.Checked = False
            dtpDataEmissaoTerminoFiltro.Value = Now.Date : dtpDataEmissaoTerminoFiltro.Checked = False
            dtpDataVencimentoInicioFiltro.Value = Now.Date : dtpDataVencimentoInicioFiltro.Checked = False
            dtpDataVencimentoTerminoFiltro.Value = Now.Date : dtpDataVencimentoTerminoFiltro.Checked = False
            dtpDataPagamentoInicioFiltro.Value = Now.Date : dtpDataPagamentoInicioFiltro.Checked = False
            dtpDataPagamentoTerminoFiltro.Value = Now.Date : dtpDataPagamentoTerminoFiltro.Checked = False

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FinanceiroReclassificacao)
            Call ConfiguraGrid(grdClassificacao, Formulario.FinanceiroReclassificacao)

            'Seta Aba
            tabMain.TabPages.Remove(pagDespesa)

            'Seta Focu
            txtNumeroDocumentoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: TÍTULO :::"

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Controles
            oClsFinReclassificacao.LoadGrid(grdListagem, _
                                            txtNumeroDocumentoFiltro.Text.Trim, _
                                            txtSerieFiltro.Text.Trim, _
                                            txtParceiroNegocioFiltro.Text.Trim, _
                                            IIf(cboTipoTituloFiltro.SelectedIndex = -1, "", cboTipoTituloFiltro.SelectedValue), _
                                            IIf(cboCentroGastoFiltro.SelectedIndex = -1, -1, cboCentroGastoFiltro.SelectedValue), _
                                            IIf(cboContaContabilFiltro.SelectedIndex = -1, "", cboContaContabilFiltro.SelectedValue), _
                                            IIf(cboStatusFiltro.SelectedIndex = -1, -1, cboStatusFiltro.SelectedValue), _
                                            IIf(dtpDataEmissaoInicioFiltro.Checked = False, "", dtpDataEmissaoInicioFiltro.Value), _
                                            IIf(dtpDataEmissaoTerminoFiltro.Checked = False, "", dtpDataEmissaoTerminoFiltro.Value), _
                                            IIf(dtpDataVencimentoInicioFiltro.Checked = False, "", dtpDataVencimentoInicioFiltro.Value), _
                                            IIf(dtpDataVencimentoTerminoFiltro.Checked = False, "", dtpDataVencimentoTerminoFiltro.Value), _
                                            IIf(dtpDataPagamentoInicioFiltro.Checked = False, "", dtpDataPagamentoInicioFiltro.Value), _
                                            IIf(dtpDataPagamentoTerminoFiltro.Checked = False, "", dtpDataPagamentoTerminoFiltro.Value))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.FinanceiroReclassificacao, gcUpdate) = True Then

                'Carrega Controles
                txtNumeroDocumento.Text = grdListagem.CurrentRow.Cells("numero_documento").Value
                txtSerie.Text = grdListagem.CurrentRow.Cells("serie").Value
                txtDataEmissao.Text = grdListagem.CurrentRow.Cells("data_emissao").Value
                txtParceiroNegocio.Text = grdListagem.CurrentRow.Cells("parceiro_negocio").Value
                txtValor.Value = grdListagem.CurrentRow.Cells("valor").Value
                txtValorPago.Value = grdListagem.CurrentRow.Cells("valor_classificado").Value
                txtNumeroDocumento.Tag = grdListagem.CurrentRow.Cells.Item("codigo_titulo_capa").Value

                'Carrega Grid de Classificação
                oClsFinReclassificacao.LoadGridClassificacao(grdClassificacao, _
                                                             grdListagem.CurrentRow.Cells.Item("codigo_titulo_capa").Value)

                'Alterna Aba
                tabMain.TabPages.Remove(pagListagem)
                tabMain.TabPages.Add(pagDespesa)

                'Seta Focu
                cboCentroGasto.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: CLASSIFICAÇÃO :::"

    Private Sub InserirClassificacao()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoClassificacao() = True Then

                'Verifica o Tipo de Operação
                If IsNumeric(btnInserirClassificao.Tag) Then

                    'Altera Registro
                    oClsFinReclassificacao.UpdateClassificacao(txtNumeroDocumento.Tag, _
                                                               IIf(cboCentroGasto.SelectedIndex = -1, -1, cboCentroGasto.SelectedValue), _
                                                               IIf(cboContaContabil.SelectedIndex = -1, "", cboContaContabil.SelectedValue), _
                                                               txtValorClassificacao.Value, _
                                                               IIf(IsDBNull(grdClassificacao.CurrentRow.Cells("codigo_centro_custo").Value), -1, grdClassificacao.CurrentRow.Cells("codigo_centro_custo").Value), _
                                                               IIf(IsDBNull(grdClassificacao.CurrentRow.Cells("codigo_conta_contabil").Value), "", grdClassificacao.CurrentRow.Cells("codigo_conta_contabil").Value))

                Else

                    'Insere Registro
                    oClsFinReclassificacao.InsertClassificacao(txtNumeroDocumento.Tag, _
                                                               IIf(cboCentroGasto.SelectedIndex = -1, -1, cboCentroGasto.SelectedValue), _
                                                               IIf(cboContaContabil.SelectedIndex = -1, "", cboContaContabil.SelectedValue), _
                                                               txtValorClassificacao.Value)

                End If

                'Carrega Grid
                Call oClsFinReclassificacao.LoadGridClassificacao(grdClassificacao, _
                                                                  txtNumeroDocumento.Tag)

                'Limpa Formulário
                Call NovoClassificacao()

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarClassificacao()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.FinanceiroReclassificacao, gcUpdate) = True Then

                'Carrega Controles
                cboCentroGasto.SelectedValue = grdClassificacao.CurrentRow.Cells("codigo_centro_custo").Value
                cboContaContabil.SelectedValue = grdClassificacao.CurrentRow.Cells("codigo_conta_contabil").Value
                txtValorClassificacao.Value = grdClassificacao.CurrentRow.Cells("valor").Value
                btnInserirClassificao.Tag = grdClassificacao.CurrentRow.RowIndex

                'Seta Focu
                cboCentroGasto.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteClassificacao()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdClassificacao) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Dim i As Integer

                    For i = 0 To UBound(gSelecaoRow)

                        'Deleta Classificação
                        Call oClsFinReclassificacao.DeleteClassificacao(txtNumeroDocumento.Tag, _
                                                                        IIf(IsDBNull(gSelecaoRow(i).Cells("codigo_centro_custo").Value), -1, gSelecaoRow(i).Cells("codigo_centro_custo").Value), _
                                                                        IIf(IsDBNull(gSelecaoRow(i).Cells("codigo_conta_contabil").Value), "", gSelecaoRow(i).Cells("codigo_conta_contabil").Value))
                    Next

                    'Carrega Grid
                    Call oClsFinReclassificacao.LoadGridClassificacao(grdClassificacao, _
                                                                      txtNumeroDocumento.Tag)

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                MsgBox("Primeiramente Selecione um ou mais Registros Válidos.", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteClassificacaoCapa()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Dim i As Integer

                    For i = 0 To UBound(gSelecaoRow)

                        'Deleta Classificação
                        Call oClsFinReclassificacao.DeleteClassificacao(gSelecaoRow(i).Cells("codigo_titulo_capa").Value, _
                                                                        IIf(IsDBNull(gSelecaoRow(i).Cells("codigo_centro_custo").Value), -1, gSelecaoRow(i).Cells("codigo_centro_custo").Value), _
                                                                        IIf(IsDBNull(gSelecaoRow(i).Cells("codigo_conta_contabil").Value), "", gSelecaoRow(i).Cells("codigo_conta_contabil").Value))
                    Next

                    'Carrega Grid
                    Call LoadGrid()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                MsgBox("Primeiramente Selecione um ou mais Registros Válidos.", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoClassificacao()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            cboCentroGasto.SelectedIndex = -1
            cboContaContabil.SelectedIndex = -1
            txtValorClassificacao.Value = 0
            btnInserirClassificao.Tag = ""

            'Seta Focu
            cboCentroGasto.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoClassificacao() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoClassificacao = False

            'Verifica se foi Selecionado o Campo - Centro de Gasto ou Conta Contábil
            If cboCentroGasto.SelectedIndex = -1 And cboContaContabil.SelectedIndex = -1 Then
                frmMain.errInfo.SetError(lblCentroGasto, "Primeiramente Selecione um Centro de Gasto ou uma Conta Contábil.")
                cboCentroGasto.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Valor
            If ValidaCampo(txtValorClassificacao, lblValorClassificacao, True) = False Then
                Exit Function
            End If

            'Valida se a Soma do Valor Classificação é maior que o Valor Total
            Dim dValor, dValorTotal As Double

            If IsNumeric(btnInserirClassificao.Tag) Then
                dValor = grdClassificacao.CurrentRow.Cells("valor").Value
            End If
            If grdClassificacao.GetDataRows.Count > 0 Then
                dValorTotal = grdClassificacao.GetTotalRow.Cells("valor").Value
            End If
            If (txtValor.Value < (dValorTotal - dValor + txtValorClassificacao.Value)) Then
                frmMain.errInfo.SetError(lblValorClassificacao, "A Soma dos Valores (Classificação) não pode ser maior que o Valor Total.")
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoClassificacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

    Private Sub tabMain_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.Tab.TabEventArgs) Handles tabMain.SelectedTabChanged

    End Sub
End Class

