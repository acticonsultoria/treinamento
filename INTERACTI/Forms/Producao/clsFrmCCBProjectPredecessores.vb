Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX

Public Class clsFrmCCBProjectPredecessores

#Region "::: FUNCTION / SUB :::"


    Public Sub LoadDadosAtividade(ByVal oGrid As GridEX, _
                                  ByVal iCodigoAtividade As Integer)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(0) As SqlParameter

        Try


            'Seta Parametros - Código da Atividade
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_ccb_atividade_project"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = iCodigoAtividade

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_ccb_dados_atividade_project", oSqlParameter)

            While oSqlDataReader.Read

                oGrid.SetValue("duracao", oSqlDataReader.Item("duracao"))
                oGrid.SetValue("recurso", oSqlDataReader.Item("codigo_departamento"))
                oGrid.SetValue("restricao", oSqlDataReader.Item("codigo_tipo_restricao"))

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


#End Region

End Class
