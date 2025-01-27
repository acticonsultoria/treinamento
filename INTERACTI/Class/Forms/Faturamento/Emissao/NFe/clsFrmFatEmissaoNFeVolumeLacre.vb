Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls

Public Class clsFrmFatEmissaoNFeVolumeLacre

#Region "::: FUNCTION / SUB :::"

    Public Sub Delete(ByVal lCodigoEmissaoCapa As Long, _
                      ByVal iCodigoEmissaoTransporteVolume As Integer)

        'Variaveis Locais
        Dim i As Integer
        Dim oSqlParameter(3) As SqlParameter

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Codigo Emissão Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

                'Seta Parametros - Codigo Emissão Transporte Volume
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_transporte_volume"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = iCodigoEmissaoTransporteVolume : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Número do Lacre
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero_lacre"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 60
                oSqlParameter(i).Value = oRow.Cells("lacre").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_transporte_volume_lacre", oSqlParameter)

                'Exclui Linha da Grid
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Insert(ByVal lCodigoEmissaoCapa As Long, _
                      ByVal iCodigoEmissaoTransporteVolume As Integer, _
                      ByVal sNumeroLacre As String)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Codigo Emissão Transporte Volume
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_transporte_volume"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoEmissaoTransporteVolume : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Número do Lacre
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_lacre"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sNumeroLacre

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_transporte_volume_lacre", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal lCodigoEmissaoCapa As Long, _
                        ByVal iCodigoEmissaoTransporteVolume As Integer)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim oDataSet As DataSet
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Codigo Emissão Transporte Volume
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_transporte_volume"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoEmissaoTransporteVolume : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_transporte_volume_lacre", oSqlParameter)

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

    Public Sub Update(ByVal lCodigoEmissaoCapa As Long, _
                      ByVal iCodigoEmissaoTransporteVolume As Integer, _
                      ByVal sNumeroLacre As String, _
                      ByVal sNumeroLacreAntigo As String)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Codigo Emissão Transporte Volume
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_transporte_volume"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoEmissaoTransporteVolume : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Número do Lacre
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_lacre"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sNumeroLacre : i += 1

            'Seta Parametros - Número do Lacre Antigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_lacre_antigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sNumeroLacreAntigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_transporte_volume_lacre", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
