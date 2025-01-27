Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.CalendarCombo

Public Class clsUsrCadTipoItemSped

#Region "::: VARIAVEIS :::"

    Private iCodigo As Integer
    Private iCodigoTipoItemSped As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoTipoItemSped() As Integer
        Get
            Return iCodigoTipoItemSped
        End Get
        Set(ByVal value As Integer)
            iCodigoTipoItemSped = value
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
     
    Public Sub Update()

        Dim oSqlParameter(2) As SqlParameter

        Try
             
            'Seta Parametros 
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(0).Value = goUsuario.iEmpresa

            'Seta Parametros
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Int
            oSqlParameter(1).Value = iCodigo

            'Seta Parametros
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_tipo_item_sped"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iCodigoTipoItemSped

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_tipo_item_sped", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
     
    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sDescricao As String, _
                        ByVal sCodigoItem As String, _
                        ByVal iCodigoNCM As Integer, _
                        ByVal iCodigoGrupoItem As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(4) As SqlParameter

        Try

            'Seta Parametros 
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "descricao"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.VarChar
            oSqlParameter(0).Value = sDescricao

            'Seta Parametros 
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_item"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Value = sCodigoItem

            'Seta Parametros 
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_grupo_item"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iCodigoGrupoItem

            'Seta Parametros 
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_ncm"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iCodigoNCM

            'Seta Parametros - Código Empresa
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "codigo_empresa"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(4).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_tipo_item_sped", oSqlParameter)

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
