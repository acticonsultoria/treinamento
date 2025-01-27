Imports Janus.Windows.EditControls
Imports Dundas.Charting.WinControl
Imports Janus.Windows.GridEX
Imports System.Linq
Public Class usrEstListagem

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsEstListagem As New clsUsrEstListagem

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usrEstListagem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter 
                    If InStr(sender.name, "Filtro", Microsoft.VisualBasic.CompareMethod.Text) > 0 Then
                        If InStr(sender.name, "Grafico", Microsoft.VisualBasic.CompareMethod.Text) > 0 Then
                            Call LoadGrafico()
                        Else
                            Call LoadGrid()
                        End If
                    End If

                Case Keys.F5

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.WaitCursor

                    Select Case sender.Name

                        Case "cboDepositoFiltro", "cboDepositoFiltroGrafico"
                            Dim oComboBox(1) As UIComboBox
                            oComboBox(0) = cboDepositoFiltro : oComboBox(1) = cboDepositoFiltroGrafico
                            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa)
                        Case "cboGrupoItemFiltro" : Call LoadCombo(cboGrupoItemFiltro, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)

                    End Select

                    'Seta Cursor do Mouse
                    Cursor.Current = Cursors.Default

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrEstListagem_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

#End Region

#Region "::: LISTAGEM :::"

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
            oForm.NomeFormulario = Formulario.EstoqueListagem
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.EstoqueListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGrid.Click

        Try

            'Abre Formulário de Integração com Excel
            Call ExportExcel(grdListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try
            Call Imprimir()

            Call LoadGrid()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            'Carrega Dados
            Call LoadGrid()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click, _
                                                                                                  btnSairGrafico.Click

        Try

            'Deleta Aba
            If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub cboCongelarColuna_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCongelarColuna.SelectedIndexChanged

        Try

            If cboCongelarColuna.SelectedIndex = -1 Then
                grdListagem.FrozenColumns = 0
            Else
                grdListagem.FrozenColumns = cboCongelarColuna.SelectedValue
            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdListagem_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdListagem, _
                                     Formulario.EstoqueListagem)

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
                                     Formulario.EstoqueListagem, _
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
                                          Formulario.EstoqueListagem, _
                                          e.Group.Column.Key, _
                                          IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                          e.ProposedPosition)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick
        Try
            If grdListagem.CurrentColumn.Key = "transferir" Then
                Dim oForm As New frmCadProdutoTransferirMovimentacao
                oForm.CodigoItem = grdListagem.GetValue("codigo_item")
                oForm.DataCorte = IIf(dtpDataCorteFiltro.Checked = True, dtpDataCorteFiltro.Value, "")

                oForm.txtProduto.Text = grdListagem.GetValue("codigo_produto")
                oForm.txtDescricao.Text = grdListagem.GetValue("descricao")
                oForm.txtEstoqueAtual.Text = grdListagem.GetValue("saldo_estoque")
                oForm.ShowDialog()
            End If
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
#End Region

#Region "::: GRÁFICO :::"

