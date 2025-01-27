Imports System.Data
Imports System.Data.SqlClient
Imports SysACTi.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class clsUsrCmpRecebimentoCancelar

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private lRecebimentoCapa As Long
    Private lDespesaCapa As Long

#End Region

#Region "::: PROPERTIE :::"

    Public Property RecebimentoCapa() As String
        Get
            Return lRecebimentoCapa
        End Get
        Set(ByVal value As String)
            lRecebimentoCapa = value
        End Set
    End Property

    Public Property DespesaCapa() As String
        Get
            Return lDespesaCapa
        End Get
        Set(ByVal value As String)
            lDespesaCapa = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As Janus.Windows.GridEX.GridEX, _
                        ByVal sNumeroDocumento As String, _
                        ByVal sSerie As String, _
                        ByVal lNumeroPedido As Long, _
                        ByVal lFornecedor As Long, _
                        ByVal sDataInicio As String, _
                        ByVal sDataTermino As String, _
                        ByVal sPartNumber As String, _
                        ByVal sItem As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(8) As SqlParameter

        Try

            'Seta Parametros - Número do Documento
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "numero_documento"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.VarChar
            oSqlParameter(0).Size = 20
            oSqlParameter(0).Value = sNumeroDocumento

            'Seta Parametros - Série
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "serie"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Size = 3
            oSqlParameter(1).Value = sSerie

            'Seta Parametros - Número do Pedido
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "numero_pedido"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.BigInt
            oSqlParameter(2).Value = IIf(lNumeroPedido = -1, DBNull.Value, lNumeroPedido)

            'Seta Parametros - Código do Fornecedor
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_fornecedor"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.BigInt
            oSqlParameter(3).Value = lFornecedor

            'Seta Parametros - Data da Início
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "data_inicio"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Date
            oSqlParameter(4).Value = IIf(sDataInicio = "", DBNull.Value, sDataInicio)

            'Seta Parametros - Data Termino
            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "data_termino"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.Date
            oSqlParameter(5).Value = IIf(sDataTermino = "", DBNull.Value, sDataTermino)

            'Seta Parametros - Empresa
            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "codigo_empresa"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.Int
            oSqlParameter(6).Value = goUsuario.iEmpresa

            'Seta Parametros - Part Number
            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "part_number"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.VarChar
            oSqlParameter(7).Value = sPartNumber

            'Seta Parametros - Item
            oSqlParameter(8) = New SqlParameter
            oSqlParameter(8).ParameterName = "item"
            oSqlParameter(8).Direction = ParameterDirection.Input
            oSqlParameter(8).SqlDbType = SqlDbType.VarChar
            oSqlParameter(8).Value = sItem

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_recebimento_cancelar", oSqlParameter)

            With oGrid



                .RootTable.Columns.Item("numero_documento").DataMember = "numero_documento"
                .RootTable.Columns.Item("data_recebimento").DataMember = "data_recebimento"
                .RootTable.Columns.Item("fornecedor").DataMember = "fornecedor"
                .RootTable.Columns.Item("numero_pedido").DataMember = "numero_pedido"
                .RootTable.Columns.Item("usuario").DataMember = "usuario"
                .RootTable.Columns.Item("valor_total").DataMember = "valor_total"
                .RootTable.Columns.Item("codigo_fornecedor").DataMember = "codigo_fornecedor"
                .RootTable.Columns.Item("codigo_recebimento_capa").DataMember = "codigo_recebimento_capa"
                .RootTable.Columns.Item("codigo_despesa_capa").DataMember = "codigo_despesa_capa"
                .RootTable.Columns.Item("status").DataMember = "status"

                .DataSource = oDataSet.DefaultViewManager
                .DataMember = oDataSet.Tables(0).TableName

            End With


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub CancelarRecebimento()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Recebimento Capa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_recebimento_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lRecebimentoCapa

            'Seta Parametros - Despesa Capa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_despesa_capa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = lDespesaCapa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_compras_recebimento_cancelar", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidarCancelarRecebimento(ByVal lCodigo As Long) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim iReturn As Integer
        Try

            'Seta Parametros - Recebimento Capa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_recebimento_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigo


            'Executa Query
            iReturn = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_compras_recebimento_cancelar", oSqlParameter)

            If iReturn > 0 Then
                ValidarCancelarRecebimento = False
            Else
                ValidarCancelarRecebimento = True
            End If

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class
