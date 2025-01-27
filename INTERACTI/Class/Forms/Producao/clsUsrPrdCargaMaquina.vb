Imports System.Data
Imports System.Data.SqlClient
Imports Janus.Windows.GridEX
Imports INTERACTI.SQLHelper

Public Class clsUsrPrdCargaMaquina

#Region "::: FUNCTION / SUB :::"
    Public Sub LoadDadosOrcamento(ByVal lcodigoOrcamento As Long, _
                                  ByRef sNumeroOrcamento As String, _
                                  ByRef sRevisao As String, _
                                  ByRef dDataEntrega As Date, _
                                  ByRef sCliente As String)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(16) As SqlParameter
        Dim i As Integer = 0

        Try


            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_orcamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lcodigoOrcamento : i += 1




            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_orcamento_dados_orcamento", oSqlParameter)

            If oSqlDataReader.Read Then

                sNumeroOrcamento = oSqlDataReader.Item("numero_orcamento")
                sRevisao = oSqlDataReader.Item("revisao")
                sCliente = oSqlDataReader.Item("cliente")
                dDataEntrega = oSqlDataReader.Item("data_entrega")

            End If

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
 
    Public Sub LoadGrid(ByVal oGridNecessidade As GridEX, _
                        ByVal oGridDisponibilidade As GridEX, _
                        ByVal oGridCargaMaquina As GridEX, _
                        ByVal sStatus As String, _
                        ByVal bIncluirSabado As Boolean, _
                        ByVal bIncluirDomingo As Boolean, _
                        ByVal sOrcamentos As String, _
                        ByVal sDataInicio As String, _
                        ByVal sDataTermino As String, _
                        ByVal sDataEntregaInicio As String, _
                        ByVal sDataEntregaTermino As String, _
                        ByVal sOrdemProducaoDesconsiderar As String
                        )

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim i As Integer = 0
        Dim oSqlParameter(i) As SqlParameter

        Try

            Dim sMaquina As String = ""

            For Each oRow In oGridDisponibilidade.GetRows

                If oRow.Cells.Item("disponibilidade_diaria").Value > 0.0 Then

                    sMaquina += IIf(sMaquina = "", "", ",") + CStr(oRow.Cells.Item("codigo_maquina").Value) + "|" + oRow.Cells.Item("disponibilidade_diaria").Value.ToString.Replace(",", ".")


                End If

            Next


            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "orcamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sOrcamentos : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "maquina"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sMaquina : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sStatus : i += 1 : ReDim Preserve oSqlParameter(i)


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "incluir_sabado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bIncluirSabado : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "incluir_domingo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bIncluirDomingo : i += 1 : ReDim Preserve oSqlParameter(i)


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ordem_producao_desconsiderar"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sOrdemProducaoDesconsiderar : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_producao_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataInicio = "", DBNull.Value, sDataInicio) : i += 1 : ReDim Preserve oSqlParameter(i)


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_producao_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataTermino = "", DBNull.Value, sDataTermino) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_entrega_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataEntregaInicio = "", DBNull.Value, sDataEntregaInicio) : i += 1 : ReDim Preserve oSqlParameter(i)


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_entrega_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataEntregaTermino = "", DBNull.Value, sDataEntregaTermino)

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_producao_carga_maquina", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGridNecessidade)
            'Call ConfigurarDataMemberGrid(oGridDisponibilidade)
            Call ConfigurarDataMemberGrid(oGridCargaMaquina)



            'Carrega Grid
            oGridNecessidade.DataSource = oDataSet.DefaultViewManager
            oGridNecessidade.DataMember = oDataSet.Tables(0).TableName

            'oGridDisponibilidade.DataSource = oDataSet.DefaultViewManager
            'oGridDisponibilidade.DataMember = oDataSet.Tables(1).TableName

            oGridCargaMaquina.DataSource = oDataSet.DefaultViewManager
            oGridCargaMaquina.DataMember = oDataSet.Tables(2).TableName


            oGridNecessidade.RootTable.HierarchicalMode = HierarchicalMode.SelfReferencing
            oGridNecessidade.RootTable.SelfReferencingSettings.ChildDataMember = "codigo_ordem_producao_pai"
            oGridNecessidade.RootTable.SelfReferencingSettings.ExpandColumn = oGridNecessidade.RootTable.Columns("ordem_producao")
            oGridNecessidade.RootTable.SelfReferencingSettings.ParentDataMember = "codigo"
            oGridNecessidade.RootTable.SelfReferencingSettings.TreatOrphanRowsAsRoot = True
            oGridNecessidade.Hierarchical = True



        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Public Sub LoadGridMaquina(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(16) As SqlParameter
        Dim i As Integer = 0

        Try


            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1


            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_producao_carga_maquina_disponibilidade", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)



            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName



        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridOrcamentoOperacao(ByVal oGrid As GridEX, _
                                         ByVal sOrcamento As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(16) As SqlParameter
        Dim i As Integer = 0

        Try


            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "orcamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sOrcamento : i += 1



            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_producao_carga_maquina_orcamento_operacao", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)


            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
#End Region

End Class
