Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports System.IO

Public Class usrPrdCenario

#Region "::: VARIAVEIS :::"

    'Variáveis da Classe
    Private oClsUsrPrdCenario As New clsUsrPrdCenario
    Private iFormulario As Integer

#End Region

#Region "::: CONTROLES :::"

#Region "::: DADOS GERAIS :::"

    Private Sub usr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

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

    Private Sub usr_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura UserControl
        ConfigurarUserControl()

    End Sub

#End Region

#Region "::: CENÁRIO :::"

    Private Sub cboOrcamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOrcamento.SelectedIndexChanged
        Try

            If cboOrcamento.SelectedIndex = -1 Then Exit Sub

            dtpDataEntregaOrcamento.Value = LoadCodigo("sp_select_venda_orcamento_data_entrega " & cboOrcamento.SelectedValue & "," & goUsuario.iEmpresa)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
    Private Sub grdOrcamento_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdOrcamento.RowDoubleClick
        Try
            ExcluirOrcamento()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnInserirOrcamento_Click(sender As Object, e As EventArgs) Handles btnInserirOrcamento.Click
        Try
            InserirOrcamento()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub cboMaquina_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMaquina.SelectedIndexChanged
        Try

            If cboMaquina.SelectedIndex <> -1 Then

                oClsUsrPrdCenario.LoadGridPlanejamentoMaquina(grdPlanejamento,
                                                              btnSalvar.Tag,
                                                              cboMaquina.SelectedValue)

            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub dtpDataTerminoFiltro_LostFocus(sender As Object, e As EventArgs) Handles dtpDataTerminoFiltro.LostFocus
        Try
            CalcularDiasUteis()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click

        Try

            Delete()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Try

            LoadGrid()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click

        Try

            Novo()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnNovo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo1.Click

        Try

            Novo()

            tabMain.TabPages.Remove(pagLista)
            tabMain.TabPages.Add(pagDados)

            txtCenario.Focus()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Try

            frmMain.errInfo.Clear()

            If Validacao() = False Then Exit Sub

            If MsgBox("Deseja salvar o cenário? Após a confirmação, ele será bloqueado para edições futuras.", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                'Salva Dados de Qualidade
                Call Salvar()

            End If


        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
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

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click

        Try

            'Carrega Grid
            Call LoadGrid()

            'Alterna Aba
            tabMain.TabPages.Remove(pagDados)
            tabMain.TabPages.Add(pagLista)

            'Seta Focu
            txtCenarioFiltro.Focus()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub grdListagem_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grdListagem.RowDoubleClick

        Try

            If IsNothing(grdListagem.CurrentColumn) Then Exit Sub

            Select Case grdListagem.CurrentColumn.Key

                Case "editar" : Editar()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_SizingColumn(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.SizingColumnEventArgs) Handles grdListagem.SizingColumn, _
                                                                                                                        grdPool.SizingColumn, _
                                                                                                                        grdCarga.SizingColumn, _
                                                                                                                        grdManutencao.SizingColumn, _
                                                                                                                        grdPlanejamento.SizingColumn

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(sender.Name, _
                                iFormulario, _
                                e.Column.Key, _
                                e.ProposedWidth)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_ColumnMoved(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdListagem.ColumnMoved, _
                                                                                                                       grdPool.ColumnMoved, _
                                                                                                                       grdCarga.ColumnMoved, _
                                                                                                                       grdManutencao.ColumnMoved, _
                                                                                                                       grdPlanejamento.ColumnMoved

        Try

            'Atualiza Grid
            UpdateConfiguraGrid(sender, _
                                iFormulario)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grd_GroupsChanging(sender As Object, e As GroupsChangingEventArgs) Handles grdListagem.GroupsChanging, _
                                                                                           grdPool.GroupsChanging, _
                                                                                           grdCarga.GroupsChanging, _
                                                                                           grdManutencao.GroupsChanging, _
                                                                                           grdPlanejamento.GroupsChanging

        Try

            'Atualiza Grid
            UpdateConfiguraGridGrupo(sender.Name, _
                                     iFormulario, _
                                     e.Group.Column.Key, _
                                     IIf(e.Action = GroupChangeAction.Add Or e.Action = GroupChangeAction.Move, True, False), _
                                     e.ProposedPosition)

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnGerarCenario_Click(sender As Object, e As EventArgs) Handles btnGerarCenario.Click

        Try

            GerarCenario()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnCadastrarCentroTrabalho_Click(sender As Object, e As EventArgs) Handles btnCadastrarCentroTrabalho.Click

        Try

            Dim oForm As New frmPrdCenarioManutencao
            oForm.CodigoCenario = btnSalvar.Tag
            oForm.ShowDialog()

            LoadGridManutencao()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdManutencao_RowDoubleClick(sender As Object, e As RowActionEventArgs) Handles grdManutencao.RowDoubleClick

        Try

            If IsNothing(grdManutencao.CurrentColumn) Then Exit Sub

            Select Case grdManutencao.CurrentColumn.Key

                Case "excluir" : ExcluirManutencao()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub grdCarga_CellValueChanged(sender As Object, e As ColumnActionEventArgs) Handles grdCarga.CellValueChanged

        Try

            Select Case grdCarga.CurrentColumn.Key

                Case "turno1" : CalculoCargaHoras()
                Case "turno2" : CalculoCargaHoras()
                Case "turno3" : CalculoCargaHoras()

            End Select

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnVisualizarGrafico_Click(sender As Object, e As EventArgs) Handles btnVisualizarGrafico.Click
        Try

            VisualizarGrafico()

        Catch ex As Exception

            Call TratamentoErro(ex.Message, Me.Parent.Text)

        End Try
    End Sub


#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: DADOS GERAIS :::"

    Private Sub ConfigurarUserControl()

        Try

            Cursor.Current = Cursors.WaitCursor

            iFormulario = LoadCodigo("sp_select_static_formulario_codigo_user_control '" & Me.Name & "'")

            AddGotFocus(Me, New DelegateGotFocus(AddressOf Control_GotFocus))
            AddKeyDown(Me, New DelegateKeyDown(AddressOf usr_KeyDown))
            AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            btnExcluir.Enabled = VerificaDireito(iFormulario, gcDelete)
            btnNovo1.Enabled = VerificaDireito(iFormulario, gcInsert)


            tabMain.TabPages.Remove(pagDados)

            dtpDataCenarioFiltroInicio.Checked = False : dtpDataCenarioFiltroInicio.Value = DateAdd(DateInterval.Month, -1, Now)
            dtpDataCenarioFiltroTermino.Checked = False : dtpDataCenarioFiltroTermino.Value = Now


            Call LoadCombo(cboMaquina, "sp_select_combo_cadastro_basico_maquina -1," & goUsuario.iEmpresa)
            Call LoadCombo(cboOrcamento, "sp_select_combo_venda_orcamento_orcamento_cenario_planejamento " & goUsuario.iEmpresa)
            Call LoadCombo(cboStatusFiltro, "sp_select_combo_static_status_ordem_producao 1")
            cboStatusFiltro.CheckAll()

            ConfiguraGrid(grdListagem, iFormulario)
            ConfiguraGrid(grdPool, iFormulario)
            ConfiguraGrid(grdCarga, iFormulario)
            ConfiguraGrid(grdManutencao, iFormulario)
            ConfiguraGrid(grdPlanejamento, iFormulario)

            txtCenarioFiltro.Focus()

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

#Region "::: CENÁRIO :::"

    Private Sub InserirOrcamento()
        Try

            frmMain.errInfo.Clear()

            If ValidaCampo(cboOrcamento, lblOrcamento) = False Then Exit Sub

            'Insere o orçamento na carga
            oClsUsrPrdCenario.InsertOrcamento(btnSalvar.Tag, cboOrcamento.SelectedValue, dtpDataEntregaOrcamento.Value)

            'Limpa o registro
            cboOrcamento.SelectedIndex = -1

            'Carrega os dados
            LoadGridOrcamento()


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ExcluirOrcamento()
        Try

            'Excluir
            oClsUsrPrdCenario.DeleteOrcamento(btnSalvar.Tag, grdOrcamento.GetValue("codigo"))

            'Carrega os dados novamente
            LoadGridOrcamento()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LoadGridOrcamento()

        Try

            oClsUsrPrdCenario.LoadGridOrcamento(grdOrcamento, btnSalvar.Tag)
            oClsUsrPrdCenario.LoadGridOrcamentoOperacao(grdOrcamentoOperacao, btnSalvar.Tag)


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Editar()

        Try
            Dim bRegistroSalvo As Boolean

            'Verifica se o Usuário tem direito para Alterar os Dados
            If VerificaDireito(iFormulario, gcUpdate) = True Then

                Cursor.Current = Cursors.WaitCursor

                'Limpa Formulário
                Novo(False)

                'Desabilita os campos se ja foi salvo
                bRegistroSalvo = grdListagem.GetValue("registro_salvo")
                DesabilitarCampos(bRegistroSalvo)

                btnSalvar.Tag = grdListagem.GetValue("codigo")
                txtCenario.Text = grdListagem.GetValue("cenario")
                dtpDataCenario.Value = grdListagem.GetValue("data")
                dtpDataTerminoFiltro.Value = grdListagem.GetValue("data_termino")
                txtDiasUteisFiltro.Value = grdListagem.GetValue("dias_uteis")

                oClsUsrPrdCenario.LoadGridPool(grdPool, btnSalvar.Tag)
                oClsUsrPrdCenario.LoadGridCarga(grdCarga, dtpDataTerminoFiltro.Value, txtDiasUteisFiltro.Value)
                oClsUsrPrdCenario.LoadGridManutencao(grdManutencao, btnSalvar.Tag)
                oClsUsrPrdCenario.LoadGridPlanejamentoEdicao(grdPlanejamento, btnSalvar.Tag)

                tabMain.TabPages.Remove(pagLista)
                tabMain.TabPages.Add(pagDados)

                Cursor.Current = Cursors.Default

            Else
                frmMain.Informacao(Mensagem.DireitoAlteracao)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Delete()

        Try

            If VerificaSelecaoRow(grdListagem) = True Then

                If MsgBox("Deseja excluir permanentemente este" & IIf(gSelecaoRow.Count = 1, " ", "s ") & gSelecaoRow.Count & " registro" & IIf(gSelecaoRow.Count = 1, "?", "s?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Parent.Text) = MsgBoxResult.Yes Then

                    Cursor.Current = Cursors.WaitCursor

                    oClsUsrPrdCenario.Delete()

                    frmMain.Informacao(Mensagem.RegistroExcluido)

                    Cursor.Current = Cursors.Default

                End If

            Else
                frmMain.Informacao(Mensagem.ValidacaoSelecionar)
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Novo(Optional ByVal bGerarCodigo As Boolean = True)

        Try

            LimparCamposGroupBox(grpDados)
            LimparCamposGroupBox(grpFiltroPool)

            LoadGridOrcamento()

            grdPool.DataSource = Nothing
            grdCarga.DataSource = Nothing
            grdManutencao.DataSource = Nothing
            grdPlanejamento.DataSource = Nothing

            btnSalvar.Tag = ""

            If bGerarCodigo = False Then Exit Sub

            oClsUsrPrdCenario.GerarCodigo(btnSalvar)

            tabDados.SelectedTab = pagPool

            txtCenario.Focus()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Salvar()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor


            Call oClsUsrPrdCenario.UpdateCenario(lCodigo:=btnSalvar.Tag,
                                                 sCenario:=txtCenario.Text.Trim,
                                                 sData:=dtpDataCenario.Value,
                                                 iCodigoMaquina:=cboMaquina.SelectedValue,
                                                 sDataTerino:=dtpDataTerminoFiltro.Value,
                                                 iDiasUteis:=txtDiasUteisFiltro.Value)


            frmMain.Informacao(Mensagem.RegistroSalvo)


            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGrid()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Parametros
            oClsUsrPrdCenario.LoadGrid(grdListagem, _
                                       txtCenarioFiltro.Text.Trim, _
                                       IIf(dtpDataCenarioFiltroInicio.Checked = False, "", dtpDataCenarioFiltroInicio.Value), _
                                       IIf(dtpDataCenarioFiltroTermino.Checked = False, "", dtpDataCenarioFiltroTermino.Value))

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            If ValidaCampo(txtCenario, lblCenario, TipoCampo.texto) = False Then Return False

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub GerarCenario()

        Try

            Cursor.Current = Cursors.WaitCursor
            Dim sStatus As String = ""

            'Status
            If cboStatusFiltro.SelectionLength > 0 Then
                For i = 0 To UBound(cboStatusFiltro.CheckedValues)
                    sStatus &= IIf(sStatus = "", "", ",") & cboStatusFiltro.CheckedValues(i).ToString
                Next
            End If
            oClsUsrPrdCenario.InsertPool(btnSalvar.Tag, sStatus, dtpDataTerminoFiltro.Value)

            LoadGridPool()
            LoadGridCarga()
            LoadGridManutencao()
            LoadGridPlanejamento()


            Gerar()

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    'Dim newSeries As New Series

    'openConn()'opens the connection
    'openRS("SELECT * FROM Data")'pull data from database
    'Do Until rs.EOF
    '    newSeries = New Series'create a new dataSeries
    '    yPlot1 = CDbl(rs.Fields("Start Date").Value.ToOADate())'set beginning of bar
    '    yPlot2 = CDbl(DateAdd(DateInterval.Day, rs.Fields("Duration").Value, rs.Fields("Start Date").Value).ToOADate())'set end of bar
    '    newSeries.ChartType = SeriesChartType.RangeBar
    '    newSeries.YValuesPerPoint = 2
    '    newSeries.CustomProperties = "DrawSideBySide=false"
    '    xOrdinal = rs.Fields("Ordinal").Value
    '    newSeries.Points.AddXY(xOrdinal, yPlot1, yPlot2)
    '    newSeries.Points(0).ToolTip = rs.Fields("Task Name").Value.ToString
    '    newSeries.Name = rs.Fields("Task Name").Value.ToString
    '    newSeries.Points(0).Color = Color.FromKnownColor(DirectCast([Enum].Parse(GetType(KnownColor), CStr(rs.Fields("Color").Value.ToString)), KnownColor))
    '    newSeries.Points(0).AxisLabel = rs.Fields("Ordinal Name").Value.ToString
    '    seriesList.Add(newSeries)
    '    rs.MoveNext()
    'Loop

    'rs = Nothing
    'cn.Close()
    'cn = Nothing

    'Chart1.Series.Clear()
    'For Each plotSeries As Series In seriesList
    '    Chart1.Series.Add(plotSeries)
    'Next
    'Chart1.ChartAreas(0).AxisX.Interval = 1
    'Chart1.ChartAreas(0).AxisY.Interval = 7
    'Chart1.ChartAreas(0).AxisX.IsReversed = True
    'Chart1.ChartAreas(0).AxisY.IsStartedFromZero = False
    'Chart1.ChartAreas(0).AxisY.IsMarginVisible = False
    'Chart1.ChartAreas(0).AxisY.IntervalType = DateTimeIntervalType.Days

    'Chart1.ChartAreas(0).AxisY.Minimum = CDbl(#4/1/2012#.ToOADate())
    'Chart1.ChartAreas(0).AxisY.Maximum = CDbl(#6/30/2012#.ToOADate())
    'Chart1.ChartAreas(0).AxisY.LabelStyle.Format = "ddd M/d"

    'Chart1.Update()
    Private Sub Gerar()
        Try
            Dim newSeries As New System.Windows.Forms.DataVisualization.Charting.Series
            Dim seriesList As System.Windows.Forms.DataVisualization.Charting.Series()
       
            For Each oRow In grdPlanejamento.GetRows
                newSeries = New System.Windows.Forms.DataVisualization.Charting.Series 'create a new dataSeries
                Dim yPlot1 As Double = CDbl(oRow.Cells.Item("data_inicio").Value.ToOADate()) 'set beginning of bar
                Dim yPlot2 As Double = CDbl(oRow.Cells.Item("data_termino").Value.ToOADate()) 'set end of bar
                newSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar
                newSeries.YValuesPerPoint = 2
                newSeries.CustomProperties = "DrawSideBySide=false"
                Dim xOrdinal As Double = oRow.Cells.Item("ordem").Value
                newSeries.Points.AddXY(xOrdinal, yPlot1, yPlot2)
                newSeries.Points(0).ToolTip = oRow.Cells.Item("ordem_producao").Value.ToString
                newSeries.Name = oRow.Cells.Item("ordem_producao").Value.ToString
                'newSeries.Points(0).Color = Color.FromKnownColor(DirectCast([Enum].Parse(GetType(KnownColor), CStr(rs.Fields("Color").Value.ToString)), KnownColor))
                newSeries.Points(0).AxisLabel = "TESTE"

                If seriesList Is Nothing Then
                    ReDim seriesList(0)
                Else
                    ReDim Preserve seriesList(seriesList.Count)
                End If


                seriesList(seriesList.Count - 1) = newSeries

            Next


            'Chart1.Series.Clear()
            'For Each plotSeries As System.Windows.Forms.DataVisualization.Charting.Series In seriesList
            '    Chart1.Series.Add(plotSeries)
            'Next
            'Chart1.ChartAreas(0).AxisX.Interval = 1
            'Chart1.ChartAreas(0).AxisY.Interval = 7
            'Chart1.ChartAreas(0).AxisX.IsReversed = True
            'Chart1.ChartAreas(0).AxisY.IsStartedFromZero = False
            'Chart1.ChartAreas(0).AxisY.IsMarginVisible = False
            'Chart1.ChartAreas(0).AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days

            'Chart1.ChartAreas(0).AxisY.Minimum = CDbl(#1/1/2024#.ToOADate())
            'Chart1.ChartAreas(0).AxisY.Maximum = CDbl(#1/31/2014#.ToOADate())
            'Chart1.ChartAreas(0).AxisY.LabelStyle.Format = "ddd M/d"

            'Chart1.Update()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadGridPool()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsUsrPrdCenario.LoadGridPool(grdPool, _
                                           btnSalvar.Tag)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridCarga()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsUsrPrdCenario.LoadGridCarga(grdCarga, _
                                            dtpDataTerminoFiltro.Value, _
                                            txtDiasUteisFiltro.Value)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridManutencao()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsUsrPrdCenario.LoadGridManutencao(grdManutencao, _
                                                 btnSalvar.Tag)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadGridPlanejamento()

        Try

            Cursor.Current = Cursors.WaitCursor

            oClsUsrPrdCenario.LoadGridPlanejamento(grdPlanejamento,
                                                   btnSalvar.Tag,
                                                   dtpDataTerminoFiltro.Value,
                                                   txtDiasUteisFiltro.Value)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ExcluirManutencao()

        Try

            If MsgBox("Deseja excluir esse registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Validação") <> MsgBoxResult.Yes Then Exit Sub

            Cursor.Current = Cursors.WaitCursor

            oClsUsrPrdCenario.DeleteManutencao(btnSalvar.Tag, _
                                               grdManutencao.GetValue("codigo"))

            LoadGridManutencao()

            frmMain.Informacao(Mensagem.RegistroExcluido)

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CalculoCargaHoras()

        Try

            Dim dHorasOriginais As Double = 8 'grdCarga.GetValue("horas_disponiveis_original")
            Dim dHorasDisponiveis As Double = 0
            Dim iQuantidadeTurnos As Integer = 0

            If grdCarga.GetValue("turno1") = True Then iQuantidadeTurnos += 1
            If grdCarga.GetValue("turno2") = True Then iQuantidadeTurnos += 1
            If grdCarga.GetValue("turno3") = True Then iQuantidadeTurnos += 1

            dHorasDisponiveis = dHorasOriginais * iQuantidadeTurnos * txtDiasUteisFiltro.Value

            grdCarga.SetValue("horas_disponiveis", dHorasDisponiveis)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CalcularDiasUteis()
        Try

            Dim dData As Date = dtpDataCenario.Value
            Dim iDiaUtil As Integer = 0

            'Verifica se é dia útil
            While dData <= dtpDataTerminoFiltro.Value

                'Verifica 
                If Not dData.DayOfWeek = DayOfWeek.Sunday And Not dData.DayOfWeek = DayOfWeek.Saturday Then

                    'Incrementa o contador
                    iDiaUtil += 1

                End If


                'Incrementa o contador
                dData = DateAdd(DateInterval.Day, 1, dData)
            End While

            'Seta o valor
            txtDiasUteisFiltro.Value = iDiaUtil


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnConfigurarDias_Click(sender As Object, e As EventArgs) Handles btnConfigurarPeriodo.Click

        Try

            Dim oForm As New frmPrdCenarioConfigurarDias
            oForm.CodigoCenario = btnSalvar.Tag
            oForm.ShowDialog()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub VisualizarGrafico()

        Try

            Dim link As String = LoadCodigo("sp_load_producao_cenario_link_gantt " & goUsuario.iEmpresa)

            oClsUsrPrdCenario.LoadDadosGrafico(iCodigoCenario:=btnSalvar.Tag,
                                               iCodigoMaquina:=IIf(cboMaquina.SelectedIndex = -1, -1, cboMaquina.SelectedValue))

            Process.Start(link)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub DesabilitarCampos(bDesabilitar As Boolean)

        Try

            txtCenario.Enabled = Not bDesabilitar
            dtpDataCenario.Enabled = Not bDesabilitar
            btnGerarCenario.Enabled = Not bDesabilitar
            btnConfigurarPeriodo.Enabled = Not bDesabilitar
            btnSalvar.Enabled = Not bDesabilitar
            txtDiasUteisFiltro.Enabled = Not bDesabilitar
            dtpDataTerminoFiltro.Enabled = Not bDesabilitar

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region


  
   
End Class
