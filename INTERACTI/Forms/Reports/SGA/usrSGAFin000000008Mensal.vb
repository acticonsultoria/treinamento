Imports Janus.Windows.GridEX

Public Class usrSGAFin000000008Mensal

    'Variáveis da Classe
    Private oClsFin000000008 As New clsUsrFin000000008

#Region "::: CONTROLES :::"

    Private Sub btnConfiguraGridListagem_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfiguraGridListagem.Click

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagemDimas
            oForm.NomeFormulario = Formulario.RelatorioFIN000000001
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagemDimas, Formulario.RelatorioFIN000000001)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelListagem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcelListagem.Click

        Try

            'Exporta para Excel
            Call ExportExcel(grdListagemDimas)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub


    Private Sub usrFin000000008_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrFin000000008_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Enter
                    If InStr(sender.name, "Filtro", CompareMethod.Text) > 0 Then Call LoadGrid() Else Control_Enter(sender)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnConfigurarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Variaveis Locais
            Dim oForm As New frmCfgGrid

            'Seta Parametros
            oForm.Grid = grdListagemDimas
            oForm.NomeFormulario = Formulario.RelatorioFIN000000008
            'Abre Formulário
            Call ConfigureMaskEdit(oForm) : Call LoadControlesTraducao(oForm) : oForm.ShowDialog(Me)

            'Configura Grid
            Call ConfiguraGrid(grdListagemDimas, Formulario.RelatorioFIN000000008)

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub btnExcelGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            'Exporta para Excel
            Call ExportExcel(grdListagemDimas)

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

            'Visualizar Impressão


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

    Private Sub trvMain_AfterCheck(ByVal sender As Object, ByVal e As TreeViewEventArgs)

        Try

            For Each oNode As TreeNode In e.Node.Nodes
                oNode.Checked = e.Node.Checked
            Next

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub


    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Try

            Select Case tabDados.SelectedTab.Name

                Case "pagDimas" : Call ExportExcel(grdListagemDimas)
                Case "pagGroupserv" : Call ExportExcel(grdListagemGroupserv)
                Case "pagRodrigues" : Call ExportExcel(grdListagemRodrigues)
                Case "pagSolutions" : Call ExportExcel(grdListagemSolutions)
                Case "pagTotais" : Call ExportExcel(grdListagemTotais)

            End Select

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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usrFin000000008_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            'Carrega ComboBox
            cboTipo.Items.Clear()
            cboTipo.Items.Add("DESPESA", "D")
            cboTipo.Items.Add("RECEITA", "R")


            'Configura DateTimePicker
            cboTipoDataFiltro.Items.Clear()
            cboTipoDataFiltro.Items.Add("DATA EMISSÃO", 1)
            cboTipoDataFiltro.Items.Add("DATA VENCIMENTO", 2)
            cboTipoDataFiltro.Items.Add("DATA PAGAMENTO", 3)

            cboTipoDataFiltro.SelectedIndex = -1

            'Seta Direito
            btnVisualizarImpressao.Enabled = VerificaDireito(Formulario.RelatorioFIN000000008, gcPrint)
            btnExcelListagem.Enabled = VerificaDireito(Formulario.RelatorioFIN000000008, gcPrint)


            Dim oVetor(4) As GridEX
            oVetor(0) = grdListagemDimas
            oVetor(1) = grdListagemGroupserv
            oVetor(2) = grdListagemRodrigues
            oVetor(3) = grdListagemSolutions
            oVetor(4) = grdListagemTotais

            For i As Integer = 0 To 4

                Dim oGridex As GridEX = oVetor(i)

                Dim oFormatCondition As GridEXFormatCondition

                ' FORMATAÇÃO das grids
                Dim oFormatCellStyleNivel3 As New GridEXFormatStyle
                oFormatCellStyleNivel3.ForeColor = Color.SteelBlue

                Dim oFormatCellStyleNivel2 As New GridEXFormatStyle
                oFormatCellStyleNivel2.ForeColor = Color.Purple

                Dim oFormatCellStyleNivel1 As New GridEXFormatStyle
                oFormatCellStyleNivel1.ForeColor = Color.ForestGreen
                oFormatCellStyleNivel1.FontBold = TriState.True

                Dim oFormatCellStyleNivelSemNivel As New GridEXFormatStyle
                oFormatCellStyleNivelSemNivel.ForeColor = Color.Firebrick
                oFormatCellStyleNivelSemNivel.FontBold = TriState.True

                oFormatCondition = New GridEXFormatCondition(oGridex.RootTable.Columns("nivel"), ConditionOperator.Equal, 3)
                oFormatCondition.FormatStyle = oFormatCellStyleNivel3
                oGridex.RootTable.FormatConditions.Add(oFormatCondition)

                oFormatCondition = New GridEXFormatCondition(oGridex.RootTable.Columns("nivel"), ConditionOperator.Equal, 2)
                oFormatCondition.FormatStyle = oFormatCellStyleNivel2
                oGridex.RootTable.FormatConditions.Add(oFormatCondition)


                oFormatCondition = New GridEXFormatCondition(oGridex.RootTable.Columns("nivel"), ConditionOperator.Equal, 1)
                oFormatCondition.FormatStyle = oFormatCellStyleNivel1
                oGridex.RootTable.FormatConditions.Add(oFormatCondition)

                oFormatCondition = New GridEXFormatCondition(oGridex.RootTable.Columns("nivel"), ConditionOperator.IsNull, "")
                oFormatCondition.FormatStyle = oFormatCellStyleNivelSemNivel
                oGridex.RootTable.FormatConditions.Add(oFormatCondition)


            Next
            ' FORMATAÇÃO das grids

            'Seta Focu
            cboTipo.Focus()

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

            If ValidaCampo(cboTipoDataFiltro, lblTipoData) = False Then
                Exit Sub
            End If

            If ValidaCampo(dtpDataInicioFiltro, lblDataEmissao) = False Then
                Exit Sub
            End If

            If ValidaCampo(dtpDataTerminoFiltro, lblDataEmissao) = False Then
                Exit Sub
            End If

            'Load Grid Dimas
            oClsFin000000008.LoadGridDetalhado(grdListagemDimas, 1, _
                                                IIf(cboTipo.SelectedIndex = -1, "", cboTipo.SelectedValue), _
                                                cboTipoDataFiltro.SelectedValue, _
                                               IIf(dtpDataInicioFiltro.Checked = True, dtpDataInicioFiltro.Value, ""), _
                                               IIf(dtpDataTerminoFiltro.Checked = True, dtpDataTerminoFiltro.Value, ""))

            oClsFin000000008.LoadGridDetalhado(grdListagemSolutions, 2, _
                                                IIf(cboTipo.SelectedIndex = -1, "", cboTipo.SelectedValue), _
                                                cboTipoDataFiltro.SelectedValue, _
                                               IIf(dtpDataInicioFiltro.Checked = True, dtpDataInicioFiltro.Value, ""), _
                                               IIf(dtpDataTerminoFiltro.Checked = True, dtpDataTerminoFiltro.Value, ""))

            oClsFin000000008.LoadGridDetalhado(grdListagemRodrigues, 3, _
                                                IIf(cboTipo.SelectedIndex = -1, "", cboTipo.SelectedValue), _
                                                cboTipoDataFiltro.SelectedValue, _
                                               IIf(dtpDataInicioFiltro.Checked = True, dtpDataInicioFiltro.Value, ""), _
                                               IIf(dtpDataTerminoFiltro.Checked = True, dtpDataTerminoFiltro.Value, ""))

            oClsFin000000008.LoadGridDetalhado(grdListagemGroupserv, 4, _
                                                IIf(cboTipo.SelectedIndex = -1, "", cboTipo.SelectedValue), _
                                                cboTipoDataFiltro.SelectedValue, _
                                               IIf(dtpDataInicioFiltro.Checked = True, dtpDataInicioFiltro.Value, ""), _
                                               IIf(dtpDataTerminoFiltro.Checked = True, dtpDataTerminoFiltro.Value, ""))

            oClsFin000000008.LoadGridDetalhado(grdListagemTotais, -1, _
                                                IIf(cboTipo.SelectedIndex = -1, "", cboTipo.SelectedValue), _
                                                cboTipoDataFiltro.SelectedValue, _
                                               IIf(dtpDataInicioFiltro.Checked = True, dtpDataInicioFiltro.Value, ""), _
                                               IIf(dtpDataTerminoFiltro.Checked = True, dtpDataTerminoFiltro.Value, ""))

            'oClsFin000000008.LoadGridSGA(grdListagemDimas, _
            '                             grdListagemSolutions, _
            '                             grdListagemRodrigues, _
            '                             grdListagemGroupserv, _
            '                             grdListagemTotais, _
            '                          IIf(cboTipo.SelectedIndex = -1, "", cboTipo.SelectedValue), _
            '                          IIf(dtpDataEmissaoInicioFiltro.Checked = True, dtpDataEmissaoInicioFiltro.Value, ""), _
            '                          IIf(dtpDataEmissaoTerminoFiltro.Checked = True, dtpDataEmissaoTerminoFiltro.Value, ""), _
            '                          IIf(dtpDataVencimentoInicioFiltro.Checked = True, dtpDataVencimentoInicioFiltro.Value, ""), _
            '                          IIf(dtpDataVencimentoTerminoFiltro.Checked = True, dtpDataVencimentoTerminoFiltro.Value, ""), _
            '                          IIf(dtpDataPagamentoInicioFiltro.Checked = True, dtpDataPagamentoInicioFiltro.Value, ""), _
            '                          IIf(dtpDataPagamentoTerminoFiltro.Checked = True, dtpDataPagamentoTerminoFiltro.Value, ""))

            ''Load Grid Dimas
            'oClsFin000000008.LoadGridSGA(grdListagemDimas, _
            '                          IIf(cboTipo.SelectedIndex = -1, "", cboTipo.SelectedValue), _
            '                          IIf(dtpDataEmissaoInicioFiltro.Checked = True, dtpDataEmissaoInicioFiltro.Value, ""), _
            '                          IIf(dtpDataEmissaoTerminoFiltro.Checked = True, dtpDataEmissaoTerminoFiltro.Value, ""), _
            '                          IIf(dtpDataVencimentoInicioFiltro.Checked = True, dtpDataVencimentoInicioFiltro.Value, ""), _
            '                          IIf(dtpDataVencimentoTerminoFiltro.Checked = True, dtpDataVencimentoTerminoFiltro.Value, ""), _
            '                          IIf(dtpDataPagamentoInicioFiltro.Checked = True, dtpDataPagamentoInicioFiltro.Value, ""), _
            '                          IIf(dtpDataPagamentoTerminoFiltro.Checked = True, dtpDataPagamentoTerminoFiltro.Value, ""), _
            '                          sCodigoCentroCusto & ", -1", 1)

            ''Load Grid Solutions
            'oClsFin000000008.LoadGridSGA(grdListagemSolutions, _
            '                          IIf(cboTipo.SelectedIndex = -1, "", cboTipo.SelectedValue), _
            '                          IIf(dtpDataEmissaoInicioFiltro.Checked = True, dtpDataEmissaoInicioFiltro.Value, ""), _
            '                          IIf(dtpDataEmissaoTerminoFiltro.Checked = True, dtpDataEmissaoTerminoFiltro.Value, ""), _
            '                          IIf(dtpDataVencimentoInicioFiltro.Checked = True, dtpDataVencimentoInicioFiltro.Value, ""), _
            '                          IIf(dtpDataVencimentoTerminoFiltro.Checked = True, dtpDataVencimentoTerminoFiltro.Value, ""), _
            '                          IIf(dtpDataPagamentoInicioFiltro.Checked = True, dtpDataPagamentoInicioFiltro.Value, ""), _
            '                          IIf(dtpDataPagamentoTerminoFiltro.Checked = True, dtpDataPagamentoTerminoFiltro.Value, ""), _
            '                          sCodigoCentroCusto & ", -1", 2)

            ''Load Grid Rodrigues
            'oClsFin000000008.LoadGridSGA(grdListagemRodrigues, _
            '                          IIf(cboTipo.SelectedIndex = -1, "", cboTipo.SelectedValue), _
            '                          IIf(dtpDataEmissaoInicioFiltro.Checked = True, dtpDataEmissaoInicioFiltro.Value, ""), _
            '                          IIf(dtpDataEmissaoTerminoFiltro.Checked = True, dtpDataEmissaoTerminoFiltro.Value, ""), _
            '                          IIf(dtpDataVencimentoInicioFiltro.Checked = True, dtpDataVencimentoInicioFiltro.Value, ""), _
            '                          IIf(dtpDataVencimentoTerminoFiltro.Checked = True, dtpDataVencimentoTerminoFiltro.Value, ""), _
            '                          IIf(dtpDataPagamentoInicioFiltro.Checked = True, dtpDataPagamentoInicioFiltro.Value, ""), _
            '                          IIf(dtpDataPagamentoTerminoFiltro.Checked = True, dtpDataPagamentoTerminoFiltro.Value, ""), _
            '                          sCodigoCentroCusto & ", -1", 3)

            ''Load Grid Groupserv
            'oClsFin000000008.LoadGridSGA(grdListagemGroupserv, _
            '                          IIf(cboTipo.SelectedIndex = -1, "", cboTipo.SelectedValue), _
            '                          IIf(dtpDataEmissaoInicioFiltro.Checked = True, dtpDataEmissaoInicioFiltro.Value, ""), _
            '                          IIf(dtpDataEmissaoTerminoFiltro.Checked = True, dtpDataEmissaoTerminoFiltro.Value, ""), _
            '                          IIf(dtpDataVencimentoInicioFiltro.Checked = True, dtpDataVencimentoInicioFiltro.Value, ""), _
            '                          IIf(dtpDataVencimentoTerminoFiltro.Checked = True, dtpDataVencimentoTerminoFiltro.Value, ""), _
            '                          IIf(dtpDataPagamentoInicioFiltro.Checked = True, dtpDataPagamentoInicioFiltro.Value, ""), _
            '                          IIf(dtpDataPagamentoTerminoFiltro.Checked = True, dtpDataPagamentoTerminoFiltro.Value, ""), _
            '                          sCodigoCentroCusto & ", -1", 4)

            ''Load Grid Totais
            'oClsFin000000008.LoadGridSGA(grdListagemTotais, _
            '                          IIf(cboTipo.SelectedIndex = -1, "", cboTipo.SelectedValue), _
            '                          IIf(dtpDataEmissaoInicioFiltro.Checked = True, dtpDataEmissaoInicioFiltro.Value, ""), _
            '                          IIf(dtpDataEmissaoTerminoFiltro.Checked = True, dtpDataEmissaoTerminoFiltro.Value, ""), _
            '                          IIf(dtpDataVencimentoInicioFiltro.Checked = True, dtpDataVencimentoInicioFiltro.Value, ""), _
            '                          IIf(dtpDataVencimentoTerminoFiltro.Checked = True, dtpDataVencimentoTerminoFiltro.Value, ""), _
            '                          IIf(dtpDataPagamentoInicioFiltro.Checked = True, dtpDataPagamentoInicioFiltro.Value, ""), _
            '                          IIf(dtpDataPagamentoTerminoFiltro.Checked = True, dtpDataPagamentoTerminoFiltro.Value, ""), _
            '                          sCodigoCentroCusto & ", -1", -1)



            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub



#End Region

    
    Private Sub cboTipoDataFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoDataFiltro.SelectedIndexChanged
        Try
            If cboTipoDataFiltro.SelectedIndex = -1 Then
                dtpDataInicioFiltro.Enabled = False
                dtpDataTerminoFiltro.Enabled = False
            Else
                dtpDataInicioFiltro.Enabled = True
                dtpDataTerminoFiltro.Enabled = True
            End If
        Catch ex As Exception
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try
    End Sub
End Class
