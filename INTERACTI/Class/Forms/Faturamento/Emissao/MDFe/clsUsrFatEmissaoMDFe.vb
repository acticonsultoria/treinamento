Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.CalendarCombo
Imports Janus.Windows.EditControls
Imports System.IO

Public Class clsUsrFatEmissaoMDFe

#Region "::: VARIAVEIS :::"

#Region "::: VARIAVEIS - CAPA :::"

    'Variaveis da Classe - dados mdfe
    Private iCodigoModeloManifestoEletronico As Integer
    Private iSerie As Integer
    Private lCodigoEmissaoCapa As Long
    Private iNumeroMDFe As Integer
    Private sDataEmissao As String
    Private sDataSaida As String
    Private sUFCapa As String
    Private iCodigoTipoEmitente As Integer
    Private iCodigoModalidade As Integer
    Private iCodigoFormaEmissaoMDFe As Integer
    Private sUFDescarregamento As String

    'variaveis da classe - carregamento
    Private sUFCarregamento As String
    Private iCodigoMunicipioCarregamento As Integer

    'variaveis da classe - percurso
    Private sUFPercurso As String


#End Region

#Region "::: VARIAVEIS - RODOVIÁRIO :::"

    'Variaveis do Veiculo
    Private sRntrcVeiculo As String
    Private iCiotVeiculo As Integer
    Private iCodigoAgendamentoPortoVeiculo As Integer
    Private iCodigoInternoVeiculo As Integer
    Private iCodigoTipoCarroceriaVeiculo As Integer
    Private sPlacaVeiculo As String
    Private iTaraKgVeiculo As Integer
    Private iRenavamVeiculo As Integer
    Private sUFVeiculo As String
    Private iCodigoTipoRodadoVeiculo As Integer
    Private iCapacidadeKgVeiculo As Integer
    Private iCapacidadeM3Veiculo As Integer

    'Variaveis do Proprietario
    Private bPropriedadeVeiculo As Boolean
    Private sRntrcProprietarioVeiculo As String
    Private iCodigoTipoProprietarioVeiculo As Integer
    Private sUFProprietarioVeiculo As String
    Private sCPFCNPJProprietarioVeiculo As String
    Private sNomeProprietarioVeiculo As String
    Private sIEProprietarioVeiculo As String

    'Variaveis do Condutor
    Private sNomeCondutorVeiculo As String
    Private sCPFCondutorVeiculo As String

    'Variaveis do Reboque
    Private iCodigoInternoReboque As Integer
    Private iCodigoTipoCarroceriaReboque As Integer
    Private sPlacaReboque As String
    Private iTaraKgReboque As Integer
    Private iRenavamReboque As String
    Private sUFLicenciamentoReboque As String
    Private iCodigoTipoRodadoReboque As Integer
    Private iCapacidadeKgReboque As Integer
    Private iCapacidadeM3Reboque As Integer

    'Variaveis do Propriétario do veiculo de reboque 
    Private bPropriedadeReboque As Boolean
    Private sRntrcProprietarioReboque As String
    Private iCodigoTipoProprietatioReboque As Integer
    Private sUFProprietarioReboque As String
    Private sCPFCNPJProprietarioReboque As String
    Private sNomeProprietarioReboque As String
    Private iIEProprietarioReboque As Integer

    'Variaveis do Vale Pedagio
    Private sCNPJAgenciaValePedagio As String
    Private iNumeroComprovanteValePedagio As Integer
    Private sCNPJResponsavelValePedagio As String



#End Region

#Region "::: VARIAVEIS - AQUAVIÁRIO :::"

    'Váriaveis da Classe - Dados
    Private sCNPJAgencia As String
    Private iCodigoTipoEmbarcacao As Integer
    Private iCodigoEmbarcacao As Integer
    Private iNumeroViagem As Integer
    Private sNomeEmbarcacao As String
    Private iCodigoPortoEmbarque As Integer
    Private iCodigoPortoDestino As Integer

    'variaveis da classe - carregamento 
    Private iCodigoTerminalCarregamento As Integer
    Private sNomeTerminalCarregamento As String

    'Variaveis da Classe - Descarregamento 
    Private iCodigoTerminalDescarregamento As Integer
    Private sNomeTerminalDescarregamento As String

    'Variaveis da Classe - Comboio
    Private iCodigoEmbarcacaoComboio As Integer

    'Variaveis da Classe - Unidade Carga Vazia
    Private sIdentificacaoUnidadeCarga As String
    Private iCodigoTipoUnidade As Integer
    Private iQuantidadeRateadaUnidade As Integer
    Private iNumeroLacreUnidade As Integer

#End Region

#Region "::: VARIAVEIS - INFORMAÇÕES DOCUMENTOS :::"

    'Váriaveis da Classe - Descarregamento 
    Private sUFDescarregamentoDocumentos As String
    Private iCodigoMunicipioDocumentos As Integer

    ''Variaveis da Classe - Nota Fiscal 
    'Private sUFNotaFiscal As String
    'Private iCodigoMunicipioNotaFiscal As Integer
    'Private iChaveAcessoNotaFiscal As Integer
    'Private iCodigoUnidadeTransporteNotaFiscal As Integer

    ''Variaveis da Classe - MDF-e Referenciada
    'Private sUFReferenciada As String
    'Private iCodigoMunicipioReferenciada As Integer
    'Private iChaveAcessoReferenciada As Integer
    'Private iCodigoUnidadeTransporteReferenciada As Integer

#End Region

#Region "::: VARIAVEIS - TOTAL :::"

    'Váriaveis da Classe - Totais
    Private iQuantidadeTotalCTe As Integer
    Private iQuantidadeTotalNFe As Integer
    Private iQuantidadeTotalNFMod As Integer
    Private dTotalCargaTransportada As Double
    Private iCodigoUnidadeMedida As Integer
    Private dPesoBrutoTotalCarga As Double

    'Variaveis da Classe - Lacres
    Private iNumeroLacres As Integer

    'Variaveis da Classe - Autorizados para Download 
    Private sCNPJCPFAutorizados As String

#End Region

#Region "::: VARIAVEIS - INFORMAÇÕES ADICIONAIS :::"

    Private sInformacaoAdicionalFisco As String
    Private sInformacaoAdicionalContribuinte As String

#End Region

#End Region

#Region "::: PROPERTIE :::"

#Region "::: PROPERTIE - CAPA :::"

    'variaveis da classe - dados mdfe

    Public Property CodigoModeloManifestoEletronico() As Integer
        Get
            Return iCodigoModeloManifestoEletronico
        End Get
        Set(ByVal value As Integer)
            iCodigoModeloManifestoEletronico = value
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

    Public Property NumeroMDFe() As Integer
        Get
            Return iNumeroMDFe
        End Get
        Set(ByVal value As Integer)
            iNumeroMDFe = value
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

    Public Property DataEmissao() As String
        Get
            Return sDataEmissao
        End Get
        Set(ByVal value As String)
            sDataEmissao = value
        End Set
    End Property

    Public Property DataSaida() As String
        Get
            Return sDataSaida
        End Get
        Set(ByVal value As String)
            sDataSaida = value
        End Set
    End Property

    Public Property UFCapa() As String
        Get
            Return sUFCapa
        End Get
        Set(ByVal value As String)
            sUFCapa = value
        End Set
    End Property

    Public Property CodigoTipoEmitente() As Integer
        Get
            Return iCodigoTipoEmitente
        End Get
        Set(ByVal value As Integer)
            iCodigoTipoEmitente = value
        End Set
    End Property

    Public Property CodigoModalidade() As Integer
        Get
            Return iCodigoModalidade
        End Get
        Set(ByVal value As Integer)
            iCodigoModalidade = value
        End Set
    End Property

    Public Property CodigoFormaEmissaoMDFe() As Integer
        Get
            Return iCodigoFormaEmissaoMDFe
        End Get
        Set(ByVal value As Integer)
            iCodigoFormaEmissaoMDFe = value
        End Set
    End Property

    Public Property UFDescarregamento() As String
        Get
            Return sUFDescarregamento
        End Get
        Set(ByVal value As String)
            sUFDescarregamento = value
        End Set
    End Property

    'variaveis da classe - carregamento
    Public Property UFCarregamento() As String
        Get
            Return sUFCarregamento
        End Get
        Set(ByVal value As String)
            sUFCarregamento = value
        End Set
    End Property

    Public Property CodigoMunicipioCarregamento() As Integer
        Get
            Return iCodigoMunicipioCarregamento
        End Get
        Set(ByVal value As Integer)
            iCodigoMunicipioCarregamento = value
        End Set
    End Property

    'variaveis da classe - percurso
    Public Property UFPercurso() As String
        Get
            Return sUFPercurso
        End Get
        Set(ByVal value As String)
            sUFPercurso = value
        End Set
    End Property

#End Region

