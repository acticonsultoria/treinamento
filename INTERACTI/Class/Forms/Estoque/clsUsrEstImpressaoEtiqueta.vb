Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper

Public Class clsUsrEstImpressaoEtiqueta


#Region "::: FUNCTION / SUB :::"

    Public Sub IntegracaoEstoque(ByVal lCodigo As Long)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_estoque_movimentacao_baixa_manual", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function Insert(ByVal lCodigoItem As Long, _
                      ByVal dQuantidade As Double, _
                      ByVal dDataBaixa As Date, _
                      ByVal sObservacao As String, _
                      ByVal sTipo As String, _
                      ByVal dValorUnitario As Double) As Long

        'Variaveis Locais
        Dim oSqlParameter(6) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_item"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoItem

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "quantidade"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Float
            oSqlParameter(1).Value = dQuantidade

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "data_baixa"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Date
            oSqlParameter(2).Value = dDataBaixa


            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "observacao"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.VarChar
            oSqlParameter(3).Value = sObservacao


            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "tipo"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.VarChar
            oSqlParameter(4).Value = sTipo

            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "valor_unitario"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.Float
            oSqlParameter(5).Value = dValorUnitario

            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "codigo"
            oSqlParameter(6).Direction = ParameterDirection.Output
            oSqlParameter(6).SqlDbType = SqlDbType.BigInt

            Dim lCodigo As Long
            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_estoque_baixa", oSqlParameter)
            lCodigo = oSqlParameter(6).Value
            Return lCodigo
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub Delete()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
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
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_estoque_baixa", oSqlParameter)

                'Exclui Linha
                gSelecaoRow(i).Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGrid(ByVal oGrid As Janus.Windows.GridEX.GridEX, _
                        ByVal iCodigoDocumento As Integer, _
                        ByVal iCodigoEtiqueta As Integer, _
                        ByVal iCodigoCliente As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(4) As SqlParameter

        Try


            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_documento"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = iCodigoDocumento

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_etiqueta"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.BigInt
            oSqlParameter(2).Value = iCodigoEtiqueta

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_empresa"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(3).Value = goUsuario.iEmpresa

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "codigo_cliente"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.BigInt
            oSqlParameter(4).Value = iCodigoCliente


            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_estoque_etiqueta", oSqlParameter)

            With oGrid
                ConfigurarDataMemberGrid(oGrid)

                .DataSource = oDataSet.DefaultViewManager
                .DataMember = oDataSet.Tables(0).TableName

            End With

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosProduto(ByVal lCodigoItem As Long, _
                                     ByVal txtDescricao As Janus.Windows.GridEX.EditControls.EditBox, _
                                     ByVal txtEstoque As Janus.Windows.GridEX.EditControls.NumericEditBox)


        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_item"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoItem



            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_dados_produto", oSqlParameter)


            If oSqlDataReader.Read Then
                txtDescricao.Text = oSqlDataReader.Item("descricao")
                txtEstoque.Value = oSqlDataReader.Item("estoque")
            Else
                txtDescricao.Text = ""
                txtEstoque.Value = 0
            End If

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class
