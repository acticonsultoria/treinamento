Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls
Imports System.Drawing.Printing

Public Class clsUsrFatEmissaoNFsJacarei

#Region "::: VARIAVEIS :::"

#Region "::: VARIAVEIS - NOTA FISCAL :::"

    'Variaveis da Classe - Capa
    Private sCodigoModeloNotaFiscal As String
    Private iSerie As Integer
    Private iCodigoTipoRPS As Integer
    Private iCodigoNaturezaOperacao As Integer
    Private sUFTributacao As String
    Private iCodigoMunicipioTributacao As Integer
    Private lCodigoEmissaoNFSe As Long

#End Region

#Region "::: VARIAVEIS - TOMADOR :::"

    'Váriaveis da Classe - Destinatário
    Private iCodigoTomador As Integer
    Private sCnpjCpfTomador As String
    Private sInscricaoEstadualTomador As String
    Private sInscricaoMunicipalTomador As String
    Private sCepTomador As String
    Private iCodigoPaisTomador As Integer
    Private sUFTomador As String
    Private iCodigoMunicipioTomador As Integer
    Private sLogradouroTomador As String
    Private sNumeroTomador As String
    Private sBairroTomador As String
    Private sComplementoTomador As String
    Private sTelefoneTomador As String
    Private sEmailTomador As String

#End Region

#Region "::: VARIAVEIS - INTERMEDIARIO :::"

    'Váriaveis da Classe - Intermediário
    Private sRazaoSocialIntermediario As String
    Private iCodigoPersonalidade As Integer
    Private sCnpjCpfIntermediario As String
    Private sInscricaoMunicipalIntermediario As String

#End Region

#Region "::: VARIAVEIS - SERVIÇO :::"

    'Variaveis da Classe - Capa
    Private lCodigoServico As Long
    Private sDescricao As String
    Private dValorServico As Double
    Private dDescontoCondicional As Double
    Private dDescontoIncondicional As Double
    Private dValorLiquidoServico As Double
    Private iCodigoCentroGasto As Integer
    Private sCodigoContaContabil As String
    Private dOutrasReducoes As Double
    Private dValorDeducoes As Double
    Private dBaseCalculo As Double
    Private dAliquotaISS As Double
    Private dValorISS As Double
    Private bISSRetido As Boolean
    Private dValorISSRetido As Double
    Private dAliquotaPIS As Double
    Private dValorPIS As Double
    Private dAliquotaCOFINS As Double
    Private dValorCOFINS As Double
    Private dAliquotaINSS As Double
    Private dValorINSS As Double
    Private dAliquotaCSLL As Double
    Private dValorCSLL As Double
    Private dAliquotaIR As Double
    Private dValorIR As Double
    Private lCodigoPedidoVenda As Long
    Private iCodigoPedidoVendaItem As Integer
    Private iCodigoPedidoVendaItemEntrega As Integer
    Private dQuantidadePedido As Double

#End Region

#Region "::: VARIAVEIS - FATURA :::"

    'Váriaveis da Classe - Fatura
    Private sFatura As String
    Private dValorOriginal As Double
    Private dValorDesconto As Double
    Private dValorLiquido As Double
    Private iCodigoFormaPagamentoNFe As Integer
    Private iNumeroParcela As Integer
    Private iIntervaloParcela As Integer

#End Region

#Region "::: VARIAVEIS - INTEGRAÇÃO :::"

    'Variaveis da Classe - Capa
    Private lCodigoTituloCapa As Long

#End Region

#Region "::: VARIAVEIS - CONSTRUÇÃO CIVIL :::"

    'Váriaveis da Classe - Intermediário
    Private sCodigoObra As String
    Private sCodigoArt As String

#End Region

#End Region

#Region "::: PROPERTIE :::"

#Region "::: PROPERTIE - NOTA FISCAL :::"

    Public Property ModeloNotaFiscal() As String
        Get
            Return sCodigoModeloNotaFiscal
        End Get
        Set(ByVal value As String)
            sCodigoModeloNotaFiscal = value
        End Set
    End Property

    Public Property Serie() As Integer
        Get
            Return iSerie
        End Get
        Set(ByVal value As Integer)
            iSerie = value
        End Set
    End Property

    Public Property CodigoTipoRPS() As Integer
        Get
            Return iCodigoTipoRPS
        End Get
        Set(ByVal value As Integer)
            iCodigoTipoRPS = value
        End Set
    End Property

    Public Property CodigoNaturezaOperacao() As Integer
        Get
            Return iCodigoNaturezaOperacao
        End Get
        Set(ByVal value As Integer)
            iCodigoNaturezaOperacao = value
        End Set
    End Property

    Public Property UFTributacao() As String
        Get
            Return sUFTributacao
        End Get
        Set(ByVal value As String)
            sUFTributacao = value
        End Set
    End Property

    Public Property CodigoMunicipioTributacao() As Integer
        Get
            Return iCodigoMunicipioTributacao
        End Get
        Set(ByVal value As Integer)
            iCodigoMunicipioTributacao = value
        End Set
    End Property

    Public Property CodigoEmissaoNFSe() As Long
        Get
            Return lCodigoEmissaoNFSe
        End Get
        Set(ByVal value As Long)
            lCodigoEmissaoNFSe = value
        End Set
    End Property

