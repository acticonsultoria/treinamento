Imports Janus.Windows.GridEX
Imports Janus.Windows.CalendarCombo

Public Class frmQAInspecaoEtiqueta

#Region "::: VARIAVEIS :::"

    Private oClsUsrQAInspecao As New clsUsrQAInspecaoEtiqueta

    Dim lCodigoEntradaCapa As Long
    Dim lCodigoEntradaItem
    Dim sProduto As String
    Dim sLote As String
    Dim sNotaFiscal As String
    Dim sPedidoCompra As String
    Dim sDataValidade As String
    Dim sFornecedor As String
    Dim lCodigoItem As Long
    Dim iCodigoEntradaVinculo As Integer

#End Region

#Region "::: PROPERTY :::"

    Public Property CodigoEntradaItem As Long
        Get
            Return lCodigoEntradaItem
        End Get
        Set(value As Long)
            lCodigoEntradaItem = value
        End Set
    End Property

    Public Property CodigoEntradaCapa As Long
        Get
            Return lCodigoEntradaCapa
        End Get
        Set(value As Long)
            lCodigoEntradaCapa = value
        End Set
    End Property

    Public Property Produto As String
        Get
            Return sProduto
        End Get
        Set(value As String)
            sProduto = value
        End Set
    End Property

    Public Property Lote As String
        Get
            Return sLote
        End Get
        Set(value As String)
            sLote = value
        End Set
    End Property

    Public Property NotaFiscal As String
        Get
            Return sNotaFiscal
        End Get
        Set(value As String)
            sNotaFiscal = value
        End Set
    End Property

    Public Property PedidoCompra As String
        Get
            Return sPedidoCompra
        End Get
        Set(value As String)
            sPedidoCompra = value
        End Set
    End Property

    Public Property DataValidade As String
        Get
            Return sDataValidade
        End Get
        Set(value As String)
            sDataValidade = value
        End Set
    End Property

    Public Property Fornecedor As String
        Get
            Return sFornecedor
        End Get
        Set(value As String)
            sFornecedor = value
        End Set
    End Property

    Public Property CodigoItem As Long
        Get
            Return lCodigoItem
        End Get
        Set(value As Long)
            lCodigoItem = value
        End Set
    End Property
    Public Property CodigoEntradaVinculo As Integer
        Get
            Return iCodigoEntradaVinculo
        End Get
        Set(value As Integer)
            iCodigoEntradaVinculo = value
        End Set
    End Property

#End Region

#Region "::: CONTROLES :::"

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Configura Formulário
        ConfigurarFormulario()

    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        Try

            'Fecha o Controle
            Me.Dispose()

        Catch ex As Exception
            'Trata Erro
            Call TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub btnDesmembrarLote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Try

            'Limpa Erro
            frmMain.errInfo.Clear()

            'Valida Formulário
            If Validacao() = False Then Exit Sub

            ImprimirEtiqueta()

            'Fecha o Formulário
            Me.Dispose()

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Sub GerarLote() Handles txtVolume.ValueChanged, txtQuantidade.ValueChanged

        Try

            'Caso Número de Entregas é maior do que 0
            If txtVolume.Value > 0 Then

                'Variaveis Locais
                Dim dQuantidade As Double = txtQuantidade.Value
                Dim oDataSet As New DataSet
                Dim oDataTable As New DataTable
                Dim oDCVolume As New DataColumn("volume")
                Dim oDCDataValidade As New DataColumn("data_validade")
                Dim oDCQUantidade As New DataColumn("quantidade")

                'Seta DataType
                oDCVolume.DataType = 0.GetType
                oDCQUantidade.DataType = 0.0.GetType

                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)

                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCVolume)
                oDataTable.Columns.Add(oDCQUantidade)

                For iNumero As Integer = 1 To txtVolume.Value


                    Dim oDataRow As DataRow = oDataTable.NewRow

                    oDataRow("volume") = iNumero
                    oDataRow("quantidade") = txtQuantidade.Value / txtVolume.Value
                    oDataTable.Rows.Add(oDataRow)

                Next

                'Limpa Grid
                grdVolume.DataSource = Nothing

                'Configura DataMember
                ConfigurarDataMemberGrid(grdVolume)

                'Carrega Grid
                grdVolume.DataSource = oDataSet.DefaultViewManager
                grdVolume.DataMember = oDataSet.Tables(0).TableName

            End If

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

#End Region

#Region "::: FUNCTION / SUB :::"

    Private Sub ConfigurarFormulario()

        Try

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.WaitCursor

            'Seta Ícone
            Me.Icon = frmMain.Icon

            oClsUsrQAInspecao.LoadDados(lCodigoEntradaCapa, _
                                        lCodigoEntradaItem, _
                                        txtProduto, _
                                        txtLote, _
                                        txtNotaFiscal, _
                                        txtPedidoCompra, _
                                        txtFornecedor)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            TratamentoErro(ex.Message, Me.Name)
        End Try

    End Sub

    Private Function Validacao() As Boolean

        Try

            If ValidaCampo(txtVolume, lblVolume, True) = False Then Return False
            If ValidaCampo(txtQuantidade, lblQuantidade, True) = False Then Return False

            If grdVolume.RecordCount > 0 Then

                If FormatNumber(grdVolume.GetTotalRow.Cells.Item("quantidade").Value, 2) <> FormatNumber(txtQuantidade.Value, 2) Then
                    MsgBox("A somatória das quantidades não batem!", MsgBoxStyle.Exclamation, "Validação")
                    Return False
                End If

            End If

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub ImprimirEtiqueta()

        Try

            Cursor.Current = Cursors.WaitCursor

            Dim sVolume As String = ""

            For Each oRow As GridEXRow In grdVolume.GetDataRows

                sVolume += IIf(sVolume = "", "", ";") & oRow.Cells("quantidade").Value

            Next

            'Redimenciona Vetor
            ReDim goCrystalReport.sReportParameter(0)
            Dim i As Integer = 0

            'Seta Parametros
            goCrystalReport.sReportParameter(i).sParamenter = "@codigo_entrada_item"
            goCrystalReport.sReportParameter(i).sValue = lCodigoEntradaItem : i += 1 : ReDim Preserve goCrystalReport.sReportParameter(i)

            goCrystalReport.sReportParameter(i).sParamenter = "@codigo_entrada_capa"
            goCrystalReport.sReportParameter(i).sValue = lCodigoEntradaCapa : i += 1 : ReDim Preserve goCrystalReport.sReportParameter(i)

            goCrystalReport.sReportParameter(i).sParamenter = "@codigo_empresa"
            goCrystalReport.sReportParameter(i).sValue = goUsuario.iEmpresa : i += 1 : ReDim Preserve goCrystalReport.sReportParameter(i)

            goCrystalReport.sReportParameter(i).sParamenter = "@volume"
            goCrystalReport.sReportParameter(i).sValue = sVolume : i += 1 : ReDim Preserve goCrystalReport.sReportParameter(i)

            goCrystalReport.sReportParameter(i).sParamenter = "@codigo_entrada_item_vinculo"
            goCrystalReport.sReportParameter(i).sValue = iCodigoEntradaVinculo : ReDim Preserve goCrystalReport.sReportParameter(i)

            goCrystalReport.sReport = goCrystalReport.sPath & "QA000000002.rpt"

            Dim oReport As New usrReport
            oReport.Dock = DockStyle.Fill

            'Abre Relatório
            frmMain.LoadPageReport("QA000000002", "Etiqueta", oReport)

            'Seta Cursor do Mouse
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

   
End Class