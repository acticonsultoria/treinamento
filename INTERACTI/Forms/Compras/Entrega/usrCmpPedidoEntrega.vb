Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Microsoft.Office.Interop

Public Class usrCmpPedidoEntrega

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCmpPedidoEntrega As New clsUsrCmpPedidoEntrega
    Private oRow As New Hashtable

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrCmpPedidoEntrega_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrCmpPedidoEntrega_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

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
            oForm.NomeFormulario = Formulario.ComprasPedidoControleEntrega
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ComprasPedidoControleEntrega)

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

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Try

            'Imprime Relatório
            Call ImprimirEntregaPendente()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Dados da Grid
            LoadGrid()

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

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Salva Dados do Registro
            Call Salvar()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnEntradaFisica_Click(sender As Object, e As EventArgs) Handles btnEntradaFisica.Click

        Try

            Call EntradaFisica()

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboCongelarColuna_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCongelarColuna.SelectedIndexChanged

        Try

            If cboCongelarColuna.SelectedIndex = -1 Then
                grdListagem.FrozenColumns = 3
            Else
                grdListagem.FrozenColumns = cboCongelarColuna.SelectedValue
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Coluna é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "imprimir" : ImprimirPedidoCompra(grdListagem.CurrentRow.Cells.Item("codigo_pedido").Value, _
                                                            grdListagem.CurrentRow.Cells.Item("reaprovar").Value)
                Case "comentario" : InserirHistorico()
                Case "historico" : LoadHistorico()
                Case "inspecao" : Inspecao()
                Case "entrada_fisica" : EntradaFisicaLinha()
                Case "excluir" : Excluir()
                Case "editar" : Editar(grdListagem.CurrentRow.Cells.Item("codigo_pedido").Value, _
                                       grdListagem.CurrentRow.Cells.Item("numero_pedido").Value, _
                                       IIf(IsDBNull(grdListagem.CurrentRow.Cells.Item("data_previsao_entrega").Value), "", grdListagem.CurrentRow.Cells.Item("data_previsao_entrega").Value), _
                                       IIf(IsDBNull(grdListagem.CurrentRow.Cells.Item("data_entrega").Value), "", grdListagem.CurrentRow.Cells.Item("data_entrega").Value), _
                                       grdListagem.CurrentRow.Cells.Item("fornecedor").Value, _
                                       grdListagem.CurrentRow.Cells.Item("status").Value, _
                                       grdListagem.CurrentRow.Cells.Item("codigo_item").Value, _
                                       grdListagem.CurrentRow.Cells.Item("codigo_pedido_item").Value, _
                                       grdListagem.CurrentRow.Cells.Item("descricao").Value, _
                                       IIf(IsDBNull(grdListagem.CurrentRow.Cells.Item("quantidade").Value), 0, grdListagem.CurrentRow.Cells.Item("quantidade").Value), _
                                       grdListagem.CurrentRow.Cells.Item("codigo").Value)

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdListagem_CellEdited(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.CellEdited

        Try

            'Seta Linha        
            If oRow.ContainsKey(grdListagem.CurrentRow.RowIndex) = False Then
                oRow.Add(grdListagem.CurrentRow.RowIndex, grdListagem.CurrentRow)
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.ComprasPedidoControleEntrega)

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
                                     Formulario.ComprasPedidoControleEntrega, _
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
                                          Formulario.ComprasPedidoControleEntrega, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdListagem.CellUpdated

        Try

            Select Case e.Column.Key

                Case "data_entrada_fisica"

                    oClsCmpPedidoEntrega.AtualizarDataEntradafisica(grdListagem.CurrentRow.Cells("codigo_pedido").Value, _
                                                                    grdListagem.CurrentRow.Cells("codigo_pedido_item").Value, _
                                                                    grdListagem.CurrentRow.Cells("codigo").Value, _
                                                                    IIf(IsDBNull(grdListagem.GetValue("data_entrada_fisica")), "", grdListagem.GetValue("data_entrada_fisica")))
                Case "data_entrega_contratual"

                    oClsCmpPedidoEntrega.AtualizarDataEntregaEmail(grdListagem.CurrentRow.Cells("codigo_pedido").Value, _
                                                                   grdListagem.CurrentRow.Cells("codigo_pedido_item").Value, _
                                                                   grdListagem.CurrentRow.Cells("codigo").Value, _
                                                                   grdListagem.GetValue("data_entrega_contratual"), _
                                                                   "C", _
                                                                   grdListagem.GetValue("pn_topo"), _
                                                                   grdListagem.GetValue("referencia"))

                Case "data_previsao_entrega"

                    oClsCmpPedidoEntrega.AtualizarDataEntregaEmail(grdListagem.CurrentRow.Cells("codigo_pedido").Value, _
                                                                   grdListagem.CurrentRow.Cells("codigo_pedido_item").Value, _
                                                                   grdListagem.CurrentRow.Cells("codigo").Value, _
                                                                   grdListagem.GetValue("data_previsao_entrega"), _
                                                                   "P", _
                                                                   grdListagem.GetValue("pn_topo"), _
                                                                   grdListagem.GetValue("referencia"))

                    'Váriavel - Integração
                    Dim oClsIntegracao As New clsIntegracao

                    'Salva Financeiro - Receita
                    oClsIntegracao.IntegracaoPedidoCompraFinanceiro(grdListagem.CurrentRow.Cells("codigo_pedido").Value, _
                                                                    False)

                Case "percentual_execucao"

                    If IsNumeric(grdListagem.CurrentRow.Cells("percentual_execucao").Value) Then

                        oClsCmpPedidoEntrega.AtualizarPercentualExecucao(grdListagem.CurrentRow.Cells("codigo_pedido").Value, _
                                                                         grdListagem.CurrentRow.Cells("codigo_pedido_item").Value, _
                                                                         grdListagem.CurrentRow.Cells("percentual_execucao").Value)
                    End If


            End Select

            LoadGrid()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnExcluirLinhaEntrega_Click(sender As Object, e As EventArgs)

        Try

            ExcluirLinhaEntrega()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCmpPedidoEntrega_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnSalvar.Enabled = VerificaDireito(Formulario.ComprasPedidoControleEntrega, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.ComprasPedidoControleEntrega, gcPrint)
            btnImprimir.Enabled = VerificaDireito(Formulario.ComprasPedidoControleEntrega, gcPrint)

            'Carrega Combo
            Call LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_venda_pedido_item_entrega")
            Call LoadComboSimNao(cboFollowUpFitro)
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

            'Configura DateTimer
            dtpDataPrevisaoEntregaInicioFiltro.Value = Now.Date : dtpDataPrevisaoEntregaInicioFiltro.Checked = False
            dtpDataPrevisaoEntregaTerminoFiltro.Value = Now.Date : dtpDataPrevisaoEntregaTerminoFiltro.Checked = False
            dtpDataEntregaInicioFiltro.Value = Now.Date : dtpDataEntregaInicioFiltro.Checked = False
            dtpDataEntregaTerminoFiltro.Value = Now.Date : dtpDataEntregaTerminoFiltro.Checked = False

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ComprasPedidoControleEntrega)

            'Seta Focu
            txtNumeroPedidoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim sStatus As String = ""

            'Status
            If cboStatusFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboStatusFiltro.CheckedValues)
                    sStatus &= IIf(sStatus = "", "", ",") & cboStatusFiltro.CheckedValues(i).ToString
                Next
            End If

            'Carrega Controles
            oClsCmpPedidoEntrega.LoadGrid(grdListagem, _
                                          IIf(IsNumeric(txtNumeroPedidoFiltro.Text.Trim), txtNumeroPedidoFiltro.Text.Trim, -1), _
                                          IIf(dtpDataPrevisaoEntregaInicioFiltro.Checked = False, "", dtpDataPrevisaoEntregaInicioFiltro.Value), _
                                          IIf(dtpDataPrevisaoEntregaTerminoFiltro.Checked = False, "", dtpDataPrevisaoEntregaTerminoFiltro.Value), _
                                          txtFornecedorFiltro.Text.Trim, _
                                          txtItemFiltro.Text.Trim, _
                                          IIf(dtpDataEntregaInicioFiltro.Checked = False, "", dtpDataEntregaInicioFiltro.Value), _
                                          IIf(dtpDataEntregaTerminoFiltro.Checked = False, "", dtpDataEntregaTerminoFiltro.Value), _
                                          sStatus, _
                                          IIf(cboFollowUpFitro.SelectedIndex = -1, -1, IIf(cboFollowUpFitro.SelectedValue = True, 1, 0)))

            grdListagem.Row = 0

            'Limpa Linha
            oRow.Clear()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EntradaFisica()

        Try

            'Verifica se selecionou alguma linha
            If VerificaSelecaoRow(grdListagem) = True Then

                'Seta cursor
                Cursor.Current = Cursors.WaitCursor

                'Insere na tabela temporária
                oClsCmpPedidoEntrega.InsertDataEntradaFisicaTempPublic()

                'Abre o Form
                Dim oForm As New frmCmpPedidoProdutoEntregaDataEntradaFisica
                oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.Location

                'Abre Formulário
                oForm.ShowDialog()

                Call LoadGrid()

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Salva Dados da Entrega
            Call oClsCmpPedidoEntrega.Save(oRow)

            'Carrega Grid
            Call LoadGrid()

            'Informa o usuário sobre o sucesso da operação
            frmMain.Informacao(Mensagem.RegistroSalvo)

            'Limpa oRow
            oRow.Clear()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub InserirHistorico()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Abre Formulário
            Dim oForm As New frmCmpPedidoProdutoEntregaHistoricoInserir

            'Seta Parâmetros
            oForm.Grid = grdListagem
            oForm.NumeroPedido = grdListagem.CurrentRow.Cells("numero_pedido").Value
            oForm.DataPedido = grdListagem.CurrentRow.Cells("data_pedido").Value
            oForm.ParceiroNegocio = grdListagem.CurrentRow.Cells("fornecedor").Value
            oForm.Produto = grdListagem.CurrentRow.Cells("codigo_item").Value & " - " & grdListagem.CurrentRow.Cells("descricao").Value
            oForm.Quantidade = grdListagem.CurrentRow.Cells("quantidade").Value
            oForm.UnidadeMedida = grdListagem.CurrentRow.Cells("unidade_medida").Value
            oForm.ValorUnitario = grdListagem.CurrentRow.Cells("valor_unitario").Value
            oForm.ValorTotal = grdListagem.CurrentRow.Cells("valor_unitario").Value * grdListagem.CurrentRow.Cells("quantidade").Value

            'Abre Formulário
            oForm.ShowDialog()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadHistorico()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Abre Formulário
            Dim oForm As New frmCmpPedidoProdutoEntregaHistorico

            'Seta Tamanho / Posição do Fórmulário
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.Location

            'Seta Parâmetros
            oForm.Grid = grdListagem
            oForm.NumeroPedido = grdListagem.CurrentRow.Cells("numero_pedido").Value
            oForm.DataPedido = grdListagem.CurrentRow.Cells("data_pedido").Value
            oForm.ParceiroNegocio = grdListagem.CurrentRow.Cells("fornecedor").Value
            oForm.Produto = grdListagem.CurrentRow.Cells("codigo_item").Value & " - " & grdListagem.CurrentRow.Cells("descricao").Value
            oForm.Quantidade = grdListagem.CurrentRow.Cells("quantidade").Value
            oForm.UnidadeMedida = grdListagem.CurrentRow.Cells("unidade_medida").Value
            oForm.ValorUnitario = grdListagem.CurrentRow.Cells("valor_unitario").Value
            oForm.ValorTotal = grdListagem.CurrentRow.Cells("valor_unitario").Value * grdListagem.CurrentRow.Cells("quantidade").Value

            'Abre Formulário
            oForm.ShowDialog()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ImprimirPedidoCompra(ByVal lCodigoPedidoCapa As Long, _
                                     ByVal bReaprovar As Boolean)

        Try

            'Verifica se o usuário tem direito de Imprimir
            If VerificaDireito(Formulario.ComprasPedido, gcPrint) = False Then
                frmMain.Informacao(Mensagem.DireitoImprimir)
            End If

            If bReaprovar = True Then
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Este Pedido de Compra Necessita ser Reaprovado.")
                Exit Sub
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Dim oClsCmpPedido As New clsUsrCmpPedido

            'Váriaveis - Locais
            Dim sReport As String
            Dim sUF As String = oClsCmpPedido.LoadUFParceiroNegocioPedido(lCodigoPedidoCapa)

            'Váriavel - Formulário
            Dim oForm As New frmRptSelecionar
            oForm.Tipo = "PEDIDO DE COMPRA"
            oForm.ShowDialog(Me)
            sReport = oForm.Relatorio

            'Verifica o Relatório
            If sReport = "" Then Exit Sub

            'Seta Váriavel
            sReport &= ".rpt"

            If sUF = "EX" Then
                sReport = sReport.Replace(".rpt", "E.rpt")
            End If

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
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_pedido"
            goCrystalReport.sReportParameter(1).sValue = lCodigoPedidoCapa
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

    Private Sub ImprimirEntregaPendente()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Redimenciona Vetor
            ReDim goCrystalReport.sReportParameter(6)
            'Seta Parametros
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
            goCrystalReport.sReportParameter(2).sParamenter = "@numero_pedido"
            goCrystalReport.sReportParameter(2).sValue = IIf(IsNumeric(txtNumeroPedidoFiltro.Text.Trim), txtNumeroPedidoFiltro.Text, -1)
            goCrystalReport.sReportParameter(3).sParamenter = "@data_previsao_entrega_inicio"
            goCrystalReport.sReportParameter(3).sValue = IIf(dtpDataPrevisaoEntregaInicioFiltro.Checked = False, "NULL", dtpDataPrevisaoEntregaInicioFiltro.Value)
            goCrystalReport.sReportParameter(4).sParamenter = "@data_previsao_entrega_termino"
            goCrystalReport.sReportParameter(4).sValue = IIf(dtpDataPrevisaoEntregaTerminoFiltro.Checked = False, "NULL", dtpDataPrevisaoEntregaTerminoFiltro.Value)
            goCrystalReport.sReportParameter(5).sParamenter = "@fornecedor"
            goCrystalReport.sReportParameter(5).sValue = txtFornecedorFiltro.Text.Trim
            goCrystalReport.sReportParameter(6).sParamenter = "@item"
            goCrystalReport.sReportParameter(6).sValue = txtItemFiltro.Text.Trim
            goCrystalReport.sReport = goCrystalReport.sPath & "CMP000000011.rpt"

            Dim oReport As New usrReport
            oReport.Dock = DockStyle.Fill

            'Abre Relatório
            frmMain.LoadPageReport("CMP000000011", "Pedido de Compra - Entregas Pendentes", oReport)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Inspecao()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            If IsDate(grdListagem.CurrentRow.Cells("data_entrega").Value) = False Then
                MsgBox("Este Item não foi entregue.", MsgBoxStyle.Exclamation, "Validação")
                Exit Sub
            End If

            'Abre Formulário
            Dim oForm As New frmCmpPedidoProdutoInspecao

            'Seta Parâmetros
            oForm.CodigoPedido = grdListagem.CurrentRow.Cells("codigo_pedido").Value
            oForm.CodigoPedidoItem = grdListagem.CurrentRow.Cells("codigo_pedido_item").Value
            oForm.CodigoPedidoItemEntrega = grdListagem.CurrentRow.Cells("codigo").Value
            oForm.NumeroPedido = grdListagem.CurrentRow.Cells("numero_pedido").Value
            oForm.DataPedido = grdListagem.CurrentRow.Cells("data_pedido").Value
            oForm.ParceiroNegocio = grdListagem.CurrentRow.Cells("fornecedor").Value
            oForm.CodigoProduto = grdListagem.CurrentRow.Cells("codigo_item").Value
            oForm.Quantidade = grdListagem.CurrentRow.Cells("quantidade_entregue").Value
            oForm.DataPrevisaoEntrega = grdListagem.CurrentRow.Cells("data_previsao_entrega").Value

            'Abre Formulário
            oForm.ShowDialog()

            Call LoadGrid()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EntradaFisicaLinha()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Abre Formulário
            Dim oForm As New frmCmpPedidoNovaEntradaFisica

            'Seta Parâmetros
            oForm.CodigoPedido = grdListagem.CurrentRow.Cells("codigo_pedido").Value
            oForm.CodigoPedidoItem = grdListagem.CurrentRow.Cells("codigo_pedido_item").Value
            oForm.CodigoPedidoItemEntrega = grdListagem.CurrentRow.Cells("codigo").Value
            oForm.NumeroPedido = grdListagem.CurrentRow.Cells("numero_pedido").Value
            oForm.DataPedido = grdListagem.CurrentRow.Cells("data_pedido").Value
            oForm.ParceiroNegocio = grdListagem.CurrentRow.Cells("fornecedor").Value
            oForm.CodigoProduto = grdListagem.CurrentRow.Cells("codigo_item").Value
            oForm.Quantidade = grdListagem.CurrentRow.Cells("quantidade").Value
            oForm.DataPrevisaoEntrega = grdListagem.CurrentRow.Cells("data_previsao_entrega").Value

            'Abre Formulário
            oForm.ShowDialog()

            Call LoadGrid()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Excluir()

        Try

            'Verifica se é ADM ou ADM Processo
            If goUsuario.iPerfil = 1 Or goUsuario.iPerfil = 8 Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente esta linha?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    oClsCmpPedidoEntrega.DeleteLinha(grdListagem.CurrentRow.Cells("codigo_pedido").Value, _
                                                     grdListagem.CurrentRow.Cells("codigo_pedido_item").Value, _
                                                     grdListagem.CurrentRow.Cells("codigo").Value)

                    LoadGrid()

                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário que ele não tem Direito
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Editar(ByVal iCodigoPedido As Long, _
                       ByVal sNumeroPedido As String, _
                       ByVal sDataPrevisaoEntrega As String, _
                       ByVal sDataEntrega As String, _
                       ByVal sFornecedor As String, _
                       ByVal sStatus As String, _
                       ByVal iCodigoItem As String, _
                       ByVal iCodigoPedidoItem As Integer, _
                       ByVal sDescricaoItem As String, _
                       ByVal dQuantidade As Double, _
                       ByVal iCodigo As Integer)
        Try

            'Váriaveis Locais
            Dim oForm As New frmCmpEditarPedidoEntrega
            'Seta Tamanho e Localização do Formulário
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location
            oForm.CodigoPedido = iCodigoPedido
            oForm.NumeroPedido = sNumeroPedido
            oForm.Fornecedor = sFornecedor
            oForm.CodigoItem = iCodigoItem
            oForm.CodigoPedidoItem = iCodigoPedidoItem
            oForm.Descricao = sDescricaoItem
            oForm.Quantidade = dQuantidade
            oForm.Codigo = iCodigo

            oForm.ShowDialog(Me)

            If oForm.Finalizado = False Then Exit Sub

            LoadGrid()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ExcluirLinhaEntrega()

        Try

            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, "", "s " & gSelecaoRow.Count) & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsCmpPedidoEntrega.DeleteLinhasEntrega()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class


