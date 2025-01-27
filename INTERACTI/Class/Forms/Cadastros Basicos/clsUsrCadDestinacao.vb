Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper

Public Class clsUsrCadDestinacao

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sDescricao As String
    Private bRemessa As Boolean
    Private bConsumidorFinal As Boolean
    Private bReceita As Boolean
    Private iCodigo As Integer

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

    Public Property Receita() As Boolean
        Get
            Return bReceita
        End Get
        Set(ByVal value As Boolean)
            bReceita = value
        End Set
    End Property

    Public Property Remessa() As Boolean
        Get
            Return bRemessa
        End Get
        Set(ByVal value As Boolean)
            bRemessa = value
        End Set
    End Property

    Public Property ConsumidorFinal() As Boolean
        Get
            Return bConsumidorFinal
        End Get
        Set(ByVal value As Boolean)
            bConsumidorFinal = value
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

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub Insert()

        'Variaveis Locais
        Dim oSqlParameter(10) As SqlParameter

        Try


            'Seta Parametros - Descricao
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "descricao"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Value = sDescricao

            'Seta Parametros - Ativo
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "receita"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Bit
            oSqlParameter(2).Value = bReceita

            'Seta Parametros - Codigo Empresa
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "remessa"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Bit
            oSqlParameter(3).Value = bRemessa

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "consumidor_final"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Bit
            oSqlParameter(4).Value = bConsumidorFinal

            'Seta Parametros - Codigo
            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "codigo"
            oSqlParameter(5).Direction = ParameterDirection.Output
            oSqlParameter(5).SqlDbType = SqlDbType.Int

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_static_cadastro_basico_destinacao", oSqlParameter)

            iCodigo = oSqlParameter(5).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update()

        'Variaveis Locais
        Dim oSqlParameter(10) As SqlParameter

        Try

            'Seta Parametros - Descricao
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "descricao"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Value = sDescricao

            'Seta Parametros - Ativo
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "receita"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Bit
            oSqlParameter(2).Value = bReceita

            'Seta Parametros - Codigo Empresa
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "remessa"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Bit
            oSqlParameter(3).Value = bRemessa

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "consumidor_final"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Bit
            oSqlParameter(4).Value = bConsumidorFinal

            'Seta Parametros - Codigo
            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "codigo"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.Int
            oSqlParameter(5).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_static_cadastro_basico_destinacao", oSqlParameter)

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

        Try

            For i = 0 To UBound(gSelecaoRow)

                'Seta Parametros - Código
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.Int
                oSqlParameter(0).Value = gSelecaoRow(i).Cells("codigo").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_static_cadastro_basico_destinacao", oSqlParameter)

                'Exclui Linha
                gSelecaoRow(i).Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGrid(ByVal oGrid As Janus.Windows.GridEX.GridEX, _
                        ByVal sDescricao As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter

        Try


            'Seta Parametros - Descrição
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "descricao"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Size = 50
            oSqlParameter(1).Value = sDescricao


            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_static_cadastro_basico_destinacao", oSqlParameter)

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

    Public Function ValidaMoeda(ByVal iCodigo As Integer, _
                                ByVal sMoeda As String) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim iReturn As Integer

        Try

            'Seta Retorno da Função
            ValidaMoeda = False

            'Seta Parametros - Moeda
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "moeda"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.VarChar
            oSqlParameter(0).Size = 10
            oSqlParameter(0).Value = sMoeda

            'Seta Parametros - Codigo
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Int
            oSqlParameter(1).Value = iCodigo

            'Seta Parametros - Codigo Empresa
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_empresa"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(2).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_cadastro_basico_moeda", oSqlParameter), Integer)

            'Seta Retorno da Função
            ValidaMoeda = IIf(iReturn > 0, False, True)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class
