Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class clsUsrPrdOrdemProducaoTratamentoRejeito

#Region "::: FUNCTION / SUB :::"

#Region "::: ORDEM DE PRODUÇÃO :::"

    Public Sub LoadGridOrdemProducao(ByVal oGrid As GridEX, _
                                     ByVal sOrdemProducao As String, _
                                     ByVal iSequencia As Integer, _
                                     ByVal iCodigoCentroTrabalho As Integer, _
                                     ByVal iCodigoOperacao As Integer, _
                                     ByVal sProduto As String, _
                                     ByVal sDataInicio As String, _
                                     ByVal sDataTermino As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(7) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ordem_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sOrdemProducao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sequencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iSequencia : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_trabalho"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCentroTrabalho : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_operacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoOperacao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sProduto : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataInicio), sDataInicio, DBNull.Value) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataTermino), sDataTermino, DBNull.Value)

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_producao_ordem_producao_tratamento_rejeito", oSqlParameter)

            'Configura DataMember - Grid
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

#End Region

#Region "::: RETRABALHO :::"

#Region "::: DADOS DO RETRABALHO :::"

    Public Sub InsertOrdemProducaoRetrabalho(ByVal lCodigoOrdemProducao As Long, _
                                             ByVal iSequencia As Integer, _
                                             ByVal iCodigoApontamentoRejeito As Integer, _
                                             ByVal dQuantidade As Double, _
                                             ByRef lCodigoOrdemProducaoNovo As Long)

        'Variaveis Locais
        Dim oSqlParameter(6) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Ordem Produção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ordem_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoOrdemProducao : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Sequencia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sequencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iSequencia : i += 1

            'Seta Parametros - Código Apontamento Rejeito
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_apontamento_rejeito"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoApontamentoRejeito : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código Ordem Produção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ordem_producao_novo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_producao_ordem_producao_retrabalho", oSqlParameter)

            'Seta Váriavel
            lCodigoOrdemProducaoNovo = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: ROTEIRO :::"

    Public Sub InsertRoteiroRetrabalho(ByVal lCodigoOrdemProducao As Long, _
                                       ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(14) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In oGrid.GetDataRows

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Ordem Produção
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_ordem_producao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoOrdemProducao : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Sequência
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "sequencia"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("sequencia").Value : i += 1

                'Seta Parametros - Código Centro Trabalho
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_centro_trabalho"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo_centro_trabalho").Value : i += 1

                'Seta Parametros - Código Operação
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_operacao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo_operacao").Value : i += 1

                'Seta Parametros - Sequência Predecessora
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "sequencia_predecessora"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("sequencia_predecessora").Value : i += 1

                'Seta Parametros - Aponta
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "aponta"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Bit
                oSqlParameter(i).Value = oRow.Cells("aponta").Value : i += 1

                'Seta Parametros - Aponta Equipamento
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "aponta_equipamento"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Bit
                oSqlParameter(i).Value = oRow.Cells("aponta_equipamento").Value : i += 1

                'Seta Parametros - Apontamento Concorrente
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "apontamento_concorrente"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Bit
                oSqlParameter(i).Value = oRow.Cells("apontamento_concorrente").Value : i += 1

                'Seta Parametros - Controla Qualidade
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "controla_qualidade"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Bit
                oSqlParameter(i).Value = oRow.Cells("controla_qualidade").Value : i += 1

                'Seta Parametros - Tempo Setup Máquina
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "tempo_setup_maquina"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = ((DatePart(DateInterval.Hour, CDate(oRow.Cells("tempo_setup_maquina").Value)) * 60) + DatePart(DateInterval.Minute, CDate(oRow.Cells("tempo_setup_maquina").Value)) + (DatePart(DateInterval.Second, CDate(oRow.Cells("tempo_setup_maquina").Value)) / 60)) : i += 1

                'Seta Parametros - Tempo Mão Obra
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "tempo_mao_obra"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = IIf(oRow.Cells("referencia_produto").Value = 0, 0, ((DatePart(DateInterval.Hour, CDate(oRow.Cells("tempo_mao_obra").Value)) * 60) + DatePart(DateInterval.Minute, CDate(oRow.Cells("tempo_mao_obra").Value)) + (DatePart(DateInterval.Second, CDate(oRow.Cells("tempo_mao_obra").Value)) / 60)) / oRow.Cells("referencia_produto").Value) : i += 1

                'Seta Parametros - Tempo Máquina
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "tempo_maquina"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = IIf(oRow.Cells("referencia_produto").Value = 0, 0, ((DatePart(DateInterval.Hour, CDate(oRow.Cells("tempo_maquina").Value)) * 60) + DatePart(DateInterval.Minute, CDate(oRow.Cells("tempo_maquina").Value)) + (DatePart(DateInterval.Second, CDate(oRow.Cells("tempo_maquina").Value)) / 60)) / oRow.Cells("referencia_produto").Value) : i += 1

                'Seta Parametros - Referência - Produto
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "referencia_produto"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("referencia_produto").Value : i += 1

                'Seta Parametros - Observação
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "observacao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 5000
                oSqlParameter(i).Value = IIf(oRow.Cells("observacao").Value = "", DBNull.Value, oRow.Cells("observacao").Value)

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_producao_ordem_producao_apontamento_retrabalho", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosOperacao(ByVal iCodigoOperacao As Integer, _
                                 ByRef sCentroTrabalho As String, _
                                 ByRef sDescricaoCentroTrabalho As String, _
                                 ByRef sOperacao As String, _
                                 ByRef sDescricaoOperacao As String)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Operação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoOperacao : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_operacao_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                sOperacao = oSqlDataReader.Item("operacao")
                sDescricaoOperacao = oSqlDataReader.Item("descricao_operacao")
                sCentroTrabalho = oSqlDataReader.Item("centro_trabalho")
                sDescricaoCentroTrabalho = oSqlDataReader.Item("descricao_centro_trabalho")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: QUALIDADE ROTEIRO :::"

    Public Sub InsertQualidadeRoteiroRetrabalho(ByVal lCodigoOrdemProducao As Long, _
                                                ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In oGrid.GetDataRows

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Ordem Produção
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_ordem_producao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoOrdemProducao : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Sequencia
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "sequencia"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("sequencia").Value : i += 1

                'Seta Parametros - Código Caracteristica Inspecionar
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_caracteristica_inspecionar"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo_caracteristica_inspecionar").Value : i += 1

                'Seta Parametros - Valor Nominal
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor_nominal"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("valor_nominal").Value : i += 1

                'Seta Parametros - Valor Minimo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor_minimo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("valor_minimo").Value : i += 1

                'Seta Parametros - Valor Máximo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor_maximo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("valor_maximo").Value : i += 1

                'Seta Parametros - Frequência
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "frequencia"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("frequencia").Value : i += 1

                'Seta Parametros - Observacao
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "observacao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 1000
                oSqlParameter(i).Value = IIf(oRow.Cells("observacao").Value = "", DBNull.Value, oRow.Cells("observacao").Value)

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_producao_ordem_producao_apontamento_qualidade_retrabalho", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

