Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls
Imports Janus.Windows.CalendarCombo
Imports System.Drawing.Printing

Public Class clsUsrFatEntradaNFs

#Region "::: VARIAVEIS :::"

#Region "::: VARIAVEIS - NOTA FISCAL :::"

    'Variaveis da Classe - Capa
    Private lNotaFiscal As Long
    Private sSerie As String
    Private sDataEmissao As String
    Private sDataEntrada As String
    Private iCodigoTipoNotaFiscal As Integer
    Private sCodigoVerificacao As String
    Private lCodigoNFsCapa As Long    

#End Region

#Region "::: VARIAVEIS - PRESTADOR :::"

    'Váriaveis da Classe - Destinatário
    Private iCodigoPrestador As Integer
    Private sCnpjCpfPrestador As String
    Private sInscricaoEstadualPrestador As String
    Private sInscricaoMunicipalPrestador As String
    Private sCepPrestador As String
    Private iCodigoPaisPrestador As Integer
    Private sUFPrestador As String
    Private iCodigoMunicipioPrestador As Integer
    Private sLogradouroPrestador As String
    Private sNumeroPrestador As String
    Private sBairroPrestador As String
    Private sComplementoPrestador As String
    Private sTelefonePrestador As String
    Private sEmailPrestador As String

#End Region

#Region "::: VARIAVEIS - SERVIÇO :::"

    'Variaveis da Classe - Capa
    Private sPedidoCompra As String
    Private lCodigoServico As Long
    Private sDescricao As String
    Private dValorServico As Double
    Private dDescontoCondicional As Double
    Private dDescontoIncondicional As Double
    Private dValorLiquidoServico As Double
    Private iCodigoCentroGasto As Integer
    Private sCodigoContaContabil As String
    Private dOutrasReducoes As Double
    Private dValorDeducoes As Double
    Private dBaseCalculo As Double
    Private dAliquotaISS As Double
    Private dValorISS As Double
    Private bISSRetido As Boolean
    Private dValorISSRetido As Double
    Private dAliquotaPIS As Double
    Private dValorPIS As Double
    Private dAliquotaCOFINS As Double
    Private dValorCOFINS As Double
    Private dAliquotaINSS As Double
    Private dValorINSS As Double
    Private dAliquotaCSLL As Double
    Private dValorCSLL As Double
    Private dAliquotaIR As Double
    Private dValorIR As Double
    Private lCodigoPedidoVenda As Long
    Private iCodigoPedidoVendaItem As Integer
    Private iCodigoPedidoVendaItemEntrega As Integer
    Private dQuantidadePedido As Double
    Private bCalculoImpostoManual As Boolean

#End Region

#Region "::: VARIAVEIS - FATURA :::"

    'Váriaveis da Classe - Fatura
    Private sFatura As String
    Private dValorOriginal As Double
    Private dValorDesconto As Double
    Private dValorLiquido As Double
    Private iCodigoFormaPagamentoNFe As Integer
    Private iNumeroParcela As Integer
    Private iIntervaloParcela As Integer

#End Region

#End Region

#Region "::: PROPERTIE :::"

#Region "::: PROPERTIE - NOTA FISCAL :::"

    Public Property NotaFiscal() As Long
        Get
            Return lNotaFiscal
        End Get
        Set(ByVal value As Long)
            lNotaFiscal = value
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

    Public Property DataEmissao() As String
        Get
            Return sDataEmissao
        End Get
        Set(ByVal value As String)
            sDataEmissao = value
        End Set
    End Property

    Public Property DataEntrada() As String
        Get
            Return sDataEntrada
        End Get
        Set(ByVal value As String)
            sDataEntrada = value
        End Set
    End Property

    Public Property CodigoTipoNotaFiscal() As Integer
        Get
            Return iCodigoTipoNotaFiscal
        End Get
        Set(ByVal value As Integer)
            iCodigoTipoNotaFiscal = value
        End Set
    End Property

    Public Property CodigoVerificacao() As String
        Get
            Return sCodigoVerificacao
        End Get
        Set(ByVal value As String)
            sCodigoVerificacao = value
        End Set
    End Property

    Public Property CodigoNFSCapa() As Long
        Get
            Return lCodigoNFsCapa
        End Get
        Set(ByVal value As Long)
            lCodigoNFsCapa = value
        End Set
    End Property

#End Region

#Region "::: PROPERTIE - PRESTADOR :::"

    Public Property CodigoPrestador() As Integer
        Get
            Return iCodigoPrestador
        End Get
        Set(ByVal value As Integer)
            iCodigoPrestador = value
        End Set
    End Property

    Public Property CnpjCpfPrestador() As String
        Get
            Return sCnpjCpfPrestador
        End Get
        Set(ByVal value As String)
            sCnpjCpfPrestador = value
        End Set
    End Property

    Public Property InscricaoEstadualPrestador() As String
        Get
            Return sInscricaoEstadualPrestador
        End Get
        Set(ByVal value As String)
            sInscricaoEstadualPrestador = value
        End Set
    End Property

    Public Property InscricaoMunicipalPrestador() As String
        Get
            Return sInscricaoMunicipalPrestador
        End Get
        Set(ByVal value As String)
            sInscricaoMunicipalPrestador = value
        End Set
    End Property

    Public Property CepPrestador() As String
        Get
            Return sCepPrestador
        End Get
        Set(ByVal value As String)
            sCepPrestador = value
        End Set
    End Property

    Public Property CodigoPaisPrestador() As Integer
        Get
            Return iCodigoPaisPrestador
        End Get
        Set(ByVal value As Integer)
            iCodigoPaisPrestador = value
        End Set
    End Property

    Public Property UFPrestador() As String
        Get
            Return sUFPrestador
        End Get
        Set(ByVal value As String)
            sUFPrestador = value
        End Set
    End Property

    Public Property CodigoMunicipioPrestador() As Integer
        Get
            Return iCodigoMunicipioPrestador
        End Get
        Set(ByVal value As Integer)
            iCodigoMunicipioPrestador = value
        End Set
    End Property

    Public Property LogradouroPrestador() As String
        Get
            Return sLogradouroPrestador
        End Get
        Set(ByVal value As String)
            sLogradouroPrestador = value
        End Set
    End Property

    Public Property NumeroPrestador() As String
        Get
            Return sNumeroPrestador
        End Get
        Set(ByVal value As String)
            sNumeroPrestador = value
        End Set
    End Property

    Public Property BairroPrestador() As String
        Get
            Return sBairroPrestador
        End Get
        Set(ByVal value As String)
            sBairroPrestador = value
        End Set
    End Property

    Public Property ComplementoPrestador() As String
        Get
            Return sComplementoPrestador
        End Get
        Set(ByVal value As String)
            sComplementoPrestador = value
        End Set
    End Property

    Public Property TelefonePrestador() As String
        Get
            Return sTelefonePrestador
        End Get
        Set(ByVal value As String)
            sTelefonePrestador = value
        End Set
    End Property

    Public Property EmailPrestador() As String
        Get
            Return sEmailPrestador
        End Get
        Set(ByVal value As String)
            sEmailPrestador = value
        End Set
    End Property

