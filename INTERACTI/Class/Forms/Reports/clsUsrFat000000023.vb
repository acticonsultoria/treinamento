Imports System.Data
Imports System.Data.SqlClient
Imports Janus.Windows.GridEX
Imports INTERACTI.SQLHelper

Public Class clsUsrFat000000023

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sNotaFiscal As String, _
                        ByVal sDataInicio As String, _
                        ByVal sDataTermino As String, _
                        ByVal iCodigoParceiroNegocio As Integer, _
                        ByVal sCodigoItem As String, _
                        ByVal iCodigoTipoDocumentoFiscal As Integer, _
                        ByVal bExibirCancelada As Boolean, _
                        ByVal bSomenteFatura As Boolean)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCodigoItem : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_documento_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoTipoDocumentoFiscal : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            'Seta Parametros - Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNotaFiscal : i += 1

            'Seta Parametros - Data Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataInicio) = True, sDataInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataTermino) = True, sDataTermino, DBNull.Value) : i += 1

            'Seta Parametros - Cancelada
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "exibir_cancelada"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.bit
            oSqlParameter(i).Value = bexibircancelada : i += 1

            'Seta Parametros - ftura
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "somente_fatura"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.bit
            oSqlParameter(i).Value = bsomentefatura : i += 1


            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_grid_fat000000023", oSqlParameter)

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
