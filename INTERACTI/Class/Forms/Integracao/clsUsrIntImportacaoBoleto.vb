Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Microsoft.Office.Interop

Public Class clsUsrIntImportacaoBoleto

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private iCodigoBancoConta As Integer
    Private sNotaFiscal As String
    Private iCodigoGerarBoleto As Integer
    Private iCodigoBoletoNF As Integer
    Private iCodigoBoleto As Integer
    Private sRazaoSocial As String
    Private iCodigo As Integer
    Private iRegistroTitulo As Integer
    Private iAgenciaDebito As Integer
    Private sDigitoAgenciaDebito As String
    Private iRazaoContaCorrente As Integer
    Private iContaCorrente As Integer
    Private sDigitoContaCorrente As String
    Private sEmpresaBeneficiario As String
    Private sNumeroControleParticipante As String
    Private sCodigoBanco As String
    Private iMulta As Integer
    Private iPercentualMulta As Integer
    Private lTitulo As Long
    Private sDigitoAutoConfNumBancario As String
    Private dDescontoBonificacaoDia As Double
    Private iCondEmissaoPapeletaCobranca As String
    Private sBoletoDebitoAutomatico As String
    Private sOperacaoBanco As String
    Private sRateioCredito As String
    Private iEndAvisoDebAutomaticoCC As String
    Private iOcorrencia As Integer
    Private sNumeroDoc As String
    Private dtDataVencimentoTitulo As Date
    Private dValorTitulo As Double
    Private iBancoEncarregadoCobranca As Integer
    Private iAgenciaDepositaria As Integer
    Private iEspecieTitulo As Integer
    Private sIdentificacao As String
    Private dtDataEmissaoTitulo As Date
    Private iInstrucao1 As Integer
    Private iInstrucao2 As Integer
    Private dValorAtrasoDia As Double
    Private dtDataLimiteConDesconto As Date
    Private dValorDesconto As Double
    Private dValorIOF As Double
    Private dValorAbatimento As Double
    Private iTipoInscricaoPagador As Integer
    Private iInscricaoPagador As Integer
    Private sNomePagador As String
    Private sEnderecoPagador As String
    Private sMensagem1 As String
    Private iCEP As Integer
    Private iSufixoCEP As Integer
    Private sMensagem2 As String
    Private iNumeroRegistroTitulo As String
    Private iTipoRegistro As Integer
    Private sMensagem1InsTitulo As String
    Private sMensagem2InsTitulo As String
    Private sMensagem3 As String
    Private sMensagem4 As String
    Private dtDataLimiteDesconto2 As Date
    Private dtDataLimiteDesconto3 As Date
    Private dValorDesconto2 As Double
    Private dValorDesconto3 As Double
    Private sReserva As String
    Private sCarteira As String
    Private iAgencia As Integer
    Private sContaCorrenteInsTitulo As String
    Private sDigitoContaCorrenteInsTitulo As String
    Private sNossoNumero As String
    Private sDACNossoNumero As String
    Private iNumeroRegistroInsTitulo As Integer
    Private sNumeroInscricaoPagador As String

#End Region

