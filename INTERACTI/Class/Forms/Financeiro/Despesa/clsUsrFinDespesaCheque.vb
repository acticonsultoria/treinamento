Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class clsUsrFinDespesaCheque

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sNumeroCheque As String, _
                        ByVal sNumeroDocumento As String, _
                        ByVal sParceiroNegocio As String, _
                        ByVal sDataPagamentoInicio As String, _
                        ByVal sDataPagamentoTermino As String, _
                        ByVal sDataCompensacaoInicio As String, _
                        ByVal sDataCompensacaoTermino As String, _
                        ByVal iCodigoBancoConta As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Número Cheque
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_cheque"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sNumeroCheque : i += 1

            'Seta Parametros - Número do Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNumeroDocumento : i += 1

            'Seta Parametros - Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sParceiroNegocio : i += 1

            'Seta Parametros - Data Pagamento Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_pagamento_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataPagamentoInicio = "", DBNull.Value, sDataPagamentoInicio) : i += 1

            'Seta Parametros - Data Pagamento Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_pagamento_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataPagamentoTermino = "", DBNull.Value, sDataPagamentoTermino) : i += 1

            'Seta Parametros - Data Compensação Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_compensacao_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataCompensacaoInicio = "", DBNull.Value, sDataCompensacaoInicio) : i += 1

            'Seta Parametros - Data Compensação Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_compensacao_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataCompensacaoTermino = "", DBNull.Value, sDataCompensacaoTermino) : i += 1

            'Seta Parametros - Código Banco Conta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_banco_conta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoBancoConta : i += 1

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Char
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = "D" : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_titulo_parcela_pagamento_cheque", oSqlParameter)

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

    Public Sub CancelarCompensarCheque(ByVal lCodigoTituloCapa As Long, _
                                       ByVal iNumeroParcela As Integer, _
                                       ByVal iCodigoTituloParcelaPagamento As Integer, _
                                       ByVal lCodigoTituloCapaReceita As Long, _
                                       ByVal iNumeroParcelaReceita As Integer, _
                                       ByVal iCodigoTituloParcelaPagamentoReceita As Integer)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
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

            'Seta Parametros - Número da Parcela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iNumeroParcela : i += 1

            'Seta Parametros - Código Título Parcela Pagamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_parcela_pagamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTituloParcelaPagamento : i += 1

            'Seta Parametros - Data Compensacao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_compensacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = DBNull.Value : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = StatusDespesaPagamento.ChequeNaoCompensado : i += 1

            'Seta Parametros - Código Título Capa - Receita
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_capa_receita"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoTituloCapaReceita : i += 1

            'Seta Parametros - Número Parcela - Receita
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela_receita"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iNumeroParcelaReceita : i += 1

            'Seta Parametros - Código Titulo Parcela Pagamento - Receita
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_parcela_pagamento_receita"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTituloParcelaPagamentoReceita

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_financeiro_titulo_parcela_pagamento_cheque", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