#Region "::: PROPERTIE - RODOVIÁRIO :::"

    Public Property RntrcVeiculo() As String
        Get
            Return sRntrcVeiculo
        End Get
        Set(ByVal value As String)
            sRntrcVeiculo = value
        End Set
    End Property

    Public Property CiotVeiculo() As Integer
        Get
            Return iCiotVeiculo
        End Get
        Set(ByVal value As Integer)
            iCiotVeiculo = value
        End Set
    End Property

    Public Property CodigoAgendamentoPortoVeiculo() As Integer
        Get
            Return iCodigoAgendamentoPortoVeiculo
        End Get
        Set(ByVal value As Integer)
            iCodigoAgendamentoPortoVeiculo = value
        End Set
    End Property

    Public Property CodigoInternoVeiculo() As Integer
        Get
            Return iCodigoInternoVeiculo
        End Get
        Set(ByVal value As Integer)
            iCodigoInternoVeiculo = value
        End Set
    End Property

    Public Property CodigoTipoCarroceriaVeiculo() As Integer
        Get
            Return iCodigoTipoCarroceriaVeiculo
        End Get
        Set(ByVal value As Integer)
            iCodigoTipoCarroceriaVeiculo = value
        End Set
    End Property

    Public Property PlacaVeiculo() As String
        Get
            Return sPlacaVeiculo
        End Get
        Set(ByVal value As String)
            sPlacaVeiculo = value
        End Set
    End Property

    Public Property TaraKgVeiculo() As Integer
        Get
            Return iTaraKgVeiculo
        End Get
        Set(ByVal value As Integer)
            iTaraKgVeiculo = value
        End Set
    End Property

    Public Property RenavamVeiculo() As Integer
        Get
            Return iRenavamVeiculo
        End Get
        Set(ByVal value As Integer)
            iRenavamVeiculo = value
        End Set
    End Property

    Public Property UFVeiculo() As String
        Get
            Return sUFVeiculo
        End Get
        Set(ByVal value As String)
            sUFVeiculo = value
        End Set
    End Property

    Public Property CodigoTipoRodadoVeiculo() As Integer
        Get
            Return iCodigoTipoRodadoVeiculo
        End Get
        Set(ByVal value As Integer)
            iCodigoTipoRodadoVeiculo = value
        End Set
    End Property

    Public Property CapacidadeKgVeiculo() As Integer
        Get
            Return iCapacidadeKgVeiculo
        End Get
        Set(ByVal value As Integer)
            iCapacidadeKgVeiculo = value
        End Set
    End Property

    Public Property CapacidadeM3Veiculo() As Integer
        Get
            Return iCapacidadeM3Veiculo
        End Get
        Set(ByVal value As Integer)
            iCapacidadeM3Veiculo = value
        End Set
    End Property

    'Variaveis do Proprietario
    Public Property PropriedadeVeiculo() As Boolean
        Get
            Return bPropriedadeVeiculo
        End Get
        Set(ByVal value As Boolean)
            bPropriedadeVeiculo = value
        End Set
    End Property

    Public Property RntrcProprietarioVeiculo() As String
        Get
            Return sRntrcProprietarioVeiculo
        End Get
        Set(ByVal value As String)
            sRntrcProprietarioVeiculo = value
        End Set
    End Property

    Public Property CodigoTipoProprietarioVeiculo() As Integer
        Get
            Return iCodigoTipoProprietarioVeiculo
        End Get
        Set(ByVal value As Integer)
            iCodigoTipoProprietarioVeiculo = value
        End Set
    End Property

    Public Property UFProprietarioVeiculo() As String
        Get
            Return sUFProprietarioVeiculo
        End Get
        Set(ByVal value As String)
            sUFProprietarioVeiculo = value
        End Set
    End Property

    Public Property CPFCNPJProprietarioVeiculo() As String
        Get
            Return sCPFCNPJProprietarioVeiculo
        End Get
        Set(ByVal value As String)
            sCPFCNPJProprietarioVeiculo = value
        End Set
    End Property

    Public Property NomeProprietarioVeiculo() As String
        Get
            Return sNomeProprietarioVeiculo
        End Get
        Set(ByVal value As String)
            sNomeProprietarioVeiculo = value
        End Set
    End Property

    Public Property IEProprietarioVeiculo() As String
        Get
            Return sIEProprietarioVeiculo
        End Get
        Set(ByVal value As String)
            sIEProprietarioVeiculo = value
        End Set
    End Property

    'Variaveis do Condutor
    Public Property CPFCondutorVeiculo() As String
        Get
            Return sCPFCondutorVeiculo
        End Get
        Set(ByVal value As String)
            sCPFCondutorVeiculo = value
        End Set
    End Property

    Public Property NomeCondutorVeiculo() As String
        Get
            Return sNomeCondutorVeiculo
        End Get
        Set(ByVal value As String)
            sNomeCondutorVeiculo = value
        End Set
    End Property

    'Variaveis do Reboque
    Public Property CapacidadeM3Reboque() As Integer
        Get
            Return iCapacidadeM3Reboque
        End Get
        Set(ByVal value As Integer)
            iCapacidadeM3Reboque = value
        End Set
    End Property

    Public Property CapacidadeKgReboque() As Integer
        Get
            Return iCapacidadeKgReboque
        End Get
        Set(ByVal value As Integer)
            iCapacidadeKgReboque = value
        End Set
    End Property

    Public Property CodigoTipoRodadoReboque() As Integer
        Get
            Return iCodigoTipoRodadoReboque
        End Get
        Set(ByVal value As Integer)
            iCodigoTipoRodadoReboque = value
        End Set
    End Property

    Public Property UFLicenciamentoReboque() As String
        Get
            Return sUFLicenciamentoReboque
        End Get
        Set(ByVal value As String)
            sUFLicenciamentoReboque = value
        End Set
    End Property

    Public Property RenavamReboque() As Integer
        Get
            Return iRenavamReboque
        End Get
        Set(ByVal value As Integer)
            iRenavamReboque = value
        End Set
    End Property

    Public Property TaraKgReboque() As Integer
        Get
            Return iTaraKgReboque
        End Get
        Set(ByVal value As Integer)
            iTaraKgReboque = value
        End Set
    End Property

    Public Property PlacaReboque() As String
        Get
            Return sPlacaReboque
        End Get
        Set(ByVal value As String)
            sPlacaReboque = value
        End Set
    End Property

    Public Property CodigoTipoCarroceriaReboque() As Integer
        Get
            Return iCodigoTipoCarroceriaReboque
        End Get
        Set(ByVal value As Integer)
            iCodigoTipoCarroceriaReboque = value
        End Set
    End Property

    Public Property CodigoInternoReboque() As Integer
        Get
            Return iCodigoInternoReboque
        End Get
        Set(ByVal value As Integer)
            iCodigoInternoReboque = value
        End Set
    End Property

    'Variaveis do Propriétario do veiculo de reboque 
    Public Property PropriedadeReboque() As Boolean
        Get
            Return bPropriedadeReboque
        End Get
        Set(ByVal value As Boolean)
            bPropriedadeReboque = value
        End Set
    End Property
    
    Public Property IEProprietarioReboque() As Integer
        Get
            Return iIEProprietarioReboque
        End Get
        Set(ByVal value As Integer)
            iIEProprietarioReboque = value
        End Set
    End Property

    Public Property NomeProprietarioReboque() As String
        Get
            Return sNomeProprietarioReboque
        End Get
        Set(ByVal value As String)
            sNomeProprietarioReboque = value
        End Set
    End Property

    Public Property CPFCNPJProprietarioReboque() As String
        Get
            Return sCPFCNPJProprietarioReboque
        End Get
        Set(ByVal value As String)
            sCPFCNPJProprietarioReboque = value
        End Set
    End Property

    Public Property UFProprietarioReboque() As String
        Get
            Return sUFProprietarioReboque
        End Get
        Set(ByVal value As String)
            sUFProprietarioReboque = value
        End Set
    End Property

    Public Property CodigoTipoProprietatioReboque() As Integer
        Get
            Return iCodigoTipoProprietatioReboque
        End Get
        Set(ByVal value As Integer)
            iCodigoTipoProprietatioReboque = value
        End Set
    End Property

    Public Property RntrcProprietarioReboque() As String
        Get
            Return sRntrcProprietarioReboque
        End Get
        Set(ByVal value As String)
            sRntrcProprietarioReboque = value
        End Set
    End Property

    'Variaveis do Vale Pedagio
    Public Property CNPJResponsavelValePedagio() As String
        Get
            Return sCNPJResponsavelValePedagio
        End Get
        Set(ByVal value As String)
            sCNPJResponsavelValePedagio = value
        End Set
    End Property

    Public Property CNPJAgenciaValePedagio() As String
        Get
            Return sCNPJAgenciaValePedagio
        End Get
        Set(ByVal value As String)
            sCNPJAgenciaValePedagio = value
        End Set
    End Property

    Public Property NumeroComprovanteValePedagio() As Integer
        Get
            Return iNumeroComprovanteValePedagio
        End Get
        Set(ByVal value As Integer)
            iNumeroComprovanteValePedagio = value
        End Set
    End Property

#End Region

#Region "::: PROPERTIE - AQUAVIÁRIO :::"

    'Váriaveis da Classe - Dados
    Public Property CNPJAgencia() As String
        Get
            Return sCNPJAgencia
        End Get
        Set(ByVal value As String)
            sCNPJAgencia = value
        End Set
    End Property

    Public Property CodigoTipoEmbarcacao() As Integer
        Get
            Return iCodigoTipoEmbarcacao
        End Get
        Set(ByVal value As Integer)
            iCodigoTipoEmbarcacao = value
        End Set
    End Property

    Public Property CodigoEmbarcacao() As Integer
        Get
            Return iCodigoEmbarcacao
        End Get
        Set(ByVal value As Integer)
            iCodigoEmbarcacao = value
        End Set
    End Property

    Public Property NumeroViagem() As Integer
        Get
            Return iNumeroViagem
        End Get
        Set(ByVal value As Integer)
            iNumeroViagem = value
        End Set
    End Property

    Public Property NomeEmbarcacao() As String
        Get
            Return sNomeEmbarcacao
        End Get
        Set(ByVal value As String)
            sNomeEmbarcacao = value
        End Set
    End Property

    Public Property CodigoPortoEmbarque() As Integer
        Get
            Return iCodigoPortoEmbarque
        End Get
        Set(ByVal value As Integer)
            iCodigoPortoEmbarque = value
        End Set
    End Property

    Public Property CodigoPortoDestino() As Integer
        Get
            Return iCodigoPortoDestino
        End Get
        Set(ByVal value As Integer)
            iCodigoPortoDestino = value
        End Set
    End Property

    'variaveis da classe - carregamento 
    Public Property CodigoTerminalCarregamento() As Integer
        Get
            Return iCodigoTerminalCarregamento
        End Get
        Set(ByVal value As Integer)
            iCodigoTerminalCarregamento = value
        End Set
    End Property

    Public Property NomeTerminalCarregamento() As String
        Get
            Return sNomeTerminalCarregamento
        End Get
        Set(ByVal value As String)
            sNomeTerminalCarregamento = value
        End Set
    End Property

    'Variaveis da Classe - Descarregamento 
    Public Property CodigoTerminalDescarregamento() As Integer
        Get
            Return iCodigoTerminalDescarregamento
        End Get
        Set(ByVal value As Integer)
            iCodigoTerminalDescarregamento = value
        End Set
    End Property

    Public Property NomeTerminalDescarregamento() As String
        Get
            Return sNomeTerminalDescarregamento
        End Get
        Set(ByVal value As String)
            sNomeTerminalDescarregamento = value
        End Set
    End Property

    'Variaveis da Classe - Comboio
    Public Property CodigoEmbarcacaoComboio() As Integer
        Get
            Return iCodigoEmbarcacaoComboio
        End Get
        Set(ByVal value As Integer)
            iCodigoEmbarcacaoComboio = value
        End Set
    End Property

    'Variaveis da Classe - Unidade Carga Vazia
    Public Property IdentificacaoUnidadeCarga() As String
        Get
            Return sIdentificacaoUnidadeCarga
        End Get
        Set(ByVal value As String)
            sIdentificacaoUnidadeCarga = value
        End Set
    End Property

    Public Property CodigoTipoUnidade() As Integer
        Get
            Return iCodigoTipoUnidade
        End Get
        Set(ByVal value As Integer)
            iCodigoTipoUnidade = value
        End Set
    End Property

    Public Property QuantidadeRateadaUnidade() As Integer
        Get
            Return iQuantidadeRateadaUnidade
        End Get
        Set(ByVal value As Integer)
            iQuantidadeRateadaUnidade = value
        End Set
    End Property

    Public Property NumeroLacreUnidade() As Integer
        Get
            Return iNumeroLacreUnidade
        End Get
        Set(ByVal value As Integer)
            iNumeroLacreUnidade = value
        End Set
    End Property

#End Region

