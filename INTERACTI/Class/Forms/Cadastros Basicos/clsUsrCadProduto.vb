Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports System.IO
Imports System.Drawing.Imaging
Imports Dundas.Charting

Public Class clsUsrCadProduto

#Region "::: VARIAVEIS :::"

#Region "::: DADOS GERAIS :::"

    Private iTipoItem As Integer
    Private iGrupoItem As Integer
    Private iCodigoTipoMaterial As Integer
    Private iCodigoAcabamento As Integer
    Private iCodigoFormato As Integer
    Private sCodigoItem As String
    Private sCodigoItem2 As String
    Private sCodigoBarras As String
    Private bAtivo As Boolean
    Private sDescricao As String
    Private iCodigoMarca As Integer
    Private sMarca As String
    Private sDescricao2 As String
    Private sReferencia As String
    Private sRegistroAnvisa As String
    Private bEstoque As Boolean
    Private bCompra As Boolean
    Private bVenda As Boolean
    Private bAtivoFixo As Boolean
    Private bProducao As Boolean
    Private iCodigoNCM As Integer
    Private bInsumoProducao As Boolean
    Private dPesoLiquido As Double
    Private iCodigoOrigemItem As Integer
    Private iCodigoCor As Integer = -1
    Private iCodigoVolume As Integer = -1
    Private iCodigoTipoAlca As Integer = -1
    Private iCodigoPlanoControle As Integer = -1
    Private iCodigoFolhaOperacao As Integer = -1
    Private iCodigoEspecificacaoTecnica As Integer = -1
    Private iQuantidadeLinhasCertificado As Integer = -1
    Private sObservacao As String
    Private sCor As String
    Private dBitola As Double
    Private iCodigoIntegracao As Integer
    Private sTipoVenda As String
    Private lCodigoProduto As Long
    Private dValor As Double
    Private iCodigoTipoItemSped As Integer
    Private iCodigoNivelInspecao As Integer
    Private dEstoqueMinimoUsoConsumo As Double
    Private iCodigoUnidadeMedidaUsoConsumo As Integer

    'Foto
    Private picFoto As PictureBox

#End Region

#Region "::: DADOS DE VENDA :::"

    Private iCodigoUnidadeMedidaVenda As Integer
    Private dFatorConversaoUnidadeMedidaVenda As Double
    Private iFormaVenda As Integer
    Private iCodigoGrupoItemVenda As Integer

#End Region

#Region "::: DADOS DE COMPRA :::"

    Private iCodigoUnidadeMedidaCompra As Integer
    Private dFatorConversaoUnidadeMedidaCompra As Double
    Private iLeadTime As Integer
    Private bNecessitaFornecedorHomologado As Boolean
    Private dQuantidadeMinima As Double
    Private dMultiploCompra As Double
    
#End Region

#Region "::: DADOS DO RECEBIMENTO :::"

    Private dToleranciaQuantidadeRecebimento As Double
    Private dToleranciaValorRecebimento As Double
    Private iToleranciaDiasRecebimento As Integer

#End Region

#Region "::: DADOS DE ESTOQUE :::"

    Private iCodigoUnidadeMedidaEstoque As Integer
    Private dEstoqueMinimo As Double
    Private dEstoqueMaximo As Double
    Private iCodigoMetodologiaSaidaProdutoEstoque As Integer
    Private bControlaQualidade As Boolean
    Private bControlaLote As Boolean
    Private bGeraLoteInterno As Boolean
    Private sCaracterLote As String
    Private bControlaValidade As Boolean
    Private bControlaDataFabricacao As Boolean
    Private bControlaTempoMaximoExposicao As Boolean
    Private dTempoMaximoExposicao As Double

#End Region

#Region "::: DADOS DE ATIVO FIXO :::"

    Private dPercentualDesvalorizacao As Double
    Private iFrequenciaDesvalorizacaoDia As Integer
    Private iCodigoTipoAtivoFixo As Integer
    Private dVidaUtilBem As Double
    Private dTaxaDepreciacaoAnual As Double
    Private dTaxaDepreciacaoMensal As Double
    Private dValorBem As Double
    Private dValorImpostosRecuperaveis As Double
    Private dValorResidual As Double
    Private dValorDepreciavel As Double
    Private dValorDepreciacaoAnual As Double
    Private dValorDepreciacaoMensal As Double
    Private sControlePatrimonial As String

#End Region

#Region "::: DADOS DAS DIMENSÕES :::"

    Private iCodigoTipoPerfil As Integer
    Private iCodigoMaterial As Integer
    Private dMedida1 As Double
    Private dMedida2 As Double
    Private dMedida3 As Double
    Private dMedida4 As Double
    Private iCodigoUnidadeMedidaDimensao As Integer

#End Region

#End Region

#Region "::: PROPERTIE :::"

#Region "::: DADOS GERAIS :::"

    Public Property CodigoUnidadeMedidaUsoConsumo() As Integer
        Get
            Return iCodigoUnidadeMedidaUsoConsumo
        End Get
        Set(ByVal value As Integer)
            iCodigoUnidadeMedidaUsoConsumo = value
        End Set
    End Property

    Public Property EstoqueMinimoUsoConsumo() As Double
        Get
            Return dEstoqueMinimoUsoConsumo
        End Get
        Set(ByVal value As Double)
            dEstoqueMinimoUsoConsumo = value
        End Set
    End Property

    Public Property Valor() As Double
        Get
            Return dValor
        End Get
        Set(ByVal value As Double)
            dValor = value
        End Set
    End Property
    Public Property TipoItem() As Integer
        Get
            Return iTipoItem
        End Get
        Set(ByVal value As Integer)
            iTipoItem = value
        End Set
    End Property

    Public Property GrupoItem() As Integer
        Get
            Return iGrupoItem
        End Get
        Set(ByVal value As Integer)
            iGrupoItem = value
        End Set
    End Property

    Public Property CodigoTipoMaterial As Integer
        Get
            Return iCodigoTipoMaterial
        End Get
        Set(ByVal value As Integer)
            iCodigoTipoMaterial = value
        End Set
    End Property
    Public Property CodigoAcabamento As Integer
        Get
            Return iCodigoAcabamento
        End Get
        Set(ByVal value As Integer)
            iCodigoAcabamento = value
        End Set
    End Property
    Public Property CodigoFormato As Integer
        Get
            Return iCodigoFormato
        End Get
        Set(ByVal value As Integer)
            iCodigoFormato = value
        End Set
    End Property

    Public Property CodigoItem() As String
        Get
            Return sCodigoItem
        End Get
        Set(ByVal value As String)
            sCodigoItem = value
        End Set
    End Property

    Public Property CodigoItem2() As String
        Get
            Return sCodigoItem2
        End Get
        Set(ByVal value As String)
            sCodigoItem2 = value
        End Set
    End Property

    Public Property CodigoBarras() As String
        Get
            Return sCodigoBarras
        End Get
        Set(ByVal value As String)
            sCodigoBarras = value
        End Set
    End Property

    Public Property Ativo() As Boolean
        Get
            Return bAtivo
        End Get
        Set(ByVal value As Boolean)
            bAtivo = value
        End Set
    End Property

    Public Property Descricao() As String
        Get
            Return sDescricao
        End Get
        Set(ByVal value As String)
            sDescricao = value
        End Set
    End Property

    Public Property CodigoMarca() As Integer
        Get
            Return iCodigoMarca
        End Get
        Set(ByVal value As Integer)
            iCodigoMarca = value
        End Set
    End Property

    Public Property Marca() As String
        Get
            Return sMarca
        End Get
        Set(ByVal value As String)
            sMarca = value
        End Set
    End Property

    Public Property Descricao2() As String
        Get
            Return sDescricao2
        End Get
        Set(ByVal value As String)
            sDescricao2 = value
        End Set
    End Property

    Public Property Referencia() As String
        Get
            Return sReferencia
        End Get
        Set(ByVal value As String)
            sReferencia = value
        End Set
    End Property

    Public Property RegistroAnvisa() As String
        Get
            Return sRegistroAnvisa
        End Get
        Set(ByVal value As String)
            sRegistroAnvisa = value
        End Set
    End Property

    Public Property CodigoNCM() As Integer
        Get
            Return iCodigoNCM
        End Get
        Set(ByVal value As Integer)
            iCodigoNCM = value
        End Set
    End Property

    Public Property InsumoProducao() As Boolean
        Get
            Return bInsumoProducao
        End Get
        Set(ByVal value As Boolean)
            bInsumoProducao = value
        End Set
    End Property

    Public Property PesoLiquido() As Double
        Get
            Return dPesoLiquido
        End Get
        Set(ByVal value As Double)
            dPesoLiquido = value
        End Set
    End Property

    Public Property CodigoOrigemItem() As Integer
        Get
            Return iCodigoOrigemItem
        End Get
        Set(ByVal value As Integer)
            iCodigoOrigemItem = value
        End Set
    End Property

    Public Property CodigoTipoItemSped() As Integer
        Get
            Return iCodigoTipoItemSped
        End Get
        Set(ByVal value As Integer)
            iCodigoTipoItemSped = value
        End Set
    End Property

    Public Property CodigoCor() As Integer
        Get
            Return iCodigoCor
        End Get
        Set(ByVal value As Integer)
            iCodigoCor = value
        End Set
    End Property

    Public Property CodigoVolume() As Integer
        Get
            Return iCodigoVolume
        End Get
        Set(ByVal value As Integer)
            iCodigoVolume = value
        End Set
    End Property

    Public Property CodigoTipoAlca() As Integer
        Get
            Return iCodigoTipoAlca
        End Get
        Set(ByVal value As Integer)
            iCodigoTipoAlca = value
        End Set
    End Property

    Public Property CodigoPlanoControle() As Integer
        Get
            Return iCodigoPlanoControle
        End Get
        Set(ByVal value As Integer)
            iCodigoPlanoControle = value
        End Set
    End Property

    Public Property CodigoFolhaOperacao() As Integer
        Get
            Return iCodigoFolhaOperacao
        End Get
        Set(ByVal value As Integer)
            iCodigoFolhaOperacao = value
        End Set
    End Property

    Public Property CodigoEspecificacaoTecnica() As Integer
        Get
            Return iCodigoEspecificacaoTecnica
        End Get
        Set(ByVal value As Integer)
            iCodigoEspecificacaoTecnica = value
        End Set
    End Property

    Public Property QuantidadeLinhasCertificado() As Integer
        Get
            Return iQuantidadeLinhasCertificado
        End Get
        Set(ByVal value As Integer)
            iQuantidadeLinhasCertificado = value
        End Set
    End Property

    Public Property Observacao() As String
        Get
            Return sObservacao
        End Get
        Set(ByVal value As String)
            sObservacao = value
        End Set
    End Property

    Public Property Cor() As String
        Get
            Return sCor
        End Get
        Set(ByVal value As String)
            sCor = value
        End Set
    End Property

    Public Property Bitola() As Double
        Get
            Return dBitola
        End Get
        Set(ByVal value As Double)
            dBitola = value
        End Set
    End Property

    Public Property CodigoIntegracao() As Integer
        Get
            Return iCodigoIntegracao
        End Get
        Set(ByVal value As Integer)
            iCodigoIntegracao = value
        End Set
    End Property

    Public Property TipoVenda() As String
        Get
            Return sTipoVenda
        End Get
        Set(ByVal value As String)
            sTipoVenda = value
        End Set
    End Property

    Public Property Foto() As PictureBox
        Get
            Return picFoto
        End Get
        Set(ByVal value As PictureBox)
            picFoto = value
        End Set
    End Property

    Public Property Estoque() As Boolean
        Get
            Return bEstoque
        End Get
        Set(ByVal value As Boolean)
            bEstoque = value
        End Set
    End Property

    Public Property Compra() As Boolean
        Get
            Return bCompra
        End Get
        Set(ByVal value As Boolean)
            bCompra = value
        End Set
    End Property

    Public Property Venda() As Boolean
        Get
            Return bVenda
        End Get
        Set(ByVal value As Boolean)
            bVenda = value
        End Set
    End Property

    Public Property Producao() As Boolean
        Get
            Return bProducao
        End Get
        Set(ByVal value As Boolean)
            bProducao = value
        End Set
    End Property

    Public Property AtivoFixo() As Boolean
        Get
            Return bAtivoFixo
        End Get
        Set(ByVal value As Boolean)
            bAtivoFixo = value
        End Set
    End Property

    Public Property CodigoProduto() As Long
        Get
            Return lCodigoProduto
        End Get
        Set(ByVal value As Long)
            lCodigoProduto = value
        End Set
    End Property

    Public Property CodigoNivelInspecao() As Integer
        Get
            Return iCodigoNivelInspecao
        End Get
        Set(ByVal value As Integer)
            iCodigoNivelInspecao = value
        End Set
    End Property

#End Region

#Region "::: DADOS DE VENDAS :::"

    Public Property CodigoUnidadeMedidaVenda() As Integer
        Get
            Return iCodigoUnidadeMedidaVenda
        End Get
        Set(ByVal value As Integer)
            iCodigoUnidadeMedidaVenda = value
        End Set
    End Property

    Public Property FatorConversaoUnidadeMedidaVenda() As Double
        Get
            Return dFatorConversaoUnidadeMedidaVenda
        End Get
        Set(ByVal value As Double)
            dFatorConversaoUnidadeMedidaVenda = value
        End Set
    End Property

    Public Property FormaVenda() As Integer
        Get
            Return iFormaVenda
        End Get
        Set(ByVal value As Integer)
            iFormaVenda = value
        End Set
    End Property

    Public Property CodigoGrupoItemVenda() As Integer
        Get
            Return iCodigoGrupoItemVenda
        End Get
        Set(ByVal value As Integer)
            iCodigoGrupoItemVenda = value
        End Set
    End Property

#End Region

#Region "::: DADOS DE COMPRA :::"

    Public Property CodigoUnidadeMedidaCompra() As Integer
        Get
            Return iCodigoUnidadeMedidaCompra
        End Get
        Set(ByVal value As Integer)
            iCodigoUnidadeMedidaCompra = value
        End Set
    End Property

    Public Property FatorConversaoUnidadeMedidaCompra() As Double
        Get
            Return dFatorConversaoUnidadeMedidaCompra
        End Get
        Set(ByVal value As Double)
            dFatorConversaoUnidadeMedidaCompra = value
        End Set
    End Property

    Public Property LeadTime() As Integer
        Get
            Return iLeadTime
        End Get
        Set(ByVal value As Integer)
            iLeadTime = value
        End Set
    End Property

    Public Property NecessitaFornecedorHomologado() As Boolean
        Get
            Return bNecessitaFornecedorHomologado
        End Get
        Set(ByVal value As Boolean)
            bNecessitaFornecedorHomologado = value
        End Set
    End Property

    Public Property QuantidadeMinima() As Double
        Get
            Return dQuantidadeMinima
        End Get
        Set(ByVal value As Double)
            dQuantidadeMinima = value
        End Set
    End Property

    Public Property MultiploCompra() As Double
        Get
            Return dMultiploCompra
        End Get
        Set(ByVal value As Double)
            dMultiploCompra = value
        End Set
    End Property

#End Region

#Region "::: DADOS DE RECEBIMENTO :::"

    Public Property ToleranciaQuantidadeRecebimento() As Double
        Get
            Return dToleranciaQuantidadeRecebimento
        End Get
        Set(ByVal value As Double)
            dToleranciaQuantidadeRecebimento = value
        End Set
    End Property

    Public Property ToleranciaValorRecebimento() As Double
        Get
            Return dToleranciaValorRecebimento
        End Get
        Set(ByVal value As Double)
            dToleranciaValorRecebimento = value
        End Set
    End Property

    Public Property ToleranciaDiasRecebimento() As Integer
        Get
            Return iToleranciaDiasRecebimento
        End Get
        Set(ByVal value As Integer)
            iToleranciaDiasRecebimento = value
        End Set
    End Property

#End Region

#Region "::: DADOS DO ESTOQUE :::"

    Public Property CodigoUnidadeMedidaEstoque() As Integer
        Get
            Return iCodigoUnidadeMedidaEstoque
        End Get
        Set(ByVal value As Integer)
            iCodigoUnidadeMedidaEstoque = value
        End Set
    End Property

    Public Property EstoqueMinimo() As Double
        Get
            Return dEstoqueMinimo
        End Get
        Set(ByVal value As Double)
            dEstoqueMinimo = value
        End Set
    End Property

    Public Property EstoqueMaximo() As Double
        Get
            Return dEstoqueMaximo
        End Get
        Set(ByVal value As Double)
            dEstoqueMaximo = value
        End Set
    End Property

    Public Property CodigoMetodologiaSaidaProdutoEstoque() As Integer
        Get
            Return iCodigoMetodologiaSaidaProdutoEstoque
        End Get
        Set(ByVal value As Integer)
            iCodigoMetodologiaSaidaProdutoEstoque = value
        End Set
    End Property

    Public Property ControlaLote() As Boolean
        Get
            Return bControlaLote
        End Get
        Set(ByVal value As Boolean)
            bControlaLote = value
        End Set
    End Property

    Public Property GeraLoteInterno() As Boolean
        Get
            Return bGeraLoteInterno
        End Get
        Set(ByVal value As Boolean)
            bGeraLoteInterno = value
        End Set
    End Property

    Public Property CaracaterLote() As String
        Get
            Return sCaracterLote
        End Get
        Set(ByVal value As String)
            sCaracterLote = value
        End Set
    End Property

    Public Property ControlaQualidade() As Boolean
        Get
            Return bControlaQualidade
        End Get
        Set(ByVal value As Boolean)
            bControlaQualidade = value
        End Set
    End Property

    Public Property ControlaValidade() As Boolean
        Get
            Return bControlaValidade
        End Get
        Set(ByVal value As Boolean)
            bControlaValidade = value
        End Set
    End Property

    Public Property ControlaDataFabricacao() As Boolean
        Get
            Return bControlaDataFabricacao
        End Get
        Set(ByVal value As Boolean)
            bControlaDataFabricacao = value
        End Set
    End Property

    Public Property ControlaTempoMaximoExposicao() As Boolean
        Get
            Return bControlaTempoMaximoExposicao
        End Get
        Set(ByVal value As Boolean)
            bControlaTempoMaximoExposicao = value
        End Set
    End Property

    Public Property TempoMaximoExposicao() As Double
        Get
            Return dTempoMaximoExposicao
        End Get
        Set(ByVal value As Double)
            dTempoMaximoExposicao = value
        End Set
    End Property

#End Region

#Region "::: DADOS DE ATIVO FIXO :::"

    Public Property PercentualDesvalorizacao() As Double
        Get
            Return dPercentualDesvalorizacao
        End Get
        Set(ByVal value As Double)
            dPercentualDesvalorizacao = value
        End Set
    End Property

    Public Property FrequenciaDesvalorizacaoDia() As Integer
        Get
            Return iFrequenciaDesvalorizacaoDia
        End Get
        Set(ByVal value As Integer)
            iFrequenciaDesvalorizacaoDia = value
        End Set
    End Property

    Public Property CodigoTipoAtivoFixo() As Integer
        Get
            Return iCodigoTipoAtivoFixo
        End Get
        Set(ByVal value As Integer)
            iCodigoTipoAtivoFixo = value
        End Set
    End Property

    Public Property VidaUtilBem() As Double
        Get
            Return dVidaUtilBem
        End Get
        Set(ByVal value As Double)
            dVidaUtilBem = value
        End Set
    End Property

    Public Property TaxaDepreciacaoAnual() As Double
        Get
            Return dTaxaDepreciacaoAnual
        End Get
        Set(ByVal value As Double)
            dTaxaDepreciacaoAnual = value
        End Set
    End Property

    Public Property TaxaDepreciacaoMensal() As Double
        Get
            Return dTaxaDepreciacaoMensal
        End Get
        Set(ByVal value As Double)
            dTaxaDepreciacaoMensal = value
        End Set
    End Property

    Public Property ValorBem() As Double
        Get
            Return dValorBem
        End Get
        Set(ByVal value As Double)
            dValorBem = value
        End Set
    End Property

    Public Property ValorImpostosRecuperaveis() As Double
        Get
            Return dValorImpostosRecuperaveis
        End Get
        Set(ByVal value As Double)
            dValorImpostosRecuperaveis = value
        End Set
    End Property

    Public Property ValorResidual() As Double
        Get
            Return dValorResidual
        End Get
        Set(ByVal value As Double)
            dValorResidual = value
        End Set
    End Property

    Public Property ValorDepreciavel() As Double
        Get
            Return dValorDepreciavel
        End Get
        Set(ByVal value As Double)
            dValorDepreciavel = value
        End Set
    End Property

    Public Property ValorDepreciacaoAnual() As Double
        Get
            Return dValorDepreciacaoAnual
        End Get
        Set(ByVal value As Double)
            dValorDepreciacaoAnual = value
        End Set
    End Property

    Public Property ValorDepreciacaoMensal() As Double
        Get
            Return dValorDepreciacaoMensal
        End Get
        Set(ByVal value As Double)
            dValorDepreciacaoMensal = value
        End Set
    End Property

    Public Property ControlePatrimonial() As String
        Get
            Return sControlePatrimonial
        End Get
        Set(ByVal value As String)
            sControlePatrimonial = value
        End Set
    End Property

#End Region

