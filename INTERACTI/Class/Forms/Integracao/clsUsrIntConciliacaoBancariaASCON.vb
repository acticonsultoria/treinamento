Imports System.IO
Imports System.IO.File
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports BoletoNet

Public Class clsUsrIntConciliacaoBancariaASCON

#Region "::: VARIAVEIS :::"

    Private dDataInicio As Date
    Private dDataTermino As Date
    Private sArquivoNF As StreamWriter
    Private lCodigoArquivoRetorno As Long
    Private iCodigoEmpresa As Integer

#End Region

#Region "::: PROPERTIE ::: "

    Public Property CodigoEmpresa As Integer
        Get
            Return icodigoempresa
        End Get
        Set(ByVal value As Integer)
            icodigoempresa = value
        End Set
    End Property

    Public Property DataInicio() As Date
        Get
            Return dDataInicio
        End Get
        Set(ByVal value As Date)
            dDataInicio = value
        End Set
    End Property

    Public Property DataTermino() As Date
        Get
            Return dDataTermino
        End Get
        Set(ByVal value As Date)
            dDataTermino = value
        End Set
    End Property

    Public Property ArquivoNF() As StreamWriter
        Get
            Return sArquivoNF
        End Get
        Set(ByVal value As StreamWriter)
            sArquivoNF = value
        End Set
    End Property

    Public Property CodigoArquivoRetorno() As Long
        Get
            Return lCodigoArquivoRetorno
        End Get
        Set(ByVal value As Long)
            lCodigoArquivoRetorno = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: REMESSA :::"

    Public Sub LoadGridRemessa(ByVal oGrid As GridEX, _
                               ByVal sDataInicio As String, _
                               ByVal sDataTermino As String, _
                               ByVal iCodigoBancoConta As Integer)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim oDataSet As DataSet
        Dim i As Integer = 0

        Try

            'Seta Parametros - Data Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataInicio = "", DBNull.Value, sDataInicio) : i += 1

            'Seta Parametros - Data Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataTermino = "", DBNull.Value, sDataTermino) : i += 1

            'Seta Parametros - Tipo de Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco_conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoBancoConta : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Quety
            oDataSet = SQLHelper.ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_integracao_conciliacao_bancaria", oSqlParameter)

            'Configura DataMember
            ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

            'Seta Posição
            oGrid.MoveFirst()

        Catch Sqlex As SqlException
            Throw Sqlex
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub GerarArquivoRemessa(ByVal oGrid As GridEX, _
                                   ByVal iBancoConta As Integer, _
                                   ByVal sPath As String, _
                                         Optional ByVal bCancelamento As Boolean = False)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0
        Dim sConvenio As String = ""
        Dim iCNAB As Integer = 240
        Dim oInstrucao1 As Instrucao
        Dim oInstrucao2 As Instrucao

        'Instanciando um stream
        Dim oStream As System.IO.FileStream = File.Create(sPath)

        Try

            'Instanciando o componente de cedente
            Dim oCedente As Cedente = LoadCedente(iBancoConta)

            'Criando um array de boleto
            Dim oBoletos As New Boletos

            'Percorrendo os boletos criados
            For Each oRow In oGrid.GetCheckedRows

                'Setando o contador
                i = 0

                'Código Título Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_titulo_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells.Item("codigo").Value : i += 1

                'Número Parcela
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero_parcela"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells.Item("numero_parcela").Value : i += 1

                'Código da Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Quety
                oSqlDataReader = SQLHelper.ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_integracao_conciliacao_bancaria_dados_boleto", oSqlParameter)

                'Verificando a leitura
                If oSqlDataReader.Read Then

                    'Verifica se foi encontrado a espécie
                    If IsDBNull(oSqlDataReader.Item("especie")) Then
                        frmMain.Informacao(Mensagem.OperacaoNaoRealizada, "Não existe espécie associado ao Banco.")
                        oSqlDataReader.Close()
                        Exit Sub
                    End If

                    'Variavies que serão utilizadas depois
                    sConvenio = oSqlDataReader.Item("convenio")
                    iCNAB = oSqlDataReader.Item("cnab")

                    'Configurando o arry de boletos
                    oBoletos.Banco = New Banco(oSqlDataReader.Item("codigo_banco"))

                    'Seta Carteira
                    oCedente.Carteira = oRow.Cells("carteira").Value

                    If oSqlDataReader.Item("codigo_banco") = 104 Then
                        oCedente.Codigo = oSqlDataReader.Item("convenio")
                    End If

                    'Seta Conta Bancária
                    oBoletos.contaBancaria = oCedente.ContaBancaria

                    'Setando os Parâmetros de Endereço
                    Dim oEnderecoSacado As New Endereco
                    oEnderecoSacado.Bairro = oSqlDataReader.Item("bairro")
                    oEnderecoSacado.CEP = oSqlDataReader.Item("cep")
                    oEnderecoSacado.Cidade = oSqlDataReader.Item("cidade")
                    oEnderecoSacado.Logradouro = oSqlDataReader.Item("logradouro")
                    oEnderecoSacado.End = oSqlDataReader.Item("logradouro") + "," + oSqlDataReader.Item("numero") + "," + oSqlDataReader.Item("bairro")

                    If oSqlDataReader.Item("complemento") <> "" Then
                        oEnderecoSacado.Complemento = oSqlDataReader.Item("complemento")
                    End If
                    If oSqlDataReader.Item("email") <> "" Then
                        oEnderecoSacado.Email = oSqlDataReader.Item("email")
                    End If

                    oEnderecoSacado.Numero = oSqlDataReader.Item("numero")
                    oEnderecoSacado.UF = oSqlDataReader.Item("uf")

                    'Configurando o Cacado
                    Dim oSacado As New Sacado(oSqlDataReader.Item("cnpj_cpf"), _
                                              oSqlDataReader.Item("nome"), _
                                              oEnderecoSacado)

                    'Configurando o boleto bancário
                    Dim oBoletoBancario As New BoletoBancario
                    oBoletoBancario.CodigoBanco = oSqlDataReader.Item("codigo_banco")

                    'Configurando o boleto
                    Dim oBoleto As New Boleto

                    'Setando o emissor e destinatario
                    oBoleto.Cedente = oCedente
                    oBoleto.Sacado = oSacado

                    'Parâmetros 
                    oBoleto.EspecieDocumento = New EspecieDocumento(oSqlDataReader.Item("codigo_banco"), oSqlDataReader.Item("especie"))

                    oBoleto.Carteira = oSqlDataReader.Item("carteira")
                    oBoleto.ValorBoleto = oSqlDataReader.Item("valor")
                    oBoleto.NossoNumero = oSqlDataReader.Item("nosso_numero")
                    oBoleto.NumeroDocumento = oSqlDataReader.Item("numero_documento")
                    oBoleto.DataVencimento = oSqlDataReader.Item("data_vencimento")
                    oBoleto.DataDocumento = Now.Date
                    oBoleto.DataProcessamento = Now.Date
                    oBoleto.JurosMora = oSqlDataReader.Item("juros_mora")
                    oBoleto.PercMulta = oSqlDataReader.Item("valor_multa")

                    If oSqlDataReader.Item("codigo_instrucao1") <> "" Then
                        oInstrucao1 = New Instrucao(oSqlDataReader.Item("codigo_banco"))
                        oInstrucao1.Codigo = oSqlDataReader.Item("codigo_instrucao1")
                        If oSqlDataReader.Item("numero_dias1") > -1 Then oInstrucao1.QuantidadeDias = Format(oSqlDataReader.Item("numero_dias1"), "00")
                        oInstrucao1.Descricao = oSqlDataReader.Item("instrucao1")
                        oBoleto.Instrucoes.Add(oInstrucao1)
                    End If

                    If oSqlDataReader.Item("codigo_instrucao2") <> "" Then
                        oInstrucao2 = New Instrucao(oSqlDataReader.Item("codigo_banco"))
                        oInstrucao2.Codigo = oSqlDataReader.Item("codigo_instrucao2")
                        If oSqlDataReader.Item("numero_dias2") > 0 Then oInstrucao2.QuantidadeDias = Format(oSqlDataReader.Item("numero_dias2"), "00")
                        oInstrucao2.Descricao = oSqlDataReader.Item("instrucao2")
                        oBoleto.Instrucoes.Add(oInstrucao2)
                    End If

                    oBoleto.LocalPagamento = "PAGÁVEL EM QUALQUER BANCO ATÉ O VENCIMENTO"
                    oBoleto.Especie = IIf(oSqlDataReader.Item("codigo_banco") = "104", "DS", "DM")
                    If Not IsDBNull(oSqlDataReader.Item("data_multa")) Then
                        oBoleto.DataMulta = oSqlDataReader.Item("data_multa")
                    End If

                    If bCancelamento = False Then
                        oBoleto.TipoOcorrencia = "01"
                    Else
                        oBoleto.TipoOcorrencia = "02"
                    End If

                    'Instanciando o banco
                    oBoleto.Banco = New Banco(oSqlDataReader.Item("codigo_banco"))

                    'Setando o boleto
                    oBoletoBancario.Boleto = oBoleto

                    'Validando se houve algum problema
                    'oBoletoBancario.Boleto.Valida()

                    'Adicionando o boleto
                    oBoletos.Add(oBoleto)

                End If

                'Fechando o recordset
                oSqlDataReader.Close()

            Next

            'Configurando o arquivo de remessa
            Dim oArquivoRemessa As BoletoNet.ArquivoRemessa

            If iCNAB = 240 Then
                oArquivoRemessa = New BoletoNet.ArquivoRemessa(TipoArquivo.CNAB240)
            ElseIf iCNAB = 400 Then
                oArquivoRemessa = New BoletoNet.ArquivoRemessa(TipoArquivo.CNAB400)
            Else
                oArquivoRemessa = New BoletoNet.ArquivoRemessa(TipoArquivo.Outro)
            End If

            Dim iNumeroArquivoRemessa = LoadNumeroArquivoRemessa()

            'Gerando o arquivo
            oArquivoRemessa.GerarArquivoRemessa(sConvenio, New Banco(oBoletos(0).Banco.Codigo), oCedente, oBoletos, oStream, iNumeroArquivoRemessa)

            'Fechando o recordset
            oSqlDataReader.Close()

        Catch Sqlex As SqlException
            Throw Sqlex
        Catch ex As Exception
            Throw ex
        Finally
            oStream.Close()
        End Try

    End Sub

    Public Function LoadNumeroArquivoRemessa() As Integer

        Try

            'Váriaveis Locais
            Dim oSqlParameter(1) As SqlParameter
            Dim i As Integer = 0
            Dim iReturn As Integer = 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa a query
            iReturn = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_integracao_conciliacao_ultimo_arquivo_remessa", oSqlParameter)

            Return iReturn

        Catch Sqlex As SqlException
            Throw Sqlex
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function LoadCedente(ByVal iBancoConta As Integer) As Cedente

        Try

            'Váriaveis Locais
            Dim oSqlParameter(1) As SqlParameter
            Dim oSqlDataReader As SqlDataReader
            Dim i As Integer = 0

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco_conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iBancoConta : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa a query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_integracao_conciliacao_bancaria_dados_cedente", oSqlParameter)

            'Instanciando o objeto
            Dim oCedente As Cedente

            'Lendo a informação
            If oSqlDataReader.Read Then

                'Configura Cedente
                oCedente = New Cedente(oSqlDataReader.Item("cedente_cnpj_cpf"), _
                                       oSqlDataReader.Item("cedente_nome"), _
                                       oSqlDataReader.Item("cedente_agencia"), _
                                       oSqlDataReader.Item("cedente_digito_agencia"), _
                                       oSqlDataReader.Item("cedente_conta"), _
                                       oSqlDataReader.Item("cedente_digito_conta"), _
                                       "")

                'Verifica se possui Convenio
                If oSqlDataReader.Item("convenio") <> "" Then
                    oCedente.Convenio = oSqlDataReader.Item("convenio")
                    oCedente.Codigo = oSqlDataReader.Item("convenio")
                End If

            End If

            'Fechando o recordset
            oSqlDataReader.Close()

            'Retorno da função
            Return oCedente

        Catch Sqlex As SqlException
            Throw Sqlex
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: RETORNO :::"

    Public Sub GerarNFSe(ByVal iCodigoTituloCapa As Integer, _
                         ByVal sDataCompetencia As String)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

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
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoEmpresa : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoTituloCapa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_competencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDataCompetencia

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_nfse_boleto_retorno", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertArquivoRetornoCapa(ByVal sArquivo As String)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Arquivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sArquivo : i += 1

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
            oSqlParameter(i).Value = iCodigoEmpresa : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_integracao_arquivo_retorno_capa", oSqlParameter)

            'Seta Código
            lCodigoArquivoRetorno = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertArquivoRetornoLinha(ByVal oRow As DataRow)

        'Variaveis Locais
        Dim oSqlParameter(17) As SqlParameter
        Dim i As Integer

        Try



            'Seta Váriavel 
            i = 0

            'Seta Parametros - Código  
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_arquivo_retorno_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoArquivoRetorno : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = oRow("nota_fiscal") : i += 1

            'Seta Parametros - Nosso Numero
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nosso_numero"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = oRow("nosso_numero") : i += 1

            'Seta Parametros - Numero Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = oRow("numero_documento") : i += 1

            'Seta Parametros - Numero Documento Boleto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento_boleto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = oRow("numero_documento_boleto") : i += 1

            'Seta Parametros - Valor Titulo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_titulo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = oRow("valor_titulo") : i += 1

            'Seta Parametros - Valor Pago
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_pago"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = oRow("valor_pago") : i += 1

            'Seta Parametros - Sacado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "sacado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = oRow("sacado") : i += 1

            'Seta Parametros - Valor Tarifas
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_tarifas"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = oRow("valor_tarifas") : i += 1

            'Seta Parametros - Codigo Rejeição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_rejeicao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = oRow("codigo_rejeicao") : i += 1

            'Seta Parametros - Data de Vencimento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = oRow("data_vencimento") : i += 1

            'Seta Parametros - Data de Ocorrencia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_ocorrencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = oRow("data_ocorrencia") : i += 1

            'Seta Parametros - Juros
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "juros"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = oRow("juros") : i += 1

            'Seta Parametros - Tipo Movimento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo_movimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = oRow("tipo_movimento") : i += 1


            'Seta Parametros - CNPJ CPF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnpj_cpf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = oRow("cnpj_cpf").ToString.Trim : i += 1

            'Seta Parametros - Data da Quitação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_quitacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = oRow("data_quitacao")

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_integracao_arquivo_retorno_linha", oSqlParameter)



        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadArquivoRetorno(ByVal iCodigoBancoConta As Integer, _
                                   ByVal sArquivo As String)

        'Variaveis Locais
        Dim iBanco As Integer

        Try
            'Setando o código do banco para a leitura
            iBanco = LoadCodigo("sp_select_cadastro_basico_codigo_banco " & iCodigoBancoConta & "," & goUsuario.iEmpresa)

            'Lendo o arquivo de retorno
            Dim oArquivoRetorno As New ArquivoRetornoCNAB240(sArquivo)
            oArquivoRetorno.LerArquivoRetorno(New Banco(iBanco))

            oArquivoRetorno.DetalheRetorno.NossoNumero = 1

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub LoadArquivoRetornoCNAB400(ByVal iCodigoBancoConta As Integer, _
                                       ByVal oGrid As GridEX, _
                                       ByVal sArquivo As String)
        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim oDataSet As New DataSet
        Dim iBanco As Integer

        Try
            'Verifica o CNPJ/CPF do arquivo
            Dim oStreamReader As New StreamReader(sArquivo)

            'Verifica o arquivo
            Dim sEmpresa As String = oStreamReader.ReadLine.Substring(18, 14)

            'fecha o stream reader para ser usado novamente depois
            oStreamReader.Close()

            'Dim iCodigoEmpresa As Integer
            Try
                iCodigoEmpresa = LoadCodigo("sp_select_administracao_cadastro_basico_empresa_cnpj " & CLng(sEmpresa))
            Catch ex As Exception
                iCodigoEmpresa = -1
            End Try

            If iCodigoEmpresa = -1 Then
                iCodigoEmpresa = goUsuario.iEmpresa
            End If

            'Cria Stream
            Dim oFileStream As New FileStream(sArquivo, System.IO.FileMode.Open)


            'Setando o código do banco para a leitura
            iBanco = LoadCodigo("sp_select_cadastro_basico_codigo_banco_conta " & iCodigoBancoConta & "," & goUsuario.iEmpresa)



            'Instancia o arquivo de retorno
            Dim oArquivoRetorno As New ArquivoRetornoCNAB400



            'Lê o arquivo
            oArquivoRetorno.LerArquivoRetorno(New Banco(iBanco), oFileStream)

            'Fecha Stream
            oFileStream.Close()

            

            'Carregando os dados na grid
            If oGrid.DataSource Is Nothing Then

                'Adicionando uma tabela
                oDataSet.Tables.Add("main")

                'Adicionando as colunas
                oDataSet.Tables(0).Columns.Add("empresa")
                oDataSet.Tables(0).Columns.Add("cnpj_cpf")
                oDataSet.Tables(0).Columns.Add("codigo_empresa")
                oDataSet.Tables(0).Columns.Add("pago")
                oDataSet.Tables(0).Columns.Add("sistema")
                oDataSet.Tables(0).Columns.Add("nosso_numero")
                oDataSet.Tables(0).Columns.Add("numero_documento")
                oDataSet.Tables(0).Columns.Add("competencia")
                oDataSet.Tables(0).Columns.Add("numero_parcela")
                oDataSet.Tables(0).Columns.Add("valor_titulo")
                oDataSet.Tables(0).Columns.Add("valor_pago")
                oDataSet.Tables(0).Columns.Add("valor_residual")
                oDataSet.Tables(0).Columns.Add("sacado")
                oDataSet.Tables(0).Columns.Add("valor_tarifas")
                oDataSet.Tables(0).Columns.Add("desconto")
                oDataSet.Tables(0).Columns.Add("codigo_rejeicao")
                oDataSet.Tables(0).Columns.Add("data_vencimento")
                oDataSet.Tables(0).Columns.Add("data_ocorrencia")
                oDataSet.Tables(0).Columns.Add("juros")
                oDataSet.Tables(0).Columns.Add("tipo_movimento")
                oDataSet.Tables(0).Columns.Add("data_quitacao")
                oDataSet.Tables(0).Columns.Add("nota_fiscal")
                oDataSet.Tables(0).Columns.Add("codigo_titulo_capa")

                'Preenche Valores
                oDataSet.Tables(0).Columns("codigo_empresa").DataType = 0.GetType
                oDataSet.Tables(0).Columns("empresa").DataType = "".GetType
                oDataSet.Tables(0).Columns("sistema").DataType = True.GetType
                oDataSet.Tables(0).Columns("pago").DataType = True.GetType
                oDataSet.Tables(0).Columns("data_quitacao").DataType = Now.GetType
                oDataSet.Tables(0).Columns("data_vencimento").DataType = Now.GetType
                oDataSet.Tables(0).Columns("data_ocorrencia").DataType = Now.GetType
                oDataSet.Tables(0).Columns("valor_titulo").DataType = 0.0.GetType
                oDataSet.Tables(0).Columns("valor_pago").DataType = 0.0.GetType
                oDataSet.Tables(0).Columns("valor_residual").DataType = 0.0.GetType
                oDataSet.Tables(0).Columns("juros").DataType = 0.0.GetType
                oDataSet.Tables(0).Columns("valor_tarifas").DataType = 0.0.GetType
                oDataSet.Tables(0).Columns("desconto").DataType = 0.0.GetType

            Else
                'Copia DataSet Anterior
                oDataSet = CType(oGrid.DataSource.dataset, DataSet).Copy
            End If


            'Agora setando os campos de retorno
            For Each oDetalheRetorno As BoletoNet.DetalheRetorno In oArquivoRetorno.ListaDetalhe

                'Adicionando as linhas
                Dim oDataRow As DataRow = oDataSet.Tables(0).Rows.Add
                Dim sDataVencimento As String = ""
                Dim sTipo As String = ""
                Dim sSerie As String = ""
                Dim sNumeroParcela As String = ""
                Dim sIdentificacao As String = ""
                Dim lCodigoTituloCapa As Long = 0
                Dim sNumeroDocumento As String = ""
                Dim sCompetencia As Date
                Dim sNotaFiscal As String = ""
                Dim bPago As Boolean = False
                Dim sSacado As String = ""

                Try
                    sIdentificacao = oDetalheRetorno.NumeroDocumento.Trim
                    sNumeroParcela = Right(sIdentificacao, 2)
                    sIdentificacao = sIdentificacao.Substring(1, sIdentificacao.Length - 3)
                Catch ex As Exception

                End Try

                'Carrega Dados do Boleto Bancário
                Call LoadDadosBoletoBancarioASCON(oDetalheRetorno.NossoNumero, _
                                                   oDetalheRetorno.ValorTitulo, _
                                                   sDataVencimento, _
                                                 sNumeroParcela, _
                                                 lCodigoTituloCapa, _
                                                 bPago, _
                                                 sSacado, _
                                                 sNumeroDocumento, _
                                                 sCompetencia,
                                                 sNotaFiscal, _
                                                 iCodigoEmpresa)

                oDataRow("nota_fiscal") = sNotaFiscal
                oDataRow("nosso_numero") = oDetalheRetorno.NossoNumero
                oDataRow("numero_parcela") = sNumeroParcela
                oDataRow("codigo_titulo_capa") = lCodigoTituloCapa
                oDataRow("sistema") = IIf(lCodigoTituloCapa = 0, False, True)
                oDataRow("pago") = bPago
                oDataRow("sacado") = sSacado
                oDataRow("numero_documento") = oDetalheRetorno.NumeroDocumento
                oDataRow("valor_titulo") = oDetalheRetorno.ValorTitulo
                oDataRow("valor_pago") = oDetalheRetorno.ValorPrincipal
                If goUsuario.iEmpresa = 1 Then
                    oDataRow("valor_tarifas") = oDetalheRetorno.TarifaCobranca
                Else
                    oDataRow("valor_tarifas") = 0
                End If
                'oDataRow("valor_tarifas") = oDetalheRetorno.TarifaCobranca
                oDataRow("desconto") = oDetalheRetorno.Descontos
                If IsNumeric(oDetalheRetorno.MotivosRejeicao) Then oDataRow("codigo_rejeicao") = oDetalheRetorno.MotivosRejeicao
                oDataRow("data_vencimento") = IIf(Year(oDetalheRetorno.DataVencimento) = 1, IIf(sDataVencimento <> "", sDataVencimento, DBNull.Value), oDetalheRetorno.DataVencimento)
                oDataRow("data_ocorrencia") = oDetalheRetorno.DataOcorrencia
                oDataRow("juros") = IIf(Year(oDetalheRetorno.DataCredito) = 1, 0, oDetalheRetorno.JurosMora)
                oDataRow("valor_residual") = IIf(Year(oDetalheRetorno.DataCredito) = 1, DBNull.Value, (oDetalheRetorno.ValorTitulo - oDetalheRetorno.TarifaCobranca + oDetalheRetorno.JurosMora - oDetalheRetorno.Descontos) - oDetalheRetorno.ValorPrincipal)
                Dim oCodigo As New CodigoMovimento(1, oDetalheRetorno.CodigoOcorrencia)
                oDataRow("tipo_movimento") = CStr(oDetalheRetorno.CodigoOcorrencia) + " - " + oCodigo.Descricao
                oDataRow("data_quitacao") = IIf(Year(oDetalheRetorno.DataCredito) = 1, DBNull.Value, oDetalheRetorno.DataCredito)

                'Insere Registro na Base de Dados
                Call InsertArquivoRetornoLinha(oDataRow)

            Next

            'Configurando os datamembers da grid
            Call ConfigurarDataMemberGrid(oGrid)

            'Referenciando os datamembers
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LoadArquivoRetornoCNAB240(ByVal iCodigoBancoConta As Integer, _
                                       ByVal oGrid As GridEX, _
                                       ByVal sArquivo As String)
        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim oDataSet As New DataSet
        Dim iBanco As Integer
        'Verifica o CNPJ/CPF do arquivo
        Dim oStreamReader As StreamReader
        Try
            'Verifica o CNPJ/CPF do arquivo
            oStreamReader = New StreamReader(sArquivo)

            'Verifica o arquivo
            Dim sEmpresa As String = oStreamReader.ReadLine.Substring(18, 14)
            Dim sEmpresaLogin As String = goUsuario.sEmpresa
            'fecha o stream reader para ser usado novamente depois
            oStreamReader.Close()


            Try
                iCodigoEmpresa = LoadCodigo("sp_select_administracao_cadastro_basico_empresa_cnpj " & CLng(sEmpresa))
                sEmpresa = LoadCodigo("sp_select_administracao_cadastro_basico_empresa_nome_fantasia " & iCodigoEmpresa)

            Catch ex As Exception
                iCodigoEmpresa = goUsuario.iEmpresa
            End Try
            If sEmpresa <> sEmpresaLogin Then
                MsgBox("Não foi possível realizar a importação, o arquivo selecionado corresponde a outra empresa!")
                Exit Sub
            End If
            If iCodigoEmpresa = -1 Then
                iCodigoEmpresa = goUsuario.iEmpresa
            End If

            'Cria Stream
            Dim oFileStream As New FileStream(sArquivo, System.IO.FileMode.Open)


            'Setando o código do banco para a leitura
            iBanco = LoadCodigo("sp_select_cadastro_basico_codigo_banco_conta " & iCodigoBancoConta & "," & goUsuario.iEmpresa)



            'Instancia o arquivo de retorno
            Dim oArquivoRetorno As New ArquivoRetornoCNAB240


            'Lê o arquivo
            oArquivoRetorno.LerArquivoRetorno(New Banco(iBanco), oFileStream)

            'Fecha Stream
            oFileStream.Close()



            'Insere na tab main
            'Call InsertArquivoRetornoCapa(sArquivo)

            'Carregando os dados na grid
            If oGrid.DataSource Is Nothing Then

                'Adicionando uma tabela
                oDataSet.Tables.Add("main")

                'Adicionando as colunas
                oDataSet.Tables(0).Columns.Add("empresa")
                oDataSet.Tables(0).Columns.Add("cnpj_cpf")
                oDataSet.Tables(0).Columns.Add("codigo_empresa")
                oDataSet.Tables(0).Columns.Add("pago")
                oDataSet.Tables(0).Columns.Add("sistema")
                oDataSet.Tables(0).Columns.Add("nosso_numero")
                oDataSet.Tables(0).Columns.Add("numero_documento")
                oDataSet.Tables(0).Columns.Add("numero_documento_boleto")
                oDataSet.Tables(0).Columns.Add("competencia")
                oDataSet.Tables(0).Columns.Add("numero_parcela")
                oDataSet.Tables(0).Columns.Add("valor_titulo")
                oDataSet.Tables(0).Columns.Add("valor_pago")
                oDataSet.Tables(0).Columns.Add("valor_residual")
                oDataSet.Tables(0).Columns.Add("sacado")
                oDataSet.Tables(0).Columns.Add("valor_tarifas")
                oDataSet.Tables(0).Columns.Add("desconto")
                oDataSet.Tables(0).Columns.Add("codigo_rejeicao")
                oDataSet.Tables(0).Columns.Add("data_vencimento")
                oDataSet.Tables(0).Columns.Add("data_ocorrencia")
                oDataSet.Tables(0).Columns.Add("juros")
                oDataSet.Tables(0).Columns.Add("tipo_movimento")
                oDataSet.Tables(0).Columns.Add("data_quitacao")
                oDataSet.Tables(0).Columns.Add("nota_fiscal")
                oDataSet.Tables(0).Columns.Add("codigo_titulo_capa")

                'Preenche Valores
                oDataSet.Tables(0).Columns("codigo_empresa").DataType = 0.GetType
                oDataSet.Tables(0).Columns("empresa").DataType = "".GetType
                oDataSet.Tables(0).Columns("cnpj_cpf").DataType = "".GetType
                oDataSet.Tables(0).Columns("sistema").DataType = True.GetType
                oDataSet.Tables(0).Columns("pago").DataType = True.GetType
                oDataSet.Tables(0).Columns("data_quitacao").DataType = Now.GetType
                oDataSet.Tables(0).Columns("data_vencimento").DataType = Now.GetType
                oDataSet.Tables(0).Columns("data_ocorrencia").DataType = Now.GetType
                oDataSet.Tables(0).Columns("valor_titulo").DataType = 0.0.GetType
                oDataSet.Tables(0).Columns("valor_pago").DataType = 0.0.GetType
                oDataSet.Tables(0).Columns("valor_residual").DataType = 0.0.GetType
                oDataSet.Tables(0).Columns("juros").DataType = 0.0.GetType
                oDataSet.Tables(0).Columns("valor_tarifas").DataType = 0.0.GetType
                oDataSet.Tables(0).Columns("desconto").DataType = 0.0.GetType

            Else
                'Copia DataSet Anterior
                oDataSet = CType(oGrid.DataSource.dataset, DataSet).Copy
            End If


            'Agora setando os campos de retorno
            For Each oDetalheRetorno In oArquivoRetorno.ListaDetalhes

                'Adicionando as linhas
                Dim oDataRow As DataRow = oDataSet.Tables(0).Rows.Add

                Dim sTipo As String = ""
                Dim sSerie As String = ""
                Dim sNumeroParcela As String = ""
                Dim sIdentificacao As String = ""
                Dim lCodigoTituloCapa As Long = 0
                Dim sNumeroDocumento As String = ""
                Dim sCompetencia As String
                Dim sNotaFiscal As String = ""
                Dim bPago As Boolean = False
                Dim sSacado As String = ""
                Dim sDataVencimento As String = ""

                'Try
                '    sIdentificacao = oDetalheRetorno.SegmentoT.NumeroDocumento.Trim
                '    sNumeroParcela = Right(sIdentificacao, 2)
                '    sIdentificacao = sIdentificacao.Substring(1, sIdentificacao.Length - 3)
                'Catch ex As Exception

                'End Try

                If iBanco = 104 And oDetalheRetorno.SegmentoT.NossoNumero.Trim.Length > 0 Then
                    oDetalheRetorno.SegmentoT.NossoNumero = oDetalheRetorno.SegmentoT.NossoNumero.Trim
                    oDetalheRetorno.SegmentoT.NossoNumero = Left(oDetalheRetorno.SegmentoT.NossoNumero, Len(oDetalheRetorno.SegmentoT.NossoNumero) - 1)
                End If

                Call LoadDadosBoletoBancarioASCON(oDetalheRetorno.SegmentoT.NossoNumero, _
                                                  oDetalheRetorno.SegmentoT.ValorTitulo, _
                                                  sDataVencimento, _
                                                sNumeroParcela, _
                                                lCodigoTituloCapa, _
                                                bPago, _
                                                sSacado, _
                                                sNumeroDocumento, _
                                                sCompetencia,
                                                sNotaFiscal, _
                                                iCodigoEmpresa)


                oDataRow("numero_documento_boleto") = oDetalheRetorno.SegmentoT.NumeroDocumento.Trim
                oDataRow("nosso_numero") = oDetalheRetorno.SegmentoT.NossoNumero
                oDataRow("empresa") = sEmpresa
                oDataRow("codigo_empresa") = iCodigoEmpresa
                oDataRow("cnpj_cpf") = oDetalheRetorno.SegmentoT.NumeroInscricao
                oDataRow("numero_documento") = oDetalheRetorno.SegmentoT.NumeroDocumento

                If lCodigoTituloCapa <> 0 Then
                    oDataRow("sistema") = True
                    oDataRow("numero_parcela") = sNumeroParcela
                    oDataRow("codigo_titulo_capa") = lCodigoTituloCapa
                    oDataRow("nota_fiscal") = sNotaFiscal
                    oDataRow("pago") = bPago
                    oDataRow("sacado") = sSacado
                    oDataRow("numero_documento") = sNumeroDocumento
                    oDataRow("competencia") = sCompetencia
                Else
                    oDataRow("sistema") = False
                    oDataRow("pago") = bPago
                End If



                oDataRow("valor_titulo") = oDetalheRetorno.SegmentoT.ValorTitulo
                oDataRow("valor_pago") = oDetalheRetorno.SegmentoU.ValorPagoPeloSacado
                If goUsuario.iEmpresa = 1 Then
                    oDataRow("valor_tarifas") = oDetalheRetorno.SegmentoT.ValorTarifas
                Else
                    oDataRow("valor_tarifas") = 0
                End If

                oDataRow("desconto") = oDetalheRetorno.SegmentoU.ValorDescontoConcedido
                If IsNumeric(oDetalheRetorno.SegmentoW.CodigoErro) Then
                    If oDetalheRetorno.SegmentoW.CodigoErro <> 0 Then
                        oDataRow("codigo_rejeicao") = oDetalheRetorno.SegmentoW.CodigoErro
                    End If
                End If

                'oDataRow("data_vencimento") = IIf(Year(oDetalheRetorno.SegmentoT.DataVencimento) = 1, DBNull.Value, oDetalheRetorno.SegmentoT.DataVencimento)
                oDataRow("data_vencimento") = IIf(Year(oDetalheRetorno.SegmentoT.DataVencimento) = 1, IIf(sDataVencimento <> "", sDataVencimento, DBNull.Value), oDetalheRetorno.SegmentoT.DataVencimento)
                oDataRow("data_ocorrencia") = oDetalheRetorno.SegmentoU.DataOcorrencia
                oDataRow("juros") = IIf(Year(oDetalheRetorno.SegmentoU.DataCredito) = 1, 0, oDetalheRetorno.SegmentoU.JurosMultaEncargos)
                oDataRow("valor_residual") = IIf(Year(oDetalheRetorno.SegmentoU.DataCredito) = 1, DBNull.Value, (oDetalheRetorno.SegmentoT.ValorTitulo - oDetalheRetorno.SegmentoU.JurosMultaEncargos - oDetalheRetorno.SegmentoU.ValorDescontoConcedido) - oDetalheRetorno.SegmentoU.ValorPagoPeloSacado)
                'Dim oCodigo As New CodigoMovimento(1, oDetalheRetorno.SegmentoU.CodigoOcorrenciaSacado)
                'oDataRow("tipo_movimento") = CStr(oDetalheRetorno.SegmentoU.CodigoOcorrenciaSacado) + " - " + oCodigo.Descricao
                oDataRow("tipo_movimento") = oDetalheRetorno.SegmentoT.CodigoMovimento.Descricao
                oDataRow("data_quitacao") = IIf(Year(oDetalheRetorno.SegmentoU.DataCredito) = 1, DBNull.Value, oDetalheRetorno.SegmentoU.DataCredito)

                InsertArquivoRetornoLinha(oDataRow)

            Next

            'Configurando os datamembers da grid
            Call ConfigurarDataMemberGrid(oGrid)

            'Referenciando os datamembers
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()


        Catch ex As Exception
            oStreamReader.Close()
            oStreamReader.Dispose()
            Throw ex
        End Try
    End Sub

    Public Sub LoadArquivoRetorno(ByVal iCodigoBancoConta As Integer, _
                                  ByVal oGrid As GridEX, _
                                  ByVal sArquivo As String)

        Try
            Dim iCNAB As Integer = LoadCodigo("sp_select_configuracao_boleto_bancario_cnab " & iCodigoBancoConta & "," & goUsuario.iEmpresa)

            If iCNAB = 400 Then
                LoadArquivoRetornoCNAB400(iCodigoBancoConta, oGrid, sArquivo)
            Else
                LoadArquivoRetornoCNAB240(iCodigoBancoConta, oGrid, sArquivo)
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub SalvarRetorno(ByVal oGrid As GridEX, _
                             ByVal iCodigoBancoConta As Integer)

        'Variaveis Locais
        Dim oSqlParameter(11) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow In oGrid.GetRows

                If oRow.Cells.Item("sistema").Value = True _
                    And oRow.Cells.Item("pago").Value = False _
                    And oRow.Cells.Item("valor_pago").Value > 0 _
                    And IsDBNull(oRow.Cells.Item("data_quitacao").Value) = False Then

                    i = 0

                    'Seta Parametros - Código
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_titulo_capa"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                    oSqlParameter(i).Value = oRow.Cells.Item("codigo_titulo_capa").Value : i += 1

                    'Seta Parametros - Código Empresa
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_empresa"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                    oSqlParameter(i).Value = oRow.Cells.Item("codigo_empresa").Value : i += 1

                    'Seta Parametros - Número Parcela
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "numero_parcela"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.Int
                    oSqlParameter(i).Value = oRow.Cells.Item("numero_parcela").Value : i += 1

                    'Seta Parametros - Código Banco Conta
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_banco_conta"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                    oSqlParameter(i).Value = iCodigoBancoConta : i += 1

                    'Seta Parametros - Código Tipo Documento Pagamento
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_tipo_documento_pagamento"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                    oSqlParameter(i).Value = TipoDocumentoPagamento.BoletoBancario : i += 1

                    'Seta Parametros - Número Documento
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "numero_documento"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                    oSqlParameter(i).Size = 100
                    oSqlParameter(i).Value = oRow.Cells.Item("numero_documento").Value.ToString.Trim : i += 1

                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "data_pagamento"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.Date
                    oSqlParameter(i).Value = oRow.Cells.Item("data_quitacao").Value : i += 1

                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "valor"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.Float
                    oSqlParameter(i).Value = oRow.Cells.Item("valor_pago").Value : i += 1

                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "valor_tarifas"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.Float
                    oSqlParameter(i).Value = oRow.Cells.Item("valor_tarifas").Value : i += 1

                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "juros"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.Float
                    oSqlParameter(i).Value = oRow.Cells.Item("juros").Value : i += 1

                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "data_ocorrencia"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                    oSqlParameter(i).Value = oRow.Cells.Item("data_ocorrencia").Value : i += 1

                    'Seta Parametros - Código Usuário
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_usuario"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.Int
                    oSqlParameter(i).Value = goUsuario.iUsuario

                    'Executa Query
                    ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_titulo_parcela_pagamento_individual", oSqlParameter)

                End If

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosBoletoBancarioASCON(ByVal sNossoNumero As String, _
                                            ByVal dValor As Double, _
                                            ByVal sDataVencimento As String, _
                                            ByRef sNumeroParcela As String, _
                                            ByRef lCodigoTituloCapa As Long, _
                                            ByRef bPago As Boolean, _
                                            ByRef sSacado As String, _
                                            ByRef sNumeroDocumento As String, _
                                            ByRef sCompetencia As String, _
                                            ByRef sNotaFiscal As String, _
                                            ByVal iCodigoEmpresa As Integer)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nosso_numero"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNossoNumero.Trim : i += 1

            'Seta Parametros - Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValor : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_titulo_boleto_bancario_dados_ASCON", oSqlParameter)
            If oSqlDataReader.HasRows = False Then
                bPago = False
                lCodigoTituloCapa = 0
            End If
            While oSqlDataReader.Read

                sDataVencimento = oSqlDataReader.Item("data_vencimento")
                sNumeroParcela = oSqlDataReader.Item("numero_parcela")
                lCodigoTituloCapa = oSqlDataReader.Item("codigo_titulo_capa")
                bPago = oSqlDataReader.Item("pago")
                sSacado = oSqlDataReader.Item("sacado")
                sNossoNumero = oSqlDataReader.Item("nosso_numero")
                sNumeroDocumento = oSqlDataReader.Item("numero_documento")
                sCompetencia = oSqlDataReader.Item("competencia")
                sNotaFiscal = If(IsDBNull(oSqlDataReader.Item("nota_fiscal")), "", oSqlDataReader.Item("nota_fiscal"))

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosBoletoBancarioASCONErrata(ByVal sNossoNumero As String, _
                                                  ByVal dDataVencimento As Date, _
                                          ByVal dValor As Double, _
                                          ByVal sDataVencimento As String, _
                                     ByRef sNumeroParcela As String, _
                                     ByRef lCodigoTituloCapa As Long, _
                                     ByRef bPago As Boolean, _
                                     ByRef sSacado As String, _
                                     ByRef sNumeroDocumento As String, _
                                     ByRef sNotaFiscal As String, _
                                     ByVal iCodigoEmpresa As Integer)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nosso_numero"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNossoNumero.Trim : i += 1

            'Seta Parametros - Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValor : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDataVencimento : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_titulo_boleto_bancario_dados_ASCON_errata", oSqlParameter)
            If oSqlDataReader.HasRows = False Then
                bPago = False
                lCodigoTituloCapa = 0
            End If
            While oSqlDataReader.Read

                sDataVencimento = oSqlDataReader.Item("data_vencimento")
                sNumeroParcela = oSqlDataReader.Item("numero_parcela")
                lCodigoTituloCapa = oSqlDataReader.Item("codigo_titulo_capa")
                bPago = oSqlDataReader.Item("pago")
                sSacado = oSqlDataReader.Item("sacado")
                sNossoNumero = oSqlDataReader.Item("nosso_numero")
                sNumeroDocumento = oSqlDataReader.Item("numero_documento")
                sNotaFiscal = If(IsDBNull(oSqlDataReader.Item("nota_fiscal")), "", oSqlDataReader.Item("nota_fiscal"))

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

