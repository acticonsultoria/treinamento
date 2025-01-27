Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.CalendarCombo

Public Class clsUsrFinDespesaLancamento

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sNumeroDocumento As String
    Private sSerie As String
    Private iTipoDocumento As Integer
    Private lParceiroNegocio As Long
    Private sDataEmissao As String
    Private iTipoTituloFinanceiro As Integer
    Private iMoeda As Integer
    Private dFatorCambial As Double
    Private dMultaPagamento As Double
    Private dJurosPagamento As Double
    Private dDescontoPagamento As Double
    Private iFormaPagamento As Integer
    Private iNumeroParcela As Integer
    Private iIntervaloParcela As Integer
    Private sDescritivo As String
    Private dValor As Double
    Private dDescontoValor As Double
    Private dDescontoPercentual As Double
    Private lCodigoDespesaCapa As Long
    Private iCodigoCondicaoPagamento As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoCondicaoPagamento() As Integer
        Get
            Return iCodigoCondicaoPagamento
        End Get
        Set(ByVal value As Integer)
            iCodigoCondicaoPagamento = value
        End Set
    End Property

    Public Property NumeroDocumento() As String
        Get
            Return sNumeroDocumento
        End Get
        Set(ByVal value As String)
            sNumeroDocumento = value
        End Set
    End Property

    Public Property Serie() As String
        Get
            Return sSerie
        End Get
        Set(ByVal value As String)
            sSerie = value
        End Set
    End Property

    Public Property TipoDocumento() As Integer
        Get
            Return iTipoDocumento
        End Get
        Set(ByVal value As Integer)
            iTipoDocumento = value
        End Set
    End Property

    Public Property ParceiroNegocio() As Long
        Get
            Return lParceiroNegocio
        End Get
        Set(ByVal value As Long)
            lParceiroNegocio = value
        End Set
    End Property

    Public Property DataEmissao() As String
        Get
            Return sDataEmissao
        End Get
        Set(ByVal value As String)
            sDataEmissao = value
        End Set
    End Property

    Public Property TipoTituloFinanceiro() As Integer
        Get
            Return iTipoTituloFinanceiro
        End Get
        Set(ByVal value As Integer)
            iTipoTituloFinanceiro = value
        End Set
    End Property

    Public Property Moeda() As Integer
        Get
            Return iMoeda
        End Get
        Set(ByVal value As Integer)
            iMoeda = value
        End Set
    End Property

    Public Property FatorCambial() As Double
        Get
            Return dFatorCambial
        End Get
        Set(ByVal value As Double)
            dFatorCambial = value
        End Set
    End Property

    Public Property MultaPagamento() As Double
        Get
            Return dMultaPagamento
        End Get
        Set(ByVal value As Double)
            dMultaPagamento = value
        End Set
    End Property

    Public Property JurosPagamento() As Double
        Get
            Return dJurosPagamento
        End Get
        Set(ByVal value As Double)
            dJurosPagamento = value
        End Set
    End Property

    Public Property DescontoPagamento() As Double
        Get
            Return dDescontoPagamento
        End Get
        Set(ByVal value As Double)
            dDescontoPagamento = value
        End Set
    End Property

    Public Property FormaPagamento() As Integer
        Get
            Return iFormaPagamento
        End Get
        Set(ByVal value As Integer)
            iFormaPagamento = value
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

    Public Property IntervaloParcela() As Integer
        Get
            Return iIntervaloParcela
        End Get
        Set(ByVal value As Integer)
            iIntervaloParcela = value
        End Set
    End Property

    Public Property Descritivo() As String
        Get
            Return sDescritivo
        End Get
        Set(ByVal value As String)
            sDescritivo = value
        End Set
    End Property

    Public Property Valor() As Double
        Get
            Return dValor
        End Get
        Set(ByVal value As Double)
            dValor = value
        End Set
    End Property

    Public Property DescontoValor() As Double
        Get
            Return dDescontoValor
        End Get
        Set(ByVal value As Double)
            dDescontoValor = value
        End Set
    End Property

    Public Property DescontoPercentual() As Double
        Get
            Return dDescontoPercentual
        End Get
        Set(ByVal value As Double)
            dDescontoPercentual = value
        End Set
    End Property

    Public Property CodigoDespesaCapa() As Long
        Get
            Return lCodigoDespesaCapa
        End Get
        Set(ByVal value As Long)
            lCodigoDespesaCapa = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: TÍTULO :::"

    Public Sub Insert()

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Número Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNumeroDocumento : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Série
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "serie"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 3
            oSqlParameter(i).Value = IIf(sSerie = "", DBNull.Value, sSerie) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Tipo Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iTipoDocumento : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lParceiroNegocio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Data Emissão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataEmissao : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_titulo_financeiro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iTipoTituloFinanceiro : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Moeda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_moeda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMoeda : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Fator Cambial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fator_cambial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dFatorCambial : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Multa Pagamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "multa_pagamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMultaPagamento : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Juros Pagamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "juros_pagamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dJurosPagamento : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Desconto Pagamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desconto_pagamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDescontoPagamento : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Descritivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descritivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 1000
            oSqlParameter(i).Value = sDescritivo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValor : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Desconto Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desconto_valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDescontoValor : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Desconto Percentual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desconto_percentual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDescontoPercentual : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Forma de Pagamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_forma_pagamento_nfe"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iFormaPagamento : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Numero Parcela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iNumeroParcela : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Intervalo Parcela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "intervalo_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iIntervaloParcela : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = StatusTitulo.Aberto : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Char
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = "D" : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_condicao_pagamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCondicaoPagamento : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_titulo_capa", oSqlParameter)

            'Seta Código
            lCodigoDespesaCapa = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update()

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Número Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNumeroDocumento : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Série
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "serie"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 3
            oSqlParameter(i).Value = IIf(sSerie = "", DBNull.Value, sSerie) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Tipo Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iTipoDocumento : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lParceiroNegocio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Data Emissão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataEmissao : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_titulo_financeiro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iTipoTituloFinanceiro : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Moeda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_moeda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iMoeda : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Fator Cambial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fator_cambial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dFatorCambial : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Multa Pagamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "multa_pagamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMultaPagamento : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Juros Pagamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "juros_pagamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dJurosPagamento : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Desconto Pagamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desconto_pagamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDescontoPagamento : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Descritivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descritivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 1000
            oSqlParameter(i).Value = sDescritivo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValor : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Desconto Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desconto_valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDescontoValor : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Desconto Percentual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desconto_percentual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDescontoPercentual : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Forma de Pagamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_forma_pagamento_nfe"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iFormaPagamento : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Numero Parcela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iNumeroParcela : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Intervalo Parcela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "intervalo_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iIntervaloParcela : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_condicao_pagamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoCondicaoPagamento = -1, DBNull.Value, iCodigoCondicaoPagamento) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoDespesaCapa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_financeiro_titulo_capa", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateVinculoTituloPrevisao(ByVal lCodigoTituloPrevisto As Long)

        'Variaveis Locais
        Dim oSqlParameter(19) As SqlParameter
        Dim i As Integer = 0

        Try


            'Seta Parametros - Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoDespesaCapa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_previsto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoTituloPrevisto : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_financeiro_titulo_vinculo_previsao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteVinculoTituloPrevisao(ByVal lCodigoTituloPrevisto As Long)

        'Variaveis Locais
        Dim oSqlParameter(19) As SqlParameter
        Dim i As Integer = 0

        Try


            

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_previsto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoTituloPrevisto : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_financeiro_titulo_previsto", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadControlesTituloPrevisao(ByVal lCodigo As Long, _
                          ByVal txtNumeroDocumentoPrevisto As MaskedEditBox, _
                          ByVal txtValorPrevisto As NumericEditBox, _
                          ByVal dtpDataVencimentoPrevisto As CalendarCombo)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
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
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_titulo_previsto_dados", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    txtNumeroDocumentoPrevisto.Text = oSqlDataReader.Item("numero_documento")
                    txtValorPrevisto.Value = oSqlDataReader.Item("valor")
                    dtpDataVencimentoPrevisto.Text = oSqlDataReader.Item("data_vencimento")
                    

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

    Public Sub Delete()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo_titulo_capa").Value : i += 1

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
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_financeiro_titulo_capa", oSqlParameter)

                'Deleta Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sNumeroDocumento As String, _
                        ByVal sSerie As String, _
                        ByVal sParceiroNegocio As String, _
                        ByVal iStatus As Integer, _
                        ByVal sDataEmissaoInicio As String, _
                        ByVal sDataEmissaoTermino As String, _
                        ByVal sDataVencimentoInicio As String, _
                        ByVal sDataVencimentoTermino As String, _
                        ByVal sDataPagamentoInicio As String, _
                        ByVal sDataPagamentoTermino As String, _
                        ByVal iTipoTituloFinanceiro As Integer, _
                        ByVal dValor As Double, _
                        ByVal iCodigoContaBancaria As Integer, _
                        ByVal sDescritivo As String, _
                        ByVal sDataInputInicio As String, _
                        ByVal sDataInputTermino As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try
             
            'Seta Parametros - Número Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNumeroDocumento : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Série
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "serie"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 3
            oSqlParameter(i).Value = sSerie : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sParceiroNegocio : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iStatus : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Data Emissão Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(IsDate(sDataEmissaoInicio) = False, DBNull.Value, sDataEmissaoInicio) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Data Emissão Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(IsDate(sDataEmissaoTermino) = False, DBNull.Value, sDataEmissaoTermino) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Data Vencimento Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(IsDate(sDataVencimentoInicio) = False, DBNull.Value, sDataVencimentoInicio) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Data Vencimento Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(IsDate(sDataVencimentoTermino) = False, DBNull.Value, sDataVencimentoTermino) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Data Pagamento Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_pagamento_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(IsDate(sDataPagamentoInicio) = False, DBNull.Value, sDataPagamentoInicio) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Data Pagamento Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_pagamento_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = IIf(IsDate(sDataPagamentoTermino) = False, DBNull.Value, sDataPagamentoTermino) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Tipo Título Financeiro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_titulo_financeiro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iTipoTituloFinanceiro : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Char
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = "D" : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dValor = -1, DBNull.Value, dValor) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Conta Bancária
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_conta_bancaria"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoContaBancaria : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Descritivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descritivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sDescritivo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_titulo_entrada", oSqlParameter)

            'Configura DataMember
            ConfigurarDataMemberGrid(oGrid)

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oDataSet.Tables(0).Columns("codigo_titulo_capa"), oDataSet.Tables(1).Columns("codigo_titulo_capa"))

            'Carrega Grid
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName
            oGrid.DataSource = oDataSet.DefaultViewManager

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridLavalpa(ByVal oGrid As GridEX, _
                        ByVal sNumeroDocumento As String, _
                        ByVal sSerie As String, _
                        ByVal sParceiroNegocio As String, _
                        ByVal iStatus As Integer, _
                        ByVal sDataEmissaoInicio As String, _
                        ByVal sDataEmissaoTermino As String, _
                        ByVal sDataVencimentoInicio As String, _
                        ByVal sDataVencimentoTermino As String, _
                        ByVal sDataPagamentoInicio As String, _
                        ByVal sDataPagamentoTermino As String, _
                        ByVal iTipoTituloFinanceiro As Integer, _
                        ByVal dValor As Double, _
                        ByVal iCodigoContaBancaria As Integer, _
                        ByVal sDescritivo As String, _
                        ByVal sDataInputInicio As String, _
                        ByVal sDataInputTermino As String, _
                        ByVal bLavalpa As Integer, _
                        ByVal bLeSix As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(17) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Lavalpa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "lavalpa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(bLavalpa = 2, DBNull.Value, IIf(bLavalpa = False, 0, 1)) : i += 1

            'Seta Parametros - Le Six
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "le_six"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(bLeSix = 2, DBNull.Value, IIf(bLeSix = False, 0, 1)) : i += 1

            'Seta Parametros - Número Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNumeroDocumento : i += 1

            'Seta Parametros - Série
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "serie"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 3
            oSqlParameter(i).Value = sSerie : i += 1

            'Seta Parametros - Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sParceiroNegocio : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iStatus : i += 1

            'Seta Parametros - Data Emissão Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataEmissaoInicio) = False, DBNull.Value, sDataEmissaoInicio) : i += 1

            'Seta Parametros - Data Emissão Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataEmissaoTermino) = False, DBNull.Value, sDataEmissaoTermino) : i += 1

            'Seta Parametros - Data Vencimento Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataVencimentoInicio) = False, DBNull.Value, sDataVencimentoInicio) : i += 1

            'Seta Parametros - Data Vencimento Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataVencimentoTermino) = False, DBNull.Value, sDataVencimentoTermino) : i += 1

            'Seta Parametros - Data Pagamento Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_pagamento_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataPagamentoInicio) = False, DBNull.Value, sDataPagamentoInicio) : i += 1

            'Seta Parametros - Data Pagamento Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_pagamento_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataPagamentoTermino) = False, DBNull.Value, sDataPagamentoTermino) : i += 1

            ''Seta Parametros - Data Input Início
            'oSqlParameter(i) = New SqlParameter
            'oSqlParameter(i).ParameterName = "data_input_inicio"
            'oSqlParameter(i).Direction = ParameterDirection.Input
            'oSqlParameter(i).SqlDbType = SqlDbType.Date
            'oSqlParameter(i).Value = IIf(IsDate(sDataInputInicio) = False, DBNull.Value, sDataInputInicio) : i += 1

            ''Seta Parametros - Data Input Término
            'oSqlParameter(i) = New SqlParameter
            'oSqlParameter(i).ParameterName = "data_input_termino"
            'oSqlParameter(i).Direction = ParameterDirection.Input
            'oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            'oSqlParameter(i).Value = IIf(IsDate(sDataInputTermino) = False, DBNull.Value, sDataInputTermino) : i += 1

            'Seta Parametros - Tipo Título Financeiro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_titulo_financeiro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iTipoTituloFinanceiro : i += 1

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Char
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = "D" : i += 1

            'Seta Parametros - Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dValor = -1, DBNull.Value, dValor) : i += 1

            'Seta Parametros - Código Conta Bancária
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_conta_bancaria"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoContaBancaria : i += 1

            'Seta Parametros - Descritivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descritivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sDescritivo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_titulo_entrada_lavalpa", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oDataSet.Tables(0).Columns("codigo_titulo_capa"), oDataSet.Tables(1).Columns("codigo_titulo_capa"))

            'Carrega Grid
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName
            oGrid.DataSource = oDataSet.DefaultViewManager

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadControles(ByVal lCodigo As Long, _
                             ByVal txtNumeroDocumento As MaskedEditBox, _
                             ByVal txtSerie As MaskedEditBox, _
                             ByVal cboTipoDocumento As UIComboBox, _
                             ByVal cboParceiroNegocio As UIComboBox, _
                             ByVal dtpDataEmissao As CalendarCombo, _
                             ByVal cboTipoTituloFinanceiro As UIComboBox, _
                             ByVal cboMoeda As UIComboBox, _
                             ByVal txtFatorCambial As NumericEditBox, _
                             ByVal txtMultaPagamento As NumericEditBox, _
                             ByVal txtJurosPagamento As NumericEditBox, _
                             ByVal txtDescontoPagamento As NumericEditBox, _
                             ByVal txtDescritivo As EditBox, _
                             ByVal txtValor As NumericEditBox, _
                             ByVal txtDescontoValor As NumericEditBox, _
                             ByVal txtDescontoPercentual As NumericEditBox, _
                             ByVal cboFormaPagamento As UIComboBox, _
                             ByVal txtNumeroParcela As NumericEditBox, _
                             ByVal txtIntervaloParcela As NumericEditBox, _
                             ByVal txtNumDocumentoPrevisto As MaskedEditBox, _
                             ByVal txtValorPrevisto As NumericEditBox, _
                             ByVal dtpDataVencimentoPrevisto As CalendarCombo, _
                             ByVal cboTituloPrevisto As UIComboBox, _
                             ByVal cboCondicaoPagamento As UIComboBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_titulo_dados_capa", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    txtNumeroDocumento.Text = oSqlDataReader.Item("numero_documento")
                    txtSerie.Text = IIf(IsDBNull(oSqlDataReader.Item("serie")), "", oSqlDataReader.Item("serie"))
                    cboTipoDocumento.SelectedValue = oSqlDataReader.Item("codigo_tipo_documento")
                    cboParceiroNegocio.SelectedValue = oSqlDataReader.Item("codigo_parceiro_negocio")
                    dtpDataEmissao.Value = oSqlDataReader.Item("data_emissao")
                    cboTipoTituloFinanceiro.SelectedValue = oSqlDataReader.Item("codigo_tipo_titulo_financeiro")
                    cboMoeda.SelectedValue = oSqlDataReader.Item("codigo_moeda")
                    txtFatorCambial.Value = oSqlDataReader.Item("fator_cambial")
                    txtMultaPagamento.Value = oSqlDataReader.Item("multa_pagamento")
                    txtJurosPagamento.Value = oSqlDataReader.Item("juros_pagamento")
                    txtDescontoPagamento.Value = oSqlDataReader.Item("desconto_pagamento")
                    txtDescritivo.Text = oSqlDataReader.Item("descritivo")
                    txtValor.Value = oSqlDataReader.Item("valor")
                    txtDescontoValor.Value = oSqlDataReader.Item("desconto_valor")
                    txtDescontoPercentual.Value = oSqlDataReader.Item("desconto_percentual")
                    cboFormaPagamento.SelectedValue = oSqlDataReader.Item("codigo_forma_pagamento_nfe")
                    txtNumeroParcela.Value = oSqlDataReader.Item("numero_parcela")
                    txtIntervaloParcela.Value = oSqlDataReader.Item("intervalo_parcela")
                    txtNumDocumentoPrevisto.Text = oSqlDataReader.Item("numero_documento_previsto")
                    txtValorPrevisto.Value = oSqlDataReader.Item("valor_previsto")
                    dtpDataVencimentoPrevisto.Value = oSqlDataReader.Item("data_vencimento_previsto")

                    If IsDBNull(oSqlDataReader.Item("numero_documento_previsto")) Then
                        cboTituloPrevisto.Enabled = True
                    Else
                        cboTituloPrevisto.Enabled = False
                    End If

                    If IsDBNull(oSqlDataReader("codigo_condicao_pagamento")) Then
                        cboCondicaoPagamento.SelectedIndex = -1
                    Else
                        cboCondicaoPagamento.SelectedValue = oSqlDataReader("codigo_condicao_pagamento")
                    End If

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

    Public Function GerarNumeroDocumento() As String

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0
        Dim sReturn As String

        Try

            'Seta Retorno da Função
            GerarNumeroDocumento = False

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Char
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = "D"

            'Executa Query
            sReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_titulo_gerar_numero_documento", oSqlParameter), String)

            Return sReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ValidaDespesaCapa(ByVal lCodigoDespesaCapa As Long, _
                                      ByVal sNumeroDocumento As String, _
                                      ByVal sSerie As String, _
                                      ByVal lParceiroNegocio As Long) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim iReturn As Integer
        Dim i As Integer = 0

        Try

            'Seta Retorno da Função
            ValidaDespesaCapa = False

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoDespesaCapa : i += 1

            'Seta Parametros - Número Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNumeroDocumento : i += 1

            'Seta Parametros - Série
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "serie"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 3
            oSqlParameter(i).Value = IIf(sSerie = "", DBNull.Value, Serie) : i += 1

            'Seta Parametros - Codigo Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lParceiroNegocio : i += 1

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Char
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = "D"

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_financeiro_titulo_capa", oSqlParameter), Integer)

            'Seta Retorno da Função
            ValidaDespesaCapa = IIf(iReturn > 0, False, True)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: PARCELA :::"

    Public Sub InsertParcela(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In oGrid.GetDataRows

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Titulo Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_titulo_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoDespesaCapa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - N° Parcela
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero_parcela"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.RowIndex + 1 : i += 1

                'Seta Parametros - Data Vencimento
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data_vencimento"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = oRow.Cells("data_vencimento").Value : i += 1

                'Seta Parametros - Valor Parcela
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor_parcela"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("valor").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_titulo_parcela", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteParcela(ByVal lCodigoTituloCapa As Long)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
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
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_financeiro_titulo_parcela", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridParcela(ByVal oGrid As GridEX, _
                               ByVal lCodigoTituloCapa As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
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
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_titulo_dados_parcela", oSqlParameter)

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

    Public Sub GerarParcela(ByVal oGrid As GridEX, _
                            ByVal dDataEmissao As Date, _
                            ByVal dValor As Double, _
                            ByVal iNumeroParcela As Integer, _
                            ByVal iIntervaloParcela As Integer)

        Try

            'Limpa Grid
            oGrid.DataSource = Nothing

            'Caso Valor Liquido maior que 0
            If dValor <= 0 Then Exit Sub

            'Variaveis Locais
            Dim oDataSet As New DataSet
            Dim oDataTable As New DataTable
            Dim oDCPago As New DataColumn("pago")
            Dim oDCVencimento As New DataColumn("data_vencimento")
            Dim oDCValor As New DataColumn("valor")
            Dim oDCValorPago As New DataColumn("valor_pago")
            Dim dValorResidual As Double = dValor

            'Seta DataType
            oDCPago.DataType = False.GetType
            oDCVencimento.DataType = Now.Date.GetType
            oDCValor.DataType = 0.0.GetType

            'Adiciona Tabela ao DataSet
            oDataSet.Tables.Add(oDataTable)

            'Adiciona Colunas ao DataTable
            oDataTable.Columns.Add(oDCPago)
            oDataTable.Columns.Add(oDCVencimento)
            oDataTable.Columns.Add(oDCValor)
            oDataTable.Columns.Add(oDCValorPago)

            'Adiciona Linhas ao DataTable
            For i = 1 To iNumeroParcela
                Dim oDataRow As DataRow = oDataTable.NewRow
                oDataRow("pago") = False
                oDataRow("data_vencimento") = CDate(DateAdd(DateInterval.Day, i * iIntervaloParcela, dDataEmissao))
                oDataRow("valor") = IIf(iNumeroParcela = i, dValorResidual, FormatNumber(dValor / iNumeroParcela, 2))
                dValorResidual -= FormatNumber(dValor / iNumeroParcela, 2)
                oDataRow("valor_pago") = 0
                oDataTable.Rows.Add(oDataRow)
            Next

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

    Public Sub GerarDuplicata(ByVal oGrid As GridEX, _
                              ByVal iCodigoCondicaoPagamento As Integer, _
                              ByVal dValor As Double, _
                              ByVal sDataEmissao As String)

        Try

            'Váriaveis Locais
            Dim oRow As GridEXRow
            Dim dValorTotal As Double = 0
            Dim dValorResidual As Double = 0
            Dim iParcela As Integer = 0

            'Preenche Total
            For Each oRow In oGrid.GetDataRows
                If oRow.Cells("valor_pago").Value > 0 Then
                    iParcela += 1
                    dValorTotal += oRow.Cells("valor").Value
                End If
            Next

            'Caso Valor Liquido maior que 0
            If dValor - dValorTotal > 0 Then

                'Variaveis Locais
                Dim oDataSet As New DataSet
                Dim oDataTable As New DataTable
                Dim oDCPago As New DataColumn("pago")
                Dim oDCVencimento As New DataColumn("data_vencimento")
                Dim oDCValor As New DataColumn("valor")
                Dim oDCValorPago As New DataColumn("valor_pago")
                Dim oSqlDataReader As SqlDataReader
                Dim oSqlParameter(0) As SqlParameter
                Dim oDataRow As DataRow
                Dim i As Integer = 0

                'Seta DataType
                oDCPago.DataType = False.GetType
                oDCVencimento.DataType = Now.Date.GetType
                oDCValor.DataType = 0.0.GetType
                oDCValorPago.DataType = 0.0.GetType

                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)

                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCPago)
                oDataTable.Columns.Add(oDCVencimento)
                oDataTable.Columns.Add(oDCValor)
                oDataTable.Columns.Add(oDCValorPago)

                'Adiciona Linhas ao DataTable - Pago
                For Each oRow In oGrid.GetDataRows
                    If oRow.Cells("valor_pago").Value > 0 Then
                        oDataRow = oDataTable.NewRow
                        oDataRow("pago") = oRow.Cells("pago").Value
                        oDataRow("data_vencimento") = oRow.Cells("data_vencimento").Value
                        oDataRow("valor") = oRow.Cells("valor").Value
                        oDataRow("valor_pago") = oRow.Cells("valor_pago").Value
                        oDataTable.Rows.Add(oDataRow)
                    End If
                Next

                dValorResidual = (dValor - dValorTotal)

                'Verifica se possui Valor Residual
                If dValorResidual > 0 Then

                    'Seta Parametros - Código Empresa
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_empresa"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                    oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

                    'Seta Parametros - Código Condição de Pagamento
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_condicao_pagamento"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                    oSqlParameter(i).Value = iCodigoCondicaoPagamento : i += 1 : ReDim Preserve oSqlParameter(i)

                    'Seta Parametros - Valor
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "valor"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.Float
                    oSqlParameter(i).Value = dValorResidual : i += 1 : ReDim Preserve oSqlParameter(i)

                    'Seta Parametros - Parcela
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "parcela"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                    oSqlParameter(i).Value = iParcela : i += 1 : ReDim Preserve oSqlParameter(i)

                    'Seta Parametros - Data Emissão
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "data_emissao"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                    oSqlParameter(i).Value = sDataEmissao

                    'Carrega Query
                    oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_condicao_pagamento_parcela_valor", oSqlParameter)

                    While oSqlDataReader.Read

                        oDataRow = oDataTable.NewRow
                        oDataRow("pago") = False
                        oDataRow("data_vencimento") = oSqlDataReader.Item("data_vencimento")
                        oDataRow("valor") = oSqlDataReader.Item("valor")
                        oDataRow("valor_pago") = 0
                        oDataTable.Rows.Add(oDataRow)

                    End While

                    'Fecah o SqlDataReader
                    If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

                End If

                'Limpa Grid
                oGrid.DataSource = Nothing

                'Configura DataMember
                ConfigurarDataMemberGrid(oGrid)

                'Carrega Grid
                oGrid.DataSource = oDataSet.DefaultViewManager
                oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

            Else

                'Limpa Grid
                oGrid.DataSource = Nothing

            End If

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: CLASSIFICAÇÃO :::"

    Public Sub InsertClassificacao(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer

        Try



            For Each oRow As GridEXRow In oGrid.GetDataRows

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Titulo Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_titulo_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoDespesaCapa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Código Centro Gasto
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_centro_custo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo_centro_custo").Value : i += 1

                'Seta Parametros - Código Conta Contábil
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_conta_contabil"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 20
                oSqlParameter(i).Value = oRow.Cells("codigo_conta_contabil").Value : i += 1

                'Seta Parametros - Valor
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("valor").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_titulo_classificacao", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteClassificacao(ByVal lCodigoTituloCapa As Long)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
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
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_financeiro_titulo_classificacao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridClassificacao(ByVal oGrid As GridEX, _
                                     ByVal lCodigoTituloCapa As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
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
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_titulo_classificacao", oSqlParameter)

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

    Public Sub InsertClassificacaoGrid(ByVal oGrid As GridEX, _
                                       ByVal sCentroGasto As String, _
                                       ByVal sContaContabil As String, _
                                       ByVal dValor As Double, _
                                       ByVal iCodigoCentroGasto As Integer, _
                                       ByVal sCodigoContaContabil As String, _
                                       ByVal sTipoOperacao As String, _
                                       ByVal iCodigoCentroGastoAntigo As Integer, _
                                       ByVal sCodigoContaContabilAntigo As String)

        Try

            'Variaveis Locais
            Dim oDataSet As New DataSet
            Dim oDataTable As New DataTable
            Dim oDataRow As DataRow
            Dim oDCCentroGasto As New DataColumn("centro_custo")
            Dim oDCContaContabil As New DataColumn("conta_contabil")
            Dim oDCValor As New DataColumn("valor")
            Dim oDCCodigoCentroGasto As New DataColumn("codigo_centro_custo")
            Dim oDCCodigoContaContabil As New DataColumn("codigo_conta_contabil")

            'Verifica se o DataSource é Vazio
            If Not oGrid.DataSource Is Nothing Then
                oDataSet = oGrid.DataSource.DataSet
                oDataTable = oDataSet.Tables(0)
                oGrid.DataSource = Nothing
            Else
                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)
                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCCentroGasto)
                oDataTable.Columns.Add(oDCContaContabil)
                oDataTable.Columns.Add(oDCValor)
                oDataTable.Columns.Add(oDCCodigoCentroGasto)
                oDataTable.Columns.Add(oDCCodigoContaContabil)
                'Seta DataType
                oDCValor.DataType = 0.0.GetType
            End If

            'Verifica o Tipo de Operação
            If sTipoOperacao = "I" Then
                'Adiciona Linhas ao DataTable
                oDataRow = oDataTable.NewRow
                oDataRow("centro_custo") = sCentroGasto
                oDataRow("conta_contabil") = sContaContabil
                oDataRow("valor") = dValor
                oDataRow("codigo_centro_custo") = IIf(iCodigoCentroGasto = -1, DBNull.Value, iCodigoCentroGasto)
                oDataRow("codigo_conta_contabil") = IIf(sCodigoContaContabil = "", DBNull.Value, sCodigoContaContabil)
                oDataTable.Rows.Add(oDataRow)
            Else
                Dim sQuery As String
                sQuery = IIf(iCodigoCentroGastoAntigo = -1, "(codigo_centro_custo IS NULL) ", "(codigo_centro_custo = " & iCodigoCentroGastoAntigo & ") ")
                sQuery &= IIf(sCodigoContaContabilAntigo = "", "AND (codigo_conta_contabil IS NULL)", "AND (codigo_conta_contabil = '" & sCodigoContaContabilAntigo & "')")
                oDataRow = oDataTable.Select(sQuery)(0)
                oDataRow("centro_custo") = sCentroGasto
                oDataRow("conta_contabil") = sContaContabil
                oDataRow("valor") = dValor
                oDataRow("codigo_centro_custo") = IIf(iCodigoCentroGasto = -1, DBNull.Value, iCodigoCentroGasto)
                oDataRow("codigo_conta_contabil") = IIf(sCodigoContaContabil = "", DBNull.Value, sCodigoContaContabil)
            End If

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: NOTA FISCAL - ENTRADA :::"

    Public Sub InsertNotaFiscalEntrada(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Titulo Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_titulo_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoDespesaCapa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Código Entrada Capa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_entrada_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo_entrada_capa").Value : i += 1

                'Seta Parametros - Código Conta Contábil
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_conta_contabil"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo_emissao_capa").Value : i += 1

                'Seta Parametros - Valor
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("valor").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_titulo_nota_fiscal_entrada", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteNotaFiscalEntrada(ByVal lCodigoTituloCapa As Long)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
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
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_financeiro_titulo_nota_fiscal_entrada", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridNotaFiscalEntrada(ByVal oGrid As GridEX, _
                                         ByVal lCodigoTituloCapa As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
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
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_titulo_nota_fiscal_entrada", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertNotaFiscalEntradaoGrid(ByVal oGrid As GridEX, _
                                            ByVal sNotaFiscal As String, _
                                            ByVal sSerie As String, _
                                            ByVal sDataEmissao As String, _
                                            ByVal sFornecedor As String, _
                                            ByVal dValor As Double, _
                                            ByVal lCodigoEmissaoCapa As Long, _
                                            ByVal lCodigoEntradaCapa As Long, _
                                            ByVal lCodigoAntigo As Long, _
                                            ByVal sTipo As String)

        Try

            'Variaveis Locais
            Dim oDataSet As New DataSet
            Dim oDataTable As New DataTable
            Dim oDataRow As DataRow
            Dim oDCNotaFiscal As New DataColumn("nota_fiscal")
            Dim oDCSerie As New DataColumn("serie")
            Dim oDCDataEmissao As New DataColumn("data_emissao")
            Dim oDCFornecedor As New DataColumn("fornecedor")
            Dim oDCValor As New DataColumn("valor")
            Dim oDCCodigoEmissaoCapa As New DataColumn("codigo_emissao_capa")
            Dim oDCCodigoEntradaCapa As New DataColumn("codigo_entrada_capa")

            'Verifica se o DataSource é Vazio
            If Not oGrid.DataSource Is Nothing Then
                oDataSet = oGrid.DataSource.DataSet
                oDataTable = oDataSet.Tables(0)
                oGrid.DataSource = Nothing
            Else
                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)
                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCNotaFiscal)
                oDataTable.Columns.Add(oDCSerie)
                oDataTable.Columns.Add(oDCDataEmissao)
                oDataTable.Columns.Add(oDCFornecedor)
                oDataTable.Columns.Add(oDCValor)
                oDataTable.Columns.Add(oDCCodigoEmissaoCapa)
                oDataTable.Columns.Add(oDCCodigoEntradaCapa)
                'Seta DataType
                oDCDataEmissao.DataType = Now.Date.GetType
                oDCValor.DataType = 0.0.GetType
            End If

            'Verifica o Tipo de Operação
            If sTipo = "" Then
                'Adiciona Linhas ao DataTable
                oDataRow = oDataTable.NewRow
                oDataRow("nota_fiscal") = sNotaFiscal
                oDataRow("serie") = sSerie
                oDataRow("data_emissao") = sDataEmissao
                oDataRow("fornecedor") = sFornecedor
                oDataRow("valor") = dValor
                oDataRow("codigo_emissao_capa") = IIf(lCodigoEmissaoCapa = -1, DBNull.Value, lCodigoEmissaoCapa)
                oDataRow("codigo_entrada_capa") = IIf(lCodigoEntradaCapa = -1, DBNull.Value, lCodigoEntradaCapa)
                oDataTable.Rows.Add(oDataRow)
            Else
                Dim sQuery As String
                sQuery = IIf(sTipo = "P", "(codigo_emissao_capa = " & lCodigoAntigo & ")", "(codigo_entrada_capa = " & lCodigoAntigo & ")")
                oDataRow = oDataTable.Select(sQuery)(0)
                oDataRow("nota_fiscal") = sNotaFiscal
                oDataRow("serie") = sSerie
                oDataRow("data_emissao") = sDataEmissao
                oDataRow("fornecedor") = sFornecedor
                oDataRow("valor") = dValor
                oDataRow("codigo_emissao_capa") = IIf(lCodigoEmissaoCapa = -1, DBNull.Value, lCodigoEmissaoCapa)
                oDataRow("codigo_entrada_capa") = IIf(lCodigoEntradaCapa = -1, DBNull.Value, lCodigoEntradaCapa)
            End If

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class
