Imports System.IO
Imports System.Xml
Imports INTERACTI.NFe
Imports INTERACTI.NFe.ConsultaNFDest
Imports INTERACTI.NFe.RetConsultaNFDest
Imports INTERACTI.NFe.ValidaXML
Imports INTERACTI.NFe.WebService_V2

Public Class clsNFeConsultaNFDestinada

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sPathArquivoEnvio As String
    Private sPathArquivoRetorno As String
    Private sArquivoXML As String
    'Variaveis da Classe - ReadOnly
    Private sMensagemErro As String


    Private sUltimoNSU As String
    Private sNSU As String
    Private sChaveAcesso As String
    Private sCNPJ As String
    Private sIE As String
    Private dDataEmissao As Date
    Private iCodigoTipoNotaFiscal As Integer
    Private dValor As Double
    Private iCodigoSituacaoNFe As Integer
    Private iCodigoSituacaoManifestacao As Integer
    Private indContField As Integer
#End Region

#Region "::: PROPERTIE :::"

    Public ReadOnly Property indCont() As Integer
        Get
            Return indContField
        End Get
    End Property

    Public Property UltimoNSU() As String
        Get
            Return sUltimoNSU
        End Get
        Set(ByVal value As String)
            sUltimoNSU = value
        End Set
    End Property

    Public ReadOnly Property NSU() As String
        Get
            Return sNSU
        End Get
    End Property

    Public ReadOnly Property ChaveAcesso() As String
        Get
            Return sChaveAcesso
        End Get
    End Property

    Public ReadOnly Property CNPJ() As String
        Get
            Return sCNPJ
        End Get
    End Property

    Public ReadOnly Property IE() As String
        Get
            Return sIE
        End Get
    End Property

    Public ReadOnly Property DataEmissao() As Date
        Get
            Return dDataEmissao
        End Get
    End Property

    Public ReadOnly Property CodigoTipoNotaFiscal() As Integer
        Get
            Return iCodigoTipoNotaFiscal
        End Get
    End Property

    Public ReadOnly Property Valor() As Double
        Get
            Return dValor
        End Get
    End Property

    Public ReadOnly Property CodigoSituacaoNFe() As Integer
        Get
            Return iCodigoSituacaoNFe
        End Get
    End Property

    Public ReadOnly Property CodigoSituacaoManifestacao() As Integer
        Get
            Return iCodigoSituacaoManifestacao
        End Get
    End Property

    Public ReadOnly Property PathArquivoEnvio() As String
        Get
            Return sPathArquivoEnvio
        End Get
    End Property

    Public ReadOnly Property PathArquivoRetorno() As String
        Get
            Return sPathArquivoRetorno
        End Get
    End Property

    Public ReadOnly Property ArquivoXML() As String
        Get
            Return sArquivoXML
        End Get
    End Property

    Public ReadOnly Property MensagemErro() As String
        Get
            Return sMensagemErro
        End Get
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Function Send(ByVal sUltimoNSU As String) As Boolean

        'Váriaveis Locais
        Dim sRetornoWS As String
        Dim oTConsSitNFe As New TConsNFeDest

        Try

            'Parâmetros
            oTConsSitNFe.versao = ConsultaNFDest.TVeConsNFeDest.Item101
            oTConsSitNFe.tpAmb = ConsultaNFDest.TAmb.Item1
            oTConsSitNFe.CNPJ = Replace(Replace(Replace(goEmitente.sCNPJ, ".", ""), "/", ""), "-", "")
            oTConsSitNFe.xServ = TConsNFeDestXServ.CONSULTARNFEDEST
            oTConsSitNFe.indNFe = TConsNFeDestIndNFe.Item2
            oTConsSitNFe.indEmi = TConsNFeDestIndEmi.Item1  'todos que o CNPJ é diferente do destinatário / emitente

            'Recebendo o último NSU criado
            oTConsSitNFe.ultNSU = sUltimoNSU

            'Seta Arquivo
            sPathArquivoEnvio = goConfiguracaoNFe.sPastaEnvio & Format(Now, "yyyy_mm_dd") & "-ped-consulta-nf-destinada.xml"

            'Salva Pedido de Status do Serviço Temporariamente
            oTConsSitNFe.Save(sPathArquivoEnvio)

            'Valida Arquivo XML Assinado
            Dim sRetornoValidacao As String = ""

            'Verifica se Encontrou algum Erro no Arquivo XML
            sRetornoValidacao = ValidaArquivoXML(sPathArquivoEnvio, _
                                                 goConfiguracaoNFe.sPastaXSD & "consNFeDest_v1.01.xsd")

            'Verifica se ocorreu algum erro na Validação
            If sRetornoValidacao <> "" Then

                'Exclui Arquivo XML (Status)
                File.Delete(sPathArquivoEnvio)

                'Seta Informação
                sMensagemErro = "O Arquivo XML apresentou os seguintes erros:" & vbCrLf & sRetornoValidacao
                'Retorno da Função
                Return False

            Else

                Try

                    'Executa Serviço (SÍNCRONO)
                    sRetornoWS = WSConsultaNFDestinada(sPathArquivoEnvio)

                    'Setando o retorno da função
                    sArquivoXML = sRetornoWS
                Catch ex As Exception
                    'Exclui Arquivo XML (Pedido de Cancelamento e Cabeçalho)
                    File.Delete(sPathArquivoEnvio)
                    'Seta Informação
                    sMensagemErro = ex.Message
                    'Retorno da Função
                    Return False
                End Try

                'Seta Arquivo de Retorno
                sPathArquivoRetorno = goConfiguracaoNFe.sPastaRecibo & sChaveAcesso & "-ret-ped-consulta-nf-destinada.xml"

                'Recebe Arquivo de Retorno do WebService
                Dim oStreamWriter As StreamWriter = File.CreateText(sPathArquivoRetorno)
                oStreamWriter.Write(sRetornoWS)
                oStreamWriter.Close()

            End If

            'Seta Retorno da Função
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function LoadArquivo() As Boolean

        'Váriaveis Locais
        Dim oTRetConsultaNFDest As New TRetConsNFeDest
        'Instanciando a classe para inserir no banco de dados
        Dim oClsFatEntradaNFeDestinada As New clsUsrFatEntradaNFeDestinada

        Try

            'Carrega arquivo de Retorno
            oTRetConsultaNFDest = TRetConsNFeDest.Load(sPathArquivoRetorno)

            'Setando os filtros
            sUltimoNSU = oTRetConsultaNFDest.ultNSU
            indContField = oTRetConsultaNFDest.indCont

            'Zerando a variável
            sMensagemErro = ""

            If oTRetConsultaNFDest.cStat = "137" Then 'Nenhum documento encontrado
                oTRetConsultaNFDest = Nothing
                Return False
            End If

            'Retorna o erro 
            If oTRetConsultaNFDest.cStat <> "138" Then 'No caso de alguma rejeição
                sMensagemErro = oTRetConsultaNFDest.xMotivo
                Return False
            End If

            'Verifica se retornou algum registro
            If oTRetConsultaNFDest.ret.Count > 0 Then

                'Percorrendo todos os itens que retornaram
                For Each oRet In oTRetConsultaNFDest.ret

                    'Verificnado se é uma NF-e AUTORIZADA
                    If Not oRet.ResNFe Is Nothing Then

                        'Setando os valores para retorno de NF-e autorizada
                        With oRet.resNFe

                            'Inserindo os dados
                            oClsFatEntradaNFeDestinada.InsertNFeAutorizada(.NSU, _
                                                                           .chNFe, _
                                                                           .Item, _
                                                                           .xNome, _
                                                                           .IE, _
                                                                           .dEmi, _
                                                                           .tpNF, _
                                                                           .vNF / 100.0, _
                                                                           .cSitNFe, _
                                                                           .cSitConf, _
                                                                           .dhRecbto)

                        End With

                    End If


                    'Verificnado se é uma NF-e CANCELADA
                    If Not oRet.resCanc Is Nothing Then

                        'Setando os dados de retorno da NF-e cancelada
                        With oRet.resCanc

                            'Inserindo os dados
                            oClsFatEntradaNFeDestinada.InsertNFeCancelada(.NSU, _
                                                                          .chNFe, _
                                                                          .Item, _
                                                                          .xNome, _
                                                                          .IE, _
                                                                          .dEmi, _
                                                                          .tpNF, _
                                                                          .vNF / 100.0, _
                                                                          .cSitNFe, _
                                                                          .cSitConf, _
                                                                          .dhRecbto)

                        End With

                    End If

                    'Verificnado se é uma CC-e
                    If Not oRet.resCCe Is Nothing Then

                        'Setando os dados de retorno da CC-e
                        With oRet.resCCe

                            'Inserindo os dados
                            oClsFatEntradaNFeDestinada.InsertNFeCCe(.NSU, _
                                                                    .chNFe, _
                                                                    .dhEvento, _
                                                                    .tpEvento, _
                                                                    .descEvento, _
                                                                    .nSeqEvento, _
                                                                    .xCorrecao, _
                                                                    .tpNF, _
                                                                    .dhRecbto)

                        End With

                    End If

                Next

                Return True
            Else

                'Retornar o último NSU usado para a consulta
                sUltimoNSU = oTRetConsultaNFDest.ultNSU

                oTRetConsultaNFDest = Nothing

                'Retorno que não encontrou registros
                Return False
            End If

            'Limpa Váriaveis
            oTRetConsultaNFDest = Nothing

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class
