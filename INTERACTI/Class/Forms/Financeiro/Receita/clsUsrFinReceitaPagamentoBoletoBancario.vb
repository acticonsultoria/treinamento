Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class clsUsrFinReceitaPagamentoBoletoBancario

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sNumeroDocumento As String, _
                        ByVal sDataEmissaoInicio As String, _
                        ByVal sDataEmissaoTermino As String, _
                        ByVal sParceiroNegocio As String, _
                        ByVal sDataVencimentoInicio As String, _
                        ByVal sDataVencimentoTermino As String, _
                        ByVal iTipoDocumento As Integer, _
                        ByVal sCarteira As String, _
                        ByVal iNumeroDocumentoPagamento As Integer, _
                        ByVal dValor As Double)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(10) As SqlParameter
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

            'Seta Parametros - Tipo Docmento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iTipoDocumento : i += 1

            'Seta Parametros - Carteira
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "carteira"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCarteira : i += 1

            'Seta Parametros - Nº Documento de Pagamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento_pagamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iNumeroDocumentoPagamento : i += 1

            'Seta Parametros - Valor 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dValor = 0, DBNull.Value, dValor) : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_titulo_pagamento_boleto_bancario", oSqlParameter)

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

    Public Sub UpdateParcela(ByVal oGrid As GridEX, _
                             ByVal iTipo As Integer)

        'Variaveis Locais
        Dim i As Integer
        Dim oSqlParameter(14) As SqlParameter

        Try

            For Each oRow As GridEXRow In oGrid.GetDataRows

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Título Capa
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
                oSqlParameter(i).Value = 1 : i += 1 ' bOLETO

                'Seta Parametros - Carteira
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "carteira"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 20
                oSqlParameter(i).Value = oRow.Cells("carteira").Value : i += 1

                'Seta Parametros - Número do Documento de Pagamento
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero_documento_pagamento"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = oRow.Cells("numero_documento_pagamento").Value : i += 1

                'Seta Parametros - Data Vencimento
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data_vencimento"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = oRow.Cells("data_vencimento").Value : i += 1

                'Seta Parametros - Data Pagamento
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data_pagamento"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = oRow.Cells("data_pagamento").Value : i += 1

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

                'Seta Parametros - Status Pagamento
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "status_pagamento"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = StatusReceitaPagamento.Quitado : i += 1

                'Seta Parametros - Tipo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "tipo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = iTipo

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_financeiro_titulo_parcela_boleto_bancario", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
