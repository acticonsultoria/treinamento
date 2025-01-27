Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls
Imports System.Drawing.Printing
Imports Janus.Windows.CalendarCombo

Public Class clsUsrCadSala

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sDescricao As String
    Private bAtivo As Boolean
    Private iCodigo As Integer
    Private dAreaConstruidaLocada As Double
    Private dAreaPatioLocada As Double
    Private dValorAluguel As Double
    Private sReferenciaInterna As String
    Private dInicioVigenciaContrato As DateTime
    Private dTerminoVigenciaContrato As DateTime
    Private dRateioConsumoAgua As Double
    Private lCodigoCliente As Long

#End Region

#Region "::: PROPERTIE :::"

    Public Property Descricao() As String
        Get
            Return sDescricao
        End Get
        Set(ByVal value As String)
            sDescricao = value
        End Set
    End Property

    Public Property Ativo() As Boolean
        Get
            Return bAtivo
        End Get
        Set(ByVal value As Boolean)
            bAtivo = value
        End Set
    End Property

    Public Property Codigo() As Integer
        Get
            Return iCodigo
        End Get
        Set(ByVal value As Integer)
            iCodigo = value
        End Set
    End Property

    Public Property AreaConstruidaLocada() As Double
        Get
            Return dAreaConstruidaLocada
        End Get
        Set(ByVal value As Double)
            dAreaConstruidaLocada = value
        End Set
    End Property

    Public Property AreaPatioLocada() As Double
        Get
            Return dAreaPatioLocada
        End Get
        Set(ByVal value As Double)
            dAreaPatioLocada = value
        End Set
    End Property

    Public Property ValorAluguel() As Double
        Get
            Return dValorAluguel
        End Get
        Set(ByVal value As Double)
            dValorAluguel = value
        End Set
    End Property

    Public Property ReferenciaInterna() As String
        Get
            Return sReferenciaInterna
        End Get
        Set(ByVal value As String)
            sReferenciaInterna = value
        End Set
    End Property

    Public Property InicioVigenciaContrato() As DateTime
        Get
            Return dInicioVigenciaContrato
        End Get
        Set(ByVal value As DateTime)
            dInicioVigenciaContrato = value
        End Set
    End Property

    Public Property TerminoVigenciaContrato() As DateTime
        Get
            Return dTerminoVigenciaContrato
        End Get
        Set(ByVal value As DateTime)
            dTerminoVigenciaContrato = value
        End Set
    End Property

    Public Property CodigoCliente() As Long
        Get
            Return lCodigoCliente
        End Get
        Set(ByVal value As Long)
            lCodigoCliente = value
        End Set
    End Property

    Public Property RateioConsumoAgua() As Double
        Get
            Return dRateioConsumoAgua
        End Get
        Set(ByVal value As Double)
            dRateioConsumoAgua = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub Insert()

        'Variaveis Locais
        Dim oSqlParameter(11) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Descricao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAtivo : i += 1

            'Seta Parametros - Area Construida Locada
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "area_construida_locada"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAreaConstruidaLocada : i += 1

            'Seta Parametros - Area Patio Locada
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "area_patio_locada"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAreaPatioLocada : i += 1

            'Seta Parametros - Valor Aluguel
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_aluguel"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAluguel : i += 1

            'Seta Parametros - Referencia Interna
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "referencia_interna"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sReferenciaInterna : i += 1

            'Seta Parametros - Inicio Vigencia Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inicio_vigencia_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dInicioVigenciaContrato : i += 1

            'Seta Parametros - Termino Vigencia Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "termino_vigencia_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dTerminoVigenciaContrato : i += 1

            'Seta Parametros - Rateio Consumo Água
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "rateio_consumo_agua"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dRateioConsumoAgua : i += 1

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCliente : i += 1

            'Seta Parametros - Codigo Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_sala", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update()

        'Variaveis Locais
        Dim oSqlParameter(12) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Descricao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAtivo : i += 1

            'Seta Parametros - Area Construida Locada
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "area_construida_locada"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAreaConstruidaLocada : i += 1

            'Seta Parametros - Area Patio Locada
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "area_patio_locada"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAreaPatioLocada : i += 1

            'Seta Parametros - Valor Aluguel
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_aluguel"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAluguel : i += 1

            'Seta Parametros - Referencia Interna
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "referencia_interna"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sReferenciaInterna : i += 1

            'Seta Parametros - Inicio Vigencia Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inicio_vigencia_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dInicioVigenciaContrato : i += 1

            'Seta Parametros - Termino Vigencia Contrato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "termino_vigencia_contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dTerminoVigenciaContrato : i += 1

            'Seta Parametros - Rateio Consumo Água
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "rateio_consumo_agua"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dRateioConsumoAgua : i += 1

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCliente : i += 1

            'Seta Parametros - Codigo Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_sala", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Delete()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Codigo Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_usuario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_sala", oSqlParameter)

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
                        ByVal sDescricao As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try


            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_sala", oSqlParameter)

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

    Public Sub LoadDadossala(ByVal iCodigo As Integer, _
                               ByVal txtDescricao As MaskedEditBox, _
                               ByVal cboAtivo As UIComboBox, _
                               ByVal txtAreaConstruidaLocada As NumericEditBox, _
                               ByVal txtAreaPatioLocada As NumericEditBox, _
                               ByVal txtValorAluguel As NumericEditBox, _
                               ByVal txtReferenciaInterna As MaskedEditBox, _
                               ByVal dtpInicioVigenciaContrato As CalendarCombo, _
                               ByVal dtpTerminoVigenciaContrato As CalendarCombo, _
                               ByVal txtRateioConsumoAgua As NumericEditBox, _
                               ByVal cboCliente As UIComboBox)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_sala_dados", oSqlParameter)

            While oSqlDataReader.Read
                txtDescricao.Text = oSqlDataReader.Item("descricao")
                cboAtivo.SelectedValue = oSqlDataReader.Item("ativo")
                txtAreaConstruidaLocada.Value = oSqlDataReader.Item("area_construida_locada")
                txtAreaPatioLocada.Value = oSqlDataReader.Item("area_patio_locada")
                txtValorAluguel.Value = oSqlDataReader.Item("valor_aluguel")
                txtReferenciaInterna.Text = oSqlDataReader.Item("referencia_interna")
                dtpInicioVigenciaContrato.Value = oSqlDataReader.Item("data_inicio_vigencia_contrato")
                dtpTerminoVigenciaContrato.Value = oSqlDataReader.Item("data_termino_vigencia_contrato")
                txtRateioConsumoAgua.Value = oSqlDataReader.Item("rateio_consumo_agua")
                cboCliente.SelectedValue = oSqlDataReader.Item("codigo_cliente")

            End While

            'Fecha o SQLDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


#End Region

End Class
