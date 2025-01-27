Imports System.IO
Imports System.IO.File
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports SysACTi.SQLHelper

Public Class clsUsrFatEntradaNFASCON

#Region "::: FUNCTION / SUB :::"


    Public Sub LoadGrid(ByVal oGrid As Janus.Windows.GridEX.GridEX, _
                        ByVal sNotaFiscal As String, _
                        ByVal sDataEmissaoInicio As String, _
                        ByVal sDataEmissaoFim As String, _
                        ByVal sEmitente As String, _
                        ByVal sDataEntradaInicio As String, _
                        ByVal sDataEntradaFim As String)

        'Variaveis Locais
        Dim oSqlParameter(10) As SqlParameter
        Dim oDataSet As DataSet

        Try


            'Seta Parametros - Código Empresa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "nota_fiscal"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.VarChar
            oSqlParameter(0).Value = sNotaFiscal

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "data_emissao_inicio"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Date
            oSqlParameter(1).Value = IIf(sDataEmissaoInicio = "", DBNull.Value, sDataEmissaoInicio)

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "data_emissao_fim"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Date
            oSqlParameter(2).Value = IIf(sDataEmissaoFim = "", DBNull.Value, sDataEmissaoFim)

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "emitente"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.VarChar
            oSqlParameter(3).Value = sEmitente

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "data_entrada_inicio"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Date
            oSqlParameter(4).Value = IIf(sDataEntradaInicio = "", DBNull.Value, sDataEntradaInicio)

            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "data_entrada_fim"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.Date
            oSqlParameter(5).Value = IIf(sDataEntradaFim = "", DBNull.Value, sDataEntradaFim)

            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "codigo_empresa"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.Int
            oSqlParameter(6).Value = goUsuario.iEmpresa

            'Executa Quety
            oDataSet = SQLHelper.ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_entrada_ascon", oSqlParameter)

            With oGrid

                ConfigurarDataMemberGrid(oGrid)

                .DataSource = oDataSet.DefaultViewManager
                .DataMember = oDataSet.Tables(0).TableName

            End With

        Catch Sqlex As SqlException
            Throw Sqlex
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class


