Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Microsoft.Office.Interop
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Math

Public Class usrVenPedidoEntrega

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsVenPedidoEntrega As New clsUsrVenPedidoEntrega
    Private oRow As New Hashtable

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrVenPedidoEntrega_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

                Case Keys.F3

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "txtClienteFiltro" : Call btnProcurarClienteFiltro_Click(btnProcurarClienteFiltro, System.EventArgs.Empty)
                        Case "txtProdutoFiltro" : Call btnProcurarProdutoFiltro_Click(btnProcurarProdutoFiltro, System.EventArgs.Empty)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrVenPedidoEntrega_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: CONTROLE DE ENTREGA :::"

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
            oForm.NomeFormulario = Formulario.ComercialPedidoVendaControleEntrega
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ComercialPedidoVendaControleEntrega)

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
            sItemVendaFind = "S"
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

    Private Sub cboCongelarColuna_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCongelarColuna.SelectedIndexChanged

        Try

            If cboCongelarColuna.SelectedIndex = -1 Then
                grdListagem.FrozenColumns = 2
            Else
                grdListagem.FrozenColumns = cboCongelarColuna.SelectedValue
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
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

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica a Linha é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            'Verifica que Coluna foi Pressionada
            Select Case grdListagem.CurrentColumn.Key

                Case "imprimir" : Call ImprimirPedidoVenda(grdListagem.CurrentRow.Cells("codigo_pedido").Value)
                Case "desmembrar_entrega" : Call DesmembrarEntrega()
                Case "quantidade_po_transito" : Call LoadPedidoCompraTransito()

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
                                     Formulario.ComercialPedidoVendaControleEntrega)

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
                                     Formulario.ComercialPedidoVendaControleEntrega, _
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
                                          Formulario.ComercialPedidoVendaControleEntrega, _
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

            Cursor.Current = Cursors.WaitCursor

            Select Case e.Column.Key

                Case "data_entrega_contratual"

                    Call oClsVenPedidoEntrega.AtualizarDataEntregaContratual(grdListagem.CurrentRow.Cells("codigo_pedido").Value, _
                                                                      grdListagem.CurrentRow.Cells("codigo_pedido_item").Value, _
                                                                      grdListagem.CurrentRow.Cells("codigo").Value, _
                                                                      grdListagem.GetValue("data_entrega_contratual"))

                Case "data_previsao_entrega"

                    Call oClsVenPedidoEntrega.AtualizarDataEntregaPrevista(grdListagem.CurrentRow.Cells("codigo_pedido").Value, _
                                                                      grdListagem.CurrentRow.Cells("codigo_pedido_item").Value, _
                                                                      grdListagem.CurrentRow.Cells("codigo").Value, _
                                                                      grdListagem.GetValue("data_previsao_entrega"))

                    Call oClsVenPedidoEntrega.IntegracaoFinanceiro(grdListagem.CurrentRow.Cells("codigo_pedido").Value)

            End Select

            Call LoadGrid()



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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrVenPedidoEntrega_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnSalvar.Enabled = VerificaDireito(Formulario.ComercialPedidoVendaControleEntrega, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.ComercialPedidoVendaControleEntrega, gcPrint)

            If goUsuario.iCodigoTipoEmpresa = TipoEmpresa.Comercio Then
                grdListagem.RootTable.Columns.Remove("ordem_producao")
            End If

            'Carrega Combo
            Call LoadCombo(cboVendedorInternoFiltro, "sp_select_combo_cadastro_basico_vendedor " & goUsuario.iEmpresa & ", " & goUsuario.iUsuario)
            Call LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_venda_pedido_item_entrega")
            cboEstoqueFiltro.Items.Clear()
            cboEstoqueFiltro.Items.Add("EM ESTOQUE", 1)
            cboEstoqueFiltro.Items.Add("EM TRÂNSITO", 2)
            cboEstoqueFiltro.Items.Add("EM ESTOQUE + TRÂNSITO", 3)
            cboEstoqueFiltro.Items.Add("SEM ESTOQUE E SEM TRÂNSITO", 4)
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

            'Configura DateTimer
            dtpDataPrevisaoEntregaInicioFiltro.Value = Now.Date : dtpDataPrevisaoEntregaInicioFiltro.Checked = True
            dtpDataPrevisaoEntregaTerminoFiltro.Value = Now.Date : dtpDataPrevisaoEntregaTerminoFiltro.Checked = False
            dtpDataEntregaInicioFiltro.Value = Now.Date : dtpDataEntregaInicioFiltro.Checked = False
            dtpDataEntregaTerminoFiltro.Value = Now.Date : dtpDataEntregaTerminoFiltro.Checked = False
            dtpDataAceiteInicioFiltro.Value = Now.Date : dtpDataAceiteInicioFiltro.Checked = False
            dtpDataAceiteTerminoFiltro.Value = Now.Date : dtpDataAceiteTerminoFiltro.Checked = False

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.ComercialPedidoVendaControleEntrega)

            'Seta Focu
            txtNumeroPedidoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: CONTROLE DE ENTREGA :::"

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
            oClsVenPedidoEntrega.LoadGrid(grdListagem, _
                                          IIf(IsNumeric(txtNumeroPedidoFiltro.Text.Trim), txtNumeroPedidoFiltro.Text.Trim, -1), _
                                          IIf(dtpDataPrevisaoEntregaInicioFiltro.Checked = False, "", dtpDataPrevisaoEntregaInicioFiltro.Value), _
                                          IIf(dtpDataPrevisaoEntregaTerminoFiltro.Checked = False, "", dtpDataPrevisaoEntregaTerminoFiltro.Value), _
                                          txtClienteFiltro.Text.Trim, _
                                          txtProdutoFiltro.Text.Trim, _
                                          IIf(dtpDataEntregaInicioFiltro.Checked = False, "", dtpDataEntregaInicioFiltro.Value), _
                                          IIf(dtpDataEntregaTerminoFiltro.Checked = False, "", dtpDataEntregaTerminoFiltro.Value), _
                                          sStatus, _
                                          IIf(cboEstoqueFiltro.SelectedIndex = -1, -1, cboEstoqueFiltro.SelectedValue), _
                                          IIf(dtpDataAceiteInicioFiltro.Checked = False, "", dtpDataAceiteInicioFiltro.Value), _
                                          IIf(dtpDataAceiteTerminoFiltro.Checked = False, "", dtpDataAceiteTerminoFiltro.Value), _
                                          IIf(cboVendedorInternoFiltro.SelectedIndex = -1, -1, cboVendedorInternoFiltro.SelectedValue))

            'Limpa Linha
            oRow.Clear()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Salva Dados da Entrega
            oClsVenPedidoEntrega.Save(oRow)

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

    Private Sub LoadPedidoCompraTransito()

        Try

            'Verifica se existe Quantidade de PO em Trânsito
            If grdListagem.CurrentRow.Cells("quantidade_po_transito").Value > 0 Then

                'Váriavel - Formulário
                Dim oForm As New frmCmpQuantidadeAberto
                'Seta Parâmetro
                oForm.CodigoItem = grdListagem.CurrentRow.Cells("codigo_item").Value
                oForm.Tipo = 2
                'Abre o Formulário
                Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            Else
                'Informa o Usuário que não existe PO em Trânsito
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Não existe Compra Trânsito.")
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DesmembrarEntrega()

        Try

            'Verifica se existe Quantidade de PO em Trânsito
            If grdListagem.CurrentRow.Cells("quantidade_pendente").Value > 0 Then

                'Váriavel - Formulário
                Dim oForm As New frmVenPedidoEntregaDesmembrar

                'Seta Parâmetro
                oForm.CodigoPedido = grdListagem.CurrentRow.Cells("codigo_pedido").Value
                oForm.CodigoPedidoItem = grdListagem.CurrentRow.Cells("codigo_pedido_item").Value
                oForm.CodigoPedidoItemEntrega = grdListagem.CurrentRow.Cells("codigo").Value
                oForm.Item = grdListagem.CurrentRow.Cells("descricao").Value
                oForm.Quantidade = grdListagem.CurrentRow.Cells("quantidade_pendente").Value
                oForm.DataEntrega = grdListagem.CurrentRow.Cells("data_previsao_entrega").Value

                'Abre o Formulário
                Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            Else
                'Informa o Usuário que não existe PO em Trânsito
                frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Não possui Quantidade Pendente.")
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ImprimirPedidoVenda(ByVal lCodigoPedidoCapa As Long)

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriavel - Relatório
            Dim sReport As String = ""

            'Váriavel - Formulário
            Dim oForm As New frmRptSelecionar
            oForm.Tipo = "PEDIDO DE VENDA"
            oForm.ShowDialog(Me)
            sReport = oForm.Relatorio

            'Verifica o Relatório
            If sReport = "" Then Exit Sub

            'Carrega Váriavel
            sReport &= ".rpt"

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
            'Seta Parametros - Report
            oReport.Tabela = "tb_ven_pedido"
            oReport.Codigo = lCodigoPedidoCapa
            oReport.Arquivo = True
            'Abre Relatório
            frmMain.LoadPageReport("VEN000000002", "Pedido de Venda", oReport)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class