#Region "::: PERDA :::"

    Public Sub InsertApontamentoRejeitoPerda(ByVal lCodigoOrdemProducao As Long, _
                                             ByVal iSequencia As Integer, _
                                             ByVal iSequenciaConcorrente As Integer, _
                                             ByVal iCodigoApontamentoRejeito As Integer, _
                                             ByVal dQuantidade As Double, _
                                             ByVal sObservacao As String)

        'Variaveis Locais
        Dim oSqlParameter(7) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Ordem Produção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ordem_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoOrdemProducao : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Sequencia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sequencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iSequencia : i += 1

            'Seta Parametros - Sequencia Concorrente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sequencia_concorrente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iSequenciaConcorrente : i += 1

            'Seta Parametros - Código Apontamento Rejeito
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_apontamento_rejeito"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoApontamentoRejeito : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            'Seta Parametros - Observação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sObservacao : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_producao_apontamento_rejeito_perda", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: REPOSIÇÃO :::"

    Public Sub InsertOrdemProducaoReposicao(ByVal lCodigoOrdemProducao As Long, _
                                            ByVal iSequencia As Integer, _
                                            ByVal iSequenciaConcorrente As Integer, _
                                            ByVal iCodigoApontamentoRejeito As Integer, _
                                            ByVal dQuantidade As Double, _
                                            ByVal sObservacao As String)

        'Variaveis Locais
        Dim oSqlParameter(7) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Ordem Produção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ordem_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoOrdemProducao : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Sequencia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sequencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iSequencia : i += 1

            'Seta Parametros - Sequencia Concorrente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sequencia_concorrente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iSequenciaConcorrente : i += 1

            'Seta Parametros - Código Apontamento Rejeito
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_apontamento_rejeito"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoApontamentoRejeito : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            'Seta Parametros - Observação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sObservacao : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_producao_ordem_producao_reposicao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class
