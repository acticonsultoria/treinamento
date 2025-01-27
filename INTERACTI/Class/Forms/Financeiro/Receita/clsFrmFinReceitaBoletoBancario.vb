Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.html.simpleparser
Imports ImagePDF
Imports BoletoNet
Imports System.IO
Imports System.Text

Public Class clsFrmFinReceitaBoletoBancario

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGridParcela(ByVal oGrid As GridEX, _
                               ByVal lCodigoTituloCapa As Long, _
                               ByVal iNumeroParcela As Integer, _
                               ByVal iContaBancaria As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Título Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoTituloCapa : i += 1

            'Seta Parametros - Número da Parcela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iNumeroParcela : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Conta Bancária
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco_conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iContaBancaria

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_titulo_boleto_bancario", oSqlParameter)

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

    Public Function LoadValorTotal(ByVal lCodigoTituloCapa As Long, _
                                   ByVal iNumeroParcela As Integer) As Double

        'Variaveis Locais
        Dim dResult As Double
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Título Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoTituloCapa : i += 1

            'Seta Parametros - Número da Parcela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iNumeroParcela : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            dResult = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_titulo_boleto_bancario_total", oSqlParameter)

            Return dResult

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub InsertBoletoBancario(ByVal lCodigoTituloCapa As Long, _
                                    ByVal iNumeroParcela As Integer, _
                                    ByVal sDataVencimento As String, _
                                    ByVal dValor As Double, _
                                    ByVal iCodigoBancoConta As Integer, _
                                    ByVal sCarteira As String, _
                                    ByVal bPago As Boolean, _
                                    ByVal dJuros As Double, _
                                    ByVal dMulta As Double)

        'Variaveis Locais
        Dim oSqlParameter(10) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Título Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoTituloCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Número Parcela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iNumeroParcela : i += 1

            'Seta Parametros - Data Vencimento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataVencimento : i += 1

            'Seta Parametros - Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValor : i += 1

            'Seta Parametros - Código Banco Conta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco_conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoBancoConta : i += 1

            'Seta Parametros - Carteira
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "carteira"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCarteira : i += 1

            'Seta Parametros - Pago
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pago"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bPago : i += 1

            'Seta Parametros - Juros
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "juros"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dJuros : i += 1

            'Seta Parametros - Multa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "multa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMulta : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financerio_titulo_parcela_boleto_bancario", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertBoletoBancario(ByVal lCodigoTituloCapa As Long, _
                                    ByVal iNumeroParcela As Integer, _
                                    ByVal sDataVencimento As String, _
                                    ByVal dValor As Double, _
                                    ByVal iCodigoBancoConta As Integer, _
                                    ByVal sCarteira As String, _
                                    ByVal bPago As Boolean, _
                                    ByVal dJuros As Double, _
                                    ByVal dMulta As Double, _
                                    ByRef iCodigoBanco As Integer, _
                                    ByRef sAgencia As String, _
                                    ByRef sConta As String, _
                                    ByRef sDigitoConta As String, _
                                    ByRef sNossoNumero As String, _
                                    ByRef sCNPJSacado As String, _
                                    ByRef sRazaoSocialSacado As String, _
                                    ByRef sBairroSacado As String, _
                                    ByRef sCidadeSacado As String, _
                                    ByRef sCEPSacado As String, _
                                    ByRef sUFSacado As String, _
                                    ByRef sLogradouroSacado As String, _
                                    ByRef sNumeroSacado As String, _
                                    ByRef sComplementoSacado As String, _
                                    ByRef sCodigoInstrucao1 As String, _
                                    ByRef sCodigoInstrucao2 As String, _
                                    ByRef sCodigoInstrucao3 As String, _
                                    ByRef sInstrucao1 As String, _
                                    ByRef sInstrucao2 As String, _
                                    ByRef sInstrucao3 As String, _
                                    ByRef iNumeroDias1 As Integer, _
                                    ByRef iNumeroDias2 As Integer, _
                                    ByRef iNumeroDias3 As Integer, _
                                    ByRef sConvenio As String)

        'Variaveis Locais
        Dim oSqlParameter(34) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Título Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoTituloCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Número Parcela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iNumeroParcela : i += 1

            'Seta Parametros - Data Vencimento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataVencimento : i += 1

            'Seta Parametros - Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValor : i += 1

            'Seta Parametros - Código Banco Conta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco_conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoBancoConta : i += 1

            'Seta Parametros - Carteira
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "carteira"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCarteira : i += 1

            'Seta Parametros - Juros
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "juros"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dJuros : i += 1

            'Seta Parametros - Multa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "multa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMulta : i += 1

            'Seta Parametros - Pago
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pago"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bPago : i += 1

            'Seta Parametros - Código Banco
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.Int : i += 1

            'Seta Parametros - Agência
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "agencia"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10 : i += 1

            'Seta Parametros - Conta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "conta"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10 : i += 1

            'Seta Parametros - Dígito Conta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "digito_conta"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2 : i += 1


            If bSistemaPerforma = True Then
                'Seta Parametros - Código Banco
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "nosso_numero"
                oSqlParameter(i).Direction = ParameterDirection.Output
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 100 : i += 1

            Else
                'Seta Parametros - Código Banco
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "nosso_numero"
                oSqlParameter(i).Direction = ParameterDirection.Output
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt : i += 1


            End If

            'Seta Parametros - CNPJ Sacado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnpj_sacado"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20 : i += 1

            'Seta Parametros - Razão Social Sacado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "razao_social_sacado"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60 : i += 1

            'Seta Parametros - Bairro Sacado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "bairro_sacado"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60 : i += 1

            'Seta Parametros - Cidade Sacado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cidade_sacado"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60 : i += 1

            'Seta Parametros - CEP Sacado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cep_sacado"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10 : i += 1

            'Seta Parametros - UF Sacado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf_sacado"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2 : i += 1

            'Seta Parametros - Logradouro Sacado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "logradouro_sacado"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60 : i += 1

            'Seta Parametros - Número Sacado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_sacado"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60 : i += 1

            'Seta Parametros - Complemento Sacado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "complemento_sacado"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60 : i += 1

            'Seta Parametros - Codigo Instrução 1
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_instrucao1"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2 : i += 1

            'Seta Parametros - Codigo Instrução 2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_instrucao2"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2 : i += 1

            'Seta Parametros - Codigo Instrução 3
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_instrucao3"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2 : i += 1

            'Seta Parametros - Instrução 1
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "instrucao1"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100 : i += 1

            'Seta Parametros - Instrução 2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "instrucao2"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100 : i += 1

            'Seta Parametros - Instrução 3
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "instrucao3"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100 : i += 1

            'Seta Parametros - Número de Dias 1
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_dias1"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt : i += 1

            'Seta Parametros - Número de Dias 2
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_dias2"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt : i += 1

            'Seta Parametros - Número de Dias 3
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_dias3"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt : i += 1

            'Seta Parametros - Convenio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "convenio"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 9 : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financerio_titulo_parcela_boleto_bancario_dll", oSqlParameter)

            iCodigoBanco = oSqlParameter(10).Value
            sAgencia = oSqlParameter(11).Value
            sConta = oSqlParameter(12).Value
            sDigitoConta = oSqlParameter(13).Value
            sNossoNumero = oSqlParameter(14).Value.ToString
            sCNPJSacado = oSqlParameter(15).Value.ToString
            sRazaoSocialSacado = oSqlParameter(16).Value.ToString
            sBairroSacado = oSqlParameter(17).Value.ToString
            sCidadeSacado = oSqlParameter(18).Value.ToString
            sCEPSacado = oSqlParameter(19).Value.ToString
            sUFSacado = oSqlParameter(20).Value.ToString
            sLogradouroSacado = oSqlParameter(21).Value.ToString
            sNumeroSacado = oSqlParameter(22).Value.ToString
            sComplementoSacado = oSqlParameter(23).Value.ToString
            sCodigoInstrucao1 = oSqlParameter(24).Value.ToString
            sCodigoInstrucao2 = oSqlParameter(25).Value.ToString
            sCodigoInstrucao3 = oSqlParameter(26).Value.ToString
            sInstrucao1 = oSqlParameter(27).Value.ToString
            sInstrucao2 = oSqlParameter(28).Value.ToString
            sInstrucao3 = oSqlParameter(29).Value.ToString
            iNumeroDias1 = oSqlParameter(30).Value.ToString
            iNumeroDias2 = oSqlParameter(31).Value.ToString
            iNumeroDias3 = oSqlParameter(32).Value.ToString
            sConvenio = oSqlParameter(33).Value.ToString

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadArquivoBoleto(ByVal sCodigoTituloCapa As String, _
                                 ByVal sNotaConcatenado As String, _
                                 ByRef sArquivo As String, _
                                 Optional ByVal iParcela As Integer = -1, _
                                 Optional ByVal iCodigoEmpresa As Integer = -1)

        If iCodigoEmpresa = -1 Then
            iCodigoEmpresa = goUsuario.iEmpresa
        End If

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim sNotaFiscal As String = ""
        Dim i As Integer = 0
        Dim lBoleto As New List(Of BoletoBancario)
        Try

            'Carrega Dados - Emitente
            Call LoadDadosEmitente()

            'Dim lCodigoTituloCapa As Long

            Dim oVetor() As String = sCodigoTituloCapa.Split(",")
            Dim oNumeroDocumento() As String = sNotaConcatenado.Split("$")

            For iVetor As Integer = 0 To oVetor.Count - 1
                i = 0
                'Seta Parametros - Código Título Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_titulo_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                If oVetor(iVetor).Contains("|") Then
                    oSqlParameter(i).Value = oVetor(iVetor).Split("|")(0) : i += 1
                Else
                    oSqlParameter(i).Value = oVetor(iVetor) : i += 1
                End If

                ''Seta Parametros - Código Título Capa
                'oSqlParameter(i) = New SqlParameter
                'oSqlParameter(i).ParameterName = "codigo_titulo_capa"
                'oSqlParameter(i).Direction = ParameterDirection.Input
                'oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                'oSqlParameter(i).Value = sCodigoTituloCapa

                'Seta Parametros - Parcela
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "parcela"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = iParcela : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                If oVetor(iVetor).Contains("|") Then
                    oSqlParameter(i).Value = oVetor(iVetor).Split("|")(1)
                Else
                    oSqlParameter(i).Value = iCodigoEmpresa
                End If

                'Executa Query
                oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financerio_titulo_parcela_boleto_bancario_arquivo", oSqlParameter)

                If oSqlDataReader.HasRows = True Then

                    'Váriavel - Boleto
                    sNotaFiscal = oNumeroDocumento(iVetor)

                    Dim oBoletoBancario As BoletoBancario
                    Dim oInstrucao1 As Instrucao
                    Dim oInstrucao2 As Instrucao
                    Dim oInstrucao3 As Instrucao
                    Dim oCedente As Cedente

                    While oSqlDataReader.Read

                        sNotaFiscal = Replace(sNotaFiscal, "/", "_")

                        'Seta Váriavel 
                        oBoletoBancario = New BoletoBancario

                        'Seta Codigo do Banco
                        oBoletoBancario.CodigoBanco = oSqlDataReader.Item("codigo_banco")

                        If oSqlDataReader.Item("digito_conta") = "" Then
                            oCedente = New Cedente(oSqlDataReader.Item("cnpj_empresa"), oSqlDataReader.Item("razao_social_empresa") & "<br>" & oSqlDataReader.Item("logradouro_empresa") & ", " & oSqlDataReader.Item("numero_empresa") & " - " & oSqlDataReader.Item("bairro_empresa"), oSqlDataReader.Item("agencia"), oSqlDataReader.Item("conta"))
                        Else
                            If Len(oSqlDataReader.Item("agencia")) = 5 Then
                                oCedente = New Cedente(oSqlDataReader.Item("cnpj_empresa"), oSqlDataReader.Item("razao_social_empresa") & "<br>" & oSqlDataReader.Item("logradouro_empresa") & ", " & oSqlDataReader.Item("numero_empresa") & " - " & oSqlDataReader.Item("bairro_empresa"), Mid(oSqlDataReader.Item("agencia"), 1, 4), Mid(oSqlDataReader.Item("agencia"), 5, 1), oSqlDataReader.Item("conta"), oSqlDataReader.Item("digito_conta"))
                            Else
                                oCedente = New Cedente(oSqlDataReader.Item("cnpj_empresa"), oSqlDataReader.Item("razao_social_empresa") & "<br>" & oSqlDataReader.Item("logradouro_empresa") & ", " & oSqlDataReader.Item("numero_empresa") & " - " & oSqlDataReader.Item("bairro_empresa"), oSqlDataReader.Item("agencia"), oSqlDataReader.Item("conta"), oSqlDataReader.Item("digito_conta"))
                            End If
                        End If

                        If oSqlDataReader.Item("convenio") = "" Then

                            oCedente.Convenio = 111111
                        Else
                            oCedente.Convenio = oSqlDataReader.Item("convenio")

                        End If

                        If CInt(oSqlDataReader.Item("codigo_banco")) = 33 Then
                            oCedente.Codigo = oSqlDataReader.Item("convenio")
                        ElseIf CInt(oSqlDataReader.Item("codigo_banco")) = 104 Then
                            oCedente.Codigo = oSqlDataReader.Item("convenio")
                        End If

                        If oSqlDataReader.Item("codigo_banco") = 341 Then
                            oCedente.ContaBancaria.Conta = CInt(oCedente.ContaBancaria.Conta)
                        End If

                        Dim oBoleto As New Boleto(oSqlDataReader.Item("data_vencimento"), oSqlDataReader.Item("valor"), oSqlDataReader.Item("carteira"), oSqlDataReader.Item("nosso_numero"), oCedente, New EspecieDocumento(oSqlDataReader.Item("codigo_banco"), 1))


                        oBoleto.NossoNumero = oSqlDataReader.Item("nosso_numero")


                        If oSqlDataReader.Item("nosso_numero").ToString.Length = 17 Then
                            oBoleto.NumeroDocumento = Right(oSqlDataReader.Item("nosso_numero").ToString, 10)
                        ElseIf oBoletoBancario.CodigoBanco = "748" Then
                            oBoleto.NossoNumero = Format(oSqlDataReader.Item("data_emissao"), "yy") + "2" + sNotaFiscal.PadLeft(4, "0") + CStr(oSqlDataReader.Item("numero_parcela"))
                            oBoleto.NumeroDocumento = sNotaFiscal + "-" + CStr(oSqlDataReader.Item("numero_parcela"))
                            oCedente.ContaBancaria.OperacaConta = oSqlDataReader.Item("conta") + oSqlDataReader.Item("digito_conta")
                        End If

                        oBoleto.Sacado = New Sacado(oSqlDataReader.Item("cnpj_sacado"), oSqlDataReader.Item("razao_social_sacado"))
                        oBoleto.Sacado.Endereco.End = oSqlDataReader.Item("logradouro_sacado") & ", " & oSqlDataReader.Item("numero_sacado") & IIf(oSqlDataReader.Item("complemento_sacado") = "", "", " - " & oSqlDataReader.Item("complemento_sacado"))
                        oBoleto.Sacado.Endereco.Bairro = oSqlDataReader.Item("bairro_sacado")
                        oBoleto.Sacado.Endereco.Cidade = oSqlDataReader.Item("cidade_sacado")
                        oBoleto.Sacado.Endereco.CEP = oSqlDataReader.Item("cep_sacado")
                        oBoleto.Sacado.Endereco.UF = oSqlDataReader.Item("uf_sacado")
                        oBoleto.Sacado.Endereco.Logradouro = oSqlDataReader.Item("logradouro_sacado")
                        oBoleto.Sacado.Endereco.Numero = oSqlDataReader.Item("numero_sacado")
                        oBoleto.Sacado.Endereco.Complemento = oSqlDataReader.Item("complemento_sacado")

                        If (oSqlDataReader.Item("codigo_banco") = "0001") Then
                            oBoleto.EspecieDocumento = New EspecieDocumento(oSqlDataReader.Item("codigo_banco"), 2)
                        ElseIf oBoletoBancario.CodigoBanco = "748" Then
                            oBoleto.EspecieDocumento.Sigla = "DMI"
                        ElseIf oBoletoBancario.CodigoBanco = "104" Then
                            oBoleto.EspecieDocumento.Sigla = "DS"
                        End If


                        If bSistemaPerforma = True Then

                            oBoleto.NumeroDocumento = oSqlDataReader.Item("numero_documento").ToString
                            oCedente.ContaBancaria.Conta = CInt(oCedente.ContaBancaria.Conta)
                            'oCedente.Codigo = CInt(oCedente.ContaBancaria.Conta)
                        End If





                        'Instrução 1
                        If oSqlDataReader.Item("instrucao1") <> "" Then
                            oInstrucao1 = New Instrucao(oSqlDataReader.Item("codigo_banco"))
                            oInstrucao1.Codigo = oSqlDataReader.Item("instrucao1")
                            If oSqlDataReader.Item("numero_dias1") > -1 Then oInstrucao1.QuantidadeDias = oSqlDataReader.Item("numero_dias1")
                            oInstrucao1.Descricao = oSqlDataReader.Item("descricao_instrucao1")
                            oBoleto.Instrucoes.Add(oInstrucao1)
                        End If

                        'Instrução 2
                        If oSqlDataReader.Item("instrucao2") <> "" Then
                            oInstrucao2 = New Instrucao(oSqlDataReader.Item("codigo_banco"))
                            oInstrucao2.Codigo = oSqlDataReader.Item("instrucao2")
                            If oSqlDataReader.Item("numero_dias2") > -1 Then oInstrucao2.QuantidadeDias = oSqlDataReader.Item("numero_dias2")
                            oInstrucao2.Descricao = oSqlDataReader.Item("descricao_instrucao2")
                            oBoleto.Instrucoes.Add(oInstrucao2)
                        End If

                        'Instrução 3
                        If oSqlDataReader.Item("instrucao3") <> "" Then
                            oInstrucao3 = New Instrucao(oSqlDataReader.Item("codigo_banco"))
                            oInstrucao3.Codigo = oSqlDataReader.Item("instrucao3")
                            If oSqlDataReader.Item("numero_dias3") > -1 Then oInstrucao3.QuantidadeDias = oSqlDataReader.Item("numero_dias3")
                            oInstrucao3.Descricao = oSqlDataReader.Item("descricao_instrucao3")
                            oBoleto.Instrucoes.Add(oInstrucao3)
                        End If

                        oBoletoBancario.Boleto = oBoleto
                        oBoletoBancario.Boleto.Valida()

                        If oBoletoBancario.CodigoBanco <> "748" And bSistemaPerforma = False Then

                            oBoletoBancario.Boleto.NumeroDocumento = sNotaFiscal
                        End If

                        If bSistemaPerforma = True Then

                            'oBoleto.NumeroDocumento = txtNumeroDocumento.Text + "-" +  CStr(oSqlDataReader.Item("numero_parcela").ToString.PadLeft(2,"0")
                            ExecuteQuery("sp_update_financeiro_titulo_boleto " & CStr(goUsuario.iEmpresa) & "," & _
                                                                                 CStr(oSqlDataReader.Item("codigo_titulo_capa")) & "," & _
                                                                                 oSqlDataReader.Item("numero_parcela").ToString.PadLeft(2, "0") & ",'" & _
                                                                                 oBoletoBancario.Boleto.NossoNumero & "','" & _
                                                                                 oBoletoBancario.Boleto.CodigoBarra.LinhaDigitavel & "','" & _
                                                                                 oBoletoBancario.Boleto.CodigoBarra.Codigo & "'", goDatabase.sConnection)
                        End If


                        'Formatação específica do sicredi
                        If oBoletoBancario.CodigoBanco = "748" Then

                            oBoletoBancario.Boleto.NossoNumero = Left(oBoletoBancario.Boleto.NossoNumero, 2) + _
                                                                "/" + _
                                                                Mid(oBoletoBancario.Boleto.NossoNumero, 3, 6) + _
                                                                "-" + _
                                                                Right(oBoletoBancario.Boleto.NossoNumero, 1)


                        End If

                        If oBoletoBancario.Banco.Codigo = "033" Or oBoletoBancario.Banco.Codigo = "237" Then
                            oBoletoBancario.OcultarInstrucoes = True
                        End If

                        lBoleto.Add(oBoletoBancario)


                        If oVetor.Count = 1 Then

                            'Gera Boleto Bancario
                            Call GeraLayoutBoletoBancario(sNotaFiscal & "_" & oSqlDataReader.Item("numero_parcela"), lBoleto, sArquivo)

                        End If


                    End While

                End If

                'Fecha o SqlDataReader
                If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close() : oSqlDataReader = Nothing

            Next

            'Gera Boleto Bancario
            Call GeraLayoutBoletoBancario("", lBoleto, sArquivo)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadArquivoBoletoLote(ByVal sCodigoTituloCapa As String, _
                                     ByVal sDiretorio As String, _
                                     ByRef sArquivo As String, _
                                     ByVal bHTML As Boolean)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Carrega Dados - Emitente
            Call LoadDadosEmitente()

            'Seta Parametros - Código Título Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCodigoTituloCapa : i += 1


            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa



            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financerio_titulo_parcela_boleto_bancario_arquivo_lote", oSqlParameter)

            If oSqlDataReader.HasRows = True Then

                'Váriavel - Boleto
                Dim lBoleto As New List(Of BoletoBancario)
                Dim oBoletoBancario As BoletoBancario
                Dim oInstrucao1 As Instrucao
                Dim oInstrucao2 As Instrucao
                Dim oInstrucao3 As Instrucao
                Dim oCedente As Cedente

                While oSqlDataReader.Read


                    'Seta Váriavel 
                    oBoletoBancario = New BoletoBancario

                    'Seta Codigo do Banco
                    oBoletoBancario.CodigoBanco = oSqlDataReader.Item("codigo_banco")

                    If oSqlDataReader.Item("digito_conta") = "" Then
                        oCedente = New Cedente(oSqlDataReader.Item("cnpj_empresa"), oSqlDataReader.Item("razao_social_empresa") & "<br>" & oSqlDataReader.Item("logradouro_empresa") & ", " & oSqlDataReader.Item("numero_empresa") & " - " & oSqlDataReader.Item("bairro_empresa"), oSqlDataReader.Item("agencia"), oSqlDataReader.Item("conta"))
                    Else
                        If Len(oSqlDataReader.Item("agencia")) = 5 Then
                            oCedente = New Cedente(oSqlDataReader.Item("cnpj_empresa"), oSqlDataReader.Item("razao_social_empresa") & "<br>" & oSqlDataReader.Item("logradouro_empresa") & ", " & oSqlDataReader.Item("numero_empresa") & " - " & oSqlDataReader.Item("bairro_empresa"), Mid(oSqlDataReader.Item("agencia"), 1, 4), Mid(oSqlDataReader.Item("agencia"), 5, 1), oSqlDataReader.Item("conta"), oSqlDataReader.Item("digito_conta"))
                        Else
                            oCedente = New Cedente(oSqlDataReader.Item("cnpj_empresa"), oSqlDataReader.Item("razao_social_empresa") & "<br>" & oSqlDataReader.Item("logradouro_empresa") & ", " & oSqlDataReader.Item("numero_empresa") & " - " & oSqlDataReader.Item("bairro_empresa"), oSqlDataReader.Item("agencia"), oSqlDataReader.Item("conta"), oSqlDataReader.Item("digito_conta"))
                        End If
                    End If

                    If oSqlDataReader.Item("convenio") = "" Then

                        oCedente.Convenio = 111111
                    Else
                        oCedente.Convenio = oSqlDataReader.Item("convenio")

                    End If

                    If CInt(oSqlDataReader.Item("codigo_banco")) = 33 Then
                        oCedente.Codigo = oSqlDataReader.Item("convenio")
                    ElseIf CInt(oSqlDataReader.Item("codigo_banco")) = 104 Then
                        oCedente.Codigo = oSqlDataReader.Item("convenio")
                    End If

                    If oSqlDataReader.Item("codigo_banco") = 341 Then
                        oCedente.ContaBancaria.Conta = CInt(oCedente.ContaBancaria.Conta)
                    End If

                    Dim oBoleto As New Boleto(oSqlDataReader.Item("data_vencimento"), oSqlDataReader.Item("valor"), oSqlDataReader.Item("carteira"), oSqlDataReader.Item("nosso_numero"), oCedente, New EspecieDocumento(oSqlDataReader.Item("codigo_banco"), 1))


                    oBoleto.NossoNumero = oSqlDataReader.Item("nosso_numero")


                    If bSistemaPerforma = True Then

                        oBoleto.NumeroDocumento = CInt(Right(oSqlDataReader.Item("nosso_numero").ToString, 10))
                        oCedente.ContaBancaria.Conta = CInt(oCedente.ContaBancaria.Conta)
                    End If



                    If oSqlDataReader.Item("nosso_numero").ToString.Length = 17 Then
                        oBoleto.NumeroDocumento = Right(oSqlDataReader.Item("nosso_numero").ToString, 10)
                    End If
                    oBoleto.Sacado = New Sacado(oSqlDataReader.Item("cnpj_sacado"), oSqlDataReader.Item("razao_social_sacado"))
                    oBoleto.Sacado.Endereco.End = oSqlDataReader.Item("logradouro_sacado") & ", " & oSqlDataReader.Item("numero_sacado") & IIf(oSqlDataReader.Item("complemento_sacado") = "", "", " - " & oSqlDataReader.Item("complemento_sacado"))
                    oBoleto.Sacado.Endereco.Bairro = oSqlDataReader.Item("bairro_sacado")
                    oBoleto.Sacado.Endereco.Cidade = oSqlDataReader.Item("cidade_sacado")
                    oBoleto.Sacado.Endereco.CEP = oSqlDataReader.Item("cep_sacado")
                    oBoleto.Sacado.Endereco.UF = oSqlDataReader.Item("uf_sacado")
                    oBoleto.Sacado.Endereco.Logradouro = oSqlDataReader.Item("logradouro_sacado")
                    oBoleto.Sacado.Endereco.Numero = oSqlDataReader.Item("numero_sacado")
                    oBoleto.Sacado.Endereco.Complemento = oSqlDataReader.Item("complemento_sacado")

                    If (oSqlDataReader.Item("codigo_banco") = "0001") Then
                        oBoleto.EspecieDocumento = New EspecieDocumento(oSqlDataReader.Item("codigo_banco"), 2)
                    End If
                    'Instrução 1
                    If oSqlDataReader.Item("instrucao1") <> "" Then
                        oInstrucao1 = New Instrucao(oSqlDataReader.Item("codigo_banco"))
                        oInstrucao1.Codigo = oSqlDataReader.Item("instrucao1")
                        If oSqlDataReader.Item("numero_dias1") > -1 Then oInstrucao1.QuantidadeDias = oSqlDataReader.Item("numero_dias1")
                        oInstrucao1.Descricao = oSqlDataReader.Item("descricao_instrucao1")
                        oBoleto.Instrucoes.Add(oInstrucao1)
                    End If

                    'Instrução 2
                    If oSqlDataReader.Item("instrucao2") <> "" Then
                        oInstrucao2 = New Instrucao(oSqlDataReader.Item("codigo_banco"))
                        oInstrucao2.Codigo = oSqlDataReader.Item("instrucao2")
                        If oSqlDataReader.Item("numero_dias2") > -1 Then oInstrucao2.QuantidadeDias = oSqlDataReader.Item("numero_dias2")
                        oInstrucao2.Descricao = oSqlDataReader.Item("descricao_instrucao2")
                        oBoleto.Instrucoes.Add(oInstrucao2)
                    End If

                    'Instrução 3
                    If oSqlDataReader.Item("instrucao3") <> "" Then
                        oInstrucao3 = New Instrucao(oSqlDataReader.Item("codigo_banco"))
                        oInstrucao3.Codigo = oSqlDataReader.Item("instrucao3")
                        If oSqlDataReader.Item("numero_dias3") > -1 Then oInstrucao3.QuantidadeDias = oSqlDataReader.Item("numero_dias3")
                        oInstrucao3.Descricao = oSqlDataReader.Item("descricao_instrucao3")
                        oBoleto.Instrucoes.Add(oInstrucao3)
                    End If

                    oBoletoBancario.Boleto = oBoleto
                    oBoletoBancario.Boleto.Valida()

                    oBoletoBancario.Boleto.NumeroDocumento = oSqlDataReader.Item("numero_documento")
                    If oBoletoBancario.Banco.Codigo = "033" Or oBoletoBancario.Banco.Codigo = "237" Then
                        oBoletoBancario.OcultarInstrucoes = True
                    End If
                    lBoleto.Add(oBoletoBancario)


                    If bHTML = False Then
                        'Seta o arquivo
                        sArquivo = sDiretorio + oSqlDataReader.Item("numero_documento") + ".html"

                        'Gera Boleto Bancario
                        Call GeraLayoutBoletoBancario(Format(Now, "yyyyMMdd_HHMM"), lBoleto, sArquivo)




                        'Contantes para o boleto
                        Dim iWidth As Integer = 680
                        Dim iHeight As Integer = 1096
                        Dim iWebBrowserWidth As Integer = 680
                        Dim iWebBrowserHeight As Integer = 1096
                        Dim oDoc As iTextSharp.text.Document
                        Dim oBmp As System.Drawing.Bitmap
                        Dim oGif As Image
                        Dim sHTML As String = ""
                        Dim sBoletoPathBMP As String
                        Dim sBoletoPathPDF As String

                        'Acessando a classe para fazer a imagem direto do html
                        oBmp = WebsiteThumbnailImageGenerator.GetWebSiteThumbnail(sArquivo, iWebBrowserWidth, iWebBrowserHeight, iWidth, iHeight)

                        'sBoletoPathBMP = System.IO.Path.Combine(System.IO.Path.GetTempPath, "Boleto_" & Format(Now, "yyyyMMdd_HHMM") & ".bmp")
                        sBoletoPathBMP = sArquivo.Replace(".html", ".bmp")

                        'Verifica se existe o arquivo, se sim apagar
                        If System.IO.File.Exists(sBoletoPathBMP) Then
                            System.IO.File.Delete(sBoletoPathBMP)
                        End If


                        'Salvar o arquivo temporário
                        oBmp.Save(sBoletoPathBMP)


                        'sBoletoPathPDF = System.IO.Path.Combine(System.IO.Path.GetTempPath, Format(Now, "yyyyMMdd_HHMM") & ".pdf")
                        sBoletoPathPDF = sArquivo.Replace(".html", ".pdf")

                        'Verifica se existe o pdf transformado
                        If System.IO.File.Exists(sBoletoPathPDF) Then
                            System.IO.File.Delete(sBoletoPathPDF)
                        End If

                        'Define um documento tipo doc para depois salvar como PDF
                        oDoc = New Document(PageSize.A4, 40, 0, 40, 0)

                        'Instancia o documento para depois escrevê-lo como PDF
                        PdfWriter.GetInstance(oDoc, New FileStream(sBoletoPathPDF, FileMode.Create))


                        'Abre o DOC
                        oDoc.Open()
                        'Instancia um tipo imagem para salvar o documento
                        oGif = Image.GetInstance(sBoletoPathBMP)
                        'Define as dimensões
                        oGif.ScaleAbsolute(494.0F, 785.0F)

                        'Adiciona a imagem no documento
                        oDoc.Add(oGif)
                        'Fecha o do documento (e salva-o também)
                        oDoc.Close()

                        'Finaliza o vetor
                        lBoleto.Clear()

                    End If

                End While

                If bHTML = True Then
                    'Seta o arquivo
                    sArquivo = sDiretorio + "boleto.html"

                    'Gera Boleto Bancario
                    Call GeraLayoutBoletoBancario(Format(Now, "yyyyMMdd_HHMM"), lBoleto, sArquivo)

                    Process.Start(sArquivo)
                End If

            End If


            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close() : oSqlDataReader = Nothing

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadArquivoBoletoLoteCrystal(ByVal sCodigoTituloCapa As String, _
                                     ByVal sDiretorio As String, _
                                     ByRef sArquivo As String, _
                                     ByRef iCodigoBanco As Integer)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Carrega Dados - Emitente
            Call LoadDadosEmitente()

            'Seta Parametros - Código Título Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCodigoTituloCapa : i += 1


            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa



            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financerio_titulo_parcela_boleto_bancario_arquivo_lote", oSqlParameter)

            If oSqlDataReader.HasRows = True Then

                'Váriavel - Boleto
                Dim lBoleto As New List(Of BoletoBancario)
                Dim oBoletoBancario As BoletoBancario
                Dim oInstrucao1 As Instrucao
                Dim oInstrucao2 As Instrucao
                Dim oInstrucao3 As Instrucao
                Dim oCedente As Cedente

                While oSqlDataReader.Read


                    'Seta Váriavel 
                    oBoletoBancario = New BoletoBancario

                    'Seta Codigo do Banco
                    oBoletoBancario.CodigoBanco = oSqlDataReader.Item("codigo_banco")
                    iCodigoBanco = CInt(oSqlDataReader.Item("codigo_banco"))

                    If oSqlDataReader.Item("digito_conta") = "" Then
                        oCedente = New Cedente(oSqlDataReader.Item("cnpj_empresa"), oSqlDataReader.Item("razao_social_empresa") & "<br>" & oSqlDataReader.Item("logradouro_empresa") & ", " & oSqlDataReader.Item("numero_empresa") & " - " & oSqlDataReader.Item("bairro_empresa"), oSqlDataReader.Item("agencia"), oSqlDataReader.Item("conta"))
                    Else
                        If Len(oSqlDataReader.Item("agencia")) = 5 Then
                            oCedente = New Cedente(oSqlDataReader.Item("cnpj_empresa"), oSqlDataReader.Item("razao_social_empresa") & "<br>" & oSqlDataReader.Item("logradouro_empresa") & ", " & oSqlDataReader.Item("numero_empresa") & " - " & oSqlDataReader.Item("bairro_empresa"), Mid(oSqlDataReader.Item("agencia"), 1, 4), Mid(oSqlDataReader.Item("agencia"), 5, 1), oSqlDataReader.Item("conta"), oSqlDataReader.Item("digito_conta"))
                        Else
                            oCedente = New Cedente(oSqlDataReader.Item("cnpj_empresa"), oSqlDataReader.Item("razao_social_empresa") & "<br>" & oSqlDataReader.Item("logradouro_empresa") & ", " & oSqlDataReader.Item("numero_empresa") & " - " & oSqlDataReader.Item("bairro_empresa"), oSqlDataReader.Item("agencia"), oSqlDataReader.Item("conta"), oSqlDataReader.Item("digito_conta"))
                        End If
                    End If

                    If oSqlDataReader.Item("convenio") = "" Then

                        oCedente.Convenio = 111111
                    Else
                        oCedente.Convenio = oSqlDataReader.Item("convenio")

                    End If

                    If CInt(oSqlDataReader.Item("codigo_banco")) = 33 Then
                        oCedente.Codigo = oSqlDataReader.Item("convenio")
                    ElseIf CInt(oSqlDataReader.Item("codigo_banco")) = 104 Then
                        oCedente.Codigo = oSqlDataReader.Item("convenio")
                    End If

                    If oSqlDataReader.Item("codigo_banco") = 341 Then
                        oCedente.ContaBancaria.Conta = CInt(oCedente.ContaBancaria.Conta)
                    End If

                    Dim oBoleto As New Boleto(oSqlDataReader.Item("data_vencimento"), oSqlDataReader.Item("valor"), oSqlDataReader.Item("carteira"), oSqlDataReader.Item("nosso_numero"), oCedente, New EspecieDocumento(oSqlDataReader.Item("codigo_banco"), 1))


                    oBoleto.NossoNumero = oSqlDataReader.Item("nosso_numero")


                    If oSqlDataReader.Item("nosso_numero").ToString.Length = 17 Then
                        oBoleto.NumeroDocumento = Right(oSqlDataReader.Item("nosso_numero").ToString, 10)
                    End If
                    oBoleto.Sacado = New Sacado(oSqlDataReader.Item("cnpj_sacado"), oSqlDataReader.Item("razao_social_sacado"))
                    oBoleto.Sacado.Endereco.End = oSqlDataReader.Item("logradouro_sacado") & ", " & oSqlDataReader.Item("numero_sacado") & IIf(oSqlDataReader.Item("complemento_sacado") = "", "", " - " & oSqlDataReader.Item("complemento_sacado"))
                    oBoleto.Sacado.Endereco.Bairro = oSqlDataReader.Item("bairro_sacado")
                    oBoleto.Sacado.Endereco.Cidade = oSqlDataReader.Item("cidade_sacado")
                    oBoleto.Sacado.Endereco.CEP = oSqlDataReader.Item("cep_sacado")
                    oBoleto.Sacado.Endereco.UF = oSqlDataReader.Item("uf_sacado")
                    oBoleto.Sacado.Endereco.Logradouro = oSqlDataReader.Item("logradouro_sacado")
                    oBoleto.Sacado.Endereco.Numero = oSqlDataReader.Item("numero_sacado")
                    oBoleto.Sacado.Endereco.Complemento = oSqlDataReader.Item("complemento_sacado")

                    If (oSqlDataReader.Item("codigo_banco") = "0001") Then
                        oBoleto.EspecieDocumento = New EspecieDocumento(oSqlDataReader.Item("codigo_banco"), 2)
                    End If
                    'Instrução 1
                    If oSqlDataReader.Item("instrucao1") <> "" Then
                        oInstrucao1 = New Instrucao(oSqlDataReader.Item("codigo_banco"))
                        oInstrucao1.Codigo = oSqlDataReader.Item("instrucao1")
                        If oSqlDataReader.Item("numero_dias1") > -1 Then oInstrucao1.QuantidadeDias = oSqlDataReader.Item("numero_dias1")
                        oInstrucao1.Descricao = oSqlDataReader.Item("descricao_instrucao1")
                        oBoleto.Instrucoes.Add(oInstrucao1)
                    End If

                    'Instrução 2
                    If oSqlDataReader.Item("instrucao2") <> "" Then
                        oInstrucao2 = New Instrucao(oSqlDataReader.Item("codigo_banco"))
                        oInstrucao2.Codigo = oSqlDataReader.Item("instrucao2")
                        If oSqlDataReader.Item("numero_dias2") > -1 Then oInstrucao2.QuantidadeDias = oSqlDataReader.Item("numero_dias2")
                        oInstrucao2.Descricao = oSqlDataReader.Item("descricao_instrucao2")
                        oBoleto.Instrucoes.Add(oInstrucao2)
                    End If

                    'Instrução 3
                    If oSqlDataReader.Item("instrucao3") <> "" Then
                        oInstrucao3 = New Instrucao(oSqlDataReader.Item("codigo_banco"))
                        oInstrucao3.Codigo = oSqlDataReader.Item("instrucao3")
                        If oSqlDataReader.Item("numero_dias3") > -1 Then oInstrucao3.QuantidadeDias = oSqlDataReader.Item("numero_dias3")
                        oInstrucao3.Descricao = oSqlDataReader.Item("descricao_instrucao3")
                        oBoleto.Instrucoes.Add(oInstrucao3)
                    End If

                    oBoletoBancario.Boleto = oBoleto
                    oBoletoBancario.Boleto.Valida()

                    oBoletoBancario.Boleto.NumeroDocumento = oSqlDataReader.Item("numero_documento")
                    If oBoletoBancario.Banco.Codigo = "033" Or oBoletoBancario.Banco.Codigo = "237" Then
                        oBoletoBancario.OcultarInstrucoes = True
                    End If
                    lBoleto.Add(oBoletoBancario)

                    'Seta o arquivo
                    sArquivo = sDiretorio + oSqlDataReader.Item("numero_documento") + ".html"


                    'Gera Boleto Bancario
                    Call GeraLayoutBoletoBancario(Format(Now, "yyyyMMdd_HHMM"), lBoleto, sArquivo)



                    ExecuteQuery("update tb_fin_titulo_parcela_boleto_bancario set codigo_barras = '" & oBoleto.CodigoBarra.Codigo & "'," & _
                                 "linha_digitavel = '" & oBoleto.CodigoBarra.LinhaDigitavel & "'," & _
                                 "nosso_numero_formatado = '" & oBoleto.NossoNumero & "' " & _
                                 "where numero_parcela = " & oSqlDataReader.Item("numero_parcela") & " and ativo = 1 and codigo_titulo_capa = " & sCodigoTituloCapa)




                End While
            End If

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close() : oSqlDataReader = Nothing

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadArquivoBoletoLoteCrystalParcela(ByVal sCodigoTituloCapa As String, _
                                                   ByVal iNumeroParcela As Integer, _
                                                   ByVal sDiretorio As String, _
                                                   ByRef sArquivo As String, _
                                                   ByRef iCodigoBanco As Integer)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Carrega Dados - Emitente
            Call LoadDadosEmitente()

            'Seta Parametros - Código Título Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCodigoTituloCapa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iNumeroParcela : i += 1


            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa



            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financerio_titulo_parcela_boleto_bancario_arquivo_parcela", oSqlParameter)

            If oSqlDataReader.HasRows = True Then

                'Váriavel - Boleto
                Dim lBoleto As New List(Of BoletoBancario)
                Dim oBoletoBancario As BoletoBancario
                Dim oInstrucao1 As Instrucao
                Dim oInstrucao2 As Instrucao
                Dim oInstrucao3 As Instrucao
                Dim oCedente As Cedente

                While oSqlDataReader.Read


                    'Seta Váriavel 
                    oBoletoBancario = New BoletoBancario

                    'Seta Codigo do Banco
                    oBoletoBancario.CodigoBanco = oSqlDataReader.Item("codigo_banco")
                    iCodigoBanco = CInt(oSqlDataReader.Item("codigo_banco"))

                    If oSqlDataReader.Item("digito_conta") = "" Then
                        oCedente = New Cedente(oSqlDataReader.Item("cnpj_empresa"), oSqlDataReader.Item("razao_social_empresa") & "<br>" & oSqlDataReader.Item("logradouro_empresa") & ", " & oSqlDataReader.Item("numero_empresa") & " - " & oSqlDataReader.Item("bairro_empresa"), oSqlDataReader.Item("agencia"), oSqlDataReader.Item("conta"))
                    Else
                        If Len(oSqlDataReader.Item("agencia")) = 5 Then
                            oCedente = New Cedente(oSqlDataReader.Item("cnpj_empresa"), oSqlDataReader.Item("razao_social_empresa") & "<br>" & oSqlDataReader.Item("logradouro_empresa") & ", " & oSqlDataReader.Item("numero_empresa") & " - " & oSqlDataReader.Item("bairro_empresa"), Mid(oSqlDataReader.Item("agencia"), 1, 4), Mid(oSqlDataReader.Item("agencia"), 5, 1), oSqlDataReader.Item("conta"), oSqlDataReader.Item("digito_conta"))
                        Else
                            oCedente = New Cedente(oSqlDataReader.Item("cnpj_empresa"), oSqlDataReader.Item("razao_social_empresa") & "<br>" & oSqlDataReader.Item("logradouro_empresa") & ", " & oSqlDataReader.Item("numero_empresa") & " - " & oSqlDataReader.Item("bairro_empresa"), oSqlDataReader.Item("agencia"), oSqlDataReader.Item("conta"), oSqlDataReader.Item("digito_conta"))
                        End If
                    End If

                    If oSqlDataReader.Item("convenio") = "" Then

                        oCedente.Convenio = 111111
                    Else
                        oCedente.Convenio = oSqlDataReader.Item("convenio")

                    End If

                    If CInt(oSqlDataReader.Item("codigo_banco")) = 33 Then
                        oCedente.Codigo = oSqlDataReader.Item("convenio")
                    ElseIf CInt(oSqlDataReader.Item("codigo_banco")) = 104 Then
                        oCedente.Codigo = oSqlDataReader.Item("convenio")
                    End If

                    If oSqlDataReader.Item("codigo_banco") = 341 Then
                        oCedente.ContaBancaria.Conta = CInt(oCedente.ContaBancaria.Conta)
                    End If

                    Dim oBoleto As New Boleto(oSqlDataReader.Item("data_vencimento"), oSqlDataReader.Item("valor"), oSqlDataReader.Item("carteira"), oSqlDataReader.Item("nosso_numero"), oCedente, New EspecieDocumento(oSqlDataReader.Item("codigo_banco"), 1))


                    oBoleto.NossoNumero = oSqlDataReader.Item("nosso_numero")


                    If oSqlDataReader.Item("nosso_numero").ToString.Length = 17 Then
                        oBoleto.NumeroDocumento = Right(oSqlDataReader.Item("nosso_numero").ToString, 10)
                    End If
                    oBoleto.Sacado = New Sacado(oSqlDataReader.Item("cnpj_sacado"), oSqlDataReader.Item("razao_social_sacado"))
                    oBoleto.Sacado.Endereco.End = oSqlDataReader.Item("logradouro_sacado") & ", " & oSqlDataReader.Item("numero_sacado") & IIf(oSqlDataReader.Item("complemento_sacado") = "", "", " - " & oSqlDataReader.Item("complemento_sacado"))
                    oBoleto.Sacado.Endereco.Bairro = oSqlDataReader.Item("bairro_sacado")
                    oBoleto.Sacado.Endereco.Cidade = oSqlDataReader.Item("cidade_sacado")
                    oBoleto.Sacado.Endereco.CEP = oSqlDataReader.Item("cep_sacado")
                    oBoleto.Sacado.Endereco.UF = oSqlDataReader.Item("uf_sacado")
                    oBoleto.Sacado.Endereco.Logradouro = oSqlDataReader.Item("logradouro_sacado")
                    oBoleto.Sacado.Endereco.Numero = oSqlDataReader.Item("numero_sacado")
                    oBoleto.Sacado.Endereco.Complemento = oSqlDataReader.Item("complemento_sacado")

                    If (oSqlDataReader.Item("codigo_banco") = "0001") Then
                        oBoleto.EspecieDocumento = New EspecieDocumento(oSqlDataReader.Item("codigo_banco"), 2)
                    End If
                    'Instrução 1
                    If oSqlDataReader.Item("instrucao1") <> "" Then
                        oInstrucao1 = New Instrucao(oSqlDataReader.Item("codigo_banco"))
                        oInstrucao1.Codigo = oSqlDataReader.Item("instrucao1")
                        If oSqlDataReader.Item("numero_dias1") > -1 Then oInstrucao1.QuantidadeDias = oSqlDataReader.Item("numero_dias1")
                        oInstrucao1.Descricao = oSqlDataReader.Item("descricao_instrucao1")
                        oBoleto.Instrucoes.Add(oInstrucao1)
                    End If

                    'Instrução 2
                    If oSqlDataReader.Item("instrucao2") <> "" Then
                        oInstrucao2 = New Instrucao(oSqlDataReader.Item("codigo_banco"))
                        oInstrucao2.Codigo = oSqlDataReader.Item("instrucao2")
                        If oSqlDataReader.Item("numero_dias2") > -1 Then oInstrucao2.QuantidadeDias = oSqlDataReader.Item("numero_dias2")
                        oInstrucao2.Descricao = oSqlDataReader.Item("descricao_instrucao2")
                        oBoleto.Instrucoes.Add(oInstrucao2)
                    End If


                    oBoletoBancario.Boleto = oBoleto
                    oBoletoBancario.Boleto.Valida()

                    oBoletoBancario.Boleto.NumeroDocumento = oSqlDataReader.Item("numero_documento")
                    If oBoletoBancario.Banco.Codigo = "033" Or oBoletoBancario.Banco.Codigo = "237" Then
                        oBoletoBancario.OcultarInstrucoes = True
                    End If
                    lBoleto.Add(oBoletoBancario)

                    'Seta o arquivo
                    sArquivo = sDiretorio + oSqlDataReader.Item("numero_documento") + ".html"


                    'Gera Boleto Bancario
                    Call GeraLayoutBoletoBancario(Format(Now, "yyyyMMdd_HHMM"), lBoleto, sArquivo)



                    ExecuteQuery("update tb_fin_titulo_parcela_boleto_bancario set codigo_barras = '" & oBoleto.CodigoBarra.Codigo & "'," & _
                                 "linha_digitavel = '" & oBoleto.CodigoBarra.LinhaDigitavel & "'," & _
                                 "nosso_numero_formatado = '" & oBoleto.NossoNumero & "' " & _
                                 "where numero_parcela = " & oSqlDataReader.Item("numero_parcela") & " and ativo = 1 and codigo_titulo_capa = " & sCodigoTituloCapa)




                End While
            End If

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close() : oSqlDataReader = Nothing

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadArquivoBoletoLoteCrystalNFE(ByVal sCodigoTituloCapa As String, _
                                                 ByVal sDiretorio As String, _
                                                 ByRef sArquivo As String, _
                                                 ByRef iCodigoBanco As Integer)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Carrega Dados - Emitente
            Call LoadDadosEmitente()

            'Seta Parametros - Código Título Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCodigoTituloCapa : i += 1


            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa



            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financerio_titulo_parcela_boleto_bancario_arquivo_lote_nfe", oSqlParameter)

            If oSqlDataReader.HasRows = True Then

                'Váriavel - Boleto
                Dim lBoleto As New List(Of BoletoBancario)
                Dim oBoletoBancario As BoletoBancario
                Dim oInstrucao1 As Instrucao
                Dim oInstrucao2 As Instrucao
                Dim oInstrucao3 As Instrucao
                Dim oCedente As Cedente

                While oSqlDataReader.Read


                    'Seta Váriavel 
                    oBoletoBancario = New BoletoBancario

                    'Seta Codigo do Banco
                    oBoletoBancario.CodigoBanco = oSqlDataReader.Item("codigo_banco")
                    iCodigoBanco = CInt(oSqlDataReader.Item("codigo_banco"))

                    If oSqlDataReader.Item("digito_conta") = "" Then
                        oCedente = New Cedente(oSqlDataReader.Item("cnpj_empresa"), oSqlDataReader.Item("razao_social_empresa") & "<br>" & oSqlDataReader.Item("logradouro_empresa") & ", " & oSqlDataReader.Item("numero_empresa") & " - " & oSqlDataReader.Item("bairro_empresa"), oSqlDataReader.Item("agencia"), oSqlDataReader.Item("conta"))
                    Else
                        If Len(oSqlDataReader.Item("agencia")) = 5 Then
                            oCedente = New Cedente(oSqlDataReader.Item("cnpj_empresa"), oSqlDataReader.Item("razao_social_empresa") & "<br>" & oSqlDataReader.Item("logradouro_empresa") & ", " & oSqlDataReader.Item("numero_empresa") & " - " & oSqlDataReader.Item("bairro_empresa"), Mid(oSqlDataReader.Item("agencia"), 1, 4), Mid(oSqlDataReader.Item("agencia"), 5, 1), oSqlDataReader.Item("conta"), oSqlDataReader.Item("digito_conta"))
                        Else
                            oCedente = New Cedente(oSqlDataReader.Item("cnpj_empresa"), oSqlDataReader.Item("razao_social_empresa") & "<br>" & oSqlDataReader.Item("logradouro_empresa") & ", " & oSqlDataReader.Item("numero_empresa") & " - " & oSqlDataReader.Item("bairro_empresa"), oSqlDataReader.Item("agencia"), oSqlDataReader.Item("conta"), oSqlDataReader.Item("digito_conta"))
                        End If
                    End If

                    If oSqlDataReader.Item("convenio") = "" Then

                        oCedente.Convenio = 111111
                    Else
                        oCedente.Convenio = oSqlDataReader.Item("convenio")

                    End If

                    If CInt(oSqlDataReader.Item("codigo_banco")) = 33 Then
                        oCedente.Codigo = oSqlDataReader.Item("convenio")
                    ElseIf CInt(oSqlDataReader.Item("codigo_banco")) = 104 Then
                        oCedente.Codigo = oSqlDataReader.Item("convenio")
                    End If

                    If oSqlDataReader.Item("codigo_banco") = 341 Then
                        oCedente.ContaBancaria.Conta = CInt(oCedente.ContaBancaria.Conta)
                    End If

                    Dim oBoleto As New Boleto(oSqlDataReader.Item("data_vencimento"), oSqlDataReader.Item("valor"), oSqlDataReader.Item("carteira"), oSqlDataReader.Item("nosso_numero"), oCedente, New EspecieDocumento(oSqlDataReader.Item("codigo_banco"), 1))


                    oBoleto.NossoNumero = oSqlDataReader.Item("nosso_numero")


                    If oSqlDataReader.Item("nosso_numero").ToString.Length = 17 Then
                        oBoleto.NumeroDocumento = Right(oSqlDataReader.Item("nosso_numero").ToString, 10)
                    End If
                    oBoleto.Sacado = New Sacado(oSqlDataReader.Item("cnpj_sacado"), oSqlDataReader.Item("razao_social_sacado"))
                    oBoleto.Sacado.Endereco.End = oSqlDataReader.Item("logradouro_sacado") & ", " & oSqlDataReader.Item("numero_sacado") & IIf(oSqlDataReader.Item("complemento_sacado") = "", "", " - " & oSqlDataReader.Item("complemento_sacado"))
                    oBoleto.Sacado.Endereco.Bairro = oSqlDataReader.Item("bairro_sacado")
                    oBoleto.Sacado.Endereco.Cidade = oSqlDataReader.Item("cidade_sacado")
                    oBoleto.Sacado.Endereco.CEP = oSqlDataReader.Item("cep_sacado")
                    oBoleto.Sacado.Endereco.UF = oSqlDataReader.Item("uf_sacado")
                    oBoleto.Sacado.Endereco.Logradouro = oSqlDataReader.Item("logradouro_sacado")
                    oBoleto.Sacado.Endereco.Numero = oSqlDataReader.Item("numero_sacado")
                    oBoleto.Sacado.Endereco.Complemento = oSqlDataReader.Item("complemento_sacado")

                    If (oSqlDataReader.Item("codigo_banco") = "0001") Then
                        oBoleto.EspecieDocumento = New EspecieDocumento(oSqlDataReader.Item("codigo_banco"), 2)
                    End If
                    'Instrução 1
                    If oSqlDataReader.Item("instrucao1") <> "" Then
                        oInstrucao1 = New Instrucao(oSqlDataReader.Item("codigo_banco"))
                        oInstrucao1.Codigo = oSqlDataReader.Item("instrucao1")
                        If oSqlDataReader.Item("numero_dias1") > -1 Then oInstrucao1.QuantidadeDias = oSqlDataReader.Item("numero_dias1")
                        oInstrucao1.Descricao = oSqlDataReader.Item("descricao_instrucao1")
                        oBoleto.Instrucoes.Add(oInstrucao1)
                    End If

                    'Instrução 2
                    If oSqlDataReader.Item("instrucao2") <> "" Then
                        oInstrucao2 = New Instrucao(oSqlDataReader.Item("codigo_banco"))
                        oInstrucao2.Codigo = oSqlDataReader.Item("instrucao2")
                        If oSqlDataReader.Item("numero_dias2") > -1 Then oInstrucao2.QuantidadeDias = oSqlDataReader.Item("numero_dias2")
                        oInstrucao2.Descricao = oSqlDataReader.Item("descricao_instrucao2")
                        oBoleto.Instrucoes.Add(oInstrucao2)
                    End If

                    'Instrução 3
                    If oSqlDataReader.Item("instrucao3") <> "" Then
                        oInstrucao3 = New Instrucao(oSqlDataReader.Item("codigo_banco"))
                        oInstrucao3.Codigo = oSqlDataReader.Item("instrucao3")
                        If oSqlDataReader.Item("numero_dias3") > -1 Then oInstrucao3.QuantidadeDias = oSqlDataReader.Item("numero_dias3")
                        oInstrucao3.Descricao = oSqlDataReader.Item("descricao_instrucao3")
                        oBoleto.Instrucoes.Add(oInstrucao3)
                    End If

                    oBoletoBancario.Boleto = oBoleto
                    oBoletoBancario.Boleto.Valida()

                    oBoletoBancario.Boleto.NumeroDocumento = oSqlDataReader.Item("numero_documento")
                    If oBoletoBancario.Banco.Codigo = "033" Or oBoletoBancario.Banco.Codigo = "237" Then
                        oBoletoBancario.OcultarInstrucoes = True
                    End If
                    lBoleto.Add(oBoletoBancario)

                    'Seta o arquivo
                    sArquivo = sDiretorio + oSqlDataReader.Item("numero_documento") + ".html"


                    'Gera Boleto Bancario
                    Call GeraLayoutBoletoBancario(Format(Now, "yyyyMMdd_HHMM"), lBoleto, sArquivo)



                    ExecuteQuery("update tb_fin_titulo_parcela_boleto_bancario set codigo_barras = '" & oBoleto.CodigoBarra.Codigo & "'," & _
                                 "linha_digitavel = '" & oBoleto.CodigoBarra.LinhaDigitavel & "'," & _
                                 "nosso_numero_formatado = '" & oBoleto.NossoNumero & "' " & _
                                 "where numero_parcela = " & oSqlDataReader.Item("numero_parcela") & " and ativo = 1 and codigo_titulo_capa = " & sCodigoTituloCapa)




                End While
            End If

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close() : oSqlDataReader = Nothing

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadArquivoBoletoPDF(ByVal lCodigoTituloCapa As Long, _
                                    ByVal sNotaFiscal As String, _
                                    ByRef sArquivo As String, _
                                    Optional ByVal iParcela As Integer = -1, _
                                    Optional ByVal bHTML As Boolean = False)


        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Carrega Dados - Emitente
            Call LoadDadosEmitente()

            'Seta Parametros - Código Título Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoTituloCapa : i += 1

            'Seta Parametros - Parcela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iParcela : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financerio_titulo_parcela_boleto_bancario_arquivo", oSqlParameter)

            If oSqlDataReader.HasRows = True Then

                'Váriavel - Boleto
                Dim lBoleto As New List(Of BoletoBancario)
                Dim oBoletoBancario As BoletoBancario
                Dim oInstrucao1 As Instrucao
                Dim oInstrucao2 As Instrucao
                Dim oInstrucao3 As Instrucao
                Dim oCedente As Cedente
                'Variáveis - PDF                
                Dim sHTML As String = ""
                Dim sBoletoPathBMP As String
                Dim sBoletoPathPDF As String
                Dim iWidth As Integer = 680
                Dim iHeight As Integer = 1096
                Dim iWebBrowserWidth As Integer = 680
                Dim iWebBrowserHeight As Integer = 1096
                Dim oDoc As iTextSharp.text.Document
                Dim oBmp As System.Drawing.Bitmap
                Dim oGif As Image
                Dim sFilePDF As String = ""
                Dim oClsPDFCreator As New clsPDFCreator
                Dim sArquivoBoleto As String = ""

                While oSqlDataReader.Read

                    'Seta Váriavel 
                    oBoletoBancario = New BoletoBancario

                    'Seta Codigo do Banco
                    oBoletoBancario.CodigoBanco = oSqlDataReader.Item("codigo_banco")

                    If oSqlDataReader.Item("digito_conta") = "" Then
                        oCedente = New Cedente(goEmitente.sCNPJ, goEmitente.sRazaoSocial, oSqlDataReader.Item("agencia"), oSqlDataReader.Item("conta"))
                    Else
                        oCedente = New Cedente(goEmitente.sCNPJ, goEmitente.sRazaoSocial, oSqlDataReader.Item("agencia"), oSqlDataReader.Item("conta"), oSqlDataReader.Item("digito_conta"))
                    End If

                    oCedente.Convenio = oSqlDataReader.Item("convenio")

                    If CInt(oSqlDataReader.Item("codigo_banco")) = 33 Then
                        oCedente.Codigo = oSqlDataReader.Item("convenio")
                    ElseIf CInt(oSqlDataReader.Item("codigo_banco")) = 104 Then
                        oCedente.Codigo = oSqlDataReader.Item("convenio")
                    End If


                    If oSqlDataReader.Item("codigo_banco") = 341 Then
                        oCedente.ContaBancaria.Conta = CInt(oCedente.ContaBancaria.Conta)
                    End If

                    Dim oBoleto As New Boleto(oSqlDataReader.Item("data_vencimento"), oSqlDataReader.Item("valor"), oSqlDataReader.Item("carteira"), oSqlDataReader.Item("nosso_numero"), oCedente, New EspecieDocumento(oSqlDataReader.Item("codigo_banco"), 1))
                    oBoleto.NumeroDocumento = oBoleto.NossoNumero

                    oBoleto.Sacado = New Sacado(oSqlDataReader.Item("cnpj_sacado"), oSqlDataReader.Item("razao_social_sacado"))
                    oBoleto.Sacado.Endereco.End = oSqlDataReader.Item("logradouro_sacado") & ", " & oSqlDataReader.Item("numero_sacado") & IIf(oSqlDataReader.Item("complemento_sacado") = "", "", " - " & oSqlDataReader.Item("complemento_sacado"))
                    oBoleto.Sacado.Endereco.Bairro = oSqlDataReader.Item("bairro_sacado")
                    oBoleto.Sacado.Endereco.Cidade = oSqlDataReader.Item("cidade_sacado")
                    oBoleto.Sacado.Endereco.CEP = oSqlDataReader.Item("cep_sacado")
                    oBoleto.Sacado.Endereco.UF = oSqlDataReader.Item("uf_sacado")
                    oBoleto.Sacado.Endereco.Logradouro = oSqlDataReader.Item("logradouro_sacado")
                    oBoleto.Sacado.Endereco.Numero = oSqlDataReader.Item("numero_sacado")
                    oBoleto.Sacado.Endereco.Complemento = oSqlDataReader.Item("complemento_sacado")

                    'Instrução 1
                    If oSqlDataReader.Item("instrucao1") <> "" Then
                        oInstrucao1 = New Instrucao(oSqlDataReader.Item("codigo_banco"))
                        oInstrucao1.Codigo = oSqlDataReader.Item("instrucao1")
                        If oSqlDataReader.Item("numero_dias1") > -1 Then oInstrucao1.QuantidadeDias = oSqlDataReader.Item("numero_dias1")
                        oInstrucao1.Descricao = oSqlDataReader.Item("descricao_instrucao1")
                        oBoleto.Instrucoes.Add(oInstrucao1)
                    End If

                    'Instrução 2
                    If oSqlDataReader.Item("instrucao2") <> "" Then
                        oInstrucao2 = New Instrucao(oSqlDataReader.Item("codigo_banco"))
                        oInstrucao2.Codigo = oSqlDataReader.Item("instrucao2")
                        If oSqlDataReader.Item("numero_dias2") > -1 Then oInstrucao2.QuantidadeDias = oSqlDataReader.Item("numero_dias2")
                        oInstrucao2.Descricao = oSqlDataReader.Item("descricao_instrucao2")
                        oBoleto.Instrucoes.Add(oInstrucao2)
                    End If

                    'Instrução 3
                    If oSqlDataReader.Item("instrucao3") <> "" Then
                        oInstrucao3 = New Instrucao(oSqlDataReader.Item("codigo_banco"))
                        oInstrucao3.Codigo = oSqlDataReader.Item("instrucao3")
                        If oSqlDataReader.Item("numero_dias3") > -1 Then oInstrucao3.QuantidadeDias = oSqlDataReader.Item("numero_dias3")
                        oInstrucao3.Descricao = oSqlDataReader.Item("descricao_instrucao3")
                        oBoleto.Instrucoes.Add(oInstrucao3)
                    End If

                    oBoletoBancario.Boleto = oBoleto
                    oBoletoBancario.Boleto.Valida()
                    oBoletoBancario.Boleto.NumeroDocumento = oSqlDataReader.Item("numero_documento")
                    lBoleto.Add(oBoletoBancario)

                    'Gera Boleto Bancario
                    Call GeraLayoutBoletoBancario(lBoleto, sArquivoBoleto, sHTML)

                    'Se for html , não converter para PDF
                    If bHTML = False Then


                        'Acessando a classe para fazer a imagem direto do html
                        oBmp = WebsiteThumbnailImageGenerator.GetWebSiteThumbnail(sArquivoBoleto, iWebBrowserWidth, iWebBrowserHeight, iWidth, iHeight)

                        sBoletoPathBMP = System.IO.Path.Combine(System.IO.Path.GetTempPath, "Boleto_" & oSqlDataReader.Item("numero_parcela") & ".bmp")

                        'Salvar o arquivo temporário
                        oBmp.Save(sBoletoPathBMP)

                        sBoletoPathPDF = System.IO.Path.Combine(System.IO.Path.GetTempPath, sNotaFiscal & "_" & oSqlDataReader.Item("numero_parcela") & ".pdf")

                        'Define um documento tipo doc para depois salvar como PDF
                        oDoc = New Document(PageSize.A4, 40, 0, 40, 0)
                        'Instancia o documento para depois escrevê-lo como PDF
                        PdfWriter.GetInstance(oDoc, New FileStream(sBoletoPathPDF, FileMode.Create))
                        'Abre o DOC
                        oDoc.Open()
                        'Instancia um tipo imagem para salvar o documento
                        oGif = Image.GetInstance(sBoletoPathBMP)
                        'Define as dimensões
                        oGif.ScaleAbsolute(494.0F, 785.0F)

                        'Adiciona a imagem no documento
                        oDoc.Add(oGif)
                        'Fecha o do documento (e salva-o também)
                        oDoc.Close()

                        Application.DoEvents()

                        lBoleto.Clear()

                        sFilePDF = sFilePDF & """" & sBoletoPathPDF & """" & " "

                    End If

                End While

                If bHTML = False Then
                    sBoletoPathPDF = System.IO.Path.Combine(System.IO.Path.GetTempPath, sNotaFiscal & ".pdf")

                    'Agrupa Arquivos PDFs
                    oClsPDFCreator.MergePDFFiles(sFilePDF, """" & sBoletoPathPDF & """")

                    Application.DoEvents()

                    sArquivo = sBoletoPathPDF

                Else
                    Dim sArquivoHTML As String = System.IO.Path.GetTempPath & sNotaFiscal & ".html"
                    Try
                        System.IO.File.Delete(sArquivoHTML)
                    Catch ex As Exception

                    End Try
                    System.IO.File.Copy(sArquivoBoleto, sArquivoHTML)
                    sArquivo = sArquivoHTML

                End If


            End If

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close() : oSqlDataReader = Nothing

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadArquivoBoletoPDFBKP(ByVal lCodigoTituloCapa As Long, _
                                    ByVal sNotaFiscal As String, _
                                    ByRef sArquivo As String, _
                                    Optional ByVal iParcela As Integer = -1)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Carrega Dados - Emitente
            Call LoadDadosEmitente()

            'Seta Parametros - Código Título Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoTituloCapa : i += 1

            'Seta Parametros - Parcela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iParcela : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financerio_titulo_parcela_boleto_bancario_arquivo", oSqlParameter)

            If oSqlDataReader.HasRows = True Then

                'Váriavel - Boleto
                Dim lBoleto As New List(Of BoletoBancario)
                Dim oBoletoBancario As BoletoBancario
                Dim oInstrucao1 As Instrucao
                Dim oInstrucao2 As Instrucao
                Dim oInstrucao3 As Instrucao
                Dim oCedente As Cedente
                'Variáveis - PDF                
                Dim sHTML As String = ""
                Dim sBoletoPathBMP As String
                Dim sBoletoPathPDF As String
                Dim iWidth As Integer = 680
                Dim iHeight As Integer = 1096
                Dim iWebBrowserWidth As Integer = 680
                Dim iWebBrowserHeight As Integer = 1096
                Dim oDoc As iTextSharp.text.Document
                Dim oBmp As System.Drawing.Bitmap
                Dim oGif As Image
                Dim sFilePDF As String = ""
                Dim oClsPDFCreator As New clsPDFCreator
                Dim sArquivoBoleto As String = ""

                While oSqlDataReader.Read

                    'Seta Váriavel 
                    oBoletoBancario = New BoletoBancario

                    'Seta Codigo do Banco
                    oBoletoBancario.CodigoBanco = oSqlDataReader.Item("codigo_banco")

                    If oSqlDataReader.Item("digito_conta") = "" Then
                        oCedente = New Cedente(goEmitente.sCNPJ, goEmitente.sRazaoSocial, oSqlDataReader.Item("agencia"), oSqlDataReader.Item("conta"))
                    Else
                        oCedente = New Cedente(goEmitente.sCNPJ, goEmitente.sRazaoSocial, oSqlDataReader.Item("agencia"), oSqlDataReader.Item("conta"), oSqlDataReader.Item("digito_conta"))
                    End If

                    oCedente.Convenio = oSqlDataReader.Item("convenio")

                    Dim oBoleto As New Boleto(oSqlDataReader.Item("data_vencimento"), oSqlDataReader.Item("valor"), oSqlDataReader.Item("carteira"), oSqlDataReader.Item("nosso_numero"), oCedente, New EspecieDocumento(oSqlDataReader.Item("codigo_banco"), 1))
                    oBoleto.NumeroDocumento = oBoleto.NossoNumero

                    oBoleto.Sacado = New Sacado(oSqlDataReader.Item("cnpj_sacado"), oSqlDataReader.Item("razao_social_sacado"))
                    oBoleto.Sacado.Endereco.End = oSqlDataReader.Item("logradouro_sacado") & ", " & oSqlDataReader.Item("numero_sacado") & IIf(oSqlDataReader.Item("complemento_sacado") = "", "", " - " & oSqlDataReader.Item("complemento_sacado"))
                    oBoleto.Sacado.Endereco.Bairro = oSqlDataReader.Item("bairro_sacado")
                    oBoleto.Sacado.Endereco.Cidade = oSqlDataReader.Item("cidade_sacado")
                    oBoleto.Sacado.Endereco.CEP = oSqlDataReader.Item("cep_sacado")
                    oBoleto.Sacado.Endereco.UF = oSqlDataReader.Item("uf_sacado")
                    oBoleto.Sacado.Endereco.Logradouro = oSqlDataReader.Item("logradouro_sacado")
                    oBoleto.Sacado.Endereco.Numero = oSqlDataReader.Item("numero_sacado")
                    oBoleto.Sacado.Endereco.Complemento = oSqlDataReader.Item("complemento_sacado")

                    'Instrução 1
                    If oSqlDataReader.Item("instrucao1") <> "" Then
                        oInstrucao1 = New Instrucao(oSqlDataReader.Item("codigo_banco"))
                        oInstrucao1.Codigo = oSqlDataReader.Item("instrucao1")
                        If oSqlDataReader.Item("numero_dias1") > -1 Then oInstrucao1.QuantidadeDias = oSqlDataReader.Item("numero_dias1")
                        oInstrucao1.Descricao = oSqlDataReader.Item("descricao_instrucao1")
                        oBoleto.Instrucoes.Add(oInstrucao1)
                    End If

                    'Instrução 2
                    If oSqlDataReader.Item("instrucao2") <> "" Then
                        oInstrucao2 = New Instrucao(oSqlDataReader.Item("codigo_banco"))
                        oInstrucao2.Codigo = oSqlDataReader.Item("instrucao2")
                        If oSqlDataReader.Item("numero_dias2") > -1 Then oInstrucao2.QuantidadeDias = oSqlDataReader.Item("numero_dias2")
                        oInstrucao2.Descricao = oSqlDataReader.Item("descricao_instrucao2")
                        oBoleto.Instrucoes.Add(oInstrucao2)
                    End If

                    'Instrução 3
                    If oSqlDataReader.Item("instrucao3") <> "" Then
                        oInstrucao3 = New Instrucao(oSqlDataReader.Item("codigo_banco"))
                        oInstrucao3.Codigo = oSqlDataReader.Item("instrucao3")
                        If oSqlDataReader.Item("numero_dias3") > -1 Then oInstrucao3.QuantidadeDias = oSqlDataReader.Item("numero_dias3")
                        oInstrucao3.Descricao = oSqlDataReader.Item("descricao_instrucao3")
                        oBoleto.Instrucoes.Add(oInstrucao3)
                    End If

                    oBoletoBancario.Boleto = oBoleto
                    oBoletoBancario.Boleto.Valida()

                    lBoleto.Add(oBoletoBancario)

                    'Gera Boleto Bancario
                    Call GeraLayoutBoletoBancario(lBoleto, sArquivoBoleto, sHTML)

                    'Acessando a classe para fazer a imagem direto do html
                    oBmp = WebsiteThumbnailImageGenerator.GetWebSiteThumbnail(sArquivoBoleto, iWebBrowserWidth, iWebBrowserHeight, iWidth, iHeight)

                    sBoletoPathBMP = System.IO.Path.Combine(System.IO.Path.GetTempPath, "Boleto_" & oSqlDataReader.Item("numero_parcela") & ".bmp")

                    'Salvar o arquivo temporário
                    oBmp.Save(sBoletoPathBMP)

                    sBoletoPathPDF = System.IO.Path.Combine(System.IO.Path.GetTempPath, sNotaFiscal & "_" & oSqlDataReader.Item("numero_parcela") & ".pdf")

                    'Define um documento tipo doc para depois salvar como PDF
                    oDoc = New Document(PageSize.A4, 40, 0, 40, 0)
                    'Instancia o documento para depois escrevê-lo como PDF
                    PdfWriter.GetInstance(oDoc, New FileStream(sBoletoPathPDF, FileMode.Create))
                    'Abre o DOC
                    oDoc.Open()
                    'Instancia um tipo imagem para salvar o documento
                    oGif = Image.GetInstance(sBoletoPathBMP)
                    'Define as dimensões
                    oGif.ScaleAbsolute(494.0F, 785.0F)

                    'Adiciona a imagem no documento
                    oDoc.Add(oGif)
                    'Fecha o do documento (e salva-o também)
                    oDoc.Close()

                    Application.DoEvents()

                    lBoleto.Clear()

                    sFilePDF = sFilePDF & """" & sBoletoPathPDF & """" & " "

                End While

                sBoletoPathPDF = System.IO.Path.Combine(System.IO.Path.GetTempPath, "BB_" & sNotaFiscal & ".pdf")

                'Agrupa Arquivos PDFs
                oClsPDFCreator.MergePDFFiles(sFilePDF, """" & sBoletoPathPDF & """")

                Application.DoEvents()

                sArquivo = sBoletoPathPDF

            End If

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close() : oSqlDataReader = Nothing

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadArquivoBoletoPDF2(ByVal lCodigoTituloCapa As Long, _
                                ByVal iCodigoEmpresa As Integer, _
                                ByVal sNotaFiscal As String, _
                                ByRef sArquivo As String, _
                                Optional ByVal iParcela As Integer = -1)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Carrega Dados - Emitente
            Call LoadDadosEmitente()

            'Seta Parametros - Código Título Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoTituloCapa : i += 1

            'Seta Parametros - Parcela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iParcela : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financerio_titulo_parcela_boleto_bancario_arquivo", oSqlParameter)

            If oSqlDataReader.HasRows = True Then

                'Váriavel - Boleto
                Dim lBoleto As New List(Of BoletoBancario)
                Dim oBoletoBancario As BoletoBancario
                Dim oInstrucao1 As Instrucao
                Dim oInstrucao2 As Instrucao
                Dim oCedente As Cedente
                'Variáveis - PDF                
                Dim sHTML As String = ""
                Dim sBoletoPathBMP As String
                Dim sBoletoPathPDF As String
                Dim iWidth As Integer = 680
                Dim iHeight As Integer = 1096
                Dim iWebBrowserWidth As Integer = 680
                Dim iWebBrowserHeight As Integer = 1096
                Dim oDoc As iTextSharp.text.Document
                Dim oBmp As System.Drawing.Bitmap
                Dim oGif As Image
                Dim sFilePDF As String = ""
                Dim oClsPDFCreator As New clsPDFCreator
                Dim sArquivoBoleto As String = ""
                'Dim sArquivoTotal As String = ""

                While oSqlDataReader.Read
                    sNotaFiscal = sNotaFiscal.Replace("/", "_")
                    'Seta Váriavel 
                    oBoletoBancario = New BoletoBancario

                    'Seta Codigo do Banco
                    oBoletoBancario.CodigoBanco = oSqlDataReader.Item("codigo_banco")

                    If oSqlDataReader.Item("digito_conta") = "" Then
                        oCedente = New Cedente(oSqlDataReader.Item("cnpj_empresa"), oSqlDataReader.Item("razao_social_empresa") & "<br>" & oSqlDataReader.Item("logradouro_empresa") & ", " & oSqlDataReader.Item("numero_empresa") & " - " & oSqlDataReader.Item("bairro_empresa"), oSqlDataReader.Item("agencia"), oSqlDataReader.Item("conta"))
                    Else
                        If Len(oSqlDataReader.Item("agencia")) = 5 Then
                            oCedente = New Cedente(oSqlDataReader.Item("cnpj_empresa"), oSqlDataReader.Item("razao_social_empresa") & "<br>" & oSqlDataReader.Item("logradouro_empresa") & ", " & oSqlDataReader.Item("numero_empresa") & " - " & oSqlDataReader.Item("bairro_empresa"), Mid(oSqlDataReader.Item("agencia"), 1, 4), Mid(oSqlDataReader.Item("agencia"), 5, 1), oSqlDataReader.Item("conta"), oSqlDataReader.Item("digito_conta"))
                        Else
                            oCedente = New Cedente(oSqlDataReader.Item("cnpj_empresa"), oSqlDataReader.Item("razao_social_empresa") & "<br>" & oSqlDataReader.Item("logradouro_empresa") & ", " & oSqlDataReader.Item("numero_empresa") & " - " & oSqlDataReader.Item("bairro_empresa"), oSqlDataReader.Item("agencia"), oSqlDataReader.Item("conta"), oSqlDataReader.Item("digito_conta"))
                        End If
                    End If

                    If oSqlDataReader.Item("convenio") = "" Then

                        oCedente.Convenio = 111111
                    Else
                        oCedente.Convenio = oSqlDataReader.Item("convenio")

                    End If
                    If CInt(oSqlDataReader.Item("codigo_banco")) = 33 Then
                        oCedente.Codigo = oSqlDataReader.Item("convenio")
                    ElseIf CInt(oSqlDataReader.Item("codigo_banco")) = 104 Then
                        oCedente.Codigo = oSqlDataReader.Item("convenio")
                    End If

                    If oSqlDataReader.Item("codigo_banco") = 341 Then
                        oCedente.ContaBancaria.Conta = CInt(oCedente.ContaBancaria.Conta)
                    End If

                    Dim oBoleto As New Boleto(oSqlDataReader.Item("data_vencimento"), oSqlDataReader.Item("valor"), oSqlDataReader.Item("carteira"), oSqlDataReader.Item("nosso_numero"), oCedente, New EspecieDocumento(oSqlDataReader.Item("codigo_banco"), 1))


                    oBoleto.NossoNumero = oSqlDataReader.Item("nosso_numero")

                    If oSqlDataReader.Item("nosso_numero").ToString.Length = 17 Then
                        oBoleto.NumeroDocumento = Right(oSqlDataReader.Item("nosso_numero").ToString, 10)
                    ElseIf oBoletoBancario.CodigoBanco = "748" Then
                        oBoleto.NossoNumero = Format(oSqlDataReader.Item("data_emissao"), "yy") + "2" + sNotaFiscal.PadLeft(4, "0") + CStr(oSqlDataReader.Item("numero_parcela"))
                        oBoleto.NumeroDocumento = sNotaFiscal + "-" + CStr(oSqlDataReader.Item("numero_parcela"))
                        oCedente.ContaBancaria.OperacaConta = oSqlDataReader.Item("conta") + oSqlDataReader.Item("digito_conta")
                    End If

                    oBoleto.Sacado = New Sacado(oSqlDataReader.Item("cnpj_sacado"), oSqlDataReader.Item("razao_social_sacado"))
                    oBoleto.Sacado.Endereco.End = oSqlDataReader.Item("logradouro_sacado") & ", " & oSqlDataReader.Item("numero_sacado") & IIf(oSqlDataReader.Item("complemento_sacado") = "", "", " - " & oSqlDataReader.Item("complemento_sacado"))
                    oBoleto.Sacado.Endereco.Bairro = oSqlDataReader.Item("bairro_sacado")
                    oBoleto.Sacado.Endereco.Cidade = oSqlDataReader.Item("cidade_sacado")
                    oBoleto.Sacado.Endereco.CEP = oSqlDataReader.Item("cep_sacado")
                    oBoleto.Sacado.Endereco.UF = oSqlDataReader.Item("uf_sacado")
                    oBoleto.Sacado.Endereco.Logradouro = oSqlDataReader.Item("logradouro_sacado")
                    oBoleto.Sacado.Endereco.Numero = oSqlDataReader.Item("numero_sacado")
                    oBoleto.Sacado.Endereco.Complemento = oSqlDataReader.Item("complemento_sacado")

                    If (oSqlDataReader.Item("codigo_banco") = "0001") Then
                        oBoleto.EspecieDocumento = New EspecieDocumento(oSqlDataReader.Item("codigo_banco"), 2)
                    ElseIf oBoletoBancario.CodigoBanco = "748" Then
                        oBoleto.EspecieDocumento.Sigla = "DMI"
                    ElseIf oBoletoBancario.CodigoBanco = "104" Then
                        oBoleto.EspecieDocumento.Sigla = "DS"
                    End If

                    'Instrução 1
                    If oSqlDataReader.Item("instrucao1") <> "" Then
                        oInstrucao1 = New Instrucao(oSqlDataReader.Item("codigo_banco"))
                        oInstrucao1.Codigo = oSqlDataReader.Item("instrucao1")
                        If oSqlDataReader.Item("numero_dias1") > -1 Then oInstrucao1.QuantidadeDias = oSqlDataReader.Item("numero_dias1")
                        oInstrucao1.Descricao = oSqlDataReader.Item("descricao_instrucao1")
                        oBoleto.Instrucoes.Add(oInstrucao1)
                    End If

                    'Instrução 2
                    If oSqlDataReader.Item("instrucao2") <> "" Then
                        oInstrucao2 = New Instrucao(oSqlDataReader.Item("codigo_banco"))
                        oInstrucao2.Codigo = oSqlDataReader.Item("instrucao2")
                        If oSqlDataReader.Item("numero_dias2") > -1 Then oInstrucao2.QuantidadeDias = oSqlDataReader.Item("numero_dias2")
                        oInstrucao2.Descricao = oSqlDataReader.Item("descricao_instrucao2")
                        oBoleto.Instrucoes.Add(oInstrucao2)
                    End If



                    oBoletoBancario.Boleto = oBoleto
                    oBoletoBancario.Boleto.Valida()

                    If oBoletoBancario.CodigoBanco <> "748" Then

                        oBoletoBancario.Boleto.NumeroDocumento = sNotaFiscal
                    End If

                    'Formatação específica do sicredi
                    If oBoletoBancario.CodigoBanco = "748" Then

                        oBoletoBancario.Boleto.NossoNumero = Left(oBoletoBancario.Boleto.NossoNumero, 2) + _
                                                            "/" + _
                                                            Mid(oBoletoBancario.Boleto.NossoNumero, 3, 6) + _
                                                            "-" + _
                                                            Right(oBoletoBancario.Boleto.NossoNumero, 1)


                    End If

                    If oBoletoBancario.Banco.Codigo = "033" Or oBoletoBancario.Banco.Codigo = "237" Then
                        oBoletoBancario.OcultarInstrucoes = True
                    End If

                    lBoleto.Add(oBoletoBancario)

                    'Gera Boleto Bancario
                    ' Call GeraLayoutBoletoBancario(lBoleto, sArquivoBoleto, sHTML)
                    Call GeraLayoutBoletoBancario(sNotaFiscal & "_" & oSqlDataReader.Item("numero_parcela"), lBoleto, sArquivo)



                    'Acessando a classe para fazer a imagem direto do html
                    oBmp = WebsiteThumbnailImageGenerator.GetWebSiteThumbnail(sArquivo, iWebBrowserWidth, iWebBrowserHeight, iWidth, iHeight)

                    sBoletoPathBMP = System.IO.Path.Combine(System.IO.Path.GetTempPath, "Boleto_" & oSqlDataReader.Item("numero_parcela") & ".bmp")

                    'Salvar o arquivo temporário
                    oBmp.Save(sBoletoPathBMP)

                    sBoletoPathPDF = System.IO.Path.GetTempPath & "BOLETO_" & goUsuario.sSiglaEmpresa & "_" + sNotaFiscal.Replace("/", "_") & oSqlDataReader.Item("numero_parcela") & ".pdf"

                    'Define um documento tipo doc para depois salvar como PDF
                    oDoc = New Document(PageSize.A4, 46, 0, 40, 0)
                    'Instancia o documento para depois escrevê-lo como PDF
                    PdfWriter.GetInstance(oDoc, New FileStream(sBoletoPathPDF, FileMode.Create))
                    'Abre o DOC
                    oDoc.Open()
                    'Instancia um tipo imagem para salvar o documento
                    oGif = iTextSharp.text.Image.GetInstance(sBoletoPathBMP)
                    'Define as dimensões
                    oGif.ScaleAbsolute(494.0F, 785.0F)

                    'Adiciona a imagem no documento
                    oDoc.Add(oGif)
                    'Fecha o do documento (e salva-o também)

                    oDoc.Close()

                    Application.DoEvents()

                    lBoleto.Clear()

                    'sFilePDF = sFilePDF & """" & sBoletoPathPDF & """" & " | "
                    sFilePDF = sFilePDF & """" & sBoletoPathPDF & """" & "  "

                    'sArquivoTotal += sFilePDF

                End While

                'Comentei essa linha de baixo, pois estava carregando o boleto anterior ao clicar no botão do e-mail
                'sBoletoPathPDF = System.IO.Path.Combine(System.IO.Path.GetTempPath, "BB_" & sNotaFiscal & ".pdf")

                'If File.Exists(sBoletoPathPDF) Then
                '    File.Delete(sBoletoPathPDF)
                'End If

                'Comentei essa linha de baixo, pois estava carregando o boleto anterior ao clicar no botão do e-mail
                sBoletoPathPDF = System.IO.Path.Combine(System.IO.Path.GetTempPath, "BB_" & sNotaFiscal & ".pdf")

                'Agrupa Arquivos PDFs
                oClsPDFCreator.MergePDFFiles(sFilePDF, """" & sBoletoPathPDF & """")
                System.Threading.Thread.Sleep(5000)
                'Application.DoEvents()

                sArquivo = sBoletoPathPDF

            End If

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close() : oSqlDataReader = Nothing

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