#End Region

#Region "::: PROPERTIE - TOMADOR :::"

    Public Property CodigoTomador() As Integer
        Get
            Return iCodigoTomador
        End Get
        Set(ByVal value As Integer)
            iCodigoTomador = value
        End Set
    End Property

    Public Property CnpjCpfTomador() As String
        Get
            Return sCnpjCpfTomador
        End Get
        Set(ByVal value As String)
            sCnpjCpfTomador = value
        End Set
    End Property

    Public Property InscricaoEstadualTomador() As String
        Get
            Return sInscricaoEstadualTomador
        End Get
        Set(ByVal value As String)
            sInscricaoEstadualTomador = value
        End Set
    End Property

    Public Property InscricaoMunicipalTomador() As String
        Get
            Return sInscricaoMunicipalTomador
        End Get
        Set(ByVal value As String)
            sInscricaoMunicipalTomador = value
        End Set
    End Property

    Public Property CepTomador() As String
        Get
            Return sCepTomador
        End Get
        Set(ByVal value As String)
            sCepTomador = value
        End Set
    End Property

    Public Property CodigoPaisTomador() As Integer
        Get
            Return iCodigoPaisTomador
        End Get
        Set(ByVal value As Integer)
            iCodigoPaisTomador = value
        End Set
    End Property

    Public Property UFTomador() As String
        Get
            Return sUFTomador
        End Get
        Set(ByVal value As String)
            sUFTomador = value
        End Set
    End Property

    Public Property CodigoMunicipioTomador() As Integer
        Get
            Return iCodigoMunicipioTomador
        End Get
        Set(ByVal value As Integer)
            iCodigoMunicipioTomador = value
        End Set
    End Property

    Public Property LogradouroTomador() As String
        Get
            Return sLogradouroTomador
        End Get
        Set(ByVal value As String)
            sLogradouroTomador = value
        End Set
    End Property

    Public Property NumeroTomador() As String
        Get
            Return sNumeroTomador
        End Get
        Set(ByVal value As String)
            sNumeroTomador = value
        End Set
    End Property

    Public Property BairroTomador() As String
        Get
            Return sBairroTomador
        End Get
        Set(ByVal value As String)
            sBairroTomador = value
        End Set
    End Property

    Public Property ComplementoTomador() As String
        Get
            Return sComplementoTomador
        End Get
        Set(ByVal value As String)
            sComplementoTomador = value
        End Set
    End Property

    Public Property TelefoneTomador() As String
        Get
            Return sTelefoneTomador
        End Get
        Set(ByVal value As String)
            sTelefoneTomador = value
        End Set
    End Property

    Public Property EmailTomador() As String
        Get
            Return sEmailTomador
        End Get
        Set(ByVal value As String)
            sEmailTomador = value
        End Set
    End Property

#End Region

#Region "::: PROPERTIE - INTERMEDIARIO :::"

    Public Property RazaoSocialIntermediario() As String
        Get
            Return sRazaoSocialIntermediario
        End Get
        Set(ByVal value As String)
            sRazaoSocialIntermediario = value
        End Set
    End Property

    Public Property CodigoPersonalidade() As Integer
        Get
            Return iCodigoPersonalidade
        End Get
        Set(ByVal value As Integer)
            iCodigoPersonalidade = value
        End Set
    End Property

    Public Property CnpjCpfIntermediario() As String
        Get
            Return sCnpjCpfIntermediario
        End Get
        Set(ByVal value As String)
            sCnpjCpfIntermediario = value
        End Set
    End Property

    Public Property InscricaoMunicipalIntermediario() As String
        Get
            Return sInscricaoMunicipalIntermediario
        End Get
        Set(ByVal value As String)
            sInscricaoMunicipalIntermediario = value
        End Set
    End Property

#End Region

