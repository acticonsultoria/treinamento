Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper

Public Class clsUsrCadTipoVeiculo

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sDescricao As String
    Private bAtivo As Boolean
    Private iCodigoFormaControleVeiculo As Integer
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

    Public Property Ativo() As Boolean
        Get
            Return bAtivo
        End Get
        Set(ByVal value As Boolean)
            bAtivo = value
        End Set
    End Property

    Public Property CodigoFormaControleVeiculo() As Integer
        Get
            Return iCodigoFormaControleVeiculo
        End Get
        Set(ByVal value As Integer)
            iCodigoFormaControleVeiculo = value
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
        Dim oSqlParameter(3) As SqlParameter

        Try

            'Seta Parametros - Descricao
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "descricao"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.VarChar
            oSqlParameter(0).Size = 50
            oSqlParameter(0).Value = sDescricao

            'Seta Parametros - Codigo Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Seta Parametros - Codigo Forma de Controle Veículo
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_forma_controle_veiculo"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(2).Value = iCodigoFormaControleVeiculo

            'Seta Parametros - Ativo
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "ativo"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Bit
            oSqlParameter(3).Value = bAtivo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_tipo_veiculo", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update()

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter

        Try

            'Seta Parametros - Codigo
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(0).Value = iCodigo

            'Seta Parametros - Codigo Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Seta Parametros - Descricao
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "descricao"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Size = 50
            oSqlParameter(2).Value = sDescricao

            'Seta Parametros - Código Forma de Controle Veículo
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_forma_controle_veiculo"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(3).Value = iCodigoFormaControleVeiculo

            'Seta Parametros - Ativo
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "ativo"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Bit
            oSqlParameter(4).Value = bAtivo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_tipo_veiculo", oSqlParameter)

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
                oSqlParameter(0).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(0).Value = gSelecaoRow(i).Cells("codigo").Value

                'Seta Parametros - Codigo Empresa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_empresa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(1).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_tipo_veiculo", oSqlParameter)

                'Exclui Linha
                gSelecaoRow(i).Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaDescricao(ByVal iCodigo As Integer, _
                                    ByVal sDescricao As String) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim iReturn As Integer

        Try

            'Seta Retorno da Função
            ValidaDescricao = False

            'Seta Parametros - Codigo
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(0).Value = iCodigo

            'Seta Parametros - Descrição
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "descricao"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Size = 50
            oSqlParameter(1).Value = sDescricao

            'Seta Parametros - Codigo Empresa
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_empresa"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(2).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_cadastro_basico_tipo_veiculo", oSqlParameter), Integer)

            'Seta Retorno da Função
            ValidaDescricao = IIf(iReturn > 0, False, True)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub LoadGrid(ByVal oGrid As Janus.Windows.GridEX.GridEX, ByVal sDescricao As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Descrição
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "descricao"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.VarChar
            oSqlParameter(0).Size = 50
            oSqlParameter(0).Value = sDescricao

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_tipo_veiculo", oSqlParameter)
                        
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

End Class
