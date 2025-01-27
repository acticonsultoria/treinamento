Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Imports BoletoNet

Public Class usrFinReceitaPagamentoBoletoBancario

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsFinReceitaPagamentoBoletoBancario As New clsUsrFinReceitaPagamentoBoletoBancario

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrFinReceitaPagamentoBoletoBancario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

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

    Private Sub usrFinReceitaPagamentoBoletoBancario_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: PAGAMENTO :::"

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
            oForm.NomeFormulario = Formulario.FinanceiroReceitaPagamentoBoletoBancario
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FinanceiroReceitaPagamentoBoletoBancario)

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

            'Carrega Dados da Grid
            Call LoadGrid()

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

    Private Sub grdListagem_RowCheckStateChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowCheckStateChangeEventArgs) Handles grdListagem.RowCheckStateChanged

        Try

            'Calcula Valor Total Selecionado
            lblValorTitulo.Text = "R$ " & FormatNumber(CalculaValorTotalSelecionado(grdListagem), 2, Microsoft.VisualBasic.TriState.True)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Coluna pressionada é Válida
            If IsNothing(grdListagem) Then Exit Sub

            'Verifica a Coluna Selecionada
            Select Case grdListagem.CurrentColumn.Key

                Case "boleto_bancario" : Call BoletoBancario()
                Case "imprimir" : Call ImprimirBoletoBancario()
                Case "email" : Call EmailBoletoBancario()

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
                                     Formulario.FinanceiroReceitaPagamentoBoletoBancario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.FinanceiroReceitaPagamentoBoletoBancario, _
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
                                          Formulario.FinanceiroReceitaPagamentoBoletoBancario, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: PARCELA :::"

    Private Sub btnAgruparGridParcela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgruparGridParcela.Click

        Try

            'Verifica se o Grupo está Habilita
            If grdParcela.GroupByBoxVisible = True Then

                'Oculta Grupo
                grdParcela.GroupByBoxVisible = False

            Else

                'Exibe Grupo
                grdParcela.GroupByBoxVisible = True
                grdParcela.HideColumnsWhenGrouped = InheritableBoolean.True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGridParcela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridParcela.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdParcela
            oForm.NomeFormulario = Formulario.FinanceiroReceitaPagamentoBoletoBancario
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdParcela, Formulario.FinanceiroReceitaPagamentoBoletoBancario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGridParcela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridParcela.Click

        Try

            'Exporta Grid para Excel
            Call ExportExcel(grdParcela)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnPagar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagar1.Click

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Verifica se foi Selecionado algum Registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Carrega Grid
                Call LoadGridDuplicatas(grdParcela)

                'Alterna Aba                
                tabMain.TabPages.Remove(pagListagem)
                tabMain.TabPages.Add(pagDados)

                'Habilita Botão
                btnPagar.Enabled = True

            Else
                'Informa o Usuário da Necessidade de Selecionar um ou mai Registro
                MsgBox("Primeiramente Selecione um ou mais Registros.", MsgBoxStyle.Exclamation, Me.Parent.Text)
            End If

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagar.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Dados do Formúlário
            If Validacao() = True Then
                'Salva Pagamento
                Call Salvar()
            End If

            'Seta Controle
            btnPagar.Enabled = False

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
            tabMain.TabPages.Add(pagListagem)
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            txtNumeroDocumentoFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdParcela_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdParcela.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdParcela, _
                                     Formulario.FinanceiroReceitaPagamentoBoletoBancario)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdParcela_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdParcela.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdParcela.Name, _
                                     Formulario.FinanceiroReceitaPagamentoBoletoBancario, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdParcela_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdParcela.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdParcela.Name, _
                                          Formulario.FinanceiroReceitaPagamentoBoletoBancario, _
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

