Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX

Public Class clsUsrNFeLogCancelamento

#Region "::: FUNCTION / SUB :::"

    Public Sub Delete()

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer

        Try

            For i = 0 To UBound(gSelecaoRow)

                'Seta Parametros - Código
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.Int
                oSqlParameter(0).Value = gSelecaoRow(i).Cells("codigo").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_pais", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal lNotaFiscal As Long, _
                        ByVal iSerie As Integer, _
                        ByVal sDestinatario As String, _
                        ByVal sDataInicio As String, _
                        ByVal sDataTermino As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(0) As SqlParameter

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_nfe_log_cancelamento", oSqlParameter)

            With oGrid

                .RootTable.Columns.Item("versao").DataMember = "versao"
                .RootTable.Columns.Item("id").DataMember = "id"
                .RootTable.Columns.Item("tipo_ambiente").DataMember = "tipo_ambiente"
                .RootTable.Columns.Item("versao_aplicativo").DataMember = "versao_aplicativo"
                .RootTable.Columns.Item("status").DataMember = "status"
                .RootTable.Columns.Item("uf").DataMember = "uf"
                .RootTable.Columns.Item("chave_acesso").DataMember = "chave_acesso"
                .RootTable.Columns.Item("cnpj").DataMember = "cnpj"
                .RootTable.Columns.Item("destinatario").DataMember = "destinatario"
                .RootTable.Columns.Item("nota_fiscal").DataMember = "nota_fiscal"
                .RootTable.Columns.Item("serie").DataMember = "serie"                
                .RootTable.Columns.Item("data_processamento").DataMember = "data_processamento"
                .RootTable.Columns.Item("numero_protocolo").DataMember = "numero_protocolo"
                .RootTable.Columns.Item("data_input").DataMember = "data_input"
                .RootTable.Columns.Item("usuario").DataMember = "codigo_usuario"
                .RootTable.Columns.Item("arquivo_envio").DataMember = "arquivo_envio"
                .RootTable.Columns.Item("arquivo_retorno").DataMember = "arquivo_retorno"

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
