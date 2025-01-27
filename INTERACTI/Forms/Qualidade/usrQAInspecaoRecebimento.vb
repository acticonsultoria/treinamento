Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Microsoft.Office.Interop

Public Class usrQAInspecaoRecebimento

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsUsrQAInspecaoRecebimento As New clsUsrQAInspecaoRecebimento
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
            oForm.NomeFormulario = Formulario.QualidadeInspecaoRecebimento
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.QualidadeInspecaoRecebimento)

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

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            LoadGrid()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.Text)
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

                Case "historico" : Call LoadHistorico()
                Case "inspecao" : Call Inspecao()

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
                                     Formulario.QualidadeInspecaoRecebimento)

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
                                     Formulario.QualidadeInspecaoRecebimento, _
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
                                          Formulario.QualidadeInspecaoRecebimento, _
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

                Case "referencia_estoque"

                    oClsUsrQAInspecaoRecebimento.UpdateReferenciaEstoque(grdListagem.CurrentRow.Cells("codigo_pedido").Value, _
                                                                     grdListagem.CurrentRow.Cells("codigo_pedido_item").Value, _
                                                                     grdListagem.CurrentRow.Cells("codigo").Value, _
                                                                     IIf(IsDBNull(grdListagem.CurrentRow.Cells("referencia_estoque").Value) = True, "", grdListagem.CurrentRow.Cells("referencia_estoque").Value))
            End Select

            LoadGrid()

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
            btnExcelGrid.Enabled = VerificaDireito(Formulario.QualidadeInspecaoRecebimento, gcPrint)

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
            Call ConfiguraGrid(grdListagem, Formulario.QualidadeInspecaoRecebimento)

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

            oClsUsrQAInspecaoRecebimento.LoadGrid(grdListagem, _
                                               IIf(IsNumeric(txtNumeroPedidoFiltro.Text.Trim), txtNumeroPedidoFiltro.Text.Trim, -1), _
                                               IIf(dtpDataPrevisaoEntregaInicioFiltro.Checked = False, "", dtpDataPrevisaoEntregaInicioFiltro.Value), _
                                               IIf(dtpDataPrevisaoEntregaTerminoFiltro.Checked = False, "", dtpDataPrevisaoEntregaTerminoFiltro.Value), _
                                               txtFornecedorFiltro.Text.Trim, _
                                               txtItemFiltro.Text.Trim, _
                                               IIf(dtpDataEntregaInicioFiltro.Checked = False, "", dtpDataEntregaInicioFiltro.Value), _
                                               IIf(dtpDataEntregaTerminoFiltro.Checked = False, "", dtpDataEntregaTerminoFiltro.Value), _
                                               sStatus, _
                                               IIf(cboFollowUpFitro.SelectedIndex = -1, -1, IIf(cboFollowUpFitro.SelectedValue = True, 1, 0)), _
                                               chkAguardandoInspecao.Checked)

            grdListagem.Row = 0

            oRow.Clear()

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

    Private Sub Inspecao()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            If IsDate(grdListagem.CurrentRow.Cells("data_entrada_fisica").Value) = False Then
                MsgBox("Este Item não possui Data de Entrada Física!", MsgBoxStyle.Exclamation, "Validação")
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

#End Region

End Class


