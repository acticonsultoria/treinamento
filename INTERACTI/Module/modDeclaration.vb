Imports System.Runtime.InteropServices
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.GridEX

Public Module modDeclaration

#Region "::: VARIAVEIS GLOBAIS :::"

    'SPED
    Public oTxtInformacaoSPED As Janus.Windows.GridEX.EditControls.EditBox
    Public sNomeFormulario As String
    Public iFormularioGrid As Integer = -1

    Public glCodigoEditar As Long = -1

    Public bSistemaPerforma As Boolean = False

    'Conexão com o Banco de Dados    
    Public goDatabase As Database
    'Dados do Usuario
    Public goUsuario As Usuario
    'Dados do Emitente
    Public goEmitente As Emitente
    'Relatório - Crystal
    Public goCrystalReport As CrystalReports
    'Configurações de Email
    Public goEmail As Email
    'Configuração NFe
    Public goConfiguracaoNFe As ConfiguracaoNFe
    'Configuração NFSe
    Public goConfiguracaoNFSe As ConfiguracaoNFSe
    'Icone
    Public gIcon As Icon
    'Configuração Fonte
    Public goFonte As Fonte
    'Contole Alterado
    Public bChangeControl As Boolean
    Public sControlValue As String

    'Cor - Mensagens
    Public gColorInformacaoErro As Color = Color.Purple
    Public gColorInformacaoOK As Color = Color.Blue
    Public gColorSistemaErro As Color = Color.Red
    Public gAplicacao As String


    'Auxiliares - Sistema    
    Public gSelecao() As Integer
    Public gSelecaoRow() As Janus.Windows.GridEX.GridEXRow
    Public gSelecaoNode() As TreeNode
    Public goPageAtual As Janus.Windows.UI.Tab.UITabPage

    Public gLicencaAPIValida As Boolean = False

    'ComboBox - Cliente
    Public oTipoComboBox() As TipoComboBox

    'Controle Corrente
    Public oCurrentControl As Control

    'Ajuda
    Public sURLHelp As String

    'Find
    Public oComboBoxFind As UIComboBox
    Public oComboBoxFindGrupoItemProduto As UIComboBox
    Public sGrupoItemFerramentaConcatenado As String
    Public lGrupoItemCodigoOrdemProducao As Long = -1
    Public oEditBoxFind As EditBox
    Public oMaskedEditBoxFind As MaskedEditBox
    Public oMultiComboBoxFind As MTGCComboBox
    Public oGridEX As GridEX
    Public oGridExOrcamento As GridEX

    'Filtros
    Public iCodigoTipoClasse As Integer = -1
    Public iTipoAutoTextoFind As TipoAutotexto
    Public sFormularioFind As String = ""
    Public sTabelaFind As String = ""
    Public lCodigoItemFind As Long = -1
    Public iCodigoTipoItemFind As Integer = -1
    Public sItemVendaFind As String = ""
    Public sItemCompraFind As String = ""
    Public sItemProducaoFind As String = ""
    Public sItemEstoqueFind As String = ""
    Public sItemAtivoFixoFind As String = ""
    Public sInsumoProducaoFind As String = ""
    Public iCodigoTipoParceiroNegocioFind As Integer = -1
    Public sRetornoParceiroNegocio As String = ""
    Public bInserirProdutoFind As Boolean = False
    Public sTipoFind As String = ""
    Public sTelaVenda As String = ""
    Public iCodigoPersonalidadeFind As Integer = -1
    Public iCodigoClienteGlobal As Integer = -1
    Public sClienteGlobal As String = ""
    Public lCodigoVendaGlobal As Long = -1
    Public iCodigoPedidoItemGlobal As Integer = -1
    Public lCodigoOrcamentoGlobal As Long = -1
    Public iCodigoOrcamentoItemGlobal As Integer = -1
    Public sRevisaoGlobal As String = ""
    Public sQueryFind As String = ""
    Public iCodigoAtivoPai As Integer
    Public bIndicador As Boolean = False

    'Form MsgBox
    Public lCodigoMsgBox As Long = -1


    'Alerta
    Public bMensagem As Boolean = False
    Public oToolStripItem As ToolStripItem

#End Region

#Region "::: CONSTANTES GLOBAIS :::"

    Public Const gcKeyAPI As String = "00411863ACTi"
    Public Const gcAlgoritimo As String = "AES-256-CBC"
    Public Const gcAuthorization As String = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJici5jb20uaW50ZXJhY3Rpd2ViIiwiY29kaWdvIjoiMSIsIm5vbWUiOiJhY3RpIn0=.y0t03YlWanDIU9ir5EiwXujUIOQez+LdYqW6i0QZ4l4="
    Public Const gcUrl As String = "http://www.acticonsultoria.com.br/api-interacti/index.php/"

    'Dados do Sistema
    Public Const gcDefaultCaminhoArquivoXML = "\\192.168.200.200\ACTi\ARQUIVO FISCAL XML"
    Public Const gSistema As String = "INTERACTI"
    Public Const gcVersaoNFe As String = "iA03"
    Public Const gcKey As String = "00411863ACTi!@#$%¨&*"
    Public Const gcControlaLicenca As Boolean = False
    Public Const gcFormAjust As Integer = 0

    'Auxiliares
    Public Const gcTempoMensagem As Integer = 5000
    Public Const gcSeparadorReport As String = "¨"
    Public Const gcDateInicioBoleto As Date = #10/7/1997#
    Public Const gcUFExterior As String = "EX"

    'Constantes de Perfil
    Public Const gcSelect As String = "visualizar"
    Public Const gcInsert As String = "inserir"
    Public Const gcUpdate As String = "alterar"
    Public Const gcDelete As String = "excluir"
    Public Const gcPrint As String = "imprimir"
    Public Const gcAdministrator As String = "administrador"

    'Nota Fiscal Eletrônica
    Public Const QuantidadeMaximaHorasCancelamentoNFe As Integer = 168

#End Region

#Region "::: ESTRUTURAS GLOBAIS :::"

    'Controle Alterado
    Public Structure ControlChange
        Dim sUserControl As String
        Dim sControle As String
        Dim sTexto As String
        Dim sTextoPos As String
    End Structure

    'Tipo - Combobox
    Public Structure TipoComboBox
        Dim sTipo As String
        Dim oColor As Color
    End Structure

    'Email
    Public Structure Email
        Dim iCodigoFormaEnvio As Integer
        Dim sEmail As String
        Dim sServidor As String
        Dim iPorta As Integer
        Dim sUsuario As String
        Dim sSenha As String
        Dim bSsl As Boolean
    End Structure

    'Usuário
    Public Structure Usuario
        Public sUsuario As String
        Public sNome As String
        Public iPerfil As Integer
        Public iDepartamento As Integer
        Public iUsuario As Integer
        Public iEmpresa As Integer
        Public iCodigoTipoEmpresa As Integer
        Public iIdioma As Integer
        Public sEmpresa As String
        Public sCNPJEmpresa As String
        Public sDataValidade As String
        Public sDataValidacao As String
        Public sDataUltimoAcesso As String
        Public iNumeroLicenca As Integer
        Public sUF As String
        Public sCodigoIBGEMunicipio As String
        Public sSiglaEmpresa As String
        Public bBoletoBancarioDLL As Boolean

        'API
        Public bValidacaoLicencaAPI As Boolean
        Public sDataValidadeAPI As String
        Public sDataValidacaoAPI As String
        Public sDataUltimoAcessoAPI As String
        Public iNumeroLicencaAPI As Integer
        Public iToleranciaAPI As Integer

    End Structure

    'Banco de Dados
    Public Structure Database
        Dim sConnection As String
        Dim sDataSource As String
        Dim sInitialCatalog As String
        Dim sUserID As String
        Dim sPassword As String
    End Structure

    'Crystal Report
    Public Structure CrystalReports
        Dim sPath As String
        Dim sReport As String
        Dim sManual As String
        Dim sReportParameter() As CrystalReportsParameter
    End Structure

    'Report Parameter
    Public Structure CrystalReportsParameter
        Dim sValue As String
        Dim sParamenter As String
    End Structure

    'Configuração NFe
    Public Structure ConfiguracaoNFe
        Dim sPastaEntrada As String
        Dim sPastaSaida As String
        Dim sPastaRecibo As String
        Dim sPastaImpressao As String
        Dim sPastaXSD As String
        Dim sPastaEnvio As String
        Dim bHabilitarProxy As Boolean
        Dim sDominio As String
        Dim sUsuario As String
        Dim sSenha As String
        Dim sEndereco As String
        Dim iPorta As Integer
        Dim iCodigoTipoAmbienteNFe As TipoAmbienteNFe
        Dim iModoOperacaoNFe As ModoOperacaoNFe
        Dim sUF As String
        Dim sCodigoEstado As String
        Dim iTimeOut As Integer
        Dim iQuantidadeMaximaNF As Integer
        Dim iTamanhoMaximo As Integer
        Dim iFormatoImpressaoDANFE As Integer
        Dim bHorarioVerao As Boolean
        Dim sCertificado As String
        Dim bEnviarEmailAutomaticamente As Boolean
        Dim sUsuarioEmail As String
        Dim sEmail As String
        Dim sSenhaEmail As String
        Dim sServidorEmail As String
        Dim iPortaEmail As String
        Dim bSSLEmail As Boolean
        Dim iCodigoAutotextoEmail As Integer
    End Structure

    'Configuração MDFe
    Public Structure ConfiguracaoMDFe
        Dim sPastaEntrada As String
        Dim sPastaSaida As String
        Dim sPastaRecibo As String
        Dim sPastaImpressao As String
        Dim sPastaXSD As String
        Dim sPastaEnvio As String
        Dim bHabilitarProxy As Boolean
        Dim sDominio As String
        Dim sUsuario As String
        Dim sSenha As String
        Dim sEndereco As String
        Dim iPorta As Integer
        Dim iCodigoTipoAmbienteMDFe As TipoAmbienteNFe
        Dim iModoOperacaoMDFe As ModoOperacaoMDFe
        Dim sUF As String
        Dim sCodigoEstado As String
        Dim iTimeOut As Integer
        Dim iQuantidadeMaximaMDF As Integer
        Dim iTamanhoMaximo As Integer
        Dim iFormatoImpressaoDAMFE As Integer
        Dim bHorarioVerao As Boolean
        Dim sCertificado As String
    End Structure

    Public Enum ModoOperacaoMDFe
        normal = 1
        contigencia = 2
    End Enum

    Public goConfiguracaoMDFe As ConfiguracaoMDFe

    'Configuração NFe
    Public Structure ConfiguracaoNFSe
        Dim sPastaEntrada As String
        Dim sPastaSaida As String
        Dim sPastaRecibo As String
        Dim sPastaImpressao As String
        Dim sPastaXSD As String
        Dim sPastaEnvio As String
        Dim bHabilitarProxy As Boolean
        Dim sDominio As String
        Dim sUsuario As String
        Dim sSenha As String
        Dim sEndereco As String
        Dim iPorta As Integer
        Dim iCodigoTipoAmbienteNFSe As TipoAmbienteNFe
        Dim iTamanhoMaximo As Integer
    End Structure

    'Dados do Emitente
    Public Structure Emitente
        Dim sCNPJ As String
        Dim sRazaoSocial As String
        Dim sNomeFantasia As String
        Dim sRegimeTributario As String
        Dim sCEP As String
        Dim sPais As String
        Dim sUF As String
        Dim iUF As Integer
        Dim sMunicipio As String
        Dim iMunicipio As Integer
        Dim sLogradouro As String
        Dim sNumero As String
        Dim sComplemento As String
        Dim sBairro As String
        Dim sInscricaoEstadual As String
        Dim sInscricaoEstadualST As String
        Dim sInscricaoMunicipal As String
        Dim sEmail As String
        Dim sTelefone As String
        Dim dAliquotaPIS As Double
        Dim dAliquotaCOFINS As Double
        Dim iRegimeTributario As Integer
    End Structure

    'Dados do Emitente
    Public Structure Fonte
        Dim sFonte As String
        Dim dSize As Single
        Dim bBold As Boolean
        Dim bItalic As Boolean
    End Structure

    'Dados do Protocolo
    Public Structure InformacaoProtocoloNFe
        Dim sChaveAcesso As String
        Dim sDataProcessamento As String
        Dim sNumeroProtocolo As String
        Dim iStatus As Integer
        Dim sMotivo As String
    End Structure

    Public Structure InformacaoProtocoloMDFe
        Dim sChaveAcesso As String
        Dim sDataProcessamento As String
        Dim sNumeroProtocolo As String
        Dim iStatus As Integer
        Dim sMotivo As String
    End Structure

    'Vendas - Itens Retulizados
    Public Structure ItemUtilizadoVenda
        Public lCodigoItem As Long
        Public dQuantidadeNecessaria As Double
        Public dQuantidadeUtilizada As Double
        Public dValorUnitario As Double
    End Structure

    'Vedas - Preço do Produto
    Public Structure PrecoVendaProduto
        Public dQuantidade As Double
        Public dValorUnitario As Double
        Public dVariavel As Double
    End Structure

    'Formulário - Cadastro Básico
    Public Structure FormularioCadastroBasico
        Public oValor As Object
        Public sControle As String
    End Structure

    'Formulário - Gráfico
    Public Structure Grafico
        Public sX As String
        Public oSeries() As Dundas.Charting.WinControl.Series
    End Structure

    'Aprovar Pedido de Compra
    Public Structure PedidoCompra
        Dim iCodigoFornecedor As Integer
        Dim oRow() As Janus.Windows.GridEX.GridEXRow
        Dim dQuantidade As Integer
    End Structure

    'Previsão de Entrega
    Public Structure PrevisaoEntrega
        Dim iCodigoEntrega As Integer
        Dim sPrevisaoEntrega As String
        Dim dQuantidade As Double
        Dim dQuantidadeFaturada As Double
        Dim sNotaFiscal As String
    End Structure

    'Encargos Sociais - Espécie de Insumo
    Public Structure EncargosSociais
        Dim iCodigoEncargo As Integer
        Dim dPercentual As Double
    End Structure