#End Region

#Region "::: PROPERTIE - SERVIÇO :::"

    Public Property CodigoServico() As Long
        Get
            Return lCodigoServico
        End Get
        Set(ByVal value As Long)
            lCodigoServico = value
        End Set
    End Property

    Public Property PedidoCompra() As String
        Get
            Return sPedidoCompra
        End Get
        Set(ByVal value As String)
            sPedidoCompra = value
        End Set
    End Property

    Public Property Descricao() As String
        Get
            Return sDescricao
        End Get
        Set(ByVal value As String)
            sDescricao = value
        End Set
    End Property

    Public Property ValorServico() As Double
        Get
            Return dValorServico
        End Get
        Set(ByVal value As Double)
            dValorServico = value
        End Set
    End Property

    Public Property DescontoCondicional() As Double
        Get
            Return dDescontoCondicional
        End Get
        Set(ByVal value As Double)
            dDescontoCondicional = value
        End Set
    End Property

    Public Property DescontoIncondicional() As Double
        Get
            Return dDescontoIncondicional
        End Get
        Set(ByVal value As Double)
            dDescontoIncondicional = value
        End Set
    End Property

    Public Property ValorLiquidoServico() As Double
        Get
            Return dValorLiquidoServico
        End Get
        Set(ByVal value As Double)
            dValorLiquidoServico = value
        End Set
    End Property

    Public Property CodigoCentroGasto() As Integer
        Get
            Return iCodigoCentroGasto
        End Get
        Set(ByVal value As Integer)
            iCodigoCentroGasto = value
        End Set
    End Property

    Public Property CodigoContaContabil() As String
        Get
            Return sCodigoContaContabil
        End Get
        Set(ByVal value As String)
            sCodigoContaContabil = value
        End Set
    End Property

    Public Property OutrasReducoes() As Double
        Get
            Return dOutrasReducoes
        End Get
        Set(ByVal value As Double)
            dOutrasReducoes = value
        End Set
    End Property

    Public Property ValorDeducoes() As Double
        Get
            Return dValorDeducoes
        End Get
        Set(ByVal value As Double)
            dValorDeducoes = value
        End Set
    End Property

    Public Property BaseCalculo() As Double
        Get
            Return dBaseCalculo
        End Get
        Set(ByVal value As Double)
            dBaseCalculo = value
        End Set
    End Property

    Public Property AliquotaISS() As Double
        Get
            Return dAliquotaISS
        End Get
        Set(ByVal value As Double)
            dAliquotaISS = value
        End Set
    End Property

    Public Property ValorISS() As Double
        Get
            Return dValorISS
        End Get
        Set(ByVal value As Double)
            dValorISS = value
        End Set
    End Property

    Public Property ISSRetido() As Boolean
        Get
            Return bISSRetido
        End Get
        Set(ByVal value As Boolean)
            bISSRetido = value
        End Set
    End Property

    Public Property ValorISSRetido() As Double
        Get
            Return dValorISSRetido
        End Get
        Set(ByVal value As Double)
            dValorISSRetido = value
        End Set
    End Property

    Public Property AliquotaPIS() As Double
        Get
            Return dAliquotaPIS
        End Get
        Set(ByVal value As Double)
            dAliquotaPIS = value
        End Set
    End Property

    Public Property ValorPIS() As Double
        Get
            Return dValorPIS
        End Get
        Set(ByVal value As Double)
            dValorPIS = value
        End Set
    End Property

    Public Property AliquotaCOFINS() As Double
        Get
            Return dAliquotaCOFINS
        End Get
        Set(ByVal value As Double)
            dAliquotaCOFINS = value
        End Set
    End Property

    Public Property ValorCOFINS() As Double
        Get
            Return dValorCOFINS
        End Get
        Set(ByVal value As Double)
            dValorCOFINS = value
        End Set
    End Property

    Public Property AliquotaINSS() As Double
        Get
            Return dAliquotaINSS
        End Get
        Set(ByVal value As Double)
            dAliquotaINSS = value
        End Set
    End Property

    Public Property ValorINSS() As Double
        Get
            Return dValorINSS
        End Get
        Set(ByVal value As Double)
            dValorINSS = value
        End Set
    End Property

    Public Property AliquotaCSLL() As Double
        Get
            Return dAliquotaCSLL
        End Get
        Set(ByVal value As Double)
            dAliquotaCSLL = value
        End Set
    End Property

    Public Property ValorCSLL() As Double
        Get
            Return dValorCSLL
        End Get
        Set(ByVal value As Double)
            dValorCSLL = value
        End Set
    End Property

    Public Property AliquotaIR() As Double
        Get
            Return dAliquotaIR
        End Get
        Set(ByVal value As Double)
            dAliquotaIR = value
        End Set
    End Property

    Public Property ValorIR() As Double
        Get
            Return dValorIR
        End Get
        Set(ByVal value As Double)
            dValorIR = value
        End Set
    End Property

    Public Property CodigoPedidoVenda() As Long
        Get
            Return lCodigoPedidoVenda
        End Get
        Set(ByVal value As Long)
            lCodigoPedidoVenda = value
        End Set
    End Property

    Public Property CodigoPedidoVendaItem() As Integer
        Get
            Return iCodigoPedidoVendaItem
        End Get
        Set(ByVal value As Integer)
            iCodigoPedidoVendaItem = value
        End Set
    End Property

    Public Property CodigoPedidoVendaItemEntrega() As Integer
        Get
            Return iCodigoPedidoVendaItemEntrega
        End Get
        Set(ByVal value As Integer)
            iCodigoPedidoVendaItemEntrega = value
        End Set
    End Property

    Public Property QuantidadePedido() As Double
        Get
            Return dQuantidadePedido
        End Get
        Set(ByVal value As Double)
            dQuantidadePedido = value
        End Set
    End Property

    Public Property CalculoImpostoManual() As Boolean
        Get
            Return bCalculoImpostoManual
        End Get
        Set(ByVal value As Boolean)
            bCalculoImpostoManual = value
        End Set
    End Property