#Region "::: HISTÓRICO :::"

    Public Sub LoadGridHistorico(ByVal oGrid As GridEX, _
                               ByVal sDataInicio As String, _
                               ByVal sDataTermino As String, _
                               ByVal iCodigoEmpresa As Integer)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim oDataSet As DataSet
        Dim i As Integer = 0

        Try

            'Seta Parametros - Data Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataInicio = "", DBNull.Value, sDataInicio) : i += 1

            'Seta Parametros - Data Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataTermino = "", DBNull.Value, sDataTermino) : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoEmpresa : i += 1



            'Executa Quety
            oDataSet = SQLHelper.ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_integracao_conciliacao_bancaria_historico", oSqlParameter)

            'Confiura os data members
            ConfigurarDataMemberGrid(oGrid)

            Dim oParent(1) As DataColumn
            Dim oChildren(1) As DataColumn

            oParent(0) = oDataSet.Tables(0).Columns("codigo")
            oParent(1) = oDataSet.Tables(0).Columns("codigo_empresa")

            oChildren(0) = oDataSet.Tables(1).Columns("codigo_arquivo_retorno_capa")
            oChildren(1) = oDataSet.Tables(1).Columns("codigo_empresa")

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oParent, oChildren)

            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName


        Catch Sqlex As SqlException
            Throw Sqlex
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteHistorico(ByVal lCodigo As Long, _
                                   ByVal iCodigoEmpresa As Integer)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
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
            oSqlParameter(i).Value = iCodigoEmpresa : i += 1



            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_integracao_arquivo_retorno_capa", oSqlParameter)



        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class