#Region "::: DADOS GERAIS :::"

    Private Sub btnFiltrarGrafico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrarGrafico.Click

        Try

            'Carrega Dados
            Call LoadGrafico()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: QUANTIDADE :::"

    Private Sub btnConfigurarGridGrupoItemQuantidade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridGrupoItemQuantidade.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdGrupoItemQuantidade
            oForm.NomeFormulario = Formulario.EstoqueListagem
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdGrupoItemQuantidade, Formulario.EstoqueListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnGraficoGrupoItemQuantidade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGraficoGrupoItemQuantidade.Click

        Try

            'Oculta Controle
            grdGrupoItemQuantidade.Visible = False
            btnConfigurarGridGrupoItemQuantidade.Visible = False
            btnGraficoGrupoItemQuantidade.Visible = False
            btnExcelGridGrupoItemQuantidade.Visible = False
            chrGrupoItemQuantidade.Visible = True

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGridGrupoItemQuantidade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridGrupoItemQuantidade.Click

        Try

            'Abre Formulário de Integração com Excel
            Call ExportExcel(grdGrupoItemQuantidade)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub chrGrupoItemQuantidade_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles chrGrupoItemQuantidade.MouseMove

        Try

            'Call Hit Test Method
            Dim oResult As HitTestResult = chrGrupoItemQuantidade.HitTest(e.X, e.Y)

            'Reset Data Point Attributes
            Dim oPoint As DataPoint
            For Each oPoint In chrGrupoItemQuantidade.Series(0).Points
                oPoint.BackGradientEndColor = Color.Black
                oPoint.BackHatchStyle = ChartHatchStyle.None
                oPoint.BorderWidth = 1
            Next oPoint

            'Se for selecionado o DataPoint ou a Legenda
            If oResult.ChartElementType = ChartElementType.DataPoint Or oResult.ChartElementType = ChartElementType.LegendItem Then

                'Seta o Cursor do Mouse
                chrGrupoItemQuantidade.Cursor = Cursors.Hand

                'Obtem o Ponto Selecionado
                oPoint = chrGrupoItemQuantidade.Series(0).Points(oResult.PointIndex)

                'Seta Gradiente
                oPoint.BackGradientEndColor = Color.White

                'Seta hatch style
                oPoint.BackHatchStyle = ChartHatchStyle.Percent25

                'Increase border width
                oPoint.BorderWidth = 3
            Else

                'Seta o Cursor do Mouse
                chrGrupoItemQuantidade.Cursor = Cursors.Default

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub chrGrupoItemQuantidade_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles chrGrupoItemQuantidade.MouseDown

        Try

            'Call Hit Test Method
            Dim oResult As HitTestResult = chrGrupoItemQuantidade.HitTest(e.X, e.Y)

            If oResult.ChartElementType = ChartElementType.DataPoint Or oResult.ChartElementType = ChartElementType.LegendItem Then

                'Carrega Grid
                Call oClsEstListagem.LoadGridGrupoItemQuantidade(grdGrupoItemQuantidade, _
                                                                 chrGrupoItemQuantidade.Series("Default").Points(oResult.PointIndex).AxisLabel.ToString)

                'Troca Controles
                chrGrupoItemQuantidade.Visible = False
                btnConfigurarGridGrupoItemQuantidade.Visible = True
                btnGraficoGrupoItemQuantidade.Visible = True
                btnExcelGridGrupoItemQuantidade.Visible = True
                grdGrupoItemQuantidade.Visible = True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdGrupoItemQuantidade_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdGrupoItemQuantidade.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdGrupoItemQuantidade, _
                                     Formulario.EstoqueListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdGrupoItemQuantidade_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdGrupoItemQuantidade.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdGrupoItemQuantidade.Name, _
                                     Formulario.EstoqueListagem, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: PREÇO DE VENDA :::"

    Private Sub btnConfigurarGridGrupoItemPrecoVenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridGrupoItemPrecoVenda.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdGrupoItemPrecoVenda
            oForm.NomeFormulario = Formulario.EstoqueListagem
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdGrupoItemPrecoVenda, Formulario.EstoqueListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnGraficoGrupoItemPrecoVenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGraficoGrupoItemPrecoVenda.Click

        Try

            'Oculta Controle
            grdGrupoItemPrecoVenda.Visible = False
            btnConfigurarGridGrupoItemPrecoVenda.Visible = False
            btnGraficoGrupoItemPrecoVenda.Visible = False
            btnExcelGridGrupoItemPrecoVenda.Visible = False
            chrGrupoItemPrecoVenda.Visible = True

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGridGrupoItemPrecoVenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridGrupoItemPrecoVenda.Click

        Try

            'Abre Formulário de Integração com Excel
            Call ExportExcel(grdGrupoItemPrecoVenda)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub chrGrupoItemPrecoVenda_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles chrGrupoItemPrecoVenda.MouseMove

        Try

            'Call Hit Test Method
            Dim oResult As HitTestResult = chrGrupoItemPrecoVenda.HitTest(e.X, e.Y)

            'Reset Data Point Attributes
            Dim oPoint As DataPoint
            For Each oPoint In chrGrupoItemPrecoVenda.Series(0).Points
                oPoint.BackGradientEndColor = Color.Black
                oPoint.BackHatchStyle = ChartHatchStyle.None
                oPoint.BorderWidth = 1
            Next oPoint

            'Se for selecionado o DataPoint ou a Legenda
            If oResult.ChartElementType = ChartElementType.DataPoint Or oResult.ChartElementType = ChartElementType.LegendItem Then

                'Seta o Cursor do Mouse
                chrGrupoItemPrecoVenda.Cursor = Cursors.Hand

                'Obtem o Ponto Selecionado
                oPoint = chrGrupoItemPrecoVenda.Series(0).Points(oResult.PointIndex)

                'Seta Gradiente
                oPoint.BackGradientEndColor = Color.White

                'Seta hatch style
                oPoint.BackHatchStyle = ChartHatchStyle.Percent25

                'Increase border width
                oPoint.BorderWidth = 3
            Else

                'Seta o Cursor do Mouse
                chrGrupoItemPrecoVenda.Cursor = Cursors.Default

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub chrGrupoItemPrecoVenda_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles chrGrupoItemPrecoVenda.MouseDown

        Try

            'Call Hit Test Method
            Dim oResult As HitTestResult = chrGrupoItemPrecoVenda.HitTest(e.X, e.Y)

            If oResult.ChartElementType = ChartElementType.DataPoint Or oResult.ChartElementType = ChartElementType.LegendItem Then

                'Carrega Grid
                Call oClsEstListagem.LoadGridGrupoItemPrecoVenda(grdGrupoItemPrecoVenda, _
                                                                 chrGrupoItemPrecoVenda.Series("Default").Points(oResult.PointIndex).AxisLabel.ToString)

                'Troca Controles
                chrGrupoItemPrecoVenda.Visible = False                
                btnConfigurarGridGrupoItemPrecoVenda.Visible = True
                btnGraficoGrupoItemPrecoVenda.Visible = True
                btnExcelGridGrupoItemPrecoVenda.Visible = True
                grdGrupoItemPrecoVenda.Visible = True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdGrupoItemPrecoVenda_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdGrupoItemPrecoVenda.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdGrupoItemPrecoVenda, _
                                     Formulario.EstoqueListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdGrupoItemPrecoVenda_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdGrupoItemPrecoVenda.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdGrupoItemPrecoVenda.Name, _
                                     Formulario.EstoqueListagem, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: CUSTO MÉDIO :::"

    Private Sub btnConfigurarGridGrupoItemCustoMedio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridGrupoItemCustoMedio.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdGrupoItemCustoMedio
            oForm.NomeFormulario = Formulario.EstoqueListagem
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdGrupoItemCustoMedio, Formulario.EstoqueListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnGraficoGrupoItemCustoMedio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGraficoGrupoItemCustoMedio.Click

        Try

            'Oculta Controle
            grdGrupoItemCustoMedio.Visible = False
            btnConfigurarGridGrupoItemCustoMedio.Visible = False
            btnGraficoGrupoItemCustoMedio.Visible = False
            btnExcelGridGrupoItemCustoMedio.Visible = False
            chrGrupoItemCustoMedio.Visible = True

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGridGrupoItemCustoMedio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridGrupoItemCustoMedio.Click

        Try

            'Abre Formulário de Integração com Excel
            Call ExportExcel(grdGrupoItemCustoMedio)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub chrGrupoItemCustoMedio_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles chrGrupoItemCustoMedio.MouseMove

        Try

            'Call Hit Test Method
            Dim oResult As HitTestResult = chrGrupoItemCustoMedio.HitTest(e.X, e.Y)

            'Reset Data Point Attributes
            Dim oPoint As DataPoint
            For Each oPoint In chrGrupoItemCustoMedio.Series(0).Points
                oPoint.BackGradientEndColor = Color.Black
                oPoint.BackHatchStyle = ChartHatchStyle.None
                oPoint.BorderWidth = 1
            Next oPoint

            'Se for selecionado o DataPoint ou a Legenda
            If oResult.ChartElementType = ChartElementType.DataPoint Or oResult.ChartElementType = ChartElementType.LegendItem Then

                'Seta o Cursor do Mouse
                chrGrupoItemCustoMedio.Cursor = Cursors.Hand

                'Obtem o Ponto Selecionado
                oPoint = chrGrupoItemCustoMedio.Series(0).Points(oResult.PointIndex)

                'Seta Gradiente
                oPoint.BackGradientEndColor = Color.White

                'Seta hatch style
                oPoint.BackHatchStyle = ChartHatchStyle.Percent25

                'Increase border width
                oPoint.BorderWidth = 3
            Else

                'Seta o Cursor do Mouse
                chrGrupoItemCustoMedio.Cursor = Cursors.Default

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub chrGrupoItemCustoMedio_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles chrGrupoItemCustoMedio.MouseDown

        Try

            'Call Hit Test Method
            Dim oResult As HitTestResult = chrGrupoItemCustoMedio.HitTest(e.X, e.Y)

            If oResult.ChartElementType = ChartElementType.DataPoint Or oResult.ChartElementType = ChartElementType.LegendItem Then

                'Carrega Grid
                Call oClsEstListagem.LoadGridGrupoItemCustoMedio(grdGrupoItemCustoMedio, _
                                                                 chrGrupoItemCustoMedio.Series("Default").Points(oResult.PointIndex).AxisLabel.ToString)

                'Troca Controles
                chrGrupoItemCustoMedio.Visible = False                
                btnConfigurarGridGrupoItemCustoMedio.Visible = True
                btnGraficoGrupoItemCustoMedio.Visible = True
                btnExcelGridGrupoItemCustoMedio.Visible = True
                grdGrupoItemCustoMedio.Visible = True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdGrupoItemCustoMedio_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdGrupoItemCustoMedio.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdGrupoItemCustoMedio, _
                                     Formulario.EstoqueListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdGrupoItemCustoMedio_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdGrupoItemCustoMedio.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdGrupoItemCustoMedio.Name, _
                                     Formulario.EstoqueListagem, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