#End Region

#Region "::: DELEGATE :::"

    Public Delegate Sub DelegateKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    Public Delegate Sub DelegateMouseClick(sender As Object, e As MouseEventArgs)
    Public Delegate Sub DelegateGotFocus(ByVal sender As Object, ByVal e As EventArgs)
    Public Delegate Sub DelegateLostFocus(ByVal sender As Object, ByVal e As EventArgs)
    Public Delegate Sub DelegateTextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Delegate Sub DelegateValueChanged(sender As Object, e As EventArgs)
    Public Delegate Sub DelegateCommandClick(sender As Object, e As Janus.Windows.UI.CommandBars.CommandEventArgs)
    Public Delegate Sub DelegateRowCheckStateChanged(sender As Object, e As RowCheckStateChangeEventArgs)
    Public Delegate Sub DelegateButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Public Delegate Sub DelegateLostFocusTextBox(ByVal sender As Object, ByVal e As EventArgs)

#End Region

#Region "::: ENUMS GLOBAIS :::"
    'Condição de Aqusisição do Ativo Imobilizado
    Public Enum CondicaoAquisicao

        Novo = 1
        UsadoComNotaOrigem = 2
        UsadoSemDocumentoOrigem = 3

    End Enum
    Public Enum TipoApontamentoAutomatizado

        OrdemProducao = 1
        OrdemServico = 2
        OrdemIndustrializacao = 3
        OrdemDespesa = 4

    End Enum

    Public Enum FluxoNTO

        Processo = 1
        Projeto = 2
        Suprimentos = 3
        Producao = 4
        Qualidade = 5
        FollowUp = 6

    End Enum

    Public Enum DisposicaoNTO

        AceitoNoEstado = 1
        Retrabalhar = 2
        Refabricar = 3
        Sucatear = 4

    End Enum

    Public Enum ResponsavelDisposicaoNTO

        Interno = 1
        Fornecedor = 2

    End Enum

    Public Enum TipoFornecedorNTO

        Externo = 1
        Interno = 2

    End Enum

    Public Enum TipoControleLicenca
        Interacti = 1
        API = 2
    End Enum


    Public Enum StatusManifestoEletronico
        AguardandoTransmissao = 1
        AguardandoRetorno = 2
        Rejeitada = 3
        AutorizadaUso = 4
        Cancelada = 5
        EnviadoDestinatario = 6
    End Enum

    Public Enum TipoIntervalo
        Horas = 1
        Dias = 2
        Semanas = 3
        Meses = 4
        Anos = 5
    End Enum

#Region "::: SPED :::"

    'Tipo de Energia
    Public Enum TipoEnergia
        Eletrica = 1
    End Enum

    'Tipo de Operação de Comunicação
    Public Enum TipoOperacaoComunicacao
        Comunicacao = 1
        Telecomunicacao = 2
    End Enum

    'Tipo de Conhecimento de Transporte
    Public Enum TipoConhecimentoTranporte
        Aereo = 1
    End Enum

