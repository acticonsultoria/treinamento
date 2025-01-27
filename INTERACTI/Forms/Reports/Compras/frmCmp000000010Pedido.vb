Imports Janus.Windows.GridEX
Imports System.Reflection
Imports System.Reflection.Assembly

Public Class frmCmp000000010Pedido

#Region "::: VÁRIAVEIS :::"

    Private oClsCmp000000010 As New clsUsrCmp000000010
    Private oClsCmpPedido As New clsUsrCmpPedido

#End Region

#Region "::: CONTROLES :::"

#Region "::: GERAL :::"

    Private Sub frmCmp000000010Pedido_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter : Control_Enter(sender)

                Case Keys.Escape : Me.Dispose()

                Case Keys.F3

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboFornecedor" : Call btnProcurarFornecedor_Click(btnProcurarFornecedor, System.EventArgs.Empty)
                        Case "cboCentroGasto" : Call btnProcurarCentroGasto_Click(btnProcurarCentroGasto, System.EventArgs.Empty)
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

                Case Keys.Oemplus, Keys.Add

                    Select Case sender.Name
                        Case "cboFornecedor" : Call btnCadastrarFornecedor_Click(btnCadastrarFornecedor, System.EventArgs.Empty)
                        Case "cboCentroGasto" : Call btnCadastrarCentroGasto_Click(btnCadastrarCentroGasto, System.EventArgs.Empty)
                        Case "cboContaContabil" : Call btnCadastrarContaContabil_Click(btnCadastrarContaContabil, System.EventArgs.Empty)                        
                    End Select

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub frmCmp000000010Pedido_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        Call ConfigurarFormulario()

    End Sub

#End Region

