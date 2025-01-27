Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Imports System.Math

Public Class usrVenAcordoComercial

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsVenAcordoComercial As New clsUsrVenAcordoComercial

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrVenAcordoComercial_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                    
                Case Keys.F3

                    Select Case sender.Name
                        Case "cboProduto" : Call btnProcurarProduto_Click(btnProcurarProduto, System.EventArgs.Empty)
                        Case "cboServico" : Call btnProcurarServico_Click(btnProcurarServico, System.EventArgs.Empty)
                        Case "cboCliente" : Call btnProcurarCliente_Click(btnProcurarCliente, System.EventArgs.Empty)
                        Case "cboClienteFiltro" : Call btnProcurarClienteFiltro_Click(btnProcurarClienteFiltro, System.EventArgs.Empty)
                        Case "cboAtivoFixo" : Call btnProcurarAtivoFixo_Click(btnProcurarAtivoFixo, System.EventArgs.Empty)
                    End Select

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboProduto" : Call LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_item_descricao " & goUsuario.iEmpresa & ", 1, NULL, " & CInt(TipoItem.produto).ToString, False)
                        Case "cboServico" : Call LoadCombo(cboServico, "sp_select_combo_cadastro_basico_item_descricao " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.servico).ToString, False)
                        Case "cboAtivoFixo" : LoadCombo(cboAtivoFixo, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.ativo).ToString)
                        Case "cboMoedaFiltro" : Call LoadCombo(cboMoedaFiltro, "sp_select_combo_cadastro_basico_moeda " & goUsuario.iEmpresa)
                        Case "cboMoeda" : Call LoadCombo(cboMoeda, "sp_select_combo_cadastro_basico_moeda " & goUsuario.iEmpresa)
                        Case "cboClienteFiltro" : Call LoadCombo(cboClienteFiltro, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa)
                        Case "cboCliente" : Call LoadCombo(cboCliente, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa)
                        Case "cboUnidadeMedidaProduto" : Call LoadCombo(cboUnidadeMedidaProduto, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)
                        Case "cboUnidadeMedidaServico" : Call LoadCombo(cboUnidadeMedidaServico, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)
                        Case "cboDespesa" : Call LoadCombo(cboDespesa, "sp_select_combo_cadastro_basico_despesa " & goUsuario.iEmpresa, False)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboProduto" : Call btnCadastrarProduto_Click(btnCadastrarProduto, System.EventArgs.Empty)
                        Case "cboServico" : Call btnCadastrarServico_Click(btnCadastrarServico, System.EventArgs.Empty)
                        Case "cboAtivoFixo" : Call btnCadastrarAtivoFixo_Click(btnCadastrarAtivoFixo, System.EventArgs.Empty)
                        Case "cboCliente" : Call btnCadastrarCliente_Click(btnCadastrarCliente, System.EventArgs.Empty)
                        Case "cboMoeda" : Call btnCadastrarMoeda_Click(btnCadastrarMoeda, System.EventArgs.Empty)
                        Case "cboUnidadeMedidaProduto" : Call btnCadastrarUnidadeMedidaProduto_Click(btnCadastrarUnidadeMedidaProduto, System.EventArgs.Empty)
                        Case "cboUnidadeMedidaServico" : Call btnCadastrarUnidadeMedidaServico_Click(btnCadastrarUnidadeMedidaServico, System.EventArgs.Empty)
                        Case "cboDespesa" : Call btnCadastrarDespesa_Click(btnCadastrarDespesa, System.EventArgs.Empty)
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrVenAcordoComercial_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: ACORDO COMERCIAL :::"

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
            oForm.NomeFormulario = Formulario.ComercialAcordoComercial
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ComercialAcordoComercial)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Planilha para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCadastrarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCliente.Click

        Try

             'Carrega o form de parceiro de negócio
            LoadUsrControlForm(Me, "usrCadParceiroNegocio")

            'Carrega Combo            
            Call LoadCombo(cboCliente, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa)

            'Seta Focu
            cboCliente.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarMoeda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarMoeda.Click

        Try

                'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadMoeda")

            'Carrega Combo            
            Call LoadCombo(cboMoeda, "sp_select_combo_cadastro_basico_moeda " & goUsuario.iEmpresa)

            'Seta Focu
            cboMoeda.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarClienteFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarClienteFiltro.Click

        Try
            
            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = TipoParceiroNegocio.cliente
            oComboBoxFind = cboClienteFiltro

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboClienteFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
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

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Carrega Dados da Grid
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Exclui Registros
            Call Delete()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click

        Try

            'Prepara Formulário
            Call Novo()

            'Alterna Aba
            tabMain.TabPages.Remove(pagListagem)
            tabMain.TabPages.Add(pagDados)

            'Seta Focu
            cboCliente.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Prepara Formulário para Inserção de um Novo Registro
            Call Novo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnEmail_Click(sender As Object, e As EventArgs) Handles btnEmail.Click

        Try

            'Verifica se já foi gerado o Acordo Comercial
            If txtNumeroAcordoComercial.Text.Trim <> "" Then

                'Prepara E-mail
                Call Email(btnSalvar.Tag, _
                           txtNumeroAcordoComercial.Text.Trim, _
                           IIf(cboCliente.SelectedIndex = -1, -1, cboCliente.SelectedValue))

            Else
                'Informa o Usuário que a Operação Não pode ser Realizada
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click

        Try

            'Verifica se já foi gerado o Acordo Comercial
            If txtNumeroAcordoComercial.Text.Trim <> "" Then

                'Imprimi
                Call Imprimir(btnSalvar.Tag)

            Else
                'Informa o Usuário que a Operação Não pode ser Realizada
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida dados do Formulário
            If Validacao() = True Then

                'Salva Registro
                Call Salvar()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        Try

            'Carrega Grid
            Call LoadGrid()

            'Alterna Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagListagem)

            'Seta Focu
            txtNumeroAcordoComercialFiltro.Focus()

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
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Linha é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            'Verifica a Coluna pressionada
            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Call Editar()
                Case "imprimir" : Call Imprimir(grdListagem.CurrentRow.Cells("codigo").Value)
                Case "email" : Call Email(grdListagem.CurrentRow.Cells("codigo").Value, _
                                          grdListagem.CurrentRow.Cells("numero_acordo_comercial").Value, _
                                          grdListagem.CurrentRow.Cells("codigo_cliente").Value)

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
                                     Formulario.ComercialAcordoComercial)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.ComercialAcordoComercial, _
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
                                          Formulario.ComercialAcordoComercial, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: PRODUTO :::"

    Private Sub btnAgruparGridProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridProduto.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdProduto.GroupByBoxVisible = True Then

                'Exclui Linhas do Grupo
                For Each oGroup As GridEXGroup In grdProduto.RootTable.Groups
                    grdProduto.RootTable.Groups.Remove(oGroup)
                Next

                'Oculta Grupo
                grdProduto.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdProduto.GroupByBoxVisible = True
                grdProduto.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridProduto.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdProduto
            oForm.NomeFormulario = Formulario.ComercialAcordoComercial
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdProduto, Formulario.ComercialAcordoComercial)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridProduto.Click

        Try

            'Exporta Planilha para Excel
            Call ExportExcel(grdProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCadastrarProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarProduto.Click

        Try

              'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadProduto")

            'Carrega Combo            
            Call LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_item_descricao " & goUsuario.iEmpresa & ", 1, NULL, " & CInt(TipoItem.produto).ToString)

            'Seta Focu
            cboProduto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarUnidadeMedidaProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarUnidadeMedidaProduto.Click

        Try

                'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadUnidadeMedida")

            'Carrega Combo            
            Call LoadCombo(cboUnidadeMedidaProduto, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)

            'Seta Focu
            cboUnidadeMedidaProduto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarProduto.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = TipoItem.produto
            sItemVendaFind = "S"
            oComboBoxFind = cboProduto

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboProduto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnInserirProduto_Click(sender As Object, e As EventArgs) Handles btnInserirProduto.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Produto
            If ValidacaoProduto() = True Then

                'Salva Dados do Produto
                Call SalvarProduto()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirProduto_Click(sender As Object, e As EventArgs) Handles btnExcluirProduto.Click

        Try

            'Exclui Produto
            Call DeleteProduto()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboProduto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProduto.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado algum Registro
            If cboProduto.SelectedIndex = -1 Then

                'Limpa Controles
                txtDescricaoProduto.Text = ""
                txtValorUnitarioProduto.Value = 0
                cboUnidadeMedidaProduto.SelectedIndex = -1

            Else

                'Váriaveis Locais
                Dim oClsCadProduto As New clsUsrCadProduto

                'Carrega Controles
                Call oClsCadProduto.LoadDadosProduto(cboProduto.SelectedValue, _
                                                     txtDescricaoProduto, _
                                                     cboUnidadeMedidaProduto, _
                                                     txtValorUnitarioProduto)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdProduto.RowDoubleClick

        Try

            'Verifica se a Linha é Válida
            If IsNothing(grdProduto.CurrentColumn) Then Exit Sub

            'Verifica a Coluna pressionada
            Select Case grdProduto.CurrentColumn.Key

                Case "editar" : Call EditarProduto()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdProduto.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdProduto, _
                                     Formulario.ComercialAcordoComercial)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdProduto.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdProduto.Name, _
                                     Formulario.ComercialAcordoComercial, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdProduto.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdProduto.Name, _
                                          Formulario.ComercialAcordoComercial, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CalculoPrecoVenda(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValorUnitarioProduto.ValueChanged, _
                                                                                               txtDescontoValorProduto.LostFocus, _
                                                                                               txtDescontoPercentualProduto.LostFocus, _
                                                                                               txtPrecoVendaProduto.LostFocus

        Try

            Select Case sender.Name

                Case "txtDescontoPercentualProduto"
                    If IsNumeric(txtDescontoPercentualProduto.Tag) Then
                        If Round(txtDescontoPercentualProduto.Tag, 5) = txtDescontoPercentualProduto.Value Then
                            txtPrecoVendaProduto.Value = txtValorUnitarioProduto.Value - (txtDescontoPercentualProduto.Tag * txtValorUnitarioProduto.Value / 100.0)
                        Else
                            txtPrecoVendaProduto.Value = txtValorUnitarioProduto.Value - (txtDescontoPercentualProduto.Value * txtValorUnitarioProduto.Value / 100.0)
                        End If
                    Else
                        txtPrecoVendaProduto.Value = txtValorUnitarioProduto.Value - (txtDescontoPercentualProduto.Value * txtValorUnitarioProduto.Value / 100.0)
                    End If
                    txtDescontoValorProduto.Value = txtValorUnitarioProduto.Value - txtPrecoVendaProduto.Value

                Case "txtDescontoValorProduto"
                    txtPrecoVendaProduto.Value = txtValorUnitarioProduto.Value - txtDescontoValorProduto.Value
                    txtDescontoPercentualProduto.Value = IIf(txtValorUnitarioProduto.Value = 0, 0, (1 - txtPrecoVendaProduto.Value / txtValorUnitarioProduto.Value) * 100)

                Case "txtPrecoVendaProduto"
                    If txtPrecoVendaProduto.Value < 0 Then
                        txtPrecoVendaProduto.Value = 0
                    End If
                    If txtPrecoVendaProduto.Value < txtValorUnitarioProduto.Value Then
                        txtDescontoPercentualProduto.Value = (1 - txtPrecoVendaProduto.Value / txtValorUnitarioProduto.Value) * 100
                        txtDescontoPercentualProduto.Tag = (1 - txtPrecoVendaProduto.Value / txtValorUnitarioProduto.Value) * 100
                        txtDescontoValorProduto.Value = txtValorUnitarioProduto.Value - txtPrecoVendaProduto.Value
                    Else
                        txtDescontoPercentualProduto.Value = 0
                        txtDescontoValorProduto.Value = 0
                    End If

                Case "txtValorUnitarioProduto"
                    If txtPrecoVendaProduto.Value = 0 Then
                        txtPrecoVendaProduto.Value = txtValorUnitarioProduto.Value
                        txtDescontoPercentualProduto.Value = 0
                        txtDescontoValorProduto.Value = 0
                    ElseIf txtDescontoPercentualProduto.Value = 0 Then
                        txtPrecoVendaProduto.Value = txtValorUnitarioProduto.Value
                    End If

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: SERVIÇO :::"

    Private Sub btnAgruparGridServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridServico.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdServico.GroupByBoxVisible = True Then

                'Exclui Linhas do Grupo
                For Each oGroup As GridEXGroup In grdServico.RootTable.Groups
                    grdServico.RootTable.Groups.Remove(oGroup)
                Next

                'Oculta Grupo
                grdServico.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdServico.GroupByBoxVisible = True
                grdServico.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridServico.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdServico
            oForm.NomeFormulario = Formulario.ComercialAcordoComercial
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdServico, Formulario.ComercialAcordoComercial)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridServico.Click

        Try

            'Exporta Planilha para Excel
            Call ExportExcel(grdServico)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCadastrarServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarServico.Click

        Try

               'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadServico")

            'Carrega Combo            
            Call LoadCombo(cboServico, "sp_select_combo_cadastro_basico_item_descricao " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.servico).ToString)

            'Seta Focu
            cboServico.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarUnidadeMedidaServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarUnidadeMedidaServico.Click

        Try

                'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadUnidadeMedida")

            'Carrega Combo            
            Call LoadCombo(cboUnidadeMedidaServico, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)

            'Seta Focu
            cboUnidadeMedidaServico.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarServico.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = TipoItem.produto
            sItemVendaFind = "S"
            oComboBoxFind = cboServico

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboServico.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnInserirServico_Click(sender As Object, e As EventArgs) Handles btnInserirServico.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Servico
            If ValidacaoServico() = True Then
                
                'Salva Dados do Serviço
                Call SalvarServico()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirServico_Click(sender As Object, e As EventArgs) Handles btnExcluirServico.Click

        Try

            'Exclui Servico
            Call DeleteServico()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboServico_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboServico.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado algum Registro
            If cboServico.SelectedIndex = -1 Then

                'Limpa Controles
                txtDescricaoServico.Text = ""
                txtValorServico.Value = 0

            Else

                'Váriaveis Locais
                Dim oClsCadProduto As New clsUsrCadProduto

                'Carrega Controles
                Call oClsCadProduto.LoadDadosProduto(cboServico.SelectedValue, _
                                                     txtDescricaoServico, _
                                                     txtValorServico)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdServico_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdServico.RowDoubleClick

        Try

            'Verifica se a Linha é Válida
            If IsNothing(grdServico.CurrentColumn) Then Exit Sub

            'Verifica a Coluna pressionada
            Select Case grdServico.CurrentColumn.Key

                Case "editar" : Call EditarServico()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdServico_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdServico.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdServico, _
                                     Formulario.ComercialAcordoComercial)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdServico_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdServico.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdServico.Name, _
                                     Formulario.ComercialAcordoComercial, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdServico_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdServico.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdServico.Name, _
                                          Formulario.ComercialAcordoComercial, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: LOCAÇÃO :::"

    Private Sub btnAgruparGridLocacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridLocacao.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdLocacao.GroupByBoxVisible = True Then

                'Exclui Linhas do Grupo
                For Each oGroup As GridEXGroup In grdLocacao.RootTable.Groups
                    grdLocacao.RootTable.Groups.Remove(oGroup)
                Next

                'Oculta Grupo
                grdLocacao.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdLocacao.GroupByBoxVisible = True
                grdLocacao.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridLocacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridLocacao.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdLocacao
            oForm.NomeFormulario = Formulario.ComercialAcordoComercial
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdLocacao, Formulario.ComercialAcordoComercial)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridLocacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridLocacao.Click

        Try

            'Exporta Planilha para Excel
            Call ExportExcel(grdLocacao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCadastrarAtivoFixo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarAtivoFixo.Click

        Try

              'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadProduto")

            'Carrega Combo            
            Call LoadCombo(cboAtivoFixo, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.ativo).ToString)

            'Seta Focu
            cboAtivoFixo.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarAtivoFixo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarAtivoFixo.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = TipoItem.produto
            sItemAtivoFixoFind = "S"
            oComboBoxFind = cboAtivoFixo

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboAtivoFixo.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub
    
    Private Sub btnInserirLocacao_Click(sender As Object, e As EventArgs) Handles btnInserirLocacao.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados da Locação
            If ValidacaoLocacao() = True Then

                'Salva Dados da Locação
                Call SalvarLocacao()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirLocacao_Click(sender As Object, e As EventArgs) Handles btnExcluirLocacao.Click

        Try

            'Exclui Locação
            Call DeleteLocacao()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboAtivoFixo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAtivoFixo.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado algum Registro
            If cboAtivoFixo.SelectedIndex = -1 Then

                'Limpa Controles
                txtDescricaoAtivoFixo.Text = ""

            Else

                'Váriaveis Locais
                Dim oClsCadProduto As New clsUsrCadProduto

                'Carrega Controles
                Call oClsCadProduto.LoadDadosProduto(cboAtivoFixo.SelectedValue, _
                                                     txtDescricaoAtivoFixo)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdLocacao_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdLocacao.RowDoubleClick

        Try

            'Verifica se a Linha é Válida
            If IsNothing(grdLocacao.CurrentColumn) Then Exit Sub

            'Verifica a Coluna pressionada
            Select Case grdLocacao.CurrentColumn.Key

                Case "editar" : Call EditarLocacao()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdLocacao_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdLocacao.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdLocacao, _
                                     Formulario.ComercialAcordoComercial)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdLocacao_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdLocacao.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdLocacao.Name, _
                                     Formulario.ComercialAcordoComercial, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdLocacao_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdLocacao.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdLocacao.Name, _
                                          Formulario.ComercialAcordoComercial, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: DESPESA :::"

    Private Sub btnAgruparGridDespesa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridDespesa.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdDespesa.GroupByBoxVisible = True Then

                'Exclui Linhas do Grupo
                For Each oGroup As GridEXGroup In grdDespesa.RootTable.Groups
                    grdDespesa.RootTable.Groups.Remove(oGroup)
                Next

                'Oculta Grupo
                grdDespesa.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdDespesa.GroupByBoxVisible = True
                grdDespesa.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridDespesa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridDespesa.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdDespesa
            oForm.NomeFormulario = Formulario.ComercialAcordoComercial
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdDespesa, Formulario.ComercialAcordoComercial)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridDespesa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridDespesa.Click

        Try

            'Exporta Planilha para Excel
            Call ExportExcel(grdDespesa)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCadastrarDespesa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarDespesa.Click

        Try

                'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadDespesa")

            'Carrega Combo            
            Call LoadCombo(cboDespesa, "sp_select_combo_cadastro_basico_despesa " & goUsuario.iEmpresa, False)

            'Seta Focu
            cboDespesa.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub
    
    Private Sub btnInserirDespesa_Click(sender As Object, e As EventArgs) Handles btnInserirDespesa.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados da Despesa
            If ValidacaoDespesa() = True Then

                'Salva Dados da Despesa
                Call SalvarDespesa()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirDespesa_Click(sender As Object, e As EventArgs) Handles btnExcluirDespesa.Click

        Try

            'Exclui Locação
            Call DeleteDespesa()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdDespesa_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdDespesa.RowDoubleClick

        Try

            'Verifica se a Linha é Válida
            If IsNothing(grdDespesa.CurrentColumn) Then Exit Sub

            'Verifica a Coluna pressionada
            Select Case grdDespesa.CurrentColumn.Key

                Case "editar" : Call EditarDespesa()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdDespesa_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdDespesa.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdDespesa, _
                                     Formulario.ComercialAcordoComercial)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdDespesa_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdDespesa.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdDespesa.Name, _
                                     Formulario.ComercialAcordoComercial, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdDespesa_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdDespesa.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdDespesa.Name, _
                                          Formulario.ComercialAcordoComercial, _
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
            oForm.NomeFormulario = Formulario.ComprasRequisicao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdArquivo, Formulario.ComprasRequisicao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridArquivo.Click

        Try

            'Exporta Planilha para Excel
            Call ExportExcel(grdArquivo)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCadastrarTipoArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarTipoArquivo.Click

        Try

                'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadTipoArquivo")

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

            'Valida Dados do Formulário
            If ValidacaoArquivo() = True Then

                If IsNumeric(btnInserirArquivo.Tag) = False Then

                    'Insere Arquivo
                    Call InsertArquivoBD("tb_ven_acordo_comercial", _
                                         txtDescricaoArquivo.Text.Trim, _
                                         txtRevisaoArquivo.Text.Trim, _
                                         txtArquivo.Text.Trim, _
                                         cboTipoArquivo.SelectedValue, _
                                         btnSalvar.Tag)

                Else

                    'Atualiza Arquivo
                    Call UpdateArquivoBD("tb_ven_acordo_comercial", _
                                         txtDescricaoArquivo.Text.Trim, _
                                         txtRevisaoArquivo.Text.Trim, _
                                         IIf(txtArquivo.Text.Trim = "", grdArquivo.CurrentRow.Cells("path").Value, txtArquivo.Text.Trim), _
                                         cboTipoArquivo.SelectedValue, _
                                         grdArquivo.CurrentRow.Cells("path").Value, _
                                         btnSalvar.Tag)

                End If

                'Carrega Grid
                Call LoadGridArquivoBD(grdArquivo, "tb_ven_acordo_comercial", btnSalvar.Tag)

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
                Case "visualizar" : Call VisualizarDocumentoBD(grdArquivo.CurrentRow.Cells("arquivo").Value, grdArquivo.CurrentRow.Cells("extensao").Value)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdArquivo.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdArquivo, _
                                     Formulario.ComprasRequisicao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdArquivo.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdArquivo.Name, _
                                     Formulario.ComprasRequisicao, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdArquivo_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdArquivo.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdArquivo.Name, _
                                          Formulario.ComprasRequisicao, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: LOCAÇÃO ::: "

