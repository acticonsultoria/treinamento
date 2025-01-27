Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class clsFrmFinReceitaCobrancaHistorico

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal lCodigoTituloCapa As Long, _
                        ByVal iNumeroParcela As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter

        Try

            'Seta Parametros - Código Título Capa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_titulo_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoTituloCapa

            'Seta Parametros - Número da Parcela
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "numero_parcela"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = iNumeroParcela

            'Seta Parametros - Código de Empresa
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_empresa"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(2).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_titulo_parcela_cobranca", oSqlParameter)
                        
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
