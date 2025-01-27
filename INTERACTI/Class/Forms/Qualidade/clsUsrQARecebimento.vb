Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class clsUsrQARecebimento

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private iCodigo As Integer


#End Region

#Region "::: PROPERTIE :::"

    Public Property Codigo() As Integer
        Get
            Return iCodigo
        End Get
        Set(ByVal value As Integer)
            iCodigo = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: NOTA FISCAL :::"

    Public Sub LoadGridNotaFiscal(ByVal oGrid As GridEX, _
                                  ByVal sNumeroDocumento As String, _
                                  ByVal sSerie As String, _
                                  ByVal sEmitente As String, _
                                  ByVal sDataEmissaoInicio As String, _
                                  ByVal sDataEmissaoTermino As String, _
                                  ByVal sProduto As String, _
                                  ByVal sTipoDocumento As String)

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
            oSqlParameter(i).ParameterName = "numero_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNumeroDocumento : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "serie"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 3
            oSqlParameter(i).Value = sSerie : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "emitente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sEmitente : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataEmissaoInicio), sDataEmissaoInicio, DBNull.Value) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataEmissaoTermino), sDataEmissaoTermino, DBNull.Value) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sProduto : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sTipoDocumento

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_qualidade_inspecao_produto", oSqlParameter)

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

