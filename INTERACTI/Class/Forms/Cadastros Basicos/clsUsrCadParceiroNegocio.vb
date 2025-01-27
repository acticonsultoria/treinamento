Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.CalendarCombo

Public Class clsUsrCadParceiroNegocio

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private bFerramental As Boolean
    Private bProduto As Boolean
    Private dPorcentagemReducaoBaseCalculoICMS As Double
    Private dAliquotaICMS As Double
    Private dAliquotaICMSReduzida As Double
    Private dAliquotaIPI As Double
    Private bIncidePISCOFINS As Boolean
    Private dAliquotaPIS As Double
    Private dAliquotaCOFINS As Double
    Private dAliquotaISS As Double
    Private iCodigoProduto As Integer
    Private sCodigoProsoft As String
    Private iTipoFrasco As Integer
    Private dtData As DateTime
    Private sNumeroPedido As String
    Private bCliente As Boolean
    Private bFornecedor As Boolean
    Private bAgenteLogistico As Boolean
    Private bDespachante As Boolean
    Private iPersonalidade As Integer
    Private sCNPJCPF As String
    Private sRazaoSocial As String
    Private sNomeFantasia As String
    Private sSigla As String
    Private iCodigoParceiroNegocioSegmento As Integer
    Private iRegimeTributario As Integer
    Private sCNAE As String
    Private bAtivo As Boolean
    Private iCodigoTipoInscricaoEstadual As Integer
    Private sInscricaoEstadual As String
    Private sInscricaoEstadualSubstitutoTributario As String
    Private sInscricaoMunicipal As String
    Private sInscricaoSuframa As String
    Private iPais As Integer
    Private sUF As String
    Private iMunicipio As Integer
    Private sLogradouro As String
    Private sNumero As String
    Private sBairro As String
    Private sComplemento As String
    Private sCEP As String
    Private sDataAniversario As String
    Private sDataFundacao As String
    Private sDataCadastro As String
    Private sRG As String
    Private sOrgaoEmissor As String
    Private sDataEmissaoRG As String
    Private sObservacao As String
    Private sTelefone1 As String
    Private sTelefone2 As String
    Private sTelefoneRecado As String
    Private sFax As String
    Private sEmail As String
    Private sEmail2 As String
    Private iCodigoVendedor As Integer
    Private iCodigoVendedorInterno As Integer
    Private iCodigoCondicaoPagamento As Integer
    Private iCodigoFormaPagamento As Integer
    Private iCodigoMoeda As Integer
    Private iCodigoModalidadeFrete As Integer
    Private sCodigoIntegracao As String
    Private iEnviarAR As Integer
    Private iCodigoCampanha As Integer
    Private iCodigoDestinacao As Integer
    Private iCodigoCondicaoPagamentoFornecedor As Integer
    Private iCodigoFormaPagamentoFornecedor As Integer
    Private iCodigoMoedaFornecedor As Integer
    Private iCodigoModalidadeFreteFornecedor As Integer
    Private sClassificacaoFornecedor As String
    Private dLimiteCredito As Double
    Private iAvisoTempoCompra As Integer
    Private iNumeroMesesValidadeProduto As Integer
    Private sCodigoInstrucaoCobranca1 As String
    Private sCodigoInstrucaoCobranca2 As String
    Private iNumeroDias1 As Integer
    Private iNumeroDias2 As Integer
    Private iCodigoTipoNegativacao As Integer
    Private sDataNegativacao As String
    Private sTextoNegativacao As String
    Private sCodigoIdentificacao As String
    Private sNomePai As String
    Private sNomeMae As String
    Private iAnoCadastro As Integer
    Private iMesCadastro As Integer
    Private sSexo As String
    Private iCodigoRota As Integer
    Private iCodigoEquipeTrabalho As Integer
    Private iCodigoIndicante As Integer
    Private iCodigo As Integer
    Private sCodigoFornecedor As String
    Private bImportado As Boolean
    Private bNecessitaConferencia As Boolean
    Private bEspacoLeSix As Boolean
    Private bLavalpa As Boolean
    Private bCronograma As Boolean
    Private bEntregaFisica As Boolean
    Private bEntregaEmail As Boolean
    Private bPagamentoAVista As Boolean
    Private sPontoReferencia As String
    Private bPagamentoPontual As Boolean
    Private bConferir As Boolean
    Private sTipoConsultor As String
    Private iCodigoGrupo As Integer
    Private iCodigoEmpresaContrato As Integer
    Private bEntregaVizinho As Boolean
    Private sDadosVizinho As String
    Private bRetiradaDocumentos As Boolean
    Private iCodigoBanco As Integer
    Private sAgencia As String
    Private sConta As String
    Private iCodigoCentroGasto As Integer
    Private sGrupoTecnologia As String
    Private dCapacidadeMensal As Double
    Private iCodigoCategoria As Integer
    Private iValidadeOrcamentoDias As Integer
    Private bCheckTelefone1 As Boolean
    Private bCheckTelefone2 As Boolean

#End Region