#End Region

    'Formulários do Sistema
    Public Enum Formulario

        LogAlteracao = 6000

        FinanceiroImportarExtratoVinculo = 1
        'Administração
        AdministracaoAlterarSenha = 1
        AdministracaoAtualizarAplicativo = 2
        AdministracaoAlternarUsuario = 3
        AdministracaoBackupDatabase = 4
        AdministracaoCadastroPerfil = 5
        AdministracaoCadastroUsuario = 6
        AdministracaoConfiguracaoInteracti = 7
        AdministracaoControleLicenca = 6
        AdministracaoGerarArquivoLicenca = 9
        AdministracaoSQL = 10
        AdministracaoMenuSuspenso = 11
        AdministracaoTelaInicial = 12
        AdministracaoSQLCompare = 13
        AdministracaoIdioma = 14
        AdministracaoMalaDireta = 15

        AlertaRH = 8000
        AlertaEquipamento = 8001
        AlertaVendaVisita = 8002
        AlertaNFeDestinada = 8003

        'Cadastro Básico
        CadastroBasicoAjudaCusto = 101
        CadastroBasicoOcupacao = 102
        CadastroBasicoBanco = 103
        CadastroBasicoBancoConta = 104
        CadastroBasicoBomba = 105
        CadastroBasicoCalendario = 106
        CadastroBasicoCentroGasto = 107
        CadastroBasicoCentroTrabalho = 108
        CadastroBasicoCertificadoImportacao = 109
        CadastroBasicoCFOP = 110
        CadastroBasicoCondicaoPagamento = 113
        CadastroBasicoDepartamento = 115
        CadastroBasicoDeposito = 116
        CadastroBasicoDocumento = 117
        CadastroBasicoEmpresa = 119
        CadastroBasicoFuncionario = 121
        CadastroBasicoGrupoItem = 123
        CadastroBasicoGrupoRejeito = 124
        CadastroBasicoIncoterms = 126
        CadastroBasicoInstrucaoEmbarque = 127
        CadastroBasicoModalidadeTransporte = 129
        CadastroBasicoMoeda = 130
        CadastroBasicoMotivoRequisicaoEstoque = 131
        CadastroBasicoNaturezaOperacao = 132
        CadastroBasicoNCM = 133
        CadastroBasicoGrupoMotivoParada = 134
        CadastroBasicoOperacao = 135
        CadastroBasicoPais = 136
        CadastroBasicoParceiroNegocio = 137
        CadastroBasicoParceiroNegocioSegmento = 138
        CadastroBasicoPlanoContas = 139
        CadastroBasicoProduto = 140
        CadastroBasicoProdutoBOM = 141
        CadastroBasicoProdutoPrecoVenda = 142
        CadastroBasicoRejeito = 143
        CadastroBasicoServico = 144
        CadastroBasicoTipoDocumento = 146
        CadastroBasicoTipoHoraExtra = 147
        CadastroBasicoTipoVeiculo = 148
        CadastroBasicoTransportadora = 149
        CadastroBasicoTurno = 150
        CadastroBasicoUnidadeMedida = 151
        CadastroBasicoVeiculo = 152
        CadastroBasicoVeiculoKmHora = 153
        CadastroBasicoVendedor = 154
        CadastroBasicoParceiroNegocioRelacionamento = 155
        CadastroBasicoAtoConcessorio = 156
        CadastroBasicoContratoCambio = 157
        CadastroBasicoTextoEmail = 159
        CadastroBasicoAgenda = 160
        CadastroBasicoProdutoEspecificacao = 161
        CadastroBasicoProdutoPlanoControle = 189
        CadastroBasicoProdutoFolhaOperacao = 190
        CadastroBasicoRoteiroProducao = 164
        CadastroBasicoListaCAMEX = 165
        'CadastroBasicoProdutoListaPreco = 166
        CadastroBasicoProdutoDisparco = 167
        CadastroBasicoCartaoCredito = 168
        CadastroBasicoProbabilidadeExitoVenda = 169
        CadastroBasicoRelatorio = 170
        CadastroBasicoMolde = 173
        CadastroBasicoTipoArquivo = 175
        CadastroBasicoQualidadeCaracteristicasInspecionar = 176
        CadastroBasicoItemGrupoItem = 177
        CadastroBasicoTipoContato = 179
        CadastroBasicoBandeiraCartaoCredito = 180
        CadastroBasicoProdutoLMTerm = 181
        CadastroBasicoPortariaNotaFiscal = 182
        CadastroBasicoAutotexto = 183
        CadastroBasicoProdutoRoteiroProducao = 184
        CadastroBasicoMaquinaEquipamento = 185
        CadastroBasicoProdutoModeloRoteiroProducao = 186
        CadastroBasicoMotivoParada = 187
        CadastroBasicoDespesa = 188
        CadastroBasicoControle = 191
        CadastroBasicoControleDados = 192
        CadastroBasicoControleVinculado = 193
        CadastroBasicoProdutoControlesDinamicos = 198
        CadastroBasicoProdutoMarca = 199
        CadastroBasicoRegiao = 158
        CadastroBasicoCampanhaAbrangencia = 200
        CadastroBasicoCampanha = 201
        CadastroBasicoCentroGastoBudget = 202
        CadastroBasicoDocumentoWord = 111
        CadastroBasicoParceiroNegocioFornecedor = 4000
        CadastroBasicoParceiroNegocioCliente = 4001
        CadastroBasicoParceiroNegocioDespachante = 4002
        CadastroBasicoParceiroNegocioAgenteLogistico = 4003
        CadastroBasicoParceiroNegocioClienteNegativacao = 4004
        CadastroBasicoParceiroNegocioClienteCondicaoFornecimento = 4005
        CadastroBasicoParceiroNegocioClienteCRM = 4006
        CadastroBasicoParceiroNegocioFornecedorCertificados = 4007
        CadastroBasicoParceiroNegocioContatos = 4008
        CadastroBasicoParceiroNegocioEnderecos = 4009
        CadastroBasicoParceiroNegocioClienteMarcasHomologadas = 4010
        CadastroBasicoColecao = 4012
        CadastroBasicoCor = 4013
        CadastroBasicoEstampa = 4014
        CadastroBasicoModelo = 4015
        CadastroBasicoTamanho = 4016
        CadastroBasicoTecido = 4017
        CadastroBasicoMaterial = 4018
        CadastroBasicoTurnoProducao = 4019
        CadastroBasicoArea = 4020
        CadastroBasicoEquipe = 4021
        CadastroBasicoAtividade = 4022
        CadastroBasicoManutencao = 4023
        CadastroBasicoPluviometria = 4024
        CadastroBasicoClasse = 4025
        CadastroBasicoPeneira = 4026
        CadastroBasicoCultivar = 4027
        CadastroBasicoParcela = 4028
        CadastroBasicoSafra = 4029
        CadastroBasicoPlantaFabrica = 4030
        CadastroBasicoVolume = 4031
        CadastroBasicoTipoAlca = 4032
        CadastroBasicoProdutoKuarup = 4033
        CadastroBasicoSutura = 4034
        CadastroBasicoEspecialidade = 4035
        CadastroBasicoTamanhoAgulha = 4036
        CadastroBasicoBitola = 4037
        CadastroBasicoFormatoAgulha = 4038
        CadastroBasicoDiametroFio = 4039
        CadastroBasicoComprimentoFio = 4040
        CadastroBasicoCorFio = 4041
        CadastroBasicoRelacionamento = 4042
        CadastroBasicoProdutoTabelaPrecoLBMedica = 4043
        CadastroBasicoProdutoLBMedica = 4044
        'CadastroBasicoParceiroNegocioTrakmaq = 4045
        CadastroBasicoProcedimentoCirurgico = 4046
        CadastroBasicoProdutoMETALG = 4047
        CadastroBasicoProdutoArte = 4048
        CadastroBasicoEmbalagem = 4049
        CadastroBasicoEspecieInsumo = 4050
        CadastroBasicoInsumo = 4051
        CadastroBasicoGrupoEncargosSociais = 4052
        CadastroBasicoEncargos = 4053
        CadastroBasicoEquipeTrabalho = 4054
        'CadastroBasicoParceiroNegocioMagma = 4055
        CadastroBasicoRota = 4056
        CadastroBasicoCadernoServico = 4058
        CadastroBasicoFormatoMP = 4059
        CadastroBasicoFabricante = 4060
        CadastroBasicoBaseOperacional = 4061
        CadastroBasicoPerguntaAnaliseCriticaOrcamento = 4062
        CadastroBasicoTipoFrasco = 4064
        CadastroBasicoDestinacao = 4065
        CadastroBasicoDestinacaoCFOPEntrada = 4066
        CadastroBasicoDescontos = 4067
        CadastroBasicoOutrasCobrancas = 4068
        CadastroBasicoTabelaLeitura = 4069
        CadastroBasicoGalpao = 4070
        CadastroBasicoEventoAdicional = 4073
        CadastroBasicoEvento = 4071
        CadastroBasicoBudget = 4075
        CadastroBasicoProjeto = 4076
        CadastroBasicoSubProjeto = 4077
        CadastroBasicoParceiroNegocioCentralEmail = 4078
        CadastroBasicoTipoItemSped = 4080
        CadastroItemMagma = 4083
        CadastroBasicoTextoSMS = 4084
        CadastroBasicoLocalizacaoMagma = 4085
        CadastroBasicoMotorista = 4086
        CadastroBasicoVeiculoMDFe = 4084
        CadastroBasicoItemLote = 4085
        CadastroBasicoClasseSeng = 4090
        CadastroBasicoDefeito = 4091
        CadastroBasicoResponsavel = 4092
        CadastroBasicoFluxo = 4093

        'Comercial
        ComercialComissaoRegra = 203
        ComercialComissaoGrupoItem = 204
        ComercialComissaoRegraFormula = 242
        ComercialCadastroJustificativaCancelamento = 243
        ComercialEventoPreco = 247
        ComercialEventoRevisao = 248
        ComercialEventoOrçamento = 249

        ComercialOrcamento = 205
        ComercialOrcamentoCancelar = 206
        ComercialOrcamentoLocacao = 207
        ComercialOrcamentoProduto = 208
        ComercialOrcamentoServico = 209
        ComercialOrcamentoDadosCliente = 210
        ComercialOrcamentoDadosLocacao = 211
        ComercialOrcamentoDadosProduto = 213
        ComercialOrcamentoDadosServico = 215
        ComercialOrcamentoLBMedica = 237
        ComercialOrcamentoIssartel = 239
        ComercialOrcamentoTranstelli = 240
        ComercialOrcamentoIndicadorCapacidade = 241
        ComercialOrcamentoIndicadorGanho = 242

        ComercialPedidoVenda = 217
        ComercialPedidoVendaProduto = 219
        ComercialPedidoVendaServico = 220
        ComercialPedidoVendaPagamento = 226
        ComercialPedidoVendaFinalizar = 227
        ComercialJustificativaCancelamento = 243
        ComercialPedidoVendaKuarup = 244
        ComercialPedidoVendaLBMedica = 238
        ComercialVendaOcorrenciaMagma = 245
        ComercialVendaOcorrenciaMagmaListaNegra = 246
        ComercialVendaInvoice = 247

        ComercialPedidoVendaControleEntrega = 221
        ComercialPDV = 228
        ComercialOrcamentoPrevisaoVenda = 229
        ComercialIntegracaoEmbraer = 230
        ComercialCadastroClassificacaoCliente = 231
        MarketingClassificarCliente = 232
        MarketingObjetivoVisita = 233
        MarketingVisita = 234
        MarketingAgenda = 235
        ComercialFormacaoPreco = 236
        ComercialAcordoComercial = 241
        ComercialPDVComercio = 245
        ComercialPedidoVEndaAprovarArte = 246
        ComercialIntegracaoEmbraer2 = 252
        ComercialOrcamentoDetalhado = 228

        'Compras
        ComprasRequisicao = 300
        ComprasRequisicaoAprovar = 301
        ComprasCotacao = 302
        ComprasCotacaoDefinirFornecedor = 303
        ComprasCotacaoAprovarOrcamento = 304
        ComprasCotacaoCancelar = 305
        ComprasCotacaoOrcamento = 306
        ComprasPedidoAprovar = 308
        ComprasRecebimento = 309
        ComprasRequisicaoAutomatico = 310
        ComprasContrato = 311
        ComprasAcordoComercial = 312

        'Compras
        ComprasPedido = 400
        ComprasPedidoCancelar = 401
        ComprasPedidoProduto = 402
        ComprasPedidoServico = 403
        ComprasPedidoDadosFornecedor = 404
        ComprasPedidoDadosProduto = 405
        ComprasPedidoHistoricoProduto = 406
        ComprasPedidoDadosServico = 407
        ComprasPedidoHistoricoServico = 408
        ComprasPedidoControleEntrega = 409
        ComprasPedidoReaprovar = 410
        ComprasPedidoAprovacaoSuperior = 411
        ComprasPedidoContrato = 412
        ComprasPedidoControleExecucao = 413
        ComprasIndicador2 = 50007
        ComprasIndicadorIAF = 416

        'Configuração        
        ConfiguracaoBancoContaSaldoInicial = 500
        ConfiguracaoBoletoBancario = 501
        ConfiguracaoEmail = 502
        ConfiguracaoNotaFiscalEletronica = 503
        ConfiguracaoNotaFiscalServicoEletronica = 504
        ConfiguracaoNumeracaoNotaFiscal = 505
        ConfiguracaoPastaIntegracaoNFe = 506
        ConfiguracaoCupomFiscal = 507
        ConfiguracaoNumeracaoOrcamento = 508
        ConfiguracaoNumeracaoPedidoVenda = 509
        ConfiguracaoNumeracaoPedidoCompra = 510
        ConfiguracaoNumeracaoOrdemProducao = 511
        ConfiguracaoNumeracaoCotacao = 512
        ConfiguracaoNumeracaoInventario = 513
        ConfiguracaoNumeracaoECF = 514
        ConfiguracaoNumeracaoRequisicaoCompra = 515
        ConfiguracaoNumeracaoRequisicaoEstoque = 516
        ConfiguracaoNumeracaoRecebimento = 517
        ConfiguracaoNumeracaoProduto = 518
        ConfiguracaoNumeracaoServico = 519
        ConfiguracaoNumeracaoOrdemServico = 520
        ConfiguracaoNumeracaoBoletimMedicao = 521
        ConfiguracaoNumeracaoComercialAcordoComercial = 522
        ConfiguracaoNumeracaoPicking = 523
        ConfiguracaoInteracti = 524
        ConfiguracaoManifestoEletronico = 525
        ConfiguracaoStatusOrdemProducao = 521

        'Contrato
        ContratoComodato = 600
        ContratoConsignacao = 601
        VendaRequisicaoConsignado = 602
        ContratoDiaria = 603
        ContratoDiariaFechamento = 604
        ContratoBoletimMedicao = 605
        ContratoDesconto = 606

        'Controle de Frota
        ControleFrotaConsumo = 700
        ControleFrotaManutencao = 701

        'Estoque
        EstoqueListagem = 800
        EstoqueMovimentacao = 801
        EstoqueLocalizacao = 802
        EstoqueInventario = 803
        EstoqueValorizacao = 804
        EstoqueRequisicao = 805
        EstoqueRequisicaoPagar = 807
        EstoqueRequisicaoEstornar = 808
        EstoqueEntradaProducao = 809
        EstoqueTransferenciaDeposito = 810
        EstoqueCurvaABC = 811
        EstoquePicking = 812
        EstoqueMovimentacaoManual = 813
        EstoqueEntradaPlantio = 814
        EstoqueBaixaPerda = 815
        EstoqueBaixaManual = 816
        EstoqueModelo7 = 817
        EstoqueIssartel = 818
        EstoqueRequisicaoPagarMultiplo = 819
        EstoqueImpressaoEtiqueta = 820

        'Faturamento - NFe
        FaturamentoEmissaoNFe = 900
        FaturamentoEmissaoNFeCancelar = 901
        FaturamentoEmissaoNFeConsultarSituacaoNFe = 902
        FaturamentoEmissaoNFeConsultarSituacaoParceiroNegocio = 903
        FaturamentoEmissaoNFeInutilizarNumeracao = 904
        FaturamentoEmissaoNFeStatusServico = 905
        FaturamentoEmissaoNFeGerarXML = 906
        FaturamentoEmissaoNFeFCI = 907
        FaturamentoEmissaoNFeLote = 908
        FaturamentoControleSMS = 908
        FaturamentoEmissaoNFeProdutoClassificacao = 909
        FaturamentoEntradaNFeProdutoClassificacao = 910
        FaturamentoEmissaoMDFe = 911
        FaturamentoEmissaoNFeDevolucaoMagma = 912
        FaturamentoControleDevolucao = 913
        FaturamentoAlteracaoEntrada = 914
        FaturamentoControleIndustrializacao = 915
        FaturamentoEmissaoRelatorio = 916

        'Faturamento - Serviço
        FaturamentoEmissaoNFs = 1000
        FaturamentoEmissaoNFsCancelar = 1001
        FaturamentoEntradaNFs = 1002
        FaturamentoEntradaNFsCancelar = 1003
        FaturamentoEntradaRelatorioCFOP = 1009

        'Faturamento - Locação
        FaturamentoEmissaoLocacao = 1050
        FaturamentoEmissaoLocacaoCancelar = 1051

        'Faturamento - Entrada NF
        FaturamentoEntradaNF = 1100
        FaturamentoEntradaNFCancelar = 1101
        FaturamentoEntradaNFDestinada = 1102
        FaturamentoEntradaNFIPI = 1103
        FaturamentoEntradaNFAprovar = 1104
        FaturamentoEntradaNFProdutoGerarEstoque = 1105
        FaturamentoEntradaComparativoValores = 1106
        FaturamentoEntradaNFXML = 1107
        FaturamentoEntradaCorrecao = 1108


        'Financeiro 
        FinanceiroFluxoCaixa = 1200
        FinanceiroReclassificacao = 1201
        FinanceiroExcluirPrevisao = 1202
        FinanceiroTransferenciaBancaria = 1203
        FinanceiroFluxoCaixaVertical = 1204
        FinanceiroReciboLocacao = 1205
        FinanceiroImportarExtrato = 1206
        FinanceiroTituloRecorrente = 1208
        'FinanceiroImportarExtratoVinculo = 1207
        FinanceiroReclassificacaoValor = 1209
        FinanceiroImportacaoRazao = 1210
        FinanceiroBaixaCheque = 1211
        FinanceiroControleAdiantamento = 1212

        'Financeiro - Despesa
        FinanceiroDespesaLancamento = 1300
        FinanceiroDespesaCancelar = 1301
        FinanceiroDespesaPagamento = 1302
        FinanceiroDespesaPagamentoCancelar = 1303
        FinanceiroDespesaControleCheque = 1304
        FinanceiroDespesaControleCartaoCredito = 1305
        FinanceiroDespesaNotaFiscalEntrada = 1306
        FinanceiroDespesaAdiantamento = 1308

        'Financeiro - Receita
        FinanceiroReceitaLancamento = 1400
        FinanceiroReceitaCancelar = 1401
        FinanceiroReceitaBoletoBancario = 1402
        FinanceiroReceitaPagamento = 1403
        FinanceiroReceitaPagamentoBoletoBancario = 1404
        FinanceiroReceitaPagamentoCancelar = 1405
        FinanceiroReceitaControleCheque = 1406
        FinanceiroReceitaCobranca = 1407
        FinanceiroReceitaCobrancaProtesto = 1408
        FinanceiroReceitaAdiantamento = 1409
        FinanceiroReceitaDescontoDuplicata = 1410
        FinanceiroReceitaNotaFiscalEmissao = 1307
        FinanceiroReceitaFaturamentoDevolucao = 1411
        FinanceiroReceitaInclusaoCheque = 1412
        FinanceiroReceitaControleBoletoBancario = 1413
        FinanceiroPrevisaoMensal = 1414

        'Imposto
        ImpostoRegraICMS = 1500
        ImpostoRegraIPI = 1501
        ImpostoRegraPIS = 1502
        ImpostoRegraCOFINS = 1503
        ImpostoRegra = 1504
        ImpostoSimplesNacional = 1505
        ImpostoRegraII = 1506
        ImpostoNCMIBPT = 4057
        ImpostoFCI = 1507

        'Integração
        IntegracaoImportarNFe = 1600
        IntegracaoProsoft = 1601
        IntegracaoImportarProduto = 1602
        IntegracaoImportarNFs = 1603
        IntegracaoBoletoBancario = 1604
        IntegracaoLCBSistema = 1605
        IntegracaoK2 = 1606
        IntegracaoMagmaParceiroNegocio = 1608
        IntegracaoMagmaProduto = 1609
        IntegracaoMagmaPedidoVenda = 1607
        IntegracaoPedidoVendaCarcare = 1610
        IntegracaoImportarNFeTXT = 1611
        IntegracaoSolidWorks = 1614
        IntegracaoMagmaOcorrencia = 1614

        'Link
        LinkVendaProducao = 9001

        'Produção
        ProducaoPlanejamento = 1700
        ProducaoOrdemProducao = 1701
        ProducaoApontamento = 1703
        ProducaoPlanejamentoMolde = 1704
        ProducaoOrdemProducaoManual = 1705
        ProducaoForecast = 1706
        ProducaoOrdemProducaoTratamentoRejeito = 1707
        ProducaoPlanejamentoMaquina = 1708
        ProducaoApontamentoManual = 1709
        ProducaoVisaoPlanta = 1710
        ProducaoForecastDia = 1711
        ProducaoOrdemProducaoLumaVale = 1712
        ProducaoOrdemProducaoLumaValeFiltro = 1713
        ProducaoOrdemProducaoProjeto = 4079
        ProducaoAnalise = 1714
        ProducaoOrdemDespesa = 1715
        ProducaoApontamentoDespesa = 1716
        ProducaoAnaliseSeng = 1717
        ProducaoOrdemServico = 1718
        ProducaoIndicadorHorasApontadas = 4079
        ProducaoIndicadorHorasApontadasItem = 4080
        ProducaoApontamentoAutomatizado = 1721

        'Qualidade
        QualidadeInspecaoRecebimento = 1750
        QualidadeInspecaoProducao = 1751
        QualidadeRecebimento = 1752
        QualidadeNTO = 1753
        QualidadeNTOIndicador = 1754
        QualidadeNTORelatorio = 1755
        IndicadorNTOFluxo = 1757
        IndicadorFilaInspecao = 1758
        IndicadorNTOAnaliseCritica = 1759

        'ATIVO
        CadastroAtivoImobilizado = 4088
        RelatorioAtivoImobilizado = 4089
        FindCadastroBasicoAtivoImobilizado = 4087
        CadastroBasicoAtivoFixo = 5028

        RelatorioCAD000000001 = 1890
        RelatorioCAD000000002 = 1891
        RelatorioCAD000000003 = 1892
        RelatorioCAD000000004 = 1893
        RelatorioCAD000000005 = 1894
        RelatorioCMP000000001 = 1918
        RelatorioCMP000000002 = 1023
        RelatorioCMP000000003 = 1920
        RelatorioCMP000000007 = 1919
        RelatorioCMP000000008 = 1922
        RelatorioCMP000000009 = 1926
        RelatorioCMP000000010 = 1927
        RelatorioCMP000000011 = 1928
        RelatorioEST000000001 = 1800
        RelatorioEST000000002 = 1801
        RelatorioEST000000003 = 1802
        RelatorioEST000000004 = 1803
        RelatorioEST000000005 = 1804
        RelatorioEST000000006 = 1972
        RelatorioEST000000010 = 1806
        RelatorioFAT000000001 = 1820
        RelatorioFAT000000002 = 1821
        RelatorioFAT000000003 = 1822
        RelatorioFAT000000004 = 1823
        RelatorioFAT000000007 = 1826
        RelatorioFAT000000008 = 1827
        RelatorioFAT000000009 = 1828
        RelatorioFAT000000012 = 1933
        RelatorioFAT000000013 = 1829
        RelatorioFAT000000014 = 1830
        RelatorioFAT000000015 = 1831
        RelatorioFAT000000016 = 1832
        RelatorioFAT000000017 = 1833
        RelatorioFAT000000018 = 1834
        RelatorioFAT000000019 = 1835
        RelatorioFAT000000020 = 1836
        RelatorioFAT000000024 = 1837
        RelatorioFIN000000001 = 1840
        RelatorioFIN000000002 = 1841
        RelatorioFIN000000003 = 1842
        RelatorioFIN000000004 = 1843
        RelatorioFIN000000005 = 1844
        RelatorioFIN000000006 = 1845
        RelatorioFIN000000007 = 1846
        RelatorioFIN000000008 = 1847
        RelatorioFIN000000009 = 1848
        RelatorioFIN000000010 = 1849
        RelatorioFIN000000011 = 1850
        RelatorioFIN000000012 = 1851
        RelatorioFIN000000013 = 1935
        RelatorioFIN000000014 = 1936
        RelatorioFIN000000015 = 1937
        RelatorioFIN000000016 = 1938
        RelatorioFIN000000017 = 1939
        RelatorioFIN000000018 = 1940
        RelatorioFIN000000024 = 1856
        RelatorioFIN000000030 = 1941
        RelatorioVEN000000001 = 1860
        RelatorioVEN000000002 = 1861
        RelatorioVEN000000003 = 1862
        RelatorioVEN000000003_02 = 1863
        RelatorioVEN000000003_03 = 1864
        RelatorioVEN000000003_04 = 1865
        RelatorioVEN000000004 = 1866
        RelatorioVEN000000005 = 1867
        RelatorioVEN000000006 = 1868
        RelatorioVEN000000007 = 1869
        RelatorioVEN000000008 = 1870
        RelatorioVEN000000009 = 1871
        RelatorioVEN0000000010 = 1872
        RelatorioVEN0000000011 = 1873
        RelatorioVEN0000000012 = 1874
        RelatorioVEN0000000013 = 1875
        RelatorioVEN000000014 = 1876
        RelatorioVEN000000015 = 1877
        RelatorioVEN000000018 = 1878
        RelatorioVEN000000019 = 1879
        RelatorioVEN000000020 = 1880
        RelatorioPRD000000001 = 1811
        RelatorioPRD000000003 = 1911
        RelatorioPRD000000004 = 1912
        RelatorioPRD000000005 = 1913
        RelatorioPRD000000006 = 1914
        RelatorioPRD000000007 = 1720
        RelatorioQA000000001 = 1950
        RelatorioRH000000001 = 1880
        RelatorioMKT000000001 = 1930
        RelatorioMKT000000002 = 1931
        RelatorioMKT000000003 = 1932
        RelatorioCust000000001 = 1970
        RelatorioCust000000002 = 1971
        RelatorioMagma = 1972
        RelatorioFAT000000023 = 1974
        RelatorioVEN000000022 = 1975
        RelatorioVEN000000023 = 1976
        RelatorioVEN000000024 = 1977
        RelatorioVEN000000025 = 1978
        RelatorioVenCarteira = 1979
        FaturamentoRankingFornecedor = 1852

        'Relatório Magma
        'RelatorioMagma = 1972
        RelatorioAnaliseCadastro = 1973


        'RH
        RHFuncionarioSalario = 1900
        RHFuncionarioPonto = 1901
        RHFuncionarioPontoLancamento = 1902
        RHImportarArquivoAFD = 1903

        'Projeto
        ProjetoProcesso = 3500
        ProjetoIndicador = 3501

        'Serviço
        ServicoOrdemServico = 2000
        ServicoOrdemServicoCancelar = 2001
        ServicoApontamento = 2002
        ServicoApontamentoFechamento = 2003
        ServicoOrdemServicoFaturamento = 2004
        ServicoOrdemServicoDespesa = 2005

        'SPED
        SPEDDocumentoEntradaC500 = 3001
        SPEDDocumentoEntradaD100 = 3002
        SPEDDocumentoEntradaD500 = 3003

        'JNJ
        JnJCadastroBasicoAco = 5000
        JnJCadastroBasicoProduto = 5001
        JnJCadastroBasicoMensagem = 5002
        JnJCadastroBasicoComprimentoPonta = 5003
        JnJCadastroBasicoEmbalagem = 5004
        JnJCadastroBasicoFluxo = 5005
        JnJCadastroBasicoForma = 5006
        JnJCadastroBasicoFormato = 5007
        JnJCadastroBasicoFuncao = 5008
        JnJCadastroBasicoOperacao = 5009
        JnJCadastroBasicoPais = 5010
        JnJCadastroBasicoTipo = 5011
        JnJCadastroBasicoPonta = 5012
        JnJCadastroBasicoPinch = 5013
        JnJCadastroBasicoCurvatura = 5014
        JnJCadastroBasicoCorpo = 5015
        JnJCadastroBasicoTipoEncastoamento = 5016
        JnJCadastroBasicoCorda = 5017
        JnJCadastroBasicoDesenho = 5018
        JnJCadastroBasicoColetor = 5019
        JnJCadastroBasicoDocumento = 5020
        JnJCadastroBasicoAtividade = 5021
        JnJCadastroBasicoFuncionario = 5022
        JnJCadastroBasicoTurno = 5023
        JnJCadastroBasicoTipoHoraExtra = 5024
        JnJCadastroBasicoLocal = 5025
        JnJCadastroBasicoSuporte = 5026

        'JNJ Parâmetros
        JnJParametroColetor = 5100
        JnJParametroColeta = 5101

        'JNJ - Agulha - Teste de Penetração
        JNJAgulhaTestePenetracao = 7000

        'ECF
        ECFLeituraX = 6000
        ECFReducaoZ = 6001
        ECFAliquota = 6002
        ECFEmissao = 6003

        'Interacti
        InteraciMalaDireta = 9000

        'Aernnova
        AernnovaImportar = 10000
        AernnovaPlanejamento = 10003
        AernnovaCadastroBasicoLocalPartNumber = 10004
        AernnovaCadastroBasicoPrograma = 10005
        AernnovaCadastroBasicoAviao = 10006
        AernnovaCadastroBasicoDestinoMercadoria = 10007
        AernnovaCadastroBasicoModalidadeTransporte = 10008
        AernnovaCadastroBasicoOrigemMercadoria = 10009
        AernnovaCadastroBasicoFornecedor = 10010
        AernnovaCadastroBasicoMoeda = 10011
        AernnovaCadastroBasicoFormaPagamento = 10012
        AernnovaCadastroBasicoDespachante = 10013
        AernnovaCadastroBasicoTransportadora = 10014
        AernnovaCadastroBasicoStatusEnvio = 10015
        AernnovaCadastroBasicoEstacao = 10016
        AernnovaCadastroBasicoTipoDespesaImportacao = 10017
        AernnovaCadastroBasicoOperacao = 10018
        AernnovaCadastroBasicoCentroTrabalho = 10019
        AernnovaCadastroBasicoSubAtividade = 10020
        AernnovaCadastroBasicoFichagem = 10305
        AernnovaImportacaoControleEnvio = 10200
        AernnovaImportacaoPartNumberCritico = 10201
        AernnovaImportacaoPesquisa = 10202
        AernnovaPlanejamentoIndicadores = 10023
        AernnovaFichagem = 10300
        AernnovaExportacaoControleEnvio = 10301
        AernnovaFichagemDashboard = 10302
        AernnovaSerializacao = 10303
        AernnovaCadastroBasicoPartNumberSerializado = 10304
        AernnovaFichagemSequencia = 10305

        'Zigbee
        ZigBeeCadastroBotoeira = 20000
        ZigBeeCadastroPlanta = 20001
        ZigBeeAndonVisualizacaoPlanta = 20002
        ZigBeeAndonHistorico = 20003

        'Manutenção
        ManutencaoRequisicao = 30000
        ManutencaoRequisicaoAprovar = 30001
        ManutencaoOrdemServico = 30002
        ManutencaoOrdemServicoApontamento = 30003
        ManutencaoPreventiva = 30004

        'Plantio
        PlantioOrdemPlantio = 40000

        IndicadorFIN000000001 = 50000
        IndicadorFIN000000002 = 50001
        IndicadorFIN000000003 = 50002
        IndicadorFIN000000004 = 50003
        IndicadorFIN000000005 = 50004
        IndicadorFIN000000006 = 50005

        IndicadorVEN000000001 = 50100
        IndicadorVEN000000002 = 50101
        IndicadorVEN000000003 = 50102
        IndicadorVEN000000004 = 50103
        IndicadorVEN000000005 = 50104

        IndicadorFAT000000001 = 50200
        IndicadorFAT000000002 = 50201
        IndicadorFAT000000003 = 50202

        DashboardMain = 60000

        MedicoAgendamentoCirurgia = 70000

        'Custeio
        ApontamentoCusto = 80000
        CustoGerar = 80001
        CustoCenario = 80002
        CustoProducao = 80003
        CustoHorasMensais = 80004


        CadastroBasicoHardware = 100000

    End Enum

    'Idiomas do Sistema
    Public Enum Idioma
        Portugues = 1
        Ingles = 2
        Espanhol = 3
    End Enum

    'Tipo de Parceiro de Negócio
    Public Enum TipoParceiroNegocio
        cliente = 1
        fornecedor = 2
    End Enum

    'Tipo de Contato
    Public Enum TipoContato
        Comercial = 1
        Fiscal = 2
        Financeiro = 3
    End Enum

    'Tipo de Endereço
    Public Enum TipoEndereco
        Cobranca = 1
        Faturamento = 2
        Entrega = 3
        Correspondecia = 4
        Outros = 5
    End Enum

    'Tipo de Personalidade
    Public Enum Personalidade
        Juridica = 1
        Fisica = 2
        OrgaoPublico = 3
        Outros = 4
        Prospecção = 5
        Paciente = 6
        Medico = 7
        Hospital = 8
        Convenio = 9
        Instrumentador = 10
    End Enum

    'Tipo Campo
    Public Enum TipoCampo
        numero = 1
        texto = 2
        data = 3
        hora = 4
        minuto = 5
        email = 6
    End Enum

    'Tipo de Item
    Public Enum TipoItem
        nao_definido = 0
        produto = 1
        servico = 2
        ativo = 3
        insumo = 4
    End Enum

    'Tipo de Item - BOM
    Public Enum TipoItemBOM
        MateriaPrima = 1
        Ferramental = 2
        Insumo = 3
    End Enum

    'Forma de Venda do Item
    Public Enum FormaVendaItem
        Indefinido = 0
        PrecoFixo = 1
        MargemLucro = 2
        PrecoFixoVariavel = 3
        Kit = 4
    End Enum

    'País
    Public Enum Pais
        Brasil = 0
    End Enum

    'Moeda
    Public Enum Moeda
        Real = 1
        Dolar = 2
        Euro = 162
    End Enum

    'Formato Arquivo de Licença
    Public Enum FormatoArquivoLicenca
        DataValidacao = 0
        DataValidade = 1
        NumeroLicenca = 2
    End Enum

    'Forma de Pagamento NFe
    Public Enum FormaPagamentoNFe
        PagamentoAVista = 0
        PagamentoAPrazo = 1
        Outros = 2
    End Enum

    'Status Despesa
    Public Enum StatusTitulo
        Aberto = 1
        Quitado = 2
        ParcialmenteQuitado = 3
        Cancelado = 4
    End Enum

    'Status - Agendamento de Cirurgia
    Public Enum StatusAgendamentoCirurgia
        EmAberto = 1
        ComPedidoVenda = 2
        Faturado = 3
        Cancelado = 4
    End Enum

    'Status Despesa Parcela
    Public Enum StatusDespesaPagamento
        Quitado = 1
        ChequeNaoCompensado = 2
    End Enum

    'Status Despesa Fatura Cartão de Crédito
    Public Enum StatusDespesaFaturaCartaoCredito
        Paga = 2
        Aberta = 1
        EmAtraso = 3
    End Enum

    'Forma de Pagamento
    Public Enum TipoDocumentoPagamento
        BoletoBancario = 1
        Cheque = 2
        ChequeTerceiro = 3
        Dinheiro = 4
        TED = 5
        DOC = 6
        Bordero = 7
        CartaoDebito = 8
        CartaoCredito = 9
        TransferenciaDeposito = 10
        PagoCartorio = 11
        DuplicataDescontada = 12
    End Enum

    'Status Receita Pagamento
    Public Enum StatusReceitaPagamento
        Quitado = 1
        ChequeNaoCompensado = 2
    End Enum

    'Tipo de Título Financeiro
    Public Enum TipoTituloFinanceiro
        Real = 1
        Previsto = 2
    End Enum

    'Tipo de Calculo Desconto
    Public Enum TipoCalculoDesconto
        Porcentagem = 1
        Valor = 2
    End Enum

    'Motivo Pagamento a Menor
    Public Enum MotivoPagamentoMenor
        Desconto = 1
        PagamentoParcial = 2
        Tarifas = 3
    End Enum

    'Tipo de Ambiente - NFe
    Public Enum TipoAmbienteNFe
        producao = 1
        homologacao = 2
    End Enum

    'Tipo de Ambiente - MDFe
    Public Enum TipoAmbienteMDFe
        producao = 1
        homologacao = 2
    End Enum

    'Mode de Operação - NFe
    Public Enum ModoOperacaoNFe
        normal = 1
        contigencia = 2
    End Enum

    'Status NF 
    Public Enum StatusNotaFiscal
        AguardandoImpressao = 1
        Impressa = 2
        Cancelada = 3
    End Enum

    'Status NF Eletrônica
    Public Enum StatusNotaFiscalEletronica
        AguardandoTransmissao = 1
        AguardandoRetorno = 2
        Rejeitada = 3
        AutorizadaUso = 4
        Cancelada = 5
        EnviadoDestinatario = 6
        Simulacao = 7
    End Enum

    'Forma de Impressão NFe
    Public Enum FormaImpressaoDANFENFe
        Retrato = 1
        Paisagem = 2
    End Enum

    'Status NF de Entrada
    Public Enum StatusNotaFiscalEntrada
        EmDigitacao = 0
        EntradaEfetuadaSucesso = 1
        Cancelada = 2

    End Enum

    'Status NFS Eletrônica
    Public Enum StatusNFSe
        AguardandoTransmissao = 1
        AguardandoRetorno = 2
        AutorizadoUso = 3
        Rejeitada = 4
        Cancelada = 5
    End Enum

    'Status NF Locacao
    Public Enum StatusNFLocacao
        Elaboracao = 1
        Impressa = 2
        Cancelada = 3
    End Enum

    'Status NFS Entrada
    Public Enum StatusNFsEntrada
        AutorizadoUso = 1
        Cancelada = 2
    End Enum

    'Tipo Documento Fiscal
    Public Enum TipoDocumentoFiscal
        Entrada = 0
        Saida = 1
        SaidaSemNF = 2
        Picking = 3
    End Enum

    Public Enum TipoDocumentoFinanceiro
        Adiantamento = 25
    End Enum

    'Finalidade Emissão NFe
    Public Enum FinalidadeEmissaoNFe
        NFeNormal = 1
        NFeComplementar = 2
        NFeAjuste = 3
        NFeDevolucao = 4
    End Enum

    'Modalidade do Frete
    Public Enum ModalidadeFrete
        Emitente = 0
        Destinatario = 1
        Terceiro = 2
        SemFrete = 3
    End Enum

    'Tipo Operacação NFe
    Public Enum TipoOperacaoNFe
        NaoAplica = 0
        OperacaoPresencial = 1
        Internet = 3
        Teleatendimento = 4
        NFCeDomicilio = 5
        Outros = 9
    End Enum

    'Tipo Consumidor
    Public Enum TipoConsumidor
        Normal = 0
        ConsumidorFinal = 1
    End Enum

    'Forma de Emissão NFe
    Public Enum FormaEmissaoNFe
        Normal = 1
        Contingencia = 2
        ContingenciaSCAN = 3
        ContingenciaDPEC = 4
        ContingenciaFSDA = 5
    End Enum

    'Modalidade Determinação da Base de Calculo do ICMS
    Public Enum ModalidadeDeterminacaoBCICMS
        MargemValorAgregado = 0
        Pauta = 1
        PrecoTabelado = 2
        ValorOperacao = 3
    End Enum

    'Modalidade Determinação da Base de Calculo do ICMS ST
    Public Enum ModalidadeDeterminacaoBCICMSST
        PrecoTabelaMaximoSugerido = 0
        ListaNegativa = 1
        ListaPositiva = 2
        ListaNeutra = 3
        MargemValorAgregado = 4
        Pauta = 5
    End Enum

    'Tipo Calculo Imposto
    Public Enum TipoCalculoImposto
        Percentual = 1
        Valor = 2
    End Enum

    'WebService NFe
    Public Enum WebServiceNFe
        ConsultaCadastro = 1
        NfeRecepcao = 2
        NfeRetRecepcao = 3
        NfeCancelamento = 4
        NfeiNutilizacao = 5
        NfeStatusServico = 6
        NfeConsultaNF = 7
        NFeRecepcaoEvento = 8
    End Enum

    'WebService MDFe
    Public Enum WebServiceMDFe
        Recepcao = 1
        RetRecepcao = 2
        Evento = 3
        Consulta = 4
        StatusServico = 5
    End Enum

    'Tipo de Nota Fiscal
    Public Enum TipoNotaFiscal
        NotaFiscal = 1
        NotaFiscalEletronica = 2
        DACTE = 3
        CTRC = 4
        NFST = 5
        NFE = 6
        CTE = 7
        ManifestoEletronico = 8
    End Enum

    'Situação Tributária do IPI
    Public Enum SituacaoTributariaIPI
        _00 = 1
        _01 = 2
        _02 = 3
        _03 = 4
        _04 = 5
        _05 = 6
        _49 = 7
        _50 = 8
        _51 = 9
        _52 = 10
        _53 = 11
        _54 = 12
        _55 = 13
        _99 = 14
    End Enum

    'Situação Tributária do PIS
    Public Enum SituacaoTributariaPIS
        _01 = 1
        _02 = 2
        _03 = 3
        _04 = 4
        _06 = 5
        _07 = 6
        _08 = 7
        _09 = 8
        _99 = 9
        _70 = 70
    End Enum

    'Situação Tributária do COFINS
    Public Enum SituacaoTributariaCOFINS
        _01 = 1
        _02 = 2
        _03 = 3
        _04 = 4
        _06 = 5
        _07 = 6
        _08 = 7
        _09 = 8
        _99 = 9
        _70 = 70
    End Enum

    'Modelo de Nota Fiscal
    Public Enum ModeloNotaFiscal
        Modelo55 = 55
    End Enum

    Public Enum ModeloManifesto
        Modelo58 = 58
    End Enum

    'Tipo de Veículo
    Public Enum TipoVeiculo
        VeiculoReboque = 1
        Balsa = 2
        Vagao = 3
    End Enum

    'Regime de Tributação
    Public Enum RegimeTributario
        SimplesNacional = 1
        SimplesNacionalExceto = 2
        LucroPresumido = 3
        LucroReal = 4
    End Enum

    'Tipo de Empresa - Simples Nacional
    Public Enum TipoEmpresaSimplesNacional
        Comercio = 1
        Industria = 2
        Servico = 3
    End Enum

    'Tipo de Vendedor
    Public Enum TipoVendedor
        Representante = 1
        Vendedor = 2
        Supervisor = 3
        Gerente = 4
    End Enum

