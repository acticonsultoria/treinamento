Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX

Public Class clsFrmFinTituloDuplicar

#Region "::: FUNCTION / SUB :::"

    Public Sub Duplicar(ByVal lCodigoTitulo As Long, _
                        ByVal oGrid As gridEX)

        'Variaveis Locais
        Dim oSqlParameter(10) As SqlParameter
        Dim oRow As GridEXRow
        Dim i As Integer

        Try

            For Each oRow In oGrid.GetDataRows

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoTitulo : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Número Documento
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero_documento"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 20
                oSqlParameter(i).Value = oRow.Cells("numero_documento").Value : i += 1

                'Seta Parametros - Série
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "serie"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 3
                oSqlParameter(i).Value = oRow.Cells("serie").Value : i += 1

                'Seta Parametros - Data Emissão
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data_emissao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = oRow.Cells("data_emissao").Value : i += 1

                'Seta Parametros - N° Dias
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero_dias"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("numero_dias").Value : i += 1

                'Seta Parametros - Código Tipo do Título Financeiro
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_tipo_titulo_financeiro"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("tipo_titulo_financeiro").Value : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("valor").Value : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data_vencimento"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = oRow.Cells("data_vencimento").Value : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_usuario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = goUsuario.iUsuario

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_titulo_duplicar", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
