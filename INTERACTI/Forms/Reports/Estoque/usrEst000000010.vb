Imports Janus.Windows.GridEX
Imports System.IO

Public Class usrEst000000010

#Region "::: VÁRIAVEIS :::"

    'Váriaveis da Classe
    Private oClsEst000000010 As New clsUsrEst000000010

#End Region

#Region "::: CONTROLES :::"

    Private Sub usrEst000000010_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", Microsoft.VisualBasic.CompareMethod.Text) > 0 Then
                        Call LoadGrid()
                    End If

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrEst000000010_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGrid.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagem
            oForm.NomeFormulario = Formulario.RelatorioEST000000010
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioEST000000010)

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

    Private Sub btnVisualizarImpressao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizarImpressao.Click

        Try

            'Visualizar Impressão
            Call VisualizarImpressao()

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

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.RelatorioEST000000010)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem.Name, _
                                     Formulario.RelatorioEST000000010, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub CarregaGrid() Handles cboNumeroMesesFiltro.SelectedIndexChanged, _
                                      dtpDataInicioFiltro.ValueChanged

        Try

            'Limpa Controles
            grdListagem.DataSource = Nothing

            'Exclui Colunas
            For i = grdListagem.RootTable.Columns.Count - 1 To 1 Step -1
                If grdListagem.RootTable.Columns(i).Key <> "descricao" Then
                    grdListagem.RootTable.Columns.Remove(grdListagem.RootTable.Columns(i).Key)
                End If
            Next

            If cboNumeroMesesFiltro.SelectedIndex > -1 Then

                Dim oColumn As GridEXColumn

                For i As Integer = 1 To cboNumeroMesesFiltro.SelectedValue

                    'Adiciona Coluna - Valor Faturado
                    oColumn = New GridEXColumn(i)
                    oColumn.AllowSize = False
                    oColumn.Width = 100
                    oColumn.HeaderAlignment = TextAlignment.Center
                    oColumn.HeaderLineAlignment = TextAlignment.Center
                    oColumn.TextAlignment = TextAlignment.Center
                    oColumn.LineAlignment = TextAlignment.Center
                    oColumn.SelectableCells = SelectableCells.FilterRowCells
                    oColumn.AggregateFunction = AggregateFunction.Sum
                    oColumn.TotalFormatString = "#,#0.00"
                    oColumn.FormatString = "#,#0.00"
                    oColumn.Caption = Format(DateAdd(DateInterval.Month, i - 1, dtpDataInicioFiltro.Value), "MM/yyyy")
                    oColumn.CellStyle.BackColor = IIf(i Mod 2 = 0, System.Drawing.SystemColors.Info, Color.Transparent)
                    grdListagem.RootTable.Columns.Add(oColumn)


                    'Adiciona Coluna - RO
                    oColumn = New GridEXColumn("RO_" & i)
                    oColumn.AllowSize = False
                    oColumn.Width = 100
                    oColumn.HeaderAlignment = TextAlignment.Center
                    oColumn.HeaderLineAlignment = TextAlignment.Center
                    oColumn.TextAlignment = TextAlignment.Center
                    oColumn.LineAlignment = TextAlignment.Center
                    oColumn.SelectableCells = SelectableCells.FilterRowCells
                    oColumn.AggregateFunction = AggregateFunction.Sum
                    oColumn.TotalFormatString = "#,#0.00"
                    oColumn.FormatString = "#,#0.00"
                    oColumn.Caption = "RO " & Format(DateAdd(DateInterval.Month, i - 1, dtpDataInicioFiltro.Value), "MM/yyyy")
                    oColumn.CellStyle.BackColor = IIf(i Mod 2 = 0, System.Drawing.SystemColors.Info, Color.Transparent)
                    grdListagem.RootTable.Columns.Add(oColumn)

                    'Adiciona Coluna - Percentual RO
                    oColumn = New GridEXColumn("PRO_" & i)
                    oColumn.AllowSize = False
                    oColumn.Width = 60
                    oColumn.HeaderAlignment = TextAlignment.Center
                    oColumn.HeaderLineAlignment = TextAlignment.Center
                    oColumn.TextAlignment = TextAlignment.Center
                    oColumn.LineAlignment = TextAlignment.Center
                    oColumn.SelectableCells = SelectableCells.FilterRowCells
                    oColumn.AggregateFunction = AggregateFunction.Sum
                    oColumn.TotalFormatString = "#,#0.00%"
                    oColumn.FormatString = "#,#0.00%"
                    oColumn.Caption = "% RO " & Format(DateAdd(DateInterval.Month, i - 1, dtpDataInicioFiltro.Value), "MM/yyyy")
                    oColumn.CellStyle.BackColor = IIf(i Mod 2 = 0, System.Drawing.SystemColors.Info, Color.Transparent)
                    grdListagem.RootTable.Columns.Add(oColumn)

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

            'Adiciona KeyUP
            Call AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrEst000000010_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Seta Controles
            dtpDataInicioFiltro.Value = Now.Date

            'Verifica Direito
            btnExcelGrid.Enabled = VerificaDireito(Formulario.RelatorioEST000000010, gcPrint)
            btnVisualizarImpressao.Enabled = VerificaDireito(Formulario.RelatorioEST000000010, gcPrint)

            'Carrega Combo
            Call LoadComboNumeroMes(cboNumeroMesesFiltro)
            Call LoadCombo(cboMarcaFiltro, "sp_select_cadastro_basico_item_marca " & goUsuario.iEmpresa, False)
            Call LoadCombo(cboGrupoItemFiltro, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa, False)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.RelatorioEST000000010)

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

            'Carrega Grid
            Call oClsEst000000010.LoadGrid(grdListagem, _
                                           "01/" & DatePart(DateInterval.Month, dtpDataInicioFiltro.Value) & "/" & DatePart(DateInterval.Year, dtpDataInicioFiltro.Value), _
                                           cboNumeroMesesFiltro.SelectedValue, _
                                           IIf(cboGrupoItemFiltro.SelectedIndex = -1, -1, cboGrupoItemFiltro.SelectedValue), _
                                           IIf(cboMarcaFiltro.SelectedIndex = -1, "", cboMarcaFiltro.SelectedValue), _
                                           txtEstoqueMinimoFiltro.Value)

            'Move para o Primeiro Registro
            grdListagem.MoveFirst()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub VisualizarImpressao()

        Try

            'Redimensiona Vetor
            ReDim goCrystalReport.sReportParameter(6)

            'Relatório
            goCrystalReport.sReport = goCrystalReport.sPath & "FAT000000020.rpt"

            'Seta Paramentro - Nome
            goCrystalReport.sReportParameter(0).sParamenter = "usuario"
            goCrystalReport.sReportParameter(0).sValue = goUsuario.sNome
            'Seta Paramentro - Empresa
            goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
            'Seta Paramentro - Data Emissão Início
            goCrystalReport.sReportParameter(2).sParamenter = "@data_inicio"
            goCrystalReport.sReportParameter(2).sValue = "01/" & DatePart(DateInterval.Month, dtpDataInicioFiltro.Value) & "/" & DatePart(DateInterval.Year, dtpDataInicioFiltro.Value)
            'Seta Paramentro - Número Meses
            goCrystalReport.sReportParameter(3).sParamenter = "@numero_meses"
            goCrystalReport.sReportParameter(3).sValue = cboNumeroMesesFiltro.SelectedValue
            'Seta Paramentro - Código Grupo Item
            goCrystalReport.sReportParameter(4).sParamenter = "@codigo_grupo_item"
            goCrystalReport.sReportParameter(4).sValue = IIf(cboGrupoItemFiltro.SelectedIndex = -1, -1, cboGrupoItemFiltro.SelectedValue)
            'Seta Paramentro - Código Marca
            goCrystalReport.sReportParameter(5).sParamenter = "@codigo_marca"
            goCrystalReport.sReportParameter(5).sValue = IIf(cboMarcaFiltro.SelectedIndex = -1, "", cboMarcaFiltro.SelectedValue)
            'Seta Paramentro - Fator
            goCrystalReport.sReportParameter(6).sParamenter = "@fator"
            goCrystalReport.sReportParameter(6).sValue = txtEstoqueMinimoFiltro.Value

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