#Region "::: MANUTENÇÃO :::"

    Public Enum StatusRequisicaoManutencao
        AguardandoAprovacao = 1
        Aprovada = 2
        Reprovada = 3
        AguardandoOrdemServico = 4
        EmAndamento = 5
        Concluida = 6
    End Enum

    Public Enum TipoManutencao
        Preventiva = 1
        Preditiva = 2
        Corretiva = 3
    End Enum

    Public Enum StatusOrdemServicoManutencao
        EmAndamento = 1
        Concluido = 2
        Cancelado = 3
    End Enum

#End Region

#Region " - CADASTRO BÁSICO - "

    'Tipo de Autotexto Email
    Public Enum TipoAutotextoEmail
        Outros = 0
        PedidoCompra = 1
        SolicitacaoOrcamento = 2
        PedidoVenda = 3
        OrcamentoVenda = 4
        NotaFiscalEmissao = 5
        SolicitacaoAprovacaoArte = 6
        BoletoBancario = 7
    End Enum

    'Tipo de Empresa
    Public Enum TipoEmpresa
        Industria = 1
        Comercio = 2
    End Enum

    'Tipo de Conta Contábil
    Public Enum TipoContaContabil
        Titulo = 1
        ContaAtiva = 2
    End Enum

    'Tipo de Documento
    Public Enum TipoDocumento
        Equipamento = 1
        Funcionario = 2
    End Enum

    'Tipo de Equipamento
    Public Enum TipoEquipamento
        Equipamento = 1
        Veiculo = 2
        Guindaste = 3
    End Enum

    'Tipo Valor
    Public Enum TipoValor
        ValorHora = 1
        ValorFixo = 2
    End Enum

    'Tipo - Centro de Gasto
    Public Enum TipoCentroGasto
        CentroGastoAuxiliar = 1
        CentroGastoProdutivo = 2
    End Enum

    'Forma de Rateio - Centro de Gasto
    Public Enum FormaRateioCentroGasto
        Percentual = 1
    End Enum

    'Tipo de Máquina
    Public Enum TipoMaquina
        Injetora = 1
        Forno = 2
    End Enum

    'Tipo de Autotexto
    Public Enum TipoAutotexto
        TBD = -1
        TermoGarantia = 1
        CondicaoFornecimento = 2
        ObservacaoVenda = 3
        ObservacaoCompra = 4
        DadosAdicionais = 5
        SugestaoVenda = 6
        ObrigacoesContratante = 7
        ObrigacoesContratada = 8
    End Enum

    'Tipo de Campo
    Public Enum TipoCampoControle
        Numerico = 1
        Texto = 2
        Cadastro = 3
        CadastroCorrelacionado = 4
        SimNao = 5
    End Enum

    'Tipo de Negativação
    Public Enum TipoNegativacaoCliente
        BloquearCliente = 1
        AlertarVendedor = 2
        Liberado = 3
        Juridico = 4
        Protestado = 5
    End Enum

