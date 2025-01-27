Imports Dundas.Charting.WinControl
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Dundas.Charting
Public Class usrChartDinamico

#Region "::: VÁRIAVEIS :::"

    Private oGrid As gridex
    Private oGrupoFiltro As UIGroupBox

#End Region

#Region "::: ENUMS :::"

    Private Enum TipoIntervalo
        Horas = 1
        Dias = 2
        Semanas = 3
        Meses = 4
        Anos = 5
    End Enum

    Private Structure Grafico
        Dim sSerie As String
        Dim sEixoX As String
        Dim dQuantidade As Double
        Dim dValor As Double
        Dim dValor2 As Double
    End Structure

#End Region

#Region "::: PROPERTIE :::"

    Public WriteOnly Property Grid As gridex
        Set(ByVal value As gridex)
            oGrid = value
        End Set
    End Property

    Public WriteOnly Property GrupoFiltro As UIGroupBox
        Set(ByVal value As UIGroupBox)
            oGrupoFiltro = value
        End Set
    End Property
#End Region

#Region "::: CONTROLES :::"

    Private Sub usr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try

            Select Case e.KeyCode

                Case Keys.Escape : Call btnSair_Click(btnSair, System.EventArgs.Empty)

            End Select

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub usrChart_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        'Configura UserControl
        Call ConfigurarUserControl()

    End Sub

    Private Sub usrChart_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Reposiciona UserControl
        Me.Top = (frmMain.picImage.Top + ((frmMain.picImage.Height - Me.Height) / 2))
        Me.Left = ((frmMain.picImage.Width - Me.Width) / 2)

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        'Deleta Aba
        If TypeOf Me.Parent Is Form Then Me.Parent.Dispose() Else If TypeOf Me.Parent Is Panel Then Me.Parent.Controls.Remove(Me) Else frmMain.tabMain.TabPages.Remove(Me.Parent)
        'Fecha o Controle
        Me.Dispose()

    End Sub

    Private Sub btnGerarGrafico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGerarGrafico.Click
        Try
            GerarGrafico()
        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Parent.ToString)
        End Try
    End Sub
    Private Sub cboIntervalo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboIntervalo.SelectedIndexChanged
        Try
            If cboIntervalo.SelectedIndex <> -1 Then
                cboCampoData.Visible = True
                lblCampoData.Visible = True
            Else
                cboCampoData.Visible = False
                lblCampoData.Visible = False
                cboCampoData.SelectedIndex = -1
            End If
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
            Call AddKeyDown(Me, New DelegateKeyDown(AddressOf usr_KeyDown))
            Call AddLostFocus(Me, New DelegateLostFocus(AddressOf Control_LostFocus))

            LoadComboIntervalo()
            LoadComboEixoY()
            LoadComboCampoData()
            LoadComboSerie()
            LoadComboTipo()

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Parent.Text)
        End Try

    End Sub

    Private Sub GerarGrafico()
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
            If cboCampoData.SelectedIndex = -1 Then
                GerarGraficoDundas(chrGrafico, cboSerie.SelectedValue, cboSerie.Text, cboEixoY.SelectedValue, cboEixoY.Text, oGrid, cboTipo.SelectedValue, cboTipo.Text, txtMeta.Value, IIf(cboIntervalo.SelectedIndex = -1, -1, cboIntervalo.SelectedValue), oGrupoFiltro, txtTotal)
            Else
                GerarGraficoDundasData(chrGrafico, cboSerie.SelectedValue, cboSerie.Text, cboEixoY.SelectedValue, cboEixoY.Text, oGrid, cboTipo.SelectedValue, cboTipo.Text, txtMeta.Value, IIf(cboIntervalo.SelectedIndex = -1, -1, cboIntervalo.SelectedValue), cboCampoData.SelectedValue, oGrupoFiltro, txtTotal)
            End If

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

            Dim oDataSetGrid As New DataSet
            oDataSetGrid = CType(oGrid.DataSource.DataSet, DataSet).Copy

            If oGrid.RecordCount = 0 Then Exit Sub

            'Percorrendo todas as colunas da grid
            For Each oColumn As Janus.Windows.GridEX.GridEXColumn In oGrid.RootTable.Columns

                If oColumn.Visible = False Or oColumn.Key = "x" Or oColumn.Caption = "" Then Continue For
                If Not oDataSetGrid.Tables(0).Columns.Contains(oColumn.Key) Then Continue For
                Dim sValor As String
                sValor = IIf(IsDBNull(oDataSetGrid.Tables(0).Compute("MAX(" + oColumn.Key + ")", "")), "", oDataSetGrid.Tables(0).Compute("MAX(" + oColumn.Key + ")", ""))

                'Se for diferente de X e for visível
                If (IsNumeric(sValor) And oColumn.HasValueList = False) Or oColumn.Key = "codigo_operacao" Then

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

    Private Sub LoadComboCampoData()
        Try

            Dim oDataSet As New DataSet
            Dim oDataRow As DataRow
            Dim bFlag As Boolean = False
            oDataSet.Tables.Add()
            oDataSet.Tables(0).Columns.Add("codigo")
            oDataSet.Tables(0).Columns.Add("descricao")

            'Percorrendo todas as colunas da grid
            For Each oColumn As Janus.Windows.GridEX.GridEXColumn In oGrid.RootTable.Columns

                'Se for diferente de X e for visível
                If oColumn.Key.ToUpper.Contains("DATA") Then


                    oDataRow = oDataSet.Tables(0).Rows.Add
                    oDataRow(0) = oColumn.Key
                    oDataRow(1) = oColumn.Caption

                End If
            Next

            With cboCampoData
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
            For Each oColumn As Janus.Windows.GridEX.GridEXColumn In oGrid.RootTable.Columns

                'Se for diferente de X e for visível
                If Not IsNumeric(oGrid.GetRow(0).Cells.Item(oColumn.Key).Value) And oGrid.RootTable.Columns(oColumn.Key).Caption <> "" And oGrid.RootTable.Columns(oColumn.Key).Visible = True Then


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

            'oDataRow = oDataSet.Tables(0).Rows.Add
            'oDataRow(0) = 3
            'oDataRow(1) = "PORCENTAGEM"

            oDataRow = oDataSet.Tables(0).Rows.Add
            oDataRow(0) = 4
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

    Private Function LoadTituloDundas(ByVal oGridDados As GridEX, ByVal oGroupBox As UIGroupBox) As String
        Try
            Dim sTitulo As String = ""
            If Not oGroupBox Is Nothing Then
                Dim sName As String
                Dim sValor As String
                Dim sLabel As String
                Dim bFlag2 As Boolean = False

                For Each oObject In oGroupBox.Controls
                    sName = oObject.Name
                    sValor = ""
                    If oObject.GetType.Name = "EditBox" Or oObject.GetType.Name = "UIComboBox" Then
                        If oObject.Text <> "" Then
                            sValor = oObject.Text
                            sLabel = oObject.name.ToString.Replace("txt", "").Replace("cbo", "").Replace("Filtro", "")
                        End If


                        'Try
                        '    sLabel = FindControlLabel(oGroupBox, oObject).Text
                        'Catch ex As Exception
                        '    sLabel = ""
                        'End Try
                    End If


                    If oObject.GetType.Name = "DateTimePicker" Then
                        If CType(oObject, DateTimePicker).Checked = True Or CType(oObject, DateTimePicker).ShowCheckBox = False Then
                            sValor = oObject.Text
                            sLabel = oObject.name.ToString.Replace("dtp", "").Replace("Filtro", "")
                        End If


                        'Try
                        '    sLabel = FindControlLabel(oGroupBox, oObject).Text
                        'Catch ex As Exception
                        '    sLabel = ""
                        'End Try
                    End If

                    If sValor <> "" Then
                        If bFlag2 = True Then
                            sTitulo += " | "
                        End If
                        sTitulo += SepararMaiuscula(sLabel) + ": " + sValor
                        bFlag2 = True
                    End If
                Next


            End If

            If Not oGridDados.RootTable.FilterApplied Is Nothing Then
                Dim sFilterGrid As String = oGridDados.RootTable.FilterApplied.ToString
                sFilterGrid = Replace(sFilterGrid, "_", " ").Replace("{", "").Replace("}", "").Replace("(", "").Replace(")", "").Replace("[", "").Replace("]", "").Replace("And", " | ").Replace("null", "")

                sFilterGrid = Replace(sFilterGrid, "BeginsWith ", "Começa Com: ")
                sFilterGrid = Replace(sFilterGrid, "Contains ", "Contêm: ")
                sFilterGrid = Replace(sFilterGrid, "Is empty ", "É Vazio ")
                sFilterGrid = Replace(sFilterGrid, "Isn't empty ", "Não é Vazio ")
                sFilterGrid = Replace(sFilterGrid, "EndsWith ", "Termina Com: ")

                sTitulo += vbNewLine + sFilterGrid
            End If


            Return sTitulo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function SepararMaiuscula(ByVal sValor As String) As String
        Try

            For i As Integer = 65 To 90
                sValor = Replace(sValor, Chr(i), " " + Chr(i))
            Next



            Return sValor
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub GerarGraficoDundas(ByVal oChart As Dundas.Charting.WinControl.Chart, _
                      ByVal sKeyCampoSerie As String, _
                      ByVal sNomeCampoSerie As String, _
                      ByVal sEixoY As String, _
                      ByVal sNomeEixoY As String, _
                      ByVal oGridDados As Janus.Windows.GridEX.GridEX, _
                      ByVal iTipo As Integer, _
                      ByVal sTipo As String, _
                      ByVal iMeta As Integer, _
                      ByVal iIntervalo As Integer, _
                      Optional ByVal oGroupBox As UIGroupBox = Nothing, _
                      Optional ByVal txtTotal As NumericEditBox = Nothing)

        Dim oRow As GridEXRow

        Try
            'Variável auxiliar
            Dim oStructGrafico(0) As Grafico
            Dim dValorTotal As Double = 0
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
            oChart.Titles(0).Text = "GRÁFICO DE " & sNomeCampoSerie & vbNewLine & vbNewLine & "FILTROS: " & vbNewLine
            oChart.Titles(0).Text += LoadTituloDundas(oGridDados, oGroupBox)
            oChart.Legends(0).LegendStyle = WinControl.LegendStyle.Table

            'Limpando as séries
            oChart.Series.Clear()

            'Formatando o eixo X de acordo com o valor escolhido
            oChart.ChartAreas(0).AxisX.Title = "GRÁFICO - " & sNomeEixoY & " / " & sNomeCampoSerie
            oChart.ChartAreas(0).AxisY.Title = sTipo & " - " & sNomeEixoY

            'Adicionandoo campo de série
            ChartSerieAdicionar(oChart, sNomeCampoSerie)


            If iMeta > 0 Then
                oChart.UnusedColor = Color.Green
                ChartSerieAdicionar(oChart, "META")
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

                        If IsDBNull(oRow.Cells.Item(sKeyCampoSerie).Text) Then
                            Continue For
                        End If
                        If (oRow.Cells.Item(sKeyCampoSerie).Text) = "" Then
                            Continue For
                        End If
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

                        If IsDBNull(oRow.Cells.Item(sKeyCampoSerie).Text) Then
                            Continue For
                        End If
                        If (oRow.Cells.Item(sKeyCampoSerie).Text) = "" Then
                            Continue For
                        End If

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

            'Dim oArray(oStructGrafico.Count) As String
            'For iCont As Integer = 1 To oStructGrafico.Count - 1
            '    oArray(iCont) = oStructGrafico(iCont).sEixoX
            'Next
            'System.Array.Sort(Of Grafico)(oStructGrafico)

            'Dim oStruct = oStructGrafico.OrderBy(Function(C) C.sEixoX)


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
                    If iTipo = 4 Then
                        dValorTotal += .dQuantidade
                    Else : dValorTotal += .dValor
                    End If
                    ' dValorTotal += .dValor
                End With
            Next

            oChart.ChartAreas(0).AxisX.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.NotSet
            oChart.ChartAreas(0).AxisX.Interval = 1
            oChart.ChartAreas(0).ReCalc()

            If Not txtTotal Is Nothing Then
                txtTotal.Value = dValorTotal
            End If




        Catch SqlEx As OleDb.OleDbException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub GerarGraficoDundasData(ByVal oChart As Dundas.Charting.WinControl.Chart, _
                      ByVal sKeyCampoSerie As String, _
                      ByVal sNomeCampoSerie As String, _
                      ByVal sEixoY As String, _
                      ByVal sNomeEixoY As String, _
                      ByVal oGridDados As Janus.Windows.GridEX.GridEX, _
                      ByVal iTipo As Integer, _
                      ByVal sTipo As String, _
                      ByVal iMeta As Integer, _
                      ByVal iIntervalo As Integer, _
                      ByVal sCampoData As String, _
                      Optional ByVal oGroupBox As UIGroupBox = Nothing, _
                      Optional ByVal txtTotal As NumericEditBox = Nothing)



        Try
            'Variável auxiliar
            Dim oStructGrafico(0) As Grafico
            Dim dValorTotal As Double = 0


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

            'Atribuindo o nome ao gráfico
            oChart.Titles(0).Text = "GRÁFICO DE " & sNomeCampoSerie & vbNewLine & vbNewLine & "FILTROS: " & vbNewLine
            oChart.Titles(0).Text += LoadTituloDundas(oGridDados, oGroupBox)
            oChart.Legends(0).LegendStyle = WinControl.LegendStyle.Table


            'If iMeta > 0 Then
            '    oChart.UnusedColor = Color.Green
            '    ChartSerieAdicionar(oChart, "META")
            '    oChart.Series("META").Type = Dundas.Charting.WinControl.SeriesChartType.Line
            '    oChart.Series("META").ShowLabelAsValue = False
            '    oChart.Series("META").MarkerStyle = Dundas.Charting.WinControl.MarkerStyle.Square
            '    oChart.Series("META").MarkerSize = 8
            '    oChart.Series("META").BorderWidth = 6
            '    oChart.Series("META").Color = Color.Green

            'End If



            Dim oHashMeta As New Hashtable

            'Percorrendo todas linha da grid
            For Each oRow In oGridDados.GetRows

                'Zerando a variável
                bFlag = False

                If IsDBNull(oRow.Cells.Item(sEixoY).Value) = False Then

                    ''Verificando a meta
                    'If iMeta > 0 Then


                    '    If iIntervalo = -1 Then
                    '        If Not oHashMeta.Contains(oRow.Cells.Item(sKeyCampoSerie).Text) Then
                    '            oHashMeta.Add(oRow.Cells.Item(sKeyCampoSerie).Text, 0)
                    '            oChart.Series("META").Points.AddXY(oRow.Cells.Item(sKeyCampoSerie).Text, iMeta)
                    '        End If
                    '    Else
                    '        If Not oHashMeta.Contains(Format(CDate(oRow.Cells.Item(sKeyCampoSerie).Text), sFormatoData) + IIf(iIntervalo = TipoIntervalo.Semanas, CStr(DatePart(DateInterval.WeekOfYear, oRow.Cells.Item(sKeyCampoSerie).Value)), "")) Then
                    '            oHashMeta.Add(Format(CDate(oRow.Cells.Item(sKeyCampoSerie).Text), sFormatoData) + IIf(iIntervalo = TipoIntervalo.Semanas, CStr(DatePart(DateInterval.WeekOfYear, oRow.Cells.Item(sKeyCampoSerie).Value)), ""), 0)
                    '            oChart.Series("META").Points.AddXY(Format(CDate(oRow.Cells.Item(sKeyCampoSerie).Text), sFormatoData) + IIf(iIntervalo = TipoIntervalo.Semanas, CStr(DatePart(DateInterval.WeekOfYear, oRow.Cells.Item(sKeyCampoSerie).Value)), ""), iMeta)
                    '        End If
                    '    End If

                    'End If

                    'Verificando se já existe a chava
                    For iCont As Integer = 1 To oStructGrafico.Count - 1

                        'Verificando se já existe a serie com a data
                        If (oStructGrafico(iCont).sSerie = oRow.Cells.Item(sKeyCampoSerie).Text) And _
                            (oStructGrafico(iCont).sEixoX = Format(CDate(oRow.Cells.Item(sCampoData).Text), sFormatoData) + IIf(iIntervalo = TipoIntervalo.Semanas, CStr(DatePart(DateInterval.WeekOfYear, oRow.Cells.Item(sCampoData).Value)), "")) Then

                            'Adicionando o valor
                            oStructGrafico(iCont).dQuantidade += 1
                            oStructGrafico(iCont).dValor += oRow.Cells.Item(sEixoY).Value * IIf(sEixoY = "eficiencia", 100, 1)

                            'Saindo do laço
                            bFlag = True
                            Exit For

                        End If

                    Next

                    'Se ele não encontrou a chave, adicioná-la 
                    If bFlag = False Then

                        'Redimensionando o vetor da estrutura
                        ReDim Preserve oStructGrafico(oStructGrafico.Count)

                        'Atribuindo os valores
                        oStructGrafico(oStructGrafico.Count - 1).sSerie = oRow.Cells.Item(sKeyCampoSerie).Text
                        oStructGrafico(oStructGrafico.Count - 1).sEixoX = Format(CDate(oRow.Cells.Item(sCampoData).Text), sFormatoData) + IIf(iIntervalo = TipoIntervalo.Semanas, CStr(DatePart(DateInterval.WeekOfYear, oRow.Cells.Item(sCampoData).Value)), "")
                        oStructGrafico(oStructGrafico.Count - 1).dQuantidade = 1
                        oStructGrafico(oStructGrafico.Count - 1).dValor = oRow.Cells.Item(sEixoY).Value * IIf(sEixoY = "eficiencia", 100, 1)

                    End If

                End If
            Next


            'Depois de montada a estrutura, o gráfico irá ser montado a partir das informações
            For iCont As Integer = 1 To oStructGrafico.Count - 1
                Dim bExiste As Boolean = False
                For iSerie As Integer = 0 To oChart.Series.Count - 1

                    If oChart.Series(iSerie).Name = oStructGrafico(iCont).sSerie Then
                        bExiste = True
                        Exit For
                    End If


                Next

                If bExiste = False Then
                    'Adicionandoo campo de série
                    ChartSerieAdicionar(oChart, oStructGrafico(iCont).sSerie, Nothing, WinControl.SeriesChartType.StackedColumn)
                End If
            Next


            'Percorrendo os dados da estrutura
            For iCont As Integer = 1 To oStructGrafico.Count - 1


                With oStructGrafico(iCont)

                    If iTipo = 1 Then 'Soma
                        'Adicionando os pontos
                        oChart.Series(oStructGrafico(iCont).sSerie).Points.AddXY( _
                                        .sEixoX, _
                                        CDbl(FormatNumber(.dValor, 2)))
                    ElseIf iTipo = 2 Then 'MÉDIA


                        'Adicionando os pontos
                        oChart.Series(oStructGrafico(iCont).sSerie).Points.AddXY( _
                                        .sEixoX, _
                                        CDbl(FormatNumber(.dValor / .dQuantidade, 2)))
                    Else 'CONTAR
                        'Adicionando os pontos
                        oChart.Series(oStructGrafico(iCont).sSerie).Points.AddXY( _
                                        .sEixoX, _
                                        CDbl(FormatNumber(.dQuantidade, 2)))
                    End If
                    If iTipo = 4 Then
                        dValorTotal += .dQuantidade
                    Else : dValorTotal += .dValor
                    End If
                End With

            Next

            oChart.ChartAreas(0).AxisX.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.NotSet
            oChart.ChartAreas(0).AxisX.Interval = 1
            oChart.ChartAreas(0).ReCalc()




            If Not txtTotal Is Nothing Then
                txtTotal.Value = dValorTotal
            End If



        Catch SqlEx As OleDb.OleDbException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ChartSerieAdicionar(ByRef oChart As Dundas.Charting.WinControl.Chart, _
                                    ByRef sKey As String, _
                                    Optional ByVal oColor As Color = Nothing, _
                                    Optional ByVal oChartType As Dundas.Charting.WinControl.SeriesChartType = Nothing)

        Try

            With oChart


                .Series.Add(sKey)
                If oChartType <> Nothing Then
                    .Series(sKey).Type = oChartType
                Else
                    .Series(sKey).Type = Dundas.Charting.WinControl.SeriesChartType.Column
                End If

                .Series(sKey).ShowLabelAsValue = True
                .Series(sKey).BorderStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
                .Series(sKey).BorderColor = Color.Black
                .Series(sKey).ShadowColor = Color.DarkGray
                .Series(sKey).ShadowOffset = 3
                If oColor <> Nothing Then
                    .Series(sKey).Color = oColor
                End If

                oChart.ChartAreas(0).AxisX.LabelStyle.FontAngle = 45

                '.Series(sKey).ShowLabelAsValue = False

            End With
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
#End Region

    
   
End Class
