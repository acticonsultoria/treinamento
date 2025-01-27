Imports System.Data
Imports System.Data.SqlClient
Imports System.IO.File
Imports INTERACTI.SQLHelper
Imports System.Text
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports System.IO

Public Class clsUsrFinReceitaCobranca

#Region "::: VARIAVEIS :::"

    Private sArquivoScript As StreamWriter

#End Region

#Region "::: PROPERTIE ::: "

    Public Property ArquivoScript() As StreamWriter
        Get
            Return sArquivoScript
        End Get
        Set(ByVal value As StreamWriter)
            sArquivoScript = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                         ByVal sNumeroDocumento As String, _
                         ByVal sDataEmissaoInicio As String, _
                         ByVal sDataEmissaoTermino As String, _
                         ByVal sParceiroNegocio As String, _
                         ByVal sDataVencimentoInicio As String, _
                         ByVal sDataVencimentoTermino As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(7) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Número Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNumeroDocumento : i += 1

            'Seta Parametros - Data Emissão Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataEmissaoInicio), sDataEmissaoInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Emissão Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataEmissaoTermino), sDataEmissaoTermino, DBNull.Value) : i += 1

            'Seta Parametros - Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sParceiroNegocio : i += 1

            'Seta Parametros - Data Vencimento Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataVencimentoInicio = "", DBNull.Value, sDataVencimentoInicio) : i += 1

            'Seta Parametros - Data Vencimento Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataVencimentoTermino = "", DBNull.Value, sDataVencimentoTermino) : i += 1

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Char
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = "R" : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            'oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_titulo_cobranca", oSqlParameter)

            ''Configura DataMember Grid
            'Call ConfigurarDataMemberGrid(oGrid)

            ''Carrega Grid
            'oGrid.DataSource = oDataSet.DefaultViewManager
            'oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_titulo_cobranca", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oDataSet.Tables(0).Columns("pk"), oDataSet.Tables(1).Columns("pk"))

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

    Public Sub UpdateTipoNegativacaoCliente(ByVal iCodigoParceiroNegocio As Integer, _
                                            ByVal iCodigoTipoNegativacao As TipoNegativacaoCliente, _
                                            ByVal sTextoNegativacao As String)

        'Variaveis Locais
        Dim i As Integer = 0
        Dim oSqlParameter(4) As SqlParameter
        Dim oSqlDataReader As SqlDataReader

        Try

            'Seta Parametros - Código Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_negativacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = CInt(iCodigoTipoNegativacao) : i += 1

            'Seta Parametros - Texto Negativação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "texto_negativacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5000
            oSqlParameter(i).Value = sTextoNegativacao.Trim : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_cadastro_basico_parceiro_negocio_negativacao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateProtesto()

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_titulo_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_titulo_parcela"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo_parcela").Value : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_usuario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_financeiro_receita_protesto", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateEnvio()

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_titulo_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_titulo_parcela"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo_parcela").Value : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_usuario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_financeiro_receita_envio", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateCobranca()

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_titulo_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_titulo_parcela"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo_parcela").Value : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_usuario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_financeiro_receita_cobranca", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridProtesto(ByVal oGrid As GridEX, _
                                ByVal sCliente As String, _
                                ByVal sDataInicio As String, _
                                ByVal sDataTermino As String, _
                                ByVal sStatus As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(sStatus = "", DBNull.Value, sStatus) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCliente : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio_vencimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataInicio = "", DBNull.Value, sDataInicio) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino_vencimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataTermino = "", DBNull.Value, sDataTermino) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_titulo_cobranca_protesto", oSqlParameter)

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

            'Seta Parametros - Código Banco
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nosso_numero"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt : i += 1

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

    Public Sub LoadGridCartaBoleto(ByVal oGrid As GridEX, _
                                   ByVal sCodigo As String, _
                                   ByVal sCodigoParcela As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(7) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCodigo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCodigoParcela : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_titulo_cobranca_carta_boleto", oSqlParameter)

            'Configura DataMember Grid
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

    Public Sub UpdateTituloCartaBoleta(ByVal lCodigoTituloCapa As Long, _
                                        ByVal iNumeroParcela As Integer, _
                                        ByVal dValorCorrigido As Double, _
                                        ByVal dDataVencimento As Date, _
                                        ByVal dPercentual As Double)

        'Variaveis Locais
        Dim oSqlParameter(13) As SqlParameter
        Dim i As Integer

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoTituloCapa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iNumeroParcela : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_corrigido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorCorrigido : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = dDataVencimento : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "percentual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPercentual : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_financeiro_titulo_cobranca_carta_boleto", oSqlParameter)



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
                                  ByVal bPago As Boolean, _
                                  ByVal dJuros As Double, _
                                  ByVal dMulta As Double, _
                                  ByVal dValorAntigo As Double, _
                                  ByVal dDataAntiga As Date)

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

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento_antiga"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = dDataAntiga : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_antigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAntigo : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "carta_boleto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = True

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_cobranca_titulo_parcela_boleto_bancario", oSqlParameter)



        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub GerarArquivoScript(ByVal sCodigosTituloCapa As String)

        'Variaveis Locaisn
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0
        Dim sLinha As New StringBuilder
        Dim iCont As Integer = 0
        Dim sCampo As String
        Dim sErro As String = ""

        Try

            'Seta Parametros - Código da Empresa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(0).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_titulo_capa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Value = sCodigosTituloCapa

            oSqlDataReader = SQLHelper.ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_titulo_cobranca_carta_boleto_script", oSqlParameter)


            While oSqlDataReader.Read
                'Zera Variavel Auxiliar
                sLinha.Remove(0, sLinha.Length)
                'Incrementando o contador
                iCont += 1

                'Recebendo o campo e tratando
                sCampo = IIf(IsDBNull(oSqlDataReader.Item("linha")), "", oSqlDataReader.Item("linha"))
                'Seta Variavel com o Valor da Linha
                sLinha.Append(sCampo)

                'Escreve Linha
                sArquivoScript.WriteLine(sLinha.ToString)

            End While

            'Fecha o oSqlDataReader
            oSqlDataReader.Close()


        Catch ex As Exception
            Throw ex
        End Try

    End Sub
#End Region

End Class