#End Region

#Region " - ECF - "

    'Tipo de Cupom Fiscal
    Public Enum TipoCupomFiscal
        CupomFiscal = 1
        PedidoVenda = 2
    End Enum

#End Region

#Region " - VENDAS - "

    'Status - Orçamento
    Public Enum FormaOrcamento
        ValorHora = 1
        Fechado = 2
    End Enum

    'Status - Pedido de Venda
    Public Enum StatusVendaPedidoItem
        PedidoVenda = 1
        Faturado = 2
        ParcialmenteFaturado = 3
        Cancelado = 4
        PedidoSeparado = 5
    End Enum

    'Status - Pedido de Venda Picking
    Public Enum StatusVendaPedidoPicking
        AguardandoPicking = 1
        FolhaImpressa = 2
        Separado = 3
    End Enum

    'Status - Orçamento Item
    Public Enum StatusOrcamentoItem
        Orcamento = 1
        PedidoVenda = 2
        Cancelado = 3
        ParcialmenteVendido = 4
    End Enum

    'Status - Consignado Item
    Public Enum StatusConsignadoItem
        Consignado = 1
        Remetido = 2
        Cancelado = 3
        ParciamentoRemetido = 4
    End Enum

    'Status Orçamento Pagamento
    Public Enum StatusOrcamentoPagamento
        Quitado = 1
        ChequeNaoCompensado = 2
    End Enum

    'Destinação
    Public Enum Destinacao
        Revenda = 1
        Consumo = 2
        RemessaIndustrializacao = 3
        RemessaConcerto = 4
        RemessaDemonstracao = 5
        Emprestimo = 6
        SimplesRemessa = 7
        RetornoConcerto = 8
        RemessaConsignado = 9
        Amostra = 10
        Locação = 11
    End Enum

    'Status Arte
    Public Enum StatusPedidoVendaArte
        AguardandoAprovacao = 1
        Aprovado = 2
        Reprovado = 3
    End Enum