#End Region

#Region "::: PONTO REPOSIÇÃO :::"

    Private Sub btnConfigurarGridPontoReposicao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurarGridPontoReposicao.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdPontoReposicao
            oForm.NomeFormulario = Formulario.EstoqueListagem
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdPontoReposicao, Formulario.EstoqueListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnGraficoPontoReposicao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGraficoPontoReposicao.Click

        Try

            'Oculta Controle
            grdPontoReposicao.Visible = False
            btnConfigurarGridPontoReposicao.Visible = False
            btnGraficoPontoReposicao.Visible = False
            btnExcelGridPontoReposicao.Visible = False
            chrPontoReposicao.Visible = True

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub btnExcelGridPontoReposicao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelGridPontoReposicao.Click

        Try

            'Abre Formulário de Integração com Excel
            Call ExportExcel(grdPontoReposicao)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub chrPontoReposicao_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles chrPontoReposicao.MouseMove

        Try

            'Call Hit Test Method
            Dim oResult As HitTestResult = chrPontoReposicao.HitTest(e.X, e.Y)

            'Reset Data Point Attributes
            Dim oPoint As DataPoint
            For Each oPoint In chrPontoReposicao.Series(0).Points
                oPoint.BackGradientEndColor = Color.Black
                oPoint.BackHatchStyle = ChartHatchStyle.None
                oPoint.BorderWidth = 1
            Next oPoint

            'Se for selecionado o DataPoint ou a Legenda
            If oResult.ChartElementType = ChartElementType.DataPoint Or oResult.ChartElementType = ChartElementType.LegendItem Then

                'Seta o Cursor do Mouse
                chrPontoReposicao.Cursor = Cursors.Hand

                'Obtem o Ponto Selecionado
                oPoint = chrPontoReposicao.Series(0).Points(oResult.PointIndex)

                'Seta Gradiente
                oPoint.BackGradientEndColor = Color.White

                'Seta hatch style
                oPoint.BackHatchStyle = ChartHatchStyle.Percent25

                'Increase border width
                oPoint.BorderWidth = 3
            Else

                'Seta o Cursor do Mouse
                chrPontoReposicao.Cursor = Cursors.Default

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub chrPontoReposicao_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles chrPontoReposicao.MouseDown

        Try

            'Call Hit Test Method
            Dim oResult As HitTestResult = chrPontoReposicao.HitTest(e.X, e.Y)

            If oResult.ChartElementType = ChartElementType.DataPoint Or oResult.ChartElementType = ChartElementType.LegendItem Then

                'Carrega Grid
                Call oClsEstListagem.LoadGridPontoReposicao(grdPontoReposicao, _
                                                            chrPontoReposicao.Series("Default").Points(oResult.PointIndex).AxisLabel.ToString)

                'Troca Controles
                chrPontoReposicao.Visible = False                
                btnConfigurarGridPontoReposicao.Visible = True
                btnGraficoPontoReposicao.Visible = True
                btnExcelGridPontoReposicao.Visible = True
                grdPontoReposicao.Visible = True

            End If

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub grdPontoReposicao_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdPontoReposicao.ColumnMoved

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdPontoReposicao, _
                                     Formulario.EstoqueListagem)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdPontoReposicao_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdPontoReposicao.SizingColumn

        Try

            'Atualiza Grid
            Call UpdateConfiguraGrid(grdPontoReposicao.Name, _
                                     Formulario.EstoqueListagem, _
                                     e.Column.Key, _
                                     e.ProposedWidth)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub
