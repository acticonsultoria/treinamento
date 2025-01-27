Imports CrystalDecisions.CrystalReports.Engine
Imports Janus.Windows.GridEX
Imports System.Threading

Public Class usrEstMovimentacao

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsEstMovimentacao As New clsUsrEstMovimentacao
    Public iCodigoProdutoMovimentacao As Integer = -1
    Public sLoteMovimentacao As String = ""
    Public iCodigoDepositoMovimentacao As Integer = -1
    Public iQuantidadeMovimentacao As Double = -1

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrEstMovimentacao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                     
                Case Keys.F3

                    Select Case sender.Name

                        Case "cboParceiroNegocioFiltro" : Call btnProcurarParceiroNegocioFiltro_Click(btnProcurarParceiroNegocioFiltro, System.EventArgs.Empty)
                        Case "cboParceiroNegocio" : Call btnProcurarParceiroNegocio_Click(btnProcurarParceiroNegocio, System.EventArgs.Empty)
                        Case "cboProduto" : Call btnProcurarProduto_Click(btnProcurarProduto, System.EventArgs.Empty)
                        Case "cboCodigoProdutoMovimentacao" : Call btnProcurarProdutoMovimentacao_Click(btnProcurarProdutoMovimentacao, System.EventArgs.Empty)

                    End Select

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name

                        Case "cboDepositoFiltro" : Call LoadCombo(cboDepositoFiltro, "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa)
                        Case "cboGrupoItemFiltro" : Call LoadCombo(cboGrupoItemFiltro, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)
                        Case "cboParceiroNegocioFiltro" : Call LoadCombo(cboGrupoItemFiltro, "sp_select_combo_cadastro_basico_parceiro_negocio " & goUsuario.iEmpresa)
                        Case "cboTipoMovimentacaoFiltro" : Call LoadCombo(cboTipoMovimentacaoFiltro, "sp_select_combo_static_tipo_movimentacao_estoque")
                        Case "cboTipoDocumentoFiltro" : Call LoadCombo(cboTipoDocumentoFiltro, "sp_select_combo_estoque_tipo_documento " & goUsuario.iEmpresa)
                        Case "cboParceiroNegocio" : Call LoadCombo(cboParceiroNegocio, "sp_select_combo_cadastro_basico_parceiro_negocio " & goUsuario.iEmpresa)
                        Case "cboDeposito" : Call LoadCombo(cboDeposito, "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa)
                        Case "cboProduto" : Call LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & TipoItem.produto & ", NULL, NULL, 1, NULL, NULL", False)
                        Case "cboDepositoMovimentacao" : Call LoadCombo(cboDepositoMovimentacao, "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa)
                        Case "cboCodigoProdutoMovimentacao" : Call LoadCombo(cboCodigoProdutoMovimentacao, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & TipoItem.produto & ", NULL, NULL, 1, NULL, NULL", False)

                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrEstMovimentacao_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: MOVIMENTAÇÃO :::"

    Private Sub btnAtualizarDeposito_Click(sender As Object, e As EventArgs) Handles btnAtualizarDeposito.Click

        Try

            AtualizaDeposito()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.EstoqueMovimentacao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.EstoqueMovimentacao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

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

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Planilha Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarParceiroNegocioFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarParceiroNegocioFiltro.Click

        Try
            
            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = -1
            oComboBoxFind = cboParceiroNegocioFiltro

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboParceiroNegocioFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarParceiroNegocio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarParceiroNegocio.Click

        Try
            
            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindParceiroNegocio"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Parceiro de Negócio"

            'Seta Parametros
            iCodigoTipoParceiroNegocioFind = -1
            oComboBoxFind = cboParceiroNegocio

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboParceiroNegocio.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarParceiroNegocio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarParceiroNegocio.Click

        Try

             'Carrega o form de parceiro de negócio
            LoadUsrControlForm(Me, "usrCadParceiroNegocio")

            'Carrega Combo            
            Call LoadCombo(cboParceiroNegocio, "sp_select_combo_cadastro_basico_parceiro_negocio " & goUsuario.iEmpresa, True)

            'Seta Focu
            cboParceiroNegocio.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnImprimirEtiqueta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Imprime Etiqueta
            Call ImprimirEtiqueta()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Limpa Formulário
            Call Novo()

            'Alterna Aba
            tabMain.TabPages.Remove(pagListagem)
            tabMain.TabPages.Add(pagDados)

            'Seta Focu
            txtNumeroDocumento.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            'Limpa Formulário
            Call Novo()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            Delete()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
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
            tabMain.TabPages.Add(pagListagem)

            'Seta Focu
            cboDepositoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboTipoMovimentacao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoMovimentacao.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado algum Controle
            If cboTipoMovimentacao.SelectedIndex <> -1 Then

                Select Case cboTipoMovimentacao.SelectedValue
                    Case "S" : cboLote.Visible = True : txtLote.Visible = False : cboLote.Text = ""
                    Case "E" : cboLote.Visible = False : txtLote.Visible = True : txtLote.Text = ""
                End Select

            End If

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
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(grdListagem, _
                                Formulario.EstoqueMovimentacao)

            'Carrega Combo
            LoadComboColunasGrid(cboCongelarColuna, grdListagem)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(grdListagem.Name, _
                                Formulario.EstoqueMovimentacao, _
                                e.Column.Key, _
                                e.ProposedWidth)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdListagem_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging

        Try

            'Atualiza Grid
            UpdateConfiguraGridGrupo(grdListagem.Name, _
                                     Formulario.EstoqueMovimentacao, _
                                     e.Group.Column.Key, _
                                     IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                     e.ProposedPosition)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Editar()

            End Select

            grdMovimentacao.DataSource = Nothing

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

#Region "::: PRODUTO :::"

    Private Sub btnConfigurarGridProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridProduto.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdProduto
            oForm.NomeFormulario = Formulario.EstoqueMovimentacao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdProduto, Formulario.EstoqueMovimentacao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnAgruparGridProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridProduto.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdProduto.GroupByBoxVisible = True Then

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

    Private Sub btnExcelGridProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridProduto.Click

        Try

            'Exporta Planilha Excel
            Call ExportExcel(grdProduto)

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
            sItemEstoqueFind = "S"
            oComboBoxFind = cboProduto

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboProduto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarProduto.Click

        Try

               'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadProduto")

            'Carrega Combo            
            Call LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & TipoItem.produto & ", NULL, NULL, 1, NULL, NULL", False)

            'Seta Focu
            cboProduto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboProduto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProduto.SelectedIndexChanged, _
                                                                                                                    cboDeposito.SelectedIndexChanged

        Try

            'Verifica se Foi Selecionado algum Registro
            If cboProduto.SelectedIndex <> -1 Then

                'Váriaveis Locais
                Dim oClsCadProduto As New clsUsrCadProduto

                'Carrega Dados do Produto
                Call oClsCadProduto.LoadDadosProduto(cboProduto.SelectedValue, _
                                                     txtDescricao)

                'Verifica se foi Selecionado o Depósito
                If cboDeposito.SelectedIndex > -1 And cboTipoMovimentacao.SelectedIndex > -1 AndAlso cboTipoMovimentacao.SelectedValue = "S" Then
                    Call LoadCombo(cboLote, "sp_select_combo_estoque_lote " & cboProduto.SelectedValue & ", " & goUsuario.iEmpresa & ", " & cboDeposito.SelectedValue, True)
                Else
                    cboLote.DataSource = Nothing : cboLote.Text = ""
                End If

            Else

                'Limpa Controles
                txtDescricao.Text = ""
                cboLote.DataSource = Nothing : cboLote.Text = ""
                txtLote.Text = ""

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdProduto.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdProduto, _
                                     Formulario.EstoqueMovimentacao)

            'Carrega Combo
            Call LoadComboColunasGrid(cboCongelarColuna, grdProduto)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdProduto_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdProduto.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdProduto.Name, _
                                     Formulario.EstoqueMovimentacao, _
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
                                          Formulario.EstoqueMovimentacao, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    