#End Region

#Region " - COMPRAS - "

    'Tipo de Pedido
    Public Enum TipoPedido
        Pedido = 1
        Compra = 2
        Cancelado = 3
    End Enum

    'Status Pedido Pagamento
    Public Enum StatusPedidoPagamento
        Quitado = 1
        ChequeNaoCompensado = 2
    End Enum

    'Status da Requisição de Compras - Item
    Public Enum StatusRequisicaoComprasItem
        AguardandoAprovacao = 1
        Aprovado = 2
        AguardandoRecebimento = 3
        PedidoConcluido = 4
        Reprovado = 5
        EntregaEfetuada = 6
    End Enum

    'Status da Cotação
    Public Enum StatusComprasCotacao
        AguardandoCotacao = 1
        Cotando = 2
        Concluido = 3
        Cancelado = 4
    End Enum

    'Forma de Análise do Orçamento
    Public Enum FormaAnaliseOrcamento
        Preco = 1
        PrazoEntrega = 2
    End Enum

    'Status - Pedido de Compra
    Public Enum StatusCompraPedidoItem
        PedidoCompra = 1
        Entregue = 2
        ParcialmenteEntregue = 3
        Cancelado = 4
        Reavaliar = 5
    End Enum

    'Tipo de Pedido
    Public Enum TipoPedidoCompras
        PedidoSimples = 1
        ProcessoCompra = 2
    End Enum

