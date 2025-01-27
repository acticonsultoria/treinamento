Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Dundas.Charting.WinControl

Public Class clsUsrEstModelo7

#Region "::: FUNCTION / SUB :::"



    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal oGridSintetico As GridEX, _
                        ByVal sCodigoItem As String, _
                        ByVal sDataReferencia As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try




            'Seta Parametros - Código do Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sCodigoItem : i += 1


            'Seta Parametros - Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Data Referencia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_referencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = sDataReferencia : i += 1



            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_estoque_modelo7", oSqlParameter)

            With oGrid

                ConfigurarDataMemberGrid(oGrid)


                'Datasource
                .DataSource = oDataSet

                'Setando o datasource da capa 
                .DataMember = oDataSet.Tables(0).TableName

            End With

            With oGridSintetico

                ConfigurarDataMemberGrid(oGridSintetico)


                'Datasource
                .DataSource = oDataSet

                'Setando o datasource da capa 
                .DataMember = oDataSet.Tables(2).TableName

            End With

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    
#End Region

End Class