#Region "::: DADOS DAS DIMENSÕES :::"

    Public Property CodigoTipoPerfil() As Integer
        Get
            Return iCodigoTipoPerfil
        End Get
        Set(ByVal value As Integer)
            iCodigoTipoPerfil = value
        End Set
    End Property

    Public Property CodigoMaterial() As Integer
        Get
            Return iCodigoMaterial
        End Get
        Set(ByVal value As Integer)
            iCodigoMaterial = value
        End Set
    End Property



    Public Property Medida1() As Integer
        Get
            Return dMedida1
        End Get
        Set(ByVal value As Integer)
            dMedida1 = value
        End Set
    End Property

    Public Property Medida2() As Integer
        Get
            Return dMedida2
        End Get
        Set(ByVal value As Integer)
            dMedida2 = value
        End Set
    End Property

    Public Property Medida3() As Integer
        Get
            Return dMedida3
        End Get
        Set(ByVal value As Integer)
            dMedida3 = value
        End Set
    End Property

    Public Property Medida4() As Integer
        Get
            Return dMedida4
        End Get
        Set(ByVal value As Integer)
            dMedida4 = value
        End Set
    End Property

    Public Property CodigoUnidadeMedidaDimensao() As Integer
        Get
            Return iCodigoUnidadeMedidaDimensao
        End Get
        Set(ByVal value As Integer)
            iCodigoUnidadeMedidaDimensao = value
        End Set
    End Property

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: PRODUTO :::"

    Public Sub LoadDadosHistorico(ByVal lCodigoItem As Long, _
                                  ByVal txtCodigoItem As MaskedEditBox, _
                                  ByVal txtCodigoItem2 As MaskedEditBox, _
                                  ByVal txtDescricao As MaskedEditBox, _
                                  ByVal txtMarca As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0
        Dim oSqlDataReader As SqlDataReader

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)


            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_dados_historico", oSqlParameter)

            If oSqlDataReader.Read Then

                txtCodigoItem.Text = oSqlDataReader.Item("codigo_item")
                txtCodigoItem2.Text = oSqlDataReader.Item("codigo_item2")
                txtDescricao.Text = oSqlDataReader.Item("descricao")
                txtMarca.Text = oSqlDataReader.Item("marca")


                oSqlDataReader.Close()
            End If
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    

    Public Sub Insert()

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_nivel_inspecao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoNivelInspecao = -1, DBNull.Value, iCodigoNivelInspecao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Contrle Patrimonial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "controle_patrimonial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sControlePatrimonial : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Vida Util Bem
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "vida_util_bem"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dVidaUtilBem : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Taxa Depreciacao Anual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "taxa_depreciacao_anual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTaxaDepreciacaoAnual : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Taxa Depreciacao Mensal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "taxa_depreciacao_mensal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTaxaDepreciacaoMensal : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Valor Bem
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_bem"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorBem : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Valor Impostos Recuperaveis
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_impostos_recuperaveis"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorImpostosRecuperaveis : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Valor Residual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_residual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorResidual : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Valor Depreciavel
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_depreciavel"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorDepreciavel : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Valor Depreciacao Anual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_depreciacao_anual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorDepreciacaoAnual : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Valor Depreciacao Mensal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_depreciacao_mensal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorDepreciacaoMensal : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Tipo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iTipoItem : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Grupo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_grupo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iGrupoItem = -1, DBNull.Value, iGrupoItem) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sCodigoItem : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Item 2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sCodigoItem2 : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Barras
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_barras"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 14
            oSqlParameter(i).Value = IIf(sCodigoBarras = "", DBNull.Value, sCodigoBarras) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAtivo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sDescricao : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Marca
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_marca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoMarca = -1, DBNull.Value, iCodigoMarca) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Descrição 2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = IIf(sDescricao2 = "", DBNull.Value, sDescricao2) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Referencia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "referencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(sReferencia = "", DBNull.Value, sReferencia) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código NCM
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ncm"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoNCM = -1, DBNull.Value, iCodigoNCM) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Peso Liquido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "peso_liquido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPesoLiquido : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Insumo de Produção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "insumo_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bInsumoProducao : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Origem Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_origem_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoOrigemItem = -1, DBNull.Value, iCodigoOrigemItem) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Cor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoCor = -1, DBNull.Value, iCodigoCor) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Tipo Alça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_alca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoTipoAlca = -1, DBNull.Value, iCodigoTipoAlca) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Volume
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_volume"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoVolume = -1, DBNull.Value, iCodigoVolume) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Plano de Controle
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_plano_controle"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoPlanoControle = -1, DBNull.Value, iCodigoPlanoControle) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Folha de Operação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_folha_operacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoFolhaOperacao = -1, DBNull.Value, iCodigoFolhaOperacao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Especificação Técnica
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_especificacao_tecnica"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoEspecificacaoTecnica = -1, DBNull.Value, iCodigoEspecificacaoTecnica) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Quantidade Linhas Certificado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_linhas_certificado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iQuantidadeLinhasCertificado : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Observação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Text
            oSqlParameter(i).Value = IIf(sObservacao = "", DBNull.Value, sObservacao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Cor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sCor = "", DBNull.Value, sCor) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Bitola
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "bitola"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dBitola = 0, DBNull.Value, dBitola) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Integração
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_integracao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoIntegracao = 0, DBNull.Value, iCodigoIntegracao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Tipo Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sTipoVenda = "", DBNull.Value, sTipoVenda) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Verifica se existe Foto
            If Not picFoto.Image Is Nothing Then

                'Carrega Imagem
                Dim oMemoryStream As MemoryStream = New MemoryStream()
                picFoto.Image.Save(oMemoryStream, ImageFormat.Jpeg)
                Dim bytBLOBData(oMemoryStream.Length - 1) As Byte
                oMemoryStream.Position = 0
                oMemoryStream.Read(bytBLOBData, 0, oMemoryStream.Length)

                'Seta Parametros - Foto
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "foto"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarBinary
                oSqlParameter(i).Value = bytBLOBData : i += 1 : ReDim Preserve oSqlParameter(i)

            Else

                'Seta Parametros - Foto
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "foto"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarBinary
                oSqlParameter(i).Value = DBNull.Value : i += 1 : ReDim Preserve oSqlParameter(i)

            End If

            'Seta Parametros - Código Unidade Medida - Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(bVenda = False, DBNull.Value, IIf(iCodigoUnidadeMedidaVenda = -1, DBNull.Value, iCodigoUnidadeMedidaVenda)) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Fator de Conversão Unidade de Medida - Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fator_conversao_unidade_medida_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(bVenda = False, DBNull.Value, dFatorConversaoUnidadeMedidaVenda) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Forma de Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_forma_venda_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(bVenda = False, DBNull.Value, IIf(iFormaVenda = -1, DBNull.Value, iFormaVenda)) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código do Grupo de Item de Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_grupo_item_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoGrupoItemVenda = -1, DBNull.Value, iCodigoGrupoItemVenda) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Unidade Medida - Compra
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida_compra"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(bCompra = False, DBNull.Value, IIf(iCodigoUnidadeMedidaCompra = -1, DBNull.Value, iCodigoUnidadeMedidaCompra)) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Fator de Conversão Unidade de Medida - Compra
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fator_conversao_unidade_medida_compra"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(bCompra = False, DBNull.Value, dFatorConversaoUnidadeMedidaCompra) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Lead Time
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "lead_time"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(bCompra = False, DBNull.Value, iLeadTime) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Necessita Fornecedor Homologado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "necessita_fornecedor_homologado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = IIf(bCompra = False, DBNull.Value, bNecessitaFornecedorHomologado) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Quantidade Mínima
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_minima"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(bCompra = False, DBNull.Value, dQuantidadeMinima) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Múltiplo Compra
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "multiplo_compra"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(bCompra = False, DBNull.Value, dMultiploCompra) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - % Tolerância Quantidade - Recebimento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tolerancia_quantidade_recebimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(bCompra = False, DBNull.Value, dToleranciaQuantidadeRecebimento) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - % Tolerância Valor - Recebimento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tolerancia_valor_recebimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(bCompra = False, DBNull.Value, dToleranciaValorRecebimento) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Tolerância Dias - Recebimento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tolerancia_dias_recebimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(bCompra = False, DBNull.Value, iToleranciaDiasRecebimento) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Unidade Medida - Estoque
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida_estoque"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(bEstoque = False, DBNull.Value, IIf(iCodigoUnidadeMedidaEstoque = -1, DBNull.Value, iCodigoUnidadeMedidaEstoque)) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Estoque Mínimo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "estoque_minimo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(bEstoque = False, DBNull.Value, dEstoqueMinimo) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Estoque Máximo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "estoque_maximo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(bEstoque = False, DBNull.Value, dEstoqueMaximo) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Metodologia Controle Estoque
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_metodologia_saida_produto_estoque"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(bEstoque = False, DBNull.Value, iCodigoMetodologiaSaidaProdutoEstoque) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Controla Qualidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "controla_qualidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = IIf(bEstoque = False, DBNull.Value, bControlaQualidade) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Controla Lote
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "controla_lote"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = IIf(bEstoque = False, DBNull.Value, bControlaLote) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Gera Lote Interno
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "gera_lote_interno"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = IIf(bEstoque = False, DBNull.Value, bGeraLoteInterno) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Caracter Lote
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "caracter_lote"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 3
            oSqlParameter(i).Value = IIf(bEstoque = False, DBNull.Value, sCaracterLote) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Controla Tempo Máximo Exposicao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tempo_maximo_exposicao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(bEstoque = False, DBNull.Value, dTempoMaximoExposicao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Tempo Máximo Exposicao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "controla_tempo_exposicao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = IIf(bEstoque = False, DBNull.Value, bControlaTempoMaximoExposicao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Controla Validade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "controla_validade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = IIf(bEstoque = False, DBNull.Value, bControlaValidade) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Controla Data Fabricação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "controla_data_fabricacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = IIf(bEstoque = False, DBNull.Value, bControlaDataFabricacao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Percentual de Desvalorização
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "percentual_desvalorizacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(bAtivoFixo = False, DBNull.Value, dPercentualDesvalorizacao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Frequencia de Desvalorização (dia)
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "frequencia_desvalorizacao_dia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(bAtivoFixo = False, DBNull.Value, iFrequenciaDesvalorizacaoDia) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Tipo de Ativo Fixo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_ativo_fixo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(bAtivoFixo = False, DBNull.Value, iCodigoTipoAtivoFixo) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Estoque
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item_estoque"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bEstoque : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Compra
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item_compra"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bCompra : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bVenda : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Produção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bProducao : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Ativo Fixo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item_ativo_fixo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAtivoFixo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Especialidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_especialidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = DBNull.Value : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Diâmetro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_diametro_fio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = DBNull.Value : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Comprimento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_comprimento_fio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = DBNull.Value : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Cor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cor_fio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = DBNull.Value : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Bitola
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_bitola"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = DBNull.Value : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Tamanho Agulha
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tamanho_agulha"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = DBNull.Value : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Formato Agulha
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_formato_agulha"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = DBNull.Value : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Agulha Sutura
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "agulha_sutura"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = DBNull.Value : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_perfil"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoTipoPerfil = -1, DBNull.Value, iCodigoTipoPerfil) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_material"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoMaterial = -1, DBNull.Value, iCodigoMaterial) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "medida1"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMedida1 : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "medida2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMedida2 : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "medida3"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMedida3 : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "medida4"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMedida4 : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida_dimensao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoUnidadeMedidaDimensao = -1, DBNull.Value, iCodigoUnidadeMedidaDimensao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_produto", oSqlParameter)

            lCodigoProduto = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertNovo()

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Tipo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = modDeclaration.TipoItem.produto : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_produto", oSqlParameter)

            lCodigoProduto = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Import(ByVal bCadastraGrupoItem As Boolean, _
                      ByVal bCadastraUnidadeMedida As Boolean, _
                      ByVal bCadastraNCM As Boolean, _
                      ByVal bAtualizaRegistroIgual As Boolean, _
                      ByVal iTipoItem As Integer, _
                      ByVal sGrupoItem As String, _
                      ByVal sCodigoItem As String, _
                      ByVal sCodigoBarras As String, _
                      ByVal bAtivo As Boolean, _
                      ByVal sDescricao As String, _
                      ByVal sMarca As String, _
                      ByVal sDescricao2 As String, _
                      ByVal sCodigoNCM As String, _
                      ByVal dPesoLiquido As Double, _
                      ByVal iCodigoOrigemItem As Integer, _
                      ByVal sObservacao As String, _
                      ByVal sUnidadeMedidaVenda As String, _
                      ByVal dFatorConversaoUnidadeMedidaVenda As Double, _
                      ByVal iFormaVenda As Integer, _
                      ByVal sUnidadeMedidaCompra As String, _
                      ByVal dFatorConversaoUnidadeMedidaCompra As Double, _
                      ByVal iLeadTime As Integer, _
                      ByVal bNecessitaFornecedorHomologado As Boolean, _
                      ByVal sUnidadeMedidaEstoque As String, _
                      ByVal dEstoqueMinimo As Double, _
                      ByVal dEstoqueMaximo As Double, _
                      ByVal bControlaLote As Boolean, _
                      ByVal bControlaValidade As Boolean, _
                      ByVal bControlaDataFabricacao As Boolean, _
                      ByVal dPercentualDesvalorizacao As Double, _
                      ByVal iFrequenciaDesvalorizacaoDia As Integer, _
                      ByVal bEstoque As Boolean, _
                      ByVal bCompra As Boolean, _
                      ByVal bVenda As Boolean, _
                      ByVal bProducao As Boolean, _
                      ByVal bAtivoFixo As Boolean, _
                      ByRef sMensagem As String)

        'Variaveis Locais
        Dim oSqlParameter(37) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Cadastrar Grupo de Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cadastrar_grupo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bCadastraGrupoItem : i += 1

            'Seta Parametros - Cadastrar Unidade de Medida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cadastrar_unidade_medida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bCadastraUnidadeMedida : i += 1

            'Seta Parametros - Cadastrar NCM
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cadastrar_ncm"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bCadastraNCM : i += 1

            'Seta Parametros - Atualizar Registros Iguais
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "atualizar_registros_iguais"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAtualizaRegistroIgual : i += 1

            'Seta Parametros - Código Tipo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iTipoItem : i += 1

            'Seta Parametros - Grupo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "grupo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sGrupoItem : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sCodigoItem : i += 1

            'Seta Parametros - Código Barras
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_barras"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 14
            oSqlParameter(i).Value = IIf(sCodigoBarras = "", DBNull.Value, sCodigoBarras) : i += 1

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAtivo : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Marca
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "marca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sMarca = "", DBNull.Value, sMarca) : i += 1

            'Seta Parametros - Descrição 2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = IIf(sDescricao2 = "", DBNull.Value, sDescricao2) : i += 1

            'Seta Parametros - Código NCM
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ncm"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 8
            oSqlParameter(i).Value = sCodigoNCM : i += 1

            'Seta Parametros - Peso Liquido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "peso_liquido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPesoLiquido : i += 1

            'Seta Parametros - Código Origem Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_origem_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoOrigemItem = -1, DBNull.Value, iCodigoOrigemItem) : i += 1

            'Seta Parametros - Observação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Text
            oSqlParameter(i).Value = IIf(sObservacao = "", DBNull.Value, sObservacao) : i += 1

            'Seta Parametros - Unidade Medida - Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "unidade_medida_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 6
            oSqlParameter(i).Value = IIf(bVenda = False, DBNull.Value, sUnidadeMedidaVenda) : i += 1

            'Seta Parametros - Fator de Conversão Unidade de Medida - Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fator_conversao_unidade_medida_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(bVenda = False, DBNull.Value, dFatorConversaoUnidadeMedidaVenda) : i += 1

            'Seta Parametros - Código Forma de Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_forma_venda_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(bVenda = False, DBNull.Value, 1) : i += 1

            'Seta Parametros - Unidade Medida - Compra
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "unidade_medida_compra"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 6
            oSqlParameter(i).Value = IIf(bCompra = False, DBNull.Value, sUnidadeMedidaCompra) : i += 1

            'Seta Parametros - Fator de Conversão Unidade de Medida - Compra
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fator_conversao_unidade_medida_compra"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(bCompra = False, DBNull.Value, dFatorConversaoUnidadeMedidaCompra) : i += 1

            'Seta Parametros - Lead Time
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "lead_time"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(bCompra = False, DBNull.Value, iLeadTime) : i += 1

            'Seta Parametros - Necessita Fornecedor Homologado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "necessita_fornecedor_homologado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = IIf(bCompra = False, DBNull.Value, bNecessitaFornecedorHomologado) : i += 1

            'Seta Parametros - Unidade Medida - Estoque
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "unidade_medida_estoque"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 6
            oSqlParameter(i).Value = IIf(bEstoque = False, DBNull.Value, sUnidadeMedidaEstoque) : i += 1

            'Seta Parametros - Estoque Mínimo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "estoque_minimo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(bEstoque = False, DBNull.Value, dEstoqueMinimo) : i += 1

            'Seta Parametros - Estoque Máximo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "estoque_maximo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(bEstoque = False, DBNull.Value, dEstoqueMaximo) : i += 1

            'Seta Parametros - Controla Lote
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "controla_lote"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = IIf(bEstoque = False, DBNull.Value, bControlaLote) : i += 1

            'Seta Parametros - Controla Validade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "controla_validade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = IIf(bEstoque = False, DBNull.Value, bControlaValidade) : i += 1

            'Seta Parametros - Controla Data Fabricação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "controla_data_fabricacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = IIf(bEstoque = False, DBNull.Value, bControlaDataFabricacao) : i += 1

            'Seta Parametros - Percentual de Desvalorização
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "percentual_desvalorizacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(bAtivoFixo = False, DBNull.Value, dPercentualDesvalorizacao) : i += 1

            'Seta Parametros - Frequencia de Desvalorização (dia)
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "frequencia_desvalorizacao_dia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(bAtivoFixo = False, DBNull.Value, iFrequenciaDesvalorizacaoDia) : i += 1

            'Seta Parametros - Estoque
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item_estoque"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bEstoque : i += 1

            'Seta Parametros - Compra
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item_compra"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bCompra : i += 1

            'Seta Parametros - Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bVenda : i += 1

            'Seta Parametros - Produção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bProducao : i += 1

            'Seta Parametros - Ativo Fixo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item_ativo_fixo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAtivoFixo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Mensagem
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "mensagem"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 1000

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_import_cadastro_basico_item", oSqlParameter)

            sMensagem = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update()

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "estoque_minimo_uso_consumo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dEstoqueMinimoUsoConsumo : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida_uso_consumo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoUnidadeMedidaUsoConsumo = -1, DBNull.Value, iCodigoUnidadeMedidaUsoConsumo) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_nivel_inspecao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoNivelInspecao = -1, DBNull.Value, iCodigoNivelInspecao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Controle Patrimonial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "controle_patrimonial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sControlePatrimonial : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Vida Util Bem
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "vida_util_bem"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dVidaUtilBem : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Taxa Depreciacao Anual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "taxa_depreciacao_anual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTaxaDepreciacaoAnual : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Taxa Depreciacao Mensal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "taxa_depreciacao_mensal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTaxaDepreciacaoMensal : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Valor Bem
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_bem"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorBem : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Valor Impostos Recuperaveis
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_impostos_recuperaveis"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorImpostosRecuperaveis : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Valor Residual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_residual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorResidual : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Valor Depreciavel
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_depreciavel"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorDepreciavel : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Valor Depreciacao Anual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_depreciacao_anual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorDepreciacaoAnual : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Valor Depreciacao Mensal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_depreciacao_mensal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorDepreciacaoMensal : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Tipo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iTipoItem : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Grupo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_grupo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iGrupoItem : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sCodigoItem : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Item 2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sCodigoItem2 : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Barras
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_barras"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 14
            oSqlParameter(i).Value = IIf(sCodigoBarras = "", DBNull.Value, sCodigoBarras) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAtivo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sDescricao : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Marca
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_marca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoMarca = -1, DBNull.Value, iCodigoMarca) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Descrição 2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = IIf(sDescricao2 = "", DBNull.Value, sDescricao2) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Referencia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "referencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(sReferencia = "", DBNull.Value, sReferencia) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código NCM
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ncm"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoNCM = -1, DBNull.Value, iCodigoNCM) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Peso Liquido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "peso_liquido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPesoLiquido : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Insumo de Produção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "insumo_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bInsumoProducao : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Origem Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_origem_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoOrigemItem = -1, DBNull.Value, iCodigoOrigemItem) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Cor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoCor = -1, DBNull.Value, iCodigoCor) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Tipo Alça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_alca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoTipoAlca = -1, DBNull.Value, iCodigoTipoAlca) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Volume
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_volume"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoVolume = -1, DBNull.Value, iCodigoVolume) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Plano de Controle
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_plano_controle"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoPlanoControle = -1, DBNull.Value, iCodigoPlanoControle) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Folha de Operação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_folha_operacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoFolhaOperacao = -1, DBNull.Value, iCodigoFolhaOperacao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Especificação Técnica
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_especificacao_tecnica"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoEspecificacaoTecnica = -1, DBNull.Value, iCodigoEspecificacaoTecnica) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Quantidade Linhas Certificado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_linhas_certificado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iQuantidadeLinhasCertificado : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Observação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Text
            oSqlParameter(i).Value = IIf(sObservacao = "", DBNull.Value, sObservacao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Cor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sCor = "", DBNull.Value, sCor) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Bitola
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "bitola"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dBitola = 0, DBNull.Value, dBitola) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Integração
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_integracao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoIntegracao = 0, DBNull.Value, iCodigoIntegracao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Tipo Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sTipoVenda = "", DBNull.Value, sTipoVenda) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Verifica se existe Foto
            If Not picFoto.Image Is Nothing Then

                'Carrega Imagem
                Dim oMemoryStream As MemoryStream = New MemoryStream()
                picFoto.Image.Save(oMemoryStream, ImageFormat.Jpeg)
                Dim bytBLOBData(oMemoryStream.Length - 1) As Byte
                oMemoryStream.Position = 0
                oMemoryStream.Read(bytBLOBData, 0, oMemoryStream.Length)

                'Seta Parametros - Foto
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "foto"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarBinary
                oSqlParameter(i).Value = bytBLOBData : i += 1 : ReDim Preserve oSqlParameter(i)

            Else

                'Seta Parametros - Foto
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "foto"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarBinary
                oSqlParameter(i).Value = DBNull.Value : i += 1 : ReDim Preserve oSqlParameter(i)

            End If

            'Seta Parametros - Código Unidade Medida - Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(bVenda = False, DBNull.Value, iCodigoUnidadeMedidaVenda) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Fator de Conversão Unidade de Medida - Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fator_conversao_unidade_medida_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(bVenda = False, DBNull.Value, dFatorConversaoUnidadeMedidaVenda) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Forma de Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_forma_venda_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(bVenda = False, DBNull.Value, IIf(iFormaVenda = -1, DBNull.Value, iFormaVenda)) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código do Grupo de Item de Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_grupo_item_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoGrupoItemVenda = -1, DBNull.Value, iCodigoGrupoItemVenda) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Unidade Medida - Compra
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida_compra"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(bCompra = False, DBNull.Value, iCodigoUnidadeMedidaCompra) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Fator de Conversão Unidade de Medida - Compra
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fator_conversao_unidade_medida_compra"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(bCompra = False, DBNull.Value, dFatorConversaoUnidadeMedidaCompra) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Lead Time
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "lead_time"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(bCompra = False, DBNull.Value, iLeadTime) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Necessita Fornecedor Homologado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "necessita_fornecedor_homologado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = IIf(bCompra = False, DBNull.Value, bNecessitaFornecedorHomologado) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Quantidade Mínima
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_minima"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(bCompra = False, DBNull.Value, dQuantidadeMinima) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Múltiplo Compra
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "multiplo_compra"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(bCompra = False, DBNull.Value, dMultiploCompra) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - % Tolerância Quantidade - Recebimento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tolerancia_quantidade_recebimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(bCompra = False, DBNull.Value, dToleranciaQuantidadeRecebimento) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - % Tolerância Valor - Recebimento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tolerancia_valor_recebimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(bCompra = False, DBNull.Value, dToleranciaValorRecebimento) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Tolerância Dias - Recebimento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tolerancia_dias_recebimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(bCompra = False, DBNull.Value, iToleranciaDiasRecebimento) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Unidade Medida - Estoque
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida_estoque"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(bEstoque = False, DBNull.Value, iCodigoUnidadeMedidaEstoque) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Estoque Mínimo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "estoque_minimo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(bEstoque = False, DBNull.Value, dEstoqueMinimo) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Estoque Máximo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "estoque_maximo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(bEstoque = False, DBNull.Value, dEstoqueMaximo) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Metodologia Controle Estoque
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_metodologia_saida_produto_estoque"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(bEstoque = False, DBNull.Value, iCodigoMetodologiaSaidaProdutoEstoque) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Controla Qualidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "controla_qualidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = IIf(bEstoque = False, DBNull.Value, bControlaQualidade) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Controla Lote
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "controla_lote"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = IIf(bEstoque = False, DBNull.Value, bControlaLote) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Gera Lote Interno
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "gera_lote_interno"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = IIf(bEstoque = False, DBNull.Value, bGeraLoteInterno) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Caracter Lote
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "caracter_lote"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 3
            oSqlParameter(i).Value = IIf(bEstoque = False, DBNull.Value, sCaracterLote) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Controla Tempo Máximo Exposicao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tempo_maximo_exposicao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(bEstoque = False, DBNull.Value, dTempoMaximoExposicao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Tempo Máximo Exposicao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "controla_tempo_exposicao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = IIf(bEstoque = False, DBNull.Value, bControlaTempoMaximoExposicao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Controla Validade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "controla_validade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = IIf(bEstoque = False, DBNull.Value, bControlaValidade) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Controla Data Fabricação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "controla_data_fabricacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = IIf(bEstoque = False, DBNull.Value, bControlaDataFabricacao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Percentual de Desvalorização
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "percentual_desvalorizacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(bAtivoFixo = False, DBNull.Value, dPercentualDesvalorizacao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Frequencia de Desvalorização (dia)
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "frequencia_desvalorizacao_dia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(bAtivoFixo = False, DBNull.Value, iFrequenciaDesvalorizacaoDia) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Tipo de Ativo Fixo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_ativo_fixo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(bAtivoFixo = False, DBNull.Value, iCodigoTipoAtivoFixo) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Estoque
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item_estoque"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bEstoque : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Compra
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item_compra"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bCompra : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bVenda : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Produção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bProducao : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Ativo Fixo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item_ativo_fixo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAtivoFixo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Especialidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_especialidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = DBNull.Value : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Diâmetro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_diametro_fio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = DBNull.Value : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Comprimento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_comprimento_fio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = DBNull.Value : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Cor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cor_fio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = DBNull.Value : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Bitola
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_bitola"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = DBNull.Value : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Tamanho Agulha
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tamanho_agulha"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = DBNull.Value : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Formato Agulha
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_formato_agulha"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = DBNull.Value : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Agulha Sutura
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "agulha_sutura"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = DBNull.Value : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Agulha Sutura
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item_sped"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoItemSped : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_perfil"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoTipoPerfil = -1, DBNull.Value, iCodigoTipoPerfil) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_material"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoMaterial = -1, DBNull.Value, iCodigoMaterial) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "medida1"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMedida1 : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "medida2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMedida2 : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "medida3"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMedida3 : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "medida4"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMedida4 : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida_dimensao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoUnidadeMedidaDimensao = -1, DBNull.Value, iCodigoUnidadeMedidaDimensao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_produto", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Duplicar(ByVal lCodigoItem As Long, _
                        ByRef lCodigo As Long)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_produto_duplicar", oSqlParameter)

            'Obtém Linha
            lCodigo = oSqlParameter(1).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Delete()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_produto", oSqlParameter)

                'Deleta Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaCodigoProduto(ByVal lCodigo As Long, _
                                        ByVal sCodigoProduto As String) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim iReturn As Integer
        Dim i As Integer = 0

        Try

            'Seta Retorno da Função
            ValidaCodigoProduto = False

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_cadastro_basico_produto", oSqlParameter), Integer)

            'Seta Retorno da Função
            ValidaCodigoProduto = IIf(iReturn > 0, False, True)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub LoadGridMovimentacaoEstoque(ByVal oGrid As GridEX, _
                                           ByVal lCodigoItem As Long, _
                                           ByVal sDataCorte As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(14) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Data Corte
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_corte"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataCorte = "", DBNull.Value, sDataCorte) : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_movimentacao_estoque", oSqlParameter)

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

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal iGrupoItem As Integer, _
                        ByVal sCodigoItem As String, _
                        ByVal sCodigoItem2 As String, _
                        ByVal sCodigoBarras As String, _
                        ByVal iInsumoProducao As Integer, _
                        ByVal iControlaQualidade As Integer, _
                        ByVal sDescricao As String, _
                        ByVal iCodigoMarca As Integer, _
                        ByVal sDescricao2 As String, _
                        Optional ByVal iCodigoCor As Integer = -1, _
                        Optional ByVal iCodigoVolume As Integer = -1, _
                        Optional ByVal iCodigoTipoAlca As Integer = -1)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(14) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Tipo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = CInt(modDeclaration.TipoItem.produto) : i += 1

            'Seta Parametros - Grupo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_grupo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iGrupoItem : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sCodigoItem : i += 1

            'Seta Parametros - Código Item2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sCodigoItem2 : i += 1

            'Seta Parametros - Código Barras
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_barras"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 14
            oSqlParameter(i).Value = sCodigoBarras : i += 1

            'Seta Parametros - Insumo Produção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "insumo_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = IIf(iInsumoProducao = -1, DBNull.Value, iInsumoProducao) : i += 1

            'Seta Parametros - Controla Qualidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "controla_qualidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = IIf(iControlaQualidade = -1, DBNull.Value, iControlaQualidade) : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Marca
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_marca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoMarca : i += 1

            'Seta Parametros - Descrição 2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sDescricao2 : i += 1

            'Seta Parametros - Código Cor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCor : i += 1

            'Seta Parametros - Código Tipo Alça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_alca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoAlca : i += 1

            'Seta Parametros - Código Volume
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_volume"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoVolume : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto", oSqlParameter)

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

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal iGrupoItem As Integer, _
                        ByVal sCodigoItem As String, _
                        ByVal sCodigoItem2 As String, _
                        ByVal sCodigoBarras As String, _
                        ByVal sDescricao As String, _
                        ByVal iCodigoMarca As Integer, _
                        ByVal sDescricao2 As String, _
                        Optional ByVal iCodigoCor As Integer = -1, _
                        Optional ByVal iCodigoVolume As Integer = -1, _
                        Optional ByVal iCodigoTipoAlca As Integer = -1)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(12) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Tipo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = CInt(modDeclaration.TipoItem.produto) : i += 1

            'Seta Parametros - Grupo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_grupo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iGrupoItem : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sCodigoItem : i += 1

            'Seta Parametros - Código Item2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sCodigoItem2 : i += 1

            'Seta Parametros - Código Barras
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_barras"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 14
            oSqlParameter(i).Value = sCodigoBarras : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Marca
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_marca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoMarca : i += 1

            'Seta Parametros - Descrição 2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sDescricao2 : i += 1

            'Seta Parametros - Item Produção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = True : i += 1

            'Seta Parametros - Código Cor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCor : i += 1

            'Seta Parametros - Código Tipo Alça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_alca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoAlca : i += 1

            'Seta Parametros - Código Volume
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_volume"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoVolume : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto", oSqlParameter)

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

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sRevisao As String, _
                        ByVal sProduto As String, _
                        ByVal lCodigoItem As Long, _
                        ByVal iCodigoGrupoItem As Integer, _
                        ByVal iCodigoMaterial As Integer, _
                        ByVal iCodigoDiametro As Integer, _
                        ByVal iCodigoTamanhoAgulha As Integer, _
                        ByVal iCodigoFormatoAgulha As Integer, _
                        ByVal iCodigoBitola As Integer, _
                        ByVal iCodigoEspecialidade As Integer, _
                        ByVal iCodigoMarca As Integer, _
                        ByVal iCodigoCor As Integer, _
                        ByVal sItemVenda As String, _
                        ByVal sItemCompra As String, _
                        ByVal sItemProducao As String, _
                        ByVal sItemEstoque As String, _
                        ByVal sItemAtivoFixo As String, _
                        ByVal sInsumoProducao As String, _
                        ByVal iAtivo As Integer, _
                        ByVal sTipoUnidadeMedida As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(22) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Revisão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "revisao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sRevisao : i += 1

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoClienteGlobal : i += 1

            'Seta Parametros - Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sProduto : i += 1

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Código Grupo do Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_grupo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoGrupoItem : i += 1

            'Seta Parametros - Código Material
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_material"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoMaterial : i += 1

            'Seta Parametros - Código Diâmetro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_diametro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoDiametro : i += 1

            'Seta Parametros - Código Tamanho Agulha
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tamanho_agulha"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoTamanhoAgulha : i += 1

            'Seta Parametros - Código Formato Agulha
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_formato_agulha"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFormatoAgulha : i += 1

            'Seta Parametros - Código Bitola
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_bitola"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoBitola : i += 1

            'Seta Parametros - Código Especialidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_especialidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoEspecialidade : i += 1

            'Seta Parametros - Código Marca
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_marca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoMarca : i += 1

            'Seta Parametros - Código Cor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCor : i += 1

            'Seta Parametros - Item Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = sItemVenda : i += 1

            'Seta Parametros - Item Compra
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item_compra"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = sItemCompra : i += 1

            'Seta Parametros - Item Produção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = sItemProducao : i += 1

            'Seta Parametros - Item Estoque
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item_estoque"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = sItemEstoque : i += 1

            'Seta Parametros - Item Ativo Fixo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item_ativo_fixo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = sItemAtivoFixo : i += 1

            'Seta Parametros - Insumo Produção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "insumo_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = sInsumoProducao : i += 1

            'Seta Parametros - Tipo Unidade de Medida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo_unidade_medida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Char
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = sTipoUnidadeMedida : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = IIf(iAtivo = -1, DBNull.Value, IIf(iAtivo = 1, True, False))

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_tabela_preco", oSqlParameter)

            'Configurar DataMember
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

    Public Sub LoadGridFind(ByVal oGrid As GridEX, _
                            ByVal iCodigoTipoItem As Integer, _
                            ByVal sItemVenda As String, _
                            ByVal sItemCompra As String, _
                            ByVal sItemProducao As String, _
                            ByVal sItemEstoque As String, _
                            ByVal sItemAtivoFixo As String, _
                            ByVal sInsumoProducao As String, _
                            Optional ByVal iCodigoGrupoItem As Integer = -1)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(8) As SqlParameter
        Dim oSqlParameterAuxiliar(2) As SqlParameter
        Dim oColumn As GridEXColumn
        Dim i As Integer = 0

        Try

            'Exclui Colunas
            For i = oGrid.RootTable.Columns.Count - 1 To 1 Step -1
                If IsNumeric(oGrid.RootTable.Columns(i).Key) Then
                    oGrid.RootTable.Columns.Remove(oGrid.RootTable.Columns(i).Key)
                End If
            Next

            'Seta Parametros - Tipo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoItem : i += 1

            'Seta Parametros - Código Grupo de Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_grupo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoGrupoItem : i += 1

            'Seta Parametros - Item Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = sItemVenda : i += 1

            'Seta Parametros - Item Compra
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item_compra"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = sItemCompra : i += 1

            'Seta Parametros - Item Produção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = sItemProducao : i += 1

            'Seta Parametros - Item Estoque
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item_estoque"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = sItemEstoque : i += 1

            'Seta Parametros - Item Ativo Fixo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item_ativo_fixo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = sItemAtivoFixo : i += 1

            'Seta Parametros - Insumo Produção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "insumo_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = sInsumoProducao : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_find_item", oSqlParameter)

            For Each oDataColumn As DataColumn In oDataSet.Tables(0).Columns

                If IsNumeric(oDataColumn.ColumnName) Then

                    'Seta Váriavel
                    i = 0

                    'Seta Parametros - Código Controle
                    oSqlParameterAuxiliar(i) = New SqlParameter
                    oSqlParameterAuxiliar(i).ParameterName = "codigo_controle"
                    oSqlParameterAuxiliar(i).Direction = ParameterDirection.Input
                    oSqlParameterAuxiliar(i).SqlDbType = SqlDbType.Int
                    oSqlParameterAuxiliar(i).Value = oDataColumn.ColumnName : i += 1

                    'Seta Parametros - Código Grupo de Item
                    oSqlParameterAuxiliar(i) = New SqlParameter
                    oSqlParameterAuxiliar(i).ParameterName = "codigo_grupo_item"
                    oSqlParameterAuxiliar(i).Direction = ParameterDirection.Input
                    oSqlParameterAuxiliar(i).SqlDbType = SqlDbType.Int
                    oSqlParameterAuxiliar(i).Value = iCodigoGrupoItem : i += 1

                    'Seta Parametros - Código Empresa
                    oSqlParameterAuxiliar(i) = New SqlParameter
                    oSqlParameterAuxiliar(i).ParameterName = "codigo_empresa"
                    oSqlParameterAuxiliar(i).Direction = ParameterDirection.Input
                    oSqlParameterAuxiliar(i).SqlDbType = SqlDbType.SmallInt
                    oSqlParameterAuxiliar(i).Value = goUsuario.iEmpresa

                    'Executa Query
                    oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_controle_item", oSqlParameterAuxiliar)

                    While oSqlDataReader.Read

                        oColumn = New GridEXColumn
                        oColumn.Key = oDataColumn.ColumnName
                        oColumn.Caption = Strings.StrConv(oSqlDataReader.Item("descricao").ToString, VbStrConv.ProperCase)
                        oColumn.SelectableCells = SelectableCells.FilterRowCells
                        oColumn.Width = oSqlDataReader.Item("largura")
                        Select Case oSqlDataReader.Item("codigo_tipo_campo")
                            Case TipoCampoControle.Cadastro, TipoCampoControle.CadastroCorrelacionado
                                oColumn.HasValueList = True
                                oColumn.ColumnType = ColumnType.Text
                                oColumn.EditType = EditType.Combo
                            Case TipoCampoControle.SimNao
                                oColumn.ColumnType = ColumnType.CheckBox
                                oColumn.EditType = EditType.CheckBox
                                oColumn.CheckBoxFalseValue = "False"
                                oColumn.CheckBoxTrueValue = "True"
                            Case TipoCampoControle.Numerico
                                oColumn.ColumnType = ColumnType.Text
                                oColumn.MaskPrompt = "Number" & oSqlDataReader.Item("numero_casas_decimais")
                                oColumn.EditType = EditType.TextBox
                            Case TipoCampoControle.Texto : oColumn.ColumnType = ColumnType.Text
                                oColumn.ColumnType = ColumnType.Text
                                oColumn.EditType = EditType.TextBox
                        End Select

                        oGrid.RootTable.Columns.Add(oColumn)

                        'Carrega Combo
                        If oColumn.EditType = EditType.Combo Then
                            Call LoadComboGrid(oGrid, oColumn.Key, "sp_select_combo_cadastro_basico_dados_controle " & oDataColumn.ColumnName.Replace("[", "").Replace("]", "") & ", " & goUsuario.iEmpresa)
                        End If

                    End While

                    'Fecha o SqlDataReader
                    If oSqlDataReader.IsClosed = True Then oSqlDataReader.Close() : oSqlDataReader = Nothing

                End If

            Next

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

            oGrid.MoveToRowIndex(-1)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridFindIndicador(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(8) As SqlParameter
        Dim oSqlParameterAuxiliar(2) As SqlParameter
        Dim oColumn As GridEXColumn
        Dim i As Integer = 0

        Try

            'Exclui Colunas
            For i = oGrid.RootTable.Columns.Count - 1 To 1 Step -1
                If IsNumeric(oGrid.RootTable.Columns(i).Key) Then
                    oGrid.RootTable.Columns.Remove(oGrid.RootTable.Columns(i).Key)
                End If
            Next

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_find_item_indicador", oSqlParameter)
            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

            oGrid.MoveToRowIndex(-1)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridFindServico(ByVal oGrid As GridEX, _
                                   ByVal iCodigoTipoItem As Integer, _
                                   ByVal sItemVenda As String, _
                                   ByVal sItemCompra As String, _
                                   ByVal sItemProducao As String, _
                                   ByVal sItemEstoque As String, _
                                   ByVal sItemAtivoFixo As String, _
                                   ByVal sInsumoProducao As String, _
                                   Optional ByVal iCodigoGrupoItem As Integer = -1)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(8) As SqlParameter
        Dim oSqlParameterAuxiliar(2) As SqlParameter
        Dim oColumn As GridEXColumn
        Dim i As Integer = 0

        Try

            'Exclui Colunas
            For i = oGrid.RootTable.Columns.Count - 1 To 1 Step -1
                If IsNumeric(oGrid.RootTable.Columns(i).Key) Then
                    oGrid.RootTable.Columns.Remove(oGrid.RootTable.Columns(i).Key)
                End If
            Next

            'Seta Parametros - Tipo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoItem : i += 1

            'Seta Parametros - Código Grupo de Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_grupo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoGrupoItem : i += 1

            'Seta Parametros - Item Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = sItemVenda : i += 1

            'Seta Parametros - Item Compra
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item_compra"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = sItemCompra : i += 1

            'Seta Parametros - Item Produção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = sItemProducao : i += 1

            'Seta Parametros - Item Estoque
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item_estoque"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = sItemEstoque : i += 1

            'Seta Parametros - Item Ativo Fixo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item_ativo_fixo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = sItemAtivoFixo : i += 1

            'Seta Parametros - Insumo Produção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "insumo_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = sInsumoProducao : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_find_servico", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

            oGrid.MoveToRowIndex(-1)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadControles(ByVal lCodigoItem As Long,
                             ByVal cboGrupoItem As UIComboBox,
                             ByVal txtCodigoItem As MaskedEditBox,
                             ByVal txtCodigoItem2 As MaskedEditBox,
                             ByVal txtCodigoBarras As MaskedEditBox,
                             ByVal txtDescricao As MaskedEditBox,
                             ByVal cboMarca As UIComboBox,
                             ByVal txtDescricao2 As MaskedEditBox,
                             ByVal txtReferencia As MaskedEditBox,
                             ByVal cboAtivo As UIComboBox,
                             ByVal cboNCM As UIComboBox,
                             ByVal cboInsumoProducao As UIComboBox,
                             ByVal txtPesoLiquido As NumericEditBox,
                             ByVal cboOrigemItem As UIComboBox,
                             ByVal cboTipoItemSped As UIComboBox,
                             ByVal cboCor As UIComboBox,
                             ByVal cboVolume As UIComboBox,
                             ByVal cboTipoAlca As UIComboBox,
                             ByVal txtObservacao As EditBox,
                             ByVal picFoto As PictureBox,
                             ByVal cboUnidadeMedidaVenda As UIComboBox,
                             ByVal txtFatorConversaoUnidadeMedidaVenda As NumericEditBox,
                             ByVal cboFormaVenda As UIComboBox,
                             ByVal cboGrupoItemVenda As UIComboBox,
                             ByVal cboUnidadeMedidaCompra As UIComboBox,
                             ByVal txtFatorConversaoUnidadeMedidaCompra As NumericEditBox,
                             ByVal txtLeadTime As NumericEditBox,
                             ByVal cboNecessitaFornecedorHomologado As UIComboBox,
                             ByVal txtQuantidadeMinima As NumericEditBox,
                             ByVal txtMultiploCompra As NumericEditBox,
                             ByVal txtToleranciaQuantidadeRecebimento As NumericEditBox,
                             ByVal txtToleranciaValorRecebimento As NumericEditBox,
                             ByVal txtToleranciaDiasRecebimento As NumericEditBox,
                             ByVal cboUnidadeMedidaEstoque As UIComboBox,
                             ByVal txtEstoqueMinimo As NumericEditBox,
                             ByVal txtEstoqueMaximo As NumericEditBox,
                             ByVal cboMetodologiaSaidaProdutoEstoque As UIComboBox,
                             ByVal chkControlaLote As UICheckBox,
                             ByVal chkGeraLoteInterno As UICheckBox,
                             ByVal txtCaracterLote As MaskedEditBox,
                             ByVal chkControlaQualidade As UICheckBox,
                             ByVal chkControlaValidade As UICheckBox,
                             ByVal chkControlaDataFabricacao As UICheckBox,
                             ByVal chkControlaTempoMaximoExposicao As UICheckBox,
                             ByVal txtTempoMaximoExposicao As MaskedEditBox,
                             ByVal txtPercentualDesvalorizacao As NumericEditBox,
                             ByVal txtFrequenciaDesvalorizacao As NumericEditBox,
                             ByVal cboTipoAtivoFixo As UIComboBox,
                             ByVal chkItemEstoque As UICheckBox,
                             ByVal chkItemCompra As UICheckBox,
                             ByVal chkItemVenda As UICheckBox,
                             ByVal chkItemProducao As UICheckBox,
                             ByVal chkAtivoFixo As UICheckBox,
                             ByVal txtCor As MaskedEditBox,
                             ByVal txtBitola As NumericEditBox,
                             ByVal txtCodigoIntegracao As NumericEditBox,
                             ByVal txtTipoVenda As MaskedEditBox,
                             ByVal cboNivelInspecao As UIComboBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_dados", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    If IsDBNull(oSqlDataReader.Item("codigo_tipo_item_sped")) Then
                        cboTipoItemSped.SelectedIndex = -1
                    Else
                        cboTipoItemSped.SelectedValue = oSqlDataReader.Item("codigo_tipo_item_sped")
                    End If

                    If IsDBNull(oSqlDataReader.Item("codigo_nivel_inspecao")) Then
                        cboNivelInspecao.SelectedIndex = -1
                    Else
                        cboNivelInspecao.SelectedValue = oSqlDataReader.Item("codigo_nivel_inspecao")
                    End If

                    cboGrupoItem.SelectedValue = oSqlDataReader.Item("codigo_grupo_item")
                    txtCodigoItem.Text = oSqlDataReader.Item("codigo_item")
                    txtCodigoItem2.Text = oSqlDataReader.Item("codigo_item2")
                    txtCodigoBarras.Text = oSqlDataReader.Item("codigo_barras")
                    txtDescricao.Text = oSqlDataReader.Item("descricao")
                    cboMarca.SelectedValue = oSqlDataReader.Item("codigo_marca")
                    txtDescricao2.Text = oSqlDataReader.Item("descricao2")
                    txtReferencia.Text = oSqlDataReader.Item("referencia")
                    cboAtivo.SelectedValue = oSqlDataReader.Item("ativo")
                    cboNCM.SelectedValue = oSqlDataReader.Item("codigo_ncm")
                    txtPesoLiquido.Value = oSqlDataReader.Item("peso_liquido")
                    cboInsumoProducao.SelectedValue = oSqlDataReader.Item("insumo_producao")
                    cboOrigemItem.SelectedValue = oSqlDataReader.Item("codigo_origem_item")
                    cboCor.SelectedValue = oSqlDataReader.Item("codigo_cor")
                    cboVolume.SelectedValue = oSqlDataReader.Item("codigo_volume")
                    cboTipoAlca.SelectedValue = oSqlDataReader.Item("codigo_tipo_alca")
                    txtObservacao.Text = oSqlDataReader.Item("observacao")
                    cboUnidadeMedidaVenda.SelectedValue = oSqlDataReader.Item("codigo_unidade_medida_venda")
                    txtFatorConversaoUnidadeMedidaVenda.Value = oSqlDataReader.Item("fator_conversao_unidade_medida_venda")
                    cboFormaVenda.SelectedValue = oSqlDataReader.Item("codigo_forma_venda_item")
                    cboGrupoItemVenda.SelectedValue = oSqlDataReader.Item("codigo_grupo_item_venda")
                    cboUnidadeMedidaCompra.SelectedValue = oSqlDataReader.Item("codigo_unidade_medida_compra")
                    txtFatorConversaoUnidadeMedidaCompra.Value = oSqlDataReader.Item("fator_conversao_unidade_medida_compra")
                    txtLeadTime.Value = oSqlDataReader.Item("lead_time")
                    cboNecessitaFornecedorHomologado.SelectedValue = oSqlDataReader.Item("necessita_fornecedor_homologado")
                    txtQuantidadeMinima.Value = oSqlDataReader.Item("quantidade_minima")
                    txtMultiploCompra.Value = oSqlDataReader.Item("multiplo_compra")
                    txtToleranciaQuantidadeRecebimento.Value = oSqlDataReader.Item("tolerancia_quantidade_recebimento")
                    txtToleranciaValorRecebimento.Value = oSqlDataReader.Item("tolerancia_valor_recebimento")
                    txtToleranciaDiasRecebimento.Value = oSqlDataReader.Item("tolerancia_dias_recebimento")
                    cboUnidadeMedidaEstoque.SelectedValue = oSqlDataReader.Item("codigo_unidade_medida_estoque")
                    txtEstoqueMinimo.Value = oSqlDataReader.Item("estoque_minimo")
                    txtEstoqueMaximo.Value = oSqlDataReader.Item("estoque_maximo")
                    cboMetodologiaSaidaProdutoEstoque.SelectedValue = oSqlDataReader.Item("codigo_metodologia_saida_produto_estoque")
                    chkControlaLote.Checked = oSqlDataReader.Item("controla_lote")
                    chkGeraLoteInterno.Checked = oSqlDataReader.Item("gera_lote_interno")
                    txtCaracterLote.Text = oSqlDataReader.Item("caracter_lote")
                    chkControlaQualidade.Checked = oSqlDataReader.Item("controla_qualidade")
                    chkControlaValidade.Checked = oSqlDataReader.Item("controla_validade")
                    chkControlaDataFabricacao.Checked = oSqlDataReader.Item("controla_data_fabricacao")
                    chkControlaTempoMaximoExposicao.Checked = oSqlDataReader.Item("controla_tempo_exposicao")
                    txtTempoMaximoExposicao.Text = oSqlDataReader.Item("tempo_maximo_exposicao")
                    txtPercentualDesvalorizacao.Value = oSqlDataReader.Item("percentual_desvalorizacao")
                    txtFrequenciaDesvalorizacao.Value = oSqlDataReader.Item("frequencia_desvalorizacao_dia")
                    cboTipoAtivoFixo.SelectedValue = oSqlDataReader.Item("codigo_tipo_ativo_fixo")
                    chkItemProducao.Checked = oSqlDataReader.Item("item_producao")
                    chkItemEstoque.Checked = oSqlDataReader.Item("item_estoque")
                    chkItemCompra.Checked = oSqlDataReader.Item("item_compra")
                    chkItemVenda.Checked = oSqlDataReader.Item("item_venda")
                    chkAtivoFixo.Checked = oSqlDataReader.Item("item_ativo_fixo")
                    txtCor.Text = oSqlDataReader.Item("cor")
                    txtBitola.Value = oSqlDataReader.Item("bitola")
                    txtCodigoIntegracao.Value = oSqlDataReader.Item("codigo_integracao")
                    txtTipoVenda.Text = oSqlDataReader.Item("tipo_venda")

                    'Carrega Foto
                    If IsDBNull(oSqlDataReader.Item("foto")) = False Then
                        Dim bytBLOBData(oSqlDataReader.GetBytes(1, 0, Nothing, 0, Integer.MaxValue) - 1) As Byte
                        oSqlDataReader.GetBytes(1, 0, bytBLOBData, 0, bytBLOBData.Length)
                        Dim stmBLOBData As New MemoryStream(bytBLOBData)
                        picFoto.Image = Image.FromStream(stmBLOBData)
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

    'Public Sub LoadControlesNFE(ByVal lCodigoItem As Long, _
    '                        ByVal cboGrupoItem As UIComboBox, _
    '                        ByVal txtCodigoItem As MaskedEditBox, _
    '                        ByVal txtCodigoItem2 As MaskedEditBox, _
    '                        ByVal txtCodigoBarras As MaskedEditBox, _
    '                        ByVal txtDescricao As MaskedEditBox, _
    '                        ByVal txtReferencia As MaskedEditBox, _
    '                        ByVal cboAtivo As UIComboBox, _
    '                        ByVal cboNCM As UIComboBox, _
    '                        ByVal cboInsumoProducao As UIComboBox, _
    '                        ByVal txtPesoLiquido As NumericEditBox, _
    '                        ByVal cboOrigemItem As UIComboBox, _
    '                        ByVal cboCor As UIComboBox, _
    '                        ByVal cboVolume As UIComboBox, _
    '                        ByVal cboTipoAlca As UIComboBox, _
    '                        ByVal txtObservacao As EditBox, _
    '                        ByVal chkItemEstoque As UICheckBox, _
    '                        ByVal chkItemCompra As UICheckBox, _
    '                        ByVal chkItemVenda As UICheckBox, _
    '                        ByVal chkItemProducao As UICheckBox, _
    '                        ByVal chkAtivoFixo As UICheckBox)

    '    Variaveis(Locais)
    '    Dim oSqlDataReader As SqlDataReader
    '    Dim oSqlParameter(1) As SqlParameter
    '    Dim i As Integer = 0

    '    Try

    '        Seta Parametros - Código Fornecedor
    '        oSqlParameter(i) = New SqlParameter
    '        oSqlParameter(i).ParameterName = "codigo"
    '        oSqlParameter(i).Direction = ParameterDirection.Input
    '        oSqlParameter(i).SqlDbType = SqlDbType.BigInt
    '        oSqlParameter(i).Value = lCodigoItem : i += 1

    '        Seta Parametros - Codigo Empresa
    '        oSqlParameter(i) = New SqlParameter
    '        oSqlParameter(i).ParameterName = "codigo_empresa"
    '        oSqlParameter(i).Direction = ParameterDirection.Input
    '        oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
    '        oSqlParameter(i).Value = goUsuario.iEmpresa

    '        Executa(Query)
    '        oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_dados", oSqlParameter)

    '        If oSqlDataReader.HasRows Then

    '            While oSqlDataReader.Read

    '                cboGrupoItem.SelectedValue = oSqlDataReader.Item("codigo_grupo_item")
    '                txtCodigoItem.Text = oSqlDataReader.Item("codigo_item")
    '                txtCodigoItem2.Text = oSqlDataReader.Item("codigo_item2")
    '                txtCodigoBarras.Text = oSqlDataReader.Item("codigo_barras")
    '                txtDescricao.Text = oSqlDataReader.Item("descricao")
    '                cboMarca.SelectedValue = oSqlDataReader.Item("codigo_marca")
    '                txtDescricao2.Text = oSqlDataReader.Item("descricao2")
    '                txtReferencia.Text = oSqlDataReader.Item("referencia")
    '                cboAtivo.SelectedValue = oSqlDataReader.Item("ativo")
    '                cboNCM.SelectedValue = oSqlDataReader.Item("codigo_ncm")
    '                txtPesoLiquido.Value = oSqlDataReader.Item("peso_liquido")
    '                cboInsumoProducao.SelectedValue = oSqlDataReader.Item("insumo_producao")
    '                cboOrigemItem.SelectedValue = oSqlDataReader.Item("codigo_origem_item")
    '                cboCor.SelectedValue = oSqlDataReader.Item("codigo_cor")
    '                cboVolume.SelectedValue = oSqlDataReader.Item("codigo_volume")
    '                cboTipoAlca.SelectedValue = oSqlDataReader.Item("codigo_tipo_alca")
    '                txtObservacao.Text = oSqlDataReader.Item("observacao")
    '                cboUnidadeMedidaVenda.SelectedValue = oSqlDataReader.Item("codigo_unidade_medida_venda")
    '                txtFatorConversaoUnidadeMedidaVenda.Value = oSqlDataReader.Item("fator_conversao_unidade_medida_venda")
    '                cboFormaVenda.SelectedValue = oSqlDataReader.Item("codigo_forma_venda_item")
    '                cboGrupoItemVenda.SelectedValue = oSqlDataReader.Item("codigo_grupo_item_venda")
    '                cboUnidadeMedidaCompra.SelectedValue = oSqlDataReader.Item("codigo_unidade_medida_compra")
    '                txtFatorConversaoUnidadeMedidaCompra.Value = oSqlDataReader.Item("fator_conversao_unidade_medida_compra")
    '                txtLeadTime.Value = oSqlDataReader.Item("lead_time")
    '                cboNecessitaFornecedorHomologado.SelectedValue = oSqlDataReader.Item("necessita_fornecedor_homologado")
    '                txtQuantidadeMinima.Value = oSqlDataReader.Item("quantidade_minima")
    '                txtMultiploCompra.Value = oSqlDataReader.Item("multiplo_compra")
    '                txtToleranciaQuantidadeRecebimento.Value = oSqlDataReader.Item("tolerancia_quantidade_recebimento")
    '                txtToleranciaValorRecebimento.Value = oSqlDataReader.Item("tolerancia_valor_recebimento")
    '                txtToleranciaDiasRecebimento.Value = oSqlDataReader.Item("tolerancia_dias_recebimento")
    '                cboUnidadeMedidaEstoque.SelectedValue = oSqlDataReader.Item("codigo_unidade_medida_estoque")
    '                txtEstoqueMinimo.Value = oSqlDataReader.Item("estoque_minimo")
    '                txtEstoqueMaximo.Value = oSqlDataReader.Item("estoque_maximo")
    '                cboMetodologiaSaidaProdutoEstoque.SelectedValue = oSqlDataReader.Item("codigo_metodologia_saida_produto_estoque")
    '                chkControlaLote.Checked = oSqlDataReader.Item("controla_lote")
    '                chkGeraLoteInterno.Checked = oSqlDataReader.Item("gera_lote_interno")
    '                txtCaracterLote.Text = oSqlDataReader.Item("caracter_lote")
    '                chkControlaQualidade.Checked = oSqlDataReader.Item("controla_qualidade")
    '                chkControlaValidade.Checked = oSqlDataReader.Item("controla_validade")
    '                chkControlaDataFabricacao.Checked = oSqlDataReader.Item("controla_data_fabricacao")
    '                chkControlaTempoMaximoExposicao.Checked = oSqlDataReader.Item("controla_tempo_exposicao")
    '                txtTempoMaximoExposicao.Text = oSqlDataReader.Item("tempo_maximo_exposicao")
    '                txtPercentualDesvalorizacao.Value = oSqlDataReader.Item("percentual_desvalorizacao")
    '                txtFrequenciaDesvalorizacao.Value = oSqlDataReader.Item("frequencia_desvalorizacao_dia")
    '                cboTipoAtivoFixo.SelectedValue = oSqlDataReader.Item("codigo_tipo_ativo_fixo")
    '                chkItemProducao.Checked = oSqlDataReader.Item("item_producao")
    '                chkItemEstoque.Checked = oSqlDataReader.Item("item_estoque")
    '                chkItemCompra.Checked = oSqlDataReader.Item("item_compra")
    '                chkItemVenda.Checked = oSqlDataReader.Item("item_venda")
    '                chkAtivoFixo.Checked = oSqlDataReader.Item("item_ativo_fixo")

    '                Carrega(Foto)
    '                If IsDBNull(oSqlDataReader.Item("foto")) = False Then
    '                    Dim bytBLOBData(oSqlDataReader.GetBytes(1, 0, Nothing, 0, Integer.MaxValue) - 1) As Byte
    '                    oSqlDataReader.GetBytes(1, 0, bytBLOBData, 0, bytBLOBData.Length)
    '                    Dim stmBLOBData As New MemoryStream(bytBLOBData)
    '                    picFoto.Image = Image.FromStream(stmBLOBData)
    '                End If

    '            End While

    '        End If

    '        Fecha o DataReader
    '        If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

    '    Catch SqlEx As SqlException
    '        Throw SqlEx
    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    'End Sub

    'Public Sub LoadControles(ByVal lCodigoItem As Long, _
    '                         ByVal cboGrupoItem As UIComboBox, _
    '                         ByVal txtCodigoItem As MaskedEditBox, _
    '                         ByVal txtCodigoItem2 As MaskedEditBox, _
    '                         ByVal txtCodigoBarras As MaskedEditBox, _
    '                         ByVal txtDescricao As MaskedEditBox, _
    '                         ByVal cboMarca As UIComboBox, _
    '                         ByVal txtDescricao2 As MaskedEditBox, _
    '                         ByVal txtReferencia As MaskedEditBox, _
    '                         ByVal txtRegistroAnvisa As MaskedEditBox, _
    '                         ByVal cboAtivo As UIComboBox, _
    '                         ByVal cboNCM As UIComboBox, _
    '                         ByVal txtPesoLiquido As NumericEditBox, _
    '                         ByVal cboOrigemItem As UIComboBox, _
    '                         ByVal txtObservacao As EditBox, _
    '                         ByVal picFoto As PictureBox, _
    '                         ByVal cboUnidadeMedidaVenda As UIComboBox, _
    '                         ByVal cboFormaVenda As UIComboBox, _
    '                         ByVal cboGrupoItemVenda As UIComboBox, _
    '                         ByVal cboUnidadeMedidaCompra As UIComboBox, _
    '                         ByVal txtLeadTime As NumericEditBox, _
    '                         ByVal cboNecessitaFornecedorHomologado As UIComboBox, _
    '                         ByVal txtQuantidadeMinima As NumericEditBox, _
    '                         ByVal txtMultiploCompra As NumericEditBox, _
    '                         ByVal txtToleranciaQuantidadeRecebimento As NumericEditBox, _
    '                         ByVal txtToleranciaValorRecebimento As NumericEditBox, _
    '                         ByVal txtToleranciaDiasRecebimento As NumericEditBox, _
    '                         ByVal cboUnidadeMedidaEstoque As UIComboBox, _
    '                         ByVal txtEstoqueMinimo As NumericEditBox, _
    '                         ByVal txtEstoqueMaximo As NumericEditBox, _
    '                         ByVal cboMetodologiaSaidaProdutoEstoque As UIComboBox, _
    '                         ByVal chkControlaQualidade As UICheckBox, _
    '                         ByVal chkControlaLote As UICheckBox, _
    '                         ByVal chkGeraLoteInterno As UICheckBox, _
    '                         ByVal txtCaracterLote As MaskedEditBox, _
    '                         ByVal chkControlaValidade As UICheckBox, _
    '                         ByVal chkControlaDataFabricacao As UICheckBox, _
    '                         ByVal chkControlaTempoExposicao As UICheckBox, _
    '                         ByVal txtTempoMaximoExposicao As MaskedEditBox, _
    '                         ByVal txtPercentualDesvalorizacao As NumericEditBox, _
    '                         ByVal txtFrequenciaDesvalorizacao As NumericEditBox, _
    '                         ByVal cboTipoAtivoFixo As UIComboBox, _
    '                         ByVal chkItemEstoque As UICheckBox, _
    '                         ByVal chkItemCompra As UICheckBox, _
    '                         ByVal chkItemVenda As UICheckBox, _
    '                         ByVal chkItemProducao As UICheckBox, _
    '                         ByVal chkAtivoFixo As UICheckBox, _
    '                         ByVal cboMaterial As UIComboBox, _
    '                         ByVal cboEspecialidade As UIComboBox, _
    '                         ByVal cboDiametro As UIComboBox, _
    '                         ByVal cboComprimento As UIComboBox, _
    '                         ByVal cboCor As UIComboBox, _
    '                         ByVal cboBitola As UIComboBox, _
    '                         ByVal cboTamanhoAgulha As UIComboBox, _
    '                         ByVal cboFormatoAgulha As UIComboBox, _
    '                         ByVal cboAgulhaSutura As UIComboBox)

    '    'Variaveis Locais
    '    Dim oSqlDataReader As SqlDataReader
    '    Dim oSqlParameter(1) As SqlParameter
    '    Dim i As Integer = 0

    '    Try

    '        'Seta Parametros - Código Fornecedor
    '        oSqlParameter(i) = New SqlParameter
    '        oSqlParameter(i).ParameterName = "codigo"
    '        oSqlParameter(i).Direction = ParameterDirection.Input
    '        oSqlParameter(i).SqlDbType = SqlDbType.BigInt
    '        oSqlParameter(i).Value = lCodigoItem : i += 1

    '        'Seta Parametros - Codigo Empresa
    '        oSqlParameter(i) = New SqlParameter
    '        oSqlParameter(i).ParameterName = "codigo_empresa"
    '        oSqlParameter(i).Direction = ParameterDirection.Input
    '        oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
    '        oSqlParameter(i).Value = goUsuario.iEmpresa

    '        'Executa Query
    '        oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_dados", oSqlParameter)

    '        If oSqlDataReader.HasRows Then

    '            While oSqlDataReader.Read

    '                cboGrupoItem.SelectedValue = oSqlDataReader.Item("codigo_grupo_item")
    '                txtCodigoItem.Text = oSqlDataReader.Item("codigo_item")
    '                txtCodigoItem2.Text = oSqlDataReader.Item("codigo_item2")
    '                txtCodigoBarras.Text = oSqlDataReader.Item("codigo_barras")
    '                txtDescricao.Text = oSqlDataReader.Item("descricao")
    '                cboMarca.SelectedValue = oSqlDataReader.Item("codigo_marca")
    '                txtDescricao2.Text = oSqlDataReader.Item("descricao2")
    '                txtReferencia.Text = oSqlDataReader.Item("referencia")
    '                txtRegistroAnvisa.Text = oSqlDataReader.Item("registro_anvisa")
    '                cboAtivo.SelectedValue = oSqlDataReader.Item("ativo")
    '                cboNCM.SelectedValue = oSqlDataReader.Item("codigo_ncm")
    '                txtPesoLiquido.Value = oSqlDataReader.Item("peso_liquido")
    '                cboOrigemItem.SelectedValue = oSqlDataReader.Item("codigo_origem_item")
    '                txtObservacao.Text = oSqlDataReader.Item("observacao")
    '                cboUnidadeMedidaVenda.SelectedValue = oSqlDataReader.Item("codigo_unidade_medida_venda")
    '                cboFormaVenda.SelectedValue = oSqlDataReader.Item("codigo_forma_venda_item")
    '                cboGrupoItemVenda.SelectedValue = oSqlDataReader.Item("codigo_grupo_item_venda")
    '                cboUnidadeMedidaCompra.SelectedValue = oSqlDataReader.Item("codigo_unidade_medida_compra")
    '                txtLeadTime.Value = oSqlDataReader.Item("lead_time")
    '                cboNecessitaFornecedorHomologado.SelectedValue = oSqlDataReader.Item("necessita_fornecedor_homologado")
    '                txtQuantidadeMinima.Value = oSqlDataReader.Item("quantidade_minima")
    '                txtMultiploCompra.Value = oSqlDataReader.Item("multiplo_compra")
    '                txtToleranciaQuantidadeRecebimento.Value = oSqlDataReader.Item("tolerancia_quantidade_recebimento")
    '                txtToleranciaValorRecebimento.Value = oSqlDataReader.Item("tolerancia_valor_recebimento")
    '                txtToleranciaDiasRecebimento.Value = oSqlDataReader.Item("tolerancia_dias_recebimento")
    '                cboUnidadeMedidaEstoque.SelectedValue = oSqlDataReader.Item("codigo_unidade_medida_estoque")
    '                txtEstoqueMinimo.Value = oSqlDataReader.Item("estoque_minimo")
    '                txtEstoqueMaximo.Value = oSqlDataReader.Item("estoque_maximo")
    '                cboMetodologiaSaidaProdutoEstoque.SelectedValue = oSqlDataReader.Item("codigo_metodologia_saida_produto_estoque")
    '                chkControlaQualidade.Checked = oSqlDataReader.Item("controla_qualidade")
    '                chkControlaLote.Checked = oSqlDataReader.Item("controla_lote")
    '                chkGeraLoteInterno.Checked = oSqlDataReader.Item("gera_lote_interno")
    '                txtCaracterLote.Text = oSqlDataReader.Item("caracter_lote")
    '                chkControlaValidade.Checked = oSqlDataReader.Item("controla_validade")
    '                chkControlaDataFabricacao.Checked = oSqlDataReader.Item("controla_data_fabricacao")
    '                txtPercentualDesvalorizacao.Value = oSqlDataReader.Item("percentual_desvalorizacao")
    '                txtFrequenciaDesvalorizacao.Value = oSqlDataReader.Item("frequencia_desvalorizacao_dia")
    '                cboTipoAtivoFixo.SelectedValue = oSqlDataReader.Item("codigo_tipo_ativo_fixo")
    '                chkItemProducao.Checked = oSqlDataReader.Item("item_producao")
    '                chkItemEstoque.Checked = oSqlDataReader.Item("item_estoque")
    '                chkItemCompra.Checked = oSqlDataReader.Item("item_compra")
    '                chkItemVenda.Checked = oSqlDataReader.Item("item_venda")
    '                chkAtivoFixo.Checked = oSqlDataReader.Item("item_ativo_fixo")
    '                cboMaterial.SelectedValue = oSqlDataReader.Item("codigo_material")
    '                cboEspecialidade.SelectedValue = oSqlDataReader.Item("codigo_especialidade")
    '                cboDiametro.SelectedValue = oSqlDataReader.Item("codigo_diametro_fio")
    '                cboComprimento.SelectedValue = oSqlDataReader.Item("codigo_comprimento_fio")
    '                cboCor.SelectedValue = oSqlDataReader.Item("codigo_cor_fio")
    '                cboBitola.SelectedValue = oSqlDataReader.Item("codigo_bitola")
    '                cboTamanhoAgulha.SelectedValue = oSqlDataReader.Item("codigo_tamanho_agulha")
    '                cboFormatoAgulha.SelectedValue = oSqlDataReader.Item("codigo_formato_agulha")
    '                cboAgulhaSutura.SelectedValue = oSqlDataReader.Item("agulha_sutura")

    '                'Carrega Foto
    '                If IsDBNull(oSqlDataReader.Item("foto")) = False Then
    '                    Dim bytBLOBData(oSqlDataReader.GetBytes(1, 0, Nothing, 0, Integer.MaxValue) - 1) As Byte
    '                    oSqlDataReader.GetBytes(1, 0, bytBLOBData, 0, bytBLOBData.Length)
    '                    Dim stmBLOBData As New MemoryStream(bytBLOBData)
    '                    picFoto.Image = Image.FromStream(stmBLOBData)
    '                End If

    '            End While

    '        End If

    '        'Fecha o DataReader
    '        If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

    '    Catch SqlEx As SqlException
    '        Throw SqlEx
    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    'End Sub

    Public Sub LoadControlesDimensao(ByVal lCodigoItem As Long, _
                             ByVal cboUnidadeMedida As UIComboBox, _
                             ByVal lblComprimento As Label, _
                             ByVal lblLargura As Label, _
                             ByVal lblAltura As Label, _
                             ByVal txtComprimento As NumericEditBox, _
                             ByVal txtLargura As NumericEditBox, _
                             ByVal txtAltura As NumericEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Unidade Medida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = cboUnidadeMedida.SelectedValue : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_dados_dimensao", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read


                    lblComprimento.Text = oSqlDataReader.Item("label_comprimento")
                    lblLargura.Text = oSqlDataReader.Item("label_largura")
                    lblAltura.Text = oSqlDataReader.Item("label_altura")

                    txtComprimento.Text = 0
                    txtLargura.Text = 0
                    txtAltura.Text = 0


                    If lblComprimento.Text = "" Then
                        lblComprimento.Visible = False
                        txtComprimento.Visible = False
                    Else
                        lblComprimento.Visible = True
                        txtComprimento.Visible = True
                        txtComprimento.ReadOnly = False
                        txtComprimento.Enabled = True

                    End If

                    If lblLargura.Text = "" Then
                        lblLargura.Visible = False
                        txtLargura.Visible = False
                    Else
                        lblLargura.Visible = True
                        txtLargura.Visible = True
                        txtLargura.ReadOnly = False
                        txtLargura.Enabled = True
                    End If


                    If lblAltura.Text = "" Then
                        lblAltura.Visible = False
                        txtAltura.Visible = False
                    Else
                        lblAltura.Visible = True
                        txtAltura.Visible = True
                        txtAltura.ReadOnly = False
                        txtAltura.Enabled = True
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

    'Public Sub LoadControles(ByVal lCodigoItem As Long, _
    '                         ByVal cboGrupoItem As UIComboBox, _
    '                         ByVal txtCodigoItem As MaskedEditBox, _
    '                         ByVal txtCodigoItem2 As MaskedEditBox, _
    '                         ByVal txtCodigoBarras As MaskedEditBox, _
    '                         ByVal txtDescricao As MaskedEditBox, _
    '                         ByVal cboMarca As UIComboBox, _
    '                         ByVal txtDescricao2 As MaskedEditBox, _
    '                         ByVal txtReferencia As MaskedEditBox, _
    '                         ByVal cboAtivo As UIComboBox, _
    '                         ByVal cboNCM As UIComboBox, _
    '                         ByVal cboInsumoProducao As UIComboBox, _
    '                         ByVal txtPesoLiquido As NumericEditBox, _
    '                         ByVal cboOrigemItem As UIComboBox, _
    '                         ByVal txtObservacao As EditBox, _
    '                         ByVal picFoto As PictureBox, _
    '                         ByVal cboUnidadeMedidaVenda As UIComboBox, _
    '                         ByVal txtFatorConversaoUnidadeMedidaVenda As NumericEditBox, _
    '                         ByVal cboFormaVenda As UIComboBox, _
    '                         ByVal cboGrupoItemVenda As UIComboBox, _
    '                         ByVal cboUnidadeMedidaCompra As UIComboBox, _
    '                         ByVal txtFatorConversaoUnidadeMedidaCompra As NumericEditBox, _
    '                         ByVal txtLeadTime As NumericEditBox, _
    '                         ByVal cboNecessitaFornecedorHomologado As UIComboBox, _
    '                         ByVal txtQuantidadeMinima As NumericEditBox, _
    '                         ByVal txtMultiploCompra As NumericEditBox, _
    '                         ByVal txtToleranciaQuantidadeRecebimento As NumericEditBox, _
    '                         ByVal txtToleranciaValorRecebimento As NumericEditBox, _
    '                         ByVal txtToleranciaDiasRecebimento As NumericEditBox, _
    '                         ByVal cboUnidadeMedidaEstoque As UIComboBox, _
    '                         ByVal txtEstoqueMinimo As NumericEditBox, _
    '                         ByVal txtEstoqueMaximo As NumericEditBox, _
    '                         ByVal cboMetodologiaSaidaProdutoEstoque As UIComboBox, _
    '                         ByVal chkControlaLote As UICheckBox, _
    '                         ByVal chkGeraLoteInterno As UICheckBox, _
    '                         ByVal txtCaracterLote As MaskedEditBox, _
    '                         ByVal chkControlaQualidade As UICheckBox, _
    '                         ByVal chkControlaValidade As UICheckBox, _
    '                         ByVal chkControlaDataFabricacao As UICheckBox, _
    '                         ByVal chkControlaTempoMaximoExposicao As UICheckBox, _
    '                         ByVal txtTempoMaximoExposicao As MaskedEditBox, _
    '                         ByVal txtPercentualDesvalorizacao As NumericEditBox, _
    '                         ByVal txtFrequenciaDesvalorizacao As NumericEditBox, _
    '                         ByVal cboTipoAtivoFixo As UIComboBox, _
    '                         ByVal chkItemEstoque As UICheckBox, _
    '                         ByVal chkItemCompra As UICheckBox, _
    '                         ByVal chkItemVenda As UICheckBox, _
    '                         ByVal chkItemProducao As UICheckBox, _
    '                         ByVal chkAtivoFixo As UICheckBox, _
    '                         ByVal txtDiametro As MaskedEditBox, _
    '                         ByVal txtModelo As MaskedEditBox, _
    '                         ByVal txtPressaoEntrada As MaskedEditBox, _
    '                         ByVal txtPressaoSaida As MaskedEditBox, _
    '                         ByVal txtFluido As MaskedEditBox, _
    '                         ByVal txtTemperaturaInicial As NumericEditBox, _
    '                         ByVal txtTemperaturaFinal As NumericEditBox, _
    '                         ByVal txtVazao As MaskedEditBox, _
    '                         ByVal txtTempoReposicaoMes As NumericEditBox, _
    '                         ByVal txtFabricanteLMTerm As MaskedEditBox, _
    '                         ByVal txtModeloLMTerm As MaskedEditBox, _
    '                         ByVal txtLarguraLMTerm As NumericEditBox, _
    '                         ByVal txtAlturaLMTerm As NumericEditBox, _
    '                         ByVal txtComprimentoLMTerm As NumericEditBox, _
    '                         ByVal txtDiametroInternoLMTerm As NumericEditBox, _
    '                         ByVal txtDiametroExternoLMTerm As NumericEditBox, _
    '                         ByVal txtDiametroNominalLMTerm As NumericEditBox, _
    '                         ByVal txtMaterialLMTerm As MaskedEditBox, _
    '                         ByVal txtNumeroSerieLMTerm As MaskedEditBox, _
    '                         ByVal txtTensaoLMTerm As NumericEditBox, _
    '                         ByVal txtPotenciaLMTerm As NumericEditBox, _
    '                         ByVal txtCorrenteLMTerm As NumericEditBox, _
    '                         ByVal txtCapacidadeLMTerm As NumericEditBox, _
    '                         ByVal txtObservacaoLMTerm As EditBox)

    '    'Variaveis Locais
    '    Dim oSqlDataReader As SqlDataReader
    '    Dim oSqlParameter(1) As SqlParameter
    '    Dim i As Integer = 0

    '    Try

    '        'Seta Parametros - Código Fornecedor
    '        oSqlParameter(i) = New SqlParameter
    '        oSqlParameter(i).ParameterName = "codigo"
    '        oSqlParameter(i).Direction = ParameterDirection.Input
    '        oSqlParameter(i).SqlDbType = SqlDbType.BigInt
    '        oSqlParameter(i).Value = lCodigoItem : i += 1

    '        'Seta Parametros - Codigo Empresa
    '        oSqlParameter(i) = New SqlParameter
    '        oSqlParameter(i).ParameterName = "codigo_empresa"
    '        oSqlParameter(i).Direction = ParameterDirection.Input
    '        oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
    '        oSqlParameter(i).Value = goUsuario.iEmpresa

    '        'Executa Query
    '        oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_dados", oSqlParameter)

    '        If oSqlDataReader.HasRows Then

    '            While oSqlDataReader.Read

    '                cboGrupoItem.SelectedValue = oSqlDataReader.Item("codigo_grupo_item")
    '                txtCodigoItem.Text = oSqlDataReader.Item("codigo_item")
    '                txtCodigoItem2.Text = oSqlDataReader.Item("codigo_item2")
    '                txtCodigoBarras.Text = oSqlDataReader.Item("codigo_barras")
    '                txtDescricao.Text = oSqlDataReader.Item("descricao")
    '                cboMarca.SelectedValue = oSqlDataReader.Item("codigo_marca")
    '                txtDescricao2.Text = oSqlDataReader.Item("descricao2")
    '                txtReferencia.Text = oSqlDataReader.Item("referencia")
    '                cboAtivo.SelectedValue = oSqlDataReader.Item("ativo")
    '                cboNCM.SelectedValue = oSqlDataReader.Item("codigo_ncm")
    '                txtPesoLiquido.Value = oSqlDataReader.Item("peso_liquido")
    '                cboInsumoProducao.SelectedValue = oSqlDataReader.Item("insumo_producao")
    '                cboOrigemItem.SelectedValue = oSqlDataReader.Item("codigo_origem_item")
    '                txtObservacao.Text = oSqlDataReader.Item("observacao")
    '                cboUnidadeMedidaVenda.SelectedValue = oSqlDataReader.Item("codigo_unidade_medida_venda")
    '                txtFatorConversaoUnidadeMedidaVenda.Value = oSqlDataReader.Item("fator_conversao_unidade_medida_venda")
    '                cboFormaVenda.SelectedValue = oSqlDataReader.Item("codigo_forma_venda_item")
    '                cboGrupoItemVenda.SelectedValue = oSqlDataReader.Item("codigo_grupo_item_venda")
    '                cboUnidadeMedidaCompra.SelectedValue = oSqlDataReader.Item("codigo_unidade_medida_compra")
    '                txtFatorConversaoUnidadeMedidaCompra.Value = oSqlDataReader.Item("fator_conversao_unidade_medida_compra")
    '                txtLeadTime.Value = oSqlDataReader.Item("lead_time")
    '                cboNecessitaFornecedorHomologado.SelectedValue = oSqlDataReader.Item("necessita_fornecedor_homologado")
    '                txtQuantidadeMinima.Value = oSqlDataReader.Item("quantidade_minima")
    '                txtMultiploCompra.Value = oSqlDataReader.Item("multiplo_compra")
    '                txtToleranciaQuantidadeRecebimento.Value = oSqlDataReader.Item("tolerancia_quantidade_recebimento")
    '                txtToleranciaValorRecebimento.Value = oSqlDataReader.Item("tolerancia_valor_recebimento")
    '                txtToleranciaDiasRecebimento.Value = oSqlDataReader.Item("tolerancia_dias_recebimento")
    '                cboUnidadeMedidaEstoque.SelectedValue = oSqlDataReader.Item("codigo_unidade_medida_estoque")
    '                txtEstoqueMinimo.Value = oSqlDataReader.Item("estoque_minimo")
    '                txtEstoqueMaximo.Value = oSqlDataReader.Item("estoque_maximo")
    '                cboMetodologiaSaidaProdutoEstoque.SelectedValue = oSqlDataReader.Item("codigo_metodologia_saida_produto_estoque")
    '                chkControlaLote.Checked = oSqlDataReader.Item("controla_lote")
    '                chkGeraLoteInterno.Checked = oSqlDataReader.Item("gera_lote_interno")
    '                txtCaracterLote.Text = oSqlDataReader.Item("caracter_lote")
    '                chkControlaQualidade.Checked = oSqlDataReader.Item("controla_qualidade")
    '                chkControlaValidade.Checked = oSqlDataReader.Item("controla_validade")
    '                chkControlaDataFabricacao.Checked = oSqlDataReader.Item("controla_data_fabricacao")
    '                chkControlaTempoMaximoExposicao.Checked = oSqlDataReader.Item("controla_tempo_exposicao")
    '                txtTempoMaximoExposicao.Text = oSqlDataReader.Item("tempo_maximo_exposicao")
    '                txtPercentualDesvalorizacao.Value = oSqlDataReader.Item("percentual_desvalorizacao")
    '                txtFrequenciaDesvalorizacao.Value = oSqlDataReader.Item("frequencia_desvalorizacao_dia")
    '                cboTipoAtivoFixo.SelectedValue = oSqlDataReader.Item("codigo_tipo_ativo_fixo")
    '                chkItemProducao.Checked = oSqlDataReader.Item("item_producao")
    '                chkItemEstoque.Checked = oSqlDataReader.Item("item_estoque")
    '                chkItemCompra.Checked = oSqlDataReader.Item("item_compra")
    '                chkItemVenda.Checked = oSqlDataReader.Item("item_venda")
    '                chkAtivoFixo.Checked = oSqlDataReader.Item("item_ativo_fixo")
    '                txtDiametro.Text = oSqlDataReader.Item("diametro_disparco")
    '                txtModelo.Text = oSqlDataReader.Item("modelo_disparco")
    '                txtPressaoEntrada.Text = oSqlDataReader.Item("pressao_entrada_disparco")
    '                txtPressaoSaida.Text = oSqlDataReader.Item("pressao_saida_disparco")
    '                txtFluido.Text = oSqlDataReader.Item("fluido_disparco")
    '                txtTemperaturaInicial.Value = oSqlDataReader.Item("temperatura_inicial_disparco")
    '                txtTemperaturaFinal.Value = oSqlDataReader.Item("temperatura_final_disparco")
    '                txtVazao.Text = oSqlDataReader.Item("vazao_disparco")
    '                txtTempoReposicaoMes.Value = oSqlDataReader.Item("tempo_reposicao_mes_disparco")
    '                txtFabricanteLMTerm.Text = oSqlDataReader.Item("fabricante_lmterm")
    '                txtModeloLMTerm.Text = oSqlDataReader.Item("modelo_lmterm")
    '                txtLarguraLMTerm.Value = oSqlDataReader.Item("largura_lmterm")
    '                txtAlturaLMTerm.Value = oSqlDataReader.Item("altura_lmterm")
    '                txtComprimentoLMTerm.Value = oSqlDataReader.Item("comprimento_lmterm")
    '                txtDiametroInternoLMTerm.Value = oSqlDataReader.Item("diametro_interno_lmterm")
    '                txtDiametroExternoLMTerm.Value = oSqlDataReader.Item("diametro_externo_lmterm")
    '                txtDiametroNominalLMTerm.Value = oSqlDataReader.Item("diametro_nominal_lmterm")
    '                txtMaterialLMTerm.Text = oSqlDataReader.Item("material_lmterm")
    '                txtNumeroSerieLMTerm.Text = oSqlDataReader.Item("numero_serie_lmterm")
    '                txtTensaoLMTerm.Value = oSqlDataReader.Item("tensao_lmterm")
    '                txtPotenciaLMTerm.Value = oSqlDataReader.Item("potencia_lmterm")
    '                txtCorrenteLMTerm.Value = oSqlDataReader.Item("corrente_lmterm")
    '                txtCapacidadeLMTerm.Value = oSqlDataReader.Item("capacidade_lmterm")
    '                txtObservacaoLMTerm.Text = oSqlDataReader.Item("observacao_lmterm")

    '                'Carrega Foto
    '                If IsDBNull(oSqlDataReader.Item("foto")) = False Then
    '                    Dim bytBLOBData(oSqlDataReader.GetBytes(1, 0, Nothing, 0, Integer.MaxValue) - 1) As Byte
    '                    oSqlDataReader.GetBytes(1, 0, bytBLOBData, 0, bytBLOBData.Length)
    '                    Dim stmBLOBData As New MemoryStream(bytBLOBData)
    '                    picFoto.Image = Image.FromStream(stmBLOBData)
    '                End If

    '            End While

    '        End If

    '        'Fecha o DataReader
    '        If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

    '    Catch SqlEx As SqlException
    '        Throw SqlEx
    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    'End Sub

    Public Sub LoadControles(ByVal lCodigoItem As Long,
                             ByVal cboGrupoItem As UIComboBox,
                             ByVal txtCodigoItem As MaskedEditBox,
                             ByVal txtCodigoItem2 As MaskedEditBox,
                             ByVal txtCodigoBarras As MaskedEditBox,
                             ByVal txtDescricao As MaskedEditBox,
                             ByVal cboMarca As UIComboBox,
                             ByVal txtDescricao2 As MaskedEditBox,
                             ByVal txtReferencia As MaskedEditBox,
                             ByVal cboAtivo As UIComboBox,
                             ByVal cboNCM As UIComboBox,
                             ByVal cboInsumoProducao As UIComboBox,
                             ByVal txtPesoLiquido As NumericEditBox,
                             ByVal cboOrigemItem As UIComboBox,
                             ByVal cboTipoItemSped As UIComboBox,
                             ByVal txtObservacao As EditBox,
                             ByVal picFoto As PictureBox,
                             ByVal cboUnidadeMedidaVenda As UIComboBox,
                             ByVal cboFormaVenda As UIComboBox,
                             ByVal cboGrupoItemVenda As UIComboBox,
                             ByVal cboUnidadeMedidaCompra As UIComboBox,
                             ByVal txtLeadTime As NumericEditBox,
                             ByVal cboNecessitaFornecedorHomologado As UIComboBox,
                             ByVal txtQuantidadeMinima As NumericEditBox,
                             ByVal txtMultiploCompra As NumericEditBox,
                             ByVal txtToleranciaQuantidadeRecebimento As NumericEditBox,
                             ByVal txtToleranciaValorRecebimento As NumericEditBox,
                             ByVal txtToleranciaDiasRecebimento As NumericEditBox,
                             ByVal cboUnidadeMedidaEstoque As UIComboBox,
                             ByVal txtEstoqueMinimo As NumericEditBox,
                             ByVal txtEstoqueMaximo As NumericEditBox,
                             ByVal cboMetodologiaSaidaProdutoEstoque As UIComboBox,
                             ByVal chkControlaLote As UICheckBox,
                             ByVal chkGeraLoteInterno As UICheckBox,
                             ByVal txtCaracterLote As MaskedEditBox,
                             ByVal chkControlaQualidade As UICheckBox,
                             ByVal chkControlaValidade As UICheckBox,
                             ByVal chkControlaDataFabricacao As UICheckBox,
                             ByVal chkControlaTempoMaximoExposicao As UICheckBox,
                             ByVal txtTempoMaximoExposicao As MaskedEditBox,
                             ByVal txtPercentualDesvalorizacao As NumericEditBox,
                             ByVal txtFrequenciaDesvalorizacao As NumericEditBox,
                             ByVal cboTipoAtivoFixo As UIComboBox,
                             ByVal chkItemEstoque As UICheckBox,
                             ByVal chkItemCompra As UICheckBox,
                             ByVal chkItemVenda As UICheckBox,
                             ByVal chkItemProducao As UICheckBox,
                             ByVal chkAtivoFixo As UICheckBox,
                             ByVal txtValor As NumericEditBox,
                             ByVal txtCor As MaskedEditBox,
                             ByVal txtBitola As NumericEditBox,
                             ByVal txtCodigoIntegracao As NumericEditBox,
                             ByVal txtTipoVenda As MaskedEditBox,
                             ByVal txtVidaUtilBem As NumericEditBox,
                             ByVal txtTaxaDepreciacaoAnual As NumericEditBox,
                             ByVal txtTaxaDepreciacaoMensal As NumericEditBox,
                             ByVal txtValorBem As NumericEditBox,
                             ByVal txtValorImpostosRecuperaveis As NumericEditBox,
                             ByVal txtValorResidual As NumericEditBox,
                             ByVal txtValorDepreciavel As NumericEditBox,
                             ByVal txtValorDepreciacaoAnual As NumericEditBox,
                             ByVal txtValorDepreciacaoMensal As NumericEditBox,
                             ByVal txtControlePatrimonial As MaskedEditBox,
                             ByVal cboNivelInspecao As UIComboBox,
                             ByVal txtEstoqueMinimoUsoConsumo As NumericEditBox,
                             ByVal cboUnidadeMedidaUsoConsumo As UIComboBox,
                             ByVal cboTipoPerfil As UIComboBox,
                             ByVal cboMaterial As UIComboBox,
                             ByVal txtMedida1 As NumericEditBox,
                             ByVal txtMedida2 As NumericEditBox,
                             ByVal txtMedida3 As NumericEditBox,
                             ByVal txtMedida4 As NumericEditBox,
                             ByVal cboUnidadeMedidaDimensao As UIComboBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_dados", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    If IsDBNull(oSqlDataReader.Item("codigo_tipo_item_sped")) Then
                        cboTipoItemSped.SelectedIndex = -1
                    Else
                        cboTipoItemSped.SelectedValue = oSqlDataReader.Item("codigo_tipo_item_sped")
                    End If

                    If IsDBNull(oSqlDataReader.Item("codigo_nivel_inspecao")) Then
                        cboNivelInspecao.SelectedIndex = -1
                    Else
                        cboNivelInspecao.SelectedValue = oSqlDataReader.Item("codigo_nivel_inspecao")
                    End If

                    If IsDBNull(oSqlDataReader.Item("codigo_tipo_perfil")) Then
                        cboTipoPerfil.SelectedIndex = -1
                    Else
                        cboTipoPerfil.SelectedValue = oSqlDataReader.Item("codigo_tipo_perfil")
                    End If

                    If IsDBNull(oSqlDataReader.Item("codigo_material")) Then
                        cboMaterial.SelectedIndex = -1
                    Else
                        cboMaterial.SelectedValue = oSqlDataReader.Item("codigo_material")
                    End If

                    If IsDBNull(oSqlDataReader.Item("codigo_unidade_medida_dimensao")) Then
                        cboUnidadeMedidaDimensao.SelectedIndex = -1
                    Else
                        cboUnidadeMedidaDimensao.SelectedValue = oSqlDataReader.Item("codigo_unidade_medida_dimensao")
                    End If

                    txtMedida1.Value = oSqlDataReader("medida1")
                    txtMedida2.Value = oSqlDataReader("medida2")
                    txtMedida3.Value = oSqlDataReader("medida3")
                    txtMedida4.Value = oSqlDataReader("medida4")

                    cboGrupoItem.SelectedValue = oSqlDataReader.Item("codigo_grupo_item")
                    txtCodigoItem.Text = oSqlDataReader.Item("codigo_item")
                    txtCodigoItem2.Text = oSqlDataReader.Item("codigo_item2")
                    txtCodigoBarras.Text = oSqlDataReader.Item("codigo_barras")
                    txtDescricao.Text = oSqlDataReader.Item("descricao")
                    cboMarca.SelectedValue = oSqlDataReader.Item("codigo_marca")
                    txtDescricao2.Text = oSqlDataReader.Item("descricao2")
                    txtReferencia.Text = oSqlDataReader.Item("referencia")
                    cboAtivo.SelectedValue = oSqlDataReader.Item("ativo")
                    cboNCM.SelectedValue = oSqlDataReader.Item("codigo_ncm")
                    txtPesoLiquido.Value = oSqlDataReader.Item("peso_liquido")
                    cboInsumoProducao.SelectedValue = oSqlDataReader.Item("insumo_producao")
                    cboOrigemItem.SelectedValue = oSqlDataReader.Item("codigo_origem_item")
                    txtObservacao.Text = oSqlDataReader.Item("observacao")
                    cboUnidadeMedidaVenda.SelectedValue = oSqlDataReader.Item("codigo_unidade_medida_venda")
                    cboFormaVenda.SelectedValue = oSqlDataReader.Item("codigo_forma_venda_item")
                    cboGrupoItemVenda.SelectedValue = oSqlDataReader.Item("codigo_grupo_item_venda")
                    cboUnidadeMedidaCompra.SelectedValue = oSqlDataReader.Item("codigo_unidade_medida_compra")
                    txtLeadTime.Value = oSqlDataReader.Item("lead_time")
                    cboNecessitaFornecedorHomologado.SelectedValue = oSqlDataReader.Item("necessita_fornecedor_homologado")
                    txtQuantidadeMinima.Value = oSqlDataReader.Item("quantidade_minima")
                    txtMultiploCompra.Value = oSqlDataReader.Item("multiplo_compra")
                    txtToleranciaQuantidadeRecebimento.Value = oSqlDataReader.Item("tolerancia_quantidade_recebimento")
                    txtToleranciaValorRecebimento.Value = oSqlDataReader.Item("tolerancia_valor_recebimento")
                    txtToleranciaDiasRecebimento.Value = oSqlDataReader.Item("tolerancia_dias_recebimento")
                    cboUnidadeMedidaEstoque.SelectedValue = oSqlDataReader.Item("codigo_unidade_medida_estoque")
                    txtEstoqueMinimo.Value = oSqlDataReader.Item("estoque_minimo")
                    txtEstoqueMaximo.Value = oSqlDataReader.Item("estoque_maximo")
                    cboMetodologiaSaidaProdutoEstoque.SelectedValue = oSqlDataReader.Item("codigo_metodologia_saida_produto_estoque")
                    chkControlaLote.Checked = oSqlDataReader.Item("controla_lote")
                    chkGeraLoteInterno.Checked = oSqlDataReader.Item("gera_lote_interno")
                    txtCaracterLote.Text = oSqlDataReader.Item("caracter_lote")
                    chkControlaQualidade.Checked = oSqlDataReader.Item("controla_qualidade")
                    chkControlaValidade.Checked = oSqlDataReader.Item("controla_validade")
                    chkControlaDataFabricacao.Checked = oSqlDataReader.Item("controla_data_fabricacao")
                    chkControlaTempoMaximoExposicao.Checked = oSqlDataReader.Item("controla_tempo_exposicao")
                    txtTempoMaximoExposicao.Text = oSqlDataReader.Item("tempo_maximo_exposicao")
                    txtPercentualDesvalorizacao.Value = oSqlDataReader.Item("percentual_desvalorizacao")
                    txtFrequenciaDesvalorizacao.Value = oSqlDataReader.Item("frequencia_desvalorizacao_dia")
                    cboTipoAtivoFixo.SelectedValue = oSqlDataReader.Item("codigo_tipo_ativo_fixo")
                    chkItemProducao.Checked = oSqlDataReader.Item("item_producao")
                    chkItemEstoque.Checked = oSqlDataReader.Item("item_estoque")
                    chkItemCompra.Checked = oSqlDataReader.Item("item_compra")
                    chkItemVenda.Checked = oSqlDataReader.Item("item_venda")
                    chkAtivoFixo.Checked = oSqlDataReader.Item("item_ativo_fixo")
                    txtVidaUtilBem.Value = oSqlDataReader.Item("vida_util_bem")
                    txtTaxaDepreciacaoAnual.Value = oSqlDataReader.Item("taxa_depreciacao_anual")
                    txtTaxaDepreciacaoMensal.Value = oSqlDataReader.Item("taxa_depreciacao_mensal")
                    txtValorBem.Value = oSqlDataReader.Item("valor_bem")
                    txtValorImpostosRecuperaveis.Value = oSqlDataReader.Item("valor_impostos_recuperaveis")
                    txtValorResidual.Value = oSqlDataReader.Item("valor_residual")
                    txtValorDepreciavel.Value = oSqlDataReader.Item("valor_depreciavel")
                    txtValorDepreciacaoAnual.Value = oSqlDataReader.Item("valor_depreciacao_anual")
                    txtValorDepreciacaoMensal.Value = oSqlDataReader.Item("valor_depreciacao_mensal")
                    txtControlePatrimonial.Text = oSqlDataReader.Item("controle_patrimonial")
                    If goDatabase.sInitialCatalog = "INTERACTI_ISSARTEL_PRD" Then
                        txtValor.Value = oSqlDataReader.Item("valor")
                    End If
                    txtCor.Text = oSqlDataReader.Item("cor")
                    txtBitola.Value = oSqlDataReader.Item("bitola")
                    txtCodigoIntegracao.Value = oSqlDataReader.Item("codigo_integracao")
                    txtTipoVenda.Text = oSqlDataReader.Item("tipo_venda")

                    'Carrega Foto
                    If IsDBNull(oSqlDataReader.Item("foto")) = False Then
                        Dim bytBLOBData(oSqlDataReader.GetBytes(1, 0, Nothing, 0, Integer.MaxValue) - 1) As Byte
                        oSqlDataReader.GetBytes(1, 0, bytBLOBData, 0, bytBLOBData.Length)
                        Dim stmBLOBData As New MemoryStream(bytBLOBData)
                        picFoto.Image = Image.FromStream(stmBLOBData)
                    End If

                    txtEstoqueMinimoUsoConsumo.Value = oSqlDataReader.Item("estoque_minimo_uso_consumo")

                    If IsDBNull(oSqlDataReader.Item("codigo_unidade_medida_uso_consumo")) Then
                        cboUnidadeMedidaUsoConsumo.SelectedIndex = -1
                    Else
                        cboUnidadeMedidaUsoConsumo.SelectedValue = oSqlDataReader.Item("codigo_unidade_medida_uso_consumo")
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

    Public Sub LoadDadosTipoItem(ByVal iTipoItem As Integer, _
                                 ByVal chkEstoque As UICheckBox, _
                                 ByVal chkCompra As UICheckBox, _
                                 ByVal chkVenda As UICheckBox, _
                                 ByVal chkProducao As UICheckBox, _
                                 ByVal chkAtivoFixo As UICheckBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Código Tipo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iTipoItem

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_static_dados_tipo_item", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    If oSqlDataReader.Item("estoque") = False Then
                        chkEstoque.Checked = False
                    End If
                    If oSqlDataReader.Item("compra") = False Then
                        chkCompra.Checked = False
                    End If
                    If oSqlDataReader.Item("venda") = False Then
                        chkVenda.Checked = False
                    End If
                    If oSqlDataReader.Item("ativo_fixo") = False Then
                        chkAtivoFixo.Checked = False
                    End If
                    If oSqlDataReader.Item("producao") = False Then
                        chkProducao.Checked = False
                    End If

                    chkEstoque.Enabled = oSqlDataReader.Item("estoque")
                    chkCompra.Enabled = oSqlDataReader.Item("compra")
                    chkVenda.Enabled = oSqlDataReader.Item("venda")
                    chkAtivoFixo.Enabled = oSqlDataReader.Item("ativo_fixo")
                    chkProducao.Enabled = oSqlDataReader.Item("producao")

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

    Public Function GeraCodigoItem(ByVal iCodigoGrupoItem As Integer)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim sReturn As String
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Grupo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_grupo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoGrupoItem

            'Executa Query
            sReturn = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_gerar_codigo", oSqlParameter)

            Return sReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function GeraCodigoItemLHColus(ByVal iCodigoGrupoItem As Integer, _
                                          ByVal iCodigoTipoMaterial As Integer, _
                                          ByVal iCodigoFormato As Integer, _
                                          ByVal iCodigoAcabamento As Integer)

        'Variaveis Locais
        Dim oSqlParameter(10) As SqlParameter
        Dim sReturn As String
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Grupo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_grupo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoGrupoItem : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_material"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoTipoMaterial : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_formato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFormato : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acabamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoAcabamento

            'Executa Query
            sReturn = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_gerar_codigo_lhcolus", oSqlParameter)

            Return sReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub LoadDadosProduto(ByVal lCodigoProduto As Long, _
                                ByVal iCodigoCliente As Integer, _
                                ByVal iCodigoDestinacao As Integer, _
                                ByVal dQuantidade As Double, _
                                ByVal sData As String, _
                                ByRef sDescricao As String, _
                                ByRef iCodigoUnidadeMedida As Integer, _
                                ByRef dQuantidadeEstoque As Double, _
                                ByRef bItemEstoque As Boolean, _
                                ByRef bItemProducao As Boolean, _
                                ByRef iCodigoFormaVendaProduto As FormaVendaItem, _
                                ByRef dPrecoTabela As Double, _
                                ByRef dDescontoPercentual As Double, _
                                ByRef dDescontoValor As Double, _
                                ByRef dPrecoVenda As Double, _
                                ByRef dPrecoMinimo As Double, _
                                ByRef dCustoTeorico As Double, _
                                ByRef iLeadTime As Integer, _
                                ByRef bICMSEmbutido As Boolean, _
                                ByRef dAliquotaICMS As Double, _
                                ByRef bIPIEmbutido As Boolean, _
                                ByRef dAliquotaIPI As Double, _
                                ByRef bPISCOFINSEmbutido As Boolean, _
                                ByRef dAliquotaPISCOFINS As Double, _
                                ByRef dQuantidadeMinima As Double, _
                                ByRef dMultiploVenda As Double, _
                                ByRef bAcordoComercial As Boolean, _
                                ByRef lCodigoAcordoComercial As Long, _
                                ByRef iCodigoAcordoComercialItem As Integer, _
                                ByRef sObservacaoVenda As String, _
                                Optional ByRef lCodigoRegraFaturamento As Long = -1)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(6) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Código Destinação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_destinacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoDestinacao : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            'Seta Parametros - Data
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sData : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoCliente

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_dados_imposto", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    'Carrega Váriavel
                    sDescricao = oSqlDataReader.Item("descricao")
                    iCodigoUnidadeMedida = oSqlDataReader.Item("codigo_unidade_medida_venda")
                    dQuantidadeEstoque = oSqlDataReader.Item("quantidade_estoque")
                    bItemEstoque = oSqlDataReader.Item("item_estoque")
                    bItemProducao = oSqlDataReader.Item("item_producao")
                    iCodigoFormaVendaProduto = oSqlDataReader.Item("codigo_forma_venda_item")
                    dPrecoTabela = oSqlDataReader.Item("preco_tabela")
                    dDescontoPercentual = oSqlDataReader.Item("desconto_percentual")
                    dDescontoValor = oSqlDataReader.Item("desconto_valor")
                    dPrecoVenda = oSqlDataReader.Item("preco_venda")
                    dPrecoMinimo = oSqlDataReader.Item("preco_minimo")
                    dCustoTeorico = oSqlDataReader.Item("custo_teorico")
                    iLeadTime = oSqlDataReader.Item("lead_time")
                    bICMSEmbutido = oSqlDataReader.Item("icms_embutido")
                    dAliquotaICMS = oSqlDataReader.Item("aliquota_icms")
                    bIPIEmbutido = oSqlDataReader.Item("ipi_embutido")
                    dAliquotaIPI = oSqlDataReader.Item("aliquota_ipi")
                    bPISCOFINSEmbutido = oSqlDataReader.Item("pis_cofins_embutido")
                    dAliquotaPISCOFINS = oSqlDataReader.Item("aliquota_pis_cofins")
                    dQuantidadeMinima = oSqlDataReader.Item("quantidade_minima")
                    dMultiploVenda = oSqlDataReader.Item("multiplo_venda")
                    bAcordoComercial = oSqlDataReader.Item("acordo_comercial")
                    lCodigoAcordoComercial = oSqlDataReader.Item("codigo_acordo_comercial")
                    iCodigoAcordoComercialItem = oSqlDataReader.Item("codigo_acordo_comercial_item")
                    sObservacaoVenda = oSqlDataReader.Item("observacao_preco_venda")
                    lCodigoRegraFaturamento = oSqlDataReader.Item("codigo_regra_faturamento")

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

    Public Sub LoadDadosProduto(ByVal lCodigoProduto As Long, _
                                ByRef sReferencia As String, _
                                ByRef sDescricao As String, _
                                ByRef sMarca As String, _
                                ByRef dQuantidadeEstoque As Double, _
                                ByRef dCustoMedio As Double, _
                                ByRef dCustoTeorico As Double, _
                                ByRef dPrecoVendaMedio As Double)

        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Váriaveis
                sReferencia = oSqlDataReader.Item("referencia")
                sDescricao = oSqlDataReader.Item("descricao")
                sMarca = oSqlDataReader.Item("marca")
                dQuantidadeEstoque = oSqlDataReader.Item("quantidade_estoque")
                dCustoMedio = oSqlDataReader.Item("custo_medio")
                dCustoTeorico = oSqlDataReader.Item("custo_teorico")
                dPrecoVendaMedio = oSqlDataReader.Item("preco_venda_medio")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosProduto(ByVal lCodigoProduto As Long, _
                               ByVal txtDescricao As MaskedEditBox, _
                               ByVal cboUnidadeMedida As UIComboBox)

        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Váriaveis
                txtDescricao.Text = oSqlDataReader.Item("descricao")
                cboUnidadeMedida.SelectedValue = IIf(IsDBNull(oSqlDataReader.Item("codigo_unidade_medida_estoque")), oSqlDataReader.Item("codigo_unidade_medida_venda"), oSqlDataReader.Item("codigo_unidade_medida_estoque"))

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosProdutoBOM(ByVal lCodigoProduto As Long, _
                               ByVal txtDescricao As MaskedEditBox, _
                               ByVal cboUnidadeMedida As UIComboBox, _
                               ByVal txtSC As NumericEditBox, _
                               ByVal txtDET As NumericEditBox, _
                               ByVal cboNivelInspecao As UIComboBox)

        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Váriaveis
                txtDescricao.Text = oSqlDataReader.Item("descricao")
                cboUnidadeMedida.SelectedValue = IIf(IsDBNull(oSqlDataReader.Item("codigo_unidade_medida_estoque")), oSqlDataReader.Item("codigo_unidade_medida_venda"), oSqlDataReader.Item("codigo_unidade_medida_estoque"))
                txtSC.Text = oSqlDataReader.Item("sc")
                txtDET.Text = oSqlDataReader.Item("det")

                If IsDBNull(oSqlDataReader.Item("codigo_nivel_inspecao")) Then
                    cboNivelInspecao.SelectedIndex = -1
                Else
                    cboNivelInspecao.SelectedValue = oSqlDataReader.Item("codigo_nivel_inspecao")
                End If

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosProduto(ByVal iCodigoCliente As Integer, _
                                ByVal lCodigoProduto As Long, _
                                ByRef sReferencia As String, _
                                ByRef sDescricao As String, _
                                ByRef sMarca As String, _
                                ByRef dQuantidadeEstoque As Double, _
                                ByRef dCustoMedio As Double, _
                                ByRef dCustoTeorico As Double, _
                                ByRef dPrecoVenda As Double, _
                                ByRef dPrecoMinimo As Double, _
                                ByRef lCodigoAcordoComercial As Long, _
                                ByRef iCodigoAcordoComercialItem As Integer, _
                                ByRef dFatorConversaoUnidadeMedidaVenda As Double, _
                                ByRef sUnidadeMedidaVenda As String, _
                                ByRef sUnidadeMedidaEstoque As String, _
                                ByRef sSugestaoVenda As String, _
                                ByRef dEstoqueReservado As Double, _
                                ByRef dPedidoCompraTransito As Double, _
                                ByRef dPrecoVendaMedio As Double)

        Dim oSqlParameter(3) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCliente : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Váriaveis
                sReferencia = oSqlDataReader.Item("referencia")
                sDescricao = oSqlDataReader.Item("descricao")
                sMarca = oSqlDataReader.Item("marca")
                dQuantidadeEstoque = oSqlDataReader.Item("quantidade_estoque")
                dCustoMedio = oSqlDataReader.Item("custo_medio")
                dCustoTeorico = oSqlDataReader.Item("custo_teorico")
                dPrecoVenda = oSqlDataReader.Item("preco_tabela")
                dPrecoMinimo = oSqlDataReader.Item("preco_minimo")
                lCodigoAcordoComercial = oSqlDataReader.Item("codigo_acordo_comercial")
                iCodigoAcordoComercialItem = oSqlDataReader.Item("codigo_acordo_comercial_item")
                dFatorConversaoUnidadeMedidaVenda = oSqlDataReader.Item("fator_conversao_unidade_medida_venda")
                sUnidadeMedidaVenda = oSqlDataReader.Item("unidade_medida_venda")
                sUnidadeMedidaEstoque = oSqlDataReader.Item("unidade_medida_estoque")
                sSugestaoVenda = oSqlDataReader.Item("sugestao_venda")
                dEstoqueReservado = oSqlDataReader.Item("estoque_reservado")
                dPedidoCompraTransito = oSqlDataReader.Item("pedido_compra_transito")
                dPrecoVendaMedio = oSqlDataReader.Item("preco_venda_medio")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosProduto(ByVal lCodigoProduto As Long, _
                                ByRef sCodigoProduto As String, _
                                ByRef sDescricao As String, _
                                ByRef dQuantidadeEstoque As Double, _
                                ByRef dCustoMedio As Double, _
                                ByRef dPrecoCompra As Double, _
                                ByRef dMargemLucro As Double, _
                                ByRef dPrecoVenda As Double)

        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Váriaveis
                sCodigoProduto = oSqlDataReader.Item("codigo_item")
                sDescricao = oSqlDataReader.Item("descricao")
                dQuantidadeEstoque = oSqlDataReader.Item("quantidade_estoque")
                dCustoMedio = oSqlDataReader.Item("custo_medio")
                dPrecoCompra = oSqlDataReader.Item("preco_compra")
                dMargemLucro = oSqlDataReader.Item("margem_lucro")
                dPrecoVenda = oSqlDataReader.Item("preco_venda")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosProduto(ByRef sCodigoItem As String, _
                                ByRef sDescricao As String, _
                                ByRef sTipoItem As String, _
                                ByRef lCodigo As Long)

        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sCodigoItem : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_dados_codigo", oSqlParameter)

            If oSqlDataReader.HasRows = True Then

                While oSqlDataReader.Read

                    'Carrega Váriaveis
                    sDescricao = oSqlDataReader.Item("descricao")
                    sTipoItem = oSqlDataReader.Item("tipo_item")
                    lCodigo = oSqlDataReader.Item("codigo")

                End While

            Else

                'Limpa Váriaveis
                sCodigoItem = ""
                sDescricao = ""
                sTipoItem = ""
                lCodigo = 0

            End If

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosProduto(ByVal lCodigo As Long, _
                                ByRef sDescricao As String)

        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_dados", oSqlParameter)

            If oSqlDataReader.HasRows = True Then

                While oSqlDataReader.Read

                    'Carrega Váriaveis
                    sDescricao = oSqlDataReader.Item("descricao")

                End While

            Else

                'Limpa Váriaveis
                sDescricao = ""

            End If

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosProduto(ByVal lCodigoProduto As Long, _
                                ByVal txtPrecoVenda As NumericEditBox)

        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Váriaveis
                txtPrecoVenda.Value = oSqlDataReader.Item("preco_venda")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosProduto(ByVal lCodigoProduto As Long, _
                                ByVal txtDescricao As MaskedEditBox, _
                                ByVal txtLeadTime As NumericEditBox, _
                                ByVal txtCustoMedio As NumericEditBox, _
                                ByVal txtUltimoPrecoCompra As NumericEditBox, _
                                ByVal txtMaiorPrecoCompra As NumericEditBox, _
                                ByVal txtMenorPrecoCompra As NumericEditBox, _
                                ByVal cboUnidadeMedidaVenda As UIComboBox, _
                                ByVal txtPrecoVenda As NumericEditBox)

        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Váriaveis
                txtDescricao.Text = oSqlDataReader.Item("descricao")
                txtLeadTime.Value = oSqlDataReader.Item("lead_time")
                txtCustoMedio.Value = oSqlDataReader.Item("custo_medio")
                txtUltimoPrecoCompra.Value = oSqlDataReader.Item("preco_ultima_compra")
                txtMaiorPrecoCompra.Value = oSqlDataReader.Item("maior_preco_compra")
                txtMenorPrecoCompra.Value = oSqlDataReader.Item("menor_preco_compra")
                txtPrecoVenda.Value = oSqlDataReader.Item("preco_venda")
                cboUnidadeMedidaVenda.SelectedValue = oSqlDataReader.Item("codigo_unidade_medida_venda")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosProduto(ByVal lCodigoProduto As Long, _
                                ByVal txtDescricao As MaskedEditBox)

        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Váriaveis
                txtDescricao.Text = oSqlDataReader.Item("descricao")


            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosProduto(ByVal lCodigoProduto As Long, _
                                ByVal txtDescricao As MaskedEditBox, _
                                ByVal cboUnidadeMedidaVenda As UIComboBox, _
                                ByVal txtValorUnitario As NumericEditBox)

        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Váriaveis
                txtDescricao.Text = oSqlDataReader.Item("descricao")
                cboUnidadeMedidaVenda.SelectedValue = oSqlDataReader.Item("codigo_unidade_medida_venda")
                txtValorUnitario.Value = oSqlDataReader.Item("preco_venda")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosProduto(ByVal lCodigoProduto As Long, _
                                ByVal txtDescricao As MaskedEditBox, _
                                ByVal txtValorTransporte As NumericEditBox, _
                                ByVal txtValorEmbalagem As NumericEditBox, _
                                ByVal txtValorMaoObra As NumericEditBox, _
                                ByVal txtDescontoPercentualMaoObra As NumericEditBox)

        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Váriaveis
                txtDescricao.Text = oSqlDataReader.Item("descricao")
                txtValorTransporte.Value = oSqlDataReader.Item("valor_transporte")
                txtValorEmbalagem.Value = oSqlDataReader.Item("valor_embalagem")
                txtValorMaoObra.Value = oSqlDataReader.Item("valor_mao_obra")
                txtDescontoPercentualMaoObra.Value = oSqlDataReader.Item("desconto_percentual_mao_obra")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosProduto(ByVal lCodigoProduto As Long, _
                                ByRef sDescricao As String, _
                                ByRef dPrecoCompra As Double)

        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Váriaveis
                sDescricao = oSqlDataReader.Item("descricao")
                dPrecoCompra = oSqlDataReader.Item("custo_medio")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosProduto(ByVal lCodigoProduto As Long, _
                                ByVal txtDescricao As MaskedEditBox, _
                                ByVal txtCustoMedio As NumericEditBox, _
                                ByVal txtPrecoVenda As NumericEditBox)

        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Váriaveis
                txtDescricao.Text = oSqlDataReader.Item("descricao")
                txtPrecoVenda.Value = oSqlDataReader.Item("preco_venda")
                txtCustoMedio.Value = oSqlDataReader.Item("custo_teorico")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosProduto(ByVal lCodigoProduto As Long, _
                                ByVal txtDescricao As MaskedEditBox, _
                                ByVal txtPrecoVenda As NumericEditBox)

        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Váriaveis
                txtDescricao.Text = oSqlDataReader.Item("descricao")
                txtPrecoVenda.Value = oSqlDataReader.Item("preco_venda")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosProduto(ByVal lCodigoProduto As Long, _
                                ByVal txtDescricao As EditBox, _
                                ByVal txtPrecoVenda As NumericEditBox)

        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Váriaveis
                txtDescricao.Text = oSqlDataReader.Item("descricao")
                txtPrecoVenda.Value = oSqlDataReader.Item("preco_venda")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosProduto(ByVal lCodigoProduto As Long, _
                                ByRef sCodigoProduto As String, _
                                ByRef sDescricao As String, _
                                ByRef sLocalizacao As String, _
                                ByRef dQuantidadeEstoque As Double, _
                                ByRef dCustoMedio As Double, _
                                ByRef dPrecoCompra As Double, _
                                ByRef dMargemLucro As Double, _
                                ByRef dPrecoVenda As Double)

        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Váriaveis
                sCodigoProduto = oSqlDataReader.Item("codigo_item")
                sDescricao = oSqlDataReader.Item("descricao")
                dQuantidadeEstoque = oSqlDataReader.Item("quantidade_estoque")
                dCustoMedio = oSqlDataReader.Item("custo_medio")
                dPrecoCompra = oSqlDataReader.Item("preco_compra")
                dMargemLucro = oSqlDataReader.Item("margem_lucro")
                dPrecoVenda = oSqlDataReader.Item("preco_venda")
                sLocalizacao = oSqlDataReader.Item("localizacao")
                dQuantidadeEstoque = oSqlDataReader.Item("quantidade_estoque")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosProduto(ByVal lCodigoProduto As Long, _
                                ByVal txtGrupoItem As MaskedEditBox, _
                                ByVal txtCodigo As MaskedEditBox, _
                                ByVal txtCodigoEAN As MaskedEditBox, _
                                ByVal txtCodigoNCM As MaskedEditBox, _
                                ByVal txtDescricao2 As MaskedEditBox)

        'Váriaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Váriaveis
                txtGrupoItem.Text = oSqlDataReader.Item("grupo_item")
                txtCodigo.Text = oSqlDataReader.Item("codigo_item")
                txtCodigoEAN.Text = oSqlDataReader.Item("codigo_barras")
                txtCodigoNCM.Text = oSqlDataReader.Item("ncm")
                txtDescricao2.Text = oSqlDataReader.Item("descricao2")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosProduto(ByVal lCodigoProduto As Long, _
                                ByRef iCodigoGrupoItem As Integer, _
                                ByRef sCodigoItem As String, _
                                ByRef sCodigoItem2 As String, _
                                ByRef sDescricao As String)

        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Váriaveis
                iCodigoGrupoItem = oSqlDataReader.Item("codigo_grupo_item")
                sDescricao = oSqlDataReader.Item("descricao")
                sCodigoItem = oSqlDataReader.Item("codigo_item")
                sCodigoItem2 = oSqlDataReader.Item("codigo_item2")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosProduto(ByVal lCodigoProduto As Long, _
                                ByVal iCodigoCliente As Integer, _
                                ByRef sDescricao As String, _
                                ByRef iCodigoUnidadeMedida As Integer, _
                                ByRef dQuantidadeEstoque As Double, _
                                ByRef bItemEstoque As Boolean, _
                                ByRef bItemProducao As Boolean, _
                                ByRef iCodigoFormaVendaProduto As FormaVendaItem, _
                                ByRef dPrecoVenda As Double, _
                                ByRef iLeadTime As Integer)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoCliente

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_dados", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    'Carrega Váriavel
                    sDescricao = oSqlDataReader.Item("descricao")
                    iCodigoUnidadeMedida = oSqlDataReader.Item("codigo_unidade_medida_venda")
                    dQuantidadeEstoque = oSqlDataReader.Item("quantidade_estoque")
                    bItemEstoque = oSqlDataReader.Item("item_estoque")
                    bItemProducao = oSqlDataReader.Item("item_producao")
                    iCodigoFormaVendaProduto = oSqlDataReader.Item("codigo_forma_venda_item")
                    dPrecoVenda = oSqlDataReader.Item("preco_venda")
                    iLeadTime = oSqlDataReader.Item("lead_time")

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

    Public Sub LoadDadosProduto(ByVal lCodigoProduto As Long, _
                                ByVal iCodigoCliente As Integer, _
                                ByVal iCodigoDestinacao As Integer, _
                                ByRef sDescricao As String, _
                                ByRef iCodigoUnidadeMedida As Integer, _
                                ByRef dQuantidadeEstoque As Double, _
                                ByRef bItemEstoque As Boolean, _
                                ByRef bItemProducao As Boolean, _
                                ByRef iCodigoFormaVendaProduto As FormaVendaItem, _
                                ByRef dPrecoVenda As Double, _
                                ByRef dPrecoMinimo As Double, _
                                ByRef iLeadTime As Integer, _
                                ByRef bICMSEmbutido As Boolean, _
                                ByRef dAliquotaICMS As Double, _
                                ByRef bIPIEmbutido As Boolean, _
                                ByRef dAliquotaIPI As Double, _
                                ByRef bPISCOFINSEmbutido As Boolean, _
                                ByRef dAliquotaPISCOFINS As Double)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Código Destinação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_destinacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoDestinacao : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoCliente

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_dados_imposto", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    'Carrega Váriavel
                    sDescricao = oSqlDataReader.Item("descricao")
                    iCodigoUnidadeMedida = oSqlDataReader.Item("codigo_unidade_medida_venda")
                    dQuantidadeEstoque = oSqlDataReader.Item("quantidade_estoque")
                    bItemEstoque = oSqlDataReader.Item("item_estoque")
                    bItemProducao = oSqlDataReader.Item("item_producao")
                    iCodigoFormaVendaProduto = oSqlDataReader.Item("codigo_forma_venda_item")
                    dPrecoVenda = oSqlDataReader.Item("preco_venda")
                    dPrecoMinimo = oSqlDataReader.Item("preco_minimo")
                    iLeadTime = oSqlDataReader.Item("lead_time")
                    bICMSEmbutido = oSqlDataReader.Item("icms_embutido")
                    dAliquotaICMS = oSqlDataReader.Item("aliquota_icms")
                    bIPIEmbutido = oSqlDataReader.Item("ipi_embutido")
                    dAliquotaIPI = oSqlDataReader.Item("aliquota_ipi")
                    bPISCOFINSEmbutido = oSqlDataReader.Item("pis_cofins_embutido")
                    dAliquotaPISCOFINS = oSqlDataReader.Item("aliquota_pis_cofins")

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

    Public Sub LoadDadosProduto(ByVal lCodigoProduto As Long, _
                                ByVal sRevisaoTabelaPreco As String, _
                                ByVal iCodigoCliente As Integer, _
                                ByVal iCodigoDestinacao As Integer, _
                                ByVal dQuantidade As Double, _
                                ByVal sData As String, _
                                ByRef sDescricao As String, _
                                ByRef iCodigoUnidadeMedida As Integer, _
                                ByRef dQuantidadeEstoque As Double, _
                                ByRef bItemEstoque As Boolean, _
                                ByRef bItemProducao As Boolean, _
                                ByRef iCodigoFormaVendaProduto As FormaVendaItem, _
                                ByRef dPrecoTabela As Double, _
                                ByRef dDescontoPercentual As Double, _
                                ByRef dDescontoValor As Double, _
                                ByRef dPrecoVenda As Double, _
                                ByRef dPrecoMinimo As Double, _
                                ByRef dCustoTeorico As Double, _
                                ByRef iLeadTime As Integer, _
                                ByRef bICMSEmbutido As Boolean, _
                                ByRef dAliquotaICMS As Double, _
                                ByRef bIPIEmbutido As Boolean, _
                                ByRef dAliquotaIPI As Double, _
                                ByRef bPISCOFINSEmbutido As Boolean, _
                                ByRef dAliquotaPISCOFINS As Double, _
                                ByRef dQuantidadeMinima As Double, _
                                ByRef dMultiploVenda As Double, _
                                ByRef bAcordoComercial As Boolean, _
                                ByRef lCodigoAcordoComercial As Long, _
                                ByRef iCodigoAcordoComercialItem As Integer, _
                                ByRef sObservacaoVenda As String, _
                                Optional ByRef lCodigoRegraFaturamento As Long = -1)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(6) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Revisão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "revisao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sRevisaoTabelaPreco : i += 1

            'Seta Parametros - Código Destinação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_destinacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoDestinacao : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            'Seta Parametros - Data
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sData : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoCliente

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_dados_imposto", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    'Carrega Váriavel
                    sDescricao = oSqlDataReader.Item("descricao")
                    iCodigoUnidadeMedida = oSqlDataReader.Item("codigo_unidade_medida_venda")
                    dQuantidadeEstoque = oSqlDataReader.Item("quantidade_estoque")
                    bItemEstoque = oSqlDataReader.Item("item_estoque")
                    bItemProducao = oSqlDataReader.Item("item_producao")
                    iCodigoFormaVendaProduto = oSqlDataReader.Item("codigo_forma_venda_item")
                    dPrecoTabela = oSqlDataReader.Item("preco_tabela")
                    dDescontoPercentual = oSqlDataReader.Item("desconto_percentual")
                    dDescontoValor = oSqlDataReader.Item("desconto_valor")
                    dPrecoVenda = oSqlDataReader.Item("preco_venda")
                    dPrecoMinimo = oSqlDataReader.Item("preco_minimo")
                    dCustoTeorico = oSqlDataReader.Item("custo_teorico")
                    iLeadTime = oSqlDataReader.Item("lead_time")
                    bICMSEmbutido = oSqlDataReader.Item("icms_embutido")
                    dAliquotaICMS = oSqlDataReader.Item("aliquota_icms")
                    bIPIEmbutido = oSqlDataReader.Item("ipi_embutido")
                    dAliquotaIPI = oSqlDataReader.Item("aliquota_ipi")
                    bPISCOFINSEmbutido = oSqlDataReader.Item("pis_cofins_embutido")
                    dAliquotaPISCOFINS = oSqlDataReader.Item("aliquota_pis_cofins")
                    dQuantidadeMinima = oSqlDataReader.Item("quantidade_minima")
                    dMultiploVenda = oSqlDataReader.Item("multiplo_venda")
                    bAcordoComercial = oSqlDataReader.Item("acordo_comercial")
                    lCodigoAcordoComercial = oSqlDataReader.Item("codigo_acordo_comercial")
                    iCodigoAcordoComercialItem = oSqlDataReader.Item("codigo_acordo_comercial_item")
                    sObservacaoVenda = oSqlDataReader.Item("observacao_preco_venda")
                    lCodigoRegraFaturamento = oSqlDataReader.Item("codigo_regra_faturamento")

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

    Public Sub LoadDadosProduto(ByVal lCodigoProduto As Long, _
                                ByRef sCodigoProduto As String, _
                                ByRef sDescricao As String)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_dados", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    'Carrega Váriavel
                    sCodigoProduto = oSqlDataReader.Item("codigo_item")
                    sDescricao = oSqlDataReader.Item("descricao")

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

    Public Sub LoadDadosProduto(ByVal lCodigoProduto As Long, _
                                ByRef sCodigoProduto As String, _
                                ByRef sDescricao As String, _
                                ByRef sRegistroAnvisa As String)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_dados", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    'Carrega Váriavel
                    sCodigoProduto = oSqlDataReader.Item("codigo_item")
                    sDescricao = oSqlDataReader.Item("descricao")
                    sRegistroAnvisa = oSqlDataReader.Item("registro_anvisa")

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

    Public Sub LoadDadosProduto(ByVal lCodigoProduto As Long, _
                                ByRef sDescricao As String, _
                                ByRef dCustoMedio As Double, _
                                ByRef dPrecoVenda As Double)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_dados", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    'Carrega Váriavel
                    sDescricao = oSqlDataReader.Item("descricao")
                    dCustoMedio = oSqlDataReader.Item("custo_medio")
                    dPrecoVenda = oSqlDataReader.Item("preco_venda")

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

    Public Sub AtualizaProduto(ByVal lCodigoProduto As Long, _
                               ByVal dPrecoCompra As Double, _
                               ByVal dMargemLucro As Double, _
                               ByVal dPrecoVenda As Double)

        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Preço de Compra
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "preco_compra"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPrecoCompra : i += 1

            'Seta Parametros - Margem de Lucro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "margem_lucro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMargemLucro : i += 1

            'Seta Parametros - Preço de Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "preco_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPrecoVenda : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_estoque_item", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub AtualizaProduto(ByVal lCodigoProduto As Long, _
                               ByVal sLocalizacao As String, _
                               ByVal dQuantidadeFisico As Double, _
                               ByVal dPrecoCompra As Double, _
                               ByVal dMargemLucro As Double, _
                               ByVal dPrecoVenda As Double)

        Dim oSqlParameter(7) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Localização
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "localizacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sLocalizacao : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidadeFisico : i += 1

            'Seta Parametros - Preço de Compra
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "preco_compra"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPrecoCompra : i += 1

            'Seta Parametros - Margem de Lucro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "margem_lucro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMargemLucro : i += 1

            'Seta Parametros - Preço de Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "preco_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPrecoVenda : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_estoque_item", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridHistoricoVenda(ByVal oGrid As GridEX, _
                                      ByVal lCodigoItem As Long, _
                                      Optional ByVal iNumeroMeses As Integer = 0, _
                                      Optional ByVal sCliente As String = "", _
                                      Optional ByVal iCodigoCliente As Integer = -1)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Número de Meses
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_meses"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iNumeroMeses : i += 1

            'Seta Parametros - Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sCliente : i += 1

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCliente

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_produto_item_historico", oSqlParameter)

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

    Public Sub LoadGridHistoricoOrcamento(ByVal oGrid As GridEX, _
                                          ByVal lCodigoItem As Long, _
                                          Optional ByVal iNumeroMeses As Integer = 0, _
                                          Optional ByVal sCliente As String = "", _
                                          Optional ByVal iCodigoCliente As Integer = -1)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Número de Meses
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_meses"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iNumeroMeses : i += 1

            'Seta Parametros - Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sCliente : i += 1

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCliente

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_orcamento_produto_item_historico", oSqlParameter)

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

    Public Sub LoadGridHistoricoCompra(ByVal oGrid As GridEX, _
                                       ByVal lCodigoItem As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_entrada_produto_item_historico", oSqlParameter)

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

    Public Sub LoadGridSimilar(ByVal oGrid As GridEX, _
                               ByVal sRevisao As String, _
                               ByVal lCodigoItem As Long, _
                               ByVal iAtivo As Integer, _
                               ByVal sTipoUnidadeMedida As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(6) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Revisão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "revisao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sRevisao : i += 1

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoClienteGlobal : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Tipo Unidade Medida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo_unidade_medida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Char
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = sTipoUnidadeMedida : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = IIf(iAtivo = -1, DBNull.Value, IIf(iAtivo = 1, True, False))

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_similar", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName

            oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: PRODUTO - CLIENTE :::"

    Public Sub InsertCliente(ByVal lCodigoProduto As Long, _
                             ByVal iCodigoCliente As Integer, _
                             ByVal sCodigoProduto As String, _
                             ByVal sCodigoProduto2 As String, _
                             ByVal iCodigoEspecificacaoProduto As Integer)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCliente : i += 1

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sCodigoProduto : i += 1

            'Seta Parametros - Código Produto 2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_produto2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sCodigoProduto2 : i += 1

            'Seta Parametros - Código Especificacao Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_especificacao_produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoEspecificacaoProduto = -1, DBNull.Value, iCodigoEspecificacaoProduto)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_produto_cliente", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateCliente(ByVal lCodigoProduto As Long, _
                             ByVal iCodigoCliente As Integer, _
                             ByVal sCodigoProduto As String, _
                             ByVal sCodigoProduto2 As String, _
                             ByVal iCodigoEspecificacaoProduto As Integer, _
                             ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(6) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCliente : i += 1

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sCodigoProduto : i += 1

            'Seta Parametros - Código Produto 2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_produto2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sCodigoProduto2 : i += 1

            'Seta Parametros - Código Especificacao Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_especificacao_produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoEspecificacaoProduto = -1, DBNull.Value, iCodigoEspecificacaoProduto) : i += 1

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigo : i += 1


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_produto_cliente", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteCliente(ByVal lCodigoProduto As Long)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel 
                i = 0

                'Seta Parametros - Código Produto
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_item"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoProduto : i += 1

                'Seta Parametros - Codigo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_produto_cliente", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridCliente(ByVal oGrid As GridEX, _
                               ByVal lCodigoProduto As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_cliente", oSqlParameter)

            'Configura DataMember
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

#End Region

#Region "::: PRODUTO - FORNECEDOR :::"

    Public Sub InsertFornecedor(ByVal lCodigoProduto As Long, _
                                ByVal iCodigoFornecedor As Integer, _
                                ByVal sCodigoProdutoFornecedor As String, _
                                ByVal dQuantidadeMinima As Double, _
                                ByVal dMultiploCompra As Double)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Produto Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sCodigoProdutoFornecedor : i += 1

            'Seta Parametros - Quantidade Mínima
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_minima"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidadeMinima : i += 1

            'Seta Parametros - Multiplo de Compras
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "multiplo_compra"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMultiploCompra : i += 1

            'Seta Parametros - Código Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFornecedor

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_produto_fornecedor", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateFornecedor(ByVal lCodigoProduto As Long, _
                                ByVal iCodigoFornecedor As Integer, _
                                ByVal sCodigoProdutoFornecedor As String, _
                                ByVal dQuantidadeMinima As Double, _
                                ByVal dMultiploCompra As Double, _
                                ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(6) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Produto Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sCodigoProdutoFornecedor : i += 1

            'Seta Parametros - Código Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFornecedor : i += 1

            'Seta Parametros - Quantidade Mínima
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_minima"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidadeMinima : i += 1

            'Seta Parametros - Multiplo de Compras
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "multiplo_compra"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMultiploCompra : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_produto_fornecedor", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteFornecedor(ByVal lCodigoProduto As Long)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel 
                i = 0

                'Seta Parametros - Código Produto
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_item"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoProduto : i += 1

                'Seta Parametros - Codigo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_produto_fornecedor", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridFornecedor(ByVal oGrid As GridEX, _
                                  ByVal lCodigoProduto As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_fornecedor", oSqlParameter)

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

#End Region

#Region "::: PRODUTO - LOCALIZAÇÃO :::"

    Public Sub InsertLocalizacao(ByVal lCodigoProduto As Long, _
                                 ByVal iCodigoDeposito As Integer, _
                                 ByVal sLocalizacao As String)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Depósito
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_deposito"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoDeposito : i += 1

            'Seta Parametros - Localização
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "localizacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sLocalizacao

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_produto_localizacao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateLocalizacao(ByVal lCodigoProduto As Long, _
                                 ByVal iCodigoDeposito As Integer, _
                                 ByVal sLocalizacao As String, _
                                 ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Depósito
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_deposito"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoDeposito : i += 1

            'Seta Parametros - Localização
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "localizacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sLocalizacao : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_produto_localizacao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateReferencia(ByVal lCodigoProduto As Long, _
                                ByVal sReferencia As String, _
                                ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Depósito
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "referencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sReferencia : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_produto_referencia", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertReferencia(ByVal lCodigoProduto As Long, _
                              ByVal sReferencia As String)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Depósito
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "referencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sReferencia : i += 1

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_produto_referencia", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Public Sub DeleteLocalizacao(ByVal lCodigoProduto As Long)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel 
                i = 0

                'Seta Parametros - Código Produto
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_item"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoProduto : i += 1

                'Seta Parametros - Codigo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_produto_localizacao", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridLocalizacao(ByVal oGrid As GridEX, _
                                   ByVal lCodigoProduto As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_localizacao", oSqlParameter)

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

    Public Sub LoadGridReferencia(ByVal oGrid As GridEX, _
                                  ByVal lCodigoProduto As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_referencia", oSqlParameter)

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
#End Region

#Region "::: PRODUTO - ROTEIRO :::"

    Public Sub InsertRoteiro(ByVal lCodigoItem As Long, _
                             ByVal iCodigoModeloRoteiroProducao As Integer, _
                             ByVal sRevisao As String, _
                             ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(18) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In oGrid.GetDataRows

                'Verifica se a Linha é Válida
                If IsDBNull(oRow.Cells("sequencia").Value) = False And IsDate(oRow.Cells("quantidade_horas").Value) Then

                    'Seta Váriavel
                    i = 0

                    'Seta Parametros - Código Item
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_item"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                    oSqlParameter(i).Value = lCodigoItem : i += 1

                    'Seta Parametros - Código Modelo Roteiro de Produção
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_modelo_roteiro_producao"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                    oSqlParameter(i).Value = iCodigoModeloRoteiroProducao : i += 1

                    'Seta Parametros - Codigo Empresa
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_empresa"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                    oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                    'Seta Parametros - Revisão
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "revisao"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                    oSqlParameter(i).Size = 5
                    oSqlParameter(i).Value = sRevisao : i += 1

                    'Seta Parametros - Sequência
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "sequencia"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                    oSqlParameter(i).Value = oRow.Cells("sequencia").Value : i += 1

                    'Seta Parametros - Código Centro de Trabalho
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_centro_trabalho"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                    oSqlParameter(i).Value = oRow.Cells("codigo_centro_trabalho").Value : i += 1

                    'Seta Parametros - Código Operação
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_operacao"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                    oSqlParameter(i).Value = oRow.Cells("codigo_operacao").Value : i += 1

                    'Seta Parametros - Sequência Predecessora
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "sequencia_predecessora"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                    oSqlParameter(i).Value = DBNull.Value : i += 1

                    'Seta Parametros - Tempo Setup Máquina
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "tempo_setup_maquina"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.Float
                    oSqlParameter(i).Value = 0 : i += 1

                    'Seta Parametros - Tempo Mão de Obra
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "tempo_mao_obra"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.Float
                    oSqlParameter(i).Value = ((Hour(oRow.Cells("quantidade_horas").Value) * 60) + Minute(oRow.Cells("quantidade_horas").Value) + (Second(oRow.Cells("quantidade_horas").Value) / 60.0)) : i += 1

                    'Seta Parametros - Valor Hora
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "valor_hora"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.Float
                    oSqlParameter(i).Value = oRow.Cells("valor_hora").Value : i += 1

                    'Seta Parametros - Tempo Máquina
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "tempo_maquina"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.Float
                    oSqlParameter(i).Value = 0 : i += 1

                    'Seta Parametros - Referência
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "referencia"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.Int
                    oSqlParameter(i).Value = 1 : i += 1

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
                    oSqlParameter(i).Value = False : i += 1

                    'Seta Parametros - Apontamento Concorrente
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "apontamento_concorrente"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.Bit
                    oSqlParameter(i).Value = False : i += 1

                    'Seta Parametros - Controla Qualidade
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "controla_qualidade"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.Bit
                    oSqlParameter(i).Value = oRow.Cells("aponta").Value : i += 1

                    'Seta Parametros - Observação
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "observacao"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                    oSqlParameter(i).Size = 5000
                    oSqlParameter(i).Value = DBNull.Value : i += 1

                    'Seta Parametros - Código Usuário
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_usuario"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.Int
                    oSqlParameter(i).Value = goUsuario.iUsuario

                    'Executa Query
                    ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_item_roteiro", oSqlParameter)

                End If

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertRoteiro(ByVal lCodigoItem As Long, _
                             ByVal iCodigoModeloRoteiroProducao As Integer, _
                             ByVal sRevisao As String, _
                             ByVal iSequencia As Integer, _
                             ByVal iCodigoCentroTrabalho As Integer, _
                             ByVal iCodigoOperacao As Integer, _
                             ByVal iSequenciaPredecessora As Integer, _
                             ByVal dTempoSetupMaquina As Double, _
                             ByVal dTempoMaoObra As Double, _
                             ByVal dTempoMaquina As Double, _
                             ByVal iReferencia As Integer, _
                             ByVal bAponta As Boolean, _
                             ByVal bApontaEquipamento As Boolean, _
                             ByVal bApontamentoConcorrente As Boolean, _
                             ByVal bControlaQualidade As Boolean, _
                             ByVal sObservacao As String)

        'Variaveis Locais
        Dim oSqlParameter(17) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Código Modelo Roteiro de Produção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modelo_roteiro_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoModeloRoteiroProducao : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Revisão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "revisao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5
            oSqlParameter(i).Value = sRevisao : i += 1

            'Seta Parametros - Sequência
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sequencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iSequencia : i += 1

            'Seta Parametros - Código Centro de Trabalho
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_trabalho"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoCentroTrabalho : i += 1

            'Seta Parametros - Código Operação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_operacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoOperacao : i += 1

            'Seta Parametros - Sequência Predecessora
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sequencia_predecessora"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iSequenciaPredecessora = -1, DBNull.Value, iSequenciaPredecessora) : i += 1

            'Seta Parametros - Tempo Setup Máquina
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tempo_setup_maquina"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTempoSetupMaquina : i += 1

            'Seta Parametros - Tempo Mão de Obra
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tempo_mao_obra"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTempoMaoObra : i += 1

            'Seta Parametros - Tempo Máquina
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tempo_maquina"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTempoMaquina : i += 1

            'Seta Parametros - Referência
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "referencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iReferencia : i += 1

            'Seta Parametros - Aponta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aponta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAponta : i += 1

            'Seta Parametros - Aponta Equipamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aponta_equipamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bApontaEquipamento : i += 1

            'Seta Parametros - Apontamento Concorrente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "apontamento_concorrente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bApontamentoConcorrente : i += 1

            'Seta Parametros - Controla Qualidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "controla_qualidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bControlaQualidade : i += 1

            'Seta Parametros - Observação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5000
            oSqlParameter(i).Value = sObservacao : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_item_roteiro", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateRoteiro(ByVal lCodigoItem As Long, _
                             ByVal iCodigoModeloRoteiroProducao As Integer, _
                             ByVal sRevisao As String, _
                             ByVal iSequencia As Integer, _
                             ByVal iCodigoCentroTrabalho As Integer, _
                             ByVal iCodigoOperacao As Integer, _
                             ByVal iSequenciaPredecessora As Integer, _
                             ByVal dTempoSetupMaquina As Double, _
                             ByVal dTempoMaoObra As Double, _
                             ByVal dTempoMaquina As Double, _
                             ByVal iReferencia As Integer, _
                             ByVal bAponta As Boolean, _
                             ByVal bApontaEquipamento As Boolean, _
                             ByVal bApontamentoConcorrente As Boolean, _
                             ByVal bControlaQualidade As Boolean, _
                             ByVal sObservacao As String, _
                             ByVal iSequenciaAntigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(18) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Código Modelo Roteiro de Produção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modelo_roteiro_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoModeloRoteiroProducao : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Revisão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "revisao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5
            oSqlParameter(i).Value = sRevisao : i += 1

            'Seta Parametros - Sequência
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sequencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iSequencia : i += 1

            'Seta Parametros - Código Centro de Trabalho
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_trabalho"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoCentroTrabalho : i += 1

            'Seta Parametros - Código Operação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_operacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoOperacao : i += 1

            'Seta Parametros - Sequência Predecessora
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sequencia_predecessora"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iSequenciaPredecessora = -1, DBNull.Value, iSequenciaPredecessora) : i += 1

            'Seta Parametros - Tempo Setup Máquina
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tempo_setup_maquina"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTempoSetupMaquina : i += 1

            'Seta Parametros - Tempo Mão de Obra
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tempo_mao_obra"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTempoMaoObra : i += 1

            'Seta Parametros - Tempo Máquina
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tempo_maquina"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTempoMaquina : i += 1

            'Seta Parametros - Referência
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "referencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iReferencia : i += 1

            'Seta Parametros - Aponta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aponta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAponta : i += 1

            'Seta Parametros - Aponta Equipamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aponta_equipamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bApontaEquipamento : i += 1

            'Seta Parametros - Apontamento Concorrente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "apontamento_concorrente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bApontamentoConcorrente : i += 1

            'Seta Parametros - Controla Qualidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "controla_qualidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bControlaQualidade : i += 1

            'Seta Parametros - Observação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5000
            oSqlParameter(i).Value = sObservacao : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Sequencia Antigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sequencia_antigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iSequenciaAntigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_item_roteiro", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteRoteiro(ByVal lCodigoItem As Long, _
                             ByVal iCodigoModeloRoteiroProducao As Integer, _
                             ByVal sRevisao As String)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel 
                i = 0

                'Seta Parametros - Código Item
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_item"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoItem : i += 1

                'Seta Parametros - Código Modelo Roteiro Produção
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_modelo_roteiro_producao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = iCodigoModeloRoteiroProducao : i += 1

                'Seta Parametros - Revisão
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "revisao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 5
                oSqlParameter(i).Value = sRevisao : i += 1

                'Seta Parametros - Sequência
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "sequencia"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("sequencia").Value : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_item_roteiro", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridRoteiro(ByVal oGrid As GridEX, _
                               ByVal lCodigoItem As Long, _
                               ByVal iCodigoModeloRoteiroProducao As Integer, _
                               Optional sRevisao As String = "")

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Código Modelo Roteiro de Produção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modelo_roteiro_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoModeloRoteiroProducao : i += 1

            'Seta Parametros - Revisão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "revisao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5
            oSqlParameter(i).Value = IIf(sRevisao = "", DBNull.Value, sRevisao) : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_item_roteiro", oSqlParameter)

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

    Public Sub LoadDadosRoteiroRevisao(ByVal lCodigoItem As Long, _
                                       ByVal iCodigoModeloRoteiroProducao As Integer, _
                                       ByVal sRevisao As String, _
                                       ByVal lblRevisaoInfo As Label, _
                                       ByVal lblDataInicioRevisaoInfo As Label, _
                                       ByVal lblDataValidadeRevisaoInfo As Label, _
                                       ByVal lblStatusRevisaoInfo As Label, _
                                       ByVal lblElaboradoPorRevisaoInfo As Label, _
                                       ByVal lblAprovadoPorRevisaoInfo As Label, _
                                       ByVal lblQuantidadeOrdemProducaoTryoutRevisaoInfo As Label, _
                                       ByVal lblQuantidadeOrdemProducaoRevisaoInfo As Label, _
                                       ByVal lblQuantidadeRejeitoRevisaoInfo As Label, _
                                       ByVal lblTempoEstimadoMaoObraRevisaoInfo As Label, _
                                       ByVal lblTempoEstimadoSetupRevisaoInfo As Label, _
                                       ByVal lblTempoEstimadoMaquinaRevisaoInfo As Label, _
                                       ByVal lblTempoMedioProducaoRevisaoInfo As Label)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Código Modelo Roteiro de Produção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modelo_roteiro_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoModeloRoteiroProducao : i += 1

            'Seta Parametros - Revisão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "revisao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5
            oSqlParameter(i).Value = sRevisao : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_item_roteiro_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                lblRevisaoInfo.Text = oSqlDataReader.Item("revisao")
                lblDataInicioRevisaoInfo.Text = oSqlDataReader.Item("data_inicio")
                lblDataValidadeRevisaoInfo.Text = oSqlDataReader.Item("data_validade")
                Select Case oSqlDataReader.Item("status")
                    Case CInt(StatusRevisaoRoteiro.EmElaboracao) : lblStatusRevisaoInfo.Text = "EM ELABORAÇÃO"
                    Case CInt(StatusRevisaoRoteiro.EmProducao) : lblStatusRevisaoInfo.Text = "EM PRODUÇÃO"
                    Case CInt(StatusRevisaoRoteiro.Revisado) : lblStatusRevisaoInfo.Text = "REVISADO"
                    Case CInt(StatusRevisaoRoteiro.Futuro) : lblStatusRevisaoInfo.Text = "REVISÃO FUTURA"
                End Select
                lblStatusRevisaoInfo.Tag = oSqlDataReader.Item("status")
                lblElaboradoPorRevisaoInfo.Text = oSqlDataReader.Item("elaborado_por")
                lblAprovadoPorRevisaoInfo.Text = oSqlDataReader.Item("aprovado_por")
                lblQuantidadeOrdemProducaoTryoutRevisaoInfo.Text = oSqlDataReader.Item("quantidade_ordem_producao_tryout")
                lblQuantidadeOrdemProducaoRevisaoInfo.Text = oSqlDataReader.Item("quantidade_ordem_producao")
                lblQuantidadeRejeitoRevisaoInfo.Text = oSqlDataReader.Item("quantidade_rejeito")
                lblTempoEstimadoMaoObraRevisaoInfo.Text = oSqlDataReader.Item("tempo_estimado_mao_obra")
                lblTempoEstimadoSetupRevisaoInfo.Text = oSqlDataReader.Item("tempo_estimado_setup")
                lblTempoEstimadoMaquinaRevisaoInfo.Text = oSqlDataReader.Item("tempo_estimado_maquina")
                lblTempoMedioProducaoRevisaoInfo.Text = oSqlDataReader.Item("tempo_medio_producao")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteRoteiroOrcamento(ByVal lCodigoItem As Long)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer

        Try

            'Seta Váriavel 
            i = 0

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_item_roteiro_orcamento", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: PRODUTO - ROTEIRO - REVISÃO :::"

    Public Sub InsertRoteiroRevisao(ByVal lCodigoItem As Long, _
                                    ByVal iCodigoModeloRoteiroProducao As Integer, _
                                    ByVal sRevisao As String, _
                                    ByVal sDataInicio As String, _
                                    ByVal sDataValidade As String, _
                                    ByVal lCodigoProdutoImportar As Long, _
                                    ByVal iCodigoModelorRoteiroImportar As Integer, _
                                    ByVal sRevisaoImportar As String)

        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Revisão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "revisao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5
            oSqlParameter(i).Value = sRevisao : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Código Modelo Roteiro Produção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modelo_roteiro_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoModeloRoteiroProducao : i += 1

            'Seta Parametros - Data Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataInicio : i += 1

            'Seta Parametros - Data Validade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_validade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataValidade), sDataValidade, DBNull.Value) : i += 1

            'Seta Parametros - Codigo Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Revisão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "revisao_importar"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5
            oSqlParameter(i).Value = sRevisaoImportar : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_importar"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProdutoImportar : i += 1

            'Seta Parametros - Código Modelo Roteiro Produção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modelo_roteiro_producao_importar"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoModelorRoteiroImportar : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_item_revisao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub AprovarRoteiroRevisao(ByVal lCodigoProduto As Long, _
                                     ByVal iCodigoModeloRoteiroProducao As Integer, _
                                     ByVal sRevisao As String)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Código Modelo Roteiro Produção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modelo_roteiro_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoModeloRoteiroProducao : i += 1

            'Seta Parametros - Revisão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "revisao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5
            oSqlParameter(i).Value = sRevisao : i += 1

            'Seta Parametros - Codigo Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_item_revisao_aprovar", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaRoteiroRevisao(ByVal lCodigoItem As Long, _
                                         ByVal iCodigoModeloRoteiroProducao As Integer, _
                                         ByVal sRevisao As String) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim iReturn As Integer
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Modelo Roteiro Produção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modelo_roteiro_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoModeloRoteiroProducao : i += 1

            'Seta Parametros - Revisão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "revisao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5
            oSqlParameter(i).Value = sRevisao : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_cadastro_basico_item_roteiro_revisao", oSqlParameter), Integer)

            'Seta Retorno da Função
            Return IIf(iReturn > 0, False, True)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: PRODUTO - ROTEIRO - QUALIDADE :::"

    Public Sub InsertQualidadeRoteiro(ByVal lCodigoItem As Long, _
                                      ByVal iCodigoModeloRoteiroProducao As Integer, _
                                      ByVal sRevisao As String, _
                                      ByVal iSequencia As Integer, _
                                      ByVal iCaracteristicaInspecionar As Integer, _
                                      ByVal bAponta As Boolean, _
                                      ByVal dValorNominal As Double, _
                                      ByVal dValorMinimo As Double, _
                                      ByVal dValorMaximo As Double, _
                                      ByVal iFrequencia As Integer, _
                                      ByVal sObservacao As String)

        'Variaveis Locais
        Dim oSqlParameter(11) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Modelo Roteiro Produção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modelo_roteiro_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoModeloRoteiroProducao : i += 1

            'Seta Parametros - Revisão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "revisao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5
            oSqlParameter(i).Value = sRevisao : i += 1

            'Seta Parametros - Sequencia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sequencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iSequencia : i += 1

            'Seta Parametros - Código Caracteristica Inspecionar
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_caracteristica_inspecionar"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCaracteristicaInspecionar : i += 1

            'Seta Parametros - Aponta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aponta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAponta : i += 1

            'Seta Parametros - Valor Nominal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_nominal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dValorNominal = -1, DBNull.Value, dValorNominal) : i += 1

            'Seta Parametros - Valor Minimo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_minimo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dValorMinimo = -1, DBNull.Value, dValorMinimo) : i += 1

            'Seta Parametros - Valor Máximo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_maximo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dValorMaximo = -1, DBNull.Value, dValorMaximo) : i += 1

            'Seta Parametros - Frequência
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "frequencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iFrequencia : i += 1

            'Seta Parametros - Observacao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 1000
            oSqlParameter(i).Value = IIf(sObservacao = "", DBNull.Value, sObservacao)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_item_roteiro_qualidade", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateQualidadeRoteiro(ByVal lCodigoItem As Long, _
                                      ByVal iCodigoModeloRoteiroProducao As Integer, _
                                      ByVal sRevisao As String, _
                                      ByVal iSequencia As Integer, _
                                      ByVal iCaracteristicaInspecionar As Integer, _
                                      ByVal bAponta As Boolean, _
                                      ByVal dValorNominal As Double, _
                                      ByVal dValorMinimo As Double, _
                                      ByVal dValorMaximo As Double, _
                                      ByVal iFrequencia As Integer, _
                                      ByVal sObservacao As String, _
                                      ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(12) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Modelo Roteiro Produção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modelo_roteiro_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoModeloRoteiroProducao : i += 1

            'Seta Parametros - Revisão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "revisao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5
            oSqlParameter(i).Value = sRevisao : i += 1

            'Seta Parametros - Sequencia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sequencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iSequencia : i += 1

            'Seta Parametros - Código Caracteristica Inspecionar
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_caracteristica_inspecionar"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCaracteristicaInspecionar : i += 1

            'Seta Parametros - Aponta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aponta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAponta : i += 1

            'Seta Parametros - Valor Nominal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_nominal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dValorNominal = -1, DBNull.Value, dValorNominal) : i += 1

            'Seta Parametros - Valor Minimo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_minimo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dValorMinimo = -1, DBNull.Value, dValorMinimo) : i += 1

            'Seta Parametros - Valor Máximo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_maximo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dValorMaximo = -1, DBNull.Value, dValorMaximo) : i += 1

            'Seta Parametros - Frequência
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "frequencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iFrequencia : i += 1

            'Seta Parametros - Observacao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 1000
            oSqlParameter(i).Value = IIf(sObservacao = "", DBNull.Value, sObservacao) : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_item_roteiro_qualidade", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteQualidadeRoteiro(ByVal lCodigoItem As Long, _
                                      ByVal iCodigoModeloRoteiroProducao As Integer, _
                                      ByVal sRevisao As String)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel 
                i = 0

                'Seta Parametros - Código Item
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_item"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoItem : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Código Modelo Roteiro Produção
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_modelo_roteiro_producao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = iCodigoModeloRoteiroProducao : i += 1

                'Seta Parametros - Revisão
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "revisao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 5
                oSqlParameter(i).Value = sRevisao : i += 1

                'Seta Parametros - Sequencia
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "sequencia"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("sequencia").Value : i += 1

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_item_roteiro_qualidade", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridQualidadeRoteiro(ByVal oGrid As GridEX, _
                                        ByVal lCodigoProduto As Long, _
                                        ByVal iCodigoModeloRoteiroProducao As Integer, _
                                        ByVal sRevisao As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Modelo Roteiro de Produção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modelo_roteiro_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoModeloRoteiroProducao : i += 1

            'Seta Parametros - Revisao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "revisao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5
            oSqlParameter(i).Value = sRevisao

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_item_roteiro_qualidade", oSqlParameter)

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

#End Region

#Region "::: PRODUTO - ROTEIRO - BOM :::"

    Public Sub LoadGridBOMRoteiro(ByVal oGrid As GridEX, _
                                  ByVal lCodigoItem As Long, _
                                  ByVal iCodigoModeloRoteiroProducao As Integer, _
                                  ByVal sRevisao As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Modelo Roteiro de Produção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modelo_roteiro_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoModeloRoteiroProducao : i += 1

            'Seta Parametros - Revisao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "revisao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5
            oSqlParameter(i).Value = sRevisao

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_item_roteiro_bom", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oDataSet.Tables(0).Columns("codigo_item"), oDataSet.Tables(1).Columns("codigo_item"))

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertBOMRoteiro(ByVal lCodigoItem As Long, _
                                ByVal iCodigoModeloRoteiroProducao As Integer, _
                                ByVal sRevisao As String, _
                                ByVal iSequencia As Integer, _
                                ByVal lCodigoItemFilho As Long)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Modelo Roteiro de Produção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modelo_roteiro_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoModeloRoteiroProducao : i += 1

            'Seta Parametros - Revisao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "revisao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5
            oSqlParameter(i).Value = sRevisao : i += 1

            'Seta Parametros - Sequencia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sequencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iSequencia = -1, DBNull.Value, iSequencia) : i += 1

            'Seta Parametros - Código Item Filho
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_filho"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItemFilho : i += 1

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_item_roteiro_bom", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: PRODUTO - BOM :::"

    Public Sub UpdateBOMTipoProduto(ByVal lCodigo As Long, _
                                    ByVal bIndustrializacao As Boolean, _
                                    ByVal bItemCompra As Boolean)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item_compra"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bItemCompra : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "industrializacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bIndustrializacao

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_item_bom_tipo_produto", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ImportarBOM(ByVal lCodigoProdutoPai As Long, _
                    ByVal lCodigoProdutoImportar As Long)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_pai"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProdutoPai : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_importar"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProdutoImportar : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_importar_cadastro_basico_item_bom", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertBOM(ByVal lCodigoProduto As Long, _
                         ByVal iCodigoTipoItem As Integer, _
                         ByVal lCodigoItemFilho As Long, _
                         ByVal lCodigoItemOriginal As Long, _
                         ByVal iCodigoUnidadeMedida As Integer, _
                         ByVal dQuantidade As Double, _
                         ByVal dReferencia As Double, _
                         ByVal iSC As Integer, _
                         ByVal iDET As Integer, _
                         ByVal sMP As String)

        'Variaveis Locais
        Dim oSqlParameter(15) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - SC
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sc"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iSC : i += 1

            'Seta Parametros - DET
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "det"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iDET : i += 1

            'Seta Parametros - MP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "mp"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sMP : i += 1

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_pai"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Tipo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoItem : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Item Filho
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_filho"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItemFilho : i += 1

            'Seta Parametros - Código Item Original
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_original"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoItemOriginal = -1, DBNull.Value, lCodigoItemOriginal) : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            'Seta Parametros - Referência
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "referencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dReferencia : i += 1

            'Seta Parametros - Código Unidade de Medida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoUnidadeMedida : i += 1



            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_item_bom", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertBOMGrid(ByVal lCodigoProduto As Long, _
                        ByVal lCodigoItemFilho As Long, _
                        ByVal lCodigoItemOriginal As Long, _
                        ByVal iCodigoUnidadeMedida As Integer, _
                        ByVal dQuantidade As Double, _
                        ByVal dReferencia As Double, _
                        ByVal iSC As Integer, _
                        ByVal iDET As Integer, _
                        ByVal sMP As String, _
                        ByVal dComprimento As Double, _
                        ByVal dLargura As Double, _
                        ByVal dAltura As Double, _
                        ByVal sDimensao As String, _
                        ByVal iCodigoUnidadeMedidaDimensao As Integer, _
                        ByVal iCodigoUnidadeMedidaQuantidade As Integer, _
                        ByVal iCodigoNivelInspecao As Integer)

        'Variaveis Locais
        Dim oSqlParameter(16) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Und. Med. Dimensão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida_dimensao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoUnidadeMedidaDimensao = -1, DBNull.Value, iCodigoUnidadeMedidaDimensao) : i += 1

            'Seta Parametros - Und. Med. Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida_quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoUnidadeMedidaQuantidade = -1, DBNull.Value, iCodigoUnidadeMedidaQuantidade) : i += 1

            'Seta Parametros - Dimensao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "dimensao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDimensao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "comprimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dComprimento : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "largura"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dLargura : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "altura"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAltura : i += 1


            'Seta Parametros - SC
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sc"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iSC : i += 1

            'Seta Parametros - DET
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "det"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iDET : i += 1

            'Seta Parametros - MP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "mp"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sMP : i += 1

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_pai"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Item Filho
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_filho"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItemFilho : i += 1

            'Seta Parametros - Código Item Original
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_original"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoItemOriginal = -1, DBNull.Value, lCodigoItemOriginal) : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            'Seta Parametros - Referência
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "referencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dReferencia : i += 1

            'Seta Parametros - Código Unidade de Medida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoUnidadeMedida : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_nivel_inspecao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoNivelInspecao = -1, DBNull.Value, iCodigoNivelInspecao)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_item_bom", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateBOM(ByVal lCodigoProduto As Long, _
                         ByVal iCodigoTipoItem As Integer, _
                         ByVal lCodigoItemFilho As Long, _
                         ByVal lCodigoItemOriginal As Long, _
                         ByVal iCodigoUnidadeMedida As Integer, _
                         ByVal dQuantidade As Double, _
                         ByVal dReferencia As Double, _
                         ByVal lCodigoItemAntigo As Long, _
                         ByVal iSC As Integer, _
                         ByVal iDET As Integer, _
                         ByVal sMP As String, _
                            ByVal dComprimento As Double, _
                            ByVal dLargura As Double, _
                            ByVal dAltura As Double)

        'Variaveis Locais
        Dim oSqlParameter(18) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "comprimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dComprimento : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "largura"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dLargura : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "altura"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAltura : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "comprimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dComprimento : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "largura"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dLargura  : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "altura"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAltura : i += 1

            'Seta Parametros - SC
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sc"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iSC : i += 1

            'Seta Parametros - DET
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "det"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iDET : i += 1

            'Seta Parametros - MP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "mp"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sMP : i += 1


            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_pai"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Tipo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoItem : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Item Filho
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_filho"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItemFilho : i += 1

            'Seta Parametros - Código Item Original
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_original"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoItemOriginal = -1, DBNull.Value, lCodigoItemOriginal) : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            'Seta Parametros - Código Unidade de Medida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoUnidadeMedida : i += 1

            'Seta Parametros - Referência
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "referencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dReferencia : i += 1

            'Seta Parametros - Código Item Filho Antigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_filho_antigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItemAntigo : i += 1

            'Seta Parametros - Valor Unitário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_unitario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = 0 : i += 1

            'Seta Parametros - Valor Unitário Desconto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_unitario_desconto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = 0

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_item_bom", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateBOMGrid(ByVal lCodigoProduto As Long, _
                            ByVal lCodigoItemFilho As Long, _
                            ByVal lCodigoItemOriginal As Long, _
                            ByVal iCodigoUnidadeMedida As Integer, _
                            ByVal dQuantidade As Double, _
                            ByVal dReferencia As Double, _
                            ByVal lCodigoItemAntigo As Long, _
                            ByVal iSC As Integer, _
                            ByVal iDET As Integer, _
                            ByVal sMP As String, _
                            ByVal dComprimento As Double, _
                            ByVal dLargura As Double, _
                            ByVal dAltura As Double, _
                            ByVal sDimensao As String, _
                            ByVal iCodigoUnidadeMedidaDimensao As Integer, _
                            ByVal iCodigoUnidadeMEdidaQuantidade As Integer, _
                            ByVal iCodigoNivelInspecao As Integer, _
                            ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(20) As SqlParameter
        Dim i As Integer = 0

        Try
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Und. Med. Dimensão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida_dimensao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoUnidadeMedidaDimensao = -1, DBNull.Value, iCodigoUnidadeMedidaDimensao) : i += 1

            'Seta Parametros - Und. Med. Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida_quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoUnidadeMEdidaQuantidade = -1, DBNull.Value, iCodigoUnidadeMEdidaQuantidade) : i += 1

            'Seta Parametros - Dimensao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "dimensao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDimensao : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "comprimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dComprimento : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "largura"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dLargura : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "altura"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAltura : i += 1

            'Seta Parametros - SC
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sc"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iSC : i += 1

            'Seta Parametros - DET
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "det"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iDET : i += 1

            'Seta Parametros - MP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "mp"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sMP : i += 1


            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_pai"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Item Filho
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_filho"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItemFilho : i += 1

            'Seta Parametros - Código Item Original
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_original"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoItemOriginal = -1, DBNull.Value, lCodigoItemOriginal) : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            'Seta Parametros - Código Unidade de Medida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoUnidadeMedida : i += 1

            'Seta Parametros - Referência
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "referencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dReferencia : i += 1

            'Seta Parametros - Código Item Filho Antigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_filho_antigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItemAntigo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_nivel_inspecao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoNivelInspecao = -1, DBNull.Value, iCodigoNivelInspecao) : i += 1

            'Seta Parametros - Valor Unitário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_unitario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = 0 : i += 1

            'Seta Parametros - Valor Unitário Desconto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_unitario_desconto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = 0

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_item_bom", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteBOMOrcamento(ByVal lCodigoProduto As Long)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_pai"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_item_bom_orcamento", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteItemBOM(ByVal lCodigoProduto As Long)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel 
                i = 0

                'Seta Parametros - Código Produto
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_item_pai"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoProduto : i += 1

                'Seta Parametros - Codigo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_item_bom", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteItemBOMTreeView(ByVal lCodigoProduto As Long)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            For Each oNode As TreeNode In gSelecaoNode

                If lCodigoProduto <> oNode.Tag Then

                    'Seta Váriavel
                    i = 0

                    'Seta Parametros - Código Produto
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_item_pai"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                    oSqlParameter(i).Value = lCodigoProduto : i += 1

                    'Seta Parametros - Codigo
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                    oSqlParameter(i).Value = oNode.Tag : i += 1

                    'Seta Parametros - Codigo Empresa
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_empresa"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                    oSqlParameter(i).Value = goUsuario.iEmpresa

                    'Executa Query
                    ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_item_bom", oSqlParameter)

                    oNode.Remove()

                End If

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosTipoItemBOM(ByVal iTipoItem As Integer, _
                                    ByRef bItemCompra As Boolean, _
                                    ByRef bItemProducao As Boolean, _
                                    ByRef bItemAtivoFixo As Boolean, _
                                    ByRef bItemAlternativo As Boolean)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Código Tipo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iTipoItem

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_static_tipo_item_bom_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Váriaveis
                bItemCompra = oSqlDataReader.Item("item_compra")
                bItemProducao = oSqlDataReader.Item("item_producao")
                bItemAtivoFixo = oSqlDataReader.Item("item_ativo_fixo")
                bItemAlternativo = oSqlDataReader.Item("alternativo")

            End While

            'Fecha o DataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosBOM(ByVal lCodigoItemPai As Long, _
                         ByVal lCodigoItemFilho As Long, _
                         ByVal cboTipoItem As UIComboBox, _
                         ByVal cboCodigoItemOriginal As UIComboBox, _
                         ByVal cboCodigoItem As UIComboBox, _
                         ByVal cboUnidadeMedida As UIComboBox, _
                         ByVal txtQuantidade As NumericEditBox, _
                         ByVal txtReferencia As NumericEditBox, _
                         ByVal txtPosicao As MaskedEditBox, _
                         ByVal txtSC As NumericEditBox, _
                         ByVal txtDET As NumericEditBox, _
                         ByVal txtMP As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Código Item Pai
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_pai"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItemPai : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Item Filho
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_filho"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItemFilho

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_item_bom_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Váriaveis
                cboTipoItem.SelectedValue = oSqlDataReader.Item("codigo_tipo_item_bom")
                cboCodigoItemOriginal.SelectedValue = oSqlDataReader.Item("codigo_item_original")
                cboCodigoItem.SelectedValue = oSqlDataReader.Item("codigo_item_filho")
                txtReferencia.Value = oSqlDataReader.Item("referencia")
                txtQuantidade.Value = oSqlDataReader.Item("quantidade")
                cboUnidadeMedida.SelectedValue = oSqlDataReader.Item("codigo_unidade_medida")
                txtPosicao.Text = ""               'oSqlDataReader.Item("posicao")

                txtSC.Text = oSqlDataReader.Item("sc")
                txtDET.Text = oSqlDataReader.Item("det")
                txtMP.Text = oSqlDataReader.Item("mp")

            End While

            'Fecha o DataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridBOM(ByVal oGrid As GridEX, _
                           ByVal lCodigoProduto As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_pai"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_item_bom", oSqlParameter)

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

    Public Sub LoadTreeViewBOM(ByVal oTreeView As TreeView, _
                                ByVal lCodigoItem As Long, _
                                Optional ByVal iNivel As Integer = 1)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nivel"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(lCodigoItem = -1, iNivel, -1) : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_item_bom_treeview", oSqlParameter)

            While oSqlDataReader.Read

                If oSqlDataReader.Item("nivel") = 1 Then

                    Dim oNode As TreeNode
                    oNode = oTreeView.Nodes.Add(oSqlDataReader.Item("codigo_filho"), oSqlDataReader.Item("item_filho"))
                    oNode.Tag = oSqlDataReader.Item("codigo_filho_int")
                    oNode.ForeColor = Color.Black

                Else

                    Dim oNodePai As TreeNode
                    Dim oNodeFilho As TreeNode
                    If oTreeView.Nodes.Find(oSqlDataReader.Item("codigo_pai"), True).Count > 0 Then
                        oNodePai = oTreeView.Nodes.Find(oSqlDataReader.Item("codigo_pai"), True)(0)
                        If oNodePai.Nodes.Find(oSqlDataReader.Item("codigo_filho"), True).Count = 0 Then
                            oNodeFilho = oNodePai.Nodes.Add(oSqlDataReader.Item("codigo_filho"), oSqlDataReader.Item("item_filho"))
                            oNodeFilho.Tag = oSqlDataReader.Item("codigo_filho_int")
                            'oNodeFilho.ForeColor = IIf(oSqlDataReader.Item("tipo") = 2, Color.Blue, Color.Black)

                            If oSqlDataReader.Item("item_fantasma") = True Then
                                oNodeFilho.ForeColor = Color.Firebrick
                            ElseIf oSqlDataReader.Item("gera_op") = True Then
                                oNodeFilho.ForeColor = Color.ForestGreen
                            Else
                                oNodeFilho.ForeColor = Color.SteelBlue
                            End If





                        End If

                    End If

                End If

            End While

            'Carrega Nível seguinte
            If oSqlDataReader.HasRows Then Call LoadTreeViewBOM(oTreeView, -1, iNivel + 1)

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub SaveBOM(ByVal oRowUpdate As Hashtable, _
                       ByVal lCodigoProduto As Long)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim oRow As GridEXRow
        Dim i As Integer

        Try

            For Each oRow In oRowUpdate.Values

                i = 0

                'Seta Parametros - Código Produto
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_item_pai"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoProduto : i += 1

                'Seta Parametros - Código Produto
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_item_filho_antigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo_item").Value : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Valor Unitário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor_unitario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("valor_unitario").Value : i += 1

                'Seta Parametros - Valor Unitário Desconto
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor_unitario_desconto"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("valor_unitario_desconto").Value : i += 1

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_item_bom_desconto_percentual", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaCodigoBOM(ByVal lCodigo As Long, _
                                    ByVal lCodigoMateriaPrima As Long, _
                                    ByVal lCodigoMateriaPrimaOld As Long, _
                                    ByVal sMp As String) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim iReturn As Integer
        Dim i As Integer = 0

        Try

            'Seta Retorno da Função
            ValidaCodigoBOM = False

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código Filho
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_filho"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoMateriaPrima : i += 1

            'Seta Parametros - Código Filho Old
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_filho_old"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoMateriaPrimaOld : i += 1

            'Seta Parametros - mp
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "mp"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sMp : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_cadastro_basico_produto_bom", oSqlParameter), Integer)

            'Seta Retorno da Função
            ValidaCodigoBOM = IIf(iReturn > 0, False, True)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub LoadDadosExportarBOM(ByVal iCodigoPai As Integer, _
                                  ByVal iCodigoFilho As Integer, _
                                  ByRef dQuantidade As Double, _
                                  ByRef sCodigoProduto As String, _
                                  ByRef sCodigo2 As String, _
                                  ByRef sDescricao As String, _
                                  ByRef sTipo As String, _
                                  ByRef sOrigem As String, _
                                  ByRef sUnidadeMedida As String, _
                                  ByRef sGrupoItem As String, _
                                  ByRef sSubgrupo1 As String, _
                                  ByRef sD1Subgrupo1 As String, _
                                  ByRef sD2Subgrupo1 As String, _
                                  ByRef sSubgrupo2 As String, _
                                  ByRef sD1Subgrupo2 As String, _
                                  ByRef sRevisao As String, _
                                  ByRef sSC As String, _
                                  ByRef sDET As String, _
                                  ByRef sMP As String, _
                                  ByRef sDimensao As String, _
                                  ByRef sUnidadeDimensao As String)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Código Pai
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_pai"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoPai : i += 1

            'Seta Parametros - Código Filho
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_filho"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFilho : i += 1

            'Seta Parametros - Código Pai
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_item_bom_exportar", oSqlParameter)

            While oSqlDataReader.Read


                sCodigoProduto = oSqlDataReader.Item("codigo_item")
                sCodigo2 = oSqlDataReader.Item("codigo_item2")
                sDescricao = oSqlDataReader.Item("descricao")
                sTipo = oSqlDataReader.Item("tipo")
                sOrigem = oSqlDataReader.Item("origem")
                sUnidadeMedida = oSqlDataReader.Item("unidade_medida")
                dQuantidade = oSqlDataReader.Item("quantidade")


                sGrupoItem = oSqlDataReader.Item("grupo_item")
                sSubgrupo1 = oSqlDataReader.Item("subgrupo1")
                sD1Subgrupo1 = oSqlDataReader.Item("detalhe1_subgrupo1")
                sD2Subgrupo1 = oSqlDataReader.Item("detalhe2_subgrupo1")
                sSubgrupo2 = oSqlDataReader.Item("subgrupo2")
                sD1Subgrupo2 = oSqlDataReader.Item("detalhe1_subgrupo2")

                sRevisao = oSqlDataReader.Item("revisao")

                sSC = oSqlDataReader.Item("sc")
                sDET = oSqlDataReader.Item("det")
                sMP = oSqlDataReader.Item("mp")
                sDimensao = oSqlDataReader.Item("dimensao")
                sUnidadeDimensao = oSqlDataReader.Item("unidade_medida_dimensao")


            End While

            'Fecha o DataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadBOMGridTeste(ByVal oGrid As GridEX, _
                           ByVal lCodigoItem As Long)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim oDataSet As DataSet
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_item_bom_treeview", oSqlParameter)

            'Configura DataMember
            'ConfigurarDataMemberGrid(oGrid)

            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadBOMGrid(ByVal oGrid As GridEX, _
                           ByVal lCodigoItem As Long)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim oDataSet As DataSet
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_item_bom_grid", oSqlParameter)

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oDataSet.Tables(0).Columns("pk"), oDataSet.Tables(1).Columns("pk_pai2"))

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(2).TableName, oDataSet.Tables(1).Columns("pk2"), oDataSet.Tables(2).Columns("pk_pai3"))

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(3).TableName, oDataSet.Tables(2).Columns("pk3"), oDataSet.Tables(3).Columns("pk_pai4"))

            'Configura DataMember
            ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName
            oGrid.RootTable.ChildTables(0).ChildTables(0).DataMember = oDataSet.Tables(2).TableName
            oGrid.RootTable.ChildTables(0).ChildTables(0).ChildTables(0).DataMember = oDataSet.Tables(3).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridControle(ByVal oGrid As GridEX, _
                                ByVal lCodigoItem As Long)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oDataSet As DataSet
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_item_bom_grid_indicador", oSqlParameter)

            'Adiciona Relacionamento
            'oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oDataSet.Tables(0).Columns("codigo_item_pai"), oDataSet.Tables(1).Columns("codigo_item"))

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            'oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    
    Public Function VerificaEdicaoBOM(ByVal iCodigoItem As Integer) As Boolean

        VerificaEdicaoBOM = False

        'Variaveis Locais
        Dim iReturn As Integer
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoItem : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(SQLHelper.ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validade_producao_importacao_bom_item_mp", oSqlParameter), Integer)

            'Seta Retorno da Função
            VerificaEdicaoBOM = IIf(iReturn = 0, False, True)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: PRODUTO - DESPESA :::"

    Public Sub DeleteDespesa(ByVal lCodigoProduto As Long)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_item_despesa", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertDespesa(ByVal lCodigoProduto As Long, _
                             ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In oGrid.GetDataRows

                'Verifiva se foi Preenchido o Valor Total
                If IsNumeric(oRow.Cells("valor_total").Value) Then

                    'Seta Váriavel
                    i = 0

                    'Seta Parametros - Código Produto
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_item"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                    oSqlParameter(i).Value = lCodigoProduto : i += 1

                    'Seta Parametros - Codigo Despesa
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_despesa"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.Int
                    oSqlParameter(i).Value = oRow.Cells("codigo_despesa").Value : i += 1

                    'Seta Parametros - Codigo Empresa
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_empresa"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                    oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                    'Seta Parametros - Quantidade
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "quantidade"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.Float
                    oSqlParameter(i).Value = oRow.Cells("quantidade").Value : i += 1

                    'Seta Parametros - Valor 
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "valor"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.Float
                    oSqlParameter(i).Value = oRow.Cells("valor").Value

                    'Executa Query
                    ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_item_despesa", oSqlParameter)

                End If

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: PRODUTO - DISPARCO :::"

    Public Sub InsertDisparco(ByVal sDiametro As String, _
                              ByVal sModelo As String, _
                              ByVal sFluido As String, _
                              ByVal sPressaoEntrada As String, _
                              ByVal sPressaoSaida As String, _
                              ByVal dTemperaturaInicial As Double, _
                              ByVal dTemperaturaFinal As Double, _
                              ByVal sVazao As String, _
                              ByVal iTempoReposicaoMes As Integer)

        'Variaveis Locais
        Dim oSqlParameter(11) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Diametro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "diametro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = IIf(sDiametro = "", DBNull.Value, sDiametro) : i += 1

            'Seta Parametros - Modelo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "modelo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = IIf(sModelo = "", DBNull.Value, sModelo) : i += 1

            'Seta Parametros - Fluido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fluido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = IIf(sFluido = "", DBNull.Value, sFluido) : i += 1

            'Seta Parametros - Pressão de Entrada
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pressao_entrada"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = IIf(sPressaoEntrada = "", DBNull.Value, sPressaoEntrada) : i += 1

            'Seta Parametros - Pressão de Saída
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pressao_saida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = IIf(sPressaoSaida = "", DBNull.Value, sPressaoSaida) : i += 1

            'Seta Parametros - Temperatura Inicial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "temperatura_inicial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTemperaturaInicial : i += 1

            'Seta Parametros - Temperatura Final
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "temperatura_final"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTemperaturaFinal : i += 1

            'Seta Parametros - Vazao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "vazao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = IIf(sVazao = "", DBNull.Value, sVazao) : i += 1

            'Seta Parametros - Tempo de Reposição - Mês
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tempo_reposicao_mes"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iTempoReposicaoMes

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_produto_disparco", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateDisparco(ByVal sDiametro As String, _
                              ByVal sModelo As String, _
                              ByVal sFluido As String, _
                              ByVal sPressaoEntrada As String, _
                              ByVal sPressaoSaida As String, _
                              ByVal dTemperaturaInicial As Double, _
                              ByVal dTemperaturaFinal As Double, _
                              ByVal sVazao As String, _
                              ByVal iTempoReposicaoMes As Integer)

        'Variaveis Locais
        Dim oSqlParameter(10) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Diametro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "diametro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = IIf(sDiametro = "", DBNull.Value, sDiametro) : i += 1

            'Seta Parametros - Modelo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "modelo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = IIf(sModelo = "", DBNull.Value, sModelo) : i += 1

            'Seta Parametros - Fluido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fluido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = IIf(sFluido = "", DBNull.Value, sFluido) : i += 1

            'Seta Parametros - Pressão de Entrada
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pressao_entrada"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = IIf(sPressaoEntrada = "", DBNull.Value, sPressaoEntrada) : i += 1

            'Seta Parametros - Pressão de Saída
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pressao_saida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = IIf(sPressaoSaida = "", DBNull.Value, sPressaoSaida) : i += 1

            'Seta Parametros - Temperatura Inicial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "temperatura_inicial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTemperaturaInicial : i += 1

            'Seta Parametros - Temperatura Final
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "temperatura_final"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTemperaturaFinal : i += 1

            'Seta Parametros - Vazao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "vazao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = IIf(sVazao = "", DBNull.Value, sVazao) : i += 1

            'Seta Parametros - Tempo de Reposição - Mês
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tempo_reposicao_mes"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iTempoReposicaoMes

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_produto_disparco", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: PRODUTO - LMTerm :::"

    Public Sub InsertLMTerm(ByVal sFabricante As String, _
                            ByVal sModelo As String, _
                            ByVal dLargura As Double, _
                            ByVal dAltura As Double, _
                            ByVal dComprimento As Double, _
                            ByVal dDiametroInterno As Double, _
                            ByVal dDiametroExterno As Double, _
                            ByVal dDiametroNominal As Double, _
                            ByVal sMaterial As String, _
                            ByVal sNumeroSerie As String, _
                            ByVal dTensao As Double, _
                            ByVal dPotencia As Double, _
                            ByVal dCorrente As Double, _
                            ByVal dCapacidade As Double, _
                            ByVal sObservacao As String)

        'Variaveis Locais
        Dim oSqlParameter(16) As SqlParameter
        Dim i As Integer = 0

        Try
            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Fabricante
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fabricante"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sFabricante = "", DBNull.Value, sFabricante) : i += 1

            'Seta Parametros - Modelo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "modelo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sModelo = "", DBNull.Value, sModelo) : i += 1

            'Seta Parametros - Largura
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "largura"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dLargura : i += 1

            'Seta Parametros - Altura
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "altura"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAltura : i += 1

            'Seta Parametros - Comprimento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "comprimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dComprimento : i += 1

            'Seta Parametros - Diamentro Interno
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "diametro_interno"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDiametroInterno : i += 1

            'Seta Parametros - Diametro Externo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "diametro_externo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDiametroExterno : i += 1

            'Seta Parametros - Diametro Nominal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "diametro_nominal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDiametroNominal : i += 1

            'Seta Parametros - Material
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "material"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(sMaterial = "", DBNull.Value, sMaterial) : i += 1

            'Seta Parametros - Número de Série
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_serie"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sNumeroSerie = "", DBNull.Value, sNumeroSerie) : i += 1

            'Seta Parametros - Tensão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tensao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTensao : i += 1

            'Seta Parametros - Potência
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "potencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPotencia : i += 1

            'Seta Parametros - Corrente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "corrente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAltura : i += 1

            'Seta Parametros - Capacidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "capacidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dCapacidade : i += 1

            'Seta Parametros - Observação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = IIf(sObservacao = "", DBNull.Value, sObservacao)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_produto_lmterm", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateLMTerm(ByVal sFabricante As String, _
                            ByVal sModelo As String, _
                            ByVal dLargura As Double, _
                            ByVal dAltura As Double, _
                            ByVal dComprimento As Double, _
                            ByVal dDiametroInterno As Double, _
                            ByVal dDiametroExterno As Double, _
                            ByVal dDiametroNominal As Double, _
                            ByVal sMaterial As String, _
                            ByVal sNumeroSerie As String, _
                            ByVal dTensao As Double, _
                            ByVal dPotencia As Double, _
                            ByVal dCorrente As Double, _
                            ByVal dCapacidade As Double, _
                            ByVal sObservacao As String)

        'Variaveis Locais
        Dim oSqlParameter(16) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Fabricante
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fabricante"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sFabricante = "", DBNull.Value, sFabricante) : i += 1

            'Seta Parametros - Modelo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "modelo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sModelo = "", DBNull.Value, sModelo) : i += 1

            'Seta Parametros - Largura
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "largura"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dLargura : i += 1

            'Seta Parametros - Altura
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "altura"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAltura : i += 1

            'Seta Parametros - Comprimento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "comprimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dComprimento : i += 1

            'Seta Parametros - Diamentro Interno
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "diametro_interno"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDiametroInterno : i += 1

            'Seta Parametros - Diametro Externo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "diametro_externo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDiametroExterno : i += 1

            'Seta Parametros - Diametro Nominal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "diametro_nominal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDiametroNominal : i += 1

            'Seta Parametros - Material
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "material"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(sMaterial = "", DBNull.Value, sMaterial) : i += 1

            'Seta Parametros - Número de Série
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_serie"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sNumeroSerie = "", DBNull.Value, sNumeroSerie) : i += 1

            'Seta Parametros - Tensão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tensao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTensao : i += 1

            'Seta Parametros - Potência
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "potencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPotencia : i += 1

            'Seta Parametros - Corrente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "corrente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAltura : i += 1

            'Seta Parametros - Capacidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "capacidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dCapacidade : i += 1

            'Seta Parametros - Observação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = IIf(sObservacao = "", DBNull.Value, sObservacao)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_produto_lmterm", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: PRODUTO - LB Medica :::"

    Public Sub InsertLBMedica(ByVal iCodigoFamilia As Integer, _
                              ByVal iCodigoTipo As Integer, _
                              ByVal iCodigoAgulha As Integer, _
                              ByVal iCodigoFormato As Integer, _
                              ByVal iCodigoBitola As Integer, _
                              ByVal iCodigoEspecialidade As Integer, _
                              ByVal iCodigoComprimento As Integer)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try
            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Família
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_familia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoFamilia = -1, DBNull.Value, iCodigoFamilia) : i += 1

            'Seta Parametros - Código Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoTipo = -1, DBNull.Value, iCodigoTipo) : i += 1

            'Seta Parametros - Código Agulha
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_agulha"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoAgulha = -1, DBNull.Value, iCodigoAgulha) : i += 1

            'Seta Parametros - Código Formato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_formato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoFormato = -1, DBNull.Value, iCodigoFormato) : i += 1

            'Seta Parametros - Código Bitola
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_bitola"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoBitola = -1, DBNull.Value, iCodigoBitola) : i += 1

            'Seta Parametros - Código Especialidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_especialidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoEspecialidade = -1, DBNull.Value, iCodigoEspecialidade) : i += 1

            'Seta Parametros - Código Comprimento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_comprimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoComprimento = -1, DBNull.Value, iCodigoComprimento)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_produto_lbmedica", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateLBMedica(ByVal iCodigoFamilia As Integer, _
                              ByVal iCodigoTipo As Integer, _
                              ByVal iCodigoAgulha As Integer, _
                              ByVal iCodigoFormato As Integer, _
                              ByVal iCodigoBitola As Integer, _
                              ByVal iCodigoEspecialidade As Integer, _
                              ByVal iCodigoComprimento As Integer)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try
            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Família
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_familia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoFamilia = -1, DBNull.Value, iCodigoFamilia) : i += 1

            'Seta Parametros - Código Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoTipo = -1, DBNull.Value, iCodigoTipo) : i += 1

            'Seta Parametros - Código Agulha
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_agulha"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoAgulha = -1, DBNull.Value, iCodigoAgulha) : i += 1

            'Seta Parametros - Código Formato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_formato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoFormato = -1, DBNull.Value, iCodigoFormato) : i += 1

            'Seta Parametros - Código Bitola
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_bitola"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoBitola = -1, DBNull.Value, iCodigoBitola) : i += 1

            'Seta Parametros - Código Especialidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_especialidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoEspecialidade = -1, DBNull.Value, iCodigoEspecialidade) : i += 1

            'Seta Parametros - Código Comprimento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_comprimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoComprimento = -1, DBNull.Value, iCodigoComprimento)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_produto_lbmedica", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadHistoricoOrcamento(ByVal oGrid As GridEX, _
                                      ByVal lCodigoItem As Long, _
                                      ByVal sDataInicio As String, _
                                      ByVal sDataTermino As String, _
                                      ByVal sCliente As String, _
                                      ByVal bProdutosSimilares As Boolean)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim oDataSet As DataSet
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Data Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataInicio), sDataInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataTermino), sDataTermino, DBNull.Value) : i += 1

            'Seta Parametros - Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sCliente : i += 1

            'Seta Parametros - Produtos Similares
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "produtos_similares"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bProdutosSimilares : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_historico_orcamento", oSqlParameter)

            'Carrega Grid
            Call ConfigurarDataMemberGrid(oGrid)
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadHistoricoOrcamentoPedidoVenda(ByVal oGrid As GridEX, _
                                                 ByVal lCodigoOrcamento As Long, _
                                                 ByVal iCodigoOrcamentoItem As Integer)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim oDataSet As DataSet
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Orçamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_orcamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoOrcamento : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoOrcamentoItem : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_historico_orcamento_pedido_venda", oSqlParameter)

            'Carrega Grid
            Call ConfigurarDataMemberGrid(oGrid)
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadHistoricoVendaAnalitico(ByVal oGrid As GridEX, _
                                           ByVal lCodigoItem As Long, _
                                           ByVal sDataInicio As String, _
                                           ByVal sDataTermino As String, _
                                           ByVal sCliente As String, _
                                           ByVal bProdutosSimilares As Boolean, _
                                           ByVal iFatura As Integer)

        'Variaveis Locais
        Dim oSqlParameter(6) As SqlParameter
        Dim oDataSet As DataSet
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Data Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataInicio), sDataInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataTermino), sDataTermino, DBNull.Value) : i += 1

            'Seta Parametros - Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sCliente : i += 1

            'Seta Parametros - Produtos Similares
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "produtos_similares"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bProdutosSimilares : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Fatura
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fatura"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = IIf(iFatura = -1, DBNull.Value, IIf(iFatura = 1, True, False))

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_historico_venda_analitico", oSqlParameter)

            'Carrega Grid
            Call ConfigurarDataMemberGrid(oGrid)
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadHistoricoVendaDiaria(ByVal oGrid As GridEX, _
                                        ByVal lCodigoItem As Long, _
                                        ByVal sDataInicio As String, _
                                        ByVal sDataTermino As String, _
                                        ByVal sAgrupado As String, _
                                        ByVal bProdutosSimilares As Boolean, _
                                        ByVal iFatura As Integer)

        'Variaveis Locais
        Dim oSqlParameter(6) As SqlParameter
        Dim oDataSet As DataSet
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Data Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataInicio), sDataInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataTermino), sDataTermino, DBNull.Value) : i += 1

            'Seta Parametros - Agrupado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "agrupado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sAgrupado : i += 1

            'Seta Parametros - Produtos Similares
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "produtos_similares"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bProdutosSimilares : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Fatura
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fatura"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = IIf(iFatura = -1, DBNull.Value, IIf(iFatura = 1, True, False))

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_historico_venda_diaria", oSqlParameter)

            'Carrega Grid
            Call ConfigurarDataMemberGrid(oGrid)
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadHistoricoVendaMensal(ByVal oGrid As GridEX, _
                                        ByVal lCodigoItem As Long, _
                                        ByVal sDataInicio As String, _
                                        ByVal sDataTermino As String, _
                                        ByVal sAgrupado As String, _
                                        ByVal bProdutosSimilares As Boolean, _
                                        ByVal iFatura As Integer)

        'Variaveis Locais
        Dim oSqlParameter(6) As SqlParameter
        Dim oDataSet As DataSet
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Data Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataInicio), sDataInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataTermino), sDataTermino, DBNull.Value) : i += 1

            'Seta Parametros - Agrupado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "agrupado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sAgrupado : i += 1

            'Seta Parametros - Produtos Similares
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "produtos_similares"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bProdutosSimilares : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Fatura
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fatura"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = IIf(iFatura = -1, DBNull.Value, IIf(iFatura = 1, True, False))

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_historico_venda_mensal", oSqlParameter)

            'Carrega Grid
            Call ConfigurarDataMemberGrid(oGrid)
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadPedidoVendaAberto(ByVal oGrid As GridEX, _
                                     ByVal lCodigoItem As Long)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oDataSet As DataSet
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_pedido_venda_aberto", oSqlParameter)

            'Carrega Grid
            Call ConfigurarDataMemberGrid(oGrid)
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadCompra(ByVal oGrid As GridEX, _
                          ByVal lCodigoItem As Long, _
                          ByVal sDataInicio As String, _
                          ByVal sDataTermino As String, _
                          ByVal sFornecedor As String)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim oDataSet As DataSet
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Data Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataInicio), sDataInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataTermino), sDataTermino, DBNull.Value) : i += 1

            'Seta Parametros - Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sFornecedor : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_historico_compra", oSqlParameter)

            'Carrega Grid
            Call ConfigurarDataMemberGrid(oGrid)
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub AlterarCodigoEstoque(ByVal lCodigoItemFornecedor As Long, _
                                    ByVal lCodigoItemEstoque As Long, _
                                    ByVal lCodigoFornecedor As Long)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter

        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItemFornecedor : i += 1

            'Seta Parametros - Código Item Estoque
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_estoque"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItemEstoque : i += 1

            'Seta Parametros - Código Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoFornecedor : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_item_alterar_codigo", oSqlParameter)



        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub AlterarCodigoEstoqueIndividual(ByVal lCodigoItemFornecedor As Long, _
                                    ByVal lCodigoItemEstoque As Long, _
                                    ByVal sTipo As String, _
                                    ByVal lCodigoCapa As Long, _
                                    ByVal iCodigoLinha As Integer)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter

        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item Antigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItemFornecedor : i += 1

            'Seta Parametros - Código Item Estoque
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_estoque"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItemEstoque : i += 1


            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sTipo : i += 1

            'Seta Parametros - Código Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCapa : i += 1

            'Seta Parametros - Código linha
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_linha"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoLinha : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_item_alterar_codigo_individual", oSqlParameter)



        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadPedidoCompra(ByVal oGrid As GridEX, _
                                ByVal lCodigoItem As Long, _
                                ByVal sDataInicio As String, _
                                ByVal sDataTermino As String, _
                                ByVal bPedidoCompraAberto As Boolean, _
                                ByVal sFornecedor As String)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim oDataSet As DataSet
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Data Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataInicio), sDataInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataTermino), sDataTermino, DBNull.Value) : i += 1

            'Seta Parametros - Pedido de Compra em Aberto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pedido_compra_aberto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bPedidoCompraAberto : i += 1

            'Seta Parametros - Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sFornecedor : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_historico_pedido_compra", oSqlParameter)

            'Carrega Grid
            Call ConfigurarDataMemberGrid(oGrid)
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadEstoqueMovimentacao(ByVal oGrid As GridEX, _
                                       ByVal lCodigoItem As Long, _
                                       ByVal sDataInicio As String, _
                                       ByVal sDataTermino As String)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim oDataSet As DataSet
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Data Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataInicio), sDataInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataTermino), sDataTermino, DBNull.Value) : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_historico_movimentacao_estoque", oSqlParameter)

            'Carrega Grid
            Call ConfigurarDataMemberGrid(oGrid)
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: PRODUTO - FORMAÇÃO DO PREÇO DE VENDA :::"

    Public Sub LoadGridPrecoVenda(ByVal oGrid As GridEX, _
                                  ByVal sCodigoProduto As String, _
                                  ByVal sDescricao As String)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim oDataSet As DataSet
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sCodigoProduto : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Executa Query
            'oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_item_disparco", oSqlParameter)

            'Carrega Grid
            'Call ConfigurarDataMemberGrid(oGrid)
            'oGrid.DataSource = oDataSet.DefaultViewManager
            'oGrid.DataMember = oDataSet.Tables(0).TableName: oGrid.MoveFirst

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: PRODUTO - QUALIDADE :::"

    Public Sub InsertQualidade(ByVal lCodigoProduto As Long, _
                               ByVal iCaracteristicaInspecionar As Integer, _
                               ByVal dValorNominal As Double, _
                               ByVal dValorMinimo As Double, _
                               ByVal dValorMaximo As Double, _
                               ByVal sObservacao As String)

        'Variaveis Locais
        Dim oSqlParameter(6) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Caracteristica Inspecionar
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_caracteristica_inspecionar"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCaracteristicaInspecionar : i += 1

            'Seta Parametros - Valor Nominal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_nominal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dValorNominal = -1, DBNull.Value, dValorNominal) : i += 1

            'Seta Parametros - Valor Minimo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_minimo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dValorMinimo = -1, DBNull.Value, dValorMinimo) : i += 1

            'Seta Parametros - Valor Máximo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_maximo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dValorMaximo = -1, DBNull.Value, dValorMaximo) : i += 1

            'Seta Parametros - Observacao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 1000
            oSqlParameter(i).Value = IIf(sObservacao = "", DBNull.Value, sObservacao)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_produto_qualidade", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateQualidade(ByVal lCodigoProduto As Long, _
                               ByVal iCaracteristicaInspecionar As Integer, _
                               ByVal dValorNominal As Double, _
                               ByVal dValorMinimo As Double, _
                               ByVal dValorMaximo As Double, _
                               ByVal sObservacao As String, _
                               ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(7) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Caracteristica Inspecionar
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_caracteristica_inspecionar"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCaracteristicaInspecionar : i += 1

            'Seta Parametros - Valor Nominal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_nominal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dValorNominal = -1, DBNull.Value, dValorNominal) : i += 1

            'Seta Parametros - Valor Minimo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_minimo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dValorMinimo = -1, DBNull.Value, dValorMinimo) : i += 1

            'Seta Parametros - Valor Máximo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_maximo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dValorMaximo = -1, DBNull.Value, dValorMaximo) : i += 1

            'Seta Parametros - Observacao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 1000
            oSqlParameter(i).Value = IIf(sObservacao = "", DBNull.Value, sObservacao) : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_produto_qualidade", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteQualidade(ByVal lCodigoProduto As Long)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel 
                i = 0

                'Seta Parametros - Código Item
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_item"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoProduto : i += 1

                'Seta Parametros - Codigo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_produto_qualidade", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridQualidade(ByVal oGrid As GridEX, _
                                 ByVal lCodigoProduto As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_qualidade", oSqlParameter)

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

