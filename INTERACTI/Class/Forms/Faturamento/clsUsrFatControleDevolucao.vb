Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.CalendarCombo
Imports Janus.Windows.EditControls
Imports System.IO

Public Class clsUsrFatControleDevolucao

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sNotaFiscal As String, _
                        ByVal sDataInicio As String, _
                        ByVal sDataTermino As String, _
                        ByVal sCFOP As String, _
                        ByVal sFornecedor As String, _
                        ByVal sStatus As String)

        'Variaveis Locais
        Dim oSqlParameter(6) As SqlParameter
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
            oSqlParameter(i).ParameterName = "cfop"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sCFOP = "", DBNull.Value, sCFOP) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sStatus = "", DBNull.Value, sStatus) : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_devolucao", oSqlParameter)

            With oGrid

                'Configura os data members
                ConfigurarDataMemberGrid(oGrid)

                Dim oParentColumn(1) As DataColumn
                Dim oChildColumn(1) As DataColumn

                oParentColumn(0) = oDataSet.Tables(0).Columns("codigo_emissao_capa")
                oParentColumn(1) = oDataSet.Tables(0).Columns("codigo_emissao_item")
                oChildColumn(0) = oDataSet.Tables(1).Columns("codigo_emissao_capa")
                oChildColumn(1) = oDataSet.Tables(1).Columns("codigo_emissao_item")


                oDataSet.Relations.Add("children", oParentColumn, oChildColumn)

                .DataSource = oDataSet.DefaultViewManager
                .DataMember = "main"
                .RootTable.ChildTables(0).DataMember = "children"

            End With

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#Region "::: AJUSTE :::"

    Public Sub LoadGridAjuste(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim oDataSet As DataSet
        Dim i As Integer = 0

        Try


            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_devolucao_ajuste", oSqlParameter)

            'Configura DataMember da Grid
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega a Grid    
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Public Sub LoadDadosRemessaNF(ByVal lCodigoEmissaoCapa As Long, _
                                  ByVal iCodigoEmissaoItem As Integer, _
                                  ByVal txtRemessaNF As MaskedEditBox, _
                                  ByVal txtRemessaDataEmissao As MaskedEditBox, _
                                  ByVal txtRemessaDestinatario As MaskedEditBox, _
                                  ByVal txtRemessaProduto As MaskedEditBox, _
                                  ByVal txtRemessaDescricao As MaskedEditBox, _
                                  ByVal txtRemessaQuantidade As NumericEditBox)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoEmissaoItem : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_devolucao_ajuste_dados", oSqlParameter)

            While oSqlDataReader.Read

                txtRemessaNF.Tag = lCodigoEmissaoCapa
                txtRemessaNF.Text = oSqlDataReader("remessa_nota_fiscal")
                txtRemessaDataEmissao.Text = oSqlDataReader("remessa_data_emissao")
                txtRemessaDestinatario.Text = oSqlDataReader("remessa_destinatario")
                txtRemessaDestinatario.Tag = oSqlDataReader("remessa_codigo_destinatario")
                txtRemessaDescricao.Text = oSqlDataReader("remessa_descricao_produto")
                txtRemessaProduto.Text = oSqlDataReader("remessa_produto")
                txtRemessaProduto.Tag = iCodigoEmissaoItem
                txtRemessaQuantidade.Value = oSqlDataReader("remessa_quantidade")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosDevolucaoNF(ByVal lCodigoEntradaCapa As Long, _
                                    ByVal txtDevolucaoDataEmissao As MaskedEditBox, _
                                    ByVal txtDevolucaoEmitente As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_devolucao_ajuste_devolucao_dados", oSqlParameter)

            While oSqlDataReader.Read

                txtDevolucaoDataEmissao.Text = oSqlDataReader("devolucao_data_emissao")
                txtDevolucaoEmitente.Text = oSqlDataReader("devolucao_emitente")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosDevolucaoItensNF(ByVal lCodigoEntradaCapa As Long, _
                                         ByVal iCodigoEntradaItem As Integer, _
                                         ByVal txtDevolucaoDescricao As MaskedEditBox, _
                                         ByVal txtDevolucaoQuantidade As NumericEditBox)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
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
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoEntradaItem : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_devolucao_ajuste_devolucao_produtos_dados", oSqlParameter)

            While oSqlDataReader.Read

                txtDevolucaoDescricao.Text = oSqlDataReader("devolucao_item_descricao")
                txtDevolucaoQuantidade.Value = oSqlDataReader("devolucao_quantidade")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Public Sub LoadGridProduto(ByVal lCodigoEmissaoCapa As Long, _
                               ByVal iCodigoEmissaoItem As Integer, _
                               ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoEmissaoItem : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_entrada_produto_ajuste", oSqlParameter)

            'Configura DataMember da Grid
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega a Grid    
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Salvar(ByVal lCodigoEmissaoCapa As Long, _
                      ByVal iCodigoEmissaoItem As Integer, _
                      ByVal lCodigoEntradaCapa As Long, _
                      ByVal iCodigoEntradaItem As Integer, _
                      ByVal dQuantidade As Double)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoEmissaoItem : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoEntradaItem : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_devolucao_ajuste", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Delete()

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_entrada_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo_entrada_capa").Value : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_entrada_item"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo_entrada_item").Value : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_entrada_devolucao_ajuste", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region


#End Region

End Class
