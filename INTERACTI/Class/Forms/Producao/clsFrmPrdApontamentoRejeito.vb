Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls

Public Class clsFrmPrdApontamentoRejeito

#Region "::: FUNCTION / SUB :::"

    Public Sub UpdateApontamento(ByVal lCodigoOrdemProducao As Long, _
                                 ByVal iSequencia As Integer, _
                                 ByVal iInicio As Integer, _
                                 ByVal iCodigo As Integer, _
                                 ByVal sProntuarioFuncionario As String, _
                                 ByVal iCodigoEquipamento As Integer, _
                                 ByVal dQuantidadeProduzida As Double, _
                                 ByVal dQuantidadeRejeito As Double)

        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Tipo de Apontamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_apontamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = 4 : i += 1

            'Seta Parametros - Código Ordem de Produção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ordem_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoOrdemProducao : i += 1

            'Seta Parametros - Sequência
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sequencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iSequencia : i += 1

            'Seta Parametros - Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iInicio : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Prontuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "prontuario_funcionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sProntuarioFuncionario : i += 1

            'Seta Parametros - Código do Equipamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_equipamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoEquipamento = -1, DBNull.Value, iCodigoEquipamento) : i += 1

            'Seta Parametros - Quantidade Produzida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_produzida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dQuantidadeProduzida = -1, DBNull.Value, dQuantidadeProduzida) : i += 1

            'Seta Parametros - Quantidade Rejeito
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_rejeito"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dQuantidadeRejeito = -1, DBNull.Value, dQuantidadeRejeito) : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_producao_apontamento", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
