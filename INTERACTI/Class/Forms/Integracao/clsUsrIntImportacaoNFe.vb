Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports System.IO
Imports System.Drawing.Imaging

Public Class clsUsrIntImportacaoNFe

#Region "::: VARIAVEIS :::"

    Private lCodigoEmissaoCapa As Long
    Private lCodigoNFSeCapa As Long

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoEmissaoCapa() As Long
        Get
            Return lCodigoEmissaoCapa
        End Get
        Set(ByVal value As Long)
            lCodigoEmissaoCapa = value
        End Set
    End Property

    Public Property CodigoNFSeCapa() As Long
        Get
            Return lCodigoNFSeCapa
        End Get
        Set(ByVal value As Long)
            lCodigoNFSeCapa = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Function ArrumarXML(ByVal sChaveAcesso As String, _
                               ByVal sXMLEnvio As String) As String

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try
            'Seta Parametros - XML Envio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "xml_envio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Text
            oSqlParameter(i).Value = sXMLEnvio : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "chave_acesso"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sChaveAcesso : i += 1

            'Seta Parametros - Código da Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_arrumar_xml", oSqlParameter)

          

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ImportarXMLEmissao(ByVal sArquivoXML As String, _
                                       ByVal sArquivo As String, _
                                       ByRef sMensagem As String) As String

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try

            sArquivoXML = sArquivoXML.Replace("<?xml version = '1.0' encoding = 'UTF-8'?>", "")
            sArquivoXML = sArquivoXML.Replace("xmlns=""http://www.portalfiscal.inf.br/nfe""", "")
            sArquivoXML = RetirarAcento2(sArquivoXML)

            'Seta Parametros - Arquivo XML
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo_txt"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Text
            oSqlParameter(i).Value = sArquivoXML : i += 1

            'Seta Parametros - Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sArquivo : i += 1

            'Seta Parametros - Código do Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Hostname
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hostname"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = System.Net.Dns.GetHostName : i += 1

            'Seta Parametros - Código da Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1


            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt

            'Executa Query
            sMensagem = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_importar_xml", oSqlParameter), String)

            If sMensagem = "" Then
                lCodigoEmissaoCapa = oSqlParameter(5).Value
            End If

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ImportarXMLEntrada(ByVal sArquivoXML As String, _
                                       ByVal sArquivo As String, _
                                       ByRef sMensagem As String, _
                                       ByVal bUsoConsumo As Boolean) As String

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            sArquivoXML = sArquivoXML.Replace("<?xml version = ""1.0"" encoding = ""UTF-8""?>", "")
            sArquivoXML = sArquivoXML.Replace("<?xml version = '1.0' encoding = 'UTF-8'?>", "")
            sArquivoXML = sArquivoXML.Replace("<?xml version='1.0' encoding='UTF-8'?>", "")
            sArquivoXML = sArquivoXML.Replace("xmlns=""http://www.portalfiscal.inf.br/nfe""", "")
            sArquivoXML = sArquivoXML.Replace("xmlns=""http://www.portalfiscal.inf.br/cte""", "")
            sArquivoXML = sArquivoXML.Replace("nfeProc versao='3.10'", "nfeProc versao=""3.10""")
            sArquivoXML = sArquivoXML.Replace("nfeProc versao='2.00'", "nfeProc versao=""2.00""")
            sArquivoXML = sArquivoXML.Replace("protNFe versao='3.10'", "protNFe versao=""3.10""")
            sArquivoXML = sArquivoXML.Replace("protNFe versao='2.00'", "protNFe versao=""2.00""")

            sArquivoXML = RetirarAcento2(sArquivoXML)

            'Seta Parametros - Arquivo TXT
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo_txt"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Text
            oSqlParameter(i).Value = sArquivoXML : i += 1

            'Seta Parametros - Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sArquivo : i += 1

            'Seta Parametros - Código do Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Hostname
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hostname"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = System.Net.Dns.GetHostName : i += 1

            'Seta Parametros - Código da Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uso_consumo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bUsoConsumo : i += 1

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt

            'Executa Query
            If sArquivoXML.ToUpper.Contains("CTEPROC") Then
                sMensagem = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_importar_cte", oSqlParameter), String)
            Else
                sMensagem = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_importar_xml2", oSqlParameter), String)
            End If

            If sMensagem = "" Then
                lCodigoEmissaoCapa = oSqlParameter(i).Value
            End If

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ImportarXMLEmissaoServicoAscon(ByVal sArquivoXML As String, _
                                             ByVal sArquivo As String, _
                                             ByRef sMensagem As String) As String

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim sReturn As String
        Dim i As Integer = 0

        Try

            sArquivoXML = sArquivoXML.Replace("<?xml version = '1.0' encoding = 'UTF-8'?>", "")
            sArquivoXML = sArquivoXML.Replace("xmlns=""http://www.portalfiscal.inf.br/nfe""", "")
            sArquivoXML = RetirarAcento2(sArquivoXML)

            'Vetor para armazenar as notas
            Dim oArquivos() As String


            Dim bLote As Boolean = True
            Dim sRetorno As String = ""

            'Verifica se é um conjunto de notas
            If sArquivoXML.Contains("<ns2:Nfse") Then

                'Tirando o cabeçalho
                sArquivoXML = Replace(sArquivoXML, "<NFSE xmlns:ns2=""http://www.w3.org/2000/09/xmldsig"" xmlns:ns3=""http://www.ginfes.com.br/tipos"" xmlns:ns4=""http://www.ginfes.com.br/servico_consultar_nfse_envio"" xmlns:ns5=""http://www.ginfes.com.br/servico_cancelar_nfse_envio"">", "")

                'Tira o final do fechamento do cabeçalho
                sArquivoXML = Replace(sArquivoXML, "</NFSE>", "")


                'Coloca um caracter para fazer um split entre as notas
                sArquivoXML = Replace(sArquivoXML, "<ns2:Nfse>", "§<ns2:Nfse>")

                'Por fim, aplica o Split para gerar o vetor
                oArquivos = sArquivoXML.Split("§")


            Else
                'Seta variavel
                bLote = False

                'Redimensiona o vetor
                ReDim oArquivos(1)

                'Coloca somente uma posição, no caso de ser apenas uma nota
                oArquivos(1) = sArquivoXML

            End If

            'Percorre o vetor das notas
            For iNFSe As Integer = 1 To oArquivos.Count - 1

                i = 0

                'Seta Parametros - Arquivo XML
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "arquivo_txt"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Text
                oSqlParameter(i).Value = oArquivos(iNFSe) : i += 1

                'Seta Parametros - Arquivo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "arquivo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 500
                oSqlParameter(i).Value = sArquivo : i += 1

                'Seta Parametros - Código do Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_usuario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

                'Seta Parametros - Hostname
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "hostname"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 50
                oSqlParameter(i).Value = System.Net.Dns.GetHostName : i += 1

                'Seta Parametros - Código da Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Código NFSe Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_nfse_capa"
                oSqlParameter(i).Direction = ParameterDirection.Output
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt

                'Executa Query
                If bLote = True Then

                    sRetorno = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_servico_importar_xml_lote", oSqlParameter), String)
                Else

                    sRetorno = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_servico_importar_xml", oSqlParameter), String)
                End If


                'Concatena o retorno
                sMensagem += sRetorno
            Next

            'Verifica se teve algum erro
            If sMensagem = "" Then
                lCodigoNFSeCapa = oSqlParameter(5).Value
            End If

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                             ByVal lCodigoEmissaoCapa As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Vitrine
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
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_item_produto", oSqlParameter)

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

    Public Sub InsertItemTemp(ByVal lCodigoEmissaoCapa As Long, _
                            ByVal iCodigoEmissaoItem As Integer, _
                            ByVal iCodigoItemNovo As Integer, _
                            ByVal sItemNovo As String)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Justificativa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoEmissaoItem : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_novo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoItemNovo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item_novo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sItemNovo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_item_tmp", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteItemTemp(ByVal lCodigoEmissaoCapa As Long, _
                           ByVal iCodigoEmissaoItem As Integer)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Justificativa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoEmissaoItem : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_emissao_item_tmp", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateItemTemp(ByVal lCodigoEmissaoCapa As Long, _
                           ByVal iCodigoEmissaoItem As Integer, _
                           ByVal iCodigoItemNovo As Integer, _
                           ByVal sItemNovo As String)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Justificativa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoEmissaoItem : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_novo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoItemNovo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item_novo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sItemNovo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_item_tmp", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateItemNFTemp(ByVal lCodigoEmissaoCapa As Long)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
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
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_item_importacao_tmp", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Public Sub UpdateNFImportacao(ByVal lCodigoEmissaoCapa As Long, _
                                  ByVal iCFOP As Integer, _
                                  ByVal sNumeroDrawback As String, _
                                  ByVal sNaturezaOperacao As String)

        'Variaveis Locais
        Dim oSqlParameter(6) As SqlParameter
        Dim i As Integer = 0

        Try


            'Seta Parametros - Código Entrada Capa
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


            'Seta Parametros - Código cfop
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cfop"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCFOP : i += 1

            'Seta Parametros - natureza operação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "natureza_operacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNaturezaOperacao : i += 1


            'Seta Parametros - drawback
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_drawback_adicao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sNumeroDrawback = "", DBNull.Value, sNumeroDrawback) : i += 1

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_importacao", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateNFProduto(ByVal lCodigoEmissaoCapa As Long, _
                                  ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(6) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow In oGrid.GetRows
                i = 0
                If oRow.Cells.Item("codigo_produto_servico").Value Is Nothing Then Continue For
                If IsDBNull(oRow.Cells.Item("codigo_produto_servico").Value) = True Then Continue For

                'Seta Parametros - Código Entrada Capa
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


                'Seta Parametros - Código Emissao Item
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_item"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells.Item("codigo_emissao_item").Value : i += 1

                'Seta Parametros - Código Produto Servico
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_produto_servico"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oRow.Cells.Item("codigo_produto_servico").Value : i += 1

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_item_importacao", oSqlParameter)

            Next
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridItemTemp(ByVal oGrid As GridEX, _
                            ByVal lCodigoEmissaoCapa As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Vitrine
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
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_item_tmp", oSqlParameter)

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

    Public Function ImportarXMLEmissaoServico(ByVal sArquivoXML As String, _
                                              ByVal sArquivo As String, _
                                              ByRef sMensagem As String) As String

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim sReturn As String
        Dim i As Integer = 0

        Try

            sArquivoXML = sArquivoXML.Replace("<?xml version = '1.0' encoding = 'UTF-8'?>", "")
            sArquivoXML = sArquivoXML.Replace("xmlns=""http://www.portalfiscal.inf.br/nfe""", "")
            sArquivoXML = RetirarAcento2(sArquivoXML)
            sArquivoXML = sArquivoXML.Replace("&#13;", " ")
            sArquivoXML = sArquivoXML.Replace("&13;", " ")

            'Vetor para armazenar as notas
            Dim oArquivos() As String


            Dim bLote As Boolean = True
            Dim sRetorno As String = ""

            'Verifica se é um conjunto de notas
            If sArquivoXML.Contains("ListaNotaFiscal") Then

                Dim oXMLDocument As New Xml.XmlDocument
                oXMLDocument.LoadXml(sArquivoXML)


                ReDim oArquivos(0)

                For Each oNode In oXMLDocument.GetElementsByTagName("ListaNotaFiscal")(0)

                    ReDim Preserve oArquivos(oArquivos.Count)
                    oArquivos(oArquivos.Count - 1) = oNode.innerxml

                Next


            


            Else
                'Seta variavel
                bLote = False

                'Redimensiona o vetor
                ReDim oArquivos(1)

                'Coloca somente uma posição, no caso de ser apenas uma nota
                oArquivos(1) = sArquivoXML

            End If

            'Percorre o vetor das notas
            For iNFSe As Integer = 1 To oArquivos.Count - 1

                i = 0

                'Seta Parametros - Arquivo XML
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "arquivo_txt"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Text
                oSqlParameter(i).Value = oArquivos(iNFSe) : i += 1

                'Seta Parametros - Arquivo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "arquivo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 500
                oSqlParameter(i).Value = sArquivo : i += 1

                'Seta Parametros - Código do Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_usuario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

                'Seta Parametros - Hostname
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "hostname"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 50
                oSqlParameter(i).Value = System.Net.Dns.GetHostName : i += 1

                'Seta Parametros - Código da Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Código NFSe Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_nfse_capa"
                oSqlParameter(i).Direction = ParameterDirection.Output
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt

                'Executa Query
                If bLote = True Then

                    sRetorno = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_servico_importar_xml_lote", oSqlParameter), String)
                Else

                    sRetorno = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_servico_importar_xml", oSqlParameter), String)
                End If


                'Concatena o retorno
                sMensagem += sRetorno
            Next

            'Verifica se teve algum erro
            If sMensagem = "" Then
                lCodigoNFSeCapa = oSqlParameter(5).Value
            End If

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ArquivoImportado(ByVal sArquivoXML As String) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0
        Dim bReturn As Boolean

        Try

            'Seta Parametros - Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sArquivoXML : i += 1

            'Seta Parametros - Código da Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            bReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_integracao_arquivo_nfe", oSqlParameter), Boolean)

            Return bReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ArquivoImportadoVolumes(ByVal sArquivoXML As String) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0
        Dim bReturn As Boolean

        Try

            'Seta Parametros - Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sArquivoXML : i += 1

            'Seta Parametros - Código da Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            bReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_integracao_arquivo_nfe_volumes", oSqlParameter), Boolean)

            Return bReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub InsertArquivoVolumes(ByVal sArquivo As String)

        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0

        Try


            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1
          

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sArquivo : i += 1

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_integracao_nfe_volumes", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub



    Public Sub InsertVolumes(ByVal sNumeroEtiqueta As String, _
                             ByVal sNumeroLote As String, _
                             ByVal sNumeroVolume As String, _
                             ByVal sTotalVolumes As String, _
                             ByVal sNumeroPedido As String, _
                             ByVal sSetor As String, _
                             ByVal sSemana As String, _
                             ByVal sCodigoConsultora As String)

        'Variaveis Locais
        Dim oSqlParameter(19) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_etiqueta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroEtiqueta : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_lote"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroLote : i += 1

            'Seta Parametros - Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_volume"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroVolume : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "total_volumes"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sTotalVolumes : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroPedido : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "setor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sSetor : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "semana"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sSemana : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_consultora"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCodigoConsultora : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_controle_volumes", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


#Region "::: BOLETA :::"

    Public Sub LoadGridBoleta(ByVal oGrid As GridEX, _
                            ByVal lCodigoBoleta As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_boleta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoBoleta : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_boleta", oSqlParameter)

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

    Public Sub LoadDadosParceiroNegocio(ByVal lCodigo As Long, _
                                       ByRef sUF As String, _
                                       ByRef iPersonalidade As Integer)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigo

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Obtem o DataSet
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_dados_parceiro_negocio", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                sUF = oSqlDataReader.Item("uf")
                iPersonalidade = oSqlDataReader.Item("codigo_personalidade")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertEmitente(ByVal lCodigoEmissaoCapa As Long)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emitente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emitente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_emitente_importacao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertDestinatario(ByVal lCodigoEmissaoCapa As Long, _
                                ByVal lCodigoDestinatario As Long)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Destinatário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_destinatario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoDestinatario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_destinatario_importacao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertFatura(ByVal lCodigoEmissaoCapa As Long, _
                          ByVal lCodigoBoleta As Long)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_boleta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoBoleta : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_fatura_boleta", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertTransporte(ByVal lCodigoEmissaoCapa As Long, _
                               ByVal lCodigoBoleta As Long)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Emissão Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_boleta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoBoleta : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_transporte_boleta", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertItem(ByVal lCodigoEmissaoCapa As Long, _
                        ByVal lCodigoBoleta As Long, _
                        ByVal iCodigoItem As Integer, _
                        ByVal iCodigoRegraFaturamento As Integer, _
                        ByVal dQuantidade As Double, _
                        ByVal iCodigoBoletaItem As Integer)

        'Variaveis Locais
        Dim oSqlParameter(16) As SqlParameter
        Dim i As Integer

        Try
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_boleta_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoBoletaItem : i += 1

            'Seta Parametros - Código Emissao Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_emissao_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEmissaoCapa : i += 1

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_boleta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoBoleta : i += 1

            'Seta Parametros - Código Regra Faturamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_regra_faturamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoRegraFaturamento : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_item_boleta", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ImportarBoleta(ByVal lCodigoEmissaoCapa As Long, _
                                ByVal iCodigoCliente As Integer, _
                                ByVal lCodigoBoleta As Long, _
                                ByVal oGrid As GridEX)

        Try

            'Váriaveis Locais
            Dim bPrimeiroRegistro As Boolean = True
            Dim sUF As String
            Dim iCodigoPersonalidade As Integer

            LoadDadosParceiroNegocio(iCodigoCliente, sUF, iCodigoPersonalidade)

            'Insere Dados do Emitente
            Call InsertEmitente(lCodigoEmissaoCapa)

            'Insere Dados do Destinatário
            Call InsertDestinatario(lCodigoEmissaoCapa, iCodigoCliente)

            'Percorre Grid
            For Each oRow As GridEXRow In oGrid.GetRows

                'Insere Dados do Item
                Call InsertItem(lCodigoEmissaoCapa, _
                                lCodigoBoleta, _
                                oRow.Cells("codigo_produto_servico").Value, _
                                LoadCodigo("sp_select_faturamento_regra_faturamento " & _
                                          oRow.Cells.Item("codigo_produto_servico").Value & ", " & _
                                          goUsuario.iEmpresa & ", " & _
                                          iCodigoPersonalidade & "," & _
                                          0 & ", " & _
                                          iCodigoCliente & ", '" & _
                                          sUF & "', " & _
                                          oRow.Cells.Item("codigo_ncm").Value), _
                                oRow.Cells("quantidade").Value, _
                                oRow.Cells("codigo").Value)

            Next

            'Insere Dados da Fatura
            Call InsertFatura(lCodigoEmissaoCapa, lCodigoBoleta)

            'Insere Dados do Transporte
            Call InsertTransporte(lCodigoEmissaoCapa, lCodigoBoleta)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateItemBoleta(ByVal lCodigoBoleta As Long, _
                                ByVal iCodigo As Integer, _
                                ByVal iCodigoItem As Integer)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_boleta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoBoleta : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoItem : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_boleta_item", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
#End Region

#End Region

End Class
