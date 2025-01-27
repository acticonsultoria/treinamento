Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class clsUsrFinReceitaPagamento

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

    Public Function ValidaCheque(ByVal sNumeroCheque As String) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0
        Dim iReturn As Integer

        Try

            'Seta Retorno da Função
            ValidaCheque = False

            'Seta Parametros - Nº Cheque
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_cheque"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sNumeroCheque : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_financeiro_receita_cheque", oSqlParameter), Integer)

            'Seta Retorno da Função
            ValidaCheque = IIf(iReturn > 0, False, True)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sNumeroDocumento As String, _
                        ByVal sDataEmissaoInicio As String, _
                        ByVal sDataEmissaoTermino As String, _
                        ByVal sParceiroNegocio As String, _
                        ByVal sDataVencimentoInicio As String, _
                        ByVal sDataVencimentoTermino As String, _
                        ByVal dValor As Double, _
                        ByVal sDataReferencia As String, _
                        ByVal bAdiantamento As Boolean, _
                        ByVal iAVista As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(11) As SqlParameter
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
            oSqlParameter(i).Value = "R" : i += 1

            'Seta Parametros - Adiantamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "adiantamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAdiantamento : i += 1

            'Seta Parametros - A Vista
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "a_vista"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = IIf(iAVista = -1, DBNull.Value, IIf(iAVista = 1, True, False)) : i += 1

            'Seta Parametros - Data Referência
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_referencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataReferencia : i += 1

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

    Public Sub LoadDadosChequeTerceiro(ByVal lCodigoTituloCapa As Long, _
                                       ByVal iNumeroParcela As Integer, _
                                       ByVal iCodigo As Integer, _
                                       ByVal txtBanco As MaskedEditBox, _
                                       ByVal txtRecebidoEm As MaskedEditBox, _
                                       ByVal txtDataPreDatado As MaskedEditBox, _
                                       ByVal txtValor As NumericEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Titulo Capa
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

            'Seta Parametros - Número da Parcela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iNumeroParcela : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigo


            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_titulo_dados_pagamento", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    'Seta Valores da Célula
                    txtBanco.Text = oSqlDataReader.Item("banco")
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

    Public Sub UpdateParcela(ByVal oGrid As GridEX, _
                             ByVal iTipo As Integer)

        'Variaveis Locais
        Dim i As Integer
        Dim oRow As GridEXRow
        Dim oSqlParameter(8) As SqlParameter

        Try

            For Each oRow In oGrid.GetDataRows

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Receita Capa
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

                        'Seta Parametros - Código Receita Capa
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

                        'Seta Parametros - Valor Baixado
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "valor_baixado"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.Float
                        oSqlParameter(i).Value = oRowPagamento.Cells("valor_baixado").Value : i += 1

                        'Seta Parametros - Valor Cheque
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "valor_cheque"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.Float
                        oSqlParameter(i).Value = oRowPagamento.Cells("valor_cheque").Value : i += 1

                        'Seta Parametros - Descricao Cheque
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "descricao_cheque"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                        oSqlParameter(i).Value = oRowPagamento.Cells("descricao_cheque").Value : i += 1

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
        Dim oRowParcela As GridEXRow
        Dim oRowPagamento As GridEXRow
        Dim dValorParcela As Double
        Dim dValorPagamento As Double
        Dim oSqlParameter(18) As SqlParameter
        Dim i As Integer

        Try

            For Each oRowParcela In grdParcela.GetDataRows

                dValorParcela = oRowParcela.Cells("valor_pago").Value

                For Each oRowPagamento In grdPagamento.GetDataRows

                    dValorPagamento = (oRowPagamento.Cells("valor").Value - oRowPagamento.Cells("valor_associado").Value)

                    If dValorPagamento > 0 Then

                        'Seta Váriavel
                        i = 0

                        'Seta Parametros - Código Receita Capa
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
                        oSqlParameter(i).Value = IIf(oRowPagamento.Cells("codigo_banco_conta").Value = 0, DBNull.Value, oRowPagamento.Cells("codigo_banco_conta").Value) : i += 1

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

                        'Seta Parametros - Data Creditado
                        oSqlParameter(i) = New SqlParameter
                        oSqlParameter(i).ParameterName = "data_creditado"
                        oSqlParameter(i).Direction = ParameterDirection.Input
                        oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                        oSqlParameter(i).Value = DBNull.Value : i += 1

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

                    End If

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

    Public Sub InsertPagamentoIndividual(ByVal lCodigoTituloCapa As Long, _
                                         ByVal iNumeroParcela As Integer, _
                                         ByVal iCodigoBancoConta As Integer, _
                                         ByVal iCodigoTipoDocumentoPagamento As Integer, _
                                         ByVal sNumeroDocumento As String, _
                                         ByVal sDataPagamento As String, _
                                         ByVal dValor As Double, _
                                         ByVal sBanco As String, _
                                         ByVal sFavorecido As String, _
                                         ByVal iPreDatado As Integer, _
                                         ByVal sDataPreDatado As String, _
                                         ByVal lCodigoTituloCapaReceita As Long, _
                                         ByVal iCodigoTituloPagamentoReceita As Integer, _
                                         ByVal iNumeroParcelaReceita As Integer, _
                                         ByVal iStatus As Integer)

        'Variaveis Locais
        Dim i As Integer = 0
        Dim oSqlParameter(16) As SqlParameter

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
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iNumeroParcela : i += 1

            'Seta Parametros - Código Banco Conta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco_conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoBancoConta : i += 1

            'Seta Parametros - Código Tipo Documento Pagamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_documento_pagamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoDocumentoPagamento : i += 1

            'Seta Parametros - Número do Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(sNumeroDocumento = "", DBNull.Value, sNumeroDocumento) : i += 1

            'Seta Parametros - Data Pagamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_pagamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataPagamento : i += 1

            'Seta Parametros - Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValor : i += 1

            'Seta Parametros - Banco
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "banco"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(sBanco = "", DBNull.Value, sBanco) : i += 1

            'Seta Parametros - Favorecido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "favorecido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(sFavorecido = "", DBNull.Value, sFavorecido) : i += 1

            'Seta Parametros - Pré Datado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pre_datado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = IIf(iPreDatado = -1, DBNull.Value, iPreDatado) : i += 1

            'Seta Parametros - Data Pré Datado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_pre_datado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataPreDatado = "", DBNull.Value, sDataPreDatado) : i += 1

            'Seta Parametros - Código Titulo Capa Receita
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_capa_receita"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoTituloCapaReceita = -1, DBNull.Value, lCodigoTituloCapaReceita) : i += 1

            'Seta Parametros - Código Título Parcela Pagamento Receita
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_parcela_pagamento_receita"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoTituloPagamentoReceita = -1, DBNull.Value, iCodigoTituloPagamentoReceita) : i += 1

            'Seta Parametros - Numero Parcela Receita
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela_receita"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iNumeroParcela = -1, DBNull.Value, iNumeroParcela) : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iStatus : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_titulo_parcela_pagamento_individual", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertDuplicataDescontada(ByVal iCodigoBancoConta As Integer, _
                                         ByVal dValor As Double, _
                                         ByVal sDataPagamento As String, _
                                         ByVal sNumeroDocumentoPagamento As String, _
                                         ByVal dValorTotal As Double, _
                                         ByRef lCodigoTituloDespesa As Long, _
                                         ByRef lCodigoTituloReceita As Long)

        'Variaveis Locais
        Dim i As Integer = 0
        Dim oSqlParameter(8) As SqlParameter

        Try

            'Seta Parametros - Código Título Despesa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_despesa"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt : i += 1

            'Seta Parametros - Código Título Receita
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_receita"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Banco Conta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco_conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoBancoConta : i += 1

            'Seta Parametros - Número do Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNumeroDocumentoPagamento : i += 1

            'Seta Parametros - Data Pagamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_pagamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataPagamento : i += 1

            'Seta Parametros - Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValor : i += 1

            'Seta Parametros - Valor Total
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_total"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorTotal : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_titulo_desconto_duplicata", oSqlParameter)

            'Seta Váriavel
            lCodigoTituloDespesa = oSqlParameter(0).Value
            lCodigoTituloReceita = oSqlParameter(1).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try


    End Sub

    Public Sub InsertDuplicataDescontadaParcela(ByVal lCodigoTituloDuplicataReceita As Long, _
                                                ByVal lCodigoTituloDuplicataDespesa As Long, _
                                                ByVal lCodigoTituloReceita As Long, _
                                                ByVal iNumeroParcelaReceita As Integer, _
                                                ByVal iCodigoBancoConta As Integer)

        'Variaveis Locais
        Dim i As Integer = 0
        Dim oSqlParameter(5) As SqlParameter

        Try

            'Seta Parametros - Código Título Duplicata Receita
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_duplicata_receita"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoTituloDuplicataReceita : i += 1

            'Seta Parametros - Código Título Duplicata Despesa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_duplicata_despesa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoTituloDuplicataDespesa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Título Receita
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_receita"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoTituloReceita : i += 1

            'Seta Parametros - Número da Parcela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela_receita"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iNumeroParcelaReceita : i += 1

            'Seta Parametros - Código Banco Conta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco_conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoBancoConta

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_titulo_desconto_duplicata_parcela", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try


    End Sub

    Public Sub LoadGridPagamento(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_titulo_cheque_pagamento", oSqlParameter)

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

#Region "::: ADIANTAMENTO :::"

    Public Sub InsertAdiantamento(ByVal iCodigoParceiroNegocio As Integer,
                              ByVal iCodigoBancoConta As Integer,
                              ByVal dValorAdiantamento As Double,
                              ByVal sDataPagamento As String,
                              ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0
        Dim dValorPago As Double
        Dim dValor As Double = dValorAdiantamento
        Dim dValorParcela As Double = 0

        Try

            'Verifica se teve Adiantamento
            If dValorAdiantamento = 0 Then Exit Sub

            'Seta Váriavel
            dValorPago = oGrid.GetTotalRow.Cells("valor_pago").Value

            For Each oRow As GridEXRow In oGrid.GetDataRows

                'Seta Váriavel
                i = 0

                dValorParcela = IIf(CDbl(FormatNumber(oRow.Cells("valor_pago").Value / dValorPago * dValorAdiantamento, 2)) < dValor, CDbl(FormatNumber(oRow.Cells("valor_pago").Value / dValorPago * dValorAdiantamento, 2)), dValor)
                dValor -= dValorParcela

                'Seta Parametros - Código Parceiro de Negócio
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Código Banco Conta
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_banco_conta"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigoBancoConta : i += 1

                'Seta Parametros - Data Pagamento
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data_pagamento"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = sDataPagamento : i += 1

                'Seta Parametros - Tipo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "tipo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 1
                oSqlParameter(i).Value = "R" : i += 1

                'Seta Parametros - Valor Adiantamento
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor_adiantamento"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = IIf(dValorParcela > dValor, dValorParcela, dValor) : i += 1

                'Seta Parametros - Código Título Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_titulo_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo_titulo_capa").Value : i += 1

                'Seta Parametros - Número Parcela
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero_parcela"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("numero_parcela").Value : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_usuario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = goUsuario.iUsuario

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_adiantamento", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertLancamentoAdiantamento(ByVal iCodigoParceiroNegocio As Integer, _
                                          ByVal iCodigoBancoConta As Integer, _
                                          ByVal sNumeroDocumento As String, _
                                          ByVal dValorAdiantamento As Double, _
                                          ByVal sDataPagamento As String, _
                                          ByVal lCodigo As Long)

        'Variaveis Locais
        Dim oSqlParameter(10) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Váriavel
            i = 0

            'Seta Parametros - Código Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Banco Conta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco_conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoBancoConta : i += 1

            'Seta Parametros - Data Pagamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_pagamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataPagamento : i += 1

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = "R" : i += 1

            'Seta Parametros - Número Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sNumeroDocumento : i += 1

            'Seta Parametros - Valor Adiantamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_adiantamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorAdiantamento : i += 1

            'Seta Parametros - Código Título Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Número Parcela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = 1 : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_adiantamento", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertPagamentoAdiantamento(ByVal sContaBancaria As String, _
                                         ByVal sTipoDocumentoPagamento As String, _
                                         ByVal sNumeroDocumento As String, _
                                         ByVal sDataPagamento As String, _
                                         ByVal dValor As Double, _
                                         ByVal dJuros As Double, _
                                         ByVal sBanco As String, _
                                         ByVal sFavorecido As String, _
                                         ByVal iPreDatado As Integer, _
                                         ByVal sDataPreDatado As String, _
                                         ByVal iCodigoBancoConta As Integer, _
                                         ByVal iCodigoTipoDocumentoPagamento As Integer, _
                                         ByVal lCodigoTituloCapaReceita As Long, _
                                         ByVal iCodigoTituloParcelaPagamentoReceita As Integer, _
                                         ByVal iNumeroParcelaReceita As Integer, _
                                         ByVal iStatus As Integer, _
                                         ByVal sEmitente As String, _
                                         ByVal lCodigo As Long)

        'Variaveis Locais
        Dim oSqlParameter(17) As SqlParameter
        Dim i As Integer

        Try

            'Seta Váriavel
            i = 0

            'Seta Parametros - Código Receita Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

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
            oSqlParameter(i).Value = 1 : i += 1

            'Seta Parametros - Código Banco Conta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco_conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoBancoConta : i += 1

            'Seta Parametros - Código Tipo Documento Pagamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_documento_pagamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoDocumentoPagamento : i += 1

            'Seta Parametros - Número do Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sNumeroDocumento : i += 1

            'Seta Parametros - Data Pagamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_pagamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataPagamento : i += 1

            'Seta Parametros - Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValor : i += 1

            'Seta Parametros - Banco
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "banco"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sBanco : i += 1

            'Seta Parametros - Favorecido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "favorecido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sFavorecido : i += 1

            'Seta Parametros - Pré Datado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pre_datado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            If IsDBNull(iPreDatado) Then
                oSqlParameter(i).Value = DBNull.Value : i += 1
            Else
                oSqlParameter(i).Value = IIf(iPreDatado = "1", True, False) : i += 1
            End If

            'Seta Parametros - Data Pré Datado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_pre_datado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataPreDatado : i += 1

            'Seta Parametros - Código Titulo Capa Receita
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_capa_receita"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoTituloCapaReceita : i += 1

            'Seta Parametros - Código Título Parcela Pagamento Receita
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_parcela_pagamento_receita"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTituloParcelaPagamentoReceita : i += 1

            'Seta Parametros - Numero Parcela Receita
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela_receita"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iNumeroParcelaReceita : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iStatus : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_titulo_parcela_pagamento", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateParcelaAdiantamento(ByVal lCodigo As Integer, _
                                      ByVal sDataVencimento As String, _
                                      ByVal dValorPago As Double, _
                                      ByVal dValorDevido As Double)

        'Variaveis Locais
        Dim i As Integer
        Dim oSqlParameter(8) As SqlParameter

        Try

            'Seta Váriavel
            i = 0

            'Seta Parametros - Código Receita Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

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
            oSqlParameter(i).Value = 1 : i += 1

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
            oSqlParameter(i).Value = 0 : i += 1

            'Seta Parametros - Juros
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "juros"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = 0 : i += 1

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = 1

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_financeiro_titulo_parcela", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region


#End Region

End Class