#End Region

#Region " - ESTOQUE - "

    Public Enum StatusBaixaPerda
        AguardandoAprovacao = 1
        Aprovado = 2
        Cancelado = 3
    End Enum

    Public Enum StatusInventario
        AguardandoAprovacao = 1
        Aprovado = 2
        Reprovado = 3
    End Enum

    Public Enum TipoRequisicaoEstoque
        OrdemProducao = 1
        Outros = 2
        OrdemServico = 3
        OrdemServicoManutencao = 4
        Perda = 5
    End Enum

    Public Enum StatusRequisicaoEstoque
        NaoAtendida = 1
        ParcialmentePaga = 2
        RequisicaoPaga = 3
        Cancelada = 4
    End Enum

    Public Enum TipoMovimentacaoEstoqueCFOP
        EntradaSaida = 1
        SemMovimentacao = 2
        TransferenciaDeposito = 3
    End Enum

    Public Enum StatusPicking
        Picking = 1
        Cancelado = 2
    End Enum

    Public Enum MetodogoliaControleEstoque
        FIFO = 1
        FEFO = 2
        LIFO = 3
        NAO_DEFINIDO = 4
    End Enum

#End Region

#Region " - PRODUÇÃO - "

    Public Enum StatusOrdemProducao
        Producao = 1
        AguardandoEstoque = 2
        Concluido = 3
        Cancelado = 4
        EmAtraso = 5
    End Enum

    Public Enum StatusRevisaoRoteiro
        EmElaboracao = 1
        EmProducao = 2
        Revisado = 3
        Futuro = 4
    End Enum

    Public Enum TipoApontamentoConcorrente
        Nao = 0
        ApontaQuantidadeAbertuda = 1
        NaoApontaQuantidadeAbertura = 2
    End Enum

#End Region

#Region " - CONTRATO - "

    'Status - Diária
    Public Enum StatusDiaria
        Aberto = 1
        AguardandoAprovacao = 2
        Aprovado = 3
        Faturado = 4
        Cancelado = 5
    End Enum

    'Status - Diária
    Public Enum StatusBoletimMedica
        AguardandoAprovacao = 1
        Aprovado = 2
        Faturado = 3
        Cancelado = 4
    End Enum

#End Region

#Region " - IMPOSTO - "

    'Tipo de Regra
    Public Enum TipoRegraImposto
        Venda = 1
        RetornoMaterialIndustrializado = 2
        RemessaIndustrializacao = 3
        Importacao = 4
        DevolucaoNotaFiscalEmitida = 5
        DevolucaoNotaFiscalEntrada = 6
        RemessaComodato = 7
        RemessaConsignado = 8
        RetornoSimbolicoConsignado = 9
        DevoluvaoConsignado = 10
        Remessa = 11
        RetornoDemonstracao = 12
        RetornoLocacao = 13
        RetornoComodato = 14
        RetornoAmostra = 15
        RetornoBonificacao = 16
        RetornoSimplesRemessa = 17
        RetornoConcerto = 18
        DevolucaoNotaFiscalEntradaImposto = 19
    End Enum

#End Region

#Region " - NFS - "

    'Tipo de Ambiente - NFSe
    Public Enum TipoAmbienteNFSe
        naoidentificado = -1
        producao = 1
        homologacao = 2
    End Enum

    'Natureza da Operação - NFSe
    Public Enum NaturezaOperacaoNFSe
        TributacaoMunicipio = 1
        TributacaoForaMunicipio = 2
        Insencao = 3
        Imune = 4
        ExigbilidadeSuspensaDescisaoJudicial = 5
        ExigbilidadeSuspensaProcedimentoAdministrativo = 6
    End Enum

    'Tipo de Nota Fiscal - Serviço
    Public Enum TipoNotaFiscalServico
        NotaFiscal = 1
        NotaFiscalJoseense = 2
    End Enum

#End Region

#Region " - JNJ - "

    'Tipo de Mensagem - Coletor
    Public Enum JnJTipoMensagemColetor
        MensagemNormal = 1
        MensagemCondicional = 2
    End Enum

    'Condição - Mensagem do Coletor
    Public Enum JnJCondicaoMensagem
        Igual = 1
        Maior = 2
        Menor = 3
        Entre = 4
        Diferente = 5
        Fora = 6
    End Enum

    'Condição - Mensagem do Coletor - Retorno
    Public Enum JnJCondicaoMensagemRetorno
        SomaMsg1 = 1
        QtdeMsg1 = 2
        SomaMsg2 = 3
        QtdeMsg2 = 4
    End Enum

    'Condição - Tipo Valor
    Public Enum JnJTipoValor
        Numerico = 1
        Texto = 2
        BancoDados = 3
    End Enum

    'ECNT
    Public Enum JnJECNTPort
        JMenos = 5
        JMais = 4
        IMenos = 7
        IMais = 8
        Pare = 9
        FimCurso = 1
        CelulaCarga = 6
        Ganho = 2
    End Enum

#End Region

#Region " - PDV - "

    Public Enum TipoVendaPDV
        Venda = 1
        Orcamento = 2
        Faturamento = 3
    End Enum

#End Region

#Region " - DRAWBACK - "

    Public Enum StatusAtoConcessorio
        Aberto = 1
        Baixado = 2
        Fechado = 3
    End Enum

#End Region

#Region " - CONFIGURAÇÃO - "

    Public Enum TipoEmail
        Outlook = 1
        Interacti = 2
    End Enum

    Public Enum TipoEmailDestino
        Outros = 0
        PedidoCompra = 1
        SolicitacaoOrcamento = 2
        PedidoVenda = 3
        OrcamentoVenda = 4
        EmissaoNotaFiscal = 5
        MalaDireta = 6
    End Enum

#End Region

#Region " - ORDER DE SERVIÇO - "

    Public Enum StatusOrdemServico
        OrdemServico = 1
        Cancelado = 2
    End Enum

    Public Enum StatusOrdemServicoItem
        OrdemServico = 1
        Cancelado = 2
    End Enum

#End Region

#Region " - MENSAGENS - "

    Public Enum Mensagem
        RegistroExcluido = 1
        RegistroAlterado = 2
        RegistroInserido = 3
        DireitoAlteracao = 4
        DireitoInserir = 5
        RegistroSalvo = 6
        ValidacaoInserir = 7
        DireitoAdministrador = 8
        RegistroNaoPodeAlterado = 9
        ValidacaoSelecionar = 10
        OperacaoRealizadaSucesso = 11
        RegistroAprovado = 12
        ValidacaoCancelamento = 13
        OperacaoNaoRealizada = 14
        RegistroNaoPodeExcluido = 15
        RegistroNaoPodeCancelado = 16
        NaoExisteHistorico = 17
        ObjetoNaoEncontrado = 18
        Erro = 19
        QuantidadeCaracter = 20
        ValorInformadoNaoValido = 21
        DiretorioNaoEncontrado = 22
        NaoFoiInformado = 23
        DireitoImprimir = 24
        DireitoVisualizar = 25
        FK = 26
    End Enum

#End Region

#Region "::: NF-e DESTINADA :::"

    Public Enum StatusNotaFiscalDestinada
        NFeEntrada = 1
        NFeManifestada = 2
        NFeDownload = 3
    End Enum

#End Region

#Region "::: FATURAMENTO - ENTRADA DE NOTA FISCAL :::"

    'Váriaveis
    Public Enum TipoOperacaoNotaFiscalEntrada
        EntradaNFe = 1
        Compra = 2
        DevolucaoNFe = 3
        RetornoRemessaIndustrializacao = 4
        RemessaTerceiros = 5
        CobrancaServicoIndustrializacao = 6
        EntradaNFeNumeroDocumento = 7
        OrdemProducao = 8
    End Enum

    Public Enum StatusFaturamentoEntradaRecebimento
        Aprovado = 1
        AguardandoAprovacao = 2
        Reprovado = 3
    End Enum

#End Region

#Region "::: QUALIDADE :::"

    Public Enum QualidadeTipoCaracteristicaInspecionar
        Valor = 1
        SimNao = 2
    End Enum

#End Region

#Region "::: CONTRATO :::"

    Public Enum TipoDocumentoWord
        ContratoComodato = 1
    End Enum

