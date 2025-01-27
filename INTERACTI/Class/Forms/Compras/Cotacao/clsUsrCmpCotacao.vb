Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls
Imports Janus.Windows.CalendarCombo
Imports System.IO

Public Class clsUsrCmpCotacao

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private lNumeroCotacao As Long
    Private lCotacaoFornecedorCapa As Long
    Private lFornecedor As Long
    Private iCondicaoPagamento As Integer
    Private iFormaPagamento As Integer
    Private sPrazoResposta As String
    Private sValidadeOrcamento As String
    Private iTipoFrete As Integer
    Private dValorFrete As Double
    Private lTransportadora As Long
    Private iMoeda As Integer
    Private iModalidadeTransporte As Integer
    Private iIncoterms As Integer
    Private iCertificadoImportacao As Integer
    Private sObservacao As String
    Private lCotacaoFornecedorLinha As Long
    Private lCotacaoCapa As Long
    Private lCotacaoLinha As Long
    Private lAgenteLogistico As Long
    Private iInstrucaoEmbarque As Integer
    Private sObservacaoAprovacao As String
    Private sQuotationNumber As String

    Private iCondicaoAprovacao As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property CondicaoAprovacao() As Integer
        Get
            Return iCondicaoAprovacao
        End Get
        Set(ByVal value As Integer)
            iCondicaoAprovacao = value
        End Set
    End Property

    Public Property ObservacaoAprovacao() As String
        Get
            Return sObservacaoAprovacao
        End Get
        Set(ByVal value As String)
            sObservacaoAprovacao = value
        End Set
    End Property

    Public Property CotacaoFornecedorCapa() As Long
        Get
            Return lCotacaoFornecedorCapa
        End Get
        Set(ByVal value As Long)
            lCotacaoFornecedorCapa = value
        End Set
    End Property

    Public Property AgenteLogistico() As Long
        Get
            Return lAgenteLogistico
        End Get
        Set(ByVal value As Long)
            lAgenteLogistico = value
        End Set
    End Property

    Public Property InstrucaoEmbarque() As Integer
        Get
            Return iInstrucaoEmbarque
        End Get
        Set(ByVal value As Integer)
            iInstrucaoEmbarque = value
        End Set
    End Property

    Public Property CotacaoFornecedorLinha() As Long
        Get
            Return lCotacaoFornecedorLinha
        End Get
        Set(ByVal value As Long)
            lCotacaoFornecedorLinha = value
        End Set
    End Property

    Public Property CotacaoCapa() As Long
        Get
            Return lCotacaoCapa
        End Get
        Set(ByVal value As Long)
            lCotacaoCapa = value
        End Set
    End Property

    Public Property CotacaoLinha() As Long
        Get
            Return lCotacaoLinha
        End Get
        Set(ByVal value As Long)
            lCotacaoLinha = value
        End Set
    End Property

    Public Property NumeroCotacao() As Long
        Get
            Return lNumeroCotacao
        End Get
        Set(ByVal value As Long)
            lNumeroCotacao = value
        End Set
    End Property

    Public Property Fornecedor() As Long
        Get
            Return lFornecedor
        End Get
        Set(ByVal value As Long)
            lFornecedor = value
        End Set
    End Property

    Public Property CondicaoPagamento() As Integer
        Get
            Return iCondicaoPagamento
        End Get
        Set(ByVal value As Integer)
            iCondicaoPagamento = value
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

    Public Property PrazoResposta() As String
        Get
            Return sPrazoResposta
        End Get
        Set(ByVal value As String)
            sPrazoResposta = value
        End Set
    End Property

    Public Property ValidadeOrcamento() As String
        Get
            Return sValidadeOrcamento
        End Get
        Set(ByVal value As String)
            sValidadeOrcamento = value
        End Set
    End Property

    Public Property TipoFrete() As Integer
        Get
            Return iTipoFrete
        End Get
        Set(ByVal value As Integer)
            iTipoFrete = value
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

    Public Property Transportadora() As Long
        Get
            Return lTransportadora
        End Get
        Set(ByVal value As Long)
            lTransportadora = value
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

    Public Property ModalidadeTransporte() As Integer
        Get
            Return iModalidadeTransporte
        End Get
        Set(ByVal value As Integer)
            iModalidadeTransporte = value
        End Set
    End Property

    Public Property Incoterms() As Integer
        Get
            Return iIncoterms
        End Get
        Set(ByVal value As Integer)
            iIncoterms = value
        End Set
    End Property

    Public Property CertificadoImportacao() As Integer
        Get
            Return iCertificadoImportacao
        End Get
        Set(ByVal value As Integer)
            iCertificadoImportacao = value
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

    Public Property QuotationNumber() As String
        Get
            Return sQuotationNumber
        End Get
        Set(ByVal value As String)
            sQuotationNumber = value
        End Set
    End Property

#End Region