#End Region

#Region "::: PROPERTIE - FATURA :::"

    Public Property Fatura() As String
        Get
            Return sFatura
        End Get
        Set(ByVal value As String)
            sFatura = value
        End Set
    End Property

    Public Property ValorOriginal() As Double
        Get
            Return dValorOriginal
        End Get
        Set(ByVal value As Double)
            dValorOriginal = value
        End Set
    End Property

    Public Property ValorDesconto() As Double
        Get
            Return dValorDesconto
        End Get
        Set(ByVal value As Double)
            dValorDesconto = value
        End Set
    End Property

    Public Property ValorLiquido() As Double
        Get
            Return dValorLiquido
        End Get
        Set(ByVal value As Double)
            dValorLiquido = value
        End Set
    End Property

    Public Property CodigoFormaPagamentoNFe() As Integer
        Get
            Return iCodigoFormaPagamentoNFe
        End Get
        Set(ByVal value As Integer)
            iCodigoFormaPagamentoNFe = value
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

#End Region

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: NOTA FISCAL :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal lNotaFiscal As Long, _
                        ByVal sSerie As String, _
                        ByVal sPedidoCompra As String, _
                        ByVal sPrestador As String, _
                        ByVal sDataEmissaoInicio As String, _
                        ByVal sDataEmissaoTermino As String, _
                        ByVal sDataEntradaInicio As String, _
                        ByVal sDataEntradaTermino As String, _
                        ByVal sCodigoTipoNotaFiscal As String, _
                        ByVal sStatus As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(10) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lNotaFiscal : i += 1

            'Seta Parametros - Série
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "serie"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5
            oSqlParameter(i).Value = sSerie : i += 1

            'Seta Parametros - Prestador
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "prestador"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sPrestador : i += 1

            'Seta Parametros - Pedido de Compra
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pedido_compra"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sPedidoCompra : i += 1

            'Seta Parametros - Data de Emissão - Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataEmissaoInicio = "", DBNull.Value, sDataEmissaoInicio) : i += 1

            'Seta Parametros - Data de Emissão - Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataEmissaoTermino = "", DBNull.Value, sDataEmissaoTermino) : i += 1

            'Seta Parametros - Data de Entrada - Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_entrada_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataEntradaInicio = "", DBNull.Value, sDataEntradaInicio) : i += 1

            'Seta Parametros - Data de Entrada - Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_entrada_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataEntradaTermino = "", DBNull.Value, sDataEntradaTermino) : i += 1

            'Seta Parametros - Código Tipo de Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sCodigoTipoNotaFiscal : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sStatus : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_entrada_nfs", oSqlParameter)

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oDataSet.Tables(0).Columns("codigo"), oDataSet.Tables(1).Columns("codigo_nfs_capa"))

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName
            
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridHistorico(ByVal oGrid As GridEX, _
                                 ByVal lCodigoNFSCapa As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_nfs_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoNFSCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_entrada_nfs_historico", oSqlParameter)

            'Configura DataMember
            ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertCapa()

        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Tipo de Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoNotaFiscal : i += 1

            'Seta Parametros - Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lNotaFiscal : i += 1

            'Seta Parametros - Série
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "serie"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5
            oSqlParameter(i).Value = sSerie : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = StatusNFsEntrada.AutorizadoUso : i += 1

            'Seta Parametros - Data Emissão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataEmissao : i += 1

            'Seta Parametros - Data Entrada
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_entrada"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataEntrada : i += 1

            'Seta Parametros - Código de Verificador
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_verificacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 9
            oSqlParameter(i).Value = IIf(sCodigoVerificacao = "", DBNull.Value, sCodigoVerificacao) : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_nfs_capa", oSqlParameter)

            'Seta Váriavel 
            lCodigoNFsCapa = oSqlParameter(9).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateCapa()

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Tipo de Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoNotaFiscal : i += 1

            'Seta Parametros - Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lNotaFiscal : i += 1

            'Seta Parametros - Série
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "serie"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5
            oSqlParameter(i).Value = sSerie : i += 1

            'Seta Parametros - Data Emissão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataEmissao : i += 1

            'Seta Parametros - Data Entrada
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_entrada"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataEntrada : i += 1

            'Seta Parametros - Código de Verificador
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_verificacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 9
            oSqlParameter(i).Value = IIf(sCodigoVerificacao = "", DBNull.Value, sCodigoVerificacao) : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoNFsCapa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_entrada_nfs_capa", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteCapa()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            'Exclui Registro
            For Each oRow As GridEXRow In gSelecaoRow

                i = 0

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_usuario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = goUsuario.iUsuario

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_entrada_nfs_capa", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosNotaFiscal(ByVal lCodigo As Long, _
                                   ByVal cboTipoNotaFiscal As UIComboBox, _
                                   ByVal txtNotaFiscal As MaskedEditBox, _
                                   ByVal txtSerie As MaskedEditBox, _
                                   ByVal dtpDataEmissao As CalendarCombo, _
                                   ByVal dtpDataEntrada As CalendarCombo, _
                                   ByVal txtCodigoVerificacao As MaskedEditBox, _
                                   ByVal cboPrestador As UIComboBox, _
                                   ByVal txtCNPJPrestador As MaskedEditBox, _
                                   ByVal txtInscricaoEstadualPrestador As MaskedEditBox, _
                                   ByVal txtInscricaoMunicipalPrestador As MaskedEditBox, _
                                   ByVal txtCEPPrestador As MaskedEditBox, _
                                   ByVal cboPaisPrestador As UIComboBox, _
                                   ByVal cboUFPrestador As UIComboBox, _
                                   ByVal cboMunicipioPrestador As UIComboBox, _
                                   ByVal txtLogradouroPrestador As MaskedEditBox, _
                                   ByVal txtNumeroPrestador As MaskedEditBox, _
                                   ByVal txtBairroPrestador As MaskedEditBox, _
                                   ByVal txtComplementoPrestador As MaskedEditBox, _
                                   ByVal txtTelefonePrestador As MaskedEditBox, _
                                   ByVal txtEmailPrestador As MaskedEditBox, _
                                   ByVal txtFatura As MaskedEditBox, _
                                   ByVal txtValorOriginal As NumericEditBox, _
                                   ByVal txtValorDesconto As NumericEditBox, _
                                   ByVal txtValorLiquido As NumericEditBox, _
                                   ByVal cboFormaPagamento As UIComboBox, _
                                   ByVal txtNumeroParcela As NumericEditBox, _
                                   ByVal txtIntervaloEntreParcelas As NumericEditBox, _
                                   ByVal cboTipoDocumentoPagamento As UIComboBox, _
                                   ByVal txtDescritivo As EditBox)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
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
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_entrada_nfs_dados", oSqlParameter)

            While oSqlDataReader.Read

                cboTipoNotaFiscal.SelectedValue = oSqlDataReader.Item("codigo_tipo_nota_fiscal")
                txtNotaFiscal.Text = oSqlDataReader.Item("numero_documento")
                txtSerie.Text = oSqlDataReader.Item("serie")
                dtpDataEmissao.Value = oSqlDataReader.Item("data_emissao")
                dtpDataEntrada.Value = oSqlDataReader.Item("data_entrada")
                txtCodigoVerificacao.Text = oSqlDataReader.Item("codigo_verificacao")
                cboPrestador.SelectedValue = oSqlDataReader.Item("codigo_prestador")
                txtCNPJPrestador.Text = oSqlDataReader.Item("cnpj_cpf")
                txtInscricaoEstadualPrestador.Text = oSqlDataReader.Item("inscricao_estadual")
                txtInscricaoMunicipalPrestador.Text = oSqlDataReader.Item("inscricao_municipal")
                txtCEPPrestador.Text = oSqlDataReader.Item("cep")
                cboPaisPrestador.SelectedValue = oSqlDataReader.Item("codigo_pais")
                cboUFPrestador.SelectedValue = oSqlDataReader.Item("uf")
                cboMunicipioPrestador.SelectedValue = oSqlDataReader.Item("codigo_municipio")
                txtLogradouroPrestador.Text = oSqlDataReader.Item("logradouro")
                txtNumeroPrestador.Text = oSqlDataReader.Item("numero")
                txtBairroPrestador.Text = oSqlDataReader.Item("bairro")
                txtComplementoPrestador.Text = oSqlDataReader.Item("complemento")
                txtTelefonePrestador.Text = oSqlDataReader.Item("telefone")
                txtEmailPrestador.Text = oSqlDataReader.Item("email")
                txtFatura.Text = oSqlDataReader.Item("fatura")
                txtValorOriginal.Value = oSqlDataReader.Item("valor_original")
                txtValorDesconto.Value = oSqlDataReader.Item("valor_desconto")
                txtValorLiquido.Value = oSqlDataReader.Item("valor_liquido")
                cboFormaPagamento.SelectedValue = oSqlDataReader.Item("codigo_forma_pagamento")
                txtNumeroParcela.Value = oSqlDataReader.Item("numero_parcela")
                txtIntervaloEntreParcelas.Value = oSqlDataReader.Item("intervalo_parcela")

                'Try
                '    If IsDBNull(oSqlDataReader.Item("codigo_tipo_documento_pagamento")) Then
                '        cboTipoDocumentoPagamento.SelectedIndex = -1
                '    Else
                '        cboTipoDocumentoPagamento.SelectedValue = oSqlDataReader.Item("codigo_tipo_documento_pagamento")
                '    End If
                'Catch ex As Exception

                'End Try
            End While

            'Fecha o SQLDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosVinculoTituloPrevisto(ByVal lCodigoTituloCapa As Long, _
                                               ByVal cboTituloPrevisto As UIComboBox, _
                                               ByVal txtNumeroDocumentoPrevisto As MaskedEditBox, _
                                               ByVal txtNumeroParcela As MaskedEditBox, _
                                               ByVal txtValorPrevisto As NumericEditBox, _
                                               ByVal dtpDataVencimentoPrevisto As CalendarCombo)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
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
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_titulo_previsao_dados", oSqlParameter)

            While oSqlDataReader.Read

                txtValorPrevisto.Value = oSqlDataReader.Item("valor_previsto")
                txtNumeroDocumentoPrevisto.Text = oSqlDataReader.Item("numero_documento_previsto")
                txtNumeroParcela.Text = oSqlDataReader.Item("numero_parcela_previsto")
                dtpDataVencimentoPrevisto.Value = oSqlDataReader.Item("data_vencimento_previsto")

                'Habilita Controle
                If oSqlDataReader.Item("numero_documento_previsto") <> "" Then
                    cboTituloPrevisto.Enabled = False
                Else
                    cboTituloPrevisto.Enabled = True
                End If


            End While

            'Fecha o SQLDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Cancelar(ByVal lCodigoNFSCapa As Long, _
                        ByVal sJustificativa As String)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código NFS Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_nfs_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoNFSCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Justificativa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "justificativa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sJustificativa : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = StatusNFsEntrada.Cancelada

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_entrada_nfs_status", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaDocumentoNFs(ByVal lCodigoEntradaNFsCapa As Long, _
                                      ByVal lNumeroDocumento As Long, _
                                    ByVal sSerie As String, _
                                    ByVal lCodigoPrestador As Long) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim iReturn As Integer
        Dim i As Integer = 0

        Try

            'Seta Retorno da Função
            ValidaDocumentoNFs = False


            'Seta Parametros - Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nota_fiscal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lNumeroDocumento : i += 1

            'Seta Parametros - Série
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "serie"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sSerie : i += 1

            'Seta Parametros - Código Prestador
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_prestador"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPrestador : i += 1

            'Seta Parametros - Código Entrada Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_nfs_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaNFsCapa : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_faturamento_entrada_nfs_capa", oSqlParameter), Integer)

            'Seta Retorno da Função
            ValidaDocumentoNFs = IIf(iReturn > 0, False, True)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ValidaContrato(ByVal lCodigoPedido As Long) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim iReturn As Integer
        Dim i As Integer = 0

        Try

            'Seta Retorno da Função
            ValidaContrato = False

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_faturamento_entrada_nfs_contrato", oSqlParameter), Integer)

            'Seta Retorno da Função
            ValidaContrato = IIf(iReturn > 0, False, True)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function


