Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.CalendarCombo

Public Class clsUsrCadParceiroNegocioCentralEmail
     
#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As Janus.Windows.GridEX.GridEX, _
                        ByVal iTipoEmail As Integer, _
                        ByVal iCodigoEmpresa As Integer, _
                        ByVal sCliente As String, _
                        ByVal sContato As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Tipo E-mail
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo_email"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iTipoEmail : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoEmpresa : i += 1

            'Seta Parametros - Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sCliente : i += 1

            'Seta Parametros - Contato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "contato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sContato

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_central_email", oSqlParameter)

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
