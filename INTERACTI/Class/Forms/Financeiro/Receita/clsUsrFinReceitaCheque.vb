Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class clsUsrFinReceitaCheque

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

        Try

            'Seta Parametros - Número Cheque
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "numero_cheque"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.VarChar
            oSqlParameter(0).Size = 100
            oSqlParameter(0).Value = sNumeroCheque

            'Seta Parametros - Número do Documento
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "numero_documento"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Size = 20
            oSqlParameter(1).Value = sNumeroDocumento

            'Seta Parametros - Parceiro de Negócio
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "parceiro_negocio"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Size = 60
            oSqlParameter(2).Value = sParceiroNegocio

            'Seta Parametros - Data Pagamento Início
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "data_pagamento_inicio"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.DateTime
            oSqlParameter(3).Value = IIf(sDataPagamentoInicio = "", DBNull.Value, sDataPagamentoInicio)

            'Seta Parametros - Data Pagamento Término
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "data_pagamento_termino"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.DateTime
            oSqlParameter(4).Value = IIf(sDataPagamentoTermino = "", DBNull.Value, sDataPagamentoTermino)

            'Seta Parametros - Data Compensação Início
            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "data_compensacao_inicio"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.DateTime
            oSqlParameter(5).Value = IIf(sDataCompensacaoInicio = "", DBNull.Value, sDataCompensacaoInicio)

            'Seta Parametros - Data Compensação Término
            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "data_compensacao_termino"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.DateTime
            oSqlParameter(6).Value = IIf(sDataCompensacaoTermino = "", DBNull.Value, sDataCompensacaoTermino)

            'Seta Parametros - Código Banco Conta
            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "codigo_banco_conta"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.Int
            oSqlParameter(7).Value = iCodigoBancoConta

            'Seta Parametros - Tipo
            oSqlParameter(8) = New SqlParameter
            oSqlParameter(8).ParameterName = "tipo"
            oSqlParameter(8).Direction = ParameterDirection.Input
            oSqlParameter(8).SqlDbType = SqlDbType.Char
            oSqlParameter(8).Size = 1
            oSqlParameter(8).Value = "R"

            'Seta Parametros - Código Empresa
            oSqlParameter(9) = New SqlParameter
            oSqlParameter(9).ParameterName = "codigo_empresa"
            oSqlParameter(9).Direction = ParameterDirection.Input
            oSqlParameter(9).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(9).Value = goUsuario.iEmpresa

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

        Try

            'Seta Parametros - Código Título Capa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_titulo_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoTituloCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Seta Parametros - Número da Parcela
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "numero_parcela"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(2).Value = iNumeroParcela

            'Seta Parametros - Código Título Parcela Pagamento
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_titulo_parcela_pagamento"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(3).Value = iCodigoTituloParcelaPagamento

            'Seta Parametros - Data Compensacao
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "data_compensacao"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.DateTime
            oSqlParameter(4).Value = DBNull.Value

            'Seta Parametros - Status
            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "status"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(5).Value = StatusReceitaPagamento.ChequeNaoCompensado

            'Seta Parametros - Código Título Capa - Receita
            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "codigo_titulo_capa_receita"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.BigInt
            oSqlParameter(6).Value = lCodigoTituloCapaReceita

            'Seta Parametros - Número Parcela - Receita
            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "numero_parcela_receita"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(7).Value = iNumeroParcelaReceita

            'Seta Parametros - Código Titulo Parcela Pagamento - Receita
            oSqlParameter(8) = New SqlParameter
            oSqlParameter(8).ParameterName = "codigo_titulo_parcela_pagamento_receita"
            oSqlParameter(8).Direction = ParameterDirection.Input
            oSqlParameter(8).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(8).Value = iCodigoTituloParcelaPagamentoReceita

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