#Region "::: PROPERTIE - SERVIÇO :::"

    Public Property CodigoServico() As Long
        Get
            Return lCodigoServico
        End Get
        Set(ByVal value As Long)
            lCodigoServico = value
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

    Public Property ValorServico() As Double
        Get
            Return dValorServico
        End Get
        Set(ByVal value As Double)
            dValorServico = value
        End Set
    End Property

    Public Property DescontoCondicional() As Double
        Get
            Return dDescontoCondicional
        End Get
        Set(ByVal value As Double)
            dDescontoCondicional = value
        End Set
    End Property

    Public Property DescontoIncondicional() As Double
        Get
            Return dDescontoIncondicional
        End Get
        Set(ByVal value As Double)
            dDescontoIncondicional = value
        End Set
    End Property

    Public Property ValorLiquidoServico() As Double
        Get
            Return dValorLiquidoServico
        End Get
        Set(ByVal value As Double)
            dValorLiquidoServico = value
        End Set
    End Property

    Public Property CodigoCentroGasto() As Integer
        Get
            Return iCodigoCentroGasto
        End Get
        Set(ByVal value As Integer)
            iCodigoCentroGasto = value
        End Set
    End Property

    Public Property CodigoContaContabil() As String
        Get
            Return sCodigoContaContabil
        End Get
        Set(ByVal value As String)
            sCodigoContaContabil = value
        End Set
    End Property

    Public Property OutrasReducoes() As Double
        Get
            Return dOutrasReducoes
        End Get
        Set(ByVal value As Double)
            dOutrasReducoes = value
        End Set
    End Property

    Public Property ValorDeducoes() As Double
        Get
            Return dValorDeducoes
        End Get
        Set(ByVal value As Double)
            dValorDeducoes = value
        End Set
    End Property

    Public Property BaseCalculo() As Double
        Get
            Return dBaseCalculo
        End Get
        Set(ByVal value As Double)
            dBaseCalculo = value
        End Set
    End Property

    Public Property AliquotaISS() As Double
        Get
            Return dAliquotaISS
        End Get
        Set(ByVal value As Double)
            dAliquotaISS = value
        End Set
    End Property

    Public Property ValorISS() As Double
        Get
            Return dValorISS
        End Get
        Set(ByVal value As Double)
            dValorISS = value
        End Set
    End Property

    Public Property ISSRetido() As Boolean
        Get
            Return bISSRetido
        End Get
        Set(ByVal value As Boolean)
            bISSRetido = value
        End Set
    End Property

    Public Property ValorISSRetido() As Double
        Get
            Return dValorISSRetido
        End Get
        Set(ByVal value As Double)
            dValorISSRetido = value
        End Set
    End Property

    Public Property AliquotaPIS() As Double
        Get
            Return dAliquotaPIS
        End Get
        Set(ByVal value As Double)
            dAliquotaPIS = value
        End Set
    End Property

    Public Property ValorPIS() As Double
        Get
            Return dValorPIS
        End Get
        Set(ByVal value As Double)
            dValorPIS = value
        End Set
    End Property

    Public Property AliquotaCOFINS() As Double
        Get
            Return dAliquotaCOFINS
        End Get
        Set(ByVal value As Double)
            dAliquotaCOFINS = value
        End Set
    End Property

    Public Property ValorCOFINS() As Double
        Get
            Return dValorCOFINS
        End Get
        Set(ByVal value As Double)
            dValorCOFINS = value
        End Set
    End Property

    Public Property AliquotaINSS() As Double
        Get
            Return dAliquotaINSS
        End Get
        Set(ByVal value As Double)
            dAliquotaINSS = value
        End Set
    End Property

    Public Property ValorINSS() As Double
        Get
            Return dValorINSS
        End Get
        Set(ByVal value As Double)
            dValorINSS = value
        End Set
    End Property

    Public Property AliquotaCSLL() As Double
        Get
            Return dAliquotaCSLL
        End Get
        Set(ByVal value As Double)
            dAliquotaCSLL = value
        End Set
    End Property

    Public Property ValorCSLL() As Double
        Get
            Return dValorCSLL
        End Get
        Set(ByVal value As Double)
            dValorCSLL = value
        End Set
    End Property

    Public Property AliquotaIR() As Double
        Get
            Return dAliquotaIR
        End Get
        Set(ByVal value As Double)
            dAliquotaIR = value
        End Set
    End Property

    Public Property ValorIR() As Double
        Get
            Return dValorIR
        End Get
        Set(ByVal value As Double)
            dValorIR = value
        End Set
    End Property

    Public Property CodigoPedidoVenda() As Long
        Get
            Return lCodigoPedidoVenda
        End Get
        Set(ByVal value As Long)
            lCodigoPedidoVenda = value
        End Set
    End Property

    Public Property CodigoPedidoVendaItem() As Integer
        Get
            Return iCodigoPedidoVendaItem
        End Get
        Set(ByVal value As Integer)
            iCodigoPedidoVendaItem = value
        End Set
    End Property

    Public Property CodigoPedidoVendaItemEntrega() As Integer
        Get
            Return iCodigoPedidoVendaItemEntrega
        End Get
        Set(ByVal value As Integer)
            iCodigoPedidoVendaItemEntrega = value
        End Set
    End Property

    Public Property QuantidadePedido() As Double
        Get
            Return dQuantidadePedido
        End Get
        Set(ByVal value As Double)
            dQuantidadePedido = value
        End Set
    End Property

#End Region

#Region "::: PROPERTIE - FATURA :::"

    Public Property Fatura() As String
        Get
            Return sFatura
        End Get
        Set(ByVal value As String)
            sFatura = value
        End Set
    End Property

    Public Property ValorOriginal() As Double
        Get
            Return dValorOriginal
        End Get
        Set(ByVal value As Double)
            dValorOriginal = value
        End Set
    End Property

    Public Property ValorDesconto() As Double
        Get
            Return dValorDesconto
        End Get
        Set(ByVal value As Double)
            dValorDesconto = value
        End Set
    End Property

    Public Property ValorLiquido() As Double
        Get
            Return dValorLiquido
        End Get
        Set(ByVal value As Double)
            dValorLiquido = value
        End Set
    End Property

    Public Property CodigoFormaPagamentoNFe() As Integer
        Get
            Return iCodigoFormaPagamentoNFe
        End Get
        Set(ByVal value As Integer)
            iCodigoFormaPagamentoNFe = value
        End Set
    End Property

    Public Property NumeroParcela() As Integer
        Get
            Return iNumeroParcela
        End Get
        Set(ByVal value As Integer)
            iNumeroParcela = value
        End Set
    End Property

    Public Property IntervaloParcela() As Integer
        Get
            Return iIntervaloParcela
        End Get
        Set(ByVal value As Integer)
            iIntervaloParcela = value
        End Set
    End Property

