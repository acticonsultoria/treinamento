Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.CalendarCombo

Public Class clsUsrFinReclassificacao

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

#End Region

#Region "::: PROPERTIE :::"

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

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sNumeroDocumento As String, _
                        ByVal sSerie As String, _
                        ByVal sParceiroNegocio As String, _
                        ByVal sTipo As String, _
                        ByVal iCodigoCentroGasto As Integer, _
                        ByVal sCodigoContaContabil As String, _
                        ByVal iStatus As Integer, _
                        ByVal sDataEmissaoInicio As String, _
                        ByVal sDataEmissaoTermino As String, _
                        ByVal sDataVencimentoInicio As String, _
                        ByVal sDataVencimentoTermino As String, _
                        ByVal sDataPagamentoInicio As String, _
                        ByVal sDataPagamentoTermino As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(13) As SqlParameter
        Dim i As Integer = 0

        Try

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

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Char
            oSqlParameter(i).Value = sTipo : i += 1

            'Seta Parametros - Código Centro Gasto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_custo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCentroGasto : i += 1

            'Seta Parametros - Código Conta Contábil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_conta_contabil"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCodigoContaContabil : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iStatus : i += 1

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

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_financeiro_titulo_reclassificacao", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oDataSet.Tables(0).Columns("codigo_titulo_capa"), oDataSet.Tables(1).Columns("codigo_titulo_capa"))

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

#End Region

#Region "::: CLASSIFICAÇÃO :::"

    Public Sub InsertClassificacao(ByVal lCodigoTituloCapa As Long, _
                                   ByVal iCodigoCentroGasto As Integer, _
                                   ByVal sCodigoContaContabil As String, _
                                   ByVal dValor As Double)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
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

            'Seta Parametros - Código Centro Gasto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_custo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoCentroGasto = -1, DBNull.Value, iCodigoCentroGasto) : i += 1

            'Seta Parametros - Código Conta Contábil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_conta_contabil"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sCodigoContaContabil = "", DBNull.Value, sCodigoContaContabil) : i += 1

            'Seta Parametros - Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValor

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_titulo_classificacao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateClassificacao(ByVal lCodigoTituloCapa As Long, _
                                   ByVal iCodigoCentroGasto As Integer, _
                                   ByVal sCodigoContaContabil As String, _
                                   ByVal dValor As Double, _
                                   ByVal iCodigoCentroGastoAntigo As Integer, _
                                   ByVal sCodigoContaContabilAntigo As String)

        'Variaveis Locais
        Dim oSqlParameter(6) As SqlParameter
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

            'Seta Parametros - Código Centro Gasto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_custo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoCentroGasto = -1, DBNull.Value, iCodigoCentroGasto) : i += 1

            'Seta Parametros - Código Conta Contábil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_conta_contabil"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sCodigoContaContabil = "", DBNull.Value, sCodigoContaContabil) : i += 1

            'Seta Parametros - Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValor : i += 1

            'Seta Parametros - Código Centro GastoAntigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_custo_antigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCentroGastoAntigo : i += 1

            'Seta Parametros - Código Conta Contábil Antigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_conta_contabil_antigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCodigoContaContabilAntigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_financeiro_titulo_classificacao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteClassificacao(ByVal lCodigoTituloCapa As Long, _
                                   ByVal iCodigoCentroGasto As Integer, _
                                   ByVal sCodigoContaContabil As String)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Título Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoTituloCapa : i += 1

            'Seta Parametros - Código Centro Gasto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_custo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCentroGasto : i += 1

            'Seta Parametros - Código Conta Contábil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_conta_contabil"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCodigoContaContabil : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_financeiro_titulo_classificacao2", oSqlParameter)

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

#End Region

#End Region

End Class
