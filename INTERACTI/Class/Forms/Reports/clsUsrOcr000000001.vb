Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX

Public Class clsUsrOcr000000001

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGridAnalitico(ByVal oGrid As GridEX, _
                                 ByVal oGridStatus As GridEX, _
                                 ByVal oGridTempo As GridEX, _
                                ByVal sNumeroProtocolo As String, _
                                ByVal sDataOcorrenciaInicio As String, _
                                ByVal sDataOcorrenciaTermino As String, _
                                ByVal sProduto As String, _
                                ByVal sNotaFiscal As String, _
                                ByVal sRevendedor As String, _
                                ByVal sStatus As String, _
                                ByVal sSemana As String, _
                                ByVal sLote As String, _
                                ByVal sNumeroPedido As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(30) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_protocolo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sNumeroProtocolo = "", DBNull.Value, sNumeroProtocolo) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataOcorrenciaInicio = "", DBNull.Value, sDataOcorrenciaInicio) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataOcorrenciaTermino = "", DBNull.Value, sDataOcorrenciaTermino) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sProduto = "", DBNull.Value, sProduto) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sNotaFiscal = "", DBNull.Value, sNotaFiscal) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "revendedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sRevendedor = "", DBNull.Value, sRevendedor) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sStatus : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "lote"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sLote = "", DBNull.Value, sLote) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sNumeroPedido = "", DBNull.Value, sNumeroPedido) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "semana"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sSemana = "", DBNull.Value, sSemana)

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_ocorrencia_relatorio_tempo", oSqlParameter)

            'Configura DataMember Grid
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

            'Configura DataMember Grid
            Call ConfigurarDataMemberGrid(oGridStatus)

            'Carrega Grid
            oGridStatus.DataSource = oDataSet.DefaultViewManager
            oGridStatus.DataMember = oDataSet.Tables(1).TableName : oGrid.MoveFirst()

            'Configura DataMember Grid
            Call ConfigurarDataMemberGrid(oGridTempo)

            'Carrega Grid
            oGridTempo.DataSource = oDataSet.DefaultViewManager
            oGridTempo.DataMember = oDataSet.Tables(2).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
