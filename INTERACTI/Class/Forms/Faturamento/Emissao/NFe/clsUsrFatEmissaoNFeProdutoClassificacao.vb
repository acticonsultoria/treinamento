Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls

Public Class clsUsrFatEmissaoNFeProdutoClassificacao

#Region ":::: VARIAVEIS ::::"
    Private lCodigoEmissaoCapa As Long
    Private iCodigoEmissaoItem As Integer
    Private iCodigoDeposito As Integer
    Private dQuantidadeNotaFiscal As Double
    Private dQuantidadeEstoque As Double
    Private dQuantidade As Integer
    Private iFatorConversao As Integer
    Private sLote As String
    Private iCodigo As Integer
    Private oGrid As GridEX
    Private iCodigoProduto As Integer
    Private sDestinatario As String
    Private sDataEmissaoInicio As String
    Private sDataEmissaoTermino As String
    Private lNotaFiscal As Long
    Private iNovoCodigoProduto As Integer
    Private sNovoProduto As String
#End Region

#Region ":::: PROPERTY ::::"
    Public Property NotaFiscal() As Long
        Get
            Return lNotaFiscal
        End Get
        Set(ByVal value As Long)
            lNotaFiscal = value
        End Set
    End Property

    Public Property CodigoEmissaoCapa() As Long
        Get
            Return lCodigoEmissaoCapa
        End Get
        Set(ByVal value As Long)
            lCodigoEmissaoCapa = value
        End Set
    End Property

    Public Property CodigoEmissaoItem() As Integer
        Get
            Return iCodigoEmissaoItem
        End Get
        Set(ByVal value As Integer)
            iCodigoEmissaoItem = value
        End Set
    End Property

    Public Property NovoCodigoProduto() As Integer
        Get
            Return NovoCodigoProduto
        End Get
        Set(ByVal value As Integer)
            NovoCodigoProduto = value
        End Set
    End Property

    Public Property NovoProduto() As String
        Get
            Return NovoProduto
        End Get
        Set(ByVal value As String)
            NovoProduto = value
        End Set
    End Property

    Public Property CodigoDeposito() As Integer
        Get
            Return iCodigoDeposito
        End Get
        Set(ByVal value As Integer)
            iCodigoDeposito = value
        End Set
    End Property

    Public Property QuantidadeNotaFiscal() As Double
        Get
            Return dQuantidadeNotaFiscal
        End Get
        Set(ByVal value As Double)
            dQuantidadeNotaFiscal = value
        End Set
    End Property

    Public Property QuantidadeEstoque() As Double
        Get
            Return dQuantidadeEstoque
        End Get
        Set(ByVal value As Double)
            dQuantidadeEstoque = value
        End Set
    End Property

    Public Property Quantidade() As Double
        Get
            Return dQuantidade
        End Get
        Set(ByVal value As Double)
            dQuantidade = value
        End Set
    End Property

    Public Property FatorConversao() As Integer
        Get
            Return iFatorConversao
        End Get
        Set(ByVal value As Integer)
            iFatorConversao = value
        End Set
    End Property

    Public Property Lote() As String
        Get
            Return sLote
        End Get
        Set(ByVal value As String)
            sLote = value
        End Set
    End Property

    Public Property Codigo() As Integer
        Get
            Return iCodigo
        End Get
        Set(ByVal value As Integer)
            iCodigo = value
        End Set
    End Property

    Public Property CodigoProduto() As Integer
        Get
            Return iCodigoProduto
        End Get
        Set(ByVal value As Integer)
            iCodigoProduto = value
        End Set
    End Property

    Public Property Destinatario() As String
        Get
            Return sDestinatario
        End Get
        Set(ByVal value As String)
            sDestinatario = value
        End Set
    End Property

    Public Property DataEmissaoInicio() As String
        Get
            Return sDataEmissaoInicio
        End Get
        Set(ByVal value As String)
            sDataEmissaoInicio = value
        End Set
    End Property

    Public Property DataEmissaoTermino As String
        Get
            Return sDataEmissaoTermino
        End Get
        Set(ByVal value As String)
            sDataEmissaoTermino = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal iCodigoProduto As Integer, _
                        ByVal sDestinatario As String, _
                        ByVal lNotaFiscal As Long, _
                        ByVal sDataEmissaoTermino As String, _
                        ByVal sDataEmissaoInicio As String, _
                        ByVal sUnidadeMedida As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try
            'Seta Parametros - Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoProduto : i += 1

            'Seta Parametros - Destinatario
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "destinatario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDestinatario : i += 1

            'Seta Parametros - Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lNotaFiscal : i += 1

            'Seta Parametros - Data de Emissão - Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataEmissaoInicio = "", DBNull.Value, sDataEmissaoInicio) : i += 1

            'Seta Parametros - Data de Emissão - Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataEmissaoTermino = "", DBNull.Value, sDataEmissaoTermino) : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_nfe_item_classificacao", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridLote(ByVal oGrid As GridEX, _
                        ByVal lCodigoEmissaoCapa As Long, _
                        ByVal iCodigoEmissaoItem As Integer)


        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim oDataSet As DataSet
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Emissão Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoEmissaoItem

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_nfe_item_lote", oSqlParameter)

            Call ConfigurarDataMemberGrid(oGrid)
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Insert(ByVal lCodigoEmissaoCapa As Long, _
                  ByVal iCodigoEmissaoItem As Integer, _
                  ByVal iCodigoDeposito As Integer, _
                  ByVal dQuantidadeEstoque As Double, _
                  ByVal sLote As String, _
                  ByVal iCodigoUnidadeMedida As Integer, _
                  ByVal iCodigoProduto As Integer, _
                  ByVal sProduto As String)

        'Variaveis Locais
        Dim oSqlParameter(16) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissao Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Emissão Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoEmissaoItem : i += 1

            'Seta Parametros - Código Depósito
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_deposito"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoDeposito : i += 1

            'Seta Parametros - Quantidade Estoque
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidadeEstoque : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_estoque"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidadeEstoque : i += 1

            'Seta Parametros - Lote
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "lote"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = IIf(sLote = "", DBNull.Value, sLote) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoProduto : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sProduto : i += 1

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_nfe_item_lote", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update(ByVal lCodigoEmissaoCapa As Long, _
                     ByVal iCodigoEmissaoItem As Integer, _
                     ByVal iCodigoDeposito As Integer, _
                     ByVal dQuantidadeEstoque As Double, _
                     ByVal sLote As String, _
                     ByVal iCodigo As Integer, _
                     ByVal iCodigoUnidadeMedida As Integer, _
                     ByVal iCodigoProduto As Integer, _
                     ByVal sProduto As String)

        'Variaveis Locais
        Dim oSqlParameter(17) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissao Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Emissão Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoEmissaoItem : i += 1

            'Seta Parametros - Código Depósito
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_deposito"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoDeposito : i += 1

            'Seta Parametros - Quantidade Estoque
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidadeEstoque : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_estoque"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidadeEstoque : i += 1

            'Seta Parametros - Lote
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "lote"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = IIf(sLote = "", DBNull.Value, sLote) : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoProduto : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sProduto : i += 1

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_nfe_item_lote", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Delete(ByVal lCodigoEmissaoCapa As Long, _
                     ByVal iCodigoEmissaoItem As Integer)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Emissao Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Código Emissão Item
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_item"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = iCodigoEmissaoItem : i += 1

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_nfe_item_lote", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub SalvarLote(ByVal lCodigoEmissaoCapa As Long)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissao Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_integracao_emissao_nota_fiscal_estoque", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