#End Region

#Region "::: PRODUTO - COMPRA :::"

    Public Sub LoadGridHistoricoPrecoCompra(ByVal oGrid As GridEX, _
                                            ByVal lCodigoProduto As Long, _
                                            ByVal sDataInicio As String, _
                                            ByVal sDataTermino As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Data Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataInicio), sDataInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataTermino), sDataTermino, DBNull.Value) : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_historico_preco_compra", oSqlParameter)

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

    Public Sub LoadGraficoHistoricoPrecoCompra(ByVal oChart As WinControl.Chart, _
                                               ByVal lCodigoProduto As Long, _
                                               ByVal sDataInicio As String, _
                                               ByVal sDataTermino As String)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Data Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataInicio), sDataInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataTermino), sDataTermino, DBNull.Value) : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_historico_preco_compra", oSqlParameter)

            'Limpa Série
            oChart.Series.Clear()

            oChart.Series.Clear()
            oChart.Series.Add("Default")
            oChart.Series("Default").LegendText = "Preço de Compra"
            oChart.Series("Default").Points.DataBind(oSqlDataReader, "data", "valor_final", "Tooltip=valor_final")
            oChart.Series("Default").ShowInLegend = True
            oChart.Series("Default").ShowLabelAsValue = True
            oChart.Series("Default").Type = WinControl.SeriesChartType.Spline
            oChart.ResetAutoValues()

            oChart.ChartAreas("Default").AxisX.Title = "Período (dias)"
            oChart.ChartAreas("Default").AxisX.LabelsAutoFitStyle = WinControl.LabelsAutoFitStyle.LabelsAngleStep45
            oChart.ChartAreas("Default").AxisY.LabelsAutoFitStyle = WinControl.LabelsAutoFitStyle.LabelsAngleStep45
            oChart.ChartAreas("Default").AxisX.IntervalType = WinControl.DateTimeIntervalType.Days

            For Each oDataPoint As WinControl.DataPoint In oChart.Series("Default").Points
                If oDataPoint.YValues(0) <> 0 Then
                    oDataPoint.ShowLabelAsValue = True
                    oDataPoint("LabelStyle") = "Bottom"
                End If
            Next

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: PRODUTO - PREÇO DE VENDA :::"

    Public Sub LoadDadosProduto(ByVal lCodigo As Long, _
                                ByVal iCodigoCliente As Integer, _
                                ByVal txtCodigo As MaskedEditBox, _
                                ByVal txtDescricao As MaskedEditBox, _
                                ByVal txtMarca As MaskedEditBox, _
                                ByVal txtQuantidadeUnidade As NumericEditBox, _
                                ByVal txtCustoTeorico As NumericEditBox, _
                                ByVal txtMargemTeorico As NumericEditBox, _
                                ByVal txtMarkupTeorico As NumericEditBox, _
                                ByVal txtGPTeorico As NumericEditBox, _
                                ByVal txtPrecoVendaTeorico As NumericEditBox, _
                                ByVal txtPrecoUnidadeTeorico As NumericEditBox, _
                                ByVal txtCustoMedio As NumericEditBox, _
                                ByVal txtMargemMedio As NumericEditBox, _
                                ByVal txtMarkupMedio As NumericEditBox, _
                                ByVal txtGPMedio As NumericEditBox, _
                                ByVal txtPrecoVendaMedio As NumericEditBox, _
                                ByVal txtPrecoUnidadeMedio As NumericEditBox, _
                                ByVal txtRecomendacaoVenda As EditBox, _
                                ByVal txtValorUltimaVenda As NumericEditBox, _
                                ByVal txtDataUltimaVenda As MaskedEditBox, _
                                ByVal txtComprouSimilares As MaskedEditBox, _
                                ByVal txtAtrasaPagamentos As MaskedEditBox)
        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCliente : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_dados_venda", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                txtCodigo.Text = oSqlDataReader.Item("codigo_item")
                txtDescricao.Text = oSqlDataReader.Item("descricao")
                txtMarca.Text = oSqlDataReader.Item("marca")
                txtQuantidadeUnidade.Value = oSqlDataReader.Item("fator_conversao_unidade_medida_venda")
                txtCustoTeorico.Value = oSqlDataReader.Item("preco_compra")
                txtMargemTeorico.Value = oSqlDataReader.Item("margem_preco_venda")
                txtGPTeorico.Value = oSqlDataReader.Item("gp_preco_venda")
                txtMarkupTeorico.Value = oSqlDataReader.Item("markup_preco_venda")
                txtPrecoVendaTeorico.Value = oSqlDataReader.Item("preco_venda")
                txtPrecoUnidadeTeorico.Value = oSqlDataReader.Item("preco_venda") / oSqlDataReader.Item("fator_conversao_unidade_medida_venda")
                txtCustoMedio.Value = oSqlDataReader.Item("custo_medio")
                txtMargemMedio.Value = oSqlDataReader.Item("margem_preco_venda")
                txtGPMedio.Value = oSqlDataReader.Item("gp_preco_venda")
                txtMarkupMedio.Value = oSqlDataReader.Item("markup_preco_venda")
                txtPrecoVendaMedio.Value = oSqlDataReader.Item("preco_venda")
                txtPrecoUnidadeMedio.Value = oSqlDataReader.Item("preco_venda") / oSqlDataReader.Item("fator_conversao_unidade_medida_venda")
                txtRecomendacaoVenda.Text = oSqlDataReader.Item("observacao_preco_venda")
                txtValorUltimaVenda.Value = oSqlDataReader.Item("valor_ultima_venda")
                txtDataUltimaVenda.Text = oSqlDataReader.Item("data_ultima_venda")
                txtComprouSimilares.Text = oSqlDataReader.Item("comprou_similares")
                txtAtrasaPagamentos.Text = oSqlDataReader.Item("atrasa_pagamentos")

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