#Region "::: QUALIDADE :::"
    Public Sub InsertVerificacao(ByVal iCodigoRecebimento As Integer, _
                                    ByVal dQuantidade As Double, _
                                    ByVal sNumeroSerie As String, _
                                    ByVal sControleVisual As String, _
                                    ByVal bConforme As Boolean, _
                                    ByVal sMaterial As String, _
                                    ByVal dPesoMedido As Double, _
                                    ByVal dPesoTeorico As Double, _
                                    ByVal dLarguraMedida As Double, _
                                    ByVal dLarguraTeorica As Double, _
                                    ByVal dComprimentoMedido As Double, _
                                    ByVal dComprimentoTeorico As Double, _
                                    ByVal iCodigoItem As Integer, _
                                    ByVal iCodigoItemNota As Integer)

        'Variaveis Locais
        Dim oSqlParameter(22) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_qld_recebimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoRecebimento : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoItem : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_serie"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sNumeroSerie : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "controle_visual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sControleVisual : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "conforme"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bConforme : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "material"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sMaterial : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "peso_medido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPesoMedido : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "peso_teorico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPesoTeorico : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "largura_medida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dLarguraMedida : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "largura_teorica"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dLarguraTeorica : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "comprimento_medido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dComprimentoMedido : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "comprimento_teorico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dComprimentoTeorico : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_nota"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = iCodigoItemNota : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_qualidade_recebimento_produto_verificacao", oSqlParameter)



        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertQuestionario(ByVal iCodigoRecebimento As Integer, _
                                   ByVal iCodigoQuestionario As Integer, _
                                   ByVal sResposta As String, _
                                   ByVal bNaoAplicavel As Boolean)

        'Variaveis Locais
        Dim oSqlParameter(21) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_qld_recebimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoRecebimento : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_questionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoQuestionario : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "resposta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sResposta : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nao_aplicavel"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bNaoAplicavel : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_qualidade_recebimento_produto_questionario", oSqlParameter)



        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update(ByVal iCodigoRecebimento As Integer, _
                                  ByVal sOrdemProducao As String, _
                                  ByVal iCodigoCondicao As Integer, _
                                  ByVal iCodigoUsuarioVerificacao As Integer, _
                                  ByVal dDataVerificacao As String, _
                                  ByVal sObservacao As String, _
                                  ByVal sPedidoCompra As String, _
                                  ByVal sContrato As String, _
                                  ByVal iCodigoCondicaoRecebimento As Integer, _
                                  ByVal iNumeroRecebimento As Integer)

        'Variaveis Locais
        Dim oSqlParameter(11) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_qld_recebimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoRecebimento : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ordem_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sOrdemProducao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario_verificacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoUsuarioVerificacao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_verificacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = dDataVerificacao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sObservacao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pedido_compra"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sPedidoCompra : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "contrato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sContrato : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_condicao_recebimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCondicaoRecebimento : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_recebimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iNumeroRecebimento : i += 1

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_qualidade_recebimento", oSqlParameter)



        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteQuestionario(ByVal iCodigoRecebimento As Integer)

        'Variaveis Locais
        Dim oSqlParameter(11) As SqlParameter
        Dim i As Integer = 0

        Try


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_qld_recebimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoRecebimento : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_qualidade_recebimento_produto_questionario", oSqlParameter)



        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sTipo As String, _
                        ByVal dDataInicio As String, _
                        ByVal dDataFim As String, _
                        ByVal sNotaFiscal As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(20) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sTipo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(dDataInicio = "", DBNull.Value, dDataInicio) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_fim"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(dDataFim = "", DBNull.Value, dDataFim) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNotaFiscal : i += 1


            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_qualidade_recebimento", oSqlParameter)

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

    Public Sub LoadGridQuestionario(ByVal oGrid As GridEX, _
                                        ByVal sTipoRecebimento As String, _
                                        ByVal iCodigoRecebimento As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo_recebimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sTipoRecebimento : i = i + 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recebimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(iCodigoRecebimento = -1, DBNull.Value, iCodigoRecebimento)

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_qualidade_questionario", oSqlParameter)

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

    Public Sub DeleteVerificacao(ByVal iCodigoRecebimento As Integer)

        'Variaveis Locais
        Dim oSqlParameter(11) As SqlParameter
        Dim i As Integer = 0

        Try


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_qld_recebimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoRecebimento : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_qualidade_recebimento_produto_verificacao", oSqlParameter)



        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
   
    Public Sub LoadGridVerificacao(ByVal oGrid As GridEX, _
                                    ByVal sTipoDocumento As String, _
                                    ByVal iCodigoNF As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sTipoDocumento : i = i + 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = iCodigoNF : i = i + 1

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_qualidade_verificacao", oSqlParameter)

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

    Public Sub Insert(ByVal iCodigoUsuarioInspecao As Integer, _
                      ByVal dData As Date, _
                      ByVal sTipo As String, _
                      ByVal iCodigoNF As Integer, _
                      ByVal sTipoDocumento As String, _
                      ByVal iNumeroRecebimento As Integer)

        'Variaveis Locais
        Dim oSqlParameter(11) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario_inspecao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoUsuarioInspecao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = dData : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoNF : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_recebimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iNumeroRecebimento : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sTipo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sTipoDocumento : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_qualidade_recebimento", oSqlParameter)

            iCodigo = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosNF(ByVal sTipoDocumento As String, _
                            ByVal iCodigoNF As Integer, _
                            ByVal txtFornecedor As MaskedEditBox, _
                            ByVal txtTransportadora As MaskedEditBox, _
                            ByVal txtQuantidade As NumericEditBox, _
                            ByVal txtPedidoCompra As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Orçamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código de Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sTipoDocumento : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoNF

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_qualidade_nf_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                txtFornecedor.Text = oSqlDataReader.Item("fornecedor")
                txtTransportadora.Text = oSqlDataReader.Item("transportadora")
                txtQuantidade.Value = oSqlDataReader.Item("quantidade")
                txtPedidoCompra.Text = oSqlDataReader.Item("numero_pedido")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadNovoNumeroRecebimento(ByVal sTipoRecebimento As String, _
                                         ByVal txtNumeroRecebimento As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Orçamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código de Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo_recebimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sTipoRecebimento : i += 1

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_qualidade_recebimento_novo_numero", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                If sTipoRecebimento = "MERCADORIA" Then
                    txtNumeroRecebimento.Text = "CR" & CStr(oSqlDataReader.Item("numero_recebimento"))
                End If
                If sTipoRecebimento = "MATÉRIA-PRIMA" Then
                    txtNumeroRecebimento.Text = "RMP" & CStr(oSqlDataReader.Item("numero_recebimento"))
                End If
                If sTipoRecebimento = "PEÇAS INTERMEDIÁRIAS" Then
                    txtNumeroRecebimento.Text = "RPI" & CStr(oSqlDataReader.Item("numero_recebimento"))
                End If
                txtNumeroRecebimento.Tag = oSqlDataReader.Item("numero_recebimento")
            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Public Sub DeleteCapa(ByVal iCodigoRecebimento As Integer)

        'Variaveis Locais
        Dim oSqlParameter(11) As SqlParameter
        Dim i As Integer = 0

        Try


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoRecebimento : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_qualidade_recebimento", oSqlParameter)



        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
#End Region

#End Region

End Class
