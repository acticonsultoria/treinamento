Imports System.Data
Imports System.Data.SqlClient
Imports SysACTi.SQLHelper
Imports Janus.Windows.GridEX

Public Class clsUsrCmpReclassificarItem

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private lCodigoRequisicao As Long
    Private iCentroCusto As Integer
    Private iUtilizacaoItem As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property CentroCusto() As Integer
        Get
            Return iCentroCusto
        End Get
        Set(ByVal value As Integer)
            iCentroCusto = value
        End Set
    End Property

    Public Property UtilizacaoItem() As Integer
        Get
            Return iUtilizacaoItem
        End Get
        Set(ByVal value As Integer)
            iUtilizacaoItem = value
        End Set
    End Property

    Public Property CodigoRequisicao() As Long
        Get
            Return lCodigoRequisicao
        End Get
        Set(ByVal value As Long)
            lCodigoRequisicao = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub Salvar()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter

        Try

            'Seta Parametros - Centro de Custo
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_centro_custo"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = iCentroCusto

            'Seta Parametros - Utilização do Item
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_utilizacao_item"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Int
            oSqlParameter(1).Value = iUtilizacaoItem

            'Seta Parametros - Código Requisição de Compras
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_requisicao"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.BigInt
            oSqlParameter(2).Value = lCodigoRequisicao

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_compras_reclassificar_item", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal lNumeroRequisicao As Long, _
                        ByVal sItem As String, _
                        ByVal iCentroCusto As Integer, _
                        ByVal iUtilizacaoItem As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(5) As SqlParameter

        Try

            'Seta Parametros - Número de Requisição
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "numero_requisicao"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lNumeroRequisicao

            'Seta Parametros - Item
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "item"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Size = 100
            oSqlParameter(1).Value = sItem

            'Seta Parametros - Centro de Custo
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_centro_custo"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iCentroCusto

            'Seta Parametros - Utilização Item
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_utilizacao_item"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iUtilizacaoItem

            'Seta Parametros - Empresa
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "codigo_empresa"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Int
            oSqlParameter(4).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_reclassificar_item", oSqlParameter)

            With oGrid

                .RootTable.Columns.Item("numero_requisicao").DataMember = "numero_requisicao"
                .RootTable.Columns.Item("item").DataMember = "item"
                .RootTable.Columns.Item("centro_custo").DataMember = "centro_custo"
                .RootTable.Columns.Item("utilizacao_item").DataMember = "utilizacao_item"
                .RootTable.Columns.Item("codigo_item").DataMember = "codigo_item"
                .RootTable.Columns.Item("codigo").DataMember = "codigo"

                .DataSource = oDataSet.DefaultViewManager
                .DataMember = oDataSet.Tables(0).TableName

            End With


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