#Region "::: PRODUTO - CENTRO DE CUSTO :::"

    Public Sub InsertCentroCusto(ByVal lCodigoProduto As Long, _
                                 ByVal iCodigoCentroCusto As Integer)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Centro de Custo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_custo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCentroCusto

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_produto_centro_custo", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateCentroCusto(ByVal lCodigoProduto As Long, _
                                 ByVal iCodigoCentroCusto As Integer, _
                                 ByVal iCodigoCentroCustoAntigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Centro de Custo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_custo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCentroCusto : i += 1

            'Seta Parametros - Código Centro de Custo Antigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_custo_antigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCentroCustoAntigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_produto_centro_custo", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteCentroCusto(ByVal lCodigoProduto As Long)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel 
                i = 0

                'Seta Parametros - Código Produto
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_item"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoProduto : i += 1

                'Seta Parametros - Codigo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_centro_custo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_produto_centro_custo", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridCentroCusto(ByVal oGrid As GridEX, _
                                   ByVal lCodigoProduto As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_centro_custo", oSqlParameter)

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

#End Region

#Region "::: PRODUTO - CONTA CONTÁBIL :::"

    Public Sub InsertContaContabil(ByVal lCodigoProduto As Long, _
                                   ByVal sCodigoContaContabil As String)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Conta Contábil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "conta_contabil"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCodigoContaContabil

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_produto_conta_contabil", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateContaContabil(ByVal lCodigoProduto As Long, _
                                   ByVal sCodigoContaContabil As String, _
                                   ByVal sCodigoContaContabilAntigo As String)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Conta Contábil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "conta_contabil"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCodigoContaContabil : i += 1

            'Seta Parametros - Conta Contábil Antigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "conta_contabil_antigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCodigoContaContabilAntigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_produto_conta_contabil", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteContaContabil(ByVal lCodigoProduto As Long)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel 
                i = 0

                'Seta Parametros - Código Produto
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_item"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoProduto : i += 1

                'Seta Parametros - Conta Contábil
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "conta_contabil"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 20
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_produto_conta_contabil", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridContaContabil(ByVal oGrid As GridEX, _
                                     ByVal lCodigoProduto As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_conta_contabil", oSqlParameter)

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