#Region "::: PROPERTIE :::"
    Public Property Ferramental As Boolean
        Get
            Return bFerramental
        End Get
        Set(value As Boolean)
            bFerramental = value
        End Set
    End Property
    Public Property Produto As Boolean
        Get
            Return bProduto
        End Get
        Set(value As Boolean)
            bProduto = value
        End Set
    End Property
    Public Property PorcentagemReducaoBaseCalculoICMS() As Double
        Get
            Return dPorcentagemReducaoBaseCalculoICMS
        End Get
        Set(ByVal value As Double)
            dPorcentagemReducaoBaseCalculoICMS = value
        End Set
    End Property

    Public Property AliquotaICMS() As Double
        Get
            Return dAliquotaICMS
        End Get
        Set(ByVal value As Double)
            dAliquotaICMS = value
        End Set
    End Property

    Public Property AliquotaICMSReduzida() As Double
        Get
            Return dAliquotaICMSReduzida
        End Get
        Set(ByVal value As Double)
            dAliquotaICMSReduzida = value
        End Set
    End Property

    Public Property AliquotaIPI() As Double
        Get
            Return dAliquotaIPI
        End Get
        Set(ByVal value As Double)
            dAliquotaIPI = value
        End Set
    End Property

    Public Property IncidePISCOFINS() As Boolean
        Get
            Return bIncidePISCOFINS
        End Get
        Set(ByVal value As Boolean)
            bIncidePISCOFINS = value
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

    Public Property AliquotaCOFINS() As Double
        Get
            Return dAliquotaCOFINS
        End Get
        Set(ByVal value As Double)
            dAliquotaCOFINS = value
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

    Public Property CodigoCategoria() As Integer
        Get
            Return iCodigoCategoria
        End Get
        Set(ByVal value As Integer)
            iCodigoCategoria = value
        End Set
    End Property

    Public Property CapacidadeMensal() As Double
        Get
            Return dCapacidadeMensal
        End Get
        Set(ByVal value As Double)
            dCapacidadeMensal = value
        End Set
    End Property

    Public Property GrupoTecnologia() As String
        Get
            Return sGrupoTecnologia
        End Get
        Set(ByVal value As String)
            sGrupoTecnologia = value
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

    Public Property Agencia() As String
        Get
            Return sAgencia
        End Get
        Set(ByVal value As String)
            sAgencia = value
        End Set
    End Property

    Public Property Conta() As String
        Get
            Return sConta
        End Get
        Set(ByVal value As String)
            sConta = value
        End Set
    End Property

    Public Property CodigoBanco() As Integer
        Get
            Return iCodigoBanco
        End Get
        Set(ByVal value As Integer)
            iCodigoBanco = value
        End Set
    End Property

    Public Property RetiradaDocumentos() As Boolean
        Get
            Return bRetiradaDocumentos
        End Get
        Set(ByVal value As Boolean)
            bRetiradaDocumentos = value
        End Set
    End Property

    Public Property DadosVizinho() As String
        Get
            Return sDadosVizinho
        End Get
        Set(ByVal value As String)
            sDadosVizinho = value
        End Set
    End Property

    Public Property EntregaVizinho() As Boolean
        Get
            Return bEntregaVizinho
        End Get
        Set(ByVal value As Boolean)
            bEntregaVizinho = value
        End Set
    End Property

    Public Property CodigoEmpresaContrato() As Integer
        Get
            Return iCodigoEmpresaContrato
        End Get
        Set(ByVal value As Integer)
            iCodigoEmpresaContrato = value
        End Set
    End Property

    Public Property CodigoGrupo() As Integer
        Get
            Return iCodigoGrupo
        End Get
        Set(ByVal value As Integer)
            iCodigoGrupo = value
        End Set
    End Property

    Public Property TipoConsultor() As String
        Get
            Return sTipoConsultor
        End Get
        Set(ByVal value As String)
            sTipoConsultor = value
        End Set
    End Property

    Public Property Conferir() As Boolean
        Get
            Return bConferir
        End Get
        Set(ByVal value As Boolean)
            bConferir = value
        End Set
    End Property

    Public Property CodigoProsoft() As String
        Get
            Return sCodigoProsoft
        End Get
        Set(ByVal value As String)
            sCodigoProsoft = value
        End Set
    End Property

    Public Property PagamentoPontual() As Boolean
        Get
            Return bPagamentoPontual
        End Get
        Set(ByVal value As Boolean)
            bPagamentoPontual = value
        End Set
    End Property

    Public Property PontoReferencia() As String
        Get
            Return sPontoReferencia
        End Get
        Set(ByVal value As String)
            sPontoReferencia = value
        End Set
    End Property

    Public Property EspacoLeSix() As Boolean
        Get
            Return bEspacoLeSix
        End Get
        Set(ByVal value As Boolean)
            bEspacoLeSix = value
        End Set
    End Property

    Public Property Lavalpa() As Boolean
        Get
            Return bLavalpa
        End Get
        Set(ByVal value As Boolean)
            bLavalpa = value
        End Set
    End Property

    Public Property Data() As DateTime
        Get
            Return dtData
        End Get
        Set(ByVal value As DateTime)
            dtData = value
        End Set
    End Property

    Public Property NumeroPedido() As String
        Get
            Return sNumeroPedido
        End Get
        Set(ByVal value As String)
            sNumeroPedido = value
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

    Public Property TipoFrasco() As Integer
        Get
            Return iTipoFrasco
        End Get
        Set(ByVal value As Integer)
            iTipoFrasco = value
        End Set
    End Property

    Public Property Importado() As Boolean
        Get
            Return bImportado
        End Get
        Set(ByVal value As Boolean)
            bImportado = value
        End Set
    End Property

    Public Property AgenteLogistico() As Boolean
        Get
            Return bAgenteLogistico
        End Get
        Set(ByVal value As Boolean)
            bAgenteLogistico = value
        End Set
    End Property

    Public Property Cliente() As Boolean
        Get
            Return bCliente
        End Get
        Set(ByVal value As Boolean)
            bCliente = value
        End Set
    End Property

    Public Property Despachante() As Boolean
        Get
            Return bDespachante
        End Get
        Set(ByVal value As Boolean)
            bDespachante = value
        End Set
    End Property

    Public Property Fornecedor() As Boolean
        Get
            Return bFornecedor
        End Get
        Set(ByVal value As Boolean)
            bFornecedor = value
        End Set
    End Property

    Public Property Personalidade() As Integer
        Get
            Return iPersonalidade
        End Get
        Set(ByVal value As Integer)
            iPersonalidade = value
        End Set
    End Property

    Public Property CNPJCPF() As String
        Get
            Return sCNPJCPF
        End Get
        Set(ByVal value As String)
            sCNPJCPF = value
        End Set
    End Property

    Public Property RazaoSocial() As String
        Get
            Return sRazaoSocial
        End Get
        Set(ByVal value As String)
            sRazaoSocial = value
        End Set
    End Property

    Public Property NomeFantasia() As String
        Get
            Return sNomeFantasia
        End Get
        Set(ByVal value As String)
            sNomeFantasia = value
        End Set
    End Property

    Public Property Sigla() As String
        Get
            Return sSigla
        End Get
        Set(ByVal value As String)
            sSigla = value
        End Set
    End Property

    Public Property CodigoParceiroNegocioSegmento() As Integer
        Get
            Return iCodigoParceiroNegocioSegmento
        End Get
        Set(ByVal value As Integer)
            iCodigoParceiroNegocioSegmento = value
        End Set
    End Property

    Public Property RegimeTributario() As Integer
        Get
            Return iRegimeTributario
        End Get
        Set(ByVal value As Integer)
            iRegimeTributario = value
        End Set
    End Property

    Public Property CNAE() As String
        Get
            Return sCNAE
        End Get
        Set(ByVal value As String)
            sCNAE = value
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

    Public Property CodigoTipoInscricaoEstadual() As Integer
        Get
            Return iCodigoTipoInscricaoEstadual
        End Get
        Set(ByVal value As Integer)
            iCodigoTipoInscricaoEstadual = value
        End Set
    End Property

    Public Property InscricaoEstadual() As String
        Get
            Return sInscricaoEstadual
        End Get
        Set(ByVal value As String)
            sInscricaoEstadual = value
        End Set
    End Property

    Public Property InscricaoEstadualSubstitutoTributario() As String
        Get
            Return sInscricaoEstadualSubstitutoTributario
        End Get
        Set(ByVal value As String)
            sInscricaoEstadualSubstitutoTributario = value
        End Set
    End Property

    Public Property InscricaoMunicipal() As String
        Get
            Return sInscricaoMunicipal
        End Get
        Set(ByVal value As String)
            sInscricaoMunicipal = value
        End Set
    End Property

    Public Property InscricaoSuframa() As String
        Get
            Return sInscricaoSuframa
        End Get
        Set(ByVal value As String)
            sInscricaoSuframa = value
        End Set
    End Property

    Public Property Pais() As Integer
        Get
            Return iPais
        End Get
        Set(ByVal value As Integer)
            iPais = value
        End Set
    End Property

    Public Property UF() As String
        Get
            Return sUF
        End Get
        Set(ByVal value As String)
            sUF = value
        End Set
    End Property

    Public Property Municipio() As Integer
        Get
            Return iMunicipio
        End Get
        Set(ByVal value As Integer)
            iMunicipio = value
        End Set
    End Property

    Public Property Logradouro() As String
        Get
            Return sLogradouro
        End Get
        Set(ByVal value As String)
            sLogradouro = value
        End Set
    End Property

    Public Property Numero() As String
        Get
            Return sNumero
        End Get
        Set(ByVal value As String)
            sNumero = value
        End Set
    End Property

    Public Property Bairro() As String
        Get
            Return sBairro
        End Get
        Set(ByVal value As String)
            sBairro = value
        End Set
    End Property

    Public Property Complemento() As String
        Get
            Return sComplemento
        End Get
        Set(ByVal value As String)
            sComplemento = value
        End Set
    End Property

    Public Property Cep() As String
        Get
            Return sCEP
        End Get
        Set(ByVal value As String)
            sCEP = value
        End Set
    End Property

    Public Property DataAniversario() As String
        Get
            Return sDataAniversario
        End Get
        Set(ByVal value As String)
            sDataAniversario = value
        End Set
    End Property

    Public Property DataFundacao() As String
        Get
            Return sDataFundacao
        End Get
        Set(ByVal value As String)
            sDataFundacao = value
        End Set
    End Property

    Public Property DataCadastro() As String
        Get
            Return sDataCadastro
        End Get
        Set(ByVal value As String)
            sDataCadastro = value
        End Set
    End Property

    Public Property RG() As String
        Get
            Return sRG
        End Get
        Set(ByVal value As String)
            sRG = value
        End Set
    End Property

    Public Property OrgaoEmissor() As String
        Get
            Return sOrgaoEmissor
        End Get
        Set(ByVal value As String)
            sOrgaoEmissor = value
        End Set
    End Property

    Public Property DataEmissaoRG() As String
        Get
            Return sDataEmissaoRG
        End Get
        Set(ByVal value As String)
            sDataEmissaoRG = value
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

    Public Property Telefone1() As String
        Get
            Return sTelefone1
        End Get
        Set(ByVal value As String)
            sTelefone1 = value
        End Set
    End Property

    Public Property Telefone2() As String
        Get
            Return sTelefone2
        End Get
        Set(ByVal value As String)
            sTelefone2 = value
        End Set
    End Property

    Public Property TelefoneRecado() As String
        Get
            Return sTelefoneRecado
        End Get
        Set(ByVal value As String)
            sTelefoneRecado = value
        End Set
    End Property

    Public Property Fax() As String
        Get
            Return sFax
        End Get
        Set(ByVal value As String)
            sFax = value
        End Set
    End Property

    Public Property Email() As String
        Get
            Return sEmail
        End Get
        Set(ByVal value As String)
            sEmail = value
        End Set
    End Property

    Public Property Email2() As String
        Get
            Return sEmail2
        End Get
        Set(ByVal value As String)
            sEmail2 = value
        End Set
    End Property

    Public Property CodigoVendedor() As Integer
        Get
            Return iCodigoVendedor
        End Get
        Set(ByVal value As Integer)
            iCodigoVendedor = value
        End Set
    End Property

    Public Property CodigoVendedorInterno() As Integer
        Get
            Return iCodigoVendedorInterno
        End Get
        Set(ByVal value As Integer)
            iCodigoVendedorInterno = value
        End Set
    End Property

    Public Property CodigoCondicaoPagamento() As Integer
        Get
            Return iCodigoCondicaoPagamento
        End Get
        Set(ByVal value As Integer)
            iCodigoCondicaoPagamento = value
        End Set
    End Property

    Public Property CodigoFormaPagamento() As Integer
        Get
            Return iCodigoFormaPagamento
        End Get
        Set(ByVal value As Integer)
            iCodigoFormaPagamento = value
        End Set
    End Property

    Public Property CodigoMoeda() As Integer
        Get
            Return iCodigoMoeda
        End Get
        Set(ByVal value As Integer)
            iCodigoMoeda = value
        End Set
    End Property

    Public Property CodigoModalidadeFrete() As Integer
        Get
            Return iCodigoModalidadeFrete
        End Get
        Set(ByVal value As Integer)
            iCodigoModalidadeFrete = value
        End Set
    End Property

    Public Property CodigoIntegracao() As String
        Get
            Return sCodigoIntegracao
        End Get
        Set(ByVal value As String)
            sCodigoIntegracao = value
        End Set
    End Property

    Public Property EnviarAR() As Integer
        Get
            Return iEnviarAR
        End Get
        Set(ByVal value As Integer)
            iEnviarAR = value
        End Set
    End Property

    Public Property CodigoCampanha() As Integer
        Get
            Return iCodigoCampanha
        End Get
        Set(ByVal value As Integer)
            iCodigoCampanha = value
        End Set
    End Property

    Public Property CodigoDestinacao() As Integer
        Get
            Return iCodigoDestinacao
        End Get
        Set(ByVal value As Integer)
            iCodigoDestinacao = value
        End Set
    End Property

    Public Property LimiteCredito() As Double
        Get
            Return dLimiteCredito
        End Get
        Set(ByVal value As Double)
            dLimiteCredito = value
        End Set
    End Property

    Public Property AvisoTempoCompra() As Integer
        Get
            Return iAvisoTempoCompra
        End Get
        Set(ByVal value As Integer)
            iAvisoTempoCompra = value
        End Set
    End Property

    Public Property NumeroMesesValidadeProduto() As Integer
        Get
            Return iNumeroMesesValidadeProduto
        End Get
        Set(ByVal value As Integer)
            iNumeroMesesValidadeProduto = value
        End Set
    End Property

    Public Property CodigoInstrucaoCobranca1() As String
        Get
            Return sCodigoInstrucaoCobranca1
        End Get
        Set(ByVal value As String)
            sCodigoInstrucaoCobranca1 = value
        End Set
    End Property

    Public Property CodigoInstrucaoCobranca2() As String
        Get
            Return sCodigoInstrucaoCobranca2
        End Get
        Set(ByVal value As String)
            sCodigoInstrucaoCobranca2 = value
        End Set
    End Property

    Public Property NumeroDias1() As Integer
        Get
            Return iNumeroDias1
        End Get
        Set(ByVal value As Integer)
            iNumeroDias1 = value
        End Set
    End Property

    Public Property NumeroDias2() As Integer
        Get
            Return iNumeroDias2
        End Get
        Set(ByVal value As Integer)
            iNumeroDias2 = value
        End Set
    End Property

    Public Property CodigoCondicaoPagamentoFornecedor() As Integer
        Get
            Return iCodigoCondicaoPagamentoFornecedor
        End Get
        Set(ByVal value As Integer)
            iCodigoCondicaoPagamentoFornecedor = value
        End Set
    End Property

    Public Property CodigoFormaPagamentoFornecedor() As Integer
        Get
            Return iCodigoFormaPagamentoFornecedor
        End Get
        Set(ByVal value As Integer)
            iCodigoFormaPagamentoFornecedor = value
        End Set
    End Property

    Public Property CodigoMoedaFornecedor() As Integer
        Get
            Return iCodigoMoedaFornecedor
        End Get
        Set(ByVal value As Integer)
            iCodigoMoedaFornecedor = value
        End Set
    End Property

    Public Property CodigoModalidadeFreteFornecedor() As Integer
        Get
            Return iCodigoModalidadeFreteFornecedor
        End Get
        Set(ByVal value As Integer)
            iCodigoModalidadeFreteFornecedor = value
        End Set
    End Property

    Public Property ClassificacaoFornecedor() As String
        Get
            Return sClassificacaoFornecedor
        End Get
        Set(ByVal value As String)
            sClassificacaoFornecedor = value
        End Set
    End Property

    Public Property CodigoTipoNegativacao() As Integer
        Get
            Return iCodigoTipoNegativacao
        End Get
        Set(ByVal value As Integer)
            iCodigoTipoNegativacao = value
        End Set
    End Property

    Public Property DataNegativacao() As String
        Get
            Return sDataNegativacao
        End Get
        Set(ByVal value As String)
            sDataNegativacao = value
        End Set
    End Property

    Public Property TextoNegativacao() As String
        Get
            Return sTextoNegativacao
        End Get
        Set(ByVal value As String)
            sTextoNegativacao = value
        End Set
    End Property

    Public Property CodigoIdentificacao() As String
        Get
            Return sCodigoIdentificacao
        End Get
        Set(ByVal value As String)
            sCodigoIdentificacao = value
        End Set
    End Property

    Public Property NomePai() As String
        Get
            Return sNomePai
        End Get
        Set(ByVal value As String)
            sNomePai = value
        End Set
    End Property

    Public Property NomeMae() As String
        Get
            Return sNomeMae
        End Get
        Set(ByVal value As String)
            sNomeMae = value
        End Set
    End Property

    Public Property AnoCadastro() As Integer
        Get
            Return iAnoCadastro
        End Get
        Set(ByVal value As Integer)
            iAnoCadastro = value
        End Set
    End Property

    Public Property MesCadastro() As Integer
        Get
            Return iMesCadastro
        End Get
        Set(ByVal value As Integer)
            iMesCadastro = value
        End Set
    End Property

    Public Property Sexo() As String
        Get
            Return sSexo
        End Get
        Set(ByVal value As String)
            sSexo = value
        End Set
    End Property

    Public Property CodigoRota() As Integer
        Get
            Return iCodigoRota
        End Get
        Set(ByVal value As Integer)
            iCodigoRota = value
        End Set
    End Property

    Public Property CodigoEquipeTrabalho() As Integer
        Get
            Return iCodigoEquipeTrabalho
        End Get
        Set(ByVal value As Integer)
            iCodigoEquipeTrabalho = value
        End Set
    End Property

    Public Property CodigoIndicante() As Integer
        Get
            Return iCodigoIndicante
        End Get
        Set(ByVal value As Integer)
            iCodigoIndicante = value
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

    Public Property CodigoFornecedor() As String
        Get
            Return sCodigoFornecedor
        End Get
        Set(ByVal value As String)
            sCodigoFornecedor = value
        End Set
    End Property

    Public Property NecessitaConferencia As Boolean
        Get
            Return bNecessitaConferencia
        End Get
        Set(ByVal value As Boolean)
            bNecessitaConferencia = value
        End Set
    End Property

    Public Property Cronograma As Boolean
        Get
            Return bCronograma
        End Get
        Set(ByVal value As Boolean)
            bCronograma = value
        End Set
    End Property

    Public Property PagamentoAVista() As Boolean
        Get
            Return bPagamentoAVista
        End Get
        Set(ByVal value As Boolean)
            bPagamentoAVista = value
        End Set
    End Property

    Public Property EntregaFisica As Boolean
        Get
            Return bEntregaFisica
        End Get
        Set(ByVal value As Boolean)
            bEntregaFisica = value
        End Set
    End Property

    Public Property EntregaEmail As Boolean
        Get
            Return bEntregaEmail
        End Get
        Set(ByVal value As Boolean)
            bEntregaEmail = value
        End Set
    End Property

    Public Property ValidadeOrcamentoDias() As Integer
        Get
            Return iValidadeOrcamentoDias
        End Get
        Set(ByVal value As Integer)
            iValidadeOrcamentoDias = value
        End Set
    End Property

    Public Property CheckTelefone1() As Boolean
        Get
            Return bCheckTelefone1
        End Get
        Set(ByVal value As Boolean)
            bCheckTelefone1 = value
        End Set
    End Property

    Public Property CheckTelefone2() As Boolean
        Get
            Return bCheckTelefone2
        End Get
        Set(ByVal value As Boolean)
            bCheckTelefone2 = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: PARCEIRO DE NEGÓCIO :::"
    Public Sub DeleteUnidadeNegocio(ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1 : ReDim Preserve oSqlParameter(i)

        
            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_parceiro_negocio_unidade_negocio", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Public Sub InsertUnidadeNegocio(ByVal iCodigo As Integer,
                                    ByVal iCodigoUnidadeNegocio As Integer)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoUnidadeNegocio : i += 1 : ReDim Preserve oSqlParameter(i)


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_parceiro_negocio_unidade_negocio", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteMercado(ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_parceiro_negocio_mercado", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Public Sub InsertMercado(ByVal iCodigo As Integer,
                             ByVal iCodigoMercado As Integer)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_mercado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoMercado


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_parceiro_negocio_mercado", oSqlParameter)

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
            oSqlParameter(i).ParameterName = "porcentagem_reducao_base_calculo_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPorcentagemReducaoBaseCalculoICMS : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ferramental"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bFerramental : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bProduto : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaICMS : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_icms_reduzida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaICMSReduzida : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaIPI : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "incide_pis_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bIncidePISCOFINS : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_pis"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaPIS : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaCOFINS : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_iss"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaISS : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "capacidade_mensal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dCapacidadeMensal : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Prosoft
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_prosoft"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sCodigoProsoft : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Agente Logístico
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "agente_logistico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAgenteLogistico : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bCliente : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bFornecedor : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Despachante
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "despachante"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bDespachante : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Personalidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_personalidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iPersonalidade : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Nome Fantasia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_fantasia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sNomeFantasia : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Sigla
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sigla"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(sSigla = "", DBNull.Value, sSigla) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Razão Social
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "razao_social"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sRazaoSocial : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Parceiro de Negócio - Segmento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio_segmento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoParceiroNegocioSegmento = -1, DBNull.Value, iCodigoParceiroNegocioSegmento) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Regime Tributário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_regime_tributario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iRegimeTributario = -1, DBNull.Value, iRegimeTributario) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_rota"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoRota : i += 1 : ReDim Preserve oSqlParameter(i)


            'Seta Parametros - CNAE
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnae"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 7
            oSqlParameter(i).Value = IIf(sCNAE = "", DBNull.Value, sCNAE) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = Ativo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Cnpj/Cpf
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnpj_cpf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCNPJCPF : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Tipo Inscrição Estadual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_inscricao_estadual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoTipoInscricaoEstadual = -1, DBNull.Value, iCodigoTipoInscricaoEstadual) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Inscrição Estadual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inscricao_estadual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 14
            oSqlParameter(i).Value = IIf(sInscricaoEstadual = "", DBNull.Value, sInscricaoEstadual) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Inscrição Estadual Substituto Tributário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inscricao_estadual_substituto_tributario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 14
            oSqlParameter(i).Value = IIf(sInscricaoEstadualSubstitutoTributario = "", DBNull.Value, sInscricaoEstadualSubstitutoTributario) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Inscrição Municipal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inscricao_municipal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = IIf(sInscricaoMunicipal = "", DBNull.Value, sInscricaoMunicipal) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Inscrição Suframa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inscricao_suframa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 9
            oSqlParameter(i).Value = IIf(sInscricaoSuframa = "", DBNull.Value, sInscricaoSuframa) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - País
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pais"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iPais : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - UF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sUF : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Município
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_municipio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iMunicipio = -1, DBNull.Value, iMunicipio) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Logradouro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "logradouro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sLogradouro : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Número
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sNumero : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Bairro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "bairro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sBairro : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Complemento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "complemento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sComplemento = "", DBNull.Value, sComplemento) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - CEP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cep"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sCEP : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Vendedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_vendedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoVendedor = -1, DBNull.Value, iCodigoVendedor) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Vendedor Interno
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_vendedor_interno"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoVendedorInterno = -1, DBNull.Value, iCodigoVendedorInterno) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Data da Fundação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_fundacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataFundacao), sDataFundacao, DBNull.Value) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Data do Cadastro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_cadastro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataCadastro), sDataCadastro, DBNull.Value) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - RG
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "rg"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sRG = "", DBNull.Value, sRG) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Orgão Emissor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "orgao_emissor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sOrgaoEmissor = "", DBNull.Value, sRG) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Data Emissão RG
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_rg"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataEmissaoRG), sDataEmissaoRG, DBNull.Value) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Observação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Text
            oSqlParameter(i).Value = IIf(sObservacao = "", DBNull.Value, sObservacao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Telefone 1
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone1"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = sTelefone1 : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Telefone 2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = sTelefone2 : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Fax
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fax"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = sFax : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Telefone Recado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone_recado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = sTelefoneRecado : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Email
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "email"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sEmail : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Email2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "email2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sEmail2 : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Condição de Pagamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_condicao_pagamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(iCodigoCondicaoPagamento = -1, DBNull.Value, iCodigoCondicaoPagamento) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Forma de Pagamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_forma_pagamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoFormaPagamento = -1, DBNull.Value, iCodigoFormaPagamento) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Moeda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_moeda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoMoeda = -1, DBNull.Value, iCodigoMoeda) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Modalidade Frete
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modalidade_frete"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoModalidadeFrete = -1, DBNull.Value, iCodigoModalidadeFrete) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Integração
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_integracao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sCodigoIntegracao = "", DBNull.Value, sCodigoIntegracao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Enviar AR
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "enviar_ar"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = IIf(iEnviarAR = -1, DBNull.Value, iEnviarAR) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Campanha
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_campanha"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoCampanha = -1, DBNull.Value, iCodigoCampanha) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Destinação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_destinacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoDestinacao = -1, DBNull.Value, iCodigoDestinacao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Nº Meses Validade Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_meses_validade_produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iNumeroMesesValidadeProduto : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Condição de Pagamento Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_condicao_pagamento_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(iCodigoCondicaoPagamentoFornecedor = -1, DBNull.Value, iCodigoCondicaoPagamentoFornecedor) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Forma de Pagamento Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_forma_pagamento_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoFormaPagamentoFornecedor = -1, DBNull.Value, iCodigoFormaPagamentoFornecedor) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Moeda Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_moeda_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoMoedaFornecedor = -1, DBNull.Value, iCodigoMoedaFornecedor) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Modalidade Frete Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modalidade_frete_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoModalidadeFreteFornecedor = -1, DBNull.Value, iCodigoModalidadeFreteFornecedor) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Classificacao Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "classificacao_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = IIf(sClassificacaoFornecedor = "", DBNull.Value, sClassificacaoFornecedor) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Limite de Crédito
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "limite_credito"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dLimiteCredito = 0, DBNull.Value, dLimiteCredito) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Instrução 1
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_instrucao1"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sCodigoInstrucaoCobranca1 = "", DBNull.Value, sCodigoInstrucaoCobranca1) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Instrução 2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_instrucao2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sCodigoInstrucaoCobranca2 = "", DBNull.Value, sCodigoInstrucaoCobranca2) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Número Dias 1
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_dias1"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iNumeroDias1 = -1, DBNull.Value, iNumeroDias1) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Número Dias 2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_dias2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iNumeroDias2 = -1, DBNull.Value, iNumeroDias2) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Tipo Negativação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_negativacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoTipoNegativacao = -1, DBNull.Value, iCodigoTipoNegativacao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Data Negativação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_negativacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(iCodigoTipoNegativacao = -1, DBNull.Value, sDataNegativacao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Texto da Negativação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "texto_negativacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5000
            oSqlParameter(i).Value = IIf(iCodigoTipoNegativacao = -1, DBNull.Value, sTextoNegativacao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_equipe_trabalho"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoEquipeTrabalho : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_identificacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCodigoIdentificacao : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_pai"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNomePai : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_mae"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNomeMae : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ano_cadastro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iAnoCadastro : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "semana_cadastro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iMesCadastro : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sexo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sSexo : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "necessita_conferencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bNecessitaConferencia : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_categoria"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCategoria : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "validade_orcamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iValidadeOrcamentoDias : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "chk_telefone1"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bCheckTelefone1 : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "chk_telefone2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bCheckTelefone2 : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.Int

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_parceiro_negocio", oSqlParameter)

            'Seta Código
            iCodigo = oSqlParameter(i).Value

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
            oSqlParameter(i).ParameterName = "porcentagem_reducao_base_calculo_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPorcentagemReducaoBaseCalculoICMS : i += 1 : ReDim Preserve oSqlParameter(i)


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ferramental"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bFerramental : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bProduto : i += 1 : ReDim Preserve oSqlParameter(i)


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaICMS : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_icms_reduzida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaICMSReduzida : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaIPI : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "incide_pis_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bIncidePISCOFINS : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_pis"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaPIS : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaCOFINS : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_iss"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaISS : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "capacidade_mensal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dCapacidadeMensal : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "agente_logistico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAgenteLogistico : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bCliente : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bFornecedor : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Despachante
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "despachante"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bDespachante : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Personalidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_personalidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iPersonalidade : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Nome Fantasia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_fantasia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sNomeFantasia : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Razão Social
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "razao_social"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sRazaoSocial : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Sigla
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sigla"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sSigla = "", DBNull.Value, sSigla) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Parceiro de Negócio - Segmento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio_segmento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoParceiroNegocioSegmento = -1, DBNull.Value, iCodigoParceiroNegocioSegmento) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Regime Tributário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_regime_tributario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iRegimeTributario = -1, DBNull.Value, iRegimeTributario) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - CNAE
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnae"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 7
            oSqlParameter(i).Value = IIf(sCNAE = "", DBNull.Value, sCNAE) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Ativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = Ativo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Cnpj/Cpf
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnpj_cpf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCNPJCPF : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Tipo Inscrição Estadual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_inscricao_estadual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoTipoInscricaoEstadual = -1, DBNull.Value, iCodigoTipoInscricaoEstadual) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Inscrição Estadual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inscricao_estadual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 14
            oSqlParameter(i).Value = IIf(sInscricaoEstadual = "", DBNull.Value, sInscricaoEstadual) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Inscrição Estadual Substituto Tributário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inscricao_estadual_substituto_tributario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 14
            oSqlParameter(i).Value = IIf(sInscricaoEstadualSubstitutoTributario = "", DBNull.Value, sInscricaoEstadualSubstitutoTributario) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Inscrição Municipal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inscricao_municipal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = IIf(sInscricaoMunicipal = "", DBNull.Value, sInscricaoMunicipal) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Inscrição Suframa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inscricao_suframa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 9
            oSqlParameter(i).Value = IIf(sInscricaoSuframa = "", DBNull.Value, sInscricaoSuframa) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - País
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pais"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iPais : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - UF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sUF : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Município
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_municipio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iMunicipio = -1, DBNull.Value, iMunicipio) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Logradouro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "logradouro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sLogradouro : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Número
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sNumero : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Bairro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "bairro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sBairro : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Complemento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "complemento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sComplemento = "", DBNull.Value, sComplemento) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - CEP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cep"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sCEP : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Vendedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_vendedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoVendedor = -1, DBNull.Value, iCodigoVendedor) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Vendedor Interno
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_vendedor_interno"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoVendedorInterno = -1, DBNull.Value, iCodigoVendedorInterno) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Data da Fundação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_fundacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataFundacao), sDataFundacao, DBNull.Value) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Data do Cadastro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_cadastro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataCadastro), sDataCadastro, DBNull.Value) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - RG
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "rg"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sRG = "", DBNull.Value, sRG) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Orgão Emissor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "orgao_emissor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sOrgaoEmissor = "", DBNull.Value, sRG) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Data Emissão RG
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_rg"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataEmissaoRG), sDataEmissaoRG, DBNull.Value) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Observação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Text
            oSqlParameter(i).Value = IIf(sObservacao = "", DBNull.Value, sObservacao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Telefone 1
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone1"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = sTelefone1 : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Telefone 2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = sTelefone2 : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Fax
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fax"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = sFax : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Telefone Recado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone_recado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = sTelefoneRecado : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Email
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "email"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sEmail : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "email2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sEmail2 : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Condição de Pagamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_condicao_pagamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(iCodigoCondicaoPagamento = -1, DBNull.Value, iCodigoCondicaoPagamento) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Forma de Pagamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_forma_pagamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoFormaPagamento = -1, DBNull.Value, iCodigoFormaPagamento) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Moeda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_moeda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoMoeda = -1, DBNull.Value, iCodigoMoeda) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Modalidade Frete
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modalidade_frete"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoModalidadeFrete = -1, DBNull.Value, iCodigoModalidadeFrete) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Limite de Crédito
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "limite_credito"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dLimiteCredito = 0, DBNull.Value, dLimiteCredito) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Instrução 1
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_instrucao1"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sCodigoInstrucaoCobranca1 = "", DBNull.Value, sCodigoInstrucaoCobranca1) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Instrução 2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_instrucao2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = IIf(sCodigoInstrucaoCobranca2 = "", DBNull.Value, sCodigoInstrucaoCobranca2) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Número Dias 1
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_dias1"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iNumeroDias1 = -1, DBNull.Value, iNumeroDias1) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Número Dias 2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_dias2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iNumeroDias2 = -1, DBNull.Value, iNumeroDias2) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Integração
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_integracao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sCodigoIntegracao = "", DBNull.Value, sCodigoIntegracao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Enviar AR
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "enviar_ar"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = IIf(iEnviarAR = -1, DBNull.Value, iEnviarAR) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Campanha
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_campanha"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoCampanha = -1, DBNull.Value, iCodigoCampanha) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Destinação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_destinacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoDestinacao = -1, DBNull.Value, iCodigoDestinacao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Nº Meses Validade Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_meses_validade_produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iNumeroMesesValidadeProduto : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Condição de Pagamento Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_condicao_pagamento_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(iCodigoCondicaoPagamentoFornecedor = -1, DBNull.Value, iCodigoCondicaoPagamentoFornecedor) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Forma de Pagamento Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_forma_pagamento_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoFormaPagamentoFornecedor = -1, DBNull.Value, iCodigoFormaPagamentoFornecedor) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Moeda Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_moeda_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoMoedaFornecedor = -1, DBNull.Value, iCodigoMoedaFornecedor) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Modalidade Frete Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modalidade_frete_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoModalidadeFreteFornecedor = -1, DBNull.Value, iCodigoModalidadeFreteFornecedor) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Classificacao Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "classificacao_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = IIf(sClassificacaoFornecedor = "", DBNull.Value, sClassificacaoFornecedor) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Tipo Negativação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_negativacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoTipoNegativacao = -1, DBNull.Value, iCodigoTipoNegativacao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Data Negativação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_negativacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(iCodigoTipoNegativacao = -1, DBNull.Value, sDataNegativacao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Texto da Negativação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "texto_negativacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5000
            oSqlParameter(i).Value = IIf(iCodigoTipoNegativacao = -1, DBNull.Value, sTextoNegativacao) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_equipe_trabalho"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoEquipeTrabalho = -1, DBNull.Value, iCodigoEquipeTrabalho) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_rota"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoRota = -1, DBNull.Value, iCodigoRota) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_identificacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCodigoIdentificacao : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_pai"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNomePai : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_mae"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNomeMae : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ano_cadastro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iAnoCadastro = -1, DBNull.Value, iAnoCadastro) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "semana_cadastro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iMesCadastro = -1, DBNull.Value, iMesCadastro) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sexo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sSexo : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "necessita_conferencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bNecessitaConferencia : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_categoria"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCategoria : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "validade_orcamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iValidadeOrcamentoDias : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "chk_telefone1"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bCheckTelefone1 : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "chk_telefone2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bCheckTelefone2 : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_parceiro_negocio", oSqlParameter)

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
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_usuario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_parceiro_negocio", oSqlParameter)

                'Deleta Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaCnpjCpf(ByVal lCodigo As Long, _
                                  ByVal sCNPJ As String) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0
        Dim iReturn As Integer

        Try

            'Seta Retorno da Função
            ValidaCnpjCpf = False

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Cnpj / CPF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnpj_cpf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCNPJ : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_cadastro_basico_parceiro_negocio", oSqlParameter), Integer)

            'Seta Retorno da Função
            ValidaCnpjCpf = IIf(iReturn > 0, False, True)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub LoadGrid(ByVal oGrid As Janus.Windows.GridEX.GridEX, _
                        ByVal iTipoParceiroNegocio As Integer, _
                        ByVal iPersonalidade As Integer, _
                        ByVal sRazaoSocial As String, _
                        ByVal sNomeFantasia As String, _
                        ByVal sCnpjCpf As String, _
                        ByVal iCodigoParceiroNegocioSegmento As Integer, _
                        ByVal sMunicipio As String, _
                        ByVal sCodigoVendedor As String, _
                        ByVal iCodigoTipoNegativacao As Integer, _
                        ByVal iImportado As Integer, _
                        ByVal iCliente As Integer, _
                        ByVal iFornecedor As Integer, _
                        ByVal iAtivo As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(15) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Tipo Parceiro Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iTipoParceiroNegocio : i += 1

            'Seta Parametros - Personalidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_personalidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iPersonalidade : i += 1

            'Seta Parametros - Razão Social
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "razao_social"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sRazaoSocial : i += 1

            'Seta Parametros - Nome Fantasia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_fantasia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sNomeFantasia : i += 1

            'Seta Parametros - Cnpj / Cpf
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnpj_cpf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCnpjCpf : i += 1

            'Seta Parametros - Código Parceiro de Negócio - Segmento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio_segmento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoParceiroNegocioSegmento : i += 1

            'Seta Parametros - Município
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "municipio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sMunicipio : i += 1

            'Seta Parametros - Vendedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_vendedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sCodigoVendedor : i += 1

            'Seta Parametros - Código Tipo Negativação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_negativacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoNegativacao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "importado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iImportado = -1, DBNull.Value, iImportado) : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iAtivo = -1, DBNull.Value, iAtivo) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCliente = -1, DBNull.Value, iCliente) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iFornecedor = -1, DBNull.Value, iFornecedor)

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio", oSqlParameter)

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

    Public Sub LoadGridLavalpa(ByVal oGrid As Janus.Windows.GridEX.GridEX, _
                               ByVal iTipoParceiroNegocio As Integer, _
                               ByVal iPersonalidade As Integer, _
                               ByVal sRazaoSocial As String, _
                               ByVal sNomeFantasia As String, _
                               ByVal sCnpjCpf As String, _
                               ByVal iCodigoParceiroNegocioSegmento As Integer, _
                               ByVal sMunicipio As String, _
                               ByVal sCodigoVendedor As String, _
                               ByVal iCodigoTipoNegativacao As Integer, _
                               ByVal iImportado As Integer, _
                               ByVal bLavalpa As Integer, _
                               ByVal bLeSix As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(12) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Lavalpa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "lavalpa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(bLavalpa = 2, DBNull.Value, IIf(bLavalpa = False, 0, 1)) : i += 1

            'Seta Parametros - Le Six
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "le_six"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(bLeSix = 2, DBNull.Value, IIf(bLeSix = False, 0, 1)) : i += 1

            'Seta Parametros - Tipo Parceiro Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iTipoParceiroNegocio : i += 1

            'Seta Parametros - Personalidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_personalidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iPersonalidade : i += 1

            'Seta Parametros - Razão Social
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "razao_social"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sRazaoSocial : i += 1

            'Seta Parametros - Nome Fantasia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_fantasia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sNomeFantasia : i += 1

            'Seta Parametros - Cnpj / Cpf
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnpj_cpf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCnpjCpf : i += 1

            'Seta Parametros - Código Parceiro de Negócio - Segmento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio_segmento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoParceiroNegocioSegmento : i += 1

            'Seta Parametros - Município
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "municipio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sMunicipio : i += 1

            'Seta Parametros - Vendedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_vendedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sCodigoVendedor : i += 1

            'Seta Parametros - Código Tipo Negativação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_negativacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoNegativacao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "importado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iImportado = -1, DBNull.Value, iImportado) : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_lavalpa", oSqlParameter)

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

    Public Sub LoadGridFind(ByVal oGrid As GridEX, _
                            ByVal iCodigoTipoParceiroNegocio As Integer, _
                            ByVal iCodigoPersonalidade As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Tipo Parceiro Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoParceiroNegocio : i += 1

            'Seta Parametros - Código Personalidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_personalidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoPersonalidade : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_find_parceiro_negocio", oSqlParameter)

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

    Public Sub LoadGridFind(ByVal oGrid As GridEX, _
                            ByVal sQuery As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim i As Integer = 0

        Try

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.Text, sQuery)

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

    Public Sub LoadControlesMagma(ByVal lCodigoParceiroNegocio As Long, _
                             ByVal chkAgenteLogistico As UICheckBox, _
                             ByVal chkCliente As UICheckBox, _
                             ByVal chkFornecedor As UICheckBox, _
                             ByVal chkDespachante As UICheckBox, _
                             ByVal cboPersonalidade As UIComboBox, _
                             ByVal txtRazaoSocial As MaskedEditBox, _
                             ByVal txtNomeFantasia As MaskedEditBox, _
                             ByVal cboSegmento As UIComboBox, _
                             ByVal cboAtivo As UIComboBox, _
                             ByVal txtCnpjCpf As MaskedEditBox, _
                             ByVal cboRegimeTributario As UIComboBox, _
                             ByVal txtCNAE As MaskedEditBox, _
                             ByVal cboTipoInscricaoEstadual As UIComboBox, _
                             ByVal txtInscricaoEstadual As MaskedEditBox, _
                             ByVal txtInscricaoEstadualSubstitutoTributario As MaskedEditBox, _
                             ByVal txtInscricaoMunicipal As MaskedEditBox, _
                             ByVal txtInscricaoSuframa As MaskedEditBox, _
                             ByVal txtLogradouro As MaskedEditBox, _
                             ByVal txtNumero As MaskedEditBox, _
                             ByVal txtBairro As MaskedEditBox, _
                             ByVal cboMunicipio As UIComboBox, _
                             ByVal cboPais As UIComboBox, _
                             ByVal cboUF As UIComboBox, _
                             ByVal txtComplemento As MaskedEditBox, _
                             ByVal txtCEP As MaskedEditBox, _
                             ByVal txtObservacao As EditBox, _
                             ByVal txtTelefone1 As MaskedEditBox, _
                             ByVal txtTelefone2 As MaskedEditBox, _
                             ByVal txtTelefoneRecado As MaskedEditBox, _
                             ByVal txtFax As MaskedEditBox, _
                             ByVal txtEmail As MaskedEditBox, _
                             ByVal cboCondicaoPagamento As UIComboBox, _
                             ByVal cboFormaPagamento As UIComboBox, _
                             ByVal cboMoeda As UIComboBox, _
                             ByVal cboModalidadeFrete As UIComboBox, _
                             ByVal txtLimiteCredito As NumericEditBox, _
                             ByVal cboInstrucaoCobranca1 As UIComboBox, _
                             ByVal cboInstrucaoCobranca2 As UIComboBox, _
                             ByVal txtNumeroDias1 As NumericEditBox, _
                             ByVal txtNumeroDias2 As NumericEditBox, _
                             ByVal cboCondicaoPagamentoFornecedor As UIComboBox, _
                             ByVal cboFormaPagamentoFornecedor As UIComboBox, _
                             ByVal cboMoedaFornecedor As UIComboBox, _
                             ByVal cboModalidadeFreteFornecedor As UIComboBox, _
                             ByVal txtClassificacaoFornecedor As MaskedEditBox, _
                             ByVal cboTipoNegativacao As UIComboBox, _
                             ByVal dtpDataNegativacao As CalendarCombo, _
                             ByVal txtTextoNegativacao As EditBox, _
                             ByVal cboIndicante As UIComboBox, _
                             ByVal cboEquipeTrabalho As UIComboBox, _
                             ByVal dtpDataAniversario As CalendarCombo, _
                             ByVal dtpDataCadastro As CalendarCombo, _
                             ByVal txtNomePai As MaskedEditBox, _
                             ByVal txtNomeMae As MaskedEditBox, _
                             ByVal cboSexo As UIComboBox, _
                             ByVal txtCodigoIdentificacao As MaskedEditBox, _
                             ByVal cboAnoCadastro As UIComboBox, _
                             ByVal cboSemanaCadastro As UIComboBox, _
                             ByVal cboRota As UIComboBox, _
                             ByVal chkNecessitaConferencia As UICheckBox, _
                             ByVal chkPagamentoAVista As UICheckBox, _
                             ByVal txtPontoReferencia As MaskedEditBox, _
                             ByVal chkConferir As UICheckBox, _
                             ByVal txtTipoConsultor As MaskedEditBox, _
                             ByVal cboGrupo As UIComboBox, _
                             ByVal chkEntregaVizinho As UICheckBox, _
                             ByVal txtDadosVizinho As MaskedEditBox, _
                             ByVal chkRetiradaDocumentos As UICheckBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try




            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_parceiro_negocio", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    chkNecessitaConferencia.Checked = oSqlDataReader.Item("necessita_conferencia")
                    chkAgenteLogistico.Checked = oSqlDataReader.Item("agente_logistico")
                    chkCliente.Checked = oSqlDataReader.Item("cliente")
                    chkFornecedor.Checked = oSqlDataReader.Item("fornecedor")
                    chkDespachante.Checked = oSqlDataReader.Item("despachante")
                    cboPersonalidade.SelectedValue = oSqlDataReader.Item("codigo_personalidade")
                    txtRazaoSocial.Text = oSqlDataReader.Item("razao_social")
                    txtNomeFantasia.Text = oSqlDataReader.Item("nome_fantasia")
                    cboSegmento.SelectedValue = oSqlDataReader.Item("codigo_parceiro_negocio_segmento")
                    cboRegimeTributario.SelectedValue = oSqlDataReader.Item("codigo_regime_tributario")
                    txtCNAE.Text = IIf(IsDBNull(oSqlDataReader.Item("cnae")), "", oSqlDataReader.Item("cnae"))
                    cboAtivo.SelectedValue = oSqlDataReader.Item("ativo")
                    txtCnpjCpf.Text = oSqlDataReader.Item("cnpj_cpf")
                    cboTipoInscricaoEstadual.SelectedValue = oSqlDataReader.Item("codigo_tipo_inscricao_estadual")
                    txtInscricaoEstadual.Text = IIf(IsDBNull(oSqlDataReader.Item("inscricao_estadual")), "", oSqlDataReader.Item("inscricao_estadual"))
                    txtInscricaoEstadualSubstitutoTributario.Text = IIf(IsDBNull(oSqlDataReader.Item("inscricao_estadual_substituto_tributario")), "", oSqlDataReader.Item("inscricao_estadual_substituto_tributario"))
                    txtInscricaoMunicipal.Text = IIf(IsDBNull(oSqlDataReader.Item("inscricao_municipal")), "", oSqlDataReader.Item("inscricao_municipal"))
                    txtInscricaoSuframa.Text = IIf(IsDBNull(oSqlDataReader.Item("inscricao_suframa")), "", oSqlDataReader.Item("inscricao_suframa"))
                    cboPais.SelectedValue = oSqlDataReader.Item("codigo_pais")
                    cboUF.SelectedValue = oSqlDataReader.Item("uf")
                    cboMunicipio.SelectedValue = oSqlDataReader.Item("codigo_municipio")
                    txtLogradouro.Text = oSqlDataReader.Item("logradouro")
                    txtNumero.Text = oSqlDataReader.Item("numero")
                    txtBairro.Text = oSqlDataReader.Item("bairro")
                    txtComplemento.Text = oSqlDataReader.Item("complemento")
                    txtCEP.Text = oSqlDataReader.Item("cep")
                    cboIndicante.SelectedValue = oSqlDataReader.Item("codigo_indicante")
                    cboEquipeTrabalho.SelectedValue = oSqlDataReader.Item("codigo_equipe_trabalho")
                    If IsDBNull(oSqlDataReader.Item("data_aniversario")) Then
                        dtpDataAniversario.Value = Now.Date : dtpDataAniversario.Checked = False
                    Else
                        dtpDataAniversario.Value = oSqlDataReader.Item("data_aniversario") : dtpDataAniversario.Checked = True
                    End If
                    If IsDBNull(oSqlDataReader.Item("data_cadastro")) Then
                        dtpDataCadastro.Value = Now.Date : dtpDataCadastro.Checked = False
                    Else
                        dtpDataCadastro.Value = oSqlDataReader.Item("data_cadastro") : dtpDataCadastro.Checked = True
                    End If
                    txtObservacao.Text = IIf(IsDBNull(oSqlDataReader.Item("observacao")), "", oSqlDataReader.Item("observacao"))
                    txtTelefone1.Text = oSqlDataReader.Item("telefone1")
                    txtTelefone2.Text = oSqlDataReader.Item("telefone2")
                    txtFax.Text = oSqlDataReader.Item("fax")
                    txtTelefoneRecado.Text = oSqlDataReader.Item("telefone_recado")
                    txtEmail.Text = oSqlDataReader.Item("email")
                    cboCondicaoPagamento.SelectedValue = oSqlDataReader.Item("codigo_condicao_pagamento")
                    cboFormaPagamento.SelectedValue = oSqlDataReader.Item("codigo_forma_pagamento")
                    cboMoeda.SelectedValue = oSqlDataReader.Item("codigo_moeda")
                    cboModalidadeFrete.SelectedValue = oSqlDataReader.Item("codigo_modalidade_frete")
                    txtLimiteCredito.Value = oSqlDataReader.Item("limite_credito")
                    cboInstrucaoCobranca1.SelectedValue = oSqlDataReader.Item("codigo_instrucao1")
                    'IIf(IsDBNull(oSqlDataReader.Item("codigo_instrucao1")), cboInstrucaoCobranca1.SelectedIndex = -1, cboInstrucaoCobranca1.SelectedValue = oSqlDataReader.Item("codigo_instrucao1"))
                    'IIf(IsDBNull(oSqlDataReader.Item("codigo_instrucao2")), cboInstrucaoCobranca2.SelectedIndex = -1, cboInstrucaoCobranca2.SelectedValue = oSqlDataReader.Item("codigo_instrucao2"))
                    cboInstrucaoCobranca2.SelectedValue = oSqlDataReader.Item("codigo_instrucao2")
                    If IsDBNull(oSqlDataReader.Item("numero_dias1")) = False Then txtNumeroDias1.Value = oSqlDataReader.Item("numero_dias1")
                    If IsDBNull(oSqlDataReader.Item("numero_dias2")) = False Then txtNumeroDias2.Value = oSqlDataReader.Item("numero_dias2")
                    cboCondicaoPagamentoFornecedor.SelectedValue = oSqlDataReader.Item("codigo_condicao_pagamento_fornecedor")
                    cboFormaPagamentoFornecedor.SelectedValue = oSqlDataReader.Item("codigo_forma_pagamento_fornecedor")
                    cboMoedaFornecedor.SelectedValue = oSqlDataReader.Item("codigo_moeda_fornecedor")
                    cboModalidadeFreteFornecedor.SelectedValue = oSqlDataReader.Item("codigo_modalidade_frete_fornecedor")
                    txtClassificacaoFornecedor.Text = oSqlDataReader.Item("classificacao_fornecedor")
                    cboTipoNegativacao.SelectedValue = oSqlDataReader.Item("codigo_tipo_negativacao")
                    dtpDataNegativacao.Value = IIf(IsDBNull(oSqlDataReader.Item("data_negativacao")), Now.Date, oSqlDataReader.Item("data_negativacao"))
                    txtTextoNegativacao.Text = oSqlDataReader.Item("texto_negativacao")
                    'IIf(oSqlDataReader.Item("sexo") = "F", cboSexo.SelectedValue = 2, cboSexo.SelectedValue = 2)
                    cboSexo.SelectedValue = oSqlDataReader.Item("sexo")
                    If IsDBNull(oSqlDataReader.Item("ano_cadastro")) Then
                        cboAnoCadastro.SelectedIndex = -1
                    Else
                        cboAnoCadastro.SelectedValue = oSqlDataReader.Item("ano_cadastro")
                    End If
                    If IsDBNull(oSqlDataReader.Item("semana_cadastro")) Then
                        cboSemanaCadastro.SelectedIndex = -1
                    Else
                        cboSemanaCadastro.SelectedValue = oSqlDataReader.Item("semana_cadastro")
                    End If
                    If IsDBNull(oSqlDataReader.Item("codigo_rota")) Then
                        cboRota.SelectedIndex = -1
                    Else
                        cboRota.SelectedValue = oSqlDataReader.Item("codigo_rota")
                    End If

                    chkPagamentoAVista.Checked = oSqlDataReader.Item("pagamento_vista")
                    txtCodigoIdentificacao.Text = oSqlDataReader.Item("codigo_identificacao")
                    txtNomeMae.Text = oSqlDataReader.Item("nome_mae")
                    txtNomePai.Text = oSqlDataReader.Item("nome_pai")
                    txtPontoReferencia.Text = oSqlDataReader.Item("ponto_referencia")
                    chkConferir.Checked = oSqlDataReader.Item("conferir")
                    txtTipoConsultor.Text = oSqlDataReader.Item("tipo_cliente")
                    cboGrupo.SelectedValue = oSqlDataReader.Item("grupo_cliente")
                    chkEntregaVizinho.Checked = oSqlDataReader.Item("entrega_vizinho")
                    txtDadosVizinho.Text = oSqlDataReader.Item("dados_vizinho")
                    chkRetiradaDocumentos.Checked = oSqlDataReader.Item("retirada_documentos")

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

    Public Sub LoadControlesLBMedica(ByVal lCodigoParceiroNegocio As Long, _
                             ByVal chkAgenteLogistico As UICheckBox, _
                             ByVal chkCliente As UICheckBox, _
                             ByVal chkFornecedor As UICheckBox, _
                             ByVal chkDespachante As UICheckBox, _
                             ByVal cboPersonalidade As UIComboBox, _
                             ByVal txtRazaoSocial As MaskedEditBox, _
                             ByVal txtNomeFantasia As MaskedEditBox, _
                             ByVal txtSigla As MaskedEditBox, _
                             ByVal cboSegmento As UIComboBox, _
                             ByVal cboAtivo As UIComboBox, _
                             ByVal txtCnpjCpf As MaskedEditBox, _
                             ByVal cboRegimeTributario As UIComboBox, _
                             ByVal txtCNAE As MaskedEditBox, _
                             ByVal txtInscricaoEstadual As MaskedEditBox, _
                             ByVal txtInscricaoEstadualSubstitutoTributario As MaskedEditBox, _
                             ByVal txtInscricaoMunicipal As MaskedEditBox, _
                             ByVal txtInscricaoSuframa As MaskedEditBox, _
                             ByVal txtLogradouro As MaskedEditBox, _
                             ByVal txtNumero As MaskedEditBox, _
                             ByVal txtBairro As MaskedEditBox, _
                             ByVal cboMunicipio As UIComboBox, _
                             ByVal cboPais As UIComboBox, _
                             ByVal cboUF As UIComboBox, _
                             ByVal txtComplemento As MaskedEditBox, _
                             ByVal txtCEP As MaskedEditBox, _
                             ByVal cboVendedor As UIComboBox, _
                             ByVal cboVendedorInterno As UIComboBox, _
                             ByVal dtpDataFundacao As CalendarCombo, _
                             ByVal dtpDataCadastro As CalendarCombo, _
                             ByVal txtObservacao As EditBox, _
                             ByVal txtTelefone1 As MaskedEditBox, _
                             ByVal txtTelefone2 As MaskedEditBox, _
                             ByVal txtTelefoneRecado As MaskedEditBox, _
                             ByVal txtFax As MaskedEditBox, _
                             ByVal txtEmail As MaskedEditBox, _
                             ByVal cboCondicaoPagamento As UIComboBox, _
                             ByVal cboFormaPagamento As UIComboBox, _
                             ByVal cboMoeda As UIComboBox, _
                             ByVal cboModalidadeFrete As UIComboBox, _
                             ByVal txtCodigoIntegracao As MaskedEditBox, _
                             ByVal cboEnviarAR As UIComboBox, _
                             ByVal cboDestinacao As UIComboBox, _
                             ByVal txtLimiteCredito As NumericEditBox, _
                             ByVal cboInstrucaoCobranca1 As UIComboBox, _
                             ByVal cboInstrucaoCobranca2 As UIComboBox, _
                             ByVal txtNumeroDias1 As NumericEditBox, _
                             ByVal txtNumeroDias2 As NumericEditBox, _
                             ByVal cboCondicaoPagamentoFornecedor As UIComboBox, _
                             ByVal cboFormaPagamentoFornecedor As UIComboBox, _
                             ByVal cboMoedaFornecedor As UIComboBox, _
                             ByVal cboModalidadeFreteFornecedor As UIComboBox, _
                             ByVal txtClassificacaoFornecedor As MaskedEditBox, _
                             ByVal cboTipoNegativacao As UIComboBox, _
                             ByVal dtpDataNegativacao As CalendarCombo, _
                             ByVal txtTextoNegativacao As EditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_parceiro_negocio", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    chkAgenteLogistico.Checked = oSqlDataReader.Item("agente_logistico")
                    chkCliente.Checked = oSqlDataReader.Item("cliente")
                    chkFornecedor.Checked = oSqlDataReader.Item("fornecedor")
                    chkDespachante.Checked = oSqlDataReader.Item("despachante")
                    cboPersonalidade.SelectedValue = oSqlDataReader.Item("codigo_personalidade")
                    txtRazaoSocial.Text = oSqlDataReader.Item("razao_social")
                    txtNomeFantasia.Text = oSqlDataReader.Item("nome_fantasia")
                    txtSigla.Text = oSqlDataReader.Item("sigla")
                    cboSegmento.SelectedValue = oSqlDataReader.Item("codigo_parceiro_negocio_segmento")
                    cboRegimeTributario.SelectedValue = oSqlDataReader.Item("codigo_regime_tributario")
                    txtCNAE.Text = IIf(IsDBNull(oSqlDataReader.Item("cnae")), "", oSqlDataReader.Item("cnae"))
                    cboAtivo.SelectedValue = oSqlDataReader.Item("ativo")
                    txtCnpjCpf.Text = oSqlDataReader.Item("cnpj_cpf")
                    txtInscricaoEstadual.Text = IIf(IsDBNull(oSqlDataReader.Item("inscricao_estadual")), "", oSqlDataReader.Item("inscricao_estadual"))
                    txtInscricaoEstadualSubstitutoTributario.Text = IIf(IsDBNull(oSqlDataReader.Item("inscricao_estadual_substituto_tributario")), "", oSqlDataReader.Item("inscricao_estadual_substituto_tributario"))
                    txtInscricaoMunicipal.Text = IIf(IsDBNull(oSqlDataReader.Item("inscricao_municipal")), "", oSqlDataReader.Item("inscricao_municipal"))
                    txtInscricaoSuframa.Text = IIf(IsDBNull(oSqlDataReader.Item("inscricao_suframa")), "", oSqlDataReader.Item("inscricao_suframa"))
                    cboPais.SelectedValue = oSqlDataReader.Item("codigo_pais")
                    cboUF.SelectedValue = oSqlDataReader.Item("uf")
                    cboMunicipio.SelectedValue = oSqlDataReader.Item("codigo_municipio")
                    txtLogradouro.Text = oSqlDataReader.Item("logradouro")
                    txtNumero.Text = oSqlDataReader.Item("numero")
                    txtBairro.Text = oSqlDataReader.Item("bairro")
                    txtComplemento.Text = oSqlDataReader.Item("complemento")
                    txtCEP.Text = oSqlDataReader.Item("cep")
                    cboVendedor.SelectedValue = oSqlDataReader.Item("codigo_vendedor")
                    cboVendedorInterno.SelectedValue = oSqlDataReader.Item("codigo_vendedor_interno")
                    If IsDBNull(oSqlDataReader.Item("data_fundacao")) Then
                        dtpDataFundacao.Value = Now.Date : dtpDataFundacao.Checked = False
                    Else
                        dtpDataFundacao.Value = oSqlDataReader.Item("data_fundacao") : dtpDataFundacao.Checked = True
                    End If
                    If IsDBNull(oSqlDataReader.Item("data_cadastro")) Then
                        dtpDataCadastro.Value = Now.Date : dtpDataCadastro.Checked = False
                    Else
                        dtpDataCadastro.Value = oSqlDataReader.Item("data_cadastro") : dtpDataCadastro.Checked = True
                    End If
                    txtObservacao.Text = IIf(IsDBNull(oSqlDataReader.Item("observacao")), "", oSqlDataReader.Item("observacao"))
                    txtTelefone1.Text = oSqlDataReader.Item("telefone1")
                    txtTelefone2.Text = oSqlDataReader.Item("telefone2")
                    txtFax.Text = oSqlDataReader.Item("fax")
                    txtTelefoneRecado.Text = oSqlDataReader.Item("telefone_recado")
                    txtEmail.Text = oSqlDataReader.Item("email")
                    cboCondicaoPagamento.SelectedValue = oSqlDataReader.Item("codigo_condicao_pagamento")
                    cboFormaPagamento.SelectedValue = oSqlDataReader.Item("codigo_forma_pagamento")
                    cboMoeda.SelectedValue = oSqlDataReader.Item("codigo_moeda")
                    cboModalidadeFrete.SelectedValue = oSqlDataReader.Item("codigo_modalidade_frete")
                    txtCodigoIntegracao.Text = oSqlDataReader.Item("codigo_integracao")
                    txtLimiteCredito.Value = oSqlDataReader.Item("limite_credito")
                    cboInstrucaoCobranca1.SelectedValue = oSqlDataReader.Item("codigo_instrucao1")
                    cboInstrucaoCobranca2.SelectedValue = oSqlDataReader.Item("codigo_instrucao2")
                    If IsDBNull(oSqlDataReader.Item("numero_dias1")) = False Then txtNumeroDias1.Value = oSqlDataReader.Item("numero_dias1")
                    If IsDBNull(oSqlDataReader.Item("numero_dias2")) = False Then txtNumeroDias2.Value = oSqlDataReader.Item("numero_dias2")
                    cboCondicaoPagamentoFornecedor.SelectedValue = oSqlDataReader.Item("codigo_condicao_pagamento_fornecedor")
                    cboFormaPagamentoFornecedor.SelectedValue = oSqlDataReader.Item("codigo_forma_pagamento_fornecedor")
                    cboMoedaFornecedor.SelectedValue = oSqlDataReader.Item("codigo_moeda_fornecedor")
                    cboModalidadeFreteFornecedor.SelectedValue = oSqlDataReader.Item("codigo_modalidade_frete_fornecedor")
                    txtClassificacaoFornecedor.Text = oSqlDataReader.Item("classificacao_fornecedor")
                    cboTipoNegativacao.SelectedValue = oSqlDataReader.Item("codigo_tipo_negativacao")
                    dtpDataNegativacao.Value = IIf(IsDBNull(oSqlDataReader.Item("data_negativacao")), Now.Date, oSqlDataReader.Item("data_negativacao"))
                    txtTextoNegativacao.Text = oSqlDataReader.Item("texto_negativacao")
                    If IsDBNull(oSqlDataReader.Item("enviar_ar")) Then cboEnviarAR.SelectedIndex = -1 Else cboEnviarAR.SelectedValue = oSqlDataReader.Item("enviar_ar")
                    cboDestinacao.SelectedValue = oSqlDataReader.Item("codigo_destinacao")

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

    Public Sub LoadControles(ByVal lCodigoParceiroNegocio As Long,
                             ByVal chkAgenteLogistico As UICheckBox,
                             ByVal chkCliente As UICheckBox,
                             ByVal chkFornecedor As UICheckBox,
                             ByVal chkDespachante As UICheckBox,
                             ByVal cboPersonalidade As UIComboBox,
                             ByVal txtRazaoSocial As MaskedEditBox,
                             ByVal txtNomeFantasia As MaskedEditBox,
                             ByVal cboSegmento As UIComboBox,
                             ByVal cboAtivo As UIComboBox,
                             ByVal txtCnpjCpf As MaskedEditBox,
                             ByVal cboRegimeTributario As UIComboBox,
                             ByVal txtCNAE As MaskedEditBox,
                             ByVal cboTipoInscricaoEstadual As UIComboBox,
                             ByVal txtInscricaoEstadual As MaskedEditBox,
                             ByVal txtInscricaoEstadualSubstitutoTributario As MaskedEditBox,
                             ByVal txtInscricaoMunicipal As MaskedEditBox,
                             ByVal txtInscricaoSuframa As MaskedEditBox,
                             ByVal txtLogradouro As MaskedEditBox,
                             ByVal txtNumero As MaskedEditBox,
                             ByVal txtBairro As MaskedEditBox,
                             ByVal cboMunicipio As UIComboBox,
                             ByVal cboPais As UIComboBox,
                             ByVal cboUF As UIComboBox,
                             ByVal txtComplemento As MaskedEditBox,
                             ByVal txtCEP As MaskedEditBox,
                             ByVal cboVendedor As UIComboBox,
                             ByVal cboVendedorInterno As UIComboBox,
                             ByVal dtpDataFundacao As CalendarCombo,
                             ByVal dtpDataCadastro As CalendarCombo,
                             ByVal txtObservacao As EditBox,
                             ByVal txtTelefone1 As MaskedEditBox,
                             ByVal txtTelefone2 As MaskedEditBox,
                             ByVal txtTelefoneRecado As MaskedEditBox,
                             ByVal txtFax As MaskedEditBox,
                             ByVal txtEmail As MaskedEditBox,
                             ByVal txtEmail2 As MaskedEditBox,
                             ByVal cboCondicaoPagamento As UIComboBox,
                             ByVal cboFormaPagamento As UIComboBox,
                             ByVal cboMoeda As UIComboBox,
                             ByVal cboModalidadeFrete As UIComboBox,
                             ByVal txtCodigoIntegracao As MaskedEditBox,
                             ByVal cboEnviarAR As UIComboBox,
                             ByVal cboCampanha As UIComboBox,
                             ByVal txtNumeroMesesValidadeProduto As NumericEditBox,
                             ByVal cboDestinacao As UIComboBox,
                             ByVal txtLimiteCredito As NumericEditBox,
                             ByVal cboInstrucaoCobranca1 As UIComboBox,
                             ByVal cboInstrucaoCobranca2 As UIComboBox,
                             ByVal txtNumeroDias1 As NumericEditBox,
                             ByVal txtNumeroDias2 As NumericEditBox,
                             ByVal cboCondicaoPagamentoFornecedor As UIComboBox,
                             ByVal cboFormaPagamentoFornecedor As UIComboBox,
                             ByVal cboMoedaFornecedor As UIComboBox,
                             ByVal cboModalidadeFreteFornecedor As UIComboBox,
                             ByVal txtClassificacaoFornecedor As MaskedEditBox,
                             ByVal cboTipoNegativacao As UIComboBox,
                             ByVal dtpDataNegativacao As CalendarCombo,
                             ByVal txtTextoNegativacao As EditBox,
                             ByVal cboBanco As UIComboBox,
                             ByVal txtAgencia As MaskedEditBox,
                             ByVal txtConta As MaskedEditBox,
                             ByVal cboGrupoTecnologia As CheckedComboBox,
                             ByVal cboCategoria As UIComboBox,
                             ByVal txtAliquotaICMS As NumericEditBox,
                             ByVal txtAliquotaIPI As NumericEditBox,
                             ByVal cboIncidePISCOFINS As UIComboBox,
                             ByVal txtAliquotaPIS As NumericEditBox,
                             ByVal txtAliquotaCOFINS As NumericEditBox,
                             ByVal txtAliquotaISS As NumericEditBox,
                             ByVal txtPorcentagemReducaoBCICMS As NumericEditBox,
                             ByVal txtAliquotaICMSReduzida As NumericEditBox,
                             ByVal txtValidadeOrcamento As NumericEditBox,
                             ByVal chkFerramental As UICheckBox,
                             ByVal chkProduto As UICheckBox,
                             ByVal cboUnidadeNegocio As Janus.Windows.GridEX.EditControls.CheckedComboBox,
                             ByVal cboMercado As Janus.Windows.GridEX.EditControls.CheckedComboBox,
                             ByVal chkCelular As UICheckBox,
                             ByVal chkCelular2 As UICheckBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_parceiro_negocio", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    If oSqlDataReader.Item("chk_telefone1") = True Then
                        chkCelular.Checked = True
                    Else
                        chkCelular.Checked = False
                    End If

                    If oSqlDataReader.Item("chk_telefone2") = True Then
                        chkCelular2.Checked = True
                    Else
                        chkCelular2.Checked = False
                    End If

                    txtPorcentagemReducaoBCICMS.Value = oSqlDataReader("porcentagem_reducao_base_calculo_icms")
                    txtAliquotaICMS.Value = oSqlDataReader("aliquota_icms")
                    txtAliquotaICMSReduzida.Value = oSqlDataReader("aliquota_icms_reduzida")
                    txtAliquotaIPI.Value = oSqlDataReader("aliquota_ipi")

                    If IsDBNull(oSqlDataReader("incide_pis_cofins")) Then
                        cboIncidePISCOFINS.SelectedValue = False
                    Else
                        cboIncidePISCOFINS.SelectedValue = oSqlDataReader("incide_pis_cofins")
                    End If

                    txtAliquotaPIS.Value = oSqlDataReader("aliquota_pis")
                    txtAliquotaCOFINS.Value = oSqlDataReader("aliquota_cofins")
                    txtAliquotaISS.Value = oSqlDataReader("aliquota_iss")

                    chkFerramental.Checked = oSqlDataReader("ferramental")
                    chkProduto.Checked = oSqlDataReader("produto")

                    chkAgenteLogistico.Checked = oSqlDataReader.Item("agente_logistico")
                    chkCliente.Checked = oSqlDataReader.Item("cliente")
                    chkFornecedor.Checked = oSqlDataReader.Item("fornecedor")
                    chkDespachante.Checked = oSqlDataReader.Item("despachante")
                    cboPersonalidade.SelectedValue = oSqlDataReader.Item("codigo_personalidade")
                    txtRazaoSocial.Text = oSqlDataReader.Item("razao_social")
                    txtNomeFantasia.Text = oSqlDataReader.Item("nome_fantasia")
                    cboSegmento.SelectedValue = oSqlDataReader.Item("codigo_parceiro_negocio_segmento")
                    cboRegimeTributario.SelectedValue = oSqlDataReader.Item("codigo_regime_tributario")
                    txtCNAE.Text = IIf(IsDBNull(oSqlDataReader.Item("cnae")), "", oSqlDataReader.Item("cnae"))
                    cboAtivo.SelectedValue = oSqlDataReader.Item("ativo")
                    txtCnpjCpf.Text = oSqlDataReader.Item("cnpj_cpf")
                    cboTipoInscricaoEstadual.SelectedValue = oSqlDataReader.Item("codigo_tipo_inscricao_estadual")
                    txtInscricaoEstadual.Text = IIf(IsDBNull(oSqlDataReader.Item("inscricao_estadual")), "", oSqlDataReader.Item("inscricao_estadual"))
                    txtInscricaoEstadualSubstitutoTributario.Text = IIf(IsDBNull(oSqlDataReader.Item("inscricao_estadual_substituto_tributario")), "", oSqlDataReader.Item("inscricao_estadual_substituto_tributario"))
                    txtInscricaoMunicipal.Text = IIf(IsDBNull(oSqlDataReader.Item("inscricao_municipal")), "", oSqlDataReader.Item("inscricao_municipal"))
                    txtInscricaoSuframa.Text = IIf(IsDBNull(oSqlDataReader.Item("inscricao_suframa")), "", oSqlDataReader.Item("inscricao_suframa"))
                    cboPais.SelectedValue = oSqlDataReader.Item("codigo_pais")
                    cboUF.SelectedValue = oSqlDataReader.Item("uf")
                    cboMunicipio.SelectedValue = oSqlDataReader.Item("codigo_municipio")
                    txtLogradouro.Text = oSqlDataReader.Item("logradouro")
                    txtNumero.Text = oSqlDataReader.Item("numero")
                    txtBairro.Text = oSqlDataReader.Item("bairro")
                    txtComplemento.Text = oSqlDataReader.Item("complemento")
                    txtCEP.Text = oSqlDataReader.Item("cep")
                    cboVendedor.SelectedValue = oSqlDataReader.Item("codigo_vendedor")
                    cboVendedorInterno.SelectedValue = oSqlDataReader.Item("codigo_vendedor_interno")
                    If IsDBNull(oSqlDataReader.Item("data_fundacao")) Then
                        dtpDataFundacao.Value = Now.Date : dtpDataFundacao.Checked = False
                    Else
                        dtpDataFundacao.Value = oSqlDataReader.Item("data_fundacao") : dtpDataFundacao.Checked = True
                    End If
                    If IsDBNull(oSqlDataReader.Item("data_cadastro")) Then
                        dtpDataCadastro.Value = Now.Date : dtpDataCadastro.Checked = False
                    Else
                        dtpDataCadastro.Value = oSqlDataReader.Item("data_cadastro") : dtpDataCadastro.Checked = True
                    End If
                    If Not IsDBNull(oSqlDataReader.Item("codigo_campanha")) Then
                        cboCampanha.SelectedValue = oSqlDataReader.Item("codigo_campanha")
                    End If
                    txtNumeroMesesValidadeProduto.Value = oSqlDataReader.Item("numero_meses_validade_produto")
                    txtObservacao.Text = IIf(IsDBNull(oSqlDataReader.Item("observacao")), "", oSqlDataReader.Item("observacao"))
                    txtTelefone1.Text = oSqlDataReader.Item("telefone1")
                    txtTelefone2.Text = oSqlDataReader.Item("telefone2")
                    txtFax.Text = oSqlDataReader.Item("fax")
                    txtTelefoneRecado.Text = oSqlDataReader.Item("telefone_recado")
                    txtEmail.Text = oSqlDataReader.Item("email")
                    txtEmail2.Text = oSqlDataReader.Item("email2")
                    cboCondicaoPagamento.SelectedValue = oSqlDataReader.Item("codigo_condicao_pagamento")
                    cboFormaPagamento.SelectedValue = oSqlDataReader.Item("codigo_forma_pagamento")
                    cboMoeda.SelectedValue = oSqlDataReader.Item("codigo_moeda")
                    cboModalidadeFrete.SelectedValue = oSqlDataReader.Item("codigo_modalidade_frete")
                    txtCodigoIntegracao.Text = oSqlDataReader.Item("codigo_integracao")
                    txtLimiteCredito.Value = oSqlDataReader.Item("limite_credito")

                    If IsDBNull(oSqlDataReader.Item("numero_dias1")) = False Then txtNumeroDias1.Value = oSqlDataReader.Item("numero_dias1")
                    If IsDBNull(oSqlDataReader.Item("numero_dias2")) = False Then txtNumeroDias2.Value = oSqlDataReader.Item("numero_dias2")
                    cboCondicaoPagamentoFornecedor.SelectedValue = oSqlDataReader.Item("codigo_condicao_pagamento_fornecedor")
                    cboFormaPagamentoFornecedor.SelectedValue = oSqlDataReader.Item("codigo_forma_pagamento_fornecedor")
                    cboMoedaFornecedor.SelectedValue = oSqlDataReader.Item("codigo_moeda_fornecedor")
                    cboModalidadeFreteFornecedor.SelectedValue = oSqlDataReader.Item("codigo_modalidade_frete_fornecedor")
                    txtClassificacaoFornecedor.Text = oSqlDataReader.Item("classificacao_fornecedor")
                    cboTipoNegativacao.SelectedValue = oSqlDataReader.Item("codigo_tipo_negativacao")
                    dtpDataNegativacao.Value = IIf(IsDBNull(oSqlDataReader.Item("data_negativacao")), Now.Date, oSqlDataReader.Item("data_negativacao"))
                    txtTextoNegativacao.Text = oSqlDataReader.Item("texto_negativacao")
                    If IsDBNull(oSqlDataReader.Item("enviar_ar")) Then cboEnviarAR.SelectedIndex = -1 Else cboEnviarAR.SelectedValue = oSqlDataReader.Item("enviar_ar")
                    cboDestinacao.SelectedValue = oSqlDataReader.Item("codigo_destinacao")
                    cboBanco.SelectedValue = oSqlDataReader.Item("codigo_banco")
                    txtAgencia.Text = oSqlDataReader.Item("agencia")
                    txtConta.Text = oSqlDataReader.Item("conta")
                    txtValidadeOrcamento.Text = oSqlDataReader.Item("validade_orcamento")

                    If IsDBNull(oSqlDataReader.Item("codigo_instrucao1")) Then
                        cboInstrucaoCobranca1.SelectedIndex = -1
                    Else
                        cboInstrucaoCobranca1.SelectedValue = oSqlDataReader.Item("codigo_instrucao1")
                    End If

                    If IsDBNull(oSqlDataReader.Item("codigo_instrucao2")) Then
                        cboInstrucaoCobranca2.SelectedIndex = -1
                    Else
                        cboInstrucaoCobranca2.SelectedValue = oSqlDataReader.Item("codigo_instrucao2")
                    End If


                    If IsDBNull(oSqlDataReader.Item("codigo_categoria")) Then

                        cboCategoria.SelectedIndex = -1

                    Else

                        cboCategoria.SelectedValue = oSqlDataReader.Item("codigo_categoria")

                    End If

                    If IsDBNull(oSqlDataReader.Item("grupo_tecnologia_texto")) = False Then

                        Dim sVetor() As String = oSqlDataReader.Item("grupo_tecnologia").ToString.Split(",")

                        cboGrupoTecnologia.CheckedValues = oSqlDataReader.Item("grupo_tecnologia").ToString.Split(",")
                        cboGrupoTecnologia.Text = oSqlDataReader.Item("grupo_tecnologia_texto")

                    Else

                        Dim sVetor() As String = oSqlDataReader.Item("grupo_tecnologia").ToString.Split(",")

                        cboGrupoTecnologia.CheckedValues = sVetor
                        cboGrupoTecnologia.Text = ""

                    End If

                    If IsDBNull(oSqlDataReader.Item("unidade_negocio")) = False Then
                        cboUnidadeNegocio.Text = oSqlDataReader.Item("unidade_negocio")
                    Else
                        cboUnidadeNegocio.Text = ""
                    End If

                    If IsDBNull(oSqlDataReader.Item("mercado")) = False Then
                        cboMercado.Text = oSqlDataReader.Item("mercado")
                    Else
                        cboMercado.Text = ""
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

    Public Sub LoadEspacoLeSix(ByVal lCodigoParceiroNegocio As Long, _
                           ByVal txtNacionalidadeCliente As MaskedEditBox, _
                           ByVal txtProfissaoCliente As MaskedEditBox, _
                           ByVal cboEstadoCivilCliente As UIComboBox, _
                           ByVal txtNomeAcompanhante As MaskedEditBox, _
                           ByVal txtProfissaoAcompanhante As MaskedEditBox, _
                           ByVal cboEstadoCivilAcompanhante As UIComboBox, _
                           ByVal txtRGAcompanhante As MaskedEditBox, _
                           ByVal txtCPFAcompanhante As MaskedEditBox, _
                           ByVal txtCEPaAcompanhante As MaskedEditBox, _
                           ByVal cboPaisAcompanhante As UIComboBox, _
                           ByVal cboUFAcompanhante As UIComboBox, _
                           ByVal cboMunicipioAcompanhante As UIComboBox, _
                           ByVal txtLogradouroAcompanhante As MaskedEditBox, _
                           ByVal txtNumeroAcompanhante As MaskedEditBox, _
                           ByVal txtBairroAcompanhante As MaskedEditBox, _
                           ByVal txtComplementoAcompanhante As MaskedEditBox, _
                           ByVal txNacionalidadeAcompanhante As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_parceiro_negocio_norsul", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    txtNacionalidadeCliente.Text = oSqlDataReader.Item("nacionalidade_cliente")
                    txtProfissaoCliente.Text = oSqlDataReader.Item("profissao_cliente")
                    cboEstadoCivilCliente.SelectedValue = oSqlDataReader.Item("codigo_estado_civil_cliente")
                    txtNomeAcompanhante.Text = oSqlDataReader.Item("nome_acompanhante")
                    txtProfissaoAcompanhante.Text = oSqlDataReader.Item("profissao_acompanhante")
                    cboEstadoCivilAcompanhante.SelectedValue = oSqlDataReader.Item("codigo_estado_civil")
                    txtRGAcompanhante.Text = oSqlDataReader.Item("rg")
                    txtCPFAcompanhante.Text = oSqlDataReader.Item("cpf")
                    txtCEPaAcompanhante.Text = oSqlDataReader.Item("cep")
                    cboPaisAcompanhante.SelectedValue = oSqlDataReader.Item("codigo_pais")
                    cboUFAcompanhante.SelectedValue = oSqlDataReader.Item("uf")
                    cboMunicipioAcompanhante.SelectedValue = oSqlDataReader.Item("codigo_municipio")
                    txtLogradouroAcompanhante.Text = oSqlDataReader.Item("logradouro")
                    txtNumeroAcompanhante.Text = oSqlDataReader.Item("numero")
                    txtBairroAcompanhante.Text = oSqlDataReader.Item("bairro")
                    txtComplementoAcompanhante.Text = oSqlDataReader.Item("complemento")
                    txNacionalidadeAcompanhante.Text = oSqlDataReader.Item("nacionalidade")


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


    Public Sub LoadControlesTrakmaq(ByVal lCodigoParceiroNegocio As Long, _
                             ByVal chkAgenteLogistico As UICheckBox, _
                             ByVal chkCliente As UICheckBox, _
                             ByVal chkFornecedor As UICheckBox, _
                             ByVal chkDespachante As UICheckBox, _
                             ByVal cboPersonalidade As UIComboBox, _
                             ByVal txtRazaoSocial As MaskedEditBox, _
                             ByVal txtNomeFantasia As MaskedEditBox, _
                             ByVal cboSegmento As UIComboBox, _
                             ByVal cboAtivo As UIComboBox, _
                             ByVal txtCnpjCpf As MaskedEditBox, _
                             ByVal cboRegimeTributario As UIComboBox, _
                             ByVal txtCNAE As MaskedEditBox, _
                             ByVal cboTipoInscricaoEstadual As UIComboBox, _
                             ByVal txtInscricaoEstadual As MaskedEditBox, _
                             ByVal txtInscricaoEstadualSubstitutoTributario As MaskedEditBox, _
                             ByVal txtInscricaoMunicipal As MaskedEditBox, _
                             ByVal txtInscricaoSuframa As MaskedEditBox, _
                             ByVal txtLogradouro As MaskedEditBox, _
                             ByVal txtNumero As MaskedEditBox, _
                             ByVal txtBairro As MaskedEditBox, _
                             ByVal cboMunicipio As UIComboBox, _
                             ByVal cboPais As UIComboBox, _
                             ByVal cboUF As UIComboBox, _
                             ByVal txtComplemento As MaskedEditBox, _
                             ByVal txtCEP As MaskedEditBox, _
                             ByVal cboVendedor As UIComboBox, _
                             ByVal cboVendedorInterno As UIComboBox, _
                             ByVal dtpDataFundacao As CalendarCombo, _
                             ByVal dtpDataCadastro As CalendarCombo, _
                             ByVal txtObservacao As EditBox, _
                             ByVal txtTelefone1 As MaskedEditBox, _
                             ByVal txtTelefone2 As MaskedEditBox, _
                             ByVal txtTelefoneRecado As MaskedEditBox, _
                             ByVal txtFax As MaskedEditBox, _
                             ByVal txtEmail As MaskedEditBox, _
                             ByVal cboCondicaoPagamento As UIComboBox, _
                             ByVal cboFormaPagamento As UIComboBox, _
                             ByVal cboMoeda As UIComboBox, _
                             ByVal cboModalidadeFrete As UIComboBox, _
                             ByVal txtCodigoIntegracao As MaskedEditBox, _
                             ByVal cboEnviarAR As UIComboBox, _
                             ByVal cboDestinacao As UIComboBox, _
                             ByVal txtLimiteCredito As NumericEditBox, _
                             ByVal txtAvisoTempoCompra As NumericEditBox, _
                             ByVal cboInstrucaoCobranca1 As UIComboBox, _
                             ByVal cboInstrucaoCobranca2 As UIComboBox, _
                             ByVal txtNumeroDias1 As NumericEditBox, _
                             ByVal txtNumeroDias2 As NumericEditBox, _
                             ByVal cboCondicaoPagamentoFornecedor As UIComboBox, _
                             ByVal cboFormaPagamentoFornecedor As UIComboBox, _
                             ByVal cboMoedaFornecedor As UIComboBox, _
                             ByVal cboModalidadeFreteFornecedor As UIComboBox, _
                             ByVal txtClassificacaoFornecedor As MaskedEditBox, _
                             ByVal cboTipoNegativacao As UIComboBox, _
                             ByVal dtpDataNegativacao As CalendarCombo, _
                             ByVal txtTextoNegativacao As EditBox, _
                             ByVal chkCronograma As UICheckBox, _
                             ByVal chkEntregaFisica As UICheckBox, _
                             ByVal chkEntregaEmail As UICheckBox, _
                             ByVal chkPagamentoPontual As UICheckBox, _
                             ByVal txtCodigoProsoft As MaskedEditBox, _
                             ByVal cboEmpresaContrato As UIComboBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_parceiro_negocio", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    txtCodigoProsoft.Text = oSqlDataReader.Item("codigo_prosoft")
                    chkAgenteLogistico.Checked = oSqlDataReader.Item("agente_logistico")
                    chkCliente.Checked = oSqlDataReader.Item("cliente")
                    chkFornecedor.Checked = oSqlDataReader.Item("fornecedor")
                    chkDespachante.Checked = oSqlDataReader.Item("despachante")
                    cboPersonalidade.SelectedValue = oSqlDataReader.Item("codigo_personalidade")
                    txtRazaoSocial.Text = oSqlDataReader.Item("razao_social")
                    txtNomeFantasia.Text = oSqlDataReader.Item("nome_fantasia")
                    cboSegmento.SelectedValue = oSqlDataReader.Item("codigo_parceiro_negocio_segmento")
                    cboRegimeTributario.SelectedValue = oSqlDataReader.Item("codigo_regime_tributario")
                    txtCNAE.Text = IIf(IsDBNull(oSqlDataReader.Item("cnae")), "", oSqlDataReader.Item("cnae"))
                    cboAtivo.SelectedValue = oSqlDataReader.Item("ativo")
                    txtCnpjCpf.Text = oSqlDataReader.Item("cnpj_cpf")
                    cboTipoInscricaoEstadual.SelectedValue = oSqlDataReader.Item("codigo_tipo_inscricao_estadual")
                    txtInscricaoEstadual.Text = IIf(IsDBNull(oSqlDataReader.Item("inscricao_estadual")), "", oSqlDataReader.Item("inscricao_estadual"))
                    txtInscricaoEstadualSubstitutoTributario.Text = IIf(IsDBNull(oSqlDataReader.Item("inscricao_estadual_substituto_tributario")), "", oSqlDataReader.Item("inscricao_estadual_substituto_tributario"))
                    txtInscricaoMunicipal.Text = IIf(IsDBNull(oSqlDataReader.Item("inscricao_municipal")), "", oSqlDataReader.Item("inscricao_municipal"))
                    txtInscricaoSuframa.Text = IIf(IsDBNull(oSqlDataReader.Item("inscricao_suframa")), "", oSqlDataReader.Item("inscricao_suframa"))
                    cboPais.SelectedValue = oSqlDataReader.Item("codigo_pais")
                    cboUF.SelectedValue = oSqlDataReader.Item("uf")
                    cboMunicipio.SelectedValue = oSqlDataReader.Item("codigo_municipio")
                    txtLogradouro.Text = oSqlDataReader.Item("logradouro")
                    txtNumero.Text = oSqlDataReader.Item("numero")
                    txtBairro.Text = oSqlDataReader.Item("bairro")
                    txtComplemento.Text = oSqlDataReader.Item("complemento")
                    txtCEP.Text = oSqlDataReader.Item("cep")
                    cboVendedor.SelectedValue = oSqlDataReader.Item("codigo_vendedor")
                    cboVendedorInterno.SelectedValue = oSqlDataReader.Item("codigo_vendedor_interno")
                    If IsDBNull(oSqlDataReader.Item("data_fundacao")) Then
                        dtpDataFundacao.Value = Now.Date : dtpDataFundacao.Checked = False
                    Else
                        dtpDataFundacao.Value = oSqlDataReader.Item("data_fundacao") : dtpDataFundacao.Checked = True
                    End If
                    If IsDBNull(oSqlDataReader.Item("data_cadastro")) Then
                        dtpDataCadastro.Value = Now.Date : dtpDataCadastro.Checked = False
                    Else
                        dtpDataCadastro.Value = oSqlDataReader.Item("data_cadastro") : dtpDataCadastro.Checked = True
                    End If


                    txtObservacao.Text = IIf(IsDBNull(oSqlDataReader.Item("observacao")), "", oSqlDataReader.Item("observacao"))
                    txtTelefone1.Text = oSqlDataReader.Item("telefone1")
                    txtTelefone2.Text = oSqlDataReader.Item("telefone2")
                    txtFax.Text = oSqlDataReader.Item("fax")
                    txtTelefoneRecado.Text = oSqlDataReader.Item("telefone_recado")
                    txtEmail.Text = oSqlDataReader.Item("email")
                    cboCondicaoPagamento.SelectedValue = oSqlDataReader.Item("codigo_condicao_pagamento")
                    cboFormaPagamento.SelectedValue = oSqlDataReader.Item("codigo_forma_pagamento")
                    cboMoeda.SelectedValue = oSqlDataReader.Item("codigo_moeda")
                    cboModalidadeFrete.SelectedValue = oSqlDataReader.Item("codigo_modalidade_frete")
                    txtCodigoIntegracao.Text = oSqlDataReader.Item("codigo_integracao")
                    txtLimiteCredito.Value = oSqlDataReader.Item("limite_credito")
                    cboInstrucaoCobranca1.SelectedValue = oSqlDataReader.Item("codigo_instrucao1")
                    cboInstrucaoCobranca2.SelectedValue = oSqlDataReader.Item("codigo_instrucao2")
                    If IsDBNull(oSqlDataReader.Item("numero_dias1")) = False Then txtNumeroDias1.Value = oSqlDataReader.Item("numero_dias1")
                    If IsDBNull(oSqlDataReader.Item("numero_dias2")) = False Then txtNumeroDias2.Value = oSqlDataReader.Item("numero_dias2")
                    cboCondicaoPagamentoFornecedor.SelectedValue = oSqlDataReader.Item("codigo_condicao_pagamento_fornecedor")
                    cboFormaPagamentoFornecedor.SelectedValue = oSqlDataReader.Item("codigo_forma_pagamento_fornecedor")
                    cboMoedaFornecedor.SelectedValue = oSqlDataReader.Item("codigo_moeda_fornecedor")
                    cboModalidadeFreteFornecedor.SelectedValue = oSqlDataReader.Item("codigo_modalidade_frete_fornecedor")
                    txtClassificacaoFornecedor.Text = oSqlDataReader.Item("classificacao_fornecedor")
                    cboTipoNegativacao.SelectedValue = oSqlDataReader.Item("codigo_tipo_negativacao")
                    dtpDataNegativacao.Value = IIf(IsDBNull(oSqlDataReader.Item("data_negativacao")), Now.Date, oSqlDataReader.Item("data_negativacao"))
                    txtTextoNegativacao.Text = oSqlDataReader.Item("texto_negativacao")
                    If IsDBNull(oSqlDataReader.Item("enviar_ar")) Then cboEnviarAR.SelectedIndex = -1 Else cboEnviarAR.SelectedValue = oSqlDataReader.Item("enviar_ar")
                    cboDestinacao.SelectedValue = oSqlDataReader.Item("codigo_destinacao")
                    If goDatabase.sInitialCatalog = "INTERACTI_ASCON_PRD" Then
                        chkCronograma.Checked = oSqlDataReader.Item("cronograma")
                    End If
                    If bSistemaPerforma = True Then
                        txtAvisoTempoCompra.Value = oSqlDataReader.Item("aviso_tempo_compra")
                    End If
                    If goDatabase.sInitialCatalog = "INTERACTI_ASCON_PRD" Then
                        chkEntregaFisica.Checked = oSqlDataReader.Item("entrega_fisica")
                        chkEntregaEmail.Checked = oSqlDataReader.Item("entrega_email")
                        chkPagamentoPontual.Checked = oSqlDataReader.Item("pagamento_pontual")
                        cboEmpresaContrato.SelectedValue = oSqlDataReader.Item("codigo_empresa_contrato")
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


    Public Sub LoadControlesNFE(ByVal lCodigoParceiroNegocio As Long, _
                             ByVal chkAgenteLogistico As UICheckBox, _
                             ByVal chkCliente As UICheckBox, _
                             ByVal chkFornecedor As UICheckBox, _
                             ByVal chkDespachante As UICheckBox, _
                             ByVal cboPersonalidade As UIComboBox, _
                             ByVal txtRazaoSocial As MaskedEditBox, _
                             ByVal txtNomeFantasia As MaskedEditBox, _
                             ByVal cboSegmento As UIComboBox, _
                             ByVal cboAtivo As UIComboBox, _
                             ByVal txtCnpjCpf As MaskedEditBox, _
                             ByVal cboRegimeTributario As UIComboBox, _
                             ByVal txtCNAE As MaskedEditBox, _
                             ByVal cboTipoInscricaoEstadual As UIComboBox, _
                             ByVal txtInscricaoEstadual As MaskedEditBox, _
                             ByVal txtInscricaoEstadualSubstitutoTributario As MaskedEditBox, _
                             ByVal txtInscricaoMunicipal As MaskedEditBox, _
                             ByVal txtInscricaoSuframa As MaskedEditBox, _
                             ByVal txtLogradouro As MaskedEditBox, _
                             ByVal txtNumero As MaskedEditBox, _
                             ByVal txtBairro As MaskedEditBox, _
                             ByVal cboMunicipio As UIComboBox, _
                             ByVal cboPais As UIComboBox, _
                             ByVal cboUF As UIComboBox, _
                             ByVal txtComplemento As MaskedEditBox, _
                             ByVal txtCEP As MaskedEditBox, _
                             ByVal txtObservacao As EditBox, _
                             ByVal txtTelefone1 As MaskedEditBox, _
                             ByVal txtTelefone2 As MaskedEditBox, _
                             ByVal txtEmail As MaskedEditBox, _
                             ByVal txtLimiteCredito As NumericEditBox, _
                             ByVal txtAvisoTempoCompra As NumericEditBox, _
                             ByVal cboCentroGasto As UIComboBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_parceiro_negocio", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    chkAgenteLogistico.Checked = oSqlDataReader.Item("agente_logistico")
                    chkCliente.Checked = oSqlDataReader.Item("cliente")
                    chkFornecedor.Checked = oSqlDataReader.Item("fornecedor")
                    chkDespachante.Checked = oSqlDataReader.Item("despachante")
                    cboPersonalidade.SelectedValue = oSqlDataReader.Item("codigo_personalidade")
                    txtRazaoSocial.Text = oSqlDataReader.Item("razao_social")
                    txtNomeFantasia.Text = oSqlDataReader.Item("nome_fantasia")
                    cboSegmento.SelectedValue = oSqlDataReader.Item("codigo_parceiro_negocio_segmento")
                    cboRegimeTributario.SelectedValue = oSqlDataReader.Item("codigo_regime_tributario")
                    txtCNAE.Text = IIf(IsDBNull(oSqlDataReader.Item("cnae")), "", oSqlDataReader.Item("cnae"))
                    cboAtivo.SelectedValue = oSqlDataReader.Item("ativo")
                    txtCnpjCpf.Text = oSqlDataReader.Item("cnpj_cpf")
                    cboTipoInscricaoEstadual.SelectedValue = oSqlDataReader.Item("codigo_tipo_inscricao_estadual")
                    txtInscricaoEstadual.Text = IIf(IsDBNull(oSqlDataReader.Item("inscricao_estadual")), "", oSqlDataReader.Item("inscricao_estadual"))
                    txtInscricaoEstadualSubstitutoTributario.Text = IIf(IsDBNull(oSqlDataReader.Item("inscricao_estadual_substituto_tributario")), "", oSqlDataReader.Item("inscricao_estadual_substituto_tributario"))
                    txtInscricaoMunicipal.Text = IIf(IsDBNull(oSqlDataReader.Item("inscricao_municipal")), "", oSqlDataReader.Item("inscricao_municipal"))
                    txtInscricaoSuframa.Text = IIf(IsDBNull(oSqlDataReader.Item("inscricao_suframa")), "", oSqlDataReader.Item("inscricao_suframa"))
                    cboPais.SelectedValue = oSqlDataReader.Item("codigo_pais")
                    cboUF.SelectedValue = oSqlDataReader.Item("uf")
                    cboMunicipio.SelectedValue = oSqlDataReader.Item("codigo_municipio")
                    txtLogradouro.Text = oSqlDataReader.Item("logradouro")
                    txtNumero.Text = oSqlDataReader.Item("numero")
                    txtBairro.Text = oSqlDataReader.Item("bairro")
                    txtComplemento.Text = oSqlDataReader.Item("complemento")
                    txtCEP.Text = oSqlDataReader.Item("cep")
                    txtObservacao.Text = IIf(IsDBNull(oSqlDataReader.Item("observacao")), "", oSqlDataReader.Item("observacao"))
                    txtTelefone1.Text = oSqlDataReader.Item("telefone1")
                    txtTelefone2.Text = oSqlDataReader.Item("telefone2")
                    txtEmail.Text = oSqlDataReader.Item("email")
                    txtAvisoTempoCompra.Value = oSqlDataReader.Item("aviso_tempo_compra")
                    txtLimiteCredito.Value = oSqlDataReader.Item("limite_credito")
                    cboCentroGasto.SelectedValue = oSqlDataReader.Item("codigo_centro_gasto")

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


    Public Sub LoadControles(ByVal lCodigoParceiroNegocio As Long, _
                             ByVal chkAgenteLogistico As UICheckBox, _
                             ByVal chkCliente As UICheckBox, _
                             ByVal chkFornecedor As UICheckBox, _
                             ByVal chkDespachante As UICheckBox, _
                             ByVal cboPersonalidade As UIComboBox, _
                             ByVal txtRazaoSocial As MaskedEditBox, _
                             ByVal txtNomeFantasia As MaskedEditBox, _
                             ByVal cboSegmento As UIComboBox, _
                             ByVal cboAtivo As UIComboBox, _
                             ByVal txtCnpjCpf As MaskedEditBox, _
                             ByVal cboRegimeTributario As UIComboBox, _
                             ByVal txtCNAE As MaskedEditBox, _
                             ByVal cboTipoInscricaoEstadual As UIComboBox, _
                             ByVal txtInscricaoEstadual As MaskedEditBox, _
                             ByVal txtInscricaoEstadualSubstitutoTributario As MaskedEditBox, _
                             ByVal txtInscricaoMunicipal As MaskedEditBox, _
                             ByVal txtInscricaoSuframa As MaskedEditBox, _
                             ByVal txtLogradouro As MaskedEditBox, _
                             ByVal txtNumero As MaskedEditBox, _
                             ByVal txtBairro As MaskedEditBox, _
                             ByVal cboMunicipio As UIComboBox, _
                             ByVal cboPais As UIComboBox, _
                             ByVal cboUF As UIComboBox, _
                             ByVal txtComplemento As MaskedEditBox, _
                             ByVal txtCEP As MaskedEditBox, _
                             ByVal cboVendedor As UIComboBox, _
                             ByVal cboVendedorInterno As UIComboBox, _
                             ByVal dtpDataFundacao As CalendarCombo, _
                             ByVal dtpDataCadastro As CalendarCombo, _
                             ByVal txtObservacao As EditBox, _
                             ByVal txtTelefone1 As MaskedEditBox, _
                             ByVal txtTelefone2 As MaskedEditBox, _
                             ByVal txtTelefoneRecado As MaskedEditBox, _
                             ByVal txtFax As MaskedEditBox, _
                             ByVal txtEmail As MaskedEditBox, _
                             ByVal cboCondicaoPagamento As UIComboBox, _
                             ByVal cboFormaPagamento As UIComboBox, _
                             ByVal cboMoeda As UIComboBox, _
                             ByVal cboModalidadeFrete As UIComboBox, _
                             ByVal txtCodigoIntegracao As MaskedEditBox, _
                             ByVal cboEnviarAR As UIComboBox, _
                             ByVal cboCampanha As UIComboBox, _
                             ByVal txtNumeroMesesValidadeProduto As NumericEditBox, _
                             ByVal cboDestinacao As UIComboBox, _
                             ByVal txtLimiteCredito As NumericEditBox, _
                             ByVal cboInstrucaoCobranca1 As UIComboBox, _
                             ByVal cboInstrucaoCobranca2 As UIComboBox, _
                             ByVal txtNumeroDias1 As NumericEditBox, _
                             ByVal txtNumeroDias2 As NumericEditBox, _
                             ByVal cboCondicaoPagamentoFornecedor As UIComboBox, _
                             ByVal cboFormaPagamentoFornecedor As UIComboBox, _
                             ByVal cboMoedaFornecedor As UIComboBox, _
                             ByVal cboModalidadeFreteFornecedor As UIComboBox, _
                             ByVal txtClassificacaoFornecedor As MaskedEditBox, _
                             ByVal cboTipoNegativacao As UIComboBox, _
                             ByVal dtpDataNegativacao As CalendarCombo, _
                             ByVal txtTextoNegativacao As EditBox, _
                             ByVal txtCodigoFornecedor As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_parceiro_negocio", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    chkAgenteLogistico.Checked = oSqlDataReader.Item("agente_logistico")
                    chkCliente.Checked = oSqlDataReader.Item("cliente")
                    chkFornecedor.Checked = oSqlDataReader.Item("fornecedor")
                    chkDespachante.Checked = oSqlDataReader.Item("despachante")
                    cboPersonalidade.SelectedValue = oSqlDataReader.Item("codigo_personalidade")
                    txtRazaoSocial.Text = oSqlDataReader.Item("razao_social")
                    txtNomeFantasia.Text = oSqlDataReader.Item("nome_fantasia")
                    cboSegmento.SelectedValue = oSqlDataReader.Item("codigo_parceiro_negocio_segmento")
                    cboRegimeTributario.SelectedValue = oSqlDataReader.Item("codigo_regime_tributario")
                    txtCNAE.Text = IIf(IsDBNull(oSqlDataReader.Item("cnae")), "", oSqlDataReader.Item("cnae"))
                    cboAtivo.SelectedValue = oSqlDataReader.Item("ativo")
                    txtCnpjCpf.Text = oSqlDataReader.Item("cnpj_cpf")
                    cboTipoInscricaoEstadual.SelectedValue = oSqlDataReader.Item("codigo_tipo_inscricao_estadual")
                    txtInscricaoEstadual.Text = IIf(IsDBNull(oSqlDataReader.Item("inscricao_estadual")), "", oSqlDataReader.Item("inscricao_estadual"))
                    txtInscricaoEstadualSubstitutoTributario.Text = IIf(IsDBNull(oSqlDataReader.Item("inscricao_estadual_substituto_tributario")), "", oSqlDataReader.Item("inscricao_estadual_substituto_tributario"))
                    txtInscricaoMunicipal.Text = IIf(IsDBNull(oSqlDataReader.Item("inscricao_municipal")), "", oSqlDataReader.Item("inscricao_municipal"))
                    txtInscricaoSuframa.Text = IIf(IsDBNull(oSqlDataReader.Item("inscricao_suframa")), "", oSqlDataReader.Item("inscricao_suframa"))
                    cboPais.SelectedValue = oSqlDataReader.Item("codigo_pais")
                    cboUF.SelectedValue = oSqlDataReader.Item("uf")
                    cboMunicipio.SelectedValue = oSqlDataReader.Item("codigo_municipio")
                    txtLogradouro.Text = oSqlDataReader.Item("logradouro")
                    txtNumero.Text = oSqlDataReader.Item("numero")
                    txtBairro.Text = oSqlDataReader.Item("bairro")
                    txtComplemento.Text = oSqlDataReader.Item("complemento")
                    txtCEP.Text = oSqlDataReader.Item("cep")
                    cboVendedor.SelectedValue = oSqlDataReader.Item("codigo_vendedor")
                    cboVendedorInterno.SelectedValue = oSqlDataReader.Item("codigo_vendedor_interno")
                    If IsDBNull(oSqlDataReader.Item("data_fundacao")) Then
                        dtpDataFundacao.Value = Now.Date : dtpDataFundacao.Checked = False
                    Else
                        dtpDataFundacao.Value = oSqlDataReader.Item("data_fundacao") : dtpDataFundacao.Checked = True
                    End If
                    If IsDBNull(oSqlDataReader.Item("data_cadastro")) Then
                        dtpDataCadastro.Value = Now.Date : dtpDataCadastro.Checked = False
                    Else
                        dtpDataCadastro.Value = oSqlDataReader.Item("data_cadastro") : dtpDataCadastro.Checked = True
                    End If
                    txtObservacao.Text = IIf(IsDBNull(oSqlDataReader.Item("observacao")), "", oSqlDataReader.Item("observacao"))
                    txtTelefone1.Text = oSqlDataReader.Item("telefone1")
                    txtTelefone2.Text = oSqlDataReader.Item("telefone2")
                    txtFax.Text = oSqlDataReader.Item("fax")
                    txtTelefoneRecado.Text = oSqlDataReader.Item("telefone_recado")
                    txtEmail.Text = oSqlDataReader.Item("email")
                    cboCondicaoPagamento.SelectedValue = oSqlDataReader.Item("codigo_condicao_pagamento")
                    cboFormaPagamento.SelectedValue = oSqlDataReader.Item("codigo_forma_pagamento")
                    cboMoeda.SelectedValue = oSqlDataReader.Item("codigo_moeda")
                    cboModalidadeFrete.SelectedValue = oSqlDataReader.Item("codigo_modalidade_frete")
                    txtCodigoIntegracao.Text = oSqlDataReader.Item("codigo_integracao")
                    txtLimiteCredito.Value = oSqlDataReader.Item("limite_credito")
                    cboInstrucaoCobranca1.SelectedValue = oSqlDataReader.Item("codigo_instrucao1")
                    cboInstrucaoCobranca2.SelectedValue = oSqlDataReader.Item("codigo_instrucao2")
                    If IsDBNull(oSqlDataReader.Item("numero_dias1")) = False Then txtNumeroDias1.Value = oSqlDataReader.Item("numero_dias1")
                    If IsDBNull(oSqlDataReader.Item("numero_dias2")) = False Then txtNumeroDias2.Value = oSqlDataReader.Item("numero_dias2")
                    cboCondicaoPagamentoFornecedor.SelectedValue = oSqlDataReader.Item("codigo_condicao_pagamento_fornecedor")
                    cboFormaPagamentoFornecedor.SelectedValue = oSqlDataReader.Item("codigo_forma_pagamento_fornecedor")
                    cboMoedaFornecedor.SelectedValue = oSqlDataReader.Item("codigo_moeda_fornecedor")
                    cboModalidadeFreteFornecedor.SelectedValue = oSqlDataReader.Item("codigo_modalidade_frete_fornecedor")
                    txtClassificacaoFornecedor.Text = oSqlDataReader.Item("classificacao_fornecedor")
                    cboTipoNegativacao.SelectedValue = oSqlDataReader.Item("codigo_tipo_negativacao")
                    dtpDataNegativacao.Value = IIf(IsDBNull(oSqlDataReader.Item("data_negativacao")), Now.Date, oSqlDataReader.Item("data_negativacao"))
                    txtTextoNegativacao.Text = oSqlDataReader.Item("texto_negativacao")
                    If IsDBNull(oSqlDataReader.Item("enviar_ar")) Then cboEnviarAR.SelectedIndex = -1 Else cboEnviarAR.SelectedValue = oSqlDataReader.Item("enviar_ar")
                    If IsDBNull(oSqlDataReader.Item("codigo_campanha")) Then cboCampanha.SelectedIndex = -1 Else cboCampanha.SelectedValue = oSqlDataReader.Item("codigo_campanha")
                    cboDestinacao.SelectedValue = oSqlDataReader.Item("codigo_destinacao")
                    txtNumeroMesesValidadeProduto.Value = oSqlDataReader.Item("numero_meses_validade_produto")
                    txtCodigoFornecedor.Text = oSqlDataReader.Item("codigo_fornecedor")

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

    Public Sub LoadControles(ByVal lCodigoParceiroNegocio As Long, _
                             ByVal chkAgenteLogistico As UICheckBox, _
                             ByVal chkCliente As UICheckBox, _
                             ByVal chkFornecedor As UICheckBox, _
                             ByVal chkDespachante As UICheckBox, _
                             ByVal cboPersonalidade As UIComboBox, _
                             ByVal txtRazaoSocial As MaskedEditBox, _
                             ByVal txtNomeFantasia As MaskedEditBox, _
                             ByVal txtSigla As MaskedEditBox, _
                             ByVal cboSegmento As UIComboBox, _
                             ByVal cboAtivo As UIComboBox, _
                             ByVal txtCnpjCpf As MaskedEditBox, _
                             ByVal cboRegimeTributario As UIComboBox, _
                             ByVal txtCNAE As MaskedEditBox, _
                             ByVal txtInscricaoEstadual As MaskedEditBox, _
                             ByVal txtInscricaoEstadualSubstitutoTributario As MaskedEditBox, _
                             ByVal txtInscricaoMunicipal As MaskedEditBox, _
                             ByVal txtInscricaoSuframa As MaskedEditBox, _
                             ByVal txtLogradouro As MaskedEditBox, _
                             ByVal txtNumero As MaskedEditBox, _
                             ByVal txtBairro As MaskedEditBox, _
                             ByVal cboMunicipio As UIComboBox, _
                             ByVal cboPais As UIComboBox, _
                             ByVal cboUF As UIComboBox, _
                             ByVal txtComplemento As MaskedEditBox, _
                             ByVal txtCEP As MaskedEditBox, _
                             ByVal cboVendedor As UIComboBox, _
                             ByVal cboVendedorInterno As UIComboBox, _
                             ByVal dtpDataFundacao As CalendarCombo, _
                             ByVal dtpDataCadastro As CalendarCombo, _
                             ByVal txtObservacao As EditBox, _
                             ByVal txtTelefone1 As MaskedEditBox, _
                             ByVal txtTelefone2 As MaskedEditBox, _
                             ByVal txtTelefoneRecado As MaskedEditBox, _
                             ByVal txtFax As MaskedEditBox, _
                             ByVal txtEmail As MaskedEditBox, _
                             ByVal cboCondicaoPagamento As UIComboBox, _
                             ByVal cboFormaPagamento As UIComboBox, _
                             ByVal cboMoeda As UIComboBox, _
                             ByVal cboModalidadeFrete As UIComboBox, _
                             ByVal txtCodigoIntegracao As MaskedEditBox, _
                             ByVal cboEnviarAR As UIComboBox, _
                             ByVal cboCampanha As UIComboBox, _
                             ByVal txtNumeroMesesValidadeProduto As NumericEditBox, _
                             ByVal cboDestinacao As UIComboBox, _
                             ByVal txtLimiteCredito As NumericEditBox, _
                             ByVal cboInstrucaoCobranca1 As UIComboBox, _
                             ByVal cboInstrucaoCobranca2 As UIComboBox, _
                             ByVal txtNumeroDias1 As NumericEditBox, _
                             ByVal txtNumeroDias2 As NumericEditBox, _
                             ByVal cboCondicaoPagamentoFornecedor As UIComboBox, _
                             ByVal cboFormaPagamentoFornecedor As UIComboBox, _
                             ByVal cboMoedaFornecedor As UIComboBox, _
                             ByVal cboModalidadeFreteFornecedor As UIComboBox, _
                             ByVal txtClassificacaoFornecedor As MaskedEditBox, _
                             ByVal cboTipoNegativacao As UIComboBox, _
                             ByVal dtpDataNegativacao As CalendarCombo, _
                             ByVal txtTextoNegativacao As EditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_parceiro_negocio", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    chkAgenteLogistico.Checked = oSqlDataReader.Item("agente_logistico")
                    chkCliente.Checked = oSqlDataReader.Item("cliente")
                    chkFornecedor.Checked = oSqlDataReader.Item("fornecedor")
                    chkDespachante.Checked = oSqlDataReader.Item("despachante")
                    cboPersonalidade.SelectedValue = oSqlDataReader.Item("codigo_personalidade")
                    txtRazaoSocial.Text = oSqlDataReader.Item("razao_social")
                    txtNomeFantasia.Text = oSqlDataReader.Item("nome_fantasia")
                    txtSigla.Text = oSqlDataReader.Item("sigla")
                    cboSegmento.SelectedValue = oSqlDataReader.Item("codigo_parceiro_negocio_segmento")
                    cboRegimeTributario.SelectedValue = oSqlDataReader.Item("codigo_regime_tributario")
                    txtCNAE.Text = IIf(IsDBNull(oSqlDataReader.Item("cnae")), "", oSqlDataReader.Item("cnae"))
                    cboAtivo.SelectedValue = oSqlDataReader.Item("ativo")
                    txtCnpjCpf.Text = oSqlDataReader.Item("cnpj_cpf")
                    txtInscricaoEstadual.Text = IIf(IsDBNull(oSqlDataReader.Item("inscricao_estadual")), "", oSqlDataReader.Item("inscricao_estadual"))
                    txtInscricaoEstadualSubstitutoTributario.Text = IIf(IsDBNull(oSqlDataReader.Item("inscricao_estadual_substituto_tributario")), "", oSqlDataReader.Item("inscricao_estadual_substituto_tributario"))
                    txtInscricaoMunicipal.Text = IIf(IsDBNull(oSqlDataReader.Item("inscricao_municipal")), "", oSqlDataReader.Item("inscricao_municipal"))
                    txtInscricaoSuframa.Text = IIf(IsDBNull(oSqlDataReader.Item("inscricao_suframa")), "", oSqlDataReader.Item("inscricao_suframa"))
                    cboPais.SelectedValue = oSqlDataReader.Item("codigo_pais")
                    cboUF.SelectedValue = oSqlDataReader.Item("uf")
                    cboMunicipio.SelectedValue = oSqlDataReader.Item("codigo_municipio")
                    txtLogradouro.Text = oSqlDataReader.Item("logradouro")
                    txtNumero.Text = oSqlDataReader.Item("numero")
                    txtBairro.Text = oSqlDataReader.Item("bairro")
                    txtComplemento.Text = oSqlDataReader.Item("complemento")
                    txtCEP.Text = oSqlDataReader.Item("cep")
                    cboVendedor.SelectedValue = oSqlDataReader.Item("codigo_vendedor")
                    cboVendedorInterno.SelectedValue = oSqlDataReader.Item("codigo_vendedor_interno")
                    If IsDBNull(oSqlDataReader.Item("data_fundacao")) Then
                        dtpDataFundacao.Value = Now.Date : dtpDataFundacao.Checked = False
                    Else
                        dtpDataFundacao.Value = oSqlDataReader.Item("data_fundacao") : dtpDataFundacao.Checked = True
                    End If
                    If IsDBNull(oSqlDataReader.Item("data_cadastro")) Then
                        dtpDataCadastro.Value = Now.Date : dtpDataCadastro.Checked = False
                    Else
                        dtpDataCadastro.Value = oSqlDataReader.Item("data_cadastro") : dtpDataCadastro.Checked = True
                    End If
                    txtObservacao.Text = IIf(IsDBNull(oSqlDataReader.Item("observacao")), "", oSqlDataReader.Item("observacao"))
                    txtTelefone1.Text = oSqlDataReader.Item("telefone1")
                    txtTelefone2.Text = oSqlDataReader.Item("telefone2")
                    txtFax.Text = oSqlDataReader.Item("fax")
                    txtTelefoneRecado.Text = oSqlDataReader.Item("telefone_recado")
                    txtEmail.Text = oSqlDataReader.Item("email")
                    cboCondicaoPagamento.SelectedValue = oSqlDataReader.Item("codigo_condicao_pagamento")
                    cboFormaPagamento.SelectedValue = oSqlDataReader.Item("codigo_forma_pagamento")
                    cboMoeda.SelectedValue = oSqlDataReader.Item("codigo_moeda")
                    cboModalidadeFrete.SelectedValue = oSqlDataReader.Item("codigo_modalidade_frete")
                    txtCodigoIntegracao.Text = oSqlDataReader.Item("codigo_integracao")
                    txtLimiteCredito.Value = oSqlDataReader.Item("limite_credito")
                    cboInstrucaoCobranca1.SelectedValue = oSqlDataReader.Item("codigo_instrucao1")
                    cboInstrucaoCobranca2.SelectedValue = oSqlDataReader.Item("codigo_instrucao2")
                    If IsDBNull(oSqlDataReader.Item("numero_dias1")) = False Then txtNumeroDias1.Value = oSqlDataReader.Item("numero_dias1")
                    If IsDBNull(oSqlDataReader.Item("numero_dias2")) = False Then txtNumeroDias2.Value = oSqlDataReader.Item("numero_dias2")
                    cboCondicaoPagamentoFornecedor.SelectedValue = oSqlDataReader.Item("codigo_condicao_pagamento_fornecedor")
                    cboFormaPagamentoFornecedor.SelectedValue = oSqlDataReader.Item("codigo_forma_pagamento_fornecedor")
                    cboMoedaFornecedor.SelectedValue = oSqlDataReader.Item("codigo_moeda_fornecedor")
                    cboModalidadeFreteFornecedor.SelectedValue = oSqlDataReader.Item("codigo_modalidade_frete_fornecedor")
                    txtClassificacaoFornecedor.Text = oSqlDataReader.Item("classificacao_fornecedor")
                    cboTipoNegativacao.SelectedValue = oSqlDataReader.Item("codigo_tipo_negativacao")
                    dtpDataNegativacao.Value = IIf(IsDBNull(oSqlDataReader.Item("data_negativacao")), Now.Date, oSqlDataReader.Item("data_negativacao"))
                    txtTextoNegativacao.Text = oSqlDataReader.Item("texto_negativacao")
                    If IsDBNull(oSqlDataReader.Item("enviar_ar")) Then cboEnviarAR.SelectedIndex = -1 Else cboEnviarAR.SelectedValue = oSqlDataReader.Item("enviar_ar")
                    cboDestinacao.SelectedValue = oSqlDataReader.Item("codigo_destinacao")

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

    Public Sub LoadControles(ByVal lCodigoParceiroNegocio As Long, _
                             ByVal txtCnpjCpf As MaskedEditBox, _
                             ByVal txtRazaoSocial As MaskedEditBox, _
                             ByVal txtUF As MaskedEditBox, _
                             ByVal txtMunicipio As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_parceiro_negocio", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    txtCnpjCpf.Text = oSqlDataReader.Item("cnpj_cpf")
                    txtRazaoSocial.Text = oSqlDataReader.Item("razao_social")
                    txtUF.Text = oSqlDataReader.Item("uf")
                    txtMunicipio.Text = oSqlDataReader.Item("municipio")

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

    Public Sub LoadControles(ByVal lCodigoParceiroNegocio As Long, _
                             ByVal chkAgenteLogistico As UICheckBox, _
                             ByVal chkCliente As UICheckBox, _
                             ByVal chkFornecedor As UICheckBox, _
                             ByVal chkDespachante As UICheckBox, _
                             ByVal txtPersonalidade As MaskedEditBox, _
                             ByVal txtRazaoSocial As MaskedEditBox, _
                             ByVal txtNomeFantasia As MaskedEditBox, _
                             ByVal txtSegmento As MaskedEditBox, _
                             ByVal cboAtivo As UIComboBox, _
                             ByVal txtRegimeTributario As MaskedEditBox, _
                             ByVal txtCNAE As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_parceiro_negocio", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    chkAgenteLogistico.Checked = oSqlDataReader.Item("agente_logistico")
                    chkCliente.Checked = oSqlDataReader.Item("cliente")
                    chkFornecedor.Checked = oSqlDataReader.Item("fornecedor")
                    chkDespachante.Checked = oSqlDataReader.Item("despachante")
                    txtPersonalidade.Text = oSqlDataReader.Item("personalidade")
                    txtRazaoSocial.Text = oSqlDataReader.Item("razao_social")
                    txtNomeFantasia.Text = oSqlDataReader.Item("nome_fantasia")
                    txtSegmento.Text = oSqlDataReader.Item("segmento")
                    txtRegimeTributario.Text = oSqlDataReader.Item("regime_tributario")
                    txtCNAE.Text = IIf(IsDBNull(oSqlDataReader.Item("cnae")), "", oSqlDataReader.Item("cnae"))
                    cboAtivo.SelectedValue = oSqlDataReader.Item("ativo")

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

    Public Function EmailParceiroNegocio(ByVal lCodigoParceiroNegocio As Long) As String

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim sReturn As String = ""
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_parceiro_negocio_email", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    If oSqlDataReader.Item("codigo_personalidade") = modDeclaration.Personalidade.Fisica Then
                        sReturn = "PERSONALIDADE: FÍSICA" & vbCrLf
                        sReturn &= "NOME: " & oSqlDataReader.Item("razao_social") & vbCrLf
                        sReturn &= "CPF: " & oSqlDataReader.Item("cnpj_cpf") & vbCrLf
                        sReturn &= "RG: " & IIf(IsDBNull(oSqlDataReader.Item("inscricao_estadual")), "", oSqlDataReader.Item("inscricao_estadual")) & vbCrLf
                    Else
                        sReturn = "PERSONALIDADE: JURIDICA" & vbCrLf
                        sReturn &= "RAZÃO SOCIAL: " & oSqlDataReader.Item("razao_social") & vbCrLf
                        sReturn &= "NOME FANTASIA: " & oSqlDataReader.Item("nome_fantasia") & vbCrLf
                        sReturn &= "CNPJ: " & oSqlDataReader.Item("cnpj_cpf") & vbCrLf
                        sReturn &= "INSCRIÇÃO ESTADUAL: " & IIf(IsDBNull(oSqlDataReader.Item("inscricao_estadual")), "", oSqlDataReader.Item("inscricao_estadual")) & vbCrLf
                        sReturn &= "INSCRIÇÃO MUNICIPAL: " & IIf(IsDBNull(oSqlDataReader.Item("inscricao_municipal")), "", oSqlDataReader.Item("inscricao_municipal")) & vbCrLf
                        sReturn &= "INSCRIÇÃO SUFRAMA: " & IIf(IsDBNull(oSqlDataReader.Item("inscricao_suframa")), "", oSqlDataReader.Item("inscricao_suframa")) & vbCrLf
                        sReturn &= "CNAE: " & IIf(IsDBNull(oSqlDataReader.Item("cnae")), "", oSqlDataReader.Item("cnae")) & vbCrLf
                    End If
                    sReturn &= "UF: " & oSqlDataReader.Item("uf") & vbCrLf
                    sReturn &= "MUNICÍPIO: " & oSqlDataReader.Item("municipio") & vbCrLf
                    sReturn &= "LOGRADOURO: " & oSqlDataReader.Item("logradouro") & vbCrLf
                    sReturn &= "NÚMERO: " & oSqlDataReader.Item("numero") & vbCrLf
                    sReturn &= "BAIRRO: " & oSqlDataReader.Item("bairro") & vbCrLf
                    sReturn &= "COMPLEMENTO: " & oSqlDataReader.Item("complemento") & vbCrLf
                    sReturn &= "Telefone 1: " & oSqlDataReader.Item("telefone1") & vbCrLf
                    sReturn &= "Telefone 2: " & oSqlDataReader.Item("telefone1") & vbCrLf
                    sReturn &= "FAX: " & oSqlDataReader.Item("fax") & vbCrLf
                    sReturn &= "TELEFONE DE RECADO: " & oSqlDataReader.Item("recado") & vbCrLf

                End While

            End If

            'Fecha o DataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Return sReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub LoadGridPedidoCompra(ByVal oGrid As GridEX, _
                                 ByVal lCodigoParceiroNegocio As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_pedido_compra", oSqlParameter)

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

    Public Sub LoadGridPedidoVenda(ByVal oGrid As GridEX, _
                                   ByVal lCodigoParceiroNegocio As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_pedido_venda", oSqlParameter)

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

    Public Sub LoadGridEmail(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_email", oSqlParameter)

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

    Public Sub LoadDadosParceiroNegocioVenda(ByVal iCodigoParceiroNegocio As Integer, _
                                             ByRef sMunicipio As String, _
                                             ByRef sUF As String, _
                                             ByRef iCodigoDestinacao As Integer)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Váriaveis
                sMunicipio = oSqlDataReader.Item("municipio")
                sUF = oSqlDataReader.Item("uf")
                iCodigoDestinacao = oSqlDataReader.Item("codigo_destinacao")

            End While

            'Fecha o SQLDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosParceiroNegocio(ByVal iCodigoParceiroNegocio As Integer, _
                                        ByRef iCodigoCondicaoPagamento As Integer, _
                                        ByRef iCodigoFormaPagamento As Integer, _
                                        ByRef dLimiteCredito As Double, _
                                        ByRef sLimiteCredito As String, _
                                        ByVal iCodigoTipoVendaPDV As TipoVendaPDV, _
                                        ByVal lCodigo As Long)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            'Seta Parametros - Código Pedido Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_orcamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código Tipo Pedido Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoVendaPDV : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Váriaveis
                iCodigoCondicaoPagamento = oSqlDataReader.Item("codigo_condicao_pagamento")
                iCodigoFormaPagamento = oSqlDataReader.Item("codigo_forma_pagamento")
                dLimiteCredito = oSqlDataReader.Item("limite_credito")
                sLimiteCredito = oSqlDataReader.Item("possui_limite_credito")

            End While

            'Fecha o SQLDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosParceiroNegocio(ByVal iCodigoParceiroNegocio As Integer, _
                                        ByRef iNumeroParcela As Integer, _
                                        ByRef iIntervaloParcela As Integer, _
                                        ByRef iCodigoFormaPagamento As Integer, _
                                        ByRef dLimiteCredito As Double, _
                                        ByVal iCodigoTipoVendaPDV As TipoVendaPDV, _
                                        ByVal lCodigo As Long)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            'Seta Parametros - Código Pedido Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_orcamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código Tipo Pedido Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoVendaPDV : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Váriaveis
                iCodigoCondicaoPagamento = oSqlDataReader.Item("codigo_condicao_pagamento")
                iCodigoFormaPagamento = oSqlDataReader.Item("codigo_forma_pagamento")
                dLimiteCredito = oSqlDataReader.Item("limite_credito")
                iNumeroParcela = oSqlDataReader.Item("numero_parcela")
                iIntervaloParcela = oSqlDataReader.Item("intervalo_parcela")

            End While

            'Fecha o SQLDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosParceiroNegocio(ByVal iCodigoParceiroNegocio As Integer, _
                                        ByRef iCodigoCondicaoPagamento As Integer, _
                                        ByRef iCodigoFormaPagamento As Integer, _
                                        ByRef iCodigoVendedor As Integer)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Váriaveis
                iCodigoCondicaoPagamento = oSqlDataReader.Item("codigo_condicao_pagamento")
                iCodigoFormaPagamento = oSqlDataReader.Item("codigo_forma_pagamento")
                iCodigoVendedor = oSqlDataReader.Item("codigo_vendedor")

            End While

            'Fecha o SQLDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosParceiroNegocio(ByVal iCodigoParceiroNegocio As Integer, _
                                        ByRef iCodigoCondicaoPagamento As Integer, _
                                        ByRef iCodigoFormaPagamento As Integer, _
                                        ByRef iCodigoModalidadeFrete As Integer, _
                                        ByRef iCodigoMoeda As Integer, _
                                        ByRef dLimiteCredito As Double, _
                                        ByRef iCodigoVendedor As Integer, _
                                        ByRef iCodigoDestinacao As Integer, _
                                        ByRef iCodigoCampanha As Integer, _
                                        ByRef iCodigoEmbalagem As Integer)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Váriaveis
                iCodigoCondicaoPagamento = oSqlDataReader.Item("codigo_condicao_pagamento")
                iCodigoFormaPagamento = oSqlDataReader.Item("codigo_forma_pagamento")
                iCodigoModalidadeFrete = oSqlDataReader.Item("codigo_modalidade_frete")
                iCodigoMoeda = oSqlDataReader.Item("codigo_moeda")
                dLimiteCredito = oSqlDataReader.Item("limite_credito")
                iCodigoVendedor = oSqlDataReader.Item("codigo_vendedor")
                iCodigoDestinacao = oSqlDataReader.Item("codigo_destinacao")
                iCodigoCampanha = oSqlDataReader.Item("codigo_campanha")
                iCodigoEmbalagem = oSqlDataReader.Item("codigo_embalagem")

            End While

            'Fecha o SQLDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosParceiroNegocio(ByVal iCodigoParceiroNegocio As Integer, _
                                        ByRef iCodigoCondicaoPagamento As Integer, _
                                        ByRef iCodigoFormaPagamento As Integer, _
                                        ByRef iCodigoModalidadeFrete As Integer, _
                                        ByRef iCodigoMoeda As Integer)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Váriaveis
                iCodigoCondicaoPagamento = oSqlDataReader.Item("codigo_condicao_pagamento")
                iCodigoFormaPagamento = oSqlDataReader.Item("codigo_forma_pagamento")
                iCodigoModalidadeFrete = oSqlDataReader.Item("codigo_modalidade_frete")
                iCodigoMoeda = oSqlDataReader.Item("codigo_moeda")

            End While

            'Fecha o SQLDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosParceiroNegocio(ByVal iCodigoParceiroNegocio As Integer, _
                                        ByRef sRazaoSocial As String, _
                                        ByRef sCNPJ As String, _
                                        ByRef sMunicipioUF As String)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Váriaveis
                sRazaoSocial = oSqlDataReader.Item("razao_social")
                sCNPJ = oSqlDataReader.Item("cnpj")
                sMunicipioUF = oSqlDataReader.Item("municipio_uf")

            End While

            'Fecha o SQLDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub AlterarEmpresa(ByVal iCodigoEmpresaNovo As Integer, _
                              ByVal sCodigoIntegracao As String)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try



            'Seta Váriavel
            i = 0

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_integracao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(sCodigoIntegracao = "", -1, sCodigoIntegracao) : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa_antigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa_novo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoEmpresaNovo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_acti_transferir_empresa", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
#End Region

    Public Sub InsertGrupoTecnologia(ByVal iCodigoParceiroNegocio As Integer, _
                                     ByVal sGrupoTecnologia As String)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            'Seta Váriavel
            i = 0

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_grupo_tecnologia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sGrupoTecnologia : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_parceiro_negocio_grupo_tecnologia", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#Region "::: CONTATO :::"

    Public Sub InsertContatoAscon(ByVal sNomeContato As String, _
                             ByVal sTelefoneContato As String, _
                             ByVal sCelularContato As String, _
                             ByVal sDataAniversario As String, _
                             ByVal sEmailContato As String, _
                             ByVal sComplementoContato As String, _
                             ByVal iCodigoTipoContato As Integer, _
                             ByVal bCronograma As Boolean, _
                             ByVal bFinanceiro As Boolean, _
                             ByVal bFaturamento As Boolean, _
                             ByVal bMarketing As Boolean, _
                             ByVal bCircular As Boolean, _
                             ByVal bOutros As Boolean)


        'Variaveis Locais
        Dim oSqlParameter(14) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Cronograma
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cronograma"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bCronograma : i += 1

            'Seta Parametros - Financeiro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "financeiro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bFinanceiro : i += 1

            'Seta Parametros - Faturamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "faturamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bFaturamento : i += 1

            'Seta Parametros - Marketing
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "marketing"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bMarketing : i += 1

            'Seta Parametros - Circular
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "circular"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bCircular : i += 1

            'Seta Parametros - Outrosvo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "outros"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bOutros : i += 1

            'Seta Parametros - Código Parceiro Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Tipo Contato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_contato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoContato : i += 1

            'Seta Parametros - Nome
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 70
            oSqlParameter(i).Value = sNomeContato : i += 1

            'Seta Parametros - Telefone
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sTelefoneContato : i += 1

            'Seta Parametros - Celular
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "celular"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCelularContato : i += 1

            'Seta Parametros - Data Aniversário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_aniversario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataAniversario), sDataAniversario, DBNull.Value) : i += 1

            'Seta Parametros - Email
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "email"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sEmailContato : i += 1

            'Seta Parametros - Complemento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "complemento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sComplementoContato

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_parceiro_negocio_contato_ascon", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertContato(ByVal sNomeContato As String, _
                             ByVal sTelefoneContato As String, _
                             ByVal sCelularContato As String, _
                             ByVal sDataAniversario As String, _
                             ByVal sEmailContato As String, _
                             ByVal sComplementoContato As String, _
                             ByVal iCodigoTipoContato As Integer)


        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try
             
            'Seta Parametros - Código Parceiro Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Tipo Contato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_contato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoContato : i += 1

            'Seta Parametros - Nome
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 70
            oSqlParameter(i).Value = sNomeContato : i += 1

            'Seta Parametros - Telefone
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sTelefoneContato : i += 1

            'Seta Parametros - Celular
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "celular"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCelularContato : i += 1

            'Seta Parametros - Data Aniversário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_aniversario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataAniversario), sDataAniversario, DBNull.Value) : i += 1

            'Seta Parametros - Email
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "email"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sEmailContato : i += 1

            'Seta Parametros - Complemento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "complemento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sComplementoContato

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_parceiro_negocio_contato", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateContato(ByVal sNomeContato As String, _
                             ByVal sTelefoneContato As String, _
                             ByVal sCelularContato As String, _
                             ByVal sDataAniversario As String, _
                             ByVal sEmailContato As String, _
                             ByVal sComplementoContato As String, _
                             ByVal iCodigoTipoContato As Integer, _
                             ByVal iCodigoContato As Integer)


        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Parceiro Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Contato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoContato : i += 1

            'Seta Parametros - Tipo Contato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_contato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoContato : i += 1

            'Seta Parametros - Nome
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 70
            oSqlParameter(i).Value = sNomeContato : i += 1

            'Seta Parametros - Telefone
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sTelefoneContato : i += 1

            'Seta Parametros - Celular
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "celular"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCelularContato : i += 1

            'Seta Parametros - Data Aniversário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_aniversario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataAniversario), sDataAniversario, DBNull.Value) : i += 1

            'Seta Parametros - Email
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "email"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sEmailContato : i += 1

            'Seta Parametros - Complemento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "complemento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sComplementoContato

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_parceiro_negocio_contato", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateContatoAscon(ByVal sNomeContato As String, _
                             ByVal sTelefoneContato As String, _
                             ByVal sCelularContato As String, _
                             ByVal sDataAniversario As String, _
                             ByVal sEmailContato As String, _
                             ByVal sComplementoContato As String, _
                             ByVal iCodigoTipoContato As Integer, _
                             ByVal iCodigoContato As Integer, _
                             ByVal bCronograma As Boolean, _
                             ByVal bFinanceiro As Boolean, _
                             ByVal bFaturamento As Boolean, _
                             ByVal bMarketing As Boolean, _
                             ByVal bCircular As Boolean, _
                             ByVal bOutros As Boolean)


        'Variaveis Locais
        Dim oSqlParameter(15) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Cronograma
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cronograma"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bCronograma : i += 1

            'Seta Parametros - Financeiro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "financeiro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bFinanceiro : i += 1

            'Seta Parametros - Faturamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "faturamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bFaturamento : i += 1

            'Seta Parametros - Marketing
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "marketing"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bMarketing : i += 1

            'Seta Parametros - Circular
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "circular"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bCircular : i += 1

            'Seta Parametros - Outrosvo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "outros"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bOutros : i += 1

            'Seta Parametros - Código Parceiro Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Contato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoContato : i += 1

            'Seta Parametros - Tipo Contato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_contato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoContato : i += 1

            'Seta Parametros - Nome
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 70
            oSqlParameter(i).Value = sNomeContato : i += 1

            'Seta Parametros - Telefone
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sTelefoneContato : i += 1

            'Seta Parametros - Celular
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "celular"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCelularContato : i += 1

            'Seta Parametros - Data Aniversário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_aniversario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataAniversario), sDataAniversario, DBNull.Value) : i += 1

            'Seta Parametros - Email
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "email"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sEmailContato : i += 1

            'Seta Parametros - Complemento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "complemento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sComplementoContato

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_parceiro_negocio_contato_ascon", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteContato()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                i = 0

                'Seta Parametros - Código Parceiro de Negócio
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigo : i += 1

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
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_parceiro_negocio_contato", oSqlParameter)

                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridContato(ByVal oGrid As GridEX, _
                               ByVal lCodigoParceiroNegocio As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_contato", oSqlParameter)

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

    Public Sub LoadGridContatoEmail(ByVal oGrid As GridEX, _
                                   ByVal lCodigoParceiroNegocio As Long, _
                                   ByVal iCodigoEmpresa As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_contato_email", oSqlParameter)

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

    Public Function LoadContatoParceiroNegocio(ByVal lCodigoParceiroNegocio As Long, _
                                               ByVal iTipoContato As Integer) As String

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0
        Dim sReturn As String = ""

        Try

            'Seta Parametros - Código Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoParceiroNegocio : i += 1

            'Seta Parametros - Código Tipo do Contato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_contato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iTipoContato : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_email_contato", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Váriavel
                sReturn = sReturn & IIf(sReturn.Trim = "", "", "; ") & oSqlDataReader.Item("email")

            End While

            'Fecha o oSqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            'Retorno da Função
            Return sReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: ENDEREÇO :::"

    Public Sub InsertEndereco(ByVal iCodigoTipoEndereco As Integer, _
                              ByVal sCEPEndereco As String, _
                              ByVal iCodigoPaisEndereco As Integer, _
                              ByVal sUFEndereco As String, _
                              ByVal iCodigoMunicipioEndereco As Integer, _
                              ByVal sLogradouroEndereco As String, _
                              ByVal sNumeroEndereco As String, _
                              ByVal sBairroEndereco As String, _
                              ByVal sComplementoEndereco As String)

        'Variaveis Locais
        Dim oSqlParameter(10) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Parceiro Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Tipo Endereço
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_endereco"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoEndereco : i += 1

            'Seta Parametros - CEP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cep"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sCEPEndereco : i += 1

            'Seta Parametros - Código País
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pais"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoPaisEndereco : i += 1

            'Seta Parametros - UF 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sUFEndereco : i += 1

            'Seta Parametros - Município
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_municipio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoMunicipioEndereco : i += 1

            'Seta Parametros - Logradouro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "logradouro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sLogradouroEndereco : i += 1

            'Seta Parametros - Número
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sNumeroEndereco : i += 1

            'Seta Parametros - Bairro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "bairro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sBairroEndereco : i += 1

            'Seta Parametros - Complemento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "complemento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sComplementoEndereco

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_parceiro_negocio_endereco", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateEndereco(ByVal iCodigoTipoEndereco As Integer, _
                              ByVal sCEPEndereco As String, _
                              ByVal iCodigoPaisEndereco As Integer, _
                              ByVal sUFEndereco As String, _
                              ByVal iCodigoMunicipioEndereco As Integer, _
                              ByVal sLogradouroEndereco As String, _
                              ByVal sNumeroEndereco As String, _
                              ByVal sBairroEndereco As String, _
                              ByVal sComplementoEndereco As String, _
                              ByVal iCodigoEndereco As Integer)

        'Variaveis Locais
        Dim oSqlParameter(11) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Parceiro Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoEndereco : i += 1

            'Seta Parametros - Tipo Endereço
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_endereco"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoEndereco : i += 1

            'Seta Parametros - CEP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cep"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sCEPEndereco : i += 1

            'Seta Parametros - Código País
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pais"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoPaisEndereco : i += 1

            'Seta Parametros - UF 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sUFEndereco : i += 1

            'Seta Parametros - Município
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_municipio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoMunicipioEndereco : i += 1

            'Seta Parametros - Logradouro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "logradouro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sLogradouroEndereco : i += 1

            'Seta Parametros - Número
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sNumeroEndereco : i += 1

            'Seta Parametros - Bairro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "bairro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sBairroEndereco : i += 1

            'Seta Parametros - Complemento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "complemento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sComplementoEndereco

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_parceiro_negocio_endereco", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteEndereco()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i, j As Integer

        Try

            For j = 0 To UBound(gSelecaoRow)

                i = 0

                'Seta Parametros - Código Parceiro de Negócio
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigo : i += 1

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = gSelecaoRow(j).Cells("codigo").Value : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_parceiro_negocio_endereco", oSqlParameter)

                gSelecaoRow(j).Delete()

            Next j

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridEndereco(ByVal oGrid As Janus.Windows.GridEX.GridEX, _
                                ByVal lCodigoParceiroNegocio As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_endereco", oSqlParameter)

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

    Public Sub LoadDadosParceiroNegocioEndereco(ByVal lCodigo As Long, _
                                                ByRef sEndereco As String, _
                                                ByRef sCEP As String, _
                                                ByRef sMunicipio As String)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
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

            'Obtem o DataSet
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_parceiro_negocio", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                sEndereco = oSqlDataReader.Item("endereco")
                sCEP = oSqlDataReader.Item("cep")
                sMunicipio = oSqlDataReader.Item("municipio")

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

#Region "::: CRM :::"

    Public Sub InsertCRM(ByVal sAssunto As String, _
                         ByVal sData As String)


        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Parceiro Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Assunto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "assunto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sAssunto : i += 1

            'Seta Parametros - Data
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sData

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_parceiro_negocio_crm", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateCRM(ByVal sAssunto As String, _
                         ByVal sData As String, _
                         ByVal iCodigoCRM As Integer)


        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Parceiro Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Assunto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "assunto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sAssunto : i += 1

            'Seta Parametros - Data
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sData : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoCRM

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_parceiro_negocio_crm", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteCRM()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                i = 0

                'Seta Parametros - Código Parceiro de Negócio
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigo : i += 1

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
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_parceiro_negocio_crm", oSqlParameter)

                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridCRM(ByVal oGrid As GridEX, _
                           ByVal lCodigoParceiroNegocio As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_crm", oSqlParameter)

            Dim oParentColumn(1) As DataColumn
            Dim oChildColumn1(1) As DataColumn

            oParentColumn(0) = oDataSet.Tables(0).Columns("codigo_parceiro_negocio")
            oParentColumn(1) = oDataSet.Tables(0).Columns("codigo")

            oChildColumn1(0) = oDataSet.Tables(1).Columns("codigo_parceiro_negocio")
            oChildColumn1(1) = oDataSet.Tables(1).Columns("codigo_crm")

            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oParentColumn, oChildColumn1)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

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

#Region "::: COMENTÁRIOS :::"

    Public Sub LoadGridCRMComentario(ByVal oGrid As GridEX, _
                                     ByVal iCodigoParceiroNegocio As Integer, _
                                     ByVal iCodigoCRM As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            'Seta Parametros - Código CRM
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_crm"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoCRM : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_crm_comentario", oSqlParameter)

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

    Public Sub InsertCRMComentario(ByVal iCodigoParceiroNegocio As Integer, _
                                   ByVal iCodigoCRM As Integer, _
                                   ByVal sComentario As String)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            'Seta Parametros - Código CRM
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_crm"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoCRM : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Comentário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "comentario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sComentario : i += 1

            'Seta Parametros - Codigo Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_parceiro_negocio_crm_comentario", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

#Region "::: CERTIFICADO :::"

    Public Sub InsertCertificado(ByVal sCertificado As String, _
                                 ByVal sDataEmissao As String, _
                                 ByVal sDataValidade As String, _
                                 ByRef iCodigoCertificado As Integer)


        'Variaveis Locais
        Dim oSqlParameter(6) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Parceiro Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Certificado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "certificado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sCertificado : i += 1

            'Seta Parametros - Data Emissão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataEmissao : i += 1

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

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_parceiro_negocio_certificado", oSqlParameter)

            iCodigoCertificado = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateCertificado(ByVal sCertificado As String, _
                                 ByVal sDataEmissao As String, _
                                 ByVal sDataValidade As String, _
                                 ByVal iCodigoCertificado As Integer)


        'Variaveis Locais
        Dim oSqlParameter(6) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Parceiro Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Certificado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "certificado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sCertificado : i += 1

            'Seta Parametros - Data Emissão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataEmissao : i += 1

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

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoCertificado

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_parceiro_negocio_certificado", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteCertificado()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                i = 0

                'Seta Parametros - Código Parceiro de Negócio
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigo : i += 1

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
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_parceiro_negocio_certificado", oSqlParameter)

                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridCertificado(ByVal oGrid As GridEX, _
                                   ByVal lCodigoParceiroNegocio As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_certificado", oSqlParameter)

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

#Region "::: ESPECIALIDADE :::"

    Public Sub InsertEspecialidade(ByVal oGrid As GridEX)


        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In oGrid.GetCheckedRows

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Parceiro Negócio
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = iCodigo : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Código Especialidade
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_especialidade"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_parceiro_negocio_especialidade", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteEspecialidade()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
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
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_parceiro_negocio_especialidade", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridEspecialidade(ByVal oGrid As GridEX, _
                                     ByVal lCodigoParceiroNegocio As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_especialidade", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

            If Not oGrid.DataSource Is Nothing Then
                Dim oDataRow As DataRow
                For Each oRow As GridEXRow In oGrid.GetDataRows
                    oDataRow = oDataSet.Tables(0).Select("codigo = " & oRow.Cells("codigo").Value)(0)
                    oRow.CheckState = IIf(oDataRow.Item("x") = True, RowCheckState.Checked, RowCheckState.Unchecked)
                Next
            End If

            'Atualiza Grid
            oGrid.Refresh()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: MARCA :::"

    Public Sub InsertMarca(ByVal oGrid As GridEX)


        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In oGrid.GetCheckedRows

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Parceiro Negócio
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = iCodigo : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Código Marca
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_marca"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_parceiro_negocio_marca", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteMarca()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
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
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_parceiro_negocio_marca", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridMarca(ByVal oGrid As GridEX, _
                                     ByVal lCodigoParceiroNegocio As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_marca", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

            If Not oGrid.DataSource Is Nothing Then
                Dim oDataRow As DataRow
                For Each oRow As GridEXRow In oGrid.GetDataRows
                    oDataRow = oDataSet.Tables(0).Select("codigo = " & oRow.Cells("codigo").Value)(0)
                    oRow.CheckState = IIf(oDataRow.Item("x") = True, RowCheckState.Checked, RowCheckState.Unchecked)
                Next
            End If

            'Atualiza Grid
            oGrid.Refresh()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: COBRANCA :::"

    Public Sub InsertCobranca(ByVal sDataCobranca As String, _
                              ByVal sResponsavelCobranca As String, _
                              ByVal sTelefoneContatoCobranca As String, _
                              ByVal sHistoricoCobranca As String, _
                              ByVal sContatoCobranca As String)


        'Variaveis Locais
        Dim oSqlParameter(6) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Parceiro Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Data Cobranca
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_cobranca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataCobranca), sDataCobranca, DBNull.Value) : i += 1

            'Seta Parametros - Nome
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "responsavel_cobranca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sResponsavelCobranca : i += 1

            'Seta Parametros - Telefone
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone_contato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sTelefoneContatoCobranca : i += 1

            'Seta Parametros - Celular
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "historico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 400
            oSqlParameter(i).Value = sHistoricoCobranca : i += 1

            'Seta Parametros - Nome
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "contato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sContatoCobranca

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_parceiro_negocio_cobranca", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateCobranca(ByVal sDataCobranca As String, _
                              ByVal sResponsavelCobranca As String, _
                              ByVal sTelefoneContatoCobranca As String, _
                              ByVal sHistoricoCobranca As String, _
                              ByVal iCodigoCobranca As Integer, _
                              ByVal sContatoCobranca As String)

        'Variaveis Locais
        Dim oSqlParameter(7) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Parceiro Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Data Cobranca
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_cobranca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataCobranca), sDataCobranca, DBNull.Value) : i += 1

            'Seta Parametros - Nome
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "responsavel_cobranca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sResponsavelCobranca : i += 1

            'Seta Parametros - Telefone
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone_contato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sTelefoneContatoCobranca : i += 1

            'Seta Parametros - Celular
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "historico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 400
            oSqlParameter(i).Value = sHistoricoCobranca : i += 1

            'Seta Parametros - Código Contato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoCobranca : i += 1

            'Seta Parametros - Nome
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "contato"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sContatoCobranca

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_parceiro_negocio_cobranca", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteCobranca(ByVal iCodigoParceiroNegocio As Integer)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                i = 0

                'Seta Parametros - Código Parceiro Negócio
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

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
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_parceiro_negocio_cobranca", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridCobranca(ByVal oGrid As GridEX, _
                                ByVal iCodigoParceiroNegocio As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Parceiro Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_cobranca", oSqlParameter)

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

#Region "::: HISTÓRICO :::"

    Public Sub LoadGridPedidoCompra1(ByVal oGrid As GridEX, _
                                     ByVal lCodigoParceiroNegocio As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_pedido_compra", oSqlParameter)

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

    Public Sub LoadGridPedidoVenda1(ByVal oGrid As GridEX, _
                                    ByVal lCodigoParceiroNegocio As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_pedido_venda", oSqlParameter)

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

    Public Sub LoadGridTitulo(ByVal oGrid As GridEX, _
                              ByVal lCodigoParceiroNegocio As Long, _
                              ByVal sTipo As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sTipo

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_titulo", oSqlParameter)

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

    Public Sub LoadGridHistoricoVenda(ByVal oGrid As GridEX, _
                                      ByVal iCodigoCliente As Integer, _
                                      ByVal sDataInicio As String, _
                                      ByVal sDataTermino As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

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

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCliente

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_historico_pedido", oSqlParameter)

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

    Public Sub LoadGridHistoricoVendaProduto(ByVal oGrid As GridEX, _
                                             ByVal lCodigoPedido As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_historico_pedido_produto", oSqlParameter)

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
                                          ByVal iCodigoCliente As Integer, _
                                          ByVal sDataInicio As String, _
                                          ByVal sDataTermino As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

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

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCliente

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_historico_orcamento", oSqlParameter)

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

    Public Sub LoadGridHistoricoOrcamentoProduto(ByVal oGrid As GridEX, _
                                                 ByVal lCodigoOrcamento As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Orçamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_orcamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoOrcamento

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_historico_orcamento_produto", oSqlParameter)

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

    Public Sub LoadGridHistoricoNotaFiscal(ByVal oGrid As GridEX, _
                                           ByVal iCodigoCliente As Integer, _
                                           ByVal sDataInicio As String, _
                                           ByVal sDataTermino As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

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

            'Seta Parametros - Código Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCliente

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_historico_nota_fiscal", oSqlParameter)

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

    Public Sub LoadGridHistoricoNotaFiscalProduto(ByVal oGrid As GridEX, _
                                                  ByVal lCodigoEmissaoCapa As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_historico_nota_fiscal_produto", oSqlParameter)

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

    Public Sub LoadGridHistoricoEstoque(ByVal oGrid As GridEX, _
                                        ByVal iCodigoParceiroNegocio As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoParceiroNegocio

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_historico_estoque", oSqlParameter)

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

    Public Sub InsertHistorico(ByVal iCodigoParceiroNegocio As Integer, _
                              ByVal sDescricao As String)


        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Parceiro Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Marca
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDescricao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_parceiro_negocio_historico", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateBloqueio(ByVal iCodigoParceiroNegocio As Integer, _
                              ByVal sJustificativaBloqueio As String)


        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Parceiro Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "justificativa_bloqueio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sJustificativaBloqueio : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_parceiro_negocio_bloqueio", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridHistorico(ByVal oGrid As GridEX, _
                                 ByVal iCodigoParceiroNegocio As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoParceiroNegocio

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_historico", oSqlParameter)

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

    Public Sub LoadGridAnalise(ByVal oGrid As GridEX, _
                               ByVal sSemana As String, _
                               ByVal sNome As String, _
                               ByVal sCodigoConsultora As String, _
                               ByVal sSetor As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(10) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNome : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_consultora"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCodigoConsultora : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "setor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sSetor : i += 1

            'Seta Parametros - Código Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "semana"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sSemana

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_grid_analise_cadastro_consultora", oSqlParameter)

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

    Public Sub InsertAnalise(ByVal iCodigoParceiroNegocio As Integer, _
                                ByVal iCodigoConferidoPor As String, _
                                ByVal sConferidoPor As String, _
                                ByVal iStatusAnalise As Integer, _
                                ByVal sMotivoPendencia As String, _
                                ByVal iCodigoMotivoPendencia As Integer, _
                                ByVal sPrimeiroPedido As String, _
                                ByVal sSolucao As String, _
                                ByVal sSemana As String)


        'Variaveis Locais
        Dim oSqlParameter(15) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Parceiro Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Marca
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_conferido_por"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoConferidoPor = -1, DBNull.Value, iCodigoConferidoPor) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "conferido_por"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sConferidoPor = "", DBNull.Value, sConferidoPor) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status_analise"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iStatusAnalise = -1, DBNull.Value, iStatusAnalise) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "motivo_pendencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sMotivoPendencia = "", DBNull.Value, sMotivoPendencia) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_motivo_pendencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoMotivoPendencia = -1, DBNull.Value, iCodigoMotivoPendencia) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "primeiro_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sPrimeiroPedido : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "solucao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sSolucao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "semana"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sSemana : i += 1

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_analise_cadastro_consultora", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub AtualizarSite()


        'Variaveis Locais
        Dim oSqlParameter(15) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Parceiro Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_job"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = "UpdateCadastroSite" : i += 1


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_executar_job", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
#End Region

#Region "::: PRODUTO - CENTRO DE CUSTO :::"

    Public Sub InsertCentroCusto(ByVal iCodigoParceiroNegocio As Integer, _
                                 ByVal iCodigoCentroCusto As Integer)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

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
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_parceiro_negocio_centro_custo", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateCentroCusto(ByVal iCodigoParceiroNegocio As Integer, _
                                 ByVal iCodigoCentroCusto As Integer, _
                                 ByVal iCodigoCentroCustoAntigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

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
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_parceiro_negocio_centro_custo", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteCentroCusto(ByVal iCodigoParceiroNegocio As Integer)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel 
                i = 0

                'Seta Parametros - Código Produto
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

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
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_parceiro_negocio_centro_custo", oSqlParameter)

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
                                   ByVal iCodigoParceiroNegocio As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_centro_custo", oSqlParameter)

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

    Public Sub InsertContaContabil(ByVal iCodigoParceiroNegocio As Integer, _
                                   ByVal sCodigoContaContabil As String)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Código Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

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
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_parceiro_negocio_conta_contabil", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateContaContabil(ByVal iCodigoParceiroNegocio As Integer, _
                                   ByVal sCodigoContaContabil As String, _
                                   ByVal sCodigoContaContabilAntigo As String)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

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
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_parceiro_negocio_conta_contabil", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteContaContabil(ByVal iCodigoParceiroNegocio As Integer)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel 
                i = 0

                'Seta Parametros - Código Produto
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

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
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_parceiro_negocio_conta_contabil", oSqlParameter)

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
                                     ByVal iCodigoParceiroNegocio As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_conta_contabil", oSqlParameter)

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

#Region "::: QUALIDADE :::"

    Public Sub InsertQualidade(ByVal iNotaQuestionario As Integer, _
                               ByVal sDataVencimentoCertificado As Date, _
                               ByVal sDataEntregaQuestionario As Date, _
                               ByVal sDataVencimentoQuestionario As Date, _
                               ByVal iCodigoParceiroNegocio As Integer
                               )

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nota_questionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iNotaQuestionario : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento_certificado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = sDataVencimentoCertificado : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_entrega_questionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = sDataEntregaQuestionario : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento_questionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = sDataVencimentoQuestionario

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_parceiro_negocio_qualidade", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteQualidade(iCodigoParceiro)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                i = 0

                'Seta Parametros - Código Parceiro de Negócio
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigoParceiro : i += 1

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_qualidade"
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
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_parceiro_negocio_qualidade", oSqlParameter)

                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub updateQualidade(ByVal iCodigoQualidade As Integer, _
                               ByVal iNotaQuestionario As Integer, _
                               ByVal sDataVencimentoCertificado As Date, _
                               ByVal sDataEntregaQuestionario As Date, _
                               ByVal sDataVencimentoQuestionario As Date, _
                               ByVal iCodigoParceiroNegocio As Integer)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_qualidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoQualidade : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nota_questionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iNotaQuestionario : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento_certificado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = sDataVencimentoCertificado : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_entrega_questionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = sDataEntregaQuestionario : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento_questionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = sDataVencimentoQuestionario


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_parceiro_negocio_qualidade", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadQualidadeRisco(ByVal lblMensagem As Label, _
                                  ByVal lblMediaNota As Label, _
                                  ByVal lblStatusQualidade As Label, _
                                  ByVal iCodigoParceiroNegocio As Integer)
        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_qualidade_dados", oSqlParameter)

            While oSqlDataReader.Read

                lblMensagem.Text = oSqlDataReader("mensagem")
                lblMediaNota.Text = oSqlDataReader("media_nota")
                lblStatusQualidade.Text = oSqlDataReader("status_qualidade")

            End While

            'Fecha o SQLDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub loadGridQualidade(ByVal oGrid As GridEX, _
                                 ByVal iCodigoParceiroNegocio As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_qualidade", oSqlParameter)

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

#Region "::: AMOSTRA :::"

    Public Sub InsertAmostra()

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Descricao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sNumeroPedido : i += 1

            'Seta Parametros - Descricao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo_frasco"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iTipoFrasco : i += 1

            'Seta Parametros - Descricao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoProduto : i += 1

            'Seta Parametros - Descricao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dtData : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_parceiro_negocio_amostra", oSqlParameter)

            iCodigo = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateAmostra()

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Descricao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sNumeroPedido : i += 1

            'Seta Parametros - Descricao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo_frasco"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iTipoFrasco : i += 1

            'Seta Parametros - Descricao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoProduto : i += 1

            'Seta Parametros - Descricao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = dtData : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_parceiro_negocio_amostra", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteAmostra()

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
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_parceiro_negocio_amostra", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridAmostra(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_amostra", oSqlParameter)

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

#Region "::: ESPAÇO LE SIX :::"

    Public Sub InsertDados(ByVal iCodigoParceiroNegocio As Integer, _
                           ByVal sNacionalidadeCliente As String, _
                           ByVal sProfissaoCliente As String, _
                           ByVal iEstadoCivilCliente As Integer, _
                           ByVal sNomeAcompanhante As String, _
                           ByVal sProfissaoAcompanhante As String, _
                           ByVal iEstadoCivilAcompanhante As Integer, _
                           ByVal sRG As String, _
                           ByVal sCPF As String, _
                           ByVal sCEP As String, _
                           ByVal iCodigoPais As Integer, _
                           ByVal sUF As String, _
                           ByVal iCodigoMunicipio As Integer, _
                           ByVal sLogradouro As String, _
                           ByVal sNumero As String, _
                           ByVal sBairro As String, _
                           ByVal sComplemento As String, _
                           ByVal sNacionalidade As String)


        'Variaveis Locais
        Dim oSqlParameter(60) As SqlParameter
        Dim i As Integer = 0

        Try


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nacionalidade_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNacionalidadeCliente : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "profissao_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sProfissaoCliente : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_estado_civil_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iEstadoCivilCliente : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_acompanhante"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNomeAcompanhante : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "profissao_acompanhante"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sProfissaoAcompanhante : i += 1

            '''''
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "estado_civil"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iEstadoCivilAcompanhante : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "rg"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sRG : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cpf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCPF : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cep"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCEP : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pais"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoPais : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sUF : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_municipio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoMunicipio : i += 1

            '***
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "logradouro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sLogradouro : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumero : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "bairro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sBairro : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "complemento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sComplemento : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nacionalidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNacionalidade

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_parceiro_negocio_norsul", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteEspacoLeSix(ByVal iCodigoParceiroNegocio As Integer)


        'Variaveis Locais
        Dim oSqlParameter(60) As SqlParameter
        Dim i As Integer = 0

        Try


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1



            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_parceiro_negocio_norsul", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: AGENDA TELEFÔNICA :::"

    Public Sub LoadGridAgendaTelefonica(ByVal oGridCliente As Janus.Windows.GridEX.GridEX, _
                                        ByVal oGridContato As GridEX, _
                                       ByVal sRazaoSocial As String, _
                                       ByVal sNome As String, _
                                       ByVal sTelefone1 As String, _
                                       ByVal sTelefone2 As String, _
                                       ByVal sComplemento As String, _
                                       ByVal sTipoFiltro As String, _
                                       ByVal sDataInicio As String, _
                                       ByVal sDataTermino As String, _
                                       ByVal sNumeroCliente As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(12) As SqlParameter
        Dim i As Integer = 0

        Try
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "razao_social"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sRazaoSocial : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNome : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sTelefone1 : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sTelefone2 : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "complemento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sComplemento : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo_filtro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sTipoFiltro : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataInicio = "", DBNull.Value, sDataInicio) : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataTermino = "", DBNull.Value, sDataTermino) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroCliente : i += 1

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_agenda_telefonica", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGridCliente)
            Call ConfigurarDataMemberGrid(oGridContato)

            'Carrega Grid
            oGridCliente.DataSource = oDataSet.DefaultViewManager
            oGridCliente.DataMember = oDataSet.Tables(0).TableName

            'Carrega Grid
            oGridContato.DataSource = oDataSet.DefaultViewManager
            oGridContato.DataMember = oDataSet.Tables(1).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


#End Region

#Region "::: SOCIETÁRIO :::"
    Public Sub DeleteSocietario()

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                i = 0
                If IsDBNull(oRow.Cells.Item("codigo_sga_ordem_servico").Value) = False Then
                    Continue For
                End If
                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo_parceiro_negocio").Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_parceiro_negocio_societario", oSqlParameter)

                'Deleta Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Public Sub InsertSocietario(ByVal iCodigoParceiroNegocio As Integer, _
                                ByVal iCodigoTipoDocumento As Integer, _
                                ByVal sDescricao As String, _
                                ByVal sDataAssinatura As String, _
                                ByVal sDataRegistro As String, _
                                ByVal sNumeroRegistro As String, _
                                ByVal sResumo As String, _
                                ByVal sArquivo As String, _
                                ByVal iCodigoEmpresa As Integer)

        'Variaveis Locais
        Dim oSqlParameter(20) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoTipoDocumento : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDescricao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_assinatura"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataAssinatura = "", DBNull.Value, sDataAssinatura) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_registro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataRegistro = "", DBNull.Value, sDataRegistro) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_registro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroRegistro : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "resumo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sResumo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sArquivo : i += 1


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_parceiro_negocio_societario", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Public Sub UpdateSocientario(ByVal iCodigo As Integer, _
                                    ByVal iCodigoParceiroNegocio As Integer, _
                                    ByVal iCodigoTipoDocumento As Integer, _
                                    ByVal sDescricao As String, _
                                    ByVal sDataAssinatura As String, _
                                    ByVal sDataRegistro As String, _
                                    ByVal sNumeroRegistro As String, _
                                    ByVal sResumo As String, _
                                    ByVal sArquivo As String, _
                                    ByVal iCodigoEmpresa As Integer)

        'Variaveis Locais
        Dim oSqlParameter(20) As SqlParameter
        Dim i As Integer = 0

        Try
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoTipoDocumento : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDescricao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_assinatura"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataAssinatura = "", DBNull.Value, sDataAssinatura) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_registro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataRegistro = "", DBNull.Value, sDataRegistro) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_registro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroRegistro : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "resumo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sResumo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sArquivo : i += 1


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_parceiro_negocio_societario", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Public Sub LoadGridSocietario(ByVal oGrid As GridEX, _
                               ByVal iCodigoParceiroNegocio As Integer, _
                               ByVal iCodigoEmpresa As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(19) As SqlParameter
        Dim i As Integer = 0

        Try


            'Seta Parametros - Número Orçamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoEmpresa : i += 1


            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_societario", oSqlParameter)

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

#Region "::: VINCENDO :::"
    Public Sub UpdateVincendo(ByVal iCodigo As Integer, _
                                  ByVal iCodigoParceiroNegocio As Integer, _
                                  ByVal iCodigoTipoVincendo As Integer, _
                                  ByVal sDescricao As String, _
                                  ByVal sDataAssinatura As String, _
                                  ByVal sDataVencimento As String, _
                                  ByVal sArquivo As String, _
                                  ByVal bAtivo As Boolean, _
                                  ByVal iCodigoEmpresa As Integer, _
                                  ByVal bRenovado As Boolean, _
                                  ByVal sObservacao As String, _
                                  ByVal sDataProrrogacao As String)

        'Variaveis Locais
        Dim oSqlParameter(20) As SqlParameter
        Dim i As Integer = 0

        Try
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_vincendo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoTipoVincendo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDescricao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_assinatura"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataAssinatura = "", DBNull.Value, sDataAssinatura) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataVencimento = "", DBNull.Value, sDataVencimento) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sArquivo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAtivo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "renovado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bRenovado : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sObservacao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_prorrogacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataProrrogacao = "", DBNull.Value, sDataProrrogacao) : i += 1


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_parceiro_negocio_vincendo", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Public Sub UpdateContatoVincendo(ByVal iCodigo As Integer, _
                                     ByVal iCodigoParceiroNegocio As Integer, _
                                     ByVal iCodigoEmpresa As Integer, _
                                     ByVal bEnviarVincendo As Boolean)

        'Variaveis Locais
        Dim oSqlParameter(20) As SqlParameter
        Dim i As Integer = 0

        Try
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "enviar_vincendo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bEnviarVincendo : i += 1

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_parceiro_negocio_vincendo_contato", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Public Sub InsertVincendo(ByVal iCodigoParceiroNegocio As Integer, _
                                ByVal iCodigoTipoVincendo As Integer, _
                                ByVal sDescricao As String, _
                                ByVal sDataAssinatura As String, _
                                ByVal sDataVencimento As String, _
                                ByVal sArquivo As String, _
                                ByVal bAtivo As Boolean, _
                                ByVal iCodigoEmpresa As Integer, _
                                ByVal bRenovado As Boolean, _
                                ByVal sObservacao As String, _
                                ByVal sDataProrrogacao As String)

        'Variaveis Locais
        Dim oSqlParameter(20) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_vincendo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoTipoVincendo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDescricao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_assinatura"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataAssinatura = "", DBNull.Value, sDataAssinatura) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataVencimento = "", DBNull.Value, sDataVencimento) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAtivo : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sArquivo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "renovado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bRenovado : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sObservacao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_prorrogacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataProrrogacao = "", DBNull.Value, sDataProrrogacao) : i += 1


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_parceiro_negocio_vincendo", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Public Sub DeleteVincendo()

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                i = 0

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo_parceiro_negocio").Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_parceiro_negocio_vincendo", oSqlParameter)

                'Deleta Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Public Sub LoadGridVincendo(ByVal oGrid As GridEX, _
                              ByVal iCodigoParceiroNegocio As Integer, _
                              ByVal iCodigoEmpresa As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(19) As SqlParameter
        Dim i As Integer = 0

        Try


            'Seta Parametros - Número Orçamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoEmpresa : i += 1


            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_vincendo", oSqlParameter)

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
    Public Sub LoadGridVincendoSGA(ByVal oGrid As GridEX, _
                                      ByVal sCliente As String, _
                                      ByVal iCodigoEmpresa As Integer, _
                                      ByVal sNumeroCliente As String, _
                                      ByVal sDataInicio As String, _
                                      ByVal sDataTermino As String, _
                                      ByVal iCodigoTipoVincendo As Integer, _
                                      ByVal sDescricaoVincendo As String, _
                                      ByVal iAtivo As Integer, _
                                      ByVal iRenovado As Integer, _
                                      ByVal iStatus As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(19) As SqlParameter
        Dim i As Integer = 0

        Try


            'Seta Parametros - Número Orçamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCliente : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroCliente : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataInicio = "", DBNull.Value, sDataInicio) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataTermino = "", DBNull.Value, sDataTermino) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_vincendo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(iCodigoTipoVincendo = -1, DBNull.Value, iCodigoTipoVincendo) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao_vincendo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDescricaoVincendo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iAtivo = -1, DBNull.Value, iAtivo) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "renovado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iRenovado = -1, DBNull.Value, iRenovado) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iStatus : i += 1

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_sga_cadastro_basico_parceiro_negocio_vincendo", oSqlParameter)

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
    Public Sub InsertVincendoHistorico(ByVal iCodigoParceiroNegocio As Integer, _
                                        ByVal iCodigoVincendo As Integer, _
                                        ByVal sHistorico As String, _
                                        ByVal iCodigoEmpresa As Integer)

        'Variaveis Locais
        Dim oSqlParameter(20) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_vincendo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoVincendo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "historico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sHistorico : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = goUsuario.sNome : i += 1

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_parceiro_negocio_vincendo_historico", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Public Sub LoadGridVincendoHistorico(ByVal oGrid As GridEX, _
                                         ByVal iCodigoParceiroNegocio As Integer, _
                                         ByVal iCodigoEmpresa As Integer, _
                                         ByVal iCodigoVincendo As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(19) As SqlParameter
        Dim i As Integer = 0

        Try


            'Seta Parametros - Número Orçamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_vincendo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoVincendo : i += 1

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_vincendo_hitorico", oSqlParameter)

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

#Region "::: SÓCIOS :::"
    Public Sub InsertSocio(ByVal iCodigoParceiroNegocio As Integer, _
                            ByVal sNome As String, _
                            ByVal sCPFCNPJ As String, _
                            ByVal sRG As String, _
                            ByVal sNacionalidade As String, _
                            ByVal iCodigoEstadoCivil As Integer, _
                            ByVal sCEP As String, _
                            ByVal iCodigoPais As Integer, _
                            ByVal sUF As String, _
                            ByVal iCodigoMunicipio As Integer, _
                            ByVal sLogradouro As String, _
                            ByVal sNumero As String, _
                            ByVal sBairro As String, _
                            ByVal sComplemento As String, _
                            ByVal sQualificao As String, _
                            ByVal sTelefone As String, _
                            ByVal sEmail As String, _
                            ByVal sTaxID As String, _
                            ByVal sID As String, _
                            ByVal sTipoSocietario As String, _
                            ByVal iCodigoOrgaoRegistro As Integer, _
                            ByVal sNIRE As String, _
                            ByVal sDataInicioAtividades As String, _
                            ByVal sNumeroRegistro As String, _
                            ByVal sDataRegistro As String, _
                            ByVal sRepresentanteLegal As String, _
                            ByVal sNumeroCadastro As String, _
                            ByVal bPessoaFisica As Boolean, _
                            ByVal bPessoaJuridica As Boolean, _
                            ByVal bEstrangeiro As Boolean, _
                            ByVal bBrasileito As Boolean, _
                            ByVal sDataAdmissao As String, _
                            ByVal sCidadeNascimento As String, _
                            ByVal sDataNascimento As String, _
                            ByVal sProfissao As String)

        'Variaveis Locais
        Dim oSqlParameter(60) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pessoa_fisica"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bPessoaFisica : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pessoa_juridica"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bPessoaJuridica : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "estrangeiro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bEstrangeiro : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "brasileiro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bBrasileito : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNome : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cpf_cnpj"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCPFCNPJ : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "rg"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sRG : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nacionalidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNacionalidade : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_estado_civil"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoEstadoCivil = -1, DBNull.Value, iCodigoEstadoCivil) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cep"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCEP : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pais"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoPais : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sUF : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_municipio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoMunicipio : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "logradouro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sLogradouro : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumero : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "bairro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sBairro : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "complemento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sComplemento : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "qualificacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sQualificao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sTelefone : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "email"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sEmail : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tax_id"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sTaxID : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "id"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sID : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo_societario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sTipoSocietario = "", DBNull.Value, sTipoSocietario) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_orgao_registro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoOrgaoRegistro = -1, DBNull.Value, iCodigoOrgaoRegistro) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nire"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNIRE : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio_atividades"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataInicioAtividades = "", DBNull.Value, sDataInicioAtividades) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_registro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroRegistro : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_registro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataRegistro = "", DBNull.Value, sDataRegistro) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "representante_legal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sRepresentanteLegal : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_cadastro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroCadastro : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_admissao_sociedade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataAdmissao = "", DBNull.Value, sDataAdmissao) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cidade_nascimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCidadeNascimento : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_nascimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataNascimento = "", DBNull.Value, sDataNascimento) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "profissao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sProfissao : i += 1

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_parceiro_negocio_socios", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Public Sub UpdateSocio(ByVal iCodigo As Integer, _
                           ByVal iCodigoParceiroNegocio As Integer, _
                           ByVal sNome As String, _
                           ByVal sCPFCNPJ As String, _
                           ByVal sRG As String, _
                           ByVal sNacionalidade As String, _
                           ByVal iCodigoEstadoCivil As Integer, _
                           ByVal sCEP As String, _
                           ByVal iCodigoPais As Integer, _
                           ByVal sUF As String, _
                           ByVal iCodigoMunicipio As Integer, _
                           ByVal sLogradouro As String, _
                           ByVal sNumero As String, _
                           ByVal sBairro As String, _
                           ByVal sComplemento As String, _
                           ByVal sQualificao As String, _
                           ByVal sTelefone As String, _
                           ByVal sEmail As String, _
                           ByVal sTaxID As String, _
                           ByVal sID As String, _
                           ByVal sTipoSocietario As String, _
                           ByVal iCodigoOrgaoRegistro As Integer, _
                           ByVal sNIRE As String, _
                           ByVal sDataInicioAtividades As String, _
                           ByVal sNumeroRegistro As String, _
                           ByVal sDataRegistro As String, _
                           ByVal sRepresentanteLegal As String, _
                           ByVal sNumeroCadastro As String, _
                           ByVal bPessoaFisica As Boolean, _
                           ByVal bPessoaJuridica As Boolean, _
                           ByVal bEstrangeiro As Boolean, _
                           ByVal bBrasileiro As Boolean, _
                           ByVal sDataAdmissao As String, _
                           ByVal sCidadeNascimento As String, _
                           ByVal sDataNascimento As String, _
                           ByVal sProfissao As String)

        'Variaveis Locais
        Dim oSqlParameter(60) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pessoa_fisica"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bPessoaFisica : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pessoa_juridica"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bPessoaJuridica : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "estrangeiro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bEstrangeiro : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "brasileiro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bBrasileiro : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNome : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cpf_cnpj"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCPFCNPJ : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "rg"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sRG : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nacionalidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNacionalidade : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_estado_civil"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoEstadoCivil = -1, DBNull.Value, iCodigoEstadoCivil) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cep"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCEP : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pais"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoPais : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sUF : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_municipio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoMunicipio : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "logradouro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sLogradouro : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumero : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "bairro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sBairro : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "complemento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sComplemento : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "qualificacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sQualificao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sTelefone : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "email"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sEmail : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tax_id"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sTaxID : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "id"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sID : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo_societario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sTipoSocietario = "", DBNull.Value, sTipoSocietario) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_orgao_registro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoOrgaoRegistro = -1, DBNull.Value, iCodigoOrgaoRegistro) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nire"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNIRE : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio_atividades"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataInicioAtividades = "", DBNull.Value, sDataInicioAtividades) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_registro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroRegistro : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_registro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataRegistro = "", DBNull.Value, sDataRegistro) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "representante_legal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sRepresentanteLegal : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_cadastro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroCadastro : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_admissao_sociedade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataAdmissao = "", DBNull.Value, sDataAdmissao) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cidade_nascimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCidadeNascimento : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_nascimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(sDataNascimento = "", DBNull.Value, sDataNascimento) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "profissao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sProfissao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_parceiro_negocio_socios", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Public Sub UpdateSocioInativacao(ByVal iCodigo As Integer, _
                          ByVal iCodigoParceiroNegocio As Integer, _
                          ByVal bMorte As Boolean, _
                          ByVal bExclusao As Boolean, _
                          ByVal bCessaoQuotas As Boolean, _
                          ByVal sRegistroInativacao As String)

        'Variaveis Locais
        Dim oSqlParameter(50) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "morte"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bMorte : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "exclusao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bExclusao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cessao_quotas"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bCessaoQuotas : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "registro_inativacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sRegistroInativacao : i += 1

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_parceiro_negocio_socios_inativacao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Public Sub LoadGridSocio(ByVal oGrid As GridEX, _
                             ByVal iCodigoParceiroNegocio As Integer, _
                             ByVal iCodigoEmpresa As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(19) As SqlParameter
        Dim i As Integer = 0

        Try


            'Seta Parametros - Número Orçamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoEmpresa : i += 1


            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_socios", oSqlParameter)

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
    Public Sub LoadControlesSocioTipoPessoa(ByVal iCodigoParceiroNegocio As Integer, _
                                            ByVal iCodigo As Integer, _
                                            ByVal chkPessoaFisica As UICheckBox, _
                                            ByVal chkPessoaJuridica As UICheckBox, _
                                            ByVal chkBrasileira As UICheckBox, _
                                            ByVal chkEstrangeira As UICheckBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

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
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_parceiro_negocio_socios_tipo_pessoa", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    chkPessoaFisica.Checked = oSqlDataReader.Item("pessoa_fisica")
                    chkPessoaJuridica.Checked = oSqlDataReader.Item("pessoa_juridica")
                    chkEstrangeira.Checked = oSqlDataReader("estrangeiro")
                    chkBrasileira.Checked = oSqlDataReader("brasileiro")

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
    Public Sub LoadControlesSocio(ByVal iCodigoParceiroNegocio As Integer, _
                                  ByVal iCodigo As Integer, _
                                  ByVal txtNome As MaskedEditBox, _
                                  ByVal txtCPFCNPJ As MaskedEditBox, _
                                  ByVal txtRG As MaskedEditBox, _
                                  ByVal txtNacionalidade As MaskedEditBox, _
                                  ByVal cboEstadoCivil As UIComboBox, _
                                  ByVal txtCEP As MaskedEditBox, _
                                  ByVal cboPais As UIComboBox, _
                                  ByVal cboUF As UIComboBox, _
                                  ByVal cboMunicipio As UIComboBox, _
                                  ByVal txtLogradouro As MaskedEditBox, _
                                  ByVal txtNumero As MaskedEditBox, _
                                  ByVal txtBairro As MaskedEditBox, _
                                  ByVal txtComplemento As MaskedEditBox, _
                                  ByVal cboQualificacao As UIComboBox, _
                                  ByVal txtTelefone As MaskedEditBox, _
                                  ByVal txtEmail As MaskedEditBox, _
                                  ByVal txtTaxID As MaskedEditBox, _
                                  ByVal txtID As MaskedEditBox, _
                                  ByVal cboTipoSocietario As UIComboBox, _
                                  ByVal cboOrgaoRegistro As UIComboBox, _
                                  ByVal txtNIRE As MaskedEditBox, _
                                  ByVal dtpDataInicioAtividades As CalendarCombo, _
                                  ByVal txtNumeroRegistro As MaskedEditBox, _
                                  ByVal dtpDataRegistro As CalendarCombo, _
                                  ByVal txtRepresentanteLegal As MaskedEditBox, _
                                  ByVal txtNumeroCadastro As MaskedEditBox, _
                                  ByVal dtpDataAdmissao As CalendarCombo, _
                                  ByVal txtCidadeNascimento As MaskedEditBox, _
                                  ByVal dtpDataNascimento As CalendarCombo, _
                                  ByVal txtProfissao As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

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
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_parceiro_negocio_socios", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    txtNome.Text = oSqlDataReader.Item("nome")
                    txtCPFCNPJ.Text = oSqlDataReader.Item("cpf_cnpj")
                    txtRG.Text = oSqlDataReader.Item("rg")
                    txtNacionalidade.Text = oSqlDataReader.Item("nacionalidade")
                    cboEstadoCivil.SelectedValue = oSqlDataReader.Item("codigo_estado_civil")
                    txtCEP.Text = oSqlDataReader.Item("cep")
                    cboPais.SelectedValue = oSqlDataReader.Item("codigo_pais")
                    cboUF.SelectedValue = oSqlDataReader.Item("uf")
                    cboMunicipio.SelectedValue = oSqlDataReader.Item("codigo_municipio")
                    txtLogradouro.Text = oSqlDataReader.Item("logradouro")
                    txtNumero.Text = oSqlDataReader.Item("numero")
                    txtBairro.Text = oSqlDataReader.Item("bairro")
                    txtComplemento.Text = oSqlDataReader.Item("complemento")
                    cboQualificacao.SelectedValue = oSqlDataReader.Item("qualificacao")
                    txtTelefone.Text = oSqlDataReader.Item("telefone")
                    txtEmail.Text = oSqlDataReader.Item("email")
                    txtTaxID.Text = oSqlDataReader.Item("tax_id")
                    txtID.Text = oSqlDataReader.Item("id")
                    cboTipoSocietario.SelectedValue = oSqlDataReader.Item("tipo_societario")
                    cboOrgaoRegistro.SelectedValue = oSqlDataReader.Item("codigo_orgao_registro")
                    txtNIRE.Text = oSqlDataReader.Item("nire")
                    dtpDataInicioAtividades.Value = IIf(IsDBNull(oSqlDataReader.Item("data_inicio_atividades")), Now.Date, oSqlDataReader.Item("data_inicio_atividades"))
                    dtpDataInicioAtividades.Checked = IIf(IsDBNull(oSqlDataReader.Item("data_inicio_atividades")), False, True)
                    txtNumeroRegistro.Text = oSqlDataReader.Item("numero_registro")
                    dtpDataRegistro.Value = IIf(IsDBNull(oSqlDataReader.Item("data_registro")), Now.Date, oSqlDataReader.Item("data_registro"))
                    dtpDataRegistro.Checked = IIf(IsDBNull(oSqlDataReader.Item("data_registro")), False, True)
                    txtRepresentanteLegal.Text = oSqlDataReader.Item("representante_legal")
                    txtNumeroCadastro.Text = oSqlDataReader.Item("numero_cadastro")
                    dtpDataAdmissao.Value = IIf(IsDBNull(oSqlDataReader.Item("data_admissao_sociedade")), Now.Date, oSqlDataReader.Item("data_admissao_sociedade"))
                    dtpDataAdmissao.Checked = IIf(IsDBNull(oSqlDataReader.Item("data_admissao_sociedade")), False, True)
                    txtCidadeNascimento.Text = IIf(IsDBNull(oSqlDataReader.Item("cidade_nascimento")), "", oSqlDataReader.Item("cidade_nascimento"))
                    dtpDataNascimento.Value = IIf(IsDBNull(oSqlDataReader.Item("data_nascimento")), Now.Date, oSqlDataReader.Item("data_nascimento"))
                    dtpDataNascimento.Checked = IIf(IsDBNull(oSqlDataReader.Item("data_nascimento")), False, True)
                    txtProfissao.Text = IIf(IsDBNull(oSqlDataReader.Item("profissao")), "", oSqlDataReader.Item("profissao"))
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
    Public Sub LoadControlesSocioCPFCNPJ(ByVal sCPFCNPJ As String, _
                                         ByVal txtRazaoSocial As MaskedEditBox, _
                                          ByVal txtCEP As MaskedEditBox, _
                                          ByVal cboPais As UIComboBox, _
                                          ByVal cboUF As UIComboBox, _
                                          ByVal cboMunicipio As UIComboBox, _
                                          ByVal txtLogradouro As MaskedEditBox, _
                                          ByVal txtNumero As MaskedEditBox, _
                                          ByVal txtBairro As MaskedEditBox, _
                                          ByVal txtComplemento As MaskedEditBox, _
                                          ByVal txtTelefone As MaskedEditBox, _
                                          ByVal txtEmail As MaskedEditBox, _
                                          ByVal cboEstadoCivil As UIComboBox, _
                                          ByVal txtRG As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnpj_cpf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCPFCNPJ : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_parceiro_negocio_socios_cnpj_cpf", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    txtRazaoSocial.Text = oSqlDataReader.Item("razao_social")
                    txtCEP.Text = oSqlDataReader.Item("cep")
                    cboPais.SelectedValue = oSqlDataReader.Item("codigo_pais")
                    cboUF.SelectedValue = oSqlDataReader.Item("uf")
                    cboMunicipio.SelectedValue = oSqlDataReader.Item("codigo_municipio")
                    txtLogradouro.Text = oSqlDataReader.Item("logradouro")
                    txtNumero.Text = oSqlDataReader.Item("numero")
                    txtBairro.Text = oSqlDataReader.Item("bairro")
                    txtComplemento.Text = oSqlDataReader.Item("complemento")
                    txtTelefone.Text = oSqlDataReader.Item("telefone1")
                    txtEmail.Text = oSqlDataReader.Item("email")
                    cboEstadoCivil.SelectedValue = oSqlDataReader.Item("codigo_estado_civil")
                    txtRG.Text = oSqlDataReader.Item("rg")

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

#Region "::: FILIAL :::"

    Public Sub InsertFilial(ByVal iCodigoParceiroNegocio As Integer, _
                               ByVal iCodigoFilial As Integer)

        'Variaveis Locais
        Dim oSqlParameter(20) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_filial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoFilial : i += 1


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_parceiro_negocio_filial", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteFilial(ByVal iCodigoParceiroNegocio As Integer)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                i = 0

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_parceiro_negocio_filial", oSqlParameter)

                'Deleta Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridFilial(ByVal oGrid As GridEX, _
                             ByVal iCodigoParceiroNegocio As Integer, _
                             ByVal iCodigoEmpresa As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(19) As SqlParameter
        Dim i As Integer = 0

        Try


            'Seta Parametros - Número Orçamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoEmpresa : i += 1


            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_filial", oSqlParameter)

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

#Region "::: CNAE :::"

    Public Sub InsertCNAE(ByVal iCodigoParceiroNegocio As Integer, _
                              ByVal iCodigoCNAE As Integer)

        'Variaveis Locais
        Dim oSqlParameter(20) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cnae"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoCNAE : i += 1


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_parceiro_negocio_cnae", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteCNAE(ByVal iCodigoParceiroNegocio As Integer)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                i = 0

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_parceiro_negocio_cnae", oSqlParameter)

                'Deleta Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridCNAE(ByVal oGrid As GridEX, _
                             ByVal iCodigoParceiroNegocio As Integer, _
                             ByVal iCodigoEmpresa As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(19) As SqlParameter
        Dim i As Integer = 0

        Try


            'Seta Parametros - Número Orçamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoEmpresa : i += 1


            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_cnae", oSqlParameter)

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

#Region "::: CONTA BANCÁRIA  :::"

    Public Sub InsertConta(ByVal sAgencia As String, _
                           ByVal sConta As String, _
                           ByVal iCodigoBanco As Integer, _
                           ByVal iCodigoParceiro As Integer)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Agencia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "agencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sAgencia : i += 1

            'Seta Parametros - Codigo Parceiro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoParceiro : i += 1

            'Seta Parametros - Conta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sConta : i += 1

            'Seta Parametros - Codigo Banco
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoBanco : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_parceiro_negocio_conta", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateConta(ByVal sAgencia As String, _
                           ByVal sConta As String, _
                           ByVal iCodigoBanco As Integer, _
                           ByVal iCodigo As Integer, _
                           ByVal iCodigoParceiro As Integer)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Codigo Parceiro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoParceiro : i += 1

            'Seta Parametros - Agencia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "agencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sAgencia : i += 1

            'Seta Parametros - Conta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sConta : i += 1

            'Seta Parametros - Codigo Banco
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoBanco : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_parceiro_negocio_conta", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteConta(ByVal iCodigo As Integer)

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

                'Seta Parametros - Código Parceiro
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
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
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_parceiro_negocio_conta", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridConta(ByVal oGrid As GridEX, _
                             ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Parceiro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
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
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_conta", oSqlParameter)

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

#Region "::: ADIANTAMENTO :::"

    Public Sub LoadDadosAdiantamento(ByVal iCodigoParceiroNegocio As Integer,
                                     ByVal sTipo As String,
                                     ByVal txtValorAdiantamento As NumericEditBox,
                                     ByVal txtValorAdiantamentoUtilizado As NumericEditBox,
                                     ByVal txtValorAdiantamentoSaldo As NumericEditBox)
        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer

        Try

            'Seta Parametros - Código Parceiro Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = sTipo

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_adiantamento_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Seta Controle
                txtValorAdiantamento.Value = oSqlDataReader.Item("valor_adiantamento")
                txtValorAdiantamentoUtilizado.Value = oSqlDataReader.Item("valor_adiantamento_utilizado")
                txtValorAdiantamentoSaldo.Value = oSqlDataReader.Item("valor_adiantamento_saldo")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close() : oSqlDataReader = Nothing

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub SalvarAdiantamento(ByVal iCodigoParceiroNegocio As Integer,
                                  ByVal sTipo As String,
                                  ByVal dValor As Double)
        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer

        Try

            'Seta Parametros - Código Parceiro Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = sTipo : i += 1

            'Seta Parametros - Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValor : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_adiantamento_saldo_inicial", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridAdiantamento(ByVal oGrid As GridEX,
                                    ByVal iCodigoParceiroNegocio As Integer,
                                    ByVal sTipo As String)
        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim oDataSet As DataSet
        Dim i As Integer

        Try

            'Seta Parametros - Código Parceiro Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = sTipo

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_adiantamento", oSqlParameter)

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

    Public Sub LoadGridAdiantamentoUtilizado(ByVal oGrid As GridEX,
                                             ByVal iCodigoParceiroNegocio As Integer,
                                             ByVal sTipo As String)
        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim oDataSet As DataSet
        Dim i As Integer

        Try

            'Seta Parametros - Código Parceiro Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = sTipo

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_adiantamento_utilizado", oSqlParameter)

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

    Public Sub LoadGridAdiantamentoSaldo(ByVal oGrid As GridEX,
                                         ByVal iCodigoParceiroNegocio As Integer,
                                         ByVal sTipo As String)
        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim oDataSet As DataSet
        Dim i As Integer

        Try

            'Seta Parametros - Código Parceiro Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = sTipo

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_adiantamento_saldo", oSqlParameter)

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

#Region "CHECKLIST CLIENTE"

    Public Sub InsertChecklistCliente(ByVal lCodigoParceiroNegocio As Long,
                                      ByVal sDescricao As String,
                                      ByVal bImpressoProposta As Boolean,
                                      ByVal bExportadoParaOP As Boolean)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0
        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = lCodigoParceiroNegocio : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDescricao : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "impresso_proposta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bImpressoProposta : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "exportado_ordem_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bExportadoParaOP : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_cadastro_basico_parceiro_negocio_checklist_cliente", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridChecklistCliente(ByVal oGrid As GridEX,
                                        ByVal lCodigoParceiroNegocio As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = lCodigoParceiroNegocio : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_parceiro_negocio_checklist_cliente", oSqlParameter)

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

    Public Sub DeleteChecklistCliente(ByVal lCodigoParceiroNegocio As Long,
                                      ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = lCodigoParceiroNegocio : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigo : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_cadastro_basico_parceiro_negocio_checklist_cliente", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateChecklistCliente(ByVal lCodigoParceiroNegocio As Long,
                                      ByVal iCodigoCheklistCliente As Integer,
                                      ByVal bImpressoProposta As Boolean,
                                      ByVal bExportadoParaOP As Boolean)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0
        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = lCodigoParceiroNegocio : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoCheklistCliente : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "impresso_proposta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bImpressoProposta : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "exportado_ordem_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bExportadoParaOP

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_parceiro_negocio_checklist_cliente", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class