#Region "::: PROPERTIE :::"
    Public Property CodigoBancoConta As Integer
        Get
            Return icodigobancoconta
        End Get
        Set(ByVal value As Integer)
            iCodigoBancoConta = value
        End Set
    End Property

    Public Property NotaFiscal() As String
        Get
            Return sNotaFiscal
        End Get
        Set(ByVal value As String)
            sNotaFiscal = value
        End Set
    End Property

    Public Property CodigoBoleto() As Integer
        Get
            Return iCodigoBoleto
        End Get
        Set(ByVal value As Integer)
            iCodigoBoleto = value
        End Set
    End Property

    Public Property CodigoGerarBoleto() As Integer
        Get
            Return iCodigoGerarBoleto
        End Get
        Set(ByVal value As Integer)
            iCodigoGerarBoleto = value
        End Set
    End Property

    Public Property CodigoBoletoNF() As Integer
        Get
            Return iCodigoBoletoNF
        End Get
        Set(ByVal value As Integer)
            iCodigoBoletoNF = value
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

    Public Property NumeroInscricaoPagador() As String
        Get
            Return sNumeroInscricaoPagador
        End Get
        Set(ByVal value As String)
            sNumeroInscricaoPagador = value
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
     
    Public Property CodigoBanco() As String
        Get
            Return sCodigoBanco
        End Get
        Set(ByVal value As String)
            sCodigoBanco = value
        End Set
    End Property

    Public Property DataLimiteConDesconto() As Date
        Get
            Return dtDataLimiteConDesconto
        End Get
        Set(ByVal value As Date)
            dtDataLimiteConDesconto = value
        End Set
    End Property

    Public Property DataEmissaoTitulo() As Date
        Get
            Return dtDataEmissaoTitulo
        End Get
        Set(ByVal value As Date)
            dtDataEmissaoTitulo = value
        End Set
    End Property

    Public Property DataVencimentoTitulo() As Date
        Get
            Return dtDataVencimentoTitulo
        End Get
        Set(ByVal value As Date)
            dtDataVencimentoTitulo = value
        End Set
    End Property

    Public Property DataLimiteDesconto2() As Date
        Get
            Return dtDataLimiteDesconto2
        End Get
        Set(ByVal value As Date)
            dtDataLimiteDesconto2 = value
        End Set
    End Property

    Public Property ValorAbatimento() As Double
        Get
            Return dValorAbatimento
        End Get
        Set(ByVal value As Double)
            dValorAbatimento = value
        End Set
    End Property

    Public Property ValorIOF() As Double
        Get
            Return dValorIOF
        End Get
        Set(ByVal value As Double)
            dValorIOF = value
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

    Public Property ValorAtrasoDia() As Double
        Get
            Return dValorAtrasoDia
        End Get
        Set(ByVal value As Double)
            dValorAtrasoDia = value
        End Set
    End Property

    Public Property DescontoBonificacaoDia() As Double
        Get
            Return dDescontoBonificacaoDia
        End Get
        Set(ByVal value As Double)
            dDescontoBonificacaoDia = value
        End Set
    End Property

    Public Property ValorDesconto2() As Double
        Get
            Return dValorDesconto2
        End Get
        Set(ByVal value As Double)
            dValorDesconto2 = value
        End Set
    End Property

    Public Property ValorTitulo() As Double
        Get
            Return dValorTitulo
        End Get
        Set(ByVal value As Double)
            dValorTitulo = value
        End Set
    End Property

    Public Property NomePagador() As String
        Get
            Return sNomePagador
        End Get
        Set(ByVal value As String)
            sNomePagador = value
        End Set
    End Property

    Public Property Identificacao() As String
        Get
            Return sIdentificacao
        End Get
        Set(ByVal value As String)
            sIdentificacao = value
        End Set
    End Property

    Public Property NumeroDoc() As String
        Get
            Return sNumeroDoc
        End Get
        Set(ByVal value As String)
            sNumeroDoc = value
        End Set
    End Property

    Public Property NumeroControleParticipante() As String
        Get
            Return sNumeroControleParticipante
        End Get
        Set(ByVal value As String)
            sNumeroControleParticipante = value
        End Set
    End Property

    Public Property EmpresaBeneficiario() As String
        Get
            Return sEmpresaBeneficiario
        End Get
        Set(ByVal value As String)
            sEmpresaBeneficiario = value
        End Set
    End Property

    Public Property DigitoContaCorrente() As String
        Get
            Return sDigitoContaCorrente
        End Get
        Set(ByVal value As String)
            sDigitoContaCorrente = value
        End Set
    End Property

    Public Property RateioCredito() As String
        Get
            Return sRateioCredito
        End Get
        Set(ByVal value As String)
            sRateioCredito = value
        End Set
    End Property

    Public Property OperacaoBanco() As String
        Get
            Return sOperacaoBanco
        End Get
        Set(ByVal value As String)
            sOperacaoBanco = value
        End Set
    End Property

    Public Property BoletoDebitoAutomatico() As String
        Get
            Return sBoletoDebitoAutomatico
        End Get
        Set(ByVal value As String)
            sBoletoDebitoAutomatico = value
        End Set
    End Property

    Public Property DigitoAutoConfNumBancario() As String
        Get
            Return sDigitoAutoConfNumBancario
        End Get
        Set(ByVal value As String)
            sDigitoAutoConfNumBancario = value
        End Set
    End Property

    Public Property DigitoAgenciaDebito() As String
        Get
            Return sDigitoAgenciaDebito
        End Get
        Set(ByVal value As String)
            sDigitoAgenciaDebito = value
        End Set
    End Property

    Public Property Reserva() As String
        Get
            Return sReserva
        End Get
        Set(ByVal value As String)
            sReserva = value
        End Set
    End Property

    Public Property Mensagem4() As String
        Get
            Return sMensagem4
        End Get
        Set(ByVal value As String)
            sMensagem4 = value
        End Set
    End Property

    Public Property Mensagem3() As String
        Get
            Return sMensagem3
        End Get
        Set(ByVal value As String)
            sMensagem3 = value
        End Set
    End Property

    Public Property Mensagem2InsTitulo() As String
        Get
            Return sMensagem2InsTitulo
        End Get
        Set(ByVal value As String)
            sMensagem2InsTitulo = value
        End Set
    End Property

    Public Property Mensagem1InsTitulo() As String
        Get
            Return sMensagem1InsTitulo
        End Get
        Set(ByVal value As String)
            sMensagem1InsTitulo = value
        End Set
    End Property

    Public Property NumeroRegistroTitulo() As String
        Get
            Return iNumeroRegistroTitulo
        End Get
        Set(ByVal value As String)
            iNumeroRegistroTitulo = value
        End Set
    End Property

    Public Property Mensagem2() As String
        Get
            Return sMensagem2
        End Get
        Set(ByVal value As String)
            sMensagem2 = value
        End Set
    End Property

    Public Property Mensagem1() As String
        Get
            Return sMensagem1
        End Get
        Set(ByVal value As String)
            sMensagem1 = value
        End Set
    End Property

    Public Property EnderecoPagador() As String
        Get
            Return sEnderecoPagador
        End Get
        Set(ByVal value As String)
            sEnderecoPagador = value
        End Set
    End Property

    Public Property NossoNumero() As String
        Get
            Return sNossoNumero
        End Get
        Set(ByVal value As String)
            sNossoNumero = value
        End Set
    End Property

    Public Property DigitoContaCorrenteInsTitulo() As String
        Get
            Return sDigitoContaCorrenteInsTitulo
        End Get
        Set(ByVal value As String)
            sDigitoContaCorrenteInsTitulo = value
        End Set
    End Property

    Public Property ContaCorrenteInsTitulo() As String
        Get
            Return sContaCorrenteInsTitulo
        End Get
        Set(ByVal value As String)
            sContaCorrenteInsTitulo = value
        End Set
    End Property

    Public Property Agencia() As Integer
        Get
            Return iAgencia
        End Get
        Set(ByVal value As Integer)
            iAgencia = value
        End Set
    End Property

    Public Property Carteira() As String
        Get
            Return sCarteira
        End Get
        Set(ByVal value As String)
            sCarteira = value
        End Set
    End Property

    Public Property TipoRegistro() As Integer
        Get
            Return iTipoRegistro
        End Get
        Set(ByVal value As Integer)
            iTipoRegistro = value
        End Set
    End Property

    Public Property ContaCorrente() As Integer
        Get
            Return iContaCorrente
        End Get
        Set(ByVal value As Integer)
            iContaCorrente = value
        End Set
    End Property

    Public Property RazaoContaCorrente() As Integer
        Get
            Return iRazaoContaCorrente
        End Get
        Set(ByVal value As Integer)
            iRazaoContaCorrente = value
        End Set
    End Property

    Public Property AgenciaDebito() As Integer
        Get
            Return iAgenciaDebito
        End Get
        Set(ByVal value As Integer)
            iAgenciaDebito = value
        End Set
    End Property

    Public Property RegistroTitulo() As Integer
        Get
            Return iRegistroTitulo
        End Get
        Set(ByVal value As Integer)
            iRegistroTitulo = value
        End Set
    End Property

    Public Property InscricaoPagador() As Integer
        Get
            Return iInscricaoPagador
        End Get
        Set(ByVal value As Integer)
            iInscricaoPagador = value
        End Set
    End Property

    Public Property TipoInscricaoPagador() As Integer
        Get
            Return iTipoInscricaoPagador
        End Get
        Set(ByVal value As Integer)
            iTipoInscricaoPagador = value
        End Set
    End Property

    Public Property SufixoCEP() As Integer
        Get
            Return iSufixoCEP
        End Get
        Set(ByVal value As Integer)
            iSufixoCEP = value
        End Set
    End Property

    Public Property CEP() As Integer
        Get
            Return iCEP
        End Get
        Set(ByVal value As Integer)
            iCEP = value
        End Set
    End Property

    Public Property Ocorrencia() As Integer
        Get
            Return iOcorrencia
        End Get
        Set(ByVal value As Integer)
            iOcorrencia = value
        End Set
    End Property

    Public Property EndAvisoDebAutomaticoCC() As String
        Get
            Return iEndAvisoDebAutomaticoCC
        End Get
        Set(ByVal value As String)
            iEndAvisoDebAutomaticoCC = value
        End Set
    End Property

    Public Property CondEmissaoPapeletaCobranca() As String
        Get
            Return iCondEmissaoPapeletaCobranca
        End Get
        Set(ByVal value As String)
            iCondEmissaoPapeletaCobranca = value
        End Set
    End Property

    Public Property AgenciaDepositaria() As Integer
        Get
            Return iAgenciaDepositaria
        End Get
        Set(ByVal value As Integer)
            iAgenciaDepositaria = value
        End Set
    End Property

    Public Property EspecieTitulo() As Integer
        Get
            Return iEspecieTitulo
        End Get
        Set(ByVal value As Integer)
            iEspecieTitulo = value
        End Set
    End Property

    Public Property Instrucao1() As Integer
        Get
            Return iInstrucao1
        End Get
        Set(ByVal value As Integer)
            iInstrucao1 = value
        End Set
    End Property

    Public Property Instrucao2() As Integer
        Get
            Return iInstrucao2
        End Get
        Set(ByVal value As Integer)
            iInstrucao2 = value
        End Set
    End Property

    Public Property Multa() As Integer
        Get
            Return iMulta
        End Get
        Set(ByVal value As Integer)
            iMulta = value
        End Set
    End Property

    Public Property PercentualMulta() As Integer
        Get
            Return iPercentualMulta
        End Get
        Set(ByVal value As Integer)
            iPercentualMulta = value
        End Set
    End Property

    Public Property Titulo() As Long
        Get
            Return lTitulo
        End Get
        Set(ByVal value As Long)
            lTitulo = value
        End Set
    End Property

    Public Property BancoEncarregadoCobranca() As Integer
        Get
            Return iBancoEncarregadoCobranca
        End Get
        Set(ByVal value As Integer)
            iBancoEncarregadoCobranca = value
        End Set
    End Property

    Public Property ValorDesconto3() As Double
        Get
            Return dValorDesconto3
        End Get
        Set(ByVal value As Double)
            dValorDesconto3 = value
        End Set
    End Property

    Public Property DACNossoNumero() As String
        Get
            Return sDACNossoNumero
        End Get
        Set(ByVal value As String)
            sDACNossoNumero = value
        End Set
    End Property
     
    Public Property DataLimiteDesconto3() As Date
        Get
            Return dtDataLimiteDesconto3
        End Get
        Set(ByVal value As Date)
            dtDataLimiteDesconto3 = value
        End Set
    End Property
     
    Public Property NumeroRegistroInsTitulo() As Integer
        Get
            Return iNumeroRegistroInsTitulo
        End Get
        Set(ByVal value As Integer)
            iNumeroRegistroInsTitulo = value
        End Set
    End Property
     