#End Region

#Region "::: PRODUTO - ARTE :::"

    Public Sub InsertArte(ByVal lCodigoItem As Long, _
                          ByVal sDescricao As String, _
                          ByVal sRevisao As String, _
                          ByVal sPath As String, _
                          ByVal iCodigoTipoArquivo As Integer, _
                          ByVal bArteAtual As Boolean, _
                          ByVal sObservacao As String)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0
        Dim sArquivoServidor As String

        Try

            'Carrega Pasta de Arquivo
            sArquivoServidor = LoadDescricao("sp_select_configuracao_interacti_pasta_arquivo " & goUsuario.iEmpresa)

            If sArquivoServidor = "" Then
                Throw New Exception("Não foi configurado a Pasta de Arquivos no Servidor.")
            ElseIf Directory.Exists(sArquivoServidor) = False Then
                Throw New Exception("Você não possui permissão para enxergar a pasta (" & sArquivoServidor & ").")
            Else
                sArquivoServidor = sArquivoServidor & "FILE_" & Format(Now, "ddMMyyy_HHmmss") & "." & Right(sPath, Len(sPath) - InStrRev(sPath, "."))
                While File.Exists(sArquivoServidor) = True
                    sArquivoServidor = sArquivoServidor & "FILE_" & Format(Now, "ddMMyyy_HHmmss") & "." & Right(sPath, Len(sPath) - InStrRev(sPath, "."))
                End While
                File.Copy(sPath, sArquivoServidor)
            End If

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Revisão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "revisao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sRevisao : i += 1

            'Seta Parametros - Código Tipo do Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoTipoArquivo = -1, DBNull.Value, iCodigoTipoArquivo) : i += 1

            'Seta Parametros - Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sArquivoServidor : i += 1

            'Seta Parametros - Arte Atual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arte_atual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bArteAtual : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Observação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5000
            oSqlParameter(i).Value = sObservacao : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_produto_arte", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateArte(ByVal lCodigoItem As Long, _
                          ByVal sDescricao As String, _
                          ByVal sRevisao As String, _
                          ByVal sPath As String, _
                          ByVal sPathAntigo As String, _
                          ByVal iCodigoTipoArquivo As Integer, _
                          ByVal bArteAtual As Boolean, _
                          ByVal sObservacao As String, _
                          ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0
        Dim sArquivoServidor As String

        Try

            If sPath = sPathAntigo Then
                sArquivoServidor = sPath
            Else

                'Carrega Pasta de Arquivo
                sArquivoServidor = LoadDescricao("sp_select_configuracao_interacti_pasta_arquivo " & goUsuario.iEmpresa)

                If sArquivoServidor = "" Then
                    Throw New Exception("Não foi configurado a Pasta de Arquivos no Servidor.")
                ElseIf Directory.Exists(sArquivoServidor) = False Then
                    Throw New Exception("Você não possui permissão para enxergar a pasta (" & sArquivoServidor & ").")
                Else
                    sArquivoServidor = sArquivoServidor & "FILE_" & Format(Now, "ddMMyyy_HHmmss") & "." & Right(sPath, Len(sPath) - InStrRev(sPath, "."))
                    While File.Exists(sArquivoServidor) = True
                        sArquivoServidor = sArquivoServidor & "FILE_" & Format(Now, "ddMMyyy_HHmmss") & "." & Right(sPath, Len(sPath) - InStrRev(sPath, "."))
                    End While
                    File.Copy(sPath, sArquivoServidor)
                    File.Delete(sPathAntigo)
                End If

            End If

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Revisão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "revisao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sRevisao : i += 1

            'Seta Parametros - Código Tipo do Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoTipoArquivo = -1, DBNull.Value, iCodigoTipoArquivo) : i += 1

            'Seta Parametros - Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sArquivoServidor : i += 1

            'Seta Parametros - Arte Atual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arte_atual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bArteAtual : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Observação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5000
            oSqlParameter(i).Value = sObservacao : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_produto_arte", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridArte(ByVal oGrid As GridEX, _
                            ByVal lCodigoProduto As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_arte", oSqlParameter)

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

    Public Sub DeleteArte(ByVal lCodigoProduto As Long)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel 
                i = 0

                'Seta Parametros - Código Produto
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_item"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoProduto : i += 1

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_produto_arte", oSqlParameter)

                'Exclui Arquivo
                File.Delete(oRow.Cells("path").Value)

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

