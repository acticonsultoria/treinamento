Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.CalendarCombo

Public Class clsUsrPrjProcesso

    Private iCodigo As Integer
    Private sProjeto As String

    Public Property Codigo() As Integer
        Get
            Return iCodigo
        End Get
        Set(ByVal value As Integer)
            iCodigo = value
        End Set
    End Property

    Public Property Projeto() As String
        Get
            Return sProjeto
        End Get
        Set(ByVal value As String)
            sProjeto = value
        End Set
    End Property

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGridListagem As GridEX, _
                        ByVal sPartNumber As String, _
                       ByVal sFase As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(7) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "part_number"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sPartNumber : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fase"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sFase = "", DBNull.Value, sFase) : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_projeto_processo", oSqlParameter)

            With oGridListagem

                'Configura os data members
                ConfigurarDataMemberGrid(oGridListagem)

                Dim oParentColumn(0) As DataColumn
                Dim oChildColumn(0) As DataColumn

                oParentColumn(0) = oDataSet.Tables(0).Columns("codigo_projeto")
                oChildColumn(0) = oDataSet.Tables(1).Columns("codigo_projeto")


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

    Public Function ValidaProjeto(ByVal iCodigo As Integer, _
                                  ByVal lCodigoPedido As Long, _
                                  ByVal iCodigoPedidoItem As Integer) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim iReturn As Integer
        Dim i As Integer = 0

        Try

            'Seta Retorno da Função
            ValidaProjeto = False

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoPedidoItem : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_projeto_processo", oSqlParameter), String)

            'Seta Retorno da Função
            ValidaProjeto = IIf(iReturn > 0, True, False)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub Insert()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.Int : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "projeto"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_projeto_processo", oSqlParameter)

            iCodigo = oSqlParameter(1).Value
            sProjeto = oSqlParameter(2).Value


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update(ByVal iCodigo As Integer, _
                      ByVal lCodigoOrdemProducao As Long, _
                      ByVal sCliente As String, _
                      ByVal sTipoProjeto As String, _
                      ByVal sPO As String, _
                      ByVal sPOLinha As String, _
                      ByVal sRC As String, _
                      ByVal sCodigoCliente As String, _
                      ByVal sPartNumber As String, _
                      ByVal sNS As String, _
                      ByVal sOM As String, _
                      ByVal sAtivoFixo As String, _
                      ByVal sDataProjeto As String, _
                      ByVal sInternoExterno As String, _
                      ByVal iCodigoFuncionario As Integer, _
                      ByVal sDataLiberacaoCliente As String, _
                      ByVal sDataLiberacaoProducao As String, _
                      ByVal sDataEntrega As String, _
                      ByVal sDataConclusaoValidacao As String, _
                      ByVal bInovacao As Boolean, _
                      ByVal sFase As String)

        'Variaveis Locais
        Dim oSqlParameter(25) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Modelo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ordem_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoOrdemProducao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCliente : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_projeto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sTipoProjeto = "", DBNull.Value, sTipoProjeto) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "po"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sPO : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "po_linha"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sPOLinha : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "rc"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sRC : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCodigoCliente : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "part_number"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sPartNumber : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ns"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNS : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "om"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sOM : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo_fixo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sAtivoFixo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_projeto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataProjeto = "", DBNull.Value, sDataProjeto) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "interno_externo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sInternoExterno = "", DBNull.Value, sInternoExterno) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_funcionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoFuncionario = -1, DBNull.Value, iCodigoFuncionario) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_liberacao_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataLiberacaoCliente = "", DBNull.Value, sDataLiberacaoCliente) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_liberacao_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataLiberacaoProducao = "", DBNull.Value, sDataLiberacaoProducao) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_entrega"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataEntrega = "", DBNull.Value, sDataEntrega) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_conclusao_validacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataConclusaoValidacao = "", DBNull.Value, sDataConclusaoValidacao) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inovacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bInovacao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fase"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sFase = "", DBNull.Value, sFase) : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_projeto_processo", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Delete()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_projeto_processo", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridEtapa(ByVal oGrid As GridEX, _
                             ByVal iCodigoProjeto As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_projeto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoProjeto : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_projeto_processo_etapa", oSqlParameter)

            'Configura DataMember Grid
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

    Public Sub InsertEtapa(ByVal iCodigoProjeto As Integer,
                           ByVal sEtapa As String,
                           ByVal sDataPrevisao As String,
                           ByVal sDataInicio As String,
                           ByVal sDataTermino As String,
                           ByVal sDataResposta As String,
                           ByVal sObservacao As String)

        'Variaveis Locais
        Dim oSqlParameter(7) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_projeto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoProjeto : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "etapa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sEtapa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_previsao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = sDataPrevisao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = sDataInicio : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = sDataTermino : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_resposta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = sDataResposta : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sObservacao : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_projeto_processo_etapa", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateEtapa(ByVal iCodigo As Integer, _
                           ByVal iCodigoProjeto As Integer, _
                           ByVal sEtapa As String, _
                           ByVal sDataInicioPlanejado As String, _
                           ByVal sDataTerminoPlanejado As String, _
                           ByVal sDataInicioReal As String, _
                           ByVal sDataTerminoReal As String)

        'Variaveis Locais
        Dim oSqlParameter(7) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_projeto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoProjeto : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "etapa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sEtapa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio_planejado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = sDataInicioPlanejado : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino_planejado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = sDataTerminoPlanejado : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio_real"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataInicioReal = "", DBNull.Value, sDataInicioReal) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino_real"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataTerminoReal = "", DBNull.Value, sDataTerminoReal) : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_projeto_processo_etapa", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteEtapa(ByVal iCodigoProjeto As Integer)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Pedido
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Código Pedido Item
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_projeto"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigoProjeto : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_projeto_processo_etapa", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub AtualizaDataEtapa(ByVal iCodigoProjeto As Integer, _
                                ByVal oRow As GridEXRow)

        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_projeto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoProjeto : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = oRow.Cells.Item("data_inicio").Value : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = oRow.Cells.Item("data_termino").Value : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_previsao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = oRow.Cells.Item("data_previsao").Value : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_resposta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = oRow.Cells.Item("data_resposta").Value : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = oRow.Cells.Item("observacao").Value : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = oRow.Cells.Item("codigo").Value : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_projeto_processo_etapa_data", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub AtualizaDataEtapaLote(ByVal iCodigoProjeto As Integer, _
                                     ByVal iCodigoEtapa As Integer, _
                                     ByVal bDataExecucao As Boolean, _
                                     ByVal sDataExecucao As String, _
                                     ByVal bDataPrevisao As Boolean, _
                                     ByVal sDataPrevisao As String, _
                                     ByVal bDataResposta As Boolean, _
                                     ByVal sDataResposta As String, _
                                     ByVal bObservacao As Boolean, _
                                     ByVal sObservacao As String)

        'Variaveis Locais
        Dim oSqlParameter(12) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_projeto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoProjeto : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_execucao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataExecucao = "", DBNull.Value, sDataExecucao) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_previsao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataPrevisao = "", DBNull.Value, sDataPrevisao) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_resposta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataResposta = "", DBNull.Value, sDataResposta) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sObservacao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "atualiza_observacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bObservacao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "atualiza_data_execucao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bDataExecucao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "atualiza_data_previsao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bDataPrevisao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "atualiza_data_resposta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bDataResposta : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_etapa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoEtapa : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_projeto_processo_etapa_data_lote", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub CancelaEtapa(ByVal iCodigoProjeto As Integer, _
                            ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_projeto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoProjeto : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_projeto_processo_etapa_cancelar", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosProduto(ByVal iCodigoPedido As Long, _
                                ByVal iCodigoPedidoItem As Integer, _
                                ByVal txtDescricao As MaskedEditBox, _
                                ByVal txtQuantidadeItem As NumericEditBox, _
                                ByVal txtUnidadeMedida As MaskedEditBox, _
                                ByVal txtTerceirosPlanta As MaskedEditBox, _
                                ByVal txtTerceirosPO As MaskedEditBox, _
                                ByVal txtTerceirosPOLinha As MaskedEditBox, _
                                ByVal txtTerceirosRef As MaskedEditBox, _
                                ByVal txtTerceirosCemb As MaskedEditBox, _
                                ByVal txtTerceirosAtivoFixo As MaskedEditBox, _
                                ByVal txtTerceirosNS As MaskedEditBox, _
                                ByVal txtTerceirosRC As MaskedEditBox, _
                                ByVal txtTerceirosOM As MaskedEditBox, _
                                ByVal txtTerceirosEspecificador As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoPedido : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoPedidoItem : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_pedido_item_dados_projeto", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    txtDescricao.Text = oSqlDataReader.Item("descricao")
                    txtQuantidadeItem.Value = oSqlDataReader.Item("quantidade")
                    txtUnidadeMedida.Text = oSqlDataReader.Item("unidade_medida")
                    txtTerceirosPlanta.Text = oSqlDataReader.Item("planta")
                    txtTerceirosPO.Text = oSqlDataReader.Item("po")
                    txtTerceirosPOLinha.Text = oSqlDataReader.Item("po_linha")
                    txtTerceirosRef.Text = oSqlDataReader.Item("ref")
                    txtTerceirosCemb.Text = oSqlDataReader.Item("cemb")
                    txtTerceirosAtivoFixo.Text = oSqlDataReader.Item("ativo_fixo")
                    txtTerceirosNS.Text = oSqlDataReader.Item("ns")
                    txtTerceirosRC.Text = oSqlDataReader.Item("rc")
                    txtTerceirosOM.Text = oSqlDataReader.Item("om")
                    txtTerceirosEspecificador.Text = oSqlDataReader.Item("especificador")

                End While

            End If

            'Fecha o DataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDados(ByVal iCodigo As Integer, _
                         ByVal cboOrdemProducao As UIComboBox, _
                      ByVal txtCliente As MaskedEditBox, _
                      ByVal cboTipoProjeto As UIComboBox, _
                      ByVal txtPO As MaskedEditBox, _
                      ByVal txtPOLinha As MaskedEditBox, _
                      ByVal txtRC As MaskedEditBox, _
                      ByVal txtCodigoCliente As MaskedEditBox, _
                      ByVal txtPartNumber As MaskedEditBox, _
                      ByVal txtNS As MaskedEditBox, _
                      ByVal txtOM As MaskedEditBox, _
                      ByVal txtAtivoFixo As MaskedEditBox, _
                      ByVal dtpDataProjeto As CalendarCombo, _
                      ByVal cboInternoExterno As UIComboBox, _
                      ByVal cboCodigoFuncionario As UIComboBox, _
                      ByVal dtpDataLiberacaoCliente As CalendarCombo, _
                      ByVal dtpDataLiberacaoProducao As CalendarCombo, _
                      ByVal dtpDataEntrega As CalendarCombo, _
                      ByVal dtpDataConclusaoValidacao As CalendarCombo, _
                      ByVal chkInovacao As UICheckBox, _
                      ByVal cboFase As UIComboBox)


        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_projeto_processo_dados", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    If Not IsDBNull(oSqlDataReader.Item("codigo_ordem_producao")) Then cboOrdemProducao.SelectedValue = oSqlDataReader.Item("codigo_ordem_producao")

                    txtCliente.Text = oSqlDataReader.Item("cliente")
                    If Not IsDBNull(oSqlDataReader.Item("codigo_tipo_projeto")) Then cboTipoProjeto.SelectedValue = oSqlDataReader.Item("codigo_tipo_projeto")
                    txtPO.Text = oSqlDataReader.Item("po")
                    txtPOLinha.Text = oSqlDataReader.Item("po_linha")
                    txtRC.Text = oSqlDataReader.Item("rc")
                    txtCodigoCliente.Text = oSqlDataReader.Item("codigo_cliente")
                    txtPartNumber.Text = oSqlDataReader.Item("part_number")
                    txtNS.Text = oSqlDataReader.Item("ns")
                    txtOM.Text = oSqlDataReader.Item("om")
                    txtAtivoFixo.Text = oSqlDataReader.Item("ativo_fixo")
                    If Not IsDBNull(oSqlDataReader.Item("data_projeto")) Then
                        dtpDataProjeto.Value = oSqlDataReader.Item("data_projeto")
                        dtpDataProjeto.Checked = True
                    End If

                    If Not IsDBNull(oSqlDataReader.Item("interno_externo")) Then
                        cboInternoExterno.SelectedValue = oSqlDataReader.Item("interno_externo")
                    End If

                    If Not IsDBNull(oSqlDataReader.Item("codigo_funcionario")) Then
                        cboCodigoFuncionario.SelectedValue = oSqlDataReader.Item("codigo_funcionario")
                    End If
                    If Not IsDBNull(oSqlDataReader.Item("data_liberacao_cliente")) Then
                        dtpDataLiberacaoCliente.Value = oSqlDataReader.Item("data_liberacao_cliente")
                        dtpDataLiberacaoCliente.Checked = True
                    End If
                    If Not IsDBNull(oSqlDataReader.Item("data_liberacao_producao")) Then
                        dtpDataLiberacaoProducao.Value = oSqlDataReader.Item("data_liberacao_producao")
                        dtpDataLiberacaoProducao.Checked = True
                    End If
                    If Not IsDBNull(oSqlDataReader.Item("data_entrega")) Then
                        dtpDataEntrega.Value = oSqlDataReader.Item("data_entrega")
                        dtpDataEntrega.Checked = True
                    End If
                    If Not IsDBNull(oSqlDataReader.Item("data_conclusao_validacao")) Then
                        dtpDataConclusaoValidacao.Value = oSqlDataReader.Item("data_conclusao_validacao")
                        dtpDataConclusaoValidacao.Checked = True
                    End If
                    chkInovacao.Checked = oSqlDataReader.Item("inovacao")

                    If Not IsDBNull(oSqlDataReader.Item("fase")) Then
                        cboFase.SelectedValue = oSqlDataReader.Item("fase")
                    End If

                End While

            End If

            'Fecha o DataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