#Region "::: PROPERTIE - INFORMAÇÕES DOCUMENTOS :::"

    Public Property UFDescarregamentoDocumentos() As String
        Get
            Return sUFDescarregamentoDocumentos
        End Get
        Set(ByVal value As String)
            sUFDescarregamentoDocumentos = value
        End Set
    End Property

    Public Property CodigoMunicipioDocumentos() As Integer
        Get
            Return iCodigoMunicipioDocumentos
        End Get
        Set(ByVal value As Integer)
            iCodigoMunicipioDocumentos = value
        End Set
    End Property

    'Public Property UFNotaFiscal() As String
    '    Get
    '        Return sUFNotaFiscal
    '    End Get
    '    Set(ByVal value As String)
    '        sUFNotaFiscal = value
    '    End Set
    'End Property

    'Public Property CodigoMunicipioNotaFiscal() As Integer
    '    Get
    '        Return iCodigoMunicipioNotaFiscal
    '    End Get
    '    Set(ByVal value As Integer)
    '        iCodigoMunicipioNotaFiscal = value
    '    End Set
    'End Property

    'Public Property ChaveAcessoNotaFiscal() As Integer
    '    Get
    '        Return iChaveAcessoNotaFiscal
    '    End Get
    '    Set(ByVal value As Integer)
    '        iChaveAcessoNotaFiscal = value
    '    End Set
    'End Property

    'Public Property CodigoUnidadeTransporteNotaFiscal() As Integer
    '    Get
    '        Return iCodigoUnidadeTransporteNotaFiscal
    '    End Get
    '    Set(ByVal value As Integer)
    '        iCodigoUnidadeTransporteNotaFiscal = value
    '    End Set
    'End Property

    'Public Property UFReferenciada() As String
    '    Get
    '        Return sUFReferenciada
    '    End Get
    '    Set(ByVal value As String)
    '        sUFReferenciada = value
    '    End Set
    'End Property

    'Public Property CodigoMunicipioReferenciada() As Integer
    '    Get
    '        Return iCodigoMunicipioReferenciada
    '    End Get
    '    Set(ByVal value As Integer)
    '        iCodigoMunicipioReferenciada = value
    '    End Set
    'End Property

    'Public Property ChaveAcessoReferenciada() As Integer
    '    Get
    '        Return iChaveAcessoReferenciada
    '    End Get
    '    Set(ByVal value As Integer)
    '        iChaveAcessoReferenciada = value
    '    End Set
    'End Property

    'Public Property CodigoUnidadeTransporteReferenciada() As Integer
    '    Get
    '        Return iCodigoUnidadeTransporteReferenciada
    '    End Get
    '    Set(ByVal value As Integer)
    '        iCodigoUnidadeTransporteReferenciada = value
    '    End Set
    'End Property

#End Region

#Region "::: PROPERTIE - TOTAL :::"

    Public Property CNPJCPFAutorizados() As String
        Get
            Return sCNPJCPFAutorizados
        End Get
        Set(ByVal value As String)
            sCNPJCPFAutorizados = value
        End Set
    End Property

    Public Property NumeroLacres() As Integer
        Get
            Return iNumeroLacres
        End Get
        Set(ByVal value As Integer)
            iNumeroLacres = value
        End Set
    End Property

    Public Property PesoBrutoTotalCarga() As Double
        Get
            Return dPesoBrutoTotalCarga
        End Get
        Set(ByVal value As Double)
            dPesoBrutoTotalCarga = value
        End Set
    End Property

    Public Property CodigoUnidadeMedida() As Integer
        Get
            Return iCodigoUnidadeMedida
        End Get
        Set(ByVal value As Integer)
            iCodigoUnidadeMedida = value
        End Set
    End Property

    Public Property TotalCargaTransportada() As Double
        Get
            Return dTotalCargaTransportada
        End Get
        Set(ByVal value As Double)
            dTotalCargaTransportada = value
        End Set
    End Property

    Public Property QuantidadeTotalNFMod() As Integer
        Get
            Return iQuantidadeTotalNFMod
        End Get
        Set(ByVal value As Integer)
            iQuantidadeTotalNFMod = value
        End Set
    End Property

    Public Property QuantidadeTotalNFe() As Integer
        Get
            Return iQuantidadeTotalNFe
        End Get
        Set(ByVal value As Integer)
            iQuantidadeTotalNFe = value
        End Set
    End Property

    Public Property QuantidadeTotalCTe() As Integer
        Get
            Return iQuantidadeTotalCTe
        End Get
        Set(ByVal value As Integer)
            iQuantidadeTotalCTe = value
        End Set
    End Property

#End Region

#Region "::: PROPERTIE - INFORMAÇÃO ADICIONAL :::"

    Public Property InformacaoAdicionalFisco() As String
        Get
            Return sInformacaoAdicionalFisco
        End Get
        Set(ByVal value As String)
            sInformacaoAdicionalFisco = value
        End Set
    End Property

    Public Property InformacaoAdicionalContribuinte() As String
        Get
            Return sInformacaoAdicionalContribuinte
        End Get
        Set(ByVal value As String)
            sInformacaoAdicionalContribuinte = value
        End Set
    End Property

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: MANIFESTO ELETRÔNICO :::"