#End Region

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrEstListagem_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Verifica Direito
            btnExcelGrid.Enabled = VerificaDireito(Formulario.EstoqueListagem, gcPrint)

            'Carrega ComboBox
            Dim oComboBox(1) As UIComboBox
            oComboBox(0) = cboDepositoFiltro : oComboBox(1) = cboDepositoFiltroGrafico
            Call LoadCombo(cboUnidadeMedidaFiltro, "sp_select_combo_cadastro_basico_unidade_medida_sigla " & goUsuario.iEmpresa)
            Call LoadCombo(oComboBox, "sp_select_combo_cadastro_basico_deposito " & goUsuario.iEmpresa)
            Call LoadCombo(cboGrupoItemFiltro, "sp_select_combo_cadastro_basico_grupo_item " & goUsuario.iEmpresa)
            Call LoadCombo(cboMarcaFiltro, "sp_select_combo_cadastro_basico_item_marca " & goUsuario.iEmpresa)
            Call LoadComboSimNao(cboConsiderarLoteFiltro)
            Call LoadComboSimNao(cboInsumoProducaoFiltro)
            Call LoadComboColunasGrid(cboCongelarColuna, grdListagem)

            cboStatusFiltro.Items.Clear()
            cboStatusFiltro.Items.Add("ABAIXO DO PONTO REPOSIÇÃO", 1)
            cboStatusFiltro.Items.Add("ACIMA DO PONTO REPOSIÇÃO", 2)
            cboStatusFiltro.Items.Add("SALDO IGUAL A ZERO", 3)
            cboStatusFiltro.Items.Add("SALDO NEGATIVO", 4)
            cboStatusFiltro.Items.Add("SALDO POSITIVO", 5)
            cboStatusFiltro.Items.Add("PRODUTO VENCIDO", 6)
            dtpDataCorteFiltro.Value = Now.Date : dtpDataCorteFiltro.Checked = False
            dtpDataInicioFiltro.Value = Now.Date : dtpDataInicioFiltro.Checked = False

            'Configura Grid
            Call ConfiguraGrid(grdListagem, Formulario.EstoqueListagem)
            Call ConfiguraGrid(grdGrupoItemCustoMedio, Formulario.EstoqueListagem)
            Call ConfiguraGrid(grdGrupoItemPrecoVenda, Formulario.EstoqueListagem)
            Call ConfiguraGrid(grdGrupoItemQuantidade, Formulario.EstoqueListagem)
            Call ConfiguraGrid(grdPontoReposicao, Formulario.EstoqueListagem)

            'Verifica o Tipo da Empresa
            If goUsuario.iCodigoTipoEmpresa = TipoEmpresa.Comercio Then
                grdListagem.RootTable.Columns.Remove("quantidade_producao")
            End If

            'Seleciona Aba
            tabMain.SelectedTab = pagListagem

            'Oculta Controles
            grdGrupoItemQuantidade.Visible = False
            btnConfigurarGridGrupoItemQuantidade.Visible = False
            btnGraficoGrupoItemQuantidade.Visible = False
            btnExcelGridGrupoItemQuantidade.Visible = False
            chrGrupoItemQuantidade.Visible = True

            grdGrupoItemPrecoVenda.Visible = False
            btnConfigurarGridGrupoItemPrecoVenda.Visible = False
            btnGraficoGrupoItemPrecoVenda.Visible = False
            btnExcelGridGrupoItemPrecoVenda.Visible = False
            chrGrupoItemPrecoVenda.Visible = True

            grdGrupoItemCustoMedio.Visible = False
            btnConfigurarGridGrupoItemCustoMedio.Visible = False
            btnGraficoGrupoItemCustoMedio.Visible = False
            btnExcelGridGrupoItemCustoMedio.Visible = False
            chrGrupoItemCustoMedio.Visible = True

            grdPontoReposicao.Visible = False
            btnConfigurarGridPontoReposicao.Visible = False
            btnGraficoPontoReposicao.Visible = False
            btnExcelGridPontoReposicao.Visible = False
            chrPontoReposicao.Visible = True

            cboConsiderarLoteFiltro.SelectedValue = False

            If goUsuario.sSiglaEmpresa <> "MG" Then
                grdListagem.RootTable.Columns("transferir").Visible = False
            End If


            'Seta Focu
            cboDepositoFiltro.Focus()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#Region "::: LISTAGEM :::"

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid
            oClsEstListagem.LoadGrid(grdListagem, _
                                     IIf(cboUnidadeMedidaFiltro.SelectedIndex = -1, -1, cboUnidadeMedidaFiltro.SelectedValue), _
                                     IIf(cboDepositoFiltro.SelectedIndex = -1, -1, cboDepositoFiltro.SelectedValue), _
                                     IIf(cboGrupoItemFiltro.SelectedIndex = -1, -1, cboGrupoItemFiltro.SelectedValue), _
                                     txtCodigoProdutoFiltro.Text.Trim, _
                                     txtLoteFiltro.Text.Trim, _
                                     txtDescricaoFiltro.Text.Trim, _
                                     IIf(cboMarcaFiltro.SelectedIndex = -1, -1, cboMarcaFiltro.SelectedValue), _
                                     IIf(cboConsiderarLoteFiltro.SelectedIndex = -1, 1, IIf(cboConsiderarLoteFiltro.SelectedValue = True, 1, 0)), _
                                     IIf(cboInsumoProducaoFiltro.SelectedIndex = -1, -1, IIf(cboInsumoProducaoFiltro.SelectedValue = True, 1, 0)), _
                                     txtLocalizacaoFiltro.Text.Trim, _
                                     IIf(dtpDataInicioFiltro.Checked = True, dtpDataInicioFiltro.Value, ""), _
                                     IIf(dtpDataCorteFiltro.Checked = True, dtpDataCorteFiltro.Value, ""), _
                                     IIf(cboStatusFiltro.SelectedIndex = -1, -1, cboStatusFiltro.SelectedValue), _
                                     chkIncluirZerado.Checked)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub Imprimir()

        'Váriaveis Locais
        Dim sCodigo As String = ""

        Try

            'Verifica se foi Selecionado Algum Registro
            If VerificaSelecaoRow(grdListagem) = True Then

                'Carrega Código de Movimentação
                For i = 0 To UBound(gSelecaoRow)
                    sCodigo &= IIf(sCodigo = "", "", ",") & gSelecaoRow(i).Cells("codigo_item").Value & "*" & gSelecaoRow(i).Cells("lote").Value
                Next i

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.WaitCursor

                'Redimenciona Vetor
                ReDim goCrystalReport.sReportParameter(1)
                'Seta Parametros
                goCrystalReport.sReportParameter(0).sParamenter = "@codigo"
                goCrystalReport.sReportParameter(0).sValue = sCodigo
                goCrystalReport.sReportParameter(1).sParamenter = "@codigo_empresa"
                goCrystalReport.sReportParameter(1).sValue = goUsuario.iEmpresa
                goCrystalReport.sReport = goCrystalReport.sPath & "EST000000010.rpt"

                Dim oReport As New usrReport
                oReport.Dock = DockStyle.Fill

                'Abre Relatório
                frmMain.LoadPageReport("EST000000010", "Etiqueta", oReport)

                'Seta Cursor do Mouse
                Cursor.Current = Cursors.Default

            Else
                'Informa o Usuário que é necessário Selecionar um ou mais Registros
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function LoadGridCOPAN() As DataSet

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Carrega Grid
            Return oClsEstListagem.LoadGridCOPAN(grdListagem, _
                                     IIf(cboUnidadeMedidaFiltro.SelectedIndex = -1, -1, cboUnidadeMedidaFiltro.SelectedValue), _
                                     IIf(cboDepositoFiltro.SelectedIndex = -1, -1, cboDepositoFiltro.SelectedValue), _
                                     IIf(cboGrupoItemFiltro.SelectedIndex = -1, -1, cboGrupoItemFiltro.SelectedValue), _
                                     txtCodigoProdutoFiltro.Text.Trim, _
                                     txtLoteFiltro.Text.Trim, _
                                     txtDescricaoFiltro.Text.Trim, _
                                     IIf(cboMarcaFiltro.SelectedIndex = -1, -1, cboMarcaFiltro.SelectedValue), _
                                     IIf(cboConsiderarLoteFiltro.SelectedIndex = -1, 1, IIf(cboConsiderarLoteFiltro.SelectedValue = True, 1, 0)), _
                                     IIf(cboInsumoProducaoFiltro.SelectedIndex = -1, -1, IIf(cboInsumoProducaoFiltro.SelectedValue = True, 1, 0)), _
                                     txtLocalizacaoFiltro.Text.Trim, _
                                     IIf(dtpDataInicioFiltro.Checked = True, dtpDataInicioFiltro.Value, ""), _
                                     IIf(dtpDataCorteFiltro.Checked = True, dtpDataCorteFiltro.Value, ""), _
                                     IIf(cboStatusFiltro.SelectedIndex = -1, -1, cboStatusFiltro.SelectedValue))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Function

