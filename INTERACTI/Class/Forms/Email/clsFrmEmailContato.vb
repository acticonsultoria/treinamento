Imports System.Data
Imports System.Data.SqlClient
Imports Janus.Windows.GridEX
Imports INTERACTI.SQLHelper

Public Class clsFrmEmailContato

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadContato(ByVal oGrid As GridEX, _
                           ByVal lCodigoParceiroNegocio As Long)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oDataSet As DataSet

        Try

            'Seta Parametros - Código Parceiro de Negócio
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoParceiroNegocio

            'Seta Parametros - Codigo Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_contato_email", oSqlParameter)
                        
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