#Region "::: CAPA :::"

    Public Sub ImportarNFe(ByVal oGrid As GridEX, _
                        ByVal lCodigoEmissaoCapa As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter

        Try



            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = goUsuario.iEmpresa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = lCodigoEmissaoCapa

            For Each oRow In oGrid.GetCheckedRows

                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "codigo_emissao_capa"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.BigInt
                oSqlParameter(2).Value = oRow.Cells.Item("codigo_emissao_capa").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_mdfe_importar_nfe", oSqlParameter)

            Next
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try


    End Sub

    Public Sub LoadGridNFeImportar(ByVal oGrid As GridEX, _
                        ByVal lCodigoEmissaoCapa As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter

        Try



            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = goUsuario.iEmpresa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_emissao_capa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = lCodigoEmissaoCapa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_mdfe_importar_nfe", oSqlParameter)

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

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal lNumeroDocumento As Long, _
                        ByVal sSerie As String, _
                        ByVal sDataEmissaoInicio As String, _
                        ByVal sDataEmissaoTermino As String, _
                        ByVal sDataSaidaInicio As String, _
                        ByVal sDataSaidaTermino As String, _
                        ByVal iCodigoModalidade As Integer, _
                        ByVal iCodigoTipoEmissao As Integer, _
                        ByVal sUFDescarregamento As String, _
                        ByVal sStatus As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(10) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "numero_documento"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = IIf(lNumeroDocumento = -1, DBNull.Value, lNumeroDocumento)

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "serie"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Value = sSerie

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "data_emissao_inicio"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.DateTime
            oSqlParameter(2).Value = IIf(sDataEmissaoInicio = "", DBNull.Value, sDataEmissaoInicio)

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "data_emissao_termino"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.DateTime
            oSqlParameter(3).Value = IIf(sDataEmissaoTermino = "", DBNull.Value, sDataEmissaoTermino)

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "data_saida_inicio"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.DateTime
            oSqlParameter(4).Value = IIf(sDataSaidaInicio = "", DBNull.Value, sDataSaidaInicio)

            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "data_saida_termino"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.DateTime
            oSqlParameter(5).Value = IIf(sDataSaidaTermino = "", DBNull.Value, sDataSaidaTermino)

            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "codigo_modalidade"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.Int
            oSqlParameter(6).Value = IIf(iCodigoModalidade = -1, -1, iCodigoModalidade)

            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "codigo_tipo_emissao"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.Int
            oSqlParameter(7).Value = IIf(iCodigoTipoEmissao = -1, -1, iCodigoTipoEmissao)

            oSqlParameter(8) = New SqlParameter
            oSqlParameter(8).ParameterName = "uf_descarregamento"
            oSqlParameter(8).Direction = ParameterDirection.Input
            oSqlParameter(8).SqlDbType = SqlDbType.VarChar
            oSqlParameter(8).Value = IIf(sUFDescarregamento = "", "", sUFDescarregamento)

            oSqlParameter(9) = New SqlParameter
            oSqlParameter(9).ParameterName = "status"
            oSqlParameter(9).Direction = ParameterDirection.Input
            oSqlParameter(9).SqlDbType = SqlDbType.VarChar
            oSqlParameter(9).Value = sStatus

            oSqlParameter(10) = New SqlParameter
            oSqlParameter(10).ParameterName = "codigo_empresa"
            oSqlParameter(10).Direction = ParameterDirection.Input
            oSqlParameter(10).SqlDbType = SqlDbType.Int
            oSqlParameter(10).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_mdfe", oSqlParameter)

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

    Public Sub InsertManifesto()

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = goUsuario.iEmpresa

            'Seta Parametros - Código Usuário
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_usuario"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Int
            oSqlParameter(1).Value = goUsuario.iUsuario

            'Seta Parametros - Status
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "status"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(2).Value = StatusManifestoEletronico.AguardandoTransmissao

            'Seta Parametros - Código Tipo Nota Fiscal
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_tipo_manifesto_eletronico"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(3).Value = TipoNotaFiscal.ManifestoEletronico

            'Seta Parametros - Código
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "codigo"
            oSqlParameter(4).Direction = ParameterDirection.Output
            oSqlParameter(4).SqlDbType = SqlDbType.BigInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_mdfe_capa", oSqlParameter)

            'Seta Váriavel 
            lCodigoEmissaoCapa = oSqlParameter(4).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteManifesto()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter

        Try
            'Exclui Registro
            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Parametros - Código
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_emissao_capa"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = oRow.Cells("codigo_emissao_capa").Value

                'Seta Parametros - Código Empresa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_empresa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(1).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_mdfe_capa", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateManifesto()

        'Variaveis Locais
        Dim oSqlParameter(13) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(0).Value = goUsuario.iEmpresa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_modelo_mdfe"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = iCodigoModeloManifestoEletronico

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "numero_mdfe"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.BigInt
            oSqlParameter(2).Value = iNumeroMDFe

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "serie"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.BigInt
            oSqlParameter(3).Value = iSerie

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "data_emissao"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.VarChar
            oSqlParameter(4).Value = IIf(sDataEmissao = "", DBNull.Value, sDataEmissao)

            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "data_saida"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.VarChar
            oSqlParameter(5).Value = IIf(sDataSaida = "", DBNull.Value, sDataSaida)

            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "uf"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.VarChar
            oSqlParameter(6).Value = sUFCapa

            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "codigo_tipo_emitente_mdfe"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.Int
            oSqlParameter(7).Value = iCodigoTipoEmitente

            oSqlParameter(8) = New SqlParameter
            oSqlParameter(8).ParameterName = "codigo_modalidade_mdfe"
            oSqlParameter(8).Direction = ParameterDirection.Input
            oSqlParameter(8).SqlDbType = SqlDbType.Int
            oSqlParameter(8).Value = iCodigoModalidade

            oSqlParameter(9) = New SqlParameter
            oSqlParameter(9).ParameterName = "codigo_forma_emissao_mdfe"
            oSqlParameter(9).Direction = ParameterDirection.Input
            oSqlParameter(9).SqlDbType = SqlDbType.Int
            oSqlParameter(9).Value = iCodigoFormaEmissaoMDFe

            oSqlParameter(10) = New SqlParameter
            oSqlParameter(10).ParameterName = "uf_descarregamento"
            oSqlParameter(10).Direction = ParameterDirection.Input
            oSqlParameter(10).SqlDbType = SqlDbType.VarChar
            oSqlParameter(10).Value = sUFDescarregamento

            oSqlParameter(11) = New SqlParameter
            oSqlParameter(11).ParameterName = "codigo_usuario"
            oSqlParameter(11).Direction = ParameterDirection.Input
            oSqlParameter(11).SqlDbType = SqlDbType.Int
            oSqlParameter(11).Value = goUsuario.iUsuario

            oSqlParameter(12) = New SqlParameter
            oSqlParameter(12).ParameterName = "codigo"
            oSqlParameter(12).Direction = ParameterDirection.Input
            oSqlParameter(12).SqlDbType = SqlDbType.Int
            oSqlParameter(12).Value = lCodigoEmissaoCapa

            oSqlParameter(13) = New SqlParameter
            oSqlParameter(13).ParameterName = "status"
            oSqlParameter(13).Direction = ParameterDirection.Input
            oSqlParameter(13).SqlDbType = SqlDbType.Int
            oSqlParameter(13).Value = StatusManifestoEletronico.AguardandoTransmissao

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_mdfe_capa", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosMDF(ByVal cboModelo As UIComboBox, _
                           ByVal cboSerie As UIComboBox, _
                           ByVal txtNumeroDocumento As MaskedEditBox, _
                           ByVal dtpDataEmissao As CalendarCombo, _
                           ByVal dtpDataSaida As CalendarCombo, _
                           ByVal cboUfCapa As UIComboBox, _
                           ByVal cboTipoEmitente As UIComboBox, _
                           ByVal cboModalidade As UIComboBox, _
                           ByVal cboFormaEmissao As UIComboBox, _
                           ByVal cboUfDescarregamento As UIComboBox, _
                           ByVal txtMensagemSefaz As MaskedEditBox, _
                           ByVal txtStatusMdfe As MaskedEditBox, _
                           ByVal txtChaveAcesso As MaskedEditBox, _
                           ByVal txtRecibo As MaskedEditBox, _
                           ByVal txtLote As MaskedEditBox, _
                           ByVal txtProtocolo As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_emissao_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_mdfe_dados", oSqlParameter)

            While oSqlDataReader.Read
                lCodigoEmissaoCapa = oSqlDataReader("codigo_mdfe_capa")
                cboFormaEmissao.SelectedValue = oSqlDataReader("codigo_forma_emissao")
                cboModalidade.SelectedValue = oSqlDataReader("codigo_modalidade")
                cboModelo.SelectedValue = oSqlDataReader("codigo_modelo")
                cboTipoEmitente.SelectedValue = oSqlDataReader("codigo_tipo_emitente")
                dtpDataEmissao.Value = oSqlDataReader("data_emissao")
                dtpDataSaida.Value = oSqlDataReader("data_saida")
                txtMensagemSefaz.Text = oSqlDataReader("mensagem_sefaz")
                cboSerie.SelectedValue = oSqlDataReader("serie")
                txtNumeroDocumento.Text = oSqlDataReader("numero_documento")

                txtStatusMdfe.Tag = oSqlDataReader("status")
                cboUfCapa.SelectedValue = oSqlDataReader("uf_capa")
                cboUfDescarregamento.SelectedValue = oSqlDataReader("uf_descarregamento")
                txtChaveAcesso.Text = oSqlDataReader("chave_acesso")
                txtRecibo.Text = oSqlDataReader("numero_recibo")
                txtLote.Text = oSqlDataReader("lote")
                txtProtocolo.Text = oSqlDataReader("numero_protocolo")
            End While


            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function GeraNumeroManifestoEletronico(ByVal iSerie As Integer) As String

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(0).Value = goUsuario.iEmpresa

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_emissao_capa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = lCodigoEmissaoCapa

            'Seta Parametros - Código Tipo Ambiente
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_tipo_ambiente_mdfe"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(2).Value = goConfiguracaoMDFe.iCodigoTipoAmbienteMDFe

            'Seta Parametros - Nota Fiscal
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "manifesto_eletronico"
            oSqlParameter(3).Direction = ParameterDirection.Output
            oSqlParameter(3).SqlDbType = SqlDbType.BigInt

            'Seta Parametros -Série
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "serie"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Int
            oSqlParameter(4).Value = iSerie

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_manifesto_eletronico", oSqlParameter)

            iNumeroMDFe = oSqlParameter(3).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function GeraNumeracao(ByVal iSerie As Integer) As String

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(0).Value = goUsuario.iEmpresa

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_emissao_capa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = lCodigoEmissaoCapa

            'Seta Parametros - Código Tipo Ambiente
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_tipo_ambiente_mdfe"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(2).Value = goConfiguracaoMDFe.iCodigoTipoAmbienteMDFe

            'Seta Parametros - Nota Fiscal
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "manifesto_eletronico"
            oSqlParameter(3).Direction = ParameterDirection.Output
            oSqlParameter(3).SqlDbType = SqlDbType.BigInt

            'Seta Parametros -Série
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "serie"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Int
            oSqlParameter(4).Value = iSerie

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_manifesto_eletronico_numeracao", oSqlParameter)

            iNumeroMDFe = oSqlParameter(3).Value
            Return iNumeroMDFe


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function GeraNumeroLote() As String

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = goUsuario.iEmpresa

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_emissao_capa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = lCodigoEmissaoCapa

            'Seta Parametros - Código Tipo Ambiente
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_tipo_ambiente_mdfe"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(2).Value = goConfiguracaoMDFe.iCodigoTipoAmbienteMDFe

            'Seta Parametros - Lote
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "lote"
            oSqlParameter(3).Direction = ParameterDirection.Output
            oSqlParameter(3).SqlDbType = SqlDbType.BigInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_mdfe_lote", oSqlParameter)

            Return Format(oSqlParameter(3).Value, "000000000")

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function DuplicarManifestoEletronico(ByVal lCodigoEmissaoCapa As Long) As Long

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0
        Dim lReturn As Long

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hostname"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = System.Net.Dns.GetHostName : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = StatusManifestoEletronico.AguardandoTransmissao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa_novo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_mdfe_duplicar", oSqlParameter)

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

    Public Sub UpdateStatusManifestoEletronico(ByVal lCodigoEmissaoCapa As Long, _
                                               ByVal iStatus As Integer)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_emissao_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "status"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(2).Value = iStatus

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_status_manifesto_eletronico", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: CARREGAMENTO :::"

    Public Sub InsertCarregamento()

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "uf"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Value = sUFCarregamento

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_municipio"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iCodigoMunicipioCarregamento

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_mdfe_carregamento", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteCarregamento()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter

        Try
            For Each oRow As GridEXRow In gSelecaoRow


                'Seta Parametros - Código
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_empresa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(1).Value = goUsuario.iEmpresa

                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "codigo"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.Int
                oSqlParameter(2).Value = oRow.Cells("codigo").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_mdfe_carregamento", oSqlParameter)

                'Exclui Linha da Grid
                oRow.Delete()

            Next
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridCarregamento(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_mdfe_carregamento", oSqlParameter)

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

    Public Sub UpdateCarregamento(ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "uf"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Value = sUFCarregamento

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_municipio"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iCodigoMunicipioCarregamento

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "codigo"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.BigInt
            oSqlParameter(4).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_mdfe_carregamento", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: PERCURSO :::"

    Public Sub InsertPercurso()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter

        Try
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "uf"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Value = sUFPercurso


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_mdfe_percurso", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeletePercurso()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter

        Try
            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Parametros - Código
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_empresa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(1).Value = goUsuario.iEmpresa

                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "codigo"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.Int
                oSqlParameter(2).Value = oRow.Cells("codigo").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_mdfe_percurso", oSqlParameter)

                'Exclui Linha da Grid
                oRow.Delete()

            Next
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridPercurso(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_mdfe_percurso", oSqlParameter)

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

    Public Sub UpdatePercurso(ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "uf"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Value = sUFPercurso

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.BigInt
            oSqlParameter(3).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_mdfe_percurso", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: EMITENTE :::"

    Public Sub InsertEmitente(Optional ByVal sInscricaoEstadual As String = "")

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código Emitente
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_emitente"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(0).Value = goUsuario.iEmpresa

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_emissao_capa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = lCodigoEmissaoCapa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_mdfe_emitente", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteEmitente()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_emissao_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_mdfe_emitente", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

#Region "::: RODOVIÁRIO :::"

#Region "::: CAPA :::"

    Public Sub InsertRodoviario()

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "rntrc"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Size = 15
            oSqlParameter(2).Value = sRntrcVeiculo

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "ciot"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iCiotVeiculo

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "codigo_agendamento_porto"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Int
            oSqlParameter(4).Value = iCodigoAgendamentoPortoVeiculo


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_mdfe_rodoviario", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteRodoviario()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_mdfe_rodoviario", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosRodoviario(ByVal txtRntrcVeiculo As MaskedEditBox, _
                           ByVal txtCiotVeiculo As NumericEditBox, _
                           ByVal txtCodigoAgendamentoPorto As NumericEditBox)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_mdfe_dados_rodoviario", oSqlParameter)

            While oSqlDataReader.Read
                lCodigoEmissaoCapa = oSqlDataReader("codigo_mdfe_capa")
                txtRntrcVeiculo.Text = oSqlDataReader("rntrc")
                txtCiotVeiculo.Value = oSqlDataReader("ciot")
                txtCodigoAgendamentoPorto.Value = oSqlDataReader("codigo_agendamento_porto")
            End While


            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateRodoviario()

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "rntrc"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Size = 15
            oSqlParameter(2).Value = sRntrcVeiculo

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "ciot"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iCiotVeiculo

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "codigo_agendamento_porto"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Int
            oSqlParameter(4).Value = iCodigoAgendamentoPortoVeiculo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_mdfe_rodoviario", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: VEICULO DE TRAÇÃO :::"

    Public Sub InsertVeiculoTracao()

        'Variaveis Locais
        Dim oSqlParameter(17) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_interno_veiculo"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iCodigoInternoVeiculo

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_tipo_carroceria"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = IIf(iCodigoTipoCarroceriaVeiculo = -1, DBNull.Value, iCodigoTipoCarroceriaVeiculo)

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "placa"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.VarChar
            oSqlParameter(4).Value = sPlacaVeiculo

            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "tara"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.Int
            oSqlParameter(5).Value = iTaraKgVeiculo

            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "renavam"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.Int
            oSqlParameter(6).Value = iRenavamVeiculo

            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "uf"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.VarChar
            oSqlParameter(7).Value = sUFVeiculo

            oSqlParameter(8) = New SqlParameter
            oSqlParameter(8).ParameterName = "codigo_tipo_rodado"
            oSqlParameter(8).Direction = ParameterDirection.Input
            oSqlParameter(8).SqlDbType = SqlDbType.Int
            oSqlParameter(8).Value = IIf(iCodigoTipoRodadoVeiculo = -1, DBNull.Value, iCodigoTipoRodadoVeiculo)

            oSqlParameter(9) = New SqlParameter
            oSqlParameter(9).ParameterName = "capacidade_kg"
            oSqlParameter(9).Direction = ParameterDirection.Input
            oSqlParameter(9).SqlDbType = SqlDbType.Int
            oSqlParameter(9).Value = iCapacidadeKgVeiculo

            oSqlParameter(10) = New SqlParameter
            oSqlParameter(10).ParameterName = "capacidade_m3"
            oSqlParameter(10).Direction = ParameterDirection.Input
            oSqlParameter(10).SqlDbType = SqlDbType.Int
            oSqlParameter(10).Value = iCapacidadeM3Veiculo

            oSqlParameter(11) = New SqlParameter
            oSqlParameter(11).ParameterName = "proprietario_emitente"
            oSqlParameter(11).Direction = ParameterDirection.Input
            oSqlParameter(11).SqlDbType = SqlDbType.Bit
            oSqlParameter(11).Value = bPropriedadeVeiculo

            oSqlParameter(12) = New SqlParameter
            oSqlParameter(12).ParameterName = "rntrc_proprietario"
            oSqlParameter(12).Direction = ParameterDirection.Input
            oSqlParameter(12).SqlDbType = SqlDbType.VarChar
            oSqlParameter(12).Size = 15
            oSqlParameter(12).Value = IIf(sRntrcProprietarioVeiculo = 0, 0, sRntrcProprietarioVeiculo)

            oSqlParameter(13) = New SqlParameter
            oSqlParameter(13).ParameterName = "codigo_tipo_proprietario"
            oSqlParameter(13).Direction = ParameterDirection.Input
            oSqlParameter(13).SqlDbType = SqlDbType.Int
            oSqlParameter(13).Value = IIf(iCodigoTipoProprietarioVeiculo = -1, DBNull.Value, iCodigoTipoProprietarioVeiculo)

            oSqlParameter(14) = New SqlParameter
            oSqlParameter(14).ParameterName = "uf_proprietario"
            oSqlParameter(14).Direction = ParameterDirection.Input
            oSqlParameter(14).SqlDbType = SqlDbType.VarChar
            oSqlParameter(14).Value = IIf(sUFProprietarioVeiculo = "", DBNull.Value, sUFProprietarioVeiculo)

            oSqlParameter(15) = New SqlParameter
            oSqlParameter(15).ParameterName = "cpf_cnpj_proprietario"
            oSqlParameter(15).Direction = ParameterDirection.Input
            oSqlParameter(15).SqlDbType = SqlDbType.VarChar
            oSqlParameter(15).Value = IIf(sCPFCNPJProprietarioVeiculo = "", DBNull.Value, sCPFCNPJProprietarioVeiculo)

            oSqlParameter(16) = New SqlParameter
            oSqlParameter(16).ParameterName = "nome_proprietario"
            oSqlParameter(16).Direction = ParameterDirection.Input
            oSqlParameter(16).SqlDbType = SqlDbType.VarChar
            oSqlParameter(16).Value = IIf(sNomeProprietarioVeiculo = "", DBNull.Value, sNomeProprietarioVeiculo)

            oSqlParameter(17) = New SqlParameter
            oSqlParameter(17).ParameterName = "inscricao_estadual_proprietario"
            oSqlParameter(17).Direction = ParameterDirection.Input
            oSqlParameter(17).SqlDbType = SqlDbType.VarChar
            oSqlParameter(17).Value = IIf(sIEProprietarioVeiculo = "", DBNull.Value, sIEProprietarioVeiculo)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_mdfe_veiculo_tracao", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteVeiculoTracao()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_mdfe_veiculo_tracao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateVeiculoTracao()

        'Variaveis Locais
        Dim oSqlParameter(17) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_interno_veiculo"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iCodigoInternoVeiculo

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_tipo_carroceria"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = IIf(iCodigoTipoCarroceriaVeiculo = -1, DBNull.Value, iCodigoTipoCarroceriaVeiculo)

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "placa"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.VarChar
            oSqlParameter(4).Value = sPlacaVeiculo

            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "tara"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.Int
            oSqlParameter(5).Value = iTaraKgVeiculo

            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "renavam"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.Int
            oSqlParameter(6).Value = iRenavamVeiculo

            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "uf"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.VarChar
            oSqlParameter(7).Value = sUFVeiculo

            oSqlParameter(8) = New SqlParameter
            oSqlParameter(8).ParameterName = "codigo_tipo_rodado"
            oSqlParameter(8).Direction = ParameterDirection.Input
            oSqlParameter(8).SqlDbType = SqlDbType.Int
            oSqlParameter(8).Value = IIf(iCodigoTipoRodadoVeiculo = -1, DBNull.Value, iCodigoTipoRodadoVeiculo)

            oSqlParameter(9) = New SqlParameter
            oSqlParameter(9).ParameterName = "capacidade_kg"
            oSqlParameter(9).Direction = ParameterDirection.Input
            oSqlParameter(9).SqlDbType = SqlDbType.Int
            oSqlParameter(9).Value = iCapacidadeKgVeiculo

            oSqlParameter(10) = New SqlParameter
            oSqlParameter(10).ParameterName = "capacidade_m3"
            oSqlParameter(10).Direction = ParameterDirection.Input
            oSqlParameter(10).SqlDbType = SqlDbType.Int
            oSqlParameter(10).Value = iCapacidadeM3Veiculo

            oSqlParameter(11) = New SqlParameter
            oSqlParameter(11).ParameterName = "proprietario_emitente"
            oSqlParameter(11).Direction = ParameterDirection.Input
            oSqlParameter(11).SqlDbType = SqlDbType.Bit
            oSqlParameter(11).Value = bPropriedadeVeiculo

            oSqlParameter(12) = New SqlParameter
            oSqlParameter(12).ParameterName = "rntrc_proprietario"
            oSqlParameter(12).Direction = ParameterDirection.Input
            oSqlParameter(12).SqlDbType = SqlDbType.VarChar
            oSqlParameter(12).Size = 15
            oSqlParameter(12).Value = IIf(sRntrcProprietarioVeiculo = 0, 0, sRntrcProprietarioVeiculo)

            oSqlParameter(13) = New SqlParameter
            oSqlParameter(13).ParameterName = "codigo_tipo_proprietario"
            oSqlParameter(13).Direction = ParameterDirection.Input
            oSqlParameter(13).SqlDbType = SqlDbType.Int
            oSqlParameter(13).Value = IIf(iCodigoTipoProprietarioVeiculo = -1, DBNull.Value, iCodigoTipoProprietarioVeiculo)

            oSqlParameter(14) = New SqlParameter
            oSqlParameter(14).ParameterName = "uf_proprietario"
            oSqlParameter(14).Direction = ParameterDirection.Input
            oSqlParameter(14).SqlDbType = SqlDbType.VarChar
            oSqlParameter(14).Value = IIf(sUFProprietarioVeiculo = "", DBNull.Value, sUFProprietarioVeiculo)

            oSqlParameter(15) = New SqlParameter
            oSqlParameter(15).ParameterName = "cpf_cnpj_proprietario"
            oSqlParameter(15).Direction = ParameterDirection.Input
            oSqlParameter(15).SqlDbType = SqlDbType.VarChar
            oSqlParameter(15).Value = IIf(sCPFCNPJProprietarioVeiculo = "", DBNull.Value, sCPFCNPJProprietarioVeiculo)

            oSqlParameter(16) = New SqlParameter
            oSqlParameter(16).ParameterName = "nome_proprietario"
            oSqlParameter(16).Direction = ParameterDirection.Input
            oSqlParameter(16).SqlDbType = SqlDbType.VarChar
            oSqlParameter(16).Value = IIf(sNomeProprietarioVeiculo = "", DBNull.Value, sNomeProprietarioVeiculo)

            oSqlParameter(17) = New SqlParameter
            oSqlParameter(17).ParameterName = "inscricao_estadual_proprietario"
            oSqlParameter(17).Direction = ParameterDirection.Input
            oSqlParameter(17).SqlDbType = SqlDbType.VarChar
            oSqlParameter(17).Value = IIf(sIEProprietarioVeiculo = "", DBNull.Value, sIEProprietarioVeiculo)
            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_mdfe_veiculo_tracao", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosVeiculoTracao(ByVal txtCodigoInternoVeiculo As NumericEditBox, _
                                      ByVal cboTipoCarroceriaVeiculo As UIComboBox, _
                                      ByVal txtPlacaVeiculo As MaskedEditBox, _
                                      ByVal txtTaraVeiculo As NumericEditBox, _
                                      ByVal cboRenavamVeiculo As UIComboBox, _
                                      ByVal cboUFVeiculo As UIComboBox, _
                                      ByVal cboTipoRodadoVeiculo As UIComboBox, _
                                      ByVal txtCapacidadeKGVeiculo As NumericEditBox, _
                                      ByVal txtCapacidadeM3Veiculo As NumericEditBox, _
                                      ByVal chkProprietarioVeiculo As UICheckBox, _
                                      ByVal txtRNTRCProprietarioVeiculo As MaskedEditBox, _
                                      ByVal cboTipoProprietarioVeiculo As UIComboBox, _
                                      ByVal cboUFProprietarioVeiculo As UIComboBox, _
                                      ByVal txtCNPJCPFProprietarioVeiculo As MaskedEditBox, _
                                      ByVal txtNomeProprietarioVeiculo As MaskedEditBox, _
                                      ByVal txtIEProprietarioVeiculo As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_mdfe_dados_veiculo_tracao", oSqlParameter)

            While oSqlDataReader.Read
                lCodigoEmissaoCapa = oSqlDataReader("codigo_mdfe_capa")
                txtCapacidadeKGVeiculo.Value = oSqlDataReader("capacidade_kg")
                txtCapacidadeM3Veiculo.Value = oSqlDataReader("capacidade_m3")
                txtCodigoInternoVeiculo.Value = oSqlDataReader("codigo_interno_veiculo")
                cboTipoCarroceriaVeiculo.SelectedValue = oSqlDataReader("codigo_tipo_carroceria")
                cboTipoProprietarioVeiculo.SelectedValue = oSqlDataReader("codigo_tipo_proprietario")
                cboTipoRodadoVeiculo.SelectedValue = oSqlDataReader("codigo_tipo_rodado")
                txtCNPJCPFProprietarioVeiculo.Text = oSqlDataReader("cpf_cnpj_proprietario")
                txtIEProprietarioVeiculo.Text = oSqlDataReader("inscricao_estadual_proprietario")
                txtNomeProprietarioVeiculo.Text = oSqlDataReader("nome_proprietario")
                txtPlacaVeiculo.Text = oSqlDataReader("placa")
                chkProprietarioVeiculo.Checked = oSqlDataReader("proprietario_emitente")
                cboRenavamVeiculo.SelectedValue = oSqlDataReader("renavam")
                txtRNTRCProprietarioVeiculo.Text = oSqlDataReader("rntrc_proprietario")
                txtTaraVeiculo.Value = oSqlDataReader("tara")
                cboUFVeiculo.SelectedValue = oSqlDataReader("uf")
                cboUFProprietarioVeiculo.SelectedValue = oSqlDataReader("uf_proprietario")
            End While


            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try


    End Sub

    Public Sub LoadDadosRenavam(ByVal iRenavam As Integer, _
                                ByVal txtPlaca As MaskedEditBox, _
                                ByVal cboUF As UIComboBox, _
                                ByVal txtRNTRC As MaskedEditBox, _
                                ByVal cboTipoCarroceria As UIComboBox)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "renavam"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = iRenavam

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_mdfe_dados_veiculo_renavam", oSqlParameter)

            While oSqlDataReader.Read
                txtPlaca.Text = oSqlDataReader("placa")
                cboTipoCarroceria.SelectedValue = oSqlDataReader("codigo_tipo_carroceria")
                txtRNTRC.Text = oSqlDataReader("rntrc")
                cboUF.SelectedValue = oSqlDataReader("uf")
            End While


            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try


    End Sub

    Public Sub LoadDadosCondutor(ByVal iCodigoParceiroNegocio As Integer, _
                                 ByVal txtCPFCondutor As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = iCodigoParceiroNegocio

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_mdfe_dados_condutor", oSqlParameter)

            While oSqlDataReader.Read
                txtCPFCondutor.Text = oSqlDataReader("cpf_condutor")
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

#Region "::: CONDUTOR :::"

    Public Sub InsertCondutor()

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "nome"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Value = sNomeCondutorVeiculo

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "cpf"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.VarChar
            oSqlParameter(3).Value = sCPFCondutorVeiculo


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_mdfe_condutor", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteCondutor()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Parametros - Código
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_empresa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(1).Value = goUsuario.iEmpresa

                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "codigo"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.Int
                oSqlParameter(2).Value = oRow.Cells("codigo").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_mdfe_condutor", oSqlParameter)

                'Exclui Linha da Grid
                oRow.Delete()

            Next
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridCondutor(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_mdfe_condutor", oSqlParameter)

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

    Public Sub UpdateCondutor(ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "nome"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Value = sNomeCondutorVeiculo

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "cpf"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.VarChar
            oSqlParameter(3).Value = sCPFCondutorVeiculo

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "codigo"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.BigInt
            oSqlParameter(4).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_mdfe_condutor", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: VEÍCULO DE REBOQUE :::"

    Public Sub InsertReboque()

        'Variaveis Locais
        Dim oSqlParameter(17) As SqlParameter


        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_interno_veiculo"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iCodigoInternoReboque

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_tipo_carroceria"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iCodigoTipoCarroceriaReboque

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "placa"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.VarChar
            oSqlParameter(4).Value = sPlacaReboque

            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "tara"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.Float
            oSqlParameter(5).Value = iTaraKgReboque

            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "renavam"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.VarChar
            oSqlParameter(6).Value = iRenavamReboque

            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "uf_licenciamento"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.VarChar
            oSqlParameter(7).Value = sUFLicenciamentoReboque

            oSqlParameter(8) = New SqlParameter
            oSqlParameter(8).ParameterName = "codigo_tipo_rodado"
            oSqlParameter(8).Direction = ParameterDirection.Input
            oSqlParameter(8).SqlDbType = SqlDbType.Int
            oSqlParameter(8).Value = iCodigoTipoRodadoReboque

            oSqlParameter(9) = New SqlParameter
            oSqlParameter(9).ParameterName = "capacidade_kg"
            oSqlParameter(9).Direction = ParameterDirection.Input
            oSqlParameter(9).SqlDbType = SqlDbType.Float
            oSqlParameter(9).Value = iCapacidadeKgReboque

            oSqlParameter(10) = New SqlParameter
            oSqlParameter(10).ParameterName = "capacidade_m3"
            oSqlParameter(10).Direction = ParameterDirection.Input
            oSqlParameter(10).SqlDbType = SqlDbType.Float
            oSqlParameter(10).Value = iCapacidadeM3Reboque

            oSqlParameter(11) = New SqlParameter
            oSqlParameter(11).ParameterName = "proprietario_emitente"
            oSqlParameter(11).Direction = ParameterDirection.Input
            oSqlParameter(11).SqlDbType = SqlDbType.Bit
            oSqlParameter(11).Value = bPropriedadeReboque

            oSqlParameter(12) = New SqlParameter
            oSqlParameter(12).ParameterName = "rntrc_proprietario"
            oSqlParameter(12).Direction = ParameterDirection.Input
            oSqlParameter(12).SqlDbType = SqlDbType.VarChar
            oSqlParameter(12).Size = 15
            oSqlParameter(12).Value = IIf(sRntrcProprietarioReboque = 0, 0, sRntrcProprietarioReboque)

            oSqlParameter(13) = New SqlParameter
            oSqlParameter(13).ParameterName = "codigo_tipo_proprietario"
            oSqlParameter(13).Direction = ParameterDirection.Input
            oSqlParameter(13).SqlDbType = SqlDbType.Int
            oSqlParameter(13).Value = IIf(iCodigoTipoProprietatioReboque = -1, DBNull.Value, iCodigoTipoProprietatioReboque)

            oSqlParameter(14) = New SqlParameter
            oSqlParameter(14).ParameterName = "uf_proprietario"
            oSqlParameter(14).Direction = ParameterDirection.Input
            oSqlParameter(14).SqlDbType = SqlDbType.VarChar
            oSqlParameter(14).Value = IIf(sUFProprietarioReboque = "", DBNull.Value, sUFProprietarioReboque)

            oSqlParameter(15) = New SqlParameter
            oSqlParameter(15).ParameterName = "cpf_cnpj_proprietario"
            oSqlParameter(15).Direction = ParameterDirection.Input
            oSqlParameter(15).SqlDbType = SqlDbType.VarChar
            oSqlParameter(15).Value = IIf(sCPFCNPJProprietarioReboque = "", DBNull.Value, sCPFCNPJProprietarioReboque)

            oSqlParameter(16) = New SqlParameter
            oSqlParameter(16).ParameterName = "nome_proprietario"
            oSqlParameter(16).Direction = ParameterDirection.Input
            oSqlParameter(16).SqlDbType = SqlDbType.VarChar
            oSqlParameter(16).Value = IIf(sNomeProprietarioReboque = "", DBNull.Value, sNomeProprietarioReboque)

            oSqlParameter(17) = New SqlParameter
            oSqlParameter(17).ParameterName = "inscricao_estadual"
            oSqlParameter(17).Direction = ParameterDirection.Input
            oSqlParameter(17).SqlDbType = SqlDbType.Int
            oSqlParameter(17).Value = IIf(iIEProprietarioReboque = 0, DBNull.Value, iIEProprietarioReboque)


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_mdfe_reboque", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteReboque()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter

        Try
            For Each oRow As GridEXRow In gSelecaoRow
                'Seta Parametros - Código
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_empresa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(1).Value = goUsuario.iEmpresa

                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "codigo"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.Int
                oSqlParameter(2).Value = oRow.Cells("codigo").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_mdfe_reboque", oSqlParameter)

                'Exclui Linha da Grid
                oRow.Delete()

            Next
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridReboque(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_mdfe_reboque", oSqlParameter)

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

    Public Sub UpdateReboque(ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(18) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_interno_veiculo"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iCodigoInternoReboque

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_tipo_carroceria"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iCodigoTipoCarroceriaReboque

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "placa"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.VarChar
            oSqlParameter(4).Value = sPlacaReboque

            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "tara"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.Float
            oSqlParameter(5).Value = iTaraKgReboque

            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "renavam"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.Int
            oSqlParameter(6).Value = iRenavamReboque

            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "uf_licenciamento"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.VarChar
            oSqlParameter(7).Value = sUFLicenciamentoReboque

            oSqlParameter(8) = New SqlParameter
            oSqlParameter(8).ParameterName = "codigo_tipo_rodado"
            oSqlParameter(8).Direction = ParameterDirection.Input
            oSqlParameter(8).SqlDbType = SqlDbType.Int
            oSqlParameter(8).Value = iCodigoTipoRodadoReboque

            oSqlParameter(9) = New SqlParameter
            oSqlParameter(9).ParameterName = "capacidade_kg"
            oSqlParameter(9).Direction = ParameterDirection.Input
            oSqlParameter(9).SqlDbType = SqlDbType.Float
            oSqlParameter(9).Value = iCapacidadeKgReboque

            oSqlParameter(10) = New SqlParameter
            oSqlParameter(10).ParameterName = "capacidade_m3"
            oSqlParameter(10).Direction = ParameterDirection.Input
            oSqlParameter(10).SqlDbType = SqlDbType.Float
            oSqlParameter(10).Value = iCapacidadeM3Reboque

            oSqlParameter(11) = New SqlParameter
            oSqlParameter(11).ParameterName = "proprietario_emitente"
            oSqlParameter(11).Direction = ParameterDirection.Input
            oSqlParameter(11).SqlDbType = SqlDbType.Bit
            oSqlParameter(11).Value = bPropriedadeReboque

            oSqlParameter(12) = New SqlParameter
            oSqlParameter(12).ParameterName = "rntrc_proprietario"
            oSqlParameter(12).Direction = ParameterDirection.Input
            oSqlParameter(12).SqlDbType = SqlDbType.VarChar
            oSqlParameter(12).Size = 15
            oSqlParameter(12).Value = IIf(sRntrcProprietarioReboque = 0, 0, sRntrcProprietarioReboque)

            oSqlParameter(13) = New SqlParameter
            oSqlParameter(13).ParameterName = "codigo_tipo_proprietario"
            oSqlParameter(13).Direction = ParameterDirection.Input
            oSqlParameter(13).SqlDbType = SqlDbType.Int
            oSqlParameter(13).Value = IIf(iCodigoTipoProprietatioReboque = -1, DBNull.Value, iCodigoTipoProprietatioReboque)

            oSqlParameter(14) = New SqlParameter
            oSqlParameter(14).ParameterName = "uf_proprietario"
            oSqlParameter(14).Direction = ParameterDirection.Input
            oSqlParameter(14).SqlDbType = SqlDbType.VarChar
            oSqlParameter(14).Value = IIf(sUFProprietarioReboque = "", DBNull.Value, sUFProprietarioReboque)

            oSqlParameter(15) = New SqlParameter
            oSqlParameter(15).ParameterName = "cpf_cnpj_proprietario"
            oSqlParameter(15).Direction = ParameterDirection.Input
            oSqlParameter(15).SqlDbType = SqlDbType.VarChar
            oSqlParameter(15).Value = IIf(sCPFCNPJProprietarioReboque = "", DBNull.Value, sCPFCNPJProprietarioReboque)

            oSqlParameter(16) = New SqlParameter
            oSqlParameter(16).ParameterName = "nome_proprietario"
            oSqlParameter(16).Direction = ParameterDirection.Input
            oSqlParameter(16).SqlDbType = SqlDbType.VarChar
            oSqlParameter(16).Value = IIf(sNomeProprietarioReboque = "", DBNull.Value, sNomeProprietarioReboque)

            oSqlParameter(17) = New SqlParameter
            oSqlParameter(17).ParameterName = "inscricao_estadual"
            oSqlParameter(17).Direction = ParameterDirection.Input
            oSqlParameter(17).SqlDbType = SqlDbType.Int
            oSqlParameter(17).Value = IIf(iIEProprietarioReboque = 0, DBNull.Value, iIEProprietarioReboque)

            oSqlParameter(18) = New SqlParameter
            oSqlParameter(18).ParameterName = "codigo"
            oSqlParameter(18).Direction = ParameterDirection.Input
            oSqlParameter(18).SqlDbType = SqlDbType.BigInt
            oSqlParameter(18).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_mdfe_reboque", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: VALE PEDÁGIO :::"

    Public Sub LoadGridValePedagio(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_mdfe_vale_pedagio", oSqlParameter)

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

    Public Sub InsertValePedagio()

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter


        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "cnpj"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Value = sCNPJAgenciaValePedagio

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "numero_comprovante"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iNumeroComprovanteValePedagio

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "cnpj_responsavel"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.VarChar
            oSqlParameter(4).Value = sCNPJResponsavelValePedagio


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_mdfe_vale_pedagio", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteValePedagio()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter

        Try
            For Each oRow As GridEXRow In gSelecaoRow
                'Seta Parametros - Código
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_empresa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(1).Value = goUsuario.iEmpresa

                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "codigo"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.Int
                oSqlParameter(2).Value = oRow.Cells("codigo").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_mdfe_vale_pedagio", oSqlParameter)
                'Exclui Linha da Grid
                oRow.Delete()

            Next
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateValePedagio(ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "cnpj"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Value = sCNPJAgenciaValePedagio

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "numero_comprovante"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iNumeroComprovanteValePedagio

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "cnpj_responsavel"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.VarChar
            oSqlParameter(4).Value = sCNPJResponsavelValePedagio

            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "codigo"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.BigInt
            oSqlParameter(5).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_mdfe_vale_pedagio", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

#Region "::: AQUAVIÁRIO :::"

#Region "::: CAPA :::"

    Public Sub InsertAquaviario()

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "cnpj_agencia"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Value = sCNPJAgencia

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_tipo_embarcacao"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iCodigoTipoEmbarcacao

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "codigo_embarcacao"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Int
            oSqlParameter(4).Value = iCodigoEmbarcacao

            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "numero_viagem"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.Int
            oSqlParameter(5).Value = iNumeroViagem

            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "nome_embarcacao"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.VarChar
            oSqlParameter(6).Value = sNomeEmbarcacao

            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "codigo_porto_embarque"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.Int
            oSqlParameter(7).Value = iCodigoPortoEmbarque

            oSqlParameter(8) = New SqlParameter
            oSqlParameter(8).ParameterName = "codigo_porto_destino"
            oSqlParameter(8).Direction = ParameterDirection.Input
            oSqlParameter(8).SqlDbType = SqlDbType.Int
            oSqlParameter(8).Value = iCodigoPortoDestino

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_mdfe_aquaviario", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteAquaviario()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_mdfe_aquaviario", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosAquaviario(ByVal txtAgenciaAquaviario As MaskedEditBox, _
                           ByVal txtTipoEmbarcacaoAquaviario As NumericEditBox, _
                           ByVal txtCodigoEmbarcacaoAquaviario As NumericEditBox, _
                           ByVal txtNumeroViagemAquaviario As NumericEditBox, _
                           ByVal txtNomeEmbarcacaoAquaviario As MaskedEditBox, _
                           ByVal txtPortoEmbarqueAquaviario As NumericEditBox, _
                           ByVal txtPortoDestinoAquaviario As NumericEditBox)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_mdfe_dados_aquaviario", oSqlParameter)

            While oSqlDataReader.Read
                lCodigoEmissaoCapa = oSqlDataReader("codigo_mdfe_capa")
                txtAgenciaAquaviario.Text = oSqlDataReader("agencia_aquaviario")
                txtCodigoEmbarcacaoAquaviario.Value = oSqlDataReader("codigo_embarcacao")
                txtNomeEmbarcacaoAquaviario.Text = oSqlDataReader("nome_embarcacao")
                txtNumeroViagemAquaviario.Value = oSqlDataReader("numero_viagem")
                txtPortoDestinoAquaviario.Value = oSqlDataReader("porto_destino")
                txtPortoEmbarqueAquaviario.Value = oSqlDataReader("porto_embarque")
                txtTipoEmbarcacaoAquaviario.Value = oSqlDataReader("tipo_embarcacao")
            End While


            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateAquaviario()

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "cnpj_agencia"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Value = sCNPJAgencia

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_tipo_embarcacao"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iCodigoTipoEmbarcacao

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "codigo_embarcacao"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Int
            oSqlParameter(4).Value = iCodigoEmbarcacao

            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "numero_viagem"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.Int
            oSqlParameter(5).Value = iNumeroViagem

            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "nome_embarcacao"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.VarChar
            oSqlParameter(6).Value = sNomeEmbarcacao

            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "codigo_porto_embarque"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.Int
            oSqlParameter(7).Value = iCodigoPortoEmbarque

            oSqlParameter(8) = New SqlParameter
            oSqlParameter(8).ParameterName = "codigo_porto_destino"
            oSqlParameter(8).Direction = ParameterDirection.Input
            oSqlParameter(8).SqlDbType = SqlDbType.Int
            oSqlParameter(8).Value = iCodigoPortoDestino

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_mdfe_aquaviario", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: CARREGAMENTO :::"

    Public Sub InsertTerminalCarregamento()

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "nome_terminal_carregamento"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Value = sNomeTerminalCarregamento

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_terminal_carregamento"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iCodigoTerminalCarregamento


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_mdfe_terminal_carregamento", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteTerminalCarregamento()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter

        Try
            For Each oRow As GridEXRow In gSelecaoRow
                'Seta Parametros - Código
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_empresa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(1).Value = goUsuario.iEmpresa

                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "codigo"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.Int
                oSqlParameter(2).Value = oRow.Cells("codigo").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_mdfe_terminal_carregamento", oSqlParameter)
                'Exclui Linha da Grid
                oRow.Delete()

            Next
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridTerminalCarregamento(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_mdfe_terminal_carregamento", oSqlParameter)

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

    Public Sub UpdateTerminalCarregamento(ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "nome_terminal_carregamento"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Value = sNomeTerminalCarregamento

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_terminal_carregamento"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iCodigoTerminalCarregamento

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "codigo"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.BigInt
            oSqlParameter(4).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_mdfe_terminal_carregamento", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: DESCARREGAMENTO :::"

    Public Sub InsertTerminalDescarregamento()

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "nome_terminal_descarregamento"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Value = sNomeTerminalDescarregamento

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_terminal_descarregamento"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iCodigoTerminalDescarregamento


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_mdfe_terminal_descarregamento", oSqlParameter)



        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteTerminalDescarregamento()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter

        Try
            For Each oRow As GridEXRow In gSelecaoRow
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoCapa

                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_empresa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(1).Value = goUsuario.iEmpresa

                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "codigo"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.Int
                oSqlParameter(2).Value = oRow.Cells("codigo").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_mdfe_terminal_descarregamento", oSqlParameter)
                'Exclui Linha da Grid
                oRow.Delete()

            Next
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridTerminalDescarregamento(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_mdfe_terminal_descarregamento", oSqlParameter)

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

    Public Sub UpdateTerminalDescarregamento(ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "nome_terminal_descarregamento"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Value = sNomeTerminalDescarregamento

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_terminal_descarregamento"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iCodigoTerminalDescarregamento

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "codigo"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.BigInt
            oSqlParameter(4).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_mdfe_terminal_descarregamento", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: COMBOIO :::"

    Public Sub InsertComboio()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_embarcacao_comboio"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iCodigoEmbarcacaoComboio


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_mdfe_embarcacao_comboio", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteComboio()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter

        Try
            For Each oRow As GridEXRow In gSelecaoRow
                'Seta Parametros - Código
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_empresa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(1).Value = goUsuario.iEmpresa

                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "codigo"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.Int
                oSqlParameter(2).Value = oRow.Cells("codigo").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_mdfe_embarcacao_comboio", oSqlParameter)
                'Exclui Linha da Grid
                oRow.Delete()

            Next
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridComboio(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_mdfe_embarcacao_comboio", oSqlParameter)

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

    Public Sub UpdateComboio(ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_embarcacao_comboio"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iCodigoEmbarcacaoComboio

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.BigInt
            oSqlParameter(3).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_mdfe_embarcacao_comboio", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: UNIDADE AQUAVIÁRIO :::"

    Public Sub InsertCargaVazia()

        'Variaveis Locais
        Dim oSqlParameter(7) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "identificacao_unidade_carga"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Value = sIdentificacaoUnidadeCarga

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_tipo_unidade_carga"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iCodigoTipoUnidade

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "quantidade_rateada"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Int
            oSqlParameter(4).Value = iQuantidadeRateadaUnidade

            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "numero_lacre"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.Int
            oSqlParameter(5).Value = iNumeroLacreUnidade

            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "chave_acesso"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.VarChar
            oSqlParameter(6).Value = ""

            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "tipo"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.Int
            oSqlParameter(7).Value = 3

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_mdfe_unidade_carga", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteCargaVazia()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter

        Try
            For Each oRow As GridEXRow In gSelecaoRow
                'Seta Parametros - Código
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_empresa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(1).Value = goUsuario.iEmpresa

                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "codigo"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.Int
                oSqlParameter(2).Value = oRow.Cells("codigo").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_mdfe_unidade_carga", oSqlParameter)
                'Exclui Linha da Grid
                oRow.Delete()

            Next
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridCargaVazia(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(3) As SqlParameter

        Try

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "tipo"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = 3

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "chave_acesso"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.VarChar
            oSqlParameter(3).Value = ""

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_mdfe_unidade_carga", oSqlParameter)

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

    Public Sub UpdateCargaVazia(ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "identificacao_unidade_carga"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Value = sIdentificacaoUnidadeCarga

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_tipo_unidade_carga"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iCodigoTipoUnidade

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "quantidade_rateada"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Int
            oSqlParameter(4).Value = iQuantidadeRateadaUnidade

            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "numero_lacre"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.Int
            oSqlParameter(5).Value = iNumeroLacreUnidade

            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "chave_acesso"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.VarChar
            oSqlParameter(6).Value = ""

            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "tipo"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.Int
            oSqlParameter(7).Value = 3

            oSqlParameter(8) = New SqlParameter
            oSqlParameter(8).ParameterName = "codigo"
            oSqlParameter(8).Direction = ParameterDirection.Input
            oSqlParameter(8).SqlDbType = SqlDbType.BigInt
            oSqlParameter(8).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_mdfe_unidade_carga", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

#Region "::: INFORMAÇÕES DOS DOCUMENTOS :::"

#Region "::: MUNICÍPIOS DE DESCARREGAMENTO :::"

    Public Sub InsertMunicipioDescarregamento()

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_municipio"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iCodigoMunicipioDocumentos

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "uf"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.VarChar
            oSqlParameter(3).Value = sUFDescarregamentoDocumentos

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "codigo"
            oSqlParameter(4).Direction = ParameterDirection.Output
            oSqlParameter(4).SqlDbType = SqlDbType.BigInt


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_mdfe_municipio_descarregamento", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteMunicipioDescarregamento()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter

        Try
            For Each oRow As GridEXRow In gSelecaoRow
                'Seta Parametros - Código
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_empresa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(1).Value = goUsuario.iEmpresa

                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "codigo"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.Int
                oSqlParameter(2).Value = oRow.Cells("codigo").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_mdfe_municipio_descarregamento", oSqlParameter)
                'Exclui Linha da Grid
                oRow.Delete()

            Next
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridMunicipioDescarregamento(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_mdfe_municipio_descarregamento", oSqlParameter)

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

    Public Sub UpdateMunicipioDescarregamento(ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_municipio"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iCodigoMunicipioDocumentos

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "uf"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.VarChar
            oSqlParameter(3).Value = sUFDescarregamentoDocumentos

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "codigo"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.BigInt
            oSqlParameter(4).Value = iCodigo


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_mdfe_municipio_descarregamento", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: NOTA FISCAL ELETRÔNICA :::"

    Public Sub LoadGridNotaFiscal(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter

        Try

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "tipo"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = 1

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_mdfe_unidade_transporte", oSqlParameter)

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

#End Region

#Region "::: MDFe REFERENCIADO :::"

    Public Sub LoadGridReferenciado(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter

        Try

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "tipo"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = 2

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_mdfe_unidade_transporte", oSqlParameter)

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

#End Region

#End Region

#Region "::: TOTAIS :::"

#Region "::: CAPA :::"

    Public Sub InsertTotais()

        'Variaveis Locais
        Dim oSqlParameter(7) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "total_cte"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iQuantidadeTotalCTe

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "total_nfe"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iQuantidadeTotalNFe

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "total_nfe_mod1"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Int
            oSqlParameter(4).Value = iQuantidadeTotalNFMod

            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "total_carga"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.Float
            oSqlParameter(5).Value = dTotalCargaTransportada

            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "peso_bruto_total_carga"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.Float
            oSqlParameter(6).Value = dPesoBrutoTotalCarga

            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "codigo_unidade_medida"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.Int
            oSqlParameter(7).Value = iCodigoUnidadeMedida

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_mdfe_totais", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteTotais()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_mdfe_totais", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosTotais(ByVal txtTotalCTe As NumericEditBox, _
                           ByVal txtTotalNFe As NumericEditBox, _
                           ByVal txtTotalNFMod As NumericEditBox, _
                           ByVal txtTotalCargaTransportada As NumericEditBox, _
                           ByVal cboUnidadeMedidaTotal As UIComboBox, _
                           ByVal txtPesoBrutoTotal As NumericEditBox)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_mdfe_dados_totais", oSqlParameter)

            While oSqlDataReader.Read
                lCodigoEmissaoCapa = oSqlDataReader("codigo_mdfe_capa")
                txtTotalCTe.Value = oSqlDataReader("total_cte")
                txtTotalNFe.Value = oSqlDataReader("total_nfe")
                txtTotalNFMod.Value = oSqlDataReader("total_nfe_mod")
                txtTotalCargaTransportada.Value = oSqlDataReader("total_carga")
                cboUnidadeMedidaTotal.SelectedValue = oSqlDataReader("codigo_unidade_medida")
                txtPesoBrutoTotal.Value = oSqlDataReader("peso_bruto_total")
            End While


            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateTotais()

        'Variaveis Locais
        Dim oSqlParameter(7) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "total_cte"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iQuantidadeTotalCTe

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "total_nfe"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iQuantidadeTotalNFe

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "total_nfe_mod1"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Int
            oSqlParameter(4).Value = iQuantidadeTotalNFMod

            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "total_carga"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.Float
            oSqlParameter(5).Value = dTotalCargaTransportada

            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "peso_bruto_total_carga"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.Float
            oSqlParameter(6).Value = dPesoBrutoTotalCarga

            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "codigo_unidade_medida"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.Int
            oSqlParameter(7).Value = iCodigoUnidadeMedida

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_mdfe_totais", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: LACRE :::"

    Public Sub InsertLacre(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "numero_lacre"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iNumeroLacres


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_mdfe_lacre", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteLacre()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter

        Try
            For Each oRow As GridEXRow In gSelecaoRow
                'Seta Parametros - Código
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_empresa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(1).Value = goUsuario.iEmpresa

                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "codigo"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.Int
                oSqlParameter(2).Value = oRow.Cells("codigo").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_mdfe_lacre", oSqlParameter)
                'Exclui Linha da Grid
                oRow.Delete()

            Next
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridLacre(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_mdfe_lacre", oSqlParameter)

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

    Public Sub UpdateLacre(ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "numero_lacre"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iNumeroLacres

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.BigInt
            oSqlParameter(3).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_mdfe_lacre", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: AUTORIZADO TOTAL :::"

    Public Sub InsertAutorizado(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "cpf_cnpj_autorizado"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Value = sCNPJCPFAutorizados


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_mdfe_autorizado_xml", oSqlParameter)



        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteAutorizado()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter

        Try
            For Each oRow As GridEXRow In gSelecaoRow
                'Seta Parametros - Código
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoEmissaoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_empresa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(1).Value = goUsuario.iEmpresa

                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "codigo"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.Int
                oSqlParameter(2).Value = oRow.Cells("codigo").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_mdfe_autorizado_xml", oSqlParameter)
                'Exclui Linha da Grid
                oRow.Delete()

            Next
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridAutorizado(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_mdfe_autorizado_xml", oSqlParameter)

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

    Public Sub UpdateAutorizado(ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "cpf_cnpj_autorizado"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Value = sCNPJCPFAutorizados

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.BigInt
            oSqlParameter(3).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_mdfe_autorizado_xml", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try


    End Sub

#End Region

#End Region

#Region "::: INFORMAÇÕES ADICIONAIS :::"

    Public Sub InsertInformacoesAdicionais()

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "informacao_adicional_fisco"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Value = sInformacaoAdicionalFisco

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "informacao_adicional_contribuinte"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.VarChar
            oSqlParameter(3).Value = sInformacaoAdicionalContribuinte

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_mdfe_informacoes_adicionais", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteInformacoesAdicionais()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_mdfe_informacoes_adicionais", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosInformacoesAdicionais(ByVal txtDadosAdicionais As EditBox, _
                                              ByVal txtDadosAdicionaisFISCO As EditBox)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_mdfe_dados_informacoes_adicionais", oSqlParameter)

            While oSqlDataReader.Read
                lCodigoEmissaoCapa = oSqlDataReader("codigo_mdfe_capa")
                txtDadosAdicionais.Text = oSqlDataReader("dados_adicionais")
                txtDadosAdicionaisFISCO.Text = oSqlDataReader("dados_adicionais_fisco")
            End While


            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateInformacoesAdicionais()

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_mdfe_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoEmissaoCapa

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "informacao_adicional_fisco"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Value = sInformacaoAdicionalFisco

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "informacao_adicional_contribuinte"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.VarChar
            oSqlParameter(3).Value = sInformacaoAdicionalContribuinte

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_mdfe_informacoes_adicionais", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: NOTA FISCAL ELETRÔNICA :::"

    Public Sub UpdateMDFeFinalizar(ByVal sMensagemSefaz As String, _
                                     ByVal sChaveAcesso As String, _
                                     ByVal sJustificativa As String, _
                                     ByVal sXMLCancelamentoEnvio As String, _
                                     ByVal sXMLCancelamentoRetorno As String)

        'Variaveis Locais
        Dim oSqlParameter(7) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Mensagem Sefaz
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "mensagem_sefaz"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 255
            oSqlParameter(i).Value = sMensagemSefaz : i += 1

            'Seta Parametros - Chave de Acesso
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "chave_acesso"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sChaveAcesso : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = CInt(StatusNotaFiscalEletronica.Cancelada) : i += 1

            'Seta Parametros - XML Cancelamento Envio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "xml_cancelamento_envio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Text
            oSqlParameter(i).Value = sXMLCancelamentoEnvio : i += 1

            'Seta Parametros - XML Cancelamento Retorno
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "xml_cancelamento_retorno"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Text
            oSqlParameter(i).Value = sXMLCancelamentoRetorno : i += 1

            'Seta Parametros - Justificativa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "justificativa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 255
            oSqlParameter(i).Value = sJustificativa : i += 1

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
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_capa_mdfe_finalizar", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateMDFeEnvio(ByVal sMensagemSefaz As String, _
                              ByVal sChaveAcesso As String, _
                              ByVal sNumeroRecibo As String, _
                              ByVal sXMLEnvio As String, _
                              ByVal sXMLRetorno As String, _
                              ByVal lLote As Long, _
                              ByVal iCodigoTipoAmbienteMDFe As Integer)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Mensagem Sefaz
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "mensagem_sefaz"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 255
            oSqlParameter(i).Value = sMensagemSefaz : i += 1

            'Seta Parametros - Chave de Acesso
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "chave_acesso"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sChaveAcesso : i += 1

            'Seta Parametros - Número do Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = sNumeroRecibo : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = CInt(StatusManifestoEletronico.AguardandoRetorno) : i += 1

            'Seta Parametros - XML Envio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "xml_envio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Text
            oSqlParameter(i).Value = sXMLEnvio : i += 1

            'Seta Parametros - XML Retorno
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "xml_retorno"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Text
            oSqlParameter(i).Value = sXMLRetorno : i += 1

            'Seta Parametros - Lote
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "lote"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lLote : i += 1

            'Seta Parametros - Código Tipo de Ambiente NFe
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_ambiente_mdfe"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoAmbienteMDFe : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_capa_mdfe_envio", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateMDFeEnvioDuplicidade(ByVal sChaveAcesso As String, _
                                         ByVal sChaveAcessoCorreta As String, _
                                         ByVal sNumeroRecibo As String, _
                                         ByVal iCodigoTipoAmbienteMDFe As Integer)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Chave de Acesso
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "chave_acesso"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 44
            oSqlParameter(i).Value = sChaveAcesso : i += 1

            'Seta Parametros - Número do Recibo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_recibo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = sNumeroRecibo : i += 1

            'Seta Parametros - Código Tipo de Ambiente NFe
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_ambiente_mdfe"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoAmbienteMDFe : i += 1

            'Seta Parametros - Chave de Acesso Correta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "chave_acesso_correta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 44
            oSqlParameter(i).Value = sChaveAcessoCorreta : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_capa_mdfe_envio_duplicidade", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateMDFeRetorno(ByVal sMensagemSefaz As String, _
                                ByVal sChaveAcesso As String, _
                                ByVal sNumeroProtocolo As String, _
                                ByVal iStatus As Integer, _
                                ByVal sXMLProtocolo As String)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Mensagem Sefaz
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "mensagem_sefaz"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 255
            oSqlParameter(i).Value = sMensagemSefaz : i += 1

            'Seta Parametros - Chave de Acesso
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "chave_acesso"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sChaveAcesso : i += 1

            'Seta Parametros - Número do Protocolo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_protocolo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = sNumeroProtocolo : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iStatus : i += 1

            'Seta Parametros - XML Protocolo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "xml_protocolo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Text
            oSqlParameter(i).Value = sXMLProtocolo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_capa_mdfe_retorno", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    'Public Sub RetornoMDFe(ByVal sProtocolo As String, _
    '                      ByVal sMensagem As String)

    '    'Variaveis Locais
    '    Dim oSqlParameter(3) As SqlParameter
    '    Dim i As Integer = 0

    '    Try

    '        'Seta Parametros - Código Emissão Capa
    '        oSqlParameter(i) = New SqlParameter
    '        oSqlParameter(i).ParameterName = "codigo_emissao_capa"
    '        oSqlParameter(i).Direction = ParameterDirection.Input
    '        oSqlParameter(i).SqlDbType = SqlDbType.BigInt
    '        oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

    '        'Seta Parametros - Protocolo
    '        oSqlParameter(i) = New SqlParameter
    '        oSqlParameter(i).ParameterName = "protocolo"
    '        oSqlParameter(i).Direction = ParameterDirection.Input
    '        oSqlParameter(i).SqlDbType = SqlDbType.VarChar
    '        oSqlParameter(i).Size = 20
    '        oSqlParameter(i).Value = sProtocolo : i += 1

    '        'Seta Parametros - Mensagem
    '        oSqlParameter(i) = New SqlParameter
    '        oSqlParameter(i).ParameterName = "mensagem_sefaz"
    '        oSqlParameter(i).Direction = ParameterDirection.Input
    '        oSqlParameter(i).SqlDbType = SqlDbType.VarChar
    '        oSqlParameter(i).Size = 100
    '        oSqlParameter(i).Value = sMensagem : i += 1

    '        'Seta Parametros - Status
    '        oSqlParameter(i) = New SqlParameter
    '        oSqlParameter(i).ParameterName = "status"
    '        oSqlParameter(i).Direction = ParameterDirection.Input
    '        oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
    '        oSqlParameter(i).Value = StatusManifestoEletronico.Autorizado

    '        'Executa Query
    '        ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_nfe_protocolo", oSqlParameter)

    '    Catch SqlEx As SqlException
    '        Throw SqlEx
    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    'End Sub

    Public Sub LoadDadosMdFe(ByVal lCodigo As Long, _
                            ByRef sArquivoNFe As String, _
                            ByRef sArquivoProtocoloNFe As String, _
                            ByRef sArquivoCancelamentoNFe As String, _
                            ByRef sArquivoProtocoloCancelamentoNFe As String, _
                            ByRef sChaveAcess As String, _
                            ByRef sNotaFiscal As String, _
                            ByRef lCodigoParceiroNegocio As Long, _
                            ByRef lCodigoTituloCala As Long)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
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
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_dados_mdfe", oSqlParameter)

            While oSqlDataReader.Read

                sArquivoNFe = oSqlDataReader.Item("xml_transmissao")
                sArquivoProtocoloNFe = oSqlDataReader.Item("xml_protocolo")
                sArquivoCancelamentoNFe = oSqlDataReader.Item("xml_transmissao_cancelamento")
                sArquivoProtocoloCancelamentoNFe = oSqlDataReader.Item("xml_protocolo_cancelamento")
                sChaveAcess = oSqlDataReader.Item("chave_acesso")
                sNotaFiscal = "MDFe" & Format(oSqlDataReader.Item("numero_mdfe"), "000000000")
                lCodigoParceiroNegocio = oSqlDataReader.Item("codigo_destinatario")
                lCodigoTituloCala = oSqlDataReader.Item("codigo_titulo_capa")

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

#End Region

End Class
