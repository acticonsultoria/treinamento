Imports System.Data
Imports System.Data.SqlClient
Imports Interacti.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls
Imports Dundas.Charting.WinControl

Public Class clsUsrPrdApontamentoServico

#Region "::: FUNCTION / SUB :::"
     
    Public Sub LoadDadosApontamento(ByVal iCodigoTipoApontamento As Integer, _
                                    ByVal lCodigoOrdemServico As Long, _
                                    ByVal iSequencia As Integer, _
                                    ByVal sProntuarioFuncionario As String, _
                                    ByRef iCodigoFuncionario As Integer, _
                                    ByRef iCodigoApontamentoFuncionario As Integer, _
                                    ByRef iTipoApontamentoConcorrente As TipoApontamentoConcorrente, _
                                    ByRef dQuantidade As Double)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Tipo Apontamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_apontamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoApontamento : i += 1

            'Seta Parametros - Ordem de Servico
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ordem_servico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoOrdemServico : i += 1

            'Seta Parametros - Sequência
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sequencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iSequencia : i += 1

            'Seta Parametros - Código Funcionário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "prontuario_funcionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sProntuarioFuncionario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_producao_apontamento_servico_dados", oSqlParameter)

            While oSqlDataReader.Read

                iCodigoFuncionario = oSqlDataReader.Item("codigo_funcionario")
                iCodigoApontamentoFuncionario = oSqlDataReader.Item("codigo_apontamento_funcionario")
                iTipoApontamentoConcorrente = oSqlDataReader.Item("tipo_apontamento_concorrente")
                dQuantidade = oSqlDataReader.Item("quantidade")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosOrdemServico(ByVal lCodigoOrdemServico As Long, _
                                      ByVal iSequencia As Integer, _
                                      ByRef sOrdemServico As String, _
                                      ByRef sProduto As String)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Ordem de Servico
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ordem_servico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoOrdemServico : i += 1

            'Seta Parametros - Sequência
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sequencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iSequencia : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_producao_ordem_servico_apontamento_dados", oSqlParameter)

            While oSqlDataReader.Read

                sOrdemServico = oSqlDataReader.Item("ordem_servico")
                sProduto = oSqlDataReader.Item("codigo_produto")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridApontamento(ByVal oGrid As GridEX, _
                                   ByVal lCodigoOrdemServico As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Ordem de Servico
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ordem_servico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoOrdemServico : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_producao_ordem_servico_apontamento", oSqlParameter)

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
     
    Public Sub UpdateApontamento(ByVal iCodigoTipoApontamento As Integer, _
                                 ByVal lCodigoOrdemServico As Long, _
                                 ByVal iSequencia As Integer, _
                                 ByVal iCodigoApontamentoFuncionario As Integer, _
                                 ByVal iCodigoFuncionario As Integer, _
                                 ByVal dQuantidade As Double, _
                                 ByVal dDataInicio As DateTime, _
                                 ByVal dDataTermino As DateTime)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Tipo Apontamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_apontamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoApontamento : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Ordem de Servico
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ordem_servico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoOrdemServico : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Sequência
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sequencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iSequencia : i += 1 : ReDim Preserve oSqlParameter(i)


            'Seta Parametros - Código Apontamento Funcionário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dDataInicio : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dDataTermino : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_funcionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoFuncionario = -1, DBNull.Value, iCodigoFuncionario) : i += 1 : ReDim Preserve oSqlParameter(i)


            'Seta Parametros - Quantidade Abertura
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dQuantidade = -1, DBNull.Value, dQuantidade) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_producao_apontamento_servico", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ExcluirApontamento(ByVal lCodigoOrdemServico As Long, _
                               ByVal iSequencia As Integer, _
                               ByVal iCodigoApontamentoFuncionario As Integer)

        'Variaveis Locais
        Dim oSqlParameter(19) As SqlParameter
        Dim i As Integer = 0

        Try


            'Seta Parametros - Código Ordem de Servico
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ordem_servico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoOrdemServico : i += 1

            'Seta Parametros - Sequência
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sequencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iSequencia : i += 1

            'Seta Parametros - Código Apontamento Parada
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoApontamentoFuncionario : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_producao_apontamento_servico", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
        
#End Region

End Class