#Region "::: PRODUTO - EMBALAGEM :::"

    Public Sub InsertEmbalagem(ByVal lCodigoProduto As Long, _
                               ByVal iCodigoEmbalagem As Integer, _
                               ByVal dQuantidade As Double)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            'Seta Parametros - Código Embalagem
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_embalagem"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoEmbalagem

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_produto_embalagem", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateEmbalagem(ByVal lCodigoProduto As Long, _
                               ByVal iCodigoEmbalagem As Integer, _
                               ByVal dQuantidade As Double, _
                               ByVal iCodigoEmbalagemAntigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Embalagem
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_embalagem"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoEmbalagem : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            'Seta Parametros - Código Embalagem Antigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_embalagem_antigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoEmbalagemAntigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_produto_embalagem", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteEmbalagem(ByVal lCodigoProduto As Long)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel 
                i = 0

                'Seta Parametros - Código Produto
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_item"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoProduto : i += 1

                'Seta Parametros - Codigo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_embalagem"
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
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_produto_embalagem", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteReferencia(ByVal lCodigoProduto As Long)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel 
                i = 0

                'Seta Parametros - Código Produto
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_item"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoProduto : i += 1

                'Seta Parametros - Codigo
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
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_produto_referencia", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridEmbalagem(ByVal oGrid As GridEX, _
                                 ByVal lCodigoProduto As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_embalagem", oSqlParameter)

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