#Region "::: GALPÃO ::: "

    Private Sub btnInserirDespesaGalpao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirDespesaGalpao.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se Existe Acordo
            If txtNumeroAcordoComercial.Text <> "" Then
                'Valida Dados da Despesa
                If ValidacaoDespesaGalpao() = True Then

                    'Salva Dados da Despesa
                    Call SalvarDespesaGalpão()

                End If

            Else

                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Primeiro salve o Acordo Comercial.")

            End If

            'Verifica se existe registro na grid de Despesa do Galpão
            Dim sTipo As String = ""
            sTipo = IIf(grdDespesaGalpao.GetDataRows.Count > 0, "I", "D")

            'Integração Financeiro - Despesa Galpão
            oClsVenAcordoComercial.IntegracaoFinanceiroDespesaGalpao(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1), _
                                                                     sTipo)

            'Verifica se Faz Integração Financeiro IPTU
            If cboIPTU.SelectedIndex <> -1 And chkGerarPrevisaoReembolsoIPTU.Checked = True Then

                'Integração Financeiro - IPTU
                oClsVenAcordoComercial.IntegracaoFinanceiroReembolsoIPTU(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1), _
                                                                         IIf(cboIPTU.SelectedIndex = -1, -1, cboIPTU.SelectedValue), _
                                                                         txtValorM2IPTU.Value, _
                                                                         txtValorTotalIPTU.Value, _
                                                                         txtDescontoIPTU.Value, _
                                                                         txtValorReembolsoIPTU.Value, _
                                                                         txtNumeroParcelaIPTU.Value, _
                                                                         "I")
            End If


        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluirDespesaGalpao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirDespesaGalpao.Click
        Try

            'Exclui Locação
            Call DeleteDespesaGalpao()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCliente.SelectedIndexChanged
        Try
            'Carrega Galpão
            Call LoadCombo(cboDadosAreaGalpao, "sp_select_combo_cadastro_basico_cliente_galpao " & cboCliente.SelectedValue & ", " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboDadosAreaCasa, "sp_select_combo_cadastro_basico_cliente_casa " & cboCliente.SelectedValue & ", " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboDadosAreaSala, "sp_select_combo_cadastro_basico_cliente_sala " & cboCliente.SelectedValue & ", " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboDadosAreaBox, "sp_select_combo_cadastro_basico_cliente_box " & cboCliente.SelectedValue & ", " & goUsuario.iEmpresa, False)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboDadosAreaGalpao_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDadosAreaGalpao.SelectedIndexChanged
        Try
            'Verifica se foi selecionado Galpão
            If cboDadosAreaGalpao.SelectedIndex = -1 Then

                'Limpa Controles
                txtDadosAreaAreaConstruidaLocada.Value = 0
                txtDadosAreaAreaPatioLocada.Value = 0
                txtDadosAreaValorAluguel.Value = 0
                dtpDadosAreaDataInicioVigenciaContrato.Value = Now.Date
                dtpDadosAreaDataTerminoVigenciaContrato.Value = Now.Date

            Else

                'Carrega dados do cadastro do Galpão
                oClsVenAcordoComercial.LoadDadosGalpao(IIf(cboDadosAreaGalpao.SelectedIndex = -1, -1, cboDadosAreaGalpao.SelectedValue), _
                                                   txtDadosAreaAreaConstruidaLocada, _
                                                   txtDadosAreaAreaPatioLocada, _
                                                   txtDadosAreaValorAluguel, _
                                                   dtpDadosAreaDataInicioVigenciaContrato, _
                                                   dtpDadosAreaDataTerminoVigenciaContrato)



            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdDespesaGalpao_RowDoubleClick(ByVal sender As Object, ByVal e As RowActionEventArgs) Handles grdDespesaGalpao.RowDoubleClick

        Try

            'Verifica se a Linha é Válida
            If IsNothing(grdDespesaGalpao.CurrentColumn) Then Exit Sub

            'Verifica a Coluna pressionada
            Select Case grdDespesaGalpao.CurrentColumn.Key

                Case "editar" : Call EditarDespesaGalpao()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: SALA COMERCIAL ::: "

    Private Sub btnInserirDespesaSala_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirDespesaSala.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se Existe Acordo
            If txtNumeroAcordoComercial.Text <> "" Then
                'Valida Dados da Despesa
                If ValidacaoDespesaSala() = True Then

                    'Salva Dados da Despesa
                    Call SalvarDespesaSala()

                End If

            Else

                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Primeiro salve o Acordo Comercial.")

            End If

            'Verifica se existe registro na grid de Despesa da Sala
            Dim sTipoSala As String = ""
            sTipoSala = IIf(grdDespesaSala.GetDataRows.Count > 0, "I", "D")

            'Integração Financeiro - Despesa Galpão
            oClsVenAcordoComercial.IntegracaoFinanceiroDespesaSala(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1), _
                                                                     sTipoSala)


        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluirDespesaSala_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirDespesaSala.Click
        Try

            'Exclui Locação
            Call DeleteDespesaSala()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
     
    Private Sub cboDadosAreaSala_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDadosAreaSala.SelectedIndexChanged
        Try
            'Verifica se foi selecionado Galpão
            If cboDadosAreaSala.SelectedIndex = -1 Then

                'Limpa Controles
                txtDadosAreaAreaConstruidaLocadaSala.Value = 0
                txtDadosAreaAreaTerrenoLocadaSala.Value = 0
                txtDadosAreaValorAluguelSala.Value = 0
                dtpDadosAreaDataInicioVigenciaContratoSala.Value = Now.Date
                dtpDadosAreaDataTerminoVigenciaContratoSala.Value = Now.Date

            Else

                'Carrega dados do cadastro do Galpão
                oClsVenAcordoComercial.LoadDadosSala(IIf(cboDadosAreaSala.SelectedIndex = -1, -1, cboDadosAreaSala.SelectedValue), _
                                                   txtDadosAreaAreaConstruidaLocadaSala, _
                                                   txtDadosAreaAreaTerrenoLocadaSala, _
                                                   txtDadosAreaValorAluguelSala, _
                                                   dtpDadosAreaDataInicioVigenciaContratoSala, _
                                                   dtpDadosAreaDataTerminoVigenciaContratoSala)



            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdDespesaSala_RowDoubleClick(ByVal sender As Object, ByVal e As RowActionEventArgs) Handles grdDespesaSala.RowDoubleClick

        Try

            'Verifica se a Linha é Válida
            If IsNothing(grdDespesaSala.CurrentColumn) Then Exit Sub

            'Verifica a Coluna pressionada
            Select Case grdDespesaSala.CurrentColumn.Key

                Case "editar" : Call EditarDespesaSala()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: BOX ::: "

    Private Sub btnInserirDespesaBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirDespesaBox.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se Existe Acordo
            If txtNumeroAcordoComercial.Text <> "" Then
                'Valida Dados da Despesa
                If ValidacaoDespesaBox() = True Then

                    'Salva Dados da Despesa
                    Call SalvarDespesaBox()

                End If

            Else

                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Primeiro salve o Acordo Comercial.")

            End If

            'Verifica se existe registro na grid de Despesa do Box
            Dim sTipoBox As String = ""
            sTipoBox = IIf(grdDespesaBox.GetDataRows.Count > 0, "I", "D")

            'Integração Financeiro - Despesa Galpão
            oClsVenAcordoComercial.IntegracaoFinanceiroDespesaBox(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1), _
                                                                     sTipoBox)


        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluirDespesaBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirDespesaBox.Click
        Try

            'Exclui Locação
            Call DeleteDespesaBox()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
     
    Private Sub cboDadosAreaBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDadosAreaBox.SelectedIndexChanged
        Try
            'Verifica se foi selecionado Galpão
            If cboDadosAreaBox.SelectedIndex = -1 Then

                'Limpa Controles
                txtDadosAreaAreaConstruidaLocadaBox.Value = 0
                txtDadosAreaAreaTerrenoLocadaBox.Value = 0
                txtDadosAreaValorAluguelBox.Value = 0
                dtpDadosAreaDataInicioVigenciaContratoBox.Value = Now.Date
                dtpDadosAreaDataTerminoVigenciaContratoBox.Value = Now.Date

            Else

                'Carrega dados do cadastro do Galpão
                oClsVenAcordoComercial.LoadDadosBox(IIf(cboDadosAreaBox.SelectedIndex = -1, -1, cboDadosAreaBox.SelectedValue), _
                                                   txtDadosAreaAreaConstruidaLocadaBox, _
                                                   txtDadosAreaAreaTerrenoLocadaBox, _
                                                   txtDadosAreaValorAluguelBox, _
                                                   dtpDadosAreaDataInicioVigenciaContratoBox, _
                                                   dtpDadosAreaDataTerminoVigenciaContratoBox)



            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdDespesaBox_RowDoubleClick(ByVal sender As Object, ByVal e As RowActionEventArgs) Handles grdDespesaBox.RowDoubleClick

        Try

            'Verifica se a Linha é Válida
            If IsNothing(grdDespesaBox.CurrentColumn) Then Exit Sub

            'Verifica a Coluna pressionada
            Select Case grdDespesaBox.CurrentColumn.Key

                Case "editar" : Call EditarDespesaBox()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: CASA ::: "

    Private Sub btnInserirDespesaCasa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirDespesaCasa.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se Existe Acordo
            If txtNumeroAcordoComercial.Text <> "" Then
                'Valida Dados da Despesa
                If ValidacaoDespesaCasa() = True Then

                    'Salva Dados da Despesa
                    Call SalvarDespesaCasa()

                End If

            Else

                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Primeiro salve o Acordo Comercial.")

            End If


            'Verifica se existe registro na grid de Despesa da Casa
            Dim sTipoCasa As String = ""
            sTipoCasa = IIf(grdDespesaCasa.GetDataRows.Count > 0, "I", "D")

            'Integração Financeiro - Despesa Galpão
            oClsVenAcordoComercial.IntegracaoFinanceiroDespesaCasa(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1), _
                                                                     sTipoCasa)

            'Verifica se Faz Integração Financeiro IPTU
            If cboIPTUCasa.SelectedIndex <> -1 And chkGerarPrevisaoReembolsoIPTUCasa.Checked = True Then

                'Integração Financeiro - IPTU
                oClsVenAcordoComercial.IntegracaoFinanceiroReembolsoIPTUCasa(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1), _
                                                                         IIf(cboIPTUCasa.SelectedIndex = -1, -1, cboIPTUCasa.SelectedValue), _
                                                                         txtValorM2IPTUCasa.Value, _
                                                                         txtValorTotalIPTUCasa.Value, _
                                                                         txtValorDescontoIPTUCasa.Value, _
                                                                         txtValorReembolsoIPTUCasa.Value, _
                                                                         txtNumeroParcelaIPTUCasa.Value, _
                                                                         "I")
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcluirDespesaCasa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirDespesaCasa.Click
        Try

            'Exclui Locação
            Call DeleteDespesaCasa()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
     
    Private Sub cboDadosAreaCasa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDadosAreaCasa.SelectedIndexChanged
        Try
            'Verifica se foi selecionado Galpão
            If cboDadosAreaCasa.SelectedIndex = -1 Then

                'Limpa Controles
                txtDadosAreaAreaConstruidaLocadaCasa.Value = 0
                txtDadosAreaAreaTerrenoLocada.Value = 0
                txtDadosAreaValorAluguelCasa.Value = 0
                dtpDadosAreaDataInicioVigenciaContratoCasa.Value = Now.Date
                dtpDadosAreaDataTerminoVigenciaContratoCasa.Value = Now.Date

            Else

                'Carrega dados do cadastro do Galpão
                oClsVenAcordoComercial.LoadDadosCasa(IIf(cboDadosAreaCasa.SelectedIndex = -1, -1, cboDadosAreaCasa.SelectedValue), _
                                                   txtDadosAreaAreaConstruidaLocadaCasa, _
                                                   txtDadosAreaAreaTerrenoLocada, _
                                                   txtDadosAreaValorAluguelCasa, _
                                                   dtpDadosAreaDataInicioVigenciaContratoCasa, _
                                                   dtpDadosAreaDataTerminoVigenciaContratoCasa)



            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdDespesaCasa_RowDoubleClick(ByVal sender As Object, ByVal e As RowActionEventArgs) Handles grdDespesaCasa.RowDoubleClick

        Try

            'Verifica se a Linha é Válida
            If IsNothing(grdDespesaCasa.CurrentColumn) Then Exit Sub

            'Verifica a Coluna pressionada
            Select Case grdDespesaCasa.CurrentColumn.Key

                Case "editar" : Call EditarDespesaCasa()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrVenAcordoComercial_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcluir.Enabled = VerificaDireito(Formulario.ComercialAcordoComercial, gcDelete)
            btnNovo1.Enabled = VerificaDireito(Formulario.ComercialAcordoComercial, gcInsert)
            btnImprimir.Enabled = VerificaDireito(Formulario.ComercialAcordoComercial, gcPrint)
            btnEmail.Enabled = VerificaDireito(Formulario.ComercialAcordoComercial, gcPrint)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.ComercialAcordoComercial, gcPrint)
            btnExcelGridProduto.Enabled = btnExcelGrid.Enabled
            btnExcelGridServico.Enabled = btnExcelGrid.Enabled
            btnExcelGridLocacao.Enabled = btnExcelGrid.Enabled
            btnExcelGridDespesa.Enabled = btnExcelGrid.Enabled
            btnExcelGridArquivo.Enabled = btnExcelGrid.Enabled

            'Verifica Direito - Botão Cadastrar
            btnCadastrarCliente.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcInsert)
            btnCadastrarMoeda.Enabled = VerificaDireito(Formulario.CadastroBasicoMoeda, gcInsert)
            btnCadastrarProduto.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcInsert)
            btnCadastrarUnidadeMedidaProduto.Enabled = VerificaDireito(Formulario.CadastroBasicoUnidadeMedida, gcInsert)
            btnCadastrarServico.Enabled = VerificaDireito(Formulario.CadastroBasicoServico, gcInsert)
            btnCadastrarUnidadeMedidaServico.Enabled = VerificaDireito(Formulario.CadastroBasicoUnidadeMedida, gcInsert)
            btnCadastrarAtivoFixo.Enabled = VerificaDireito(Formulario.CadastroBasicoProduto, gcInsert)
            btnCadastrarDespesa.Enabled = VerificaDireito(Formulario.CadastroBasicoDespesa, gcInsert)
            btnCadastrarTipoArquivo.Enabled = VerificaDireito(Formulario.CadastroBasicoTipoArquivo, gcInsert)

            'Carrega ComboBox
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboClienteFiltro : oComboBox(1) = cboCliente
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_cliente " & goUsuario.iEmpresa)
            oComboBox(0) = cboMoedaFiltro : oComboBox(1) = cboMoeda
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_moeda " & goUsuario.iEmpresa)
            Call LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", 1, NULL, " & CInt(TipoItem.produto).ToString, False)
            Call LoadCombo(cboServico, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.servico).ToString, False)
            Call LoadCombo(cboAtivoFixo, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & CInt(TipoItem.ativo).ToString, False)
            oComboBox(0) = cboUnidadeMedidaProduto : oComboBox(1) = cboUnidadeMedidaServico
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboDespesa, "sp_select_combo_cadastro_basico_despesa " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboTipoArquivo, "sp_select_combo_cadastro_basico_tipo_arquivo " & goUsuario.iEmpresa, False)
            oComboBox(0) = cboIPTU : oComboBox(1) = cboIPTUCasa
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_iptu " & goUsuario.iEmpresa, False)

            'Limpa Controles
            dtpDataInicioInicioFiltro.Value = Now.Date : dtpDataInicioInicioFiltro.Checked = False
            dtpDataInicioTerminoFiltro.Value = Now.Date : dtpDataInicioTerminoFiltro.Checked = False
            dtpDataValidadeInicioFiltro.Value = Now.Date : dtpDataValidadeInicioFiltro.Checked = False
            dtpDataValidadeTerminoFiltro.Value = Now.Date : dtpDataValidadeTerminoFiltro.Checked = False

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ComercialAcordoComercial)
            Call ConfiguraGrid(grdProduto, Formulario.ComercialAcordoComercial)
            Call ConfiguraGrid(grdServico, Formulario.ComercialAcordoComercial)
            Call ConfiguraGrid(grdLocacao, Formulario.ComercialAcordoComercial)
            Call ConfiguraGrid(grdDespesa, Formulario.ComercialAcordoComercial)
            Call ConfiguraGrid(grdArquivo, Formulario.ComercialAcordoComercial)

            'Desabilita Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            txtNumeroAcordoComercialFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: ACORDO COMERCIAL :::"

    Private Sub LoadGrid()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid
            oClsVenAcordoComercial.LoadGridAcordoComercial(grdListagem, _
                                                        txtNumeroAcordoComercialFiltro.Text.Trim, _
                                                        IIf(cboClienteFiltro.SelectedIndex = -1, -1, cboClienteFiltro.SelectedValue), _
                                                        IIf(cboMoedaFiltro.SelectedIndex = -1, -1, cboMoedaFiltro.SelectedValue), _
                                                        IIf(dtpDataInicioInicioFiltro.Checked = False, "", dtpDataInicioInicioFiltro.Value), _
                                                        IIf(dtpDataInicioTerminoFiltro.Checked = False, "", dtpDataInicioTerminoFiltro.Value), _
                                                        IIf(dtpDataValidadeInicioFiltro.Checked = False, "", dtpDataValidadeInicioFiltro.Value), _
                                                        IIf(dtpDataValidadeTerminoFiltro.Checked = False, "", dtpDataValidadeTerminoFiltro.Value))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Limpa Formulário - Acordo Comercial
            txtNumeroAcordoComercial.Text = ""
            cboCliente.SelectedIndex = -1
            dtpDataInicio.Value = Now.Date
            dtpDataValidade.Value = Now.Date : dtpDataValidade.Checked = False
            txtDescritivo.Text = ""
            txtObservacao.Text = ""
            btnSalvar.Tag = ""

            'Limpa Formulário - Produto
            cboProduto.SelectedIndex = -1
            txtLeadTimeProduto.Value = 0
            txtPercentualComissao.Value = 0
            txtQuantidadeMinimaProduto.Value = 0
            txtMultiploVenda.Value = 0
            cboUnidadeMedidaProduto.SelectedIndex = -1
            txtValorUnitarioProduto.Value = 0
            txtDescontoPercentualProduto.Value = 0
            txtDescontoValorProduto.Value = 0
            txtPrecoVendaProduto.Value = 0
            btnInserirProduto.Tag = ""
            grdProduto.DataSource = Nothing

            'Limpa Formulário - Servico
            cboServico.SelectedIndex = -1
            txtDescricaoServico.Text = ""
            txtQuantidadeMinimaServico.Value = 0
            cboUnidadeMedidaServico.SelectedIndex = -1
            txtValorServico.Value = 0
            txtAliquotaISSServico.Value = 0
            btnInserirServico.Tag = ""
            grdServico.DataSource = Nothing

            'Limpa Formulário - Locação
            cboAtivoFixo.SelectedIndex = -1
            txtDescricaoAtivoFixo.Text = ""
            txtQuantidadeMinimaAtivoFixo.Value = 0
            txtValorHoraLocacao.Value = 0
            chkLei10833Locacao.Checked = False
            txtAliquotaLei10833Locacao.Value = 0
            chkINSSLocacao.Checked = False
            txtAliquotaINSSLocacao.Value = 0
            chkISSLocacao.Checked = False
            txtAliquotaISSLocacao.Value = 0
            chkIRLocacao.Checked = False
            txtAliquotaIRLocacao.Value = 0
            btnInserirLocacao.Tag = ""
            grdLocacao.DataSource = Nothing

            'Limpa Formulário - Despesa
            cboDespesa.SelectedIndex = -1
            txtValorUnitarioDespesa.Value = 0
            btnInserirDespesa.Tag = ""
            grdDespesa.DataSource = Nothing

            'Limpa Formulário - Arquivo
            txtDescricaoArquivo.Text = ""
            txtRevisaoArquivo.Text = ""
            cboTipoArquivo.SelectedIndex = -1
            txtArquivo.Text = ""
            btnInserirArquivo.Tag = ""
            grdArquivo.DataSource = Nothing

            Call NovoDespesaGalpao()
            Call NovoDespesaCasa()
            Call NovoDespesaSala()
            Call NovoDespesaBox()

            grdDespesaCasa.DataSource = Nothing
            grdDespesaSala.DataSource = Nothing
            grdDespesaBox.DataSource = Nothing
            grdDespesaGalpao.DataSource = Nothing

            'Declara Váriavel
            Dim iCodigo As Integer = 0

            'Insere Acordo Comercial
            Call oClsVenAcordoComercial.InsertAcordoComercial(iCodigo)

            'Seta Controle
            btnSalvar.Tag = iCodigo

            'Seta Aba
            tabDados.SelectedTab = pagProduto

            'Seta Focu
            cboCliente.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar()

        Try

            'Verifica o Direito
            If VerificaDireito(Formulario.ComercialAcordoComercial, gcUpdate) = True Then

                'Prepara Formulário
                Call Novo()

                'Carrega Controles
                txtNumeroAcordoComercial.Text = grdListagem.CurrentRow.Cells("numero_acordo_comercial").Value
                cboCliente.SelectedValue = grdListagem.CurrentRow.Cells("codigo_cliente").Value
                cboMoeda.SelectedValue = grdListagem.CurrentRow.Cells("codigo_moeda").Value
                dtpDataInicio.Value = grdListagem.CurrentRow.Cells("data_inicio").Value
                txtDescritivo.Text = grdListagem.CurrentRow.Cells("descritivo").Value
                txtObservacao.Text = grdListagem.CurrentRow.Cells("observacao").Value
                If IsDBNull(grdListagem.CurrentRow.Cells("data_validade").Value) Then
                    dtpDataValidade.Value = Now.Date : dtpDataValidade.Checked = False
                Else
                    dtpDataValidade.Value = grdListagem.CurrentRow.Cells("data_validade").Value : dtpDataValidade.Checked = True
                End If
                btnSalvar.Tag = grdListagem.CurrentRow.Cells("codigo").Value

                'Carrega Grid
                Call oClsVenAcordoComercial.LoadGridProduto(grdProduto, grdListagem.CurrentRow.Cells("codigo").Value)
                Call oClsVenAcordoComercial.LoadGridServico(grdServico, grdListagem.CurrentRow.Cells("codigo").Value)
                Call oClsVenAcordoComercial.LoadGridLocacao(grdLocacao, grdListagem.CurrentRow.Cells("codigo").Value)
                Call oClsVenAcordoComercial.LoadGridDespesa(grdDespesa, grdListagem.CurrentRow.Cells("codigo").Value)
                Call oClsVenAcordoComercial.LoadGridDespesaGalpao(grdDespesaGalpao, grdListagem.CurrentRow.Cells("codigo").Value)
                Call LoadGridArquivoBD(grdArquivo, "tb_ven_acordo_comercial", grdListagem.CurrentRow.Cells("codigo").Value)

                'Seta Aba
                tabDados.SelectedTab = pagProduto

                'Alterna Aba
                tabMain.TabPages.Remove(pagListagem)
                tabMain.TabPages.Add(pagDados)

                'Seta Focu
                cboCliente.Focus()

                'Carrega a Grid
                Call oClsVenAcordoComercial.LoadGridDespesaGalpao(grdDespesaGalpao, btnSalvar.Tag)
                Call oClsVenAcordoComercial.LoadGridDespesaCasa(grdDespesaCasa, btnSalvar.Tag)
                Call oClsVenAcordoComercial.LoadGridDespesaSala(grdDespesaSala, btnSalvar.Tag)
                Call oClsVenAcordoComercial.LoadGridDespesaBox(grdDespesaBox, btnSalvar.Tag)

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parâmetros
            oClsVenAcordoComercial.CodigoCliente = cboCliente.SelectedValue
            oClsVenAcordoComercial.CodigoMoeda = cboMoeda.SelectedValue
            oClsVenAcordoComercial.DataInicio = dtpDataInicio.Value
            oClsVenAcordoComercial.DataValidade = IIf(dtpDataValidade.Checked = True, dtpDataValidade.Value, "")
            oClsVenAcordoComercial.Descritivo = txtDescritivo.Text.Trim
            oClsVenAcordoComercial.Observacao = txtObservacao.Text.Trim
            oClsVenAcordoComercial.Codigo = IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1)

            'Altera Registro
            oClsVenAcordoComercial.UpdateAcordoComercial()


            'Verifica se existe registro na grid de Despesa do Galpão
            Dim sTipo As String = ""
            sTipo = IIf(grdDespesaGalpao.GetDataRows.Count > 0, "I", "D")

            'Integração Financeiro - Despesa Galpão
            oClsVenAcordoComercial.IntegracaoFinanceiroDespesaGalpao(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1), _
                                                                     sTipo)

            'Verifica se Faz Integração Financeiro IPTU
            If cboIPTU.SelectedIndex <> -1 And chkGerarPrevisaoReembolsoIPTU.Checked = True Then

                'Integração Financeiro - IPTU
                oClsVenAcordoComercial.IntegracaoFinanceiroReembolsoIPTU(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1), _
                                                                         IIf(cboIPTU.SelectedIndex = -1, -1, cboIPTU.SelectedValue), _
                                                                         txtValorM2IPTU.Value, _
                                                                         txtValorTotalIPTU.Value, _
                                                                         txtDescontoIPTU.Value, _
                                                                         txtValorReembolsoIPTU.Value, _
                                                                         txtNumeroParcelaIPTU.Value, _
                                                                         "I")
            End If


            'Verifica se existe registro na grid de Despesa da Casa
            Dim sTipoCasa As String = ""
            sTipoCasa = IIf(grdDespesaCasa.GetDataRows.Count > 0, "I", "D")

            'Integração Financeiro - Despesa Galpão
            oClsVenAcordoComercial.IntegracaoFinanceiroDespesaCasa(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1), _
                                                                     sTipoCasa)

            'Verifica se Faz Integração Financeiro IPTU
            If cboIPTUCasa.SelectedIndex <> -1 And chkGerarPrevisaoReembolsoIPTUCasa.Checked = True Then

                'Integração Financeiro - IPTU
                oClsVenAcordoComercial.IntegracaoFinanceiroReembolsoIPTUCasa(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1), _
                                                                         IIf(cboIPTUCasa.SelectedIndex = -1, -1, cboIPTUCasa.SelectedValue), _
                                                                         txtValorM2IPTUCasa.Value, _
                                                                         txtValorTotalIPTUCasa.Value, _
                                                                         txtValorDescontoIPTUCasa.Value, _
                                                                         txtValorReembolsoIPTUCasa.Value, _
                                                                         txtNumeroParcelaIPTUCasa.Value, _
                                                                         "I")
            End If

            'Verifica se existe registro na grid de Despesa da Sala
            Dim sTipoSala As String = ""
            sTipoSala = IIf(grdDespesaSala.GetDataRows.Count > 0, "I", "D")

            'Integração Financeiro - Despesa Galpão
            oClsVenAcordoComercial.IntegracaoFinanceiroDespesaSala(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1), _
                                                                     sTipoSala)

            'Verifica se existe registro na grid de Despesa do Box
            Dim sTipoBox As String = ""
            sTipoBox = IIf(grdDespesaBox.GetDataRows.Count > 0, "I", "D")

            'Integração Financeiro - Despesa Galpão
            oClsVenAcordoComercial.IntegracaoFinanceiroDespesaBox(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1), _
                                                                     sTipoBox)


            'Seta Controles
            txtNumeroAcordoComercial.Text = oClsVenAcordoComercial.NumeroAcordoComercial

            'Informa o usuário sobre o sucesso da operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Delete()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & iif(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsVenAcordoComercial.DeleteAcordoComercial()

                    'Carrega Grid
                    Call LoadGrid()

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

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função 
            Validacao = False

            'Verifica se foi Selecionado o Campo - Cliente
            If ValidaCampo(cboCliente, lblCliente) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Moeda
            If ValidaCampo(cboMoeda, lblMoeda) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Data de Válidade
            If dtpDataValidade.Checked = True Then
                If dtpDataInicio.Value > dtpDataValidade.Value Then
                    frmMain.errInfo.SetError(lblDataValidade, "A Data de Validade não pode ser menor que a Data de Início.")
                    dtpDataValidade.Focus()
                    Exit Function
                End If
            End If

            'Váriaveis Locais
            Dim sMensagem As String = ""

            'Valida se o Período não interfere em outra Lista de Preço
            If oClsVenAcordoComercial.ValidaAcordoComercial(IIf(IsNumeric(btnSalvar.Tag), btnSalvar.Tag, -1), _
                                                         cboCliente.SelectedValue, _
                                                         dtpDataInicio.Value, _
                                                         IIf(dtpDataValidade.Checked = True, dtpDataValidade.Value, ""), _
                                                         sMensagem) = False Then
                'Verifica se o Usuário deseja continuar
                If MsgBox(sMensagem, MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.No Then
                    dtpDataValidade.Focus()
                    Exit Function
                End If
            End If

            'Verifica se foi Preenchido o Campo - Descritivo
            If ValidaCampo(txtDescritivo, lblDescritivo, TipoCampo.texto) = False Then
                Exit Function
            End If


            'Seta Retorno da Função 
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub Email(ByVal iCodigoAcordoComercial As Integer, _
                      ByVal sNumeroAcordoComercial As String, _
                      ByVal iCodigoCliente As Integer)

        Try

            'Verifica se o Usuário tem Direito
            If VerificaDireito(Formulario.ComercialAcordoComercial, gcPrint) = False Then
                'Informa o Usuário que ele não tem direito
                frmMain.Informacao(Mensagem.DireitoImprimir)
                Exit Sub
            End If

            'Váriaveis Locais
            Dim oRptDocument As New ReportDocument

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Dim sReport As String = "VEN000000015.rpt"

            'Abre Relatório
            oRptDocument.Load(goCrystalReport.sPath & sReport, _
                              CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)

            'Seta Parametros Relatório
            oRptDocument.SetParameterValue("@codigo_acordo_comercial", iCodigoAcordoComercial)
            oRptDocument.SetParameterValue("@codigo_empresa", goUsuario.iEmpresa)
            oRptDocument.SetParameterValue("usuario", goUsuario.sNome)

            'Abre Conexão com o Banco de Dados
            For i = 0 To oRptDocument.DataSourceConnections.Count - 1
                oRptDocument.DataSourceConnections.Item(i).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)
            Next

            'Váriaveis Locais
            Dim sArquivo As String = System.IO.Path.GetTempPath
            sArquivo &= "VEN000000015.pdf"

            'Verifica se o Arquivo Existe
            If File.Exists(sArquivo) Then File.Delete(sArquivo)

            'Exporta para Arquivo PDF
            oRptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, _
                                      sArquivo)

            'Limpa Váriavel
            oRptDocument = Nothing

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Enviar E-mail
            Call EnviarEmail(goUsuario.sEmpresa & " - Acordo Comercial: " & sNumeroAcordoComercial, _
                             "", _
                             sArquivo, _
                             sArquivo, _
                             "", _
                             iCodigoCliente)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Imprimir(ByVal iCodigoAcordoComercial As Integer)

        Try

            'Verifica se o Usuário tem Direito
            If VerificaDireito(Formulario.ComercialAcordoComercial, gcPrint) = False Then
                'Informa o Usuário que ele não tem direito
                frmMain.Informacao(Mensagem.DireitoImprimir)
                Exit Sub
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Dim sReport As String = "VEN000000015.rpt"

            'Redimenciona Vetor
            ReDim goCrystalReport.sReportParameter(2)
            'Seta Parametros
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_acordo_comercial"
            goCrystalReport.sReportParameter(1).sValue = iCodigoAcordoComercial
            goCrystalReport.sReportParameter(2).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(2).sValue = goUsuario.iEmpresa
            goCrystalReport.sReport = goCrystalReport.sPath & sReport

            Dim oReport As New usrReport
            oReport.Dock = DockStyle.Fill

            'Abre Relatório
            frmMain.LoadPageReport("VEN000000015", "Acordo Comercial", oReport)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: PRODUTO :::"

    Private Sub NovoProduto()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Formulário - Produto
            cboProduto.SelectedIndex = -1
            txtLeadTimeProduto.Value = 0
            txtPercentualComissao.Value = 0
            txtQuantidadeMinimaProduto.Value = 0
            txtMultiploVenda.Value = 0
            cboUnidadeMedidaProduto.SelectedIndex = -1
            txtValorUnitarioProduto.Value = 0
            txtDescontoPercentualProduto.Value = 0
            txtDescontoValorProduto.Value = 0
            txtPrecoVendaProduto.Value = 0
            btnInserirProduto.Tag = ""

            'Seta Focu
            cboProduto.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarProduto()

        Try

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirProduto.Tag) = False Then

                'Insere Produto
                Call oClsVenAcordoComercial.InsertProduto(btnSalvar.Tag, _
                                                          cboProduto.SelectedValue, _
                                                          txtLeadTimeProduto.Value, _
                                                          txtPercentualComissao.Value, _
                                                          txtQuantidadeMinimaProduto.Value, _
                                                          txtMultiploVenda.Value, _
                                                          cboUnidadeMedidaProduto.SelectedValue, _
                                                          txtValorUnitarioProduto.Value, _
                                                          txtPrecoVendaProduto.Value)

            Else

                'Altera Produto
                Call oClsVenAcordoComercial.UpdateProduto(btnSalvar.Tag, _
                                                          cboProduto.SelectedValue, _
                                                          txtLeadTimeProduto.Value, _
                                                          txtPercentualComissao.Value, _
                                                          txtQuantidadeMinimaProduto.Value, _
                                                          txtMultiploVenda.Value, _
                                                          cboUnidadeMedidaProduto.SelectedValue, _
                                                          txtValorUnitarioProduto.Value, _
                                                          txtPrecoVendaProduto.Value, _
                                                          grdProduto.CurrentRow.Cells("codigo").Value)

            End If

            'Carrega a Grid
            Call oClsVenAcordoComercial.LoadGridProduto(grdProduto, btnSalvar.Tag)

            'Limpa Formulário
            Call NovoProduto()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteProduto()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdProduto) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & iif(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Linha
                    Call oClsVenAcordoComercial.DeleteProduto(btnSalvar.Tag)

                    'Limpa Formulário
                    Call NovoProduto()

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

    Private Sub EditarProduto()

        Try

            'Verifica o Direito
            If VerificaDireito(Formulario.ComercialAcordoComercial, gcUpdate) = True Then

                'Carrega Controles
                With grdProduto.CurrentRow.Cells

                    cboProduto.SelectedValue = .Item("codigo_item").Value
                    txtLeadTimeProduto.Value = .Item("lead_time").Value
                    txtPercentualComissao.Value = .Item("percentual_comissao").Value
                    txtQuantidadeMinimaProduto.Value = .Item("quantidade_minima").Value
                    txtMultiploVenda.Value = .Item("multiplo_venda").Value
                    txtValorUnitarioProduto.Value = .Item("valor_unitario").Value
                    txtDescontoPercentualProduto.Value = .Item("desconto_unitario_percentual").Value
                    txtDescontoValorProduto.Value = .Item("desconto_unitario_valor").Value
                    txtPrecoVendaProduto.Value = .Item("preco_venda").Value
                    btnInserirProduto.Tag = .Item("codigo_item").Value

                    'Seta Focu
                    cboProduto.Focus()

                End With

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoProduto() As Boolean

        Try

            'Seta Retorno da Função 
            ValidacaoProduto = False

            'Verifica se foi Selecionado o Campo - Produto
            If ValidaCampo(cboProduto, lblProduto) = False Then
                Exit Function
            End If

            'Verifica se o Produto já está inserido na Grid
            Dim iRow As Integer = -1
            If IsNumeric(btnInserirProduto.Tag) Then iRow = grdProduto.CurrentRow.RowIndex
            If VerificaExisteValorGrid(grdProduto, "codigo_item", cboProduto.SelectedValue, iRow) = True Then
                frmMain.errInfo.SetError(lblProduto, "Este Produto: " & cboProduto.Text & " já se encontra cadastrado.")
                cboProduto.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Unidade de Medida
            If ValidaCampo(cboUnidadeMedidaProduto, lblUnidadeMedidaProduto) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Valor Unitário
            If ValidaCampo(txtValorUnitarioProduto, lblValorUnitarioProduto, True) = False Then
                Exit Function
            End If

            'Seta Retorno da Função 
            ValidacaoProduto = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: SERVIÇO :::"

    Private Sub NovoServico()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Formulário - Servico
            cboServico.SelectedIndex = -1
            txtDescricaoServico.Text = ""
            txtQuantidadeMinimaServico.Value = 0
            cboUnidadeMedidaServico.SelectedIndex = -1
            txtValorServico.Value = 0
            txtAliquotaISSServico.Value = 0
            btnInserirServico.Tag = ""

            'Seta Focu
            cboServico.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarServico()

        Try

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirServico.Tag) = False Then

                'Insere Serviço
                Call oClsVenAcordoComercial.InsertServico(btnSalvar.Tag, _
                                                          cboServico.SelectedValue, _
                                                          txtQuantidadeMinimaServico.Value, _
                                                          cboUnidadeMedidaServico.SelectedValue, _
                                                          txtValorServico.Value, _
                                                          chkISSServico.CheckState, _
                                                          txtAliquotaISSServico.Value)

            Else

                'Altera Serviço
                Call oClsVenAcordoComercial.UpdateServico(btnSalvar.Tag, _
                                                          grdServico.CurrentRow.Cells("codigo").Value, _
                                                          cboServico.SelectedValue, _
                                                          txtQuantidadeMinimaServico.Value, _
                                                          cboUnidadeMedidaServico.SelectedValue, _
                                                          txtValorServico.Value, _
                                                          chkISSServico.CheckState, _
                                                          txtAliquotaISSServico.Value)

            End If

            'Carrega a Grid
            Call oClsVenAcordoComercial.LoadGridServico(grdServico, btnSalvar.Tag)

            'Limpa Formulário
            Call NovoServico()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteServico()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdServico) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & iif(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Linha
                    Call oClsVenAcordoComercial.DeleteServico(btnSalvar.Tag)

                    'Limpa Formulário
                    Call NovoServico()

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

    Private Sub EditarServico()

        Try

            'Verifica o Direito
            If VerificaDireito(Formulario.ComercialAcordoComercial, gcUpdate) = True Then

                'Carrega Controles
                With grdServico.CurrentRow.Cells

                    cboServico.SelectedValue = .Item("codigo_item").Value
                    txtQuantidadeMinimaServico.Value = .Item("quantidade_minima").Value
                    cboUnidadeMedidaServico.SelectedValue = .Item("codigo_unidade_medida").Value
                    txtValorServico.Value = .Item("valor_unitario").Value
                    chkISSServico.Checked = .Item("iss_retido").Value
                    txtAliquotaISSServico.Value = .Item("aliquota_iss").Value
                    btnInserirServico.Tag = .Item("codigo_item").Value

                    'Seta Focu
                    cboServico.Focus()

                End With

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoServico() As Boolean

        Try

            'Seta Retorno da Função 
            ValidacaoServico = False

            'Verifica se foi Selecionado o Campo - Servico
            If ValidaCampo(cboServico, lblServico) = False Then
                Exit Function
            End If

            'Verifica se o Servico já está inserido na Grid
            Dim iRow As Integer = -1
            If IsNumeric(btnInserirServico.Tag) Then iRow = grdServico.CurrentRow.RowIndex
            If VerificaExisteValorGrid(grdServico, "codigo_item", cboServico.SelectedValue, iRow) = True Then
                frmMain.errInfo.SetError(lblServico, "Este Serviço: " & cboServico.Text & " já se encontra cadastrado.")
                cboServico.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Unidade de Medida
            If ValidaCampo(cboUnidadeMedidaServico, lblUnidadeMedidaServico) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Valor Unitário
            If ValidaCampo(txtValorServico, lblValorServico, True) = False Then
                Exit Function
            End If

            'Seta Retorno da Função 
            ValidacaoServico = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: LOCAÇÃO :::"

    Private Sub NovoLocacao()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Formulário - Servico
            cboAtivoFixo.SelectedIndex = -1
            txtDescricaoAtivoFixo.Text = ""
            txtQuantidadeMinimaAtivoFixo.Value = 0
            txtValorHoraLocacao.Value = 0
            txtAliquotaLei10833Locacao.Value = 0
            txtAliquotaINSSLocacao.Value = 0
            txtAliquotaISSLocacao.Value = 0
            txtAliquotaIRLocacao.Value = 0
            btnInserirLocacao.Tag = ""

            'Seta Focu
            cboAtivoFixo.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarLocacao()

        Try

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirLocacao.Tag) = False Then

                'Insere Serviço
                Call oClsVenAcordoComercial.InsertLocacao(btnSalvar.Tag, _
                                                          cboAtivoFixo.SelectedValue, _
                                                          txtQuantidadeMinimaAtivoFixo.Value, _
                                                          txtValorHoraLocacao.Value, _
                                                          chkLei10833Locacao.CheckState, _
                                                          txtAliquotaLei10833Locacao.Value, _
                                                          chkINSSLocacao.CheckState, _
                                                          txtAliquotaINSSLocacao.Value, _
                                                          chkISSLocacao.CheckState, _
                                                          txtAliquotaISSLocacao.Value, _
                                                          chkIRLocacao.CheckState, _
                                                          txtAliquotaIRLocacao.Value)

            Else

                'Altera Serviço
                Call oClsVenAcordoComercial.UpdateLocacao(btnSalvar.Tag, _
                                                          grdLocacao.CurrentRow.Cells("codigo").Value, _
                                                          cboAtivoFixo.SelectedValue, _
                                                          txtQuantidadeMinimaAtivoFixo.Value, _
                                                          txtValorHoraLocacao.Value, _
                                                          chkLei10833Locacao.CheckState, _
                                                          txtAliquotaLei10833Locacao.Value, _
                                                          chkINSSLocacao.CheckState, _
                                                          txtAliquotaINSSLocacao.Value, _
                                                          chkISSLocacao.CheckState, _
                                                          txtAliquotaISSLocacao.Value, _
                                                          chkIRLocacao.CheckState, _
                                                          txtAliquotaIRLocacao.Value)

            End If

            'Carrega a Grid
            Call oClsVenAcordoComercial.LoadGridLocacao(grdLocacao, btnSalvar.Tag)

            'Limpa Formulário
            Call NovoLocacao()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteLocacao()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdLocacao) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & iif(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Linha
                    Call oClsVenAcordoComercial.DeleteLocacao(btnSalvar.Tag)

                    'Limpa Formulário
                    Call NovoLocacao()

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

    Private Sub EditarLocacao()

        Try

            'Verifica o Direito
            If VerificaDireito(Formulario.ComercialAcordoComercial, gcUpdate) = True Then

                'Carrega Controles
                With grdLocacao.CurrentRow.Cells

                    cboAtivoFixo.SelectedValue = .Item("codigo_item").Value
                    txtQuantidadeMinimaAtivoFixo.Value = .Item("quantidade_minima").Value
                    txtValorHoraLocacao.Value = .Item("valor_unitario").Value
                    chkLei10833Locacao.Checked = .Item("lei_10833").Value
                    txtAliquotaLei10833Locacao.Value = .Item("aliquota_lei_10833").Value
                    chkINSSLocacao.Checked = .Item("inss").Value
                    txtAliquotaINSSLocacao.Value = .Item("aliquota_inss").Value
                    chkISSLocacao.Checked = .Item("iss_retido").Value
                    txtAliquotaISSLocacao.Value = .Item("aliquota_iss").Value
                    chkIRLocacao.Checked = .Item("ir").Value
                    txtAliquotaIRLocacao.Value = .Item("aliquota_ir").Value
                    btnInserirLocacao.Tag = .Item("codigo_item").Value

                    'Seta Focu
                    cboAtivoFixo.Focus()

                End With

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoLocacao() As Boolean

        Try

            'Seta Retorno da Função 
            ValidacaoLocacao = False

            'Verifica se foi Selecionado o Campo - Ativo Fixo
            If ValidaCampo(cboAtivoFixo, lblAtivoFixo) = False Then
                Exit Function
            End If

            'Verifica se o AtivoFixo já está inserido na Grid
            Dim iRow As Integer = -1
            If IsNumeric(btnInserirLocacao.Tag) Then iRow = grdLocacao.CurrentRow.RowIndex
            If VerificaExisteValorGrid(grdLocacao, "codigo_item", cboAtivoFixo.SelectedValue, iRow) = True Then
                frmMain.errInfo.SetError(lblAtivoFixo, "Este Ativo: " & cboAtivoFixo.Text & " já se encontra cadastrado.")
                cboAtivoFixo.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Valor Hora Locação
            If ValidaCampo(txtValorHoraLocacao, lblValorHoraLocacao, True) = False Then
                Exit Function
            End If

            'Seta Retorno da Função 
            ValidacaoLocacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: DESPESA :::"

    Private Sub NovoDespesa()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Formulário - Despesa
            cboDespesa.SelectedIndex = -1
            txtValorUnitarioDespesa.Value = 0
            btnInserirDespesa.Tag = ""

            'Seta Focu
            cboDespesa.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarDespesa()

        Try

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirDespesa.Tag) = False Then

                'Insere Despesa
                Call oClsVenAcordoComercial.InsertDespesa(btnSalvar.Tag, _
                                                          cboDespesa.SelectedValue, _
                                                          txtValorUnitarioDespesa.Value)

            Else

                'Altera Serviço
                Call oClsVenAcordoComercial.UpdateDespesa(btnSalvar.Tag, _
                                                          grdDespesa.CurrentRow.Cells("codigo").Value, _
                                                          cboDespesa.SelectedValue, _
                                                          txtValorUnitarioDespesa.Value)

            End If

            'Carrega a Grid
            Call oClsVenAcordoComercial.LoadGridDespesa(grdDespesa, btnSalvar.Tag)

            'Limpa Formulário
            Call NovoDespesa()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteDespesa()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdDespesa) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & iif(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Linha
                    Call oClsVenAcordoComercial.DeleteDespesa(btnSalvar.Tag)

                    'Limpa Formulário
                    Call NovoDespesa()

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

    Private Sub EditarDespesa()

        Try

            'Verifica o Direito
            If VerificaDireito(Formulario.ComercialAcordoComercial, gcUpdate) = True Then

                'Carrega Controles
                With grdDespesa.CurrentRow.Cells

                    cboDespesa.SelectedValue = .Item("codigo_despesa").Value
                    txtValorUnitarioDespesa.Value = .Item("valor_unitario").Value
                    btnInserirDespesa.Tag = .Item("codigo_despesa").Value

                    'Seta Focu
                    cboDespesa.Focus()

                End With

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoDespesa() As Boolean

        Try

            'Seta Retorno da Função 
            ValidacaoDespesa = False

            'Verifica se foi Selecionado o Campo - Despesa
            If ValidaCampo(cboDespesa, lblDespesa) = False Then
                Exit Function
            End If

            'Verifica se o AtivoFixo já está inserido na Grid
            Dim iRow As Integer = -1
            If IsNumeric(btnInserirDespesa.Tag) Then iRow = grdDespesa.CurrentRow.RowIndex
            If VerificaExisteValorGrid(grdDespesa, "codigo_despesa", cboAtivoFixo.SelectedValue, iRow) = True Then
                frmMain.errInfo.SetError(lblAtivoFixo, "Esta Despesa: " & cboDespesa.Text & " já se encontra cadastrado.")
                cboAtivoFixo.Focus()
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Valor Unitário
            If ValidaCampo(txtValorUnitarioDespesa, lblValorUnitarioDespesa, True) = False Then
                Exit Function
            End If

            'Seta Retorno da Função 
            ValidacaoDespesa = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region
     
#Region "::: LOCAÇÃO :::"

#Region "::: GALPÃO :::"

    Private Sub btnDadosAreaCadastrarGalpao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDadosAreaCadastrarGalpao.Click
        Try

            If ValidaCampo(cboCliente, lblCliente) = True Then

                'Abre Formulário de Cadastro
                Dim oForm As New frmCadBasico
                oForm.UsrControl = "usrCadGalpao"
                oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location : oForm.Tamanho = True
                oForm.Titulo = Me.Parent.Text
                Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                'Carrega Combo - Galpão
                Call LoadCombo(cboDadosAreaGalpao, "sp_select_combo_cadastro_basico_cliente_galpao " & cboCliente.SelectedValue & ", " & goUsuario.iEmpresa, False)


                'Seta Focu
                cboDadosAreaGalpao.Focus()

            Else

                Exit Sub

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub CalculoValorFinalParcela(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValorParcela.ValueChanged, _
                                                                                                      txtValorFinal.ValueChanged, _
                                                                                                      txtValorDesconto.ValueChanged



        Try

            'Valor Final da Parcela
            If txtValorParcela.Value > 0 Then

                txtValorFinal.Value = txtValorParcela.Value - txtValorDesconto.Value

            End If




        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub NovoDespesaGalpao()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Formulário - Despesa
            cboDadosAreaGalpao.SelectedIndex = -1
            cboIPTU.SelectedIndex = -1
            txtDadosAreaAreaConstruidaLocada.Value = 0
            txtDadosAreaAreaPatioLocada.Value = 0
            txtDadosAreaValorAluguel.Value = 0
            txtValorM2IPTU.Value = 0
            txtValorTotalIPTU.Value = 0
            txtValorDesconto.Value = 0
            txtValorFinal.Value = 0
            txtNumeroParcelaIPTU.Value = 0
            txtValorParcela.Value = 0
            txtNumeroParcelaFinal.Value = 0
            txtNumeroParcelaInicial.Value = 0
            txtValorFinal.Value = 0
            chkGerarPrevisaoReembolsoIPTU.Checked = False
            'grdDespesaGalpao.DataSource = Nothing

            txtNumeroParcelaInicial.Value = 0
            txtNumeroParcelaFinal.Value = 0
            btnInserirDespesaGalpao.Tag = ""


            'Seta Focu
            txtNumeroParcelaFinal.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarDespesaGalpão()

        Try

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirDespesaGalpao.Tag) = False Then

                'Insere Despesa
                Call oClsVenAcordoComercial.InsertDespesaGalpao(btnSalvar.Tag, _
                                                                cboDadosAreaGalpao.SelectedValue, _
                                                                txtNumeroParcelaInicial.Value, _
                                                                txtNumeroParcelaFinal.Value, _
                                                                txtValorParcela.Value, _
                                                                txtValorDesconto.Value, _
                                                                txtValorFinal.Value)

            Else

                'Altera Serviço
                Call oClsVenAcordoComercial.UpdateDespesaGalpao(btnSalvar.Tag, _
                                                                grdDespesaGalpao.CurrentRow.Cells("codigo").Value, _
                                                                grdDespesaGalpao.CurrentRow.Cells("codigo_galpao").Value, _
                                                                txtNumeroParcelaInicial.Value, _
                                                                txtNumeroParcelaFinal.Value, _
                                                                txtValorParcela.Value, _
                                                                txtValorDesconto.Value, _
                                                                txtValorFinal.Value)


            End If

            'Carrega a Grid
            Call oClsVenAcordoComercial.LoadGridDespesaGalpao(grdDespesaGalpao, btnSalvar.Tag)

            'Limpa Formulário
            Call NovoDespesaGalpao()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteDespesaGalpao()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdDespesaGalpao) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Linha
                    Call oClsVenAcordoComercial.DeleteDespesaGalpao(btnSalvar.Tag)

                    'Limpa Formulário
                    Call NovoDespesaGalpao()

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

    Private Sub EditarDespesaGalpao()

        Try

            'Verifica o Direito
            If VerificaDireito(Formulario.ComercialAcordoComercial, gcUpdate) = True Then

                'Carrega Controles
                With grdDespesaGalpao.CurrentRow.Cells

                    cboDadosAreaGalpao.SelectedValue = .Item("codigo_galpao").Value
                    txtNumeroParcelaInicial.Value = .Item("numero_parcela_inicial").Value
                    txtNumeroParcelaFinal.Value = .Item("numero_parcela_final").Value
                    txtValorParcela.Value = .Item("valor_parcela").Value
                    txtValorDesconto.Value = .Item("valor_desconto").Value
                    txtValorFinal.Value = .Item("valor_final").Value
                    btnInserirDespesaGalpao.Tag = .Item("codigo").Value

                    'Seta Focu
                    txtNumeroParcelaInicial.Focus()

                End With

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoDespesaGalpao() As Boolean

        Try

            'Seta Retorno da Função 
            ValidacaoDespesaGalpao = False

            'Verifica se foi Selecionado o Campo - Galpão
            If ValidaCampo(cboDadosAreaGalpao, lblDadosAreaGalpao) = False Then
                Exit Function
            End If


            'Verifica se foi Preenchido o Campo - Numero Parcela Inicial
            If ValidaCampo(txtNumeroParcelaInicial, lblNumeroParcelaInicial, True) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Numero Parcela Final
            If ValidaCampo(txtNumeroParcelaFinal, lblNumeroParcelaFinal, True) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Valor Parcela
            If ValidaCampo(txtValorParcela, lblValorParcela, True) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Valor Parcela
            If ValidaCampo(txtValorFinal, lblValorFinal, True) = False Then
                Exit Function
            End If

            'Seta Retorno da Função 
            ValidacaoDespesaGalpao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: SALA COMERCIAL :::"

    Private Sub btnDadosAreaCadastrarSala_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDadosAreaCadastrarSala.Click
        Try

            If ValidaCampo(cboCliente, lblCliente) = True Then

                'Abre Formulário de Cadastro
                Dim oForm As New frmCadBasico
                oForm.UsrControl = "usrCadSala"
                oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location : oForm.Tamanho = True
                oForm.Titulo = Me.Parent.Text
                Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                'Carrega Combo - Galpão
                Call LoadCombo(cboDadosAreaSala, "sp_select_combo_cadastro_basico_cliente_sala " & cboCliente.SelectedValue & ", " & goUsuario.iEmpresa, False)


                'Seta Focu
                cboDadosAreaSala.Focus()

            Else

                Exit Sub

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub CalculoValorFinalParcelaSala(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValorParcelaSala.ValueChanged, _
                                                                                                      txtValorFinalSala.ValueChanged, _
                                                                                                      txtDescontoSala.ValueChanged



        Try

            'Valor Final da Parcela
            If txtValorParcelaSala.Value > 0 Then

                txtValorFinalSala.Value = txtValorParcelaSala.Value - txtDescontoSala.Value

            End If




        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub NovoDespesaSala()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()
            
            'Limpa Formulário - Despesa
            cboDadosAreaSala.SelectedIndex = -1 
            txtDadosAreaAreaConstruidaLocadaSala.Value = 0
            txtDadosAreaAreaTerrenoLocadaSala.Value = 0
            txtDadosAreaValorAluguelSala.Value = 0
            txtDescontoSala.Value = 0
            txtValorFinalSala.Value = 0
            txtValorParcelaSala.Value = 0
            txtNumeroParcelaFinalSala.Value = 0
            txtNumeroParcelaIncialSala.Value = 0
            txtValorFinalSala.Value = 0
            'grdDespesaSala.DataSource = Nothing

            txtNumeroParcelaIncialSala.Value = 0
            txtNumeroParcelaFinalSala.Value = 0
            btnInserirDespesaSala.Tag = ""

            'Seta Focu
            txtNumeroParcelaFinal.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarDespesaSala()

        Try

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirDespesaSala.Tag) = False Then

                'Insere Despesa
                Call oClsVenAcordoComercial.InsertDespesaSala(btnSalvar.Tag, _
                                                                cboDadosAreaSala.SelectedValue, _
                                                                txtNumeroParcelaIncialSala.Value, _
                                                                txtNumeroParcelaFinalSala.Value, _
                                                                txtValorParcelaSala.Value, _
                                                                txtDescontoSala.Value, _
                                                                txtValorFinalSala.Value)

            Else

                'Altera Serviço
                Call oClsVenAcordoComercial.UpdateDespesaSala(btnSalvar.Tag, _
                                                                grdDespesaSala.CurrentRow.Cells("codigo").Value, _
                                                                grdDespesaSala.CurrentRow.Cells("codigo_sala_comercial").Value, _
                                                                txtNumeroParcelaIncialSala.Value, _
                                                                txtNumeroParcelaFinalSala.Value, _
                                                                txtValorParcelaSala.Value, _
                                                                txtDescontoSala.Value, _
                                                                txtValorFinalSala.Value)


            End If

            'Carrega a Grid
            Call oClsVenAcordoComercial.LoadGridDespesaSala(grdDespesaSala, btnSalvar.Tag)

            'Limpa Formulário
            Call NovoDespesaSala()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteDespesaSala()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdDespesaSala) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Linha
                    Call oClsVenAcordoComercial.DeleteDespesaSala(btnSalvar.Tag)

                    'Limpa Formulário
                    Call NovoDespesaSala()

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

    Private Sub EditarDespesaSala()

        Try

            'Verifica o Direito
            If VerificaDireito(Formulario.ComercialAcordoComercial, gcUpdate) = True Then

                'Carrega Controles
                With grdDespesaSala.CurrentRow.Cells

                    cboDadosAreaSala.SelectedValue = .Item("codigo_sala_comercial").Value
                    txtNumeroParcelaIncialSala.Value = .Item("numero_parcela_inicial").Value
                    txtNumeroParcelaFinalSala.Value = .Item("numero_parcela_final").Value
                    txtValorParcelaSala.Value = .Item("valor_parcela").Value
                    txtDescontoSala.Value = .Item("valor_desconto").Value
                    txtValorFinalSala.Value = .Item("valor_final").Value
                    btnInserirDespesaSala.Tag = .Item("codigo").Value

                    'Seta Focu
                    txtNumeroParcelaIncialSala.Focus()

                End With

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoDespesaSala() As Boolean

        Try

            'Seta Retorno da Função 
            ValidacaoDespesaSala = False

            'Verifica se foi Selecionado o Campo - Galpão
            If ValidaCampo(cboDadosAreaSala, lblDadosAreaSala) = False Then
                Exit Function
            End If


            'Verifica se foi Preenchido o Campo - Numero Parcela Inicial
            If ValidaCampo(txtNumeroParcelaIncialSala, lblNumeroParcelaInicialSala, True) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Numero Parcela Final
            If ValidaCampo(txtNumeroParcelaFinalSala, lblNumeroParcelaFinalSala, True) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Valor Parcela
            If ValidaCampo(txtValorParcelaSala, lblValorParcelaSala, True) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Valor Parcela
            If ValidaCampo(txtValorFinalSala, lblValorFinalSala, True) = False Then
                Exit Function
            End If

            'Seta Retorno da Função 
            ValidacaoDespesaSala = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: BOX :::"

    Private Sub btnDadosAreaCadastrarBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDadosAreaCadastrarBox.Click
        Try

            If ValidaCampo(cboCliente, lblCliente) = True Then

                'Abre Formulário de Cadastro
                Dim oForm As New frmCadBasico
                oForm.UsrControl = "usrCadBox"
                oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location : oForm.Tamanho = True
                oForm.Titulo = Me.Parent.Text
                Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                'Carrega Combo - Galpão
                Call LoadCombo(cboDadosAreaBox, "sp_select_combo_cadastro_basico_cliente_box " & cboCliente.SelectedValue & ", " & goUsuario.iEmpresa, False)


                'Seta Focu
                cboDadosAreaBox.Focus()

            Else

                Exit Sub

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub CalculoValorFinalParcelaBox(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValorParcelaBox.ValueChanged, _
                                                                                                      txtValorFinalBox.ValueChanged, _
                                                                                                      txtValorDescontoBox.ValueChanged



        Try

            'Valor Final da Parcela
            If txtValorParcelaBox.Value > 0 Then

                txtValorFinalBox.Value = txtValorParcelaBox.Value - txtValorDescontoBox.Value

            End If




        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub NovoDespesaBox()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Formulário - Despesa
            cboDadosAreaBox.SelectedIndex = -1
            txtDadosAreaAreaConstruidaLocadaBox.Value = 0
            txtDadosAreaAreaTerrenoLocadaBox.Value = 0
            txtDadosAreaValorAluguelBox.Value = 0
            txtValorDescontoBox.Value = 0
            txtValorFinalBox.Value = 0
            txtValorParcelaBox.Value = 0
            txtNumeroParcelaFinalBox.Value = 0
            txtNumeroParcelaInicialBox.Value = 0
            txtValorFinalBox.Value = 0
            'grdDespesaBox.DataSource = Nothing

            txtNumeroParcelaInicialBox.Value = 0
            txtNumeroParcelaFinalBox.Value = 0
            btnInserirDespesaBox.Tag = ""

            'Seta Focu
            txtNumeroParcelaFinal.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarDespesaBox()

        Try

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirDespesaBox.Tag) = False Then

                'Insere Despesa
                Call oClsVenAcordoComercial.InsertDespesaBox(btnSalvar.Tag, _
                                                                cboDadosAreaBox.SelectedValue, _
                                                                txtNumeroParcelaInicialBox.Value, _
                                                                txtNumeroParcelaFinalBox.Value, _
                                                                txtValorParcelaBox.Value, _
                                                                txtValorDescontoBox.Value, _
                                                                txtValorFinalBox.Value)

            Else

                'Altera Serviço
                Call oClsVenAcordoComercial.UpdateDespesaBox(btnSalvar.Tag, _
                                                                grdDespesaBox.CurrentRow.Cells("codigo").Value, _
                                                                grdDespesaBox.CurrentRow.Cells("codigo_box").Value, _
                                                                txtNumeroParcelaInicialBox.Value, _
                                                                txtNumeroParcelaFinalBox.Value, _
                                                                txtValorParcelaBox.Value, _
                                                                txtValorDescontoBox.Value, _
                                                                txtValorFinalBox.Value)


            End If

            'Carrega a Grid
            Call oClsVenAcordoComercial.LoadGridDespesaBox(grdDespesaBox, btnSalvar.Tag)

            'Limpa Formulário
            Call NovoDespesaBox()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteDespesaBox()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdDespesaBox) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Linha
                    Call oClsVenAcordoComercial.DeleteDespesaBox(btnSalvar.Tag)

                    'Limpa Formulário
                    Call NovoDespesaBox()

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

    Private Sub EditarDespesaBox()

        Try

            'Verifica o Direito
            If VerificaDireito(Formulario.ComercialAcordoComercial, gcUpdate) = True Then

                'Carrega Controles
                With grdDespesaBox.CurrentRow.Cells

                    cboDadosAreaBox.SelectedValue = .Item("codigo_box").Value
                    txtNumeroParcelaInicialBox.Value = .Item("numero_parcela_inicial").Value
                    txtNumeroParcelaFinalBox.Value = .Item("numero_parcela_final").Value
                    txtValorParcelaBox.Value = .Item("valor_parcela").Value
                    txtValorDescontoBox.Value = .Item("valor_desconto").Value
                    txtValorFinalBox.Value = .Item("valor_final").Value
                    btnInserirDespesaBox.Tag = .Item("codigo").Value

                    'Seta Focu
                    txtNumeroParcelaInicialBox.Focus()

                End With

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoDespesaBox() As Boolean

        Try

            'Seta Retorno da Função 
            ValidacaoDespesaBox = False

            'Verifica se foi Selecionado o Campo - Galpão
            If ValidaCampo(cboDadosAreaBox, lblDadosAreaBox) = False Then
                Exit Function
            End If


            'Verifica se foi Preenchido o Campo - Numero Parcela Inicial
            If ValidaCampo(txtNumeroParcelaInicialBox, lblNumeroParcelaInicialBox, True) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Numero Parcela Final
            If ValidaCampo(txtNumeroParcelaFinalBox, lblNumeroParcelaFinalBox, True) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Valor Parcela
            If ValidaCampo(txtValorParcelaBox, lblValorParcelaBox, True) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Valor Parcela
            If ValidaCampo(txtValorFinalBox, lblValorFinalBox, True) = False Then
                Exit Function
            End If

            'Seta Retorno da Função 
            ValidacaoDespesaBox = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: CASA :::"

    Private Sub btnDadosAreaCadastrarCasa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDadosAreaCadastrarCasa.Click
        Try

            If ValidaCampo(cboCliente, lblCliente) = True Then

                'Abre Formulário de Cadastro
                Dim oForm As New frmCadBasico
                oForm.UsrControl = "usrCadCasa"
                oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location : oForm.Tamanho = True
                oForm.Titulo = Me.Parent.Text
                Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                'Carrega Combo - Galpão
                Call LoadCombo(cboDadosAreaCasa, "sp_select_combo_cadastro_basico_cliente_casa " & cboCliente.SelectedValue & ", " & goUsuario.iEmpresa, False)


                'Seta Focu
                cboDadosAreaCasa.Focus()

            Else

                Exit Sub

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub CalculoValorFinalParcelaCasa(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValorParcelaCasa.ValueChanged, _
                                                                                                      txtValorFinalCasa.ValueChanged, _
                                                                                                      txtDescontoCasa.ValueChanged



        Try

            'Valor Final da Parcela
            If txtValorParcelaCasa.Value > 0 Then

                txtValorFinalCasa.Value = txtValorParcelaCasa.Value - txtDescontoCasa.Value

            End If




        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub NovoDespesaCasa()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Formulário - Despesa
            cboDadosAreaCasa.SelectedIndex = -1
            cboIPTUCasa.SelectedIndex = -1
            txtDadosAreaAreaConstruidaLocadaCasa.Value = 0
            txtDadosAreaAreaTerrenoLocada.Value = 0
            txtDadosAreaValorAluguelCasa.Value = 0
            txtValorM2IPTUCasa.Value = 0
            txtValorTotalIPTUCasa.Value = 0
            txtValorDescontoIPTUCasa.Value = 0
            txtValorFinalCasa.Value = 0
            txtNumeroParcelaIPTUCasa.Value = 0
            txtValorParcelaCasa.Value = 0
            txtNumeroParcelaFinalCasa.Value = 0
            txtNumeroParcelaInicialCasa.Value = 0
            txtValorFinalCasa.Value = 0
            chkGerarPrevisaoReembolsoIPTUCasa.Checked = False
            'grdDespesaCasa.DataSource = Nothing
            txtDescontoCasa.Value = 0
            txtValorReembolsoIPTUCasa.Value = 0

            txtNumeroParcelaInicial.Value = 0
            txtNumeroParcelaFinal.Value = 0
            btnInserirDespesaGalpao.Tag = ""


            'Seta Focu
            txtNumeroParcelaFinal.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarDespesaCasa()

        Try

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirDespesaCasa.Tag) = False Then

                'Insere Despesa
                Call oClsVenAcordoComercial.InsertDespesaCasa(btnSalvar.Tag, _
                                                                cboDadosAreaCasa.SelectedValue, _
                                                                txtNumeroParcelaInicialCasa.Value, _
                                                                txtNumeroParcelaFinalCasa.Value, _
                                                                txtValorParcelaCasa.Value, _
                                                                txtDescontoCasa.Value, _
                                                                txtValorFinalCasa.Value)

            Else

                'Altera Serviço
                Call oClsVenAcordoComercial.UpdateDespesaCasa(btnSalvar.Tag, _
                                                                grdDespesaCasa.CurrentRow.Cells("codigo").Value, _
                                                                grdDespesaCasa.CurrentRow.Cells("codigo_casa").Value, _
                                                                txtNumeroParcelaInicialCasa.Value, _
                                                                txtNumeroParcelaFinalCasa.Value, _
                                                                txtValorParcelaCasa.Value, _
                                                                txtDescontoCasa.Value, _
                                                                txtValorFinalCasa.Value)


            End If

            'Carrega a Grid
            Call oClsVenAcordoComercial.LoadGridDespesaCasa(grdDespesaCasa, btnSalvar.Tag)

            'Limpa Formulário
            Call NovoDespesaCasa()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeleteDespesaCasa()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdDespesaCasa) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Linha
                    Call oClsVenAcordoComercial.DeleteDespesaCasa(btnSalvar.Tag)

                    'Limpa Formulário
                    Call NovoDespesaCasa()

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

    Private Sub EditarDespesaCasa()

        Try

            'Verifica o Direito
            If VerificaDireito(Formulario.ComercialAcordoComercial, gcUpdate) = True Then

                'Carrega Controles
                With grdDespesaCasa.CurrentRow.Cells

                    cboDadosAreaCasa.SelectedValue = .Item("codigo_casa").Value
                    txtNumeroParcelaInicialCasa.Value = .Item("numero_parcela_inicial").Value
                    txtNumeroParcelaFinalCasa.Value = .Item("numero_parcela_final").Value
                    txtValorParcelaCasa.Value = .Item("valor_parcela").Value
                    txtDescontoCasa.Value = .Item("valor_desconto").Value
                    txtValorFinalCasa.Value = .Item("valor_final").Value
                    btnInserirDespesaCasa.Tag = .Item("codigo").Value

                    'Seta Focu
                    txtNumeroParcelaInicialCasa.Focus()

                End With

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function ValidacaoDespesaCasa() As Boolean

        Try

            'Seta Retorno da Função 
            ValidacaoDespesaCasa = False

            'Verifica se foi Selecionado o Campo - Galpão
            If ValidaCampo(cboDadosAreaCasa, lblDadosAreaCasa) = False Then
                Exit Function
            End If


            'Verifica se foi Preenchido o Campo - Numero Parcela Inicial
            If ValidaCampo(txtNumeroParcelaInicialCasa, lblNumeroParcelaInicialCasa, True) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Numero Parcela Final
            If ValidaCampo(txtNumeroParcelaFinalCasa, lblNumeroParcelaFinalCasa, True) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Valor Parcela
            If ValidaCampo(txtValorParcelaCasa, lblValorParcelaCasa, True) = False Then
                Exit Function
            End If

            'Verifica se foi Preenchido o Campo - Valor Parcela
            If ValidaCampo(txtValorFinalCasa, lblValorFinalCasa, True) = False Then
                Exit Function
            End If

            'Seta Retorno da Função 
            ValidacaoDespesaCasa = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region
     
