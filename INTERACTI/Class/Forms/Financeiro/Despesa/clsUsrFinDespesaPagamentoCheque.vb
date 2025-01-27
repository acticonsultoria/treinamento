Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class clsUsrFinDespesaPagamentoCheque

#Region "::: VARIAVEIS :::"

    Private iContaBancaria As Integer
    Private iTipoDocumentoPagamento As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property ContaBancaria() As Integer
        Get
            Return iContaBancaria
        End Get
        Set(ByVal value As Integer)
            iContaBancaria = value
        End Set
    End Property

    Public Property TipoDocumentoPagamento() As Integer
        Get
            Return iTipoDocumentoPagamento
        End Get
        Set(ByVal value As Integer)
            iTipoDocumentoPagamento = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub Atualizar(ByVal dValor As Double, _
                          ByVal sNumeroCheque As String)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValor : i += 1

            'Seta Parametros - Nº Cheque
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_cheque"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sNumeroCheque : i += 1

            'Seta Parametros - Código Usuario
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
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_financeiro_titulo_parcela_pagamento_valor_cheque", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sNumeroDocumento As String, _
                        ByVal sDataEmissaoInicio As String, _
                        ByVal sDataEmissaoTermino As String, _
                        ByVal sParceiroNegocio As String, _
                        ByVal sDataVencimentoInicio As String, _
                        ByVal sDataVencimentoTermino As String, _
                        ByVal dValor As Double, _
                        ByVal bAdiantamento As Boolean)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(9) As SqlParameter
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
            oSqlParameter(i).Value = IIf(sDataEmissaoInicio = "", DBNull.Value, sDataEmissaoInicio) : i += 1

            'Seta Parametros - Data Emissão Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataEmissaoTermino = "", DBNull.Value, sDataEmissaoTermino) : i += 1

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

            'Seta Parametros - Valor 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dValor = 0, DBNull.Value, dValor) : i += 1

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Char
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = "D" : i += 1

            'Seta Parametros - Adiantamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "adiantamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAdiantamento : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_titulo_pagamento", oSqlParameter)

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

    Public Sub LoadDadosChequeTerceiro(ByVal lCodigo As Long, _
                                       ByVal lCodigoReceitaCapa As Long, _
                                       ByVal txtBanco As MaskedEditBox, _
                                       ByVal txtAgencia As MaskedEditBox, _
                                       ByVal txtConta As MaskedEditBox, _
                                       ByVal txtRecebidoEm As MaskedEditBox, _
                                       ByVal txtDataPreDatado As MaskedEditBox, _
                                       ByVal txtValor As NumericEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código Receita Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_receita_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoReceitaCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_receita_dados_pagamento", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    'Seta Valores da Célula
                    txtBanco.Text = oSqlDataReader.Item("banco")
                    txtAgencia.Text = oSqlDataReader.Item("agencia_cheque")
                    txtConta.Text = oSqlDataReader.Item("conta_cheque")
                    txtRecebidoEm.Text = oSqlDataReader.Item("data_pagamento")
                    txtDataPreDatado.Text = IIf(IsDBNull(oSqlDataReader.Item("data_pre_datado")), "", oSqlDataReader.Item("data_pre_datado"))
                    txtValor.Value = oSqlDataReader.Item("valor")

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

    Public Sub LoadDadosCheque(ByVal sNumeroDocumento As String, _
                               ByVal txtFavorecido As MaskedEditBox, _
                               ByVal txtValor As NumericEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Numero Cheque
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_cheque"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroDocumento : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_receita_dados_pagamento_cheque", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    'Seta Valores da Célula
                    txtFavorecido.Text = oSqlDataReader.Item("cliente")
                    txtValor.Value = oSqlDataReader.Item("valor")

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

    Public Sub UpdateParcela(ByVal oGrid As GridEX, _
                             ByVal iTipo As Integer)

        'Variaveis Locais
        Dim i As Integer
        Dim oRow As GridEXRow
        Dim oSqlParameter(8) As SqlParameter

        Try

            For Each oRow In oGrid.GetDataRows()

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Despesa Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_titulo_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo_titulo_capa").Value : i += 1

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
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("numero_parcela").Value : i += 1

                'Seta Parametros - Data Vencimento
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data_vencimento"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = oRow.Cells("data_vencimento").Value : i += 1

                'Seta Parametros - Valor Pago
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor_pago"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("valor_pago").Value : i += 1

                'Seta Parametros - Valor Devido
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor_devido"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("valor_devido").Value : i += 1

                'Seta Parametros - Desconto
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "desconto"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("desconto").Value : i += 1

                'Seta Parametros - Juros
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "juros"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("juros").Value : i += 1

                'Seta Parametros - Tipo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "tipo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = iTipo

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_financeiro_titulo_parcela", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Public Sub InsertPagamentoMultiplo(ByVal grdParcela As GridEX, _
                                    ByVal grdPagamento As GridEX)

        'Variaveis Locais
        Dim oRowParcela As GridEXRow
        Dim oRowPagamento As GridEXRow
        'Dim dValorParcela As Double
        Dim dValorPagamento As Double
        Dim oSqlParameter(30) As SqlParameter
        Dim i As Integer
        Dim iPagamento As Integer
        Try

            For Each oRowParcela In grdParcela.GetDataRows

                'dValorParcela = oRowParcela.Cells("valor_pago").Value

                iPagamento = 1

                For Each oRowPagamento In grdPagamento.GetDataRows

                    dValorPagamento = FormatNumber((oRowPagamento.Cells("valor").Value / CDbl(grdParcela.RecordCount)), 2)

                    Dim dResiduo As Double = FormatNumber(oRowPagamento.Cells.Item("valor").Value, 2) - FormatNumber((dValorPagamento * CDbl(grdParcela.RecordCount)), 2)

                    If dValorPagamento > 0 Then

                        'Seta Váriavel
                        i = 0

                        'Seta Parametros - Código Despesa Capa
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "codigo_titulo_capa"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                        oSqlParameter(i).Value = oRowParcela.Cells("codigo_titulo_capa").Value : i += 1

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
                        oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                        oSqlParameter(i).Value = oRowParcela.Cells("numero_parcela").Value : i += 1

                        'Seta Parametros - Código Banco Conta
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "codigo_banco_conta"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.Int
                        oSqlParameter(i).Value = oRowPagamento.Cells("codigo_banco_conta").Value : i += 1

                        'Seta Parametros - Código Tipo Documento Pagamento
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "codigo_tipo_documento_pagamento"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                        oSqlParameter(i).Value = oRowPagamento.Cells("codigo_tipo_documento_pagamento").Value : i += 1

                        'Seta Parametros - Número do Documento
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "numero_documento"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                        oSqlParameter(i).Size = 100
                        oSqlParameter(i).Value = oRowPagamento.Cells("numero_documento").Value : i += 1

                        'Seta Parametros - Data Pagamento
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "data_pagamento"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                        oSqlParameter(i).Value = oRowPagamento.Cells("data_pagamento").Value : i += 1

                        'Seta Parametros - Valor
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "valor"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.Float
                        oSqlParameter(i).Value = IIf(iPagamento = 1, dValorPagamento + dResiduo, dValorPagamento) : i += 1


                        'Seta Parametros - Banco
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "banco"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                        oSqlParameter(i).Size = 100
                        oSqlParameter(i).Value = oRowPagamento.Cells("banco").Value : i += 1

                        'Seta Parametros - Favorecido
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "favorecido"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                        oSqlParameter(i).Size = 100
                        oSqlParameter(i).Value = oRowPagamento.Cells("favorecido").Value : i += 1

                        'Seta Parametros - Pré Datado
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "pre_datado"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.Bit
                        If IsDBNull(oRowPagamento.Cells("pre_datado").Value) Then
                            oSqlParameter(i).Value = DBNull.Value : i += 1
                        Else
                            oSqlParameter(i).Value = IIf(oRowPagamento.Cells("pre_datado").Value = "1", True, False) : i += 1
                        End If

                        'Seta Parametros - Data Pré Datado
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "data_pre_datado"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                        oSqlParameter(i).Value = oRowPagamento.Cells("data_pre_datado").Value : i += 1

                        'Seta Parametros - Código Titulo Capa Receita
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "codigo_titulo_capa_receita"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                        oSqlParameter(i).Value = oRowPagamento.Cells("codigo_titulo_capa_receita").Value : i += 1

                        'Seta Parametros - Código Título Parcela Pagamento Receita
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "codigo_titulo_parcela_pagamento_receita"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                        oSqlParameter(i).Value = oRowPagamento.Cells("codigo_titulo_parcela_pagamento_receita").Value : i += 1

                        'Seta Parametros - Numero Parcela Receita
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "numero_parcela_receita"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                        oSqlParameter(i).Value = oRowPagamento.Cells("numero_parcela_receita").Value : i += 1

                        'Seta Parametros - Código Cartão de Crédito
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "codigo_cartao_credito"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                        oSqlParameter(i).Value = oRowPagamento.Cells("codigo_cartao_credito").Value : i += 1

                        'Seta Parametros - Nº Parcela Cartão Crédito
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "numero_parcela_cartao_credito"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                        oSqlParameter(i).Value = oRowPagamento.Cells("numero_parcela_cartao_credito").Value : i += 1

                        'Seta Parametros - Status
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "status"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                        oSqlParameter(i).Value = oRowPagamento.Cells("status").Value : i += 1

                        'Seta Parametros - Código Usuário
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "codigo_usuario"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.Int
                        oSqlParameter(i).Value = goUsuario.iUsuario

                        'Executa Query
                        ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_titulo_parcela_pagamento", oSqlParameter)

                        iPagamento += 1

                    End If

                Next

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Public Sub InsertPagamento(ByVal grdParcela As GridEX, _
                               ByVal grdPagamento As GridEX)

        'Variaveis Locais
        Dim i As Integer
        Dim dValorParcela As Double
        Dim dValorPagamento As Double
        Dim oRowParcela As GridEXRow
        Dim oRowPagamento As GridEXRow
        Dim oSqlParameter(18) As SqlParameter

        Try

            For Each oRowParcela In grdParcela.GetDataRows

                dValorParcela = oRowParcela.Cells("valor_pago").Value

                For Each oRowPagamento In grdPagamento.GetDataRows

                    dValorPagamento = (oRowPagamento.Cells("valor").Value - oRowPagamento.Cells("valor_associado").Value)

                    'Seta Váriavel
                    i = 0

                    'Seta Parametros - Código Despesa Capa
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_titulo_capa"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                    oSqlParameter(i).Value = oRowParcela.Cells("codigo_titulo_capa").Value : i += 1

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
                    oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                    oSqlParameter(i).Value = oRowParcela.Cells("numero_parcela").Value : i += 1

                    'Seta Parametros - Código Banco Conta
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_banco_conta"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.Int
                    oSqlParameter(i).Value = oRowPagamento.Cells("codigo_banco_conta").Value : i += 1

                    'Seta Parametros - Código Tipo Documento Pagamento
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_tipo_documento_pagamento"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                    oSqlParameter(i).Value = oRowPagamento.Cells("codigo_tipo_documento_pagamento").Value : i += 1

                    'Seta Parametros - Número do Documento
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "numero_documento"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                    oSqlParameter(i).Size = 100
                    oSqlParameter(i).Value = oRowPagamento.Cells("numero_documento").Value : i += 1

                    'Seta Parametros - Data Pagamento
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "data_pagamento"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                    oSqlParameter(i).Value = oRowPagamento.Cells("data_pagamento").Value : i += 1

                    'Seta Parametros - Valor
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "valor"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.Float
                    oSqlParameter(i).Value = IIf(dValorParcela > dValorPagamento, dValorPagamento, dValorParcela) : i += 1

                    'Seta Parametros - Banco
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "banco"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                    oSqlParameter(i).Size = 100
                    oSqlParameter(i).Value = oRowPagamento.Cells("banco").Value : i += 1

                    'Seta Parametros - Favorecido
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "favorecido"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                    oSqlParameter(i).Size = 100
                    oSqlParameter(i).Value = oRowPagamento.Cells("favorecido").Value : i += 1

                    'Seta Parametros - Pré Datado
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "pre_datado"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.Bit
                    If IsDBNull(oRowPagamento.Cells("pre_datado").Value) Then
                        oSqlParameter(i).Value = DBNull.Value : i += 1
                    Else
                        oSqlParameter(i).Value = IIf(oRowPagamento.Cells("pre_datado").Value = "1", True, False) : i += 1
                    End If

                    'Seta Parametros - Data Pré Datado
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "data_pre_datado"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                    oSqlParameter(i).Value = oRowPagamento.Cells("data_pre_datado").Value : i += 1

                    'Seta Parametros - Código Titulo Capa Receita
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_titulo_capa_receita"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                    oSqlParameter(i).Value = oRowPagamento.Cells("codigo_titulo_capa_receita").Value : i += 1

                    'Seta Parametros - Código Título Parcela Pagamento Receita
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_titulo_parcela_pagamento_receita"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                    oSqlParameter(i).Value = oRowPagamento.Cells("codigo_titulo_parcela_pagamento_receita").Value : i += 1

                    'Seta Parametros - Numero Parcela Receita
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "numero_parcela_receita"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                    oSqlParameter(i).Value = oRowPagamento.Cells("numero_parcela_receita").Value : i += 1

                    'Seta Parametros - Código Cartão de Crédito
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_cartao_credito"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                    oSqlParameter(i).Value = oRowPagamento.Cells("codigo_cartao_credito").Value : i += 1

                    'Seta Parametros - Nº Parcela Cartão Crédito
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "numero_parcela_cartao_credito"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                    oSqlParameter(i).Value = oRowPagamento.Cells("numero_parcela_cartao_credito").Value : i += 1

                    'Seta Parametros - Status
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "status"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                    oSqlParameter(i).Value = oRowPagamento.Cells("status").Value : i += 1

                    'Seta Parametros - Código Usuário
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_usuario"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.Int
                    oSqlParameter(i).Value = goUsuario.iUsuario

                    'Executa Query
                    ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_titulo_parcela_pagamento", oSqlParameter)

                    grdPagamento.Row = oRowPagamento.RowIndex
                    'Seta Valor
                    grdPagamento.SetValue("valor_associado", grdPagamento.GetValue("valor_associado") + IIf(dValorParcela > dValorPagamento, dValorPagamento, dValorParcela))
                    dValorParcela -= IIf(dValorParcela > dValorPagamento, dValorPagamento, dValorParcela)

                    If dValorParcela = 0 Then Exit For

                Next

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateParcelaIndividual(ByVal lCodigoTituloCapa As Long, _
                                       ByVal iNumeroParcela As Integer, _
                                       ByVal sDataVencimento As String, _
                                       ByVal dValorPago As Double, _
                                       ByVal dValorDevido As Double, _
                                       ByVal dDesconto As Double, _
                                       ByVal dJuros As Double, _
                                       ByVal iTipo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Despesa Capa
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
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iNumeroParcela : i += 1

            'Seta Parametros - Data Vencimento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataVencimento : i += 1

            'Seta Parametros - Valor Pago
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_pago"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorPago : i += 1

            'Seta Parametros - Valor Devido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_devido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorDevido : i += 1

            'Seta Parametros - Desconto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desconto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDesconto : i += 1

            'Seta Parametros - Juros
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "juros"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dJuros : i += 1

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iTipo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_financeiro_titulo_parcela", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertPagamentoIndividual(ByVal lCodigoTituloCapa As Long, _
                                         ByVal iNumeroParcela As Integer, _
                                         ByVal grdPagamento As GridEX)

        'Variaveis Locais
        Dim i As Integer
        Dim oSqlParameter(16) As SqlParameter

        Try

            For Each oRow As GridEXRow In grdPagamento.GetDataRows

                i = 0

                'Seta Parametros - Código Despesa Capa
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
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = iNumeroParcela : i += 1

                'Seta Parametros - Código Banco Conta
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_banco_conta"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo_banco_conta").Value : i += 1

                'Seta Parametros - Código Tipo Documento Pagamento
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_tipo_documento_pagamento"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo_tipo_documento_pagamento").Value : i += 1

                'Seta Parametros - Número do Documento
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero_documento"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 100
                oSqlParameter(i).Value = oRow.Cells("numero_documento").Value : i += 1

                'Seta Parametros - Data Pagamento
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data_pagamento"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = oRow.Cells("data_pagamento").Value : i += 1

                'Seta Parametros - Valor
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("valor").Value : i += 1

                'Seta Parametros - Banco
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "banco"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 100
                oSqlParameter(i).Value = oRow.Cells("banco").Value : i += 1

                'Seta Parametros - Favorecido
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "favorecido"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 100
                oSqlParameter(i).Value = oRow.Cells("favorecido").Value : i += 1

                'Seta Parametros - Pré Datado
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "pre_datado"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Bit
                If IsDBNull(oRow.Cells("pre_datado").Value) Then
                    oSqlParameter(i).Value = DBNull.Value : i += 1
                Else
                    oSqlParameter(i).Value = IIf(oRow.Cells("pre_datado").Value = "1", True, False) : i += 1
                End If

                'Seta Parametros - Data Pré Datado
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data_pre_datado"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = oRow.Cells("data_pre_datado").Value : i += 1

                'Seta Parametros - Código Titulo Capa Receita
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_titulo_capa_receita"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo_titulo_capa_receita").Value : i += 1

                'Seta Parametros - Código Título Parcela Pagamento Receita
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_titulo_parcela_pagamento_receita"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo_titulo_parcela_pagamento_receita").Value : i += 1

                'Seta Parametros - Numero Parcela Receita
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero_parcela_receita"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("numero_parcela_receita").Value : i += 1

                'Seta Parametros - Status
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "status"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("status").Value : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_usuario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = goUsuario.iUsuario

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_titulo_parcela_pagamento", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
