Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper

Public Class clsFrmFinChequeCompensar

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private lCodigoTituloCapa As Long
    Private iNumeroParcela As Integer
    Private iCodigoTituloParcelaPagamento As Integer
    Private sDataCompensacao As String
    Private lCodigoTituloCapaReceita As Long
    Private iNumeroParcelaReceita As Integer
    Private iCodigoTituloParcelaPagamentoReceita As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoTituloCapa() As Long
        Get
            Return lCodigoTituloCapa
        End Get
        Set(ByVal value As Long)
            lCodigoTituloCapa = value
        End Set
    End Property

    Public Property NumeroParcela() As Integer
        Get
            Return iNumeroParcela
        End Get
        Set(ByVal value As Integer)
            iNumeroParcela = value
        End Set
    End Property

    Public Property CodigoTituloParcelaPagamento() As Integer
        Get
            Return iCodigoTituloParcelaPagamento
        End Get
        Set(ByVal value As Integer)
            iCodigoTituloParcelaPagamento = value
        End Set
    End Property

    Public Property DataCompensacao() As String
        Get
            Return sDataCompensacao
        End Get
        Set(ByVal value As String)
            sDataCompensacao = value
        End Set
    End Property

    Public Property CodigoTituloCapaReceita() As Long
        Get
            Return lCodigoTituloCapaReceita
        End Get
        Set(ByVal value As Long)
            lCodigoTituloCapaReceita = value
        End Set
    End Property

    Public Property NumeroParcelaReceita() As Integer
        Get
            Return iNumeroParcelaReceita
        End Get
        Set(ByVal value As Integer)
            iNumeroParcelaReceita = value
        End Set
    End Property

    Public Property CodigoTituloParcelaPagamentoReceita() As Integer
        Get
            Return iCodigoTituloParcelaPagamentoReceita
        End Get
        Set(ByVal value As Integer)
            iCodigoTituloParcelaPagamentoReceita = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub CompensarCheque()

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
            oSqlParameter(i).Value = sDataCompensacao : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = StatusReceitaPagamento.Quitado : i += 1

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