#End Region

#Region "::: PRODUTO - ORÇAMENTO :::"

    Public Sub InsertProdutoOrcamento(ByVal iCodigoTipoItem As TipoItem, _
                                      ByVal iCodigoGrupoItem As Integer, _
                                      ByVal sCodigoItem As String, _
                                      ByVal sDesenho As String, _
                                      ByVal sRevisao As String, _
                                      ByVal sArquivo As String, _
                                      ByVal sDescricao As String, _
                                      ByVal iCodigoUnidadeMedida As Integer, _
                                      ByVal iCodigoNCM As Integer, _
                                      ByVal dMargem As Double, _
                                      ByVal dTaxaFinanceira As Double, _
                                      ByVal dPrecoVenda As Double, _
                                      ByVal dAliquotaICMS As Double, _
                                      ByVal dAliquotaPIS As Double, _
                                      ByVal dAliquotaCOFINS As Double, _
                                      ByVal dAliquotaIR As Double)

        'Variaveis Locais
        Dim oSqlParameter(17) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Tipo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoItem : i += 1

            'Seta Parametros - Código Grupo de Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_grupo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoGrupoItem : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sCodigoItem : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Desenho
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desenho"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDesenho : i += 1

            'Seta Parametros - Revisão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "revisao_desenho"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sRevisao : i += 1

            'Seta Parametros - Código Unidade Medida - Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoUnidadeMedida : i += 1

            'Seta Parametros - Código NCM
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ncm"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoNCM : i += 1

            'Seta Parametros - Margem
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "margem"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMargem : i += 1

            'Seta Parametros - Taxa Financeira
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "taxa_financeira"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTaxaFinanceira : i += 1

            'Seta Parametros - Preço de Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "preco_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPrecoVenda : i += 1

            'Seta Parametros - Alíquota ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaICMS : i += 1

            'Seta Parametros - Alíquota PIS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_pis"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaPIS : i += 1

            'Seta Parametros - Alíquota COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaCOFINS : i += 1

            'Seta Parametros - Alíquota IR
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_ir"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaIR : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_produto_orcamento", oSqlParameter)

            lCodigoProduto = oSqlParameter(i).Value

            'Insere Desenho no Banco de Dados
            If sArquivo <> "" Then

                'Insere Arquivo - Banco de Dados
                Call InsertArquivoBD("tb_cad_item", _
                                     sDesenho, _
                                     sRevisao, _
                                     sArquivo, _
                                     -1, _
                                     lCodigoProduto)

            End If

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateProdutoOrcamento(ByVal iCodigoTipoItem As TipoItem, _
                                      ByVal iCodigoGrupoItem As Integer, _
                                      ByVal sCodigoItem As String, _
                                      ByVal sDesenho As String, _
                                      ByVal sRevisao As String, _
                                      ByVal sArquivo As String, _
                                      ByVal sArquivoAntigo As String, _
                                      ByVal sDescricao As String, _
                                      ByVal iCodigoUnidadeMedida As Integer, _
                                      ByVal iCodigoNCM As Integer, _
                                      ByVal dMargem As Double, _
                                      ByVal dTaxaFinanceira As Double, _
                                      ByVal dPrecoVenda As Double, _
                                      ByVal dAliquotaICMS As Double, _
                                      ByVal dAliquotaPIS As Double, _
                                      ByVal dAliquotaCOFINS As Double, _
                                      ByVal dAliquotaIR As Double, _
                                      ByVal lCodigoItem As Long)

        'Variaveis Locais
        Dim oSqlParameter(17) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Tipo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoItem : i += 1

            'Seta Parametros - Código Grupo de Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_grupo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoGrupoItem : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sCodigoItem : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Desenho
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desenho"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDesenho : i += 1

            'Seta Parametros - Revisão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "revisao_desenho"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sRevisao : i += 1

            'Seta Parametros - Código Unidade Medida - Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoUnidadeMedida : i += 1

            'Seta Parametros - Código NCM
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ncm"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoNCM : i += 1

            'Seta Parametros - Margem
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "margem"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMargem : i += 1

            'Seta Parametros - Taxa Financeira
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "taxa_financeira"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTaxaFinanceira : i += 1

            'Seta Parametros - Preço de Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "preco_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPrecoVenda : i += 1

            'Seta Parametros - Alíquota ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaICMS : i += 1

            'Seta Parametros - Alíquota PIS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_pis"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaPIS : i += 1

            'Seta Parametros - Alíquota COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaCOFINS : i += 1

            'Seta Parametros - Alíquota IR
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_ir"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaIR : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_produto_orcamento", oSqlParameter)

            'Insere Desenho no Banco de Dados
            If sArquivo <> "" Then

                Call UpdateArquivoBD("tb_cad_item", _
                                     sDesenho, _
                                     sRevisao, _
                                     sArquivo, _
                                     -1, _
                                     sArquivoAntigo, _
                                     lCodigoItem)

            End If

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosProdutoOrcamento(ByVal lCodigoProduto As Long, _
                                         ByRef iCodigoGrupoItem As Integer, _
                                         ByRef sCodigoProduto As String, _
                                         ByRef sDesenho As String, _
                                         ByRef sRevisao As String, _
                                         ByRef sArquivo As String, _
                                         ByRef sDescricao As String, _
                                         ByRef iCodigoUnidadeMedida As Integer, _
                                         ByRef iCodigoNCM As Integer, _
                                         ByRef dMargem As Double, _
                                         ByRef dTaxaFinanceira As Double,
                                         ByRef dAliquotaICMS As Double, _
                                         ByRef dAliquotaPIS As Double, _
                                         ByRef dAliquotaCOFINS As Double, _
                                         ByRef dAliquotaIR As Double)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_orcamento", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    'Carrega Váriavel
                    iCodigoGrupoItem = IIf(IsDBNull(oSqlDataReader.Item("codigo_grupo_item")), -1, oSqlDataReader.Item("codigo_grupo_item"))
                    sCodigoProduto = oSqlDataReader.Item("codigo_item")
                    sDesenho = oSqlDataReader.Item("desenho")
                    sRevisao = oSqlDataReader.Item("revisao_desenho")
                    sArquivo = oSqlDataReader.Item("arquivo")
                    sDescricao = oSqlDataReader.Item("descricao")
                    iCodigoUnidadeMedida = IIf(IsDBNull(oSqlDataReader.Item("codigo_unidade_medida_venda")), -1, oSqlDataReader.Item("codigo_unidade_medida_venda"))
                    iCodigoNCM = IIf(IsDBNull(oSqlDataReader.Item("codigo_ncm")), -1, oSqlDataReader.Item("codigo_ncm"))
                    dMargem = oSqlDataReader.Item("margem_lucro")
                    dTaxaFinanceira = oSqlDataReader.Item("taxa_financeira")
                    dAliquotaICMS = oSqlDataReader.Item("aliquota_icms")
                    dAliquotaPIS = oSqlDataReader.Item("aliquota_pis")
                    dAliquotaCOFINS = oSqlDataReader.Item("aliquota_cofins")
                    dAliquotaIR = oSqlDataReader.Item("aliquota_ir")

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

    Public Sub InsertServicoOrcamento(ByVal iCodigoTipoItem As TipoItem, _
                                      ByVal iCodigoGrupoItem As Integer, _
                                      ByVal sCodigoItem As String, _
                                      ByVal sDesenho As String, _
                                      ByVal sRevisao As String, _
                                      ByVal sArquivo As String, _
                                      ByVal sDescricao As String, _
                                      ByVal dMargem As Double, _
                                      ByVal dTaxaFinanceira As Double, _
                                      ByVal dPrecoVenda As Double, _
                                      ByVal bISSRetido As Boolean, _
                                      ByVal dAliquotaISS As Double, _
                                      ByVal dAliquotaPIS As Double, _
                                      ByVal dAliquotaCOFINS As Double, _
                                      ByVal dAliquotaINSS As Double, _
                                      ByVal dAliquotaCSLL As Double, _
                                      ByVal dAliquotaIR As Double)

        'Variaveis Locais
        Dim oSqlParameter(18) As SqlParameter
        Dim i As Integer = 0
        Dim lCodigoItem As Long

        Try

            'Seta Parametros - Código Tipo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoItem : i += 1

            'Seta Parametros - Código Grupo de Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_grupo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoGrupoItem : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sCodigoItem : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Desenho
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desenho"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDesenho : i += 1

            'Seta Parametros - Revisão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "revisao_desenho"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sRevisao : i += 1

            'Seta Parametros - Margem
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "margem"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMargem : i += 1

            'Seta Parametros - Taxa Financeira
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "taxa_financeira"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTaxaFinanceira : i += 1

            'Seta Parametros - Preço de Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "preco_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPrecoVenda : i += 1

            'Seta Parametros - ISS Retido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "iss_retido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bISSRetido : i += 1

            'Seta Parametros - Alíquota ISS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_iss"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaISS : i += 1

            'Seta Parametros - Alíquota PIS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_pis"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaPIS : i += 1

            'Seta Parametros - Alíquota COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaCOFINS : i += 1

            'Seta Parametros - Alíquota INSS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_inss"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaINSS : i += 1

            'Seta Parametros - Alíquota CSLL
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_csll"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaCSLL : i += 1

            'Seta Parametros - Alíquota IR
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_ir"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaIR : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_servico_orcamento", oSqlParameter)

            lCodigoItem = oSqlParameter(i).Value

            'Insere Desenho no Banco de Dados
            If sArquivo <> "" Then

                'Insere Arquivo - Banco de Dados
                Call InsertArquivoBD("tb_cad_item", _
                                     sDesenho, _
                                     sRevisao, _
                                     sArquivo, _
                                     -1, _
                                     lCodigoItem)

            End If

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateServicoOrcamento(ByVal iCodigoTipoItem As TipoItem, _
                                      ByVal iCodigoGrupoItem As Integer, _
                                      ByVal sCodigoItem As String, _
                                      ByVal sDesenho As String, _
                                      ByVal sRevisao As String, _
                                      ByVal sArquivo As String, _
                                      ByVal sArquivoAntigo As String, _
                                      ByVal sDescricao As String, _
                                      ByVal dMargem As Double, _
                                      ByVal dTaxaFinanceira As Double, _
                                      ByVal dPrecoVenda As Double, _
                                      ByVal bISSRetido As Boolean, _
                                      ByVal dAliquotaISS As Double, _
                                      ByVal dAliquotaPIS As Double, _
                                      ByVal dAliquotaCOFINS As Double, _
                                      ByVal dAliquotaINSS As Double, _
                                      ByVal dAliquotaCSLL As Double, _
                                      ByVal dAliquotaIR As Double, _
                                      ByVal lCodigoItem As Long)

        'Variaveis Locais
        Dim oSqlParameter(18) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Tipo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoItem : i += 1

            'Seta Parametros - Código Grupo de Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_grupo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoGrupoItem : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sCodigoItem : i += 1

            'Seta Parametros - Descrição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Desenho
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desenho"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDesenho : i += 1

            'Seta Parametros - Revisão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "revisao_desenho"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sRevisao : i += 1

            'Seta Parametros - Margem
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "margem"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMargem : i += 1

            'Seta Parametros - Taxa Financeira
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "taxa_financeira"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dTaxaFinanceira : i += 1

            'Seta Parametros - Preço de Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "preco_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPrecoVenda : i += 1

            'Seta Parametros - ISS Retido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "iss_retido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bISSRetido : i += 1

            'Seta Parametros - Alíquota ISS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_iss"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaISS : i += 1

            'Seta Parametros - Alíquota PIS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_pis"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaPIS : i += 1

            'Seta Parametros - Alíquota COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaCOFINS : i += 1

            'Seta Parametros - Alíquota INSS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_inss"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaINSS : i += 1

            'Seta Parametros - Alíquota CSLL
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_csll"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaCSLL : i += 1

            'Seta Parametros - Alíquota IR
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_ir"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaIR : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_servico_orcamento", oSqlParameter)

            'Insere Desenho no Banco de Dados
            If sArquivo <> "" Then

                Call UpdateArquivoBD("tb_cad_item", _
                                     sDesenho, _
                                     sRevisao, _
                                     sArquivo, _
                                     -1, _
                                     sArquivoAntigo, _
                                     lCodigoItem)

            End If

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosServicoOrcamento(ByVal lCodigoServico As Long, _
                                         ByRef iCodigoGrupoItem As Integer, _
                                         ByRef sCodigoServico As String, _
                                         ByRef sDesenho As String, _
                                         ByRef sRevisao As String, _
                                         ByRef sArquivo As String, _
                                         ByRef sDescricao As String, _
                                         ByRef dMargem As Double, _
                                         ByRef dTaxaFinanceira As Double,
                                         ByRef bISSRetido As Boolean, _
                                         ByRef dAliquotaISS As Double, _
                                         ByRef dAliquotaPIS As Double, _
                                         ByRef dAliquotaCOFINS As Double, _
                                         ByRef dAliquotaINSS As Double, _
                                         ByRef dAliquotaCSLL As Double, _
                                         ByRef dAliquotaIR As Double)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoServico : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_servico_orcamento", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    'Carrega Váriavel
                    iCodigoGrupoItem = IIf(IsDBNull(oSqlDataReader.Item("codigo_grupo_item")), -1, oSqlDataReader.Item("codigo_grupo_item"))
                    sCodigoServico = oSqlDataReader.Item("codigo_item")
                    sDesenho = oSqlDataReader.Item("desenho")
                    sRevisao = oSqlDataReader.Item("revisao_desenho")
                    sArquivo = oSqlDataReader.Item("arquivo")
                    sDescricao = oSqlDataReader.Item("descricao")
                    dMargem = oSqlDataReader.Item("margem_lucro")
                    dTaxaFinanceira = oSqlDataReader.Item("taxa_financeira")
                    bISSRetido = oSqlDataReader.Item("iss_retido")
                    dAliquotaISS = oSqlDataReader.Item("aliquota_iss")
                    dAliquotaPIS = oSqlDataReader.Item("aliquota_pis")
                    dAliquotaCOFINS = oSqlDataReader.Item("aliquota_cofins")
                    dAliquotaINSS = oSqlDataReader.Item("aliquota_inss")
                    dAliquotaCSLL = oSqlDataReader.Item("aliquota_csll")
                    dAliquotaIR = oSqlDataReader.Item("aliquota_ir")

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

    Public Sub DeleteOrcamentoItemCentroTrabalho(ByVal lCodigoItem As Long)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_produto_orcamento_centro_trabalho", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertOrcamentoItemCentroTrabalho(ByVal lCodigoItem As Long, _
                                                 ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In oGrid.GetDataRows

                If IsDate(oRow.Cells("quantidade_horas").Value) And IsNumeric(oRow.Cells("valor_hora").Value) Then

                    'Seta Váriavel
                    i = 0

                    'Seta Parametros - Código Item
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_item"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                    oSqlParameter(i).Value = lCodigoItem : i += 1

                    'Seta Parametros - Código Empresa
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_empresa"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                    oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                    'Seta Parametros - Código Centro Trabalho
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_centro_trabalho"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.Int
                    oSqlParameter(i).Value = oRow.Cells("codigo_centro_trabalho").Value : i += 1

                    'Seta Parametros - Valor Hora
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "valor_hora"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.Float
                    oSqlParameter(i).Value = oRow.Cells("valor_hora").Value : i += 1

                    'Seta Parametros - Quantidade Horas
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "quantidade_horas"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.Float
                    oSqlParameter(i).Value = Minute(oRow.Cells("quantidade_horas").Value) + (Hour(oRow.Cells("quantidade_horas").Value) * 60) + (Second(oRow.Cells("quantidade_horas").Value) / 60)

                    'Executa Query
                    ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_produto_orcamento_centro_trabalho", oSqlParameter)

                End If

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridOrcamentoItemCentroTrabalho(ByVal oGrid As GridEX, _
                                                   ByVal lCodigoItem As Long)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oDataSet As DataSet
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_orcamento_centro_trabalho", oSqlParameter)

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

    Public Sub DeleteOrcamentoItemMateriaPrima(ByVal lCodigoItem As Long)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_produto_orcamento_materia_prima", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertOrcamentoItemMateriaPrima(ByVal lCodigoItem As Long, _
                                               ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(7) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In oGrid.GetDataRows

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Item
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_item"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoItem : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Código Matéria Prima
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_materia_prima"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo_item").Value : i += 1

                'Seta Parametros - Código Unidade Medida
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_unidade_medida"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo_unidade_medida").Value : i += 1

                'Seta Parametros - Quantidade
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "quantidade"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("quantidade").Value : i += 1

                'Seta Parametros - Custo Médio
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "custo_medio"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("custo_medio").Value : i += 1

                'Seta Parametros - Margem
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "margem"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("margem_lucro").Value : i += 1

                'Seta Parametros - Preço Venda
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "preco_venda"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("preco_venda").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_produto_orcamento_materia_prima", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridOrcamentoItemMateriaPrima(ByVal oGrid As GridEX, _
                                                 ByVal lCodigoItem As Long)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oDataSet As DataSet
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_orcamento_materia_prima", oSqlParameter)

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

    Public Sub DeleteOrcamentoItemCusto(ByVal lCodigoItem As Long)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_produto_orcamento_custo", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertOrcamentoItemCusto(ByVal lCodigoItem As Long, _
                                        ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In oGrid.GetDataRows

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Item
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_item"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoItem : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Código Tipo Custo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_tipo_custo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo_tipo_custo").Value : i += 1

                'Seta Parametros - Descrição
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "descricao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 100
                oSqlParameter(i).Value = oRow.Cells("descricao").Value : i += 1

                'Seta Parametros - Valor
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("valor").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_produto_orcamento_custo", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridOrcamentoItemCusto(ByVal oGrid As GridEX, _
                                          ByVal lCodigoItem As Long)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oDataSet As DataSet
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_orcamento_custo", oSqlParameter)

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

