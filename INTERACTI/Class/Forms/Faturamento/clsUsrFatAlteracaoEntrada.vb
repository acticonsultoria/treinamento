Imports System.Data
Imports System.Data.SqlClient
Imports Janus.Windows.GridEX
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX.EditControls


Public Class clsUsrFatAlteracaoEntrada

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sNotaFiscal As String, _
                        ByVal sDataInicio As String, _
                        ByVal sDataTermino As String, _
                        ByVal sProduto As String, _
                        ByVal sFornecedor As String)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim oDataSet As DataSet
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sFornecedor = "", DBNull.Value, sFornecedor) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sNotaFiscal = "", DBNull.Value, sNotaFiscal) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataInicio = "", DBNull.Value, sDataInicio) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataTermino = "", DBNull.Value, sDataTermino) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sProduto = "", DBNull.Value, sProduto) : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_alteracao_entrada", oSqlParameter)

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

    Public Sub LoadDados(ByVal lCodigoEntradaCapa As Long, _
                         ByVal lCodigoEntradaItem As Long, _
                         ByVal lCodigoEntradaItemLote As Long, _
                         ByVal cboCFOP As UIComboBox, _
                         ByVal cboOperacao As UIComboBox, _
                         ByVal txtNumeroDocumento As MaskedEditBox, _
                         ByVal cboProduto As UIComboBox, _
                         ByVal txtQuantidade As NumericEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(5) As SqlParameter
        Dim oDataSet As DataSet
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaItem : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_pedido_dados", oSqlParameter)

            'Verifica se encontrou algum Registro
            'If oSqlDataReader.HasRows Then

            'Seta Controles
            While oSqlDataReader.Read

                lCodigoEntradaItemLote = oSqlDataReader.Item("codigo_entrada_item_lote")
                cboCFOP.SelectedValue = oSqlDataReader.Item("cfop")
                cboOperacao.SelectedValue = oSqlDataReader.Item("operacao")
                txtNumeroDocumento.Text = oSqlDataReader.Item("numero_documento")
                cboProduto.SelectedValue = oSqlDataReader.Item("producao")
                txtQuantidade.Value = oSqlDataReader.Item("quantidade")

            End While

            ' End If

            'Fecha o DataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update(ByVal lCodigoEntradaCapa As Long, _
                         ByVal lCodigoEntradaItem As Long, _
                         ByVal lCodigoEntradaItemLote As Long, _
                         ByVal iCodigoCFOP As Integer, _
                         ByVal iCodigoTipoOperacao As Integer, _
                         ByVal lCodigoDocumento As Long, _
                         ByVal sCodigoProdutoConcatenado As String, _
                         ByVal dQuantidade As Double, _
                         ByVal iCodigoDeposito As Integer, _
                         ByVal sLote As String)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(12) As SqlParameter
        Dim oDataSet As DataSet
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaItem : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_item_lote"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaItemLote : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_operacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoTipoOperacao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoDocumento : i += 1

            Select Case iCodigoTipoOperacao

                Case TipoOperacaoNotaFiscalEntrada.EntradaNFe

                    Dim oVetor() As String = Split(sCodigoProdutoConcatenado, "|")


                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_1"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                    oSqlParameter(i).Value = oVetor(0) : i += 1

                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_2"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                    oSqlParameter(i).Value = oVetor(1) : i += 1

                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_item"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                    oSqlParameter(i).Value = oVetor(2) : i += 1

                Case TipoOperacaoNotaFiscalEntrada.Compra

                Case TipoOperacaoNotaFiscalEntrada.DevolucaoNFe

                Case TipoOperacaoNotaFiscalEntrada.OrdemProducao

            End Select


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_deposito"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoDeposito : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "lote"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sLote : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_entrada_item_lote", oSqlParameter)



        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
#End Region

End Class
