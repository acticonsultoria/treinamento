Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class clsFrmFatEmissaoNFePagamento

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

                i = 0

                'Seta Parametros - Código Emissão Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_emissao_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo_emissao_capa").Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Número Duplicata
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero_duplicata"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("numero_duplicata").Value : i += 1

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
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_emissao_fatura_duplicata", oSqlParameter)

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
        Dim j As Integer
        Dim dValorParcela As Double
        Dim dValorPagamento As Double
        Dim oRowParcela() As GridEXRow = grdParcela.GetDataRows
        Dim oRowPagamento() As GridEXRow = grdPagamento.GetDataRows
        Dim oSqlParameter(12) As SqlParameter

        Try

            For i = 0 To UBound(oRowParcela)

                dValorParcela = oRowParcela(i).Cells("valor_pago").Value

                For j = 0 To UBound(oRowPagamento)

                    dValorPagamento = (oRowPagamento(j).Cells("valor").Value - oRowPagamento(j).Cells("valor_associado").Value)

                    If dValorPagamento > 0 Then

                        'Seta Parametros - Código Emissão Capa
                        oSqlParameter(0) = New SqlParameter
                        oSqlParameter(0).ParameterName = "codigo_emissao_capa"
                        oSqlParameter(0).Direction = ParameterDirection.Input
                        oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                        oSqlParameter(0).Value = oRowParcela(i).Cells("codigo_emissao_capa").Value

                        'Seta Parametros - Código Empresa
                        oSqlParameter(1) = New SqlParameter
                        oSqlParameter(1).ParameterName = "codigo_empresa"
                        oSqlParameter(1).Direction = ParameterDirection.Input
                        oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
                        oSqlParameter(1).Value = goUsuario.iEmpresa

                        'Seta Parametros - Número Duplicata
                        oSqlParameter(2) = New SqlParameter
                        oSqlParameter(2).ParameterName = "numero_duplicata"
                        oSqlParameter(2).Direction = ParameterDirection.Input
                        oSqlParameter(2).SqlDbType = SqlDbType.BigInt
                        oSqlParameter(2).Value = oRowParcela(i).Cells("numero_duplicata").Value

                        'Seta Parametros - Código Banco Conta
                        oSqlParameter(3) = New SqlParameter
                        oSqlParameter(3).ParameterName = "codigo_banco_conta"
                        oSqlParameter(3).Direction = ParameterDirection.Input
                        oSqlParameter(3).SqlDbType = SqlDbType.Int
                        oSqlParameter(3).Value = oRowPagamento(j).Cells("codigo_banco_conta").Value

                        'Seta Parametros - Código Tipo Documento Pagamento
                        oSqlParameter(4) = New SqlParameter
                        oSqlParameter(4).ParameterName = "codigo_tipo_documento_pagamento"
                        oSqlParameter(4).Direction = ParameterDirection.Input
                        oSqlParameter(4).SqlDbType = SqlDbType.SmallInt
                        oSqlParameter(4).Value = oRowPagamento(j).Cells("codigo_tipo_documento_pagamento").Value

                        'Seta Parametros - Número do Documento
                        oSqlParameter(5) = New SqlParameter
                        oSqlParameter(5).ParameterName = "numero_documento"
                        oSqlParameter(5).Direction = ParameterDirection.Input
                        oSqlParameter(5).SqlDbType = SqlDbType.VarChar
                        oSqlParameter(5).Size = 100
                        oSqlParameter(5).Value = oRowPagamento(j).Cells("numero_documento").Value

                        'Seta Parametros - Data Pagamento
                        oSqlParameter(6) = New SqlParameter
                        oSqlParameter(6).ParameterName = "data_pagamento"
                        oSqlParameter(6).Direction = ParameterDirection.Input
                        oSqlParameter(6).SqlDbType = SqlDbType.DateTime
                        oSqlParameter(6).Value = oRowPagamento(j).Cells("data_pagamento").Value

                        'Seta Parametros - Valor
                        oSqlParameter(7) = New SqlParameter
                        oSqlParameter(7).ParameterName = "valor"
                        oSqlParameter(7).Direction = ParameterDirection.Input
                        oSqlParameter(7).SqlDbType = SqlDbType.Float
                        oSqlParameter(7).Value = IIf(dValorParcela > dValorPagamento, dValorPagamento, dValorParcela)

                        'Seta Parametros - Banco
                        oSqlParameter(8) = New SqlParameter
                        oSqlParameter(8).ParameterName = "banco"
                        oSqlParameter(8).Direction = ParameterDirection.Input
                        oSqlParameter(8).SqlDbType = SqlDbType.VarChar
                        oSqlParameter(8).Size = 100
                        oSqlParameter(8).Value = oRowPagamento(j).Cells("banco").Value

                        'Seta Parametros - Favorecido
                        oSqlParameter(9) = New SqlParameter
                        oSqlParameter(9).ParameterName = "favorecido"
                        oSqlParameter(9).Direction = ParameterDirection.Input
                        oSqlParameter(9).SqlDbType = SqlDbType.VarChar
                        oSqlParameter(9).Size = 100
                        oSqlParameter(9).Value = oRowPagamento(j).Cells("favorecido").Value

                        'Seta Parametros - Pré Datado
                        oSqlParameter(10) = New SqlParameter
                        oSqlParameter(10).ParameterName = "pre_datado"
                        oSqlParameter(10).Direction = ParameterDirection.Input
                        oSqlParameter(10).SqlDbType = SqlDbType.Bit
                        If IsDBNull(oRowPagamento(j).Cells("pre_datado").Value) Then
                            oSqlParameter(10).Value = DBNull.Value
                        Else
                            oSqlParameter(10).Value = IIf(oRowPagamento(j).Cells("pre_datado").Value = "1", True, False)
                        End If

                        'Seta Parametros - Data Pré Datado
                        oSqlParameter(11) = New SqlParameter
                        oSqlParameter(11).ParameterName = "data_pre_datado"
                        oSqlParameter(11).Direction = ParameterDirection.Input
                        oSqlParameter(11).SqlDbType = SqlDbType.DateTime
                        oSqlParameter(11).Value = oRowPagamento(j).Cells("data_pre_datado").Value

                        'Seta Parametros - Status
                        oSqlParameter(12) = New SqlParameter
                        oSqlParameter(12).ParameterName = "status"
                        oSqlParameter(12).Direction = ParameterDirection.Input
                        oSqlParameter(12).SqlDbType = SqlDbType.SmallInt
                        oSqlParameter(12).Value = oRowPagamento(j).Cells("status").Value

                        'Executa Query
                        ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_emissao_fatura_duplicata_pagamento", oSqlParameter)

                        grdPagamento.Row = oRowPagamento(j).RowIndex
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

#End Region

End Class