#Region "::: IMPORTAR PEDIDO DE COMPRA :::"

    Private Sub btnAgruparGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGrid.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdPedidoCompra.GroupByBoxVisible = True Then

                'Exclui Linhas do Grupo
                For Each oGroup As GridEXGroup In grdPedidoCompra.RootTable.Groups
                    grdPedidoCompra.RootTable.Groups.Remove(oGroup)
                Next

                'Oculta Grupo
                grdPedidoCompra.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdPedidoCompra.GroupByBoxVisible = True
                grdPedidoCompra.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdPedidoCompra
            oForm.NomeFormulario = Formulario.ComprasPedido
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdPedidoCompra, Formulario.ComprasPedido)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta Grid - Excel
            Call ExportExcel(grdPedidoCompra)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnCadastrarFornecedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarFornecedor.Click

        Try

             'Carrega o form de parceiro de negócio
            LoadUsrControlForm(Me, "usrCadParceiroNegocio")

            'Carrega Combo            
            Call LoadCombo(cboFornecedor, "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa)

            'Seta Focu
            cboFornecedor.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnCadastrarCentroGasto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarCentroGasto.Click

        Try

                        'Abre Formulário de Cadastro
            LoadUsrControlForm(Me, "usrCadCentroGasto")

            'Carrega Combo            
            Call LoadCombo(cboCentroGasto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)

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
            Call LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa)

            'Seta Focu
            cboContaContabil.Focus()

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
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboFornecedor.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
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
            lCodigoItemFind = -1
            oComboBoxFind = cboCentroGasto

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

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

            'Seta Váriaveis
            lCodigoItemFind = -1
            oComboBoxFind = cboContaContabil

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Seta Focu
            cboContaContabil.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnAtualizarDataEntrega_Click(sender As Object, e As EventArgs) Handles btnAtualizarDataEntrega.Click

        Try

            For Each oRow As GridEXRow In grdPedidoCompra.GetDataRows
                grdPedidoCompra.Row = oRow.RowIndex
                grdPedidoCompra.SetValue("data_previsao_entrega", dtpDataEntrega.Value)
            Next

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnAtualizarCentroGasto_Click(sender As Object, e As EventArgs) Handles btnAtualizarCentroGasto.Click

        Try

            For Each oRow As GridEXRow In grdPedidoCompra.GetDataRows
                grdPedidoCompra.Row = oRow.RowIndex
                grdPedidoCompra.SetValue("codigo_centro_custo", IIf(cboCentroGasto.SelectedIndex = -1, DBNull.Value, cboCentroGasto.SelectedValue))
            Next

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnAtualizarContaContabil_Click(sender As Object, e As EventArgs) Handles btnAtualizarContaContabil.Click

        Try

            For Each oRow As GridEXRow In grdPedidoCompra.GetDataRows
                grdPedidoCompra.Row = oRow.RowIndex
                grdPedidoCompra.SetValue("conta_contabil", IIf(cboContaContabil.SelectedIndex = -1, DBNull.Value, cboContaContabil.SelectedValue))
            Next

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnPedidoCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPedidoCompra.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formulário
            If Validacao() = True Then

                'Verifica se o Usuário deseja Gerar o Pedido de Compra
                If MsgBox("Deseja gerar Pedido de Compra?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                    'Importar Pedido de Compra
                    ImportarPedidoCompra()

                End If

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboCongelarColuna_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCongelarColuna.SelectedIndexChanged

        Try

            If cboCongelarColuna.SelectedIndex = -1 Then
                grdPedidoCompra.FrozenColumns = 0
            Else
                grdPedidoCompra.FrozenColumns = cboCongelarColuna.SelectedValue
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoCompra_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdPedidoCompra.RowDoubleClick

        Try

            'Verifica se é Válido a Coluna
            If IsNothing(grdPedidoCompra.CurrentColumn) Then Exit Sub

            'Verifica a Coluna Selecionada
            Select Case grdPedidoCompra.CurrentColumn.Key

                Case "quantidade_estoque_reservado" : Call EstoqueReservado(grdPedidoCompra.CurrentRow.Cells("codigo").Value)
                Case "quantidade_compra" : Call QuantidadeCompra(grdPedidoCompra.CurrentRow.Cells("codigo").Value)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoCompra_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles grdPedidoCompra.CellUpdated

        Try

            'Verifica se é Válido a Coluna
            If IsNothing(e.Column) Then Exit Sub

            Dim dPrecoCompra As Double = 0
            Dim dQuantidade As Double = IIf(IsNumeric(grdPedidoCompra.GetValue("necessidade")), grdPedidoCompra.GetValue("necessidade"), 0)
            Dim dValorUnitario As Double = IIf(IsNumeric(grdPedidoCompra.GetValue("valor_unitario")), grdPedidoCompra.GetValue("valor_unitario"), 0)
            Dim dAliquotaICMS As Double = IIf(IsNumeric(grdPedidoCompra.GetValue("aliquota_icms")), grdPedidoCompra.GetValue("aliquota_icms"), 0) / 100.0
            Dim dAliquotaPISCOFINS As Double = IIf(IsNumeric(grdPedidoCompra.GetValue("aliquota_pis_cofins")), grdPedidoCompra.GetValue("aliquota_pis_cofins"), 0) / 100.0
            Dim dAliquotaIPI As Double = IIf(IsNumeric(grdPedidoCompra.GetValue("aliquota_ipi")), grdPedidoCompra.GetValue("aliquota_ipi"), 0) / 100.0

            If grdPedidoCompra.GetValue("ipi_embutido") = True Then
                dValorUnitario = (dValorUnitario / (1 + dAliquotaIPI))
            End If

            'Calcula ICMS / PIS / COFINS
            If grdPedidoCompra.GetValue("icms_embutido") = True And grdPedidoCompra.GetValue("pis_cofins_embutido") = True Then
                dValorUnitario = dValorUnitario
            ElseIf grdPedidoCompra.GetValue("icms_embutido") = True And grdPedidoCompra.GetValue("pis_cofins_embutido") = False Then
                dValorUnitario = (dValorUnitario / (1 - (dAliquotaPISCOFINS)))
            ElseIf grdPedidoCompra.GetValue("icms_embutido") = False And grdPedidoCompra.GetValue("pis_cofins_embutido") = True Then
                dValorUnitario = (dValorUnitario / (1 - (dAliquotaICMS)))
            ElseIf grdPedidoCompra.GetValue("icms_embutido") = False And grdPedidoCompra.GetValue("pis_cofins_embutido") = False Then
                dValorUnitario = (dValorUnitario / (1 - (dAliquotaICMS + dAliquotaPISCOFINS)))
            End If

            'Seta Controles
            UpdateRegistroGrid(grdPedidoCompra, "codigo = " & grdPedidoCompra.GetValue("codigo"), "valor_icms", dValorUnitario * grdPedidoCompra.GetValue("aliquota_icms"))
            UpdateRegistroGrid(grdPedidoCompra, "codigo = " & grdPedidoCompra.GetValue("codigo"), "valor_pis_cofins", dValorUnitario * grdPedidoCompra.GetValue("aliquota_pis_cofins"))
            UpdateRegistroGrid(grdPedidoCompra, "codigo = " & grdPedidoCompra.GetValue("codigo"), "valor_ipi", dValorUnitario * grdPedidoCompra.GetValue("aliquota_ipi"))

            'Seta Controle - Valor Total Imposto
            UpdateRegistroGrid(grdPedidoCompra, "codigo = " & grdPedidoCompra.GetValue("codigo"), "preco_compra", ((dValorUnitario + IIf(grdPedidoCompra.GetValue("icms_embutido") = True, 0, grdPedidoCompra.GetValue("valor_icms")) + IIf(grdPedidoCompra.GetValue("pis_cofins_embutido") = True, 0, grdPedidoCompra.GetValue("valor_pis_cofins")) + IIf(grdPedidoCompra.GetValue("ipi_embutido") = True, 0, grdPedidoCompra.GetValue("valor_ipi")))))
            UpdateRegistroGrid(grdPedidoCompra, "codigo = " & grdPedidoCompra.GetValue("codigo"), "preco_total", ((dValorUnitario + IIf(grdPedidoCompra.GetValue("icms_embutido") = True, 0, grdPedidoCompra.GetValue("valor_icms")) + IIf(grdPedidoCompra.GetValue("pis_cofins_embutido") = True, 0, grdPedidoCompra.GetValue("valor_pis_cofins")) + IIf(grdPedidoCompra.GetValue("ipi_embutido") = True, 0, grdPedidoCompra.GetValue("valor_ipi"))) * dQuantidade))

            'Atualiza Grid
            grdPedidoCompra.Refresh()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoCompra_RowCheckStateChanged(sender As Object, e As RowCheckStateChangeEventArgs) Handles grdPedidoCompra.RowCheckStateChanged

        Try

            'Atualiza Grid
            grdPedidoCompra.Refresh()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoCompra_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdPedidoCompra.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdPedidoCompra, _
                                     Formulario.ComprasPedido)

            'Carrega Coluna
            Call LoadComboColunasGrid(cboCongelarColuna, grdPedidoCompra)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoCompra_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdPedidoCompra.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdPedidoCompra.Name, _
                                     Formulario.ComprasPedido, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPedidoCompra_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdPedidoCompra.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdPedidoCompra.Name, _
                                          Formulario.ComprasPedido, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: GERAL :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf frmCmp000000010Pedido_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Tamanho / Posição do Formulário
            Me.Size = frmMain.tlpMain.Size : Me.Location = New Point(0, 23)

            'Direito
            btnExcelGrid.Enabled = VerificaDireito(Formulario.ComprasPedido, gcPrint)
            btnPedidoCompra.Enabled = VerificaDireito(Formulario.ComprasPedido, gcInsert)

            'Cadastros
            btnCadastrarFornecedor.Enabled = VerificaDireito(Formulario.CadastroBasicoParceiroNegocio, gcInsert)
            btnCadastrarContaContabil.Enabled = VerificaDireito(Formulario.CadastroBasicoPlanoContas, gcInsert)
            btnCadastrarCentroGasto.Enabled = VerificaDireito(Formulario.CadastroBasicoCentroGasto, gcInsert)

            'Carrega Combo
            Call LoadCombo(cboFornecedor, "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa, False)
            Call LoadComboColunasGrid(cboCongelarColuna, grdPedidoCompra)
            Call LoadComboGrid(grdPedidoCompra, "codigo_centro_custo", "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)
            Call LoadComboGrid(grdPedidoCompra, "conta_contabil", "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa)

            'Carrega Combo            
            Call LoadCombo(cboCentroGasto, "sp_select_combo_cadastro_basico_centro_custo " & goUsuario.iEmpresa)
            Call LoadCombo(cboContaContabil, "sp_select_combo_cadastro_basico_conta_contabil " & goUsuario.iEmpresa)

            'Seta CalendarCombo
            dtpDataEntrega.Value = Now.Date

            'Configura Grid
            Call ConfiguraGrid(grdPedidoCompra, Formulario.ComprasPedido)

            'Carrega Grid
            Call LoadGridPedidoCompra()

            'Seta Focu
            grdPedidoCompra.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: IMPORTAR PEDIDO DE COMPRA :::"

    Private Sub ImportarPedidoCompra()

        Try
            
            'Salva Pedido
            oClsCmpPedido.DataPedido = Now.Date
            oClsCmpPedido.CodigoFornecedor = cboFornecedor.SelectedValue
            oClsCmpPedido.CodigoParceiroNegocioContato = -1
            oClsCmpPedido.CodigoRequerente = -1
            oClsCmpPedido.CodigoModalidadeFrete = -1
            oClsCmpPedido.CodigoTransportadora = -1
            oClsCmpPedido.Observacao = ""
            oClsCmpPedido.CodigoAgenteLogistico = -1
            oClsCmpPedido.CodigoIncoterms = -1
            oClsCmpPedido.CodigoInstrucaoEmbarque = -1
            oClsCmpPedido.Referencia = ""
            oClsCmpPedido.CodigoCondicaoPagamento = -1
            oClsCmpPedido.CodigoFormaPagamento = -1
            oClsCmpPedido.CodigoMoeda = Moeda.Real
            oClsCmpPedido.FatorCambial = 1
            oClsCmpPedido.ValorTotal = grdPedidoCompra.GetTotalRow.Cells("preco_total").Value
            oClsCmpPedido.ValorDesconto = 0
            oClsCmpPedido.DescontoGeral = 0
            oClsCmpPedido.AcrescimoGeral = 0
            oClsCmpPedido.ValorFrete = 0
            oClsCmpPedido.ValorFreteImportacao = 0
            oClsCmpPedido.ValorFinal = grdPedidoCompra.GetTotalRow.Cells("preco_total").Value
            oClsCmpPedido.Insert()

            'Váriaveis Locais
            Dim sDataPrevisaoEntrega(0) As String
            Dim sQuantidade(0) As String

            'Insere Produtos
            For Each oRow As GridEXRow In grdPedidoCompra.GetDataRows

                sDataPrevisaoEntrega(0) = oRow.Cells("data_previsao_entrega").Value
                sQuantidade(0) = oRow.Cells("necessidade").Value

                'Insere Produto
                Call oClsCmpPedido.InsertProduto(oRow.Cells("codigo").Value, _
                                                 "", _
                                                 oRow.Cells("valor_unitario").Value, _
                                                 oRow.Cells("necessidade").Value, _
                                                 oRow.Cells("codigo_unidade_medida").Value, _
                                                 oRow.Cells("ipi_embutido").Value, _
                                                 oRow.Cells("aliquota_ipi").Value * 100.0, _
                                                 oRow.Cells("valor_ipi").Value, _
                                                 oRow.Cells("icms_embutido").Value, _
                                                 oRow.Cells("aliquota_icms").Value * 100.0, _
                                                 oRow.Cells("valor_icms").Value, _
                                                 oRow.Cells("pis_cofins_embutido").Value, _
                                                 oRow.Cells("aliquota_pis_cofins").Value * 100.0, _
                                                 oRow.Cells("valor_pis_cofins").Value, _
                                                 oRow.Cells("valor_unitario").Value, _
                                                 0, _
                                                 0, _
                                                 -1, _
                                                 IIf(IsDBNull(oRow.Cells("codigo_centro_custo").Value), -1, oRow.Cells("codigo_centro_custo").Value), _
                                                 IIf(IsDBNull(oRow.Cells("conta_contabil").Value), "", oRow.Cells("conta_contabil").Value), _
                                                 oRow.Cells("rc_item").Value, _
                                                 oRow.Cells("om_item").Value, _
                                                 sDataPrevisaoEntrega, _
                                                 sQuantidade, _
                                                 "",
                                                 "",
                                                 -1,
                                                 "")

            Next

            Dim oUsrControl As UserControl
            Dim oMenuPai As ToolStripMenuItem
            Dim oAssembly As Assembly = GetExecutingAssembly()
            Dim sText As String = "Pedido de Compra"

            'Seta UserControl
            oUsrControl = oAssembly.CreateInstance("INTERACTI.usrCmpPedido")
            oUsrControl.Tag = oClsCmpPedido.CodigoPedido
            oUsrControl.Dock = DockStyle.Fill

            'Configura Mascara
            Call ConfigureMaskEdit(oUsrControl) : Call LoadControlesTraducao(oUsrControl)

            'Carrega Página
            Call frmMain.LoadPage("usrCmpPedido", sText, oUsrControl)

            'Fecha o Formulário
            Me.Dispose()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridPedidoCompra()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid de Orçamento
            Call oClsCmp000000010.LoadGridPedidoCompra(grdPedidoCompra)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub EstoqueReservado(ByVal lCodigoItem As Long)

        Try

            'Variaveis Locais
            Dim oForm As New frmVenPedidoItemAberto

            'Seta Parametros
            oForm.CodigoItem = lCodigoItem
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub QuantidadeCompra(ByVal lCodigoItem As Long)

        Try

            'Variaveis Locais
            Dim oForm As New frmCmpQuantidadeAberto

            'Seta Parametros
            oForm.CodigoItem = lCodigoItem
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Verifica se foi Selecionado o Fornecedor
            If ValidaCampo(cboFornecedor, lblFornecedor) = False Then
                Exit Function
            End If

            For Each oRow As GridEXRow In grdPedidoCompra.GetDataRows

                'Valida Data Previsão Entrega
                If IsDBNull(oRow.Cells("data_previsao_entrega").Value) Then
                    grdPedidoCompra.MoveTo(oRow)
                    grdPedidoCompra.CurrentColumn = grdPedidoCompra.RootTable.Columns("data_previsao_entrega")
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Favor informar a Data de Previsão de Entrega")
                    grdPedidoCompra.Focus()
                    Exit Function
                End If

                'Valida Necessidade
                If IsDBNull(oRow.Cells("necessidade").Value) Then
                    grdPedidoCompra.MoveTo(oRow)
                    grdPedidoCompra.CurrentColumn = grdPedidoCompra.RootTable.Columns("necessidade")
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Favor informar a Necessidade de Compra")
                    grdPedidoCompra.Focus()
                    Exit Function
                End If

                'Valida Necessidade
                If IsDBNull(oRow.Cells("aliquota_icms").Value) Then
                    grdPedidoCompra.MoveTo(oRow)
                    grdPedidoCompra.CurrentColumn = grdPedidoCompra.RootTable.Columns("aliquota_icms")
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Favor informar a % ICMS")
                    grdPedidoCompra.Focus()
                    Exit Function
                End If

                'Valida Necessidade
                If IsDBNull(oRow.Cells("aliquota_ipi").Value) Then
                    grdPedidoCompra.MoveTo(oRow)
                    grdPedidoCompra.CurrentColumn = grdPedidoCompra.RootTable.Columns("aliquota_ipi")
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Favor informar a % IPI")
                    grdPedidoCompra.Focus()
                    Exit Function
                End If

                'Valida Necessidade
                If IsDBNull(oRow.Cells("aliquota_pis_cofins").Value) Then
                    grdPedidoCompra.MoveTo(oRow)
                    grdPedidoCompra.CurrentColumn = grdPedidoCompra.RootTable.Columns("aliquota_pis_cofins")
                    frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Favor informar a % PIS/COFINS")
                    grdPedidoCompra.Focus()
                    Exit Function
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

End Class