#End Region

#Region "::: PROPERTIE - INTEGRAÇÃO :::"

    Public Property CodigoTituloCapa() As Long
        Get
            Return lCodigoTituloCapa
        End Get
        Set(ByVal value As Long)
            lCodigoTituloCapa = value
        End Set
    End Property

#End Region

#Region "::: PROPERTIE - CONSTRUÇÃO CIVIL :::"

    Public Property CodigoObra() As String
        Get
            Return sCodigoObra
        End Get
        Set(ByVal value As String)
            sCodigoObra = value
        End Set
    End Property

    Public Property CodigoArt() As String
        Get
            Return sCodigoArt
        End Get
        Set(ByVal value As String)
            sCodigoArt = value
        End Set
    End Property

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: NOTA FISCAL :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal lNotaFiscal As Long, _
                        ByVal sSerie As String, _
                        ByVal sTomador As String, _
                        ByVal sDataEmissaoInicio As String, _
                        ByVal sDataEmissaoTermino As String, _
                        ByVal sStatus As String, _
                        ByVal sTipoRPS As String, _
                        ByVal sNaturezaOperacao As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lNotaFiscal : i += 1

            'Seta Parametros - Série
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "serie"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5
            oSqlParameter(i).Value = sSerie : i += 1

            'Seta Parametros - Destinatário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "destinatario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sTomador : i += 1

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

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sStatus : i += 1

            'Seta Parametros - Código Tipo RPS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_rps"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sTipoRPS : i += 1

            'Seta Parametros - Código Natureza da Operação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_natureza_operacao_servico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sNaturezaOperacao : i += 1

            'Seta Parametros - Código Tipo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = modDeclaration.TipoItem.servico : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_nfse_capa", oSqlParameter)

            'Configura DataMember
            ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertCapa()

        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Modelo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modelo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 3
            oSqlParameter(i).Value = sCodigoModeloNotaFiscal : i += 1

            'Seta Parametros - Série
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "serie"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5
            oSqlParameter(i).Value = iSerie.ToString : i += 1

            'Seta Parametros - Código Tipo RPS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_rps"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoRPS : i += 1

            'Seta Parametros - Código Natureza da Operação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_natureza_operacao_servico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoNaturezaOperacao : i += 1

            'Seta Parametros - UF Tributacao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf_tributacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sUFTributacao : i += 1

            'Seta Parametros - Código Município Tributacao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_municipio_tributacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoMunicipioTributacao : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = StatusNFSe.AguardandoTransmissao : i += 1

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
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_nfse_capa", oSqlParameter)

            'Seta Váriavel 
            lCodigoEmissaoNFSe = oSqlParameter(9).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateCapa()

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Modelo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modelo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 3
            oSqlParameter(i).Value = sCodigoModeloNotaFiscal : i += 1

            'Seta Parametros - Série
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "serie"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5
            oSqlParameter(i).Value = iSerie.ToString : i += 1

            'Seta Parametros - Código Tipo RPS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_rps"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoRPS : i += 1

            'Seta Parametros - Código Natureza da Operação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_natureza_operacao_servico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoNaturezaOperacao : i += 1

            'Seta Parametros - UF Tributacao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf_tributacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sUFTributacao : i += 1

            'Seta Parametros - Código Município Tributacao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_municipio_tributacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoMunicipioTributacao : i += 1

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
            oSqlParameter(i).Value = lCodigoEmissaoNFSe

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_nfse_capa", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteCapa()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i, j As Integer

        Try

            'Exclui Registro
            For j = 0 To UBound(gSelecaoRow)

                i = 0

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = gSelecaoRow(j).Cells("codigo").Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_nfse_capa", oSqlParameter)

                'Exclui Linha
                gSelecaoRow(j).Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosNotaFiscal(ByVal lCodigo As Long, _
                                   ByVal cboModelo As UIComboBox, _
                                   ByVal cboSerie As UIComboBox, _
                                   ByVal txtNotaFiscal As MaskedEditBox, _
                                   ByVal txtDataEmissao As MaskedEditBox, _
                                   ByVal cboTipoRPS As UIComboBox, _
                                   ByVal cboNaturezaOperacaoServico As UIComboBox, _
                                   ByVal cboUFTributacao As UIComboBox, _
                                   ByVal cboMunicipioTributacao As UIComboBox, _
                                   ByVal cboTomador As UIComboBox, _
                                   ByVal txtCNPJTomador As MaskedEditBox, _
                                   ByVal txtInscricaoEstadualTomador As MaskedEditBox, _
                                   ByVal txtInscricaoMunicipalTomador As MaskedEditBox, _
                                   ByVal txtCEPTomador As MaskedEditBox, _
                                   ByVal cboPaisTomador As UIComboBox, _
                                   ByVal cboUFTomador As UIComboBox, _
                                   ByVal cboMunicipioTomador As UIComboBox, _
                                   ByVal txtLogradouroTomador As MaskedEditBox, _
                                   ByVal txtNumeroTomador As MaskedEditBox, _
                                   ByVal txtBairroTomador As MaskedEditBox, _
                                   ByVal txtComplementoTomador As MaskedEditBox, _
                                   ByVal txtTelefoneTomador As MaskedEditBox, _
                                   ByVal txtEmailTomador As MaskedEditBox, _
                                   ByVal cboServico As UIComboBox, _
                                   ByVal txtDiscricao As EditBox, _
                                   ByVal txtValorServico As NumericEditBox, _
                                   ByVal txtValorDescontoCondicionado As NumericEditBox, _
                                   ByVal txtValorDescontoIncondicionado As NumericEditBox, _
                                   ByVal txtValorLiquidoNFSE As NumericEditBox, _
                                   ByVal cboCentroGasto As UIComboBox, _
                                   ByVal cboContaContabil As UIComboBox, _
                                   ByVal txtOutrasRetencoes As NumericEditBox, _
                                   ByVal txtValorDeducoes As NumericEditBox, _
                                   ByVal txtBaseCalculo As NumericEditBox, _
                                   ByVal txtAliquotaISS As NumericEditBox, _
                                   ByVal txtValorISS As NumericEditBox, _
                                   ByVal cboISSRetido As UIComboBox, _
                                   ByVal txtValorISSRetido As NumericEditBox, _
                                   ByVal txtAliquotaPIS As NumericEditBox, _
                                   ByVal txtValorPIS As NumericEditBox, _
                                   ByVal txtAliquotaCOFINS As NumericEditBox, _
                                   ByVal txtValorCOFINS As NumericEditBox, _
                                   ByVal txtAliquotaINSS As NumericEditBox, _
                                   ByVal txtValorINSS As NumericEditBox, _
                                   ByVal txtAliquotaCSLL As NumericEditBox, _
                                   ByVal txtValorCSLL As NumericEditBox, _
                                   ByVal txtAliquotaIR As NumericEditBox, _
                                   ByVal txtValorIR As NumericEditBox, _
                                   ByVal txtFatura As MaskedEditBox, _
                                   ByVal txtValorOriginal As NumericEditBox, _
                                   ByVal txtValorDesconto As NumericEditBox, _
                                   ByVal txtValorLiquido As NumericEditBox, _
                                   ByVal cboFormaPagamento As UIComboBox, _
                                   ByVal txtNumeroParcela As NumericEditBox, _
                                   ByVal txtIntervaloEntreParcelas As NumericEditBox, _
                                   ByVal txtNumeroRPS As MaskedEditBox, _
                                   ByVal txtStatusNFSe As MaskedEditBox, _
                                   ByVal txtMensagemNFSe As MaskedEditBox, _
                                   ByVal txtLote As MaskedEditBox, _
                                   ByVal txtProtocolo As MaskedEditBox, _
                                   ByVal txtCodigoVerificacao As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
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
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_nfse_dados", oSqlParameter)

            While oSqlDataReader.Read

                cboModelo.SelectedValue = oSqlDataReader.Item("codigo_modelo")
                cboSerie.Text = oSqlDataReader.Item("serie")
                txtNotaFiscal.Text = IIf(IsDBNull(oSqlDataReader.Item("numero_documento")), "", oSqlDataReader.Item("numero_documento"))
                txtDataEmissao.Text = IIf(IsDBNull(oSqlDataReader.Item("data_emissao")), "", oSqlDataReader.Item("data_emissao"))
                cboTipoRPS.SelectedValue = oSqlDataReader.Item("codigo_tipo_rps")
                cboNaturezaOperacaoServico.SelectedValue = oSqlDataReader.Item("codigo_natureza_operacao_servico")
                cboUFTributacao.SelectedValue = oSqlDataReader.Item("uf_tributacao")
                cboMunicipioTributacao.SelectedValue = oSqlDataReader.Item("codigo_municipio_tributacao")
                cboTomador.SelectedValue = oSqlDataReader.Item("codigo_tomador")
                txtCNPJTomador.Text = oSqlDataReader.Item("cnpj_cpf")
                txtInscricaoEstadualTomador.Text = oSqlDataReader.Item("inscricao_estadual")
                txtInscricaoMunicipalTomador.Text = oSqlDataReader.Item("inscricao_municipal")
                txtCEPTomador.Text = oSqlDataReader.Item("cep")
                cboPaisTomador.SelectedValue = oSqlDataReader.Item("codigo_pais")
                cboUFTomador.SelectedValue = oSqlDataReader.Item("uf")
                cboMunicipioTomador.SelectedValue = oSqlDataReader.Item("codigo_municipio")
                txtLogradouroTomador.Text = oSqlDataReader.Item("logradouro")
                txtNumeroTomador.Text = oSqlDataReader.Item("numero")
                txtBairroTomador.Text = oSqlDataReader.Item("bairro")
                txtComplementoTomador.Text = oSqlDataReader.Item("complemento")
                txtTelefoneTomador.Text = oSqlDataReader.Item("telefone")
                txtEmailTomador.Text = oSqlDataReader.Item("email")
                cboServico.SelectedValue = oSqlDataReader.Item("codigo_item")
                cboServico.Tag = oSqlDataReader.Item("pedido")
                txtDiscricao.Text = oSqlDataReader.Item("descricao")
                txtValorServico.Value = oSqlDataReader.Item("valor_servico")
                txtValorDescontoCondicionado.Value = oSqlDataReader.Item("desconto_condicional")
                txtValorDescontoIncondicionado.Value = oSqlDataReader.Item("desconto_incondicional")
                txtValorLiquidoNFSE.Value = oSqlDataReader.Item("valor_liquido_nfse")
                cboCentroGasto.SelectedValue = oSqlDataReader.Item("codigo_centro_custo")
                cboContaContabil.SelectedValue = oSqlDataReader.Item("codigo_conta_contabil")
                txtOutrasRetencoes.Value = oSqlDataReader.Item("outras_retencoes")
                txtValorDeducoes.Value = oSqlDataReader.Item("valor_deducoes")
                txtBaseCalculo.Value = oSqlDataReader.Item("base_calculo")
                txtAliquotaISS.Value = oSqlDataReader.Item("aliquota_iss")
                txtValorISS.Value = oSqlDataReader.Item("valor_iss")
                cboISSRetido.SelectedValue = oSqlDataReader.Item("iss_retido")
                txtValorISSRetido.Value = oSqlDataReader.Item("valor_iss_retido")
                txtAliquotaPIS.Value = oSqlDataReader.Item("aliquota_pis")
                txtValorPIS.Value = oSqlDataReader.Item("valor_pis")
                txtAliquotaCOFINS.Value = oSqlDataReader.Item("aliquota_cofins")
                txtValorCOFINS.Value = oSqlDataReader.Item("valor_cofins")
                txtAliquotaINSS.Value = oSqlDataReader.Item("aliquota_inss")
                txtValorINSS.Value = oSqlDataReader.Item("valor_inss")
                txtAliquotaCSLL.Value = oSqlDataReader.Item("aliquota_csll")
                txtValorCSLL.Value = oSqlDataReader.Item("valor_csll")
                txtAliquotaIR.Value = oSqlDataReader.Item("aliquota_ir")
                txtValorIR.Value = oSqlDataReader.Item("valor_ir")
                txtFatura.Text = oSqlDataReader.Item("fatura")
                txtValorOriginal.Value = oSqlDataReader.Item("valor_original")
                txtValorDesconto.Value = oSqlDataReader.Item("valor_desconto")
                txtValorLiquido.Value = oSqlDataReader.Item("valor_liquido")
                cboFormaPagamento.SelectedValue = oSqlDataReader.Item("codigo_forma_pagamento")
                txtNumeroParcela.Value = oSqlDataReader.Item("numero_parcela")
                txtIntervaloEntreParcelas.Value = oSqlDataReader.Item("intervalo_parcela")
                txtNumeroRPS.Text = oSqlDataReader.Item("numero_rps")
                txtStatusNFSe.Text = oSqlDataReader.Item("status_nfse")
                txtStatusNFSe.Tag = oSqlDataReader.Item("status")
                txtMensagemNFSe.Text = oSqlDataReader.Item("mensagem")
                txtLote.Text = oSqlDataReader.Item("lote")
                txtProtocolo.Text = oSqlDataReader.Item("protocolo")
                txtCodigoVerificacao.Text = oSqlDataReader.Item("codigo_verificacao")

            End While

            'Fecha o SQLDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function GeraNumeroRPS() As String

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoNFSe : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Número RPS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_rps"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_nfse_capa_numero_rps", oSqlParameter)

            Return Format(oSqlParameter(2).Value, "000000000")

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function GeraNumeroLote() As String

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoNFSe : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Lote
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "lote"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_nfse_capa_lote", oSqlParameter)

            Return Format(oSqlParameter(2).Value, "000000000")

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function DuplicarNF(ByVal lCodigo As Long) As Long

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0
        Dim lReturn As Long

        Try

            'Seta Parametros - Código
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
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = StatusNFSe.AguardandoTransmissao : i += 1

            'Seta Parametros - Código Novo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_novo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_nfse_duplicar", oSqlParameter)

            'Seta Váriavel 
            lReturn = oSqlParameter(i).Value

            'Retorno da Função
            Return lReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub UpdateStatusNotaFiscal(ByVal lCodigo As Long, _
                                      ByVal iStatus As Integer, _
                                      Optional ByVal sProtocolo As String = "", _
                                      Optional ByVal sDataRecebimento As String = "", _
                                      Optional ByVal sMensagemNFSe As String = "", _
                                      Optional ByVal sCodigoVerificacao As String = "", _
                                      Optional ByVal sDataEmissao As String = "", _
                                      Optional ByVal lNumeroDocumento As Long = 0)

        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iStatus : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Protocolo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "protocolo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = IIf(sProtocolo = "", DBNull.Value, sProtocolo) : i += 1

            'Seta Parametros - Data Recebimento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_recebimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataRecebimento) = False, DBNull.Value, sDataRecebimento) : i += 1

            'Seta Parametros - Mensagem
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "mensagem"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 200
            oSqlParameter(i).Value = IIf(sMensagemNFSe = "", DBNull.Value, sMensagemNFSe) : i += 1

            'Seta Parametros - Código de Verificação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_verificacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 9
            oSqlParameter(i).Value = IIf(sCodigoVerificacao = "", DBNull.Value, sCodigoVerificacao) : i += 1

            'Seta Parametros - Data Emissão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataEmissao) = False, DBNull.Value, sDataEmissao) : i += 1

            'Seta Parametros - Número do Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lNumeroDocumento = 0, DBNull.Value, lNumeroDocumento)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_nfse_status", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: TOMADOR :::"

    Public Sub InsertTomador()

        'Variaveis Locais
        Dim oSqlParameter(15) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_nfse_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoNFSe : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Tomador
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tomador"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoTomador : i += 1

            'Seta Parametros - CNPJ / CPF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnpj_cpf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCnpjCpfTomador : i += 1

            'Seta Parametros - Inscrição Estadual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inscricao_estadual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 14
            oSqlParameter(i).Value = sInscricaoEstadualTomador : i += 1

            'Seta Parametros - Inscrição Municipal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inscricao_municipal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 9
            oSqlParameter(i).Value = sInscricaoMunicipalTomador : i += 1

            'Seta Parametros - CEP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cep"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sCepTomador : i += 1

            'Seta Parametros - Código Pais
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pais"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoPaisTomador : i += 1

            'Seta Parametros - UF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sUFTomador : i += 1

            'Seta Parametros - Código Municipio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_municipio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoMunicipioTomador : i += 1

            'Seta Parametros - Logradouro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "logradouro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sLogradouroTomador : i += 1

            'Seta Parametros - Número
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sNumeroTomador : i += 1

            'Seta Parametros - Bairro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "bairro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sBairroTomador : i += 1

            'Seta Parametros - Complemento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "complemento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sComplementoTomador = "", DBNull.Value, sComplementoTomador) : i += 1

            'Seta Parametros - Telefone
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = IIf(sTelefoneTomador = "", DBNull.Value, sTelefoneTomador) : i += 1

            'Seta Parametros - Email
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "email"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sEmailTomador = "", DBNull.Value, sEmailTomador)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_nfse_tomador", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteTomador()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_nfse_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoNFSe : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_nfse_tomador", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: INTERMEDIÁRIO :::"

    Public Sub InsertIntermediario()

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_nfse_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoNFSe : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Razão Social
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "razao_social"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 115
            oSqlParameter(i).Value = sRazaoSocialIntermediario

            'Seta Parametros - Código Personalidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_personalidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoPersonalidade = -1, DBNull.Value, iCodigoPersonalidade) : i += 1

            'Seta Parametros - CNPJ CPF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnpj_cpf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCnpjCpfIntermediario : i += 1

            'Seta Parametros - Inscrição Municipal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inscricao_municipal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = IIf(sInscricaoMunicipalIntermediario = "", DBNull.Value, sInscricaoMunicipalIntermediario) : i += 1

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_nfse_intermediario", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteIntermediario()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_nfse_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoNFSe : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_nfse_intermediario", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: EMITENTE :::"

    Public Sub InsertEmitente()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_nfse_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoNFSe : i += 1

            'Seta Parametros - Código Emitente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emitente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_nfse_emitente", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteEmitente()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_nfse_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoNFSe : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_nfse_emitente", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: FATURA :::"

    Public Sub InsertFatura()

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_nfse_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoNFSe : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Fatura
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fatura"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sFatura = "", DBNull.Value, sFatura) : i += 1

            'Seta Parametros - Valor Fatura
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_original"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorOriginal : i += 1

            'Seta Parametros - Valor Desconto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_desconto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorDesconto : i += 1

            'Seta Parametros - Valor Liquido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_liquido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorLiquido : i += 1

            'Seta Parametros - Código Forma de Pagamento NFe
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_forma_pagamento_nfe"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoFormaPagamentoNFe : i += 1

            'Seta Parametros - Número de Parcela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iNumeroParcela : i += 1

            'Seta Parametros - Intervalo de Parcela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "intervalo_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iIntervaloParcela

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_nfse_fatura", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertFaturaDuplicata(ByVal oGrid As GridEX)

        Try

            'Variaveis Locais
            Dim oRow() As GridEXRow
            Dim j, i As Integer
            Dim oSqlParameter(4) As SqlParameter

            'Obtem Linhas
            oRow = oGrid.GetDataRows

            For j = 0 To UBound(oRow)

                i = 0

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_nfse_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoEmissaoNFSe : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - N° Duplicata
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero_duplicata"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = j + 1 : i += 1

                'Seta Parametros - Data Vencimento
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data_vencimento"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = oRow(j).Cells("data_vencimento").Value : i += 1

                'Seta Parametros - Valor
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow(j).Cells("valor").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_nfse_fatura_duplicata", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteFatura()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_nfse_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoNFSe : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_nfse_fatura", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridFatura(ByVal oGrid As GridEX, _
                              ByVal lCodigoEmissaoNFSe As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_nfse_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoNFSe : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_nfse_fatura_duplicata", oSqlParameter)

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

    Public Sub GerarDuplicata(ByVal oGrid As GridEX, _
                              ByVal dValor As Double, _
                              ByVal iNumeroParcela As Integer, _
                              ByVal iIntervaloParcela As Integer)

        Try

            'Limpa Grid
            oGrid.DataSource = Nothing

            'Caso Valor Liquido maior que 0
            If dValor > 0 Then

                'Variaveis Locais
                Dim oDataSet As New DataSet
                Dim oDataTable As New DataTable
                Dim oDCVencimento As New DataColumn("data_vencimento")
                Dim oDCValor As New DataColumn("valor")

                'Seta DataType
                oDCVencimento.DataType = Now.Date.GetType
                oDCValor.DataType = 0.0.GetType

                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)

                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCVencimento)
                oDataTable.Columns.Add(oDCValor)

                'Adiciona Linhas ao DataTable
                For i = 1 To iNumeroParcela
                    Dim oDataRow As DataRow = oDataTable.NewRow
                    oDataRow("data_vencimento") = CDate(DateAdd(DateInterval.Day, i * iIntervaloParcela, Now.Date))
                    oDataRow("valor") = dValor / iNumeroParcela
                    oDataTable.Rows.Add(oDataRow)
                Next

                'Configura DataMember
                Call ConfigurarDataMemberGrid(oGrid)

                'Carrega Grid
                oGrid.DataSource = oDataSet.DefaultViewManager
                oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

            End If

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: SERVIÇO :::"

    Public Sub InsertServico()

        'Variaveis Locais
        Dim oSqlParameter(31) As SqlParameter
        Dim i As Integer = 1

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_nfse_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoNFSe : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoServico : i += 1

            'Seta Parametros - Descricao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5000
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Valor Serviço
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_servico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorServico : i += 1

            'Seta Parametros - Desconto Condicional
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desconto_condicional"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDescontoCondicional : i += 1

            'Seta Parametros - Desconto Incondicional
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desconto_incondicional"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDescontoIncondicional : i += 1

            'Seta Parametros - Valor Líquido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_liquido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorLiquidoServico : i += 1

            'Seta Parametros - Código Centro de Gasto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_custo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoCentroGasto = -1, DBNull.Value, iCodigoCentroGasto) : i += 1

            'Seta Parametros - Código Conta Contábil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_conta_contabil"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sCodigoContaContabil = "", DBNull.Value, sCodigoContaContabil) : i += 1

            'Seta Parametros - Outras Retenções
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "outras_retencoes"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dOutrasReducoes : i += 1

            'Seta Parametros - Valor Deduções
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_deducoes"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorDeducoes : i += 1

            'Seta Parametros - Base Cálculo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "base_calculo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dBaseCalculo : i += 1

            'Seta Parametros - Alíquota ISS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_iss"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaISS : i += 1

            'Seta Parametros - Valor ISS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_iss"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorISS : i += 1

            'Seta Parametros - ISS Retido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "iss_retido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bISSRetido : i += 1

            'Seta Parametros - Valor ISS Retido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_iss_retido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorISSRetido : i += 1

            'Seta Parametros - Alíquota PIS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_pis"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaPIS : i += 1

            'Seta Parametros - Valor PIS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_pis"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorPIS : i += 1

            'Seta Parametros - Alíquota COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaCOFINS : i += 1

            'Seta Parametros - Valor COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorCOFINS : i += 1

            'Seta Parametros - Alíquota INSS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_inss"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaINSS : i += 1

            'Seta Parametros - Valor INSS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_inss"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorINSS : i += 1

            'Seta Parametros - Alíquota CSLL
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_csll"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaCSLL : i += 1

            'Seta Parametros - Valor CSLL
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_csll"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorCSLL : i += 1

            'Seta Parametros - Alíquota IR
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_ir"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaIR : i += 1

            'Seta Parametros - Valor IR
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ir"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorIR : i += 1

            'Seta Parametros - Código Pedido de Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoPedidoVenda = -1, DBNull.Value, lCodigoPedidoVenda) : i += 1

            'Seta Parametros - Código Pedido de Venda Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_venda_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoPedidoVendaItem = -1, DBNull.Value, iCodigoPedidoVendaItem) : i += 1

            'Seta Parametros - Código Pedido de Venda Item Entrega
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_venda_item_entrega"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoPedidoVendaItemEntrega = -1, DBNull.Value, iCodigoPedidoVendaItemEntrega) : i += 1

            'Seta Parametros - Quantidade Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dQuantidadePedido = -1, DBNull.Value, dQuantidadePedido)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_nfse_servico", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteServico()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_nfse_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoNFSe : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_nfse_servico", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosServico(ByVal lCodigo As Long, _
                                ByVal txtDiscriminacao As EditBox, _
                                ByVal txtAliquotaISS As NumericEditBox)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
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
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_nfse_dados_servico", oSqlParameter)

            If oSqlDataReader.Read Then
                txtDiscriminacao.Text = oSqlDataReader.Item("descricao")
                txtAliquotaISS.Value = oSqlDataReader.Item("aliquota_iss_padrao")
            Else
                txtDiscriminacao.Text = ""
                txtAliquotaISS.Value = 0
            End If

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: CONSTRUÇÃO CIVIL :::"

    Public Sub InsertConstrucaoCivil()

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_nfse_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoNFSe : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Obra
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_obra"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = sCodigoObra : i += 1

            'Seta Parametros - Código Art
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_art"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = sCodigoArt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_nfse_construcao_civil", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteConstrucaoCivil()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_nfse_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoNFSe : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_nfse_construcao_civil", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class
