Imports Janus.Windows.GridEX

Public Class usrFin000000018

    'Variáveis da Classe
    Private oClsFin000000018 As New clsUsrFin000000018

#Region "::: CONTROLES :::"

    Private Sub usrFin000000018_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.RelatorioFIN000000018
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioFIN000000018)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Exporta para Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Dados da Grid
            Call LoadTreeView()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnFiltrarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrarGrid.Click

        Try

            'Carrega Dados da Grid
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnVisualizarImpressao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizarImpressao.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Verifica se foi Selecionado o Número de Meses
            If ValidaCampo(cboNumeroMeses, lblNumeroMeses) = False Then
                Exit Sub
            End If

            'Visualizar Impressão
            Call VisualizarImpressao()

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

    Private Sub trvMain_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles trvMain.AfterCheck

        Try

            For Each oNode As TreeNode In e.Node.Nodes
                oNode.Checked = e.Node.Checked
            Next

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CarregaGrid() Handles cboNumeroMeses.SelectedIndexChanged, _
                                      dtpDataInicioFiltro.ValueChanged

        Try

            'Limpa Controles
            grdListagem.DataSource = Nothing

            'Exclui Colunas
            For i = grdListagem.RootTable.Columns.Count - 1 To 1 Step -1
                If grdListagem.RootTable.Columns(i).Key <> "centro_custo" Then
                    grdListagem.RootTable.Columns.Remove(grdListagem.RootTable.Columns(i).Key)
                End If
            Next

            'Exclui Colunas
            For i = grdListagem.RootTable.ChildTables(0).Columns.Count - 1 To 1 Step -1
                If grdListagem.RootTable.ChildTables(0).Columns(i).Key <> "centro_custo" Then
                    grdListagem.RootTable.ChildTables(0).Columns.Remove(grdListagem.RootTable.ChildTables(0).Columns(i).Key)
                End If
            Next

            If cboNumeroMeses.SelectedIndex > -1 Then

                Dim oColumn As GridEXColumn
                Dim oColumnChild As GridEXColumn

                For i As Integer = 1 To cboNumeroMeses.SelectedValue

                    'Adiciona Coluna - Pai
                    oColumn = New GridEXColumn(i)
                    oColumn.AllowSize = False
                    oColumn.Width = 100
                    oColumn.HeaderAlignment = TextAlignment.Center
                    oColumn.HeaderLineAlignment = TextAlignment.Center
                    oColumn.TextAlignment = TextAlignment.Center
                    oColumn.LineAlignment = TextAlignment.Center
                    oColumn.SelectableCells = SelectableCells.FilterRowCells
                    oColumn.AggregateFunction = AggregateFunction.Sum
                    oColumn.TotalFormatString = "#,#0.0000"
                    oColumn.FormatString = "#,#0.0000"
                    oColumn.Caption = Format(DateAdd(DateInterval.Month, i - 1, dtpDataInicioFiltro.Value), "MM/yyyy")
                    grdListagem.RootTable.Columns.Add(oColumn)

                    'Adiciona Coluna - Filho
                    oColumnChild = New GridEXColumn(i)
                    oColumnChild.AllowSize = False
                    oColumnChild.Width = 100
                    oColumnChild.HeaderAlignment = TextAlignment.Center
                    oColumnChild.HeaderLineAlignment = TextAlignment.Center
                    oColumnChild.TextAlignment = TextAlignment.Center
                    oColumnChild.LineAlignment = TextAlignment.Center
                    oColumnChild.SelectableCells = SelectableCells.FilterRowCells
                    oColumnChild.AggregateFunction = AggregateFunction.Sum
                    oColumnChild.TotalFormatString = "#,#0.0000"
                    oColumnChild.FormatString = "#,#0.0000"
                    oColumnChild.Caption = Format(DateAdd(DateInterval.Month, i - 1, dtpDataInicioFiltro.Value), "MM/yyyy")
                    grdListagem.RootTable.ChildTables(0).Columns.Add(oColumnChild)

                Next

            End If

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

            'Carrega ComboBox
            Call LoadComboNumeroMes(cboNumeroMeses)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioFIN000000018)

            'Carrega TreeView
            Call LoadTreeView()

            'Configura DateTimePicker
            dtpDataInicioFiltro.Value = Now.Date : dtpDataInicioFiltro.Checked = False

            'Verifica Direito
            btnVisualizarImpressao.Enabled = VerificaDireito(Formulario.RelatorioFIN000000018, gcPrint)
            btnExcelGrid.Enabled = VerificaDireito(Formulario.RelatorioFIN000000018, gcPrint)

            'Seta Focu
            dtpDataInicioFiltro.Focus()

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

            'Váriaveis
            Dim sCodigoCentroCusto As String = ""

            If VerificaSelecaoNodeDesmarcado(trvMain) = True Then
                For Each oNode As TreeNode In gSelecaoNode
                    sCodigoCentroCusto &= IIf(sCodigoCentroCusto = "", "", ",") & oNode.Tag
                Next
            End If

            'Seta Parametros
            oClsFin000000018.LoadGrid(grdListagem, _
                                      "01/" & DatePart(DateInterval.Month, dtpDataInicioFiltro.Value) & "/" & DatePart(DateInterval.Year, dtpDataInicioFiltro.Value), _
                                      cboNumeroMeses.SelectedValue, _
                                      sCodigoCentroCusto)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadTreeView()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            Dim oClsCadCentroGasto As New clsUsrCadCentroGasto

            'Limpa TreeView
            trvMain.Nodes.Clear()

            'Seta Parametros
            oClsCadCentroGasto.LoadTreeViewSelecionado(trvMain, txtCentroCustroFiltro.Text.Trim)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub VisualizarImpressao()

        Try

            'Redimensiona Vetor
            ReDim goCrystalReport.sReportParameter(5)
            Dim sCodigoCentroCusto As String = ""
            Dim sCentroCusto As String = ""

            If VerificaSelecaoNodeDesmarcado(trvMain) = True Then
                For Each oNode As TreeNode In gSelecaoNode
                    sCodigoCentroCusto &= IIf(sCodigoCentroCusto = "", "", ",") & oNode.Tag
                    sCentroCusto &= IIf(sCentroCusto = "", "", ",") & oNode.Text
                Next
            End If

            'Relatório
            goCrystalReport.sReport = goCrystalReport.sPath & "FIN000000018.rpt"

            'Seta Paramentro - Nome
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            'Seta Paramentro - Empresa
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
            'Seta Paramentro - Data Início
            goCrystalReport.sReportParameter(2).sParamenter = "@data_inicio"
            goCrystalReport.sReportParameter(2).sValue = "01/" & DatePart(DateInterval.Month, dtpDataInicioFiltro.Value) & "/" & DatePart(DateInterval.Year, dtpDataInicioFiltro.Value)
            'Seta Paramentro - Número Dias
            goCrystalReport.sReportParameter(3).sParamenter = "@numero_meses"
            goCrystalReport.sReportParameter(3).sValue = cboNumeroMeses.SelectedValue
            'Seta Paramentro - Código Centro Custo
            goCrystalReport.sReportParameter(4).sParamenter = "@codigo_centro_custo"
            goCrystalReport.sReportParameter(4).sValue = sCodigoCentroCusto
            'Seta Paramentro - Centro Custo
            goCrystalReport.sReportParameter(5).sParamenter = "centro_custo"
            goCrystalReport.sReportParameter(5).sValue = sCentroCusto

            'Abre Relatório
            Dim oReport = New usrReport
            oReport.Dock = DockStyle.Fill
            frmMain.LoadPageReport(goCrystalReport.sReport, Me.Parent.Text, oReport)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