#Region "::: ARQUIVO :::"

    Private Sub DeleteArquivo()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdArquivo) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & iif(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    For Each oRow As GridEXRow In gSelecaoRow
                        'Exclui Registro do Banco de Dados
                        modFunction.DeleteArquivoBD("tb_ven_acordo_comercial", oRow.Cells("path").Value, btnSalvar.Tag)
                        'Exclui Registro da Grid
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
            If VerificaDireito(Formulario.ComprasRequisicao, gcUpdate) = True Then

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

    Private Sub CalculoValorReembolsoIPTU(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValorM2IPTU.ValueChanged, _
                                                                                                       cboDadosAreaGalpao.SelectedIndexChanged, _
                                                                                                       txtValorTotalIPTU.ValueChanged, _
                                                                                                       txtValorReembolsoIPTU.ValueChanged, _
                                                                                                       txtDadosAreaAreaConstruidaLocada.ValueChanged, _
                                                                                                       txtDescontoIPTU.ValueChanged

        Try

            Select Case sender.Name

                Case "txtValorM2IPTU"

                    'Seta Valores
                    If txtValorM2IPTU.Value = 0 Then

                        txtValorTotalIPTU.Value = 0
                        txtDescontoIPTU.Value = 0
                        txtValorReembolsoIPTU.Value = 0
                        txtNumeroParcelaIPTU.Value = 0

                    Else

                        'Verifica se foi selecionado Galpão
                        If cboDadosAreaGalpao.SelectedIndex <> -1 Then

                            txtValorTotalIPTU.Value = (txtValorM2IPTU.Value * txtDadosAreaAreaConstruidaLocada.Value)
                            txtValorReembolsoIPTU.Value = txtValorTotalIPTU.Value - txtDescontoIPTU.Value

                        End If

                    End If

                Case "txtDescontoIPTU"

                    If txtDescontoIPTU.Value > 0 Then

                        txtValorReembolsoIPTU.Value = txtValorTotalIPTU.Value - txtDescontoIPTU.Value

                    End If

            End Select



        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboIPTU_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboIPTU.SelectedIndexChanged
        Try

            'Verifica se foi selecionado Galpão
            If cboIPTU.SelectedIndex = -1 Then

                'Limpa Controles
                txtValorM2IPTU.Value = 0
                txtValorTotalIPTU.Value = 0
                txtDescontoIPTU.Value = 0
                txtValorReembolsoIPTU.Value = 0
                txtNumeroParcelaIPTU.Value = 0

            Else

                'Verifica se foi selecionado o Galpão
                If cboDadosAreaGalpao.SelectedIndex <> -1 Then

                    'Carrega dados do cadastro do IPTU
                    oClsVenAcordoComercial.LoadDadosIPTU(IIf(cboIPTU.SelectedIndex = -1, -1, cboIPTU.SelectedValue), _
                                                         txtValorM2IPTU, _
                                                         txtValorTotalIPTU)

                Else

                    'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Selecione primeiramente  Galpão.")

                End If


            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub cboIPTUCasa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboIPTUCasa.SelectedIndexChanged
        Try

            'Verifica se foi selecionado Galpão
            If cboIPTUCasa.SelectedIndex = -1 Then

                'Limpa Controles
                txtValorM2IPTUCasa.Value = 0
                txtValorTotalIPTUCasa.Value = 0
                txtValorDescontoIPTUCasa.Value = 0
                txtValorReembolsoIPTUCasa.Value = 0
                txtNumeroParcelaIPTUCasa.Value = 0

            Else

                'Verifica se foi selecionado o Galpão
                If cboDadosAreaCasa.SelectedIndex <> -1 Then

                    'Carrega dados do cadastro do IPTU
                    oClsVenAcordoComercial.LoadDadosIPTU(IIf(cboIPTUCasa.SelectedIndex = -1, -1, cboIPTUCasa.SelectedValue), _
                                                         txtValorM2IPTUCasa, _
                                                         txtValorTotalIPTUCasa)

                Else

                    'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Selecione primeiramente uma Casa.")

                End If


            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnCadastrarIPTU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarIPTU.click
        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrCadIPTU"
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location : oForm.Tamanho = True
            oForm.Titulo = Me.Parent.Text
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Carrega Combo - Galpão
            Call LoadCombo(cboIPTU, "sp_select_combo_cadastro_basico_iptu " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboIPTUCasa, "sp_select_combo_cadastro_basico_iptu " & goUsuario.iEmpresa, False)

            'Seta Focu
            cboIPTU.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
     
End Class
