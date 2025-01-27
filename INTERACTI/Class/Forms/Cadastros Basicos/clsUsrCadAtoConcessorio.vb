Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.CalendarCombo
Imports Janus.Windows.EditControls
Imports Dundas.Charting.WinControl

Public Class clsUsrCadAtoConcessorio

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sNumeroDocumento As String
    Private sDescricao As String
    Private sDataAbertura As String
    Private sDataValidade As String
    Private dValor As Double
    Private iCodigoModalidade As Integer
    Private iCodigoTipo As Integer
    Private sArquivo As String
    Private lCodigoAtoConcessorio As Long

#End Region

#Region "::: PROPERTIE :::"

    Public Property NumeroDocumento() As String
        Get
            Return sNumeroDocumento
        End Get
        Set(ByVal value As String)
            sNumeroDocumento = value
        End Set
    End Property

    Public Property Descricao() As String
        Get
            Return sDescricao
        End Get
        Set(ByVal value As String)
            sDescricao = value
        End Set
    End Property

    Public Property DataAbertura() As String
        Get
            Return sDataAbertura
        End Get
        Set(ByVal value As String)
            sDataAbertura = value
        End Set
    End Property

    Public Property DataValidade() As String
        Get
            Return sDataValidade
        End Get
        Set(ByVal value As String)
            sDataValidade = value
        End Set
    End Property

    Public Property Valor() As Double
        Get
            Return dValor
        End Get
        Set(ByVal value As Double)
            dValor = value
        End Set
    End Property

    Public Property CodigoModalidade() As Integer
        Get
            Return iCodigoModalidade
        End Get
        Set(ByVal value As Integer)
            iCodigoModalidade = value
        End Set
    End Property

    Public Property CodigoTipo() As Integer
        Get
            Return iCodigoTipo
        End Get
        Set(ByVal value As Integer)
            iCodigoTipo = value
        End Set
    End Property

    Public Property Arquivo() As String
        Get
            Return sArquivo
        End Get
        Set(ByVal value As String)
            sArquivo = value
        End Set
    End Property

    Public Property CodigoAtoConcessorio() As Long
        Get
            Return lCodigoAtoConcessorio
        End Get
        Set(ByVal value As Long)
            lCodigoAtoConcessorio = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: ATO CONCESSÓRIO :::"

    Public Sub Insert()

        'Variaveis Locais
        Dim oSqlParameter(11) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Número do Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNumeroDocumento : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Data Abertura
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_abertura"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataAbertura : i += 1

            'Seta Parametros - Data Válidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_validade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataValidade : i += 1

            'Seta Parametros - Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValor : i += 1

            'Seta Parametros - Código Modalidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modalidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoModalidade : i += 1

            'Seta Parametros - Código Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipo : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = StatusAtoConcessorio.Aberto : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = IIf(sArquivo = "", DBNull.Value, sArquivo)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_ato_concessorio", oSqlParameter)

            'Seta Váriavel
            lCodigoAtoConcessorio = oSqlParameter(0).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update()

        'Variaveis Locais
        Dim oSqlParameter(10) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoAtoConcessorio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Número do Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNumeroDocumento : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Data Abertura
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_abertura"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataAbertura : i += 1

            'Seta Parametros - Data Válidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_validade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataValidade : i += 1

            'Seta Parametros - Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValor : i += 1

            'Seta Parametros - Código Modalidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modalidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoModalidade : i += 1

            'Seta Parametros - Código Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipo : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = IIf(sArquivo = "", DBNull.Value, sArquivo)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_ato_concessorio", oSqlParameter)

            'Seta Váriavel
            lCodigoAtoConcessorio = oSqlParameter(0).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Delete()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer
        Dim oRow As GridExRow

        Try

            For Each oRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_ato_concessorio", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sNumeroDocumento As String, _
                        ByVal sDescricao As String, _
                        ByVal sDataVigente As String, _
                        ByVal iCodigoModalidade As String, _
                        ByVal iCodigoTipo As Integer, _
                        ByVal iStatus As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(6) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Nº Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNumeroDocumento : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Data Vigente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vigente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataVigente), sDataVigente, DBNull.Value) : i += 1

            'Seta Parametros - Código Modalidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modalidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoModalidade : i += 1

            'Seta Parametros - Código Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipo : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iStatus : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Váriaveis - DataSet
            Dim sCommandText(2) As String
            Dim sTableName(2) As String

            sCommandText(0) = "sp_select_cadastro_basico_ato_concessorio" : sTableName(0) = "main"
            sCommandText(1) = "sp_select_cadastro_basico_ato_concessorio_di" : sTableName(1) = "di"
            sCommandText(2) = "sp_select_cadastro_basico_ato_concessorio_re" : sTableName(2) = "re"

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_ato_concessorio", oSqlParameter)
                        
            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oDataSet.Tables(0).Columns("codigo"), oDataSet.Tables(1).Columns("codigo_ato_concessorio"))
            oDataSet.Relations.Add(oDataSet.Tables(2).TableName, oDataSet.Tables(0).Columns("codigo"), oDataSet.Tables(2).Columns("codigo_ato_concessorio"))

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            oGrid.RootTable.ChildTables(0).DataMember = "di"
            oGrid.RootTable.ChildTables(1).DataMember = "re"

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadControles(ByVal lCodigoAtoConcessorio As Long, _
                             ByVal txtNumeroDocumento As MaskedEditBox, _
                             ByVal txtDescricao As MaskedEditBox, _
                             ByVal dtpDataAbertura As CalendarCombo, _
                             ByVal dtpDataValidade As CalendarCombo, _
                             ByVal txtValor As NumericEditBox, _
                             ByVal cboTipo As UIComboBox, _
                             ByVal cboModalidade As UIComboBox, _
                             ByVal txtStatus As MaskedEditBox, _
                             ByVal txtArquivo As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoAtoConcessorio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_ato_concessorio_dados", oSqlParameter)

            If oSqlDataReader.HasRows = False Then

                'Limpa Controles
                txtNumeroDocumento.Text = ""
                txtDescricao.Text = ""
                dtpDataAbertura.Value = Now.Date
                dtpDataValidade.Value = Now.Date
                txtValor.Value = 0
                cboTipo.SelectedIndex = -1
                cboModalidade.SelectedIndex = -1
                txtStatus.Text = ""
                txtArquivo.Text = ""

            Else

                'Carrega Controles
                While oSqlDataReader.Read

                    txtNumeroDocumento.Text = oSqlDataReader.Item("numero_documento")
                    txtDescricao.Text = oSqlDataReader.Item("descricao")
                    dtpDataAbertura.Value = oSqlDataReader.Item("data_abertura")
                    dtpDataValidade.Value = oSqlDataReader.Item("data_validade")
                    txtValor.Value = oSqlDataReader.Item("valor")
                    cboTipo.SelectedValue = oSqlDataReader.Item("codigo_tipo")
                    cboModalidade.SelectedValue = oSqlDataReader.Item("codigo_modalidade")
                    txtStatus.Text = oSqlDataReader.Item("status")
                    txtArquivo.Text = oSqlDataReader.Item("arquivo")

                End While

            End If

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGrafico(ByVal oChart As Chart, _
                           ByVal lCodigoAtoConcessorio As Long)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim yValuesImportacao() As Double
        Dim yValuesExportacao() As Double
        Dim xValuesData() As String
        Dim i As Integer = 0

        Try

            'Limpa Gráfico
            oChart.Series.Clear()
            oChart.Series.Add("Importação")
            oChart.Series.Add("Exportação")

            'Redimensiona Vetor
            ReDim yValuesImportacao(0)
            ReDim yValuesExportacao(0)
            ReDim xValuesData(0)

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ato_concessorio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoAtoConcessorio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_ato_concessorio_grafico", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    'Redimensiona Vetor
                    If IsDate(xValuesData(UBound(xValuesData))) Then
                        ReDim Preserve xValuesData(UBound(xValuesData) + 1)
                        ReDim Preserve yValuesImportacao(UBound(yValuesImportacao) + 1)
                        ReDim Preserve yValuesExportacao(UBound(yValuesExportacao) + 1)
                    End If

                    'Carrega Vetor
                    xValuesData(UBound(xValuesData)) = oSqlDataReader.Item("data")
                    yValuesImportacao(UBound(yValuesImportacao)) = oSqlDataReader.Item("importacao")
                    yValuesExportacao(UBound(yValuesExportacao)) = oSqlDataReader.Item("exportacao")

                End While

                'Plota Gráfico
                oChart.Series("Importação").Points.DataBindXY(xValuesData, yValuesImportacao)
                oChart.Series("Exportação").Points.DataBindXY(xValuesData, yValuesExportacao)

                'Define Tipo do Gráfico
                oChart.Series("Importação").Type = SeriesChartType.Column
                oChart.Series("Exportação").Type = SeriesChartType.Column

                'Desabilita 3D
                oChart.ChartAreas("Default").Area3DStyle.Enable3D = False

                'Formata AxisY
                oChart.ChartAreas("Default").AxisY.LabelStyle.Format = "R$ #,#0.00"
                oChart.ChartAreas("Default").AxisY.LabelsAutoFit = True
                oChart.ChartAreas("Default").AxisY.LabelsAutoFitStyle = LabelsAutoFitStyle.OffsetLabels

                'Formata AxisX
                oChart.ChartAreas("Default").AxisX.LabelsAutoFit = True
                oChart.ChartAreas("Default").AxisX.LabelsAutoFitStyle = LabelsAutoFitStyle.OffsetLabels

                'Show Point Labels
                oChart.Series("Importação").ShowLabelAsValue = True
                oChart.Series("Importação").LabelFormat = "R$ #,#0.00"
                oChart.Series("Exportação").ShowLabelAsValue = True
                oChart.Series("Exportação").LabelFormat = "R$ #,#0.00"

            End If

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaNumeroDocumento(ByVal lCodigoAtoConcessorio As Long, _
                                          ByVal sNumeroDocumento As String) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0
        Dim iReturn As Integer

        Try

            'Seta Retorno da Função
            ValidaNumeroDocumento = False

            'Seta Parametros - Codigo do Ato Concessório
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoAtoConcessorio : i += 1

            'Seta Parametros - Nº Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNumeroDocumento : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_cadastro_basico_ato_concessorio", oSqlParameter), Integer)

            'Seta Retorno da Função
            ValidaNumeroDocumento = IIf(iReturn > 0, False, True)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: DI :::"

    Public Sub InsertDI(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(11) As SqlParameter
        Dim oRow As GridEXRow
        Dim i As Integer = 0

        Try

            For Each oRow In oGrid.GetDataRows

                i = 0

                'Seta Parametros - Código Ato Concessório
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_ato_concessorio"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoAtoConcessorio : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Número da DI
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero_di"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 20
                oSqlParameter(i).Value = oRow.Cells("numero_di").Value : i += 1

                'Seta Parametros - Código Tipo de Importação
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_tipo_importacao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo_tipo_importacao").Value : i += 1

                'Seta Parametros - Valor
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("valor").Value : i += 1

                'Seta Parametros - Código Moeda
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_moeda"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo_moeda").Value : i += 1

                'Seta Parametros - Fator Cambial
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "fator_cambial"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("fator_cambial").Value : i += 1

                'Seta Parametros - Valor Moeda Corrente
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor_moeda_corrente"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("valor_moeda_corrente").Value : i += 1

                'Seta Parametros - Data Registro
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data_registro"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = oRow.Cells("data_registro").Value : i += 1

                'Seta Parametros - Local Desembaraco
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "local_desembaraco"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 60
                oSqlParameter(i).Value = oRow.Cells("local_desembaraco").Value : i += 1

                'Seta Parametros - Data Desembaraço
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data_desembaraco"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = oRow.Cells("data_desembaraco").Value : i += 1

                'Seta Parametros - Arquivo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "arquivo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 500
                oSqlParameter(i).Value = IIf(sArquivo = "", DBNull.Value, sArquivo)

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_ato_concessorio_di", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteDI(ByVal lCodigoAtoConcessorio As Long)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ato_concessorio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoAtoConcessorio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_ato_concessorio_di", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridDI(ByVal oGrid As GridEX, _
                          ByVal lCodigoAtoConcessorio As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ato_concessorio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoAtoConcessorio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_ato_concessorio_di_grid", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaNumeroDI(ByVal lCodigoAtoConcessorio As Long, _
                                   ByVal sNumeroDI As String) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0
        Dim iReturn As Integer

        Try

            'Seta Retorno da Função
            ValidaNumeroDI = False

            'Seta Parametros - Codigo do Ato Concessório
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ato_concessorio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoAtoConcessorio : i += 1

            'Seta Parametros - Nº DI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_di"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNumeroDI : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_cadastro_basico_ato_concessorio_di", oSqlParameter), Integer)

            'Seta Retorno da Função
            ValidaNumeroDI = IIf(iReturn > 0, False, True)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: RE :::"

    Public Sub InsertRE(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(10) As SqlParameter
        Dim oRow As GridEXRow
        Dim i As Integer = 0

        Try

            For Each oRow In oGrid.GetDataRows

                i = 0

                'Seta Parametros - Código Ato Concessório
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_ato_concessorio"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoAtoConcessorio : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Número da RE
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero_re"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 20
                oSqlParameter(i).Value = oRow.Cells("numero_re").Value : i += 1

                'Seta Parametros - Código Contrato Cambio
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_contrato_cambio"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo_contrato_cambio").Value : i += 1

                'Seta Parametros - Valor
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("valor").Value : i += 1

                'Seta Parametros - Código Moeda
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_moeda"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo_moeda").Value : i += 1

                'Seta Parametros - Fator Cambial
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "fator_cambial"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("fator_cambial").Value : i += 1

                'Seta Parametros - Valor Moeda Corrente
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor_moeda_corrente"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("valor_moeda_corrente").Value : i += 1

                'Seta Parametros - Data Registro
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data_registro"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = oRow.Cells("data_registro").Value : i += 1

                'Seta Parametros - Local Embarque
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "local_embarque"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 60
                oSqlParameter(i).Value = oRow.Cells("local_embarque").Value : i += 1

                'Seta Parametros - Arquivo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "arquivo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 500
                oSqlParameter(i).Value = IIf(sArquivo = "", DBNull.Value, sArquivo)

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_ato_concessorio_re", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteRE(ByVal lCodigoAtoConcessorio As Long)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ato_concessorio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoAtoConcessorio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_ato_concessorio_re", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadContratoCambio(ByVal iCodigoContratoCambio As Integer, _
                                  ByVal cboMoedaRE As UIComboBox, _
                                  ByVal txtFatorCambialRE As NumericEditBox)

        'Váriaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Contrato Cambio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoContratoCambio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_contrato_cambio_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega/Desabilita Controles
                cboMoedaRE.SelectedValue = oSqlDataReader.Item("codigo_moeda") : cboMoedaRE.Enabled = False
                txtFatorCambialRE.Value = oSqlDataReader.Item("fator_cambial") : txtFatorCambialRE.Enabled = False

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridRE(ByVal oGrid As GridEX, _
                          ByVal lCodigoAtoConcessorio As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ato_concessorio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoAtoConcessorio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_ato_concessorio_re_grid", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaNumeroRE(ByVal lCodigoAtoConcessorio As Long, _
                                   ByVal sNumeroRE As String) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0
        Dim iReturn As Integer

        Try

            'Seta Retorno da Função
            ValidaNumeroRE = False

            'Seta Parametros - Codigo do Ato Concessório
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ato_concessorio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoAtoConcessorio : i += 1

            'Seta Parametros - Nº RE
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_re"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNumeroRE : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_cadastro_basico_ato_concessorio_re", oSqlParameter), Integer)

            'Seta Retorno da Função
            ValidaNumeroRE = IIf(iReturn > 0, False, True)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: PRODUTO :::"

    Public Sub InsertProduto(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim oRow As GridEXRow
        Dim i As Integer = 0

        Try

            For Each oRow In oGrid.GetDataRows

                i = 0

                'Seta Parametros - Código Ato Concessório
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_ato_concessorio"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoAtoConcessorio : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Código Item
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_item"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_ato_concessorio_item", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteProduto(ByVal lCodigoAtoConcessorio As Long)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ato_concessorio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoAtoConcessorio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_ato_concessorio_item", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridProduto(ByVal oGrid As GridEX, _
                               ByVal lCodigoAtoConcessorio As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ato_concessorio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoAtoConcessorio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_ato_concessorio_item", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class