#End Region

#Region "::: PRODUTO - PEDIDO DE VENDA :::"

    Public Sub LoadGridPedidoVendaAberto(ByVal oGrid As GridEX, _
                                         ByVal lCodigoItem As Long)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oDataSet As DataSet
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_pedido_item_aberto", oSqlParameter)

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

#End Region

#Region "::: PRODUTO - UNIDADE DE MEDIDA :::"

    Public Sub InsertFatorConversao(ByVal lCodigoProduto As Long, _
                                    ByVal iCodigoUnidadeMedidaOrigem As Integer, _
                                    ByVal iCodigoUnidadeMedidaDestino As Integer, _
                                    ByVal dFatorConversao As Double)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Unidade Medida Origem
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida_origem"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoUnidadeMedidaOrigem : i += 1

            'Seta Parametros - Unidade Medida Destino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida_destino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoUnidadeMedidaDestino : i += 1

            'Seta Parametros - Fator Conversao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fator_conversao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dFatorConversao

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_produto_fator_conversao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateFatorConversao(ByVal lCodigoProduto As Long, _
                                    ByVal iCodigoUnidadeMedidaOrigem As Integer, _
                                    ByVal iCodigoUnidadeMedidaDestino As Integer, _
                                    ByVal dFatorConversao As Double, _
                                    ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Unidade Medida Origem
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida_origem"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoUnidadeMedidaOrigem : i += 1

            'Seta Parametros - Unidade Medida Destino
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida_destino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoUnidadeMedidaDestino : i += 1

            'Seta Parametros - Fator Conversao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fator_conversao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dFatorConversao : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_produto_fator_conversao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteFatorConversao(ByVal lCodigoProduto As Long)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel 
                i = 0

                'Seta Parametros - Código Produto
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_item"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoProduto : i += 1

                'Seta Parametros - Codigo
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
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_produto_fator_conversao", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridFatorConversao(ByVal oGrid As GridEX, _
                                      ByVal lCodigoProduto As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_produto_fator_conversao", oSqlParameter)

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

#End Region

#End Region

End Class
