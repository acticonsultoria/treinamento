Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.CalendarCombo

Public Class clsUsrVenPedido

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sNumeroPedido As String
    Private sDataPedido As String
    Private sRevisaoTabelaPreco As String
    Private iCodigoCliente As Integer
    Private iCodigoParceiroNegocioContato As Integer
    Private sRequerente As String
    Private sNumeroPedidoCliente As String
    Private iCodigoModalidadeFrete As Integer
    Private iCodigoIncoterms As Integer
    Private iCodigoCampanha As Integer
    Private iCodigoEnderecoEntrega As Integer
    Private iCodigoTransportadora As Integer
    Private sTermoGarantia As String
    Private sCondicaoFornecimento As String
    Private sObservacao As String
    Private sReferencia As String
    Private iCodigoCondicaoPagamento As Integer
    Private iCodigoFormaPagamento As Integer
    Private iCodigoMoeda As Integer
    Private dFatorCambial As Double
    Private dValorTotal As Double
    Private dValorDesconto As Double
    Private dDescontoGeral As Double
    Private dAcrescimoGeral As Double
    Private dValorFrete As Double
    Private dValorFinal As Double
    Private dRO As Double
    Private iCodigoUsuario As Integer
    Private sLiberacao As String
    Private lCodigoPedido As Long
    Private sComprador As String
    'Dados da Cirurgia
    Private sDataCirurgia As String
    Private sHoraCirurgia As String
    Private iCodigoProcedimento As Integer = -1
    Private sPaciente As String
    Private iCodigoHospital As Integer = -1
    Private sMedico As String
    Private iCodigoConvenio As Integer = -1
    Private sNumeroMatricula As String
    Private sInstrumentador As String
    Private sObservacaoCirurgia As String
    Private sDescricao As String

#End Region