#Region "::: STRUCTURE :::"

    'Estrutura
    Private Structure Vencedor
        Public sFornecedor As String
        Public dValor As Double
        Public lCodigoCotacao As Long
        Public iCodigoCotacaoFornecedor As Integer
    End Structure

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: COTAÇÃO :::"

    Public Sub UpdateReferencia(ByVal lCodigoCotacao As Long,
                                ByVal icodigoCotacaoItem As Integer,
                                ByVal sReferencia As String)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCotacao : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = icodigoCotacaoItem : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "referencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = IIf(sReferencia = "", DBNull.Value, sReferencia) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_compras_cotacao_item_referencia", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridCotacao(ByVal oGrid As GridEX,
                               ByVal lNumeroCotacao As Long,
                               ByVal lNumeroRequisicao As Long,
                               ByVal sStatus As String,
                               ByVal sDataCotacaoInicio As String,
                               ByVal sDataCotacaoTermino As String,
                               ByVal sItem As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(6) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Número da Cotação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_cotacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lNumeroCotacao : i += 1

            'Seta Parametros - Número de Requisição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_requisicao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lNumeroRequisicao : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sStatus : i += 1

            'Seta Parametros - Data da Cotação Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio_cotacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataCotacaoInicio = "", DBNull.Value, sDataCotacaoInicio) : i += 1

            'Seta Parametros - Data da Cotação Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino_cotacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataCotacaoTermino = "", DBNull.Value, sDataCotacaoTermino) : i += 1

            'Seta Parametros - Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sItem : i += 1

            'Seta Parametros - Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_cotacao", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Preenche Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertCotacao(ByRef lCodigoCotacao As Long)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
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
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_compras_cotacao", oSqlParameter)

            'Seta Retorno da Função
            lCodigoCotacao = oSqlParameter(2).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertCotacaoItem(ByVal lCodigoCotacao As Long)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                i = 0

                'Seta Parametros - Código Requisição
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_requisicao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo_requisicao").Value : i += 1

                'Seta Parametros - Código Requisição Item
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_requisicao_item"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo_requisicao_item").Value : i += 1

                'Seta Parametros - Código da Cotação
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_cotacao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoCotacao : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_compras_cotacao_item", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertCotacaoItem(ByVal lCodigoCotacao As Long,
                                 ByVal lCodigoRequisicao As Long,
                                 ByVal iCodigoRequisicaoItem As Integer)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Requisição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_requisicao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoRequisicao : i += 1

            'Seta Parametros - Código Requisição Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_requisicao_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoRequisicaoItem : i += 1

            'Seta Parametros - Código da Cotação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCotacao : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_compras_cotacao_item", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertCotacaoAcordoComercial(ByVal lCodigoCotacao As Long)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Código da Cotação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCotacao : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_compras_cotacao_acordo_comercial", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub AlterarStatusCotacaoItem(ByVal lCodigoCotacao As Long,
                                        ByVal iCodigoCotacaoItem As Integer,
                                        ByVal sHistorico As String,
                                        ByVal iStatus As Integer)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Histórico
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "historico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sHistorico : i += 1

            'Seta Parametros - Código Cotação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCotacao : i += 1

            'Seta Parametros - Código Cotação Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoCotacaoItem : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iStatus : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_compras_cotacao_item_status", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosCotacao(ByVal lCodigoCotacao As Long,
                                ByVal txtData As MaskedEditBox,
                                ByVal txtDescritivo As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Cotação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCotacao

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_dados_cotacao", oSqlParameter)

            'Verifica se foi encontrado algum Registro
            If oSqlDataReader.HasRows = True Then

                While oSqlDataReader.Read
                    'Carrega Controles
                    txtData.Text = oSqlDataReader.Item("data_cotacao")
                    txtDescritivo.Text = oSqlDataReader.Item("descritivo")



                End While

            Else
                'Limpa Controles
                txtData.Text = ""
                txtDescritivo.Text = ""
            End If

            'Fecha o SQLDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosCotacaoFornecedor(ByVal lCodigoCotacao As Long,
                                ByVal txtData As MaskedEditBox,
                                ByVal txtDescritivo As MaskedEditBox,
                                ByVal cboCondicaoPagamento As UIComboBox,
                                ByVal cboModalidadeFrete As UIComboBox)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Cotação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCotacao

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_dados_cotacao", oSqlParameter)

            'Verifica se foi encontrado algum Registro
            If oSqlDataReader.HasRows = True Then

                While oSqlDataReader.Read
                    'Carrega Controles
                    txtData.Text = oSqlDataReader.Item("data_cotacao")
                    txtDescritivo.Text = oSqlDataReader.Item("descritivo")

                    If Not IsDBNull(oSqlDataReader.Item("codigo_condicao_pagamento")) Then
                        cboCondicaoPagamento.SelectedValue = oSqlDataReader.Item("codigo_condicao_pagamento")
                    End If
                    If Not IsDBNull(oSqlDataReader.Item("codigo_modalidade_frete")) Then
                        cboModalidadeFrete.SelectedValue = oSqlDataReader.Item("codigo_modalidade_frete")
                    End If
                End While

            Else
                'Limpa Controles
                txtData.Text = ""
                txtDescritivo.Text = ""
            End If

            'Fecha o SQLDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosCotacao(ByVal lCodigoCotacao As Long,
                                ByVal txtData As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Cotação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCotacao

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_dados_cotacao", oSqlParameter)

            'Verifica se foi encontrado algum Registro
            If oSqlDataReader.HasRows = True Then

                While oSqlDataReader.Read
                    'Carrega Controles
                    txtData.Text = oSqlDataReader.Item("data_cotacao")
                End While

            Else
                'Limpa Controles
                txtData.Text = ""
            End If

            'Fecha o SQLDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: FORNECEDOR :::"

    Public Sub LoadGridCotacaoFornecedor(ByVal oGrid As GridEX,
                                         ByVal lCodigoCotacao As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código da Cotação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCotacao : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_cotacao_fornecedor", oSqlParameter)

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

    Public Sub LoadGridCotacaoProdutos(ByVal oGrid As GridEX,
                                       ByVal lCodigoCotacao As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código da Cotação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCotacao : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_cotacao_fornecedor_item", oSqlParameter)

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

    Public Sub DeleteCotacaoFornecedor()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim j, i As Integer

        Try

            For j = 0 To UBound(gSelecaoRow)

                i = 0

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Código Cotação
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_cotacao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = gSelecaoRow(j).Cells("codigo_cotacao").Value : i += 1

                'Seta Parametros - Código Cotação Fornecedor
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = gSelecaoRow(j).Cells("codigo_cotacao_fornecedor").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_compras_cotacao_fornecedor", oSqlParameter)

                'Exclui Linha da Grid
                gSelecaoRow(j).Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertCotacaoFornecedor(ByVal lCodigoCotacao As Long,
                                       ByVal sDescritivo As String,
                                       ByVal lCodigoFornecedor As Long,
                                       ByVal sDataPrazoResposta As String,
                                       ByVal sObservacao As String)

        'Variaveis Locais
        Dim oSqlParameter(6) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código Cotação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCotacao : i += 1

            'Seta Parametros - Descritivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descritivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescritivo : i += 1

            'Seta Parametros - Código Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = lCodigoFornecedor : i += 1

            'Seta Parametros - Data Prazo Resposta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_prazo_resposta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataPrazoResposta) = False, DBNull.Value, sDataPrazoResposta) : i += 1

            'Seta Parametros - Observação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = IIf(sObservacao = "", DBNull.Value, sObservacao)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_compras_cotacao_fornecedor", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateCotacaoFornecedor(ByVal lCodigoCotacao As Long,
                                       ByVal iCodigoCotacaoFornecedor As Integer,
                                       ByVal lCodigoFornecedor As Long,
                                       ByVal sDataPrazoResposta As String,
                                       ByVal sObservacao As String)

        'Variaveis Locais
        Dim oSqlParameter(6) As SqlParameter
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

            'Seta Parametros - Código Cotação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCotacao : i += 1

            'Seta Parametros - Código Cotação Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoCotacaoFornecedor : i += 1

            'Seta Parametros - Código Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoFornecedor : i += 1

            'Seta Parametros - Data Prazo Resposta
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_prazo_resposta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataPrazoResposta) = False, DBNull.Value, sDataPrazoResposta) : i += 1

            'Seta Parametros - Observação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = IIf(sObservacao = "", DBNull.Value, sObservacao)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_compras_cotacao_fornecedor", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaCotacaoFornecedor(ByVal lCodigoCotacao As Long,
                                            ByVal lCodigoFornecedor As Long,
                                            ByVal iCodigo As Integer) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0
        Dim iReturn As Integer

        Try

            'Seta Retorno da Função
            ValidaCotacaoFornecedor = False

            'Seta Parametros - Código Cotação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCotacao : i += 1

            'Seta Parametros - Codigo Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoFornecedor : i += 1

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_compras_cotacao_fornecedor", oSqlParameter), Integer)

            'Seta Retorno da Função
            ValidaCotacaoFornecedor = IIf(iReturn > 0, False, True)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub SalvarCondicaoCotacao(ByVal lCodigoCotacao As Long,
                                       ByVal sDescritivo As String,
                                       ByVal iCodigoCondicaoPagamento As Integer,
                                       ByVal iCodigoModalidadeFrete As Integer)

        'Variaveis Locais
        Dim oSqlParameter(6) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código Cotação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCotacao : i += 1

            'Seta Parametros - Descritivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descritivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescritivo : i += 1

            'Seta Parametros - Código Modalidade Frete
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modalidade_frete"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoModalidadeFrete = -1, DBNull.Value, iCodigoModalidadeFrete) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_condicao_pagamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoCondicaoPagamento = -1, DBNull.Value, iCodigoCondicaoPagamento) : i += 1


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_compras_cotacao_condicao_cotacao", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: ORÇAMENTO :::"

    Public Sub LoadGridCotacaoFornecedorOrcamentoItem(ByVal oGrid As GridEX, _
                                                      ByVal iTipoItem As TipoItem, _
                                                      ByVal lCodigoCotacao As Long, _
                                                      ByVal iCodigoCotacaoFornecedor As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código da Cotação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCotacao : i += 1

            'Seta Parametros - Código Cotação Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoCotacaoFornecedor : i += 1

            'Seta Parametros - Código Tipo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iTipoItem : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_cotacao_fornecedor_orcamento_item", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosCotacaoFornecedorOrcamento(ByVal lCodigoCotacao As Long, _
                                                   ByVal iCodigoCotacaoFornecedor As Integer, _
                                                   ByVal cboCondicaoPagamento As UIComboBox, _
                                                   ByVal cboFormaPagamento As UIComboBox, _
                                                   ByVal cboMoeda As UIComboBox, _
                                                   ByVal txtFatorCambial As NumericEditBox, _
                                                   ByVal cboModalidadeFrete As UIComboBox, _
                                                   ByVal cboTransportadora As UIComboBox, _
                                                   ByVal txtValorFrete As NumericEditBox, _
                                                   ByVal cboModalidadeTransporte As UIComboBox, _
                                                   ByVal cboIncoterms As UIComboBox, _
                                                   ByVal cboAgenteLogistico As UIComboBox, _
                                                   ByVal txtValorHonorario As NumericEditBox, _
                                                   ByVal txtValorEstimadoCustoImportacao As NumericEditBox, _
                                                   ByVal cboInstrucaoEmbarque As UIComboBox, _
                                                   ByVal dtpDataValidade As CalendarCombo, _
                                                   ByVal txtObservacaoOrcamento As EditBox)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Cotação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCotacao : i += 1

            'Seta Parametros - Código Cotação Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoCotacaoFornecedor : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_cotacao_fornecedor_dados", oSqlParameter)

            If oSqlDataReader.HasRows = False Then

                'Limpa Controles 
                cboCondicaoPagamento.SelectedIndex = -1
                cboFormaPagamento.SelectedIndex = -1
                cboMoeda.SelectedIndex = -1
                txtFatorCambial.Value = 0
                cboModalidadeFrete.SelectedIndex = -1
                cboTransportadora.SelectedIndex = -1
                txtValorFrete.Value = 0
                cboModalidadeTransporte.SelectedIndex = -1
                cboIncoterms.SelectedIndex = -1
                cboAgenteLogistico.SelectedIndex = -1
                txtValorHonorario.Value = 0
                txtValorEstimadoCustoImportacao.Value = 0
                cboInstrucaoEmbarque.SelectedIndex = -1
                dtpDataValidade.Value = Now.Date : dtpDataValidade.Checked = False
                txtObservacaoOrcamento.Text = ""

            Else

                While oSqlDataReader.Read

                    'Carrega Controles 
                    'cboCondicaoPagamento.SelectedValue = oSqlDataReader.Item("codigo_condicao_pagamento")
                    IIf(oSqlDataReader.Item("codigo_condicao_pagamento") = -1, cboCondicaoPagamento.SelectedIndex = -1, cboCondicaoPagamento.SelectedValue = oSqlDataReader.Item("codigo_condicao_pagamento"))
                    'cboFormaPagamento.SelectedValue = oSqlDataReader.Item("codigo_forma_pagamento")
                    IIf(oSqlDataReader.Item("codigo_forma_pagamento") = -1, cboFormaPagamento.SelectedIndex = -1, cboFormaPagamento.SelectedValue = oSqlDataReader.Item("codigo_forma_pagamento"))
                    'cboMoeda.SelectedValue = oSqlDataReader.Item("codigo_moeda")
                    IIf(oSqlDataReader.Item("codigo_moeda") = -1, cboMoeda.SelectedIndex = -1, cboMoeda.SelectedValue = oSqlDataReader.Item("codigo_moeda"))
                    txtFatorCambial.Value = oSqlDataReader.Item("fator_cambial")
                    'cboModalidadeFrete.SelectedValue = oSqlDataReader.Item("codigo_modalidade_frete")
                    IIf(oSqlDataReader.Item("codigo_modalidade_frete") = -1, cboModalidadeFrete.SelectedIndex = -1, cboModalidadeFrete.SelectedValue = oSqlDataReader.Item("codigo_modalidade_frete"))
                    'cboTransportadora.SelectedValue = oSqlDataReader.Item("codigo_transportadora")
                    IIf(oSqlDataReader.Item("codigo_transportadora") = -1, cboTransportadora.SelectedIndex = -1, cboTransportadora.SelectedValue = oSqlDataReader.Item("codigo_transportadora"))
                    txtValorFrete.Value = oSqlDataReader.Item("valor_frete")
                    'cboModalidadeTransporte.SelectedValue = oSqlDataReader.Item("codigo_modalidade_transporte")
                    IIf(oSqlDataReader.Item("codigo_modalidade_transporte") = -1, cboModalidadeTransporte.SelectedIndex = -1, cboModalidadeTransporte.SelectedValue = oSqlDataReader.Item("codigo_modalidade_transporte"))
                    cboIncoterms.SelectedValue = oSqlDataReader.Item("codigo_incoterms")
                    cboAgenteLogistico.SelectedValue = oSqlDataReader.Item("codigo_agente_logistico")
                    txtValorHonorario.Value = oSqlDataReader.Item("valor_honorario")
                    txtValorEstimadoCustoImportacao.Value = oSqlDataReader.Item("valor_estimado_custo_importacao")
                    cboInstrucaoEmbarque.SelectedValue = oSqlDataReader.Item("codigo_instrucao_embarque")
                    If IsDBNull(oSqlDataReader.Item("data_validade")) Then
                        dtpDataValidade.Value = Now.Date : dtpDataValidade.Checked = False
                    Else
                        dtpDataValidade.Value = oSqlDataReader.Item("data_validade") : dtpDataValidade.Checked = True
                    End If
                    txtObservacaoOrcamento.Text = oSqlDataReader.Item("observacao_orcamento")

                End While

            End If

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateCotacaoFornecedorOrcamento(ByVal lCodigoCotacao As Long, _
                                                ByVal sDescritivo As String, _
                                                ByVal iCodigoCotacaoFornecedor As Integer, _
                                                ByVal iCodigoCondicaoPagamento As Integer, _
                                                ByVal iCodigoFormaPagamento As Integer, _
                                                ByVal iCodigoMoeda As Integer, _
                                                ByVal dFatorCambial As Double, _
                                                ByVal iCodigoModalidadeFrete As Integer, _
                                                ByVal iCodigoTransportadora As Integer, _
                                                ByVal dValorFrete As Double, _
                                                ByVal iCodigoModalidadeTransporte As Integer, _
                                                ByVal iCodigoIncoterms As Integer, _
                                                ByVal iCodigoAgenteLogistico As Integer, _
                                                ByVal dValorHonorario As Double, _
                                                ByVal dValorEstimadoCustoImportacao As Double, _
                                                ByVal iCodigoInstrucaoEmbarque As Integer, _
                                                ByVal sDataValidade As String, _
                                                ByVal sObservacaoOrcamento As String)

        'Variaveis Locais
        Dim oSqlParameter(19) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Cotação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCotacao : i += 1

            'Seta Parametros - Descritivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descritivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescritivo : i += 1

            'Seta Parametros - Código Cotação Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoCotacaoFornecedor : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Condição de Pagamento
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

            'Seta Parametros - Código Moeda
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

            'Seta Parametros - Código Modalidade de Frete
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modalidade_frete"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoModalidadeFrete = -1, DBNull.Value, iCodigoModalidadeFrete) : i += 1

            'Seta Parametros - Código Transportadora
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_transportadora"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoTransportadora = -1, DBNull.Value, iCodigoTransportadora) : i += 1

            'Seta Parametros - Valor do Frete
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_frete"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorFrete : i += 1

            'Seta Parametros - Código Modalidade de Transporte
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modalidade_transporte"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoModalidadeTransporte = -1, DBNull.Value, iCodigoModalidadeTransporte) : i += 1

            'Seta Parametros - Código Incoterms
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_incoterms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoIncoterms = -1, DBNull.Value, iCodigoIncoterms) : i += 1

            'Seta Parametros - Código Agente Logístico
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_agente_logistico"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoAgenteLogistico = -1, DBNull.Value, iCodigoAgenteLogistico) : i += 1

            'Seta Parametros - Valor do Honorários
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_honorario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorHonorario : i += 1

            'Seta Parametros - Valor Estimado de Importação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_estimado_custo_importacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorEstimadoCustoImportacao : i += 1

            'Seta Parametros - Código Instrução de Embarque
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_instrucao_embarque"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoInstrucaoEmbarque = -1, DBNull.Value, iCodigoInstrucaoEmbarque) : i += 1

            'Seta Parametros - Data de Validade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_validade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataValidade) = False, DBNull.Value, sDataValidade) : i += 1

            'Seta Parametros - Observação - Orçamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao_orcamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5000
            oSqlParameter(i).Value = IIf(sObservacaoOrcamento = "", DBNull.Value, sObservacaoOrcamento) : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_compras_cotacao_fornecedor_orcamento", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateCotacaoFornecedorOrcamentoItem(ByVal sMarca As String, _
                                                    ByVal dValorUnitario As Double, _
                                                    ByVal bIPIIncluso As Boolean, _
                                                    ByVal bICMSIncluso As Boolean, _
                                                    ByVal dAliquotaIPI As Double, _
                                                    ByVal dAliquotaICMS As Double, _
                                                    ByVal dDescontoValor As Double, _
                                                    ByVal dDescontoPercentual As Double, _
                                                    ByVal sDataPrevisaoEntrega() As String, _
                                                    ByVal sQuantidadeEntrega() As String, _
                                                    ByVal lCodigoCotacao As Long, _
                                                    ByVal iCodigoCotacaoItem As Integer, _
                                                    ByVal iCodigoCotacaoFornecedor As Integer)

        'Variaveis Locais
        Dim oSqlParameter(11) As SqlParameter
        Dim i As Integer = 0
        Dim j As Integer

        Try

            'Seta Parametros - Marca
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "marca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sMarca : i += 1

            'Seta Parametros - Valor Unitário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_unitario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorUnitario : i += 1

            'Seta Parametros - IPI Incluso
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ipi_incluso"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bIPIIncluso : i += 1

            'Seta Parametros - ICMS Incluso
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "icms_incluso"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bICMSIncluso : i += 1

            'Seta Parametros - Alíquota IPI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaIPI : i += 1

            'Seta Parametros - Alíquota ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaICMS : i += 1

            'Seta Parametros - Desconto Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desconto_valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDescontoValor : i += 1

            'Seta Parametros - Desconto %
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desconto_percentual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDescontoPercentual : i += 1

            'Seta Parametros - Código Cotação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCotacao : i += 1

            'Seta Parametros - Código Cotação Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoCotacaoItem : i += 1

            'Seta Parametros - Código Cotação Fornecedor 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoCotacaoFornecedor : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_compras_cotacao_fornecedor_item", oSqlParameter)

            'Exclui Registro da tb_cmp_cotacao_fornecedor_item_entrega
            Call DeleteCotacaoFornecedorOrcamentoItemEntrega(lCodigoCotacao, _
                                                             iCodigoCotacaoItem, _
                                                             iCodigoCotacaoFornecedor)

            'Insere Previsões de Entrega
            For j = 0 To UBound(sDataPrevisaoEntrega)
                'Insere Previsão de Entrega
                Call InsertCotacaoFornecedorOrcamentoItemEntrega(lCodigoCotacao, _
                                                                 iCodigoCotacaoItem, _
                                                                 iCodigoCotacaoFornecedor, _
                                                                 sDataPrevisaoEntrega(j), _
                                                                 sQuantidadeEntrega(j))
            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateCotacaoFornecedorOrcamentoItem(ByVal dValorUnitario As Double, _
                                                    ByVal bISSRetido As Boolean, _
                                                    ByVal dAliquotaISS As Double, _
                                                    ByVal dDescontoValor As Double, _
                                                    ByVal dDescontoPercentual As Double, _
                                                    ByVal sDataPrevisaoEntrega() As String, _
                                                    ByVal sQuantidadeEntrega() As String, _
                                                    ByVal lCodigoCotacao As Long, _
                                                    ByVal iCodigoCotacaoItem As Integer, _
                                                    ByVal iCodigoCotacaoFornecedor As Integer)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0
        Dim j As Integer

        Try

            'Seta Parametros - Valor Unitário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_unitario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorUnitario : i += 1

            'Seta Parametros - ISS Retido
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

            'Seta Parametros - Desconto Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desconto_valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDescontoValor : i += 1

            'Seta Parametros - Desconto %
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desconto_percentual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDescontoPercentual : i += 1

            'Seta Parametros - Código Cotação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCotacao : i += 1

            'Seta Parametros - Código Cotação Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoCotacaoItem : i += 1

            'Seta Parametros - Código Cotação Fornecedor 
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoCotacaoFornecedor : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_compras_cotacao_fornecedor_item", oSqlParameter)

            'Exclui Registro da tb_cmp_cotacao_fornecedor_item_entrega
            Call DeleteCotacaoFornecedorOrcamentoItemEntrega(lCodigoCotacao, _
                                                             iCodigoCotacaoItem, _
                                                             iCodigoCotacaoFornecedor)

            'Insere Previsões de Entrega
            For j = 0 To UBound(sDataPrevisaoEntrega)
                'Insere Previsão de Entrega
                Call InsertCotacaoFornecedorOrcamentoItemEntrega(lCodigoCotacao, _
                                                                 iCodigoCotacaoItem, _
                                                                 iCodigoCotacaoFornecedor, _
                                                                 sDataPrevisaoEntrega(j), _
                                                                 sQuantidadeEntrega(j))
            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteCotacaoFornecedorOrcamentoItemEntrega(ByVal lCodigoCotacao As Long, _
                                                           ByVal iCodigoCotacaoItem As Integer, _
                                                           ByVal iCodigoCotacaoFornecedor As Integer)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Cotação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCotacao : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Cotação Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoCotacaoItem : i += 1

            'Seta Parametros - Código Cotação Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoCotacaoFornecedor

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_compras_cotacao_fornecedor_item_entrega", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertCotacaoFornecedorOrcamentoItemEntrega(ByVal lCodigoCotacao As Long, _
                                                           ByVal iCodigoCotacaoItem As Integer, _
                                                           ByVal iCodigoCotacaoFornecedor As Integer, _
                                                           ByVal sDataPrevisaoEntrega As String, _
                                                           ByVal dQuantidade As Double)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Cotação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCotacao : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Cotação Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoCotacaoItem : i += 1

            'Seta Parametros - Código Cotação Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoCotacaoFornecedor : i += 1

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
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_compras_cotacao_fornecedor_item_entrega", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosCotacaoFornecedorOrcamento(ByVal lCodigoCotacao As Long,
                                                   ByVal iCodigoCotacaoFornecedor As Integer,
                                                   ByRef dValorHonorario As Double,
                                                   ByRef dValorEstimadoCustoImportacao As Double,
                                                   ByRef dValorFrete As Double,
                                                   ByRef dValorDesconto As Double,
                                                   ByRef iCodigoModalidadeFrete As Integer,
                                                   ByRef iCodigoTransportadora As Integer,
                                                   ByRef iCodigoCondicaoPgamento As Integer,
                                                   ByRef iCodigoFormaPagamento As Integer,
                                                   ByRef iCodigoMoeda As Integer,
                                                   ByRef dFatorCambial As Double)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Cotação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCotacao : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Cotação Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoCotacaoFornecedor

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_cotacao_fornecedor_dados ", oSqlParameter)

            If oSqlDataReader.HasRows Then
                'Carrega Váriaveis
                While oSqlDataReader.Read
                    dValorHonorario = oSqlDataReader.Item("valor_honorario")
                    dValorEstimadoCustoImportacao = oSqlDataReader.Item("valor_estimado_custo_importacao")
                    dValorFrete = oSqlDataReader.Item("valor_frete")
                    dValorDesconto = oSqlDataReader.Item("valor_desconto")

                    iCodigoModalidadeFrete = oSqlDataReader.Item("codigo_modalidade_frete")
                    iCodigoTransportadora = oSqlDataReader.Item("codigo_transportadora")
                    iCodigoCondicaoPgamento = oSqlDataReader.Item("codigo_condicao_pagamento")
                    iCodigoFormaPagamento = oSqlDataReader.Item("codigo_forma_pagamento")
                    iCodigoMoeda = oSqlDataReader.Item("codigo_moeda")
                    dFatorCambial = oSqlDataReader.Item("fator_cambial")

                End While
            Else
                'Limpa Váriaveis
                dValorFrete = 0
                dValorDesconto = 0
            End If

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridHistoricoOrcamento(ByVal oGrid As GridEX, _
                                          ByVal lCodigoItem As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_cotacao_fornecedor_orcamento_historico", oSqlParameter)

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

#Region "::: APROVAÇÃO :::"

    Public Sub LoadGridCotacaoAprovacao(ByVal oGrid As GridEX, _
                                        ByVal lCodigoCotacao As Long, _
                                        Optional ByVal iCodigoFormaAnaliseOrcamento As Integer = 0)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código da Cotação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCotacao : i += 1

            'Seta Parametros - Código Forma de Analise do Orçamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_forma_analise_orcamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoFormaAnaliseOrcamento : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_cotacao_fornecedor_orcamento_aprovacao", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

            'Seta Seleção
            For Each oRow In oGrid.GetDataRows
                If oRow.Cells("selecionado").Value = True Then
                    oRow.CheckState = RowCheckState.Checked
                End If
            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridFreteAprovacao(ByVal oGrid As GridEX, _
                                      ByVal lCodigoCotacao As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código da Cotação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCotacao : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_cotacao_fornecedor_frete_aprovacao", oSqlParameter)

            'Configurar Datamember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridVencedorAprovacao(ByVal oGrid As GridEX, _
                                         ByVal oRowAprovacao() As GridEXRow)

        Try

            'Váriaveis Locais            
            Dim oVencedor As New Vencedor
            Dim oListaVencedores As New Hashtable
            Dim i As Integer

            For i = 0 To UBound(oRowAprovacao)
                If oListaVencedores.Contains(oRowAprovacao(i).Cells("fornecedor").Value) Then
                    oVencedor = oListaVencedores(oRowAprovacao(i).Cells("fornecedor").Value)
                    oVencedor.dValor = oVencedor.dValor + oRowAprovacao(i).Cells("valor_total_compra").Value
                Else
                    oVencedor.dValor = oRowAprovacao(i).Cells("valor_total_compra").Value
                    oVencedor.sFornecedor = oRowAprovacao(i).Cells("fornecedor").Value
                    oVencedor.iCodigoCotacaoFornecedor = oRowAprovacao(i).Cells("codigo_cotacao_fornecedor").Value
                    oVencedor.lCodigoCotacao = oRowAprovacao(i).Cells("codigo_cotacao").Value
                End If
                oListaVencedores.Remove(oRowAprovacao(i).Cells("fornecedor").Value)
                oListaVencedores.Add(oRowAprovacao(i).Cells("fornecedor").Value, oVencedor)
            Next

            'Váriaveis - Grid
            Dim oDataSet As New DataSet
            Dim oDataTable As New DataTable
            Dim oDataRow As DataRow

            'Cria DataTable
            oDataTable = oDataSet.Tables.Add("vencedores")

            'Cria DataColumn
            Dim oDataColumnFornecedor As New DataColumn("fornecedor", GetType(String))
            Dim oDataColumnValorPedido As New DataColumn("valor_pedido", GetType(Double))
            Dim oDataColumnValorHonorario As New DataColumn("valor_honorario", GetType(Double))
            Dim oDataColumnValorImportacao As New DataColumn("valor_estimado_custo_importacao", GetType(Double))
            Dim oDataColumnValorFrete As New DataColumn("valor_frete", GetType(Double))
            Dim oDataColumnValorDesconto As New DataColumn("valor_desconto", GetType(Double))
            Dim oDataColumnPercentualDesconto As New DataColumn("percentual_desconto", GetType(Double))
            Dim oDataColumnValorFinal As New DataColumn("valor_final", GetType(Double))
            Dim oDataColumnCodigoCotacao As New DataColumn("codigo_cotacao", GetType(Long))
            Dim oDataColumnCodigoCotacaoFornecedor As New DataColumn("codigo_cotacao_fornecedor", GetType(Integer))

            Dim oDataColumnCodigoModalidadeFrete As New DataColumn("codigo_modalidade_frete", GetType(Integer))
            Dim oDataColumnCodigoTransportadora As New DataColumn("codigo_transportadora", GetType(Integer))
            Dim oDataColumnCodigoCondicaoPagamento As New DataColumn("codigo_condicao_pagamento", GetType(Integer))
            Dim oDataColumnCodigoFormaPagamento As New DataColumn("codigo_forma_pagamento", GetType(Integer))
            Dim oDataColumnCodigoMoeda As New DataColumn("codigo_moeda", GetType(Integer))
            Dim oDataColumnFatorCambial As New DataColumn("fator_cambial", GetType(Integer))
            Dim oDataColumnDescritivo As New DataColumn("descritivo", GetType(String))



            'Adiciona DataColumn ao DataTable
            oDataTable.Columns.Add(oDataColumnFornecedor)
            oDataTable.Columns.Add(oDataColumnValorPedido)
            oDataTable.Columns.Add(oDataColumnValorHonorario)
            oDataTable.Columns.Add(oDataColumnValorImportacao)
            oDataTable.Columns.Add(oDataColumnValorFrete)
            oDataTable.Columns.Add(oDataColumnValorDesconto)
            oDataTable.Columns.Add(oDataColumnPercentualDesconto)
            oDataTable.Columns.Add(oDataColumnValorFinal)
            oDataTable.Columns.Add(oDataColumnCodigoCotacao)
            oDataTable.Columns.Add(oDataColumnCodigoCotacaoFornecedor)
            oDataTable.Columns.Add(oDataColumnCodigoModalidadeFrete)
            oDataTable.Columns.Add(oDataColumnCodigoTransportadora)
            oDataTable.Columns.Add(oDataColumnCodigoCondicaoPagamento)
            oDataTable.Columns.Add(oDataColumnCodigoFormaPagamento)
            oDataTable.Columns.Add(oDataColumnCodigoMoeda)
            oDataTable.Columns.Add(oDataColumnFatorCambial)
            oDataTable.Columns.Add(oDataColumnDescritivo)


            'Váriaveis Locais
            Dim dValorFrete As Double = 0
            Dim dValorHonorario As Double = 0
            Dim dValorEstimadoCustoImportacao As Double = 0
            Dim dValorDesconto As Double = 0
            Dim dPercentualDesconto As Double = 0

            Dim iCodigoModalidadeFrete As Integer = -1
            Dim iCodigoTransportadora As Integer = -1
            Dim iCodigoCondicaoPgamento As Integer = -1
            Dim iCodigoFormaPagamento As Integer = -1
            Dim iCodigoMoeda As Integer = -1
            Dim dFatorCambial As Double = -1

            'Percorre Lista de Vencedores
            For Each oVencedor In oListaVencedores.Values

                'Carrega Dados da tb_cmp_cotacao_fornecedor
                Call LoadDadosCotacaoFornecedorOrcamento(oVencedor.lCodigoCotacao,
                                                         oVencedor.iCodigoCotacaoFornecedor,
                                                         dValorHonorario,
                                                         dValorEstimadoCustoImportacao,
                                                         dValorFrete,
                                                         dValorDesconto,
                                                         iCodigoModalidadeFrete,
                                                         iCodigoTransportadora,
                                                         iCodigoCondicaoPgamento,
                                                         iCodigoFormaPagamento,
                                                         iCodigoMoeda,
                                                         dFatorCambial)

                oDataRow = oDataTable.NewRow()
                oDataRow("fornecedor") = oVencedor.sFornecedor
                oDataRow("valor_pedido") = oVencedor.dValor
                oDataRow("valor_honorario") = dValorHonorario
                oDataRow("valor_estimado_custo_importacao") = dValorEstimadoCustoImportacao
                oDataRow("valor_frete") = dValorFrete
                oDataRow("valor_desconto") = dValorDesconto
                oDataRow("percentual_desconto") = dValorDesconto / oVencedor.dValor * 100
                oDataRow("valor_final") = oVencedor.dValor + dValorFrete - dValorDesconto
                oDataRow("codigo_cotacao") = oVencedor.lCodigoCotacao
                oDataRow("codigo_cotacao_fornecedor") = oVencedor.iCodigoCotacaoFornecedor



                oDataRow("codigo_modalidade_frete") = IIf(iCodigoModalidadeFrete = -1, DBNull.Value, iCodigoModalidadeFrete)
                oDataRow("codigo_transportadora") = IIf(iCodigoTransportadora = -1, DBNull.Value, iCodigoTransportadora)
                oDataRow("codigo_condicao_pagamento") = IIf(iCodigoCondicaoPgamento = -1, DBNull.Value, iCodigoCondicaoPgamento)
                oDataRow("codigo_forma_pagamento") = IIf(iCodigoFormaPagamento = -1, DBNull.Value, iCodigoFormaPagamento)
                oDataRow("codigo_moeda") = IIf(iCodigoMoeda = -1, DBNull.Value, iCodigoMoeda)
                oDataRow("fator_cambial") = IIf(dFatorCambial = -1, DBNull.Value, dFatorCambial)
                oDataRow("descritivo") = ""



                oDataTable.Rows.Add(oDataRow)

            Next

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub AprovarCotacao(ByVal lCodigoCotacao As Long, _
                              ByVal sDescritivo As String, _
                              ByVal sObservacao As String, _
                              ByVal sJustificativa As String, _
                              ByVal oGrid As GridEX)

        Try

            'Variaveis Locais
            Dim oSqlParameter(8) As SqlParameter
            Dim i As Integer = 0

            For Each oRow As GridEXRow In oGrid.GetCheckedRows

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Cotação
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_cotacao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoCotacao : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Código Cotação Fornecedor
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_cotacao_fornecedor"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo_cotacao_fornecedor").Value : i += 1

                'Seta Parametros - Código Cotação Item
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_cotacao_item"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo_cotacao_item").Value : i += 1

                'Seta Parametros - Descritivo
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "descritivo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 100
                oSqlParameter(i).Value = sDescritivo : i += 1

                'Seta Parametros - Observação
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "observacao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 5000
                oSqlParameter(i).Value = IIf(sObservacao = "", DBNull.Value, sObservacao) : i += 1

                'Seta Parametros - Justificativa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "justificativa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Value = sJustificativa : i += 1

                'Seta Parametros - Vencedor
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "vencedor"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Bit
                oSqlParameter(i).Value = IIf(oRow.CheckState = RowCheckState.Checked, 1, 0) : i += 1

                'Seta Parametros - Código Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_usuario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = goUsuario.iUsuario

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_compras_cotacao_fornecedor_item_vencedor", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateCotacaoFornecedorItem(ByVal lCodigoCotacao As Long, _
                                           ByVal iCodigoCotacaoFornecedor As Integer, _
                                           ByVal iCodigoCotacaoItem As Integer, _
                                           ByVal bVencedor As Boolean, _
                                           ByVal sJustificativa As String)

        Try

            'Variaveis Locais
            Dim oSqlParameter(6) As SqlParameter
            Dim i As Integer = 0

            'Seta Parametros - Código Cotação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCotacao : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Cotação Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoCotacaoFornecedor : i += 1

            'Seta Parametros - Código Cotação Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoCotacaoItem : i += 1

            'Seta Parametros - Justificativa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "justificativa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sJustificativa : i += 1

            'Seta Parametros - Vencedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "vencedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bVencedor : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_compras_cotacao_fornecedor_item_vencedor", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ReprovarCompra(ByVal lCodigoCotacao As Long, _
                              ByVal iCodigoCotacaoFornecedor As Integer, _
                              ByVal iCodigoCotacaoItem As Integer, _
                              ByVal lCodigoRequisicao As Long, _
                              ByVal iCodigoRequisicaoItem As Integer, _
                              ByVal sJustificativa As String)

        Try

            'Variaveis Locais
            Dim oSqlParameter(7) As SqlParameter
            Dim i As Integer = 0

            'Seta Parametros - Código Cotação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCotacao : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Cotação Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoCotacaoFornecedor : i += 1

            'Seta Parametros - Código Cotação Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoCotacaoItem : i += 1

            'Seta Parametros - Justificativa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "justificativa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sJustificativa : i += 1

            'Seta Parametros - Código Requisição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_requisicao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoRequisicao : i += 1

            'Seta Parametros - Código Requisição - Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_requisicao_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoRequisicaoItem : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_compras_cotacao_fornecedor_item_reprovar_compra", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: ARQUIVOS :::"
    Public Sub InsertArquivo(ByVal lCodigoCotacao As Long,
                             ByVal sDescricao As String,
                             ByVal sCaminhoArquivo As String,
                             ByVal iCodigoFornecedor As Integer)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0
        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = lCodigoCotacao : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoFornecedor : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDescricao : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "arquivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCaminhoArquivo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_compras_cotacao_fornecedor_arquivo", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ExcluirArquivo(ByVal lCodigoCotacao As Long)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer

        Try

            'Exclui Registro
            For Each oRow As GridEXRow In gSelecaoRow

                i = 0

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_cotacao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoCotacao : i += 1 : ReDim Preserve oSqlParameter(i)

                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1 : ReDim Preserve oSqlParameter(i)

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_compras_cotacao_fornecedor_arquivo", oSqlParameter)

                'Deleta o arquivo do servidor
                If File.Exists(oRow.Cells("arquivo").Value) Then
                    File.Delete(oRow.Cells("arquivo").Value)
                End If

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridArquivo(ByVal oGrid As GridEX,
                               ByVal lCodigoCotacao As Long,
                               ByVal iCodigoFornecedor As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cotacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoCotacao : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFornecedor : i += 1 : ReDim Preserve oSqlParameter(i)


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_cotacao_fornecedor_arquivo", oSqlParameter)

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
#End Region

#End Region

End Class