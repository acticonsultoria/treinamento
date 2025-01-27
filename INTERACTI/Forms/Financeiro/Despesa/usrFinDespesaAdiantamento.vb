Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX

Public Class usrFinDespesaAdiantamento

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsFinDespesaAdiantamento As New clsUsrFinDespesaAdiantamento
    'Private oClsUsrFinBloqueioExtrato As New clsUsrFinBloqueioExtrato
    Private iFormulario As Integer

#End Region

#Region "::: CONTROLES :::"

#Region "::: GERAL :::"

    Private Sub usrFinDespesaAdiantamento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

                Case Keys.F3

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboFornecedor" : Call btnProcurarFornecedor_Click(btnProcurarFornecedor, System.EventArgs.Empty)
                        Case "txtFornecedorFiltro" : Call btnProcurarFornecedorFiltro_Click(btnProcurarFornecedorFiltro, System.EventArgs.Empty)
                        Case "cboCentroGasto" : Call btnProcurarCentroCusto_Click(btnProcurarCentroCusto, System.EventArgs.Empty)
                        Case "cboContaContabil" : Call btnProcurarContaContabil_Click(btnProcurarContaContabil, System.EventArgs.Empty)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboFornecedor" : Call LoadCombo(cboFornecedor, "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa)
                        Case "cboCentroGasto" : Call LoadCombo(cboCentroGasto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)
                        Case "cboContaContabil" : Call LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.N : If e.Control = False Then Exit Sub

                    Select Case sender.Name
                        Case "cboFornecedor" : Call btnCadastrarFornecedor_Click(btnCadastrarFornecedor, System.EventArgs.Empty)
                        Case "cboCentroGasto" : Call btnCadastrarCentroGasto_Click(btnCadastrarCentroGasto, System.EventArgs.Empty)
                        Case "cboContaContabil" : Call btnCadastrarContaContabil_Click(btnCadastrarContaContabil, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrFinDespesaAdiantamento_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usr_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize

        'Reposiciona UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

#End Region

#Region "::: TÍTULO :::"

    Private Sub btnCadastrarFornecedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarFornecedor.Click

        Try

            'Carrega o form de parceiro de negócio
            If sender.Enabled = False Then Exit Sub Else LoadUsrControlForm(Me, "usrCadParceiroNegocio")

            'Carrega Combo            
            LoadCombo(cboFornecedor, "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa)

            'Seta Focu
            cboFornecedor.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarFornecedorFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarFornecedorFiltro.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.fornecedor
            oMaskedEditBoxFind = txtFornecedorFiltro

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : DisableTabStop(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            txtFornecedorFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarFornecedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarFornecedor.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.fornecedor
            oComboBoxFind = cboFornecedor

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : DisableTabStop(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboFornecedor.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Try

            'Cancela Registros
            Call Cancelar()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnAtivar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtivar.Click

        Try

            'Ativar Registros
            Call Ativar()

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

            'Prepara o Formulário para Inserção de um Novo Registro
            Call Novo()

            'Alterna Aba
            tabMain.TabPages.Remove(pagListagem)
            tabMain.TabPages.Add(pagDespesa)

            'Seta Focu
            txtNumeroDocumento.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click

        Try

            'Prepara o Formulário para Inserção de um Novo Registro
            Call Novo()

            'Seta Focu
            txtNumeroDocumento.Focus()

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

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Salva Dados do Registro
                Call Salvar()
                'Seta Focu
                btnNovo.Focus()

            End If

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

            'Verifica se a Coluna Pressionada é Válida
            If IsNothing(grdListagem) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "duplicar" : Call Duplicar()
                Case "historico" : Call Historico()
                Case "editar" : Call Editar()
                Case "editar_parceiro_negocio" : Call EditarParceiroNegocio()
                Case "editar_parcela" : Call EditarDuplicata()
                Case "pagar" : Call Pagar()
                Case "cancelar" : Call CancelarPagamento()
                Case "duplicar_parcela" : Call DuplicarParcela()
                Case "arquivo" : Call ListaArquivo("tb_fin_titulo_capa", grdListagem.CurrentRow.Cells("codigo_titulo_capa").Value)
                Case "pedido_compra"
                    If grdListagem.CurrentRow.Cells("codigo_pedido_compra").Value = 0 Then
                        frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Não existe Pedido de Compra associado a este Título")
                    Else
                        Call ImprimirPedidoCompra(grdListagem.CurrentRow.Cells("codigo_titulo_capa").Value)
                    End If

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
                                     Formulario.FinanceiroDespesaAdiantamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.FinanceiroDespesaAdiantamento, _
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
                                          Formulario.FinanceiroDespesaAdiantamento, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub


    Private Sub cboFornecedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFornecedor.SelectedIndexChanged

        Try

            LoadCombo(cboPedidoCompra, "sp_select_combo_numero_pedido_compra " & goUsuario.iEmpresa & ", " & IIf(cboFornecedor.SelectedIndex = -1, -1, cboFornecedor.SelectedValue))

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
            oForm.NomeFormulario = Formulario.FinanceiroDespesaAdiantamento
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : DisableTabStop(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdClassificacao, Formulario.FinanceiroDespesaLancamento)

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

    Private Sub btnProcurarCentroCusto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarCentroCusto.Click

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
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : DisableTabStop(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboCentroGasto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
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
            oComboBoxFind = cboContaContabil
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : DisableTabStop(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboContaContabil.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarCentroGasto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCentroGasto.Click

        Try

            'Abre Formulário de Cadastro
            If sender.Enabled = False Then Exit Sub Else LoadUsrControlForm(Me, "usrCadCentroGasto")

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
            If sender.Enabled = False Then Exit Sub Else LoadUsrControlForm(Me, "usrCadPlanoContas")

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
            If IsNothing(grdClassificacao) Then Exit Sub

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
                                     Formulario.FinanceiroDespesaAdiantamento)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdClassificacao_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdClassificacao.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdClassificacao.Name, _
                                     Formulario.FinanceiroDespesaAdiantamento, _
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
                                          Formulario.FinanceiroDespesaAdiantamento, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: ARQUIVO :::"

    Private Sub btnAgruparGridArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridArquivo.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdArquivo.GroupByBoxVisible = True Then
                'Oculta Grupo
                grdArquivo.GroupByBoxVisible = False
            Else
                'Exibe Grupo
                grdArquivo.GroupByBoxVisible = True
                grdArquivo.HideColumnsWhenGrouped = InheritableBoolean.True
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridArquivo.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdArquivo
            oForm.NomeFormulario = Formulario.CadastroBasicoProduto
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : DisableTabStop(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdArquivo, Formulario.CadastroBasicoProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridArquivo.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdArquivo)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarTipoArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarTipoArquivo.Click

        Try

            'Abre Formulário de Cadastro
            If sender.Enabled = False Then Exit Sub Else LoadUsrControlForm(Me, "usrCadTipoArquivo")

            'Carrega Combo
            Call LoadCombo(cboTipoArquivo, "sp_select_combo_cadastro_basico_tipo_arquivo " & goUsuario.iEmpresa)
            'Seta Focu
            cboTipoArquivo.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArquivo.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Campo - Tipo de Arquivo
            If ValidaCampo(cboTipoArquivo, lblTipoArquivo) = False Then
                Exit Sub
            End If

            'Variaveis Locais
            Dim arqArquivo As New OpenFileDialog

            'Abre PopUp para Usuário selecionar Imagem
            arqArquivo.InitialDirectory = "c:\\dados"
            arqArquivo.Filter = LoadDescricao("sp_select_cadastro_basico_extensao_tipo_arquivo " & goUsuario.iEmpresa & "," & cboTipoArquivo.SelectedValue)
            arqArquivo.Title = "Selecione o Arquivo"

            If arqArquivo.ShowDialog() = DialogResult.OK Then
                txtArquivo.Text = arqArquivo.FileName
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirArquivo.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Embalagem
            If ValidacaoArquivo() = True And IsNumeric(btnSalvar.Tag) = True Then

                If IsNumeric(btnInserirArquivo.Tag) = False Then

                    'Insere Arquivo
                    Call InsertArquivoBD("tb_fin_titulo_capa",
                                         txtDescricaoArquivo.Text.Trim,
                                         txtRevisaoArquivo.Text.Trim,
                                         txtArquivo.Text.Trim,
                                         cboTipoArquivo.SelectedValue,
                                         btnSalvar.Tag)

                Else

                    'Atualiza Arquivo
                    Call UpdateArquivoBD("tb_fin_titulo_capa",
                                         txtDescricaoArquivo.Text.Trim,
                                         txtRevisaoArquivo.Text.Trim,
                                         IIf(txtArquivo.Text.Trim = "", grdArquivo.CurrentRow.Cells("path").Value, txtArquivo.Text.Trim),
                                         cboTipoArquivo.SelectedValue,
                                         grdArquivo.CurrentRow.Cells("path").Value,
                                         btnSalvar.Tag)

                End If

                'Carrega Grid
                Call LoadGridArquivoBD(grdArquivo, "tb_fin_titulo_capa", btnSalvar.Tag)

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoArquivo()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirArquivo.Click

        Try

            'Deleta Registros
            Call DeleteArquivo()

            'Prepara Formulário para Inserção de um Novo Registro
            Call NovoArquivo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboTipoArquivo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoArquivo.SelectedIndexChanged

        Try

            'Limpa Controle
            txtArquivo.Text = ""

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdArquivo.RowDoubleClick

        Try

            'Verifica se foi pressionado uma Célula Válida
            If IsNothing(grdArquivo.CurrentRow) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdArquivo.CurrentColumn.Key

                Case "editar" : Call EditarArquivo()
                Case "visualizar" : Call VisualizarDocumento(grdArquivo.CurrentRow.Cells("path").Value)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdArquivo.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdArquivo,
                                     Formulario.CadastroBasicoProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdArquivo.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdArquivo.Name,
                                     Formulario.CadastroBasicoProduto,
                                     e.Column.Key,
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdArquivo.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdArquivo.Name,
                                          Formulario.CadastroBasicoProduto,
                                          e.Group.Column.Key,
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False),
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

            iFormulario = LoadCodigo("sp_select_static_formulario_codigo_user_control '" & Me.Name & "'")
            iFormularioGrid = iFormulario

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFinDespesaAdiantamento_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(iFormulario, gcDelete)
            btnNovo.Enabled = VerificaDireito(iFormulario, gcInsert)
            btnSalvar.Enabled = VerificaDireito(iFormulario, gcInsert)

            'Verifica Direito - Botão de Cadastro            
            btnCadastrarFornecedor.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcInsert)
            btnCadastrarCentroGasto.Enabled = VerificaDireito(Formulario.CadastroBasicoCentroGasto, gcInsert)
            btnCadastrarContaContabil.Enabled = VerificaDireito(Formulario.CadastroBasicoPlanoContas, gcInsert)

            'Carrega ComboBox
            LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_titulo")
            LoadCombo(cboFornecedor, "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa, False)
            LoadCombo(cboCentroGasto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa, False)
            LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa, False)
            LoadCombo(cboContaBancariaFiltro, "sp_select_combo_cadastro_basico_banco_conta " & goUsuario.iEmpresa)
            LoadCombo(cboPedidoCompra, "sp_select_combo_numero_pedido_compra " & goUsuario.iEmpresa & ", " & IIf(cboFornecedor.SelectedIndex = -1, -1, cboFornecedor.SelectedValue))

            'Carrega Combo - Conta Bancária
            LoadCombo(cboContaBancaria, "sp_select_combo_cadastro_basico_banco_conta " & goUsuario.iEmpresa & ", " & -1 & ", 'D'", True)

            'Seta Controle
            dtpDataEmissaoInicioFiltro.Checked = False : dtpDataEmissaoInicioFiltro.Value = Now.Date
            dtpDataEmissaoTerminoFiltro.Checked = False : dtpDataEmissaoTerminoFiltro.Value = Now.Date
            dtpDataVencimentoInicioFiltro.Checked = False : dtpDataVencimentoInicioFiltro.Value = Now.Date
            dtpDataVencimentoTerminoFiltro.Checked = False : dtpDataVencimentoTerminoFiltro.Value = Now.Date
            dtpDataPagamentoInicioFiltro.Checked = False : dtpDataPagamentoInicioFiltro.Value = Now.Date
            dtpDataPagamentoTerminoFiltro.Checked = False : dtpDataPagamentoTerminoFiltro.Value = Now.Date
            dtpDataVencimento.Checked = False : dtpDataVencimento.Value = Now.Date
            dtpDataVencimento.Checked = False : dtpDataVencimento.Value = Now.Date

            'Configura Grid
            Call ConfiguraGrid(grdListagem, iFormulario)
            Call ConfiguraGrid(grdClassificacao, iFormulario)

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
            oClsFinDespesaAdiantamento.LoadGrid(grdListagem,
                                              txtNumeroDocumentoFiltro.Text.Trim,
                                              txtSerieFiltro.Text.Trim,
                                              txtFornecedorFiltro.Text.Trim,
                                              IIf(cboStatusFiltro.SelectedIndex = -1, -1, cboStatusFiltro.SelectedValue),
                                              IIf(dtpDataEmissaoInicioFiltro.Checked = False, "", dtpDataEmissaoInicioFiltro.Value),
                                              IIf(dtpDataEmissaoTerminoFiltro.Checked = False, "", dtpDataEmissaoTerminoFiltro.Value),
                                              IIf(dtpDataVencimentoInicioFiltro.Checked = False, "", dtpDataVencimentoInicioFiltro.Value),
                                              IIf(dtpDataVencimentoTerminoFiltro.Checked = False, "", dtpDataVencimentoTerminoFiltro.Value),
                                              IIf(dtpDataPagamentoInicioFiltro.Checked = False, "", dtpDataPagamentoInicioFiltro.Value),
                                              IIf(dtpDataPagamentoTerminoFiltro.Checked = False, "", dtpDataPagamentoTerminoFiltro.Value),
                                              IIf(cboTipoTituloFinanceiroFiltro.SelectedIndex = -1, -1, cboTipoTituloFinanceiroFiltro.SelectedValue),
                                              IIf(txtValorFiltro.Value = 0, -1, txtValorFiltro.Value),
                                              IIf(cboContaBancariaFiltro.SelectedIndex = -1, -1, cboContaBancariaFiltro.SelectedValue),
                                              txtDescritivoFiltro.Text.Trim)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Delete()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRowLancamento(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsFinDespesaAdiantamento.Delete()
                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de selecionar um ou mais Registros
                MsgBox("Primeiramente Selecione um ou mais Registros Válidos." & vbCrLf & vbCrLf &
                       "** Registros com status: ABERTO." & vbCrLf &
                       "** Registros não vinculados a um Pedido de Compra / Entrada de NF.", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles - Dados Gerais
            txtNumeroDocumento.Text = ""
            btnSalvar.Tag = ""
            txtSerie.Text = ""
            cboFornecedor.SelectedIndex = IIf(cboFornecedor.Items.Count = 1, 0, -1)
            dtpDataEmissao.Value = Now.Date
            txtDescritivo.Text = ""
            dtpDataVencimento.Value = Now.Date
            txtValor.Value = 0
            cboContaBancaria.SelectedIndex = -1
            cboTipoDocumentoPagamento.SelectedIndex = -1

            'Limpa Controles - Classificação
            cboCentroGasto.SelectedIndex = -1
            cboContaContabil.SelectedIndex = -1
            txtValorClassificacao.Value = 0
            btnInserirClassificao.Tag = ""
            btnInserirClassificao.Enabled = True
            btnExcluirClassificacao.Enabled = True
            grdClassificacao.DataSource = Nothing
            grdClassificacao.AllowEdit = InheritableBoolean.True

            'Váriaveis Locais
            Dim dValorDevido As Double

            'Seta Valor Devido
            dValorDevido = 0
            If dValorDevido < 0 Then dValorDevido = 0


            'Limpa controles e groupbox
            cboContaBancaria.SelectedIndex = -1
            cboTipoDocumentoPagamento.SelectedIndex = -1

            If grpBoleto.Visible = True Then

                'Limpa Controles - Boleto
                dtpDataPagamentoBoleto.Value = Now.Date
                txtValorBoleto.Value = dValorDevido
                txtNumeroBoleto1.Text = ""
                txtNumeroBoleto2.Text = ""
                txtNumeroBoleto3.Text = ""
                txtNumeroBoleto4.Text = ""
                txtNumeroBoleto5.Text = ""
                txtNumeroBoleto6.Text = ""
                txtNumeroBoleto7.Text = ""
                txtNumeroBoleto8.Text = ""
                txtBancoBoleto.Text = ""
                'Seta Focu
                txtNumeroBoleto1.Focus()
                grpBoleto.Visible = False

            ElseIf grpCheque.Visible = True Then

                'Limpa Controles - Cheque
                dtpDataPagamentoCheque.Value = Now.Date
                txtValorCheque.Value = dValorDevido
                txtNumeroDocumentoCheque.Text = ""
                txtFavorecidoCheque.Text = ""
                cboPreDatadoCheque.SelectedValue = False
                cboPreDatadoCheque.SelectedValue = False
                lblDataCompensacaoCheque.Visible = False
                dtpDataCompensacaoCheque.Visible = False
                dtpDataCompensacaoCheque.Value = Now.Date
                'Seta Focu
                txtNumeroDocumentoCheque.Focus()
                grpCheque.Visible = False

            ElseIf grpCartaoCredito.Visible = True Then

                'Limpa Controles - Cartão de Crédito
                cboCartaoCredito.SelectedIndex = -1
                dtpDataPagamentoCartaoCredito.Value = Now.Date
                txtValorCartaoCredito.Value = dValorDevido
                txtNumeroParcelaCartaoCredito.Value = 1
                'Seta Focu
                cboCartaoCredito.Focus()
                grpCartaoCredito.Visible = False

            ElseIf grpChequeTerceiro.Visible = True Then

                'Limpa Controles - Cheque de Terceiro
                cboNumeroDocumentoChequeTerceiro.SelectedIndex = -1
                'Seta Focu
                cboNumeroDocumentoChequeTerceiro.Focus()
                grpChequeTerceiro.Visible = False

            ElseIf grpOutros.Visible = True Then

                'Limpa Controles - Outros
                dtpDataPagamentoOutros.Value = Now.Date
                txtValorOutros.Value = dValorDevido
                txtNumeroDocumentoOutros.Text = ""
                'Seta Focu
                txtNumeroDocumentoOutros.Focus()
                grpOutros.Visible = False

            ElseIf grpOutrosSimples.Visible = True Then

                'Limpa Controles - Outros Simples
                dtpDataPagamentoOutrosSimples.Value = Now.Date
                txtValorOutrosSimples.Value = dValorDevido
                'Seta Focu
                dtpDataPagamentoOutrosSimples.Focus()
                grpOutrosSimples.Visible = False

            ElseIf grpBoletoGuia.Visible = True Then
                dtpDataPagamentoBoletoGuia.Value = Now.Date
                txtValorBoletoGuia.Value = dValorDevido
                txtNumeroBoletoGuia1.Text = ""
                txtNumeroBoletoGuia2.Text = ""
                txtNumeroBoletoGuia3.Text = ""
                txtNumeroBoletoGuia4.Text = ""
                txtNumeroBoletoGuia5.Text = ""
                txtNumeroBoletoGuia6.Text = ""
                txtNumeroBoletoGuia7.Text = ""
                txtNumeroBoletoGuia8.Text = ""
                grpBoletoGuia.Visible = False

            End If

            'Habilita Controles
            btnSalvar.Enabled = VerificaDireito(iFormulario, gcInsert)

            'Alterna Aba
            tabDados.SelectedTab = pagDados

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsFinDespesaAdiantamento.CodigoDespesaCapa = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0)
            oClsFinDespesaAdiantamento.NumeroDocumento = txtNumeroDocumento.Text.Trim
            oClsFinDespesaAdiantamento.Serie = txtSerie.Text.Trim
            oClsFinDespesaAdiantamento.ParceiroNegocio = cboFornecedor.SelectedValue
            oClsFinDespesaAdiantamento.DataEmissao = dtpDataEmissao.Value
            oClsFinDespesaAdiantamento.TipoDocumento = TipoDocumentoFinanceiro.Adiantamento
            oClsFinDespesaAdiantamento.TipoTituloFinanceiro = TipoTituloFinanceiro.Real
            oClsFinDespesaAdiantamento.Moeda = 1
            oClsFinDespesaAdiantamento.FatorCambial = 1
            oClsFinDespesaAdiantamento.Descritivo = txtDescritivo.Text.Trim
            oClsFinDespesaAdiantamento.DataVencimento = dtpDataVencimento.Value
            oClsFinDespesaAdiantamento.Valor = txtValor.Value
            oClsFinDespesaAdiantamento.FormaPagamento = cboTipoDocumentoPagamento.SelectedValue
            oClsFinDespesaAdiantamento.NumeroParcela = 1
            oClsFinDespesaAdiantamento.IntervaloParcela = 0
            oClsFinDespesaAdiantamento.CodigoPedidoCompraAdiantamento = IIf(cboPedidoCompra.SelectedIndex = -1, -1, cboPedidoCompra.SelectedValue)

            'Verifica o Tipo de Operação
            If IsNumeric(btnSalvar.Tag) Then
                oClsFinDespesaAdiantamento.Update()
                oClsFinDespesaAdiantamento.DeleteParcela(btnSalvar.Tag)
                oClsFinDespesaAdiantamento.InsertParcelaAdiantamento()
                oClsFinDespesaAdiantamento.DeleteClassificacao(btnSalvar.Tag)
                oClsFinDespesaAdiantamento.InsertClassificacao(grdClassificacao)
                'Realiza o pagamento do Adiantamento
                PagarAdiantamento()
                btnSalvar.Enabled = False
                frmMain.Informacao(Mensagem.RegistroAlterado)

            Else
                oClsFinDespesaAdiantamento.Insert()
                oClsFinDespesaAdiantamento.InsertParcelaAdiantamento()
                oClsFinDespesaAdiantamento.InsertClassificacao(grdClassificacao)
                btnSalvar.Tag = oClsFinDespesaAdiantamento.CodigoDespesaCapa
                'Realiza o pagamento do Adiantamento
                PagarAdiantamento()
                btnSalvar.Enabled = False
                frmMain.Informacao(Mensagem.RegistroInserido)

            End If

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
            If VerificaDireito(Formulario.FinanceiroDespesaLancamento, gcUpdate) = True Then

                'Carrega Controles
                oClsFinDespesaAdiantamento.LoadControlesAdiantamento(grdListagem.CurrentRow.Cells.Item("codigo_titulo_capa").Value,
                                                                     txtNumeroDocumento,
                                                                     txtSerie,
                                                                     cboFornecedor,
                                                                     dtpDataEmissao,
                                                                     txtDescritivo,
                                                                     txtValor,
                                                                     cboPedidoCompra)

                btnSalvar.Tag = grdListagem.CurrentRow.Cells.Item("codigo_titulo_capa").Value

                'Carrega Grid de Classificação
                oClsFinDespesaAdiantamento.LoadGridClassificacao(grdClassificacao,
                                                               grdListagem.CurrentRow.Cells.Item("codigo_titulo_capa").Value)

                Call LoadGridArquivoBD(grdArquivo, "tb_fin_titulo_capa", grdListagem.CurrentRow.Cells.Item("codigo_titulo_capa").Value)

                'Desabilita Controles Caso não possa ser Editado o Registro
                If grdListagem.CurrentRow.Cells("status").Value = CInt(StatusTitulo.Aberto) Then
                    grdClassificacao.AllowEdit = InheritableBoolean.True
                    btnSalvar.Enabled = True
                    btnInserirClassificao.Enabled = True
                    btnExcluirClassificacao.Enabled = True
                Else
                    grdClassificacao.AllowEdit = InheritableBoolean.False
                    btnSalvar.Enabled = False
                    btnInserirClassificao.Enabled = False
                    btnExcluirClassificacao.Enabled = False
                End If

                'Alterna Aba
                tabMain.TabPages.Remove(pagListagem)
                tabMain.TabPages.Add(pagDespesa)
                tabDados.SelectedTab = pagDados

                'Seta Focu
                txtNumeroDocumento.Focus()

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

    Private Sub Historico()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriavel - Formulário
            Dim oForm As New frmFinTituloHistorico
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location
            'Seta Parâmetros
            oForm.Grid = grdListagem
            oForm.Tipo = "D"
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : DisableTabStop(oForm) : oForm.ShowDialog(Me)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Cancelar()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(iFormulario, gcAdministrator) = True Then

                'Verifica se foi selecionado algum registro válido
                If VerificaSelecaoRow(grdListagem, "status", StatusTitulo.Aberto) = True Then

                    'Váriavel - Formulário
                    Dim oForm As New frmFinTituloCancelar
                    oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location
                    'Abre Formulário
                    Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : DisableTabStop(oForm) : oForm.ShowDialog(Me)
                    'Carrega Grid
                    Call LoadGrid()

                Else
                    'Informa o Usuário da Necessidade de selecionar um ou mais Registros
                    frmMain.Informacao(Mensagem.ValidacaoSelecionar)
                End If

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAdministrador)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Ativar()

        Try

            'Verifica se o usuário tem direito de Administrador
            If VerificaDireito(iFormulario, gcAdministrator) = True Then

                'Verifica se foi selecionado algum registro válido
                If VerificaSelecaoRow(grdListagem, "status", StatusTitulo.Cancelado) = True Then

                    'Verifica se o Usuário deseja Retornar o Status do Orçamento
                    If MsgBox("Deseja tornar ativo os Registros Selecionados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                        'Váriaveis Locais
                        Dim oClsFinTituloCancelar As New clsFrmFinTituloCancelar

                        'Atualiza Status da Receita
                        oClsFinTituloCancelar.UpdateStatus("TÍTULO REATIVADO")

                        'Carrega a Grid
                        Call LoadGrid()

                    End If

                Else
                    'Informa o Usuário da Necessidade de selecionar um ou mais Registros
                    frmMain.Informacao(Mensagem.ValidacaoSelecionar)
                End If

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAdministrador)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Duplicar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(iFormulario, gcInsert) = True Then

                'Váriaveis - Formulário
                Dim oForm As New frmFinTituloDuplicar
                oForm.Tipo = "D"
                oForm.Grid = grdListagem
                Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : DisableTabStop(oForm) : oForm.ShowDialog(Me)

                'Carrega Grid
                Call LoadGrid()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoInserir)
            End If

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

            'Verifica se foi Preenchido o Campo - Número Documento
            If txtNumeroDocumento.Text.Trim = "" Then
                'Verifica se o Usuário quer que o Sistema gere o Número do Documento Automaticamente
                If MsgBox("Deseja que o Sistema gere o Número do Documento Automaticamente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then
                    txtNumeroDocumento.Text = oClsFinDespesaAdiantamento.GerarNumeroDocumentoAdiantamento
                End If
            End If

            Dim dDataPagamento As DateTime
            Select Case LoadFormTipoDocumentoPagamento(cboTipoDocumentoPagamento.SelectedValue,
                                                        "sp_select_static_form_tipo_documento_pagamento_receita")
                Case "grpBoleto"
                    dDataPagamento = dtpDataPagamentoBoleto.Value

                Case "grpOutros"
                    dDataPagamento = dtpDataPagamentoOutros.Value

                Case "grpSaldoFornecedor"
                    dDataPagamento = dtpDataPagamentoSaldoFornecedor.Value

                Case "grpOutrosSimples"
                    dDataPagamento = dtpDataPagamentoOutrosSimples.Value

                Case "grpCheque"
                    dDataPagamento = dtpDataPagamentoCheque.Value

                Case "grpCartaoCredito"
                    dDataPagamento = dtpDataPagamentoCartaoCredito.Value

                Case "grpChequeTerceiro"
                    dDataPagamento = dtpDataPagamentoChequeTerceiro.Value

                Case "grpBoletoGuia"
                    dDataPagamento = dtpDataPagamentoBoletoGuia.Value

            End Select

            'If oClsUsrFinBloqueioExtrato.VerificaBloqueio(dDataPagamento) = False Then
            '    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Data bloqueada, consulte o setor financeiro.")
            '    Exit Function
            'End If


            'Verifica se foi Preenchido o Campo - Número Documento
            If ValidaCampo(txtNumeroDocumento, lblNumeroDocumento, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Fornecedor
            If ValidaCampo(cboFornecedor, lblFornecedor) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Valor
            If ValidaCampo(txtValor, lblValor, TipoCampo.numero) = False Then
                Exit Function
            End If

            'Verifica se a Data de Emissão é do mês anterior
            If DateDiff(DateInterval.Month, dtpDataEmissao.Value, Now.Date) >= 1 Then
                If MsgBox("A Data de Emissão do Documento é diferente do mês corrente." & vbCrLf & "Essa data pode alterar o Fluxo de Caixa do mês anterior." & vbCrLf & vbCrLf & "Deseja prosseguir?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, Me.Parent.Text) = MsgBoxResult.No Then
                    dtpDataEmissao.Focus()
                    Exit Function
                End If
            End If

            'Verifica se o Código Banco ja foi cadastrado
            If oClsFinDespesaAdiantamento.ValidaDespesaCapa(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, 0),
                                                          txtNumeroDocumento.Text.Trim,
                                                          txtSerie.Text.Trim,
                                                          cboFornecedor.SelectedValue) = False Then
                frmMain.errInfo.SetError(lblNumeroDocumento, "Este N° Documento: " & txtNumeroDocumento.Text.Trim & IIf(txtSerie.Text.Trim = "", "", "/" & txtSerie.Text.Trim) & " já está associado a outro Registro.")
                txtNumeroDocumento.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Descritivo
            If ValidaCampo(txtDescritivo, lblDescritivo, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Fornecedor
            If ValidaCampo(cboContaBancaria, lblContaBancaria) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Tipo documento
            If ValidaCampo(cboTipoDocumentoPagamento, lblTipoDocumentoPagamento) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Pedido Compra
            If ValidaCampo(cboPedidoCompra, lblPedidoCompra) = False Then
                Exit Function
            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function VerificaSelecaoRowLancamento(ByVal oGrid As GridEX) As Boolean

        Try

            'Variáveis Loais
            Dim oCheckedRow() As Janus.Windows.GridEX.GridEXRow
            Dim oRow As Janus.Windows.GridEX.GridEXRow

            'Redimensiona Vetor
            ReDim gSelecaoRow(0)

            'Seta Retorno da Função
            VerificaSelecaoRowLancamento = False

            With oGrid

                'Verifica se foi selecionado algum registro para salvar
                If .GetCheckedRows.Length > 0 Then

                    'Recebendo o array de linhas selecionadas
                    oCheckedRow = .GetCheckedRows

                    'Varrendo os itens selecionados
                    For Each oRow In oCheckedRow


                        'Redimensiona Vetor caso necessário
                        If Not gSelecaoRow(UBound(gSelecaoRow)) Is Nothing Then
                            ReDim Preserve gSelecaoRow(UBound(gSelecaoRow) + 1)
                        End If

                        'Seta Retorno da Função
                        VerificaSelecaoRowLancamento = True

                        'Seta Valores
                        gSelecaoRow(UBound(gSelecaoRow)) = oRow



                    Next

                End If

            End With

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub ImprimirPedidoCompra(ByVal lCodigoTituloCapa As Long)

        Try

            'Verifica se o usuário tem direito de Imprimir
            If VerificaDireito(Formulario.ComprasPedido, gcPrint) = False Then
                frmMain.Informacao(Mensagem.DireitoImprimir)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis - Locais
            Dim sReport As String

            'Váriavel - Formulário
            Dim oForm As New frmRptSelecionar
            oForm.Tipo = "PEDIDO DE COMPRA FINANCEIRO"
            oForm.ShowDialog(Me)
            sReport = oForm.Relatorio

            'Verifica o Relatório
            If sReport = "" Then Exit Sub

            'Seta Váriavel
            sReport &= ".rpt"

            'Verifica se o Arquivo existe
            If System.IO.File.Exists(goCrystalReport.sPath & sReport) = False Then
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "O Relatório não foi encontrado, ou seu usuário não possui direito de Visualização pasta de Relatórios.")
                Exit Sub
            End If

            'Redimenciona Vetor
            ReDim goCrystalReport.sReportParameter(2)
            'Seta Parametros
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_titulo_capa"
            goCrystalReport.sReportParameter(1).sValue = lCodigoTituloCapa
            goCrystalReport.sReportParameter(2).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(2).sValue = goUsuario.iEmpresa
            goCrystalReport.sReport = goCrystalReport.sPath & sReport

            Dim oReport As New usrReport
            oReport.Dock = DockStyle.Fill

            'Abre Relatório
            frmMain.LoadPageReport("CMP000000001", "Pedido de Compra", oReport)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarParceiroNegocio()

        Try

            '        'Seta Cursor do Mouse
            '        Cursor.Current = Cursors.WaitCursor

            '        'Limpa Erro
            '        frmMain.errInfo.Clear()

            '        'Verifica se o usuário tem direito de alterar algum registro
            '        If VerificaDireito(Formulario.FinanceiroReceitaAdiantamento, gcUpdate) = True Then

            '            'Váriavel - Formulário
            '            Dim oForm As New frmFinEditarParceiroNegocio

            '            'Seta Parâmetros
            '            oForm.CodigoTituloCapa = grdListagem.CurrentRow.Cells.Item("codigo_titulo_capa").Value
            '            oForm.CNPJParceiroNegocioAntigo = grdListagem.CurrentRow.Cells.Item("CNPJ").Value
            '            oForm.Tipo = 0

            '            'Abre Formulário
            '            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            '            'Atualiza Grid
            '            Call LoadGrid()

            '        Else
            '            'Informa o Usuário que ele não tem Direito
            '            frmMain.Informacao(Mensagem.DireitoAlteracao)
            '        End If

            '        'Seta Cursor do Mouse
            '        Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: PARCELA :::"

    Private Sub EditarDuplicata()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(iFormulario, gcUpdate) = True Then

                'Verifica se a Duplicata já foi Baixada
                If grdListagem.CurrentRow.Cells.Item("valor_pago").Value = 0 Then

                    'Váriavel - Formulário
                    Dim oForm As New frmFinEditarDuplicata

                    'Seta Parâmetros
                    oForm.CodigoTituloCapa = grdListagem.CurrentRow.Cells.Item("codigo_titulo_capa").Value
                    oForm.NumeroParcela = grdListagem.CurrentRow.Cells.Item("numero_parcela").Text

                    'Abre Formulário
                    Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : DisableTabStop(oForm) : oForm.ShowDialog(Me)

                    'Atualiza Grid
                    Call LoadGrid()

                Else
                    'Informa o Usuário que ele não tem Direito
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
                End If

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub Pagar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se a Parcela já está paga
            If grdListagem.CurrentRow.Cells("valor_corrigido").Value > grdListagem.CurrentRow.Cells("valor_pago").Value Then

                If grdListagem.CurrentRow.Parent.Cells("tipo_titulo_financeiro").Value <> "PREVISTO" Then

                    'Verifica se o usuário tem direito de alterar algum registro
                    If VerificaDireito(Formulario.FinanceiroDespesaPagamento, gcInsert) = True Then

                        'Abre Formulário de Cadastro
                        Dim oForm As New frmCadBasico
                        oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location : oForm.Tamanho = True
                        oForm.UsrControl = "usrFinDespesaPagamento"
                        oForm.Titulo = "Financeiro - Despesa - Baixar Duplicatas"

                        'Variaveis Locais
                        Dim oDataSet As New DataSet
                        Dim oDataTable As New DataTable
                        Dim oDCNumeroDocumento As New DataColumn("numero_documento")
                        Dim oDCParcela As New DataColumn("parcela")
                        Dim oDCDescritivo As New DataColumn("descritivo")
                        Dim oDCDataVencimento As New DataColumn("data_vencimento")
                        Dim oDCValorTotal As New DataColumn("valor_total")
                        Dim oDCValorPago As New DataColumn("valor_pago")
                        Dim oDCJuros As New DataColumn("juros")
                        Dim oDCDesconto As New DataColumn("desconto")
                        Dim oDCValorDevido As New DataColumn("valor_devido")
                        Dim oDCCodigoTituloCapa As New DataColumn("codigo_titulo_capa")
                        Dim oDCNumeroParcela As New DataColumn("numero_parcela")

                        'Adiciona Tabela ao DataSet
                        oDataSet.Tables.Add(oDataTable)
                        'Adiciona Colunas ao DataTable
                        oDataTable.Columns.Add(oDCNumeroDocumento)
                        oDataTable.Columns.Add(oDCParcela)
                        oDataTable.Columns.Add(oDCDescritivo)
                        oDataTable.Columns.Add(oDCDataVencimento)
                        oDataTable.Columns.Add(oDCValorTotal)
                        oDataTable.Columns.Add(oDCValorPago)
                        oDataTable.Columns.Add(oDCJuros)
                        oDataTable.Columns.Add(oDCDesconto)
                        oDataTable.Columns.Add(oDCValorDevido)
                        oDataTable.Columns.Add(oDCCodigoTituloCapa)
                        oDataTable.Columns.Add(oDCNumeroParcela)
                        'Seta DataType
                        oDCDataVencimento.DataType = Now.Date.GetType
                        oDCValorTotal.DataType = 0.0.GetType
                        oDCValorPago.DataType = 0.0.GetType
                        oDCJuros.DataType = 0.0.GetType
                        oDCDesconto.DataType = 0.0.GetType
                        oDCValorDevido.DataType = 0.0.GetType

                        'Adiciona Linhas ao DataTable
                        Dim oDataRow As DataRow = oDataTable.NewRow
                        oDataRow("numero_documento") = grdListagem.CurrentRow.Parent.Cells("numero_documento").Value
                        oDataRow("parcela") = grdListagem.CurrentRow.Cells("parcela").Value
                        oDataRow("descritivo") = grdListagem.CurrentRow.Parent.Cells("descritivo").Value
                        oDataRow("data_vencimento") = grdListagem.CurrentRow.Cells("data_vencimento").Value
                        oDataRow("valor_total") = grdListagem.CurrentRow.Cells("valor_parcela").Value
                        oDataRow("valor_pago") = grdListagem.CurrentRow.Cells("valor_pago").Value
                        oDataRow("juros") = grdListagem.CurrentRow.Cells("juros").Value
                        oDataRow("desconto") = grdListagem.CurrentRow.Cells("desconto").Value
                        oDataRow("valor_devido") = grdListagem.CurrentRow.Cells("valor_corrigido").Value
                        oDataRow("codigo_titulo_capa") = grdListagem.CurrentRow.Cells("codigo_titulo_capa").Value
                        oDataRow("numero_parcela") = grdListagem.CurrentRow.Cells("numero_parcela").Value
                        oDataTable.Rows.Add(oDataRow)

                        'Seta Parâmetros
                        Dim oFormularioCadastroBasico(0) As FormularioCadastroBasico
                        oFormularioCadastroBasico(0).oValor = oDataSet : oFormularioCadastroBasico(0).sControle = "grdParcela"
                        oForm.CadastroBasico = oFormularioCadastroBasico

                        'Abre o Formulário
                        Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : DisableTabStop(oForm) : oForm.ShowDialog(Me)

                        'Carrega a Grid
                        Call LoadGrid()

                    Else
                        'Informa o Usuário que ele não tem Direito
                        frmMain.Informacao(Mensagem.DireitoInserir)
                    End If

                Else
                    'Informa o Usuário que ele não tem Direito
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
                End If

            Else
                'Informa o Usuário que esta parcela já se encontra Quitada
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub PagarAdiantamento()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Variaveis
            Dim iCodigoTipoDocumento As Integer = oClsFinDespesaAdiantamento.TipoDocumento

            'Instância
            Dim oClsFinDespesaPagamento As New clsUsrFinDespesaPagamento

            'Atualiza parcela do título Adiantamento para pago
            oClsFinDespesaPagamento.UpdateParcelaAdiantamento(btnSalvar.Tag,
                                                              dtpDataVencimento.Value,
                                                              txtValor.Text,
                                                              txtValor.Text)

            'Verifica se o tipo de documento é Adiantamento
            If iCodigoTipoDocumento <> TipoDocumentoFinanceiro.Adiantamento Then

                'Valida Dados do Formulário
                If ValidacaoPagamentoAdiantamento() = True Then

                    'Insere o Pagamento Adiantamento
                    Select Case LoadFormTipoDocumentoPagamento(cboTipoDocumentoPagamento.SelectedValue,
                                                               "sp_select_static_form_tipo_documento_pagamento_despesa")

                        Case "grpBoleto"
                            Call oClsFinDespesaPagamento.InsertPagamentoAdiantamento(cboContaBancaria.Text,
                                                 cboTipoDocumentoPagamento.Text,
                                                 txtNumeroBoleto.Text,
                                                 dtpDataPagamentoBoleto.Value,
                                                 txtValorBoleto.Value,
                                                 txtBancoBoleto.Text.Trim,
                                                 "",
                                                 -1,
                                                 "",
                                                 cboContaBancaria.SelectedValue,
                                                 cboTipoDocumentoPagamento.SelectedValue,
                                                 -1,
                                                 -1,
                                                 -1,
                                                 StatusDespesaPagamento.Quitado,
                                                 "",
                                                 -1,
                                                 -1,
                                                 btnSalvar.Tag)

                        Case "grpOutros"
                            Call oClsFinDespesaPagamento.InsertPagamentoAdiantamento(cboContaBancaria.Text,
                                                 cboTipoDocumentoPagamento.Text,
                                                 txtNumeroDocumentoOutros.Text.Trim,
                                                 dtpDataPagamentoOutros.Value,
                                                 txtValorOutros.Value,
                                                 "",
                                                 "",
                                                 -1,
                                                 "",
                                                 cboContaBancaria.SelectedValue,
                                                 cboTipoDocumentoPagamento.SelectedValue,
                                                 -1,
                                                 -1,
                                                 -1,
                                                 StatusDespesaPagamento.Quitado,
                                                 "",
                                                 -1,
                                                 -1,
                                                 btnSalvar.Tag)

                        Case "grpSaldoFornecedor"
                            Call oClsFinDespesaPagamento.InsertPagamentoAdiantamento(cboContaBancaria.Text,
                                                 cboTipoDocumentoPagamento.Text,
                                                 "",
                                                 dtpDataPagamentoSaldoFornecedor.Value,
                                                 txtValorSaldoFornecedor.Value,
                                                 "",
                                                 "",
                                                 -1,
                                                 "",
                                                 cboContaBancaria.SelectedValue,
                                                 cboTipoDocumentoPagamento.SelectedValue,
                                                 -1,
                                                 -1,
                                                 -1,
                                                 StatusDespesaPagamento.Quitado,
                                                 "",
                                                 -1,
                                                 -1,
                                                 btnSalvar.Tag)

                        Case "grpOutrosSimples"
                            Call oClsFinDespesaPagamento.InsertPagamentoAdiantamento(cboContaBancaria.Text,
                                                 cboTipoDocumentoPagamento.Text,
                                                 "",
                                                 dtpDataPagamentoOutrosSimples.Value,
                                                 txtValorOutrosSimples.Value,
                                                 "",
                                                 "",
                                                 -1,
                                                 "",
                                                 cboContaBancaria.SelectedValue,
                                                 cboTipoDocumentoPagamento.SelectedValue,
                                                 -1,
                                                 -1,
                                                 -1,
                                                 StatusDespesaPagamento.Quitado,
                                                 "",
                                                 -1,
                                                 -1,
                                                 btnSalvar.Tag)

                        Case "grpCheque"
                            Call oClsFinDespesaPagamento.InsertPagamentoAdiantamento(cboContaBancaria.Text,
                                                 cboTipoDocumentoPagamento.Text,
                                                 txtNumeroDocumentoCheque.Text.Trim,
                                                 dtpDataPagamentoCheque.Value,
                                                 txtValorCheque.Value,
                                                 "",
                                                 txtFavorecidoCheque.Text.Trim,
                                                 IIf(cboPreDatadoCheque.SelectedValue = True, 1, 0),
                                                 IIf(dtpDataCompensacaoCheque.Visible = True, dtpDataCompensacaoCheque.Value, ""),
                                                 cboContaBancaria.SelectedValue,
                                                 cboTipoDocumentoPagamento.SelectedValue,
                                                 -1,
                                                 -1,
                                                 -1,
                                                 StatusDespesaPagamento.ChequeNaoCompensado,
                                                 "",
                                                 -1,
                                                 -1,
                                                 btnSalvar.Tag)

                        Case "grpCartaoCredito"
                            Call oClsFinDespesaPagamento.InsertPagamentoAdiantamento(cboContaBancaria.Text,
                                                 cboTipoDocumentoPagamento.Text,
                                                 "",
                                                 dtpDataPagamentoCartaoCredito.Value,
                                                 txtValorCartaoCredito.Value,
                                                 "",
                                                 "",
                                                 -1,
                                                 "",
                                                 cboContaBancaria.SelectedValue,
                                                 cboTipoDocumentoPagamento.SelectedValue,
                                                 -1,
                                                 -1,
                                                 -1,
                                                 StatusDespesaPagamento.ChequeNaoCompensado,
                                                 "",
                                                 cboCartaoCredito.SelectedValue,
                                                 txtNumeroParcelaCartaoCredito.Value,
                                                 btnSalvar.Tag)

                        Case "grpChequeTerceiro"

                            Dim sCodigo() As String = cboNumeroDocumentoChequeTerceiro.SelectedValue.ToString.Split("|")

                            Call oClsFinDespesaPagamento.InsertPagamentoAdiantamento(cboContaBancaria.Text,
                                                 cboTipoDocumentoPagamento.Text,
                                                 cboNumeroDocumentoChequeTerceiro.Text.Trim,
                                                 dtpDataPagamentoChequeTerceiro.Value,
                                                 txtValorChequeTerceiro.Value,
                                                 txtBancoChequeTerceiro.Text.Trim,
                                                 "",
                                                 -1,
                                                 "",
                                                 cboContaBancaria.SelectedValue,
                                                 cboTipoDocumentoPagamento.SelectedValue,
                                                 sCodigo(0),
                                                 sCodigo(1),
                                                 sCodigo(2),
                                                 StatusDespesaPagamento.ChequeNaoCompensado,
                                                 "",
                                                 -1,
                                                 -1,
                                                 btnSalvar.Tag)

                        Case "grpBoletoGuia"
                            Call oClsFinDespesaPagamento.InsertPagamentoAdiantamento(cboContaBancaria.Text,
                                                 cboTipoDocumentoPagamento.Text,
                                                 txtNumeroBoletoGuia.Text,
                                                 dtpDataPagamentoBoletoGuia.Value,
                                                 txtValorBoletoGuia.Value,
                                                 "",
                                                 "",
                                                 -1,
                                                 "",
                                                 cboContaBancaria.SelectedValue,
                                                 cboTipoDocumentoPagamento.SelectedValue,
                                                 -1,
                                                 -1,
                                                 -1,
                                                 StatusDespesaPagamento.Quitado,
                                                 "",
                                                 -1,
                                                 -1,
                                                 btnSalvar.Tag)

                    End Select

                    'Prepara Formulário para Inserção de um Novo Registro
                    Call NovoPagamentoAdiantamento()

                End If
            End If

            'Valida Dados do Formulário
            If ValidacaoPagamentoAdiantamento() = True Then

                'Insere o Pagamento Adiantamento
                Select Case LoadFormTipoDocumentoPagamento(cboTipoDocumentoPagamento.SelectedValue,
                                                           "sp_select_static_form_tipo_documento_pagamento_despesa")

                    Case "grpBoleto"
                        'Insere Adiantamento
                        Call oClsFinDespesaPagamento.InsertLancamentoAdiantamento(cboFornecedor.SelectedValue,
                                                                                  cboContaBancaria.SelectedValue,
                                                                                  txtNumeroBoleto.Text,
                                                                                  txtValorBoleto.Value,
                                                                                  dtpDataPagamentoBoleto.Value,
                                                                                  btnSalvar.Tag)

                    Case "grpOutros"
                        'Insere Adiantamento
                        Call oClsFinDespesaPagamento.InsertLancamentoAdiantamento(cboFornecedor.SelectedValue,
                                                                                  cboContaBancaria.SelectedValue,
                                                                                  txtNumeroDocumentoOutros.Text.Trim,
                                                                                  txtValorOutros.Value,
                                                                                  dtpDataPagamentoOutros.Value,
                                                                                  btnSalvar.Tag)

                    Case "grpSaldoFornecedor"
                        'Insere Adiantamento
                        Call oClsFinDespesaPagamento.InsertLancamentoAdiantamento(cboFornecedor.SelectedValue,
                                                                                  cboContaBancaria.SelectedValue,
                                                                                  "",
                                                                                  txtValorSaldoFornecedor.Value,
                                                                                  dtpDataPagamentoSaldoFornecedor.Value,
                                                                                  btnSalvar.Tag)

                    Case "grpOutrosSimples"
                        'Insere Adiantamento
                        Call oClsFinDespesaPagamento.InsertLancamentoAdiantamento(cboFornecedor.SelectedValue,
                                                                                  cboContaBancaria.SelectedValue,
                                                                                  "",
                                                                                  txtValorOutrosSimples.Value,
                                                                                  dtpDataPagamentoOutrosSimples.Value,
                                                                                  btnSalvar.Tag)

                    Case "grpCheque"
                        'Insere Adiantamento
                        Call oClsFinDespesaPagamento.InsertLancamentoAdiantamento(cboFornecedor.SelectedValue,
                                                                                  cboContaBancaria.SelectedValue,
                                                                                  txtNumeroDocumentoCheque.Text.Trim,
                                                                                  txtValorCheque.Value,
                                                                                  dtpDataPagamentoCheque.Value,
                                                                                  btnSalvar.Tag)

                    Case "grpCartaoCredito"
                        'Insere Adiantamento
                        Call oClsFinDespesaPagamento.InsertLancamentoAdiantamento(cboFornecedor.SelectedValue,
                                                                                  cboContaBancaria.SelectedValue,
                                                                                  "",
                                                                                  txtValorCartaoCredito.Value,
                                                                                  dtpDataPagamentoCartaoCredito.Value,
                                                                                  btnSalvar.Tag)

                    Case "grpChequeTerceiro"

                        'Insere Adiantamento
                        Call oClsFinDespesaPagamento.InsertLancamentoAdiantamento(cboFornecedor.SelectedValue,
                                                                                  cboContaBancaria.SelectedValue,
                                                                                  cboNumeroDocumentoChequeTerceiro.Text.Trim,
                                                                                  txtValorChequeTerceiro.Value,
                                                                                  dtpDataPagamentoChequeTerceiro.Value,
                                                                                  btnSalvar.Tag)

                    Case "grpBoletoGuia"
                        'Insere Adiantamento
                        Call oClsFinDespesaPagamento.InsertLancamentoAdiantamento(cboFornecedor.SelectedValue,
                                                                                  cboContaBancaria.SelectedValue,
                                                                                  txtNumeroBoletoGuia.Text,
                                                                                  txtValorBoletoGuia.Value,
                                                                                  dtpDataPagamentoBoletoGuia.Value,
                                                                                  btnSalvar.Tag)

                End Select

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoPagamentoAdiantamento()

            End If


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoPagamentoAdiantamento() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoPagamentoAdiantamento = False

            'Verifica se foi Selecionado o Campo - Conta Bancária
            If ValidaCampo(cboContaBancaria, lblContaBancaria) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Tipo de Documento de Pagamento
            If ValidaCampo(cboTipoDocumentoPagamento, lblTipoDocumentoPagamento) = False Then
                Exit Function
            End If

            'Váriaveis Locais
            Dim dValorPagamento As Double = 0
            Dim dValorDevido As Double = txtValor.Text

            'Outros - Simples
            If grpOutrosSimples.Visible = True Then

                'Verifica se foi Preenchido o Campo - Valor
                If ValidaCampo(txtValorOutrosSimples, lblValorOutrosSimples, True) = False Then
                    Exit Function
                End If

                'Seta Valor Pagamento
                dValorPagamento = txtValorOutrosSimples.Value

            End If

            'Outros
            If grpOutros.Visible = True Then

                'Verifica se foi Preenchido o Campo - Número do Documento
                If ValidaCampo(txtNumeroDocumentoOutros, lblNumeroDocumentoOutros, TipoCampo.texto) = False Then
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - Valor
                If ValidaCampo(txtValorOutros, lblValorOutros, True) = False Then
                    Exit Function
                End If

                'Seta Valor Pagamento
                dValorPagamento = txtValorOutros.Value

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

                'Seta Valor Pagamento
                dValorPagamento = txtValorCheque.Value

            End If

            'Cartão de Credito
            If grpCartaoCredito.Visible = True Then

                'Verifica se foi Selecionado o Campo - Cartã de Crédito
                If ValidaCampo(cboCartaoCredito, lblCartaoCredito) = False Then
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - Número Parcela
                If ValidaCampo(txtNumeroParcelaCartaoCredito, lblNumeroParcelaCartaoCredito, True) = False Then
                    Exit Function
                End If

                'Seta Valor Pagamento
                dValorPagamento = txtValorCartaoCredito.Value

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

                'Seta Valor Pagamento
                dValorPagamento = txtValorChequeTerceiro.Value

            End If

            'Boleto Bancário
            If grpBoleto.Visible = True Then

                'Verifica se foi Preenchido o Campo - Boleto
                If ValidaCampo(txtNumeroBoleto, lblBancoBoleto, TipoCampo.numero) = False Then
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - Valor Boleto
                If ValidaCampo(txtValorBoleto, lblValorBoleto, True) = False Then
                    Exit Function
                End If

                'Seta Valor Pagamento
                dValorPagamento = txtValorBoleto.Value

            End If

            'Boleto Bancário
            If grpBoletoGuia.Visible = True Then

                'Verifica se foi Preenchido o Campo - Boleto Guia 
                If ValidaCampo(txtNumeroBoletoGuia, lblBancoBoletoGuia, TipoCampo.numero) = False Then
                    Exit Function
                End If

                'Verifica se foi Preenchido o Campo - Valor BoletoGuia
                If ValidaCampo(txtValorBoletoGuia, lblValorBoletoGuia, True) = False Then
                    Exit Function
                End If

                'Seta Valor Pagamento
                dValorPagamento = txtValorBoletoGuia.Value

            End If

            'Seta Retorno da Função
            ValidacaoPagamentoAdiantamento = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub NovoPagamentoAdiantamento()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Váriaveis Locais
            Dim dValorDevido As Double

            'Seta Valor Devido
            dValorDevido = 0
            If dValorDevido < 0 Then dValorDevido = 0


            'Limpa controles
            cboContaBancaria.SelectedIndex = -1
            cboTipoDocumentoPagamento.SelectedIndex = -1

            If grpBoleto.Visible = True Then

                'Limpa Controles - Boleto
                dtpDataPagamentoBoleto.Value = Now.Date
                txtValorBoleto.Value = dValorDevido
                txtNumeroBoleto.Text = ""
                'txtNumeroBoleto1.Text = ""
                'txtNumeroBoleto2.Text = ""
                'txtNumeroBoleto3.Text = ""
                'txtNumeroBoleto4.Text = ""
                'txtNumeroBoleto5.Text = ""
                'txtNumeroBoleto6.Text = ""
                'txtNumeroBoleto7.Text = ""
                'txtNumeroBoleto8.Text = ""
                txtBancoBoleto.Text = ""
                'Seta Focu
                txtNumeroBoleto.Focus()

            ElseIf grpCheque.Visible = True Then

                'Limpa Controles - Cheque
                dtpDataPagamentoCheque.Value = Now.Date
                txtValorCheque.Value = dValorDevido
                txtNumeroDocumentoCheque.Text = ""
                txtFavorecidoCheque.Text = ""
                cboPreDatadoCheque.SelectedValue = False
                cboPreDatadoCheque.SelectedValue = False
                lblDataCompensacaoCheque.Visible = False
                dtpDataCompensacaoCheque.Visible = False
                dtpDataCompensacaoCheque.Value = Now.Date
                'Seta Focu
                txtNumeroDocumentoCheque.Focus()

            ElseIf grpCartaoCredito.Visible = True Then

                'Limpa Controles - Cartão de Crédito
                cboCartaoCredito.SelectedIndex = -1
                dtpDataPagamentoCartaoCredito.Value = Now.Date
                txtValorCartaoCredito.Value = dValorDevido
                txtNumeroParcelaCartaoCredito.Value = 1
                'Seta Focu
                cboCartaoCredito.Focus()

            ElseIf grpChequeTerceiro.Visible = True Then

                'Limpa Controles - Cheque de Terceiro
                cboNumeroDocumentoChequeTerceiro.SelectedIndex = -1
                'Seta Focu
                cboNumeroDocumentoChequeTerceiro.Focus()

            ElseIf grpOutros.Visible = True Then

                'Limpa Controles - Outros
                dtpDataPagamentoOutros.Value = Now.Date
                txtValorOutros.Value = dValorDevido
                txtNumeroDocumentoOutros.Text = ""
                'Seta Focu
                txtNumeroDocumentoOutros.Focus()

            ElseIf grpOutrosSimples.Visible = True Then

                'Limpa Controles - Outros Simples
                dtpDataPagamentoOutrosSimples.Value = Now.Date
                txtValorOutrosSimples.Value = dValorDevido
                'Seta Focu
                dtpDataPagamentoOutrosSimples.Focus()

            ElseIf grpBoletoGuia.Visible = True Then
                dtpDataPagamentoBoletoGuia.Value = Now.Date
                txtValorBoletoGuia.Value = dValorDevido
                txtNumeroBoletoGuia.Text = ""
                'txtNumeroBoletoGuia1.Text = ""
                'txtNumeroBoletoGuia2.Text = ""
                'txtNumeroBoletoGuia3.Text = ""
                'txtNumeroBoletoGuia4.Text = ""
                'txtNumeroBoletoGuia5.Text = ""
                'txtNumeroBoletoGuia6.Text = ""
                'txtNumeroBoletoGuia7.Text = ""
                'txtNumeroBoletoGuia8.Text = ""

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CancelarPagamento()

        Try

            'Verifica se a Parcela já está paga
            If grdListagem.CurrentRow.Cells("valor_pago").Value > 0 Then

                'Verifica se o usuário tem direito de alterar algum registro
                If VerificaDireito(Formulario.FinanceiroDespesaPagamento, gcAdministrator) = True Then

                    'Verifica se o Usuário deseja Cancelar o Pagamento
                    If MsgBox("Deseja realmente Cancelar o Pagamento dessa Parcela?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                        'Váriavel - Classe
                        Dim oClsFinDespesaCancelarPagamento As New clsUsrFinDespesaCancelarPagamento

                        'Cancela o Pagamento
                        oClsFinDespesaCancelarPagamento.CancelarPagamentoIndividual(grdListagem.CurrentRow.Cells("codigo_titulo_capa").Value,
                                                                                    grdListagem.CurrentRow.Cells("numero_parcela").Value)

                        'Carrega Grid
                        Call LoadGrid()

                    End If

                Else
                    'Informa o Usuário que ele não tem Direito
                    frmMain.Informacao(Mensagem.DireitoAdministrador)
                End If

            Else
                'Informa o Usuário que o Título não foi quitado
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DuplicarParcela()

        Try

            'Verifica se a Parcela está Paga
            If grdListagem.CurrentRow.Cells("valor_pago").Value > 0 Then
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Esta Parcela já se encontra Paga.")
                Exit Sub
            End If

            'Verifica se o Usuário possui direito para Duplicar a Parcela
            If VerificaDireito(iFormulario, gcUpdate) = False Then
                frmMain.Informacao(Mensagem.DireitoAlteracao)
                Exit Sub
            End If

            'Váriavel - Formulário
            Dim oForm As New frmFinTituloDuplicarParcela

            'Seta Parâmetros
            oForm.DataParcela = grdListagem.CurrentRow.Cells("data_vencimento").Value
            oForm.Parcela = grdListagem.CurrentRow.Cells("parcela").Value
            oForm.Descritivo = grdListagem.CurrentRow.Parent.Cells("descritivo").Value
            oForm.Valor = grdListagem.CurrentRow.Cells("valor_parcela").Value
            oForm.CodigoTituloCapa = grdListagem.CurrentRow.Cells("codigo_titulo_capa").Value
            oForm.NumeroParcela = grdListagem.CurrentRow.Cells("numero_parcela").Value

            'Abre Formulário
            oForm.ShowDialog(Me)

            'Recarrega Grid
            Call LoadGrid()

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

                'Váriaveis - Update
                Dim iCodigoCentroGastoAntigo As Integer = -1
                Dim sCodigoContaContabilAntigo As String = ""

                'Carrega Váriaveis
                If IsNumeric(btnInserirClassificao.Tag) Then
                    iCodigoCentroGastoAntigo = IIf(IsDBNull(grdClassificacao.CurrentRow.Cells("codigo_centro_custo").Value), -1, grdClassificacao.CurrentRow.Cells("codigo_centro_custo").Value)
                    sCodigoContaContabilAntigo = IIf(IsDBNull(grdClassificacao.CurrentRow.Cells("codigo_conta_contabil").Value), "", grdClassificacao.CurrentRow.Cells("codigo_conta_contabil").Value)
                End If

                'Insere Registro na Grid
                oClsFinDespesaAdiantamento.InsertClassificacaoGrid(grdClassificacao,
                                                                 IIf(cboCentroGasto.SelectedIndex = -1, "", cboCentroGasto.Text),
                                                                 IIf(cboContaContabil.SelectedIndex = -1, "", cboContaContabil.Text),
                                                                 txtValorClassificacao.Value,
                                                                 IIf(cboCentroGasto.SelectedIndex = -1, -1, cboCentroGasto.SelectedValue),
                                                                 IIf(cboContaContabil.SelectedIndex = -1, "", cboContaContabil.SelectedValue),
                                                                 IIf(IsNumeric(btnInserirClassificao.Tag), "U", "I"),
                                                                 iCodigoCentroGastoAntigo,
                                                                 sCodigoContaContabilAntigo)

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
            If VerificaDireito(iFormulario, gcUpdate) = True Then

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
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Dim i As Integer

                    For i = 0 To UBound(gSelecaoRow)
                        gSelecaoRow(i).Delete()
                    Next

                    'Limpa Formulário
                    Call NovoClassificacao()

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

            'Seta Retorno da Função
            ValidacaoClassificacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: ARQUIVO :::"

    Private Sub DeleteArquivo()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdArquivo) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    For Each oRow As GridEXRow In gSelecaoRow
                        modFunction.DeleteArquivoBD("tb_cad_item", oRow.Cells("path").Value, btnSalvar.Tag)
                        oRow.Delete()
                    Next

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário sobre a necessidade de Selecionar um ou mais Itenss
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EditarArquivo()

        Try

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.CadastroBasicoProduto, gcUpdate) = True Then

                'Limpa Formulário
                Call NovoArquivo()

                'Carrega Controles
                txtDescricaoArquivo.Text = grdArquivo.CurrentRow.Cells("descricao").Value
                txtRevisaoArquivo.Text = grdArquivo.CurrentRow.Cells("revisao").Value
                cboTipoArquivo.SelectedValue = grdArquivo.CurrentRow.Cells("codigo_tipo_arquivo").Value
                txtArquivo.Text = ""
                btnInserirArquivo.Tag = grdArquivo.CurrentRow.RowIndex

                'Seta Focu
                cboTipoArquivo.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub NovoArquivo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles            
            txtDescricaoArquivo.Text = ""
            txtRevisaoArquivo.Text = ""
            cboTipoArquivo.SelectedIndex = -1
            txtArquivo.Text = ""
            btnInserirArquivo.Tag = ""

            'Seta Focu
            txtDescricaoArquivo.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoArquivo() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoArquivo = False

            'Verifica se foi Preenchido o Campo - Descrição
            If ValidaCampo(txtDescricaoArquivo, lblDescricaoArquivo, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Revisão
            If ValidaCampo(txtRevisaoArquivo, lblRevisaoArquivo, TipoCampo.texto) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Tipo de Arquivo
            If ValidaCampo(cboTipoArquivo, lblTipoArquivo) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Arquivo
            If IsNumeric(btnInserirArquivo.Tag) = False Then
                If ValidaCampo(txtArquivo, lblArquivo, TipoCampo.texto) = False Then
                    Exit Function
                End If
            End If

            'Verifica se o Produto é Válido
            Dim iRow As Integer = -1

            If IsNumeric(btnInserirArquivo.Tag) Then
                iRow = grdArquivo.CurrentRow.RowIndex
            End If

            For Each oRow As GridEXRow In grdArquivo.GetDataRows
                If oRow.Cells("descricao").Value = txtDescricaoArquivo.Text.Trim And oRow.Cells("revisao").Value = txtRevisaoArquivo.Text.Trim And oRow.RowIndex <> iRow Then
                    frmMain.errInfo.SetError(lblDescricaoArquivo, "Esta Descrição / Revisão já se encontra associada a um Registro.")
                    txtDescricaoArquivo.Focus()
                    Return False
                End If
            Next

            'Seta Retorno da Função
            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

    Private Sub cboContaBancaria_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboContaBancaria.SelectedIndexChanged

        Try

            'Verifia se foi Selecionado Algum Registro
            If cboContaBancaria.Text = "" Then
                'Limpa Controles
                cboCartaoCredito.DataSource = Nothing : cboCartaoCredito.Text = ""
                cboTipoDocumentoPagamento.DataSource = Nothing : cboTipoDocumentoPagamento.Text = ""
            Else
                'Carrega Combo
                Call LoadCombo(cboCartaoCredito, "sp_select_combo_cadastro_basico_cartao_credito " & goUsuario.iEmpresa & ", " & cboContaBancaria.SelectedValue, False)
                Call LoadCombo(cboTipoDocumentoPagamento, "sp_select_combo_static_tipo_documento_pagamento 'D', " & cboContaBancaria.SelectedValue, True)

                'Habilita / Desabilita Controle
                cboTipoDocumentoPagamento.Enabled = IIf(cboTipoDocumentoPagamento.Items.Count = 1, False, True)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboTipoDocumentoPagamento_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboTipoDocumentoPagamento.SelectedIndexChanged

        Try

            'Oculta Controles
            grpBoleto.Visible = False
            grpCheque.Visible = False
            grpChequeTerceiro.Visible = False
            grpCartaoCredito.Visible = False
            grpOutros.Visible = False
            grpOutrosSimples.Visible = False
            grpBoletoGuia.Visible = False
            grpSaldoFornecedor.Visible = False

            'Váriaveis Locais
            Dim dValorDevido As Double

            'Seta Valor Devido
            dValorDevido = txtValor.Text
            If dValorDevido < 0 Then dValorDevido = 0

            'Carrega o Tipo de Documento de Pagamento
            If cboTipoDocumentoPagamento.SelectedIndex <> -1 Then

                'Torna Controle Visivel
                GetControlByName(LoadFormTipoDocumentoPagamento(cboTipoDocumentoPagamento.SelectedValue, "sp_select_static_form_tipo_documento_pagamento_despesa"), Me).Visible = True

                If grpBoleto.Visible = True Then
                    'Limpa Controles - Boleto
                    dtpDataPagamentoBoleto.Value = Now.Date
                    txtValorBoleto.Value = dValorDevido
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
                    txtValorCheque.Value = dValorDevido
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
                    txtValorOutros.Value = dValorDevido
                    txtNumeroDocumentoOutros.Text = ""
                ElseIf grpCartaoCredito.Visible = True Then
                    'Limpa Controles - Outros
                    dtpDataPagamentoCartaoCredito.Value = Now.Date
                    txtValorCartaoCredito.Value = dValorDevido
                    txtNumeroParcelaCartaoCredito.Value = 1
                ElseIf grpOutrosSimples.Visible = True Then
                    'Limpa Controles - Outros Simples
                    dtpDataPagamentoOutrosSimples.Value = Now.Date
                    txtValorOutrosSimples.Value = dValorDevido
                ElseIf grpBoletoGuia.Visible = True Then
                    dtpDataPagamentoBoletoGuia.Value = Now.Date
                    txtValorBoletoGuia.Value = dValorDevido
                ElseIf grpSaldoFornecedor.Visible = True Then
                    dtpDataPagamentoSaldoFornecedor.Value = Now.Date
                    txtValorSaldoFornecedor.Value = dValorDevido
                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub TratarBoletoBancario(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumeroBoleto.TextChanged,
                                                                                                  txtNumeroBoletoGuia.TextChanged


        'txtNumeroBoleto1.TextChanged,
        'txtNumeroBoleto2.TextChanged,
        'txtNumeroBoleto3.TextChanged,
        'txtNumeroBoleto4.TextChanged,
        'txtNumeroBoleto5.TextChanged,
        'txtNumeroBoleto6.TextChanged,
        'txtNumeroBoleto7.TextChanged,
        'txtNumeroBoleto8.TextChanged,
        'txtNumeroBoletoGuia1.TextChanged,
        'txtNumeroBoletoGuia2.TextChanged,
        'txtNumeroBoletoGuia3.TextChanged,
        'txtNumeroBoletoGuia4.TextChanged,
        'txtNumeroBoletoGuia5.TextChanged,
        'txtNumeroBoletoGuia6.TextChanged,
        'txtNumeroBoletoGuia7.TextChanged,
        'txtNumeroBoletoGuia8.TextChanged

        Try

            If sender.MaxLength = sender.Text.Length Then

                SendKeys.Send("{TAB}")

                If sender.Name = "txtNumeroBoleto" Then
                    dtpDataPagamentoBoleto.Value = DateAdd(DateInterval.Day, CLng(Mid(Microsoft.VisualBasic.Right(sender.text, 14), 1, 4)), gcDateInicioBoleto)
                    txtValorBoleto.Value = CDbl(Mid(Microsoft.VisualBasic.Right(sender.text, 14), 5)) / 100

                End If

                'If sender.Name = "txtNumeroBoleto8" Then
                '    dtpDataPagamentoBoleto.Value = DateAdd(DateInterval.Day, CLng(Mid(sender.text, 1, 4)), gcDateInicioBoleto)
                '    txtValorBoleto.Value = CDbl(Mid(sender.text, 5)) / 100
                'End If

                'If sender.Name = "txtNumeroBoletoGuia8" Then
                '    dtpDataPagamentoBoleto.Value = DateAdd(DateInterval.Day, CLng(Mid(sender.text, 1, 4)), gcDateInicioBoleto)
                '    txtValorBoletoGuia.Value = CDbl(Mid(sender.text, 5)) / 100
                'End If

            ElseIf sender.Name = "txtNumeroBoleto" Then
                If Microsoft.VisualBasic.Left(sender.text, 5).Length >= 3 Then
                    txtBancoBoleto.Text = LoadDadosBanco(Mid(Microsoft.VisualBasic.Left(sender.text, 5), 1, 3))
                End If
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

End Class