#Region "::: PROPERTIE :::"

    Public Property Descricao() As String
        Get
            Return sDescricao
        End Get
        Set(ByVal value As String)
            sDescricao = value
        End Set
    End Property

    Public Property Comprador() As String
        Get
            Return sComprador
        End Get
        Set(ByVal value As String)
            sComprador = value
        End Set
    End Property

    Public Property NumeroPedido() As String
        Get
            Return sNumeroPedido
        End Get
        Set(ByVal value As String)
            sNumeroPedido = value
        End Set
    End Property

    Public Property DataPedido() As String
        Get
            Return sDataPedido
        End Get
        Set(ByVal value As String)
            sDataPedido = value
        End Set
    End Property

    Public Property RevisaoTabelaPreco() As String
        Get
            Return sRevisaoTabelaPreco
        End Get
        Set(ByVal value As String)
            sRevisaoTabelaPreco = value
        End Set
    End Property

    Public Property CodigoCliente() As Integer
        Get
            Return iCodigoCliente
        End Get
        Set(ByVal value As Integer)
            iCodigoCliente = value
        End Set
    End Property

    Public Property CodigoParceiroNegocioContato() As Integer
        Get
            Return iCodigoParceiroNegocioContato
        End Get
        Set(ByVal value As Integer)
            iCodigoParceiroNegocioContato = value
        End Set
    End Property

    Public Property Requerente() As String
        Get
            Return sRequerente
        End Get
        Set(ByVal value As String)
            sRequerente = value
        End Set
    End Property

    Public Property NumeroPedidoCliente() As String
        Get
            Return sNumeroPedidoCliente
        End Get
        Set(ByVal value As String)
            sNumeroPedidoCliente = value
        End Set
    End Property

    Public Property CodigoModalidadeFrete() As Integer
        Get
            Return iCodigoModalidadeFrete
        End Get
        Set(ByVal value As Integer)
            iCodigoModalidadeFrete = value
        End Set
    End Property

    Public Property CodigoIncoterms() As Integer
        Get
            Return iCodigoIncoterms
        End Get
        Set(ByVal value As Integer)
            iCodigoIncoterms = value
        End Set
    End Property

    Public Property CodigoCampanha() As Integer
        Get
            Return iCodigoCampanha
        End Get
        Set(ByVal value As Integer)
            iCodigoCampanha = value
        End Set
    End Property

    Public Property CodigoEnderecoEntrega() As Integer
        Get
            Return iCodigoEnderecoEntrega
        End Get
        Set(ByVal value As Integer)
            iCodigoEnderecoEntrega = value
        End Set
    End Property

    Public Property CodigoTransportadora() As Integer
        Get
            Return iCodigoTransportadora
        End Get
        Set(ByVal value As Integer)
            iCodigoTransportadora = value
        End Set
    End Property

    Public Property TermoGarantia() As String
        Get
            Return sTermoGarantia
        End Get
        Set(ByVal value As String)
            sTermoGarantia = value
        End Set
    End Property

    Public Property CondicaoFornecimento() As String
        Get
            Return sCondicaoFornecimento
        End Get
        Set(ByVal value As String)
            sCondicaoFornecimento = value
        End Set
    End Property

    Public Property Observacao() As String
        Get
            Return sObservacao
        End Get
        Set(ByVal value As String)
            sObservacao = value
        End Set
    End Property

    Public Property Referencia() As String
        Get
            Return sReferencia
        End Get
        Set(ByVal value As String)
            sReferencia = value
        End Set
    End Property

    Public Property CodigoCondicaoPagamento() As Integer
        Get
            Return iCodigoCondicaoPagamento
        End Get
        Set(ByVal value As Integer)
            iCodigoCondicaoPagamento = value
        End Set
    End Property

    Public Property CodigoFormaPagamento() As Integer
        Get
            Return iCodigoFormaPagamento
        End Get
        Set(ByVal value As Integer)
            iCodigoFormaPagamento = value
        End Set
    End Property

    Public Property CodigoMoeda() As Integer
        Get
            Return iCodigoMoeda
        End Get
        Set(ByVal value As Integer)
            iCodigoMoeda = value
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

    Public Property ValorTotal() As Double
        Get
            Return dValorTotal
        End Get
        Set(ByVal value As Double)
            dValorTotal = value
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

    Public Property ValorFrete() As Double
        Get
            Return dValorFrete
        End Get
        Set(ByVal value As Double)
            dValorFrete = value
        End Set
    End Property

    Public Property DescontoGeral() As Double
        Get
            Return dDescontoGeral
        End Get
        Set(ByVal value As Double)
            dDescontoGeral = value
        End Set
    End Property

    Public Property AcrescimoGeral() As Double
        Get
            Return dAcrescimoGeral
        End Get
        Set(ByVal value As Double)
            dAcrescimoGeral = value
        End Set
    End Property

    Public Property ValorFinal() As Double
        Get
            Return dValorFinal
        End Get
        Set(ByVal value As Double)
            dValorFinal = value
        End Set
    End Property

    Public Property RO() As Double
        Get
            Return dRO
        End Get
        Set(ByVal value As Double)
            dRO = value
        End Set
    End Property

    Public Property CodigoUsuario() As String
        Get
            Return iCodigoUsuario
        End Get
        Set(ByVal value As String)
            iCodigoUsuario = value
        End Set
    End Property

    Public Property Liberacao() As String
        Get
            Return sLiberacao
        End Get
        Set(ByVal value As String)
            sLiberacao = value
        End Set
    End Property

    Public Property CodigoPedido() As Long
        Get
            Return lCodigoPedido
        End Get
        Set(ByVal value As Long)
            lCodigoPedido = value
        End Set
    End Property

    Public Property DataCirurgia() As String
        Get
            Return sDataCirurgia
        End Get
        Set(ByVal value As String)
            sDataCirurgia = value
        End Set
    End Property

    Public Property HoraCirurgia() As String
        Get
            Return sHoraCirurgia
        End Get
        Set(ByVal value As String)
            sHoraCirurgia = value
        End Set
    End Property

    Public Property CodigoProcedimento() As Integer
        Get
            Return iCodigoProcedimento
        End Get
        Set(ByVal value As Integer)
            iCodigoProcedimento = value
        End Set
    End Property

    Public Property Paciente() As String
        Get
            Return sPaciente
        End Get
        Set(ByVal value As String)
            sPaciente = value
        End Set
    End Property

    Public Property CodigoHospital() As Integer
        Get
            Return iCodigoHospital
        End Get
        Set(ByVal value As Integer)
            iCodigoHospital = value
        End Set
    End Property

    Public Property Medico() As String
        Get
            Return sMedico
        End Get
        Set(ByVal value As String)
            sMedico = value
        End Set
    End Property

    Public Property CodigoConvenio() As Integer
        Get
            Return iCodigoConvenio
        End Get
        Set(ByVal value As Integer)
            iCodigoConvenio = value
        End Set
    End Property

    Public Property NumeroMatricula() As String
        Get
            Return sNumeroMatricula
        End Get
        Set(ByVal value As String)
            sNumeroMatricula = value
        End Set
    End Property

    Public Property Instrumentador() As String
        Get
            Return sInstrumentador
        End Get
        Set(ByVal value As String)
            sInstrumentador = value
        End Set
    End Property

    Public Property ObservacaoCirurgia() As String
        Get
            Return sObservacaoCirurgia
        End Get
        Set(ByVal value As String)
            sObservacaoCirurgia = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: PEDIDO VENDA :::"

    Public Sub AtualizarStatusPedido(ByVal lCodigo As Long)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
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
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_status_venda", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Cancelar(ByVal iCodigoJustificativaCancelamento As Integer, _
                        ByVal sHistorico As String)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Pedido
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_pedido"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo_pedido").Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Código Justificativa de Cancelamento
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_justificativa_cancelamento"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = IIf(iCodigoJustificativaCancelamento = -1, DBNull.Value, iCodigoJustificativaCancelamento) : i += 1

                'Seta Parametros - Histórico
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "historico"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 5000
                oSqlParameter(i).Value = sHistorico : i += 1

                'Seta Parametros - Codigo Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_usuario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

                'Seta Parametros - Status
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "status"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = StatusVendaPedidoItem.Cancelado

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_venda_pedido_status", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Delete()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
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
                oSqlParameter(i).Value = oRow.Cells("codigo_pedido").Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_venda_pedido", oSqlParameter)

                'Deleta Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Insert()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

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
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_venda_pedido", oSqlParameter)

            'Seta Váriaveis
            lCodigoPedido = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Duplicar(ByVal lCodigo As Long)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Orçamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

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
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_venda_pedido_duplicar", oSqlParameter)

            'Seta Código
            lCodigoPedido = oSqlParameter(3).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertRevisao(ByVal lCodigo As Long)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Orçamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

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
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_venda_pedido_revisao", oSqlParameter)

            'Seta Código
            lCodigoPedido = oSqlParameter(3).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update()

        'Variaveis Locais
        Dim oSqlParameter(41) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Data
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataPedido : i += 1
            
            'Seta Parametros - Revisão Tabela de Preço
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "revisao_tabela_preco"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sRevisaoTabelaPreco = "", DBNull.Value, sRevisaoTabelaPreco) : i += 1

            'Seta Parametros - Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoCliente : i += 1

            'Seta Parametros - Requerente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "requerente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = DBNull.Value : i += 1

            'Seta Parametros - Número Pedido Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_pedido_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = IIf(sNumeroPedidoCliente = "", DBNull.Value, sNumeroPedidoCliente) : i += 1

            'Seta Parametros - Código Modalidade de Frete
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modalidade_frete"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoModalidadeFrete = -1, DBNull.Value, iCodigoModalidadeFrete) : i += 1

            'Seta Parametros - Código Incoterms
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_incoterms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoIncoterms = -1, DBNull.Value, iCodigoIncoterms) : i += 1

            'Seta Parametros - Código Campanha
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_campanha"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoCampanha = -1, DBNull.Value, iCodigoCampanha) : i += 1

            'Seta Parametros - Código Parceiro Negócio - Endereço (Entrega)
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_endereco_entrega"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoEnderecoEntrega = -1, DBNull.Value, iCodigoEnderecoEntrega) : i += 1

            'Seta Parametros - Código da Transportadora
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_transportadora"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoTransportadora = -1, DBNull.Value, iCodigoTransportadora) : i += 1

            'Seta Parametros - Termo Garantia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "termo_garantia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5000
            oSqlParameter(i).Value = IIf(sTermoGarantia = "", DBNull.Value, sTermoGarantia) : i += 1

            'Seta Parametros - Condição de Fornecimento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "condicao_fornecimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5000
            oSqlParameter(i).Value = IIf(sCondicaoFornecimento = "", DBNull.Value, sCondicaoFornecimento) : i += 1

            'Seta Parametros - Observação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5000
            oSqlParameter(i).Value = IIf(sObservacao = "", DBNull.Value, sObservacao) : i += 1

            'Seta Parametros - Referência
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "referencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5000
            oSqlParameter(i).Value = IIf(sReferencia = "", DBNull.Value, sReferencia) : i += 1

            'Seta Parametros - Código da Condição de Pagamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_condicao_pagamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoCondicaoPagamento = -1, DBNull.Value, iCodigoCondicaoPagamento) : i += 1

            'Seta Parametros - Código Forma de Pagamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_forma_pagamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoFormaPagamento = -1, DBNull.Value, iCodigoFormaPagamento) : i += 1

            'Seta Parametros - Código da Moeda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_moeda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoMoeda = -1, DBNull.Value, iCodigoMoeda) : i += 1

            'Seta Parametros - Fator Cambial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fator_cambial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dFatorCambial : i += 1

            'Seta Parametros - Valor Total
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_total"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorTotal : i += 1

            'Seta Parametros - Valor Desconto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_desconto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorDesconto : i += 1

            'Seta Parametros - Desconto Geral
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desconto_geral"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDescontoGeral : i += 1

            'Seta Parametros - Acréscimo Geral
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "acrescimo_geral"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAcrescimoGeral : i += 1

            'Seta Parametros - Valor Frete
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_frete"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorFrete : i += 1

            'Seta Parametros - Valor Final
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_final"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorFinal : i += 1

            'Seta Parametros - RO
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dRO : i += 1

            'Seta Parametros - Codigo do Cliente - Contato
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "comprador"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sComprador : i += 1

            'Seta Parametros - Data Cirurgia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_cirurgia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataCirurgia), sDataCirurgia, DBNull.Value) : i += 1

            'Seta Parametros - Hora Cirurgia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "hora_cirurgia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(IsDate(sHoraCirurgia), sHoraCirurgia, DBNull.Value) : i += 1

            'Seta Parametros - Código Procedimento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_procedimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoProcedimento = -1, DBNull.Value, iCodigoProcedimento) : i += 1

            'Seta Parametros - Paciente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "paciente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = IIf(sPaciente = "", DBNull.Value, sPaciente) : i += 1

            'Seta Parametros - Código Hospital
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_hospital"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoHospital = -1, DBNull.Value, iCodigoHospital) : i += 1

            'Seta Parametros - Médico
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "medico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = IIf(sMedico = "", DBNull.Value, sMedico) : i += 1

            'Seta Parametros - Código Convênio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_convenio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoConvenio = -1, DBNull.Value, iCodigoConvenio) : i += 1

            'Seta Parametros - Nº Matricula
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_matricula"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 25
            oSqlParameter(i).Value = IIf(sNumeroMatricula = "", DBNull.Value, sNumeroMatricula) : i += 1

            'Seta Parametros - Instrumentador
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "instrumentador"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = IIf(sInstrumentador = "", DBNull.Value, sInstrumentador) : i += 1

            'Seta Parametros - Observação - Cirurgia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao_cirurgia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5000
            oSqlParameter(i).Value = IIf(sObservacaoCirurgia = "", DBNull.Value, sObservacaoCirurgia) : i += 1

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
            oSqlParameter(i).Value = iCodigoUsuario : i += 1

            'Seta Parametros - Liberação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "liberacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sLiberacao = "", DBNull.Value, sLiberacao) : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            'Seta Parametros - Nº Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_venda_pedido", oSqlParameter)

            'Seta Váriavel
            sNumeroPedido = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadControlesPedido(ByVal lCodigo As Long, _
                                   ByVal txtNumeroPedido As MaskedEditBox, _
                                   ByVal dtpDataPedido As CalendarCombo, _
                                   ByVal txtRevisao As MaskedEditBox, _
                                   ByVal cboCliente As UIComboBox, _
                                   ByVal txtNumeroPedidoCliente As MaskedEditBox, _
                                   ByVal cboModalidadeFrete As UIComboBox, _
                                   ByVal cboIncoterms As UIComboBox, _
                                   ByVal cboCampanha As UIComboBox, _
                                   ByVal cboEnderecoEntrega As UIComboBox, _
                                   ByVal cboTransportadora As UIComboBox, _
                                   ByVal txtTermoGarantia As EditBox, _
                                   ByVal txtCondicaoFornecimento As EditBox, _
                                   ByVal txtObservacao As EditBox, _
                                   ByVal txtReferencia As EditBox, _
                                   ByVal cboCondicaoPagamento As UIComboBox, _
                                   ByVal cboFormaPagamento As UIComboBox, _
                                   ByVal cboMoeda As UIComboBox, _
                                   ByVal txtFatorCambial As NumericEditBox, _
                                   ByVal txtValorTotalPedido As NumericEditBox, _
                                   ByVal txtValorDescontoPedido As NumericEditBox, _
                                   ByVal txtTotalImpostoProduto As NumericEditBox, _
                                   ByVal txtTotalImpostoServico As NumericEditBox, _
                                   ByVal txtDescontoGeral As NumericEditBox, _
                                   ByVal txtAcrescimoGeral As NumericEditBox, _
                                   ByVal txtValorFrete As NumericEditBox, _
                                   ByVal txtValorFinalPedido As NumericEditBox, _
                                   ByVal txtComprador As MaskedEditBox, _
                                   ByRef iStatusFinanceiro As Integer)

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

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_pedido_dados", oSqlParameter)

            'Verifica se encontrou algum Registro
            'If oSqlDataReader.HasRows Then

            'Seta Controles
            While oSqlDataReader.Read

                txtNumeroPedido.Text = oSqlDataReader.Item("numero_pedido")
                txtNumeroPedido.Tag = oSqlDataReader.Item("numero_pedido2")
                dtpDataPedido.Value = oSqlDataReader.Item("data_pedido")
                txtRevisao.Text = oSqlDataReader.Item("revisao")
                cboCliente.SelectedValue = oSqlDataReader.Item("codigo_cliente")
                txtComprador.Text = oSqlDataReader.Item("comprador")
                txtNumeroPedidoCliente.Text = oSqlDataReader.Item("numero_pedido_cliente")
                cboModalidadeFrete.SelectedValue = oSqlDataReader.Item("codigo_modalidade_frete")
                cboIncoterms.SelectedValue = oSqlDataReader.Item("codigo_incoterms")
                cboCampanha.SelectedValue = oSqlDataReader.Item("codigo_campanha")
                cboEnderecoEntrega.SelectedValue = oSqlDataReader.Item("codigo_endereco_entrega")
                cboTransportadora.SelectedValue = oSqlDataReader.Item("codigo_transportadora")
                txtTermoGarantia.Text = oSqlDataReader.Item("termo_garantia")
                txtCondicaoFornecimento.Text = oSqlDataReader.Item("condicao_fornecimento")
                txtObservacao.Text = oSqlDataReader.Item("observacao")
                txtReferencia.Text = oSqlDataReader.Item("referencia")
                cboCondicaoPagamento.SelectedValue = oSqlDataReader.Item("codigo_condicao_pagamento")
                cboFormaPagamento.SelectedValue = oSqlDataReader.Item("codigo_forma_pagamento")
                cboMoeda.SelectedValue = oSqlDataReader.Item("codigo_moeda")
                txtFatorCambial.Value = oSqlDataReader.Item("fator_cambial")
                txtValorTotalPedido.Value = oSqlDataReader.Item("valor_total")
                txtValorDescontoPedido.Value = oSqlDataReader.Item("valor_desconto")
                txtTotalImpostoProduto.Value = oSqlDataReader.Item("total_imposto_produto")
                txtTotalImpostoServico.Value = oSqlDataReader.Item("total_imposto_servico")
                txtDescontoGeral.Value = oSqlDataReader.Item("desconto_geral")
                txtAcrescimoGeral.Value = oSqlDataReader.Item("acrescimo_geral")
                txtValorFrete.Value = oSqlDataReader.Item("valor_frete")
                txtValorFinalPedido.Value = oSqlDataReader.Item("valor_final")
                txtComprador.Text = oSqlDataReader.Item("comprador")
                iStatusFinanceiro = oSqlDataReader.Item("status_financeiro")

            End While

            ' End If

            'Fecha o DataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadControlesPedido(ByVal lCodigo As Long, _
                                   ByVal txtNumeroPedido As MaskedEditBox, _
                                   ByVal cboRevisaoTabelaPreco As UIComboBox, _
                                   ByVal dtpDataPedido As CalendarCombo, _
                                   ByVal txtRevisao As MaskedEditBox, _
                                   ByVal cboCliente As UIComboBox, _
                                   ByVal txtNumeroPedidoCliente As MaskedEditBox, _
                                   ByVal cboModalidadeFrete As UIComboBox, _
                                   ByVal cboIncoterms As UIComboBox, _
                                   ByVal cboCampanha As UIComboBox, _
                                   ByVal cboEnderecoEntrega As UIComboBox, _
                                   ByVal cboTransportadora As UIComboBox, _
                                   ByVal txtTermoGarantia As EditBox, _
                                   ByVal txtCondicaoFornecimento As EditBox, _
                                   ByVal txtObservacao As EditBox, _
                                   ByVal txtReferencia As EditBox, _
                                   ByVal cboCondicaoPagamento As UIComboBox, _
                                   ByVal cboFormaPagamento As UIComboBox, _
                                   ByVal cboMoeda As UIComboBox, _
                                   ByVal txtFatorCambial As NumericEditBox, _
                                   ByVal txtValorTotalPedido As NumericEditBox, _
                                   ByVal txtValorDescontoPedido As NumericEditBox, _
                                   ByVal txtTotalImpostoProduto As NumericEditBox, _
                                   ByVal txtTotalImpostoServico As NumericEditBox, _
                                   ByVal txtDescontoGeral As NumericEditBox, _
                                   ByVal txtAcrescimoGeral As NumericEditBox, _
                                   ByVal txtValorFrete As NumericEditBox, _
                                   ByVal txtValorFinalPedido As NumericEditBox, _
                                   ByRef iStatusFinanceiro As Integer, _
                                   ByVal dtpDataCirurgia As CalendarCombo, _
                                   ByVal txtHoraCirurgia As MaskedEditBox, _
                                   ByVal cboProcedimento As UIComboBox, _
                                   ByVal txtPaciente As MaskedEditBox, _
                                   ByVal cboHospital As UIComboBox, _
                                   ByVal txtMedico As MaskedEditBox, _
                                   ByVal cboConvenio As UIComboBox, _
                                   ByVal txtNumeroMatricula As MaskedEditBox, _
                                   ByVal txtInstrumentador As MaskedEditBox, _
                                   ByVal txtObservacaoCirurgia As EditBox, _
                                   ByVal txtComprador As MaskedEditBox)

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

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_pedido_dados", oSqlParameter)

            'Verifica se encontrou algum Registro
            If oSqlDataReader.HasRows Then

                'Seta Controles
                While oSqlDataReader.Read

                    txtNumeroPedido.Text = oSqlDataReader.Item("numero_pedido")
                    txtNumeroPedido.Tag = oSqlDataReader.Item("numero_pedido2")
                    If IsDBNull(oSqlDataReader.Item("revisao_tabela_preco")) = False Then cboRevisaoTabelaPreco.SelectedValue = oSqlDataReader.Item("revisao_tabela_preco")
                    dtpDataPedido.Value = oSqlDataReader.Item("data_pedido")
                    txtRevisao.Text = oSqlDataReader.Item("revisao")
                    cboCliente.SelectedValue = oSqlDataReader.Item("codigo_cliente")
                    txtComprador.Text = oSqlDataReader.Item("comprador")
                    txtNumeroPedidoCliente.Text = oSqlDataReader.Item("numero_pedido_cliente")
                    cboModalidadeFrete.SelectedValue = oSqlDataReader.Item("codigo_modalidade_frete")
                    cboIncoterms.SelectedValue = oSqlDataReader.Item("codigo_incoterms")
                    cboCampanha.SelectedValue = oSqlDataReader.Item("codigo_campanha")
                    cboEnderecoEntrega.SelectedValue = oSqlDataReader.Item("codigo_endereco_entrega")
                    cboTransportadora.SelectedValue = oSqlDataReader.Item("codigo_transportadora")
                    txtTermoGarantia.Text = oSqlDataReader.Item("termo_garantia")
                    txtCondicaoFornecimento.Text = oSqlDataReader.Item("condicao_fornecimento")
                    txtObservacao.Text = oSqlDataReader.Item("observacao")
                    txtReferencia.Text = oSqlDataReader.Item("referencia")
                    cboCondicaoPagamento.SelectedValue = oSqlDataReader.Item("codigo_condicao_pagamento")
                    cboFormaPagamento.SelectedValue = oSqlDataReader.Item("codigo_forma_pagamento")
                    cboMoeda.SelectedValue = oSqlDataReader.Item("codigo_moeda")
                    txtFatorCambial.Value = oSqlDataReader.Item("fator_cambial")
                    txtValorTotalPedido.Value = oSqlDataReader.Item("valor_total")
                    txtValorDescontoPedido.Value = oSqlDataReader.Item("valor_desconto")
                    txtTotalImpostoProduto.Value = oSqlDataReader.Item("total_imposto_produto")
                    txtTotalImpostoServico.Value = oSqlDataReader.Item("total_imposto_servico")
                    txtDescontoGeral.Value = oSqlDataReader.Item("desconto_geral")
                    txtAcrescimoGeral.Value = oSqlDataReader.Item("acrescimo_geral")
                    txtValorFrete.Value = oSqlDataReader.Item("valor_frete")
                    txtValorFinalPedido.Value = oSqlDataReader.Item("valor_final")
                    iStatusFinanceiro = oSqlDataReader.Item("status_financeiro")
                    dtpDataCirurgia.Value = oSqlDataReader.Item("data_cirurgia")
                    txtHoraCirurgia.Text = oSqlDataReader.Item("hora_cirurgia")
                    cboProcedimento.SelectedValue = oSqlDataReader.Item("codigo_procedimento")
                    txtPaciente.Text = oSqlDataReader.Item("paciente")
                    cboHospital.SelectedValue = oSqlDataReader.Item("codigo_hospital")
                    txtMedico.Text = oSqlDataReader.Item("medico")
                    cboConvenio.SelectedValue = oSqlDataReader.Item("codigo_convenio")
                    txtNumeroMatricula.Text = oSqlDataReader.Item("numero_matricula")
                    txtInstrumentador.Text = oSqlDataReader.Item("instrumentador")
                    txtObservacaoCirurgia.Text = oSqlDataReader.Item("observacao_cirurgia")

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

    Public Sub LoadGridPedido(ByVal oGrid As GridEX, _
                              ByVal lNumeroPedido As Long, _
                              ByVal sDataInicio As String, _
                              ByVal sDataTermino As String, _
                              ByVal iRevisao As Integer, _
                              ByVal iCodigoCliente As Integer, _
                              ByVal iCodigoFormaFaturamento As Integer, _
                              ByVal sCodigoVendedor As String, _
                              ByVal sNumeroPedidoCliente As String, _
                              ByVal sStatus As String, _
                              ByVal iCodigoDestinacao As Integer, _
                              ByVal iCodigoCampanha As Integer, _
                              ByVal iCodigoTipoItem As Integer, _
                              ByVal iCodigoGrupoItem As Integer, _
                              ByVal iCodigoTransportadora As Integer, _
                              ByVal lCodigoItem As Long, _
                              ByVal sReferencia As String, _
                              Optional ByVal sTipoFiltroCirurgia As String = "", _
                              Optional ByVal sFiltroCirurgia As String = "", _
                              Optional ByVal lFiltroCirurgia As Long = -1)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(20) As SqlParameter
        Dim i As Integer = 0

        Try

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

            'Seta Parametros - Número Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lNumeroPedido : i += 1

            'Seta Parametros - Data Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataInicio = "", DBNull.Value, sDataInicio) : i += 1

            'Seta Parametros - Data Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataTermino = "", DBNull.Value, sDataTermino) : i += 1

            'Seta Parametros - Revisão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "revisao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iRevisao : i += 1

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCliente : i += 1

            'Seta Parametros - Código Forma Faturamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_forma_faturamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoFormaFaturamento : i += 1

            'Seta Parametros - Código Vendedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_vendedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCodigoVendedor : i += 1

            'Seta Parametros - Número Pedido Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_pedido_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNumeroPedidoCliente : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sStatus : i += 1

            'Seta Parametros - Código Destinação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_destinacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoDestinacao : i += 1

            'Seta Parametros - Código Campanha
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_campanha"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCampanha : i += 1

            'Seta Parametros - Código Tipo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoItem : i += 1

            'Seta Parametros - Código Grupo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_grupo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoGrupoItem : i += 1

            'Seta Parametros - Código Transportadora
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_transportadora"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoTransportadora : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Tipo de Filtro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo_filtro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sTipoFiltroCirurgia : i += 1

            'Seta Parametros - Filtro - Cirurgia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "filtro_cirurgia_texto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sFiltroCirurgia : i += 1

            'Seta Parametros - Filtro - Cirurgia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "filtro_cirurgia_numero"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lFiltroCirurgia : i += 1

            'Seta Parametros - Referência
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "referencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sReferencia

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_pedido", oSqlParameter)

            Call ConfigurarDataMemberGrid(oGrid)

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oDataSet.Tables(0).Columns("codigo_pedido"), oDataSet.Tables(1).Columns("codigo_pedido"))

            Dim oParentColumn(1) As DataColumn
            Dim oChildColumn(1) As DataColumn

            oParentColumn(0) = oDataSet.Tables(1).Columns("codigo_pedido")
            oParentColumn(1) = oDataSet.Tables(1).Columns("codigo_pedido_item")
            oChildColumn(0) = oDataSet.Tables(2).Columns("codigo_pedido")
            oChildColumn(1) = oDataSet.Tables(2).Columns("codigo_pedido_item")

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(2).TableName, oParentColumn, oChildColumn)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName
            oGrid.RootTable.ChildTables(0).ChildTables(0).DataMember = oDataSet.Tables(2).TableName

            'Call ConfigurarDataMemberGrid(oGrid)

            ''Adiciona Relacionamento
            'oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oDataSet.Tables(0).Columns("codigo_pedido"), oDataSet.Tables(1).Columns("codigo_pedido"))

            'Dim oParentColumn(1) As DataColumn
            'Dim oChildColumn(1) As DataColumn
            'Dim oChildColumn2(1) As DataColumn

            'oParentColumn(0) = oDataSet.Tables(1).Columns("codigo_pedido")
            'oParentColumn(1) = oDataSet.Tables(1).Columns("codigo_pedido_item")
            'oChildColumn(0) = oDataSet.Tables(2).Columns("codigo_pedido")
            'oChildColumn(1) = oDataSet.Tables(2).Columns("codigo_pedido_item")
            'oChildColumn2(0) = oDataSet.Tables(3).Columns("codigo_pedido")
            'oChildColumn2(1) = oDataSet.Tables(3).Columns("codigo_pedido_item")


            ''Adiciona Relacionamento
            'oDataSet.Relations.Add(oDataSet.Tables(2).TableName, oParentColumn, oChildColumn)
            'oDataSet.Relations.Add(oDataSet.Tables(3).TableName, oParentColumn, oChildColumn2)

            ''Carrega Grid
            'oGrid.DataSource = oDataSet.DefaultViewManager
            'oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            'oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName
            'oGrid.RootTable.ChildTables(0).ChildTables(0).DataMember = oDataSet.Tables(2).TableName
            'oGrid.RootTable.ChildTables(0).ChildTables(1).DataMember = oDataSet.Tables(3).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridFind(ByVal oGrid As GridEX)


        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa 

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_pedido_find", oSqlParameter)

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oDataSet.Tables(0).Columns("codigo_pedido"), oDataSet.Tables(1).Columns("codigo_pedido"))

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


    Public Function ValidaCliente(ByVal lCodigoCliente As Long) As String

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0
        Dim sReturn As String = ""

        Try

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCliente : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_pedido_dados_cliente", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    sReturn = sReturn & "N° Documento: " & oSqlDataReader.Item("numero_documento")
                    sReturn = sReturn & "     - Data Vencimento: " & oSqlDataReader.Item("data_vencimento") & vbCrLf
                    sReturn = sReturn & "     - Dias de Atraso: " & FormatNumber(oSqlDataReader.Item("atraso"), 0, Microsoft.VisualBasic.TriState.False) & vbCrLf
                    sReturn = sReturn & "     - Valor: R$" & FormatNumber(oSqlDataReader.Item("valor"), 2, Microsoft.VisualBasic.TriState.True) & vbCrLf
                    sReturn = sReturn & "     - Valor Corrigido: R$" & FormatNumber(oSqlDataReader.Item("valor_corrigido"), 2, Microsoft.VisualBasic.TriState.True) & vbCrLf & vbCrLf

                End While

            End If

            'Fecha o DataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Return sReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ValidaVenda(ByVal iCodigoParceiroNegocio As Integer, _
                                ByVal sData As String, _
                                ByVal dValorPedido As Long, _
                                ByRef sMensagem As String, _
                                ByRef sLiberacao As String) As Boolean

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0
        Dim bReturn As Boolean = False

        Try

            'Seta Parametros - Código Parceiro Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoParceiroNegocio : i += 1

            'Seta Parametros - Data
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sData : i += 1

            'Seta Parametros - Valor Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorPedido : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_venda_pedido", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    sMensagem = oSqlDataReader.Item("mensagem")
                    sLiberacao = oSqlDataReader.Item("liberacao")
                    bReturn = False

                End While

            Else
                bReturn = True
            End If

            'Fecha o DataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

            Return bReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub LoadGridHistorico(ByVal oGrid As GridEX, _
                                 ByVal lCodigoPedido As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            'Seta Parametros - Código de Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_pedido_historico", oSqlParameter)

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

    Public Sub LoadDadosHistorico(ByVal lCodigoPedido As Long, _
                                  ByVal txtNumeroPedido As MaskedEditBox, _
                                  ByVal txtDataPedido As MaskedEditBox, _
                                  ByVal txtCliente As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            'Seta Parametros - Código de Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_pedido_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                txtNumeroPedido.Text = oSqlDataReader.Item("numero_pedido")
                txtDataPedido.Text = oSqlDataReader.Item("data_pedido")
                txtCliente.Text = oSqlDataReader.Item("cliente")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertHistorico(ByVal lCodigoPedido As Long, _
                               ByVal sHistorico As String)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Pedio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            'Seta Parametros - Histórico
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "historico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sHistorico : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código de Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_venda_pedido_historico", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: PEDIDO VENDA - EXCEL :::"

    Public Sub InsertProdutoExcel(ByVal lCodigoPedido As Long, _
                                  ByVal iCodigoCliente As Integer, _
                                  ByVal iNumeroPedidoItemCliente As Integer, _
                                  ByVal lCodigoItem As Long, _
                                  ByVal dQuantidade As Double, _
                                  ByVal sDataEntrega As String, _
                                  ByVal dPrecoVenda As Double, _
                                  ByRef sErro As String)

        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCliente : i += 1

            'Seta Parametros - Nº Pedido Item Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_pedido_item_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iNumeroPedidoItemCliente : i += 1

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
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            'Seta Parametros - Data Entrega
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_entrega"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataEntrega : i += 1

            'Seta Parametros - Valor Unitário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_unitario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPrecoVenda : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Erro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "erro"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_venda_pedido_item_excel", oSqlParameter)

            'Seta Váriavel
            sErro = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: VENDEDOR :::"

    Public Sub InsertVendedor(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In oGrid.GetDataRows

                'Verifica se a Comissão é > que "0"
                If IsNumeric(oRow.Cells("percentual_comissao").Value) AndAlso oRow.Cells("percentual_comissao").Value > 0 Then

                    'Seta Váriavel
                    i = 0

                    'Seta Parametros - Código Orçamento
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_pedido"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                    oSqlParameter(i).Value = lCodigoPedido : i += 1

                    'Seta Parametros - Código Vendedor
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_vendedor"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.Int
                    oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                    'Seta Parametros - Percentual Comissão
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "percentual_comissao"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.Float
                    oSqlParameter(i).Value = oRow.Cells("percentual_comissao").Value : i += 1

                    'Seta Parametros - Valor Comissão
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "valor_comissao"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.Float
                    oSqlParameter(i).Value = oRow.Cells("valor_comissao").Value : i += 1

                    'Seta Parametros - Código Empresa
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_empresa"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                    oSqlParameter(i).Value = goUsuario.iEmpresa

                    'Executa Query
                    ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_venda_pedido_vendedor", oSqlParameter)

                End If
            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteVendedor()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Orçamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_venda_pedido_vendedor", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridVendedor(ByVal oGrid As GridEX, _
                                ByVal lCodigoPedido As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Orçamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_pedido_vendedor", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()


            If oGrid.RecordCount = 1 Then

                oGrid.Row = 0
                oGrid.SetValue("percentual_comissao", 100)

            End If

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function LoadValorComissao(ByVal iCodigoVendedor As Integer, _
                                      ByVal dPercentual As Double, _
                                      ByVal dDescontoValor As Double, _
                                      ByVal dValorTotal As Double) As Double

        'Variaveis Locais
        Dim oSqlParameter(6) As SqlParameter
        Dim dResult As Double
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            'Seta Parametros - Código Vendedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_vendedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoVendedor : i += 1

            'Seta Parametros - Percentual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "percentual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPercentual : i += 1

            'Seta Parametros - Desconto Geral
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desconto_geral"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDescontoValor : i += 1

            'Seta Parametros - Valor Total
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_total"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorTotal : i += 1

            'Seta Parametros - Código Perfil
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_perfil"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iPerfil

            'Executa Query
            dResult = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_pedido_comissao", oSqlParameter)

            Return dResult

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#Region "::: ITEM :::"

#Region "::: GERAL :::"

    Public Sub DeleteItem()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Pedido
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_pedido"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoPedido : i += 1

                'Seta Parametros - Código Pedido Item
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_pedido_item"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo_pedido_item").Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_venda_pedido_item", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosItem(ByVal lCodigoPedido As Long, _
                             ByVal iCodigoPedidoItem As Integer, _
                             ByVal txtNumeroOrcamento As MaskedEditBox, _
                             ByVal txtDataOrcamento As MaskedEditBox, _
                             ByVal txtCliente As MaskedEditBox, _
                             ByVal txtItem As MaskedEditBox, _
                             ByVal txtQuantidade As NumericEditBox, _
                             ByVal txtUnidadeMedida As MaskedEditBox, _
                             ByVal txtValorUnitario As NumericEditBox, _
                             ByVal txtValorTotal As NumericEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            'Seta Parametros - Código de Empresa
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
            oSqlParameter(i).Value = iCodigoPedidoItem

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_pedido_dados_item_historico", oSqlParameter)

            While oSqlDataReader.Read

                txtNumeroOrcamento.Text = oSqlDataReader.Item("numero_pedido")
                txtDataOrcamento.Text = oSqlDataReader.Item("data_pedido")
                txtCliente.Text = oSqlDataReader.Item("cliente")
                txtItem.Text = oSqlDataReader.Item("item")
                txtQuantidade.Value = oSqlDataReader.Item("quantidade")
                txtUnidadeMedida.Text = oSqlDataReader.Item("unidade_medida")
                txtValorUnitario.Value = oSqlDataReader.Item("valor_unitario")
                txtValorTotal.Value = oSqlDataReader.Item("valor_total")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosItemProjeto(ByVal lCodigoPedido As Long, _
                                    ByVal iCodigoPedidoItem As Integer, _
                                    ByVal txtNumeroOrcamento As MaskedEditBox, _
                                    ByVal txtDataOrcamento As MaskedEditBox, _
                                    ByVal txtCliente As MaskedEditBox, _
                                    ByVal txtItem As MaskedEditBox, _
                                    ByVal txtQuantidade As NumericEditBox, _
                                    ByVal txtUnidadeMedida As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            'Seta Parametros - Código de Empresa
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
            oSqlParameter(i).Value = iCodigoPedidoItem

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_pedido_item_historico_projeto", oSqlParameter)

            While oSqlDataReader.Read

                txtNumeroOrcamento.Text = oSqlDataReader.Item("numero_pedido")
                txtDataOrcamento.Text = oSqlDataReader.Item("data_pedido")
                txtCliente.Text = oSqlDataReader.Item("cliente")
                txtItem.Text = oSqlDataReader.Item("item")
                txtQuantidade.Value = oSqlDataReader.Item("quantidade")
                txtUnidadeMedida.Text = oSqlDataReader.Item("unidade_medida")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosItemCancelar(ByVal lCodigoPedido As Long, _
                                     ByVal iCodigoPedidoItem As Integer, _
                                     ByVal txtNumeroOrcamento As MaskedEditBox, _
                                     ByVal txtDataOrcamento As MaskedEditBox, _
                                     ByVal txtCliente As MaskedEditBox, _
                                     ByVal txtItem As MaskedEditBox, _
                                     ByVal txtQuantidade As NumericEditBox, _
                                     ByVal txtUnidadeMedida As MaskedEditBox, _
                                     ByVal txtValorUnitario As NumericEditBox, _
                                     ByVal txtValorTotal As NumericEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            'Seta Parametros - Código de Empresa
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
            oSqlParameter(i).Value = iCodigoPedidoItem

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_pedido_dados_item_historico_cancelar", oSqlParameter)

            While oSqlDataReader.Read

                txtNumeroOrcamento.Text = oSqlDataReader.Item("numero_pedido")
                txtDataOrcamento.Text = oSqlDataReader.Item("data_pedido")
                txtCliente.Text = oSqlDataReader.Item("cliente")
                txtItem.Text = oSqlDataReader.Item("item")
                txtQuantidade.Value = oSqlDataReader.Item("quantidade")
                txtUnidadeMedida.Text = oSqlDataReader.Item("unidade_medida")
                txtValorUnitario.Value = oSqlDataReader.Item("valor_unitario")
                txtValorTotal.Value = oSqlDataReader.Item("valor_total")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub CancelarItem(ByVal lCodigoPedido As Long, _
                            ByVal iCodigoPedidoItem As Integer, _
                            ByVal dQuantidade As Double, _
                            ByVal iCodigoJustificativaCancelamento As Integer, _
                            ByVal sHistorico As String)

        'Variaveis Locais
        Dim oSqlParameter(7) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Codigo Pedido Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoPedidoItem : i += 1

            'Seta Parametros - Histórico
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "historico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5000
            oSqlParameter(i).Value = sHistorico : i += 1

            'Seta Parametros - Código Justificativa de Cancelamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_justificativa_cancelamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoJustificativaCancelamento = -1, DBNull.Value, iCodigoJustificativaCancelamento) : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            'Seta Parametros - Codigo Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = StatusVendaPedidoItem.Cancelado

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_venda_pedido_item_status", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub AtivarItem(ByVal lCodigoPedido As Long, _
                          ByVal iCodigoPedidoItem As Integer, _
                          ByVal dQuantidade As Double, _
                          ByVal sHistorico As String)

        'Variaveis Locais
        Dim oSqlParameter(6) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Codigo Pedido Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoPedidoItem : i += 1

            'Seta Parametros - Histórico
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "historico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 255
            oSqlParameter(i).Value = sHistorico : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            'Seta Parametros - Codigo Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = CInt(StatusVendaPedidoItem.PedidoVenda)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_venda_pedido_item_status", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridItemHistorico(ByVal oGrid As GridEX, _
                                     ByVal lCodigoPedido As Long, _
                                     ByVal iCodigoPedidoItem As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Codigo Pedido Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoPedidoItem

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_pedido_item_historico", oSqlParameter)

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

    Public Function ValidaAtivarItem(ByVal lCodigoPedido As Long, _
                                     ByVal iCodigoPedidoItem As Integer) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim bReturn As Boolean
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
            oSqlParameter(i).Value = iCodigoPedidoItem

            'Executa Query
            bReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_venda_pedido_item_ativar", oSqlParameter), Boolean)

            Return bReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub LoadDadosEntrega(ByVal lCodigoPedido As Long, _
                                ByVal iCodigoPedidoItem As Integer, _
                                ByRef oDataEntrega As Hashtable)
        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim oPrevisaoEntrega As PrevisaoEntrega
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
            oSqlParameter(i).Value = iCodigoPedidoItem

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_pedido_item_entrega_editar", oSqlParameter)

            'Limpa Váriaveis
            i = 1
            oDataEntrega.Clear()

            While oSqlDataReader.Read

                'Seta Váriavel
                oPrevisaoEntrega.sPrevisaoEntrega = oSqlDataReader.Item("data_previsao_entrega")
                oPrevisaoEntrega.dQuantidade = oSqlDataReader.Item("quantidade")
                oPrevisaoEntrega.dQuantidadeFaturada = oSqlDataReader.Item("quantidade_entregue")
                oPrevisaoEntrega.sNotaFiscal = oSqlDataReader.Item("nota_fiscal")
                oDataEntrega.Add(i, oPrevisaoEntrega)

                i += 1

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close() : oSqlDataReader = Nothing

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: PRODUTO :::"

    Public Sub InsertProduto(ByVal lCodigoPedido As Long, _
                             ByVal sCodigoOCItem As String, _
                             ByVal lCodigoItem As Long, _
                             ByVal sComplemento As String, _
                             ByVal iCodigoDestinacao As Integer, _
                             ByVal dPrecoMinimo As Double, _
                             ByVal dCustoTeorico As Double, _
                             ByVal dQuantidade As Double, _
                             ByVal iCodigoUnidadeMedida As Integer, _
                             ByVal bIPIIncluso As Boolean, _
                             ByVal dAliquotaIPI As Double, _
                             ByVal dValorIPI As Double, _
                             ByVal bICMSIncluso As Boolean, _
                             ByVal dAliquotaICMS As Double, _
                             ByVal dValorICMS As Double, _
                             ByVal bPISCOFINSIncluso As Boolean, _
                             ByVal dAliquotaPISCOFINS As Double, _
                             ByVal dValorPISCOFINS As Double, _
                             ByVal dDescontoPercentual As Double, _
                             ByVal dDescontoValor As Double, _
                             ByVal iCodigoCentroGasto As Integer, _
                             ByVal sCodigoContaContabil As String, _
                             ByVal iCodigoEmbalagem As Integer, _
                             ByVal lCodigoAcordoComercial As Long, _
                             ByVal iCodigoAcordoComercialItem As Integer, _
                             ByVal iCodigoUsuario As Integer, _
                             ByVal oDataEntrega As Hashtable, _
                             ByVal dValorUnitarioProduto As Double, _
                             ByRef iCodigoPedidoItem As Integer)

        'Variaveis Locais
        Dim oSqlParameter(29) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            'Seta Parametros - Ordem de Compra Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_pedido_item_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(IsNumeric(sCodigoOCItem), sCodigoOCItem, DBNull.Value) : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Complemento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "complemento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = IIf(sComplemento = "", DBNull.Value, sComplemento) : i += 1

            'Seta Parametros - Código de Destinação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_destinacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoDestinacao : i += 1

            'Seta Parametros - Preço Mínimo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "preco_minimo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPrecoMinimo : i += 1

            'Seta Parametros - Custo Teórico
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "custo_teorico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dCustoTeorico : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            'Seta Parametros - Código Unidade Medida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoUnidadeMedida : i += 1

            'Seta Parametros - IPI Incluso
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ipi_incluso"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bIPIIncluso : i += 1

            'Seta Parametros - Alíquota IPI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaIPI : i += 1

            'Seta Parametros - Valor IPI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorIPI : i += 1

            'Seta Parametros - ICMS Incluso
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "icms_incluso"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bICMSIncluso : i += 1

            'Seta Parametros - Alíquota ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaICMS : i += 1

            'Seta Parametros - Valor ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorICMS : i += 1

            'Seta Parametros - PIS / COFINS Incluso
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pis_cofins_incluso"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bPISCOFINSIncluso : i += 1

            'Seta Parametros - Alíquota PIS / COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_pis_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaPISCOFINS : i += 1

            'Seta Parametros - Valor PIS / COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_pis_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorPISCOFINS : i += 1

            'Seta Parametros - Desconto Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desconto_valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDescontoValor : i += 1

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

            'Seta Parametros - Código Embalagem
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_embalagem"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoEmbalagem = -1, DBNull.Value, iCodigoEmbalagem) : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = StatusVendaPedidoItem.PedidoVenda : i += 1

            'Seta Parametros - Código Tipo de Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = CInt(TipoItem.produto) : i += 1

            'Seta Parametros - Código Acordo Comercial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoAcordoComercial = -1, DBNull.Value, lCodigoAcordoComercial) : i += 1

            'Seta Parametros - Código Acordo Comercial Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoAcordoComercialItem = -1, DBNull.Value, iCodigoAcordoComercialItem) : i += 1

            'Seta Parametros - Valor Unitário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_unitario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorUnitarioProduto : i += 1

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
            oSqlParameter(i).Value = iCodigoUsuario : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_venda_pedido_item", oSqlParameter)

            'Seta o retorno
            iCodigoPedidoItem = oSqlParameter(i).Value


            'Insere Dados da Entrega
            For Each oPrevisaoEntrega As PrevisaoEntrega In oDataEntrega.Values
                'Verifica se a Entrega já foi faturada
                If oPrevisaoEntrega.sNotaFiscal = "" Then
                    'Insere Registro na tb_ven_pedido_item_entrega
                    InsertProdutoEntrega(oSqlParameter(i).Value, _
                                         oPrevisaoEntrega.sPrevisaoEntrega, _
                                         oPrevisaoEntrega.dQuantidade)
                End If
            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertProduto(ByVal lCodigoPedido As Long, _
                             ByVal sRevisao As String, _
                             ByVal iCodigoCliente As Integer, _
                             ByVal sCodigoOCItem As String, _
                             ByVal lCodigoItem As Long, _
                             ByVal sComplemento As String, _
                             ByVal iCodigoDestinacao As Integer, _
                             ByVal dQuantidade As Double, _
                             ByVal sTipoCusto As String, _
                             ByVal dCustoMedio As Double, _
                             ByVal dCustoTeorico As Double, _
                             ByVal dMargem As Double, _
                             ByVal dGP As Double, _
                             ByVal dMarkup As Double, _
                             ByVal dValorUnitario As Double, _
                             ByVal lCodigoAcordoComercial As Long, _
                             ByVal iCodigoAcordoComercialItem As Integer, _
                             ByVal iCodigoUsuario As Integer, _
                             ByVal oDataEntrega As Hashtable)

        'Variaveis Locais
        Dim oSqlParameter(22) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            'Seta Parametros - Revisão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "revisao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sRevisao : i += 1

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCliente : i += 1

            'Seta Parametros - Ordem de Compra Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_pedido_item_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(IsNumeric(sNumeroPedidoCliente), sCodigoOCItem, DBNull.Value) : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Complemento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "complemento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = IIf(sComplemento = "", DBNull.Value, sComplemento) : i += 1

            'Seta Parametros - Código de Destinação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_destinacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoDestinacao : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            'Seta Parametros - Tipo de Custo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo_custo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sTipoCusto : i += 1

            'Seta Parametros - Custo Médio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "custo_medio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dCustoMedio : i += 1

            'Seta Parametros - Custo Teórico
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "custo_teorico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dCustoTeorico : i += 1

            'Seta Parametros - Margem
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "margem"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMargem : i += 1

            'Seta Parametros - GP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "gp"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dGP : i += 1

            'Seta Parametros - Markup
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "markup"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMarkup : i += 1

            'Seta Parametros - Valor Unitário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_unitario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorUnitario : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = StatusVendaPedidoItem.PedidoVenda : i += 1

            'Seta Parametros - Código Tipo de Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = CInt(TipoItem.produto) : i += 1

            'Seta Parametros - Código Acordo Comercial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoAcordoComercial = -1, DBNull.Value, lCodigoAcordoComercial) : i += 1

            'Seta Parametros - Código Acordo Comercial Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoAcordoComercialItem = -1, DBNull.Value, iCodigoAcordoComercialItem) : i += 1

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
            oSqlParameter(i).Value = IIf(iCodigoUsuario = 0, goUsuario.iUsuario, iCodigoUsuario) : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_venda_pedido_item_calculadora", oSqlParameter)

            'Insere Dados da Entrega
            For Each oPrevisaoEntrega As PrevisaoEntrega In oDataEntrega.Values
                'Verifica se a Entrega já foi faturada
                If oPrevisaoEntrega.sNotaFiscal = "" Then
                    'Insere Registro na tb_ven_pedido_item_entrega
                    InsertProdutoEntrega(oSqlParameter(i).Value, _
                                         oPrevisaoEntrega.sPrevisaoEntrega, _
                                         oPrevisaoEntrega.dQuantidade)
                End If
            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateProduto(ByVal lCodigoPedido As Long, _
                             ByVal sCodigoOCItem As String, _
                             ByVal lCodigoItem As Long, _
                             ByVal sComplemento As String, _
                             ByVal iCodigoDestinacao As Integer, _
                             ByVal dPrecoMinimo As Double, _
                             ByVal dCustoTeorico As Double, _
                             ByVal dQuantidade As Double, _
                             ByVal iCodigoUnidadeMedida As Integer, _
                             ByVal bIPIIncluso As Boolean, _
                             ByVal dAliquotaIPI As Double, _
                             ByVal dValorIPI As Double, _
                             ByVal bICMSIncluso As Boolean, _
                             ByVal dAliquotaICMS As Double, _
                             ByVal dValorICMS As Double, _
                             ByVal bPISCOFINSIncluso As Boolean, _
                             ByVal dAliquotaPISCOFINS As Double, _
                             ByVal dValorPISCOFINS As Double, _
                             ByVal dDescontoPercentual As Double, _
                             ByVal dDescontoValor As Double, _
                             ByVal iCodigoCentroGasto As Integer, _
                             ByVal sCodigoContaContabil As String, _
                             ByVal iCodigoEmbalagem As Integer, _
                             ByVal lCodigoAcordoComercial As Long, _
                             ByVal iCodigoAcordoComercialItem As Integer, _
                             ByVal iCodigoUsuario As Integer, _
                             ByVal oDataEntrega As Hashtable, _
                             ByVal iCodigoPedidoItem As Integer, _
                             ByVal dValorUnitarioProduto As Double)

        'Variaveis Locais
        Dim oSqlParameter(29) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            'Seta Parametros - Ordem de Compra Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_pedido_item_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(IsNumeric(sCodigoOCItem), sCodigoOCItem, DBNull.Value) : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Complemento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "complemento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = IIf(sComplemento = "", DBNull.Value, sComplemento) : i += 1

            'Seta Parametros - Código de Destinação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_destinacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoDestinacao : i += 1

            'Seta Parametros - Preço Mínimo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "preco_minimo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPrecoMinimo : i += 1

            'Seta Parametros - Custo Teórico
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "custo_teorico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dCustoTeorico : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            'Seta Parametros - Código Unidade Medida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoUnidadeMedida : i += 1

            'Seta Parametros - IPI Incluso
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ipi_incluso"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bIPIIncluso : i += 1

            'Seta Parametros - Alíquota IPI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaIPI : i += 1

            'Seta Parametros - Valor IPI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorIPI : i += 1

            'Seta Parametros - ICMS Incluso
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "icms_incluso"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bICMSIncluso : i += 1

            'Seta Parametros - Alíquota ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaICMS : i += 1

            'Seta Parametros - Valor ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorICMS : i += 1

            'Seta Parametros - PIS / COFINS Incluso
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pis_cofins_incluso"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bPISCOFINSIncluso : i += 1

            'Seta Parametros - Alíquota PIS / COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_pis_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaPISCOFINS : i += 1

            'Seta Parametros - Valor PIS / COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_pis_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorPISCOFINS : i += 1

            'Seta Parametros - Desconto Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desconto_valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDescontoValor : i += 1

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

            'Seta Parametros - Código Embalagem
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_embalagem"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoEmbalagem = -1, DBNull.Value, iCodigoEmbalagem) : i += 1

            'Seta Parametros - Valor Unitário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_unitario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorUnitarioProduto : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = StatusVendaPedidoItem.PedidoVenda : i += 1

            'Seta Parametros - Código Tipo de Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = CInt(TipoItem.produto) : i += 1

            'Seta Parametros - Código Acordo Comercial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoAcordoComercial = -1, DBNull.Value, lCodigoAcordoComercial) : i += 1

            'Seta Parametros - Código Acordo Comercial Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoAcordoComercialItem = -1, DBNull.Value, iCodigoAcordoComercialItem) : i += 1

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
            oSqlParameter(i).Value = iCodigoUsuario : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoPedidoItem

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_venda_pedido_item", oSqlParameter)

            'Insere Dados da Entrega
            For Each oPrevisaoEntrega As PrevisaoEntrega In oDataEntrega.Values
                'Verifica se a Entrega já foi faturada
                If oPrevisaoEntrega.sNotaFiscal = "" Then
                    'Insere Registro na tb_ven_pedido_item_entrega
                    InsertProdutoEntrega(oSqlParameter(i).Value, _
                                         oPrevisaoEntrega.sPrevisaoEntrega, _
                                         oPrevisaoEntrega.dQuantidade)
                End If
            Next


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateProduto(ByVal lCodigoPedido As Long, _
                             ByVal sRevisao As String, _
                             ByVal iCodigoCliente As Integer, _
                             ByVal sCodigoOCItem As String, _
                             ByVal lCodigoItem As Long, _
                             ByVal sComplemento As String, _
                             ByVal iCodigoDestinacao As Integer, _
                             ByVal dQuantidade As Double, _
                             ByVal sTipoCusto As String, _
                             ByVal dCustoMedio As Double, _
                             ByVal dCustoTeorico As Double, _
                             ByVal dMargem As Double, _
                             ByVal dGP As Double, _
                             ByVal dMarkup As Double, _
                             ByVal dValorUnitario As Double, _
                             ByVal lCodigoAcordoComercial As Long, _
                             ByVal iCodigoAcordoComercialItem As Integer, _
                             ByVal iCodigoUsuario As Integer, _
                             ByVal oDataEntrega As Hashtable, _
                             ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(21) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            'Seta Parametros - Revisão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "revisao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sRevisao : i += 1

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCliente : i += 1

            'Seta Parametros - Ordem de Compra Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_pedido_item_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(IsNumeric(sNumeroPedidoCliente), sCodigoOCItem, DBNull.Value) : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Complemento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "complemento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = IIf(sComplemento = "", DBNull.Value, sComplemento) : i += 1

            'Seta Parametros - Código de Destinação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_destinacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoDestinacao : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            'Seta Parametros - Tipo de Custo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo_custo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sTipoCusto : i += 1

            'Seta Parametros - Custo Médio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "custo_medio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dCustoMedio : i += 1

            'Seta Parametros - Custo Teórico
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "custo_teorico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dCustoTeorico : i += 1

            'Seta Parametros - Margem
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "margem"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMargem : i += 1

            'Seta Parametros - GP
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "gp"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dGP : i += 1

            'Seta Parametros - Markup
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "markup"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dMarkup : i += 1

            'Seta Parametros - Valor Unitário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_unitario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorUnitario : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = StatusVendaPedidoItem.PedidoVenda : i += 1

            'Seta Parametros - Código Tipo de Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = CInt(TipoItem.produto) : i += 1

            'Seta Parametros - Código Acordo Comercial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoAcordoComercial = -1, DBNull.Value, lCodigoAcordoComercial) : i += 1

            'Seta Parametros - Código Acordo Comercial Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoAcordoComercialItem = -1, DBNull.Value, iCodigoAcordoComercialItem) : i += 1

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
            oSqlParameter(i).Value = IIf(iCodigoUsuario = 0, goUsuario.iUsuario, iCodigoUsuario) : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_venda_pedido_item_calculadora", oSqlParameter)
            
            'Insere Dados da Entrega
            For Each oPrevisaoEntrega As PrevisaoEntrega In oDataEntrega.Values
                'Verifica se a Entrega já foi faturada
                If oPrevisaoEntrega.sNotaFiscal = "" Then
                    'Insere Registro na tb_ven_pedido_item_entrega
                    InsertProdutoEntrega(oSqlParameter(i).Value, _
                                         oPrevisaoEntrega.sPrevisaoEntrega, _
                                         oPrevisaoEntrega.dQuantidade)
                End If
            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteProduto()

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Pedido
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_pedido"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoPedido : i += 1

                'Seta Parametros - Código Pedido Item
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_pedido_item"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo_pedido_item").Value : i += 1

                'Seta Parametros - Código Tipo de Item
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_tipo_item"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = CInt(TipoItem.produto) : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_venda_pedido_item", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub EditarProduto(ByVal iCodigoPedidoItem As Integer, _
                             ByVal txtOCItem As MaskedEditBox, _
                             ByVal cboProduto As UIComboBox, _
                             ByVal txtComplemento As MaskedEditBox, _
                             ByVal cboDestinacao As UIComboBox, _
                             ByVal txtQuantidade As NumericEditBox, _
                             ByVal cboUnidadeMedida As UIComboBox, _
                             ByVal txtDescontoPercentual As NumericEditBox, _
                             ByVal txtDescontoValor As NumericEditBox, _
                             ByVal txtValorUnitario As NumericEditBox, _
                             ByVal chkICMSEmbutido As UICheckBox, _
                             ByVal txtAliquotaICMS As NumericEditBox, _
                             ByVal chkIPIEmbutido As UICheckBox, _
                             ByVal txtAliquotaIPI As NumericEditBox, _
                             ByVal chkPISCOFINSEmbutido As UICheckBox, _
                             ByVal txtAliquotaPISCOFINS As NumericEditBox, _
                             ByVal dtpDataPrevisaoEntrega As CalendarCombo, _
                             ByVal cboCentroGasto As UIComboBox, _
                             ByVal cboContaContabil As UIComboBox, _
                             ByVal cboEmbalagem As UIComboBox, _
                             ByVal txtRCItem As MaskedEditBox, _
                             ByVal txtOMItem As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            'Seta Parametros - Código Pedido Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoPedidoItem : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_pedido_item_editar", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    'Carrega Váriavel
                    cboProduto.SelectedValue = oSqlDataReader.Item("codigo_item") : Application.DoEvents()
                    txtOCItem.Text = oSqlDataReader.Item("numero_pedido_item_cliente")
                    txtComplemento.Text = oSqlDataReader.Item("complemento")
                    cboDestinacao.SelectedValue = oSqlDataReader.Item("codigo_destinacao")
                    txtQuantidade.Value = oSqlDataReader.Item("quantidade")
                    cboUnidadeMedida.SelectedValue = oSqlDataReader.Item("codigo_unidade_medida")
                    txtDescontoPercentual.Value = oSqlDataReader.Item("desconto_unitario_percentual")
                    txtDescontoPercentual.Tag = oSqlDataReader.Item("desconto_unitario_percentual")
                    txtDescontoValor.Value = oSqlDataReader.Item("desconto_unitario_valor")
                    txtValorUnitario.Value = oSqlDataReader.Item("valor_unitario")
                    chkICMSEmbutido.Checked = oSqlDataReader.Item("icms_incluso")
                    txtAliquotaICMS.Value = oSqlDataReader.Item("aliquota_icms")
                    txtAliquotaICMS.Tag = oSqlDataReader.Item("valor_icms")
                    chkIPIEmbutido.Checked = oSqlDataReader.Item("ipi_incluso")
                    txtAliquotaIPI.Value = oSqlDataReader.Item("aliquota_ipi")
                    txtAliquotaIPI.Tag = oSqlDataReader.Item("valor_ipi")
                    chkPISCOFINSEmbutido.Checked = oSqlDataReader.Item("pis_cofins_incluso")
                    txtAliquotaPISCOFINS.Value = oSqlDataReader.Item("aliquota_pis_cofins")
                    txtAliquotaPISCOFINS.Tag = oSqlDataReader.Item("valor_pis_cofins")
                    dtpDataPrevisaoEntrega.Tag = oSqlDataReader.Item("data_desmembrada") & "|" & oSqlDataReader.Item("quantidade_desmembrada") & "*" & oSqlDataReader.Item("codigo_desmembrado")
                    dtpDataPrevisaoEntrega.Value = oSqlDataReader.Item("data_desmembrada").ToString.Split(";")(0)
                    cboCentroGasto.SelectedValue = oSqlDataReader.Item("codigo_centro_custo")
                    cboContaContabil.SelectedValue = oSqlDataReader.Item("codigo_conta_contabil")
                    cboEmbalagem.SelectedValue = oSqlDataReader.Item("codigo_embalagem")
                    txtRCItem.Text = oSqlDataReader.Item("rc_item")
                    txtOMItem.Text = oSqlDataReader.Item("om_item")

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

    Public Sub EditarDadosTerceiros(ByVal iCodigoPedidoItem As Integer, _
                                    ByVal txtTerceirosAtivoFixo As MaskedEditBox, _
                                    ByVal txtTerceirosCemb As MaskedEditBox, _
                                    ByVal txtTerceirosNs As MaskedEditBox, _
                                    ByVal txtTerceirosPlanta As MaskedEditBox, _
                                    ByVal txtTerceirosPo As MaskedEditBox, _
                                    ByVal txtTerceirosPoLinha As MaskedEditBox, _
                                    ByVal txtTerceirosRef As MaskedEditBox, _
                                    ByVal txtTerceirosEspecificador As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            'Seta Parametros - Código Pedido Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoPedidoItem : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_pedido_item_editar_terceiros", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    'Carrega Váriavel
                    txtTerceirosAtivoFixo.Text = oSqlDataReader.Item("po_ativo_fixo")
                    txtTerceirosCemb.Text = oSqlDataReader.Item("po_cemb")
                    txtTerceirosNs.Text = oSqlDataReader.Item("po_ns")
                    txtTerceirosPlanta.Text = oSqlDataReader.Item("po_planta")
                    txtTerceirosPo.Text = oSqlDataReader.Item("po_numero")
                    txtTerceirosPoLinha.Text = oSqlDataReader.Item("po_numero_linha")
                    txtTerceirosRef.Text = oSqlDataReader.Item("po_ref")
                    txtTerceirosEspecificador.Text = oSqlDataReader.Item("po_especificador")

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

    Public Sub EditarDadosTerceirosServico(ByVal iCodigoPedidoItem As Integer, _
                                           ByVal txtTerceirosAtivoFixoServico As MaskedEditBox, _
                                           ByVal txtTerceirosCembServico As MaskedEditBox, _
                                           ByVal txtTerceirosNsServico As MaskedEditBox, _
                                           ByVal txtTerceirosPlantaServico As MaskedEditBox, _
                                           ByVal txtTerceirosPoServico As MaskedEditBox, _
                                           ByVal txtTerceirosPoLinhaServico As MaskedEditBox, _
                                           ByVal txtTerceirosRefServico As MaskedEditBox, _
                                           ByVal txtTerceirosEspecificadorServico As MaskedEditBox, _
                                           ByVal txtTerceirosRcServico As MaskedEditBox, _
                                           ByVal txtTerceirosOmServico As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            'Seta Parametros - Código Pedido Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoPedidoItem : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_pedido_item_editar_terceiros", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    'Carrega Váriavel
                    txtTerceirosAtivoFixoServico.Text = oSqlDataReader.Item("po_ativo_fixo")
                    txtTerceirosCembServico.Text = oSqlDataReader.Item("po_cemb")
                    txtTerceirosNsServico.Text = oSqlDataReader.Item("po_ns")
                    txtTerceirosPlantaServico.Text = oSqlDataReader.Item("po_planta")
                    txtTerceirosPoServico.Text = oSqlDataReader.Item("po_numero")
                    txtTerceirosPoLinhaServico.Text = oSqlDataReader.Item("po_numero_linha")
                    txtTerceirosRefServico.Text = oSqlDataReader.Item("po_ref")
                    txtTerceirosEspecificadorServico.Text = oSqlDataReader.Item("po_especificador")
                    txtTerceirosRcServico.Text = oSqlDataReader.Item("rc_item")
                    txtTerceirosOmServico.Text = oSqlDataReader.Item("om_item")

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

    Public Sub EditarProduto(ByVal iCodigoPedidoItem As Integer, _
                             ByVal txtOCItem As MaskedEditBox, _
                             ByVal cboProduto As UIComboBox, _
                             ByVal txtComplemento As MaskedEditBox, _
                             ByVal cboDestinacao As UIComboBox, _
                             ByVal txtQuantidade As NumericEditBox, _
                             ByVal txtQuantidadeUnidade As NumericEditBox, _
                             ByVal dtpDataPrevisaoEntrega As CalendarCombo, _
                             ByVal txtCustoMedio As NumericEditBox, _
                             ByVal txtMargemMedio As NumericEditBox, _
                             ByVal txtGPMedio As NumericEditBox, _
                             ByVal txtMarkupMedio As NumericEditBox, _
                             ByVal txtPrecoVendaMedio As NumericEditBox, _
                             ByVal txtPrecoVendaUnidadeMedio As NumericEditBox, _
                             ByVal txtCustoTeorico As NumericEditBox, _
                             ByVal txtMargemTeorico As NumericEditBox, _
                             ByVal txtGPTeorico As NumericEditBox, _
                             ByVal txtMarkupTeorico As NumericEditBox, _
                             ByVal txtPrecoVendaTeorico As NumericEditBox, _
                             ByVal txtPrecoVendaUnidadeTeorico As NumericEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            'Seta Parametros - Código Pedido Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoPedidoItem : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_pedido_item_editar", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    'Carrega Váriavel
                    txtOCItem.Text = oSqlDataReader.Item("numero_pedido_item_cliente")
                    cboProduto.SelectedValue = oSqlDataReader.Item("codigo_item")
                    txtComplemento.Text = oSqlDataReader.Item("complemento")
                    cboDestinacao.SelectedValue = oSqlDataReader.Item("codigo_destinacao")
                    txtQuantidade.Value = oSqlDataReader.Item("quantidade")
                    txtQuantidadeUnidade.Value = oSqlDataReader.Item("quantidade_unidade")
                    dtpDataPrevisaoEntrega.Tag = oSqlDataReader.Item("data_desmembrada") & "|" & oSqlDataReader.Item("quantidade_desmembrada") & "*" & oSqlDataReader.Item("codigo_desmembrado")
                    dtpDataPrevisaoEntrega.Value = oSqlDataReader.Item("data_desmembrada").ToString.Split(";")(0)
                    txtCustoMedio.Value = oSqlDataReader.Item("custo_medio")
                    txtMargemMedio.Value = oSqlDataReader.Item("custo_teorico")
                    txtGPMedio.Value = oSqlDataReader.Item("gp_medio")
                    txtMarkupMedio.Value = oSqlDataReader.Item("markup_medio")
                    txtPrecoVendaMedio.Value = oSqlDataReader.Item("preco_venda_medio")
                    txtPrecoVendaUnidadeMedio.Value = oSqlDataReader.Item("preco_venda_unidade_medio")
                    txtCustoTeorico.Value = oSqlDataReader.Item("custo_teorico")
                    txtMargemTeorico.Value = oSqlDataReader.Item("margem_teorico")
                    txtGPTeorico.Value = oSqlDataReader.Item("gp_teorico")
                    txtMarkupTeorico.Value = oSqlDataReader.Item("markup_teorico")
                    txtPrecoVendaTeorico.Value = oSqlDataReader.Item("preco_venda_teorico")
                    txtPrecoVendaUnidadeTeorico.Value = oSqlDataReader.Item("preco_venda_unidade_teorico")

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

    Public Sub LoadGridProduto(ByVal oGrid As GridEX, _
                               ByVal lCodigoPedido As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Orçamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            'Seta Parametros - Código Tipo de Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = CInt(TipoItem.produto) : i += 1

            'Seta Parametros - Código Empresa   
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_pedido_item", oSqlParameter)

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

    Public Sub LoadDadosProduto(ByVal lCodigoProduto As Long, _
                                ByRef sDescricao As String, _
                                ByRef iCodigoUnidadeMedida As Integer, _
                                ByRef dQuantidadeEstoque As Double, _
                                ByRef bItemEstoque As Boolean, _
                                ByRef bItemProducao As Boolean, _
                                ByRef iCodigoFormaVendaProduto As FormaVendaItem, _
                                ByRef iCodigoFormaVendaServico As FormaVendaItem, _
                                ByRef dPrecoVendaServico As Double, _
                                ByRef dPercentualValorProduto As Double)

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
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_pedido_dados_item", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    'Carrega Váriavel
                    sDescricao = oSqlDataReader.Item("descricao")
                    iCodigoUnidadeMedida = oSqlDataReader.Item("codigo_unidade_medida_venda")
                    dQuantidadeEstoque = oSqlDataReader.Item("quantidade_estoque")
                    bItemEstoque = oSqlDataReader.Item("item_estoque")
                    bItemProducao = oSqlDataReader.Item("item_producao")
                    iCodigoFormaVendaProduto = oSqlDataReader.Item("codigo_forma_venda_item")
                    iCodigoFormaVendaServico = oSqlDataReader.Item("codigo_forma_venda_servico")
                    dPrecoVendaServico = oSqlDataReader.Item("preco_venda_servico")
                    dPrecoVendaServico = oSqlDataReader.Item("percentual_venda_servico")

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

    Public Sub LoadDadosPrecoVendaProduto(ByVal lCodigoProduto As Long, _
                                          ByRef oPrecoVendaProduto() As PrecoVendaProduto)

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
            oSqlParameter(i).Value = lCodigoProduto : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_pedido_dados_preco_venda_item", oSqlParameter)

            'Redimensiona o Vetor
            ReDim oPrecoVendaProduto(0)

            While oSqlDataReader.Read

                'Verifica necessidade de Redimensionar o Vetor
                If oPrecoVendaProduto(UBound(oPrecoVendaProduto)).dQuantidade > 0 Then
                    'Redimensiona o Vetor
                    ReDim Preserve oPrecoVendaProduto(UBound(oPrecoVendaProduto) + 1)
                End If

                'Carrega Vetor
                oPrecoVendaProduto(UBound(oPrecoVendaProduto)).dQuantidade = oSqlDataReader.Item("quantidade")
                oPrecoVendaProduto(UBound(oPrecoVendaProduto)).dValorUnitario = oSqlDataReader.Item("valor_unitario")
                oPrecoVendaProduto(UBound(oPrecoVendaProduto)).dVariavel = oSqlDataReader.Item("variavel")

            End While

            'Fecha o DataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaProduto(ByVal lCodigoItem As Long, _
                                  ByVal lCodigoParceiroNegocio As Long, _
                                  ByVal iCodigoDestinacao As Integer) As String

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim sReturn As String = ""
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Código Parceiro de Negócio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_parceiro_negocio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoParceiroNegocio : i += 1

            'Seta Parametros - Código Destinação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_destinacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoDestinacao : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            sReturn = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_venda_pedido_item", oSqlParameter).ToString

            Return sReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ValidaProdutoComissao(ByVal lCodigoPedido As Long, _
                                          ByVal lCodigoItem As Long) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

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
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            Return CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_venda_pedido_comissao", oSqlParameter), Boolean)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub DeleteProdutoEntrega(ByVal iCodigoPedidoItem As Integer)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
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
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Pedido Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoPedidoItem

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_venda_pedido_item_entrega", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertProdutoEntrega(ByVal iCodigoPedidoItem As Integer, _
                                    ByVal sDataPrevisaoEntrega As String, _
                                    ByVal dQuantidade As Double, _
                                    Optional ByVal sTipo As String = "I")

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Orçamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Orçamento Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoPedidoItem : i += 1

            'Seta Parametros - Data Previsão Entrega
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_previsao_entrega"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataPrevisaoEntrega : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Char
            oSqlParameter(i).Size = 1
            oSqlParameter(i).Value = sTipo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_venda_pedido_item_entrega", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateDestinacao(ByVal lCodigoPedido As Long, _
                                ByVal iCodigoDestinacao As Integer)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            'Seta Parametros - Código Destinação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_destinacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoDestinacao : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_venda_pedido_item_destinacao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdatePrazoEntrega(ByVal lCodigoPedido As Long, _
                                  ByVal sPrazoEntrega As String)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            'Seta Parametros - Prazo de Entrega
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "prazo_entrega"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Datetime
            oSqlParameter(i).Value = sPrazoEntrega : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_venda_pedido_item_prazo_entrega", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: SERVIÇO :::"

    Public Sub InsertServico(ByVal sCodigoOCItem As String, _
                             ByVal lCodigoItem As Long, _
                             ByVal sComplemento As String, _
                             ByVal dQuantidade As Double, _
                             ByVal iCodigoUnidadeMedida As Integer, _
                             ByVal dValorServico As Double, _
                             ByVal dDesconto As Double, _
                             ByVal dValorLiquido As Double, _
                             ByVal sDataPrevisaoEntrega As String, _
                             ByVal bISSRetido As Boolean, _
                             ByVal dAliquotaISS As Double, _
                             ByVal dAliquotaPIS As Double, _
                             ByVal dAliquotaCOFINS As Double, _
                             ByVal dAliquotaINSS As Double, _
                             ByVal dAliquotaCSLL As Double, _
                             ByVal dAliquotaIR As Double, _
                             ByVal iCodigoCentroGasto As Integer, _
                             ByVal sCodigoContaContabil As String, _
                             ByVal oDataEntrega As Hashtable, _
                             ByRef iCodigoPedidoItem As Integer)

        'Variaveis Locais
        Dim oSqlParameter(31) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            'Seta Parametros - Ordem de Compra Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_pedido_item_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(IsNumeric(sCodigoOCItem), sCodigoOCItem, DBNull.Value) : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Complemento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "complemento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = IIf(sComplemento = "", DBNull.Value, sComplemento) : i += 1

            'Seta Parametros - Código de Destinação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_destinacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = DBNull.Value : i += 1

            'Seta Parametros - Preço de Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "preco_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = DBNull.Value : i += 1

            'Seta Parametros - Preço Mínimo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "preco_minimo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = DBNull.Value : i += 1

            'Seta Parametros - Custo Teórico
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "custo_teorico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = DBNull.Value : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            'Seta Parametros - Váriavel
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "variavel"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = DBNull.Value : i += 1

            'Seta Parametros - Código Unidade Medida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoUnidadeMedida : i += 1

            'Seta Parametros - IPI Incluso
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ipi_incluso"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = False : i += 1

            'Seta Parametros - Alíquota IPI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = DBNull.Value : i += 1

            'Seta Parametros - Valor IPI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = DBNull.Value : i += 1

            'Seta Parametros - ICMS Incluso
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "icms_incluso"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = False : i += 1

            'Seta Parametros - Alíquota ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = DBNull.Value : i += 1

            'Seta Parametros - Valor ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = DBNull.Value : i += 1

            'Seta Parametros - PIS / COFINS Incluso
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pis_cofins_incluso"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = False : i += 1

            'Seta Parametros - Alíquota PIS / COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_pis_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaPIS : i += 1

            'Seta Parametros - Valor PIS / COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_pis_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = DBNull.Value : i += 1

            'Seta Parametros - Valor Unitário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_unitario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorServico : i += 1

            'Seta Parametros - Desconto Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desconto_valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorDesconto : i += 1

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

            'Seta Parametros - Código Embalagem
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_embalagem"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = DBNull.Value : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = StatusVendaPedidoItem.PedidoVenda : i += 1

            'Seta Parametros - Código Tipo de Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = CInt(TipoItem.servico) : i += 1

            'Seta Parametros - Código Acordo Comercial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = DBNull.Value : i += 1

            'Seta Parametros - Código Acordo Comercial Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_acordo_comercial_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = DBNull.Value : i += 1

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
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_venda_pedido_item", oSqlParameter)

            'Seta o retorno
            iCodigoPedidoItem = oSqlParameter(i).Value

            'Insere Dados da Entrega
            For Each oPrevisaoEntrega As PrevisaoEntrega In oDataEntrega.Values
                'Verifica se a Entrega já foi faturada
                If oPrevisaoEntrega.sNotaFiscal = "" Then
                    'Insere Registro na tb_ven_pedido_item_entrega
                    InsertServicoEntrega(oSqlParameter(i).Value, _
                                         oPrevisaoEntrega.sPrevisaoEntrega, _
                                         oPrevisaoEntrega.dQuantidade)
                End If
            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateServico(ByVal sCodigoOCItem As String, _
                             ByVal lCodigoItem As Long, _
                             ByVal sComplemento As String, _
                             ByVal dQuantidade As Double, _
                             ByVal iCodigoUnidadeMedida As Integer, _
                             ByVal dValorServico As Double, _
                             ByVal dDesconto As Double, _
                             ByVal dValorLiquido As Double, _
                             ByVal sDataPrevisaoEntrega As String, _
                             ByVal bISSRetido As Boolean, _
                             ByVal dAliquotaISS As Double, _
                             ByVal dAliquotaPIS As Double, _
                             ByVal dAliquotaCOFINS As Double, _
                             ByVal dAliquotaINSS As Double, _
                             ByVal dAliquotaCSLL As Double, _
                             ByVal dAliquotaIR As Double, _
                             ByVal iCodigoCentroGasto As Integer, _
                             ByVal sCodigoContaContabil As String, _
                             ByVal iCodigoPedidoItem As Integer, _
                             ByVal oDataEntrega As Hashtable)

        'Variaveis Locais
        Dim oSqlParameter(20) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            'Seta Parametros - Ordem de Compra Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_pedido_item_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(IsNumeric(sCodigoOCItem), sCodigoOCItem, DBNull.Value) : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Complemento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "complemento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = IIf(sComplemento = "", DBNull.Value, sComplemento) : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            'Seta Parametros - Código Unidade Medida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = iCodigoUnidadeMedida : i += 1

            'Seta Parametros - Valor Unitário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_unitario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorServico : i += 1

            'Seta Parametros - Desconto Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desconto_valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDesconto : i += 1

            'Seta Parametros - ISS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "iss_retido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bISSRetido : i += 1

            'Seta Parametros - Alíquota ISS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_iss"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaISS : i += 1

            'Seta Parametros - Alíquota PIS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_pis"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaPIS : i += 1

            'Seta Parametros - Alíquota COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaCOFINS : i += 1

            'Seta Parametros - Alíquota INSS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_inss"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaINSS : i += 1

            'Seta Parametros - Alíquota CSLL
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_csll"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaCSLL : i += 1

            'Seta Parametros - IR
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_ir"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaIR : i += 1

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

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = StatusVendaPedidoItem.PedidoVenda : i += 1

            'Seta Parametros - Código Tipo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = CInt(TipoItem.servico) : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoPedidoItem

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_venda_pedido_item", oSqlParameter)

            'Insere Dados da Entrega
            For Each oPrevisaoEntrega As PrevisaoEntrega In oDataEntrega.Values
                'Verifica se a Entrega já foi faturada
                If oPrevisaoEntrega.sNotaFiscal = "" Then
                    'Insere Registro na tb_ven_pedido_item_entrega
                    InsertServicoEntrega(oSqlParameter(i).Value, _
                                         oPrevisaoEntrega.sPrevisaoEntrega, _
                                         oPrevisaoEntrega.dQuantidade)
                End If
            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub EditarServico(ByVal iCodigoPedidoItem As Integer, _
                             ByVal txtOrdemCompraItemServico As MaskedEditBox, _
                             ByVal cboServico As UIComboBox, _
                             ByVal txtComplemento As EditBox, _
                             ByVal txtValorServico As NumericEditBox, _
                             ByVal txtQuantidadeServico As NumericEditBox, _
                             ByVal cboUnidadeMedidaServico As UIComboBox, _
                             ByVal txtDescontoServico As NumericEditBox, _
                             ByVal txtValorTotalServico As NumericEditBox, _
                             ByVal dtpDataPrevisaoEntrega As CalendarCombo, _
                             ByVal chkISSRetido As UICheckBox, _
                             ByVal txtAliquotaISS As NumericEditBox, _
                             ByVal txtAliquotaPIS As NumericEditBox, _
                             ByVal txtAliquotaCOFINS As NumericEditBox, _
                             ByVal txtAliquotaINSS As NumericEditBox, _
                             ByVal txtAliquotaCSLL As NumericEditBox, _
                             ByVal txtAliquotaIR As NumericEditBox, _
                             ByVal cboCentroGastoServico As UIComboBox, _
                             ByVal cboContaContabilServico As UIComboBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            'Seta Parametros - Código Pedido Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoPedidoItem : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_pedido_item_editar", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    'Carrega Váriavel
                    txtOrdemCompraItemServico.Text = oSqlDataReader.Item("numero_pedido_item_cliente")
                    cboServico.SelectedValue = oSqlDataReader.Item("codigo_item")
                    txtComplemento.Text = oSqlDataReader.Item("complemento")
                    txtQuantidadeServico.Value = oSqlDataReader.Item("quantidade")
                    txtValorServico.Value = oSqlDataReader.Item("valor_unitario")
                    cboUnidadeMedidaServico.SelectedValue = oSqlDataReader.Item("codigo_unidade_medida")
                    txtDescontoServico.Value = oSqlDataReader.Item("desconto_unitario_valor")
                    txtValorTotalServico.Value = oSqlDataReader.Item("valor_total_desconto")
                    dtpDataPrevisaoEntrega.Tag = oSqlDataReader.Item("data_desmembrada") & "|" & oSqlDataReader.Item("quantidade_desmembrada")
                    dtpDataPrevisaoEntrega.Value = oSqlDataReader.Item("data_desmembrada").ToString.Split(";")(0)
                    chkISSRetido.Checked = oSqlDataReader.Item("iss_retido")
                    txtAliquotaISS.Value = oSqlDataReader.Item("aliquota_iss")
                    txtAliquotaPIS.Value = oSqlDataReader.Item("aliquota_pis")
                    txtAliquotaCOFINS.Value = oSqlDataReader.Item("aliquota_cofins")
                    txtAliquotaINSS.Value = oSqlDataReader.Item("aliquota_inss")
                    txtAliquotaCSLL.Value = oSqlDataReader.Item("aliquota_csll")
                    txtAliquotaIR.Value = oSqlDataReader.Item("aliquota_ir")
                    cboCentroGastoServico.SelectedValue = oSqlDataReader.Item("codigo_centro_custo")
                    cboContaContabilServico.SelectedValue = oSqlDataReader.Item("codigo_conta_contabil")

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

    Public Sub DeleteServico()

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow In gSelecaoRow

                'Seta Váriavel 
                i = 0

                'Seta Parametros - Código Pedido
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_pedido"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoPedido : i += 1

                'Seta Parametros - Código Pedido Item
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_pedido_item"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo_pedido_item").Value : i += 1

                'Seta Parametros - Código Tipo de Item
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_tipo_item"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = CInt(TipoItem.servico) : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_venda_pedido_item", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridServico(ByVal oGrid As GridEX, _
                               ByVal lCodigoPedido As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Orçamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            'Seta Parametros - Código Tipo de Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = CInt(TipoItem.servico) : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_pedido_item", oSqlParameter)

            'Configurar DataMember
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

    Public Sub LoadDadosServico(ByVal lCodigoServico As Long, _
                                ByVal txtDescricaoServico As MaskedEditBox, _
                                ByVal txtAliquotaISS As NumericEditBox)

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
            oSqlParameter(i).Value = lCodigoServico : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_pedido_dados_item", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    'Carrega Váriavel
                    txtDescricaoServico.Text = oSqlDataReader.Item("descricao")
                    txtAliquotaISS.Value = oSqlDataReader.Item("aliquota_iss_padrao")

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

    Public Sub InsertServicoEntrega(ByVal iCodigoPedidoItem As Integer, _
                                    ByVal sDataPrevisaoEntrega As String, _
                                    ByVal dQuantidade As Double)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Orçamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Orçamento Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoPedidoItem : i += 1

            'Seta Parametros - Data Previsão Entrega
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_previsao_entrega"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataPrevisaoEntrega : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_venda_pedido_item_entrega", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteServicoEntrega(ByVal iCodigoPedidoItem As Integer)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
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
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Pedido Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoPedidoItem

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_venda_pedido_item_entrega", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

#Region "::: PAGAMENTO :::"

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

    Public Sub InsertPagamento(ByVal iCodigoBancoConta As Integer, _
                               ByVal iCodigoTipoDocumentoPagamento As Integer, _
                               ByVal sNumeroDocumento As String, _
                               ByVal sDataPagamento As String, _
                               ByVal dValor As Double, _
                               ByVal sBanco As String, _
                               ByVal sFavorecido As String, _
                               ByVal bPreDatado As Boolean, _
                               ByVal sDataPreDatado As String, _
                               ByVal sEmitente As String)

        'Variaveis Locais
        Dim oSqlParameter(11) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Pedido Capa
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

            'Seta Parametros - Nº Documento
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
            oSqlParameter(i).Value = IIf(IsDate(sDataPagamento), sDataPagamento, DBNull.Value) : i += 1

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
            oSqlParameter(i).Value = bPreDatado : i += 1

            'Seta Parametros - Data Pré Datado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_pre_datado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataPreDatado), sDataPreDatado, DBNull.Value) : i += 1

            'Seta Parametros - Emitente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "emitente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(sEmitente = "", DBNull.Value, sEmitente)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_venda_pedido_pagamento", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdatePagamento(ByVal iCodigo As Integer, _
                               ByVal iCodigoBancoConta As Integer, _
                               ByVal iCodigoTipoDocumentoPagamento As Integer, _
                               ByVal sNumeroDocumento As String, _
                               ByVal sDataPagamento As String, _
                               ByVal dValor As Double, _
                               ByVal sBanco As String, _
                               ByVal sFavorecido As String, _
                               ByVal bPreDatado As Boolean, _
                               ByVal sDataPreDatado As String, _
                               ByVal sEmitente As String)

        'Variaveis Locais
        Dim oSqlParameter(12) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Pedido Capa
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

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigo : i += 1

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

            'Seta Parametros - Nº Documento
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
            oSqlParameter(i).Value = IIf(IsDate(sDataPagamento), sDataPagamento, DBNull.Value) : i += 1

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
            oSqlParameter(i).Value = bPreDatado : i += 1

            'Seta Parametros - Data Pre Datado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_pre_datado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataPreDatado), sDataPreDatado, DBNull.Value) : i += 1

            'Seta Parametros - Emitente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "emitente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = IIf(sEmitente = "", DBNull.Value, sEmitente)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_venda_pedido_pagamento", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeletePagamento()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer
        Dim oRow As GridEXRow

        Try

            For Each oRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Pedido Capa
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

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_venda_pedido_pagamento", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridPagamento(ByVal oGrid As GridEX, _
                                 ByVal lCodigoPedido As Long)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0
        Dim oDataSet As DataSet

        Try

            'Seta Parametros - Código Pedido Capa
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
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_pedido_pagamento", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName
            oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: PICKING :::"

    Public Sub InsertPicking(ByVal lCodigoPedido As Long)

        Try

            Dim i As Integer = 0
            Dim oSqlParameter(1) As SqlParameter

            'Seta Parametros - Código Pedido Capa
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
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_venda_pedido_picking", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: DADOS DE TERCEIROS :::"

    Public Sub SalvarDadosTerceiros(ByVal lCodigoPedido As Long, _
                                    ByVal sPlanta As String, _
                                    ByVal sPO As String, _
                                    ByVal sPOLinha As String, _
                                    ByVal sREF As String, _
                                    ByVal sCemb As String, _
                                    ByVal sAtivoFixo As String, _
                                    ByVal sNS As String, _
                                    ByVal sEspecificador As String, _
                                    ByVal sRCItem As String, _
                                    ByVal sOMItem As String, _
                                    ByVal lCodigo As Long)

        Try

            Dim i As Integer = 0
            Dim oSqlParameter(12) As SqlParameter

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "po_planta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sPlanta : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "po_numero"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sPO : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "po_numero_linha"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sPOLinha : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "po_ref"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sREF : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "po_cemb"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCemb : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "po_ativo_fixo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sAtivoFixo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "po_ns"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNS : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "po_especificador"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sEspecificador : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "rc_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sRCItem : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "om_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sOMItem : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_venda_pedido_dados_terceiros", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub SalvarDadosTerceirosServico(ByVal lCodigoPedido As Long, _
                                           ByVal sPlanta As String, _
                                           ByVal sPO As String, _
                                           ByVal sPOLinha As String, _
                                           ByVal sREF As String, _
                                           ByVal sCemb As String, _
                                           ByVal sAtivoFixo As String, _
                                           ByVal sNS As String, _
                                           ByVal sEspecificador As String)

        Try

            Dim i As Integer = 0
            Dim oSqlParameter(10) As SqlParameter

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "po_planta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sPlanta : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "po_numero"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sPO : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "po_numero_linha"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sPOLinha : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "po_ref"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sREF : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "po_cemb"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCemb : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "po_ativo_fixo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sAtivoFixo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "po_ns"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNS : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "po_especificador"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sEspecificador : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_venda_pedido_dados_terceiros", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


#End Region

#Region "::: PROJETO ::: "

    Public Sub AtualizarHistoricoProjeto(ByVal lCodigoPedido As Long, _
                                         ByVal iCodigoPedidoItem As Integer, _
                                         ByVal sObservacao As String)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoPedidoItem : i += 1

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sObservacao : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Codigo Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_venda_pedido_item_historico_projeto", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class