#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub UpdateRazaoSocial(ByVal sCNPJ As String)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_boleto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoBoleto : i += 1

            'Seta Parametros - Código Banco Conta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnpj"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCNPJ : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_importacao_boleto_razao_social", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadRazaoSocial(ByVal sCNPJ As String, _
                               ByRef sRazaoSocial As String)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try
            'Seta Parametros - Código Banco Conta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnpj"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCNPJ : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_parceiro_negocio_cnpj", oSqlParameter)

            If oSqlDataReader.Read Then

                sRazaoSocial = oSqlDataReader.Item("razao_social")

            End If

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosParceiro(ByRef lCodigoTituloCapa As Long, _
                                 ByRef lCodigoParceiroNegocio As Long, _
                                 ByRef sEmail As String)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try
            'Seta Parametros - Código Banco Conta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoTituloCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_parceiro_negocio_titulo", oSqlParameter)

            If oSqlDataReader.Read Then

                lCodigoParceiroNegocio = oSqlDataReader.Item("codigo_parceiro_negocio")
                sEmail = oSqlDataReader.Item("email")

            End If

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub SalvarBoleto()

        'Variaveis Locais
        Dim oSqlParameter(64) As SqlParameter
        Dim i As Integer

        Try
            'Seta Váriavel
            i = 0

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "registro_titulo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iRegistroTitulo : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "agencia_debito"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iAgenciaDebito : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "digito_agencia_debito"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDigitoAgenciaDebito : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "razao_conta_corrente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iRazaoContaCorrente : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "conta_corrente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iContaCorrente : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "digito_conta_corrente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDigitoContaCorrente : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "empresa_beneficiario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sEmpresaBeneficiario : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_controle_participante"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroControleParticipante : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(IsDBNull(sCodigoBanco), -1, sCodigoBanco) : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "multa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iMulta : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "percentual_multa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iPercentualMulta : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "titulo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lTitulo : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "digito_auto_conf_num_bancario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDigitoAutoConfNumBancario : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desconto_bonificacao_dia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDescontoBonificacaoDia : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cond_emissao_papeleta_cobranca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = iCondEmissaoPapeletaCobranca : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "boleto_debito_automatico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sBoletoDebitoAutomatico : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "operacao_banco"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sOperacaoBanco : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "rateio_credito"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sRateioCredito : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "end_aviso_deb_automatico_cc"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = iEndAvisoDebAutomaticoCC : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ocorrencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iOcorrencia : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroDoc : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento_titulo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = dtDataVencimentoTitulo : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_titulo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorTitulo : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "banco_encarregado_cobranca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iBancoEncarregadoCobranca : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "agencia_depositaria"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iAgenciaDepositaria : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "especie_titulo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iEspecieTitulo : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "identificacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sIdentificacao : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_titulo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = dtDataEmissaoTitulo : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "instrucao1"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iInstrucao1 : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "instrucao2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iInstrucao2 : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_atraso_dia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAtrasoDia : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_limite_concessao_desconto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = dtDataLimiteConDesconto : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_desconto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorDesconto : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_iof"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorIOF : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_abatimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAbatimento : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo_inscricao_pagador"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iTipoInscricaoPagador : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_inscricao_pagador"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroInscricaoPagador : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nome_pagador"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNomePagador : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "endereco_pagador"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sEnderecoPagador : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "mensagem1"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sMensagem1 : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cep"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCEP : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sufixo_cep"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iSufixoCEP : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "mensagem2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sMensagem2 : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_registro_titulo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iNumeroRegistroInsTitulo : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo_registro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iTipoRegistro : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "mensagem1_ins_titulo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sMensagem1InsTitulo : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "mensagem2_ins_titulo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sMensagem2InsTitulo : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "mensagem3"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sMensagem3 : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "mensagem4"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sMensagem4 : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_limite_desconto2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = dtDataLimiteDesconto2 : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_limite_desconto3"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = dtDataLimiteDesconto3 : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_desconto2"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(IsDBNull(dValorDesconto2), 0.0, dValorDesconto2) : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_desconto3"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(IsDBNull(dValorDesconto3), 0.0, dValorDesconto3) : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "reserva"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sReserva : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "carteira"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCarteira : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "agencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iAgencia : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "conta_corrente_ins_titulo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sContaCorrenteInsTitulo : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "digito_conta_corrente_ins_titulo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(IsDBNull(sDigitoContaCorrenteInsTitulo), -1, sDigitoContaCorrenteInsTitulo) : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_registro_ins_titulo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iNumeroRegistroInsTitulo : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "dac_nosso_numero"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDACNossoNumero : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nosso_numero"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNossoNumero : i += 1


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_integracao_importar_boleto_importacao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Salvar()

        'Variaveis Locaissp_insert_integracao_importar_boleto_titulo
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer

        Try

            'Seta Váriavel
            i = 0

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_integracao_importar_boleto_titulo", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Salvar_2()

        'Variaveis Locaissp_insert_integracao_importar_boleto_titulo
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer

        Try

            'Seta Váriavel
            i = 0

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_integracao_importar_boleto_titulo_2", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sNossoNumero As String, _
                        ByVal sNumeroDocumento As String, _
                        ByVal dValorTitulo As Double, _
                        ByVal dDataInicio As String, _
                        ByVal dDataTermino As String, _
                        ByVal sRazaoSocial As String, _
                        ByVal sCpfCnpj As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(7) As SqlParameter
        Dim i As Integer = 0
        Try
            'For Each oRow As GridEXRow In gSelecaoRow

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nosso_numero"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNossoNumero : i += 1

            'Seta Parametros - Data de Emissão - Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(dDataInicio = "", DBNull.Value, dDataInicio) : i += 1

            'Seta Parametros - Data de Emissão - Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(dDataTermino = "", DBNull.Value, dDataTermino) : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroDocumento : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_titulo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorTitulo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cpf_cnpj"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCpfCnpj : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "razao_social"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sRazaoSocial

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_integracao_importar_boleto_capa", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oDataSet.Tables(0).Columns("numero_documento"), oDataSet.Tables(1).Columns("numero_documento"))
            'Carrega Grid                
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName

            'Next
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex

        End Try

    End Sub

    Public Sub SalvarBoletoNF(ByVal sNotaFiscal As String, _
                              ByVal sNumeroDocumento As String, _
                              ByVal sNossoNumero As String)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer

        Try

            'Seta Váriavel
            i = 0

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(sNotaFiscal = "", DBNull.Value, sNotaFiscal) : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroDocumento : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nosso_numero"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNossoNumero



            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_integracao_importar_boleto_nota_fiscal", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridNF(ByVal oGrid As GridEX, _
                        ByVal sNossoNumero As String, _
                        ByVal sNumeroDocumento As String, _
                        ByVal dValorTitulo As Double, _
                        ByVal dDataInicio As String, _
                        ByVal dDataTermino As String, _
                        ByVal sRazaoSocial As String, _
                        ByVal sCpfCnpj As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(7) As SqlParameter
        Dim i As Integer = 0
        Try
            'For Each oRow As GridEXRow In gSelecaoRow

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nosso_numero"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNossoNumero : i += 1

            'Seta Parametros - Data de Emissão - Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(dDataInicio = "", DBNull.Value, dDataTermino) : i += 1

            'Seta Parametros - Data de Emissão - Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(dDataInicio = "", DBNull.Value, dDataTermino) : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroDocumento : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_titulo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorTitulo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cpf_cnpj"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCpfCnpj : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "razao_social"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sRazaoSocial

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_integracao_importar_boleto_capa", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName

            'Next
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex

        End Try

    End Sub

    Public Sub LoadGridBoleto(ByVal oGrid As Janus.Windows.GridEX.GridEX)

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



            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_integracao_importar_boleto", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oDataSet.Tables(0).Columns("nosso_numero"), oDataSet.Tables(1).Columns("nosso_numero"))
            'Carrega Grid                
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex

        End Try

    End Sub

    Public Function ValidaBoleto(ByVal sNossoNumero As String)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim iReturn As Integer
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Placa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nosso_numero"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = sNossoNumero

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_integracao_importacao_boleto", oSqlParameter), Integer)

            'Seta Retorno da Função
            Return (IIf(iReturn > 0, False, True))

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#Region "Salvar Boleto Antigo"

    'Public Sub SalvarBoletoAntigo(ByVal oGrid As GridEX)

    '    'Variaveis Locais
    '    Dim oSqlParameter(63) As SqlParameter
    '    Dim i As Integer

    '    Try
    '        For Each oRow As GridEXRow In oGrid.GetDataRows

    '            'Seta Váriavel
    '            i = 0

    '            'Seta Parametros - Código Empresa
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "codigo_empresa"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
    '            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "razao_social"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
    '            oSqlParameter(i).Value = oRow.Cells.Item("razao_social").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "registro_titulo"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.Int
    '            oSqlParameter(i).Value = oRow.Cells.Item("registro_titulo").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "agencia_debito"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.Int
    '            oSqlParameter(i).Value = oRow.Cells.Item("agencia_debito").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "digito_agencia_debito"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
    '            oSqlParameter(i).Value = oRow.Cells.Item("digito_agencia_debito").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "razao_conta_corrente"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.Int
    '            oSqlParameter(i).Value = oRow.Cells.Item("razao_conta_corrente").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "conta_corrente"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.Int
    '            oSqlParameter(i).Value = oRow.Cells.Item("conta_corrente").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "digito_conta_corrente"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
    '            oSqlParameter(i).Value = oRow.Cells.Item("digito_conta_corrente").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "empresa_beneficiario"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
    '            oSqlParameter(i).Value = oRow.Cells.Item("empresa_beneficiario").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "numero_controle_participante"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
    '            oSqlParameter(i).Value = oRow.Cells.Item("numero_controle_participante").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "codigo_banco"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
    '            oSqlParameter(i).Value = IIf(IsDBNull(oRow.Cells.Item("codigo_banco").Value), -1, oRow.Cells.Item("codigo_banco").Value) : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "multa"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.Int
    '            oSqlParameter(i).Value = oRow.Cells.Item("multa").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "percentual_multa"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.Int
    '            oSqlParameter(i).Value = oRow.Cells.Item("percentual_multa").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "titulo"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.Int
    '            oSqlParameter(i).Value = oRow.Cells.Item("titulo").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "digito_auto_conf_num_bancario"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
    '            oSqlParameter(i).Value = oRow.Cells.Item("digito_auto_conf_num_bancario").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "desconto_bonificacao_dia"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.Float
    '            oSqlParameter(i).Value = oRow.Cells.Item("desconto_bonificacao_dia").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "cond_emissao_papeleta_cobranca"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.Int
    '            oSqlParameter(i).Value = oRow.Cells.Item("cond_emissao_papeleta_cobranca").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "boleto_debito_automatico"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
    '            oSqlParameter(i).Value = oRow.Cells.Item("boleto_debito_automatico").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "operacao_banco"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
    '            oSqlParameter(i).Value = oRow.Cells.Item("operacao_banco").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "rateio_credito"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
    '            oSqlParameter(i).Value = oRow.Cells.Item("rateio_credito").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "end_aviso_deb_automatico_cc"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.Int
    '            oSqlParameter(i).Value = oRow.Cells.Item("end_aviso_deb_automatico_cc").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "ocorrencia"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.Int
    '            oSqlParameter(i).Value = oRow.Cells.Item("ocorrencia").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "numero_documento"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
    '            oSqlParameter(i).Value = oRow.Cells.Item("numero_documento").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "data_vencimento_titulo"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.Date
    '            oSqlParameter(i).Value = oRow.Cells.Item("data_vencimento_titulo").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "valor_titulo"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.Float
    '            oSqlParameter(i).Value = oRow.Cells.Item("valor_titulo").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "banco_encarregado_cobranca"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.Int
    '            oSqlParameter(i).Value = oRow.Cells.Item("banco_encarregado_cobranca").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "agencia_depositaria"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.Int
    '            oSqlParameter(i).Value = oRow.Cells.Item("agencia_depositaria").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "especie_titulo"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.Int
    '            oSqlParameter(i).Value = oRow.Cells.Item("especie_titulo").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "identificacao"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
    '            oSqlParameter(i).Value = oRow.Cells.Item("identificacao").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "data_emissao_titulo"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.Date
    '            oSqlParameter(i).Value = oRow.Cells.Item("data_emissao_titulo").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "instrucao1"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.Int
    '            oSqlParameter(i).Value = oRow.Cells.Item("instrucao1").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "instrucao2"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.Int
    '            oSqlParameter(i).Value = oRow.Cells.Item("instrucao2").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "valor_atraso_dia"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.Float
    '            oSqlParameter(i).Value = oRow.Cells.Item("valor_atraso_dia").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "data_limite_concessao_desconto"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.Date
    '            oSqlParameter(i).Value = oRow.Cells.Item("data_limite_concessao_desconto").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "valor_desconto"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.Float
    '            oSqlParameter(i).Value = oRow.Cells.Item("valor_desconto").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "valor_iof"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.Float
    '            oSqlParameter(i).Value = oRow.Cells.Item("valor_iof").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "valor_abatimento"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.Float
    '            oSqlParameter(i).Value = oRow.Cells.Item("valor_abatimento").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "tipo_inscricao_pagador"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.Int
    '            oSqlParameter(i).Value = oRow.Cells.Item("tipo_inscricao_pagador").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "numero_inscricao_pagador"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
    '            oSqlParameter(i).Value = oRow.Cells.Item("numero_inscricao_pagador").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "nome_pagador"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
    '            oSqlParameter(i).Value = oRow.Cells.Item("nome_pagador").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "endereco_pagador"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
    '            oSqlParameter(i).Value = oRow.Cells.Item("endereco_pagador").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "mensagem1"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
    '            oSqlParameter(i).Value = oRow.Cells.Item("mensagem1").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "cep"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.Int
    '            oSqlParameter(i).Value = oRow.Cells.Item("cep").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "sufixo_cep"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.Int
    '            oSqlParameter(i).Value = oRow.Cells.Item("sufixo_cep").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "mensagem2"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
    '            oSqlParameter(i).Value = oRow.Cells.Item("mensagem2").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "numero_registro_titulo"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.Int
    '            oSqlParameter(i).Value = oRow.Cells.Item("numero_registro_titulo").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "tipo_registro"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.Int
    '            oSqlParameter(i).Value = oRow.Cells.Item("tipo_registro").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "mensagem1_ins_titulo"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
    '            oSqlParameter(i).Value = oRow.Cells.Item("mensagem1_ins_titulo").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "mensagem2_ins_titulo"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
    '            oSqlParameter(i).Value = oRow.Cells.Item("mensagem2_ins_titulo").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "mensagem3"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
    '            oSqlParameter(i).Value = oRow.Cells.Item("mensagem3").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "mensagem4"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
    '            oSqlParameter(i).Value = oRow.Cells.Item("mensagem4").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "data_limite_desconto2"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.Date
    '            oSqlParameter(i).Value = oRow.Cells.Item("data_limite_desconto2").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "data_limite_desconto3"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.Date
    '            oSqlParameter(i).Value = oRow.Cells.Item("data_limite_desconto3").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "valor_desconto2"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.Float
    '            oSqlParameter(i).Value = IIf(IsDBNull(oRow.Cells.Item("valor_desconto2").Value), 0.0, oRow.Cells.Item("valor_desconto2").Value) : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "valor_desconto3"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.Float
    '            oSqlParameter(i).Value = IIf(IsDBNull(oRow.Cells.Item("valor_desconto3").Value), 0.0, oRow.Cells.Item("valor_desconto3").Value) : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "reserva"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
    '            oSqlParameter(i).Value = oRow.Cells.Item("reserva").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "carteira"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
    '            oSqlParameter(i).Value = oRow.Cells.Item("carteira").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "agencia"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.Int
    '            oSqlParameter(i).Value = oRow.Cells.Item("agencia").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "conta_corrente_ins_titulo"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
    '            oSqlParameter(i).Value = oRow.Cells.Item("conta_corrente_ins_titulo").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "digito_conta_corrente_ins_titulo"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
    '            oSqlParameter(i).Value = IIf(IsDBNull(oRow.Cells.Item("digito_conta_corrente_ins_titulo").Value), -1, oRow.Cells.Item("digito_conta_corrente_ins_titulo").Value) : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "numero_registro_ins_titulo"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.Int
    '            oSqlParameter(i).Value = oRow.Cells.Item("numero_registro_ins_titulo").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "nosso_numero"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
    '            oSqlParameter(i).Value = oRow.Cells.Item("nosso_numero").Value : i += 1

    '            
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "dac_nosso_numero"
    '            oSqlParameter(i).Direction = ParameterDirection.Input
    '            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
    '            oSqlParameter(i).Value = oRow.Cells.Item("dac_nosso_numero").Value : i += 1

    '            'Seta Parametros - Código Empresa
    '            oSqlParameter(i) = New SqlParameter
    '            oSqlParameter(i).ParameterName = "codigo"
    '            oSqlParameter(i).Direction = ParameterDirection.Output
    '            oSqlParameter(i).SqlDbType = SqlDbType.Int

    '            'Executa Query
    '            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_integracao_importar_boleto_importacao", oSqlParameter)

    '            If oSqlParameter(i).Value Then
    '                iCodigo = oSqlParameter(i).Value
    '            End If


    '        Next

    '    Catch SqlEx As SqlException
    '        Throw SqlEx
    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    'End Sub

#End Region

    Public Sub DeleteBoleto()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "nosso_numero"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oRow.Cells("nosso_numero").Value : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero_documento"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oRow.Cells("numero_documento").Value : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_integracao_importacao_boleto", oSqlParameter)

                'Deleta Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