#End Region

#End Region

#Region "::: DECLARATION CUPOM FISCAL - BEMAFI32.DLL :::"

    'Funções de Inicialização
    Public Declare Function Bematech_FI_AlteraSimboloMoeda Lib "BEMAFI32.DLL" (ByVal SimboloMoeda As String) As Integer
    Public Declare Function Bematech_FI_ProgramaAliquota Lib "BEMAFI32.DLL" (ByVal Aliquota As String, ByVal ICMS_ISS As Integer) As Integer
    Public Declare Function Bematech_FI_ProgramaHorarioVerao Lib "BEMAFI32.DLL" () As Integer
    Public Declare Function Bematech_FI_NomeiaDepartamento Lib "BEMAFI32.DLL" (ByVal Indice As Integer, ByVal Departamento As String) As Integer
    Public Declare Function Bematech_FI_NomeiaTotalizadorNaoSujeitoIcms Lib "BEMAFI32.DLL" (ByVal Indice As Integer, ByVal Totalizador As String) As Integer
    Public Declare Function Bematech_FI_ProgramaArredondamento Lib "BEMAFI32.DLL" () As Integer
    Public Declare Function Bematech_FI_ProgramaTruncamento Lib "BEMAFI32.DLL" () As Integer
    Public Declare Function Bematech_FI_LinhasEntreCupons Lib "BEMAFI32.DLL" (ByVal Linhas As Integer) As Integer
    Public Declare Function Bematech_FI_EspacoEntreLinhas Lib "BEMAFI32.DLL" (ByVal Dots As Integer) As Integer
    Public Declare Function Bematech_FI_ForcaImpactoAgulhas Lib "BEMAFI32.DLL" (ByVal ForcaImpacto As Integer) As Integer
    Public Declare Function Bematech_FI_HabilitaDesabilitaRetornoEstendidoMFD Lib "BEMAFI32.DLL" (ByVal FlagRetorno As String) As Integer
    Public Declare Function Bematech_FI_RetornoImpressoraMFD Lib "BEMAFI32.DLL" (ByRef ACK As Integer, ByRef ST1 As Integer, ByRef ST2 As Integer, ByRef ST3 As Integer) As Integer
    Public Declare Function Bematech_FI_VerificaTipoImpressora Lib "BEMAFI32.DLL" (ByRef TipoImpressora As String) As Integer
    'Cupom Fiscal
    Public Declare Function Bematech_FI_RetornoAliquotas Lib "BEMAFI32.DLL" (ByRef Aliquota As String) As Integer
    Public Declare Function Bematech_FI_AbreCupom Lib "BEMAFI32.DLL" (ByVal CGC_CPF As String) As Integer
    Public Declare Function Bematech_FI_VendeItem Lib "BEMAFI32.DLL" (ByVal Codigo As String, ByVal Descricao As String, ByVal Aliquota As String, ByVal TipoQuantidade As String, ByVal Quantidade As String, ByVal CasasDecimais As Integer, ByVal ValorUnitario As String, ByVal TipoDesconto As String, ByVal Desconto As String) As Integer
    Public Declare Function Bematech_FI_CancelaItemAnterior Lib "BEMAFI32.DLL" () As Integer
    Public Declare Function Bematech_FI_CancelaItemGenerico Lib "BEMAFI32.DLL" (ByVal NumeroItem As String) As Integer
    Public Declare Function Bematech_FI_CancelaCupom Lib "BEMAFI32.DLL" () As Integer
    Public Declare Function Bematech_FI_FechaCupomResumido Lib "BEMAFI32.DLL" (ByVal FormaPagamento As String, ByVal Mensagem As String) As Integer
    Public Declare Function Bematech_FI_FechaCupom Lib "BEMAFI32.DLL" (ByVal FormaPagamento As String, ByVal DiscontoAcrecimo As String, ByVal TipoDescontoAcrecimo As String, ByVal ValorAcrecimoDesconto As String, ByVal ValorPago As String, ByVal Mensagem As String) As Integer
    Public Declare Function Bematech_FI_VendeItemDepartamento Lib "BEMAFI32.DLL" (ByVal Codigo As String, ByVal Descricao As String, ByVal Aliquota As String, ByVal ValorUnitario As String, ByVal Quantidade As String, ByVal Acrescimo As String, ByVal Desconto As String, ByVal IndiceDepartamento As String, ByVal UnidadeMedida As String) As Integer
    Public Declare Function Bematech_FI_AumentaDescricaoItem Lib "BEMAFI32.DLL" (ByVal Descricao As String) As Integer
    Public Declare Function Bematech_FI_UsaUnidadeMedida Lib "BEMAFI32.DLL" (ByVal UnidadeMedida As String) As Integer
    Public Declare Function Bematech_FI_EstornoFormasPagamento Lib "BEMAFI32.DLL" (ByVal FormaOrigem As String, ByVal FormaDestino As String, ByVal Valor As String) As Integer
    Public Declare Function Bematech_FI_IniciaFechamentoCupom Lib "BEMAFI32.DLL" (ByVal AcrescimoDesconto As String, ByVal TipoAcrescimoDesconto As String, ByVal ValorAcrescimoDesconto As String) As Integer
    Public Declare Function Bematech_FI_EfetuaFormaPagamento Lib "BEMAFI32.DLL" (ByVal FormaPagamento As String, ByVal ValorFormaPagamento As String) As Integer
    Public Declare Function Bematech_FI_EfetuaFormaPagamentoDescricaoForma Lib "BEMAFI32.DLL" (ByVal FormaPagamento As String, ByVal ValorFormaPagamento As String, ByVal DescricaoOpcional As String) As Integer
    Public Declare Function Bematech_FI_TerminaFechamentoCupom Lib "BEMAFI32.DLL" (ByVal Mensagem As String) As Integer
    'Relatorios Fiscais
    Public Declare Function Bematech_FI_LeituraX Lib "BEMAFI32.DLL" () As Integer
    Public Declare Function Bematech_FI_ReducaoZ Lib "BEMAFI32.DLL" (ByVal Data As String, ByVal Hora As String) As Integer
    'Informacoes da Impressora
    Public Declare Function Bematech_FI_DadosUltimaReducao Lib "BEMAFI32.DLL" (ByVal DadosReducao As String) As Integer
    Public Declare Function Bematech_FI_NumeroCupom Lib "BEMAFI32.DLL" (ByVal NumeroCupom As String) As Integer
    Public Declare Function Bematech_FI_NumeroSerie Lib "BEMAFI32.DLL" (ByVal NumeroSerie As String) As Integer
    Public Declare Function Bematech_FI_RetornoImpressora Lib "BEMAFI32.DLL" (ByRef ACK As Integer, ByRef ST1 As Integer, ByRef ST2 As Integer) As Integer
    'Operacoes Nao Fiscais
    Public Declare Function Bematech_FI_AbreRelatorioGerencialMFD Lib "BEMAFI32.DLL" (ByVal Indice As String) As Integer
    Public Declare Function Bematech_FI_UsaRelatorioGerencialMFD Lib "BEMAFI32.DLL" (ByVal texto As String) As Integer
    Public Declare Function Bematech_FI_FechaRelatorioGerencial Lib "BEMAFI32.DLL" () As Integer

#End Region

#Region "::: DECLARATION DMA :::"

    Public Declare Function searchdevices Lib "easy_lab_ng_ab.dll" (ByRef ndevs As Byte) As Integer
    Public Declare Function readadc Lib "easy_lab_ng_ab.dll" (ByVal dev As Byte, ByVal resolution As Byte, ByVal channel As Byte, ByRef adc As Single) As Integer
    Public Declare Function getinportsab Lib "easy_lab_ng_ab.dll" (ByVal dev As Byte, ByRef dataIOout As Integer, ByRef dataIOin As Integer) As Integer
    Public Declare Function geticp Lib "easy_lab_ng_ab.dll" (ByVal dev As Byte, ByRef icp As Integer, ByRef counter As Integer) As Integer
    Public Declare Function config Lib "easy_lab_ng_ab.dll" (ByVal dev As Byte, ByVal EDDR As Byte, ByVal EDDRIOA As Byte, ByRef DDR As Integer, ByRef DDRIOA As Byte) As Integer
    Public Declare Function seticp Lib "easy_lab_ng_ab.dll" (ByVal dev As Byte, ByVal fr As Byte, ByVal counter As Byte) As Integer
    Public Declare Function setoutputportsab Lib "easy_lab_ng_ab.dll" (ByVal dev As Byte, ByVal dataout As Integer) As Integer

#End Region

#Region "::: DECLARATION IE :::"

    Public Declare Function ConsisteInscricaoEstadual Lib "DllInscE32" (ByVal Insc As String, ByVal UF As String) As Integer

#End Region

#Region "::: DECLARATION INI :::"

    'API standard para o suporte INI
    Public Declare Unicode Function WritePrivateProfileString Lib "kernel32" _
                            Alias "WritePrivateProfileStringW" (ByVal lpApplicationName As String, _
                            ByVal lpKeyName As String, ByVal lpString As String, _
                            ByVal lpFileName As String) As Int32

    Public Declare Unicode Function GetPrivateProfileString Lib "kernel32" _
                        Alias "GetPrivateProfileStringW" (ByVal lpApplicationName As String, _
                        ByVal lpKeyName As String, ByVal lpDefault As String, _
                        ByVal lpReturnedString As String, ByVal nSize As Int32, _
                        ByVal lpFileName As String) As Int32

#End Region

#Region "::: OUTROS :::"

    Public Declare Function SetParent Lib "user32" (ByVal hWndChild As Long, ByVal hWndNewParent As Long) As Long
    Public Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Long
    Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.AsAny)> ByVal lParam As Object) As Integer
    Public Declare Function SetWindowPos Lib "user32" Alias "SetWindowPos" (ByVal hwnd As Integer, ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer
    Public Declare Function DestroyWindow Lib "user32" (ByVal hndw As Integer) As Boolean
    Public Declare Function capCreateCaptureWindowA Lib "avicap32.dll" (ByVal lpszWindowName As String, ByVal dwStyle As Integer, ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, ByVal nHeight As Short, ByVal hWndParent As Integer, ByVal nID As Integer) As Integer
    Public Declare Function capGetDriverDescriptionA Lib "avicap32.dll" (ByVal wDriver As Short, ByVal lpszName As String, ByVal cbName As Integer, ByVal lpszVer As String, ByVal cbVer As Integer) As Boolean
    Public Declare Function capSetCallbackOnFrame Lib "capSetCallbackOnFrame.dll" (ByVal hwnd As Long, ByVal fpProc As Long) As Long
    Public Declare Sub RtlMoveMemory Lib "kernel32" (ByVal hpvDest As Long, ByVal hpvSource As Long, ByVal cbCopy As Long)

#End Region

End Module