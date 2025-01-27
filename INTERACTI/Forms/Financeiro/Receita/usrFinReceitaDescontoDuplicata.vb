Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class usrFinReceitaDescontoDuplicata

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsFinReceitaDescontoDuplicata As New clsUsrFinReceitaDescontoDuplicata

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrFinReceitaDescontoDuplicata_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid Else Control_Enter(sender)
                    
                Case Keys.F3

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "txtClienteFiltro" : Call btnProcurarClienteFiltro_Click(btnProcurarClienteFiltro, System.EventArgs.Empty)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name
                        Case "cboContaBancariaFiltro" : Call LoadCombo(cboContaBancariaFiltro, "sp_select_combo_cadastro_basico_banco_conta " & goUsuario.iEmpresa)
                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub usrFinReceitaDescontoDuplicata_Load(sender As Object, e As EventArgs) Handles Me.Load

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
            oForm.NomeFormulario = Formulario.FinanceiroReceitaDescontoDuplicata
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FinanceiroReceitaDescontoDuplicata)

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

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Dados da Grid
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            'Exclui Registro
            Call Delete()

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

    Private Sub cboCongelarColuna_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCongelarColuna.SelectedIndexChanged

        Try

            If cboCongelarColuna.SelectedIndex = -1 Then
                grdListagem.FrozenColumns = 2
            Else
                grdListagem.FrozenColumns = cboCongelarColuna.SelectedValue
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            'Verifica se a Colula Selecionada é Válida
            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            'Verifica a Coluna que foi Pressionada
            Select Case grdListagem.CurrentColumn.Key

                Case "pagar" : Call Pagar()

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, Formulario.FinanceiroReceitaDescontoDuplicata)

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
                                     Formulario.FinanceiroReceitaDescontoDuplicata, _
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
                                          Formulario.FinanceiroReceitaDescontoDuplicata, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFinReceitaDescontoDuplicata_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcelGrid.Enabled = VerificaDireito(Formulario.FinanceiroReceitaDescontoDuplicata, gcPrint)

            'Carrega ComboBox
            Call LoadCombo(cboContaBancariaFiltro, "sp_select_combo_cadastro_basico_banco_conta " & goUsuario.iEmpresa)
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

            'Seta Controles
            dtpDataPagamentoInicioFiltro.Value = Now.Date : dtpDataPagamentoInicioFiltro.Checked = False
            dtpDataPagamentoTerminoFiltro.Value = Now.Date : dtpDataPagamentoTerminoFiltro.Checked = False

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.FinanceiroReceitaDescontoDuplicata)

            'Seta Focu
            txtNumeroDocumentoFiltro.Focus()

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

            'Carrega Controles
            oClsFinReceitaDescontoDuplicata.LoadGrid(grdListagem, _
                                                     txtNumeroDocumentoFiltro.Text.Trim, _
                                                     txtNumeroContratoFiltro.Text.Trim, _
                                                     txtClienteFiltro.Text.Trim, _
                                                     IIf(dtpDataPagamentoInicioFiltro.Checked = False, "", dtpDataPagamentoInicioFiltro.Value), _
                                                     IIf(dtpDataPagamentoTerminoFiltro.Checked = False, "", dtpDataPagamentoTerminoFiltro.Value), _
                                                     IIf(cboContaBancariaFiltro.SelectedIndex = -1, -1, cboContaBancariaFiltro.SelectedValue))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Pagar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se o usuário tem direito de alterar algum registro
            If VerificaDireito(Formulario.FinanceiroReceitaPagamento, gcInsert) = True Then

                'Abre Formulário de Cadastro
                Dim oForm As New frmCadBasico
                oForm.UsrControl = "usrFinReceitaPagamento"
                oForm.Size = frmMain.tlpMain.Size : oForm.Location = frmMain.tlpMain.Location : oForm.Tamanho = True
                oForm.Titulo = "Financeiro - Receita - Baixar Duplicatas"

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
                oDataRow("numero_documento") = grdListagem.CurrentRow.Cells("numero_documento").Value
                oDataRow("parcela") = grdListagem.CurrentRow.Cells("parcela").Value
                oDataRow("descritivo") = grdListagem.CurrentRow.Cells("descritivo").Value
                oDataRow("data_vencimento") = grdListagem.CurrentRow.Cells("data_vencimento").Value
                oDataRow("valor_total") = grdListagem.CurrentRow.Cells("valor").Value
                oDataRow("valor_pago") = 0
                oDataRow("juros") = 0
                oDataRow("desconto") = 0
                oDataRow("valor_devido") = grdListagem.CurrentRow.Cells("valor").Value
                oDataRow("codigo_titulo_capa") = grdListagem.CurrentRow.Cells("codigo_titulo_capa").Value
                oDataRow("numero_parcela") = grdListagem.CurrentRow.Cells("numero_parcela").Value
                oDataTable.Rows.Add(oDataRow)

                'Seta Parâmetros
                Dim oFormularioCadastroBasico(0) As FormularioCadastroBasico
                oFormularioCadastroBasico(0).oValor = oDataSet : oFormularioCadastroBasico(0).sControle = "grdParcela"
                oForm.CadastroBasico = oFormularioCadastroBasico

                'Abre o Formulário
                Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

                'Carrega a Grid
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

    Private Sub Delete()

        Try

            'Verifica se foi selecionado algum registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Verifica se o Usuário Deseja Excluir os Registros Selecionados
                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro” & iif(gSelecaoRow.Count = 1, “?", “s?”), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    'Exclui Registro
                    oClsFinReceitaDescontoDuplicata.Delete()

                    'Informa o Usuário sobre o Sucesso da Operação
                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

                End If

            Else
                'Informa o Usuário da Necessidade de selecionar um ou mais Registros
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
