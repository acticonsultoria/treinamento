Imports System.IO
Imports System.Xml
Imports INTERACTI.NFe
Imports INTERACTI.NFe.ConsultaDFe_V2
Imports INTERACTI.NFe.RetConsultaDFe_v2
Imports INTERACTI.NFe.ValidaXML
Imports INTERACTI.NFe.WebService_V4
Imports System.IO.Compression
Public Class clsNFeConsultaDFe_V4

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

    Public Function SendNSU_CTE(ByVal sNSU As String, _
                            ByRef sXMLRetorno As String) As Boolean

        'Váriaveis Locais
        Dim sRetornoWS As String
        Dim oTConsSitNFe As New ConsultaDFe_CTE.distDFeInt

        Try


            'Parâmetros0
            oTConsSitNFe.versao = ConsultaDFe_CTE.TVerDistDFe.Item100
            oTConsSitNFe.tpAmb = ConsultaDFe_CTE.TAmb.Item1
            oTConsSitNFe.ItemElementName = ItemChoiceType.CNPJ
            oTConsSitNFe.Item = Replace(Replace(Replace(goEmitente.sCNPJ, ".", ""), "/", ""), "-", "")

            oTConsSitNFe.cUFAutor = TCodUfIBGE.Item35

            'Recebendo o último NSU criado
            Dim oDistDFeIntConsNSU = New ConsultaDFe_CTE.distDFeIntConsNSU
            oDistDFeIntConsNSU.NSU = sNSU
            oTConsSitNFe.Item1 = oDistDFeIntConsNSU


            'Seta Arquivo
            sPathArquivoEnvio = goConfiguracaoNFe.sPastaEnvio & Format(Now, "yyyy_mm_dd") & "-ped-consulta-nf-destinada.xml"

            'Salva Pedido de Status do Serviço Temporariamente
            oTConsSitNFe.Save(sPathArquivoEnvio)

            'Valida Arquivo XML Assinado
            Dim sRetornoValidacao As String = ""

            'Verifica se Encontrou algum Erro no Arquivo XML
            sRetornoValidacao = ValidaArquivoXMLCTE(sPathArquivoEnvio, _
                                                 goConfiguracaoNFe.sPastaXSD & "distDFeInt_v1.00.xsd")


            sRetornoValidacao = ""

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
                    sRetornoWS = WSConsultaDFe_CTE(sPathArquivoEnvio)

                    'Setando o retorno da função
                    sxmlretorno = sRetornoWS


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

    'Public Function SendNSU(ByVal sNSU As String, _
    '                        ByRef sXMLRetorno As String) As Boolean

    '    'Váriaveis Locais
    '    Dim sRetornoWS As String
    '    Dim oTConsSitNFe As New distDFeInt

    '    Try


    '        'Parâmetros0
    '        oTConsSitNFe.versao = NFe.ConsultaDFe_V2.TVerDistDFe.Item101
    '        oTConsSitNFe.tpAmb = NFe.ConsultaDFe_V2.TAmb.Item1
    '        oTConsSitNFe.ItemElementName = ItemChoiceType.CNPJ
    '        oTConsSitNFe.Item = Replace(Replace(Replace(goEmitente.sCNPJ, ".", ""), "/", ""), "-", "")

    '        oTConsSitNFe.cUFAutor = TCodUfIBGE.Item51

    '        'Recebendo o último NSU criado
    '        Dim oDistDFeIntConsNSU = New distDFeIntConsNSU
    '        oDistDFeIntConsNSU.NSU = sNSU
    '        oTConsSitNFe.Item1 = oDistDFeIntConsNSU


    '        'Seta Arquivo
    '        sPathArquivoEnvio = goConfiguracaoNFe.sPastaEnvio & Format(Now, "yyyy_mm_dd") & "-ped-consulta-nf-destinada.xml"

    '        'Salva Pedido de Status do Serviço Temporariamente
    '        oTConsSitNFe.Save(sPathArquivoEnvio)

    '        'Valida Arquivo XML Assinado
    '        Dim sRetornoValidacao As String = ""

    '        'Verifica se Encontrou algum Erro no Arquivo XML
    '        sRetornoValidacao = ValidaArquivoXML(sPathArquivoEnvio, _
    '                                             goConfiguracaoNFe.sPastaXSD & "distDFeInt_v1.01.xsd")

    '        'Verifica se ocorreu algum erro na Validação
    '        If sRetornoValidacao <> "" Then

    '            'Exclui Arquivo XML (Status)
    '            File.Delete(sPathArquivoEnvio)

    '            'Seta Informação
    '            sMensagemErro = "O Arquivo XML apresentou os seguintes erros:" & vbCrLf & sRetornoValidacao
    '            'Retorno da Função
    '            Return False

    '        Else

    '            Try

    '                'Executa Serviço (SÍNCRONO)
    '                sRetornoWS = WSConsultaDFe(sPathArquivoEnvio)

    '                'Setando o retorno da função
    '                sXMLRetorno = sRetornoWS


    '            Catch ex As Exception
    '                'Exclui Arquivo XML (Pedido de Cancelamento e Cabeçalho)
    '                File.Delete(sPathArquivoEnvio)
    '                'Seta Informação
    '                sMensagemErro = ex.Message
    '                'Retorno da Função
    '                Return False
    '            End Try

    '            'Seta Arquivo de Retorno
    '            sPathArquivoRetorno = goConfiguracaoNFe.sPastaRecibo & sChaveAcesso & "-ret-ped-consulta-nf-destinada.xml"

    '            'Recebe Arquivo de Retorno do WebService
    '            Dim oStreamWriter As StreamWriter = File.CreateText(sPathArquivoRetorno)
    '            oStreamWriter.Write(sRetornoWS)
    '            oStreamWriter.Close()

    '        End If

    '        'Seta Retorno da Função
    '        Return True

    '    Catch ex As Exception
    '        Return False
    '    End Try

    'End Function
    Public Function SendChaveAcesso(ByVal sChaveAcesso As String, _
                            ByRef sXMLRetorno As String) As Boolean

        'Váriaveis Locais
        Dim sRetornoWS As String
        Dim oTConsSitNFe As New distDFeInt

        Try


            'Parâmetros0
            oTConsSitNFe.versao = NFe.ConsultaDFe_V2.TVerDistDFe.Item101
            oTConsSitNFe.tpAmb = NFe.ConsultaDFe_V2.TAmb.Item1
            oTConsSitNFe.ItemElementName = ItemChoiceType.CNPJ
            oTConsSitNFe.Item = Replace(Replace(Replace(goEmitente.sCNPJ, ".", ""), "/", ""), "-", "")

            oTConsSitNFe.cUFAutor = TCodUfIBGE.Item51

            'Recebendo o último NSU criado
            Dim odistDFeIntConsChNFe = New distDFeIntConsChNFe
            odistDFeIntConsChNFe.chNFe = sChaveAcesso
            oTConsSitNFe.Item1 = odistDFeIntConsChNFe


            'Seta Arquivo
            sPathArquivoEnvio = goConfiguracaoNFe.sPastaEnvio & Format(Now, "yyyy_mm_dd") & "-ped-consulta-nf-destinada.xml"

            'Salva Pedido de Status do Serviço Temporariamente
            oTConsSitNFe.Save(sPathArquivoEnvio)

            'Valida Arquivo XML Assinado
            Dim sRetornoValidacao As String = ""

            'Verifica se Encontrou algum Erro no Arquivo XML
            sRetornoValidacao = ValidaArquivoXML(sPathArquivoEnvio, _
                                                 goConfiguracaoNFe.sPastaXSD & "distDFeInt_v1.01.xsd")

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
                    sRetornoWS = WSConsultaDFe(sPathArquivoEnvio)

                    'Setando o retorno da função
                    sXMLRetorno = sRetornoWS


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

    Public Function Send(ByVal sUltimoNSU As String) As Boolean

        'Váriaveis Locais
        Dim sRetornoWS As String
        Dim oTConsSitNFe As New distDFeInt

        Try


            'Parâmetros0
            oTConsSitNFe.versao = NFe.ConsultaDFe_V2.TVerDistDFe.Item101
            oTConsSitNFe.tpAmb = NFe.ConsultaDFe_V2.TAmb.Item1
            oTConsSitNFe.ItemElementName = ItemChoiceType.CNPJ
            oTConsSitNFe.Item = Replace(Replace(Replace(goEmitente.sCNPJ, ".", ""), "/", ""), "-", "")

            oTConsSitNFe.cUFAutor = TCodUfIBGE.Item51

            'Recebendo o último NSU criado
            Dim oDistDFeIntDistNSU = New distDFeIntDistNSU
            oDistDFeIntDistNSU.ultNSU = sUltimoNSU
            oTConsSitNFe.Item1 = oDistDFeIntDistNSU


            'Seta Arquivo
            sPathArquivoEnvio = goConfiguracaoNFe.sPastaEnvio & Format(Now, "yyyy_mm_dd") & "-ped-consulta-nf-destinada.xml"

            'Salva Pedido de Status do Serviço Temporariamente
            oTConsSitNFe.Save(sPathArquivoEnvio)

            'Valida Arquivo XML Assinado
            Dim sRetornoValidacao As String = ""

            'Verifica se Encontrou algum Erro no Arquivo XML
            sRetornoValidacao = ValidaArquivoXML(sPathArquivoEnvio, _
                                                 goConfiguracaoNFe.sPastaXSD & "distDFeInt_v1.01.xsd")

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
                    sRetornoWS = WSConsultaDFe(sPathArquivoEnvio)

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

                'Grava um log informando que o usuário fez essa consulta
                LogConsultaNFeDestinada()

            End If

            'Seta Retorno da Função
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function SendCTE(ByVal sUltimoNSU As String) As Boolean

        'Váriaveis Locais
        Dim sRetornoWS As String
        Dim oTConsSitNFe As New NFe.ConsultaDFe_CTE.distDFeInt

        Try


            'Parâmetros0
            oTConsSitNFe.versao = NFe.ConsultaDFe_CTE.TVerDistDFe.Item100
            oTConsSitNFe.tpAmb = NFe.ConsultaDFe_CTE.TAmb.Item1
            oTConsSitNFe.ItemElementName = ItemChoiceType.CNPJ
            oTConsSitNFe.Item = Replace(Replace(Replace(goEmitente.sCNPJ, ".", ""), "/", ""), "-", "")

            oTConsSitNFe.cUFAutor = TCodUfIBGE.Item51

            'Recebendo o último NSU criado
            Dim oDistDFeIntDistNSU = New NFe.ConsultaDFe_CTE.distDFeIntDistNSU
            oDistDFeIntDistNSU.ultNSU = sUltimoNSU
            oTConsSitNFe.Item1 = oDistDFeIntDistNSU


            'Seta Arquivo
            sPathArquivoEnvio = goConfiguracaoNFe.sPastaEnvio & Format(Now, "yyyy_mm_dd") & "-ped-consulta-nf-destinada.xml"

            'Salva Pedido de Status do Serviço Temporariamente
            oTConsSitNFe.Save(sPathArquivoEnvio)

            'Valida Arquivo XML Assinado
            Dim sRetornoValidacao As String = ""

            'Verifica se Encontrou algum Erro no Arquivo XML
            sRetornoValidacao = ValidaArquivoXMLCTE(sPathArquivoEnvio, _
                                                 goConfiguracaoNFe.sPastaXSD & "distDFeInt_v1.00.xsd")


            sRetornoValidacao = ""

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
                    sRetornoWS = WSConsultaDFe_CTE(sPathArquivoEnvio)

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

    Public Function LoadArquivoCTE(ByVal sNSUInicial As String) As Boolean

        'Váriaveis Locais
        Dim oTRetConsultaNFDest As New NFe.RetConsultaDFe_CTE.retDistDFeInt
        'Instanciando a classe para inserir no banco de dados
        'Dim oClsUsrIntNFeDestinada As New clsUsrFatEntradaNFeDestinada
        Try

            'Carrega arquivo de Retorno
            oTRetConsultaNFDest = NFe.RetConsultaDFe_CTE.retDistDFeInt.Load(sPathArquivoRetorno)

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

            Dim bFlag = False
            Dim sUltimoNSU As String = oTRetConsultaNFDest.ultNSU
            'percorre os retornos
            For iZip As Integer = 0 To oTRetConsultaNFDest.loteDistDFeInt.docZip.Count - 1


                Dim oClsUsrIntNFeDestinada As New clsUsrFatEntradaNFeDestinada
                'Recebe o NSU
                Dim sNSU As String = oTRetConsultaNFDest.loteDistDFeInt.docZip(iZip).NSU


                'Recebe o vetor dos bytes compactados
                Dim oByteCompactado() As Byte = oTRetConsultaNFDest.loteDistDFeInt.docZip(iZip).Value

                'Descompacta o byte
                Dim oByteDescompactado() As Byte = Decompress(oByteCompactado)

                'Seta Arquivo de Retorno
                sPathArquivoRetorno = goConfiguracaoNFe.sPastaRecibo & sNSU & "-ret-ped-consulta-nf-destinada.xml"

                'Cria a string a partir dos bytes
                Dim oEnc As New System.Text.ASCIIEncoding
                Dim sXML As String = oEnc.GetString(oByteDescompactado)

                'Escreve no arquivo
                Dim oStreamWriter As New StreamWriter(sPathArquivoRetorno, False, System.Text.Encoding.Default)
                oStreamWriter.WriteLine(sXML)
                oStreamWriter.Close()


                'Retorno de NF-e
                If oTRetConsultaNFDest.loteDistDFeInt.docZip(iZip).schema.ToUpper.Contains("PROCCTE") Then

                    Dim oXMLDocument As New XmlDocument
                    oXMLDocument.Load(sPathArquivoRetorno)

                    Dim sCNPJ As String = goEmitente.sCNPJ.Replace(".", "").Replace("-", "").Replace("/", "")

                    If (oXMLDocument.InnerXml.Contains("<toma>0</toma>") And oXMLDocument.InnerXml.Contains("<rem><CNPJ>" + sCNPJ + "</CNPJ>")) Or
                           (oXMLDocument.InnerXml.Contains("<toma>1</toma>") And oXMLDocument.InnerXml.Contains("<exped><CNPJ>" + sCNPJ + "</CNPJ>")) Or
                           (oXMLDocument.InnerXml.Contains("<toma>2</toma>") And oXMLDocument.InnerXml.Contains("<receb><CNPJ>" + sCNPJ + "</CNPJ>")) Or
                           (oXMLDocument.InnerXml.Contains("<toma>3</toma>") And oXMLDocument.InnerXml.Contains("<dest><CNPJ>" + sCNPJ + "</CNPJ>")) Then

                        If oXMLDocument.GetElementsByTagName("CNPJ")(0).InnerText <> goEmitente.sCNPJ.Replace("/", "").Replace("-", "").Replace(".", "") Then


                            oClsUsrIntNFeDestinada.InsertNFeAutorizada(sNSU, _
                                               oXMLDocument.GetElementsByTagName("chCTe")(oXMLDocument.GetElementsByTagName("chCTe").Count - 1).InnerText, _
                                               oXMLDocument.GetElementsByTagName("CNPJ")(0).InnerText, _
                                               oXMLDocument.GetElementsByTagName("xNome")(0).InnerText, _
                                               "", _
                                               oXMLDocument.GetElementsByTagName("dhEmi")(0).InnerText, _
                                               TipoDocumentoFiscal.Saida, _
                                               oXMLDocument.GetElementsByTagName("vRec")(0).InnerText / 100.0, _
                                               -1, _
                                               -1, _
                                                oXMLDocument.GetElementsByTagName("dhRecbto")(0).InnerText, _
                                                TipoNotaFiscal.CTRC)

                        End If

                    End If

                Else 'Se houver outro layout no futuro
                    Dim a As Integer = 0

                End If
            Next
            'Recebe os dados
            Dim sUltimoNSUcte As String = oTRetConsultaNFDest.ultNSU

            'Atualiza a configuração
            Call UpdateConfiguracaoNSUCTE(sNSUInicial, _
                                       sUltimoNSUcte, _
                                       "OK")


            'Limpa Váriaveis
            oTRetConsultaNFDest = Nothing

        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function LoadArquivo(ByVal sNSUInicial As String) As Boolean

        'Váriaveis Locais
        Dim oTRetConsultaNFDest As New retDistDFeInt
      
        Try
            'Verifica se é consumo indevido
            Dim oXMLDocument2 As New XmlDocument
            oXMLDocument2.Load(sPathArquivoRetorno)

            If oXMLDocument2.InnerXml.Contains("<cStat>656</cStat>") Then

                sMensagemErro = "656 - Consumo Indevido"

                'Atualiza a configuração
                Call UpdateConfiguracaoNSU(sNSUInicial, _
                                           "", _
                                           "CONSUMO INDEVIDO")

                Return False
            End If


            'Carrega arquivo de Retorno
            oTRetConsultaNFDest = retDistDFeInt.Load(sPathArquivoRetorno)

            'Zerando a variável
            sMensagemErro = ""

            If oTRetConsultaNFDest.cStat = "137" Then 'Nenhum documento encontrado

                'Atualiza a configuração
                Call UpdateConfiguracaoNSU(sNSUInicial, _
                                           "", _
                                           "SEM DOCUMENTO")
                oTRetConsultaNFDest = Nothing
                Return False
            End If

            'Retorna o erro 
            If oTRetConsultaNFDest.cStat <> "138" Then 'No caso de alguma rejeição
                sMensagemErro = oTRetConsultaNFDest.xMotivo
                Return False
            End If

            Dim bFlag = False

            'percorre os retornos
            For iZip As Integer = 0 To oTRetConsultaNFDest.loteDistDFeInt.docZip.Count - 1


                Dim oClsUsrIntNFeDestinada As New clsUsrFatEntradaNFeDestinada
                'Recebe o NSU
                Dim sNSU As String = oTRetConsultaNFDest.loteDistDFeInt.docZip(iZip).NSU


                'Recebe o vetor dos bytes compactados
                Dim oByteCompactado() As Byte = oTRetConsultaNFDest.loteDistDFeInt.docZip(iZip).Value

                'Descompacta o byte
                Dim oByteDescompactado() As Byte = Decompress(oByteCompactado)

                'Seta Arquivo de Retorno
                sPathArquivoRetorno = goConfiguracaoNFe.sPastaRecibo & sNSU & "-ret-ped-consulta-nf-destinada.xml"

                'Cria a string a partir dos bytes
                Dim oEnc As New System.Text.ASCIIEncoding
                Dim sXML As String = oEnc.GetString(oByteDescompactado)

                'Escreve no arquivo
                Dim oStreamWriter As New StreamWriter(sPathArquivoRetorno, False, System.Text.Encoding.Default)
                oStreamWriter.WriteLine(sXML)
                oStreamWriter.Close()


                'Retorno de NF-e
                If oTRetConsultaNFDest.loteDistDFeInt.docZip(iZip).schema = "resNFe_v1.00.xsd" Or oTRetConsultaNFDest.loteDistDFeInt.docZip(iZip).schema = "resNFe_v1.01.xsd" Then
                    bFlag = True

                    Dim oXMLDocument As New XmlDocument
                    oXMLDocument.Load(sPathArquivoRetorno)


                    'Inserindo os dados de autorização
                    oClsUsrIntNFeDestinada.InsertNFeAutorizada(sNSU, _
                                    oXMLDocument.GetElementsByTagName("chNFe")(0).InnerText, _
                                    oXMLDocument.GetElementsByTagName("CNPJ")(0).InnerText, _
                                    oXMLDocument.GetElementsByTagName("xNome")(0).InnerText, _
                                    sIE, _
                                    oXMLDocument.GetElementsByTagName("dhEmi")(0).InnerText, _
                                    oXMLDocument.GetElementsByTagName("tpNF")(0).InnerText, _
                                    oXMLDocument.GetElementsByTagName("vNF")(0).InnerText / 100.0, _
                                    -1, _
                                    -1, _
                                    oXMLDocument.GetElementsByTagName("dhRecbto")(0).InnerText)

                    'Retorno do evento
                ElseIf oTRetConsultaNFDest.loteDistDFeInt.docZip(iZip).schema = "procEventoNFe_v1.00.xsd" Then

                    'Instancia o objeto
                    Dim oRetEvento As New NFe.RetEventoCancelamento.TRetEvento

                    Dim oXMLDocument As New XmlDocument
                    oXMLDocument.Load(sPathArquivoRetorno)


                    If oXMLDocument.GetElementsByTagName("CNPJ")(0).InnerText <> goEmitente.sCNPJ.Replace("/", "").Replace("-", "").Replace(".", "") Then


                        If oXMLDocument.GetElementsByTagName("tpEvento")(0).InnerText <> "210200" And _
                            oXMLDocument.GetElementsByTagName("tpEvento")(0).InnerText <> "210210" Then 'Desconsiderar eventos

                            If oXMLDocument.GetElementsByTagName("tpEvento")(0).InnerText = "110111" Then 'Somente cancelamento

                                oClsUsrIntNFeDestinada.InsertNFeCancelada(sNSU, _
                                                   oXMLDocument.GetElementsByTagName("chNFe")(0).InnerText, _
                                                   oXMLDocument.GetElementsByTagName("CNPJ")(0).InnerText, _
                                                   "", _
                                                   "", _
                                                   oXMLDocument.GetElementsByTagName("dhEvento")(0).InnerText, _
                                                   TipoDocumentoFiscal.Saida, _
                                                    0, _
                                                   -1, _
                                                   -1, _
                                                    oXMLDocument.GetElementsByTagName("dhRegEvento")(0).InnerText)


                            ElseIf oXMLDocument.GetElementsByTagName("tpEvento")(0).InnerText = "110110" Then 'CC-e

                                oClsUsrIntNFeDestinada.InsertNFeCCe(sNSU, _
                                                oXMLDocument.GetElementsByTagName("chNFe")(0).InnerText, _
                                                    oXMLDocument.GetElementsByTagName("dhEvento")(0).InnerText, _
                                                   oXMLDocument.GetElementsByTagName("tpEvento")(0).InnerText, _
                                                   oXMLDocument.GetElementsByTagName("descEvento")(0).InnerText, _
                                                oXMLDocument.GetElementsByTagName("nSeqEvento")(0).InnerText, _
                                                   oXMLDocument.GetElementsByTagName("xCorrecao")(0).InnerText, _
                                                   1, _
                                                  oXMLDocument.GetElementsByTagName("dhRegEvento")(0).InnerText)

                            End If

                        End If


                    End If


                    'Retorno do CTE
                ElseIf oTRetConsultaNFDest.loteDistDFeInt.docZip(iZip).schema.ToUpper.Contains("CTE") Then

                    Dim oXMLDocument As New XmlDocument
                    oXMLDocument.Load(sPathArquivoRetorno)


                    If oXMLDocument.GetElementsByTagName("CNPJ")(0).InnerText <> goEmitente.sCNPJ.Replace("/", "").Replace("-", "").Replace(".", "") Then


                        oClsUsrIntNFeDestinada.InsertNFeAutorizada(sNSU, _
                                           oXMLDocument.GetElementsByTagName("chNFe")(0).InnerText, _
                                           oXMLDocument.GetElementsByTagName("CNPJ")(0).InnerText, _
                                           "", _
                                           "", _
                                           oXMLDocument.GetElementsByTagName("dhEvento")(0).InnerText, _
                                           TipoDocumentoFiscal.Saida, _
                                            0, _
                                           -1, _
                                           -1, _
                                            oXMLDocument.GetElementsByTagName("dhRegEvento")(0).InnerText, _
                                            TipoNotaFiscal.CTRC)





                    End If




                ElseIf oTRetConsultaNFDest.loteDistDFeInt.docZip(iZip).schema = "procNFe_v3.10.xsd" Or oTRetConsultaNFDest.loteDistDFeInt.docZip(iZip).schema = "procNFe_v4.00.xsd" Then 'Traz a nota inteira

                    Dim oXMLDocument As New XmlDocument
                    oXMLDocument.Load(sPathArquivoRetorno)




                    If oXMLDocument.GetElementsByTagName("CNPJ")(0).InnerText <> goEmitente.sCNPJ.Replace("/", "").Replace("-", "").Replace(".", "") Then 'Desconsiderar notas emitidas
                        bFlag = True
                        Dim sIE As String = ""
                        Try
                            sIE = oXMLDocument.GetElementsByTagName("IE")(0).InnerText
                        Catch ex As Exception

                        End Try
                        'Inserindo os dados de autorização
                        oClsUsrIntNFeDestinada.InsertNFeAutorizada(sNSU, _
                                        oXMLDocument.GetElementsByTagName("chNFe")(0).InnerText, _
                                        oXMLDocument.GetElementsByTagName("CNPJ")(0).InnerText, _
                                        oXMLDocument.GetElementsByTagName("xNome")(0).InnerText, _
                                        sIE, _
                                        oXMLDocument.GetElementsByTagName("dhEmi")(0).InnerText, _
                                        oXMLDocument.GetElementsByTagName("tpNF")(0).InnerText, _
                                        oXMLDocument.GetElementsByTagName("vNF")(0).InnerText / 100.0, _
                                        -1, _
                                        -1, _
                                        oXMLDocument.GetElementsByTagName("dhRecbto")(0).InnerText)
                    End If


                ElseIf oTRetConsultaNFDest.loteDistDFeInt.docZip(iZip).schema = "resEvento_v1.00.xsd" Then 'CT-e / MDF-e
                    Dim a As Integer = 0

                Else 'Se houver outro layout no futuro
                    Dim a As Integer = 0

                End If
            Next


            'Recebe os dados
            Dim sUltimoNSU As String = oTRetConsultaNFDest.ultNSU

            'Atualiza a configuração
            Call UpdateConfiguracaoNSU(sNSUInicial, _
                                       sUltimoNSU, _
                                       "OK")



            'Limpa Váriaveis
            oTRetConsultaNFDest = Nothing

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function SendDownload(ByVal sChaveAcesso As String) As Boolean

        'Váriaveis Locais
        Dim sRetornoWS As String
        Dim oTConsSitNFe As New distDFeInt

        Try


            'Tenta consultar novamente e habilitar o download
            Try
                Dim sXML As String
                Dim oClsNFeConsultaDFe_v2 As New clsNFeConsultaDFe_V4
                'Dim sNSU As String = LoadCodigo("sp_select_faturamento_entrada_nfe_destinada_nsu_chave_acesso '" & sChaveAcesso & "'," & CStr(goUsuario.iEmpresa))
                'oClsNFeConsultaDFe_v2.SendNSU(sNSU, sXML)
                oClsNFeConsultaDFe_v2.SendChaveAcesso(sChaveAcesso, sXML)

                'Seta Arquivo de Retorno
                Dim sPath = goConfiguracaoNFe.sPastaRecibo & sChaveAcesso & "-ret-ped-consulta-nf-download-teste.xml"
                sPathArquivoRetorno = sPath
                'Recebe Arquivo de Retorno do WebService
                Dim oStreamWriter As StreamWriter = File.CreateText(sPath)
                oStreamWriter.Write(sXML)
                oStreamWriter.Close()

            Catch ex As Exception

            End Try






            ''Parâmetros0
            'oTConsSitNFe.versao = NFe.ConsultaDFe_V2.TVerDistDFe.Item101
            'oTConsSitNFe.tpAmb = NFe.ConsultaDFe_V2.TAmb.Item1
            'oTConsSitNFe.ItemElementName = ItemChoiceType.CNPJ
            'oTConsSitNFe.Item = Replace(Replace(Replace(goEmitente.sCNPJ, ".", ""), "/", ""), "-", "")

            'oTConsSitNFe.cUFAutor = DefineEnum(goEmitente.iUF, GetType(TCodUfIBGE)) ' TCodUfIBGE.Item51

            ''Recebendo o último NSU criado
            'Dim oDistDFeIntConsChNFe = New distDFeIntConsNSU
            'oDistDFeIntConsChNFe.chNFe = sChaveAcesso
            'oTConsSitNFe.Item1 = oDistDFeIntConsChNFe


            ''Seta Arquivo
            'sPathArquivoEnvio = goConfiguracaoNFe.sPastaEnvio & Format(Now, "yyyy_mm_dd") & "-ped-consulta-nf-download.xml"

            ''Salva Pedido de Status do Serviço Temporariamente
            'oTConsSitNFe.Save(sPathArquivoEnvio)

            ''Valida Arquivo XML Assinado
            'Dim sRetornoValidacao As String = ""

            ''Verifica se Encontrou algum Erro no Arquivo XML
            'sRetornoValidacao = ValidaArquivoXML(sPathArquivoEnvio, _
            '                                     goConfiguracaoNFe.sPastaXSD & "distDFeInt_v1.01.xsd")

            ''Verifica se ocorreu algum erro na Validação
            'If sRetornoValidacao <> "" Then

            '    'Exclui Arquivo XML (Status)
            '    File.Delete(sPathArquivoEnvio)

            '    'Seta Informação
            '    sMensagemErro = "O Arquivo XML apresentou os seguintes erros:" & vbCrLf & sRetornoValidacao
            '    'Retorno da Função
            '    Return False

            'Else

            '    Try

            '        'Executa Serviço (SÍNCRONO)
            '        sRetornoWS = WSConsultaDFe(sPathArquivoEnvio)

            '        'Setando o retorno da função
            '        sArquivoXML = sRetornoWS
            '    Catch ex As Exception
            '        'Exclui Arquivo XML (Pedido de Cancelamento e Cabeçalho)
            '        File.Delete(sPathArquivoEnvio)
            '        'Seta Informação
            '        sMensagemErro = ex.Message
            '        'Retorno da Função
            '        Return False
            '    End Try

            '    'Seta Arquivo de Retorno
            '    sPathArquivoRetorno = goConfiguracaoNFe.sPastaRecibo & sChaveAcesso & "-ret-ped-consulta-nf-download.xml"

            '    'Recebe Arquivo de Retorno do WebService
            '    Dim oStreamWriter As StreamWriter = File.CreateText(sPathArquivoRetorno)
            '    oStreamWriter.Write(sRetornoWS)
            '    oStreamWriter.Close()

            'End If

            'Seta Retorno da Função
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function LoadArquivoDownload(ByVal sArquivo As String, ByVal sChaveAcesso As String) As Boolean

        'Váriaveis Locais
        Dim oTRetConsultaNFDest As New retDistDFeInt
        'Instanciando a classe para inserir no banco de dados
        'Dim oClsUsrIntNFeDestinada As New clsUsrFatEntradaNFeDestinada
        Try

            'Carrega arquivo de Retorno
            oTRetConsultaNFDest = retDistDFeInt.Load(sPathArquivoRetorno)

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

            Dim bFlag = False
            Dim sUltimoNSU As String = oTRetConsultaNFDest.ultNSU
            'percorre os retornos
            For iZip As Integer = 0 To oTRetConsultaNFDest.loteDistDFeInt.docZip.Count - 1


                Dim oClsUsrIntNFeDestinada As New clsUsrFatEntradaNFeDestinada
                'Recebe o NSU
                Dim sNSU As String = oTRetConsultaNFDest.loteDistDFeInt.docZip(iZip).NSU


                'Recebe o vetor dos bytes compactados
                Dim oByteCompactado() As Byte = oTRetConsultaNFDest.loteDistDFeInt.docZip(iZip).Value

                'Descompacta o byte
                Dim oByteDescompactado() As Byte = Decompress(oByteCompactado)

                'Cria a string a partir dos bytes
                Dim oEnc As New System.Text.ASCIIEncoding
                Dim sXML As String = oEnc.GetString(oByteDescompactado)


                If sXML.ToUpper.Contains("NFEPROC") Then


                    If sXML.Contains(sChaveAcesso) Then

                        'Escreve no arquivo
                        Dim oStreamWriter As New StreamWriter(sArquivo, False, System.Text.Encoding.Default)
                        oStreamWriter.WriteLine(sXML)
                        oStreamWriter.Close()
                        bFlag = True
                        Return True

                    End If
                End If
            Next

            If bFlag = False Then

                MsgBox("Não foi possível fazer o download do arquivo!", MsgBoxStyle.Exclamation, "Validação")
                Return False

            End If

            'Limpa Váriaveis
            oTRetConsultaNFDest = Nothing

        Catch ex As Exception
            Throw ex
        End Try

    End Function


    Public Function SendDownloadCTE(ByVal sChaveAcesso As String) As Boolean

        'Váriaveis Locais
        Dim sRetornoWS As String
        Dim oTConsSitNFe As New distDFeInt

        Try


            'Tenta consultar novamente e habilitar o download
            Try
                Dim sXML As String
                Dim oClsNFeConsultaDFe_v2 As New clsNFeConsultaDFe_V4
                Dim sNSU As String = LoadCodigo("sp_select_faturamento_entrada_nfe_destinada_nsu_chave_acesso '" & sChaveAcesso & "'," & CStr(goUsuario.iEmpresa))
                oClsNFeConsultaDFe_v2.SendNSU_CTE(sNSU, sXML)


                'Seta Arquivo de Retorno
                Dim sPath = goConfiguracaoNFe.sPastaRecibo & sChaveAcesso & "-ret-ped-consulta-nf-download-teste.xml"
                sPathArquivoRetorno = sPath
                'Recebe Arquivo de Retorno do WebService
                Dim oStreamWriter As StreamWriter = File.CreateText(sPath)
                oStreamWriter.Write(sXML)
                oStreamWriter.Close()

            Catch ex As Exception

            End Try






            ''Parâmetros0
            'oTConsSitNFe.versao = NFe.ConsultaDFe_V2.TVerDistDFe.Item101
            'oTConsSitNFe.tpAmb = NFe.ConsultaDFe_V2.TAmb.Item1
            'oTConsSitNFe.ItemElementName = ItemChoiceType.CNPJ
            'oTConsSitNFe.Item = Replace(Replace(Replace(goEmitente.sCNPJ, ".", ""), "/", ""), "-", "")

            'oTConsSitNFe.cUFAutor = DefineEnum(goEmitente.iUF, GetType(TCodUfIBGE)) ' TCodUfIBGE.Item51

            ''Recebendo o último NSU criado
            'Dim oDistDFeIntConsChNFe = New distDFeIntConsNSU
            'oDistDFeIntConsChNFe.chNFe = sChaveAcesso
            'oTConsSitNFe.Item1 = oDistDFeIntConsChNFe


            ''Seta Arquivo
            'sPathArquivoEnvio = goConfiguracaoNFe.sPastaEnvio & Format(Now, "yyyy_mm_dd") & "-ped-consulta-nf-download.xml"

            ''Salva Pedido de Status do Serviço Temporariamente
            'oTConsSitNFe.Save(sPathArquivoEnvio)

            ''Valida Arquivo XML Assinado
            'Dim sRetornoValidacao As String = ""

            ''Verifica se Encontrou algum Erro no Arquivo XML
            'sRetornoValidacao = ValidaArquivoXML(sPathArquivoEnvio, _
            '                                     goConfiguracaoNFe.sPastaXSD & "distDFeInt_v1.01.xsd")

            ''Verifica se ocorreu algum erro na Validação
            'If sRetornoValidacao <> "" Then

            '    'Exclui Arquivo XML (Status)
            '    File.Delete(sPathArquivoEnvio)

            '    'Seta Informação
            '    sMensagemErro = "O Arquivo XML apresentou os seguintes erros:" & vbCrLf & sRetornoValidacao
            '    'Retorno da Função
            '    Return False

            'Else

            '    Try

            '        'Executa Serviço (SÍNCRONO)
            '        sRetornoWS = WSConsultaDFe(sPathArquivoEnvio)

            '        'Setando o retorno da função
            '        sArquivoXML = sRetornoWS
            '    Catch ex As Exception
            '        'Exclui Arquivo XML (Pedido de Cancelamento e Cabeçalho)
            '        File.Delete(sPathArquivoEnvio)
            '        'Seta Informação
            '        sMensagemErro = ex.Message
            '        'Retorno da Função
            '        Return False
            '    End Try

            '    'Seta Arquivo de Retorno
            '    sPathArquivoRetorno = goConfiguracaoNFe.sPastaRecibo & sChaveAcesso & "-ret-ped-consulta-nf-download.xml"

            '    'Recebe Arquivo de Retorno do WebService
            '    Dim oStreamWriter As StreamWriter = File.CreateText(sPathArquivoRetorno)
            '    oStreamWriter.Write(sRetornoWS)
            '    oStreamWriter.Close()

            'End If

            'Seta Retorno da Função
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function LoadArquivoDownloadCTE(ByVal sArquivo As String) As Boolean

        'Váriaveis Locais
        Dim oTRetConsultaNFDest As New RetConsultaDFe_CTE.retDistDFeInt
        'Instanciando a classe para inserir no banco de dados
        'Dim oClsUsrIntNFeDestinada As New clsUsrFatEntradaNFeDestinada
        Try

            'Carrega arquivo de Retorno
            oTRetConsultaNFDest = RetConsultaDFe_CTE.retDistDFeInt.Load(sPathArquivoRetorno)

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

            Dim bFlag = False
            Dim sUltimoNSU As String = oTRetConsultaNFDest.ultNSU
            'percorre os retornos
            For iZip As Integer = 0 To oTRetConsultaNFDest.loteDistDFeInt.docZip.Count - 1


                Dim oClsUsrIntNFeDestinada As New clsUsrFatEntradaNFeDestinada
                'Recebe o NSU
                Dim sNSU As String = oTRetConsultaNFDest.loteDistDFeInt.docZip(iZip).NSU


                'Recebe o vetor dos bytes compactados
                Dim oByteCompactado() As Byte = oTRetConsultaNFDest.loteDistDFeInt.docZip(iZip).Value

                'Descompacta o byte
                Dim oByteDescompactado() As Byte = Decompress(oByteCompactado)

                'Cria a string a partir dos bytes
                Dim oEnc As New System.Text.ASCIIEncoding
                Dim sXML As String = oEnc.GetString(oByteDescompactado)


                If sXML.ToUpper.Contains("PROTCTE") Then

                    'Escreve no arquivo
                    Dim oStreamWriter As New StreamWriter(sArquivo, False, System.Text.Encoding.Default)
                    oStreamWriter.WriteLine(sXML)
                    oStreamWriter.Close()
                    bFlag = True
                    Return True
                End If
            Next

            If bFlag = False Then

                MsgBox("Não foi possível fazer o download do arquivo!", MsgBoxStyle.Exclamation, "Validação")
                Return False

            End If

            'Limpa Váriaveis
            oTRetConsultaNFDest = Nothing

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Shared Function Decompress(ByVal data As Byte()) As Byte()
        Dim input As New MemoryStream()
        input.Write(data, 0, data.Length)
        input.Position = 0
        Dim gzip As New GZipStream(input, CompressionMode.Decompress, True)
        Dim output As New MemoryStream()
        Dim buff As Byte() = New Byte(63) {}
        Dim read As Integer = -1
        read = gzip.Read(buff, 0, buff.Length)
        While read > 0
            output.Write(buff, 0, read)
            read = gzip.Read(buff, 0, buff.Length)
        End While
        gzip.Close()
        Return output.ToArray()
    End Function
#End Region

End Class