#End Region

#Region "::: EDITAR LOTE :::"

    Private Sub btnConfigurarGridMovimentacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdMovimentacao
            oForm.NomeFormulario = Formulario.EstoqueMovimentacao
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdMovimentacao, Formulario.EstoqueMovimentacao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnAgruparGridMovimentacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Verifica se o Grupo está Habilita
            If grdMovimentacao.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdMovimentacao.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdMovimentacao.GroupByBoxVisible = True
                grdMovimentacao.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelMovimentacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelMovimentacao.Click

        Try

            'Exporta Planilha Excel
            Call ExportExcel(grdMovimentacao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirMovimentacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirMovimentacao.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Deleta Registros
            Call Excluir()
            'Limpa Formulário
            Call NovoLote()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnVoltarMovimentacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltarMovimentacao.Click

        Try

            'Carrega Grid
            Call LoadGrid()

            'Alterna Aba
            tabMain.TabPages.Remove(pagMovimentacao)
            tabMain.TabPages.Add(pagListagem)

            'Seta Focu
            txtNumeroDocumento.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarProdutoMovimentacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarProdutoMovimentacao.Click

        Try

            'Abre Formulário de Cadastro
            Dim oForm As New frmCadBasico
            oForm.UsrControl = "usrFindItem"
            oForm.Titulo = Me.Parent.Text
            oForm.Tamanho = True
            oForm.Text = "Procurar Produto"

            'Seta Parametros
            iCodigoTipoItemFind = TipoItem.produto
            sItemEstoqueFind = "S"
            oComboBoxFind = cboProduto

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboProduto.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirProdutoMovimentacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirProdutoMovimentacao.Click

        Try

               'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadProduto")

            'Carrega Combo            
            Call LoadCombo(cboCodigoProdutoMovimentacao, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & TipoItem.produto & ", NULL, NULL, 1, NULL, NULL", False)

            'Seta Focu
            cboCodigoProdutoMovimentacao.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCodigoProdutoMovimentacao_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCodigoProdutoMovimentacao.SelectedIndexChanged, _
                                                                                                                    cboDepositoMovimentacao.SelectedIndexChanged

        Try

            'Verifica se Foi Selecionado algum Registro
            If cboCodigoProdutoMovimentacao.SelectedIndex <> -1 Then

                'Váriaveis Locais
                Dim oClsCadProduto As New clsUsrCadProduto

                'Carrega Dados do Produto
                Call oClsCadProduto.LoadDadosProduto(cboCodigoProdutoMovimentacao.SelectedValue, _
                                                     txtDescricaoInserirMovimentacao)

                'Verifica se foi Selecionado o Depósito
                'If cboDepositoMovimentacao.SelectedIndex > -1 Then
                '    Call LoadCombo(cboLote, "sp_select_combo_estoque_lote " & cboProduto.SelectedValue & ", " & goUsuario.iEmpresa & ", " & cboDeposito.SelectedValue, True)
                'Else
                '    cboLote.DataSource = Nothing : cboLote.Text = ""
                'End If

            Else

                'Limpa Controles
                txtDescricao.Text = ""
                txtLoteInserirMovimentacao.Text = ""

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnInserirMovimentacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirMovimentacao.Click
        Try

            'Verifica se foi Selecionado a Condição de Pagamento
            If cboCodigoProdutoMovimentacao.SelectedIndex = -1 Or cboDepositoMovimentacao.SelectedIndex = -1 Then
                If cboCodigoProdutoMovimentacao.SelectedIndex = -1 Then
                    frmMain.errInfo.SetError(lblCodigoProdutoInserir, "Selecione um produto um produto.")
                End If
                If cboDepositoMovimentacao.SelectedIndex = -1 Then
                    frmMain.errInfo.SetError(lblDepositoInserirMovimentacao, "Selecione um produto um deposito.")
                End If
            Else
                'Gera Parcela
                Call oClsEstMovimentacao.InserirMovimentacao(grdMovimentacao, _
                                                            cboCodigoProdutoMovimentacao.Text, _
                                                            cboCodigoProdutoMovimentacao.SelectedValue, _
                                                            txtDescricaoInserirMovimentacao.Text, _
                                                            txtLoteInserirMovimentacao.Text,
                                                            cboDepositoMovimentacao.Text, _
                                                            cboDepositoMovimentacao.SelectedValue, _
                                                            txtQuantidadeInserirMovimentacao.Value)


                Call NovoLote()

                frmMain.Informacao(Mensagem.RegistroInserido)

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub grdMovimentacao_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdMovimentacao.RowDoubleClick
        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdMovimentacao.CurrentColumn) Then Exit Sub

            'Verifica qual coluna foi pressionada
            Select Case grdMovimentacao.CurrentColumn.Key

                Case "editar" : Call EditarLote()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnSalvarMovimentacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarMovimentacao.Click

        Try

            'Limpa Erros
            frmMain.errInfo.Clear()

                'Salva Dados
            Call SalvarMovimentacao()
            Call ExcluirMovimentacao()



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
            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf usrEstMovimentacao_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega ComboBox
            LoadCombo(cboDepositoFiltro, "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa)
            LoadCombo(cboGrupoItemFiltro, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)
            LoadCombo(cboParceiroNegocioFiltro, "sp_select_combo_cadastro_basico_parceiro_negocio " & goUsuario.iEmpresa)
            LoadCombo(cboTipoMovimentacaoFiltro, "sp_select_combo_static_tipo_movimentacao_estoque")
            LoadCombo(cboTipoDocumentoFiltro, "sp_select_combo_estoque_tipo_documento " & goUsuario.iEmpresa)
            LoadCombo(cboCFOPFiltro, "sp_select_combo_cadastro_basico_cfop " & goUsuario.iEmpresa)
            LoadComboColunasGrid(cboCongelarColuna, grdListagem)
            LoadCombo(cboParceiroNegocio, "sp_select_combo_cadastro_basico_parceiro_negocio " & goUsuario.iEmpresa, False)
            LoadCombo(cboDeposito, "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa, False)
            LoadCombo(cboProduto, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & TipoItem.produto & ", NULL, NULL, 1, NULL, NULL", False)
            LoadCombo(cboTipoMovimentacao, "sp_select_combo_static_tipo_movimentacao_estoque", False)
            LoadCombo(cboMarcaFiltro, "sp_select_combo_cadastro_basico_item_marca " & goUsuario.iEmpresa, False)
            LoadCombo(cboDepositoMovimentacao, "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa)
            LoadCombo(cboCodigoProdutoMovimentacao, "sp_select_combo_cadastro_basico_item " & goUsuario.iEmpresa & ", NULL, NULL, " & TipoItem.produto & ", NULL, NULL, 1, NULL, NULL", False)

            'Seta Calendar Combo
            dtpDataMovimentacaoInicioFiltro.Value = Now.Date : dtpDataMovimentacaoInicioFiltro.Checked = False
            dtpDataMovimentacaoTerminoFiltro.Value = Now.Date : dtpDataMovimentacaoTerminoFiltro.Checked = False

            btnAtualizarDeposito.Enabled = VerificaDireito(Formulario.EstoqueMovimentacao, gcAdministrator)
            btnExcluir.Enabled = VerificaDireito(Formulario.EstoqueMovimentacao, gcAdministrator)

            'Configura Grid
            ConfiguraGrid(grdListagem, Formulario.EstoqueMovimentacao)
            ConfiguraGrid(grdProduto, Formulario.EstoqueMovimentacao)
            ConfiguraGrid(grdMovimentacao, Formulario.EstoqueMovimentacao)

            'Remove Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Remove(pagMovimentacao)

            cboDepositoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

#Region "::: MOVIMENTAÇÃO :::"

    Private Sub AtualizaDeposito()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                Dim sCodigo As String = ""

                For Each oRow As GridEXRow In grdListagem.GetCheckedRows
                    sCodigo &= IIf(sCodigo = "", "", ",") & oRow.Cells("codigo").Value
                Next

                Dim oForm As New frmEstMovimentacaoDeposito
                oForm.CodigoMovimentacao = sCodigo

                oForm.ShowDialog()

                If oForm.Finalizado = False Then Exit Sub

                LoadGrid()

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mais Registro
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Váriaveis Locais
            Dim sGrupoItemFiltro As String = ""
            Dim sCFOPFiltro As String = ""
            Dim sTipoMovimentacaoFiltro As String = ""
            Dim sTipoDocumentoFiltro As String = ""
            Dim i As Integer

            'Grupo de Item
            If cboGrupoItemFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboGrupoItemFiltro.CheckedValues)
                    sGrupoItemFiltro &= IIf(sGrupoItemFiltro = "", "", ",") & cboGrupoItemFiltro.CheckedValues(i).ToString
                Next
            End If

            'CFOP
            If cboCFOPFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboCFOPFiltro.CheckedValues)
                    sCFOPFiltro &= IIf(sCFOPFiltro = "", "", ",") & cboCFOPFiltro.CheckedValues(i).ToString
                Next
            End If

            'Tipo de Movimentação
            If cboTipoMovimentacaoFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboTipoMovimentacaoFiltro.CheckedValues)
                    sTipoMovimentacaoFiltro &= IIf(sTipoMovimentacaoFiltro = "", "", ",") & cboTipoMovimentacaoFiltro.CheckedValues(i).ToString
                Next
            End If

            'Tipo de Documento
            If cboTipoDocumentoFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboTipoDocumentoFiltro.CheckedValues)
                    sTipoDocumentoFiltro &= IIf(sTipoDocumentoFiltro = "", "", ",") & cboTipoDocumentoFiltro.CheckedValues(i).ToString
                Next
            End If

            'Carrega Grid
            oClsEstMovimentacao.LoadGrid(grdListagem, _
                                         IIf(cboDepositoFiltro.SelectedIndex = -1, -1, cboDepositoFiltro.SelectedValue), _
                                         sGrupoItemFiltro, _
                                         txtCodigoProdutoFiltro.Text.Trim, _
                                         txtLoteFiltro.Text.Trim, _
                                         txtDescricaoFiltro.Text.Trim, _
                                         IIf(cboParceiroNegocioFiltro.SelectedIndex = -1, -1, cboParceiroNegocioFiltro.SelectedValue), _
                                         IIf(dtpDataMovimentacaoInicioFiltro.Checked = True, dtpDataMovimentacaoInicioFiltro.Value, ""), _
                                         IIf(dtpDataMovimentacaoTerminoFiltro.Checked = True, dtpDataMovimentacaoTerminoFiltro.Value, ""), _
                                         txtNumeroDocumentoFiltro.Text.Trim, _
                                         sCFOPFiltro, _
                                         sTipoMovimentacaoFiltro, _
                                         sTipoDocumentoFiltro, _
                                         IIf(cboMarcaFiltro.SelectedIndex = -1, -1, cboMarcaFiltro.SelectedValue))

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            txtNumeroDocumento.Text = ""
            dtpDataMovimentacao.Value = Now.Date
            cboTipoMovimentacao.Text = ""
            cboParceiroNegocio.Text = ""

            'Limpa Controles - Produto
            cboProduto.Text = ""
            txtDescricao.Text = ""
            cboLote.Text = ""
            txtLote.Text = "" : txtLote.Visible = False
            cboDeposito.Text = ""
            txtQuantidade.Value = 0
            btnInserirProduto.Tag = ""
            grdProduto.DataSource = Nothing

            'Seta Focu
            txtNumeroDocumento.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Delete()

        Try

            'Verifica se foi selecinado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsEstMovimentacao.Delete(grdListagem)

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                    LoadGrid()

                End If

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mais Registro
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ImprimirEtiqueta()

        'Váriaveis Locais
        Dim sCodigoMovimentacao As String = ""

        Try

            'Verifica se foi Selecionado Algum Registro
            If VerificaSelecaoRow(grdListagem, "tipo", "E") = True Then

                'Carrega Código de Movimentação
                For i = 0 To UBound(gSelecaoRow)
                    sCodigoMovimentacao &= IIf(sCodigoMovimentacao = "", "", ",") & gSelecaoRow(i).Cells("codigo").Value
                Next i

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Redimenciona Vetor
                ReDim goCrystalReport.sReportParameter(1)
                'Seta Parametros
                goCrystalReport.sReportParameter(0).sParamenter = "@codigo_movimentacao"
                goCrystalReport.sReportParameter(0).sValue = sCodigoMovimentacao
                goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
                goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
                goCrystalReport.sReport = goCrystalReport.sPath & "EST000000005.rpt"

                Dim oReport As New usrReport
                oReport.Dock = DockStyle.Fill

                'Abre Relatório
                frmMain.LoadPageReport("EST000000005", "Etiqueta", oReport)

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

            Else
                'Informa o Usuário que é necessário Selecionar um ou mais Registros
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: LOTE :::"

    Public Sub Editar()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.EstoqueMovimentacao, gcUpdate) = True Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Seta Código
                'oClsEstMovimentacao.CodigoEmissaoCapa = lCodigoEmissaoCapa
                'oClsEstMovimentacao.CodigoEmissaoItem = iCodigoEmissaoItem

                With grdListagem.CurrentRow.Cells

                    'Carrega Controles
                    txtNumeroDocumentoMovimentacao.Text = .Item("numero_documento").Value
                    dtpDataMovimentacao.Value = .Item("data").Value
                    txtTipoMovimentacao.Text = .Item("tipo_movimentacao").Value
                    txtParceiroNegocio.Text = .Item("parceiro_negocio").Value
                    txtDeposito.Text = .Item("deposito").Value
                    txtCodigoProduto.Text = .Item("codigo_produto").Value
                    txtDescricaoMovimentacao.Text = .Item("descricao").Value
                    txtValorUnitario.Value = .Item("valor_unitario").Value
                    txtQuantidadeMovimentacao.Value = .Item("quantidade").Value
                    txtLoteMovimentacao.Text = .Item("lote").Value
                    btnInserirMovimentacao.Tag = .Item("codigo").Value

                End With


                'Alterna Aba
                'If tabMain.TabPages.Contains(pagListagem) Then tabMain.TabPages.Remove(pagListagem)
                'If tabMain.TabPages.Contains(pagMovimentacao) = False Then tabMain.TabPages.Add(pagMovimentacao)
                tabMain.TabPages.Add(pagMovimentacao)
                tabMain.TabPages.Remove(pagListagem)

                'Seta Focu
                cboCodigoProdutoMovimentacao.Focus()

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub NovoLote()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            cboCodigoProdutoMovimentacao.Text = ""
            txtDescricaoInserirMovimentacao.Text = ""
            txtLoteInserirMovimentacao.Text = ""
            cboDepositoMovimentacao.Text = ""
            txtQuantidadeInserirMovimentacao.Text = ""

            'Seta Focu
            cboCodigoProdutoMovimentacao.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub EditarLote()

        Try

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(Formulario.EstoqueMovimentacao, gcUpdate) = True Then

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Seta Código
                'oClsEstMovimentacao.CodigoEmissaoCapa = lCodigoEmissaoCapa
                'oClsEstMovimentacao.CodigoEmissaoItem = iCodigoEmissaoItem

                With grdMovimentacao.CurrentRow.Cells

                    'Carrega Controles
                    cboCodigoProdutoMovimentacao.Text = .Item("codigo_produto").Value
                    txtDescricaoInserirMovimentacao.Text = .Item("descricao").Value
                    txtLoteInserirMovimentacao.Text = .Item("lote").Value
                    cboDepositoMovimentacao.Text = .Item("deposito").Value
                    txtQuantidadeInserirMovimentacao.Text = .Item("quantidade").Value

                End With


                'Alterna Aba
                'If tabMain.TabPages.Contains(pagListagem) Then tabMain.TabPages.Remove(pagListagem)
                'If tabMain.TabPages.Contains(pagMovimentacao) = False Then tabMain.TabPages.Add(pagMovimentacao)

                'Seta Focu
                cboCodigoProdutoMovimentacao.Focus()

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Excluir()

        'Variaveis Locais
        Dim i As Integer

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdMovimentacao) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    For i = 0 To UBound(gSelecaoRow)
                        'Deleta Linha
                        gSelecaoRow(i).Delete()
                    Next

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

    Private Sub SalvarMovimentacao()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis 
            'Dim iCodigoProduto As Integer
            'Dim iCodigo As Integer
            'Dim sLote As String
            'Dim iCodigoDeposito As Integer
            'Dim iQuantidade As Double

            'iCodigoProduto = grdMovimentacao.CurrentRow.Cells("codigo_item").Value
            'iCodigo = grdListagem.CurrentRow.Cells("codigo").Value
            'sLote = grdMovimentacao.CurrentRow.Cells("lote").Value
            'iCodigoDeposito = grdMovimentacao.CurrentRow.Cells("codigo_deposito").Value
            'iQuantidade = grdMovimentacao.CurrentRow.Cells("quantidade").Value

            With grdMovimentacao.CurrentRow.Cells

               
                iCodigoProdutoMovimentacao = .Item("codigo_item").Value
                sLoteMovimentacao = .Item("lote").Value
                iCodigoDepositoMovimentacao = .Item("codigo_deposito").Value
                iQuantidadeMovimentacao = .Item("quantidade").Value

            End With

            'Salva Dados
            oClsEstMovimentacao.SalvarMovimentacao(grdMovimentacao, _
                                                   btnInserirMovimentacao.Tag, _
                                                   iCodigoProdutoMovimentacao, _
                                                   sLoteMovimentacao, _
                                                   iCodigoDepositoMovimentacao, _
                                                   iQuantidadeMovimentacao)

            'Informa o Usuário sobre o sucesso da Operação
            frmMain.Informacao(Mensagem.RegistroInserido)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ExcluirMovimentacao()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            ''Váriaveis 
            'Dim iCodigo As Integer

            'iCodigo = btnInserirMovimentacao.Tag

            'Salva Dados
            oClsEstMovimentacao.ExcluirMovimentacao(grdListagem, _
                                                   btnInserirMovimentacao.Tag)

            

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class
