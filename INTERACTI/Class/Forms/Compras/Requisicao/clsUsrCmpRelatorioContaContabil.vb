Imports System.Data
Imports System.Data.SqlClient
Imports SysACTi.SQLHelper

Public Class clsUsrCmpRelatorioContaContabil

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As Janus.Windows.GridEX.GridEX, _
                        ByVal lNotaFiscal As Long, _
                        ByVal iFornecedor As Integer, _
                        ByVal sDataEmissao1 As String, _
                        ByVal sDataEmissao2 As String, _
                        ByVal sItem As String, _
                        ByVal iContaContabil As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(6) As SqlParameter

        Try

            'Seta Parametros - Nota Fiscal
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "nota_fiscal"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lNotaFiscal

            'Seta Parametros - Código Fornecedor
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_fornecedor"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Int
            oSqlParameter(1).Value = iFornecedor

            'Seta Parametros - Data de Emissão 1
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "data_emissao1"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Date
            oSqlParameter(2).Value = IIf(sDataEmissao1 = "", DBNull.Value, sDataEmissao1)

            'Seta Parametros - Data de Emissão 2
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "data_emissao2"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Date
            oSqlParameter(3).Value = IIf(sDataEmissao2 = "", DBNull.Value, sDataEmissao2)

            'Seta Parametros - Item
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "item"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.VarChar
            oSqlParameter(4).Size = 100
            oSqlParameter(4).Value = sItem

            'Seta Parametros - Conta Contábil
            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "codigo_conta_contabil"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.Int
            oSqlParameter(5).Value = iContaContabil

            'Seta Parametros - Empresa
            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "codigo_empresa"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.Int
            oSqlParameter(6).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_report_compras_conta_contabil", oSqlParameter)

            With oGrid

                .RootTable.Columns.Item("nota_fiscal").DataMember = "nota_fiscal"
                .RootTable.Columns.Item("data_emissao").DataMember = "data_emissao"
                .RootTable.Columns.Item("fornecedor").DataMember = "fornecedor"
                .RootTable.Columns.Item("item").DataMember = "item"
                .RootTable.Columns.Item("quantidade").DataMember = "quantidade"
                .RootTable.Columns.Item("valor_unitario").DataMember = "valor_unitario"
                .RootTable.Columns.Item("valor_total").DataMember = "valor_total"
                .RootTable.Columns.Item("conta_contabil").DataMember = "conta_contabil"

                .DataSource = oDataSet.DefaultViewManager
                .DataMember = oDataSet.Tables(0).TableName

            End With


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