#End Region

#Region "::: PRESTADOR :::"

    Public Sub InsertPrestador()

        'Variaveis Locais
        Dim oSqlParameter(15) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_nfs_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoNFsCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Prestador
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_prestador"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoPrestador : i += 1

            'Seta Parametros - CNPJ / CPF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnpj_cpf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCnpjCpfPrestador : i += 1

            'Seta Parametros - Inscrição Estadual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inscricao_estadual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 14
            oSqlParameter(i).Value = sInscricaoEstadualPrestador : i += 1

            'Seta Parametros - Inscrição Municipal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inscricao_municipal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 9
            oSqlParameter(i).Value = sInscricaoMunicipalPrestador : i += 1

            'Seta Parametros - CEP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cep"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sCepPrestador : i += 1

            'Seta Parametros - Código Pais
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pais"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoPaisPrestador : i += 1

            'Seta Parametros - UF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "uf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sUFPrestador : i += 1

            'Seta Parametros - Código Municipio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_municipio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoMunicipioPrestador : i += 1

            'Seta Parametros - Logradouro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "logradouro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sLogradouroPrestador : i += 1

            'Seta Parametros - Número
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sNumeroPrestador : i += 1

            'Seta Parametros - Bairro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "bairro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sBairroPrestador : i += 1

            'Seta Parametros - Complemento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "complemento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sComplementoPrestador = "", DBNull.Value, sComplementoPrestador) : i += 1

            'Seta Parametros - Telefone
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = IIf(sTelefonePrestador = "", DBNull.Value, sTelefonePrestador) : i += 1

            'Seta Parametros - Email
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "email"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sEmailPrestador = "", DBNull.Value, sEmailPrestador)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_nfs_prestador", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeletePrestador()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_nfs_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoNFsCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_entrada_nfs_prestador", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub VerificaPrestador(ByVal cboPrestador As UIComboBox, _
                                 ByVal sCNPJCPF As String, _
                                 ByVal sRazaoSocial As String, _
                                 ByVal sInscricaoEstadual As String, _
                                 ByVal sInscricaoMunicipal As String, _
                                 ByVal sCEP As String, _
                                 ByVal sLogradouro As String, _
                                 ByVal sNumero As String, _
                                 ByVal sBairro As String, _
                                 ByVal sComplemento As String, _
                                 ByVal sTelefone As String, _
                                 ByVal sEmail As String)

        'Variaveis Locais
        Dim oSqlParameter(12) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - CNPJ / CPF
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cnpj_cpf"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sCNPJCPF : i += 1

            'Seta Parametros - Razão Social
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "razao_social"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sRazaoSocial : i += 1

            'Seta Parametros - Inscrição Estadual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inscricao_estadual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 14
            oSqlParameter(i).Value = sInscricaoEstadual : i += 1

            'Seta Parametros - Inscrição Municipal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "inscricao_municipal"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 9
            oSqlParameter(i).Value = sInscricaoMunicipal : i += 1

            'Seta Parametros - CEP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cep"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 10
            oSqlParameter(i).Value = sCEP : i += 1

            'Seta Parametros - Logradouro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "logradouro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sLogradouro : i += 1

            'Seta Parametros - Número
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sNumero : i += 1

            'Seta Parametros - Bairro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "bairro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sBairro : i += 1

            'Seta Parametros - Complemento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "complemento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sComplemento = "", DBNull.Value, sComplemento) : i += 1

            'Seta Parametros - Telefone
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "telefone"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 15
            oSqlParameter(i).Value = IIf(sTelefone = "", DBNull.Value, sTelefone) : i += 1

            'Seta Parametros - Email
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "email"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sEmail = "", DBNull.Value, sEmail) : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_faturamento_entrada_nfs_prestador_sjc", oSqlParameter)

            'Carrega Combo
            Call LoadCombo(cboPrestador, "sp_select_combo_cadastro_basico_fornecedor " & goUsuario.iEmpresa, False)
            cboPrestador.SelectedValue = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: TOMADOR :::"

    Public Sub InsertTomador()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_nfs_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoNFsCapa : i += 1

            'Seta Parametros - Código Tomador
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tomador"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_nfs_tomador", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteTomador()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_nfs_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoNFsCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_entrada_nfs_tomador", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: FATURA :::"

    Public Sub InsertFatura()

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_nfs_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoNFsCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Fatura
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fatura"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sFatura = "", DBNull.Value, sFatura) : i += 1

            'Seta Parametros - Valor Fatura
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_original"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorOriginal : i += 1

            'Seta Parametros - Valor Desconto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_desconto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorDesconto : i += 1

            'Seta Parametros - Valor Liquido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_liquido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorLiquido : i += 1

            'Seta Parametros - Código Forma de Pagamento NFe
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_forma_pagamento_nfe"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoFormaPagamentoNFe : i += 1

            'Seta Parametros - Número de Parcela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iNumeroParcela : i += 1

            'Seta Parametros - Intervalo de Parcela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "intervalo_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iIntervaloParcela

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_nfs_fatura", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertFaturaDuplicata(ByVal oGrid As GridEX)

        Try

            'Variaveis Locais
            Dim j, i As Integer
            Dim oSqlParameter(4) As SqlParameter

            For Each oRow As GridEXRow In oGrid.GetDataRows

                i = 0

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_nfs_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoNFsCapa : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - N° Duplicata
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero_duplicata"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.RowIndex + 1 : i += 1

                'Seta Parametros - Data Vencimento
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data_vencimento"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = oRow.Cells("data_vencimento").Value : i += 1

                'Seta Parametros - Valor
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("valor").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_nfs_fatura_duplicata", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteFatura()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_nfs_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoNFsCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_entrada_nfs_fatura", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridFatura(ByVal oGrid As GridEX, _
                              ByVal lCodigoNotaFiscal As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_nfs_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoNotaFiscal : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_entrada_nfs_fatura_duplicata", oSqlParameter)

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
                              ByVal dValor As Double, _
                              ByVal iNumeroParcela As Integer, _
                              ByVal iIntervaloParcela As Integer)

        Try

            'Limpa Grid
            oGrid.DataSource = Nothing

            'Caso Valor Liquido maior que 0
            If dValor > 0 Then

                'Variaveis Locais
                Dim oDataSet As New DataSet
                Dim oDataTable As New DataTable
                Dim oDCVencimento As New DataColumn("data_vencimento")
                Dim oDCValor As New DataColumn("valor")

                'Seta DataType
                oDCVencimento.DataType = Now.Date.GetType
                oDCValor.DataType = 0.0.GetType

                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)

                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCVencimento)
                oDataTable.Columns.Add(oDCValor)

                'Adiciona Linhas ao DataTable
                For i = 1 To iNumeroParcela
                    Dim oDataRow As DataRow = oDataTable.NewRow
                    oDataRow("data_vencimento") = CDate(DateAdd(DateInterval.Day, i * iIntervaloParcela, Now.Date))
                    oDataRow("valor") = dValor / iNumeroParcela
                    oDataTable.Rows.Add(oDataRow)
                Next

                'Configura DataMember
                Call ConfigurarDataMemberGrid(oGrid)

                'Carrega Grid
                oGrid.DataSource = oDataSet.DefaultViewManager
                oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

            End If

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Public Sub LoadControlesTituloPrevisao(ByVal lCodigo As Long, _
                                           ByVal iNumeroParcela As Integer, _
                                           ByVal txtNumeroDocumentoPrevisto As MaskedEditBox,
                                           ByVal txtNumeroParcelaPrevisto As MaskedEditBox, _
                                           ByVal txtValorPrevisto As NumericEditBox, _
                                           ByVal dtpDataVencimentoPrevisto As CalendarCombo)

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

            'Seta Parametros - Número Parcela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iNumeroParcela : i += 1

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
                    txtNumeroParcelaPrevisto.Text = oSqlDataReader.Item("numero_parcela")
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

    Public Sub UpdateVinculoTituloPrevisao(ByVal lCodigoTituloPrevisto As Long, _
                                           ByVal iNumeroParcelaPrevisto As Integer, _
                                           ByVal lCodigoTituloCapa As Long)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try


            'Seta Parametros - Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoTituloCapa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_previsto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoTituloPrevisto : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela_previsto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iNumeroParcelaPrevisto : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_financeiro_titulo_vinculo_previsao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteVinculoTituloPrevisao(ByVal lCodigoTituloPrevisto As Long, _
                                           ByVal iNumeroParcelaPrevisto As Integer)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_previsto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoTituloPrevisto : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela_previsto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iNumeroParcelaPrevisto : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_financeiro_titulo_previsto", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
