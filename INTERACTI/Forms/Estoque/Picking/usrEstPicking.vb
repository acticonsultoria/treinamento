Imports Janus.Windows.EditControls
Imports Microsoft.Office.Interop
Imports Janus.Windows.GridEX
Imports CrystalDecisions.CrystalReports.Engine

Public Class usrEstPicking

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsEstPicking As New clsUsrEstPicking
    Private oCurrentRow As GridEXRow

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrEstPicking_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", Microsoft.VisualBasic.CompareMethod.Text) > 0 Then
                        If InStr(sender.name, "Grafico", Microsoft.VisualBasic.CompareMethod.Text) > 0 Then
                            Call LoadGrid()
                        End If
                    End If

                Case Keys.F3

                    Select Case sender.Name
                        Case "txtClienteFiltro" : Call btnProcurarClienteFiltro_Click(btnProcurarClienteFiltro, System.EventArgs.Empty)
                        Case "txtProdutoFiltro" : Call btnProcurarProdutoFiltro_Click(btnProcurarProdutoFiltro, System.EventArgs.Empty)
                    End Select

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboNumeroPedidoVenda" : Call LoadCombo(cboNumeroPedidoVenda, "sp_select_combo_venda_pedido_picking " & goUsuario.iEmpresa & ", " & goUsuario.iUsuario)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrEstPicking_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: LISTAGEM :::"

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.EstoquePicking
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.EstoquePicking)

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

            'Exporta Planilha para Excel
            Call ExportExcel(grdListagem)

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
            oMaskedEditBoxFind = txtClienteFiltro

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            txtClienteFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnProcurarProdutoFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurarProdutoFiltro.Click

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
            oMaskedEditBoxFind = txtProdutoFiltro

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            txtProdutoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Grid
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Try

            'Cancelar Registros
            Call Cancelar()

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
            tabMain.TabPages.Add(pagDados)

            'Configura Valor Default
            Call ConfigureValorDefault(Me)

            'Seta Focu
            cboNumeroPedidoVenda.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click

        Try

            'Prepara o Formulário para Inserção de um Novo Registro
            Call Novo()

            'Configura Valor Default
            Call ConfigureValorDefault(Me)

            'Seta Focu        
            cboNumeroPedidoVenda.Focus()

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
            txtNumeroPedidoFiltro.Focus()

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

    Private Sub grdListagem_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Linha é válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "imprimir" : Call Imprimir(grdListagem.CurrentRow.Cells("codigo_picking").Value)
                Case "email" : Call Email(grdListagem.CurrentRow.Cells("codigo_picking").Value, _
                                          grdListagem.CurrentRow.Cells("numero_picking").Value, _
                                          grdListagem.CurrentRow.Cells("codigo_pedido").Value, _
                                          grdListagem.CurrentRow.Cells("codigo_cliente").Value)
                Case "historico" : Call Historico()
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
                                     Formulario.EstoquePicking)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.EstoquePicking, _
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
                                          Formulario.EstoquePicking, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: PEDIDO DE VENDA :::"

    Private Sub btnConfigurarGridPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridPedido.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdPedido
            oForm.NomeFormulario = Formulario.EstoquePicking
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdPedido, Formulario.EstoquePicking)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnAgruparGridPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridPedido.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdPedido.GroupByBoxVisible = True Then

                'Exclui Linhas do Grupo
                For Each oGroup As GridEXGroup In grdPedido.RootTable.Groups
                    grdPedido.RootTable.Groups.Remove(oGroup)
                Next

                'Oculta Grupo
                grdPedido.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdPedido.GroupByBoxVisible = True
                grdPedido.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridPedido.Click

        Try

            'Exporta Planilha para Excel
            Call ExportExcel(grdPedido)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboNumeroPedidoVenda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNumeroPedidoVenda.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado algum Registro
            If cboNumeroPedidoVenda.SelectedIndex = -1 Then

                'Limpa Controles
                oCurrentRow = Nothing
                txtDataPedido.Text = ""
                txtCliente.Text = ""
                txtNumeroPedidoCliente.Text = ""
                grdPedido.DataSource = Nothing

                'Limpa Controles - Picking
                cboDeposito.SelectedIndex = -1
                txtLote.Text = ""
                cboLote.SelectedIndex = -1
                txtQuantidade.Value = 0
                txtQuantidadeEstoque.Value = 0
                grdPicking.DataSource = Nothing
                btnInserirPicking.Tag = ""

            Else

                'Carrega Dados do Pedido
                Call oClsEstPicking.LoadDadosPedidoVenda(cboNumeroPedidoVenda.SelectedValue, _
                                                         txtDataPedido, _
                                                         txtCliente, _
                                                         txtNumeroPedidoCliente)

                'Carrega Grid
                Call LoadGridPedidoVenda()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdPedido_RowCheckStateChanged(sender As Object, e As RowCheckStateChangeEventArgs) Handles grdPedido.RowCheckStateChanged

        Try

            'Verifica se tem alguma Linha Selecionada
            If e.Row.CheckState = RowCheckState.Checked Then

                'Desmarca Linha Anterior
                If IsNothing(oCurrentRow) = False Then
                    oCurrentRow.CheckState = RowCheckState.Unchecked
                End If

                'Seta Váriavel
                oCurrentRow = e.Row

            Else
                'Limpa Váriavel
                oCurrentRow = Nothing
            End If

            'Atualiza Picking
            grdPedido.Refresh()

            'Prepara Formulário
            Call NovoPicking()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdPedido_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdPedido, _
                                     Formulario.EstoquePicking)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdPedido_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdPedido.Name, _
                                     Formulario.EstoquePicking, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdPedido_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdPedido.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdPedido.Name, _
                                          Formulario.EstoquePicking, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: PICKING :::"

    Private Sub btnInserirPicking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirPicking.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If ValidacaoPicking() = True Then

                'Váriaveis Locais
                Dim iCodigoDepositoAntigo As Integer = 0
                Dim sLoteAntigo As String = ""
                Dim dQuantidadeAntigo As Double = 0

                'Carrega dados Antigos
                If IsNumeric(btnInserirPicking.Tag) Then
                    iCodigoDepositoAntigo = grdPicking.CurrentRow.Cells("codigo_deposito").Value
                    sLoteAntigo = IIf(IsDBNull(grdPicking.CurrentRow.Cells("lote").Value), "", grdPicking.CurrentRow.Cells("lote").Value)
                    dQuantidadeAntigo = grdPicking.CurrentRow.Cells("quantidade").Value
                End If

                'Salva Dados do Registro
                Call InsertPickingGrid(grdPicking, _
                                       cboDeposito.Text, _
                                       IIf(cboLote.Visible = False, txtLote.Text.Trim, cboLote.SelectedValue), _
                                       txtQuantidade.Value, _
                                       cboDeposito.SelectedValue, _
                                       iCodigoDepositoAntigo, _
                                       sLoteAntigo, _
                                       dQuantidadeAntigo)

                'Atualiza Picking
                Call AtualizaPicking()

                'Prepara Formulário para Inserção de um Novo Registro
                Call NovoPicking()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluirPicking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirPicking.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Deleta Picking
            Call DeletePicking()

            'Atualiza Picking
            Call AtualizaPicking()

            'Limpa Formulário
            Call NovoPicking()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Valida Dados da Pedido de Venda
            If Validacao() = True Then

                'Salva dados do Picking
                Call SalvarPicking()

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboDeposito_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDeposito.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado Algum Registro
            If cboLote.Enabled = True And cboLote.Visible = True And grpPicking.Enabled = True And IsNothing(oCurrentRow) = False Then

                'Verifica se foi Selecionado Algum Depósito
                If cboDeposito.SelectedIndex = -1 Then
                    'Limpa Controles
                    cboLote.DataSource = Nothing : cboLote.Text = ""
                    txtQuantidadeEstoque.Text = ""
                Else
                    'Carrega Combo - Lote
                    Call LoadCombo(cboLote, "sp_select_combo_cadastro_basico_deposito_item_lote " & oCurrentRow.Cells("codigo_item").Value & ", " & cboDeposito.SelectedValue & ", " & goUsuario.iEmpresa)
                End If

            ElseIf (cboLote.Enabled = False Or cboLote.Visible = False) And grdPicking.Enabled = True And IsNothing(oCurrentRow) = False Then

                'Váriavel Local
                Dim dQuantidadeEstoque As Double = 0

                'Carrega Quantidade do Estoque
                Call oClsEstPicking.LoadQuantidadeEstoque(oCurrentRow.Cells("codigo_item").Value, _
                                                          cboDeposito.SelectedValue, _
                                                          "", _
                                                          dQuantidadeEstoque)

                'Carrega Controle
                txtQuantidadeEstoque.Value = dQuantidadeEstoque

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboLote_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLote.SelectedIndexChanged

        Try

            'Verifica se foi Selecionado Algum Registro
            If cboLote.Enabled = True And cboLote.SelectedIndex > -1 Then

                'Váriavel Local
                Dim dQuantidadeEstoque As Double = 0

                'Carrega Quantidade do Estoque
                Call oClsEstPicking.LoadQuantidadeEstoque(oCurrentRow.Cells("codigo_item").Value, _
                                                          cboDeposito.SelectedValue, _
                                                          cboLote.SelectedValue, _
                                                          dQuantidadeEstoque)

                'Carrega Controle
                txtQuantidadeEstoque.Value = dQuantidadeEstoque

            Else

                'Limpa Controle
                txtQuantidadeEstoque.Value = 0

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdPicking_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdPicking.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdPicking.CurrentColumn) Then Exit Sub

            'Verifica o Tipo de Operação
            Select Case grdPicking.CurrentColumn.Key

                Case "editar" : Call EditarPicking()

            End Select

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrEstPicking_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito do Usuário
            btnSalvar.Enabled = VerificaDireito(Formulario.EstoquePicking, gcInsert)
            btnNovo.Enabled = VerificaDireito(Formulario.EstoquePicking, gcInsert)
            btnNovo1.Enabled = VerificaDireito(Formulario.EstoquePicking, gcInsert)
            btnCancelar.Enabled = VerificaDireito(Formulario.EstoquePicking, gcAdministrator)
            btnInserirPicking.Enabled = VerificaDireito(Formulario.EstoquePicking, gcInsert)
            btnExcluirPicking.Enabled = VerificaDireito(Formulario.EstoquePicking, gcDelete)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.EstoquePicking, gcPrint)
            btnExcelGridPedido.Enabled = VerificaDireito(Formulario.EstoquePicking, gcPrint)

            'Carrega ComboBox            
            Call LoadCombo(cboGrupoItemFiltro, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)
            Call LoadCombo(cboStatusPicking, "sp_select_combo_static_status_estoque_picking")

            'Seta Datetime
            dtpDataPickingInicioFiltro.Value = Now.Date : dtpDataPickingInicioFiltro.Checked = False
            dtpDataPickingTerminoFiltro.Value = Now.Date : dtpDataPickingTerminoFiltro.Checked = False

            'Limpa Váriavel
            oCurrentRow = Nothing

            'Seta Controle
            If CType(LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'lote_texto_emissao'"), Boolean) = True Then
                cboLote.Visible = False : txtLote.Visible = True
            Else
                cboLote.Visible = True : txtLote.Visible = False
            End If

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.EstoquePicking)
            Call ConfiguraGrid(grdPedido, Formulario.EstoquePicking)
            Call ConfiguraGrid(grdPicking, Formulario.EstoquePicking)

            'Oculta Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            txtNumeroPickingFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: LISTAGEM :::"

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim sCodigoGrupoItem As String = ""
            Dim i As Integer

            'Grupo de Item
            If cboGrupoItemFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboGrupoItemFiltro.CheckedValues)
                    sCodigoGrupoItem &= IIf(sCodigoGrupoItem = "", "", ",") & cboGrupoItemFiltro.CheckedValues(i).ToString
                Next
            End If

            'Carrega Controles
            Call oClsEstPicking.LoadGrid(grdListagem, _
                                         txtNumeroPickingFiltro.Text.Trim, _
                                         IIf(dtpDataPickingInicioFiltro.Checked = False, "", dtpDataPickingInicioFiltro.Value), _
                                         IIf(dtpDataPickingTerminoFiltro.Checked = False, "", dtpDataPickingTerminoFiltro.Value), _
                                         txtNumeroPedidoFiltro.Text.Trim, _
                                         txtNumeroPedidoClienteFiltro.Text.Trim, _
                                         txtReferenciaFiltro.Text.Trim, _
                                         txtClienteFiltro.Text.Trim, _
                                         sCodigoGrupoItem, _
                                         txtProdutoFiltro.Text.Trim, _
                                         IIf(cboStatusPicking.SelectedIndex = -1, -1, cboStatusPicking.SelectedValue))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            txtNumeroPicking.Text = ""
            txtDataPicking.Text = Format(Now.Date, "dd/MM/yyyy")
            cboNumeroPedidoVenda.SelectedIndex = -1
            cboNumeroPedidoVenda.Tag = "I"
            grdPedido.DataSource = Nothing
            btnSalvar.Enabled = VerificaDireito(Formulario.EstoquePicking, gcInsert)

            'Limpa Controles - Picking
            cboDeposito.SelectedIndex = -1
            cboLote.SelectedIndex = -1
            txtQuantidade.Value = 0
            txtQuantidadeEstoque.Value = 0
            grdPicking.DataSource = Nothing
            btnInserirPicking.Tag = ""

            'Carrega Combo
            Call LoadCombo(cboNumeroPedidoVenda, "sp_select_combo_venda_pedido_picking " & goUsuario.iEmpresa & ", " & goUsuario.iUsuario, False)

            'Seta Focu
            cboNumeroPedidoVenda.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar()

        Try

            'Verifica o Status
            If grdListagem.CurrentRow.Cells("status").Value = CInt(StatusPicking.Picking) Then

                'Verifica se o Usuário tem direito de Alterar
                If VerificaDireito(Formulario.EstoquePicking, gcUpdate) = True Then

                    'Configura Valor Default
                    Call ConfigureValorDefault(Me)

                    'Limpa Grid
                    grdPedido.DataSource = Nothing
                    grdPicking.DataSource = Nothing

                    'Carrega Combo
                    Call LoadCombo(cboNumeroPedidoVenda, "sp_select_combo_venda_pedido_picking_editar " & goUsuario.iEmpresa & ", " & goUsuario.iUsuario, False)

                    'Seta Controle
                    cboNumeroPedidoVenda.Tag = grdListagem.CurrentRow.Cells("codigo_picking").Value

                    'Seta Controle
                    txtNumeroPicking.Text = grdListagem.CurrentRow.Cells("numero_picking").Value
                    txtDataPicking.Text = grdListagem.CurrentRow.Cells("data_picking").Value
                    cboNumeroPedidoVenda.SelectedValue = grdListagem.CurrentRow.Cells("codigo_pedido").Value

                    'Alterna Aba        
                    tabMain.TabPages.Remove(pagListagem)
                    tabMain.TabPages.Add(pagDados)

                    'Seta Focu
                    cboNumeroPedidoVenda.Focus()

                Else
                    'Informa o Usuário que ele não possui direito
                    frmMain.Informacao(Mensagem.DireitoAlteracao)
                End If

            Else
                'Informa o usuário que o Picking não pode ser alterado
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Este Picking já se encontra " & IIf(grdListagem.CurrentRow.Cells("status").Value = CInt(StatusPicking.Cancelado), "Cancelado.", "Faturado."))
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
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
                    Call oClsEstPicking.Delete()

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

    Private Sub Imprimir(ByVal lCodigoPicking As Long)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriavel - Relatório
            Dim sReport As String = "EST000000007.rpt"

            'Redimenciona Vetor
            ReDim goCrystalReport.sReportParameter(2)
            'Seta Parametros
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_picking"
            goCrystalReport.sReportParameter(1).sValue = lCodigoPicking
            goCrystalReport.sReportParameter(2).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(2).sValue = goUsuario.iEmpresa
            goCrystalReport.sReport = goCrystalReport.sPath & sReport

            Dim oReport As New usrReport
            oReport.Dock = DockStyle.Fill

            'Abre Relatório
            frmMain.LoadPageReport("EST000000007", "Picking", oReport)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Email(ByVal lCodigoPicking As Long, _
                      ByVal sNumeroPicking As String, _
                      ByVal lCodigoPedidoVenda As Long, _
                      ByVal iCodigoCliente As Integer)

        Try

            'Váriaveis Locais
            Dim oRptDocument As New ReportDocument

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriavel - Relatório
            Dim sReport As String = "EST000000007.rpt"

            'Abre Relatório
            oRptDocument.Load(goCrystalReport.sPath & sReport, _
                              CrystalDecisions.Shared.OpenReportMethod.OpenReportByTempCopy)

            'Seta Parametros Relatório
            oRptDocument.SetParameterValue("@codigo_picking", lCodigoPicking)
            oRptDocument.SetParameterValue("@codigo_empresa", goUsuario.iEmpresa)
            oRptDocument.SetParameterValue("usuario", goUsuario.sNome)

            'Abre Conexão com o Banco de Dados
            For i = 0 To oRptDocument.DataSourceConnections.Count - 1
                oRptDocument.DataSourceConnections.Item(i).SetConnection(goDatabase.sDataSource, goDatabase.sInitialCatalog, goDatabase.sUserID, goDatabase.sPassword)
            Next

            'Arquivo
            Dim sArquivo As String = System.IO.Path.GetTempPath
            sArquivo &= sNumeroPicking.Replace("/", "-").Replace("\", "-") & ".pdf"

            'Exporta para Arquivo PDF
            oRptDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, _
                                      sArquivo)

            'Limpa Váriavel
            oRptDocument = Nothing

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Enviar E-mail
            Call EnviarEmail(goUsuario.sEmpresa & " - Picking " & sNumeroPicking, _
                             LoadContatoVenda(lCodigoPedidoVenda), _
                             sArquivo, _
                             sArquivo, _
                             "", _
                             iCodigoCliente)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: PEDIDO DE VENDA :::"

    Private Sub LoadGridPedidoVenda()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Váriavel
            oCurrentRow = Nothing

            'Carrega Grid
            Call oClsEstPicking.LoadGridPedidoVenda(grdPedido, _
                                                    cboNumeroPedidoVenda.SelectedValue, _
                                                    IIf(IsNumeric(cboNumeroPedidoVenda.Tag), cboNumeroPedidoVenda.Tag, -1))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: PICKING :::"

    Private Sub NovoPicking()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Limpa Controles
            cboDeposito.SelectedIndex = -1
            txtQuantidade.Value = 0
            btnInserirPicking.Tag = ""
            btnExcluirPicking.Tag = ""

            'Verifica se foi Selecionado a Linha
            If IsNothing(oCurrentRow) = False Then

                'Carrega Grid
                Call LoadGridPicking(oCurrentRow.Cells("picking").Value, _
                                     oCurrentRow.Cells("codigo_picking").Value, _
                                     oCurrentRow.Cells("codigo_picking_produto").Value)
                cboLote.Enabled = oCurrentRow.Cells("controla_lote").Value
                txtLote.Enabled = oCurrentRow.Cells("controla_lote").Value
                'Carrega Combo
                Call LoadCombo(cboDeposito, "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa & ", 1, NULL, 0", False)
                'Habilita Entrega
                grpPicking.Enabled = True
                txtLote.Text = ""

            Else

                'Desabilita Controles
                grdPicking.DataSource = Nothing
                cboLote.Text = ""
                txtLote.Text = ""

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridPicking(ByVal sPicking As String, _
                                ByVal lCodigoPicking As Long, _
                                ByVal iCodigoPickingProduto As Integer)

        Try

            'Limpa Grid
            grdPicking.DataSource = Nothing

            'Carrega Grid
            'Call oClsEstPicking.LoadGridPicking(grdPicking, _
            '                                    lCodigoPicking, _
            '                                    iCodigoPickingProduto)

            'Verifica se existe alguma Picking Lançada
            If sPicking = "" Then Exit Sub

            'Váriaveis Locais
            Dim sPickings() As String = sPicking.Split("|")
            Dim sDadosPicking() As String

            For i As Integer = 0 To UBound(sPickings)

                sDadosPicking = sPickings(i).Split("§")

                'Insere Dados do Picking
                Call InsertPickingGrid(grdPicking, _
                                       sDadosPicking(0), _
                                       sDadosPicking(1), _
                                       sDadosPicking(2), _
                                       sDadosPicking(3), _
                                       -1, _
                                       "", _
                                       -1)
            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub InsertPickingGrid(ByVal oGrid As GridEX, _
                                  ByVal sDeposito As String, _
                                  ByVal sLote As String, _
                                  ByVal dQuantidade As Double, _
                                  ByVal iCodigoDeposito As Integer, _
                                  ByVal iCodigoDepositoAntigo As Integer, _
                                  ByVal sLoteAntigo As String, _
                                  ByVal dQuantidadeAntigo As Double)

        Try

            'Variaveis Locais
            Dim oDataSet As New DataSet
            Dim oDataTable As New DataTable
            Dim oDataRow As DataRow
            Dim oDCDeposito As New DataColumn("deposito")
            Dim oDCLote As New DataColumn("lote")
            Dim oDCQuantidade As New DataColumn("quantidade")
            Dim oDCCodigoDeposito As New DataColumn("codigo_deposito")

            'Verifica se o DataSource é Vazio
            If Not oGrid.DataSource Is Nothing Then
                oDataSet = oGrid.DataSource.DataSet
                oDataTable = oDataSet.Tables(0)
                oGrid.DataSource = Nothing
            Else
                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)
                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCDeposito)
                oDataTable.Columns.Add(oDCLote)
                oDataTable.Columns.Add(oDCQuantidade)
                oDataTable.Columns.Add(oDCCodigoDeposito)
                'Seta DataType
                oDCQuantidade.DataType = 0.0.GetType
            End If

            'Verifica o Tipo de Operação
            If IsNumeric(btnInserirPicking.Tag) = False Then
                'Adiciona Linhas ao DataTable
                oDataRow = oDataTable.NewRow
                oDataRow("deposito") = sDeposito
                oDataRow("lote") = IIf(sLote = "", DBNull.Value, sLote)
                oDataRow("quantidade") = dQuantidade
                oDataRow("codigo_deposito") = iCodigoDeposito
                oDataTable.Rows.Add(oDataRow)
            Else
                Dim sQuery As String = ""
                sQuery = "(codigo_deposito = " & iCodigoDepositoAntigo & ")"
                sQuery &= IIf(sLote = "", "", " AND (lote = '" & sLoteAntigo & "')")
                sQuery &= " AND (quantidade = " & dQuantidadeAntigo & ")"
                oDataRow = oDataTable.Select(sQuery)(0)
                oDataRow("deposito") = sDeposito
                oDataRow("lote") = IIf(sLote = "", DBNull.Value, sLote)
                oDataRow("quantidade") = dQuantidade
                oDataRow("codigo_deposito") = iCodigoDeposito
            End If

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DeletePicking()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdPicking) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    Call oClsEstPicking.DeletePickingProdutoEntrega()

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

    Private Sub EditarPicking()

        Try

            'Limpa Formulário
            Call NovoPicking()

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.EstoquePicking, gcUpdate) = True Then

                With grdPicking.CurrentRow.Cells

                    'Carrega Controles
                    cboDeposito.SelectedValue = .Item("codigo_deposito").Value
                    If IsDBNull(.Item("lote").Value) = False Then cboLote.SelectedValue = .Item("lote").Value : txtLote.Text = .Item("lote").Value
                    txtQuantidade.Value = .Item("quantidade").Value
                    btnInserirPicking.Tag = grdPicking.CurrentRow.RowIndex
                    btnExcluirPicking.Tag = .Item("quantidade").Value

                End With

                'Seta Focu
                cboDeposito.Focus()

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub SalvarPicking()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se o Usuário deseja Efetuar o Picking
            If MsgBox("Confirma o Picking referente ao Pedido " & cboNumeroPedidoVenda.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                'Insere Picking
                Call oClsEstPicking.InsertPicking(cboNumeroPedidoVenda.SelectedValue, _
                                                  txtDataPicking.Text.Trim, _
                                                  txtNumeroPicking, _
                                                  IIf(IsNumeric(cboNumeroPedidoVenda.Tag), cboNumeroPedidoVenda.Tag, 0))

                'Insere Picking - Produto
                Call oClsEstPicking.InsertPickingProduto(grdPedido)

                'Informa o Usuário sobre o Sucesso da Operação
                frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub AtualizaPicking()

        Try

            'Váriaveis Locais
            Dim sQuery As String
            Dim sPicking As String = ""
            Dim dQuantidadePicking As Double = 0

            'Seta Query
            sQuery = "((codigo_pedido = " & oCurrentRow.Cells("codigo_pedido").Value & ") "
            sQuery &= "AND (codigo_pedido_item = " & oCurrentRow.Cells("codigo_pedido_item").Value & ") "
            sQuery &= "AND (codigo_pedido_item_entrega = " & oCurrentRow.Cells("codigo_pedido_item_entrega").Value & "))"

            'Carrega Picking
            For Each oRow As GridEXRow In grdPicking.GetDataRows
                sPicking &= IIf(sPicking = "", "", "|")
                sPicking &= oRow.Cells("deposito").Value & "§"
                sPicking &= oRow.Cells("lote").Value & "§"
                sPicking &= oRow.Cells("quantidade").Value & "§"
                sPicking &= oRow.Cells("codigo_deposito").Value
            Next

            'Carrega Quantidade Picking
            If grdPicking.GetDataRows.Count > 0 Then
                dQuantidadePicking = grdPicking.GetTotalRow.Cells("quantidade").Value
            End If

            'Atualiza Grid
            Call UpdateRegistroGrid(grdPedido, sQuery, "quantidade_picking_elaboracao", dQuantidadePicking)
            Call UpdateRegistroGrid(grdPedido, sQuery, "picking", sPicking)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Historico()

        Try

            'Carrega Formulário
            Dim oForm As New frmEstPickingHistorico

            'Seta Parâmetros
            oForm.NumeroPicking = grdListagem.CurrentRow.Cells("numero_picking").Value
            oForm.DataPicking = grdListagem.CurrentRow.Cells("data_picking").Value
            oForm.NumeroPedido = grdListagem.CurrentRow.Cells("numero_pedido").Value
            oForm.Cliente = grdListagem.CurrentRow.Cells("razao_social").Value
            oForm.CodigoPicking = grdListagem.CurrentRow.Cells("codigo_picking").Value

            'Abre Formúlário
            oForm.ShowDialog(Me)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Cancelar()

        Try

            'Verifica se foi Selecionado Algum Registro
            If VerificaSelecaoRow(grdListagem, "status", CInt(StatusPicking.Picking)) = True Then

                'Carrega Formulário
                Dim oForm As New frmEstPickingCancelar
                'Abre Formúlário
                oForm.ShowDialog(Me)

                'Carrega Grid
                Call LoadGrid()

            Else
                'Informa o Usuário sobre a necessidade de Selecionar um Registro
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Verifica se alguma Requisição foi Atendida
            For Each oRow As GridEXRow In grdPedido.GetDataRows
                If oRow.Cells("picking").Value <> "" Then
                    Return True
                End If
            Next

            'Retorno da Função
            Return False

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Function ValidacaoPicking() As Boolean

        Try

            'Seta Retorno da Função
            ValidacaoPicking = False

            'Verifica se foi Selecionado o Campo - Depósito
            If ValidaCampo(cboDeposito, lblDeposito) = False Then
                Exit Function
            End If

            'Verifica se foi Selecionado o Campo - Lote
            If cboLote.Enabled = True And cboLote.Visible = True Then
                If ValidaCampo(cboLote, lblLote) = False Then
                    Exit Function
                End If
            End If

            'Verifica se foi Selecionado o Campo - Lote
            If txtLote.Enabled = True And txtLote.Visible = True Then
                If ValidaCampo(txtLote, lblLote, TipoCampo.texto) = False Then
                    Exit Function
                End If
            End If

            'Verifica se o Registro é Duplicado
            If IsNumeric(btnInserirPicking.Tag) Then
                For Each oRow As GridEXRow In grdPicking.GetDataRows
                    If oRow.Cells("codigo_deposito").Value = cboDeposito.SelectedValue And _
                        IIf(IsDBNull(oRow.Cells("lote").Value), "", oRow.Cells("lote").Value) = IIf(cboLote.SelectedIndex = -1, "", cboLote.SelectedValue) And _
                        oRow.RowIndex <> btnInserirPicking.Tag Then
                        frmMain.errInfo.SetError(lblDeposito, "Estes Dados já foram informados anteriormente.")
                        cboDeposito.Focus()
                        Exit Function
                    End If
                Next
            Else
                For Each oRow As GridEXRow In grdPicking.GetDataRows
                    If oRow.Cells("codigo_deposito").Value = cboDeposito.SelectedValue And _
                        IIf(IsDBNull(oRow.Cells("lote").Value), "", oRow.Cells("lote").Value) = IIf(cboLote.Visible = True, IIf(cboLote.SelectedIndex = -1, "", cboLote.SelectedValue), txtLote.Text.Trim) Then
                        frmMain.errInfo.SetError(lblDeposito, "Estes Dados já foram informados anteriormente.")
                        cboDeposito.Focus()
                        Exit Function
                    End If
                Next
            End If

            'Verifica se foi Preenchido o Campo - Quantidade
            If ValidaCampo(txtQuantidade, lblQuantidade, True) = False Then
                Exit Function
            End If

            'Verifica se a Quantidade é maior que a Quantidade Requerida
            Dim dQuantidade As Double = 0
            If grdPicking.GetDataRows.Count > 0 Then dQuantidade = grdPicking.GetTotalRow.Cells("quantidade").Value
            If IsNumeric(btnExcluirPicking.Tag) Then dQuantidade -= btnExcluirPicking.Tag
            If (oCurrentRow.Cells("quantidade").Value - oCurrentRow.Cells("quantidade_entregue").Value) < (txtQuantidade.Value + dQuantidade) Then
                frmMain.errInfo.SetError(lblQuantidade, "A Quantidade informada é maior que a Quantidade do Pedido.")
                txtQuantidade.Focus()
                Exit Function
            End If

            'Verifica se a Quantidade em Estoque é Suficiente
            If txtQuantidade.Value > txtQuantidadeEstoque.Value AndAlso _
               CType(LoadDescricao("sp_select_configuracao_interacti " & goUsuario.iEmpresa & ", 'controla_estoque'"), Boolean) = True Then
                frmMain.errInfo.SetError(lblQuantidade, "A Quantidade em Estoque é insuficiente para o Picking.")
                txtQuantidade.Focus()
                Exit Function
            End If

            'Seta Retorno da Função
            ValidacaoPicking = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

End Class