#Region "::: DADOS GERAIS :::"

    Private Sub ConfigurarUserControl()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFinReceitaPagamentoBoletoBancario_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Direito
            btnPagar.Enabled = VerificaDireito(Formulario.FinanceiroReceitaPagamentoBoletoBancario, gcInsert)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.FinanceiroReceitaPagamentoBoletoBancario, gcPrint)
            btnExcelGridParcela.Enabled = VerificaDireito(Formulario.FinanceiroReceitaPagamentoBoletoBancario, gcPrint)
           
            'Carrega Combo
            Call LoadCombo(cboTipoDocumentoFiltro, "sp_select_combo_cadastro_basico_tipo_documento " & goUsuario.iEmpresa)

            'Seta Controle
            dtpDataEmissaoInicioFiltro.Value = Now.Date : dtpDataEmissaoInicioFiltro.Checked = False
            dtpDataEmissaoTerminoFiltro.Value = Now.Date : dtpDataEmissaoTerminoFiltro.Checked = False
            dtpDataVencimentoInicioFiltro.Value = Now.Date : dtpDataVencimentoInicioFiltro.Checked = False
            dtpDataVencimentoTerminoFiltro.Value = Now.Date : dtpDataVencimentoTerminoFiltro.Checked = False

            'Oculta Aba
            tabMain.TabPages.Remove(pagDados)

            'Seta Focu
            txtNumeroDocumentoFiltro.Focus()

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FinanceiroReceitaPagamentoBoletoBancario)
            Call ConfiguraGrid(grdParcela, Formulario.FinanceiroReceitaPagamentoBoletoBancario)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: PAGAMENTO :::"

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            lblValorTitulo.Text = "R$ 0,00"

            'Carrega Controles
            oClsFinReceitaPagamentoBoletoBancario.LoadGrid(grdListagem, _
                                                           txtNumeroDocumentoFiltro.Text.Trim, _
                                                           IIf(dtpDataEmissaoInicioFiltro.Checked = False, "", dtpDataEmissaoInicioFiltro.Value), _
                                                           IIf(dtpDataEmissaoTerminoFiltro.Checked = False, "", dtpDataEmissaoTerminoFiltro.Value), _
                                                           txtClienteFiltro.Text.Trim, _
                                                           IIf(dtpDataVencimentoInicioFiltro.Checked = False, "", dtpDataVencimentoInicioFiltro.Value), _
                                                           IIf(dtpDataVencimentoTerminoFiltro.Checked = False, "", dtpDataVencimentoTerminoFiltro.Value), _
                                                           IIf(cboTipoDocumentoFiltro.SelectedIndex = -1, -1, cboTipoDocumentoFiltro.SelectedValue), _
                                                           IIf(IsNumeric(txtCarteiraFiltro.Text.Trim), txtCarteiraFiltro.Text.Trim, -1), _
                                                           IIf(IsNumeric(txtNumeroDocumentoPagamentoFiltro.Text.Trim), txtNumeroDocumentoPagamentoFiltro.Text.Trim, -1), _
                                                           txtValorFiltro.Value)


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function CalculaValorTotalSelecionado(ByVal oGrid As GridEX) As Double

        Try

            'Variaveis Locais
            Dim dTotal As Double = 0

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            For Each oRow As GridEXRow In oGrid.GetCheckedRows
                dTotal += oRow.Cells("valor_corrigido").Value
            Next

            'Seta Retorno da Função
            Return dTotal

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub BoletoBancario()

        Try

            'Abre Formulário
            Dim oForm As New frmFinReceitaBoletoBancarioDLL
            oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location
            oForm.CodigoTituloCapa = grdListagem.CurrentRow.Cells("codigo_titulo_capa").Value
            oForm.NumeroParcela = grdListagem.CurrentRow.Cells("numero_parcela").Value
            oForm.NumeroDocumento = grdListagem.CurrentRow.Cells("numero_documento").Value
            oForm.Cliente = grdListagem.CurrentRow.Cells("cliente").Value

            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Recarrega Grid
            Call LoadGrid()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ImprimirBoletoBancario()

        Try

            'Váriaveis Locais
            Dim oClsFinReceitaBoletoBancario As New clsFrmFinReceitaBoletoBancario
            Dim sArquivo As String = ""

            'Carrega Boleto
            oClsFinReceitaBoletoBancario.LoadArquivoBoleto(grdListagem.CurrentRow.Cells("codigo_titulo_capa").Value, _
                                                           grdListagem.CurrentRow.Cells("numero_documento").Value, _
                                                           sArquivo, _
                                                           grdListagem.CurrentRow.Cells("numero_parcela").Value)

            'Abre Página
            webBrowser.Navigate(sArquivo)

            While Not webBrowser.ReadyState = WebBrowserReadyState.Complete
                System.Threading.Thread.Sleep(100)
                Application.DoEvents()
            End While

            'Abre Tela de Impressão
            webBrowser.ShowPrintPreviewDialog()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub EmailBoletoBancario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Váriaveis Locais
            Dim oClsFinReceitaBoletoBancario As New clsFrmFinReceitaBoletoBancario
            Dim sArquivo As String = ""

            'Carrega Boleto
            oClsFinReceitaBoletoBancario.LoadArquivoBoleto(grdListagem.CurrentRow.Cells("codigo_titulo_capa").Value, _
                                                           grdListagem.CurrentRow.Cells("numero_documento").Value, _
                                                           sArquivo, _
                                                           grdListagem.CurrentRow.Cells("numero_parcela").Value)


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

            'Enviar E-mail
            Call EnviarEmail("Boleto Bancário: " & grdListagem.CurrentRow.Cells("numero_documento").Value & " - Parcela: " & grdListagem.CurrentRow.Cells("numero_parcela").Value, _
                             "", _
                             sArquivo, _
                             sArquivo, _
                             "", _
                             grdListagem.CurrentRow.Cells("codigo_parceiro_negocio").Value)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: PARCELA :::"

    Private Sub LoadGridDuplicatas(ByVal oGrid As GridEX)

        Try

            'Limpa Grid
            oGrid.DataSource = Nothing

            'Variaveis Locais
            Dim oDataSet As New DataSet
            Dim oDataTable As New DataTable
            Dim oDCNumeroDocumento As New DataColumn("numero_documento")
            Dim oDCParcela As New DataColumn("parcela")
            Dim oDCDescritivo As New DataColumn("descritivo")
            Dim oDCCarteira As New DataColumn("carteira")
            Dim oDCNumeroDocumentoPagamento As New DataColumn("numero_documento_pagamento")
            Dim oDCDataVencimento As New DataColumn("data_vencimento")
            Dim oDCDataPagamento As New DataColumn("data_pagamento")
            Dim oDCValorTotal As New DataColumn("valor_total")
            Dim oDCValorPago As New DataColumn("valor_pago")
            Dim oDCJuros As New DataColumn("juros")
            Dim oDCDesconto As New DataColumn("desconto")
            Dim oDCValorDevido As New DataColumn("valor_devido")
            Dim oDCCodigoTituloCapa As New DataColumn("codigo_titulo_capa")
            Dim oDCNumeroParcela As New DataColumn("numero_parcela")
            Dim oDCCodigoBancoConta As New DataColumn("codigo_banco_conta")

            'Seta DataType
            oDCDataVencimento.DataType = Now.Date.GetType
            oDCDataPagamento.DataType = Now.Date.GetType
            oDCValorTotal.DataType = 0.0.GetType
            oDCValorPago.DataType = 0.0.GetType
            oDCJuros.DataType = 0.0.GetType
            oDCDesconto.DataType = 0.0.GetType
            oDCValorDevido.DataType = 0.0.GetType

            'Adiciona Tabela ao DataSet
            oDataSet.Tables.Add(oDataTable)

            'Adiciona Colunas ao DataTable
            oDataTable.Columns.Add(oDCNumeroDocumento)
            oDataTable.Columns.Add(oDCParcela)
            oDataTable.Columns.Add(oDCDescritivo)
            oDataTable.Columns.Add(oDCCarteira)
            oDataTable.Columns.Add(oDCNumeroDocumentoPagamento)
            oDataTable.Columns.Add(oDCDataVencimento)
            oDataTable.Columns.Add(oDCDataPagamento)
            oDataTable.Columns.Add(oDCValorTotal)
            oDataTable.Columns.Add(oDCValorPago)
            oDataTable.Columns.Add(oDCJuros)
            oDataTable.Columns.Add(oDCDesconto)
            oDataTable.Columns.Add(oDCValorDevido)
            oDataTable.Columns.Add(oDCCodigoTituloCapa)
            oDataTable.Columns.Add(oDCNumeroParcela)
            oDataTable.Columns.Add(oDCCodigoBancoConta)

            'Adiciona Linhas ao DataTable
            For i = 0 To UBound(gSelecaoRow)
                Dim oDataRow As DataRow = oDataTable.NewRow
                oDataRow("numero_documento") = gSelecaoRow(i).Cells("numero_documento").Value
                oDataRow("parcela") = gSelecaoRow(i).Cells("parcela").Value
                oDataRow("descritivo") = gSelecaoRow(i).Cells("descritivo").Value
                oDataRow("carteira") = gSelecaoRow(i).Cells("carteira").Value
                oDataRow("numero_documento_pagamento") = gSelecaoRow(i).Cells("numero_documento_pagamento").Value
                oDataRow("data_vencimento") = gSelecaoRow(i).Cells("data_vencimento").Value
                oDataRow("data_pagamento") = Now.Date
                oDataRow("valor_total") = gSelecaoRow(i).Cells("valor").Value
                oDataRow("valor_pago") = gSelecaoRow(i).Cells("valor_corrigido").Value
                oDataRow("juros") = gSelecaoRow(i).Cells("valor_corrigido").Value - gSelecaoRow(i).Cells("valor").Value
                oDataRow("desconto") = gSelecaoRow(i).Cells("desconto").Value
                oDataRow("valor_devido") = gSelecaoRow(i).Cells("valor_corrigido").Value
                oDataRow("codigo_titulo_capa") = gSelecaoRow(i).Cells("codigo_titulo_capa").Value
                oDataRow("numero_parcela") = gSelecaoRow(i).Cells("numero_parcela").Value
                oDataRow("codigo_banco_conta") = gSelecaoRow(i).Cells("codigo_banco_conta").Value
                oDataTable.Rows.Add(oDataRow)
            Next

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName
            oGrid.MoveFirst()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            'Seta Retorno da Função
            Validacao = False

            'Verifica se o Valor Devido é Menor que o Valor Pago
            If Math.Abs(grdParcela.GetTotalRow.Cells("valor_devido").Value - grdParcela.GetTotalRow.Cells("valor_pago").Value) > 1 Then

                'Váriaveis - Form
                Dim oForm As New frmFinTituloPagamentoMenor
                'Seta Parâmetro
                oForm.lblTotalDesconto.Text = "R$ " & FormatNumber(grdParcela.GetTotalRow.Cells("desconto").Value, 2, Microsoft.VisualBasic.TriState.True)
                oForm.lblTotalDevido.Text = "R$ " & FormatNumber(grdParcela.GetTotalRow.Cells("valor_devido").Value, 2, Microsoft.VisualBasic.TriState.True)
                oForm.lblTotalJuros.Text = "R$ " & FormatNumber(grdParcela.GetTotalRow.Cells("juros").Value, 2, Microsoft.VisualBasic.TriState.True)
                oForm.lblTotalPago.Text = "R$ " & FormatNumber(grdParcela.GetTotalRow.Cells("valor_pago").Value, 2, Microsoft.VisualBasic.TriState.True)
                oForm.lblTotalTitulo.Text = "R$ " & FormatNumber(grdParcela.GetTotalRow.Cells("valor_total").Value, 2, Microsoft.VisualBasic.TriState.True)
                oForm.lblSaldo.Text = "(SALDO     R$ " & FormatNumber(grdParcela.GetTotalRow.Cells("valor_pago").Value - grdParcela.GetTotalRow.Cells("valor_devido").Value, 2, Microsoft.VisualBasic.TriState.True) & ")"
                'Abre Formulário
                Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                'Verifica Opção Escolhida - Caso 0 sai da Validação
                If CInt(btnPagar.Tag) = 0 Then
                    Exit Function
                End If

            End If

            'Seta Retorno da Função
            Validacao = True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub Salvar()

        Try


            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Pagar Parcela
            oClsFinReceitaPagamentoBoletoBancario.UpdateParcela(grdParcela, btnPagar.Tag)

            'Informa o Usuário sobre o Sucesso da Operação
            frmMain.Informacao(Mensagem.OperacaoRealizadaSucesso)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class