#End Region

#Region "::: SERVIÇO :::"

    Public Sub InsertServico()

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_nfs_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoNFsCapa : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoServico : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Descricao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5000
            oSqlParameter(i).Value = sDescricao : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Valor Serviço
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_servico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorServico : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Desconto Condicional
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desconto_condicional"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDescontoCondicional : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Desconto Incondicional
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desconto_incondicional"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDescontoIncondicional : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Valor Líquido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_liquido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorLiquidoServico : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Centro de Gasto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_custo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoCentroGasto = -1, DBNull.Value, iCodigoCentroGasto) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Conta Contábil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_conta_contabil"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sCodigoContaContabil = "", DBNull.Value, sCodigoContaContabil) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Outras Retenções
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "outras_retencoes"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dOutrasReducoes : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Valor Deduções
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_deducoes"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorDeducoes : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Base Cálculo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "base_calculo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dBaseCalculo : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Alíquota ISS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_iss"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaISS : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Valor ISS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_iss"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorISS : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - ISS Retido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "iss_retido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bISSRetido : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Valor ISS Retido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_iss_retido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorISSRetido : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Alíquota PIS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_pis"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaPIS : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Valor PIS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_pis"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorPIS : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Alíquota COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaCOFINS : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Valor COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorCOFINS : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Alíquota INSS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_inss"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaINSS : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Valor INSS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_inss"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorINSS : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Alíquota CSLL
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_csll"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaCSLL : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Valor CSLL
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_csll"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorCSLL : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Alíquota IR
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_ir"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaIR : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Valor IR
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ir"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorIR : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Cálculo Imposto Manual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "calculo_imposto_manual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bCalculoImpostoManual : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Quantidade Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dQuantidadePedido = -1, DBNull.Value, dQuantidadePedido)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_faturamento_entrada_nfs_servico", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Public Sub UpdateServico(ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(35) As SqlParameter
        Dim i As Integer = 1

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_nfs_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoNFsCapa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoServico : i += 1

            'Seta Parametros - Descricao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5000
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Valor Serviço
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_servico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorServico : i += 1

            'Seta Parametros - Desconto Condicional
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desconto_condicional"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDescontoCondicional : i += 1

            'Seta Parametros - Desconto Incondicional
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desconto_incondicional"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDescontoIncondicional : i += 1

            'Seta Parametros - Valor Líquido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_liquido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorLiquidoServico : i += 1

            'Seta Parametros - Código Centro de Gasto
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

            'Seta Parametros - Outras Retenções
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "outras_retencoes"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dOutrasReducoes : i += 1

            'Seta Parametros - Valor Deduções
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_deducoes"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorDeducoes : i += 1

            'Seta Parametros - Base Cálculo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "base_calculo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dBaseCalculo : i += 1

            'Seta Parametros - Alíquota ISS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_iss"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaISS : i += 1

            'Seta Parametros - Valor ISS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_iss"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorISS : i += 1

            'Seta Parametros - ISS Retido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "iss_retido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bISSRetido : i += 1

            'Seta Parametros - Valor ISS Retido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_iss_retido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorISSRetido : i += 1

            'Seta Parametros - Alíquota PIS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_pis"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaPIS : i += 1

            'Seta Parametros - Valor PIS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_pis"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorPIS : i += 1

            'Seta Parametros - Alíquota COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaCOFINS : i += 1

            'Seta Parametros - Valor COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorCOFINS : i += 1

            'Seta Parametros - Alíquota INSS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_inss"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaINSS : i += 1

            'Seta Parametros - Valor INSS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_inss"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorINSS : i += 1

            'Seta Parametros - Alíquota CSLL
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_csll"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaCSLL : i += 1

            'Seta Parametros - Valor CSLL
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_csll"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorCSLL : i += 1

            'Seta Parametros - Alíquota IR
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_ir"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaIR : i += 1

            'Seta Parametros - Valor IR
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ir"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorIR : i += 1

            'Seta Parametros - Cálculo Imposto Manual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "calculo_imposto_manual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bCalculoImpostoManual : i += 1

            'Seta Parametros - Código Pedido de Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_compra"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoPedidoVenda = -1, DBNull.Value, lCodigoPedidoVenda) : i += 1

            'Seta Parametros - Código Pedido de Venda Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_compra_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoPedidoVendaItem = -1, DBNull.Value, iCodigoPedidoVendaItem) : i += 1

            'Seta Parametros - Código Pedido de Venda Item Entrega
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_compra_item_entrega"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoPedidoVendaItemEntrega = -1, DBNull.Value, iCodigoPedidoVendaItemEntrega) : i += 1

            'Seta Parametros - Quantidade Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(dQuantidadePedido = -1, DBNull.Value, dQuantidadePedido)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_entrada_nfs_servico", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteServico()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_nfs_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoNFsCapa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_entrada_nfs_servico", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosServico(ByVal lCodigo As Long, _
                                ByVal txtDiscriminacao As EditBox, _
                                ByVal txtAliquotaISS As NumericEditBox)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
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
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_emissao_nfse_dados_servico", oSqlParameter)

            If oSqlDataReader.Read Then
                txtDiscriminacao.Text = oSqlDataReader.Item("descricao")
                txtAliquotaISS.Value = oSqlDataReader.Item("aliquota_iss_padrao")
            Else
                txtDiscriminacao.Text = ""
                txtAliquotaISS.Value = 0
            End If

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosServicoPedidoCompra(ByVal lCodigoPedido As Long, _
                                            ByVal iCodigoPedidoItem As Integer, _
                                            ByVal iCodigoPedidoItemEntrega As Integer, _
                                            ByVal txtQuantidadePendente As NumericEditBox, _
                                            ByVal txtValorServico As NumericEditBox, _
                                            ByVal txtDescricao As EditBox, _
                                            ByVal txtValorDescontoIncondicionado As NumericEditBox, _
                                            ByVal cboCentroGasto As UIComboBox, _
                                            ByVal cboContaContabil As UIComboBox, _
                                            ByVal txtAliquotaISS As NumericEditBox, _
                                            ByVal cboISSRetido As UIComboBox, _
                                            ByVal txtAliquotaPIS As NumericEditBox, _
                                            ByVal txtAliquotaCOFINS As NumericEditBox, _
                                            ByVal txtAliquotaCSLL As NumericEditBox, _
                                            ByVal txtAliquotaINSS As NumericEditBox, _
                                            ByVal txtAliquotaIR As NumericEditBox, _
                                            ByVal cboFormaPagamento As UIComboBox, _
                                            ByVal lCodigoNFsCapa As Long, _
                                            ByVal txtNumeroParcela As NumericEditBox, _
                                            ByVal txtIntervaloEntreParcelas As NumericEditBox)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Pedido Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoPedidoItem : i += 1

            'Seta Parametros - Código Pedido Item Entrega
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item_entrega"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoPedidoItemEntrega : i += 1

            'Seta Parametros - Código NFS Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_nfs_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoNFsCapa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_entrada_servico_compras_dados", oSqlParameter)

            If oSqlDataReader.Read Then
                txtQuantidadePendente.Value = oSqlDataReader.Item("quantidade_pendente")
                txtValorServico.Value = oSqlDataReader.Item("valor_unitario")
                txtDescricao.Text = oSqlDataReader.Item("descricao")
                txtValorDescontoIncondicionado.Value = oSqlDataReader.Item("desconto_unitario_valor")
                cboCentroGasto.SelectedValue = oSqlDataReader.Item("codigo_centro_custo")
                cboContaContabil.SelectedValue = oSqlDataReader.Item("codigo_conta_contabil")
                txtAliquotaISS.Value = oSqlDataReader.Item("aliquota_iss")
                cboISSRetido.SelectedValue = oSqlDataReader.Item("iss_retido")
                txtAliquotaPIS.Value = oSqlDataReader.Item("aliquota_pis")
                txtAliquotaCOFINS.Value = oSqlDataReader.Item("aliquota_cofins")
                txtAliquotaCSLL.Value = oSqlDataReader.Item("aliquota_csll")
                txtAliquotaINSS.Value = oSqlDataReader.Item("aliquota_inss")
                txtAliquotaIR.Value = oSqlDataReader.Item("aliquota_ir")
                cboFormaPagamento.SelectedValue = oSqlDataReader.Item("codigo_forma_pagamento")
                txtNumeroParcela.Value = 1
                txtIntervaloEntreParcelas.Value = 0
            Else
                txtQuantidadePendente.Value = 0
                txtValorServico.Value = 0
                txtDescricao.Text = ""
                txtValorDescontoIncondicionado.Value = 0
                cboCentroGasto.SelectedIndex = -1
                cboContaContabil.SelectedIndex = -1
                txtAliquotaISS.Value = 0
                cboISSRetido.SelectedValue = False
                txtAliquotaPIS.Value = 0
                txtAliquotaCOFINS.Value = 0
                txtAliquotaCSLL.Value = 0
                txtAliquotaINSS.Value = 0
                txtAliquotaIR.Value = 0
                cboFormaPagamento.SelectedIndex = -1
                txtNumeroParcela.Value = 0
                txtIntervaloEntreParcelas.Value = 0
            End If

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridServico(ByVal oGrid As GridEX, _
                               ByVal lCodigoEntradaNFS As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Nota Fiscal
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_nfs_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaNFS : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_entrada_nfs_servico", oSqlParameter)

            'Configura DataMember
            ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteServicos()

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Pedido
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_nfs_capa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo_nfs_capa").Value : i += 1

                'Seta Parametros - Código Pedido Item
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_faturamento_entrada_nfs_servico", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub EditarServico(ByVal iCodigo As Integer, _
                             ByVal cboServico As UIComboBox, _
                             ByVal txtQuantidade As NumericEditBox, _
                             ByVal txtValorServicoUnitario As NumericEditBox, _
                             ByVal txtValorServico As NumericEditBox, _
                             ByVal txtValorDescontoCondicionado As NumericEditBox, _
                             ByVal txtValorDescontoIncondicionado As NumericEditBox, _
                             ByVal txtValorLiquidoNFSE As NumericEditBox, _
                             ByVal txtDescricao As EditBox, _
                             ByVal cboCentroGasto As UIComboBox, _
                             ByVal cboContaContabil As UIComboBox, _
                             ByVal txtOutrasRetencoes As NumericEditBox, _
                             ByVal txtValorDeducoes As NumericEditBox, _
                             ByVal txtBaseCalculo As NumericEditBox, _
                             ByVal txtAliquotaISS As NumericEditBox, _
                             ByVal cboISSRetido As UIComboBox, _
                             ByVal txtAliquotaPIS As NumericEditBox, _
                             ByVal txtAliquotaCOFINS As NumericEditBox, _
                             ByVal txtAliquotaINSS As NumericEditBox, _
                             ByVal txtAliquotaCSLL As NumericEditBox, _
                             ByVal txtAliquotaIR As NumericEditBox, _
                             ByVal txtValorISS As NumericEditBox, _
                             ByVal txtValorISSRetido As NumericEditBox, _
                             ByVal txtValorPIS As NumericEditBox, _
                             ByVal txtValorCOFINS As NumericEditBox, _
                             ByVal txtValorINSS As NumericEditBox, _
                             ByVal txtValorCSLL As NumericEditBox, _
                             ByVal txtValorIR As NumericEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_nfs_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoNFsCapa : i += 1

            'Seta Parametros - Código Pedido Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Smallint
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_faturamento_entrada_nfs_servico_dados", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    cboServico.SelectedValue = oSqlDataReader.Item("codigo_item")
                    txtQuantidade.Value = oSqlDataReader.Item("quantidade")
                    txtValorServicoUnitario.Value = oSqlDataReader.Item("valor_servico")
                    txtValorServico.Value = oSqlDataReader.Item("valor_servico")
                    txtValorDescontoCondicionado.Value = oSqlDataReader.Item("desconto_condicional")
                    txtValorDescontoIncondicionado.Value = oSqlDataReader.Item("desconto_incondicional")
                    txtValorLiquidoNFSE.Value = oSqlDataReader.Item("valor_liquido")
                    txtDescricao.Text = oSqlDataReader.Item("descricao")
                    cboCentroGasto.SelectedValue = oSqlDataReader.Item("codigo_centro_custo")
                    cboContaContabil.SelectedValue = oSqlDataReader.Item("codigo_conta_contabil")
                    txtOutrasRetencoes.Value = oSqlDataReader.Item("outras_retencoes")
                    txtValorDeducoes.Value = oSqlDataReader.Item("valor_deducoes")
                    txtBaseCalculo.Value = oSqlDataReader.Item("base_calculo")
                    txtAliquotaISS.Value = oSqlDataReader.Item("aliquota_iss")
                    cboISSRetido.SelectedValue = oSqlDataReader.Item("iss_retido")

                    If cboISSRetido.SelectedValue = True Then
                        txtValorISSRetido.Value = oSqlDataReader.Item("valor_iss_retido")
                    Else
                        txtValorISS.Value = oSqlDataReader.Item("valor_iss_retido")
                    End If

                    txtAliquotaPIS.Value = oSqlDataReader.Item("aliquota_pis")
                    txtAliquotaCOFINS.Value = oSqlDataReader.Item("aliquota_cofins")
                    txtAliquotaINSS.Value = oSqlDataReader.Item("aliquota_inss")
                    txtAliquotaCSLL.Value = oSqlDataReader.Item("aliquota_csll")
                    txtAliquotaIR.Value = oSqlDataReader.Item("aliquota_ir")
                    txtValorPIS.Value = oSqlDataReader.Item("valor_pis")
                    txtValorCOFINS.Value = oSqlDataReader.Item("valor_cofins")
                    txtValorINSS.Value = oSqlDataReader.Item("valor_inss")
                    txtValorCSLL.Value = oSqlDataReader.Item("valor_csll")
                    txtValorIR.Value = oSqlDataReader.Item("valor_ir")

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

#End Region

#Region "::: DADOS DESPESA :::"
    Public Sub UpdateDadosDespesa(ByVal lCodigoTituloCapa As Long, _
                                  ByVal iCodigoTipoDocumentoPagamento As Integer, _
                                  ByVal sDescritivo As String)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo Titulo Capa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_titulo_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoTituloCapa : i += 1

            'Seta Parametros - Codigo Tipo Documento Pagamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_documento_pagamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoTipoDocumentoPagamento = -1, DBNull.Value, iCodigoTipoDocumentoPagamento) : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Descritivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descritivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDescritivo : i += 1



            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_faturamento_entrada_dados_despesa", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
#End Region

#End Region

End Class
