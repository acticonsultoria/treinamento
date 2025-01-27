Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls
Imports Janus.Windows.Common
Imports Microsoft.Office.Interop

Public Class usrCstCenario

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsCstCenario As New clsCstCenario
    Private oGridEx As GridEX

    Private Structure Grafico
        Dim sSerie As String
        Dim sEixoX As String
        Dim dQuantidade As Double
        Dim dValor As Double
        Dim dValor2 As Double
    End Structure

    Private Enum TipoIntervalo
        Horas = 1
        Dias = 2
        Semanas = 3
        Meses = 4
        Anos = 5
    End Enum

#End Region

#Region "::: CONTROLES :::"

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        Try
            Call LoadGrid()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub cboGridGrafico_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGridGrafico.SelectedIndexChanged
        Try

            'Zera os dados da combo
            cboCampoGridGrafico.DropDownDataSource = Nothing
            cboCampoGridGrafico.Text = ""

            'Verifica se foi selecionado
            If cboGridGrafico.SelectedIndex = -1 Then Exit Sub

            'Instancia um novo dataset
            Dim oDataSet As New DataSet
            oDataSet.Tables.Add()

            oDataSet.Tables(0).Columns.Add("codigo")
            oDataSet.Tables(0).Columns.Add("descricao")

            'Seta o valor
            Dim oGridControl As Object

            Select Case cboGridGrafico.SelectedValue
                Case "grdGGF" : oGridControl = grdGGF
                    'Case "grdConsumo" : oGridControl = grdConsumo
                Case "grdMP" : oGridControl = grdMP
                Case "grdBeneficiamento" : oGridControl = grdBeneficiamento1
                Case "grdConsumoOP" : oGridControl = grdConsumoOP
                Case "grdEncargos" : oGridControl = grdEncargos
                Case "grdRevenda" : oGridControl = grdOP
                Case "grdConsolidado" : oGridControl = grdConsolidado

            End Select

            If oGridControl Is Nothing Then Exit Sub


            'Seta como grid
            oGridEx = oGridControl

            'Se tiver mensal para montar o gráfico
            If oGridEx.RootTable.Columns.Contains("janeiro") Then

                'Percorre todos os registros para verificar se quer colocar os dados no gráfico
                For Each oRow In oGridEx.GetRows

                    If oRow.RowType = RowType.Record Then
                        If IsDBNull(oRow.Cells.Item("descricao").Value) = False Then

                            oDataSet.Tables(0).Rows.Add(oRow.RowIndex, oRow.Cells.Item("descricao").Value)
                        End If
                    End If
                Next

                With cboCampoGridGrafico
                    .DropDownDataSource = Nothing
                    .DropDownList.Columns.Item("descricao").DataMember = "descricao"
                    .DropDownList.Columns.Item("codigo").DataMember = "codigo"
                    .DropDownDataSource = oDataSet.Tables(0)
                    .DropDownDisplayMember = "descricao"
                    .DropDownValueMember = "codigo"
                    .DropDownDataMember = oDataSet.Tables(0).TableName

                End With

                grpGraficoMensal.Visible = True
                grpGraficoPadrao.Visible = False

            Else


                Call LoadComboIntervalo()
                Call LoadComboEixoY()
                Call LoadComboSerie()
                Call LoadComboTipo()

                grpGraficoMensal.Visible = False
                grpGraficoPadrao.Visible = True
            End If




        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnVisualizarImpressao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizarImpressao.Click
        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Campo - Pedido de Venda
            If ValidaCampo(cboAno, cboAno) = False Then
                Exit Sub
            End If

            'Visualizar Impressão
            Call VisualizarImpressao()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub btnGerarGrafico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerarGrafico.Click
        Try
            GerarGraficoMensal()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnGerarGraficoPadrao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerarGraficoPadrao.Click
        Try
            GerarGraficoPadrao()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub usrCstCenario_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp

        Try

            If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrCstCenario_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Deleta Aba
            If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else frmMain.tabMain.TabPages.Remove(Me.Parent)
            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdEncargos_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdEncargos.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdEncargos.Name, _
                                     Formulario.CustoCenario, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdCusto_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdCusto.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdCusto.Name, _
                                     Formulario.CustoCenario, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdGGF_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdGGF.Name, _
                                     Formulario.CustoCenario, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdTaxaHora_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdTaxaHora.Name, _
                                     Formulario.CustoCenario, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdWIPEstoque_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdWIPEstoque.Name, _
                                     Formulario.CustoCenario, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdCustoMaterial_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdMP.Name, _
                                     Formulario.CustoCenario, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdBeneficiamento_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs)

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdBeneficiamento1.Name, _
                                     Formulario.CustoCenario, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdConsolidado_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdConsolidado.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdConsolidado.Name, _
                                     Formulario.CustoCenario, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdEncargos_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdEncargos.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdEncargos.Name, _
                                          Formulario.CustoCenario, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdCusto_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdCusto.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdCusto.Name, _
                                          Formulario.CustoCenario, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdConsolidado_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdConsolidado.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdConsolidado.Name, _
                                          Formulario.CustoCenario, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdWIPEstoque_GroupsChanging(ByVal sender As Object, ByVal e As GroupsChangingEventArgs) Handles grdWIPEstoque.GroupsChanging

        Try

            'Atualiza Grid
            Call UpdateConfiguraGridGrupo(grdWIPEstoque.Name, _
                                          Formulario.CustoCenario, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub cboSerie_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSerie.SelectedIndexChanged
        Try
            If cboSerie.SelectedValue.ToString.ToUpper.Contains("DATA") = True Or cboSerie.Text.ToString.ToUpper.Contains("DATA") = True Then
                cboIntervalo.Visible = True
                lblIntervaloAgrupamento.Visible = True
            Else
                cboIntervalo.Visible = False
                lblIntervaloAgrupamento.Visible = False
                cboIntervalo.SelectedIndex = -1
            End If
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnExcelMonthlyReport_Click(sender As Object, e As EventArgs) Handles btnExcelMonthlyReport.Click
        Try
            ExportExcel(grdMonthlyReport)
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnExcelOutros_Click(sender As Object, e As EventArgs) Handles btnExcelOutros.Click
        Try
            ExportExcel(grdListagem)
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnExcelRateioIOF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelRateioIOF.Click
        Try
            ExportExcel(grdConsumoOP)
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnExcelWip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelWipEstoque.Click
        Try
            ExportExcel(grdWIPEstoque)
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnResultadoMensalRevenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelRevenda.Click
        Try
            ExportExcel(grdOP)
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnResultadoMensalConsolidade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelConsolidade.Click
        Try
            ExportExcel(grdConsolidado)
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnExcelEncargos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelEncargos.Click
        Try
            ExportExcel(grdEncargos)
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnExcelGGF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGGF.Click
        Try
            ExportExcel(grdGGF)
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnExcelDespesa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelDespesa.Click
        Try
            ExportExcel(grdDespesa)
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnExcelReceita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelReceita.Click
        Try
            ExportExcel(grdReceita)
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnExcelBom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelBom.Click
        Try
            ExportExcel(grdBom)
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnExcelDepreciacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelDepreciacao.Click
        Try
            ExportExcel(grdDepreciacao)
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnExcelManutencao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelManutencao.Click
        Try
            ExportExcel(grdManutencao)
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnExcelInsumo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelInsumo.Click
        Try
            ExportExcel(grdInsumo)
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnExcelMaterialDireto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelMaterialDireto.Click
        Try
            ExportExcel(grdMP)
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnExcelBeneficiamento2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelBeneficiamento.Click
        Try
            ExportExcel(grdBeneficiamento1)
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnExcelConsumo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelConsumo.Click
        Try
            ExportExcel(grdConsumo)
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnFiltrarEstoque_Click(sender As Object, e As EventArgs) Handles btnFiltrarEstoque.Click
        Try
            LoadGridWIP()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnFiltrarPerda_Click(sender As Object, e As EventArgs) Handles btnFiltrarPerda.Click

        Try

            LoadGridPerda()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try

    End Sub

    Private Sub grdMonthlyReport_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdMonthlyReport.RowDoubleClick
        Try
            'Variaveis Locais
            Dim oForm As New frmCstMonthlyReport

            'Seta Parametros
            oForm.Grid = grdMonthlyReport
            oForm.Mes = grdMonthlyReport.CurrentColumn.Key.ToString()
            oForm.Ano = cboAno.SelectedValue
            oForm.Descricao = grdMonthlyReport.CurrentRow.Cells.Item("descricao").Value

            'Abre Formulário
            ConfigureMaskEdit(oForm) : oForm.ShowDialog(Me)
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub

    Private Sub btnExcelPerdaGGF_Click(sender As Object, e As EventArgs) Handles btnExcelPerdaGGF.Click

        Try

            ExportExcel(grdPerdaGGF)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try

    End Sub

    Private Sub btnExcelPerdaEstoque_Click(sender As Object, e As EventArgs) Handles btnExcelPerdaEstoque.Click

        Try

            ExportExcel(grdPerdaEstoqueDados)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try

    End Sub

    Private Sub btnExcelDespesaGGF_Click(sender As Object, e As EventArgs) Handles btnExcelDespesaGGF.Click

        Try

            ExportExcel(grdDespesaGGF)

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelDespesaEstoque_Click(sender As Object, e As EventArgs) Handles btnExcelDespesaEstoque.Click

        Try

            ExportExcel(grdDespesaEstoque)

        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrarDespesa_Click(sender As Object, e As EventArgs) Handles btnFiltrarDespesa.Click

        Try

            LoadGridDepesa()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrCstCenario_KeyUp))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega Combo

            Call LoadCombo(cboAno, "sp_select_combo_ano " & goUsuario.iEmpresa)


            Call LoadComboMes(cboMes)
            Call LoadComboMes(cboMesPerda)
            Call LoadComboMes(cboMesDespesa)

            'Configura Grid
            Call ConfiguraGrid(grdEncargo, Formulario.CustoCenario)
            Call ConfiguraGrid(grdBeneficiamento1, Formulario.CustoCenario)
            Call ConfiguraGrid(grdConsumo, Formulario.CustoCenario)
            Call ConfiguraGrid(grdGGF, Formulario.CustoCenario)
            Call ConfiguraGrid(grdMP, Formulario.CustoCenario)
            Call ConfiguraGrid(grdConsumoOP, Formulario.CustoCenario)
            Call ConfiguraGrid(grdTaxaHora, Formulario.CustoCenario)
            Call ConfiguraGrid(grdWIPEstoque, Formulario.CustoCenario)
            Call ConfiguraGrid(grdMonthlyReport, Formulario.CustoCenario)
            Call ConfiguraGrid(grdListagem, Formulario.CustoCenario)




            Dim oDataSet As New DataSet
            oDataSet.Tables.Add()

            oDataSet.Tables(0).Columns.Add("CODIGO")
            oDataSet.Tables(0).Columns.Add("DESCRICAO")

                'Adiciona os controles
            AdicionarControles(oDataSet, Me)


            cboGridGrafico.DataSource = oDataSet.Tables(0)
            cboGridGrafico.ValueMember = "CODIGO"
            cboGridGrafico.DisplayMember = "DESCRICAO"
            cboGridGrafico.SelectedIndex = -1




            If VerificaDireito(Formulario.CustoCenario, gcAdministrator) = False Then

                tabDadosCusto.TabPages.Remove(pagGeracao)
                tabRelatorio.TabPages.Remove(pagResultadoMensalConsolidado)

            End If

            'Seta Focu
            cboAno.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub AdicionarControles(ByRef oDataSet As DataSet, ByVal oParentObject As Object)
        Try
            For Each oObject In oParentObject.Controls


                'Adiciona os controles
                AdicionarControles(oDataSet, oObject)

                'Verifica se é grid
                If oObject.GetType.ToString = "Janus.Windows.GridEX.GridEX" Then

                    oDataSet.Tables(0).Rows.Add(oObject.name, oParentObject.text)

                End If

            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            frmMain.errInfo.Clear()

            ''Seta Parametros
            oClsCstCenario.LoadGridEncargos(grdEncargos, _
                                            IIf(cboAno.SelectedIndex = -1, -1, cboAno.SelectedValue))
            'Seta Parametros
            oClsCstCenario.LoadGridGGF(grdGGF, _
                                       IIf(cboAno.SelectedIndex = -1, -1, cboAno.SelectedValue))
            'Seta Parametros
            oClsCstCenario.LoadGridDespesa(grdDespesa, _
                                           IIf(cboAno.SelectedIndex = -1, -1, cboAno.SelectedValue))
            'Seta Parametros
            oClsCstCenario.LoadGridReceita(grdReceita, _
                                           IIf(cboAno.SelectedIndex = -1, -1, cboAno.SelectedValue))
            'Seta Parametros
            oClsCstCenario.LoadGridBom(grdBom, _
                                           IIf(cboAno.SelectedIndex = -1, -1, cboAno.SelectedValue))
            'Seta Parametros
            oClsCstCenario.LoadGridDepreciacao(grdDepreciacao, _
                                               IIf(cboAno.SelectedIndex = -1, -1, cboAno.SelectedValue))
            'Seta Parametros
            oClsCstCenario.LoadGridManutencao(grdManutencao, _
                                              IIf(cboAno.SelectedIndex = -1, -1, cboAno.SelectedValue))

            'Relatórios
            oClsCstCenario.LoadGridConsolidado(grdConsolidado, _
                                               IIf(cboAno.SelectedIndex = -1, -1, cboAno.SelectedValue))


            'Relatórios
            oClsCstCenario.LoadGridMonthlyReport(grdMonthlyReport, _
                                               IIf(cboAno.SelectedIndex = -1, -1, cboAno.SelectedValue))

            oClsCstCenario.LoadGridOutros(grdListagem, _
                                          IIf(cboAno.SelectedIndex = -1, -1, cboAno.SelectedValue))


            oClsCstCenario.LoadGridRelatorioOP(grdOP, _
                                               IIf(cboAno.SelectedIndex = -1, -1, cboAno.SelectedValue))

            oClsCstCenario.LoadGridConsumoOP(grdConsumoOP, _
                                             IIf(cboAno.SelectedIndex = -1, -1, cboAno.SelectedValue))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridWIP()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            frmMain.errInfo.Clear()

            'Seta Parametros
            oClsCstCenario.LoadGridWIP(grdWIPEstoque, _
                                       IIf(cboAno.SelectedIndex = -1, -1, cboAno.SelectedValue), _
                                       IIf(cboMes.SelectedIndex = -1, -1, cboMes.SelectedValue), _
                                       optAnalitico.Checked, _
                                       optTotais.Checked)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridPerda()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            frmMain.errInfo.Clear()

            'Seta Parametros
            oClsCstCenario.LoadGridPerda(grdPerdaGGF, _
                                         grdPerdaEstoqueDados, _
                                       IIf(cboAno.SelectedIndex = -1, -1, cboAno.SelectedValue), _
                                       IIf(cboMesPerda.SelectedIndex = -1, -1, cboMesPerda.SelectedValue))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub
   
    Private Sub GerarGraficoMensal()
        Try
            'Atribuindo o nome ao gráfico
            chrGrafico.Titles(0).Text = "GRÁFICO DE " & cboGridGrafico.Text

            'Limpando as séries
            chrGrafico.Series.Clear()

            'Formatando o eixo X de acordo com o valor escolhido
            chrGrafico.ChartAreas(0).AxisX.Title = "MÊS"
            chrGrafico.ChartAreas(0).AxisY.Title = "VALOR"

            Dim sSerie As String = ""
            Dim iColunaJaneiro As Integer = oGridEx.RootTable.Columns("janeiro").Index

            'Percorre os itens selecionados e adiciona os valores
            For Each oItem In cboCampoGridGrafico.CheckedValues

                'Seta o nome da série
                sSerie = oGridEx.GetDataRows(oItem).Cells.Item("descricao").Value

                'Adiciona a serie
                ChartSerieAdicionar(chrGrafico, sSerie, Dundas.Charting.WinControl.SeriesChartType.Column)

                'Adiciona ponto por ponto de cada mês
                For iMes As Integer = 0 To 11

                    'Recebe o valor daquele mês
                    Dim dValor As Object = oGridEx.GetDataRows(oItem).Cells.Item(iMes + iColunaJaneiro).Value

                    'Verifica se nao está selecionado 
                    If IsDBNull(dValor) Or dValor Is Nothing Then dValor = 0.0

                    'Adiciona os pontos da serie
                    chrGrafico.Series(sSerie).Points.AddXY( _
                                           oGridEx.RootTable.Columns(iMes + iColunaJaneiro).Key, _
                                          CDbl(FormatNumber(dValor, 2)))
                Next


            Next
            chrGrafico.ChartAreas(0).AxisX.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.NotSet
            chrGrafico.ChartAreas(0).AxisX.Interval = 1
            chrGrafico.ChartAreas(0).ReCalc()



        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ChartSerieAdicionar(ByRef oChart As Dundas.Charting.WinControl.Chart, _
                                ByRef sKey As String, _
                                ByVal oSerieCharrType As Dundas.Charting.WinControl.SeriesChartType)

        Try

            With oChart


                .Series.Add(sKey)
                .Series(sKey).Type = oSerieCharrType
                .Series(sKey).ShowLabelAsValue = True
                .Series(sKey).BorderStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
                .Series(sKey).BorderColor = Color.Black
                .Series(sKey).ShadowColor = Color.DarkGray
                .Series(sKey).ShadowOffset = 3
                .Series(sKey).SmartLabels.Enabled = True
                .Series(sKey).SmartLabels.AllowOutsidePlotArea = Dundas.Charting.WinControl.LabelOutsidePlotAreaStyle.Yes

                oChart.ChartAreas(0).AxisX.LabelStyle.FontAngle = 45

                '.Series(sKey).ShowLabelAsValue = False

            End With
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub GerarGraficoPadrao()
        Try
            'Limpando os erros 
            frmMain.errInfo.Clear()

            'Validando
            If ValidaCampo(cboSerie, lblSerie) = False Then
                Exit Sub
            End If
            'Validando
            If ValidaCampo(cboEixoY, lblValorEixoY) = False Then
                Exit Sub
            End If
            If ValidaCampo(cboTipo, lblTipo) = False Then
                Exit Sub
            End If

            'Carregando o gráfico

            GerarGraficoDundas(chrGrafico, cboSerie.SelectedValue, cboSerie.Text, cboEixoY.SelectedValue, cboEixoY.Text, oGridEx, cboTipo.SelectedValue, cboTipo.Text, 0, IIf(cboIntervalo.SelectedIndex = -1, -1, cboIntervalo.SelectedValue))



        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LoadComboIntervalo()
        Try


            Dim oDataSet As New DataSet
            Dim oDataRow As DataRow
            oDataSet.Tables.Add()
            oDataSet.Tables(0).Columns.Add("codigo")
            oDataSet.Tables(0).Columns.Add("descricao")

            oDataRow = oDataSet.Tables(0).Rows.Add
            oDataRow(0) = 1
            oDataRow(1) = "HORAS"

            oDataRow = oDataSet.Tables(0).Rows.Add
            oDataRow(0) = 2
            oDataRow(1) = "DIAS"


            oDataRow = oDataSet.Tables(0).Rows.Add
            oDataRow(0) = 3
            oDataRow(1) = "SEMANAS"

            oDataRow = oDataSet.Tables(0).Rows.Add
            oDataRow(0) = 4
            oDataRow(1) = "MESES"

            oDataRow = oDataSet.Tables(0).Rows.Add
            oDataRow(0) = 5
            oDataRow(1) = "ANOS"

            With cboIntervalo
                .DataSource = oDataSet.Tables(0)
                .ValueMember = "CODIGO"
                .DisplayMember = "DESCRICAO"
            End With


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LoadComboEixoY()
        Try

            Dim oDataSet As New DataSet
            Dim oDataRow As DataRow
            Dim bFlag As Boolean = False
            oDataSet.Tables.Add()
            oDataSet.Tables(0).Columns.Add("codigo")
            oDataSet.Tables(0).Columns.Add("descricao")

            If oGridEx.RecordCount = 0 Then Exit Sub

            'Percorrendo todas as colunas da grid
            For Each oColumn As Janus.Windows.GridEX.GridEXColumn In oGridEx.RootTable.Columns

                If oColumn.Visible = False Then Continue For

                'Se for diferente de X e for visível
                If IsNumeric(oGridEx.GetRow(0).Cells.Item(oColumn.Key).Value) And oColumn.Caption <> "" Then

                    oDataRow = oDataSet.Tables(0).Rows.Add
                    oDataRow(0) = oColumn.Key
                    oDataRow(1) = oColumn.Caption

                End If
            Next

            With cboEixoY
                .DataSource = oDataSet.Tables(0)
                .ValueMember = "CODIGO"
                .DisplayMember = "DESCRICAO"
            End With

           


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LoadComboSerie()
        Try

            Dim oDataSet As New DataSet
            Dim oDataRow As DataRow
            oDataSet.Tables.Add()
            oDataSet.Tables(0).Columns.Add("codigo")
            oDataSet.Tables(0).Columns.Add("descricao")

            'Percorrendo todas as colunas da grid
            For Each oColumn As Janus.Windows.GridEX.GridEXColumn In oGridEx.RootTable.Columns

                'Se for diferente de X e for visível
                If Not IsNumeric(oGridEx.GetRow(0).Cells.Item(oColumn.Key).Value) And oColumn.Caption <> "" Then


                    oDataRow = oDataSet.Tables(0).Rows.Add
                    oDataRow(0) = oColumn.Key
                    oDataRow(1) = oColumn.Caption

                End If
            Next


            With cboSerie
                .DataSource = oDataSet.Tables(0)
                .ValueMember = "CODIGO"
                .DisplayMember = "DESCRICAO"
            End With


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LoadComboTipo()
        Try

            Dim oDataSet As New DataSet
            Dim oDataRow As DataRow
            oDataSet.Tables.Add()
            oDataSet.Tables(0).Columns.Add("codigo")
            oDataSet.Tables(0).Columns.Add("descricao")


            oDataRow = oDataSet.Tables(0).Rows.Add
            oDataRow(0) = 1
            oDataRow(1) = "SOMA"

            oDataRow = oDataSet.Tables(0).Rows.Add
            oDataRow(0) = 2
            oDataRow(1) = "MÉDIA"


            oDataRow = oDataSet.Tables(0).Rows.Add
            oDataRow(0) = 3
            oDataRow(1) = "CONTAR"


            With cboTipo
                .DataSource = oDataSet.Tables(0)
                .ValueMember = "CODIGO"
                .DisplayMember = "DESCRICAO"
            End With


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub GerarGraficoDundas(ByVal oChart As Dundas.Charting.WinControl.Chart, _
                      ByVal sKeyCampoSerie As String, _
                      ByVal sNomeCampoSerie As String, _
                      ByVal sEixoY As String, _
                      ByVal sNomeEixoY As String, _
                      ByVal oGridDados As Janus.Windows.GridEX.GridEX, _
                      ByVal iTipo As Integer, _
                      ByVal sTipo As String, _
                      ByVal iMeta As Integer, _
                      ByVal iIntervalo As Integer)



        Try
            'Variável auxiliar
            Dim oStructGrafico(0) As Grafico

            'Variável auxiliar
            Dim bFlag As Boolean = True

            'Limpando a ordenação
            oGridDados.RootTable.Groups.Clear()

            oGridDados.RootTable.SortKeys.Clear()

            If iIntervalo <> -1 Then
                oGridDados.RootTable.SortKeys.Add(oGridDados.RootTable.Columns(sKeyCampoSerie), Janus.Windows.GridEX.SortOrder.Ascending)
            End If

            'Definindo o formato da data de acordo com o intervalo
            Dim sFormatoData As String = ""
            Select Case iIntervalo
                Case TipoIntervalo.Horas : sFormatoData = "dd-hh"
                Case TipoIntervalo.Dias : sFormatoData = "yyyy-MMM-dd"
                Case TipoIntervalo.Semanas : sFormatoData = "yyyy-"
                Case TipoIntervalo.Meses : sFormatoData = "yyyy-MMM"
                Case TipoIntervalo.Anos : sFormatoData = "yyyy"
            End Select


            'Atribuindo o nome ao gráfico
            oChart.Titles(0).Text = "GRÁFICO DE " & sNomeCampoSerie

            'Limpando as séries
            oChart.Series.Clear()

            'Formatando o eixo X de acordo com o valor escolhido
            oChart.ChartAreas(0).AxisX.Title = "GRÁFICO - " & sNomeEixoY & " / " & sNomeCampoSerie
            oChart.ChartAreas(0).AxisY.Title = sTipo & " - " & sNomeEixoY

            'Adicionandoo campo de série
            ChartSerieAdicionar(oChart, sNomeCampoSerie, Dundas.Charting.WinControl.SeriesChartType.Column)


            If iMeta > 0 Then
                oChart.UnusedColor = Color.Green
                ChartSerieAdicionar(oChart, "META", Dundas.Charting.WinControl.SeriesChartType.Column)
                oChart.Series("META").Type = Dundas.Charting.WinControl.SeriesChartType.Line
                oChart.Series("META").ShowLabelAsValue = False
                oChart.Series("META").MarkerStyle = Dundas.Charting.WinControl.MarkerStyle.Square
                oChart.Series("META").MarkerSize = 8
                oChart.Series("META").BorderWidth = 6
                oChart.Series("META").Color = Color.Green

            End If



            Dim oHashMeta As New Hashtable

            'Percorrendo todas linha da grid
            For Each oRow In oGridDados.GetRows

                'Zerando a variável
                bFlag = False

                If IsDBNull(oRow.Cells.Item(sEixoY).Value) = False Then

                    'Verificando a meta
                    If iMeta > 0 Then


                        If iIntervalo = -1 Then
                            If Not oHashMeta.Contains(oRow.Cells.Item(sKeyCampoSerie).Text) Then
                                oHashMeta.Add(oRow.Cells.Item(sKeyCampoSerie).Text, 0)
                                oChart.Series("META").Points.AddXY(oRow.Cells.Item(sKeyCampoSerie).Text, iMeta)
                            End If
                        Else
                            If Not oHashMeta.Contains(Format(CDate(oRow.Cells.Item(sKeyCampoSerie).Text), sFormatoData) + IIf(iIntervalo = TipoIntervalo.Semanas, CStr(DatePart(DateInterval.WeekOfYear, oRow.Cells.Item(sKeyCampoSerie).Value)), "")) Then
                                oHashMeta.Add(Format(CDate(oRow.Cells.Item(sKeyCampoSerie).Text), sFormatoData) + IIf(iIntervalo = TipoIntervalo.Semanas, CStr(DatePart(DateInterval.WeekOfYear, oRow.Cells.Item(sKeyCampoSerie).Value)), ""), 0)
                                oChart.Series("META").Points.AddXY(Format(CDate(oRow.Cells.Item(sKeyCampoSerie).Text), sFormatoData) + IIf(iIntervalo = TipoIntervalo.Semanas, CStr(DatePart(DateInterval.WeekOfYear, oRow.Cells.Item(sKeyCampoSerie).Value)), ""), iMeta)
                            End If
                        End If

                    End If

                    'Verificando se já existe a chava
                    For iCont As Integer = 1 To oStructGrafico.Count - 1

                        'Verificando se já existe a serie com a data
                        If (oStructGrafico(iCont).sEixoX = oRow.Cells.Item(sKeyCampoSerie).Text) Then

                            'Adicionando o valor
                            oStructGrafico(iCont).dQuantidade += 1
                            oStructGrafico(iCont).dValor += oRow.Cells.Item(sEixoY).Value * IIf(sEixoY = "eficiencia", 100, 1)

                            'Saindo do laço
                            bFlag = True
                            Exit For

                        ElseIf iIntervalo <> -1 Then
                            If oStructGrafico(iCont).sEixoX = Format(CDate(oRow.Cells.Item(sKeyCampoSerie).Text), sFormatoData) + IIf(iIntervalo = TipoIntervalo.Semanas, CStr(DatePart(DateInterval.WeekOfYear, oRow.Cells.Item(sKeyCampoSerie).Value)), "") Then
                                'Adicionando o valor
                                oStructGrafico(iCont).dQuantidade += 1
                                oStructGrafico(iCont).dValor += oRow.Cells.Item(sEixoY).Value * IIf(sEixoY = "eficiencia", 100, 1)

                                'Saindo do laço
                                bFlag = True
                                Exit For
                            End If
                        End If
                    Next

                    'Se ele não encontrou a chave, adicioná-la 
                    If bFlag = False Then

                        'Redimensionando o vetor da estrutura
                        ReDim Preserve oStructGrafico(oStructGrafico.Count)

                        'Atribuindo os valores
                        oStructGrafico(oStructGrafico.Count - 1).sSerie = sNomeCampoSerie
                        If iIntervalo = -1 Then
                            oStructGrafico(oStructGrafico.Count - 1).sEixoX = oRow.Cells.Item(sKeyCampoSerie).Text
                        Else
                            oStructGrafico(oStructGrafico.Count - 1).sEixoX = Format(CDate(oRow.Cells.Item(sKeyCampoSerie).Text), sFormatoData) + IIf(iIntervalo = TipoIntervalo.Semanas, CStr(DatePart(DateInterval.WeekOfYear, oRow.Cells.Item(sKeyCampoSerie).Value)), "")
                        End If
                        oStructGrafico(oStructGrafico.Count - 1).dQuantidade = 1
                        oStructGrafico(oStructGrafico.Count - 1).dValor = oRow.Cells.Item(sEixoY).Value * IIf(sEixoY = "eficiencia", 100, 1)

                    End If

                End If
            Next


            'Depois de montada a estrutura, o gráfico irá ser montado a partir das informações

            'Crinado uma hash table para auxiliar
            Dim oHashSerie As New Hashtable

            'Percorrendo os dados da estrutura
            For iCont As Integer = 1 To oStructGrafico.Count - 1


                With oStructGrafico(iCont)

                    If iTipo = 1 Then 'Soma
                        'Adicionando os pontos
                        oChart.Series(sNomeCampoSerie).Points.AddXY( _
                                        .sEixoX, _
                                        CDbl(FormatNumber(.dValor, 2)))
                    ElseIf iTipo = 2 Then 'MÉDIA


                        'Adicionando os pontos
                        oChart.Series(sNomeCampoSerie).Points.AddXY( _
                                        .sEixoX, _
                                        CDbl(FormatNumber(.dValor / .dQuantidade, 2)))
                    Else 'CONTAR
                        'Adicionando os pontos
                        oChart.Series(sNomeCampoSerie).Points.AddXY( _
                                        .sEixoX, _
                                        CDbl(FormatNumber(.dQuantidade, 2)))
                    End If
                End With
            Next

            oChart.ChartAreas(0).AxisX.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.NotSet
            oChart.ChartAreas(0).AxisX.Interval = 1
            oChart.ChartAreas(0).ReCalc()






        Catch SqlEx As OleDb.OleDbException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub VisualizarImpressao()

       Try

            'Redimensiona Vetor
            ReDim goCrystalReport.sReportParameter(1)

            'Relatório
            goCrystalReport.sReport = goCrystalReport.sPath & "CST000000001.rpt"

            'Seta Paramentro - Empresa
            goCrystalReport.sReportParameter(0).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.iEmpresa
            'Seta Paramentro - Ano
            goCrystalReport.sReportParameter(1).sParamenter = "@ano"
            goCrystalReport.sReportParameter(1).sValue = IIf(cboAno.SelectedIndex = -1, -1, cboAno.SelectedValue)
            

            'Abre Relatório
            Dim oReport = New usrReport
            oReport.Dock = DockStyle.Fill
            frmMain.LoadPageReport(goCrystalReport.sReport, Me.Parent.Text, oReport)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridDepesa()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            frmMain.errInfo.Clear()

            'Seta Parametros
            oClsCstCenario.LoadGridDespesa(grdDespesaGGF, _
                                         grdDespesaEstoque, _
                                         IIf(cboAno.SelectedIndex = -1, -1, cboAno.SelectedValue), _
                                         IIf(cboMesDespesa.SelectedIndex = -1, -1, cboMesDespesa.SelectedValue))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class

