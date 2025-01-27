Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX

Public Class clsFrmFinTituloDuplicarParcela

#Region "::: FUNCTION / SUB :::"

    Public Sub DuplicarParcela(ByVal lCodigoTitulo As Long, _
                               ByVal iNumeroParcela As Integer, _
                               ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim oRow As GridEXRow
        Dim i As Integer

        Try

            For Each oRow In oGrid.GetDataRows

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Título Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_titulo_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoTitulo : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Número Parcela
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero_parcela"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = iNumeroParcela : i += 1

                'Seta Parametros - Número Parcela Atual
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero_parcela_atual"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.RowIndex + 1 : i += 1

                'Seta Parametros - Data Vencimento
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data_vencimento"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = oRow.Cells("data_vencimento").Value : i += 1

                'Seta Parametros - Valor Parcela
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor_parcela"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("valor").Value : i += 1

                'Seta Parametros - Número de Parcelas
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero_parcelas"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 2
                oSqlParameter(i).Value = oGrid.GetDataRows.Count : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_usuario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = goUsuario.iUsuario

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_titulo_parcela_duplicar", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