#End Region

#Region "::: GRÁFICO :::"

    Private Sub LoadGrafico()

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Oculta Controles
            grdGrupoItemQuantidade.Visible = False : btnConfigurarGridGrupoItemQuantidade.Visible = False
            chrGrupoItemQuantidade.Visible = True
            grdGrupoItemPrecoVenda.Visible = False : btnConfigurarGridGrupoItemPrecoVenda.Visible = False
            chrGrupoItemPrecoVenda.Visible = True
            grdGrupoItemCustoMedio.Visible = False : btnConfigurarGridGrupoItemCustoMedio.Visible = False
            chrGrupoItemCustoMedio.Visible = True
            grdPontoReposicao.Visible = False : btnConfigurarGridPontoReposicao.Visible = False
            chrPontoReposicao.Visible = True

            'Carrega Gráfico - Grupo de Item x Quantidade
            oClsEstListagem.LoadGraficoGrupoItemQuantidade(chrGrupoItemQuantidade, _
                                                           IIf(cboDepositoFiltroGrafico.SelectedIndex = -1, -1, cboDepositoFiltroGrafico.SelectedValue))

            'Carrega Gráfico - Grupo de Item x Preço Venda
            oClsEstListagem.LoadGraficoGrupoItemPrecoVenda(chrGrupoItemPrecoVenda, _
                                                           IIf(cboDepositoFiltroGrafico.SelectedIndex = -1, -1, cboDepositoFiltroGrafico.SelectedValue))

            'Carrega Gráfico - Grupo de Item x Custo Médio
            oClsEstListagem.LoadGraficoGrupoItemCustoMedio(chrGrupoItemCustoMedio, _
                                                           IIf(cboDepositoFiltroGrafico.SelectedIndex = -1, -1, cboDepositoFiltroGrafico.SelectedValue))

            'Carrega Gráfico - Ponto de Reposição
            oClsEstListagem.LoadGraficoPontoReposicao(chrPontoReposicao, _
                                                      IIf(cboDepositoFiltroGrafico.SelectedIndex = -1, -1, cboDepositoFiltroGrafico.SelectedValue))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

#End Region

#End Region

End Class
